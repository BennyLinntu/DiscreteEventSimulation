using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomVariateGeneratorLibrary
{
    public class Service_Complete_Event : DiscreteEvent
    {

        Server the_Server;
        public Service_Complete_Event(Server server, double time)
        {
            the_Server = server;
            event_Time = time;
        }

        public override void Process_Event()
        {
            if (the_Server.clientUnderService != null)
            {
                the_Server.Complete_Current_Service(event_Time);
            }
            //the_Server.Complete_Current_Service(event_Time);
        }
    }
}