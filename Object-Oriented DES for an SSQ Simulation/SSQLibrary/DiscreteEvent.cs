using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SSQLibrary
{
    public class DiscreteEvent
    {

        public double eventTime;
        protected static DESEngine engine;
        protected static ClientGenerator client;

        protected double EventTime { get => eventTime;}

        public static void SetEngine(DESEngine e)
        {
            engine = e;
        }
        public static void SetClient(ClientGenerator g)
        {
            client = g;
        }
        public void AddSimulationEngine()
        {
            engine.InsertEvent(this);
        }
        public virtual void ProcessEvent()
        {
            throw new Exception("No Implement!");
        }


    }
}