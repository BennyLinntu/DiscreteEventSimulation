using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace SSQLibrary
{
    public class DESModel
    {
        static List<Server> listofServer;
        static List<TimedQueue> listofQueue;

        
        public static DESModel Create()
        {
            listofServer = new List<Server>();
            Server s = new Server();
            listofServer.Add(s);

            listofQueue = new List<TimedQueue>();
            TimedQueue queue = new TimedQueue();
            listofQueue.Add(queue);

            ServiceNode sn = new ServiceNode(listofServer, listofQueue);
            s.Node = sn;
            s.ConnectQueue(queue);

            List<ServiceNode> nodes = new List<ServiceNode>();
            nodes.Add(sn);

            List<ServiceNode>[] itinera = new List<ServiceNode>[] { new List<ServiceNode>() };
            itinera[0].Add(sn);
            double[] p = new double[] { 100 };
            return new DESModel(nodes, itinera, p);
        }

        List<ServiceNode> nodes = new List<ServiceNode>();
        List<ServiceNode>[] i;
        ClientGenerator clientGenerator;
        Server s;
        TimedQueue queue;
        DESEngine engine;
        [Category("Client Generator")]
        public ClientGenerator TheClientGenerator { get => clientGenerator;}
        [BrowsableAttribute(false)]
        public DESEngine Engine { get => engine; }
        [Category("Model")]
        public List<ServiceNode> Nodes { get => nodes;}

        public DESModel(List<ServiceNode>nodes, List<ServiceNode>[] i, double[]p)
        {
            this.nodes = nodes;
            this.i = i;
            clientGenerator = new ClientGenerator(i, p);
            s = new Server();
            queue = new TimedQueue();
            engine = new DESEngine();
            this.engine = new DESEngine();
        }

        public void ResetSimulation()
        {
            foreach (ServiceNode sn in Nodes)
            {
                sn.Reset();
            }
            engine.Reset();
            clientGenerator.GenerateClientArrival(engine.SimulateClock);
        }

        public void RunOneEvent()
        {
            engine.RunNextEvent();
        }
        public void RunAllEvent()
        {
            engine.RunEnd();
        }

        public List<Server> GetAllServer()
        {
            return listofServer;
        }
        public List<TimedQueue> GetAllQueue()
        {
            return listofQueue;
        }



    }
}