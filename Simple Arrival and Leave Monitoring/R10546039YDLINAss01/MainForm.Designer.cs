
namespace R10546039YDLINAss01
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnOpenFile = new System.Windows.Forms.ToolStripButton();
            this.btnSaveFile = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rtbInput = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.chtJobCount = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnCreateJobCountLine = new System.Windows.Forms.Button();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtJobCount)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(1542, 30);
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
            this.splitContainer1.Panel1.Controls.Add(this.tabControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chtJobCount);
            this.splitContainer1.Panel2.Controls.Add(this.btnCreateJobCountLine);
            this.splitContainer1.Size = new System.Drawing.Size(1542, 630);
            this.splitContainer1.SplitterDistance = 721;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(721, 630);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabPage1.Controls.Add(this.rtbInput);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPage1.Size = new System.Drawing.Size(713, 595);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Current Problem";
            // 
            // rtbInput
            // 
            this.rtbInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbInput.Location = new System.Drawing.Point(5, 4);
            this.rtbInput.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(703, 587);
            this.rtbInput.TabIndex = 0;
            this.rtbInput.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SkyBlue;
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
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPage2.Size = new System.Drawing.Size(713, 595);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Create New Problem";
            // 
            // tbNumberOfJob
            // 
            this.tbNumberOfJob.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbNumberOfJob.Location = new System.Drawing.Point(433, 312);
            this.tbNumberOfJob.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbNumberOfJob.Name = "tbNumberOfJob";
            this.tbNumberOfJob.Size = new System.Drawing.Size(148, 29);
            this.tbNumberOfJob.TabIndex = 11;
            this.tbNumberOfJob.Text = "20";
            // 
            // tbDeviationService
            // 
            this.tbDeviationService.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbDeviationService.Location = new System.Drawing.Point(433, 252);
            this.tbDeviationService.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbDeviationService.Name = "tbDeviationService";
            this.tbDeviationService.Size = new System.Drawing.Size(148, 29);
            this.tbDeviationService.TabIndex = 10;
            this.tbDeviationService.Text = "2.0";
            // 
            // tbAverageServiceTime
            // 
            this.tbAverageServiceTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbAverageServiceTime.Location = new System.Drawing.Point(433, 189);
            this.tbAverageServiceTime.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbAverageServiceTime.Name = "tbAverageServiceTime";
            this.tbAverageServiceTime.Size = new System.Drawing.Size(148, 29);
            this.tbAverageServiceTime.TabIndex = 9;
            this.tbAverageServiceTime.Text = "6.2";
            // 
            // tbDeviationInterarrival
            // 
            this.tbDeviationInterarrival.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbDeviationInterarrival.Location = new System.Drawing.Point(433, 123);
            this.tbDeviationInterarrival.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbDeviationInterarrival.Name = "tbDeviationInterarrival";
            this.tbDeviationInterarrival.Size = new System.Drawing.Size(148, 29);
            this.tbDeviationInterarrival.TabIndex = 8;
            this.tbDeviationInterarrival.Text = "6";
            // 
            // tbAverageInterarrivalTime
            // 
            this.tbAverageInterarrivalTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbAverageInterarrivalTime.Location = new System.Drawing.Point(433, 61);
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
            this.btnSave.Location = new System.Drawing.Point(142, 486);
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
            this.btnCreateData.Location = new System.Drawing.Point(142, 398);
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
            this.label5.Location = new System.Drawing.Point(137, 312);
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
            this.label4.Location = new System.Drawing.Point(137, 252);
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
            this.label3.Location = new System.Drawing.Point(137, 189);
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
            this.label2.Location = new System.Drawing.Point(137, 123);
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
            this.label1.Location = new System.Drawing.Point(137, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Average Interarrival Time";
            // 
            // chtJobCount
            // 
            this.chtJobCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX.Title = "Time";
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisY.Title = "Count";
            chartArea1.Name = "ChartArea1";
            this.chtJobCount.ChartAreas.Add(chartArea1);
            this.chtJobCount.Location = new System.Drawing.Point(5, 108);
            this.chtJobCount.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chtJobCount.Name = "chtJobCount";
            this.chtJobCount.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series1.Name = "Series1";
            this.chtJobCount.Series.Add(series1);
            this.chtJobCount.Size = new System.Drawing.Size(792, 513);
            this.chtJobCount.TabIndex = 1;
            this.chtJobCount.Text = "chart1";
            // 
            // btnCreateJobCountLine
            // 
            this.btnCreateJobCountLine.Enabled = false;
            this.btnCreateJobCountLine.Location = new System.Drawing.Point(5, 34);
            this.btnCreateJobCountLine.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCreateJobCountLine.Name = "btnCreateJobCountLine";
            this.btnCreateJobCountLine.Size = new System.Drawing.Size(274, 65);
            this.btnCreateJobCountLine.TabIndex = 0;
            this.btnCreateJobCountLine.Text = "Show Job Count";
            this.btnCreateJobCountLine.UseVisualStyleBackColor = true;
            this.btnCreateJobCountLine.Click += new System.EventHandler(this.btnCreateJobCountLine_Click);
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
            this.ClientSize = new System.Drawing.Size(1542, 660);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assignment 001";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtJobCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnOpenFile;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl;
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
    }
}

