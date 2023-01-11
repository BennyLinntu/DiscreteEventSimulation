using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace MMQLibrary
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class TimedQueue
    {
        // data fields

        List<Client> clientQueue;// here we show the list of client
        Series queueSeries; // here we new queue series
        double cumulateArea;
        int maximalLength;
        int exitCount;
        int id = 1;

        // properities
        [Category("Statistics"), Description("max Count")]
        public int MaximalCount { get => maximalLength;}
        [Category("Statistics")]
        public double TimeAverageLength
        {
            get
            {
                double lastTime = (double)QueueSeries.Points[QueueSeries.Points.Count - 1].XValue;
                return cumulateArea / lastTime;
            }
        }
        [Category("Statistics")]
        public double AverageDelayTime
        {
            get
            {
                return (cumulateArea / (exitCount + clientQueue.Count));
            }

        }
        [Category("Simulation")]
        public Series QueueSeries { get => queueSeries;}
        [Category("Simulation")]
        public int ClientCount { get => clientQueue.Count;}
        [Category("Statistics")]
        public int LengthofCurrentQueue
        {
            get
            {
                return clientQueue.Count;
            }
        }



        // functions
        public bool EnQueue(Client client, double time)
        {

            if (time < 0) return false;
            // here we add a client
           
            // update series
            double lastTime = (double)QueueSeries.Points[QueueSeries.Points.Count - 1].XValue;
            
            // add delta area
            cumulateArea += (time - lastTime) * clientQueue.Count;
            clientQueue.Add(client);
            QueueSeries.Points.AddXY(time, clientQueue.Count);
            // check whether maximalCount should be updated!
            exitCount++;
            if(maximalLength < clientQueue.Count)
            {
                maximalLength = clientQueue.Count;
            }
            return true;
        }

        public void RemoveAClient(Client client, double time)
        {
            clientQueue.Remove(client);
            cumulateArea += (time - (double)queueSeries.Points[queueSeries.Points.Count - 1].XValue) * clientQueue.Count;
            queueSeries.Points.AddXY(time, clientQueue.Count);
        }

        public Client DeQueue(double time)
        {
            Client head = null;
            if (clientQueue.Count > 0)
            {
                head = clientQueue[0];
                clientQueue.RemoveAt(0);
                // update series
                //queueSeries.Points.AddXY(time, clientQueue.Count);
                // update area
                double lastTime = QueueSeries.Points[QueueSeries.Points.Count - 1].XValue;
                cumulateArea += (time - lastTime) * clientQueue.Count;
                // update count
                queueSeries.Points.AddXY(time, clientQueue.Count);
                
            }
            return head;
        }


        public void Reset() // reset the data, and clear the data
        {
            QueueSeries.Points.Clear();
            QueueSeries.Points.AddXY(0.0, 0);
            clientQueue.Clear();
            exitCount = 0;
            cumulateArea = 0.0;
            maximalLength = 0;
        }


        public TimedQueue()
        {
            clientQueue = new List<Client>();
            queueSeries = new Series();
            cumulateArea = new double();
            maximalLength = new int();
            exitCount = new int();
            QueueSeries.ChartType = SeriesChartType.StepLine; // set the series type
            queueSeries.Color = Color.Blue;
            maximalLength = 0;
        }

        public virtual string DisplaySimulationResults()
        {
            StringBuilder sb = new StringBuilder();
            return sb.ToString();
        }

    }
}