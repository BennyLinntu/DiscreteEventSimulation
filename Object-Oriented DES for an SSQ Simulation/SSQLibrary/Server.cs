using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace SSQLibrary
{
    public class Server
    {
        static int instanceCount = 0;
        static Dictionary<ServiceState, Color> ganttColor;
        Client clientService;
        List<Client> clientQueue = new List<Client>();
        List<TimedQueue> queues;
        int clientServiceCount = 0;
        int sequenceID;
        Series gantt;
        Series pie;
        ServiceNode node;
        ServiceState laststate;
        double lastEventTime;
        RandomVariateGenerator rvg;
        ContinuousType serviceType = ContinuousType.Uniform;


        [BrowsableAttribute(false)]
        public ServiceNode Node { get => node; set => node = value; }
        [BrowsableAttribute(false)]
        public Series Gantt { get => gantt; set => gantt = value; }
        [BrowsableAttribute(false)]
        public Series Pie { get => pie; set => pie = value; }

        static Server()
        {
            ganttColor = new Dictionary<ServiceState, Color>();
            ganttColor.Add(ServiceState.Free, Color.Lime);
            ganttColor.Add(ServiceState.Busy, Color.Red);
            ganttColor.Add(ServiceState.Down, Color.Olive);

        }
        public void Reset()
        {
            clientService = null;
            Gantt.Points.Clear();
            clientServiceCount = 0;
            Pie.Points[0].YValues[0] = 0.0;
            Pie.Points[1].YValues[0] = 0.0;
            lastEventTime = 0.0;
            laststate = ServiceState.Free;
        }

        public Server(ServiceNode node = null)
        {
            this.Node = node;
            sequenceID = instanceCount;
            queues = new List<TimedQueue>();
            Gantt = new Series();
            Gantt.ChartType = SeriesChartType.RangeBar;

            Pie = new Series();
            Pie.ChartType = SeriesChartType.Pie;
            Pie.Points.AddXY("Free", 0.0);
            Pie.Points[0].Color = Color.Green;
            Pie.Points.AddXY("Busy", 0.0);
            Pie.Points[1].Color = Color.Red;

            rvg = new UniformDisCRVGenerator();
            Reset();
        }
        public void ConnectQueue(TimedQueue q)
        {
            queues.Add(q);
        }
        public void StartServiceClient(Client c, double t)
        {
            DataPoint dp = new DataPoint();
            dp.XValue = 1;
            dp.YValues = new double[] { lastEventTime, t };
            dp.Color = ganttColor[laststate];
            Gantt.Points.Add(dp);

            Pie.Points[0].YValues[0] += (t - lastEventTime);

            lastEventTime = t;
            laststate = ServiceState.Busy;
            if(clientService == null)
            {
                clientService = c;
            }
            else
            {
                clientQueue.Add(c);
            }
            double serviceTime = rvg.GetRandomNumber();
            DiscreteEvent de = new ServiceCompleteEvent(this, t + serviceTime);
            de.AddSimulationEngine();

        }

        public void CompleteCurrentService(double t)
        {
            DataPoint dp = new DataPoint();
            dp.XValue = 1;
            dp.YValues = new double[] { lastEventTime, t };
            dp.Color = ganttColor[laststate];
            Gantt.Points.Add(dp);
            Pie.Points[1].YValues[0] += (t - lastEventTime);
            bool ok = node.ExitClient(clientService, t);
            if(!ok)
            {
                lastEventTime = t;
                laststate = ServiceState.Blocked;
                return;
            }
            lastEventTime = t;
            laststate = ServiceState.Free;
            if(clientQueue.Count == 0)
            {
                clientService = null;
            }
            else
            {
                clientService = clientQueue[0];
                for (int i = 0; i < clientQueue.Count - 1; i++)
                {
                    clientQueue[i] = clientQueue[i + 1];
                }
                clientQueue.RemoveAt(clientQueue.Count - 1);
            }
            TimedQueue target = null;
            int longest = -1;
            foreach (TimedQueue tq in queues)
            {
                if(tq.TimeAveragedLength > longest)
                {
                    longest = tq.TimeAveragedLength;
                    target = tq;
                }
            }
            if (target == null) return;
            Client head = target.EscortClient(t);
            if (head == null) return;
            StartServiceClient(head, t);
        }


        public enum ServiceState
        {
            None,
            Free,
            Busy,
            Down,
            Blocked,
        }
        public enum ContinuousType
        { 
            Exponential,
            Uniform,
        }

    }
}