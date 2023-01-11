using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SSQLibrary
{
    public class BuffonNeedleTipCRVGenerator : ContinuousRandomVariateGenerator
    {
        int needleLength;
        public BuffonNeedleTipCRVGenerator()
        {

        }
        protected override double NextDouble()
        {
            return randomizer.NextDouble();
        }
    }
}