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

namespace R10546039YDLINAss01
{
    public partial class MainForm : Form
    {
        //Data
        public double[] arriveTimes, serviceTimes, completeTimes;
        private int numofjobs;
        public int Numberofjobs { get => numofjobs; set => numofjobs = value; }
        List<double> Times = new List<double>();
        List<double> Queues = new List<double>();
        List<int> JobCounts = new List<int>();
        List<double> Completed = new List<double>();
        List<double> Repeats = new List<double>();
        //Open File and show it to our table
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(dlgOpen.FileName);
                string str = sr.ReadLine();
                Numberofjobs = Convert.ToInt32(str);
                string[] items;
                double arriveTime, serviceTime, completeTime;
                // allocate memory for array
                arriveTimes = new double[Numberofjobs + 1]; // here we show the different data in the table
                serviceTimes = new double[Numberofjobs + 1];
                completeTimes = new double[Numberofjobs + 1];
                arriveTimes[0] = 0;
                completeTimes[0] = 0;
                for (int i = 1; i <= Numberofjobs; i++)
                {
                    str = sr.ReadLine();
                    items = str.Split(' ');
                    arriveTime = Convert.ToDouble(items[0]);
                    serviceTime = Convert.ToDouble(items[1]);
                    arriveTimes[i] = arriveTime;
                    serviceTimes[i] = serviceTime;
                    completeTime = arriveTime + serviceTime;
                    completeTimes[i] = completeTime;
                    string showcount = $"Job{i}, ArriveTime= {arriveTime}, ServiceTime= {serviceTime}, CompleteTime= {completeTime}\n";
                    //rtbInput.Clear();
                    rtbInput.AppendText(showcount);
                }
                sr.Close();
                btnCreateJobCountLine.Enabled = true;
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
            Times.AddRange(arriveTimes);
            Times.AddRange(completeTimes);
            Times.Sort();
            Times.RemoveAt(0);
            JobCounts.Add(0);
            Completed.AddRange(completeTimes);
            for (int i = 1; i <= Numberofjobs; i++)
            {
                if (arriveTimes[i] < Completed[1])
                {
                    Queues.Add(arriveTimes[i]);
                    JobCounts.Add(Queues.Count);
                }
                else
                {
                    Queues.RemoveAt(0);
                    Completed.RemoveAt(1);
                    JobCounts.Add(Queues.Count);
                    i--;
                }
                if (i == Numberofjobs)
                {
                    for (int m = 1; m <= Completed.Count; m++)
                    {
                        Queues.RemoveAt(0);
                        Completed.RemoveAt(1);
                        JobCounts.Add(Queues.Count);
                    }
                }
            }
            JobCounts.Add(0);
            chtJobCount.Series[0].Points.Clear();
            for (int i = 0; i < Times.Count; i++)
            {
                chtJobCount.Series[0].Points.AddXY(Times.ToArray()[i], JobCounts.ToArray()[i]);
            }
            // clear all data after click the butten
            Times.Clear();
            JobCounts.Clear();
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
                completeTimes[i] = arriveTimes[i] + serviceTimes[i];
                string showcount = $"Job{i}, ArriveTime= {arriveTimes[i]}, ServiceTime= {serviceTimes[i]}, CompleteTime= {completeTimes[i]}\n";
                rtbInput.AppendText(showcount);
            }
            btnCreateJobCountLine.Enabled = true;
            btnSave.Enabled = true;
            btnSaveFile.Enabled = true;
        }
        public MainForm()
        {
            InitializeComponent();
        }

    }
}
