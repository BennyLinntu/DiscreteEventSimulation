using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SSQLibrary
{
    public class UniformDisCRVGenerator : ContinuousRandomVariateGenerator
    {
        //properity
        protected double TheoreticMean { get => TheoreticMean; }
        protected double TheoreticStandardDeviation { get => TheoreticStandardDeviation; }
        public UniformDisCRVGenerator(double lowerbound, double uppperbound)
        {
            this.LowerBound = lowerbound;
            this.UpperBound = uppperbound;
        }
        protected override double NextDouble()
        {
            return randomizer.NextDouble();
        }
        // get the uniform
        public double Uniform()
        {
            double u = randomizer.NextDouble();
            return LowerBound + ((UpperBound - LowerBound) * u);
        }

    }
}