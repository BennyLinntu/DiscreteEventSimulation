using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace MMQLibrary
{
    public class BernoulliDRVG : DiscreteRandomVariateGenerator
    {
        private double s_Pro;
        //private int NonZeroProbability;
        double lowerbound = 0, upperbound = 1;

        [Category("Range")]
        public double Lowerbound
        { get => lowerbound; set => lowerbound = value; }
        [Category("Range")]
        public double Upperbound { get => upperbound; set => upperbound = value; }

        public BernoulliDRVG(double Success_Probability)
        {
            this.s_Pro = Success_Probability;
        }

        [Category("Parameter")]
        public double S_Probability { get => s_Pro; set => s_Pro = value; }

        public override Series GetDendityFunctionSeries(double resolution)
        {
            double end = upperbound;
            double start = lowerbound;

            Series s = new Series();
            s.Points.Clear();
            s.ChartType = SeriesChartType.Point;

            for (int i = (int)start; i < end + 1; i++)
            {
                s.Points.AddXY(i, GetDensityFunction(i));
            }
            return s;
            //throw new System.NotImplementedException();
        }

        public override double GetDensityFunction(double x)
        {
            if (x == 0)
            {
                return (1.0 - S_Probability);
            }
            else
            {
                return (S_Probability);
            }

        }

        public override double GenerateARealRandomNumber()
        {
            double u = randomizer.NextDouble();
            if (u >= S_Probability)
                return 0;
            else
                return 1;
        }

        public void NextInt()
        {
            throw new System.NotImplementedException();
        }

        public override double GetParameters(char C)//discrete
        {
            switch (C)
            {
                case 'L':
                    return lowerbound;
                    break;
                case 'U':
                    return upperbound;
                    break;
                case 'P':
                    return s_Pro;
                    break;
                default:
                    return 1;
                    break;
            }
        }
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
            return Math.Round(S_Probability, 2);
        }
        public override double GetTheoreticSTD()
        {
            return Math.Round(Math.Pow(S_Probability * (1.0 - S_Probability), 0.5), 2);
        }

    }

}
