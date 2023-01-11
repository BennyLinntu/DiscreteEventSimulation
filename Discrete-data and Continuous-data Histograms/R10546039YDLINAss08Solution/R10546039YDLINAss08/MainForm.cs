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

namespace R10546039YDLINAss08
{
    public partial class MainForm : Form
    {
        // here check the select function
        public int selectFunction;
        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        // here we show the properity
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategory.Text == "Equilikely")
            {
                ppgShow.SelectedObject = new EquilikelyDRVGenerator();
                selectFunction = 0;
            }
            else if (cbCategory.Text == "Uniform")
            {
                ppgShow.SelectedObject = new UniformDisCRVGenerator();
                selectFunction = 1;
            }
            else if (cbCategory.Text == "Geometric")
            {
                ppgShow.SelectedObject = new GeometricDRVGenerator();
                selectFunction = 2;
            }
            else if (cbCategory.Text == "Exponential")
            {
                ppgShow.SelectedObject = new ExponentialDisCRVGenerator();
                selectFunction = 3;
            }
            else if (cbCategory.Text == "Bernoulli")
            {
                ppgShow.SelectedObject = new BernoulliDRVenerator();
                selectFunction = 4;
            }
            else
            {
                return;
            }
        }

        private void btnGenerateHistogram_Click(object sender, EventArgs e)
        {
            // clear the data
            chtShow.Series.Clear();
            chtShow.Titles.Clear();
            rtbResult.Clear();
            int replication = int.Parse(tbReplications.Text);
            double NumberOfBin = double.Parse(tbBigNumber.Text);
            if (selectFunction == 0)
            {
                // here we give it to the category 
                // we will according to different's category draw different chart
                // and show it's Count
                EquilikelyDRVGenerator eg = new EquilikelyDRVGenerator();
                Series s = new Series();
                s.Name = "Theoretic pdf()";
                s.ChartType = SeriesChartType.Point;
                s.Color = Color.Red;
                s.BorderWidth = 2;
                //here we set data and loop each others
                double[] arr = new double[replication];
                for (int i = 0; i < replication; i++)
                {
                    arr[i] = eg.Equilikely();
                }
                for (int i = (int)eg.LowerBound; i <= (int)eg.UpperBound; i++)
                {
                    s.Points.AddXY(i, eg.GetDensityFunctionValue(i));
                }
                //add Histogram
                DiscreteDataHistogram dh = new DiscreteDataHistogram(arr, 0);
                Series Histogram = new Series();
                Histogram.Name = "Histogram";
                Histogram.ChartType = SeriesChartType.Column;
                Histogram.Color = Color.Green;
                Histogram.BorderWidth = 2;
                for (int i = 0; i < dh.Items.Length; i++)
                {
                    Histogram.Points.AddXY(dh.Items[i].value + 1, (double)dh.Items[i].count / (double)replication);
                }
                chtShow.Series.Add(Histogram);
                chtShow.Series.Add(s);
                chtShow.ChartAreas[0].RecalculateAxesScale();
                chtShow.ChartAreas[0].AxisX.Maximum = dh.Items.Length + 1;
                rtbResult.Text = $"Theoretic Mean:{eg.TheoreticMean().ToString("0.00")} STD: {eg.TheoreticStandardDeviation().ToString("0.00")}\n{replication}Samples Means:{eg.Mean(arr).ToString("0.00")} STD: {eg.StandardDeviation(arr).ToString("0.00")}\nHistogram Mean: {eg.Mean(arr).ToString("0.00")} STD: {eg.StandardDeviation(arr).ToString("0.00")}";
            }
            else if (selectFunction == 1)
            {
                // Uniform
                UniformDisCRVGenerator ug = new UniformDisCRVGenerator();
                Series s = new Series();
                s.Name = "Theoretic pdf()";
                s.ChartType = SeriesChartType.Line;
                s.Color = Color.Red;
                s.BorderWidth = 2;
                //here we set data and loop each others
                double[] arr = new double[replication];
                for (int i = 0; i < replication; i++)
                {
                    arr[i] = ug.Uniform();
                }
                for (int i = (int)ug.LowerBound; i <= (int)ug.UpperBound; i++)
                {
                    s.Points.AddXY(i, ug.GetDensityFunctionValue(i));
                }
                //add Histogram
                ContinuousDataHistogram dh = new ContinuousDataHistogram(arr, (int)NumberOfBin);
                Series Histogram = new Series();
                Histogram.Name = "Histogram";
                Histogram.ChartType = SeriesChartType.StepLine;
                Histogram.Color = Color.Green;
                Histogram.BorderWidth = 2;
                for (int i = 0; i < dh.Items.Length; i++)
                {
                    Histogram.Points.AddXY(dh.Items[i].value, (double)dh.Items[i].count * ( NumberOfBin / ((ug.UpperBound -  ug.LowerBound)*(double)replication)));
                }
                chtShow.Series.Add(Histogram);
                chtShow.Series.Add(s);
                chtShow.ChartAreas[0].RecalculateAxesScale();
                chtShow.ChartAreas[0].AxisX.Maximum = ug.UpperBound;
                rtbResult.Text = $"Theoretic Mean:{ug.TheoreticMean().ToString("0.00")} STD: {ug.TheoreticStandardDeviation().ToString("0.00")}\n{replication}Samples Means:{ug.Mean(arr).ToString("0.00")} STD: {ug.StandardDeviation(arr).ToString("0.00")}\nHistogram Mean: {ug.Mean(arr).ToString("0.00")} STD: {ug.StandardDeviation(arr).ToString("0.00")}";

            }
            else if (selectFunction == 2)
            {
                // Geometric
                GeometricDRVGenerator eg = new GeometricDRVGenerator();
                Series s = new Series();
                s.Name = "Theoretic pdf()";
                s.ChartType = SeriesChartType.Point;
                s.Color = Color.Red;
                s.BorderWidth = 2;
                //here we set data and loop each others
                double[] arr = new double[replication];
                for (int i = 0; i < replication; i++)
                {
                    arr[i] = eg.Geometric();
                }
                for (int i = 1; i <= (int)eg.UpperBound; i++)
                {
                    s.Points.AddXY(i, eg.GetDensityFunctionValue(i));
                }
                //add Histogram
                DiscreteDataHistogram dh = new DiscreteDataHistogram(arr, 0);
                Series Histogram = new Series();
                Histogram.Name = "Histogram";
                Histogram.ChartType = SeriesChartType.Column;
                Histogram.Color = Color.Green;
                Histogram.BorderWidth = 2;
                for (int i = 0; i < dh.Items.Length; i++)
                {
                    Histogram.Points.AddXY(dh.Items[i].value + 1, (double)dh.Items[i].count / (double)replication);
                }
                chtShow.Series.Add(Histogram);
                chtShow.Series.Add(s);
                chtShow.ChartAreas[0].RecalculateAxesScale();
                chtShow.ChartAreas[0].AxisX.Maximum = dh.Items.Length + 1;
                rtbResult.Text = $"Theoretic Mean:{eg.TheoreticMean().ToString("0.00")} STD: {eg.TheoreticStandardDeviation().ToString("0.00")}\n{replication}Samples Means:{eg.Mean(arr).ToString("0.00")} STD: {eg.StandardDeviation(arr).ToString("0.00")}\nHistogram Mean: {eg.Mean(arr).ToString("0.00")} STD: {eg.StandardDeviation(arr).ToString("0.00")}";
            }
            else if (selectFunction == 3)
            {
                // ExponentialDisCRVGenerator
                ExponentialDisCRVGenerator eg = new ExponentialDisCRVGenerator();
                Series s = new Series();
                s.Name = "Theoretic pdf()";
                s.ChartType = SeriesChartType.Line;
                s.Color = Color.Red;
                s.BorderWidth = 2;
                //here we set data and loop each others
                double[] arr = new double[replication];
                for (int i = 0; i < replication; i++)
                {
                    arr[i] = eg.Exponential();
                }
                for (int i = (int)eg.LowerBound; i <= 10; i++)
                {
                    s.Points.AddXY(i, eg.GetDensityFunctionValue(i));
                }
                //add Histogram
                ContinuousDataHistogram dh = new ContinuousDataHistogram(arr, (int)NumberOfBin);
                Series Histogram = new Series();
                Histogram.Name = "Histogram";
                Histogram.ChartType = SeriesChartType.StepLine;
                Histogram.Color = Color.Green;
                Histogram.BorderWidth = 2;
                for (int i = 0; i < dh.Items.Length; i++)
                {
                    Histogram.Points.AddXY(dh.Items[i].value, (double)dh.Items[i].count * (NumberOfBin / ((50 - eg.LowerBound) * (double)replication) * eg.Average));
                }
                chtShow.Series.Add(Histogram);
                chtShow.Series.Add(s);
                chtShow.ChartAreas[0].RecalculateAxesScale();
                chtShow.ChartAreas[0].AxisX.Maximum = 10;
                rtbResult.Text = $"Theoretic Mean:{eg.TheoreticMean().ToString("0.00")} STD: {eg.TheoreticStandardDeviation().ToString("0.00")}\n{replication}Samples Means:{eg.Mean(arr).ToString("0.00")} STD: {eg.StandardDeviation(arr).ToString("0.00")}\nHistogram Mean: {eg.Mean(arr).ToString("0.00")} STD: {eg.StandardDeviation(arr).ToString("0.00")}";


            }
            else if (selectFunction == 4)
            {
                // Bernoulli
                BernoulliDRVenerator bg = new BernoulliDRVenerator();
                Series s = new Series();
                s.Name = "Theoretic pdf()";
                s.ChartType = SeriesChartType.Point;
                s.Color = Color.Red;
                s.BorderWidth = 2;
                //here we set data and loop each others
                double[] arr = new double[replication];
                for (int i = 0; i < replication; i++)
                {
                    arr[i] = bg.Bernoulli();
                }
                for (int i = (int)bg.LowerBound; i <= (int)bg.UpperBound; i++)
                {
                    s.Points.AddXY(i + 1, bg.GetDensityFunctionValue(i));
                }
                //add Histogram
                DiscreteDataHistogram dh = new DiscreteDataHistogram(arr, 0);
                Series Histogram = new Series();
                Histogram.Name = "Histogram";
                Histogram.ChartType = SeriesChartType.Column;
                Histogram.Color = Color.Green;
                Histogram.BorderWidth = 2;
                for (int i = 0; i < dh.Items.Length; i++)
                {
                    Histogram.Points.AddXY(dh.Items[i].value + 1, (double)dh.Items[i].count / (double)replication);
                }
                chtShow.Series.Add(Histogram);
                chtShow.Series.Add(s);
                chtShow.ChartAreas[0].RecalculateAxesScale();
                chtShow.ChartAreas[0].AxisX.Maximum = dh.Items.Length + 1;
                rtbResult.Text = $"Theoretic Mean:{bg.TheoreticMean().ToString("0.00")} STD: {bg.TheoreticStandardDeviation().ToString("0.00")}\n{replication}Samples Means:{bg.Mean(arr).ToString("0.00")} STD: {bg.StandardDeviation(arr).ToString("0.00")}\nHistogram Mean: {bg.Mean(arr).ToString("0.00")} STD: {bg.StandardDeviation(arr).ToString("0.00")}";
            }
            else
            {
                return;
            }

        }
    }
}
