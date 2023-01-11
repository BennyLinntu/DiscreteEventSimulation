using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.Generic;

namespace R10546039YDLINAss05
{
    public partial class MainForm : Form
    {
        public int NumberofNodes;
        public int NumberofPaths;
        public List<List<int>> PathsofAll = new List<List<int>>(); // here we Count the Path
        public List<List<int>> PathsofAllLengths = new List<List<int>>(); // here we Count the Length of Paths
        double[,] NodeLocation;
        int[,] PathPointToPoint;
        public MainForm()
        {
            InitializeComponent();
        }
        // Random Matrix
        private void btnRandomMatricesSimulate_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            RandomNumberGeneration rng = new RandomNumberGeneration();
            int Seed = int.MinValue;
            int PositiveNumber = 0;
            if(cbSeed.Text == "Auto")
            {
                Seed = r.Next(0, 999999999);
            }
            else
            {
                Seed = Convert.ToInt32(cbSeed.Text);
            }
            PositiveNumber =  rng.RandomMatrix(Convert.ToInt32(tbReplications.Text), Seed);
            rtbPositiveDeterminantProbability.Text += $"\nProbability = {PositiveNumber} / {tbReplications.Text} = {PositiveNumber / (Convert.ToDouble(tbReplications.Text))}";

        }
        // Gambling Craps
        private void btnGamblingCrapsSimulate_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            RandomNumberGeneration rng = new RandomNumberGeneration();
            int Seed = int.MinValue;
            int WinCount = 0;
            if (cbSeed.Text == "Auto")
            {
                Seed = r.Next(0, 999999999);
            }
            else
            {
                Seed = Convert.ToInt32(cbSeed.Text);
            }
            WinCount = rng.GamblingCraps(Convert.ToInt32(tbReplications.Text), Seed);
            rtbGamblingCraps.Text += $"\nProbability = ({WinCount} / {Convert.ToInt32(tbReplications.Text)}) = {WinCount / Convert.ToDouble(tbReplications.Text)}";

        }
        // Hatcheck Girl
        private void btnHatcheckGirlSimulate_Click(object sender, EventArgs e)
        {
            
            Random r = new Random();
            RandomNumberGeneration rng = new RandomNumberGeneration();
            int Seed = int.MinValue;
            int NumberofCustomer = Convert.ToInt32(tbNumberofCustomers.Text);
            int Number = 0;
            if (cbSeed.Text == "Auto")
            {
                Seed = r.Next(0, 999999999);
            }
            else
            {
                Seed = Convert.ToInt32(cbSeed.Text);
            }
            Number = rng.HatcheckGirl(Convert.ToInt32(tbReplications.Text), NumberofCustomer, Seed);
            rtbhatcheckGirl.Text += $"\nProbability = ({Number} / {Convert.ToInt32(tbReplications.Text)}) = {Number / Convert.ToDouble(tbReplications.Text)}";
        }
        //Stochastic Activity Networks
        private void btnStochasticActivityNetworksSimulate_Click(object sender, EventArgs e)
        {
            // Draw the picture
            for (int m = 0; m < NumberofNodes; m++)
            {
                // here we Draw the Circle
                // first need to Count the width and height
                int width = Convert.ToInt32(rtbResult.Width * NodeLocation[m, 0]);
                int height = Convert.ToInt32(rtbResult.Height * NodeLocation[m, 1]);
                Graphics g = rtbResult.CreateGraphics();
                Font f = new Font("f", 20);
                Rectangle rte = new Rectangle(width, height, 40, 40);
                StringFormat str = new StringFormat();
                str.Alignment = StringAlignment.Center;
                str.LineAlignment = StringAlignment.Center;
                g.FillEllipse(Brushes.White, rte);
                Pen p = new Pen(Color.Gray, 5);
                g.DrawEllipse(p, rte);
                g.DrawString((m + 1).ToString(), f, Brushes.Black, rte, str);
            }
            // here we Draw the Line in our picture
            for (int k = 0; k < NumberofPaths; k++)
            {
                double point_1_x = Convert.ToDouble(rtbResult.Width * NodeLocation[PathPointToPoint[k, 0], 0]);
                double point_1_y = Convert.ToDouble(rtbResult.Height * NodeLocation[PathPointToPoint[k, 0], 1]);
                double point_2_x = Convert.ToDouble(rtbResult.Width * NodeLocation[PathPointToPoint[k, 1], 0]);
                double point_2_y = Convert.ToDouble(rtbResult.Height * NodeLocation[PathPointToPoint[k, 1], 1]);
                double pathlength = PathPointToPoint[k, 2];
                double xlength = Math.Abs(point_1_x - point_2_x);
                double ylength = Math.Abs(point_1_y - point_2_y);
                Graphics g = rtbResult.CreateGraphics();
                Rectangle rte = new Rectangle(Convert.ToInt32(point_1_x + 0.5 * xlength), Convert.ToInt32(point_1_y + 0.5 * ylength), 40, 40);
                Point point_1 = new Point(Convert.ToInt32(point_1_x) + 15, Convert.ToInt32(point_1_y) + 25);
                Point Point_2 = new Point(Convert.ToInt32(point_2_x) + 15, Convert.ToInt32(point_2_y) + 25);
                Font f = new Font("f", 10);
                Pen p = new Pen(Color.Red, 5);
                p.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                g.DrawLine(p, point_1, Point_2);
                g.DrawString(pathlength.ToString(), f, Brushes.Black, rte);
            }
            // here we show the answer in our label
            Random r = new Random();
            RandomNumberGeneration rng = new RandomNumberGeneration();
            List<double> result = new List<double>();
            int Seed = int.MinValue;
            int pathCOUNT = PathsofAll.Count;
            if (cbSeed.Text == "Auto")
            {
                Seed = r.Next(0, 999999999);
            }
            else
            {
                Seed = Convert.ToInt32(cbSeed.Text);
            }
            result = rng.StochasticActivityNetWork(Convert.ToInt32(tbReplications.Text), Seed,  pathCOUNT,PathsofAllLengths);
            labelShow.Text = $"Simulate Results:\nMeanCompletion Time:\n{result[0]}\n";
            labelShow.Text += $"Probabilities of Critical Path:\n";
            // same as the before
            for (int j = 0; j < PathsofAll.Count; j++)
            {
                for (int k = 0; k < PathsofAll[j].Count; k++)
                {
                    if (k == PathsofAll[j].Count)
                    {
                        labelShow.Text += (PathsofAll[j][k] + 1).ToString();
                    }
                    else
                    {
                        labelShow.Text += (PathsofAll[j][k] + 1).ToString() + " -> ";
                    }
                }
                labelShow.Text += $" Prob = {result[j + 1] / Convert.ToDouble(tbReplications.Text)}\n";
            }
        }

        // open file and show the file
        public void btnOpenProjectFile_Click(object sender, EventArgs e)
        {
            // when you open a file the rich box need clear
            rtbShowData.Clear();
            
            string[] ReadLine;
            char[] seps = { ' ', ',' };
            
            // here we clean the picture
            Graphics cp = rtbResult.CreateGraphics();
            cp.Clear(rtbResult.BackColor);
            // and do the check then, open the data
            if (dlgOpen.ShowDialog() != DialogResult.OK) return;
            StreamReader sr = new StreamReader(dlgOpen.FileName);
            NumberofNodes = Convert.ToInt32(sr.ReadLine()); // here we read in the Number of nodes
            rtbShowData.Text += $"{NumberofNodes}\n";
            NodeLocation = new double[NumberofNodes, 2]; // here we get the X, and Y
            for (int i = 0; i < NumberofNodes; i++)
            {
                ReadLine = sr.ReadLine().Split(seps, StringSplitOptions.RemoveEmptyEntries);
                NodeLocation[i, 0] = Convert.ToDouble(ReadLine[0]); // give the first
                NodeLocation[i, 1] = Convert.ToDouble(ReadLine[1]); // here we give the second
                rtbShowData.Text += $"{NodeLocation[i, 0].ToString()} {NodeLocation[i, 0].ToString()}\n";
            }
            NumberofPaths = Convert.ToInt32(sr.ReadLine()); // here we read the Path
            rtbShowData.Text += $"{NumberofPaths}\n";
            PathPointToPoint = new int[NumberofPaths, 3]; // here we know the Node from and the Time of Path or Cost 
            for (int j= 0; j < NumberofPaths; j++)
            {
                ReadLine = sr.ReadLine().Split(seps, StringSplitOptions.RemoveEmptyEntries);
                PathPointToPoint[j, 0] = Convert.ToInt32(ReadLine[0]);
                PathPointToPoint[j, 1] = Convert.ToInt32(ReadLine[1]);
                PathPointToPoint[j, 2] = Convert.ToInt32(ReadLine[2]);
                rtbShowData.Text += $"{PathPointToPoint[j, 0].ToString()} {PathPointToPoint[j, 0].ToString()} {PathPointToPoint[j, 2].ToString()}\n";
            }
            // here to show the File Name
            labelFilePath.Text = $"File Name:\n{Path.GetFileName(dlgOpen.FileName)}\nFile Content:";
            sr.Close();
            // here we show all path
            List<int> s = new List<int>();
            List<int> q = new List<int>();
            CountPath(s, q, 0, 0);
            for (int j = 0; j < PathsofAll.Count; j++)
            {
                for (int k = 0; k < PathsofAll[j].Count; k++)
                {
                    if(k == PathsofAll[j].Count - 1)
                    {
                        rtbShowData.Text += (PathsofAll[j][k] + 1).ToString() + " Length = " + PathsofAll[j].Sum().ToString() + "\n";
                    }
                    else
                    {
                        rtbShowData.Text += (PathsofAll[j][k] + 1).ToString() + " -> ";
                    }
                }
            }
            // here we show the Butten
            btnStochasticActivityNetworksSimulate.Enabled = true;
            btnSave.Enabled = true;

        }
        // Save the File
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dlgSave.ShowDialog() != DialogResult.OK) return ;
            StreamWriter sw = new StreamWriter(dlgSave.FileName);
            sw.WriteLine(NumberofNodes);
            for (int i = 0; i < NumberofNodes; i++)
            {
                sw.WriteLine(NodeLocation[i, 0].ToString() + " " + NodeLocation[i, 1].ToString()); 
            }
            sw.WriteLine(NumberofPaths);
            for (int j = 0; j < NumberofPaths; j++)
            {
                sw.WriteLine(PathPointToPoint[j, 0].ToString() + " " + PathPointToPoint[j, 1].ToString() + " " + PathPointToPoint[j, 2].ToString());
            }
            sw.Close();
        }
        // clean the rtb show, here we clean the picture and the text of richbox
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            rtbResult.Clear();
            Graphics g = rtbResult.CreateGraphics();
            g.Clear(Color.White);

        }
        // clean the Ranmd matrix
        private void btnRandomMatricesClean_Click(object sender, EventArgs e)
        {
            rtbPositiveDeterminantProbability.Text = $"Positive Determinant Probability:";
        }
        // clean the Gambling Craps
        private void btnGamblingCrapsClear_Click(object sender, EventArgs e)
        {
            rtbGamblingCraps.Text = $"Probability of Winning the Craps Game:";
        }
        // clean the Hatch Girl
        private void btnHatcheckGirlClear_Click(object sender, EventArgs e)
        {
            rtbhatcheckGirl.Text = $"Probability of All Hats Returned Wrong:";
        }
        // count the paths in the data, here agrithm is from web, others
        public void CountPath(List<int> a, List<int> b, int c, int d)
        {
            a.Add(c);
            b.Add(d);
            if (c == NumberofNodes - 1)
            {
                PathsofAll.Add(a);
                PathsofAllLengths.Add(b);
            }
            for (int i = 0; i < NumberofPaths; i++)
            {
                
                if (PathPointToPoint[i, 0] == c)
                {
                    List<int> e = new List<int>();
                    e = a.ToList();
                    List<int> f = new List<int>();
                    f = b.ToList();
                    CountPath(e, f, PathPointToPoint[i, 1], PathPointToPoint[i, 2]);
                }
            }
        }


    }
}
