using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static SSQLibrary.Server;

namespace SSQLibrary
{
    public class ClientGenerator
    {
        Random r = new Random();
        List<ServiceNode>[] i;
        double[] relativeProb;
        double totalProb;
        int numberofClient = 500;

        ContinuousType arrivalType = ContinuousType.Exponential;
        RandomVariateGenerator g;

        public ContinuousType ArrivalType 
        {
            get => arrivalType;
            set
            {
                if(value != arrivalType)
                {
                    arrivalType = value;
                    update();
                }
            }
        }

        public RandomVariateGenerator ServiceTimeGenerator { get => g;}
        public int NumberofClient 
        { 
            get => numberofClient;
            set
            {
                if(value >= 0)
                {
                    numberofClient = value;
                }
            }
        }
        public ClientGenerator(List<ServiceNode>[] i, double[] p)
        {
            this.i = i;
            this.relativeProb = p;
            foreach (double  x in p)
            {
                totalProb += x;
            }
            update();
            DiscreteEvent.SetClient(this);
        }
        public DiscreteEvent GenerateClientArrival(double c)
        {
            double interArrivalTime = g.GetRandomNumber();
            double target = r.NextDouble() * totalProb;
            int j = 0;
            for (j = 0; j < i.Length; j++)
            {
                if (target < relativeProb[j]) break;
            }
            Client acli = new Client(i[j], c + interArrivalTime);
            DiscreteEvent d = new ClientArrivalEvent(acli, c + interArrivalTime);
            d.AddSimulationEngine();
            return d;

        }

        private void update()
        {
            switch (arrivalType)
            {
                case ContinuousType.Exponential:
                    g = new ExponentialDisCRVGenerator();
                    break;
                case ContinuousType.Uniform:
                    g = new UniformDisCRVGenerator();
                    break;
                default:
                    break;
            }
        }

        
    }
}