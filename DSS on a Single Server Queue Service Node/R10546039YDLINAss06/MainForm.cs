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
using SSQLibrary;

namespace R10546039YDLINAss06
{
    public partial class MainForm : Form
    {
        //Data
        private void btnSimulateStochasticCase_Click(object sender, EventArgs e)
        {
            chtJobCount.Series[0].Points.Clear();
            chtJobCount.Series[1].Points.Clear();
            chtJobCount.Series[2].Points.Clear();
            // here we input our data, variable
            Random r = new Random();
            ExponentialDisCRVGenerator eg = new ExponentialDisCRVGenerator(double.Parse(tbInterarrivalTime.Text));
            UniformDisCRVGenerator ug = new UniformDisCRVGenerator(double.Parse(tbLowerServiceTime.Text), double.Parse(tbUpperServiceTime.Text));
            if (cbSeed.Text == "New Random")
            {
                eg.getSeed(-1);
                ug.getSeed(-1);
            }
            else
            {
                eg.getSeed(int.Parse(cbSeed.Text));
                ug.getSeed(int.Parse(cbSeed.Text));
            }
            double tc = double.MaxValue;
            double ta = eg.Exponential();
            int Count = 1;
            double ma = ta;
            double ms = 0;
            double tao = 0;
            int l = 0;
            int q = 0;
            int x = 0;
            double ml = 0;
            double mq = 0;
            double mx = 0;
            double deta;
            int NumberofjobsRandom = int.Parse(tbNumberofjobsRandom.Text);
            
            //eg.SetSeed(StoSeed);
            //ug.SetSeed(StoSeed);
            // here we use algorithm to get All data, show chart, and get the statistics
            NodePlot(0, l);
            QueuePlot(0, q);
            ServicePlot(0, x);
            while(ta != double.MaxValue || tc != double.MaxValue)
            {
                if(ta <= tc)
                {
                    deta = ta - tao;
                    ml = ml + l * deta;
                    mx = mx + x * deta;
                    mq = mq + q * deta;
                    l = l + 1;
                    NodePlot(ta, l); 
                    if(x > 0)
                    {
                        q = q + 1;
                        QueuePlot(ta, q);
                    }
                    else
                    {
                        deta = ug.Uniform();
                        ms = ms + deta;
                        tc = ta + deta;
                        x = x + 1;
                        ServicePlot(ta, x);
                    }
                    tao = ta;
                    if(Count < NumberofjobsRandom)
                    {
                        deta = eg.Exponential();
                        ma = ma + deta;
                        ta = ta + deta;
                        Count++;
                    }
                    else
                    {
                        ta = double.MaxValue;
                    }
                }
                else
                {
                    deta = tc - tao;
                    ml = ml + l * deta;
                    mx = mx + x * deta;
                    mq = mq + q * deta;
                    l = l - 1;
                    NodePlot(tc, l);
                    x = x - 1;
                    ServicePlot(tc, x);
                    tao = tc;
                    if (q > 0)
                    {
                        q = q - 1;
                        QueuePlot(tc, q);
                        x = x + 1;
                        ServicePlot(tc, x);
                        deta = ug.Uniform();
                        ms = ms + deta;
                        tc = tc + deta;
                    }
                    else
                    {
                        tc = double.MaxValue;
                    }
                }
            }
            labelAIT.Text = $"Average Interarrival Time: {(ma / NumberofjobsRandom).ToString("f2")}, Arrival Rate: {(NumberofjobsRandom/ma).ToString("f4")}";
            labelAST.Text = $"Average Service Time: {(ms / NumberofjobsRandom).ToString("f2")}, Service Rate: {(NumberofjobsRandom / ms).ToString("f4")}";
            labelADT.Text = $"Average Delay Time: {(mq / NumberofjobsRandom).ToString("f2")}";
            labelAWT.Text = $"Average Wait Time: {(ms / NumberofjobsRandom + mq / NumberofjobsRandom).ToString("f2")}";
            labelTAJN.Text = $"Time_averaged Jobs in Node: {(Math.Round(ml / tao, 2))}";
            labelTAJQ.Text = $"Time_averaged Jobs in Queue: {(mq / tao).ToString("f2")}";
            labelTAJS.Text = $"Time_Averaged Jobs in Service: {(mx / tao).ToString("f2")}";
            // here is show the ppg
            eg.LowerBound = 0;
            eg.UpperBound = 2;
            ppgAverage.SelectedObject = eg;
            ppgLandU.SelectedObject = ug;
            
            // here we show the checkbox
            cbJobinNode.Enabled = true;
            cbJobinQueue.Enabled = true;
            cbJobinService.Enabled = true;
        }
        // function to draw the chart

        public void NodePlot(double a, int b)
        {
            chtJobCount.Series[0].Points.AddXY(a, b);
        }
        public void QueuePlot(double a, int b)
        {
            chtJobCount.Series[1].Points.AddXY(a, b);
        }
        public void ServicePlot(double a, int b)
        {
            chtJobCount.Series[2].Points.AddXY(a, b);
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
        int se = 0;
        Series s;
        private void btngetSteadyState_Click(object sender, EventArgs e)
        {
            s = new Series($"Series{se}");
            s.ChartType = SeriesChartType.Point;
            int Numberoftest = int.Parse(tbNOT.Text);
            double wait = 0;
            int job = 0;
            double lower = double.Parse(tbSTFFTL.Text);
            double upper = double.Parse(tbSTFFTU.Text);
            double gap = (upper - lower) / (Numberoftest - 1);
            for (int i = 0; i < Numberoftest; i++)
            {
                ExponentialDisCRVGenerator eg = new ExponentialDisCRVGenerator(double.Parse(tbInterarrivalTime.Text));
                UniformDisCRVGenerator ug = new UniformDisCRVGenerator(double.Parse(tbLowerServiceTime.Text), double.Parse(tbUpperServiceTime.Text));
                if (cbSeed.Text == "New Random")
                {
                    eg.getSeed(-1);
                    ug.getSeed(-1);
                }
                else
                {
                    eg.getSeed(int.Parse(cbSeed.Text));
                    ug.getSeed(int.Parse(cbSeed.Text));
                }
                double tc = double.MaxValue;
                double ta = eg.Exponential();
                int Count = 1;
                double ma = ta;
                double ms = 0;
                double tao = 0;
                int l = 0;
                int q = 0;
                int x = 0;
                double ml = 0;
                double mq = 0;
                double mx = 0;
                double deta;
                int NumberofjobsRandom = int.Parse(tbNumberofjobsRandom.Text);
                job += Convert.ToInt32(Math.Round(gap, 0));
                while (ta != double.MaxValue || tc != double.MaxValue)
                {
                    
                    if (ta <= tc)
                    {
                        deta = ta - tao;
                        ml = ml + l * deta;
                        mx = mx + x * deta;
                        mq = mq + q * deta;
                        l = l + 1;
                        if (x > 0)
                        {
                            q = q + 1;
                        }
                        else
                        {
                            deta = ug.Uniform();
                            ms = ms + deta;
                            tc = ta + deta;
                            x = x + 1;
                        }
                        tao = ta;
                        if (Count < job)
                        {
                            deta = eg.Exponential();
                            ma = ma + deta;
                            ta = ta + deta;
                            Count++;
                        }
                        else
                        {
                            ta = double.MaxValue;
                        }
                    }
                    else
                    {
                        deta = tc - tao;
                        ml = ml + l * deta;
                        mx = mx + x * deta;
                        mq = mq + q * deta;
                        l = l - 1;
                        x = x - 1;
                        tao = tc;
                        if (q > 0)
                        {
                            q = q - 1;
                            x = x + 1;
                            deta = ug.Uniform();
                            ms = ms + deta;
                            tc = tc + deta;
                        }
                        else
                        {
                            tc = double.MaxValue;
                        }
                    }
                }
                wait = Math.Round(ma / job + mq / job, 2);
                s.Points.AddXY(job, wait);
            }
            chtSteadStateTest.Series.Add(s);
            labelAWTALR.Text = $"Average Wait at the last run: {wait}";
            se++;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            chtSteadStateTest.Series.Clear();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {

        }
    }
}
