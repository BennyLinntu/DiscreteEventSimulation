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
using MSQLibrary;

namespace R10546039YDLINAss010
{
    public partial class MainForm : Form
    {
        List<Server> servers = new List<Server>();
        DESimulationModel theModel;
        ExponentialDisCRVGenerator exponential = new ExponentialDisCRVGenerator();
        UniformDisCRVGenerator uniform = new UniformDisCRVGenerator();
        int NumberofServices = 0;
        ContinuousRandomVariateGenerator crvg;
        bool CountOrTime = true;

        public MainForm()
        {
            InitializeComponent();
            ppgJobInterarrival.SelectedObject = exponential;
            ppgJobInterarrival.SelectedObject = exponential;
            NumberofServices = int.Parse(tbNumberofServers.Text);
            tbNumberofServers.Refresh();
        }

        private void btnSimulate_Click(object sender, EventArgs e)
        {
            chtSIS.Series.Clear();// here we clear the chart
            // data fields
            int minimal = int.Parse(tbMinimal.Text);
            int maximal = int.Parse(tbMaximal.Text);
            double demand = int.Parse(tbDemand.Text);
            int limitofperiod = int.Parse(tbLimitofPeriod.Text);
            // then we will create and show the chart
            chtSIS.ChartAreas[0].AxisX.Maximum = limitofperiod;
            chtSIS.ChartAreas[0].AxisX.Minimum = 0;
            chtSIS.ChartAreas[0].AxisX.Interval = 1;
            // here we new Series and Set them
            Series maxSeries = new Series("Maximum Level");
            Series minSeries = new Series("Minimum Level");
            Series inventorySeries = new Series("Inventory Level");
            maxSeries.ChartType = SeriesChartType.Line;
            maxSeries.Color = Color.Green;
            maxSeries.Points.AddXY(0, maximal);
            maxSeries.Points.AddXY(limitofperiod, maximal);
            minSeries.ChartType = SeriesChartType.Line;
            minSeries.Color = Color.Red;
            minSeries.Points.AddXY(0, minimal);
            minSeries.Points.AddXY(limitofperiod, minimal);
            inventorySeries.ChartType = SeriesChartType.StepLine;
            inventorySeries.Color = Color.Blue;
            inventorySeries.Points.AddXY(0, maximal);// at beginning, it should be max
            exponential.Average = 1 / demand;
            int tp = 1;
            int order = 0;
            int inventory= maximal;
            double mp = 0;
            double mn = 0;
            double averagedemand = 0;
            double avergeorder = 0;
            double orderTime = 0;
            double lastTime = 0;
            double td = exponential.NextDouble();
            double to = double.PositiveInfinity;
            
            while(tp <= limitofperiod)
            {

                if (td > limitofperiod) 
                {
                    if (tp != limitofperiod)
                    {
                        throw new Exception(" bad");
                    }
                    if (inventory > 0)
                    {
                        mp += (tp - lastTime) * inventory;
                    }
                    else
                    {
                        mn += (tp - lastTime) * inventory;
                    }
                    if (inventory != maximal)
                    {
                        orderTime++;
                        avergeorder += maximal - inventory;
                    }
                    inventorySeries.Points.AddXY(limitofperiod, maximal);
                }

                if(td < tp && td < to)
                {
                    if(inventory > 0)
                    {
                        mp += (td - lastTime) * inventory;
                    }
                    else
                    {
                        mn += (td - lastTime) * inventory;
                    }
                    inventory--;
                    inventorySeries.Points.AddXY(td, inventory);
                    lastTime = td;
                    td += exponential.NextDouble();
                    averagedemand++;
                }
                else if(to <= td && to < tp)
                {
                    if(inventory > 0)
                    {
                        mp += (to - lastTime) * inventory;

                    }
                    else
                    {
                        mn += (to - lastTime) * inventory;
                    }
                    inventory += order;
                    inventorySeries.Points.AddXY(to, inventory);
                    lastTime = to;
                    order = 0;
                    to = double.PositiveInfinity;
                }
                else
                {
                    if(inventory > 0)
                    {
                        mp += (tp - lastTime) * inventory;
                    }
                    else
                    {
                        mn += (tp - lastTime) * inventory;
                    }
                    if(inventory < minimal)
                    {
                        to = tp + exponential.NextDouble();
                        order = maximal - inventory;
                        avergeorder += order;
                        orderTime++;
                    }
                    inventorySeries.Points.AddXY(tp, inventory);
                    lastTime = tp;
                    tp++;
                }
               
            }
            averagedemand /= limitofperiod;
            avergeorder /= limitofperiod;
            orderTime /= limitofperiod;
            chtSIS.Series.Add(maxSeries);
            chtSIS.Series.Add(minSeries);
            chtSIS.Series.Add(inventorySeries);
            
            labelResult.Text = $"Average per Period: Demand = {averagedemand.ToString("0.00")}, " +
                $"Order Amount = {avergeorder.ToString("0.00")}, Orders placed = {orderTime.ToString("0.00")}\n" +
                $"Time Averaged Levels: Holding = {(mp / limitofperiod).ToString("0.00")}, Shortage = {(mn / limitofperiod).ToString("0.00")}";
            labelResult.ForeColor = Color.Purple;
            
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
            if(cbJobInterarrivalDistribution.SelectedIndex == 0)
            {
                crvg =  new ExponentialDisCRVGenerator();
            }
            else
            {
                crvg = new UniformDisCRVGenerator();
            }
            Server[] MSQServers = new Server[servers.Count];
            for (int i = 0; i < MSQServers.Length; i++)
            {
                MSQServers[i] = servers[i]; // let the servers in the MSQServers

            }
            // here is data fields
            double ta = 0;
            int j = 0;
            int q = 0;
            int clientCount = 0;
            double mj = 0;
            double mq = 0;
            double lastTime = 0;
            int maxj = 0;
            int iterator = 0;
            // set the series
            Series s_1 = new Series("Node Level");
            s_1.ChartType = SeriesChartType.StepLine;
            s_1.BorderWidth = 2;
            s_1.Color = Color.Blue;
            Series s_2 = new Series("Queue Level");
            s_2.ChartType = SeriesChartType.StepLine;
            s_2.BorderWidth = 2;
            s_2.Color = Color.Red;
            // here we draw the chart
            s_1.Points.AddXY(0, 0);
            s_2.Points.AddXY(0, 0);
            ta += crvg.NextDouble();
            clientCount++;
            while(ta != double.PositiveInfinity || j != 0)
            {
                Array.Sort(MSQServers, delegate (Server x, Server y) { return x.completeTime.CompareTo(y.completeTime); });

                if(MSQServers[0].completeTime > ta)
                {
                    double currentTime = ta;
                    if(double.IsInfinity(currentTime) || double.IsNaN(currentTime))
                    {
                        throw new Exception("Wrong");
                    }
                    if(lastTime > currentTime)
                    {
                        throw new Exception("wrong");
                    }
                    mj += j * (currentTime - lastTime);
                    mq += q * (currentTime - lastTime);

                    j++;
                    q++;
                    s_1.Points.AddXY(currentTime, j);
                    s_2.Points.AddXY(currentTime, q);
                    if (j > maxj) 
                    {
                        maxj = j;
                    }
                    Array.Sort(MSQServers, delegate (Server x, Server y) { return x.CumlatedBusyTime.CompareTo(y.CumlatedBusyTime); });
                    foreach (var item in MSQServers)
                    {
                        if(item.IsFree)
                        {
                            q--;
                            s_2.Points.AddXY(currentTime, q);
                            item.ServerAClient(currentTime);
                            break;
                        }
                    }
                    double newinterarrival = crvg.NextDouble();
                    if (CountOrTime && clientCount > int.Parse(tbCeaseTime.Text) 
                    {
                        ta = double.PositiveInfinity;
                    }
                    else if(! CountOrTime && (ta + newinterarrival) > int.Parse(tbCeaseTime.Text))
                    {
                        ta = double.PositiveInfinity;
                    }
                    else
                    {
                        ta += newinterarrival;
                        clientCount++;
                    }
                    lastTime = currentTime;
                }
                else
                {
                    double currentTime = MSQServers[0].completeTime;
                    if(double.IsInfinity(currentTime)|| double.IsNaN(currentTime))
                    {
                        throw new Exception("Wrong");
                    }
                    if(lastTime > currentTime)
                    {
                        throw new Exception("wrong");
                    }
                    mj += j * (currentTime - lastTime);
                    mq += q * (currentTime - lastTime);
                    j--;
                    s_1.Points.AddXY(currentTime, j);
                    MSQServers[0].CompleteCurrentService();
                    if (q > 0)
                    {
                        Array.Sort(MSQServers, delegate (Server x, Server y) { return x.CumlatedBusyTime.CompareTo(y.CumlatedBusyTime); });
                        foreach (var item in MSQServers)
                        {
                            if(item.IsFree)
                            {
                                item.ServerAClient(currentTime);
                            }

                        }
                        q--;
                        s_2.Points.AddXY(currentTime, q);
                    }
                    lastTime = currentTime;




                }
                iterator++;


            }
            Array.Sort(MSQServers, delegate (Server x, Server y) { return x.GanttID.CompareTo(y.GanttID)});
            foreach (var item in MSQServers)
            {

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
