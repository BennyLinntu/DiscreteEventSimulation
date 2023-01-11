using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace SSQLibrary
{
    public class DESimulationModel
    {

        // data fileds
        // service network
        List<ServiceNode> nodes = new List<ServiceNode>();
        List<ClientGenerator> generators = new List<ClientGenerator>();
        List<DiscreteEvent> futureEvents = new List<DiscreteEvent>();
        double clockTime = 0;
        // properties
        [Category("Parameter")]
        public List<ServiceNode> Nodes { get => nodes;}
        [Category("Parameter")]
        public List<ClientGenerator> Generators { get => generators;}
        [Category("Parameter")]
        public List<DiscreteEvent> FutureEvents { get => futureEvents;}
        [Category("Parameter")]
        public double ClockTime { get => clockTime;}


        // functions
        // static utility functions to create benchmark models

        static public DESimulationModel CreateAnSSQModel() // here we create an SSQ model
        {
            DESimulationModel des = new DESimulationModel(); // new a DESimulation
            ServiceNode sn = new ServiceNode(); // here we new a service node
            //Client= sn;  // give the Servicenode to the Client' SSQnode
            TimedQueue q = new TimedQueue();  // a new queue
            Server s = new Server();  // a new server
            sn.AddAServer(s);  // add a server to the service node
            sn.AddAQueue(q); // add a queue to the service node
            sn.AssignAQueueToAServer(0, 0); 
            des.AddAServiceNode(sn);  // here we add a node
            sn.ClientInNodes.QueueSeries.Color = Color.Red;
            return des;
        }
        public string GetFutrueEventInfo()
        {
            StringBuilder sb = new StringBuilder();
            foreach (DiscreteEvent de in futureEvents)
            {
                sb.AppendLine(de.ToString());
            }
            return sb.ToString();
        }




        public void AddAServiceNode(ServiceNode serviceNode)  // here we give the service node to DES model
        {
            nodes.Add(serviceNode);
        }

        public void SetGanttSeries(Chart chart, int areaID)
        {
            foreach (ServiceNode sn in nodes)  // here we set the serviceNode's chart, and it's series type.
            {
                sn.SetGanttSeries(chart, areaID);
            }
        }

        public void SetCountSeries(Chart chart, int areaID)  // here we input chart, and the position
        {
            foreach (ServiceNode sn in nodes)
            {
                sn.SetCountSeries(chart, areaID);
            }
        }



        public bool InSertAnEvent(DiscreteEvent discreteEvent)
        {
            //int pos;
            //for (pos = 0; pos < futureEvents.Count; pos++)
            //{
            //    if(discreteEvent.eventTime < futureEvents[pos].eventTime)
            //    {

            //        break;
            //    }
            //}
            //futureEvents.Insert(pos, discreteEvent);

            for (int i = 0; i <= futureEvents.Count; i++)
            {
                if(futureEvents.Count == 0 || discreteEvent.EventTime < futureEvents[i].EventTime)
                {
                    futureEvents.Insert(i, discreteEvent);
                    break;
                }
                else if(discreteEvent.EventTime >= futureEvents[i].EventTime && i == futureEvents.Count -1)
                {
                    futureEvents.Add(discreteEvent);
                    break;
                }
            }
            return true;
        }




        public void Reset()
        {
            clockTime = 0; // here let the clock time be 0
            foreach (ServiceNode sn in nodes) sn.Reset();  // reset the service nodes
            // empty the event queue
            futureEvents.Clear(); // clear the Discrete event
            // ask eachu generator gnerate the first event
            if(generators.Count == 0)
            {
                ClientGenerator c = new ClientGenerator();
                generators.Add(c);
            }
            foreach (ClientGenerator cg in generators)
            {
                cg.Reset(); // here reset the Client Generator
                cg.GenerateAClient(0, nodes[0]);
                
            }

        }

        public bool RunNextEvent()
        {
            // Remove head event and process it.
            if (futureEvents.Count == 0) return false; // if here is no event' next, return false
            DiscreteEvent head = futureEvents[0];  // let the next event record to the head
            futureEvents.RemoveAt(0); // after recor, then remove it
            clockTime = head.EventTime; // head event' time to become the clock Time
            bool result = head.ProcessEvent();
            return result;

        }
        public void RunToEnd()
        {
            while (RunNextEvent());
        }


        public DESimulationModel()
        {
            //ClientGenerator cg = new ClientGenerator(); // here we new a new ClientGenerator
            //generators.Add(cg);  // list of client generators add a new client generator

            // set engine of Discrete Event
            DiscreteEvent.engine = this;    // we let the this DESimulation to be Discrete Event' engine;
        }
    }
}