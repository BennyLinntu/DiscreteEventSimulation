
namespace R10546039YDLINAss03
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnOpenFile = new System.Windows.Forms.ToolStripButton();
            this.btnSaveFile = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControlInput = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rtbInput = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbShortageCost = new System.Windows.Forms.TextBox();
            this.tbHoldingCost = new System.Windows.Forms.TextBox();
            this.tbOrderSetupCost = new System.Windows.Forms.TextBox();
            this.tbItemCost = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbDemandVariance = new System.Windows.Forms.TextBox();
            this.tbAverageDemand = new System.Windows.Forms.TextBox();
            this.tbNumbersOfIntervals = new System.Windows.Forms.TextBox();
            this.tbMaximumInventoryLevel = new System.Windows.Forms.TextBox();
            this.tbMinimumInventoryLevel = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCreateData = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.tabControlOutput = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelTAHL = new System.Windows.Forms.Label();
            this.chtJobCount = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelAO = new System.Windows.Forms.Label();
            this.btnSimulateInventoryChanges = new System.Windows.Forms.Button();
            this.labelOF = new System.Windows.Forms.Label();
            this.labelAD = new System.Windows.Forms.Label();
            this.labelTASL = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.chtDependentCost = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelOR = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFindOptimum = new System.Windows.Forms.Button();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControlInput.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControlOutput.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtJobCount)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtDependentCost)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(1439, 30);
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
            this.splitContainer1.Panel1.Controls.Add(this.tabControlInput);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControlOutput);
            this.splitContainer1.Size = new System.Drawing.Size(1439, 730);
            this.splitContainer1.SplitterDistance = 672;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 1;
            // 
            // tabControlInput
            // 
            this.tabControlInput.Controls.Add(this.tabPage1);
            this.tabControlInput.Controls.Add(this.tabPage2);
            this.tabControlInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlInput.Location = new System.Drawing.Point(0, 0);
            this.tabControlInput.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabControlInput.Name = "tabControlInput";
            this.tabControlInput.SelectedIndex = 0;
            this.tabControlInput.Size = new System.Drawing.Size(672, 730);
            this.tabControlInput.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabPage1.Controls.Add(this.rtbInput);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPage1.Size = new System.Drawing.Size(664, 695);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Current Problem";
            // 
            // rtbInput
            // 
            this.rtbInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbInput.Location = new System.Drawing.Point(5, 4);
            this.rtbInput.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(654, 687);
            this.rtbInput.TabIndex = 0;
            this.rtbInput.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SkyBlue;
            this.tabPage2.Controls.Add(this.tbShortageCost);
            this.tabPage2.Controls.Add(this.tbHoldingCost);
            this.tabPage2.Controls.Add(this.tbOrderSetupCost);
            this.tabPage2.Controls.Add(this.tbItemCost);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.tbDemandVariance);
            this.tabPage2.Controls.Add(this.tbAverageDemand);
            this.tabPage2.Controls.Add(this.tbNumbersOfIntervals);
            this.tabPage2.Controls.Add(this.tbMaximumInventoryLevel);
            this.tabPage2.Controls.Add(this.tbMinimumInventoryLevel);
            this.tabPage2.Controls.Add(this.btnSave);
            this.tabPage2.Controls.Add(this.btnCreateData);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPage2.Size = new System.Drawing.Size(664, 695);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Create New Problem";
            // 
            // tbShortageCost
            // 
            this.tbShortageCost.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbShortageCost.Location = new System.Drawing.Point(411, 537);
            this.tbShortageCost.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbShortageCost.Name = "tbShortageCost";
            this.tbShortageCost.Size = new System.Drawing.Size(94, 29);
            this.tbShortageCost.TabIndex = 19;
            this.tbShortageCost.Text = "700";
            // 
            // tbHoldingCost
            // 
            this.tbHoldingCost.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbHoldingCost.Location = new System.Drawing.Point(411, 474);
            this.tbHoldingCost.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbHoldingCost.Name = "tbHoldingCost";
            this.tbHoldingCost.Size = new System.Drawing.Size(94, 29);
            this.tbHoldingCost.TabIndex = 18;
            this.tbHoldingCost.Text = "25";
            // 
            // tbOrderSetupCost
            // 
            this.tbOrderSetupCost.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbOrderSetupCost.Location = new System.Drawing.Point(411, 408);
            this.tbOrderSetupCost.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbOrderSetupCost.Name = "tbOrderSetupCost";
            this.tbOrderSetupCost.Size = new System.Drawing.Size(94, 29);
            this.tbOrderSetupCost.TabIndex = 17;
            this.tbOrderSetupCost.Text = "1000";
            // 
            // tbItemCost
            // 
            this.tbItemCost.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbItemCost.Location = new System.Drawing.Point(411, 346);
            this.tbItemCost.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbItemCost.Name = "tbItemCost";
            this.tbItemCost.Size = new System.Drawing.Size(94, 29);
            this.tbItemCost.TabIndex = 16;
            this.tbItemCost.Text = "8000";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 537);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Shortage Cost";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(115, 474);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Holding Cost";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(115, 408);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 23);
            this.label9.TabIndex = 13;
            this.label9.Text = "Order Setup Cost";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(115, 346);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 23);
            this.label10.TabIndex = 12;
            this.label10.Text = "Item Cost";
            // 
            // tbDemandVariance
            // 
            this.tbDemandVariance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbDemandVariance.Location = new System.Drawing.Point(411, 277);
            this.tbDemandVariance.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbDemandVariance.Name = "tbDemandVariance";
            this.tbDemandVariance.Size = new System.Drawing.Size(94, 29);
            this.tbDemandVariance.TabIndex = 11;
            this.tbDemandVariance.Text = "12";
            // 
            // tbAverageDemand
            // 
            this.tbAverageDemand.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbAverageDemand.Location = new System.Drawing.Point(411, 217);
            this.tbAverageDemand.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbAverageDemand.Name = "tbAverageDemand";
            this.tbAverageDemand.Size = new System.Drawing.Size(94, 29);
            this.tbAverageDemand.TabIndex = 10;
            this.tbAverageDemand.Text = "25";
            // 
            // tbNumbersOfIntervals
            // 
            this.tbNumbersOfIntervals.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbNumbersOfIntervals.Location = new System.Drawing.Point(411, 154);
            this.tbNumbersOfIntervals.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbNumbersOfIntervals.Name = "tbNumbersOfIntervals";
            this.tbNumbersOfIntervals.Size = new System.Drawing.Size(94, 29);
            this.tbNumbersOfIntervals.TabIndex = 9;
            this.tbNumbersOfIntervals.Text = "12";
            // 
            // tbMaximumInventoryLevel
            // 
            this.tbMaximumInventoryLevel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbMaximumInventoryLevel.Location = new System.Drawing.Point(411, 88);
            this.tbMaximumInventoryLevel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbMaximumInventoryLevel.Name = "tbMaximumInventoryLevel";
            this.tbMaximumInventoryLevel.Size = new System.Drawing.Size(94, 29);
            this.tbMaximumInventoryLevel.TabIndex = 8;
            this.tbMaximumInventoryLevel.Text = "60";
            // 
            // tbMinimumInventoryLevel
            // 
            this.tbMinimumInventoryLevel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbMinimumInventoryLevel.Location = new System.Drawing.Point(411, 26);
            this.tbMinimumInventoryLevel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbMinimumInventoryLevel.Name = "tbMinimumInventoryLevel";
            this.tbMinimumInventoryLevel.Size = new System.Drawing.Size(94, 29);
            this.tbMinimumInventoryLevel.TabIndex = 7;
            this.tbMinimumInventoryLevel.Text = "20";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(367, 600);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(207, 53);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnCreateData
            // 
            this.btnCreateData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCreateData.Location = new System.Drawing.Point(82, 600);
            this.btnCreateData.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCreateData.Name = "btnCreateData";
            this.btnCreateData.Size = new System.Drawing.Size(181, 53);
            this.btnCreateData.TabIndex = 5;
            this.btnCreateData.Text = "Create Data";
            this.btnCreateData.UseVisualStyleBackColor = true;
            this.btnCreateData.Click += new System.EventHandler(this.btnCreateData_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 277);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Demand Variance";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 217);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Average Demand";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numbers Of Intervals";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Maximum Inventory Level";
            // 
            // label
            // 
            this.label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(115, 26);
            this.label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(267, 23);
            this.label.TabIndex = 0;
            this.label.Text = "Minimum Inventory Level";
            // 
            // tabControlOutput
            // 
            this.tabControlOutput.Controls.Add(this.tabPage3);
            this.tabControlOutput.Controls.Add(this.tabPage4);
            this.tabControlOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlOutput.Location = new System.Drawing.Point(0, 0);
            this.tabControlOutput.Name = "tabControlOutput";
            this.tabControlOutput.SelectedIndex = 0;
            this.tabControlOutput.Size = new System.Drawing.Size(761, 730);
            this.tabControlOutput.TabIndex = 8;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tabPage3.Controls.Add(this.labelTAHL);
            this.tabPage3.Controls.Add(this.chtJobCount);
            this.tabPage3.Controls.Add(this.labelAO);
            this.tabPage3.Controls.Add(this.btnSimulateInventoryChanges);
            this.tabPage3.Controls.Add(this.labelOF);
            this.tabPage3.Controls.Add(this.labelAD);
            this.tabPage3.Controls.Add(this.labelTASL);
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(753, 695);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Inventory Levels";
            // 
            // labelTAHL
            // 
            this.labelTAHL.AutoSize = true;
            this.labelTAHL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelTAHL.Location = new System.Drawing.Point(360, 15);
            this.labelTAHL.Name = "labelTAHL";
            this.labelTAHL.Size = new System.Drawing.Size(309, 23);
            this.labelTAHL.TabIndex = 5;
            this.labelTAHL.Text = "Time-Averaged Holding Level:";
            // 
            // chtJobCount
            // 
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX.Title = "Period";
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisY.Title = "Inventory Level";
            chartArea1.Name = "ChartArea1";
            this.chtJobCount.ChartAreas.Add(chartArea1);
            this.chtJobCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.chtJobCount.Legends.Add(legend1);
            this.chtJobCount.Location = new System.Drawing.Point(3, 195);
            this.chtJobCount.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chtJobCount.Name = "chtJobCount";
            this.chtJobCount.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Minimum Level";
            series2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series2.Legend = "Legend1";
            series2.Name = "Maximum Level";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Blue;
            series3.Legend = "Legend1";
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series3.Name = "Inventory Level";
            this.chtJobCount.Series.Add(series1);
            this.chtJobCount.Series.Add(series2);
            this.chtJobCount.Series.Add(series3);
            this.chtJobCount.Size = new System.Drawing.Size(747, 497);
            this.chtJobCount.TabIndex = 1;
            this.chtJobCount.Text = "chart1";
            // 
            // labelAO
            // 
            this.labelAO.AutoSize = true;
            this.labelAO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelAO.Location = new System.Drawing.Point(26, 151);
            this.labelAO.Name = "labelAO";
            this.labelAO.Size = new System.Drawing.Size(159, 23);
            this.labelAO.TabIndex = 4;
            this.labelAO.Text = "Average Order:";
            // 
            // btnSimulateInventoryChanges
            // 
            this.btnSimulateInventoryChanges.Enabled = false;
            this.btnSimulateInventoryChanges.Location = new System.Drawing.Point(18, 15);
            this.btnSimulateInventoryChanges.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSimulateInventoryChanges.Name = "btnSimulateInventoryChanges";
            this.btnSimulateInventoryChanges.Size = new System.Drawing.Size(317, 50);
            this.btnSimulateInventoryChanges.TabIndex = 0;
            this.btnSimulateInventoryChanges.Text = "Simulate Inventory Changes";
            this.btnSimulateInventoryChanges.UseVisualStyleBackColor = true;
            this.btnSimulateInventoryChanges.Click += new System.EventHandler(this.btnSimulateInventoryChanges_Click);
            // 
            // labelOF
            // 
            this.labelOF.AutoSize = true;
            this.labelOF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelOF.Location = new System.Drawing.Point(360, 151);
            this.labelOF.Name = "labelOF";
            this.labelOF.Size = new System.Drawing.Size(182, 23);
            this.labelOF.TabIndex = 7;
            this.labelOF.Text = "Order Frequency:";
            // 
            // labelAD
            // 
            this.labelAD.AutoSize = true;
            this.labelAD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelAD.Location = new System.Drawing.Point(26, 82);
            this.labelAD.Name = "labelAD";
            this.labelAD.Size = new System.Drawing.Size(184, 23);
            this.labelAD.TabIndex = 3;
            this.labelAD.Text = "Average Demand:";
            // 
            // labelTASL
            // 
            this.labelTASL.AutoSize = true;
            this.labelTASL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelTASL.Location = new System.Drawing.Point(360, 82);
            this.labelTASL.Name = "labelTASL";
            this.labelTASL.Size = new System.Drawing.Size(319, 23);
            this.labelTASL.TabIndex = 6;
            this.labelTASL.Text = "Time-Averaged Shortage Level:";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tabPage4.Controls.Add(this.chtDependentCost);
            this.tabPage4.Controls.Add(this.labelOR);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.btnFindOptimum);
            this.tabPage4.Location = new System.Drawing.Point(4, 31);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(753, 695);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Optimization Application";
            // 
            // chtDependentCost
            // 
            chartArea2.AxisX.Title = "Minimum Level (s)";
            chartArea2.AxisY.Title = "Cost";
            chartArea2.BorderColor = System.Drawing.Color.DimGray;
            chartArea2.Name = "ChartArea1";
            this.chtDependentCost.ChartAreas.Add(chartArea2);
            this.chtDependentCost.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            this.chtDependentCost.Legends.Add(legend2);
            this.chtDependentCost.Location = new System.Drawing.Point(3, 171);
            this.chtDependentCost.Name = "chtDependentCost";
            this.chtDependentCost.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series4.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Left;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series4.Color = System.Drawing.Color.Fuchsia;
            series4.Legend = "Legend1";
            series4.Name = "Setup Spent";
            series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series5.Color = System.Drawing.Color.Yellow;
            series5.Legend = "Legend1";
            series5.Name = "Holding Spent";
            series5.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series6.Color = System.Drawing.Color.Red;
            series6.Legend = "Legend1";
            series6.Name = "Shortage Spent";
            series6.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            this.chtDependentCost.Series.Add(series4);
            this.chtDependentCost.Series.Add(series5);
            this.chtDependentCost.Series.Add(series6);
            this.chtDependentCost.Size = new System.Drawing.Size(747, 521);
            this.chtDependentCost.TabIndex = 4;
            this.chtDependentCost.Text = "DependentCost";
            title1.BorderWidth = 3;
            title1.Name = "Title1";
            title1.Text = "Dependent Cost";
            this.chtDependentCost.Titles.Add(title1);
            // 
            // labelOR
            // 
            this.labelOR.AutoSize = true;
            this.labelOR.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOR.ForeColor = System.Drawing.Color.Blue;
            this.labelOR.Location = new System.Drawing.Point(14, 92);
            this.labelOR.Name = "labelOR";
            this.labelOR.Size = new System.Drawing.Size(233, 23);
            this.labelOR.TabIndex = 2;
            this.labelOR.Text = "Optimization Results:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(15, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(567, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Optimization Simulation for Minimal Level from 0 to Maximal level -1";
            // 
            // btnFindOptimum
            // 
            this.btnFindOptimum.Enabled = false;
            this.btnFindOptimum.Location = new System.Drawing.Point(536, 34);
            this.btnFindOptimum.Name = "btnFindOptimum";
            this.btnFindOptimum.Size = new System.Drawing.Size(195, 48);
            this.btnFindOptimum.TabIndex = 0;
            this.btnFindOptimum.Text = "Find Optimum";
            this.btnFindOptimum.UseVisualStyleBackColor = true;
            this.btnFindOptimum.Click += new System.EventHandler(this.btnFindOptimum_Click);
            // 
            // dlgOpen
            // 
            this.dlgOpen.DefaultExt = "txt";
            this.dlgOpen.FileName = "*.txt";
            this.dlgOpen.Title = "Open the data file";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1439, 760);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assignment 003";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControlInput.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControlOutput.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtJobCount)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtDependentCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnOpenFile;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControlInput;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtJobCount;
        private System.Windows.Forms.Button btnSimulateInventoryChanges;
        private System.Windows.Forms.ToolStripButton btnSaveFile;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.RichTextBox rtbInput;
        private System.Windows.Forms.TextBox tbDemandVariance;
        private System.Windows.Forms.TextBox tbAverageDemand;
        private System.Windows.Forms.TextBox tbNumbersOfIntervals;
        private System.Windows.Forms.TextBox tbMaximumInventoryLevel;
        private System.Windows.Forms.TextBox tbMinimumInventoryLevel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCreateData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.TabControl tabControlOutput;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label labelTAHL;
        private System.Windows.Forms.Label labelAO;
        private System.Windows.Forms.Label labelOF;
        private System.Windows.Forms.Label labelAD;
        private System.Windows.Forms.Label labelTASL;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtDependentCost;
        private System.Windows.Forms.Label labelOR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFindOptimum;
        private System.Windows.Forms.TextBox tbShortageCost;
        private System.Windows.Forms.TextBox tbHoldingCost;
        private System.Windows.Forms.TextBox tbOrderSetupCost;
        private System.Windows.Forms.TextBox tbItemCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

