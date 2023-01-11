using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace MMQLibrary
{
    public class ClientGenerator
    {
        // data fields
        static int serialCount = 1;
        ArrivalEvent arrivalEvent;
        ContinuousRandomVariateGenerator interarrivalTimeGenerator;
        ContinuousDistributionType timeGeneratorType;
        int clientGeneratedCount = 0;
        double ceaseTime = 480.0;
        Random r = new Random();

        List<Itinerary> itinerariesServiced = new List<Itinerary>();
        List<double> itineraryProbabilities = new List<double>();
        // statistical data
        List<int> numberofClirntGenerated = new List<int>();

        public bool AddAServicedItinerary(Itinerary iti, double relativeProbability = 100)
        {
            if (itinerariesServiced.Contains(iti)) return false;
            itinerariesServiced.Add(iti);
            itineraryProbabilities.Add(relativeProbability);
            return true;
        }
        //double time = 0;

        // properties
        [Category("Model")]
        public ContinuousDistributionType TimeGeneratorType
        {
            get => timeGeneratorType;
            set
            {
                if (timeGeneratorType != value)
                {
                    timeGeneratorType = value;
                    interarrivalTimeGenerator = ContinuousRandomVariateGenerator.GetARandomVariateGenerator(timeGeneratorType);
                }
            }
        }
        [Category("Title")]
        public string Title { set; get; } = "Generator";

        public ContinuousRandomVariateGenerator InterarrivalTimeGenerator { get => interarrivalTimeGenerator; }

        [Category("Settings"), Description("Time limit in minutes for client generations.")]
        public double CeaseTime
        {
            get => ceaseTime; 
            set
            {
                if (value > 0) ceaseTime = value;
            }
        }
        [Category("Model")]
        public int ClientGeneratedCount { get => clientGeneratedCount;}
        public List<Itinerary> ItinerariesServiced { get => itinerariesServiced;}
        public List<double> ItineraryProbabilities { get => itineraryProbabilities; }

        public override string ToString()
        {
            return $"{Title}:{interarrivalTimeGenerator}";
        }

        // functions


        public ClientGenerator()
        {
            TimeGeneratorType = ContinuousDistributionType.Exponential;  // here we define the ganerator type
            interarrivalTimeGenerator = new ExponentialDisCRVGenerator();
            arrivalEvent = new ArrivalEvent(0, this, null, null);
            Title = $"Generator{serialCount++}";
        }
        public void Reset()
        {
            clientGeneratedCount = 0;
            interarrivalTimeGenerator.Reset();
            for (int i = 0; i < numberofClirntGenerated.Count; i++)
            {
                numberofClirntGenerated[i] = 0;
            }
            
            //time = 0;
            // generate the first arrival event and add the event to the event queue
            //GenerateAClient(0, null);
        }
        public Client GenerateAClient(double time, ServiceNode node)
        {
            if (clientGeneratedCount > ceaseTime) return null;
            clientGeneratedCount++;
            Client client = null;
            double deltaTime = interarrivalTimeGenerator.NextDouble();
            time += deltaTime;
            //if (time > ceaseTime) return null;
            Itinerary iti = null; 
            double total = 0;
            foreach (var item in itineraryProbabilities)
                total += item;
            double hit = r.NextDouble() * total;
            double v = 0; 
            for (int i = 0; i < itineraryProbabilities.Count; i++)
            {
                v += itineraryProbabilities[0];
                if (hit < v)
                {
                    iti = itinerariesServiced[i];
                    numberofClirntGenerated[i]++;
                    break;
                }
            }
            client = new Client(time, iti);
            // generate a arrival Event and add it to event queue
            arrivalEvent.EventTime = time;
            arrivalEvent.Client= client;
            arrivalEvent.Node = node;
            arrivalEvent.AddToSimulationModel();

            //ArrivalEvent ae = new ArrivalEvent(time, this, client);
            //ae.AddToSimulationModel();
            return client;
        }

        public string DisplaySimulationResults()
        {
            StringBuilder sb = new StringBuilder();
            return sb.ToString();
        }
    }
}