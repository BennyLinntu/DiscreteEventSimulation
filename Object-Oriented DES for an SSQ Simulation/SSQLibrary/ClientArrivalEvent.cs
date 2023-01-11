using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SSQLibrary
{
    public class ClientArrivalEvent : DiscreteEvent
    {
        Client c;
        public ClientArrivalEvent(Client c, double t)
        {
            this.c = c;
            eventTime = t;
            
        }
        public override void ProcessEvent()
        {
            c.EnterNextServiceNode(eventTime);
            client.GenerateClientArrival(eventTime);
        }



    }

}
