using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace RandomVariateGeneratorLibrary
{
    public class pie
    {
        Series Sever_Pie;
        public void plot(double current_Client_In_Node, double previous_Client_In_Node, DiscreteEvent head_Event, double last_Event_Time)
        {
            if (previous_Client_In_Node == 0)
                // add free time to pie series
                Sever_Pie.Points[0].YValues[0] += (head_Event.Event_Time - last_Event_Time);
            else
                // add busy time to pie series
                Sever_Pie.Points[1].YValues[0] += (head_Event.Event_Time - last_Event_Time);
        }
        public Series creat_series()
        {
            Sever_Pie = new Series();
            Sever_Pie.ChartType = SeriesChartType.Pie;

            //Sever_Pie.Points[0].YValues[0] = 0.0;
            //Sever_Pie.Points[1].YValues[0] = 0.0;

            Sever_Pie.Points.AddXY("Free", 0.0);// points[0] --> free
            Sever_Pie.Points[0].Color = Color.FromArgb(160, Color.Green);
            Sever_Pie.Points.AddXY("Busy", 0.0);// points[1] --> busy
            Sever_Pie.Points[1].Color = Color.FromArgb(160, Color.Red);

            return Sever_Pie;
        }

        public void Reset()
        {
            Sever_Pie.Points.Clear();
        }
    }
}