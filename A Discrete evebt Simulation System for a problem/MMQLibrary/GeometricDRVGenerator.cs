using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace MMQLibrary
{
    public class GeometricDRVGenerator : DiscreteRandomVariateGenerator
    {
        private double s_Pro;
        //private int NonZeroProbability;
        double lowerbound = 1, upperbound = 100;

        [Category("Range")]
        public double Lowerbound
        { get => lowerbound; set => lowerbound = value; }
        [Category("Range")]
        public double Upperbound { get => upperbound; set => upperbound = value; }

        public GeometricDRVGenerator(double Success_Probability)
        {
            this.F_Probability = Success_Probability;
        }

        [Category("Parameter")]
        public double F_Probability { get => s_Pro; set => s_Pro = value; }

        public override Series GetDendityFunctionSeries(double resolution)
        {
            double end = upperbound;
            double start = lowerbound;

            Series s = new Series();
            s.Points.Clear();
            s.ChartType = SeriesChartType.Point;

            for (int i = (int)start; i < end; i++)
            {
                s.Points.AddXY(i, GetDensityFunction(i));
            }
            return s;
            //throw new System.NotImplementedException();
        }

        public override double GetDensityFunction(double x)
        {
            double y;
            y = (1.0 - F_Probability) * (Math.Pow(F_Probability, x - 1));
            return y;
        }

        public override double GenerateARealRandomNumber()
        {

            bool success = false;
            int times = 0;
            do
            {
                double u = randomizer.NextDouble();
                if (u > F_Probability)
                    success = true;
                times++;
            } while (success == false);
            return times;
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
                case 'R':
                    return upperbound - lowerbound;
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
            return Math.Round(1.0 / (1.0 - F_Probability), 2);
        }
        public override double GetTheoreticSTD()
        {
            double y = F_Probability / Math.Pow((1.0 - F_Probability), 2);
            return Math.Round(Math.Pow(y, 0.5), 2);
        }
    }
}