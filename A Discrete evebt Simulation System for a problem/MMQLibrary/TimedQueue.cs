using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace RandomVariateGeneratorLibrary
{
    public class TimedQueue : DESElement
    {
        static int index = 0;
        //static int instance_Count = 0;
        string name;

        private List<Clients> the_Queue = new List<Clients>();
        // int index = 0;
        public int capacity = int.MaxValue;
        public Series seriesQueue = new Series();
        public ServiceNode parent_Node;
        //static int index=0;
        public bool Is_A_Priority_Queue { get; set; } = false;
        int maximumClientsinQueue = 0;
        int current_Clients_in_Queue = 0;
        int client_Queued = 0;
        int clien_Exit = 0;

        Random rnd;
        public TimedQueue(ServiceNode node)
        {
            if (node != null)
                this.parent_Node = node;

            index++;
            Name = String.Format("Queue_{0:00}", index);
            //Name = $"Queue_0{index}";
            seriesQueue.Name = Name;
            seriesQueue.ChartType = SeriesChartType.StepLine;
            rnd = new Random(index);
            //double p = rnd.NextDouble();
            seriesQueue.Color = Color.FromArgb(Convert.ToInt32(255 * rnd.NextDouble()), Convert.ToInt32(255 * rnd.NextDouble()), Convert.ToInt32(25 * rnd.NextDouble()));
            seriesQueue.BorderWidth = 2;
            //series_Queue.ChartArea = "ChartArea2";
            //series_Queue.LegendText = Name;
        }

        public override void Draw(Graphics g, Rectangle client_Rectangle)
        {
            Brush b = new SolidBrush(Color.LightBlue);

            double length;
            Point p = new Point(Bound.X, Bound.Y);
            if (Bound.X < Bound.Y)
                length = Bound.X;
            else
                length = Bound.Y;
            Rectangle squre = new Rectangle(Bound.X, Bound.Y, Bound.Width, Bound.Height);


            g.FillRectangle(b, squre);
            //g.FillRectangle(b, Bound);
            SizeF size = g.MeasureString(Name, Element_Font);
            g.DrawString(Name, Element_Font, Brushes.Black, new Point((int)(Bound.X + 0.5 * (Bound.Width - size.Width)), Bound.Bottom));
        }

        public void Reset()
        {
            the_Queue.Clear();
            seriesQueue.Points.Clear();
            maximumClientsinQueue = 0;
            client_Queued = 0;
            clien_Exit = 0;

            seriesQueue.Points.AddXY(0, 0);
        }
        public int Capacity
        {
            get => capacity;
            set
            {
                if (value != capacity && value > 0)
                    capacity = value;
            }
        }

        public double TimeAverageLength
        {
            get
            { return 0; }
        }

        public int MaxCount { get => maximumClientsinQueue; }

        [Browsable(false)]
        public Series SeriesClients { get => seriesQueue; }
        public string Name { get; set; }
        public int CurrentClientsinQueue { get => current_Clients_in_Queue; set => current_Clients_in_Queue = value; }
        public int ClientQueued { get => client_Queued; set => client_Queued = value; }

        public bool AddAClient(double time, Clients the_Client)
        {

            if (current_Clients_in_Queue == capacity)
                return false;

            //the_Client.start_queue_Time(time);
            if (Is_A_Priority_Queue == true)
            {
                int pos = the_Queue.Count;
                for (int i = 0; i < the_Queue.Count; i++)
                {
                    if (the_Queue[i].serving_Priority < the_Client.serving_Priority)
                    {
                        pos = i;

                    }
                }
                the_Queue.Insert(pos, the_Client);
            }
            else
                the_Queue.Add(the_Client);
            client_Queued++;

            ++current_Clients_in_Queue;

            if (maximumClientsinQueue < current_Clients_in_Queue)
                maximumClientsinQueue = current_Clients_in_Queue;

            SeriesClients.Points.AddXY(time, current_Clients_in_Queue);
            return true;
        }

        public string Get__Description()
        {
            return $"{this.Name} -> \n" +
                $"    maximum {maximumClientsinQueue} clients in this queue\n" +
                $"    queued {client_Queued} clients\n";
            //$"    average queue time: {}";
        }

        public virtual Clients Escort_A_Client(double time)
        {

            if (the_Queue.Count == 0)
                return null;

            clien_Exit++;
            Clients target = the_Queue[0];
            the_Queue.RemoveAt(0);

            //client_Pass++;
            SeriesClients.Points.AddXY(time, --current_Clients_in_Queue);
            if (target == null)
                throw new Exception("");
            return target;
        }

        public void Step_Line_Plotting(int queue_Index, double Time, double last_Event_Time)
        {
            int count = current_Clients_in_Queue;
            seriesQueue.Points.AddXY(Time, count);

        }
    }
}