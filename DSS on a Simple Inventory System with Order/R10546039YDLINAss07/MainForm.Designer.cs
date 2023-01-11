
namespace R10546039YDLINAss07
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tscbSeed = new System.Windows.Forms.ToolStripComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tc = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tbBatchrun = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbFeedbackProbability = new System.Windows.Forms.TextBox();
            this.btnBatchRun = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.ppgAverage = new System.Windows.Forms.PropertyGrid();
            this.btnFeedbackSimulate = new System.Windows.Forms.Button();
            this.tbNumberofjobsRandom = new System.Windows.Forms.TextBox();
            this.cbDeliveryLag = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIntervals = new System.Windows.Forms.TextBox();
            this.cbLag = new System.Windows.Forms.CheckBox();
            this.btnFindOptimalMininumLevel = new System.Windows.Forms.Button();
            this.btnDeliveryLagSimulate = new System.Windows.Forms.Button();
            this.ppgDeliveryLag = new System.Windows.Forms.PropertyGrid();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ppgMachineShop = new System.Windows.Forms.PropertyGrid();
            this.btnMultipleRuns = new System.Windows.Forms.Button();
            this.btnMachineShopSimulate = new System.Windows.Forms.Button();
            this.tabControl_2 = new System.Windows.Forms.TabControl();
            this.background = new System.Windows.Forms.TabPage();
            this.rtbShow = new System.Windows.Forms.RichTextBox();
            this.cbJobinService = new System.Windows.Forms.CheckBox();
            this.cbJobinQueue = new System.Windows.Forms.CheckBox();
            this.cbJobinNode = new System.Windows.Forms.CheckBox();
            this.chtJobCount = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tc.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.cbDeliveryLag.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl_2.SuspendLayout();
            this.background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtJobCount)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tscbSeed});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1630, 28);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "ToolStrip";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(42, 25);
            this.toolStripLabel1.Text = "Seed";
            // 
            // tscbSeed
            // 
            this.tscbSeed.Items.AddRange(new object[] {
            "New Random",
            "12345",
            "54321",
            "121212"});
            this.tscbSeed.Name = "tscbSeed";
            this.tscbSeed.Size = new System.Drawing.Size(121, 28);
            this.tscbSeed.Text = "New Random";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tc);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl_2);
            this.splitContainer1.Size = new System.Drawing.Size(1630, 836);
            this.splitContainer1.SplitterDistance = 532;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 1;
            // 
            // tc
            // 
            this.tc.Controls.Add(this.tabPage5);
            this.tc.Controls.Add(this.cbDeliveryLag);
            this.tc.Controls.Add(this.tabPage2);
            this.tc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc.Location = new System.Drawing.Point(0, 0);
            this.tc.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            this.tc.Size = new System.Drawing.Size(532, 836);
            this.tc.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.tbBatchrun);
            this.tabPage5.Controls.Add(this.label1);
            this.tabPage5.Controls.Add(this.label14);
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.tbFeedbackProbability);
            this.tabPage5.Controls.Add(this.btnBatchRun);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.ppgAverage);
            this.tabPage5.Controls.Add(this.btnFeedbackSimulate);
            this.tabPage5.Controls.Add(this.tbNumberofjobsRandom);
            this.tabPage5.Location = new System.Drawing.Point(4, 31);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(524, 801);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "SSQ w Feedback";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tbBatchrun
            // 
            this.tbBatchrun.Location = new System.Drawing.Point(29, 626);
            this.tbBatchrun.Name = "tbBatchrun";
            this.tbBatchrun.Size = new System.Drawing.Size(155, 29);
            this.tbBatchrun.TabIndex = 26;
            this.tbBatchrun.Text = "0.0,0.25,10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(25, 588);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "(start, end, #cases)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Brown;
            this.label14.Location = new System.Drawing.Point(25, 551);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(180, 21);
            this.label14.TabIndex = 24;
            this.label14.Text = "feedback probabilit";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Brown;
            this.label11.Location = new System.Drawing.Point(25, 517);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(223, 21);
            this.label11.TabIndex = 23;
            this.label11.Text = "Batch Runs on different";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 414);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(219, 23);
            this.label10.TabIndex = 22;
            this.label10.Text = "Feedback Probability";
            // 
            // tbFeedbackProbability
            // 
            this.tbFeedbackProbability.Location = new System.Drawing.Point(270, 414);
            this.tbFeedbackProbability.Name = "tbFeedbackProbability";
            this.tbFeedbackProbability.Size = new System.Drawing.Size(155, 29);
            this.tbFeedbackProbability.TabIndex = 21;
            this.tbFeedbackProbability.Text = "0.1";
            // 
            // btnBatchRun
            // 
            this.btnBatchRun.Location = new System.Drawing.Point(26, 671);
            this.btnBatchRun.Name = "btnBatchRun";
            this.btnBatchRun.Size = new System.Drawing.Size(443, 55);
            this.btnBatchRun.TabIndex = 18;
            this.btnBatchRun.Text = "Batch Run";
            this.btnBatchRun.UseVisualStyleBackColor = true;
            this.btnBatchRun.Click += new System.EventHandler(this.btnBatchRun_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 376);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(164, 23);
            this.label12.TabIndex = 15;
            this.label12.Text = "Number of Jobs";
            // 
            // ppgAverage
            // 
            this.ppgAverage.Dock = System.Windows.Forms.DockStyle.Top;
            this.ppgAverage.Location = new System.Drawing.Point(3, 3);
            this.ppgAverage.Name = "ppgAverage";
            this.ppgAverage.Size = new System.Drawing.Size(518, 345);
            this.ppgAverage.TabIndex = 7;
            // 
            // btnFeedbackSimulate
            // 
            this.btnFeedbackSimulate.Location = new System.Drawing.Point(26, 449);
            this.btnFeedbackSimulate.Name = "btnFeedbackSimulate";
            this.btnFeedbackSimulate.Size = new System.Drawing.Size(443, 55);
            this.btnFeedbackSimulate.TabIndex = 5;
            this.btnFeedbackSimulate.Text = "Simulate Stochastic Case";
            this.btnFeedbackSimulate.UseVisualStyleBackColor = true;
            this.btnFeedbackSimulate.Click += new System.EventHandler(this.btnFeedbackSimulate_Click);
            // 
            // tbNumberofjobsRandom
            // 
            this.tbNumberofjobsRandom.Location = new System.Drawing.Point(270, 370);
            this.tbNumberofjobsRandom.Name = "tbNumberofjobsRandom";
            this.tbNumberofjobsRandom.Size = new System.Drawing.Size(155, 29);
            this.tbNumberofjobsRandom.TabIndex = 3;
            this.tbNumberofjobsRandom.Text = "1000";
            // 
            // cbDeliveryLag
            // 
            this.cbDeliveryLag.Controls.Add(this.label3);
            this.cbDeliveryLag.Controls.Add(this.tbIntervals);
            this.cbDeliveryLag.Controls.Add(this.cbLag);
            this.cbDeliveryLag.Controls.Add(this.btnFindOptimalMininumLevel);
            this.cbDeliveryLag.Controls.Add(this.btnDeliveryLagSimulate);
            this.cbDeliveryLag.Controls.Add(this.ppgDeliveryLag);
            this.cbDeliveryLag.Location = new System.Drawing.Point(4, 31);
            this.cbDeliveryLag.Name = "cbDeliveryLag";
            this.cbDeliveryLag.Size = new System.Drawing.Size(524, 801);
            this.cbDeliveryLag.TabIndex = 3;
            this.cbDeliveryLag.Text = "SIS w Delivery Lag";
            this.cbDeliveryLag.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 453);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "Number of Intervals";
            // 
            // tbIntervals
            // 
            this.tbIntervals.Location = new System.Drawing.Point(260, 447);
            this.tbIntervals.Name = "tbIntervals";
            this.tbIntervals.Size = new System.Drawing.Size(155, 29);
            this.tbIntervals.TabIndex = 19;
            this.tbIntervals.Text = "1000";
            // 
            // cbLag
            // 
            this.cbLag.AutoSize = true;
            this.cbLag.Location = new System.Drawing.Point(62, 521);
            this.cbLag.Name = "cbLag";
            this.cbLag.Size = new System.Drawing.Size(212, 27);
            this.cbLag.TabIndex = 3;
            this.cbLag.Text = "With Delivery Lag";
            this.cbLag.UseVisualStyleBackColor = true;
            // 
            // btnFindOptimalMininumLevel
            // 
            this.btnFindOptimalMininumLevel.Location = new System.Drawing.Point(62, 642);
            this.btnFindOptimalMininumLevel.Name = "btnFindOptimalMininumLevel";
            this.btnFindOptimalMininumLevel.Size = new System.Drawing.Size(373, 54);
            this.btnFindOptimalMininumLevel.TabIndex = 2;
            this.btnFindOptimalMininumLevel.Text = "Find Optimal Mininum Level";
            this.btnFindOptimalMininumLevel.UseVisualStyleBackColor = true;
            this.btnFindOptimalMininumLevel.Click += new System.EventHandler(this.btnFindOptimalMininumLevel_Click);
            // 
            // btnDeliveryLagSimulate
            // 
            this.btnDeliveryLagSimulate.Location = new System.Drawing.Point(60, 569);
            this.btnDeliveryLagSimulate.Name = "btnDeliveryLagSimulate";
            this.btnDeliveryLagSimulate.Size = new System.Drawing.Size(375, 45);
            this.btnDeliveryLagSimulate.TabIndex = 1;
            this.btnDeliveryLagSimulate.Text = "Simulate Stochastic Case";
            this.btnDeliveryLagSimulate.UseVisualStyleBackColor = true;
            this.btnDeliveryLagSimulate.Click += new System.EventHandler(this.btnDeliveryLagSimulate_Click);
            // 
            // ppgDeliveryLag
            // 
            this.ppgDeliveryLag.Dock = System.Windows.Forms.DockStyle.Top;
            this.ppgDeliveryLag.Location = new System.Drawing.Point(0, 0);
            this.ppgDeliveryLag.Name = "ppgDeliveryLag";
            this.ppgDeliveryLag.Size = new System.Drawing.Size(524, 431);
            this.ppgDeliveryLag.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.ppgMachineShop);
            this.tabPage2.Controls.Add(this.btnMultipleRuns);
            this.tabPage2.Controls.Add(this.btnMachineShopSimulate);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(524, 801);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "SS Machine Shop";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 473);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "Number of Intervals";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(284, 473);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(155, 29);
            this.textBox2.TabIndex = 23;
            this.textBox2.Text = "20";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(27, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 21);
            this.label5.TabIndex = 22;
            this.label5.Text = "Exponential Disribution";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Brown;
            this.label7.Location = new System.Drawing.Point(27, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "Failure Times:";
            // 
            // ppgMachineShop
            // 
            this.ppgMachineShop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ppgMachineShop.Location = new System.Drawing.Point(11, 70);
            this.ppgMachineShop.Name = "ppgMachineShop";
            this.ppgMachineShop.Size = new System.Drawing.Size(513, 373);
            this.ppgMachineShop.TabIndex = 5;
            // 
            // btnMultipleRuns
            // 
            this.btnMultipleRuns.Location = new System.Drawing.Point(64, 683);
            this.btnMultipleRuns.Name = "btnMultipleRuns";
            this.btnMultipleRuns.Size = new System.Drawing.Size(375, 78);
            this.btnMultipleRuns.TabIndex = 4;
            this.btnMultipleRuns.Text = "Find Optimal Mininum Level";
            this.btnMultipleRuns.UseVisualStyleBackColor = true;
            // 
            // btnMachineShopSimulate
            // 
            this.btnMachineShopSimulate.Location = new System.Drawing.Point(64, 552);
            this.btnMachineShopSimulate.Name = "btnMachineShopSimulate";
            this.btnMachineShopSimulate.Size = new System.Drawing.Size(375, 78);
            this.btnMachineShopSimulate.TabIndex = 3;
            this.btnMachineShopSimulate.Text = "Simulate Stochastic Case";
            this.btnMachineShopSimulate.UseVisualStyleBackColor = true;
            // 
            // tabControl_2
            // 
            this.tabControl_2.Controls.Add(this.background);
            this.tabControl_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_2.Location = new System.Drawing.Point(0, 0);
            this.tabControl_2.Name = "tabControl_2";
            this.tabControl_2.SelectedIndex = 0;
            this.tabControl_2.Size = new System.Drawing.Size(1092, 836);
            this.tabControl_2.TabIndex = 2;
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.LightSkyBlue;
            this.background.Controls.Add(this.rtbShow);
            this.background.Controls.Add(this.cbJobinService);
            this.background.Controls.Add(this.cbJobinQueue);
            this.background.Controls.Add(this.cbJobinNode);
            this.background.Controls.Add(this.chtJobCount);
            this.background.Location = new System.Drawing.Point(4, 31);
            this.background.Name = "background";
            this.background.Padding = new System.Windows.Forms.Padding(3);
            this.background.Size = new System.Drawing.Size(1084, 801);
            this.background.TabIndex = 0;
            this.background.Text = "Simulate Job Processing";
            // 
            // rtbShow
            // 
            this.rtbShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbShow.CausesValidation = false;
            this.rtbShow.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbShow.Location = new System.Drawing.Point(3, 3);
            this.rtbShow.Name = "rtbShow";
            this.rtbShow.Size = new System.Drawing.Size(1078, 271);
            this.rtbShow.TabIndex = 15;
            this.rtbShow.Text = "";
            // 
            // cbJobinService
            // 
            this.cbJobinService.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbJobinService.AutoSize = true;
            this.cbJobinService.Checked = true;
            this.cbJobinService.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbJobinService.Enabled = false;
            this.cbJobinService.Location = new System.Drawing.Point(790, 293);
            this.cbJobinService.Name = "cbJobinService";
            this.cbJobinService.Size = new System.Drawing.Size(180, 27);
            this.cbJobinService.TabIndex = 14;
            this.cbJobinService.Text = "Jobs in Service";
            this.cbJobinService.UseVisualStyleBackColor = true;
            this.cbJobinService.CheckedChanged += new System.EventHandler(this.cbJobinService_CheckedChanged);
            // 
            // cbJobinQueue
            // 
            this.cbJobinQueue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbJobinQueue.AutoSize = true;
            this.cbJobinQueue.Checked = true;
            this.cbJobinQueue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbJobinQueue.Enabled = false;
            this.cbJobinQueue.Location = new System.Drawing.Point(426, 293);
            this.cbJobinQueue.Name = "cbJobinQueue";
            this.cbJobinQueue.Size = new System.Drawing.Size(173, 27);
            this.cbJobinQueue.TabIndex = 13;
            this.cbJobinQueue.Text = "Jobs in Queue";
            this.cbJobinQueue.UseVisualStyleBackColor = true;
            this.cbJobinQueue.CheckedChanged += new System.EventHandler(this.cbJobinQueue_CheckedChanged);
            // 
            // cbJobinNode
            // 
            this.cbJobinNode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbJobinNode.AutoSize = true;
            this.cbJobinNode.Checked = true;
            this.cbJobinNode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbJobinNode.Enabled = false;
            this.cbJobinNode.Location = new System.Drawing.Point(32, 293);
            this.cbJobinNode.Name = "cbJobinNode";
            this.cbJobinNode.Size = new System.Drawing.Size(159, 27);
            this.cbJobinNode.TabIndex = 12;
            this.cbJobinNode.Text = "Jobs in Node";
            this.cbJobinNode.UseVisualStyleBackColor = true;
            this.cbJobinNode.CheckedChanged += new System.EventHandler(this.cbJobinNode_CheckedChanged);
            // 
            // chtJobCount
            // 
            this.chtJobCount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.Name = "ChartArea1";
            this.chtJobCount.ChartAreas.Add(chartArea1);
            this.chtJobCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chtJobCount.Legends.Add(legend1);
            this.chtJobCount.Location = new System.Drawing.Point(3, 394);
            this.chtJobCount.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chtJobCount.Name = "chtJobCount";
            this.chtJobCount.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            this.chtJobCount.Size = new System.Drawing.Size(1078, 404);
            this.chtJobCount.TabIndex = 1;
            this.chtJobCount.Text = "chart1";
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
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tc.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.cbDeliveryLag.ResumeLayout(false);
            this.cbDeliveryLag.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl_2.ResumeLayout(false);
            this.background.ResumeLayout(false);
            this.background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtJobCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tc;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtJobCount;
        private System.Windows.Forms.TabControl tabControl_2;
        private System.Windows.Forms.TabPage background;
        private System.Windows.Forms.CheckBox cbJobinService;
        private System.Windows.Forms.CheckBox cbJobinQueue;
        private System.Windows.Forms.CheckBox cbJobinNode;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PropertyGrid ppgAverage;
        private System.Windows.Forms.Button btnFeedbackSimulate;
        private System.Windows.Forms.TextBox tbNumberofjobsRandom;
        private System.Windows.Forms.RichTextBox rtbShow;
        private System.Windows.Forms.ToolStripComboBox tscbSeed;
        private System.Windows.Forms.TabPage cbDeliveryLag;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox cbLag;
        private System.Windows.Forms.Button btnFindOptimalMininumLevel;
        private System.Windows.Forms.Button btnDeliveryLagSimulate;
        private System.Windows.Forms.PropertyGrid ppgDeliveryLag;
        private System.Windows.Forms.Button btnBatchRun;
        private System.Windows.Forms.Button btnMultipleRuns;
        private System.Windows.Forms.Button btnMachineShopSimulate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIntervals;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PropertyGrid ppgMachineShop;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbFeedbackProbability;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.TextBox tbBatchrun;
        private System.Windows.Forms.Label label1;
    }
}

