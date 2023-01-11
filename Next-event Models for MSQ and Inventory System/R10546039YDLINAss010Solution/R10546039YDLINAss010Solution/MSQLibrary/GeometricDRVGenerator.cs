using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSQLibrary
{
    public class GeometricDRVGenerator : DiscreteRandomVariateGenerator
    {
        double nonZeroProbability = 0.5;

        protected virtual string Title => Title;

        public double NonZeroProbability
        {
            get => nonZeroProbability;
            set
            {
                if(value > 0)
                {
                    nonZeroProbability = value;
                }
            }
        }

        public GeometricDRVGenerator()
        {
            
        }
        public int Nextint()
        {
            return randomizer.Next();
        }
        public double Geometric()
        {
            double u = randomizer.NextDouble();
            return (long)(Math.Log(1.0 - u) / Math.Log(nonZeroProbability));
        }
        public override double GetDensityFunctionValue(double x)
        {
            double l;
            l = (1.0 - NonZeroProbability) * (Math.Pow(nonZeroProbability, x - 1));
            return l;
        }

        public override double TheoreticMean()
        {
            return 1.0;
        }
        public override double TheoreticStandardDeviation()
        {
            double p = nonZeroProbability / Math.Pow((1.0 - nonZeroProbability), 2);
            return Math.Pow(p, 0.5);
        }


        public override double Mean(double[] a)
        {
            return a.Average();
        }
        public override double StandardDeviation(double[] a)
        {
            double avg = a.Average();
            double total = a.Sum(s => Math.Pow(s - avg, 2));
            return Math.Sqrt(total / ((double)a.Count() - 1.0));
        }

    }
}