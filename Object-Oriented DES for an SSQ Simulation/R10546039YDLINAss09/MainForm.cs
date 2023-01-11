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

namespace R10546039YDLINAss09
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        // data
        TimedQueue q = null;
        DESModel model;
        private void btnCreate_Click(object sender, EventArgs e)
        {
            chtShow.Series.Clear();
            chtPie.Series.Clear();
            model = DESModel.Create();
            ppgShow.SelectedObject = model;

            // Create Gantt chart pie chart and stepline chart

            Server server = model.GetAllServer()[0];
            
            TimedQueue queue = model.GetAllQueue()[0];
            server.Gantt.ChartArea = "ChartArea1";
            chtShow.Series.Add(server.Gantt);
            chtPie.Series.Add(server.Pie);
            queue.SeriesClient.ChartArea = "ChartArea2";
            queue.SeriesClient.Color = Color.Red;
            queue.SeriesClient.BorderWidth = 2;
            chtShow.Series.Add(queue.SeriesClient);
            btnReset.Enabled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            model.ResetSimulation();
            btnRunOneEvent.Enabled = true;
            btnRuntoEnd.Enabled = true;
            rbClient.Enabled = true;
            rbQueue.Enabled = true;
            rbServer.Enabled = true;
        }

        private void btnRunOneEvent_Click(object sender, EventArgs e)
        {
            rtbEventList.Clear();
            rtbEventList.AppendText($"{model.Engine.SimulateClock :0:00}->DES.ClientArrivalEvent\n");
            model.RunOneEvent();
            chtPie.Invalidate();
        }

        private void btnRuntoEnd_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < model.TheClientGenerator.NumberofClient; i++)
            {
                model.RunOneEvent();
            }
        }

        private void rbClient_CheckedChanged(object sender, EventArgs e)
        {
            ppgShow.SelectedObject = model;
        }

        private void rbServer_CheckedChanged(object sender, EventArgs e)
        {
            ppgShow.SelectedObject = model.GetAllServer();
        }

        private void rbQueue_CheckedChanged(object sender, EventArgs e)
        {
            ppgShow.SelectedObject = model.GetAllQueue()[0];
        }
    }
}
