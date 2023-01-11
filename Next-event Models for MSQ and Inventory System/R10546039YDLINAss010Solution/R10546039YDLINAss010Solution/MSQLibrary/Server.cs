using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using System.ComponentModel;

namespace MSQLibrary
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Server
    {
        // data filds
        static int serialCounter = 1;
        ServiceNode parent;
        Client theClient;
        ContinuousRandomVariateGenerator serviceTimeGenerator;
        //ServiceCompleteEvent serviceDoneEvent;
        ContinuousDistributionType timeGeneratorType;
        TimedQueue theQueue;
        Series ganttSeries = new Series();
        int ganttID = 1;
        int exitCount = 0;
        double cumlatedFreeTime = 0;
        double cumlatedBusyTime = 0;
        double lastTime;
        double completeTime = double.PositiveInfinity;
        // properties
        [Category("Model")]
        public ContinuousDistributionType TimeGeneratorType
        {
            get => timeGeneratorType;
            set
            {
                if (timeGeneratorType != value)
                {
                    timeGeneratorType = value;
                    serviceTimeGenerator = ContinuousRandomVariateGenerator.GetARandomVariateGenerator(timeGeneratorType);

                }


            }
        }
        [Category("Statistics")]
        public int ExitCount { get => exitCount;}
        [Category("Statistics")]
        public double CumlatedFreeTime { get => cumlatedFreeTime; }
        [Category("Statistics")]
        public double CumlatedBusyTime { get => cumlatedBusyTime;}
        [Category("Model")]
        public Series GanttSeries { get => ganttSeries;}
        [Category("Model")]
        public double ServiceTimeAverage
        {
            get
            {
                return serviceTimeGenerator.GeneratedMean;
            }
        }
        [Category("Model")]
        public ContinuousRandomVariateGenerator ServiceTimeGenerator { get => serviceTimeGenerator;}
        [Category("Simulation")]
        public bool IsFree 
        {
            get => theClient == null;
        }
        [Category("Model")]
        public ServiceNode Parent { get => parent; set => parent = value; }
        [Category("Model")]
        public TimedQueue TheQueue { get => theQueue; set => theQueue = value; }

        // functions

        public Server()
        {
            theClient = null;
            ganttSeries.ChartType = SeriesChartType.RangeBar;
            TimeGeneratorType = ContinuousDistributionType.Uniform;
            serviceTimeGenerator = new UniformDisCRVGenerator();
            exitCount = 0;
            cumlatedFreeTime = 0;
            cumlatedBusyTime = 0;
            lastTime = 0;
            //serviceDoneEvent = new ServiceCompleteEvent(0, this);
        }
        public void Reset()
        {  
            serviceTimeGenerator.Reset();
            theClient = null;
            ganttSeries.Points.Clear();
            exitCount = 0;
            exitCount = 0;
            cumlatedFreeTime = 0;
            cumlatedBusyTime = 0;
            completeTime = double.PositiveInfinity;
        }

        public bool ServerAClient(Client client, double time)
        {
            if (theClient != null) throw new Exception("The Client is not null!");
            theClient = client;
            // add gantt block
            
            if (ganttSeries.Points.Count == 0) lastTime = 0;
            else lastTime = ganttSeries.Points[ganttSeries.Points.Count - 1].YValues[1];
            DataPoint dp = new DataPoint();
            dp.XValue = ganttID;
            dp.YValues = new double[2] { lastTime, time };
            dp.Color = Color.Lime;
            ganttSeries.Points.Add(dp);
            // update free time
            cumlatedFreeTime += time - lastTime;

            // Generate service Time
            double serviceTime = serviceTimeGenerator.NextDouble();
            time += serviceTime;
            completeTime = time;
            //generate completion event
            //ServiceCompleteEvent doneEvent = new ServiceCompleteEvent(time, this);
            //doneEvent.AddToSimulationModel();
            //serviceDoneEvent.eventTime = time;
            //serviceDoneEvent.AddToSimulationModel();

            ServiceCompleteEvent completeEvent = new ServiceCompleteEvent(time, this);
            completeEvent.AddToSimulationModel();
            return true;
        }


        public bool CompleteCurrentService(double time)
        {
            if (theClient == null) return false;
            // add Gantt block
            double lastTime;
            lastTime = ganttSeries.Points[ganttSeries.Points.Count - 1].YValues[1];
            cumlatedBusyTime += time - lastTime;
            DataPoint dp = new DataPoint();
            dp.XValue = ganttID;
            dp.YValues = new double[2] { lastTime, time };
            dp.Color = Color.Red;
            //dp.BorderColor = Color.DarkGray;
            ganttSeries.Points.Add(dp);

            // update busy time
            exitCount++;
            // ask the node expel the client
            parent.ExpelAClient(theClient, time);
            theClient = null;

            //  check queue
            //if(theQueue.ClientCount > 0)
            //{
            //    // server the head client
            //    Client head =  theQueue.DeQueue(time);

            //    ServerAClient(head, time);
            //}
            if(theQueue.LengthofCurrentQueue != 0)
            {
                Client client = theQueue.DeQueue(time);
                ServerAClient(client, time);
            }
            return true;
            
        }

        
    }
}