using RandomVariateGeneratorLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using Cursor = System.Windows.Forms.Cursor;
using System.Drawing.Drawing2D;
using MMQLibrary;


namespace R10546039YDLINFinal
{
    public partial class Main : Form
    {
        // data fileds
        DESElement selectedElement = null;
        DESElement elementStart = null;
        DESElement elementEnd = null;
        theDESModel Model = new theDESModel();


        // here is Series
        List<ServiceNode> listofServiceNode;
        Series seriesCLientStepLine = new Series();
        Series seiesCLientQueue = new Series();
        Series seriesCLientGantt = new Series();
        Series seriesCLientPie = new Series();

        Series seriesBankStepLine = new Series();
        Series seriesBankGantt = new Series();
        Series seriesBankPie = new Series();

        Series seriesFastFoodStepLine = new Series();
        Series seiesFastFoodQueue = new Series();
        Series seriesFastFoodGantt = new Series();
        Series seriesFastFoodPie = new Series();

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern IntPtr Load_Cusor_From_File(string path);

        Cursor Cursor_Node;
        Cursor Cursor_Server;
        Cursor Cursor_Queue;

        Point mouse_Down_SCR_Point, current_Mouse_SCR_Point;
        Rectangle rubber_SCR_Frame;

        Point mouse_Down_PNL_Point, current_Mouse_PNL_Point;
        Rectangle rubber_PNL_Frame;

        public Main()
        {
            InitializeComponent();
            Cursor_Node = new Cursor("Node_Plus.cur");
            Cursor_Server = new Cursor("Server_Plus.cur");
            Cursor_Queue = new Cursor("Queue_Plus.cur");

            DES_Collection_Element_Editor.DES_Element_Add += DES_Collection_Element_Editor_DES_Element_Added;

            Model = Model.Creat_A_Empty_Model();
        }
        private void DES_Collection_Element_Editor_DES_Element_Added(object sender, DESElement e)
        {
            Model.Elements.Add(e);
            panelShow.Refresh();
        }
        

        private void btnReset_Click(object sender, EventArgs e)
        {
            
            ChartReset(); // check whether or not reset
            
            //creating simulation model
            double cease_Time = int.MaxValue;
            Model.CreatASSQModel(cease_Time);

            ppgShow.SelectedObject = Model;
            Model.Reset_Simulation();
            listofServiceNode = Model.Get_All_Service_Node();

            //washing chart
            seriesCLientStepLine = listofServiceNode[0].clientCountSeries; 
            seiesCLientQueue = listofServiceNode[0].Queues[0].seriesQueue; seiesCLientQueue.Name = listofServiceNode[0].Queues[0].Name;
            seriesCLientGantt = listofServiceNode[0].Servers[0].ganttStates; seriesCLientGantt.Name = "Server Gantt";
            Title t = new Title(); t.Text = listofServiceNode[0].Servers[0].Name;
            t.Alignment = ContentAlignment.BottomCenter;
            chtClientPie.Titles.Add(t);
            seriesCLientPie = listofServiceNode[0].Servers[0].pieStates; 
            //Pressing chart
            seriesBankStepLine = listofServiceNode[1].clientCountSeries;
            for (int i = 0; i < listofServiceNode[1].Servers.Count; i++)
            {
                chtFastFoodPie.ChartAreas.Add($"ChartArea{i + 1}");
                listofServiceNode[1].Servers[i].pieStates.ChartArea = $"ChartArea{i + 1}";
                chtFastFoodPie.Series.Add(listofServiceNode[1].Servers[i].pieStates);

                Title title = new Title(); title.Text = listofServiceNode[1].Servers[i].Name;
                title.DockedToChartArea = $"ChartArea{i + 1}";
                title.Alignment = ContentAlignment.BottomCenter;
                chtFastFoodPie.Titles.Add(title);

                listofServiceNode[1].Servers[i].ganttStates.ChartArea = "ChartArea2";
                chtFastFoodStepLine.Series.Add(listofServiceNode[1].Servers[i].ganttStates);
            }
            for (int i = 0; i < listofServiceNode[1].Queues.Count; i++)
            {
                listofServiceNode[1].Queues[i].seriesQueue.Name = listofServiceNode[1].Queues[i].Name;
                chtFastFoodStepLine.Series.Add(listofServiceNode[1].Queues[i].seriesQueue);
            }

            //Assembly chart
            seriesFastFoodStepLine = listofServiceNode[2].clientCountSeries;
            for (int i = 0; i < listofServiceNode[2].Servers.Count; i++)
            {
                chtBankPie.ChartAreas.Add($"ChartArea{i + 1}");
                listofServiceNode[2].Servers[i].pieStates.ChartArea = $"ChartArea{i + 1}";
                chtBankPie.Series.Add(listofServiceNode[2].Servers[i].pieStates);

                Title title = new Title(); title.Text = listofServiceNode[2].Servers[i].Name;
                title.DockedToChartArea = $"ChartArea{i + 1}";
                title.Alignment = ContentAlignment.BottomCenter;
                chtBankPie.Titles.Add(title);
                listofServiceNode[2].Servers[i].ganttStates.ChartArea = "ChartArea2";
                chtBankStepLine.Series.Add(listofServiceNode[1].Servers[i].ganttStates);
                chtFastFoodStepLine.Series.Add(listofServiceNode[2].Servers[i].ganttStates);
            }
            seiesFastFoodQueue = listofServiceNode[2].Queues[0].seriesQueue; seiesFastFoodQueue.Name = listofServiceNode[2].Queues[0].Name;


            chtClientGeneratorStepLine.Series.Add(seriesCLientStepLine);
            chtClientGeneratorStepLine.Series.Add(seiesCLientQueue);
            seriesCLientGantt.ChartArea = "ChartArea2";
            seriesCLientGantt.LegendText = seriesCLientGantt.Name;


            chtClientGeneratorStepLine.Series.Add(seriesCLientGantt);
            chtClientGeneratorStepLine.ChartAreas[0].AlignWithChartArea = chtClientGeneratorStepLine.ChartAreas[1].Name;


            chtClientPie.Series.Add(seriesCLientPie);

            chtFastFoodStepLine.Series.Add(seriesBankStepLine);
            chtFastFoodStepLine.ChartAreas[0].AlignWithChartArea = chtFastFoodStepLine.ChartAreas[1].Name;

            chtBankStepLine.Series.Add(seriesFastFoodStepLine);
            chtBankStepLine.Series.Add(seiesFastFoodQueue);
            chtBankStepLine.ChartAreas[0].AlignWithChartArea = chtBankStepLine.ChartAreas[1].Name;

        }


        // here is the function that can reset all chart

        public void ChartReset()
        {
            chtClientPie.Series.Clear();
            chtClientPie.Titles.Clear();
            chtClientGeneratorStepLine.Series.Clear();

            chtFastFoodPie.Series.Clear();
            chtFastFoodPie.Titles.Clear();
            chtFastFoodStepLine.Series.Clear();

            chtBankPie.Series.Clear();
            chtBankPie.Titles.Clear();
            chtBankStepLine.Series.Clear();
            chtFastFoodPie.ChartAreas.Clear();
            chtBankPie.ChartAreas.Clear();
        }

        private void btnRunOneEvent_Click(object sender, EventArgs e)
        {
            Model.Run_One_Event();

            ChartShowing();

            chtBankPie.Invalidate();
            chtFastFoodPie.Invalidate();
            chtClientPie.Invalidate();

            RtbResult.Clear();

        }


        public void ChartShowing()
        {

            ChartArea ca1 = chtClientGeneratorStepLine.ChartAreas[0];
            ChartArea ca2 = chtClientGeneratorStepLine.ChartAreas[1];
            Axis ax1 = ca1.AxisX;
            Axis ax2 = ca2.AxisY;
            ax1.ScaleView.Zoomable = true;
            ax2.ScaleView.Zoomable = true;
            ca1.CursorX.IsUserSelectionEnabled = true;
            ca2.CursorY.IsUserSelectionEnabled = true;

            ChartArea ca_Pressing = chtFastFoodStepLine.ChartAreas[0];
            ChartArea ca2_Pressing = chtFastFoodStepLine.ChartAreas[1];
            Axis ax = ca_Pressing.AxisX;
            Axis axx = ca2_Pressing.AxisY;
            ax.ScaleView.Zoomable = true;
            axx.ScaleView.Zoomable = true;
            ca_Pressing.CursorX.IsUserSelectionEnabled = true;
            ca2_Pressing.CursorY.IsUserSelectionEnabled = true;

            ChartArea c = chtBankStepLine.ChartAreas[0];
            ChartArea cc = chtBankStepLine.ChartAreas[1];
            Axis a = c.AxisX;
            Axis aa = cc.AxisY;
            a.ScaleView.Zoomable = true;
            aa.ScaleView.Zoomable = true;
            c.CursorX.IsUserSelectionEnabled = true;
            cc.CursorY.IsUserSelectionEnabled = true;

        }

        private void btnRunToEnd_Click(object sender, EventArgs e)
        {
            Model.RunToEnd();
            ChartShowing();
            chtBankPie.Invalidate();
            chtFastFoodPie.Invalidate();
            chtClientPie.Invalidate();
            RtbResult.Text = Model.Get_Description();
        }

        private void btnNode_Click(object sender, EventArgs e)
        {
            Cursor = Cursor_Node;
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            Cursor =  Cursor_Server;
        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            Cursor = Cursor_Queue;
        }

        private void panelShow_Paint(object sender, PaintEventArgs e)
        {
            if (Model == null) return;
            foreach (DESElement de in Model.Elements)
            {
                de.Draw(e.Graphics, e.ClipRectangle);
            }

            if (selectedElement != null)
            {
                selectedElement.Draw_Selection_Handles(e.Graphics);
            }


        }
        bool is_Dragging;
        private void panelShow_MouseDown(object sender, MouseEventArgs e)
        {
            //座標轉換 
            current_Mouse_PNL_Point = mouse_Down_PNL_Point = e.Location;
            current_Mouse_SCR_Point = mouse_Down_SCR_Point = panelShow.PointToScreen(mouse_Down_PNL_Point);
            ControlPaint.DrawReversibleLine(mouse_Down_SCR_Point, current_Mouse_SCR_Point, Color.Red);

            Update_Rubber_Frame(mouse_Down_PNL_Point, current_Mouse_PNL_Point);
            ControlPaint.DrawReversibleFrame(rubber_SCR_Frame, Color.Blue, FrameStyle.Dashed);

            is_Dragging = false;

            for (int i = Model.Elements.Count - 1; i >= 0; i--)
            //foreach (DES_Element de in all_Element)
            {
                if (Model.Elements[i].Bound.Contains(mouse_Down_PNL_Point))
                {
                    elementStart = Model.Elements[i];
                    break;
                }
            }
        }

        private void panelShow_MouseUp(object sender, MouseEventArgs e)
        {
            ControlPaint.DrawReversibleLine(mouse_Down_SCR_Point, current_Mouse_SCR_Point, Color.Red);
            ControlPaint.DrawReversibleFrame(rubber_SCR_Frame, Color.Blue, FrameStyle.Dashed);

            current_Mouse_PNL_Point = e.Location;
            Update_Rubber_Frame(mouse_Down_PNL_Point, current_Mouse_PNL_Point);

            if (!is_Dragging && e.Button == MouseButtons.Right)
            {
                btnPointer.Checked = true;
                Cursor = Cursors.Default;
            }

            //adding DES element
            if (btnNode.Checked)
            {
                ServiceNode sn = new ServiceNode();
                sn.Bound = rubber_PNL_Frame;
                Model.Elements.Add(sn); // graphics
                Model.Nodes.Add(sn);
            }
            else if (btnServer.Checked)
            {
                //verify whether in the service node
                foreach (DESElement de in Model.Elements)
                {

                    if (de.Bound.Contains(rubber_PNL_Frame) && de is ServiceNode)
                    {
                        ServiceNode sn = (ServiceNode)de;
                        Server s = new Server(sn);

                        s.Bound = rubber_PNL_Frame;
                        Model.Elements.Add(s);

                        sn.Servers.Add(s);
                        break;
                    }
                }
            }
            else if (btnQueue.Checked)
            {
                foreach (DESElement de in Model.Elements)
                {
                    if (de.Bound.Contains(rubber_PNL_Frame) && de is ServiceNode)
                    {
                        ServiceNode sn = (ServiceNode)de;
                        TimedQueue q = new TimedQueue(sn);

                        q.Bound = rubber_PNL_Frame;
                        Model.Elements.Add(q);

                        sn.Queues.Add(q);
                        break;
                    }
                }
            }
            else if (btnClientGenrator.Checked)
            {
                ClientGenerator cg = new ClientGenerator();
                cg.Bound = rubber_PNL_Frame;
                Model.clientGenerator = cg;
                Model.SimulationEngine.Client_Generator = cg;
                Model.Elements.Add(cg); // graphics
                                               //the_Model.Client_Generator = cg;

            }
            else if (btnItinerary.Checked)
            {
                Itinerary it = new Itinerary();
                it.Bound = rubber_PNL_Frame;
                Model.Itineraries.Add(it);
                Model.Elements.Add(it); // graphics
                                               //the_Model.Client_Generator = cg;

            }

            // adding time generator
            else if (btnTime.Checked)
            {
                ExponenitalRVG exp = new ExponenitalRVG(1, 1, 1);

                foreach (DESElement de in Model.Elements)
                {
                    if (de.Bound.Contains(rubber_PNL_Frame) && de is Server)
                    {
                        Server s = (Server)de;
                        s.ServieceTimeGenrator = exp;
                        break;
                    }
                }
            }


            if (btnPointer.Checked)
            {
                if (!is_Dragging)
                //select target for editing
                {
                    //selected_Element = the_Model;
                    ppgShow.SelectedObject = Model;
                    for (int i = Model.Elements.Count - 1; i >= 0; i--)
                    //foreach (DES_Element de in all_Element)
                    {

                        if (Model.Elements[i].Bound.Contains(current_Mouse_PNL_Point))
                        {
                            selectedElement = Model.Elements[i];
                            ppgShow.SelectedObject = selectedElement;
                            break;
                        }
                    }
                }
                else
                //adding relation
                {
                    for (int i = Model.Elements.Count - 1; i >= 0; i--)
                    //foreach (DES_Element de in all_Element)
                    {
                        //if (the_Model.All_Element[i].Bound.Contains(mouse_Down_PNL_Point))
                        //{
                        //    element_Start = the_Model.All_Element[i];
                        //}
                        if (Model.Elements[i].Bound.Contains(current_Mouse_PNL_Point))
                        {
                            elementEnd = Model.Elements[i];
                            break;
                        }
                    }

                    // link server and queue
                    if (elementEnd is Server && elementStart is TimedQueue)
                    {
                        ((Server)elementEnd).Connect_A_Queue(((TimedQueue)elementStart));
                    }
                    else if (elementEnd is TimedQueue && elementStart is Server)
                    {
                        ((Server)elementStart).Connect_A_Queue(((TimedQueue)elementEnd));
                    }

                    // link node and itinerary
                    if (elementEnd is ServiceNode && elementStart is Itinerary)
                    {
                        ((Itinerary)elementStart).my_itineraries.Add(((ServiceNode)elementEnd));
                    }
                    else if (elementEnd is Itinerary && elementStart is ServiceNode)
                    {
                        ((Itinerary)elementEnd).my_itineraries.Add(((ServiceNode)elementStart));
                    }

                    // link client generator and itinerary
                    if (elementEnd is ClientGenerator && elementStart is Itinerary)
                    {
                        ((ClientGenerator)elementEnd).Add_To_Itineraries(((Itinerary)elementStart));
                    }
                    else if (elementEnd is Itinerary && elementStart is ClientGenerator)
                    {
                        ((ClientGenerator)elementStart).Add_To_Itineraries(((Itinerary)elementEnd));
                    }



                }
            }

            panelShow.Refresh();
        }

        private void panelShow_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            ControlPaint.DrawReversibleLine(mouse_Down_SCR_Point, current_Mouse_SCR_Point, Color.Red);
            ControlPaint.DrawReversibleFrame(rubber_SCR_Frame, Color.Blue, FrameStyle.Dashed);

            current_Mouse_PNL_Point = e.Location;
            if (Math.Abs(current_Mouse_PNL_Point.X - mouse_Down_PNL_Point.X) > 2 || Math.Abs(current_Mouse_PNL_Point.Y - mouse_Down_PNL_Point.Y) > 2)
                is_Dragging = true;
            current_Mouse_SCR_Point = panelShow.PointToScreen(current_Mouse_PNL_Point);
            ControlPaint.DrawReversibleLine(mouse_Down_SCR_Point, current_Mouse_SCR_Point, Color.Red);

            Update_Rubber_Frame(mouse_Down_PNL_Point, current_Mouse_PNL_Point);
            ControlPaint.DrawReversibleFrame(rubber_SCR_Frame, Color.Blue, FrameStyle.Dashed);
        }

        private void btnPointer_Click(object sender, EventArgs e)
        {
            Cursor = default;
        }

















        void Update_Rubber_Frame(Point p1, Point p2)
        {
            if (p1.X < p2.X)
            {
                rubber_PNL_Frame.X = p1.X;
                rubber_PNL_Frame.Width = p2.X - p1.X;
            }
            else
            {
                rubber_PNL_Frame.X = p2.X;
                rubber_PNL_Frame.Width = p1.X - p2.X;
            }

            if (p1.Y < p2.Y)
            {
                rubber_PNL_Frame.Y = p1.Y;
                rubber_PNL_Frame.Height = p2.Y - p1.Y;
            }
            else
            {
                rubber_PNL_Frame.Y = p2.Y;
                rubber_PNL_Frame.Height = p1.Y - p2.Y;
            }

            rubber_SCR_Frame = panelShow.RectangleToScreen(rubber_PNL_Frame);
        }
    }
}
