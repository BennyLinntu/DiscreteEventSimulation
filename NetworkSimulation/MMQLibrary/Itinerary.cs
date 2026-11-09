using MMQLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace RandomVariateGeneratorLibrary
{
    public class Itinerary : DESElement
    {
        static int index = 0;
        string name;
        public List<ServiceNode> my_itineraries;
        public List<RandomVariateGenerator> processing_Time_Generator;
        public double priority;
        public double probability;
        public Itinerary()
        {
            Name = String.Format("Itinerary_{0:00}", ++index);
            my_itineraries = new List<ServiceNode>();
            processing_Time_Generator = new List<RandomVariateGenerator>();

        }
        public override void Draw(Graphics g, Rectangle client_Rectangle)
        {
            Brush b = new SolidBrush(Color.LightCyan);
            Pen pe = new Pen(Color.Gray);

            double length;
            Point p = new Point(Bound.X, Bound.Y);
            if (Bound.X < Bound.Y)
                length = Bound.X;
            else
                length = Bound.Y;
            Rectangle squre = new Rectangle(Bound.X, Bound.Y, Bound.Width, Bound.Height);

            Point[] Ps = new Point[5];
            //Ps[0] = Bound.X;

            //draw line to queue
            float n_X = 0;
            float n_Y = 0;
            float i_X = this.Bound.X + (float)0.5 * this.Bound.Width;
            float i_Y = this.Bound.Y + (float)0.5 * this.Bound.Height;
            if (my_itineraries != null)
            {
                for (int i = 0; i < my_itineraries.Count; i++)
                {
                    n_X = my_itineraries[i].Bound.X + my_itineraries[i].Bound.Width;
                    n_Y = my_itineraries[i].Bound.Y + (float)0.5 * my_itineraries[i].Bound.Height;
                    g.DrawLine(pe, new PointF(i_X, i_Y), new PointF(n_X, n_Y));
                }

            }

            g.FillRectangle(b, squre);
            //g.FillRectangle(b, Bound);
            SizeF size = g.MeasureString(Name, Element_Font);
            g.DrawString(Name, Element_Font, Brushes.Black, new Point((int)(Bound.X + 0.5 * (Bound.Width - size.Width)), Bound.Bottom));
        }
        public string Name { get => name; set => name = value; }
        public List<ServiceNode> My_itineraries { get => my_itineraries; set => my_itineraries = value; }
        public double Priority { get => priority; set => priority = value; }
        public double Probability { get => probability; set => probability = value; }
        public List<RandomVariateGenerator> Processing_Time_Generator { get => processing_Time_Generator; set => processing_Time_Generator = value; }
    }
}