using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace SSQLibrary
{
    public class DiscreteRandomVariateGenerator : RandomVariateGenerator
    {
        // properity
        [Category("Parameter")]
        double lowerBound = 0;
        double upperBound = 2;
        
        public double LowerBound { get => lowerBound; set => lowerBound = value; }
        public double UpperBound { get => upperBound; set => upperBound = value; }
    }
}