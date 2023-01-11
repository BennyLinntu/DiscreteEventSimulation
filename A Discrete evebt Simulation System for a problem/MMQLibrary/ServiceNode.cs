using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace RandomVariateGeneratorLibrary
{
    public class ServiceNode : DESElement
    {
        public override void Draw(Graphics g, Rectangle client_Rectangle)
        {
            Brush b = new SolidBrush(Back_Color);
            g.FillRectangle(b, Bound);
            SizeF size = g.MeasureString(Name, Element_Font);
            g.DrawString(Name, Element_Font, Brushes.Black, new Point((int)(Bound.X + 0.5 * (Bound.Width - size.Width)), Bound.Bottom));
        }

        List<Server> servers;
        List<TimedQueue> queues;
        int client_Serverd = 0;
        public TimedQueue my_Queue;// = new TimedQueue(null);
        public Series clientCountSeries;

        public static int index_of_Service_node;

        int currentClientsCount = 0;
        int exitedClientsCount;

        double queuedTimeSum = 0;
        double servedTimeSum = 0;

        public List<Server> blocked_Server_List = new List<Server>();
        public String Name { get; set; }
        public List<Server> Servers { get => servers; set => servers = value; }
        public List<TimedQueue> Queues { get => queues; set => queues = value; }
        public int ExitedClientsCount { get => exitedClientsCount; set => exitedClientsCount = value; }
        public int CurrentClientsCount { get => currentClientsCount; set => currentClientsCount = value; }
        public int ClientServerd { get => client_Serverd; set => client_Serverd = value; }

        public void Reset()
        {
            clientCountSeries.Points.Clear();
            clientCountSeries.Points.AddXY(0, 0);
            clientCountSeries.Name = Name + "_Client_Count";

            if (servers != null && queues != null)
            {
                foreach (Server s in servers) s.Reset();
                foreach (TimedQueue tq in queues) tq.Reset();
            }


            currentClientsCount = 0;
            exitedClientsCount = 0;
        }
        public ServiceNode()
        {
            index_of_Service_node++;
            //index_of_Service_node = index;
            Name = String.Format("Service_Node_{0:00}", index_of_Service_node);
            servers = new List<Server>();
            queues = new List<TimedQueue>();

            Create_Client_Count_Series();
            Back_Color = Color.LightYellow;
        }
        public ServiceNode(List<Server> servers, List<TimedQueue> queues)
        {
            //Name = $"ServiceNode=0{index}";
            this.servers = servers;
            this.queues = queues;

            Create_Client_Count_Series();
        }

        void Create_Client_Count_Series()
        {
            clientCountSeries = new Series();
            clientCountSeries.ChartType = SeriesChartType.StepLine;
            clientCountSeries.Color = Color.Red;
            clientCountSeries.BorderWidth = 2;
        }

        public bool Receive_A_Client(double time, Clients client, Server server)
        {
            TimedQueue shortest_Queue;
            // finding free server to serve
            Server free_Server = null;
            //int free_Server_index = -1;
            for (int i = 0; i < servers.Count; i++)
            {
                //if (servers[i].block_or_Not == false)
                //{
                //    if (servers[i].busy_Or_Not == false)// free server
                //    {
                //        free_Server_index = i;
                //        break;
                //    }
                //}

                //if (servers[i].current_State == Server_State.Free)
                //{
                //    free_Server = servers[i];
                //    break;
                //}

                if (servers[i].clientUnderService == null && servers[i].currentState != ServerState.Down)
                {
                    free_Server = servers[i];
                    break;
                }
            }


            if (free_Server != null)
            // has free server
            {
                client.start_serve_Time = time;
                // start serving
                free_Server.Start_Serving_A_Clent(free_Server.index, time, client);
                //if (free_Server .queues[0].the_Queue.Count == 0)
                //{                   
                //    free_Server.Start_Serving_A_Clent(free_Server.index, time, client);
                //}
                //// queue up in line
                //else
                //{
                //    free_Server.Start_Serving_A_Clent(free_Server.index, time, free_Server.queues[0].Escort_A_Client(time));
                //}
                queuedTimeSum += client.Get_Queued_Time(time);

                //clientCountSeries.Points.AddXY(time, current_Clients_Count);
                clientCountSeries.Points.AddXY(time, ++currentClientsCount);
                return true;//if no free server, queue up
            }
            else
            // no free server
            {
                //free_Server = null;
                shortest_Queue = Find_Max_Vaccancy_Queue();
                if (shortest_Queue != null)
                {// shortest queue has vaccancy
                    shortest_Queue.AddAClient(time, client);
                    client.start_queue_Time = time;

                    //clientCountSeries.Points.AddXY(time, current_Clients_Count);
                    clientCountSeries.Points.AddXY(time, ++currentClientsCount);
                    return true;
                }
                else
                {// no vacanncy
                    if (server != null)
                        blocked_Server_List.Add(server);
                    return false;
                }
            }
        }

        internal string Get_Description()
        {
            string str = "\n";
            str += ($"===[{this.Name }]===\n");
            //str += $"serverd {client_Serverd} clients\n";
            str += "[Servers]\n";

            for (int i = 0; i < servers.Count; i++)
            {
                str += servers[i].Get__Description();
                str += "\n";
            }
            str += "[Queues]\n";
            for (int i = 0; i < queues.Count; i++)
            {
                str += queues[i].Get__Description();
                str += "\n";
            }
            return str;
        }

        private TimedQueue Find_Max_Vaccancy_Queue()
        {
            //find a shortest queue to queue
            TimedQueue shortest_Queue = null;
            int maximal_Vaccancy = int.MinValue;
            //int shortest_Queue_Index = 0;
            //List<int> tmp = new List<int>();
            foreach (TimedQueue tq in queues)
            {
                int van = tq.capacity - tq.CurrentClientsinQueue;
                if (van > maximal_Vaccancy)
                {
                    shortest_Queue = tq;
                    maximal_Vaccancy = van;
                }
            }
            if (maximal_Vaccancy == 0)
            {
                return null;
            }
            else
            {
                return shortest_Queue;
            }

        }
        public bool Exit_A_Client(double time, Clients client, Server server)
        {

            // check whether the client has next service node to visit
            bool is_Client_Exit = client.Exit_A_Service_Node(time, server);

            if (is_Client_Exit == false)
            {
                // fail to leave the service node
                return false;
            }
            else
            {
                // client leaved
                clientCountSeries.Points.AddXY(time, --currentClientsCount);
            }


            servedTimeSum += client.Get_Served_Time(time);
            exitedClientsCount++;

            if (blocked_Server_List.Count != 0)
            {// blocked server send client to this node
                blocked_Server_List[0].Complete_Current_Service(time);
                blocked_Server_List.RemoveAt(0);
            }

            client_Serverd++;
            return true;
        }

        public string Get__Description()
        {
            return //$"Service Node{index } -> \n" +
                $"average queued time: {Math.Round(queuedTimeSum / Convert.ToDouble(exitedClientsCount), 2) } \n" +
                $"average served time: {Math.Round(servedTimeSum / Convert.ToDouble(exitedClientsCount), 2) } \n";
            //$"    average queue time: {}";
        }
    }
}