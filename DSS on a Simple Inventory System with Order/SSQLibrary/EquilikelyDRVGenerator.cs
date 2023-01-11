using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace SSQLibrary
{
    

    public class EquilikelyDRVGenerator : DiscreteRandomVariateGenerator
    {
        int max = 80;
        int min = 20;
        double setupcost = 1000;
        double holdingcost = 25;
        double shortagecost = 700;
        [CategoryAttribute("Demand, Uniform Distribution")]
        public int Max
        {
            get => max;
            set
            {
                if (value > 0)
                {
                    if (value > min)
                    {
                        max = value;
                    }
                }
            }
        }
        [CategoryAttribute("Demand, Uniform Distribution")]
        public int Min
        {
            get => min;
            set
            {
                if (value > 0)
                {
                    if (value < max)
                    {
                        min = value;
                    }
                }
            }
        }
        [CategoryAttribute("Demand, Uniform Distribution")]
        public double Setupcost
        {
            get => setupcost;
            set
            {
                if (value > 0)
                {
                    setupcost = value;
                }
            }

        }
        [CategoryAttribute("Demand, Uniform Distribution")]
        public double Holdingcost
        {
            get => holdingcost;
            set
            {
                if (value > 0)
                {
                    holdingcost = value;
                }
            }
        }
        [CategoryAttribute("Demand, Uniform Distribution")]
        public double Shortagecost
        {
            get => shortagecost;
            set
            {
                if (value > 0)
                {
                    shortagecost = value;
                }
            }
        }


        protected virtual double TheoreticMean => TheoreticMean;
        protected virtual double TheoreticStandardDeviation => TheoreticStandardDeviation;
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

    }
    
}