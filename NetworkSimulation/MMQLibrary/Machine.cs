using MMQLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomVariateGeneratorLibrary
{
    public class Machine : Server
    {
        static int number_Of_Machines = 1;

        bool enable_Break_Down_Event = false;
        //public Server parent_Server;
        ServerState last_Server_State;
        //Service_Complete_Event service_Complete_Event;
        BreakDownEvent break_Down_Event;
        Repair_Event repair_Event;

        ExponenitalRVG break_Down_Time_Generator;
        ExponenitalRVG repair_Time_Generator;
        //current_State = Server_State;
        public bool EnableBreakDown_Event
        {
            get => enable_Break_Down_Event;
            set
            {
                enable_Break_Down_Event = value;
                if (enable_Break_Down_Event)
                {
                    break_Down_Time_Generator = new ExponenitalRVG(500, 500, 500);
                    repair_Time_Generator = new ExponenitalRVG(100, 100, 100);
                    break_Down_Event = new BreakDownEvent(this, double.NaN);
                    repair_Event = new Repair_Event(this, double.NaN);
                }
                else
                {
                    break_Down_Time_Generator = null;
                    repair_Time_Generator = null;
                    break_Down_Event = null;
                    repair_Event = null;
                }
            }
        }
        public Machine(ServiceNode node) : base(node)
        {
            pieStates.Points.AddXY("Down", 0.0);// points[1] --> down
            pieStates.Points[3].Color = Color.FromArgb(160, Color.Blue);

            number_Of_Machines++;
            Name = String.Format("Machine_{0:00}", number_Of_Machines);

            EnableBreakDown_Event = true;
        }
        public Machine(string distribution, double mean, double derivation, double L, double U, ServiceNode node) : base(distribution, mean, derivation, L, U, node)
        {
            pieStates.Points.AddXY("Down", 0.0);// points[1] --> down
            pieStates.Points[3].Color = Color.FromArgb(160, Color.Blue);

            number_Of_Machines++;
            Name = String.Format("Machine_{0:00}", number_Of_Machines);

            EnableBreakDown_Event = true;

        }
        public override void Reset()
        {
            //server reset
            base.Reset();
            pieStates.Points[3].YValues[0] = 0.0;

            // add break down event
            break_Down_Event.event_Time = break_Down_Time_Generator.GenerateARealRandomNumber();
            break_Down_Event.Add_To_Simulation_Engine();
        }

        internal void Turn_To_Break_Down(double event_Time)
        {
            this.Gantt_Plotting(event_Time);
            this.Pie_Plotting(event_Time);



            double repair_Time = repair_Time_Generator.GenerateARealRandomNumber();
            repair_Event.event_Time = repair_Time + event_Time;
            //repair_Event.event_Time = event_Time + repair_Time;
            repair_Event.description = "Repair";
            repair_Event.Add_To_Simulation_Engine();

            // reschedule the server's future event       
            if (currentState == ServerState.Busy)
            {
                this.servicecompleteevent.Remove_Form_Simulation_Engine();
                this.servicecompleteevent.event_Time += repair_Time;
                this.servicecompleteevent.Add_To_Simulation_Engine();
            }
            last_Server_State = currentState;
            currentState = ServerState.Down;
        }
        internal void Return_Form_Repair(double event_Time)
        {
            //?
            //schedule next breakdown event
            this.Gantt_Plotting(event_Time);
            this.Pie_Plotting(event_Time);

            switch (last_Server_State)
            {
                case ServerState.None:
                    break;
                case ServerState.Free:
                    currentState = ServerState.Free;
                    break;
                case ServerState.Busy:
                    currentState = ServerState.Busy;
                    break;
                case ServerState.Down:
                    break;
                case ServerState.Blocked:
                    {
                        if (clientUnderService != null)
                        {
                            currentState = ServerState.Blocked;
                        }

                    }

                    //this.Complete_Current_Service(event_Time);
                    break;
                default:
                    break;
            }
            double break_Down_Time_Point = break_Down_Time_Generator.GenerateARealRandomNumber() + event_Time;
            if (break_Down_Time_Point < DiscreteEvent.the_Model.MaximalCeaseTime)
            {
                break_Down_Event.event_Time = break_Down_Time_Point;
                break_Down_Event.Add_To_Simulation_Engine();
            }
        }


        internal void Generate_A_Break_Down_Event(double event_Time)
        {
            // generate a break down event
            break_Down_Event = new BreakDownEvent(this, event_Time);
            break_Down_Event.event_Time = event_Time + break_Down_Time_Generator.GenerateARealRandomNumber();
            break_Down_Event.description = "Break_Down";
            break_Down_Event.Add_To_Simulation_Engine();
        }




    }
}
