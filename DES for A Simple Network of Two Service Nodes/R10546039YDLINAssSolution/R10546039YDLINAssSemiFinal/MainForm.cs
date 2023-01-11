using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MMQLibrary;

namespace R10546039YDLINAssSemiFinal
{
    public partial class MainForm : Form
    {
        List<Server> servers = new List<Server>();
        DESimulationModel theModel;
        ExponentialDisCRVGenerator exponential = new ExponentialDisCRVGenerator();
        UniformDisCRVGenerator uniform = new UniformDisCRVGenerator();
        int NumberofServices = 0;

        public MainForm()
        {
            InitializeComponent();
            ppgJobInterarrival.SelectedObject = exponential;
            ppgJobInterarrival.SelectedObject = exponential;
            NumberofServices = int.Parse(tbNumberofServers.Text);
            tbNumberofServers.Refresh();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            // let we clear the data
            chtShow.Series.Clear();
            rtbShow.Clear();
            chtPie.Series.Clear();
            chtPie.ChartAreas.Clear();
            // here we create the model
            theModel = DESimulationModel.CreateAnSSQModel(NumberofServices);
            
            theModel.SetCountSeries(chtShow, 0);
            theModel.SetGanttSeries(chtShow, 1);
            //theModel.SetGanttSeries(chtShow, 2);
            theModel.Reset();
            // refresh, and recalculate axes scale
            
            chtShow.ChartAreas[0].RecalculateAxesScale();
            chtShow.ChartAreas[1].RecalculateAxesScale();
            
            // here we set the Series type
            for (int i = 0; i < NumberofServices; i++)
            {
                chtPie.ChartAreas.Add($"Pie{i + 1}");
                chtPie.Series.Add($"Service{(1 + i)}");
                chtPie.Series[i].ChartArea = $"Pie{i + 1}";
                chtPie.Series[i].ChartType = SeriesChartType.Pie;
            }
            // here we reset the uniform and exponential
            ppgJobInterarrival.Refresh();
            ppgServer.Refresh();
            ppgServer.SelectedObject = theModel.Nodes[0].Servers[0].ServiceTimeGenerator;
            rbDifferentServiceRates.Enabled = true;
        }

        private void btnOneEvent_Click(object sender, EventArgs e)
        {
            theModel.RunNextEvent();
            if (!theModel.Nodes[0].Servers[0].IsFree)
            {
                chtShow.ChartAreas[1].AxisY.ScaleView = chtShow.ChartAreas[0].AxisX.ScaleView;
            }
            for (int j = 0; j < NumberofServices; j++)
            {
                for (int i = 0; i < NumberofServices; i++)
                {
                    chtPie.Series[i].Points.Clear();
                    chtPie.Series[i].Points.AddXY("Free", theModel.Nodes[0].Servers[i].CumlatedFreeTime);
                    if (theModel.Nodes[0].Servers[i].CumlatedBusyTime != 0)
                    {
                        chtPie.Series[i].Points.AddXY("Busy", theModel.Nodes[0].Servers[i].CumlatedBusyTime);
                    }
                }

            }
           chtShow.ChartAreas[1].AxisY.Maximum = double.NaN;
           chtShow.ChartAreas[0].AxisX.Maximum = double.NaN;
        }

        private void btnRunToEnd_Click(object sender, EventArgs e)
        {
            while(theModel.RunNextEvent());
            if (!theModel.Nodes[0].Servers[0].IsFree)
            {
                chtShow.ChartAreas[1].AxisY.ScaleView = chtShow.ChartAreas[0].AxisX.ScaleView;
            }
            for (int j = 0; j < NumberofServices; j++)
            {
                for (int i = 0; i < NumberofServices; i++)
                {
                    chtPie.Series[i].Points.Clear();
                    chtPie.Series[i].Points.AddXY("Free", theModel.Nodes[0].Servers[i].CumlatedFreeTime);
                    if (theModel.Nodes[0].Servers[i].CumlatedBusyTime != 0)
                    {
                        chtPie.Series[i].Points.AddXY("Busy", theModel.Nodes[0].Servers[i].CumlatedBusyTime);
                    }
                }

            }
            rtbShow.AppendText($"*** Multiple Server-Single Queue Ending Time: ***");

        }

        private void cbJobInterarrivalDistribution_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbJobInterarrivalDistribution.SelectedIndex == 0)
            {
                ppgJobInterarrival.SelectedObject = exponential;
            }
            else if (cbJobInterarrivalDistribution.SelectedIndex == 1)
            {
                ppgJobInterarrival.SelectedObject = uniform;
            }
            
        }

        private void cbSharedServiceTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbSharedServiceTime.SelectedIndex == 0)
            {
                ppgJobInterarrival.SelectedObject = exponential;
            }
            else if(cbSharedServiceTime.SelectedIndex == 1)
            {
                ppgJobInterarrival.SelectedObject = uniform;
            }
        }

        private void rbDifferentServiceRates_CheckedChanged(object sender, EventArgs e)
        {
            rbSameServiceRate.Checked = false;
            cbServices.Enabled = true;
            cbServices.Items.Clear();
            for (int i = 0; i < NumberofServices; i++)
            {
                cbServices.Items.Add($"Service{1 + i}");
            } 
        }

        private void cbServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbServices.SelectedIndex == 0)
            {
                ppgServer.SelectedObject = theModel.Nodes[0].Servers[0].ServiceTimeGenerator;
            }
            else if (cbServices.SelectedIndex == 1)
            {
                ppgServer.SelectedObject = theModel.Nodes[0].Servers[1].ServiceTimeGenerator;
            }
            else
            {
                ppgServer.SelectedObject = theModel.Nodes[0].Servers[2].ServiceTimeGenerator;
            }
        }
    }
}
