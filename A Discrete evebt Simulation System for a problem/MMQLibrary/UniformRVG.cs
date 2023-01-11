using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace MMQLibrary
{
    public class UniformRVG : ContinuousRandomVariateGenerator
    {
        double lowerbound, upperbound;


        public UniformRVG()
        {

        }
        public UniformRVG(double lowerbound, double upperbound)
        {
            this.lowerbound = lowerbound;
            this.upperbound = upperbound;
        }



        [Category("Range")]
        public double Lowerbound
        { get => lowerbound; set => lowerbound = value; }
        [Category("Range")]
        public double Upperbound { get => upperbound; set => upperbound = value; }

        public override double GenerateARealRandomNumber()
        {
            double u = randomizer.NextDouble();
            double range = upperbound - lowerbound;
            return lowerbound + u * range;
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
        public override double GetDensityFunction(double x)
        {
            return 1 / (upperbound - lowerbound);
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
            return Math.Round((upperbound + lowerbound) / 2.0, 2);
        }
        public override double GetTheoreticSTD()
        {
            return Math.Round(Math.Pow((Math.Pow((upperbound - lowerbound), 2) / 12.0), 0.5), 2);
        }
    }
}
