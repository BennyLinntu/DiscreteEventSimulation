using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace SSQLibrary
{
    public class ServiceNode
    {
        List<Server> server;
        List<TimedQueue> queue;
        Series s;
        int currentClientCount;
        int exitClientCount;
        public ServiceNode()
        {

        }



        public void Reset()
        {
            s.Points.Clear();
            s.Points.AddXY(0, 0);
            foreach (Server item in server)
            {
                item.Reset();
            }
            foreach (var item in queue)
            {
                item.Reset();
            }
            currentClientCount = 0;
            exitClientCount = 0;
        }

        public ServiceNode(List<Server> s, List<TimedQueue> q)
        {
            this.server = s;
            this.queue = q;
            CreateClientCountSeries();
        }
        public void CreateClientCountSeries()
        {
            s = new Series();
            s.ChartType = SeriesChartType.StepLine;
            s.Color = Color.Blue;
        }

        public bool ReciveClient(Client c, double t)
        {
            Server sfree = null;
            TimedQueue tq = null;

            sfree = server[0];
            tq = queue[0];

            if(s != null)
            {

                sfree.StartServiceClient(c, t);
                tq.AddClient(c, t);
                currentClientCount++;
                s.Points.AddXY(t, currentClientCount);
                return true;
            }
            TimedQueue sq = null;
            sq = queue[0];
            bool o =  sq.AddClient(c, t);
            if(o)
            {
                currentClientCount++;
                s.Points.AddXY(t, currentClientCount);
                return true;
            }
            return false;
        }
        public bool ExitClient(Client c, double t)
        {
            bool o = c.ExitNextServiceNode(t);
            if (!o) return false;

            currentClientCount--;
            s.Points.AddXY(0, currentClientCount);
            exitClientCount++;
            return true;
        }
    }



}