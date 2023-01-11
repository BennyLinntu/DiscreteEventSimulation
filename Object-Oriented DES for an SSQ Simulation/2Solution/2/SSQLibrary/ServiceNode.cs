using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace SSQLibrary
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class ServiceNode
    {
        // data fields
        List<Server> servers = new List<Server>(); // here is List of Servers
        List<TimedQueue> queues = new List<TimedQueue>(); // here is a list of queues
        TimedQueue ClientInNode = new TimedQueue(); 

        // properties
        public int CurrentClientCount
        {
            get => ClientInNode.ClientCount;
        }


        public double AverageClientCount
        {
            get => ClientInNode.TimeAverageLength;
        }
        public Series ClientCountSeries
        {
            get => ClientInNode.QueueSeries;
        }
        public List<Server> Servers { get => servers; }
        public List<TimedQueue> Queues { get => queues;}
        public TimedQueue ClientInNodes { get => ClientInNode; set => ClientInNode = value; }


        // functions

        public void AssignAQueueToAServer(int queueId, int serverId) // here means input the postion of queue, and server
        {
            servers[serverId].TheQueue = queues[queueId];  // TheQueue means the Time Queue, here means let here's queues give it to the list' queue
        }




        public void SetGanttSeries(Chart chart, int areaID)  // here we set the gantt chart Series
        {
            for (int i = 0; i < servers.Count; i++)
            {
                chart.Series.Add(servers[i].GanttSeries);  // here we add a gantt Series
                servers[i].GanttSeries.ChartArea = chart.ChartAreas[areaID].Name;

            }
        }

        public void AddAQueue(TimedQueue q)
        {
            queues.Add(q);
        }

        public void AddAServer(Server s)  // here is functions that let the make the Server to the list of Server.
        {
            s.Parent = this;
            servers.Add(s);
        }

        public void SetCountSeries(Chart chart, int areaID)
        {
            chart.Series.Add(ClientInNode.QueueSeries);
            ClientInNode.QueueSeries.ChartArea = chart.ChartAreas[areaID].Name;
            for (int i = 0; i < queues.Count; i++)
            {
                chart.Series.Add(queues[i].QueueSeries);
                queues[i].QueueSeries.ChartArea = chart.ChartAreas[areaID].Name;

            }
        }



        public bool ReceiveAClient(Client client, double time)
        {
            // check whether this node can receiver the client
            

            // if this node has vacancy for the client
            ClientInNode.EnQueue(client, time);
            // check free servers and randomly select one if more than one server is free
            // here we parameter the code that the others, tells me.
            int x = 0;
            foreach (var s in servers)
            {
                if (s.IsFree)
                {
                    s.ServerAClient(client, time);
                    break;
                }
                x++;
            }
            if (x >= servers.Count)
            {
                int id = 0;
                int length = int.MaxValue;
                for (int i = 0; i < queues.Count; i++)
                {
                    if(queues[i].LengthofCurrentQueue < length)
                    {
                        length = queues[i].LengthofCurrentQueue;
                        id = i;
                    }
                }
                bool s = queues[id].EnQueue(client, time);
                if (!s) return false;
            }
            //else
            //{
            //    // select shortest queue for the client
            //    TimedQueue shortestQueue = null;
            //    // loop through all queues find shortest queues, randomly select o
            //    double length = int.MaxValue;
            //    for (int i = 0; i < queues.Count; i++)
            //    {
            //        if(queues[i].TimeAverageLength < length)
            //        {
            //            length = queues[i].TimeAverageLength;
            //        }
            //    }
            //    //......
            //    shortestQueue = queues[0];
            //    if (shortestQueue != null) shortestQueue.EnQueue(client, time);
            //}
            return true;
        }

        public bool ExpelAClient(Client client, double time)
        {
            ClientInNode.RemoveAClient(client, time);
            return true;
        }

        public void Reset()
        {
            foreach (var s in servers) s.Reset();
            foreach (var q in queues) q.Reset();
            ClientInNode.Reset();

        }


    }
}