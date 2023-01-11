using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace RandomVariateGeneratorLibrary
{
    public class step_line
    {
        Series Client_Step_Line;
        public void plot(double current_Client_In_Node, double previous_Client_In_Node, DiscreteEvent head_Event, double last_Event_Time)
        {
            Client_Step_Line.Points.AddXY(head_Event.Event_Time, current_Client_In_Node);
        }
        public Series creat_series()
        {
            Client_Step_Line = new Series();
            Client_Step_Line.ChartType = SeriesChartType.StepLine;
            Client_Step_Line.Points.AddXY(0, 0);
            Client_Step_Line.Color = Color.Red;
            Client_Step_Line.BorderWidth = 2;
            Client_Step_Line.Name = "Node Level";
            //Client_Step_Line.ChartArea = "ChartArea2";

            return Client_Step_Line;
        }

        public void Reset()
        {
            Client_Step_Line.Points.Clear();
        }
    }
}