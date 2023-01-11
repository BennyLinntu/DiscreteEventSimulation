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

namespace R10546039YDLINAss03
{
    public partial class MainForm : Form
    {
        //Data
        int MinimumLevel, MaximumLevel, NumberofPeriod, CostofItem, CostofSetUp, CostofHold, CostofShort;
        double HoldingInventoryLevel = 0;
        double ShortInventoryLevel = 0;
        double AverageDemanShow;
        double AverageOrderShow;
        double AverageOrderFrequency;
        int[] DemandQuantity;
        int[] OrderedQuantity;
        int[] OrderFrequency;
        int[] InventoryQuantity;
        // Open a File
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            rtbInput.Clear();
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(dlgOpen.FileName);
                char[] seps = { ' ', ',' };
                string[] itemsFirst = sr.ReadLine().Split(seps, StringSplitOptions.RemoveEmptyEntries);
                rtbInput.AppendText($"Minimum Level:{itemsFirst[0]}, Maximum Level:{itemsFirst[1]}, Numbers:{itemsFirst[2]}\n");
                MinimumLevel = Convert.ToInt32(itemsFirst[0]);
                MaximumLevel = Convert.ToInt32(itemsFirst[1]);
                NumberofPeriod = Convert.ToInt32(itemsFirst[2]);
                DemandQuantity = new int[NumberofPeriod + 1];
                OrderedQuantity = new int[NumberofPeriod + 1];
                InventoryQuantity = new int[NumberofPeriod + 1];
                for (int i = 0; i <= NumberofPeriod; i++)
                {
                    if (i == 0)
                    {
                        DemandQuantity[i] = 0;
                    }
                    else
                    {
                        string[] items = sr.ReadLine().Split(seps, StringSplitOptions.RemoveEmptyEntries);
                        DemandQuantity[i] = Convert.ToInt32(items[0]);
                        rtbInput.AppendText($"Job{i}, Demand Quantity: {DemandQuantity[i]}\n");
                    }
                }
                string[] itemsEnd = sr.ReadLine().Split(seps, StringSplitOptions.RemoveEmptyEntries);
                rtbInput.AppendText($"Cost of Item:{itemsEnd[0]}\nCost of SetUp:{itemsEnd[1]}\nCost of Hold:{itemsEnd[2]}\nCost of Short:{itemsEnd[3]}");
                CostofItem = Convert.ToInt32(itemsEnd[0]);
                CostofSetUp = Convert.ToInt32(itemsEnd[1]);
                CostofHold = Convert.ToInt32(itemsEnd[2]);
                CostofShort = Convert.ToInt32(itemsEnd[3]);
                sr.Close();
                btnSimulateInventoryChanges.Enabled = true;
                btnFindOptimum.Enabled = true;
                btnSave.Enabled = true;
                btnSaveFile.Enabled = true;
            }
        }
        //Save a File
        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(dlgSave.FileName);
                sw.WriteLine(MinimumLevel + " " + MaximumLevel + " " + NumberofPeriod);
                for (int i = 0; i < NumberofPeriod; i++)
                {
                    sw.WriteLine(DemandQuantity[i]);
                }
                sw.WriteLine(CostofItem + " " + CostofSetUp + " " + CostofHold + " " + CostofShort);
                sw.Close();
            }
        }

        // Simulate Inventory Changes
        private void btnSimulateInventoryChanges_Click(object sender, EventArgs e)
        {
            // clear the chart
            chtJobCount.Series[0].Points.Clear();
            chtJobCount.Series[1].Points.Clear();
            chtJobCount.Series[2].Points.Clear();
            OrderFrequency = new int[NumberofPeriod + 1];
            HoldingInventoryLevel = 0;
            ShortInventoryLevel = 0;
            // draw the picture
            chtJobCount.Series[0].Points.AddXY(0, MinimumLevel);
            chtJobCount.Series[0].Points.AddXY(NumberofPeriod, MinimumLevel);
            chtJobCount.Series[1].Points.AddXY(0, MaximumLevel);
            chtJobCount.Series[1].Points.AddXY(NumberofPeriod, MaximumLevel);
            for (int i = 0; i <= NumberofPeriod; i++)
            {
                if(i != NumberofPeriod)
                {
                    if (i == 0)
                    {
                        InventoryQuantity[i] = MaximumLevel; // we know that the first number is max;
                        OrderedQuantity[i] = 0; // we know at the 0, the order quatity is o;
                        chtJobCount.Series[2].Points.AddXY(i, InventoryQuantity[i]);
                    }
                    else
                    {
                        if (InventoryQuantity[i - 1] < MinimumLevel)
                        {
                            OrderedQuantity[i - 1] = MaximumLevel - InventoryQuantity[i - 1];
                            InventoryQuantity[i] = InventoryQuantity[i - 1] - DemandQuantity[i] + OrderedQuantity[i - 1];
                            chtJobCount.Series[2].Points.AddXY(i - 1, MaximumLevel);
                            chtJobCount.Series[2].Points.AddXY(i, InventoryQuantity[i]);
                            OrderFrequency[i - 1] = 1;
                        }
                        else
                        {
                            OrderedQuantity[i] = 0;
                            InventoryQuantity[i] = InventoryQuantity[i - 1] - DemandQuantity[i] + OrderedQuantity[i];
                            chtJobCount.Series[2].Points.AddXY(i, InventoryQuantity[i]);
                            OrderFrequency[i] = 0;
                        }
                    } 
                }
                else
                {
                    if (InventoryQuantity[i - 1] < MinimumLevel)
                    {
                        chtJobCount.Series[2].Points.AddXY(i - 1, MaximumLevel);
                        InventoryQuantity[i] = MaximumLevel - DemandQuantity[i - 1];
                        OrderedQuantity[i - 1] = MaximumLevel - InventoryQuantity[i - 1];
                        OrderedQuantity[i] = MaximumLevel - InventoryQuantity[i];
                        chtJobCount.Series[2].Points.AddXY(i, InventoryQuantity[i]);
                        chtJobCount.Series[2].Points.AddXY(i, MaximumLevel);
                        OrderFrequency[i - 1] = 1;
                        OrderFrequency[i] = 1;
                    }
                    else
                    {
                        OrderedQuantity[i] = 0;
                        InventoryQuantity[i] = InventoryQuantity[i - 1] - DemandQuantity[i] + OrderedQuantity[i];
                        chtJobCount.Series[2].Points.AddXY(i, InventoryQuantity[i]);
                        chtJobCount.Series[2].Points.AddXY(i, MaximumLevel);
                        OrderedQuantity[i] = MaximumLevel - InventoryQuantity[i];
                        OrderFrequency[i] = 1;
                    }
                }
                if(i != 0)
                {
                    if (InventoryQuantity[i] < 0)
                    {
                        HoldingInventoryLevel += Math.Pow(InventoryQuantity[i - 1], 2) / (2 * DemandQuantity[i]);
                        ShortInventoryLevel += Math.Pow(InventoryQuantity[i], 2) / (2 * DemandQuantity[i]);
                    }
                    else
                    {
                        HoldingInventoryLevel += Math.Abs(InventoryQuantity[i] + (0.5 * DemandQuantity[i]));
                    }
                }
            }
            // Count the Data 
            AverageOrderShow = DemandQuantity.Sum(); // Count SUm 
            AverageOrderShow = AverageOrderShow / NumberofPeriod;
            AverageDemanShow = DemandQuantity.Sum(); // Count Sum
            AverageDemanShow = AverageDemanShow / NumberofPeriod;
            AverageOrderFrequency = OrderFrequency.Sum();
            AverageOrderFrequency = AverageOrderFrequency / NumberofPeriod;
            labelAD.Text = $"Average Demand:{Math.Round(AverageOrderShow, 4)} per period";
            labelAO.Text = $"Average Order:{Math.Round(AverageOrderShow, 4)} per period";
            labelTAHL.Text = $"Time-Averaged Holding Level:{Math.Round((HoldingInventoryLevel / NumberofPeriod), 4)}";
            labelTASL.Text = $"Time-Averaged Shortage Level:{Math.Round((ShortInventoryLevel / NumberofPeriod), 4)}";
            labelOF.Text = $"Order Order({OrderFrequency.Sum()} / {NumberofPeriod}) = {Math.Round(AverageOrderFrequency, 4)} per period";
        }



        // Create a data

        private void btnCreateData_Click(object sender, EventArgs e)
        {
            rtbInput.Clear();
            Random r = new Random();
            // Convort all data to the table and create a new data
            int DemandVariance = 0;
            int AverageDemand = 0;
            MaximumLevel = Convert.ToInt32(tbMaximumInventoryLevel.Text);
            MinimumLevel = Convert.ToInt32(tbMinimumInventoryLevel.Text);
            NumberofPeriod = Convert.ToInt32(tbNumbersOfIntervals.Text);
            AverageDemand = Convert.ToInt32(tbAverageDemand.Text);
            DemandVariance = Convert.ToInt32(tbDemandVariance.Text);
            CostofItem = Convert.ToInt32(tbItemCost.Text);
            CostofSetUp = Convert.ToInt32(tbOrderSetupCost.Text);
            CostofHold = Convert.ToInt32(tbHoldingCost.Text);
            CostofShort = Convert.ToInt32(tbShortageCost.Text);
            DemandQuantity = new int[NumberofPeriod + 1];
            OrderedQuantity = new int[NumberofPeriod + 1];
            InventoryQuantity = new int[NumberofPeriod + 1];
            rtbInput.AppendText($"Minimum Level:{MinimumLevel}, Maximum Level:{MaximumLevel}, Numbers:{NumberofPeriod}\n");
            // Create the Demand 
            for (int i = 0; i < NumberofPeriod; i++)
            {
                DemandQuantity[i] = Math.Max(0, AverageDemand + r.Next(-1 * DemandVariance, DemandVariance));
                rtbInput.AppendText($"Job{i}, Demand Quantity: {DemandQuantity[i]}\n");
            }
            rtbInput.AppendText($"Cost of Item:{CostofItem}\nCost of SetUp:{CostofSetUp}\nCost of Hold:{CostofHold}\nCost of Short:{CostofShort}");
            btnSimulateInventoryChanges.Enabled = true;
            btnFindOptimum.Enabled = true;
        }

        // Find Optimum
        private void btnFindOptimum_Click(object sender, EventArgs e)
        {
            chtDependentCost.Series[0].Points.Clear();
            chtDependentCost.Series[1].Points.Clear();
            chtDependentCost.Series[2].Points.Clear();
            double MinimumSpent = double.MaxValue;
            int MinimumLevel = 0;
            double TotalSpent;
            for (int j = 0; j < MaximumLevel; j++)
            {
                ShortInventoryLevel = HoldingInventoryLevel = 0;
                OrderFrequency = new int[NumberofPeriod + 1];
                for (int i = 0; i <= NumberofPeriod; i++)
                {
                    if (i != NumberofPeriod)
                    {
                        if (i == 0)
                        {
                            InventoryQuantity[i] = MaximumLevel; // we know that the first number is max;
                            OrderedQuantity[i] = 0; // we know at the 0, the order quatity is o;
                        }
                        else
                        {
                            if (InventoryQuantity[i - 1] < j)
                            {
                                OrderedQuantity[i - 1] = MaximumLevel - InventoryQuantity[i - 1];
                                InventoryQuantity[i] = InventoryQuantity[i - 1] - DemandQuantity[i] + OrderedQuantity[i - 1];
                                OrderFrequency[i - 1] = 1;
                            }
                            else
                            {
                                OrderedQuantity[i] = 0;
                                InventoryQuantity[i] = InventoryQuantity[i - 1] - DemandQuantity[i] + OrderedQuantity[i];
                                OrderFrequency[i] = 0;
                            }
                        }
                    }
                    else
                    {
                        if (InventoryQuantity[i - 1] < j)
                        {
                            InventoryQuantity[i] = MaximumLevel - DemandQuantity[i - 1];
                            OrderedQuantity[i - 1] = MaximumLevel - InventoryQuantity[i - 1];
                            OrderedQuantity[i] = MaximumLevel - InventoryQuantity[i];
                            OrderFrequency[i - 1] = 1;
                            OrderFrequency[i] = 1;
                        }
                        else
                        {
                            OrderedQuantity[i] = 0;
                            InventoryQuantity[i] = InventoryQuantity[i - 1] - DemandQuantity[i] + OrderedQuantity[i];
                            OrderedQuantity[i] = MaximumLevel - InventoryQuantity[i];
                            OrderFrequency[i] = 1;
                        }
                    }
                    if (i != 0)
                    {
                        if (InventoryQuantity[i] < 0)
                        {
                            HoldingInventoryLevel += Math.Pow(InventoryQuantity[i - 1], 2) / (2 * DemandQuantity[i]);
                            ShortInventoryLevel += Math.Pow(InventoryQuantity[i], 2) / (2 * DemandQuantity[i]);
                        }
                        else
                        {
                            HoldingInventoryLevel += Math.Abs(InventoryQuantity[i] + (0.5 * DemandQuantity[i]));
                        }
                    }
                }
                AverageOrderFrequency = OrderFrequency.Sum();
                AverageOrderFrequency = AverageOrderFrequency / NumberofPeriod;
                chtDependentCost.Series[0].Points.AddXY(j, Math.Max(0, AverageOrderFrequency * CostofSetUp));
                chtDependentCost.Series[1].Points.AddXY(j, Math.Max(0, HoldingInventoryLevel / NumberofPeriod * CostofHold));
                chtDependentCost.Series[2].Points.AddXY(j, Math.Max(0, ShortInventoryLevel / NumberofPeriod * CostofShort));
                chtDependentCost.ChartAreas[0].AxisX.Minimum = 0;
                //chtDependentCost.ChartAreas[0].AxisY.Minimum = 0;
                TotalSpent = ((AverageOrderFrequency * CostofSetUp) + (HoldingInventoryLevel / NumberofPeriod * CostofHold) + (ShortInventoryLevel / NumberofPeriod * CostofShort));
                if(TotalSpent < MinimumSpent)
                {
                    MinimumSpent = TotalSpent;
                    MinimumLevel = j;
                }
            }
            labelOR.Text = $"Optimization Results:Minimal Spent = {Math.Round(MinimumSpent, 4)} at Minimum Level = {MinimumLevel}";
            
        }


        public MainForm()
        {
            InitializeComponent();
        }

    }
}
