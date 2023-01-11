
namespace R10546039YDLINAssSemiFinal
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tbNumberofServers = new System.Windows.Forms.TextBox();
            this.cbSharedServiceTime = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbDifferentServiceRates = new System.Windows.Forms.RadioButton();
            this.cbServices = new System.Windows.Forms.ComboBox();
            this.rbSameServiceRate = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ppgServer = new System.Windows.Forms.PropertyGrid();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.cbJobInterarrivalDistribution = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ppgJobInterarrival = new System.Windows.Forms.PropertyGrid();
            this.btnRunToEnd = new System.Windows.Forms.Button();
            this.btnOneEvent = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.cbAnimate = new System.Windows.Forms.CheckBox();
            this.cbAllowChangeQueue = new System.Windows.Forms.CheckBox();
            this.tbCeaseTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMultipleQueue = new System.Windows.Forms.CheckBox();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.chtShow = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.rtbShow = new System.Windows.Forms.RichTextBox();
            this.chtPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtPie)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1710, 801);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Multiple Server Queue";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer1.Size = new System.Drawing.Size(1702, 793);
            this.splitContainer1.SplitterDistance = 643;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tbNumberofServers);
            this.splitContainer2.Panel1.Controls.Add(this.cbSharedServiceTime);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.rbDifferentServiceRates);
            this.splitContainer2.Panel1.Controls.Add(this.cbServices);
            this.splitContainer2.Panel1.Controls.Add(this.rbSameServiceRate);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.ppgServer);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(643, 793);
            this.splitContainer2.SplitterDistance = 331;
            this.splitContainer2.TabIndex = 0;
            // 
            // tbNumberofServers
            // 
            this.tbNumberofServers.Enabled = false;
            this.tbNumberofServers.Location = new System.Drawing.Point(20, 57);
            this.tbNumberofServers.Name = "tbNumberofServers";
            this.tbNumberofServers.Size = new System.Drawing.Size(100, 27);
            this.tbNumberofServers.TabIndex = 8;
            this.tbNumberofServers.Text = "5";
            // 
            // cbSharedServiceTime
            // 
            this.cbSharedServiceTime.FormattingEnabled = true;
            this.cbSharedServiceTime.Items.AddRange(new object[] {
            "Exponential",
            "Uniform"});
            this.cbSharedServiceTime.Location = new System.Drawing.Point(104, 295);
            this.cbSharedServiceTime.Name = "cbSharedServiceTime";
            this.cbSharedServiceTime.Size = new System.Drawing.Size(121, 28);
            this.cbSharedServiceTime.TabIndex = 7;
            this.cbSharedServiceTime.Text = "Exponential";
            this.cbSharedServiceTime.SelectedIndexChanged += new System.EventHandler(this.cbSharedServiceTime_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Distribution";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Shared Service Time";
            // 
            // rbDifferentServiceRates
            // 
            this.rbDifferentServiceRates.AutoSize = true;
            this.rbDifferentServiceRates.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.rbDifferentServiceRates.Enabled = false;
            this.rbDifferentServiceRates.Location = new System.Drawing.Point(20, 120);
            this.rbDifferentServiceRates.Name = "rbDifferentServiceRates";
            this.rbDifferentServiceRates.Size = new System.Drawing.Size(205, 24);
            this.rbDifferentServiceRates.TabIndex = 4;
            this.rbDifferentServiceRates.Text = "Different Service Rates";
            this.rbDifferentServiceRates.UseVisualStyleBackColor = true;
            this.rbDifferentServiceRates.CheckedChanged += new System.EventHandler(this.rbDifferentServiceRates_CheckedChanged);
            // 
            // cbServices
            // 
            this.cbServices.Enabled = false;
            this.cbServices.FormattingEnabled = true;
            this.cbServices.Location = new System.Drawing.Point(104, 159);
            this.cbServices.Name = "cbServices";
            this.cbServices.Size = new System.Drawing.Size(121, 28);
            this.cbServices.TabIndex = 3;
            this.cbServices.SelectedIndexChanged += new System.EventHandler(this.cbServices_SelectedIndexChanged);
            // 
            // rbSameServiceRate
            // 
            this.rbSameServiceRate.AutoSize = true;
            this.rbSameServiceRate.Checked = true;
            this.rbSameServiceRate.Location = new System.Drawing.Point(20, 90);
            this.rbSameServiceRate.Name = "rbSameServiceRate";
            this.rbSameServiceRate.Size = new System.Drawing.Size(174, 24);
            this.rbSameServiceRate.TabIndex = 2;
            this.rbSameServiceRate.TabStop = true;
            this.rbSameServiceRate.Text = "Same Service Rate";
            this.rbSameServiceRate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Servers";
            // 
            // ppgServer
            // 
            this.ppgServer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ppgServer.Location = new System.Drawing.Point(0, 354);
            this.ppgServer.Name = "ppgServer";
            this.ppgServer.Size = new System.Drawing.Size(331, 439);
            this.ppgServer.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.cbJobInterarrivalDistribution);
            this.splitContainer3.Panel1.Controls.Add(this.label4);
            this.splitContainer3.Panel1.Controls.Add(this.ppgJobInterarrival);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.btnRunToEnd);
            this.splitContainer3.Panel2.Controls.Add(this.btnOneEvent);
            this.splitContainer3.Panel2.Controls.Add(this.btnReset);
            this.splitContainer3.Panel2.Controls.Add(this.label6);
            this.splitContainer3.Panel2.Controls.Add(this.comboBox4);
            this.splitContainer3.Panel2.Controls.Add(this.cbAnimate);
            this.splitContainer3.Panel2.Controls.Add(this.cbAllowChangeQueue);
            this.splitContainer3.Panel2.Controls.Add(this.tbCeaseTime);
            this.splitContainer3.Panel2.Controls.Add(this.label5);
            this.splitContainer3.Panel2.Controls.Add(this.cbMultipleQueue);
            this.splitContainer3.Size = new System.Drawing.Size(308, 793);
            this.splitContainer3.SplitterDistance = 371;
            this.splitContainer3.TabIndex = 0;
            // 
            // cbJobInterarrivalDistribution
            // 
            this.cbJobInterarrivalDistribution.FormattingEnabled = true;
            this.cbJobInterarrivalDistribution.Items.AddRange(new object[] {
            "Exponential",
            "Uniform"});
            this.cbJobInterarrivalDistribution.Location = new System.Drawing.Point(21, 57);
            this.cbJobInterarrivalDistribution.Name = "cbJobInterarrivalDistribution";
            this.cbJobInterarrivalDistribution.Size = new System.Drawing.Size(198, 28);
            this.cbJobInterarrivalDistribution.TabIndex = 4;
            this.cbJobInterarrivalDistribution.Text = "Exponential";
            this.cbJobInterarrivalDistribution.SelectedIndexChanged += new System.EventHandler(this.cbJobInterarrivalDistribution_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Job Interarrival Distribution";
            // 
            // ppgJobInterarrival
            // 
            this.ppgJobInterarrival.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ppgJobInterarrival.Location = new System.Drawing.Point(0, 118);
            this.ppgJobInterarrival.Name = "ppgJobInterarrival";
            this.ppgJobInterarrival.Size = new System.Drawing.Size(308, 253);
            this.ppgJobInterarrival.TabIndex = 1;
            // 
            // btnRunToEnd
            // 
            this.btnRunToEnd.Location = new System.Drawing.Point(45, 361);
            this.btnRunToEnd.Name = "btnRunToEnd";
            this.btnRunToEnd.Size = new System.Drawing.Size(183, 37);
            this.btnRunToEnd.TabIndex = 15;
            this.btnRunToEnd.Text = "Run To End";
            this.btnRunToEnd.UseVisualStyleBackColor = true;
            this.btnRunToEnd.Click += new System.EventHandler(this.btnRunToEnd_Click);
            // 
            // btnOneEvent
            // 
            this.btnOneEvent.Location = new System.Drawing.Point(45, 322);
            this.btnOneEvent.Name = "btnOneEvent";
            this.btnOneEvent.Size = new System.Drawing.Size(183, 37);
            this.btnOneEvent.TabIndex = 14;
            this.btnOneEvent.Text = "One Event";
            this.btnOneEvent.UseVisualStyleBackColor = true;
            this.btnOneEvent.Click += new System.EventHandler(this.btnOneEvent_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(45, 279);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(183, 37);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cease Time";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Auto",
            "99999",
            "88888",
            "11111"});
            this.comboBox4.Location = new System.Drawing.Point(150, 232);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 28);
            this.comboBox4.TabIndex = 9;
            this.comboBox4.Text = "Auto";
            // 
            // cbAnimate
            // 
            this.cbAnimate.AutoSize = true;
            this.cbAnimate.Location = new System.Drawing.Point(34, 192);
            this.cbAnimate.Name = "cbAnimate";
            this.cbAnimate.Size = new System.Drawing.Size(92, 24);
            this.cbAnimate.TabIndex = 11;
            this.cbAnimate.Text = "Animate";
            this.cbAnimate.UseVisualStyleBackColor = true;
            // 
            // cbAllowChangeQueue
            // 
            this.cbAllowChangeQueue.AutoSize = true;
            this.cbAllowChangeQueue.Enabled = false;
            this.cbAllowChangeQueue.Location = new System.Drawing.Point(34, 145);
            this.cbAllowChangeQueue.Name = "cbAllowChangeQueue";
            this.cbAllowChangeQueue.Size = new System.Drawing.Size(187, 24);
            this.cbAllowChangeQueue.TabIndex = 10;
            this.cbAllowChangeQueue.Text = "Allow Change Queue";
            this.cbAllowChangeQueue.UseVisualStyleBackColor = true;
            // 
            // tbCeaseTime
            // 
            this.tbCeaseTime.Location = new System.Drawing.Point(34, 50);
            this.tbCeaseTime.Name = "tbCeaseTime";
            this.tbCeaseTime.Size = new System.Drawing.Size(100, 27);
            this.tbCeaseTime.TabIndex = 9;
            this.tbCeaseTime.Text = "480";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cease Time";
            // 
            // cbMultipleQueue
            // 
            this.cbMultipleQueue.AutoSize = true;
            this.cbMultipleQueue.Location = new System.Drawing.Point(34, 99);
            this.cbMultipleQueue.Name = "cbMultipleQueue";
            this.cbMultipleQueue.Size = new System.Drawing.Size(143, 24);
            this.cbMultipleQueue.TabIndex = 0;
            this.cbMultipleQueue.Text = "Multiple Queue";
            this.cbMultipleQueue.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.chtShow);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer4.Size = new System.Drawing.Size(1055, 793);
            this.splitContainer4.SplitterDistance = 330;
            this.splitContainer4.TabIndex = 0;
            // 
            // chtShow
            // 
            chartArea1.Name = "ChartArea1";
            chartArea2.Name = "ChartArea2";
            this.chtShow.ChartAreas.Add(chartArea1);
            this.chtShow.ChartAreas.Add(chartArea2);
            this.chtShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chtShow.Location = new System.Drawing.Point(0, 0);
            this.chtShow.Name = "chtShow";
            this.chtShow.Size = new System.Drawing.Size(1055, 330);
            this.chtShow.TabIndex = 0;
            this.chtShow.Text = "chart1";
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.rtbShow);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.chtPie);
            this.splitContainer5.Size = new System.Drawing.Size(1055, 459);
            this.splitContainer5.SplitterDistance = 705;
            this.splitContainer5.TabIndex = 0;
            // 
            // rtbShow
            // 
            this.rtbShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbShow.Location = new System.Drawing.Point(0, 0);
            this.rtbShow.Name = "rtbShow";
            this.rtbShow.Size = new System.Drawing.Size(705, 459);
            this.rtbShow.TabIndex = 0;
            this.rtbShow.Text = "";
            // 
            // chtPie
            // 
            this.chtPie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chtPie.Location = new System.Drawing.Point(0, 0);
            this.chtPie.Name = "chtPie";
            this.chtPie.Size = new System.Drawing.Size(346, 459);
            this.chtPie.TabIndex = 1;
            this.chtPie.Text = "chart2";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1718, 834);
            this.tabControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1718, 834);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Next Event Simulation Demo";
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtShow)).EndInit();
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtPie)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ComboBox cbSharedServiceTime;
        private System.Windows.Forms.PropertyGrid ppgServer;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button btnRunToEnd;
        private System.Windows.Forms.Button btnOneEvent;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtShow;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.RichTextBox rtbShow;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtPie;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox tbNumberofServers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbDifferentServiceRates;
        private System.Windows.Forms.ComboBox cbServices;
        private System.Windows.Forms.RadioButton rbSameServiceRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbJobInterarrivalDistribution;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PropertyGrid ppgJobInterarrival;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.CheckBox cbAnimate;
        private System.Windows.Forms.CheckBox cbAllowChangeQueue;
        private System.Windows.Forms.TextBox tbCeaseTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbMultipleQueue;
    }
}

