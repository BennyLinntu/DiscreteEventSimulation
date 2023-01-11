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
        
        double average;
        //properity
        protected double TheoreticMean { get => TheoreticMean; }
        protected double TheoreticStandardDeviation { get => TheoreticStandardDeviation; }
        [Category("Parameter")]
        public double Average { get => average; set => average = value; }

        public ExponentialDisCRVGenerator(double avg)
        {
            this.Average = avg;
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
        
    }
}