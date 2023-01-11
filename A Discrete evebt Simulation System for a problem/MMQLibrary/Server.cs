using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;
using MMQLibrary;

namespace RandomVariateGeneratorLibrary
{
    public class Server : DESElement
    {
        public static int indexofServer = 0;

        //series
        public Series ganttStates;
        public Series pieStates;
        public int index;
        public double busyTime = 0;
        private int clents_severed = 0;
        //public Machine my_Machine;
        bool breakDownEventGenerated = false;
        double ceaseTime;

        double ServiceTimeSum = 0;

        //static int insatnces_Count = 0;
        static Dictionary<ServerState, Color> ganntColor;

        public DiscreteEvent servicecompleteevent;

        public ServerState currentState = ServerState.None;


        public override void Draw(Graphics g, Rectangle client_Rectangle)
        {
            Brush b = new SolidBrush(Color.White);
            Pen pe = new Pen(Color.Gray);

            this.currentState = ServerState.Free;

            switch (currentState)
            {
                case ServerState.None:
                    break;
                case ServerState.Free:
                    b = new SolidBrush(Color.Green);
                    break;
                case ServerState.Busy:
                    b = new SolidBrush(Color.Pink);
                    break;
                case ServerState.Down:
                    break;
                case ServerState.Blocked:
                    break;
                default:
                    break;
            }
            //? adding block

            double length;
            Point p = new Point(Bound.X, Bound.Y);
            if (Bound.X < Bound.Y)
                length = Bound.X;
            else
                length = Bound.Y;
            Rectangle squre = new Rectangle(Bound.X, Bound.Y, Bound.Width, Bound.Height);

            //draw line to queue
            float q_X = 0;
            float q_Y = 0;
            float s_X = this.Bound.X + (float)0.5 * this.Bound.Width;
            float s_Y = this.Bound.Y + (float)0.5 * this.Bound.Height;
            if (myqueue != null)
            {
                q_X = myqueue.Bound.X + (float)0.5 * myqueue.Bound.Width;
                q_Y = myqueue.Bound.Y + (float)0.5 * myqueue.Bound.Height;
                g.DrawLine(pe, new PointF(q_X, q_Y), new PointF(s_X, s_Y));
            }

            g.FillEllipse(b, squre);
            //g.FillRectangle(b, Bound);
            SizeF size = g.MeasureString(Name, Element_Font);
            g.DrawString(Name, Element_Font, Brushes.Black, new Point((int)(Bound.X + 0.5 * (Bound.Width - size.Width)), Bound.Bottom));
        }

        public Clients clientUnderService;
        //List<Clients> client_In_Queue = new List<Clients>();
        TimedQueue myqueue;
        //public List<TimedQueue> queues;

        //int clients_Served_Count = 0;
        //int sequence_ID;

        public ServiceNode parentNode;
        //Server_State last_State;
        double last_Event_Time;
        RandomVariateGenerator serviece_Time_Genrator;
        public String Name { get; set; }
        public RandomVariateGenerator ServieceTimeGenrator { get => serviece_Time_Genrator; set => serviece_Time_Genrator = value; }
        private ContinuousRVGType service_Time_Type;

        public int Clentssevered { get => clents_severed; set => clents_severed = value; }

        public ServiceNode ParentNode { get => parentNode; set => parentNode = value; }
        public ContinuousRVGType ServiceTimeType { get => service_Time_Type; set => service_Time_Type = value; }

        public virtual void Reset()
        {
            clientUnderService = null;
            //clients_Served_Count = 0;
            ganttStates.Points.Clear();
            DataPoint dp = new DataPoint();
            dp.YValues = new double[] { 0, 0 };
            dp.XValue = 0;

            ganttStates.Points.Add(dp);

            pieStates.Points[0].YValues[0] = 0.0;
            pieStates.Points[1].YValues[0] = 0.0;
            pieStates.Points[2].YValues[0] = 0.0;
            //pie_States.Points[3].YValues[0] = 0.0;
            busyTime = 0;
            currentState = ServerState.Free;
            last_Event_Time = 0.0;


        }
        public Server(ServiceNode node) //: this(null)
        {
            indexofServer++;
            index = indexofServer;
            Name = String.Format("Server_{0:00}", index);

            if (node != null)
            {
                parentNode = node;
                myqueue = parentNode.my_Queue;
            }//test

            //series
            ganttStates = new Series();
            ganttStates.ChartType = SeriesChartType.RangeBar;
            ganttStates.CustomProperties = "DrawSideBySide = False, PointWidth = 0.5";
            pieStates = new Series();
            pieStates.ChartType = SeriesChartType.Pie;
            pieStates.Points.AddXY("Free", 0.0);// points[0] --> free
            pieStates.Points[0].Color = Color.FromArgb(160, Color.Purple);
            pieStates.Points.AddXY("Busy", 0.0);// points[1] --> busy
            pieStates.Points[1].Color = Color.FromArgb(160, Color.Red);
            pieStates.Points.AddXY("Block", 0.0);// points[1] --> busy
            pieStates.Points[2].Color = Color.FromArgb(160, Color.Yellow);
 
            servicecompleteevent = new Service_Complete_Event(this, double.NaN);
            //Reset();          
        }
        public Server()
        {

        }
        public Server(string distribution, double mean, double derivation, double L, double U, ServiceNode node)
        {
            if (node != null)
            {
                parentNode = node;
                myqueue = parentNode.my_Queue;
            }//test

            indexofServer++;
            index = indexofServer;
            Name = String.Format("Server_{0:00}", index);

            if (distribution == "Exp")
            {
                serviece_Time_Genrator = new ExponenitalRVG(mean, L, U);
                ServiceTimeType = ContinuousRVGType.Exponential;
            }
            else if (distribution == "Uni")
            {
                serviece_Time_Genrator = new UniformRVG(L, U);
                ServiceTimeType = ContinuousRVGType.Uniform;
            }
            else if (distribution == "Nor")
            {
                serviece_Time_Genrator = new Normal_RVG(mean, derivation, L, U);
                ServiceTimeType = ContinuousRVGType.Normal;
            }


            //series
            ganttStates = new Series();
            ganttStates.ChartType = SeriesChartType.RangeBar;

            pieStates = new Series();
            pieStates.ChartType = SeriesChartType.Pie;
            pieStates.Points.AddXY("Free", 0.0);// points[0] --> free
            pieStates.Points[0].Color = Color.FromArgb(160, Color.Green);
            pieStates.Points.AddXY("Busy", 0.0);// points[1] --> busy
            pieStates.Points[1].Color = Color.FromArgb(160, Color.Red);
            pieStates.Points.AddXY("Block", 0.0);// points[1] --> busy
            pieStates.Points[2].Color = Color.FromArgb(160, Color.Yellow);
            //pie_States.Points.AddXY("Down", 0.0);// points[1] --> down
            //pie_States.Points[3].Color = Color.FromArgb(160, Color.Blue);

            servicecompleteevent = new Service_Complete_Event(this, double.NaN);
        }



        public void Connect_A_Queue(TimedQueue queue)
        {
            myqueue = queue;
        }

        #region Public Of Interface Function
        public void Start_Serving_A_Clent(int server_Index, double time, Clients client)
        {
            //if (break_Down_Event_Generated == false)
            //{
            //    Greate_Break_Down_Event(time);
            //}
            //last_State = Server_State.Busy;

            // set client 
            if (client == null)
                throw new Exception();
            if (client != null)
                clientUnderService = client;
            //else
            //{
            //    int i = 0;
            //}
            //else
            //my_queue.Add(client);


            double service_Time;
            if (serviece_Time_Genrator != null)
                // generate service time by server
                service_Time = serviece_Time_Genrator.GenerateARealRandomNumber();
            else
                //generate service time by client
                service_Time = client.processing_Time_Generator[client.current_Itinerary].GenerateARealRandomNumber();

            // create service complete event
            if (clientUnderService != null)
            {
                //Discrete_Event de = new Service_Complete_Event(this, time + service_Time);
                //Service_Time_Sum += service_Time;
                //de.description = "complete";
                //de.Add_To_Simulation_Engine();

                //service_complete_event = de;
                servicecompleteevent.event_Time = time + service_Time;
                ServiceTimeSum += service_Time;
                servicecompleteevent.description = "complete";
                servicecompleteevent.Add_To_Simulation_Engine();
            }

            // 

            this.Gantt_Plotting(time);
            this.Pie_Plotting(time);
            currentState = ServerState.Busy; // free to busy

            //clents_severed++;
            //last_Event_Time = time;
        }

        public void Complete_Current_Service(double time)
        {// 統計
            //if (client_Under_Service == null) return;
            this.Gantt_Plotting(time);
            this.Pie_Plotting(time);

            currentState = ServerState.Free;

            if (clientUnderService == null)
                throw new Exception();
            if (!parentNode.Exit_A_Client(time, clientUnderService, this))
            {
                currentState = ServerState.Blocked;
                //this.Gantt_Plotting(time, last_Event_Time);
                //this.Pie_Plotting(time, last_Event_Time);
                //last_Event_Time = time;

                return;
            }
            //parent_Node.Exit_A_Client(time, client_Under_Service);
            busyTime += (time - last_Event_Time);
            currentState = ServerState.Free;

            if (myqueue.CurrentClientsinQueue == 0)
            {
                servicecompleteevent.event_Time = double.NaN;
                clientUnderService = null;
            }
            else
            {
                // start serving client from queue
                currentState = ServerState.Busy;
                clientUnderService = myqueue.Escort_A_Client(time);
                if (clientUnderService == null)
                    throw new Exception();
                this.Start_Serving_A_Clent(this.index, time, clientUnderService);
            }
            clents_severed++;

        }
        #endregion

        public string Get__Description()
        {
            double all_Time = pieStates.Points[0].YValues[0] + pieStates.Points[1].YValues[0];
            double busy_Time = pieStates.Points[1].YValues[0];

            double busy_Percentage = busy_Time / all_Time;
            Math.Round(busy_Percentage, 4);
            return $"{this.Name} ->\n   serverd {clents_severed} clients\n   busy ratio: {Math.Round(busy_Percentage, 1)}\n   average service time: {Math.Round(ServiceTimeSum / Convert.ToDouble(clents_severed), 2)}\n";
        }

        //public void Break_Down_Repair()
        //{
        //    break_Down_Event_Generated = false ;
        //}
        public void Gantt_Plotting(double Time)
        {
            double d;
            d = ganttStates.Points[ganttStates.Points.Count - 1].YValues[1];
            last_Event_Time = d;

            DataPoint dp = new DataPoint();
            dp.AxisLabel = Name;

            for (int i = 0; i < this.parentNode.Servers.Count; i++)
            {
                if (parentNode.Servers[i] == this)
                {
                    index = i + 1;
                }
            }

            dp.XValue = this.index;
            dp.YValues = new double[] { last_Event_Time, Time };

            switch (currentState)
            {
                case ServerState.None:
                    break;
                case ServerState.Free:
                    dp.Color = Color.Green;
                    break;
                case ServerState.Busy:
                    dp.Color = Color.Red;
                    break;
                case ServerState.Down:
                    {
                        dp.Color = Color.Blue;
                        breakDownEventGenerated = false;
                        break;
                    }

                case ServerState.Blocked:
                    dp.Color = Color.Yellow;
                    break;
                default:
                    break;
            }
            ganttStates.Points.Add(dp);
        }
        public void Pie_Plotting(double Time)
        {
            switch (currentState)
            {
                case ServerState.None:
                    break;
                case ServerState.Free:
                    pieStates.Points[0].YValues[0] += (Time - last_Event_Time);
                    break;
                case ServerState.Busy:
                    pieStates.Points[1].YValues[0] += (Time - last_Event_Time);
                    break;
                case ServerState.Down:
                    pieStates.Points[3].YValues[0] += (Time - last_Event_Time);
                    break;
                case ServerState.Blocked:
                    pieStates.Points[2].YValues[0] += (Time - last_Event_Time);
                    break;
                default:
                    break;

            }

        }
    }
}