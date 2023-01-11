
namespace R10546039YDLINAss06
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnOpenFile = new System.Windows.Forms.ToolStripButton();
            this.btnSaveFile = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl_1 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ppgLandU = new System.Windows.Forms.PropertyGrid();
            this.ppgAverage = new System.Windows.Forms.PropertyGrid();
            this.cbDynamicStochastic = new System.Windows.Forms.CheckBox();
            this.btnSimulateStochasticCase = new System.Windows.Forms.Button();
            this.cbSeed = new System.Windows.Forms.ComboBox();
            this.tbNumberofjobsRandom = new System.Windows.Forms.TextBox();
            this.tbUpperServiceTime = new System.Windows.Forms.TextBox();
            this.tbLowerServiceTime = new System.Windows.Forms.TextBox();
            this.tbInterarrivalTime = new System.Windows.Forms.TextBox();
            this.tabControl_2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbJobinService = new System.Windows.Forms.CheckBox();
            this.cbJobinQueue = new System.Windows.Forms.CheckBox();
            this.cbJobinNode = new System.Windows.Forms.CheckBox();
            this.labelTAJS = new System.Windows.Forms.Label();
            this.labelTAJQ = new System.Windows.Forms.Label();
            this.labelTAJN = new System.Windows.Forms.Label();
            this.labelAWT = new System.Windows.Forms.Label();
            this.labelADT = new System.Windows.Forms.Label();
            this.labelAST = new System.Windows.Forms.Label();
            this.labelAIT = new System.Windows.Forms.Label();
            this.chtJobCount = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbNOT = new System.Windows.Forms.TextBox();
            this.tbSTFFTU = new System.Windows.Forms.TextBox();
            this.tbSTFFTL = new System.Windows.Forms.TextBox();
            this.chtSteadStateTest = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelNOT = new System.Windows.Forms.Label();
            this.labelSTFFT = new System.Windows.Forms.Label();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.btngetSteadyState = new System.Windows.Forms.Button();
            this.labelAWTALR = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl_1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabControl_2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtJobCount)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtSteadStateTest)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpenFile,
            this.btnSaveFile});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1630, 30);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "ToolStrip";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenFile.Image")));
            this.btnOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(76, 27);
            this.btnOpenFile.Text = "Open";
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Enabled = false;
            this.btnSaveFile.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveFile.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveFile.Image")));
            this.btnSaveFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(69, 27);
            this.btnSaveFile.Text = "Save";
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 30);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl_1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl_2);
            this.splitContainer1.Size = new System.Drawing.Size(1630, 834);
            this.splitContainer1.SplitterDistance = 532;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 1;
            // 
            // tabControl_1
            // 
            this.tabControl_1.Controls.Add(this.tabPage5);
            this.tabControl_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_1.Location = new System.Drawing.Point(0, 0);
            this.tabControl_1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabControl_1.Name = "tabControl_1";
            this.tabControl_1.SelectedIndex = 0;
            this.tabControl_1.Size = new System.Drawing.Size(532, 834);
            this.tabControl_1.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label14);
            this.tabPage5.Controls.Add(this.label13);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.ppgLandU);
            this.tabPage5.Controls.Add(this.ppgAverage);
            this.tabPage5.Controls.Add(this.cbDynamicStochastic);
            this.tabPage5.Controls.Add(this.btnSimulateStochasticCase);
            this.tabPage5.Controls.Add(this.cbSeed);
            this.tabPage5.Controls.Add(this.tbNumberofjobsRandom);
            this.tabPage5.Controls.Add(this.tbUpperServiceTime);
            this.tabPage5.Controls.Add(this.tbLowerServiceTime);
            this.tabPage5.Controls.Add(this.tbInterarrivalTime);
            this.tabPage5.Location = new System.Drawing.Point(4, 31);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(524, 799);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Stochastic";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Brown;
            this.label14.Location = new System.Drawing.Point(25, 315);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 21);
            this.label14.TabIndex = 17;
            this.label14.Text = "Lower Bound:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Brown;
            this.label13.Location = new System.Drawing.Point(23, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(172, 21);
            this.label13.TabIndex = 16;
            this.label13.Text = "Exponential Disri.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 561);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(164, 23);
            this.label12.TabIndex = 15;
            this.label12.Text = "Number of Jobs";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 505);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 23);
            this.label11.TabIndex = 14;
            this.label11.Text = "Seed";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Brown;
            this.label10.Location = new System.Drawing.Point(23, 385);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 21);
            this.label10.TabIndex = 13;
            this.label10.Text = "Upper Bound:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Brown;
            this.label8.Location = new System.Drawing.Point(23, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 21);
            this.label8.TabIndex = 12;
            this.label8.Text = "Uniform Distri.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Brown;
            this.label9.Location = new System.Drawing.Point(23, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 21);
            this.label9.TabIndex = 11;
            this.label9.Text = "Service Time:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Brown;
            this.label7.Location = new System.Drawing.Point(31, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "Average:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Brown;
            this.label6.Location = new System.Drawing.Point(23, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Interarrival Time:";
            // 
            // ppgLandU
            // 
            this.ppgLandU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ppgLandU.Location = new System.Drawing.Point(218, 268);
            this.ppgLandU.Name = "ppgLandU";
            this.ppgLandU.Size = new System.Drawing.Size(284, 208);
            this.ppgLandU.TabIndex = 8;
            // 
            // ppgAverage
            // 
            this.ppgAverage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ppgAverage.Location = new System.Drawing.Point(218, 16);
            this.ppgAverage.Name = "ppgAverage";
            this.ppgAverage.Size = new System.Drawing.Size(284, 217);
            this.ppgAverage.TabIndex = 7;
            // 
            // cbDynamicStochastic
            // 
            this.cbDynamicStochastic.AutoSize = true;
            this.cbDynamicStochastic.Checked = true;
            this.cbDynamicStochastic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDynamicStochastic.Location = new System.Drawing.Point(29, 719);
            this.cbDynamicStochastic.Name = "cbDynamicStochastic";
            this.cbDynamicStochastic.Size = new System.Drawing.Size(393, 27);
            this.cbDynamicStochastic.TabIndex = 6;
            this.cbDynamicStochastic.Text = "Dynamic Stochastic(not array-based)";
            this.cbDynamicStochastic.UseVisualStyleBackColor = true;
            // 
            // btnSimulateStochasticCase
            // 
            this.btnSimulateStochasticCase.Location = new System.Drawing.Point(29, 623);
            this.btnSimulateStochasticCase.Name = "btnSimulateStochasticCase";
            this.btnSimulateStochasticCase.Size = new System.Drawing.Size(371, 55);
            this.btnSimulateStochasticCase.TabIndex = 5;
            this.btnSimulateStochasticCase.Text = "Simulate Stochastic Case";
            this.btnSimulateStochasticCase.UseVisualStyleBackColor = true;
            this.btnSimulateStochasticCase.Click += new System.EventHandler(this.btnSimulateStochasticCase_Click);
            // 
            // cbSeed
            // 
            this.cbSeed.FormattingEnabled = true;
            this.cbSeed.Items.AddRange(new object[] {
            "New Random",
            "12345",
            "54321",
            "212121"});
            this.cbSeed.Location = new System.Drawing.Point(218, 502);
            this.cbSeed.Name = "cbSeed";
            this.cbSeed.Size = new System.Drawing.Size(155, 30);
            this.cbSeed.TabIndex = 4;
            this.cbSeed.Text = "New Random";
            // 
            // tbNumberofjobsRandom
            // 
            this.tbNumberofjobsRandom.Location = new System.Drawing.Point(218, 555);
            this.tbNumberofjobsRandom.Name = "tbNumberofjobsRandom";
            this.tbNumberofjobsRandom.Size = new System.Drawing.Size(155, 29);
            this.tbNumberofjobsRandom.TabIndex = 3;
            this.tbNumberofjobsRandom.Text = "1000";
            // 
            // tbUpperServiceTime
            // 
            this.tbUpperServiceTime.Location = new System.Drawing.Point(29, 409);
            this.tbUpperServiceTime.Name = "tbUpperServiceTime";
            this.tbUpperServiceTime.Size = new System.Drawing.Size(100, 29);
            this.tbUpperServiceTime.TabIndex = 2;
            this.tbUpperServiceTime.Text = "2.0";
            // 
            // tbLowerServiceTime
            // 
            this.tbLowerServiceTime.Location = new System.Drawing.Point(29, 339);
            this.tbLowerServiceTime.Name = "tbLowerServiceTime";
            this.tbLowerServiceTime.Size = new System.Drawing.Size(100, 29);
            this.tbLowerServiceTime.TabIndex = 1;
            this.tbLowerServiceTime.Text = "1.0";
            // 
            // tbInterarrivalTime
            // 
            this.tbInterarrivalTime.Location = new System.Drawing.Point(29, 135);
            this.tbInterarrivalTime.Name = "tbInterarrivalTime";
            this.tbInterarrivalTime.Size = new System.Drawing.Size(100, 29);
            this.tbInterarrivalTime.TabIndex = 0;
            this.tbInterarrivalTime.Text = "2.0";
            // 
            // tabControl_2
            // 
            this.tabControl_2.Controls.Add(this.tabPage3);
            this.tabControl_2.Controls.Add(this.tabPage4);
            this.tabControl_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_2.Location = new System.Drawing.Point(0, 0);
            this.tabControl_2.Name = "tabControl_2";
            this.tabControl_2.SelectedIndex = 0;
            this.tabControl_2.Size = new System.Drawing.Size(1092, 834);
            this.tabControl_2.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage3.Controls.Add(this.cbJobinService);
            this.tabPage3.Controls.Add(this.cbJobinQueue);
            this.tabPage3.Controls.Add(this.cbJobinNode);
            this.tabPage3.Controls.Add(this.labelTAJS);
            this.tabPage3.Controls.Add(this.labelTAJQ);
            this.tabPage3.Controls.Add(this.labelTAJN);
            this.tabPage3.Controls.Add(this.labelAWT);
            this.tabPage3.Controls.Add(this.labelADT);
            this.tabPage3.Controls.Add(this.labelAST);
            this.tabPage3.Controls.Add(this.labelAIT);
            this.tabPage3.Controls.Add(this.chtJobCount);
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1084, 799);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Simulate Job Processing";
            // 
            // cbJobinService
            // 
            this.cbJobinService.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbJobinService.AutoSize = true;
            this.cbJobinService.Checked = true;
            this.cbJobinService.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbJobinService.Enabled = false;
            this.cbJobinService.Location = new System.Drawing.Point(787, 268);
            this.cbJobinService.Name = "cbJobinService";
            this.cbJobinService.Size = new System.Drawing.Size(180, 27);
            this.cbJobinService.TabIndex = 14;
            this.cbJobinService.Text = "Jobs in Service";
            this.cbJobinService.UseVisualStyleBackColor = true;
            this.cbJobinService.CheckedChanged += new System.EventHandler(this.cbJobinService_CheckedChanged);
            // 
            // cbJobinQueue
            // 
            this.cbJobinQueue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbJobinQueue.AutoSize = true;
            this.cbJobinQueue.Checked = true;
            this.cbJobinQueue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbJobinQueue.Enabled = false;
            this.cbJobinQueue.Location = new System.Drawing.Point(419, 268);
            this.cbJobinQueue.Name = "cbJobinQueue";
            this.cbJobinQueue.Size = new System.Drawing.Size(173, 27);
            this.cbJobinQueue.TabIndex = 13;
            this.cbJobinQueue.Text = "Jobs in Queue";
            this.cbJobinQueue.UseVisualStyleBackColor = true;
            this.cbJobinQueue.CheckedChanged += new System.EventHandler(this.cbJobinQueue_CheckedChanged);
            // 
            // cbJobinNode
            // 
            this.cbJobinNode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbJobinNode.AutoSize = true;
            this.cbJobinNode.Checked = true;
            this.cbJobinNode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbJobinNode.Enabled = false;
            this.cbJobinNode.Location = new System.Drawing.Point(30, 268);
            this.cbJobinNode.Name = "cbJobinNode";
            this.cbJobinNode.Size = new System.Drawing.Size(159, 27);
            this.cbJobinNode.TabIndex = 12;
            this.cbJobinNode.Text = "Jobs in Node";
            this.cbJobinNode.UseVisualStyleBackColor = true;
            this.cbJobinNode.CheckedChanged += new System.EventHandler(this.cbJobinNode_CheckedChanged);
            // 
            // labelTAJS
            // 
            this.labelTAJS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTAJS.AutoSize = true;
            this.labelTAJS.ForeColor = System.Drawing.Color.DarkRed;
            this.labelTAJS.Location = new System.Drawing.Point(715, 168);
            this.labelTAJS.Name = "labelTAJS";
            this.labelTAJS.Size = new System.Drawing.Size(323, 23);
            this.labelTAJS.TabIndex = 8;
            this.labelTAJS.Text = "Time_Averaged Jobs in Service:";
            // 
            // labelTAJQ
            // 
            this.labelTAJQ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTAJQ.AutoSize = true;
            this.labelTAJQ.ForeColor = System.Drawing.Color.DarkRed;
            this.labelTAJQ.Location = new System.Drawing.Point(715, 120);
            this.labelTAJQ.Name = "labelTAJQ";
            this.labelTAJQ.Size = new System.Drawing.Size(319, 23);
            this.labelTAJQ.TabIndex = 7;
            this.labelTAJQ.Text = "Time_averaged Jobs  in Queue:";
            // 
            // labelTAJN
            // 
            this.labelTAJN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTAJN.AutoSize = true;
            this.labelTAJN.ForeColor = System.Drawing.Color.DarkRed;
            this.labelTAJN.Location = new System.Drawing.Point(715, 70);
            this.labelTAJN.Name = "labelTAJN";
            this.labelTAJN.Size = new System.Drawing.Size(299, 23);
            this.labelTAJN.TabIndex = 6;
            this.labelTAJN.Text = "Time_averaged Jobs in Node:";
            // 
            // labelAWT
            // 
            this.labelAWT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelAWT.AutoSize = true;
            this.labelAWT.ForeColor = System.Drawing.Color.Indigo;
            this.labelAWT.Location = new System.Drawing.Point(37, 205);
            this.labelAWT.Name = "labelAWT";
            this.labelAWT.Size = new System.Drawing.Size(205, 23);
            this.labelAWT.TabIndex = 5;
            this.labelAWT.Text = "Average Wait Time:";
            // 
            // labelADT
            // 
            this.labelADT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelADT.AutoSize = true;
            this.labelADT.ForeColor = System.Drawing.Color.Indigo;
            this.labelADT.Location = new System.Drawing.Point(37, 151);
            this.labelADT.Name = "labelADT";
            this.labelADT.Size = new System.Drawing.Size(215, 23);
            this.labelADT.TabIndex = 4;
            this.labelADT.Text = "Average Delay Time:";
            // 
            // labelAST
            // 
            this.labelAST.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelAST.AutoSize = true;
            this.labelAST.ForeColor = System.Drawing.Color.Indigo;
            this.labelAST.Location = new System.Drawing.Point(37, 103);
            this.labelAST.Name = "labelAST";
            this.labelAST.Size = new System.Drawing.Size(229, 23);
            this.labelAST.TabIndex = 3;
            this.labelAST.Text = "Average Service Time:";
            // 
            // labelAIT
            // 
            this.labelAIT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelAIT.AutoSize = true;
            this.labelAIT.ForeColor = System.Drawing.Color.Indigo;
            this.labelAIT.Location = new System.Drawing.Point(37, 48);
            this.labelAIT.Name = "labelAIT";
            this.labelAIT.Size = new System.Drawing.Size(275, 23);
            this.labelAIT.TabIndex = 2;
            this.labelAIT.Text = "Average Interarrival Time:";
            // 
            // chtJobCount
            // 
            this.chtJobCount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            chartArea3.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea3.AxisX.Title = "Time";
            chartArea3.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea3.AxisY.Title = "Count";
            chartArea3.Name = "ChartArea1";
            this.chtJobCount.ChartAreas.Add(chartArea3);
            this.chtJobCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chtJobCount.Legends.Add(legend2);
            this.chtJobCount.Location = new System.Drawing.Point(3, 386);
            this.chtJobCount.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chtJobCount.Name = "chtJobCount";
            this.chtJobCount.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series4.Legend = "Legend1";
            series4.Name = "Job in Node l(t)";
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series5.Color = System.Drawing.Color.DarkGreen;
            series5.Legend = "Legend1";
            series5.Name = "Job in Queue q(t)";
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series6.Color = System.Drawing.Color.Blue;
            series6.Legend = "Legend1";
            series6.Name = "Job in Service x(t)";
            this.chtJobCount.Series.Add(series4);
            this.chtJobCount.Series.Add(series5);
            this.chtJobCount.Series.Add(series6);
            this.chtJobCount.Size = new System.Drawing.Size(1078, 410);
            this.chtJobCount.TabIndex = 1;
            this.chtJobCount.Text = "chart1";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tabPage4.Controls.Add(this.labelAWTALR);
            this.tabPage4.Controls.Add(this.btngetSteadyState);
            this.tabPage4.Controls.Add(this.btnClear);
            this.tabPage4.Controls.Add(this.tbNOT);
            this.tabPage4.Controls.Add(this.tbSTFFTU);
            this.tabPage4.Controls.Add(this.tbSTFFTL);
            this.tabPage4.Controls.Add(this.chtSteadStateTest);
            this.tabPage4.Controls.Add(this.labelNOT);
            this.tabPage4.Controls.Add(this.labelSTFFT);
            this.tabPage4.Location = new System.Drawing.Point(4, 31);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1084, 799);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Steady State Test";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(856, 153);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(178, 48);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbNOT
            // 
            this.tbNOT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbNOT.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNOT.Location = new System.Drawing.Point(258, 163);
            this.tbNOT.Name = "tbNOT";
            this.tbNOT.Size = new System.Drawing.Size(100, 32);
            this.tbNOT.TabIndex = 5;
            this.tbNOT.Text = "50";
            // 
            // tbSTFFTU
            // 
            this.tbSTFFTU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbSTFFTU.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSTFFTU.Location = new System.Drawing.Point(523, 55);
            this.tbSTFFTU.Name = "tbSTFFTU";
            this.tbSTFFTU.Size = new System.Drawing.Size(100, 32);
            this.tbSTFFTU.TabIndex = 4;
            this.tbSTFFTU.Text = "1000";
            // 
            // tbSTFFTL
            // 
            this.tbSTFFTL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbSTFFTL.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSTFFTL.Location = new System.Drawing.Point(350, 55);
            this.tbSTFFTL.Name = "tbSTFFTL";
            this.tbSTFFTL.Size = new System.Drawing.Size(100, 32);
            this.tbSTFFTL.TabIndex = 3;
            this.tbSTFFTL.Text = "20";
            // 
            // chtSteadStateTest
            // 
            chartArea4.AxisX.Title = "Average Wait Time";
            chartArea4.AxisY.Title = "Number of Test";
            chartArea4.Name = "ChartArea1";
            this.chtSteadStateTest.ChartAreas.Add(chartArea4);
            this.chtSteadStateTest.DataSource = this.chtJobCount.Images;
            this.chtSteadStateTest.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chtSteadStateTest.Location = new System.Drawing.Point(3, 300);
            this.chtSteadStateTest.Name = "chtSteadStateTest";
            this.chtSteadStateTest.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            this.chtSteadStateTest.Size = new System.Drawing.Size(1078, 496);
            this.chtSteadStateTest.TabIndex = 2;
            this.chtSteadStateTest.Text = "Stead State Test";
            title2.BorderWidth = 2;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Stead State Test";
            title2.Text = "Stead State Test";
            this.chtSteadStateTest.Titles.Add(title2);
            // 
            // labelNOT
            // 
            this.labelNOT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNOT.AutoSize = true;
            this.labelNOT.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNOT.Location = new System.Drawing.Point(57, 172);
            this.labelNOT.Name = "labelNOT";
            this.labelNOT.Size = new System.Drawing.Size(179, 23);
            this.labelNOT.TabIndex = 1;
            this.labelNOT.Text = "Number of Tests";
            // 
            // labelSTFFT
            // 
            this.labelSTFFT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSTFFT.AutoSize = true;
            this.labelSTFFT.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSTFFT.Location = new System.Drawing.Point(50, 64);
            this.labelSTFFT.Name = "labelSTFFT";
            this.labelSTFFT.Size = new System.Drawing.Size(573, 23);
            this.labelSTFFT.TabIndex = 0;
            this.labelSTFFT.Text = "Service Time Factors From                    to                  ";
            // 
            // dlgOpen
            // 
            this.dlgOpen.DefaultExt = "dat";
            this.dlgOpen.FileName = "*.dat";
            this.dlgOpen.Title = "Open the data file";
            // 
            // btngetSteadyState
            // 
            this.btngetSteadyState.Location = new System.Drawing.Point(523, 153);
            this.btngetSteadyState.Name = "btngetSteadyState";
            this.btngetSteadyState.Size = new System.Drawing.Size(183, 48);
            this.btngetSteadyState.TabIndex = 8;
            this.btngetSteadyState.Text = "Simulation";
            this.btngetSteadyState.UseVisualStyleBackColor = true;
            this.btngetSteadyState.Click += new System.EventHandler(this.btngetSteadyState_Click);
            // 
            // labelAWTALR
            // 
            this.labelAWTALR.AutoSize = true;
            this.labelAWTALR.Location = new System.Drawing.Point(62, 246);
            this.labelAWTALR.Name = "labelAWTALR";
            this.labelAWTALR.Size = new System.Drawing.Size(0, 23);
            this.labelAWTALR.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1630, 864);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assignment 002 Single Server Queue Demo 2022";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl_1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabControl_2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtJobCount)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtSteadStateTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnOpenFile;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl_1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtJobCount;
        private System.Windows.Forms.ToolStripButton btnSaveFile;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.TabControl tabControl_2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckBox cbJobinService;
        private System.Windows.Forms.CheckBox cbJobinQueue;
        private System.Windows.Forms.CheckBox cbJobinNode;
        private System.Windows.Forms.Label labelTAJS;
        private System.Windows.Forms.Label labelTAJQ;
        private System.Windows.Forms.Label labelTAJN;
        private System.Windows.Forms.Label labelAWT;
        private System.Windows.Forms.Label labelADT;
        private System.Windows.Forms.Label labelAST;
        private System.Windows.Forms.Label labelAIT;
        private System.Windows.Forms.TextBox tbNOT;
        private System.Windows.Forms.TextBox tbSTFFTU;
        private System.Windows.Forms.TextBox tbSTFFTL;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtSteadStateTest;
        private System.Windows.Forms.Label labelNOT;
        private System.Windows.Forms.Label labelSTFFT;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PropertyGrid ppgLandU;
        private System.Windows.Forms.PropertyGrid ppgAverage;
        private System.Windows.Forms.CheckBox cbDynamicStochastic;
        private System.Windows.Forms.Button btnSimulateStochasticCase;
        private System.Windows.Forms.ComboBox cbSeed;
        private System.Windows.Forms.TextBox tbNumberofjobsRandom;
        private System.Windows.Forms.TextBox tbUpperServiceTime;
        private System.Windows.Forms.TextBox tbLowerServiceTime;
        private System.Windows.Forms.TextBox tbInterarrivalTime;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btngetSteadyState;
        private System.Windows.Forms.Label labelAWTALR;
    }
}

