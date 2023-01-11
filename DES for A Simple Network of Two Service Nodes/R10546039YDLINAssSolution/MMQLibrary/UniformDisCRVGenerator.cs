using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace MMQLibrary
{
    public class UniformDisCRVGenerator : ContinuousRandomVariateGenerator
    {
        //properity
        double lowerBound = 1.0;
        double upperBound = 2.0;
        [CategoryAttribute("Boundary")]
        public override double LowerBound
        {
            get => lowerBound;
            set
            {
                if (value > 0)
                {
                    if (value < upperBound)
                    {
                        lowerBound = value;
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
        }
        [CategoryAttribute("Boundary")]
        public override double UpperBound
        {
            get => upperBound;
            set
            {
                if (value > 0)
                {
                    if (value > lowerBound)
                    {
                        upperBound = value;
                    }

                }
                else
                {
                    return;
                }
            }
        }


        public UniformDisCRVGenerator()
        {


        }
        public override double NextDouble()
        {
            UpdateStatistics();
            double result = lowerBound + ((upperBound - lowerBound) * (randomizer.NextDouble()));
            generatedSTD = generatedSTD + (generatedCount / (generatedCount + 1d)) * Math.Pow(result - generatedAvereage, 2);
            generatedAvereage = generatedAvereage + (1d / (generatedCount + 1d)) * (result - generatedAvereage);

            return lowerBound + ((upperBound - lowerBound) * (randomizer.NextDouble()));
        }

        public override double GetDensityFunctionValue(double x)
        {
            return 1 / (upperBound - lowerBound);
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
            return Math.Sqrt(total / ((double)a.Count() - 1.0));
        }

        public override string ToString()
        {
            return $"Uni Dis({ lowerBound:0.00}, { upperBound: 0.00})";
        }

    }
}