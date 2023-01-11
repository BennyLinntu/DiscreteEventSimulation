using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SSQLibrary;

namespace _2
{
    public partial class MainForm : Form
    {
        // data fileds
        //TimedQueue myQueue;
        //Server myServer;
        //ServiceNode myNode;
        //ClientGenerator clientGenerator;
        DESimulationModel theModel;
        //double currentTime = 0;
        
        public MainForm()
        {
            InitializeComponent();
        }
        // here we create the DES model
        private void btnCreate_Click(object sender, EventArgs e)
        {
            theModel = DESimulationModel.CreateAnSSQModel();
            theModel.SetCountSeries(chtShow, 0);
            theModel.SetGanttSeries(chtShow, 1);
            ppgShow.SelectedObject = theModel;
            ppgShow.Refresh();  // here we refresh the property grid
            // here we enabled the butten
            btnReset.Enabled = true;
            rbQueue.Enabled = true;
            rbServer.Enabled = true;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            theModel.Reset();
            rtbEvent.Text = theModel.GetFutrueEventInfo();
            labelShow.Text = $"Clock:{theModel.ClockTime:0.00}";
            // refresh, and recalculate axes scale
            ppgShow.Refresh();
            chtShow.ChartAreas[0].RecalculateAxesScale();
            chtShow.ChartAreas[1].RecalculateAxesScale();
            chtPie.Series[0].Points.Clear(); // clear the series, let it be reset

            // here we enabled the butten
            rbClientGenerator.Enabled = true;
            btnRunOne.Enabled = true;
            btnRunToEnd.Enabled = true;
            

        }

        private void ppgQueue_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            ppgShow.Refresh();
        }

        private void btnRunOne_Click(object sender, EventArgs e)
        {
            theModel.RunNextEvent();
            rtbEvent.Text = theModel.GetFutrueEventInfo();
            if(!theModel.Nodes[0].Servers[0].IsFree)
            {
                chtShow.ChartAreas[1].AxisY.ScaleView = chtShow.ChartAreas[0].AxisX.ScaleView;
            }
            labelShow.Text = $"Clock: {theModel.ClockTime:0.00}";
            ppgShow.Refresh();
            chtPie.Series[0].Points.Clear();
            chtPie.Series[0].Points.AddXY("Free", theModel.Nodes[0].Servers[0].CumlatedFreeTime);
            if(theModel.Nodes[0].Servers[0].CumlatedBusyTime != 0)
            {
                chtPie.Series[0].Points.AddXY("Busy", theModel.Nodes[0].Servers[0].CumlatedBusyTime);
            }
            chtShow.ChartAreas[1].AxisY.Maximum = double.NaN;
            chtShow.ChartAreas[0].AxisX.Maximum = double.NaN;
            rbQueue.Enabled = true;

        }

        private void btnRunToEnd_Click(object sender, EventArgs e)
        {
            while(theModel.RunNextEvent())
            {
                rtbEvent.Text = theModel.GetFutrueEventInfo();
                this.Refresh();
            }
            
        }

        private void rbClientGenerator_Click(object sender, EventArgs e)
        {
            if(rbClientGenerator.Checked)
            {
                ppgShow.SelectedObject = theModel.Generators;
            }
            else if (rbQueue.Checked)
            {
                ppgShow.SelectedObject = theModel.Nodes[0].Queues[0];
            }
            else if(rbServer.Checked)
            {
                ppgShow.SelectedObject = theModel.Nodes[0].Servers[0];
            }
        }
    }
}
