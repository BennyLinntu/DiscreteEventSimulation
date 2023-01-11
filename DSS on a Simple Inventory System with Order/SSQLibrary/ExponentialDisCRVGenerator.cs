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
        //properity
        protected double TheoreticMean { get => TheoreticMean; }
        protected double TheoreticStandardDeviation { get => TheoreticStandardDeviation; }
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
        
    }
}