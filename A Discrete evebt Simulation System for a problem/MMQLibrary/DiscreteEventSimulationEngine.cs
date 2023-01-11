using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;
using MMQLibrary;

namespace RandomVariateGeneratorLibrary
{
    public class DESEngine
    {
        // event time sorted in increasing order
        List<DiscreteEvent> future_Event_List = new List<DiscreteEvent>();
        public int current_Event_Count { get => future_Event_List.Count; }
        double simulation_Clock;
        public int current_Client_In_Node = 0;
        public int previous_Client_In_Node = 0;
        public double last_Event_Time;

        //static public step_line step_line_Chart = new step_line();
        ClientGenerator client_Generator;
        List<ServiceNode> list_Of_service_Node;
        public double SimulationClock { get => simulation_Clock; }
        public ClientGenerator Client_Generator { get => client_Generator; set => client_Generator = value; }

        public DESEngine(ClientGenerator client_Generator, List<ServiceNode> List_Of_service_Node)
        {
            DiscreteEvent.Set_Engine(this);
            current_Client_In_Node = 0;
            previous_Client_In_Node = 0;

            this.client_Generator = client_Generator;
            this.list_Of_service_Node = List_Of_service_Node;
        }



        public DESEngine()
        {
        }

        internal void Insert_An_Event(DiscreteEvent an_Event)
        {
            future_Event_List.Add(an_Event);
            //sorting
            int position = 0;
            for (int i = 0; i < future_Event_List.Count; i++)
            {
                // sort by incoming time
                if (an_Event.Event_Time < future_Event_List[i].Event_Time)
                {
                    position = i;

                    future_Event_List.Insert(i, an_Event);
                    future_Event_List.RemoveAt(future_Event_List.Count - 1);
                    return;
                }
            }
        }

        public bool Remove_An_Event(DiscreteEvent de)
        {
            return future_Event_List.Remove(de);
        }
        public void Reset()
        {
            simulation_Clock = 0;
        }

        public bool Run_Next_Event()
        {
            if (future_Event_List.Count == 0) return false;
            DiscreteEvent head_Event = future_Event_List[0];

            // plotting gannt, pie
            //for (int j = 0; j < list_Of_list_Of_Server.Count; j++)
            //{
            //    for (int i = 0; i < list_Of_list_Of_Server[j].Count; i++)
            //    {
            //        Server s;
            //        s = list_Of_list_Of_Server[j][i];
            //        //s.Gantt_Plotting(head_Event.Event_Time, last_Event_Time);
            //        //s.Pie_Plotting(head_Event.Event_Time, last_Event_Time);
            //    }
            //}                      
            future_Event_List.RemoveAt(0);
            simulation_Clock = head_Event.Event_Time;
            head_Event.Process_Event();
            // examing blocked server
            //for (int i = 0; i < list_Of_service_Node.Count; i++)
            //{
            //    for (int j = 0; j < list_Of_service_Node[i].blocked_Server_List.Count; j++)
            //    {
            //        list_Of_service_Node[i].blocked_Server_List[j].Complete_Current_Service(head_Event.Event_Time);
            //    }              
            //}

            last_Event_Time = head_Event.Event_Time;
            return true;
        }

        public void Run_To_End()
        {
            do
            {
                Run_Next_Event();
            } while (future_Event_List.Count != 0 || simulation_Clock == 0);
        }

        public string Get_Description()
        {
            string str = $"Simulation end at {Math.Round(simulation_Clock, 2) }\n";
            str += client_Generator.GetDescription();
            //str += service_Node.GetDescription();
            for (int i = 0; i < list_Of_service_Node.Count; i++)
            {
                str += list_Of_service_Node[i].Get_Description();
            }

            return str;
        }

        //public Series Get_Step_Line()
        //{
        //    return step_line_Chart.creat_series();
        //}

        public double Get_Last_Event_Time()
        {
            return last_Event_Time;
        }
    }
}