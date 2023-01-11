using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace MSQLibrary
{
    public class DiscreteRandomVariateGenerator : RandomVariateGenerator
    {
        // properity
        
        double lowerBound = 10;
        double upperBound = 50;
        [Category("Parameter")]
        public virtual double LowerBound
        { 
            get => lowerBound;
            set
            {
                if(value > 0)
                {
                    lowerBound = value;
                }
            }
        }
        [Category("Parameter")]
        public  virtual double UpperBound 
        {
            get => upperBound;
            set
            {
                if(value > 0)
                {
                    upperBound = value;
                }
            }
        }
    }
}