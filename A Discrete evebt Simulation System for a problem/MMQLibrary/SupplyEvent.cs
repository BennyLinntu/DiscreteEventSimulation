using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomVariateGeneratorLibrary
{
    public class SupplyEvent : SIS_Event
    {
        public double order_Quantities;
        public SupplyEvent(double event_Time, double order_Quantities)
        {
            this.event_Time = event_Time;
            this.order_Quantities = order_Quantities;
        }
        public override double Get_Quantities()
        {
            return order_Quantities;
        }
        public override string Get_Type()
        {
            return "s";
        }
    }
}