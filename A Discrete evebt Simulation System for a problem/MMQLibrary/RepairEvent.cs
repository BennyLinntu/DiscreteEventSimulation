using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomVariateGeneratorLibrary
{
    public class Repair_Event : DiscreteEvent
    {
        // public double event_Time;
        Machine the_Machine;
        public Repair_Event(Machine m, double time)
        {
            the_Machine = m;
            event_Time = time;
        }
        public override void Process_Event()
        {
            //the_Machine.parent_Server.
            the_Machine.Return_Form_Repair(event_Time);
        }
    }
}