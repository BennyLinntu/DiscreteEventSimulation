using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace R10546039YDLINAss02
{
    public partial class MainForm : Form
    {
        //Data
        public double[] arriveTimes, serviceTimes, delayTimes, completeTimes;
        private int numofjobs;
        public int Numberofjobs { get => numofjobs; set => numofjobs = value; }
        List<double> Times = new List<double>();
        List<double> Queues = new List<double>();
        List<int> JobCountsInNode = new List<int>(); // Count the number of Node
        List<int> JobCountsInQueue = new List<int>(); // Count the number of Queue
        List<int> JobCountsInSerive = new List<int>(); // Count the number of Serive
        List<double> Completed = new List<double>();
        List<double> Repeats = new List<double>();
        //Open File and show it to our table
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(dlgOpen.FileName);
                Numberofjobs = int.Parse(sr.ReadLine());
                double arriveTime, serviceTime, delayTime, completeTime;
                // allocate memory for array
                arriveTimes = new double[Numberofjobs + 1]; // here we show the different data in the table
                serviceTimes = new double[Numberofjobs + 1];
                completeTimes = new double[Numberofjobs + 1];
                delayTimes = new double[Numberofjobs + 1];
                arriveTimes[0] = 0;
                completeTimes[0] = 0;
                dgvInput.Rows.Clear();
                for (int i = 1; i <= Numberofjobs; i++)
                {
                    char[] seps = { ' ', ',' };
                    string[] items = sr.ReadLine().Split(seps, StringSplitOptions.RemoveEmptyEntries);
                    arriveTime = Math.Round(double.Parse(items[0]), 2);
                    serviceTime = Math.Round(double.Parse(items[1]), 2);
                    arriveTimes[i] = arriveTime;
                    serviceTimes[i] = serviceTime;
                    if (arriveTimes[i] < completeTimes[i - 1]) // to get the delay data
                    {
                        delayTime = Math.Round(completeTimes[i - 1] - arriveTimes[i], 2);
                    }
                    else
                    {
                        delayTime = 0;
                    }
                    completeTime = arriveTime + serviceTime + delayTime;
                    delayTimes[i] = delayTime;
                    completeTimes[i] = completeTime;
                    dgvInput.Rows.Add();
                    dgvInput.Rows[i - 1].Cells[0].Value = i;
                    dgvInput.Rows[i - 1].Cells[1].Value = arriveTimes[i];
                    dgvInput.Rows[i - 1].Cells[2].Value = serviceTimes[i];
                    dgvInput.Rows[i - 1].Cells[3].Value = delayTimes[i];
                    dgvInput.Rows[i - 1].Cells[4].Value = completeTimes[i];
                }
                sr.Close();
                btnCreateJobCountLine.Enabled = true;
                cbJobinNode.Enabled = true;
                cbJobinQueue.Enabled = true;
                cbJobinService.Enabled = true;
                tbServiceTimeFactor.Enabled = true;
            }

        }
        //Save File
        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(dlgSave.FileName);
                sw.WriteLine(Numberofjobs);
                for (int i = 1; i <= Numberofjobs; i++)
                {
                    sw.WriteLine(arriveTimes[i] + " " + serviceTimes[i]);
                }
                sw.Close();
            }
        }



        //Show the JobCount Line
        private void btnCreateJobCountLine_Click(object sender, EventArgs e)
        {
            // show data
            dgvInput.Rows.Clear();
            for (int i = 1; i <= Numberofjobs; i++)
            {
                if (arriveTimes[i] < completeTimes[i - 1]) // to get the delay data
                {
                    delayTimes[i] = Math.Round(completeTimes[i - 1] - arriveTimes[i], 2);
                }
                else
                {
                    delayTimes[i] = 0;
                }
                completeTimes[i] = arriveTimes[i] + serviceTimes[i] * double.Parse(tbServiceTimeFactor.Text) + delayTimes[i];
                dgvInput.Rows.Add();
                dgvInput.Rows[i - 1].Cells[0].Value = i;
                dgvInput.Rows[i - 1].Cells[1].Value = arriveTimes[i];
                dgvInput.Rows[i - 1].Cells[2].Value = serviceTimes[i] * double.Parse(tbServiceTimeFactor.Text);
                dgvInput.Rows[i - 1].Cells[3].Value = delayTimes[i];
                dgvInput.Rows[i - 1].Cells[4].Value = completeTimes[i];
            }
            Times.AddRange(arriveTimes);
            Times.AddRange(completeTimes);
            Times.Sort();
            Times.RemoveAt(0);
            // count the job in Node, Queue, and serive
            JobCountsInNode.Add(0);
            Completed.AddRange(completeTimes);
            for (int i = 1; i <= Numberofjobs; i++)
            {
                if (arriveTimes[i] < Completed[1])
                {
                    Queues.Add(arriveTimes[i]);
                    JobCountsInNode.Add(Queues.Count);
                }
                else
                {
                    if(Queues.Count != 0)
                    {
                        Queues.RemoveAt(0);
                    }
                    Completed.RemoveAt(1);
                    JobCountsInNode.Add(Queues.Count);
                    i--;
                }
                if (i == Numberofjobs)
                {
                    for (int m = 1; m <= Completed.Count; m++)
                    {
                        Queues.RemoveAt(0);
                        Completed.RemoveAt(1);
                        JobCountsInNode.Add(Queues.Count);
                    }
                }
            }
            JobCountsInNode.Add(0);
            JobCountsInQueue.AddRange(JobCountsInNode);
            JobCountsInSerive.AddRange(JobCountsInNode);
            for (int i = 0; i < JobCountsInNode.Count; i++)
            {
                if (JobCountsInNode[i] == 0)
                {
                    JobCountsInQueue[i] = 0;
                    JobCountsInSerive[i] = 0;
                }
                else
                {
                    JobCountsInQueue[i] -= 1;
                    JobCountsInSerive[i] = 1;
                }
            }
            //draw the picture
            chtJobCount.Series[0].Points.Clear();
            chtJobCount.Series[1].Points.Clear();
            chtJobCount.Series[2].Points.Clear();
            for (int i = 0; i < Times.Count; i++)
            {
                if (cbJobinNode.Checked == true)
                {
                    chtJobCount.Series[0].Points.AddXY(Times.ToArray()[i], JobCountsInNode.ToArray()[i]);
                }
                if (cbJobinQueue.Checked == true)
                {
                    chtJobCount.Series[1].Points.AddXY(Times.ToArray()[i], JobCountsInQueue.ToArray()[i]);
                }
                if (cbJobinService.Checked == true)
                {
                    chtJobCount.Series[2].Points.AddXY(Times.ToArray()[i], JobCountsInSerive.ToArray()[i]);
                }
            }
            // count the data of average
            double AverageInterarrivalTime = arriveTimes[Numberofjobs] / Numberofjobs;
            double AverageServiceTime = serviceTimes.Sum()/ Numberofjobs;
            double AverageDelayTime = delayTimes.Sum() / Numberofjobs;
            double AverageWaitTime = AverageDelayTime + AverageServiceTime;
            double TimeaveragedJobsinNode = (Numberofjobs / completeTimes[Numberofjobs] * AverageWaitTime);
            double TimeaveragedJobsinQueue = (Numberofjobs / completeTimes[Numberofjobs]) * AverageDelayTime;
            double TimeaveragedJobsinService = (Numberofjobs / completeTimes[Numberofjobs]) * AverageServiceTime;
            labelAIT.Text = $"Average Interarrival Time: {AverageInterarrivalTime.ToString("f2")}, Arrival Rate: {(1 / AverageInterarrivalTime).ToString("f4")}";
            labelAST.Text = $"Average Service Time: {AverageServiceTime.ToString("f2")}, Service Rate: {(1 / AverageServiceTime).ToString("f4")}";
            labelADT.Text = $"Average Delay Time: {AverageDelayTime.ToString("f2")}";
            labelAWT.Text = $"Average Wait Time: {AverageWaitTime.ToString("f2")}";
            labelTAJN.Text = $"Time_averaged Jobs in Node: {TimeaveragedJobsinNode.ToString("f2")}";
            labelTAJQ.Text = $"Time_averaged Jobs in Queue: {TimeaveragedJobsinQueue.ToString("f2")}";
            labelTAJS.Text = $"Time_Averaged Jobs in Service: {TimeaveragedJobsinService.ToString("f2")}";

            // clear all data after click the butten
            Times.Clear();
            JobCountsInNode.Clear();
            JobCountsInQueue.Clear();
            JobCountsInSerive.Clear();
            Completed.Clear();
            Queues.Clear();
        }


        // Create the Data
        private void btnCreateData_Click(object sender, EventArgs e)
        {
            rtbInput.Clear();
            Random r = new Random();
            double AverageInterarrivalTime = Convert.ToDouble(tbAverageInterarrivalTime.Text);
            double InterarrivalTimeDeviation = Convert.ToDouble(tbDeviationInterarrival.Text);
            double AverageServiceTime = Convert.ToDouble(tbAverageServiceTime.Text);
            double ServiceTimeDeviation = Convert.ToDouble(tbDeviationService.Text);
            Numberofjobs = Convert.ToInt32(tbNumberOfJob.Text);
            arriveTimes = new double[Numberofjobs + 1];
            serviceTimes = new double[Numberofjobs + 1];
            delayTimes = new double[Numberofjobs + 1];
            completeTimes = new double[Numberofjobs + 1];
            arriveTimes[0] = 0;
            completeTimes[0] = 0;
            for (int i = 1; i <= Numberofjobs; i++)
            {
                double RandomNumber = Convert.ToDouble(Math.Round(AverageInterarrivalTime + InterarrivalTimeDeviation * r.NextDouble(), 2));
                if (i == 1)
                {
                    arriveTimes[i] = RandomNumber;
                }
                else
                {
                    arriveTimes[i] = RandomNumber + arriveTimes[i - 1];
                }
                serviceTimes[i] = Convert.ToDouble(Math.Round(AverageServiceTime + ServiceTimeDeviation * r.NextDouble(), 2));
                if (arriveTimes[i] < completeTimes[i - 1]) // to get the delay data
                {
                    delayTimes[i] = Math.Round(completeTimes[i - 1] - arriveTimes[i], 2);
                }
                else
                {
                    delayTimes[i] = 0;
                }
                completeTimes[i] = arriveTimes[i] + serviceTimes[i] + delayTimes[i];
                string showcount = $"Job{i}, ArriveTime= {arriveTimes[i]}, ServiceTime= {serviceTimes[i]}, DelayTime= {delayTimes[i]}, CompleteTime= {completeTimes[i]}\n";
                rtbInput.AppendText(showcount);
            }
            btnCreateJobCountLine.Enabled = true;
            btnSave.Enabled = true;
            btnSaveFile.Enabled = true;
            cbJobinNode.Enabled = true;
            cbJobinQueue.Enabled = true;
            cbJobinService.Enabled = true;
        }



        //checked boxs


        private void cbJobinNode_CheckedChanged(object sender, EventArgs e)
        {
            if (cbJobinNode.Checked == true)
            {
                chtJobCount.Series[0].Enabled = true;
            }
            else
            {
                chtJobCount.Series[0].Enabled = false;
            }
        }

        private void btnSimulation_Click(object sender, EventArgs e)
        {
            chtQueueUtilizationRate.Series[0].Points.Clear();
            double IntervalofPoints;
            List<double> TimeaveragedJobsinQueue = new List<double>();
            List<double> TimeaveragedJobsinService = new List<double>();
            double LowerFactor = Convert.ToDouble(tbSTFFTL.Text);
            double UpperFactor = Convert.ToDouble(tbSTFFTU.Text);
            int TestNumber = Convert.ToInt32(tbNOT.Text);
            // Count the Interval value of Points
            IntervalofPoints = Math.Round((UpperFactor - LowerFactor) / (TestNumber - 1), 2);
            for (int j = 0; j < TestNumber; j++)
            {
                for (int i = 1; i <= Numberofjobs; i++)
                {
                    if (arriveTimes[i] < completeTimes[i - 1]) // to get the delay data
                    {
                        delayTimes[i] = Math.Round(completeTimes[i - 1] - arriveTimes[i], 2);
                    }
                    else
                    {
                        delayTimes[i] = 0;
                    }
                    completeTimes[i] = arriveTimes[i] + serviceTimes[i] * LowerFactor + delayTimes[i];
                }
                TimeaveragedJobsinQueue.Add(Math.Round((Numberofjobs / completeTimes[Numberofjobs]) * (delayTimes.Sum() / Numberofjobs), 2));
                TimeaveragedJobsinService.Add(Math.Round((Numberofjobs / completeTimes[Numberofjobs]) * (serviceTimes.Sum() * LowerFactor / Numberofjobs), 2));
                chtQueueUtilizationRate.Series[0].Points.AddXY(TimeaveragedJobsinService.ToArray()[j], TimeaveragedJobsinQueue.ToArray()[j]);
                LowerFactor = LowerFactor + IntervalofPoints;
            }
        }

        private void cbJobinQueue_CheckedChanged(object sender, EventArgs e)
        {
            if (cbJobinQueue.Checked == true)
            {
                chtJobCount.Series[1].Enabled = true;
            }
            else
            {
                chtJobCount.Series[1].Enabled = false;
            }
        }

        private void cbJobinService_CheckedChanged(object sender, EventArgs e)
        {
            if (cbJobinService.Checked == true)
            {
                chtJobCount.Series[2].Enabled = true;
            }
            else
            {
                chtJobCount.Series[2].Enabled = false;
            }
        }



        public MainForm()
        {
            InitializeComponent();
        }

    }
}
