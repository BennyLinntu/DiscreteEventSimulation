using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SSQLibrary
{
    public class GeometricDRVGenerator : DiscreteRandomVariateGenerator
    {

        double LnOnProbability;
        double nonZeroProbability;

        protected virtual string Title => Title;
        public GeometricDRVGenerator()
        {

        }
        public int Nextint()
        {
            return randomizer.Next();
        }
    }
}