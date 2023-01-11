using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomVariateGeneratorLibrary
{
    public class Simulation_Engine
    {
        List<SIS_Event> future_Event_List = new List<SIS_Event>();
        double interarrival_Rate;

        double min_Level;
        double max_Level;
        double limit_Period;
        double demane_Per_Period;

        public Simulation_Engine(double min_Level, double max_Level, double limit_Period, double demane_Per_Period)
        {
            this.min_Level = min_Level;
            this.max_Level = max_Level;
            this.limit_Period = limit_Period;
            this.demane_Per_Period = demane_Per_Period;
        }

        public Simulation_Engine Create_Simulation_Engine()
        {
            Simulation_Engine se = new Simulation_Engine(min_Level, max_Level, limit_Period, demane_Per_Period);
            return se;
        }
        public void Reset()
        {
            Demand_Event d = new Demand_Event(0);
            //future_Event_List.Add()
        }

    }
}