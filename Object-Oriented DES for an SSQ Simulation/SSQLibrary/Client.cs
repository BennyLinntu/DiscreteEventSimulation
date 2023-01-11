using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace SSQLibrary
{
    public class Client
    {
        double birthTime;
        Series s;
        TimedQueue theQueue = new TimedQueue();
        List<ServiceNode> i;
        int CurrentItinerary = -1;

        public Client(List<ServiceNode> i, double t)
        {
            this.i = i;
            this.birthTime = t;
            s = new Series();
            s.ChartType = SeriesChartType.StepLine;
        }

        public Client(double t)
        {
            birthTime = t;
            s = new Series();
            s.ChartType = SeriesChartType.StepLine;
        }


        public void EnterNextServiceNode(double t)
        {
            CurrentItinerary++;
            if (i.Count <= CurrentItinerary) return;
            bool ok = i[CurrentItinerary].ReciveClient(this, t);
            DataPoint dp = new DataPoint();
            dp.XValue = t;
            s.Points.Add(dp);
            theQueue.AddClient(this, t);

        }
        public bool ExitNextServiceNode(double t)
        {
            theQueue.EscortClient(t);
            return true;
        }

    }
}