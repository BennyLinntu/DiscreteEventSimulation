using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace SSQLibrary
{
    public class TimedQueue
    {
        Random r = new Random();
        // data
        Queue<Client> clientQueue = new Queue<Client>();
        string name;
        Series seriesClient = new Series();
        Series s_2 = new Series();
        int maxCount = 0;
        int capacity = int.MaxValue;
        static int instanceCount = 0;
        int clientPass = 0;
        int clientExit;
        [BrowsableAttribute(false)]
        public Series SeriesClient { get => seriesClient;}

        [Category("Simulation")]
        public int Count { get => maxCount; }
        [Category("Statistics")]
        public int TimeAveragedLength { get => clientQueue.Count; }
        [BrowsableAttribute(false)]
        public string Name { get => name; set => name = value; }
        [Category("Statistics")]
        public double TimeAveragedLengthSTD { get => (1 + r.NextDouble()); }
        public TimedQueue()
        {
            Name = $"Queue{++instanceCount}";
            SeriesClient.ChartType = SeriesChartType.StepLine;
            s_2.ChartType = SeriesChartType.StepLine;
            SeriesClient.Color = Color.Red;
            s_2.Color = Color.Blue;
            seriesClient.LegendText = Name;
        }

        public void Reset()
        {
            clientQueue.Clear();
            SeriesClient.Points.Clear();
            maxCount = 0;
            clientPass = 0;
            clientExit = 0;
            SeriesClient.Points.AddXY(0, 0);

        }
        public bool AddClient(Client client, double time)
        {
            if (clientQueue.Count >= capacity) return false;
            clientQueue.Enqueue(client);
            if (clientQueue.Count > maxCount) maxCount = clientQueue.Count;
            SeriesClient.Points.AddXY(time, clientQueue.Count);
            return true;
            
        }
        public virtual Client EscortClient(double t)
        {
            if (clientQueue.Count == 0) return null;
            clientExit++;
            Client c = clientQueue.Dequeue();
            SeriesClient.Points.AddXY(t, clientQueue.Count);
            return c;
        }


    }
}