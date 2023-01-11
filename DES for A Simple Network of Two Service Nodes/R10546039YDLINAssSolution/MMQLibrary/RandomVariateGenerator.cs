using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMQLibrary
{
    public class RandomVariateGenerator
    {
        // Data
        protected Random randomizer = new Random();
        protected int seed;
        protected int generatedCount = 0;
        protected double generatedAvereage = 0.0;
        protected double generatedSTD = 0.0;
        public double GeneratedMean
        {
            get => generatedAvereage;
        }
        public double GeneratedSTD
        {
            get => generatedSTD;
        }


        public RandomVariateGenerator()
        {
            
        }
        // function
        protected void UpdateStatistics()
        {
            generatedCount++;
        }

        public virtual double NextDouble()
        {
            UpdateStatistics();
            return randomizer.NextDouble();
        }
        protected virtual int Nextint()
        {
            UpdateStatistics();
            return randomizer.Next();
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
        public virtual void Reset()
        {
            generatedCount = 0;
        }

    }
}
