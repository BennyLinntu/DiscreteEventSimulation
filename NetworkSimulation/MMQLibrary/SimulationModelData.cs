using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomVariateGeneratorLibrary
{
    public class Simulation_Model
    {
        double min_Level;
        double max_Level;
        double limit_Period;
        double demane_Per_Period;

        static Simulation_Engine SE;
        public Simulation_Model(double min_Level, double max_Level, double limit_Period, double demane_Per_Period)
        {
            this.min_Level = min_Level;
            this.max_Level = max_Level;
            this.limit_Period = limit_Period;
            this.demane_Per_Period = demane_Per_Period;


        }

        public Simulation_Model Create_SIS_Model(double min_Level, double max_Level, double limit_Period, double demane_Per_Period)
        {
            Simulation_Model my_Model = new Simulation_Model(min_Level, max_Level, limit_Period, demane_Per_Period);
            SE = new Simulation_Engine(min_Level, max_Level, limit_Period, demane_Per_Period);
            return my_Model;
        }



        //public Reset()
        //{ 

        //}
    }
}