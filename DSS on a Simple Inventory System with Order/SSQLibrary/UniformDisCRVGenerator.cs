using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace SSQLibrary
{
    public class UniformDisCRVGenerator : ContinuousRandomVariateGenerator
    {
        //properity
        double average = 100.0;
        int numberofmachine = 70;
        protected double TheoreticMean { get => TheoreticMean; }
        protected double TheoreticStandardDeviation { get => TheoreticStandardDeviation; }
        [Category("Parameter")]
        public double Average 
        { 
            get => average;
            set
            {
                if(value > 0)
                {
                    average = value;
                }
            }
        }
        [Category("Parameter")]
        public int Numberofmachine
        {
            get => numberofmachine;
            set
            {
                if(value > 0)
                {
                    numberofmachine = value;
                }
            }
        }

        

        public UniformDisCRVGenerator()
        {


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