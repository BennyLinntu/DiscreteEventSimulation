
namespace _2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRunOne = new System.Windows.Forms.Button();
            this.btnRunToEnd = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ppgShow = new System.Windows.Forms.PropertyGrid();
            this.rbQueue = new System.Windows.Forms.RadioButton();
            this.rbServer = new System.Windows.Forms.RadioButton();
            this.rbClientGenerator = new System.Windows.Forms.RadioButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.chtPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rtbEvent = new System.Windows.Forms.RichTextBox();
            this.labelShow = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chtShow = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtPie)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtShow)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.Image")));
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.Location = new System.Drawing.Point(30, 28);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(224, 50);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create A SSQ Model";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(30, 84);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(224, 50);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRunOne
            // 
            this.btnRunOne.Enabled = false;
            this.btnRunOne.Image = ((System.Drawing.Image)(resources.GetObject("btnRunOne.Image")));
            this.btnRunOne.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRunOne.Location = new System.Drawing.Point(30, 140);
            this.btnRunOne.Name = "btnRunOne";
            this.btnRunOne.Size = new System.Drawing.Size(224, 50);
            this.btnRunOne.TabIndex = 2;
            this.btnRunOne.Text = "Run One Event";
            this.btnRunOne.UseVisualStyleBackColor = true;
            this.btnRunOne.Click += new System.EventHandler(this.btnRunOne_Click);
            // 
            // btnRunToEnd
            // 
            this.btnRunToEnd.Enabled = false;
            this.btnRunToEnd.Image = ((System.Drawing.Image)(resources.GetObject("btnRunToEnd.Image")));
            this.btnRunToEnd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRunToEnd.Location = new System.Drawing.Point(30, 196);
            this.btnRunToEnd.Name = "btnRunToEnd";
            this.btnRunToEnd.Size = new System.Drawing.Size(224, 50);
            this.btnRunToEnd.TabIndex = 3;
            this.btnRunToEnd.Text = "Run To End";
            this.btnRunToEnd.UseVisualStyleBackColor = true;
            this.btnRunToEnd.Click += new System.EventHandler(this.btnRunToEnd_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.btnCreate);
            this.splitContainer1.Panel1.Controls.Add(this.btnRunToEnd);
            this.splitContainer1.Panel1.Controls.Add(this.btnReset);
            this.splitContainer1.Panel1.Controls.Add(this.btnRunOne);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1133, 827);
            this.splitContainer1.SplitterDistance = 349;
            this.splitContainer1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ppgShow);
            this.groupBox1.Controls.Add(this.rbQueue);
            this.groupBox1.Controls.Add(this.rbServer);
            this.groupBox1.Controls.Add(this.rbClientGenerator);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 558);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Property";
            // 
            // ppgShow
            // 
            this.ppgShow.CategorySplitterColor = System.Drawing.Color.LightCyan;
            this.ppgShow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ppgShow.Location = new System.Drawing.Point(3, 117);
            this.ppgShow.Name = "ppgShow";
            this.ppgShow.Size = new System.Drawing.Size(343, 438);
            this.ppgShow.TabIndex = 3;
            this.ppgShow.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.ppgQueue_PropertyValueChanged);
            // 
            // rbQueue
            // 
            this.rbQueue.AutoSize = true;
            this.rbQueue.Enabled = false;
            this.rbQueue.Location = new System.Drawing.Point(16, 90);
            this.rbQueue.Name = "rbQueue";
            this.rbQueue.Size = new System.Drawing.Size(72, 21);
            this.rbQueue.TabIndex = 2;
            this.rbQueue.Text = "Queue";
            this.rbQueue.UseVisualStyleBackColor = true;
            this.rbQueue.Click += new System.EventHandler(this.rbClientGenerator_Click);
            // 
            // rbServer
            // 
            this.rbServer.AutoSize = true;
            this.rbServer.Location = new System.Drawing.Point(16, 63);
            this.rbServer.Name = "rbServer";
            this.rbServer.Size = new System.Drawing.Size(71, 21);
            this.rbServer.TabIndex = 1;
            this.rbServer.Text = "Server";
            this.rbServer.UseVisualStyleBackColor = true;
            this.rbServer.Click += new System.EventHandler(this.rbClientGenerator_Click);
            // 
            // rbClientGenerator
            // 
            this.rbClientGenerator.AutoSize = true;
            this.rbClientGenerator.Checked = true;
            this.rbClientGenerator.Location = new System.Drawing.Point(16, 36);
            this.rbClientGenerator.Name = "rbClientGenerator";
            this.rbClientGenerator.Size = new System.Drawing.Size(133, 21);
            this.rbClientGenerator.TabIndex = 0;
            this.rbClientGenerator.TabStop = true;
            this.rbClientGenerator.Text = "Client Generator";
            this.rbClientGenerator.UseVisualStyleBackColor = true;
            this.rbClientGenerator.Click += new System.EventHandler(this.rbClientGenerator_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.splitContainer2.Panel1.Controls.Add(this.chtPie);
            this.splitContainer2.Panel1.Controls.Add(this.rtbEvent);
            this.splitContainer2.Panel1.Controls.Add(this.labelShow);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer2.Size = new System.Drawing.Size(780, 827);
            this.splitContainer2.SplitterDistance = 327;
            this.splitContainer2.TabIndex = 0;
            // 
            // chtPie
            // 
            chartArea1.Name = "ChartArea1";
            this.chtPie.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtPie.Legends.Add(legend1);
            this.chtPie.Location = new System.Drawing.Point(471, 28);
            this.chtPie.Name = "chtPie";
            this.chtPie.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtPie.Series.Add(series1);
            this.chtPie.Size = new System.Drawing.Size(282, 272);
            this.chtPie.TabIndex = 2;
            this.chtPie.Text = "chart1";
            // 
            // rtbEvent
            // 
            this.rtbEvent.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rtbEvent.Location = new System.Drawing.Point(24, 67);
            this.rtbEvent.Name = "rtbEvent";
            this.rtbEvent.Size = new System.Drawing.Size(421, 236);
            this.rtbEvent.TabIndex = 1;
            this.rtbEvent.Text = "";
            // 
            // labelShow
            // 
            this.labelShow.AutoSize = true;
            this.labelShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShow.ForeColor = System.Drawing.Color.Maroon;
            this.labelShow.Location = new System.Drawing.Point(40, 28);
            this.labelShow.Name = "labelShow";
            this.labelShow.Size = new System.Drawing.Size(185, 25);
            this.labelShow.TabIndex = 0;
            this.labelShow.Text = "Current Event List";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(780, 496);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chtShow);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(772, 467);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Server & Queue";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chtShow
            // 
            this.chtShow.BackColor = System.Drawing.Color.LightCyan;
            chartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea2.AxisX.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisX.Title = "Time";
            chartArea2.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea2.AxisY.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisY.Title = "Count";
            chartArea2.Name = "ChartArea1";
            chartArea3.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea3.AxisX.Title = "Server";
            chartArea3.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea3.AxisY.Title = "Time";
            chartArea3.Name = "ChartArea2";
            this.chtShow.ChartAreas.Add(chartArea2);
            this.chtShow.ChartAreas.Add(chartArea3);
            this.chtShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chtShow.Location = new System.Drawing.Point(3, 3);
            this.chtShow.Name = "chtShow";
            this.chtShow.Size = new System.Drawing.Size(766, 461);
            this.chtShow.TabIndex = 0;
            this.chtShow.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(772, 467);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Client";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 827);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "R10546039 YiDaLin DES for SSQ(OO)";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtPie)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRunOne;
        private System.Windows.Forms.Button btnRunToEnd;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PropertyGrid ppgShow;
        private System.Windows.Forms.RadioButton rbQueue;
        private System.Windows.Forms.RadioButton rbServer;
        private System.Windows.Forms.RadioButton rbClientGenerator;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.RichTextBox rtbEvent;
        private System.Windows.Forms.Label labelShow;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtShow;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtPie;
    }
}

