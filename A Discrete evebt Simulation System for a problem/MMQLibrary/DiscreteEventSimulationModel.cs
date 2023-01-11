using MMQLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Text;

namespace RandomVariateGeneratorLibrary
{
    public class theDESModel
    {

        private List<ServiceNode> listOfServiceNode; //new List<ServiceNode>();
        private List<Itinerary> itineraries = new List<Itinerary>();

        RandomVariateGenerator servieceTimeGenrator;
        List<List<RandomVariateGenerator>> processingTimeGenerator;

        public ClientGenerator clientGenerator;

        static ServiceNode serviceNodeClientStation;
        static ServiceNode serviceNodeBankStation;
        static ServiceNode serviceNodeFastFoodStation;
        //static ServiceNode serviceNodeClientStation;
        //static ServiceNode serviceNodeClientStation;
        //Server server;
        //TimedQueue queue;

        static DESEngine simulationEngine;
        [Category("Data")]

        public double MaximalCeaseTime
        {
            get
            {
                return clientGenerator.CeaseTime;
            }
        }

        #region Class-Scope items


        public theDESModel CreatASSQModel(double Cease_Time)
        {
            //list_Of_List_Of_Servers = new List<List<Server>>();
            //list_Of_list_Of_Queues = new List<List<TimedQueue>>();

            //washing station
            List<Server> ListOfServers = new List<Server>();
            List<TimedQueue> ListOfQueues = new List<TimedQueue>();
            TimedQueue q = new TimedQueue(serviceNodeClientStation);
            q.Name = "Defined queue 1";
            q.parent_Node = serviceNodeClientStation;
            q.capacity = 10;
            ListOfQueues.Add(q);
            Machine s = new Machine("Nor", 1, 0.5, 0.1, 5, null);
            //s.parent_Node = serviceNodeClientStation;
            s.Name = "Defined machine 1";
            s.Connect_A_Queue(q);
            ListOfServers.Add(s);
            serviceNodeClientStation = new ServiceNode(ListOfServers, ListOfQueues);
            serviceNodeClientStation.Name = "<<<Defined Client>>>";
            serviceNodeClientStation.Servers[0].parentNode = serviceNodeClientStation;

            //Pression station
            ListOfServers = new List<Server>();
            ListOfQueues = new List<TimedQueue>();
            for (int i = 1; i < 4; i++)
            {
                q = new TimedQueue(serviceNodeBankStation);
                q.Name = $"Queues Count: {i}";
                q.parent_Node = serviceNodeBankStation;
                q.capacity = 9 - i;
                ListOfQueues.Add(q);

                s = new Machine(serviceNodeBankStation);
                s.Name = $"Server: Clerk {i}";
                s.parentNode = serviceNodeBankStation;
                s.Connect_A_Queue(q);
                ListOfServers.Add(s);
            }
            serviceNodeBankStation = new ServiceNode(ListOfServers, ListOfQueues);
            serviceNodeBankStation.Name = "<<< Service Node: Bank >>>";
            for (int i = 0; i < serviceNodeBankStation.Servers.Count; i++)
            {
                serviceNodeBankStation.Servers[i].parentNode = serviceNodeBankStation;
            }
            //list_Of_List_Of_Servers.Add(ListOfServers); //ListOfServers.Clear();
            //list_Of_list_Of_Queues.Add(ListOfQueues); //ListOfQueues.Clear();


            //Assembly_Station
            ListOfServers = new List<Server>();
            ListOfQueues = new List<TimedQueue>();
            q = new TimedQueue(serviceNodeFastFoodStation);
            q.Name = $"Queues Count: ";
            q.parent_Node = serviceNodeFastFoodStation;
            q.capacity = 9;
            q.Is_A_Priority_Queue = true;
            ListOfQueues.Add(q);
            for (int i = 1; i < 3; i++)
            {
                s = new Machine(serviceNodeFastFoodStation);
                s.Name = $"Server: Teller  {i}";
                s.parentNode = serviceNodeFastFoodStation;
                s.Connect_A_Queue(q);
                ListOfServers.Add(s);
            }
            serviceNodeFastFoodStation = new ServiceNode(ListOfServers, ListOfQueues);
            serviceNodeFastFoodStation.Name = "<<< Service Node: Fast Food Shop >>>";
            for (int i = 0; i < serviceNodeFastFoodStation.Servers.Count; i++)
            {
                serviceNodeFastFoodStation.Servers[i].parentNode = serviceNodeFastFoodStation;
            }
            //list_Of_List_Of_Servers.Add(ListOfServers); //ListOfServers.Clear();
            //list_Of_list_Of_Queues.Add(ListOfQueues); //ListOfQueues.Clear();


            listOfServiceNode = new List<ServiceNode>();
            listOfServiceNode.Add(serviceNodeClientStation);
            listOfServiceNode.Add(serviceNodeBankStation);
            listOfServiceNode.Add(serviceNodeFastFoodStation);


            Itinerary itinerary_A = new Itinerary();
            Itinerary itinerary_B = new Itinerary();
            itinerary_A.my_itineraries.Add(serviceNodeClientStation);
            itinerary_A.my_itineraries.Add(serviceNodeBankStation);
            itinerary_A.my_itineraries.Add(serviceNodeFastFoodStation);

            itinerary_B.my_itineraries.Add(serviceNodeClientStation);
            itinerary_B.my_itineraries.Add(serviceNodeBankStation);
            itinerary_B.my_itineraries.Add(serviceNodeClientStation);
            itinerary_B.my_itineraries.Add(serviceNodeFastFoodStation);

            itinerary_A.probability = 0.3;
            itinerary_B.probability = 0.7;

            itinerary_A.priority = 1;
            itinerary_B.priority = 0;

            List<RandomVariateGenerator> l = new List<RandomVariateGenerator>();
            ExponenitalRVG e1 = new ExponenitalRVG(8, 0, 1);
            ExponenitalRVG e2 = new ExponenitalRVG(5.5, 0, 1);
            l.Add(null); l.Add(e1); l.Add(e2);
            itinerary_A.processing_Time_Generator = l;

            l = new List<RandomVariateGenerator>();
            e1 = new ExponenitalRVG(6, 0, 1);
            e2 = new ExponenitalRVG(4.5, 0, 1);
            l.Add(null); l.Add(e1); l.Add(null); l.Add(e2);
            itinerary_B.processing_Time_Generator = l;

            itineraries.Add(itinerary_A);
            itineraries.Add(itinerary_B);


            theDESModel the_Model;
            the_Model = new theDESModel(listOfServiceNode, itineraries);
            return the_Model;

        }

        public theDESModel Creat_A_Empty_Model()
        {
            //list_Of_List_Of_Servers = new List<List<Server>>();
            //list_Of_list_Of_Queues = new List<List<TimedQueue>>();

            List<ServiceNode> nodes = new List<ServiceNode>();
            List<Itinerary> itineraries = new List<Itinerary>();
            theDESModel the_Model;
            the_Model = new theDESModel(nodes, itineraries);
            return the_Model;

        }

        public List<ServiceNode> Get_All_Service_Node()
        {
            return listOfServiceNode;
        }
        #endregion



        #region Properties
        [Category("Data")]
        public double SimulationClock { get => simulationEngine.SimulationClock; }
        //public ClientGenerator ClientGenerator { get => client_Generator;}
        [Category("Data")]
        public DESEngine SimulationEngine { get => simulationEngine; }

        [Editor(typeof(DES_Collection_Element_Editor), typeof(UITypeEditor))]
        [Category("Data")]
        public List<ServiceNode> Nodes { get => listOfServiceNode; set => listOfServiceNode = value; }
        [Category("Data")]
        public List<DESElement> Elements { get => allElement; }
        [Category("Data")]
        public ClientGenerator ClientGenerator { get => clientGenerator; set => clientGenerator = value; }
        [Category("Data")]
        public List<Itinerary> Itineraries { get => itineraries; set => itineraries = value; }
        [Category("Data")]
        public List<ServiceNode> ListOfServiceNode { get => listOfServiceNode; set => listOfServiceNode = value; }

        List<DESElement> allElement = new List<DESElement>();

        #endregion
        public theDESModel(List<ServiceNode> nodes, List<Itinerary> itineraries)
        {
            //this.maximal_Cease_Time = cease_Time;
            this.listOfServiceNode = nodes;
            this.itineraries = itineraries;



            clientGenerator = new ClientGenerator(itineraries);

            //client_Generator.numberOfClients = numberOfClients;

            //server = new Server("",0,0,1,0,null);
            //queue = new TimedQueue(null);
            simulationEngine = new DESEngine(ClientGenerator, listOfServiceNode);

            DiscreteEvent.the_Model = this;
        }

        public theDESModel(List<Itinerary> itineraries = null)
        {
            simulationEngine = new DESEngine();
            this.itineraries = itineraries;
        }

        public string Get_Description()
        {
            string str = "";
            str += "<<< Processing Result >>>\n";
            //str+="simulation ended in {}"
            str += simulationEngine.Get_Description();
            str += "<<< End Result >>>\n";
            return str;
        }

        public void Reset_Simulation()
        {
            foreach (ServiceNode sn in listOfServiceNode) sn.Reset();
            simulationEngine.Reset();
            clientGenerator.Generate_A_Client_Arrival(simulationEngine.SimulationClock);
        }

        public void Run_One_Event()
        {
            simulationEngine.Run_Next_Event();
        }

        public void RunToEnd()
        {
            simulationEngine.Run_To_End();
        }

    }
}