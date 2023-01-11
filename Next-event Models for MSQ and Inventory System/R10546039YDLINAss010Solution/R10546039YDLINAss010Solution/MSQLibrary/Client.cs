using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSQLibrary
{
    public class Client
    {

        // data fields
        /*public static ServiceNode SSQNode;*/// Assume all clients have exactly one service node to visit
        double birthTime;
        List<ServiceNode> serviceNode = new List<ServiceNode>();

        // properties

        public double BirthTime { get => birthTime;}


        // functions
        public Client(double time)
        {
            birthTime= time;
        }
        public Client()
        {

        }

        public void EnterFirstNode(double eventTime, ServiceNode node)
        {
            node.ReceiveAClient(this, eventTime);
        }
    }
}