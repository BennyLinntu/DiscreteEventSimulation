using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SSQLibrary
{
    public class ServiceCompleteEvent : DiscreteEvent
    {
        Server server;


        public ServiceCompleteEvent(Server s, double t)
        {
            server = s;
            eventTime = t;
        }
        public override void ProcessEvent()
        {
            server.CompleteCurrentService(eventTime);
        }

    }
}