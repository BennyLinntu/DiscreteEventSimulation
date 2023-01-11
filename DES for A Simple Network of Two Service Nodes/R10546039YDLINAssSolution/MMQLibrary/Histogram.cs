using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMQLibrary
{
    public class Histogram
    {
        protected int numberOfBin;
        protected double BinWidth;
        protected double[] instances;
        protected Histogramitems[] items;
        public int NumberOfBin
        {
            get => numberOfBin;
            set
            {
                if(value > 5 && numberOfBin != value)
                {
                    numberOfBin = value;
                    update();
                }

            }
        }
        public Histogramitems[] Items { get => items;}

        public Histogram(double[]Instances, int NumberofBin)
        { 
            this.instances = Instances;
            this.numberOfBin = NumberofBin;
            update();
        }
        public virtual void update()
        {
            throw new Exception("No Implementation");
        }
        // here we srt a struct, dict can not be use, so new a new struct
        public struct Histogramitems
        {
            public double value;
            public int count;
        
        }
    }
}