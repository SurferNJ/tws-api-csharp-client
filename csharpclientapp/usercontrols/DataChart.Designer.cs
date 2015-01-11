﻿namespace CSharpClientApp.usercontrols
{
    partial class DataChart
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblLow = new System.Windows.Forms.Label();
            this.lblLowLabel = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblCloseLabel = new System.Windows.Forms.Label();
            this.lblOpen = new System.Windows.Forms.Label();
            this.lblOpenLabel = new System.Windows.Forms.Label();
            this.lblHigh = new System.Windows.Forms.Label();
            this.lblHighLabel = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblYLabel = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblXLabel = new System.Windows.Forms.Label();
            this.historicalChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.contextMenuOrder = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuItemBuyLMT = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuItemSellLMT = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.historicalChart)).BeginInit();
            this.contextMenuOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLow
            // 
            this.lblLow.AutoSize = true;
            this.lblLow.Location = new System.Drawing.Point(584, 206);
            this.lblLow.Name = "lblLow";
            this.lblLow.Size = new System.Drawing.Size(16, 17);
            this.lblLow.TabIndex = 27;
            this.lblLow.Text = "0";
            // 
            // lblLowLabel
            // 
            this.lblLowLabel.AutoSize = true;
            this.lblLowLabel.Location = new System.Drawing.Point(537, 206);
            this.lblLowLabel.Name = "lblLowLabel";
            this.lblLowLabel.Size = new System.Drawing.Size(37, 17);
            this.lblLowLabel.TabIndex = 26;
            this.lblLowLabel.Text = "Low:";
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Location = new System.Drawing.Point(378, 206);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(16, 17);
            this.lblClose.TabIndex = 25;
            this.lblClose.Text = "0";
            // 
            // lblCloseLabel
            // 
            this.lblCloseLabel.AutoSize = true;
            this.lblCloseLabel.Location = new System.Drawing.Point(331, 206);
            this.lblCloseLabel.Name = "lblCloseLabel";
            this.lblCloseLabel.Size = new System.Drawing.Size(47, 17);
            this.lblCloseLabel.TabIndex = 24;
            this.lblCloseLabel.Text = "Close:";
            // 
            // lblOpen
            // 
            this.lblOpen.AutoSize = true;
            this.lblOpen.Location = new System.Drawing.Point(289, 206);
            this.lblOpen.Name = "lblOpen";
            this.lblOpen.Size = new System.Drawing.Size(16, 17);
            this.lblOpen.TabIndex = 23;
            this.lblOpen.Text = "0";
            // 
            // lblOpenLabel
            // 
            this.lblOpenLabel.AutoSize = true;
            this.lblOpenLabel.Location = new System.Drawing.Point(242, 206);
            this.lblOpenLabel.Name = "lblOpenLabel";
            this.lblOpenLabel.Size = new System.Drawing.Size(47, 17);
            this.lblOpenLabel.TabIndex = 22;
            this.lblOpenLabel.Text = "Open:";
            // 
            // lblHigh
            // 
            this.lblHigh.AutoSize = true;
            this.lblHigh.Location = new System.Drawing.Point(481, 206);
            this.lblHigh.Name = "lblHigh";
            this.lblHigh.Size = new System.Drawing.Size(16, 17);
            this.lblHigh.TabIndex = 21;
            this.lblHigh.Text = "0";
            // 
            // lblHighLabel
            // 
            this.lblHighLabel.AutoSize = true;
            this.lblHighLabel.Location = new System.Drawing.Point(434, 206);
            this.lblHighLabel.Name = "lblHighLabel";
            this.lblHighLabel.Size = new System.Drawing.Size(41, 17);
            this.lblHighLabel.TabIndex = 20;
            this.lblHighLabel.Text = "High:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(191, 206);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(0, 17);
            this.lblY.TabIndex = 19;
            // 
            // lblYLabel
            // 
            this.lblYLabel.AutoSize = true;
            this.lblYLabel.Location = new System.Drawing.Point(170, 206);
            this.lblYLabel.Name = "lblYLabel";
            this.lblYLabel.Size = new System.Drawing.Size(21, 17);
            this.lblYLabel.TabIndex = 18;
            this.lblYLabel.Text = "Y:";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(22, 206);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(0, 17);
            this.lblX.TabIndex = 17;
            // 
            // lblXLabel
            // 
            this.lblXLabel.AutoSize = true;
            this.lblXLabel.Location = new System.Drawing.Point(1, 206);
            this.lblXLabel.Name = "lblXLabel";
            this.lblXLabel.Size = new System.Drawing.Size(21, 17);
            this.lblXLabel.TabIndex = 16;
            this.lblXLabel.Text = "X:";
            // 
            // historicalChart
            // 
            this.historicalChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.historicalChart.BackColor = System.Drawing.Color.LightGray;
            this.historicalChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.historicalChart.BackImageTransparentColor = System.Drawing.Color.Silver;
            this.historicalChart.BackSecondaryColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 100F;
            chartArea1.Position.Width = 100F;
            this.historicalChart.ChartAreas.Add(chartArea1);
            this.historicalChart.ContextMenuStrip = this.contextMenuOrder;
            legend1.Name = "Legend1";
            this.historicalChart.Legends.Add(legend1);
            this.historicalChart.Location = new System.Drawing.Point(0, 0);
            this.historicalChart.Margin = new System.Windows.Forms.Padding(4);
            this.historicalChart.Name = "historicalChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series1.IsVisibleInLegend = false;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series1.YValuesPerPoint = 4;
            this.historicalChart.Series.Add(series1);
            this.historicalChart.Size = new System.Drawing.Size(618, 202);
            this.historicalChart.TabIndex = 15;
            this.historicalChart.Text = "Historical Data";
            this.historicalChart.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.historicalChart_MouseDoubleClick);
            this.historicalChart.MouseEnter += new System.EventHandler(this.historicalChart_MouseEnter);
            this.historicalChart.MouseLeave += new System.EventHandler(this.historicalChart_MouseLeave);
            this.historicalChart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.historicalChart_MouseMove);
            this.historicalChart.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.historicalChart_MouseWheel);
            // 
            // contextMenuOrder
            // 
            this.contextMenuOrder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuItemBuyLMT,
            this.contextMenuItemSellLMT});
            this.contextMenuOrder.Name = "contextMenuOrder";
            this.contextMenuOrder.Size = new System.Drawing.Size(135, 52);
            // 
            // contextMenuItemBuyLMT
            // 
            this.contextMenuItemBuyLMT.Name = "contextMenuItemBuyLMT";
            this.contextMenuItemBuyLMT.Size = new System.Drawing.Size(134, 24);
            this.contextMenuItemBuyLMT.Text = "Buy LMT";
            this.contextMenuItemBuyLMT.Click += new System.EventHandler(this.contextMenuItemBuyLMT_Click);
            // 
            // contextMenuItemSellLMT
            // 
            this.contextMenuItemSellLMT.Name = "contextMenuItemSellLMT";
            this.contextMenuItemSellLMT.Size = new System.Drawing.Size(134, 24);
            this.contextMenuItemSellLMT.Text = "Sell LMT";
            this.contextMenuItemSellLMT.Click += new System.EventHandler(this.contextMenuItemSellLMT_Click);
            // 
            // DataChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblLow);
            this.Controls.Add(this.lblLowLabel);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblCloseLabel);
            this.Controls.Add(this.lblOpen);
            this.Controls.Add(this.lblOpenLabel);
            this.Controls.Add(this.lblHigh);
            this.Controls.Add(this.lblHighLabel);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblYLabel);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblXLabel);
            this.Controls.Add(this.historicalChart);
            this.Name = "DataChart";
            this.Size = new System.Drawing.Size(622, 227);
            ((System.ComponentModel.ISupportInitialize)(this.historicalChart)).EndInit();
            this.contextMenuOrder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLow;
        private System.Windows.Forms.Label lblLowLabel;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblCloseLabel;
        private System.Windows.Forms.Label lblOpen;
        private System.Windows.Forms.Label lblOpenLabel;
        private System.Windows.Forms.Label lblHigh;
        private System.Windows.Forms.Label lblHighLabel;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblYLabel;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblXLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart historicalChart;
        private System.Windows.Forms.ContextMenuStrip contextMenuOrder;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItemBuyLMT;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItemSellLMT;
    }
}
