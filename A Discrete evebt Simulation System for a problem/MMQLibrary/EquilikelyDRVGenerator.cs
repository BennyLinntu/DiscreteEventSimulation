using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace MMQLibrary
{
    public class EquilikelyDRVGenerator : DiscreteRandomVariateGenerator
    {
        double lowerBound;
        double upperBound;

        public EquilikelyDRVGenerator(int L, int U)
        {
            this.lowerBound = L;
            this.upperBound = U;
        }

        [Category("Range")]
        public double LowerBound { get => lowerBound; set => lowerBound = value; }
        [Category("Range")]
        public double UpperBound { get => upperBound; set => upperBound = value; }

        public override Series GetDendityFunctionSeries(double resolution)
        {
            double end = UpperBound;
            double start = LowerBound;

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
            //if (lowerbound < x && x< upperbound)
            //{
            //    return 1/(upperbound - lowerbound);
            //}

            return 1.0 / (upperBound - lowerBound);
        }
        public override double GetParameters(char C)//discrete
        {
            switch (C)
            {
                case 'L':
                    return lowerBound;
                    break;
                case 'U':
                    return upperBound;
                    break;
                case 'R':
                    return upperBound - lowerBound;
                    break;
                default:
                    return 1;
                    break;
            }
        }
        public override double GenerateARealRandomNumber()
        {
            double r = randomizer.NextDouble();
            double range = (upperBound) - lowerBound;
            return lowerBound + Math.Floor(r * range);
        }
        public void NextInt()
        {
            throw new System.NotImplementedException();
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
            return Math.Round((upperBound + lowerBound) / 2.0, 2);
        }
        public override double GetTheoreticSTD()
        {
            return Math.Round(Math.Pow((Math.Pow((upperBound - lowerBound), 2) / 12.0), 0.5), 2);
        }
    }
}