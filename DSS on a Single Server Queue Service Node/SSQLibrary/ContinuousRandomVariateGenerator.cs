using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace SSQLibrary
{
    public class ContinuousRandomVariateGenerator : RandomVariateGenerator
    {
        // properity
        double lowerBound;
        double upperBound;
        public double LowerBound { get => lowerBound; set => lowerBound = value; }
        public double UpperBound { get => upperBound; set => upperBound = value; }
    }
}