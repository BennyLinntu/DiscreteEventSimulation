using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using MMQLibrary;
using RandomVariateGeneratorLibrary;

namespace RandomVariateGeneratorLibrary
{
    public class ClientGenerator : DESElement
    {
        Random randomizer = new Random();
        List<Itinerary> itineraries;
        List<List<RandomVariateGenerator>> processingTimeOfItineraries;
        List<double> probability_Cell;
        List<double> serving_Priority;
        double probabilities_Sum = 0;
        double total_Weight;
        public int numberOfClients = int.MaxValue;
        static int index = 0;
        string name;
        int generated_Clients = 0;
        //int fail_Generated_Clients = 0;
        double ceaseTime = 480;

        double interarrival_Time_Sum = 0;
        ContinuousRVGType inter_Arrival_Type = ContinuousRVGType.Exponential;
        RandomVariateGenerator interArrivalTimeGenerator;

        #region Properties
        public ContinuousRVGType InterArrivalType
        {
            get => inter_Arrival_Type;
            set
            {
                if (value != InterArrivalType)
                {
                    inter_Arrival_Type = value;
                    update_Generator();
                }

            }
        }

        public RandomVariateGenerator InterArrivalTimeGenerator
        { get => interArrivalTimeGenerator; }
        public int NumberOfClients
        {
            get => numberOfClients;
            set
            {
                if (value >= 0)
                    numberOfClients = value;
            }
        }

        public int GeneratedClients { get => generated_Clients; }
        public double CeaseTime { get => ceaseTime; set => ceaseTime = value; }
        public string Name { get => name; set => name = value; }
        #endregion

        #region Public Interfacing Function
        public ClientGenerator()
        {
            //probability_Cell = new List<double>();
            //serving_Priority = new List<double>();
            itineraries = new List<Itinerary>();
            Name = String.Format("Client_Generator_{0:00}", ++index);
        }
        public ClientGenerator(List<Itinerary> itineraries)
        {
            //this.cease_Time = cease_Time;
            probability_Cell = new List<double>();
            serving_Priority = new List<double>();

            this.itineraries = itineraries;
            for (int i = 0; i < itineraries.Count; i++)
            {
                probabilities_Sum += itineraries[i].probability;
                probability_Cell.Add(probabilities_Sum);
            }

            update_Generator();
            DiscreteEvent.Set_Client_Generator(this);
        }
        public override void Draw(Graphics g, Rectangle client_Rectangle)
        {
            Brush b = new SolidBrush(Color.LightSalmon);
            Pen pe = new Pen(Color.Gray);


            double length;
            Point p = new Point(Bound.X, Bound.Y);
            if (Bound.X < Bound.Y)
                length = Bound.X;
            else
                length = Bound.Y;
            Rectangle squre = new Rectangle(Bound.X, Bound.Y, Bound.Width, Bound.Height);

            //draw line to itinerary
            float i_X = 0;
            float i_Y = 0;
            float c_X = this.Bound.X + (float)0.5 * this.Bound.Width;
            float c_Y = this.Bound.Y + (float)0.5 * this.Bound.Height;
            if (itineraries != null)
            {

                for (int i = 0; i < itineraries.Count; i++)
                {
                    i_X = itineraries[i].Bound.X + itineraries[i].Bound.Width;
                    i_Y = itineraries[i].Bound.Y + (float)0.5 * itineraries[i].Bound.Height;
                    g.DrawLine(pe, new PointF(i_X, i_Y), new PointF(c_X, c_Y));
                }
                // ctor
                probability_Cell = new List<double>();
                serving_Priority = new List<double>();
                for (int i = 0; i < itineraries.Count; i++)
                {
                    probabilities_Sum += itineraries[i].probability;
                    probability_Cell.Add(probabilities_Sum);
                }

                update_Generator();
                DiscreteEvent.Set_Client_Generator(this);
            }

            g.FillRectangle(b, squre);
            //g.FillRectangle(b, Bound);
            SizeF size = g.MeasureString(Name, Element_Font);
            g.DrawString(Name, Element_Font, Brushes.Black, new Point((int)(Bound.X + 0.5 * (Bound.Width - size.Width)), Bound.Bottom));
        }
        public DiscreteEvent Generate_A_Client_Arrival(double current_Time)
        {
            if (current_Time > ceaseTime)
            {
                return null;
            }
            double inter_Arrival_Time = interArrivalTimeGenerator.GenerateARealRandomNumber();

            // choose an itinerary for the client
            for (int i = 0; i < itineraries.Count; i++)
            {
                probabilities_Sum += itineraries[i].probability;
                probability_Cell.Add(probabilities_Sum);
            }

            int itinerary_Index = 0;
            double target = randomizer.NextDouble() * probabilities_Sum;

            for (int i = 0; i < itineraries.Count - 1; i++)
            {
                if (target < probability_Cell[i])
                {
                    itinerary_Index = i;
                    break;
                }
            }

            Clients a_Client = new Clients(current_Time + inter_Arrival_Time, itineraries[itinerary_Index]);

            DiscreteEvent de = new Client_Arrival_Event(a_Client, current_Time + inter_Arrival_Time);

            if (generated_Clients >= numberOfClients)
            {
                return null;
            }
            else
            {
                interarrival_Time_Sum += inter_Arrival_Time;
                generated_Clients++;
                de.description = "arrival";
                de.Add_To_Simulation_Engine();
                return de;
            }
        }
        public void Add_To_Itineraries(Itinerary i)
        {
            if (itineraries != null)
            {
                itineraries.Add(i);
            }

        }
        #endregion
        public string GetDescription()
        {
            return $"Clients generator generated {generated_Clients} clients\n" +
                $"Generator cease time: {ceaseTime} \n" +
                $"Mean interarrival time: {Math.Round(interarrival_Time_Sum / Convert.ToDouble(generated_Clients), 2)}\n";
        }


        private void update_Generator()
        {
            switch (inter_Arrival_Type)
            {
                case ContinuousRVGType.Exponential:
                    interArrivalTimeGenerator = new ExponenitalRVG(2, 2, 2);
                    break;
                case ContinuousRVGType.Uniform:
                    interArrivalTimeGenerator = new UniformRVG(0, 1);
                    break;
                default:
                    break;
            }
        }

    }


}