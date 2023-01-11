using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace MSQLibrary
{
    public class BernoulliDRVenerator : DiscreteRandomVariateGenerator
    {
        double probabilityForOne = 0.5;
        double lowerBound = 0.0;
        double upperBound = 1.0;
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
        [Category("Random Varitae Parameters")]
        public double ProbabilityForOne
        {
            get => probabilityForOne;
            set
            {
                if (value > 0.0 && value < 1.0)
                {
                    probabilityForOne = value;
                }
            }
        }
        public override double GetDensityFunctionValue(double x)
        {
            if (x == 0)
            {
                return 1.0 - ProbabilityForOne;
            }
            else
            {
                return ProbabilityForOne;
            }


        }
        public BernoulliDRVenerator()
        {

        }

        public double Bernoulli()
        {
            double u = randomizer.NextDouble();
            if(u >= ProbabilityForOne)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public override double TheoreticMean()
        {
            return probabilityForOne;
        }
        public override double TheoreticStandardDeviation()
        {
            return Math.Pow(probabilityForOne * (1.0 - probabilityForOne), 0.5);
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