using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace SSQLibrary
{
    public class ExponentialDisCRVGenerator : ContinuousRandomVariateGenerator
    {
        // data
        public double average = 2.0;
        double lowerbound = 0.0;
        double upperbound = double.PositiveInfinity;
        //properity
        [Category("Parameter")]
        public double Average {
            get => average;
            set
            {
                if (value > 0)
                {
                    average = value;
                }
                else
                {
                    return;
                }
            } 
        }
        public override double LowerBound
        {
            get => lowerbound;
            set
            {
                if(value > 0)
                {
                    lowerbound = value;
                }
            }
        }
        public override double UpperBound
        { 
            get => upperbound;
            set
            {
                if(value > lowerbound)
                {
                    upperbound = value;
                }
            } 
        }

        public ExponentialDisCRVGenerator()
        {
            
        }
        protected override double NextDouble()
        {
            return randomizer.NextDouble();
        }
        // get the Exponential
        public double Exponential()
        {
            return - Average * Math.Log(1.0 - randomizer.NextDouble());
        }
        public override double GetDensityFunctionValue(double x)
        {
            return Math.Exp(-x / average) / average;
        }

        public override double TheoreticMean()
        {
            return Average;
        }
        public override double TheoreticStandardDeviation()
        {
            return Average;
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