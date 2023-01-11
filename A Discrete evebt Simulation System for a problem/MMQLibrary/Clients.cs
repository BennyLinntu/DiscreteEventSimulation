using MMQLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace RandomVariateGeneratorLibrary
{
    public class Clients
    {
        double birth_Time;
        public double start_serve_Time;
        public double start_queue_Time;
        public Server current_Server;
        Series step_Line;
        public TimedQueue my_Queue; //= new TimedQueue(null);

        Client_State current_State = Client_State.None;

        //ulgkg

        List<ServiceNode> my_itinerary;
        public int current_Itinerary = -1;
        public double serving_Priority;

        public List<RandomVariateGenerator> processing_Time_Generator;// = new List<RandomVariateGenerator>();
        public Clients(double birth_Time, Itinerary itinerary)
        {
            this.my_itinerary = itinerary.my_itineraries;
            this.birth_Time = birth_Time;
            this.processing_Time_Generator = itinerary.processing_Time_Generator;
            this.serving_Priority = itinerary.priority;
            step_Line = new Series();
            step_Line.ChartType = SeriesChartType.StepLine;
            //DataPoint dp = new DataPoint();

        }

        public Clients(double birth_Time)
        {
            this.birth_Time = birth_Time;
            step_Line = new Series();
            step_Line.ChartType = SeriesChartType.StepLine;
            //DataPoint dp = new DataPoint();

        }
        public bool Enter_A_Service_Node(double event_time, Server server)
        {
            // update gantt
            current_Itinerary++;
            if (my_itinerary.Count <= current_Itinerary)
                return true;//Process finish, leave the model   

            //next service node is block!
            bool next_Node_Receive = my_itinerary[current_Itinerary].Receive_A_Client(event_time, this, server);
            //bool next_Queue_Add = my_Queue.Add_A_Client(event_time, this);

            if (next_Node_Receive == false)
            {
                return false;
            }
            return true;
        }
        public bool Block_In_Service_Node(double time)
        {
            return false;
        }

        public bool Exit_A_Service_Node(double time, Server server)
        {
            // checking whether there is a next node to visit
            // if this is the last node, update statistic and return ok

            //my_Queue.Escort_A_Client(time);
            if (Enter_A_Service_Node(time, server))
                return true; // finish process or into next station
            else
                return false;
        }

        public double Get_Queued_Time(double time)
        {
            return (start_queue_Time - time);
        }

        public double Get_Served_Time(double time)
        {
            return (start_serve_Time - time);
        }
    }
}