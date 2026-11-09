using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMQLibrary;

namespace RandomVariateGeneratorLibrary
{
    public class Demand_Event : SIS_Event
    {
        //override 
        ExponenitalRVG arrival_Generator;
        public Demand_Event(double event_Time)
        {
            this.event_Time = event_Time;
        }

        public double Generate_Next_Demand_Event(double interarrival_Rate)
        {
            arrival_Generator = new ExponenitalRVG(interarrival_Rate, 0, 1);
            return arrival_Generator.GenerateARealRandomNumber();
        }

        public override string Get_Type()
        {
            return "d";
        }
    }
}