using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace MMQLibrary
{
    /// <summary>
    /// The class generate random variates that follow exponential distribution.
    /// </summary>
    public class ExponenitalRVG : ContinuousRandomVariateGenerator
    {
        //[Category("Theory")]
        //public override double TheoreticMean { get => mean;  }

        //data field
        double mean;
        double lowerbound, upperbound;


        public ExponenitalRVG()
        {

        }
        public ExponenitalRVG(double mean, double lowerbound, double upperbound)
        {
            this.mean = mean;
            this.lowerbound = lowerbound;
            this.upperbound = upperbound;
        }

        [Category("Parameter")]
        public double Mean { get => mean; set => mean = value; }

        [Category("Range")]
        public double Lowerbound
        { get => lowerbound; set => lowerbound = value; }
        [Category("Range")]
        public double Upperbound { get => upperbound; set => upperbound = value; }

        public override double GenerateARealRandomNumber()
        {
            return -mean * Math.Log(1.0 - randomizer.NextDouble());
        }

        public override Series GetDendityFunctionSeries(double resolution)
        {
            double end = upperbound;
            double start = lowerbound;

            Series s = new Series();
            s.Points.Clear();
            s.ChartType = SeriesChartType.Line;

            double delta = ((end - start) / resolution);
            for (double i = start; i < end; i += delta)
            {
                s.Points.AddXY(i, GetDensityFunction(i));
            }
            return s;
            //throw new System.NotImplementedException();
        }
        public override double GetDensityFunction(double x)
        {
            return Math.Exp(-x / mean) / mean;
        }


        public override double GetParameters(char C)//discrete
        {
            switch (C)
            {
                case 'M':
                    return 10 * mean;
                    break;
                default:
                    return 1;
                    break;
            }
        }
        //public Series GetDendityFunctionSeries(double start, double end, double resolution)
        //{
        //    return base.GetDendityFunctionSeries(start, end, resolution);
        //}
        public override double GetMean(double[] arr)//discrete
        {

            return Math.Round(arr.Average(), 2);
        }
        public override double GetSTD(double[] arr)
        {
            double standardDeviation = 0;

            if (arr.Any())
            {
                // Compute the average.     
                double avg = arr.Average();

                // Perform the Sum of (value-avg)_2_2.      
                double sum = arr.Sum(d => Math.Pow(d - avg, 2));

                // Put it all together.      
                standardDeviation = Math.Sqrt((sum) / (arr.Count() - 1));
            }

            return Math.Round(standardDeviation, 2);
        }

        public override double GetTheoreticMean()
        {
            return Math.Round(mean, 2);
        }
        public override double GetTheoreticSTD()
        {
            return Math.Round(mean, 2);
        }
    }
}