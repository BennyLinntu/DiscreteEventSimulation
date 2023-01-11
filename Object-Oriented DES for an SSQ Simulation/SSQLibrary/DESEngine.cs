using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSQLibrary
{
    public class DESEngine
    {
        List<DiscreteEvent> f = new List<DiscreteEvent>();
        double simulateClock;

        public double SimulateClock { get => simulateClock;}

        public DESEngine()
        {
            DiscreteEvent.SetEngine(this);
        }

        internal void InsertEvent(DiscreteEvent de)
        {
            int position = 0;
            for (int i = 0; i < f.Count; i++)
            {
                if(de.eventTime <= f[i].eventTime)
                {
                    position = i;
                    f.Insert(i, de);
                    return;
                }
            }
            f.Add(de);
        }
        public void Reset()
        {
            f.Clear();
            simulateClock = 0;
        }

        public bool RunNextEvent()
        {
            if (f.Count == 0) return false;
            DiscreteEvent headevent = f[0];
            f.RemoveAt(0);
            simulateClock = headevent.eventTime;
            headevent.ProcessEvent();
            return true;

        }


        public void RunEnd()
        {
            do
            {
                RunNextEvent();
            } while (f.Count != 0);
        }


    }
}
