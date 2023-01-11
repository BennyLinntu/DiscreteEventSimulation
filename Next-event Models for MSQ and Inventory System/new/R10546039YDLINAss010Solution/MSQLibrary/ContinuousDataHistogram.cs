using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSQLibrary
{
    public class ContinuousDataHistogram : Histogram
    {
        public ContinuousDataHistogram(double[] instances, int numberofBins): base(instances, numberofBins)
        {

        }

        public override void update()
        {
            long x;
            double max = instances.Max();
            double min = instances.Min();

            BinWidth = (max - min) / numberOfBin;
            items = new Histogramitems[numberOfBin];
            for (int i = 0; i < numberOfBin; i++)
            {
                Items[i].value=  min + i * BinWidth + (BinWidth / 2.0);
                Items[i].count = 0;
            }
            for (int i = 0; i < instances.Length; i++)
            {
                if(min <= instances[i] && instances[i] < max)
                {
                    x = (long)((instances[i] - min) / BinWidth);
                    items[x].count++;
                }
            }
        }
    }
}