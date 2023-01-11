using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace MMQLibrary
{
    public class ExponentialDisCRVGenerator : ContinuousRandomVariateGenerator
    {
        // data fields
        protected double average = 2.0;
        double lowerbound = 0.0;
        double upperbound = double.PositiveInfinity;
        //properity
        [Category("Parameter")]
        public double Average {
            get => average;
            set
            {
                if (value > 0.0)
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
        public override string ToString()
        {
            return $"Expo Dis({average:0.00})";
        }


        public ExponentialDisCRVGenerator()
        {
            
        }
        public override double NextDouble()
        {
            UpdateStatistics();
            double result = -Average * Math.Log(1.0 - randomizer.NextDouble());
            generatedSTD = generatedSTD + (generatedCount / (generatedCount + 1d)) * Math.Pow(result - generatedAvereage, 2);
            generatedAvereage = generatedAvereage + (1d / generatedCount + 1d) * (result - generatedAvereage);
            return -Average * Math.Log(1.0 - randomizer.NextDouble());
        }
        // get the Exponential

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