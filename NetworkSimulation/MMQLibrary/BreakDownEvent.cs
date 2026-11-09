using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomVariateGeneratorLibrary
{

    public class BreakDownEvent : DiscreteEvent
    {
        Machine the_Machine;
        public BreakDownEvent(Machine m, double time) : base()
        {
            the_Machine = m;
            event_Time = time;
        }

        public override void Process_Event()
        {
            // turn machine to break down
            the_Machine.Turn_To_Break_Down(event_Time);
            // gnerate repair time
        }
    }
}