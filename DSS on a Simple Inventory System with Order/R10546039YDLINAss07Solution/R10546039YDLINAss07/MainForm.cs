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

namespace R10546039YDLINAss07
{
    public partial class MainForm : Form
    {
        Random r = new Random();
        Series s1, s2, s3;
        public MainForm()
        {
            InitializeComponent();
           
        }
        //Data

        // here we Simulate the Stochastic
        private void btnFeedbackSimulate_Click(object sender, EventArgs e)
        {
            // clear all data
            rtbShow.Clear();
            chtJobCount.Series.Clear();    
            ExponentialDisCRVGenerator eg = new ExponentialDisCRVGenerator();
            UniformDisCRVGenerator ug = new UniformDisCRVGenerator();
            if(tscbSeed.Text == "New Random")
            {
                eg.getSeed(-1);
                ug.getSeed(-1);
            }
            else
            {
                eg.getSeed(int.Parse(tscbSeed.Text));
                ug.getSeed(int.Parse(tscbSeed.Text));
            }
            // data
            int NumberofJobs = int.Parse(tbNumberofjobsRandom.Text);
            double FeedbackProbability = double.Parse(tbFeedbackProbability.Text);
            double delta;
            int Feed = 0;
            int Count = 1;
            int l = 0;
            int q = 0;
            int x = 0;
            double ta = eg.Exponential();
            double tc = double.MaxValue;
            double ma = ta;
            double ms = 0;
            double t = 0;
            double ml = 0;
            double mq = 0;
            double mx = 0;
            List<double> Service = new List<double>();
            List<double> Arrival = new List<double>();
            List<double> Delay = new List<double>();
            List<double> Completion = new List<double>();
            Delay.Add(0);
            Arrival.Add(ta);
            // here we set the series
            Series JobNode = new Series("Job in Node l(t)");
            Series JobQueue = new Series("Job in Queue q(t)");
            Series JobService = new Series("job in Service x(t)");
            JobNode.Color = Color.Red;
            JobNode.ChartType = SeriesChartType.StepLine;
            JobNode.BorderWidth = 2;
            JobQueue.Color = Color.Green;
            JobQueue.ChartType = SeriesChartType.StepLine;
            JobQueue.LabelBorderWidth = 2;
            JobService.Color = Color.Blue;
            JobService.ChartType = SeriesChartType.StepLine;
            JobService.BorderWidth = 2;
            chtJobCount.ChartAreas[0].AxisX.Title = "Time";
            chtJobCount.ChartAreas[0].AxisY.Title = "Job Count";
            // here we run the algorithm and draw the chart
            JobNode.Points.AddXY(0, l);
            JobQueue.Points.AddXY(0, q);
            JobService.Points.AddXY(0, x);
            while(ta != double.MaxValue || tc != double.MaxValue)
            {
                if(ta <= tc)
                {
                    delta = ta - t;
                    ml = ml + l * delta;
                    mx = mx + x * delta;
                    mq = mq + q * delta;
                    l++;
                    JobNode.Points.AddXY(ta, l);
                    if(x > 0)
                    {
                        q += 1;
                        JobQueue.Points.AddXY(ta, q);
                    }
                    else
                    {
                        delta = ug.Uniform();
                        ms = ms + delta;
                        tc = ta + delta;
                        Service.Add(delta);
                        Completion.Add(tc);
                        x++;
                        JobService.Points.AddXY(ta, x);
                    }
                    t = ta;
                    if(Count < NumberofJobs)
                    {
                        if(GetFeedback(FeedbackProbability) == 1)
                        {
                            ta = tc;
                            Feed++;
                        }
                        else
                        {
                            delta = eg.Exponential();
                            ta = ta + delta;
                        }
                        ma = ma + delta;
                        Arrival.Add(ta);
                        Count++;
                    }
                    else
                    {
                        ta = double.MaxValue;
                    }
                }
                else
                {
                    delta = tc - t;
                    ml = ml + l * delta;
                    mx = mx + x * delta;
                    mq = mq + q * delta;
                    l--;
                    JobNode.Points.AddXY(tc, l);
                    x--;
                    JobService.Points.AddXY(tc, x);
                    t = tc;
                    if(q > 0)
                    {
                        q--;
                        JobQueue.Points.AddXY(tc, q);
                        x++;
                        JobService.Points.AddXY(tc, x);
                        delta = ug.Uniform();
                        Service.Add(delta);
                        ms = ms + delta;
                        tc = tc + delta;
                        Completion.Add(tc);
                    }
                    else
                    {
                        tc = double.MaxValue;
                    }
                }
            }
            rtbShow.AppendText($"Average Dellay Time: {(ms / NumberofJobs).ToString("0.00")}\n" + $"Average Wait Time: {((ma / NumberofJobs) + (mq / NumberofJobs)).ToString("0.00")}\n" +
                    $"Time-averaged Jobs in Node: {(ml / t).ToString("0.00")}\n" + $"Time-averaged Jobs in Queue: {(mq / t).ToString("0.00")}\n" +
                    $"Time-averaged Jobs in Service: {(mx / t).ToString("0.00")}\n" + $"Feedback ratio: ({Feed}/{NumberofJobs} ){Convert.ToDouble(Feed) / Convert.ToDouble(NumberofJobs)}\n");
            s1 = JobNode;
            s2 = JobQueue;
            s3 = JobService;
            if(cbJobinNode.Checked == true)
            {
                chtJobCount.Series.Add(s1);
            }
            if (cbJobinNode.Checked == true)
            {
                chtJobCount.Series.Add(s2);
            }
            if (cbJobinNode.Checked == true)
            {
                chtJobCount.Series.Add(s3);
            }
            cbJobinNode.Enabled = true;
            cbJobinQueue.Enabled = true;
            cbJobinService.Enabled = true;
        }

        // function
        public int GetFeedback (double b)
        {
            if(r.NextDouble() < b)
            {
                return 1;
            }
            else
            {
                return 0;
            }
                
        }




        //checked boxs
        private void cbJobinNode_CheckedChanged(object sender, EventArgs e)
        {
            if (cbJobinNode.Checked == true)
            {
                chtJobCount.Series.Add(s1);
            }
            else
            {
                chtJobCount.Series.Remove(s1);
            }
        }

        private void cbJobinQueue_CheckedChanged(object sender, EventArgs e)
        {
            if (cbJobinQueue.Checked == true)
            {
                chtJobCount.Series.Add(s2);
            }
            else
            {
                chtJobCount.Series.Remove(s2);
            }
        }

        private void cbJobinService_CheckedChanged(object sender, EventArgs e)
        {
            if (cbJobinService.Checked == true)
            {
                chtJobCount.Series.Add(s3);
            }
            else
            {
                chtJobCount.Series.Remove(s3);
            }
        }
        // here is show the ppg to the mainform
        private void MainForm_Load(object sender, EventArgs e)
        {
            ppgAverage.SelectedObject = new ExponentialDisCRVGenerator();
            ppgDeliveryLag.SelectedObject = new EquilikelyDRVGenerator();
            ppgMachineShop.SelectedObject = new UniformDisCRVGenerator();
        }
        // batch run
        private void btnBatchRun_Click(object sender, EventArgs e)
        {
            cbJobinNode.Enabled = false;
            cbJobinQueue.Enabled = false;
            cbJobinService.Enabled = false;
            // clear all data
            rtbShow.Clear();
            chtJobCount.Series.Clear();
            char[] seps = { ' ', ',' };
            double start, end, interval, c, a;
            int cases, NumberofJobs;
            NumberofJobs = int.Parse(tbNumberofjobsRandom.Text);
            string[] arr = tbBatchrun.Text.Split(seps, StringSplitOptions.RemoveEmptyEntries);
            start = Convert.ToDouble(arr[0]);
            end = Convert.ToDouble(arr[1]);
            cases = Convert.ToInt32(arr[2]);
            interval = Convert.ToDouble(((end - start) / cases).ToString("0.00"));
            // here we set the series
            Series Utilization = new Series("Utilization vs Feedback");
            Series QueueLength = new Series("Queue Length vs Feedback");
            Utilization.Color = Color.Red;
            Utilization.ChartType = SeriesChartType.Line;
            Utilization.MarkerStyle = MarkerStyle.Diamond;
            Utilization.BorderWidth = 2;
            QueueLength.Color = Color.Green;
            QueueLength.ChartType = SeriesChartType.Line;
            QueueLength.MarkerStyle = MarkerStyle.Diamond;
            QueueLength.LabelBorderWidth = 2;
            
            for (int i = 0; i < cases; i++)
            {
                ExponentialDisCRVGenerator eg = new ExponentialDisCRVGenerator();
                UniformDisCRVGenerator ug = new UniformDisCRVGenerator();
                if (tscbSeed.Text == "New Random")
                {
                    eg.getSeed(-1);
                    ug.getSeed(-1);
                }
                else
                {
                    eg.getSeed(int.Parse(tscbSeed.Text));
                    ug.getSeed(int.Parse(tscbSeed.Text));
                }
                // data
                double delta = 0;
                int Count = 1;
                int l = 0;
                int q = 0;
                int x = 0;
                double ta = eg.Exponential();
                double tc = double.MaxValue;
                double ma = ta;
                double ms = 0;
                double t = 0;
                double ml = 0;
                double mq = 0;
                double mx = 0;
                List<double> Service = new List<double>();
                List<double> Arrival = new List<double>();
                List<double> Delay = new List<double>();
                List<double> Completion = new List<double>();
                Delay.Add(0);
                Arrival.Add(ta);
                while (ta != double.MaxValue || tc != double.MaxValue)
                {
                    if (ta <= tc)
                    {
                        delta = ta - t;
                        ml = ml + l * delta;
                        mx = mx + x * delta;
                        mq = mq + q * delta;
                        l++;
                        if (x > 0)
                        {
                            q += 1;
                        }
                        else
                        {
                            delta = ug.Uniform();
                            ms = ms + delta;
                            tc = ta + delta;
                            Service.Add(delta);
                            Completion.Add(tc);
                            x++;
                        }
                        t = ta;
                        if (Count < NumberofJobs)
                        {
                            if (GetFeedback(start) == 1)
                            {
                                ta = tc;
                            }
                            else
                            {
                                delta = eg.Exponential();
                                ta = ta + delta;
                            }
                            ma = ma + delta;
                            Arrival.Add(ta);
                            Count++;
                        }
                        else
                        {
                            ta = double.MaxValue;
                        }
                    }
                    else
                    {
                        delta = tc - t;
                        ml = ml + l * delta;
                        mx = mx + x * delta;
                        mq = mq + q * delta;
                        l--;
                        x--;
                        t = tc;
                        if (q > 0)
                        {
                            q--;
                            x++;
                            delta = ug.Uniform();
                            Service.Add(delta);
                            ms = ms + delta;
                            tc = tc + delta;
                            Completion.Add(tc);
                        }
                        else
                        {
                            tc = double.MaxValue;
                        }
                    }
                }
                a = Convert.ToDouble((mq / t).ToString("0.00"));
                c = Convert.ToDouble((mx / t).ToString("0.00"));
                QueueLength.Points.AddXY(start, a);
                Utilization.Points.AddXY(start, c);
                start += interval;
            }
            s1 = Utilization;
            s2 = QueueLength;
            chtJobCount.Series.Add(s1);
            chtJobCount.Series.Add(s2);
            chtJobCount.Series[0].YAxisType = AxisType.Primary;
            chtJobCount.Series[1].YAxisType = AxisType.Secondary;
            chtJobCount.ChartAreas[0].AxisX.Title = "Feedback Rate";
            chtJobCount.ChartAreas[0].AxisY.Title = "Utilization xbar";
            chtJobCount.ChartAreas[0].AxisY2.Title = "Queue Length qbar";
        }

        private void btnDeliveryLagSimulate_Click(object sender, EventArgs e)
        {
            cbJobinNode.Enabled = false;
            cbJobinQueue.Enabled = false;
            cbJobinService.Enabled = false;
            // here we clear the data
            rtbShow.Clear();
            chtJobCount.Series.Clear();
            EquilikelyDRVGenerator eg = new EquilikelyDRVGenerator();
            if (tscbSeed.Text == "New Random")
            {
                eg.getSeed(-1);
            }
            else
            {
                eg.getSeed(int.Parse(tscbSeed.Text));
            }
            double l, d, o;
            double md = 0;
            double mo = 0;
            double mu = 0;
            double mp = 0;
            double mn = 0;
            int interval = int.Parse(tbIntervals.Text);
            int i = 0;
            double max = eg.Max;
            double min = eg.Min;
            double setupcost = eg.Setupcost;
            double holdcost = eg.Holdingcost;
            double shortagecost = eg.Shortagecost;
            double S = max;
            double s = min;
            double lp = S;
            Series MaxLine = new Series("Maximum Level");
            Series MinLine = new Series("Minimum Level");
            Series Inventory = new Series("Inventory Level");
            MaxLine.Color = Color.Red;
            MaxLine.ChartType = SeriesChartType.Line;
            MaxLine.BorderDashStyle = ChartDashStyle.Dot;
            MaxLine.BorderWidth = 2;
            MinLine.Color = Color.Green;
            MinLine.ChartType = SeriesChartType.Line;
            MinLine.BorderDashStyle = ChartDashStyle.Dot;
            MinLine.LabelBorderWidth = 2;
            Inventory.Color = Color.Blue;
            Inventory.ChartType = SeriesChartType.Line;
            Inventory.MarkerStyle = MarkerStyle.Diamond;
            Inventory.MarkerSize = 8;
            Inventory.BorderWidth = 2;
            chtJobCount.ChartAreas[0].AxisX.Title = "Interval";
            chtJobCount.ChartAreas[0].AxisY.Title = "Inventory Level";

            double delta = eg.getdelta();
            MaxLine.Points.AddXY(0, max);
            MinLine.Points.AddXY(0, min);
            Inventory.Points.AddXY(0, S);
            if (cbLag.Checked == false)
            {
                while(i < interval)
                {
                    d = eg.Equilikely();
                    md = md + d;
                    l = lp - d;
                    Inventory.Points.AddXY(i + 1, l);
                    MaxLine.Points.AddXY(i + 1, max);
                    MinLine.Points.AddXY(i + 1, min);
                    o = 0;
                    if(l < s || i == interval - 1)
                    {
                        o = S - l;
                        mu++;
                        mo = mo + 0;
                        Inventory.Points.AddXY(i + 1, S);
                        MaxLine.Points.AddXY(i + 1, max);
                        MinLine.Points.AddXY(i + 1, min);
                    }
                    if(l < 0)
                    {
                        mp = mp + (lp * lp / (2 * d));
                        mn = mn + ((d - lp) * (d - lp) / (2 * d));
                    }
                    else mp = mp + lp - (d / 2);
                    lp = l + o;
                    i++;
                }
                rtbShow.AppendText($"Average Demand: {(md / interval).ToString("0.0000")} per period\n" + $"Average Order: {(md / interval).ToString("0.0000")} per period\n" +
                    $"Average Order:({mu}/{interval}) {(mu / interval).ToString("0.0000")}per period\n" + $"Time-averaged Holding Level: {(mp / interval).ToString("0.0000")}\n" +
                    $"Time-averaged Shortage Level: {(mn / interval).ToString("0.0000")}\n" + $"Dependent Cost : {(setupcost * (mo / interval) + (holdcost * (mp / interval)) + (shortagecost * (mn / interval)))}\n");
            }
            else
            {
                while(i < interval)
                {
                    d = eg.Equilikely();
                    md = md + d;
                    l = lp - d * delta;
                    Inventory.Points.AddXY(i + 1, l);
                    MaxLine.Points.AddXY(i + 1, max);
                    MinLine.Points.AddXY(i + 1, min);
                    o = 0;
                    if(l < s || i == interval - 1)
                    {
                        o = S - l;
                        mu++;
                        mo = mo + o;
                        Inventory.Points.AddXY(i + 1, l + o - d * (1 - delta));
                        MaxLine.Points.AddXY(i + 1, max);
                        MinLine.Points.AddXY(i + 1, min);
                    }
                    if(l < 0)
                    {
                        mp = mp + Math.Pow(lp, 2) / (2 * d);
                        mn = mn + Math.Pow(d - lp, 2) / (2 * d);
                    }
                    else mp = mp + lp - (d / 2);  
                    lp = l + o - d * (1 - delta);
                    i += 1;
                }
                Inventory.Points.AddXY(interval, S);
                rtbShow.AppendText($"Average Demand: {(md / interval).ToString("0.0000")} per period\n" + $"Average Order: {(mo / interval).ToString("0.0000")} per period\n" +
                    $"Average Order: {(mu / interval).ToString("0.0000")}per period\n" + $"Time-averaged Holding Level: {(mp / interval).ToString("0.0000")}\n" +
                    $"Time-averaged Shortage Level: {(mn / interval).ToString("0.0000")}\n" + $"Dependent Cost : {(setupcost * (mo / interval) + (holdcost * (mp / interval)) + (shortagecost * (mn / interval)))}\n");
            }
            s1 = MaxLine;
            s2 = MinLine;
            s3 = Inventory;
            chtJobCount.Series.Add(s1);
            chtJobCount.Series.Add(s2);
            chtJobCount.Series.Add(s3);
        }
    }
}
