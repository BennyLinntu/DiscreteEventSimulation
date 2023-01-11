using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSQLibrary
{
    public class DiscreteEvent
    {
        public static DESimulationModel engine;


        double eventTime = 0;

        public double EventTime { get => eventTime; set => eventTime = value; }

        public virtual bool ProcessEvent()
        {
            throw new NotImplementedException();
        }
        public void AddToSimulationModel()
        {
            engine.InSertAnEvent(this);
        }
        public override string ToString()
        {
            return $"Event Generator with Arrival & Complete";
        }
    }


    public class ArrivalEvent : DiscreteEvent
    {
        ClientGenerator Generator;
        Client client;
        ServiceNode node;

        public ArrivalEvent(double time, ClientGenerator generator, Client c, ServiceNode n)
        {
            EventTime = time;
            Generator = generator;
            client = c;
            node = n;
        }

        public ServiceNode Node { get => node; set => node = value; }
        public Client Client { get => client; set => client = value; }

        public override bool ProcessEvent()
        {
            client.EnterFirstNode(EventTime, node); 
            // Generate next arrival event
            Generator.GenerateAClient(EventTime, node);
            return true;
        }

        public override string ToString()
        {
            return $"Arrival:{EventTime:0.00}";
        }

    }

    public class ServiceCompleteEvent : DiscreteEvent
    {

        public Server Server;
        public ServiceCompleteEvent(double time, Server server)
        {
            EventTime = time;
            Server = server;

        }
        public override bool ProcessEvent()
        {
            Server.CompleteCurrentService(EventTime);

            return true;
        }
        public override string ToString()
        {
            return $"Complete time:{EventTime:0.00}";
        }


    }
}