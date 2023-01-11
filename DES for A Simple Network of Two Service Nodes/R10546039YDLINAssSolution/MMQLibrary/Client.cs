using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMQLibrary;

namespace MMQLibrary
{
    public class Client
    {

        // data fields
        /*public static ServiceNode SSQNode;*/// Assume all clients have exactly one service node to visit
        double birthTime;
        List<ServiceNode> serviceNode = new List<ServiceNode>();
        int currentNodeIndex = -1;
        // properties

        public double BirthTime { get => birthTime;}


        Itinerary myItinerary;
        public Itinerary MyItinerary
        {
            get => myItinerary;
            set
            {
                myItinerary = value;
            }
        }


        // functions
        public Client(double time, Itinerary iti)
        {
            birthTime= time;
            myItinerary = iti;
        }
        public Client()
        {

        }

        public bool EnterNextNode(double eventTime, ServiceNode node)
        {
            if (currentNodeIndex >= myItinerary.NodeSequence.Count - 1) return true;
            if (currentNodeIndex < 0) return false;
            ServiceNode nextNode = myItinerary.NodeSequence[currentNodeIndex +1];
             bool isOk = node.ReceiveAClient(this, eventTime);
            if (isOk)
                currentNodeIndex++;
            return isOk;
        }
    }
}