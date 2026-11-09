using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace RandomVariateGeneratorLibrary
{
    public class gannt
    {
        Series sever_gantt;
        int Server_Index;
        public void plot(double current_Client_In_Node, double previous_Client_In_Node, DiscreteEvent head_Event, double last_Event_Time)
        {
            DataPoint dp = new DataPoint();
            dp.XValue = Server_Index;
            dp.YValues = new double[] { last_Event_Time, head_Event.Event_Time };
            if (previous_Client_In_Node == 0)
            {
                dp.Color = Color.Green;
            }
            else
            {
                dp.Color = Color.Red;
            }
            sever_gantt.Points.Add(dp);
        }
        public Series creat_series(int Server_Index)
        {
            sever_gantt = new Series();
            sever_gantt.ChartType = SeriesChartType.RangeBar;
            this.Server_Index = Server_Index;
            return sever_gantt;
        }

        public void Reset()
        {
            sever_gantt.Points.Clear();
        }
    }
}