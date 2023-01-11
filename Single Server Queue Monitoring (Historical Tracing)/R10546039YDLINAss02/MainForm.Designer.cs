
namespace R10546039YDLINAss02
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnOpenFile = new System.Windows.Forms.ToolStripButton();
            this.btnSaveFile = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl_1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvInput = new System.Windows.Forms.DataGridView();
            this.colJobs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colServiceTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelayTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompletionTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rtbInput = new System.Windows.Forms.RichTextBox();
            this.tbNumberOfJob = new System.Windows.Forms.TextBox();
            this.tbDeviationService = new System.Windows.Forms.TextBox();
            this.tbAverageServiceTime = new System.Windows.Forms.TextBox();
            this.tbDeviationInterarrival = new System.Windows.Forms.TextBox();
            this.tbAverageInterarrivalTime = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCreateData = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl_2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbJobinService = new System.Windows.Forms.CheckBox();
            this.cbJobinQueue = new System.Windows.Forms.CheckBox();
            this.cbJobinNode = new System.Windows.Forms.CheckBox();
            this.cbUseNeatAlgorithm = new System.Windows.Forms.CheckBox();
            this.tbServiceTimeFactor = new System.Windows.Forms.TextBox();
            this.labelSTF = new System.Windows.Forms.Label();
            this.labelTAJS = new System.Windows.Forms.Label();
            this.labelTAJQ = new System.Windows.Forms.Label();
            this.labelTAJN = new System.Windows.Forms.Label();
            this.labelAWT = new System.Windows.Forms.Label();
            this.labelADT = new System.Windows.Forms.Label();
            this.labelAST = new System.Windows.Forms.Label();
            this.labelAIT = new System.Windows.Forms.Label();
            this.btnCreateJobCountLine = new System.Windows.Forms.Button();
            this.chtJobCount = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnSimulation = new System.Windows.Forms.Button();
            this.tbNOT = new System.Windows.Forms.TextBox();
            this.tbSTFFTU = new System.Windows.Forms.TextBox();
            this.tbSTFFTL = new System.Windows.Forms.TextBox();
            this.chtQueueUtilizationRate = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelNOT = new System.Windows.Forms.Label();
            this.labelSTFFT = new System.Windows.Forms.Label();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl_1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInput)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabControl_2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtJobCount)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtQueueUtilizationRate)).BeginInit();
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
            this.splitContainer1.SplitterDistance = 504;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 1;
            // 
            // tabControl_1
            // 
            this.tabControl_1.Controls.Add(this.tabPage1);
            this.tabControl_1.Controls.Add(this.tabPage2);
            this.tabControl_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_1.Location = new System.Drawing.Point(0, 0);
            this.tabControl_1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabControl_1.Name = "tabControl_1";
            this.tabControl_1.SelectedIndex = 0;
            this.tabControl_1.Size = new System.Drawing.Size(504, 834);
            this.tabControl_1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabPage1.Controls.Add(this.dgvInput);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPage1.Size = new System.Drawing.Size(496, 799);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Current Problem";
            // 
            // dgvInput
            // 
            this.dgvInput.AllowUserToAddRows = false;
            this.dgvInput.AllowUserToDeleteRows = false;
            this.dgvInput.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colJobs,
            this.colArrivalTime,
            this.colServiceTime,
            this.colDelayTime,
            this.colCompletionTime});
            this.dgvInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInput.Location = new System.Drawing.Point(5, 4);
            this.dgvInput.Name = "dgvInput";
            this.dgvInput.RowHeadersVisible = false;
            this.dgvInput.RowHeadersWidth = 51;
            this.dgvInput.RowTemplate.Height = 24;
            this.dgvInput.Size = new System.Drawing.Size(486, 791);
            this.dgvInput.TabIndex = 0;
            // 
            // colJobs
            // 
            this.colJobs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colJobs.HeaderText = "Jobs";
            this.colJobs.MinimumWidth = 6;
            this.colJobs.Name = "colJobs";
            // 
            // colArrivalTime
            // 
            this.colArrivalTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colArrivalTime.HeaderText = "Arrival Time";
            this.colArrivalTime.MinimumWidth = 6;
            this.colArrivalTime.Name = "colArrivalTime";
            // 
            // colServiceTime
            // 
            this.colServiceTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colServiceTime.HeaderText = "Service Time";
            this.colServiceTime.MinimumWidth = 6;
            this.colServiceTime.Name = "colServiceTime";
            // 
            // colDelayTime
            // 
            this.colDelayTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDelayTime.HeaderText = "Delay Time";
            this.colDelayTime.MinimumWidth = 6;
            this.colDelayTime.Name = "colDelayTime";
            // 
            // colCompletionTime
            // 
            this.colCompletionTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCompletionTime.HeaderText = "Completion Time";
            this.colCompletionTime.MinimumWidth = 6;
            this.colCompletionTime.Name = "colCompletionTime";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SkyBlue;
            this.tabPage2.Controls.Add(this.rtbInput);
            this.tabPage2.Controls.Add(this.tbNumberOfJob);
            this.tabPage2.Controls.Add(this.tbDeviationService);
            this.tabPage2.Controls.Add(this.tbAverageServiceTime);
            this.tabPage2.Controls.Add(this.tbDeviationInterarrival);
            this.tabPage2.Controls.Add(this.tbAverageInterarrivalTime);
            this.tabPage2.Controls.Add(this.btnSave);
            this.tabPage2.Controls.Add(this.btnCreateData);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPage2.Size = new System.Drawing.Size(496, 804);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Create New Problem";
            // 
            // rtbInput
            // 
            this.rtbInput.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.rtbInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtbInput.Location = new System.Drawing.Point(5, 503);
            this.rtbInput.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(486, 297);
            this.rtbInput.TabIndex = 0;
            this.rtbInput.Text = "";
            // 
            // tbNumberOfJob
            // 
            this.tbNumberOfJob.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbNumberOfJob.Location = new System.Drawing.Point(317, 277);
            this.tbNumberOfJob.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbNumberOfJob.Name = "tbNumberOfJob";
            this.tbNumberOfJob.Size = new System.Drawing.Size(148, 29);
            this.tbNumberOfJob.TabIndex = 11;
            this.tbNumberOfJob.Text = "20";
            // 
            // tbDeviationService
            // 
            this.tbDeviationService.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbDeviationService.Location = new System.Drawing.Point(317, 217);
            this.tbDeviationService.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbDeviationService.Name = "tbDeviationService";
            this.tbDeviationService.Size = new System.Drawing.Size(148, 29);
            this.tbDeviationService.TabIndex = 10;
            this.tbDeviationService.Text = "2.0";
            // 
            // tbAverageServiceTime
            // 
            this.tbAverageServiceTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbAverageServiceTime.Location = new System.Drawing.Point(317, 154);
            this.tbAverageServiceTime.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbAverageServiceTime.Name = "tbAverageServiceTime";
            this.tbAverageServiceTime.Size = new System.Drawing.Size(148, 29);
            this.tbAverageServiceTime.TabIndex = 9;
            this.tbAverageServiceTime.Text = "6.2";
            // 
            // tbDeviationInterarrival
            // 
            this.tbDeviationInterarrival.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbDeviationInterarrival.Location = new System.Drawing.Point(317, 88);
            this.tbDeviationInterarrival.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbDeviationInterarrival.Name = "tbDeviationInterarrival";
            this.tbDeviationInterarrival.Size = new System.Drawing.Size(148, 29);
            this.tbDeviationInterarrival.TabIndex = 8;
            this.tbDeviationInterarrival.Text = "6";
            // 
            // tbAverageInterarrivalTime
            // 
            this.tbAverageInterarrivalTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbAverageInterarrivalTime.Location = new System.Drawing.Point(317, 26);
            this.tbAverageInterarrivalTime.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbAverageInterarrivalTime.Name = "tbAverageInterarrivalTime";
            this.tbAverageInterarrivalTime.Size = new System.Drawing.Size(148, 29);
            this.tbAverageInterarrivalTime.TabIndex = 7;
            this.tbAverageInterarrivalTime.Text = "4";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(26, 422);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(443, 53);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnCreateData
            // 
            this.btnCreateData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCreateData.Location = new System.Drawing.Point(26, 333);
            this.btnCreateData.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCreateData.Name = "btnCreateData";
            this.btnCreateData.Size = new System.Drawing.Size(443, 53);
            this.btnCreateData.TabIndex = 5;
            this.btnCreateData.Text = "Create Data";
            this.btnCreateData.UseVisualStyleBackColor = true;
            this.btnCreateData.Click += new System.EventHandler(this.btnCreateData_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 277);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Number of Jobs";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 217);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Deviation";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Average Service Time";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Deviation";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Average Interarrival Time";
            // 
            // tabControl_2
            // 
            this.tabControl_2.Controls.Add(this.tabPage3);
            this.tabControl_2.Controls.Add(this.tabPage4);
            this.tabControl_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_2.Location = new System.Drawing.Point(0, 0);
            this.tabControl_2.Name = "tabControl_2";
            this.tabControl_2.SelectedIndex = 0;
            this.tabControl_2.Size = new System.Drawing.Size(1120, 834);
            this.tabControl_2.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage3.Controls.Add(this.cbJobinService);
            this.tabPage3.Controls.Add(this.cbJobinQueue);
            this.tabPage3.Controls.Add(this.cbJobinNode);
            this.tabPage3.Controls.Add(this.cbUseNeatAlgorithm);
            this.tabPage3.Controls.Add(this.tbServiceTimeFactor);
            this.tabPage3.Controls.Add(this.labelSTF);
            this.tabPage3.Controls.Add(this.labelTAJS);
            this.tabPage3.Controls.Add(this.labelTAJQ);
            this.tabPage3.Controls.Add(this.labelTAJN);
            this.tabPage3.Controls.Add(this.labelAWT);
            this.tabPage3.Controls.Add(this.labelADT);
            this.tabPage3.Controls.Add(this.labelAST);
            this.tabPage3.Controls.Add(this.labelAIT);
            this.tabPage3.Controls.Add(this.btnCreateJobCountLine);
            this.tabPage3.Controls.Add(this.chtJobCount);
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1112, 799);
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
            this.cbJobinService.Location = new System.Drawing.Point(801, 333);
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
            this.cbJobinQueue.Location = new System.Drawing.Point(433, 333);
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
            this.cbJobinNode.Location = new System.Drawing.Point(44, 333);
            this.cbJobinNode.Name = "cbJobinNode";
            this.cbJobinNode.Size = new System.Drawing.Size(159, 27);
            this.cbJobinNode.TabIndex = 12;
            this.cbJobinNode.Text = "Jobs in Node";
            this.cbJobinNode.UseVisualStyleBackColor = true;
            this.cbJobinNode.CheckedChanged += new System.EventHandler(this.cbJobinNode_CheckedChanged);
            // 
            // cbUseNeatAlgorithm
            // 
            this.cbUseNeatAlgorithm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbUseNeatAlgorithm.AutoSize = true;
            this.cbUseNeatAlgorithm.Checked = true;
            this.cbUseNeatAlgorithm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUseNeatAlgorithm.Location = new System.Drawing.Point(800, 46);
            this.cbUseNeatAlgorithm.Name = "cbUseNeatAlgorithm";
            this.cbUseNeatAlgorithm.Size = new System.Drawing.Size(227, 27);
            this.cbUseNeatAlgorithm.TabIndex = 11;
            this.cbUseNeatAlgorithm.Text = "Use Neat Algorithm";
            this.cbUseNeatAlgorithm.UseVisualStyleBackColor = true;
            // 
            // tbServiceTimeFactor
            // 
            this.tbServiceTimeFactor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbServiceTimeFactor.Enabled = false;
            this.tbServiceTimeFactor.Location = new System.Drawing.Point(630, 43);
            this.tbServiceTimeFactor.Name = "tbServiceTimeFactor";
            this.tbServiceTimeFactor.Size = new System.Drawing.Size(100, 29);
            this.tbServiceTimeFactor.TabIndex = 10;
            this.tbServiceTimeFactor.Text = "1.0";
            // 
            // labelSTF
            // 
            this.labelSTF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSTF.AutoSize = true;
            this.labelSTF.Location = new System.Drawing.Point(367, 46);
            this.labelSTF.Name = "labelSTF";
            this.labelSTF.Size = new System.Drawing.Size(206, 23);
            this.labelSTF.TabIndex = 9;
            this.labelSTF.Text = "Service Time Factor";
            // 
            // labelTAJS
            // 
            this.labelTAJS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTAJS.AutoSize = true;
            this.labelTAJS.ForeColor = System.Drawing.Color.DarkRed;
            this.labelTAJS.Location = new System.Drawing.Point(718, 231);
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
            this.labelTAJQ.Location = new System.Drawing.Point(718, 183);
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
            this.labelTAJN.Location = new System.Drawing.Point(718, 133);
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
            this.labelAWT.Location = new System.Drawing.Point(40, 268);
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
            this.labelADT.Location = new System.Drawing.Point(40, 214);
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
            this.labelAST.Location = new System.Drawing.Point(40, 166);
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
            this.labelAIT.Location = new System.Drawing.Point(40, 111);
            this.labelAIT.Name = "labelAIT";
            this.labelAIT.Size = new System.Drawing.Size(275, 23);
            this.labelAIT.TabIndex = 2;
            this.labelAIT.Text = "Average Interarrival Time:";
            // 
            // btnCreateJobCountLine
            // 
            this.btnCreateJobCountLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreateJobCountLine.Enabled = false;
            this.btnCreateJobCountLine.Location = new System.Drawing.Point(20, 26);
            this.btnCreateJobCountLine.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCreateJobCountLine.Name = "btnCreateJobCountLine";
            this.btnCreateJobCountLine.Size = new System.Drawing.Size(307, 47);
            this.btnCreateJobCountLine.TabIndex = 0;
            this.btnCreateJobCountLine.Text = "Simulate the Process";
            this.btnCreateJobCountLine.UseVisualStyleBackColor = true;
            this.btnCreateJobCountLine.Click += new System.EventHandler(this.btnCreateJobCountLine_Click);
            // 
            // chtJobCount
            // 
            this.chtJobCount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX.Title = "Time";
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisY.Title = "Count";
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
            this.chtJobCount.Location = new System.Drawing.Point(3, 386);
            this.chtJobCount.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chtJobCount.Name = "chtJobCount";
            this.chtJobCount.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series1.Legend = "Legend1";
            series1.Name = "Job in Node l(t)";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series2.Color = System.Drawing.Color.DarkGreen;
            series2.Legend = "Legend1";
            series2.Name = "Job in Queue q(t)";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series3.Color = System.Drawing.Color.Blue;
            series3.Legend = "Legend1";
            series3.Name = "Job in Service x(t)";
            this.chtJobCount.Series.Add(series1);
            this.chtJobCount.Series.Add(series2);
            this.chtJobCount.Series.Add(series3);
            this.chtJobCount.Size = new System.Drawing.Size(1106, 410);
            this.chtJobCount.TabIndex = 1;
            this.chtJobCount.Text = "chart1";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tabPage4.Controls.Add(this.btnSimulation);
            this.tabPage4.Controls.Add(this.tbNOT);
            this.tabPage4.Controls.Add(this.tbSTFFTU);
            this.tabPage4.Controls.Add(this.tbSTFFTL);
            this.tabPage4.Controls.Add(this.chtQueueUtilizationRate);
            this.tabPage4.Controls.Add(this.labelNOT);
            this.tabPage4.Controls.Add(this.labelSTFFT);
            this.tabPage4.Location = new System.Drawing.Point(4, 31);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1112, 799);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Service Time Factor";
            // 
            // btnSimulation
            // 
            this.btnSimulation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSimulation.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimulation.Location = new System.Drawing.Point(634, 153);
            this.btnSimulation.Name = "btnSimulation";
            this.btnSimulation.Size = new System.Drawing.Size(206, 48);
            this.btnSimulation.TabIndex = 6;
            this.btnSimulation.Text = "Simulation";
            this.btnSimulation.UseVisualStyleBackColor = true;
            this.btnSimulation.Click += new System.EventHandler(this.btnSimulation_Click);
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
            this.tbNOT.Text = "11";
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
            this.tbSTFFTU.Text = "2.0";
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
            this.tbSTFFTL.Text = "0.5";
            // 
            // chtQueueUtilizationRate
            // 
            chartArea2.AxisX.Title = "Time-averaged Jobs in Service(Utilization, x-bar)";
            chartArea2.AxisY.Title = "Time-averaged Queue Length (q-bar)";
            chartArea2.Name = "ChartArea1";
            this.chtQueueUtilizationRate.ChartAreas.Add(chartArea2);
            this.chtQueueUtilizationRate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chtQueueUtilizationRate.Location = new System.Drawing.Point(3, 300);
            this.chtQueueUtilizationRate.Name = "chtQueueUtilizationRate";
            this.chtQueueUtilizationRate.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.DarkBlue;
            series4.IsValueShownAsLabel = true;
            series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series4.Name = "Rate";
            series4.YValuesPerPoint = 2;
            this.chtQueueUtilizationRate.Series.Add(series4);
            this.chtQueueUtilizationRate.Size = new System.Drawing.Size(1106, 496);
            this.chtQueueUtilizationRate.TabIndex = 2;
            this.chtQueueUtilizationRate.Text = "chart1";
            title1.BorderWidth = 2;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title_Queue-Utilization of DifferentServiceRates";
            title1.Text = "Queue-Utilization of Different Service Rates";
            this.chtQueueUtilizationRate.Titles.Add(title1);
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
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInput)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl_2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtJobCount)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtQueueUtilizationRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnOpenFile;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl_1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtJobCount;
        private System.Windows.Forms.Button btnCreateJobCountLine;
        private System.Windows.Forms.ToolStripButton btnSaveFile;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.RichTextBox rtbInput;
        private System.Windows.Forms.TextBox tbNumberOfJob;
        private System.Windows.Forms.TextBox tbDeviationService;
        private System.Windows.Forms.TextBox tbAverageServiceTime;
        private System.Windows.Forms.TextBox tbDeviationInterarrival;
        private System.Windows.Forms.TextBox tbAverageInterarrivalTime;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCreateData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.TabControl tabControl_2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckBox cbJobinService;
        private System.Windows.Forms.CheckBox cbJobinQueue;
        private System.Windows.Forms.CheckBox cbJobinNode;
        private System.Windows.Forms.CheckBox cbUseNeatAlgorithm;
        private System.Windows.Forms.TextBox tbServiceTimeFactor;
        private System.Windows.Forms.Label labelSTF;
        private System.Windows.Forms.Label labelTAJS;
        private System.Windows.Forms.Label labelTAJQ;
        private System.Windows.Forms.Label labelTAJN;
        private System.Windows.Forms.Label labelAWT;
        private System.Windows.Forms.Label labelADT;
        private System.Windows.Forms.Label labelAST;
        private System.Windows.Forms.Label labelAIT;
        private System.Windows.Forms.Button btnSimulation;
        private System.Windows.Forms.TextBox tbNOT;
        private System.Windows.Forms.TextBox tbSTFFTU;
        private System.Windows.Forms.TextBox tbSTFFTL;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtQueueUtilizationRate;
        private System.Windows.Forms.Label labelNOT;
        private System.Windows.Forms.Label labelSTFFT;
        public System.Windows.Forms.DataGridView dgvInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJobs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServiceTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDelayTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompletionTime;
    }
}

