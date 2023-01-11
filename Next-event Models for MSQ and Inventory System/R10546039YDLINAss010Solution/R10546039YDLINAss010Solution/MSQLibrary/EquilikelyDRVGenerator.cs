using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace MSQLibrary
{
    

    public class EquilikelyDRVGenerator : DiscreteRandomVariateGenerator
    {
        // properity
        double lowerBound = 1.0;
        double upperBound = 6.0;
        [Category("Parameter")]
        public override double LowerBound
        {
            get => lowerBound;
            set
            {
                if (value > 0)
                {
                    lowerBound = value;
                }
            }
        }
        [Category("Parameter")]
        public override double UpperBound
        {
            get => upperBound;
            set
            {
                if (value > 0)
                {
                    upperBound = value;
                }
            }
        }
        protected virtual string Title => Title;

        public EquilikelyDRVGenerator()
        {
            
        }
        public int NextInt()
        {
            return randomizer.Next();
        }
        public double Equilikely()
        {
            double u = randomizer.NextDouble();
            return LowerBound + (long)(UpperBound + 1 - LowerBound) * u;
        }
        public double getdelta()
        {
            return randomizer.NextDouble();
        }
        public  override double GetDensityFunctionValue(double x)
        {
            return 1 / (upperBound - lowerBound +1);
        }
        public override double TheoreticMean()
        {
            return (UpperBound + LowerBound) / 2.0;
        }
        public override double TheoreticStandardDeviation()
        {
            return Math.Pow((((UpperBound - LowerBound) * (UpperBound - LowerBound)) / 12.0), 0.5);
        }

        public override double Mean(double[] a)
        {
            return a.Average();
        }
        public override double StandardDeviation(double[] a)
        {
            double avg = a.Average();
            double total = a.Sum(s => Math.Pow(s - avg, 2));
            return Math.Sqrt(total/((double)a.Count() - 1.0));
        }
    }
    
}