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
        
        double lowerBound = 1.0;
        double upperBound = 2.0;
        [CategoryAttribute("Boundary")]
        public double LowerBound
        {
            get => lowerBound;
            set
            {
                if(value > 0)
                {
                    if(value < upperBound)
                    {
                        lowerBound = value;
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
        }
        [CategoryAttribute("Boundary")]
        public double UpperBound 
        { 
            get => upperBound;
            set
            {
                if(value > 0)
                {
                    if(value > lowerBound )
                    {
                        upperBound = value;
                    }
                    
                }
                else
                {
                    return;
                }
            }
        }
    }
}