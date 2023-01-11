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
        public override double NextDouble()
        {
            return randomizer.NextDouble();
        }
    }
}