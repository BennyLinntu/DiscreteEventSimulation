using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SSQLibrary
{
    public class DiscreteDataHistogram : Histogram
    {
        public DiscreteDataHistogram(double[] instaces, int numberOfbins) : base(instaces, numberOfbins)
        {

        }
        public override void update()
        {
            int x;
            int max = int.MinValue;
            int min = int.MaxValue;
            foreach (int item in instances)
            {
                if (item < min) min = item;
                if (item > max) max = item;
            }
            int range = max - min;
            items = new Histogramitems[range + 1];
            for (int i = 0; i < range + 1; i++)
            {
                items[i].value = i;
                items[i].count = 0;
            }
            for (int i = 0; i < instances.Length; i++)
            {
                x = (int)instances[i];
                if(min <= x && x <= max)
                {
                    items[(x - min)].count++;
                }
            }
            
        }

    }
}