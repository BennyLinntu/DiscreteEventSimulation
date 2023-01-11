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
        protected Random randomizer = new Random();
        protected int seed;
        // proprity
        
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
        public virtual double GetDensityFunctionValue(double x)
        {
            throw new System.NotImplementedException();
        }
        // here we show the Theoretic
        public virtual double TheoreticMean()
        {
            throw new System.NotImplementedException();
        }
        public virtual double TheoreticStandardDeviation()
        {
            throw new System.NotImplementedException();
        }

        public virtual double Mean(double[] a)
        {
            throw new System.NotImplementedException();
        }
        public virtual double StandardDeviation(double[] a)
        {
            throw new System.NotImplementedException();
        }

        public virtual double GetRandomNumber()
        {
            throw new System.NotImplementedException();
        }

    }
}
