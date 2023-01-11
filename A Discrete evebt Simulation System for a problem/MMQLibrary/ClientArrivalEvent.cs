using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMQLibrary;
using RandomVariateGeneratorLibrary;

namespace RandomVariateGeneratorLibrary
{
    public class Client_Arrival_Event : DiscreteEvent
    {

        public override string ToString()
        {
            return $"Client {the_Client} Arrival Event at {event_Time}";
        }
        Clients the_Client;


        public Client_Arrival_Event(Clients a_Client, double time)
        {
            the_Client = a_Client;
            event_Time = time;
        }

        public override void Process_Event()
        {
            the_Client.Enter_A_Service_Node(event_Time, null);
            the_Client_Generator.Generate_A_Client_Arrival(event_Time);// need fix 
        }
    }
}