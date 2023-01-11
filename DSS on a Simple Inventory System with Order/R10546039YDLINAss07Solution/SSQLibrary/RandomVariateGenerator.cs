using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSQLibrary
{
    public class RandomVariateGenerator
    {
        // Data
        protected Random randomizer;
        protected int seed;
        // proprity
        protected virtual double TheoreticMean => TheoreticMean;
        protected virtual double TheoreticStandardDeviation => TheoreticStandardDeviation;
        protected virtual string Title => Title;
        public RandomVariateGenerator()
        {
            
        }
        // function
        protected virtual void f()
        {

        }
        protected virtual double NextDouble()
        {
            return randomizer.NextDouble();
        }
        protected virtual int Nextint()
        {
            return 0;
        }
        protected virtual int SetSeed()
        {
            return 0;
        }
        public void getSeed(int s)
        {
            if(s == -1)
            {
                randomizer = new Random();
            }
            else
            {
                randomizer = new Random(s);
            }
        }
    }
}
