using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomVariateGeneratorLibrary
{
    public class DiscreteEvent
    {
        public double event_Time;
        protected static DESEngine the_Engine;
        protected static ClientGenerator the_Client_Generator;
        public static theDESModel the_Model;
        public string description = "";

        public double Event_Time { get => event_Time; set => event_Time = value; }

        public static void Set_Engine(DESEngine engine)
        {
            the_Engine = engine;
        }

        public static void Set_Client_Generator(ClientGenerator generator)
        {
            the_Client_Generator = generator;
        }

        //public double Event_Time
        //{
        //    get => event_Time; set => { event_Time = value; };
        //}



        public void Add_To_Simulation_Engine()
        {
            the_Engine.Insert_An_Event(this);
        }

        public bool Remove_Form_Simulation_Engine()
        {
            return the_Engine.Remove_An_Event(this);
        }
        public virtual void Process_Event()
        {
            throw new Exception("NO implement");
        }
    }
}