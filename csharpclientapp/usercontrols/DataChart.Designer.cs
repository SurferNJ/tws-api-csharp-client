namespace CSharpClientApp.usercontrols
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuItemEconomicCalendar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDailyBattlePlan = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemScopePrevious = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemScopeNext = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemExclude = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCleanDataPoints = new System.Windows.Forms.ToolStripMenuItem();
            this.checkEMA10 = new System.Windows.Forms.CheckBox();
            this.checkEMA21 = new System.Windows.Forms.CheckBox();
            this.checkEMA30 = new System.Windows.Forms.CheckBox();
            this.checkEMA50 = new System.Windows.Forms.CheckBox();
            this.checkEMA100 = new System.Windows.Forms.CheckBox();
            this.checkEMA150 = new System.Windows.Forms.CheckBox();
            this.checkEMA200 = new System.Windows.Forms.CheckBox();
            this.labelCurrentPrice = new System.Windows.Forms.Label();
            this.checkDraw = new System.Windows.Forms.CheckBox();
            this.checkVolumeOnOff = new System.Windows.Forms.CheckBox();
            this.checkTops = new System.Windows.Forms.CheckBox();
            this.checkDrawReferenceLine = new System.Windows.Forms.CheckBox();
            this.toolStripMenuClosingBell = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.historicalChart)).BeginInit();
            this.contextMenuOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLow
            // 
            this.lblLow.AutoSize = true;
            this.lblLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLow.Location = new System.Drawing.Point(560, 303);
            this.lblLow.Name = "lblLow";
            this.lblLow.Size = new System.Drawing.Size(16, 17);
            this.lblLow.TabIndex = 27;
            this.lblLow.Text = "0";
            // 
            // lblLowLabel
            // 
            this.lblLowLabel.AutoSize = true;
            this.lblLowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowLabel.Location = new System.Drawing.Point(513, 303);
            this.lblLowLabel.Name = "lblLowLabel";
            this.lblLowLabel.Size = new System.Drawing.Size(37, 17);
            this.lblLowLabel.TabIndex = 26;
            this.lblLowLabel.Text = "Low:";
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.Location = new System.Drawing.Point(354, 303);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(16, 17);
            this.lblClose.TabIndex = 25;
            this.lblClose.Text = "0";
            // 
            // lblCloseLabel
            // 
            this.lblCloseLabel.AutoSize = true;
            this.lblCloseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloseLabel.Location = new System.Drawing.Point(307, 303);
            this.lblCloseLabel.Name = "lblCloseLabel";
            this.lblCloseLabel.Size = new System.Drawing.Size(47, 17);
            this.lblCloseLabel.TabIndex = 24;
            this.lblCloseLabel.Text = "Close:";
            // 
            // lblOpen
            // 
            this.lblOpen.AutoSize = true;
            this.lblOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpen.Location = new System.Drawing.Point(258, 303);
            this.lblOpen.Name = "lblOpen";
            this.lblOpen.Size = new System.Drawing.Size(16, 17);
            this.lblOpen.TabIndex = 23;
            this.lblOpen.Text = "0";
            // 
            // lblOpenLabel
            // 
            this.lblOpenLabel.AutoSize = true;
            this.lblOpenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenLabel.Location = new System.Drawing.Point(211, 303);
            this.lblOpenLabel.Name = "lblOpenLabel";
            this.lblOpenLabel.Size = new System.Drawing.Size(47, 17);
            this.lblOpenLabel.TabIndex = 22;
            this.lblOpenLabel.Text = "Open:";
            // 
            // lblHigh
            // 
            this.lblHigh.AutoSize = true;
            this.lblHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHigh.Location = new System.Drawing.Point(457, 303);
            this.lblHigh.Name = "lblHigh";
            this.lblHigh.Size = new System.Drawing.Size(16, 17);
            this.lblHigh.TabIndex = 21;
            this.lblHigh.Text = "0";
            // 
            // lblHighLabel
            // 
            this.lblHighLabel.AutoSize = true;
            this.lblHighLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighLabel.Location = new System.Drawing.Point(410, 303);
            this.lblHighLabel.Name = "lblHighLabel";
            this.lblHighLabel.Size = new System.Drawing.Size(41, 17);
            this.lblHighLabel.TabIndex = 20;
            this.lblHighLabel.Text = "High:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY.Location = new System.Drawing.Point(160, 303);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(0, 17);
            this.lblY.TabIndex = 19;
            // 
            // lblYLabel
            // 
            this.lblYLabel.AutoSize = true;
            this.lblYLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYLabel.Location = new System.Drawing.Point(139, 303);
            this.lblYLabel.Name = "lblYLabel";
            this.lblYLabel.Size = new System.Drawing.Size(21, 17);
            this.lblYLabel.TabIndex = 18;
            this.lblYLabel.Text = "Y:";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(24, 303);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(0, 17);
            this.lblX.TabIndex = 17;
            // 
            // lblXLabel
            // 
            this.lblXLabel.AutoSize = true;
            this.lblXLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXLabel.Location = new System.Drawing.Point(3, 303);
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
            chartArea1.AlignWithChartArea = "ChartArea2";
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 100F;
            chartArea1.Position.Width = 100F;
            chartArea2.AlignWithChartArea = "ChartArea1";
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea2";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 50F;
            chartArea2.Position.Width = 100F;
            chartArea2.Position.Y = 50F;
            this.historicalChart.ChartAreas.Add(chartArea1);
            this.historicalChart.ChartAreas.Add(chartArea2);
            this.historicalChart.ContextMenuStrip = this.contextMenuOrder;
            legend1.Name = "Legend1";
            this.historicalChart.Legends.Add(legend1);
            this.historicalChart.Location = new System.Drawing.Point(4, 31);
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
            series2.ChartArea = "ChartArea2";
            series2.IsVisibleInLegend = false;
            series2.IsXValueIndexed = true;
            series2.LabelForeColor = System.Drawing.SystemColors.MenuHighlight;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            series2.SmartLabelStyle.Enabled = false;
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.historicalChart.Series.Add(series1);
            this.historicalChart.Series.Add(series2);
            this.historicalChart.Size = new System.Drawing.Size(612, 268);
            this.historicalChart.TabIndex = 15;
            this.historicalChart.Text = "Historical Data";
            this.historicalChart.AxisViewChanged += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ViewEventArgs>(this.historicalChart_AxisViewChanged);
            this.historicalChart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.historicalChart_MouseClick);
            this.historicalChart.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.historicalChart_MouseDoubleClick);
            this.historicalChart.MouseEnter += new System.EventHandler(this.historicalChart_MouseEnter);
            this.historicalChart.MouseLeave += new System.EventHandler(this.historicalChart_MouseLeave);
            this.historicalChart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.historicalChart_MouseMove);
            this.historicalChart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.historicalChart_MouseUp);
            this.historicalChart.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.historicalChart_MouseWheel);
            // 
            // contextMenuOrder
            // 
            this.contextMenuOrder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuItemBuyLMT,
            this.contextMenuItemSellLMT,
            this.toolStripSeparator1,
            this.toolStripMenuClosingBell,
            this.contextMenuItemEconomicCalendar,
            this.toolStripMenuItemDailyBattlePlan,
            this.toolStripSeparator2,
            this.toolStripMenuItemScopePrevious,
            this.toolStripMenuItemScopeNext,
            this.toolStripSeparator3,
            this.toolStripMenuItemExclude,
            this.toolStripMenuItemCleanDataPoints});
            this.contextMenuOrder.Name = "contextMenuOrder";
            this.contextMenuOrder.Size = new System.Drawing.Size(207, 266);
            // 
            // contextMenuItemBuyLMT
            // 
            this.contextMenuItemBuyLMT.Name = "contextMenuItemBuyLMT";
            this.contextMenuItemBuyLMT.Size = new System.Drawing.Size(206, 24);
            this.contextMenuItemBuyLMT.Text = "Buy LMT";
            this.contextMenuItemBuyLMT.Click += new System.EventHandler(this.contextMenuItemBuyLMT_Click);
            // 
            // contextMenuItemSellLMT
            // 
            this.contextMenuItemSellLMT.Name = "contextMenuItemSellLMT";
            this.contextMenuItemSellLMT.Size = new System.Drawing.Size(206, 24);
            this.contextMenuItemSellLMT.Text = "Sell LMT";
            this.contextMenuItemSellLMT.Click += new System.EventHandler(this.contextMenuItemSellLMT_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(203, 6);
            // 
            // contextMenuItemEconomicCalendar
            // 
            this.contextMenuItemEconomicCalendar.Name = "contextMenuItemEconomicCalendar";
            this.contextMenuItemEconomicCalendar.Size = new System.Drawing.Size(206, 24);
            this.contextMenuItemEconomicCalendar.Text = "Economic Calendar";
            this.contextMenuItemEconomicCalendar.Click += new System.EventHandler(this.contextMenuItemEconomicCalendar_Click);
            // 
            // toolStripMenuItemDailyBattlePlan
            // 
            this.toolStripMenuItemDailyBattlePlan.Name = "toolStripMenuItemDailyBattlePlan";
            this.toolStripMenuItemDailyBattlePlan.Size = new System.Drawing.Size(206, 24);
            this.toolStripMenuItemDailyBattlePlan.Text = "Daily Battle Plan";
            this.toolStripMenuItemDailyBattlePlan.Click += new System.EventHandler(this.toolStripMenuItemDailyBattlePlan_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(203, 6);
            // 
            // toolStripMenuItemScopePrevious
            // 
            this.toolStripMenuItemScopePrevious.Name = "toolStripMenuItemScopePrevious";
            this.toolStripMenuItemScopePrevious.Size = new System.Drawing.Size(206, 24);
            this.toolStripMenuItemScopePrevious.Text = "Scope Previous";
            this.toolStripMenuItemScopePrevious.Click += new System.EventHandler(this.toolStripMenuItemScopePrevious_Click);
            // 
            // toolStripMenuItemScopeNext
            // 
            this.toolStripMenuItemScopeNext.Name = "toolStripMenuItemScopeNext";
            this.toolStripMenuItemScopeNext.Size = new System.Drawing.Size(206, 24);
            this.toolStripMenuItemScopeNext.Text = "Scope Next";
            this.toolStripMenuItemScopeNext.Click += new System.EventHandler(this.toolStripMenuItemScopeNext_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(203, 6);
            // 
            // toolStripMenuItemExclude
            // 
            this.toolStripMenuItemExclude.Name = "toolStripMenuItemExclude";
            this.toolStripMenuItemExclude.Size = new System.Drawing.Size(206, 24);
            this.toolStripMenuItemExclude.Text = "Exclude This Point";
            this.toolStripMenuItemExclude.Click += new System.EventHandler(this.toolStripMenuItemExclude_Click);
            // 
            // toolStripMenuItemCleanDataPoints
            // 
            this.toolStripMenuItemCleanDataPoints.Name = "toolStripMenuItemCleanDataPoints";
            this.toolStripMenuItemCleanDataPoints.Size = new System.Drawing.Size(206, 24);
            this.toolStripMenuItemCleanDataPoints.Text = "Clean Bad Points";
            this.toolStripMenuItemCleanDataPoints.Click += new System.EventHandler(this.toolStripMenuItemCleanDataPoints_Click);
            // 
            // checkEMA10
            // 
            this.checkEMA10.AutoSize = true;
            this.checkEMA10.Location = new System.Drawing.Point(10, 3);
            this.checkEMA10.Name = "checkEMA10";
            this.checkEMA10.Size = new System.Drawing.Size(46, 21);
            this.checkEMA10.TabIndex = 28;
            this.checkEMA10.Text = "10";
            this.checkEMA10.UseVisualStyleBackColor = true;
            this.checkEMA10.CheckedChanged += new System.EventHandler(this.checkEMA10_CheckedChanged);
            // 
            // checkEMA21
            // 
            this.checkEMA21.AutoSize = true;
            this.checkEMA21.Location = new System.Drawing.Point(62, 3);
            this.checkEMA21.Name = "checkEMA21";
            this.checkEMA21.Size = new System.Drawing.Size(46, 21);
            this.checkEMA21.TabIndex = 29;
            this.checkEMA21.Text = "21";
            this.checkEMA21.UseVisualStyleBackColor = true;
            this.checkEMA21.CheckedChanged += new System.EventHandler(this.checkEMA21_CheckedChanged);
            // 
            // checkEMA30
            // 
            this.checkEMA30.AutoSize = true;
            this.checkEMA30.Location = new System.Drawing.Point(114, 3);
            this.checkEMA30.Name = "checkEMA30";
            this.checkEMA30.Size = new System.Drawing.Size(46, 21);
            this.checkEMA30.TabIndex = 30;
            this.checkEMA30.Text = "30";
            this.checkEMA30.UseVisualStyleBackColor = true;
            this.checkEMA30.CheckedChanged += new System.EventHandler(this.checkEMA30_CheckedChanged);
            // 
            // checkEMA50
            // 
            this.checkEMA50.AutoSize = true;
            this.checkEMA50.Location = new System.Drawing.Point(166, 3);
            this.checkEMA50.Name = "checkEMA50";
            this.checkEMA50.Size = new System.Drawing.Size(46, 21);
            this.checkEMA50.TabIndex = 31;
            this.checkEMA50.Text = "50";
            this.checkEMA50.UseVisualStyleBackColor = true;
            this.checkEMA50.CheckedChanged += new System.EventHandler(this.checkEMA50_CheckedChanged);
            // 
            // checkEMA100
            // 
            this.checkEMA100.AutoSize = true;
            this.checkEMA100.Location = new System.Drawing.Point(218, 3);
            this.checkEMA100.Name = "checkEMA100";
            this.checkEMA100.Size = new System.Drawing.Size(54, 21);
            this.checkEMA100.TabIndex = 32;
            this.checkEMA100.Text = "100";
            this.checkEMA100.UseVisualStyleBackColor = true;
            this.checkEMA100.CheckedChanged += new System.EventHandler(this.checkEMA100_CheckedChanged);
            // 
            // checkEMA150
            // 
            this.checkEMA150.AutoSize = true;
            this.checkEMA150.Location = new System.Drawing.Point(270, 3);
            this.checkEMA150.Name = "checkEMA150";
            this.checkEMA150.Size = new System.Drawing.Size(54, 21);
            this.checkEMA150.TabIndex = 33;
            this.checkEMA150.Text = "150";
            this.checkEMA150.UseVisualStyleBackColor = true;
            this.checkEMA150.CheckedChanged += new System.EventHandler(this.checkEMA150_CheckedChanged);
            // 
            // checkEMA200
            // 
            this.checkEMA200.AutoSize = true;
            this.checkEMA200.Location = new System.Drawing.Point(320, 3);
            this.checkEMA200.Name = "checkEMA200";
            this.checkEMA200.Size = new System.Drawing.Size(54, 21);
            this.checkEMA200.TabIndex = 34;
            this.checkEMA200.Text = "200";
            this.checkEMA200.UseVisualStyleBackColor = true;
            this.checkEMA200.CheckedChanged += new System.EventHandler(this.checkEMA200_CheckedChanged);
            // 
            // labelCurrentPrice
            // 
            this.labelCurrentPrice.AutoSize = true;
            this.labelCurrentPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentPrice.Location = new System.Drawing.Point(552, 7);
            this.labelCurrentPrice.Name = "labelCurrentPrice";
            this.labelCurrentPrice.Size = new System.Drawing.Size(34, 20);
            this.labelCurrentPrice.TabIndex = 35;
            this.labelCurrentPrice.Text = "0.0";
            // 
            // checkDraw
            // 
            this.checkDraw.AutoSize = true;
            this.checkDraw.Location = new System.Drawing.Point(488, 3);
            this.checkDraw.Name = "checkDraw";
            this.checkDraw.Size = new System.Drawing.Size(62, 21);
            this.checkDraw.TabIndex = 36;
            this.checkDraw.Text = "Draw";
            this.checkDraw.UseVisualStyleBackColor = true;
            this.checkDraw.CheckedChanged += new System.EventHandler(this.checkDraw_CheckedChanged);
            // 
            // checkVolumeOnOff
            // 
            this.checkVolumeOnOff.AutoSize = true;
            this.checkVolumeOnOff.Location = new System.Drawing.Point(437, 3);
            this.checkVolumeOnOff.Name = "checkVolumeOnOff";
            this.checkVolumeOnOff.Size = new System.Drawing.Size(50, 21);
            this.checkVolumeOnOff.TabIndex = 38;
            this.checkVolumeOnOff.Text = "Vol";
            this.checkVolumeOnOff.UseVisualStyleBackColor = true;
            this.checkVolumeOnOff.CheckedChanged += new System.EventHandler(this.checkVolumeOnOff_CheckedChanged);
            // 
            // checkTops
            // 
            this.checkTops.AutoSize = true;
            this.checkTops.Location = new System.Drawing.Point(369, 3);
            this.checkTops.Name = "checkTops";
            this.checkTops.Size = new System.Drawing.Size(62, 21);
            this.checkTops.TabIndex = 39;
            this.checkTops.Text = "Tops";
            this.checkTops.UseVisualStyleBackColor = true;
            this.checkTops.CheckedChanged += new System.EventHandler(this.checkTops_CheckedChanged);
            // 
            // checkDrawReferenceLine
            // 
            this.checkDrawReferenceLine.AutoSize = true;
            this.checkDrawReferenceLine.Location = new System.Drawing.Point(10, 31);
            this.checkDrawReferenceLine.Name = "checkDrawReferenceLine";
            this.checkDrawReferenceLine.Size = new System.Drawing.Size(52, 21);
            this.checkDrawReferenceLine.TabIndex = 40;
            this.checkDrawReferenceLine.Text = "Ref";
            this.checkDrawReferenceLine.UseVisualStyleBackColor = true;
            this.checkDrawReferenceLine.CheckedChanged += new System.EventHandler(this.checkDrawReferenceLine_CheckedChanged);
            // 
            // toolStripMenuClosingBell
            // 
            this.toolStripMenuClosingBell.Name = "toolStripMenuClosingBell";
            this.toolStripMenuClosingBell.Size = new System.Drawing.Size(206, 24);
            this.toolStripMenuClosingBell.Text = "Closing Bell";
            this.toolStripMenuClosingBell.Click += new System.EventHandler(this.toolStripMenuClosingBell_Click);
            // 
            // DataChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkDrawReferenceLine);
            this.Controls.Add(this.checkTops);
            this.Controls.Add(this.checkVolumeOnOff);
            this.Controls.Add(this.checkDraw);
            this.Controls.Add(this.labelCurrentPrice);
            this.Controls.Add(this.checkEMA200);
            this.Controls.Add(this.checkEMA150);
            this.Controls.Add(this.checkEMA100);
            this.Controls.Add(this.checkEMA50);
            this.Controls.Add(this.checkEMA30);
            this.Controls.Add(this.checkEMA21);
            this.Controls.Add(this.checkEMA10);
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
            this.Size = new System.Drawing.Size(622, 331);
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
        private System.Windows.Forms.CheckBox checkEMA10;
        private System.Windows.Forms.CheckBox checkEMA21;
        private System.Windows.Forms.CheckBox checkEMA30;
        private System.Windows.Forms.CheckBox checkEMA50;
        private System.Windows.Forms.CheckBox checkEMA100;
        private System.Windows.Forms.CheckBox checkEMA150;
        private System.Windows.Forms.CheckBox checkEMA200;
        private System.Windows.Forms.Label labelCurrentPrice;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItemEconomicCalendar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDailyBattlePlan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemScopeNext;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemScopePrevious;
        private System.Windows.Forms.CheckBox checkDraw;
        private System.Windows.Forms.CheckBox checkVolumeOnOff;
        private System.Windows.Forms.CheckBox checkTops;
        private System.Windows.Forms.CheckBox checkDrawReferenceLine;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExclude;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCleanDataPoints;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuClosingBell;
    }
}
