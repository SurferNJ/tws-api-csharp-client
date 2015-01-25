using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.Specialized;
using IBSampleApp.types;
using IBSampleApp.util;


namespace CSharpClientApp.usercontrols
{
    public partial class DataChart : UserControl
    {
        public event System.Windows.Forms.MouseEventHandler DataChartDoubleClick;

        public event System.Windows.Forms.MouseEventHandler DataChartMouseMove;

        public event EventHandler<ChangeScopeEventArgs> ScopeChange;

        // DataChart user control communicates with OrderFormBuy and OrderFormSell controls. They need to be assigned by parent control.
        public  CSharpClientApp.usercontrols.OrderForm OrderFormBuy { get; set; } 
        public CSharpClientApp.usercontrols.OrderForm OrderFormSell { get; set; }

        public double XValue { get; set; }
        public double YValue { get; set; }

        public int BarSizeInSeconds { get; set; }

        public DateTime ChartEndDate { get; set; }

        public double KeepZoomStartDate;
        public double KeepZoomFinishDate;
        public double KeepZoomMinY;
        public double KeepZoomMaxY;
        public bool KeepXZoom = false;
        public bool KeepYZoom = false;

        private bool MouseDownDrawing = false;
        private double MouseDownDrawingStartX;
        private double MouseDownDrawingStartY;
        private LineAnnotation MouseDownLineAnnotation;
        private TextAnnotation MouseDownTextAnnotation;

        private const int MouseDownTextAnnotationOffset = -10;

        private List<IIndicator> chartIndicators = new List<IIndicator>();
                        
        // DataChart user control communicates with PriceLineManager to create/change/remove price lines
        private CSharpClientApp.ui.PriceLineManager _priceLineManager;

        [Browsable(false)]
        public CSharpClientApp.ui.PriceLineManager PriceLineManager
        {
            get { return _priceLineManager; }  
            set {
                    _priceLineManager = value;
                    _priceLineManager.PriceLines.CollectionChanged 
                    += new NotifyCollectionChangedEventHandler(PriceLineManager_CollectionChanged);
            } 
        }

        [Browsable(false)]
        public string XLabelFormat { get; set; }

        [Browsable(false)]
        public string XLabelText { get { return lblX.Text; } }

        [Browsable(false)]
        public Label CurrentPriceLabel
        {
            get { return labelCurrentPrice; }            
        }

        public Chart Chart { get { return this.historicalChart; } }

        public DataChart()
        {
            InitializeComponent();

            _priceLineManager = new CSharpClientApp.ui.PriceLineManager();

            // move x scroll bar outside
            this.historicalChart.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
            
            
            // disable y scroll bar
            this.historicalChart.ChartAreas[0].AxisY.ScrollBar.Enabled = false;
            
            // avoid grid stuttering
            this.historicalChart.ChartAreas[0].AxisX.LabelStyle.IsEndLabelVisible = false; 
            this.historicalChart.ChartAreas[0].AxisY.LabelStyle.IsEndLabelVisible = false;  
          
            // remove grid lines
            this.historicalChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            // enable chart selections by user
            this.historicalChart.ChartAreas[0].CursorX.IsUserEnabled = true;
            this.historicalChart.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            this.historicalChart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;

            // format X labels
            this.Chart.ChartAreas[0].AxisX.IsLabelAutoFit = true;
            this.Chart.ChartAreas[0].AxisX.LabelAutoFitStyle = LabelAutoFitStyles.DecreaseFont;

            // format Y labels
            this.Chart.ChartAreas[0].AxisY.IsLabelAutoFit = true;
            this.Chart.ChartAreas[0].AxisY.LabelAutoFitStyle = LabelAutoFitStyles.None;
            this.Chart.ChartAreas[0].AxisY.LabelStyle.Format = "0.000";

            // background color
            this.Chart.ChartAreas[0].BackColor = Color.Black;
            this.historicalChart.ChartAreas[0].AxisX.ScrollBar.ButtonColor = Color.Gray;

            
            this.Chart.ChartAreas[0].AxisY.IsMarginVisible = true;
            this.Chart.ChartAreas[0].AxisX.IsMarginVisible = true;


            // cursor settings
            this.Chart.ChartAreas[0].CursorX.LineWidth = 2;
            this.Chart.ChartAreas[0].CursorY.LineWidth = 2;

            this.Chart.ChartAreas[0].CursorX.LineColor = Color.FromArgb(120, Color.WhiteSmoke);
            this.Chart.ChartAreas[0].CursorY.LineColor = Color.FromArgb(120, Color.WhiteSmoke);

            // setting tooltip
            //this.Chart.Series[0].ToolTip = "Data Value: #VALY{C0}";

            // volume chart settings   
            this.historicalChart.ChartAreas[1].AxisY.Enabled = AxisEnabled.False;          

            this.Chart.ChartAreas[1].AxisX.IsLabelAutoFit = true;
            this.Chart.ChartAreas[1].AxisX.LabelAutoFitStyle = LabelAutoFitStyles.DecreaseFont;

            this.historicalChart.ChartAreas[1].AxisX.LabelStyle.IsEndLabelVisible = false;
            this.historicalChart.ChartAreas[1].AxisY.LabelStyle.IsEndLabelVisible = false;

            this.historicalChart.ChartAreas[1].CursorX.SelectionColor = Color.Transparent;
            this.historicalChart.ChartAreas[1].CursorX.LineColor = Color.Transparent;
            this.historicalChart.ChartAreas[1].CursorY.LineColor = Color.Transparent;
                        
            // make volume semi-transparent
            this.historicalChart.Series[1].Color = Color.FromArgb(100, Color.LightGoldenrodYellow);

            this.historicalChart.ChartAreas[1].Visible = false;

            // setting volume tooltip
            this.Chart.Series[1].ToolTip = "Vol: #VALY{N0}";
        }

        private void historicalChart_MouseEnter(object sender, EventArgs e)
        {
            this.historicalChart.Focus();
        }

        private void historicalChart_MouseLeave(object sender, EventArgs e)
        {
            this.historicalChart.Parent.Focus();
        }



        private void historicalChart_MouseWheel(object sender, MouseEventArgs e)
        {
            try
            {
                if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
                {
                    // Zoom In
                    if (e.Delta > 0)
                    {
                        double xMin = historicalChart.ChartAreas[0].AxisX.ScaleView.ViewMinimum;
                        double xMax = historicalChart.ChartAreas[0].AxisX.ScaleView.ViewMaximum;

                        var posXStart = historicalChart.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 4;
                        var posXFinish = historicalChart.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 4;

                        historicalChart.ChartAreas[0].AxisX.ScaleView.Zoom(posXStart, posXFinish);
                    }
                    else
                    {
                        // Zoom Out
                        double xMin = historicalChart.ChartAreas[0].AxisX.ScaleView.ViewMinimum;
                        double xMax = historicalChart.ChartAreas[0].AxisX.ScaleView.ViewMaximum;

                        var posXStart = xMin - (xMax - xMin) / 4;
                        var posXFinish = xMax + (xMax - xMin) / 4;

                        historicalChart.ChartAreas[0].AxisX.ScaleView.Zoom(posXStart, posXFinish);
                        //historicalChart.ChartAreas[0].AxisX.ScaleView.Zoom(posXStart, posXFinish, DateTimeIntervalType.Auto, true);
                    }
                }
                else
                {
                    // Scrolling
                    double xMin = historicalChart.ChartAreas[0].AxisX.ScaleView.ViewMinimum;

                    var offset = e.Delta > 0 ? 0 : 2;

                    double posXStart = xMin + offset;

                    historicalChart.ChartAreas[0].AxisX.ScaleView.Scroll(posXStart);

                    historicalChart.ChartAreas[1].AxisX.ScaleView.Scroll(posXStart);

                }

                ScaleYAxis();
            }
            catch { }
        }

        public void AddHorizontalLineAnnotation(PriceLineType type, double price)
        {
            var a = new HorizontalLineAnnotation()
            {
                Name = Enum.GetName(typeof(PriceLineType), type),
                AxisX = historicalChart.ChartAreas[0].AxisX,
                AxisY = historicalChart.ChartAreas[0].AxisY,
                AnchorY = price,
                X = 0,
                Width = historicalChart.ChartAreas[0].AxisX.Maximum,
                IsSizeAlwaysRelative = false,
                IsInfinitive = true,
                ClipToChartArea = historicalChart.ChartAreas[0].Name,
                LineColor = GetAnnotationColor(type),
                LineWidth = 3,
                AllowSelecting = true,
                AllowMoving = true
            };

            historicalChart.Annotations.Add(a);
        }

        public void AddHorizontalLineAnnotation(PriceLineType type, double price, double start, double? end)
        {
            var a = new HorizontalLineAnnotation()
            {
                Name = String.Concat(Enum.GetName(typeof(PriceLineType), type), "_", start.ToString()),
                AxisX = historicalChart.ChartAreas[0].AxisX,
                AxisY = historicalChart.ChartAreas[0].AxisY,
                AnchorY = price,
                X = start,
                //Width = historicalChart.ChartAreas[0].AxisX.Maximum,
                //IsInfinitive = true,
                IsSizeAlwaysRelative = false,
                ClipToChartArea = historicalChart.ChartAreas[0].Name,
                LineColor = GetAnnotationColor(type),
                LineWidth = 3,
                AllowSelecting = true,
                AllowMoving = false                
            };

            if (end != null)
            {
                a.Width = end.Value - start;
            }
            else
            {
                a.Width = historicalChart.ChartAreas[0].AxisX.Maximum - start;
                a.IsSizeAlwaysRelative = true;
            }

            historicalChart.Annotations.Add(a);
        }

        public void AddVerticalLineAnnotation(PriceLineType type, double position)
        {
            var a = new VerticalLineAnnotation()
            {
                Name = String.Concat(Enum.GetName(typeof(PriceLineType), type),"_",position.ToString()),
                AxisX = historicalChart.ChartAreas[0].AxisX,
                AxisY = historicalChart.ChartAreas[0].AxisY,
                AnchorX = position,                
                Width = 0, //historicalChart.ChartAreas[0].AxisY.Maximum,
                IsSizeAlwaysRelative = false,
                IsInfinitive = true,
                ClipToChartArea = historicalChart.ChartAreas[0].Name,
                LineColor = GetAnnotationColor(type),
                LineWidth = 3,
                AllowSelecting = true,
                AllowMoving = false
            };

            historicalChart.Annotations.Add(a);
        }

        public void AddTwoHalfVerticalAnnotaion(PriceLineType type, int position)
        {
            var upperHalf = new VerticalLineAnnotation()
            {
                Name = String.Concat(Enum.GetName(typeof(PriceLineType), type), "_UPPERHALF_", position.ToString()),
                AxisX = historicalChart.ChartAreas[0].AxisX,
                AxisY = historicalChart.ChartAreas[0].AxisY,
                AnchorX = position + 1,
                AnchorY = historicalChart.Series[0].Points[position].YValues[0] * 1.001,
                Height = historicalChart.ChartAreas[0].AxisY.Maximum -  historicalChart.Series[0].Points[position].YValues[0] ,
                Width = 0, 
                IsSizeAlwaysRelative = false,
                ClipToChartArea = historicalChart.ChartAreas[0].Name,
                LineColor = GetAnnotationColor(type),
                LineWidth = 3,
                AllowSelecting = true,
                AllowMoving = false
            };

            var lowerHalf = new VerticalLineAnnotation()
            {
                Name = String.Concat(Enum.GetName(typeof(PriceLineType), type), "_LOWERHALF_", position.ToString()),
                AxisX = historicalChart.ChartAreas[0].AxisX,
                AxisY = historicalChart.ChartAreas[0].AxisY,
                AnchorX = position + 1,
                AnchorY = historicalChart.Series[0].Points[position].YValues[1] * 0.999,
                Height = -1 * (historicalChart.Series[0].Points[position].YValues[1] - historicalChart.ChartAreas[0].AxisY.Minimum),
                Width = 0,
                IsSizeAlwaysRelative = false,
                ClipToChartArea = historicalChart.ChartAreas[0].Name,
                LineColor = GetAnnotationColor(type),
                LineWidth = 3,
                AllowSelecting = true,
                AllowMoving = false
            };
                        
            historicalChart.Annotations.Add(upperHalf);
            historicalChart.Annotations.Add(lowerHalf);
        }

        public void RemoveAnnotation(PriceLineType type)
        {
            var name = Enum.GetName(typeof(PriceLineType), type);
            var annotations = historicalChart.Annotations.Where(x => x.Name.StartsWith(name)).ToList();

            //if (annotations.Any())
                foreach(var annotation in annotations)
                    historicalChart.Annotations.Remove(annotation);
        }

        private void SetBuyLMTOrder(double price)
        {
            var priceLine = new CSharpClientApp.ui.PriceLine()
            {
                Type = PriceLineType.BUY_LINE,
                Price = price
            };

            PriceLineManager.Add(priceLine);

            OrderFormBuy.SetTriggerPrice(OrderType.BUY_LMT, price);

            //TODO: implement buy order
        }

        private void PriceLineManager_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.OldItems != null)
            {
                foreach (var item in e.OldItems)
                {
                    var priceLine = (CSharpClientApp.ui.PriceLine)item;
                    var name = Enum.GetName(typeof(PriceLineType), priceLine.Type);
                    var existingAnnotation = historicalChart.Annotations.Where(x => x.Name.StartsWith(name)
                                                                                && x.AnchorY == priceLine.Price).FirstOrDefault();

                    if (existingAnnotation != null)
                        historicalChart.Annotations.Remove(existingAnnotation);
                }
            }

            if (e.NewItems != null)
            {
                foreach (var item in e.NewItems)
                {
                    var priceLine = (CSharpClientApp.ui.PriceLine)item;
                    AddHorizontalLineAnnotation(priceLine.Type, priceLine.Price);
                }
            }
        } 

        private Color GetAnnotationColor(PriceLineType lineType)
        {
            var result = Color.Yellow;

            switch (lineType)
            {
                case PriceLineType.BUY_LINE:
                case PriceLineType.BUY_LMT_LINE:
                    result = Color.Green;
                    break;
                case PriceLineType.SELL_LINE:
                case PriceLineType.SELL_LMT_LINE:
                    result = Color.Red;
                    break;
                case PriceLineType.OPEN_LINE:
                    result = Color.FromArgb(200, Color.LightGreen);
                    break;
                case PriceLineType.LOW_LINE:
                    result = Color.FromArgb(200, Color.Red);
                    break;
                case PriceLineType.HIGH_LINE:
                    result = Color.FromArgb(220, Color.WhiteSmoke);
                    break;
                case PriceLineType.DAILY_MARKER:                    
                    result = Color.WhiteSmoke;
                    break;
                case PriceLineType.DAILY_MARKER_1M:
                    result = Color.FromArgb(120, Color.WhiteSmoke);
                    break;
                case PriceLineType.PERCENTAGE_LINE:
                    result = Color.WhiteSmoke;
                    break;
                default:
                    result = Color.Red;
                    break;
            }

            return result;
        }
        
        private void SetSellLMTOrder(double price)
        {
            var priceLine = new CSharpClientApp.ui.PriceLine()
            {
                Type = PriceLineType.SELL_LINE,
                Price = price
            };

            // Add price line annotation to all charts
            PriceLineManager.Add(priceLine);

            //TODO: implement sell order
        }


        private void historicalChart_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (checkDraw.Checked)
            {
                if (MouseDownDrawing == false)
                {
                    // start drawing
                    MouseDownDrawing = true;

                    // disable chart selections by user
                    //this.historicalChart.ChartAreas[0].CursorX.IsUserEnabled = true;
                    //this.historicalChart.ChartAreas[0].CursorX.IsUserSelectionEnabled = false;
                    //this.historicalChart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;

                    Point mousePoint = new Point(e.X, e.Y);

                    double x = historicalChart.ChartAreas[0].AxisX.PixelPositionToValue(e.X);

                    double y = historicalChart.ChartAreas[0].AxisY.PixelPositionToValue(e.Y);

                    MouseDownDrawingStartX = e.X;
                    MouseDownDrawingStartY = e.Y;

                    MouseDownLineAnnotation = new LineAnnotation();
                    MouseDownLineAnnotation.Name = String.Concat(Enum.GetName(typeof(PriceLineType), PriceLineType.PERCENTAGE_LINE), "_", e.X.ToString(), "_", e.Y.ToString());
                    MouseDownLineAnnotation.AxisX = historicalChart.ChartAreas[0].AxisX;
                    MouseDownLineAnnotation.AxisY = historicalChart.ChartAreas[0].AxisY;
                    MouseDownLineAnnotation.AnchorX = x;
                    MouseDownLineAnnotation.AnchorY = y;
                    MouseDownLineAnnotation.IsSizeAlwaysRelative = false;
                    MouseDownLineAnnotation.AllowResizing = false;
                    MouseDownLineAnnotation.AllowMoving = false;
                    MouseDownLineAnnotation.LineColor = GetAnnotationColor(PriceLineType.PERCENTAGE_LINE);
                    MouseDownLineAnnotation.LineWidth = 2;
                    MouseDownLineAnnotation.AllowSelecting = false;
                    MouseDownLineAnnotation.AllowMoving = false;
                    this.Chart.Annotations.Add(MouseDownLineAnnotation);

                    MouseDownTextAnnotation = new TextAnnotation();
                    MouseDownTextAnnotation.Name = String.Concat(Enum.GetName(typeof(PriceLineType), PriceLineType.PERCENTAGE_LINE_TEXT), "_", e.X.ToString(), "_", e.Y.ToString());
                    MouseDownTextAnnotation.AxisX = historicalChart.ChartAreas[0].AxisX;
                    MouseDownTextAnnotation.AxisY = historicalChart.ChartAreas[0].AxisY;
                    MouseDownTextAnnotation.AnchorX = x - GetTextOffsetX();  //+ MouseDownTextAnnotationOffset;
                    MouseDownTextAnnotation.AnchorY = y;
                    MouseDownTextAnnotation.IsSizeAlwaysRelative = true;
                    MouseDownTextAnnotation.AllowResizing = false;
                    MouseDownTextAnnotation.AllowMoving = false;
                    MouseDownTextAnnotation.AllowSelecting = false;
                    MouseDownTextAnnotation.AllowMoving = false;
                    MouseDownTextAnnotation.ForeColor = GetAnnotationColor(PriceLineType.PERCENTAGE_LINE);
                    MouseDownTextAnnotation.Width = 20;
                    MouseDownTextAnnotation.Height = -6;

                    MouseDownTextAnnotation.Text = "12%";
                    MouseDownTextAnnotation.IsMultiline = false;

                    // add the annotation to the chart annotations list
                    this.Chart.Annotations.Add(MouseDownTextAnnotation);


                    //historicalChart.ChartAreas[0].CursorX.SetCursorPixelPosition(mousePoint, true);
                    //historicalChart.ChartAreas[0].CursorY.SetCursorPixelPosition(mousePoint, true);

                }
                else
                {
                    // stop drawing
                    MouseDownDrawing = false;

                    //// enable chart selections by user
                    //this.historicalChart.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
                }


            }
        }

        private void historicalChart_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                Point mousePoint = new Point(e.X, e.Y);

                historicalChart.ChartAreas[0].CursorX.Interval = 0;
                historicalChart.ChartAreas[0].CursorY.Interval = 0;

                historicalChart.ChartAreas[0].CursorX.SetCursorPixelPosition(mousePoint, true);
                historicalChart.ChartAreas[0].CursorY.SetCursorPixelPosition(mousePoint, true);

                double x = historicalChart.ChartAreas[0].AxisX.PixelPositionToValue(e.X);
                double y = historicalChart.ChartAreas[0].AxisY.PixelPositionToValue(e.Y);

                int xValue = Convert.ToInt32(x) - 1;
                var xPoint = (xValue > -1) ? historicalChart.Series[0].Points[xValue] : null;

                var yValue = y;                

                UpdateControls(xPoint, yValue);

                if (MouseDownDrawing)
                {
                    MouseDownLineAnnotation.Width = x - MouseDownLineAnnotation.AnchorX;
                    MouseDownLineAnnotation.Height = y - MouseDownLineAnnotation.AnchorY;                                        
                    MouseDownTextAnnotation.AnchorX = x - GetTextOffsetX(); //+ MouseDownTextAnnotationOffset;
                    MouseDownTextAnnotation.AnchorY = y;
                    double percentage = y / MouseDownLineAnnotation.AnchorY - 1;
                    MouseDownTextAnnotation.Text = percentage.ToString("0.00%");

                    
                                                                                
                }

                // notify listeners, so all charts can stay in sync
                var newEvent = DataChartMouseMove;
                newEvent(this, e);
            }
            catch { } // do nothing as exceptions can occur during graph resizing            
        }

        private double GetTextOffsetX()
        {
            var offsetX = 5 * (this.historicalChart.ChartAreas[0].AxisX.ScaleView.ViewMaximum - this.historicalChart.ChartAreas[0].AxisX.ScaleView.ViewMinimum) / 100;
            return offsetX;
        }

        private void historicalChart_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {            
            //// stop drawing
            //MouseDownDrawing = false;

            //// enable chart selections by user
            //this.historicalChart.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
        }



        private void contextMenuItemBuyLMT_Click(object sender, EventArgs e)
        {
            SetBuyLMTOrder(YValue);
        }

        private void contextMenuItemSellLMT_Click(object sender, EventArgs e)
        {
            SetSellLMTOrder(YValue);
        }

        private void historicalChart_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var newEvent = DataChartDoubleClick;

            if (newEvent != null)
                newEvent(this, e);
        }


        internal void UpdateControls(DataPoint xPoint, double yValue)
        {
            //HitTestResult result = historicalChart.HitTest(e.X, e.Y);
            YValue = yValue;
            lblY.Text = YValue.ToString("0.000");

            if (xPoint != null)
            {
                XValue = xPoint.XValue;
                lblX.Text = System.DateTime.FromOADate(XValue).ToString(XLabelFormat);
                lblHigh.Text = xPoint.YValues[0].ToString("0.000");
                lblLow.Text = xPoint.YValues[1].ToString("0.000");
                lblOpen.Text = xPoint.YValues[2].ToString("0.000");
                lblClose.Text = xPoint.YValues[3].ToString("0.000");
            }
            else
            {
                XValue = -1;
                lblX.Text = String.Empty;
                lblHigh.Text = String.Empty;
                lblLow.Text = String.Empty;
                lblOpen.Text = String.Empty;
                lblClose.Text = String.Empty;
            }
        }

        public void CreateIndicators()
        {
            foreach (var indicator in chartIndicators)
            {
                indicator.Create();
            }
        }

        public void UpdateIndicators()
        {
            foreach (var indicator in chartIndicators)
            {
                indicator.Update(); 
            }

            //UpdateEMA(IndicatorType.EMA10, checkEMA10.Checked);
            //UpdateEMA(IndicatorType.EMA21, checkEMA21.Checked);
            //UpdateEMA(IndicatorType.EMA30, checkEMA30.Checked);
            //UpdateEMA(IndicatorType.EMA50, checkEMA50.Checked);
            //UpdateEMA(IndicatorType.EMA100, checkEMA100.Checked);
            //UpdateEMA(IndicatorType.EMA150, checkEMA150.Checked);
            //UpdateEMA(IndicatorType.EMA200, checkEMA200.Checked);
        }

        private void UpdateEMA(IndicatorType type, bool enable)
        {
            if (enable)
                AddIndicatorEMA(type);
            else
                RemoveIndicatorEMA(type);
        }
        
        private void checkEMA10_CheckedChanged(object sender, EventArgs e)
        {
            UpdateEMA(IndicatorType.EMA10, checkEMA10.Checked);
        }

        private void AddIndicatorEMA(IndicatorType ema)
        {
            try
            {
                var indicator = new IndicatorEMA(this.Chart, ema);
                
                indicator.ToolTip = String.Concat(indicator.Name, ": #VALY{C0}");

                indicator.Create();

                chartIndicators.Add(indicator);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
        }

        private void RemoveIndicatorEMA(IndicatorType ema)
        {
            var indicator = chartIndicators.Where(x => x.Type == ema).FirstOrDefault();

            if (indicator != null)
            {
                indicator.Clear();
                chartIndicators.Remove(indicator);
            }
        }

        private void checkEMA21_CheckedChanged(object sender, EventArgs e)
        {
            UpdateEMA(IndicatorType.EMA21, checkEMA21.Checked);
        }

        private void checkEMA30_CheckedChanged(object sender, EventArgs e)
        {
            UpdateEMA(IndicatorType.EMA30, checkEMA30.Checked);
        }

        private void checkEMA50_CheckedChanged(object sender, EventArgs e)
        {
            UpdateEMA(IndicatorType.EMA50, checkEMA50.Checked);
        }

        private void checkEMA100_CheckedChanged(object sender, EventArgs e)
        {
            UpdateEMA(IndicatorType.EMA100, checkEMA100.Checked);
        }

        private void checkEMA150_CheckedChanged(object sender, EventArgs e)
        {
            UpdateEMA(IndicatorType.EMA150, checkEMA150.Checked);
        }

        private void checkEMA200_CheckedChanged(object sender, EventArgs e)
        {
            UpdateEMA(IndicatorType.EMA200, checkEMA200.Checked);
        }

        private void historicalChart_AxisViewChanged(object sender, ViewEventArgs e)
        {
            if (e.Axis.AxisName == AxisName.X)
            {
                ScaleYAxis();
            }
        }

        private void ScaleYAxis()
        {
            int start = (int)this.Chart.ChartAreas[0].AxisX.ScaleView.ViewMinimum;
            int end = (int)this.Chart.ChartAreas[0].AxisX.ScaleView.ViewMaximum;
                        
            double[] highs = this.Chart.Series[0].Points.Where((x, i) => i >= start && i <= end).Select(x => x.YValues[0]).ToArray();
            double[] lows = this.Chart.Series[0].Points.Where((x, i) => i >= start && i <= end).Select(x => x.YValues[1]).ToArray();

            if (highs.Length > 0)
            {
                double ymax = highs.Max();
                double ymin = lows.Min();

                var margin = (ymax - ymin) / 10;

                this.Chart.ChartAreas[0].AxisY.ScaleView.Position = ymin - margin;
                this.Chart.ChartAreas[0].AxisY.ScaleView.Size = ymax - ymin + margin * 2;
            }

        }

        private void contextMenuItemEconomicCalendar_Click(object sender, EventArgs e)
        {
            DateTime date;

            var dateText = this.XLabelText;

            if (DateTime.TryParse(dateText, out date))
            {
                IBSampleApp.util.UrlLauncher.EconomicCalendarShow(date);
            }
        }

        private void toolStripMenuItemDailyBattlePlan_Click(object sender, EventArgs e)
        {
            DateTime date;

            var dateText = this.XLabelText;

            if (DateTime.TryParse(dateText, out date))
            {
                IBSampleApp.util.UrlLauncher.DailyBattlePlanShow(date);
            }
        }

        private void toolStripMenuItemScopeNext_Click(object sender, EventArgs e)
        {
            // check if any subscibers raise event
            if (ScopeChange != null)
            {
                var args = new ChangeScopeEventArgs() { delta = 1 };
                ScopeChange(this, args);
            }   
        }

        private void toolStripMenuItemScopePrevious_Click(object sender, EventArgs e)
        {
            // check if any subscibers raise event
            if (ScopeChange != null)
            {
                var args = new ChangeScopeEventArgs() { delta = -1 };
                ScopeChange(this, args);
             }            
        }

        private void checkDraw_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDraw.Checked)
                // disable chart selections by user
                this.historicalChart.ChartAreas[0].CursorX.IsUserSelectionEnabled = false;
            else
                // enable chart selections by user
                this.historicalChart.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;

            this.RemoveAnnotation(PriceLineType.PERCENTAGE_LINE);
        }



        private void checkVolumeOnOff_CheckedChanged(object sender, EventArgs e)
        {
            if (checkVolumeOnOff.Checked)
            {
                // make sure Volume ScaleView is same as Chart ScaleView
                if (!Double.IsNaN(historicalChart.ChartAreas[0].AxisX.ScaleView.Size))
                    this.historicalChart.ChartAreas[1].AxisX.ScaleView = historicalChart.ChartAreas[0].AxisX.ScaleView;

                this.historicalChart.ChartAreas[1].Visible = true;               
            }

            this.historicalChart.ChartAreas[1].Visible = checkVolumeOnOff.Checked; 
        }

        private void checkTops_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopBottom(checkTops.Checked);
        }

        private void UpdateTopBottom(bool enable)
        {
            if (enable)
                AddIndicatorTopBottom();
            else
                RemoveIndicatorTopBottom();
        }

        private void AddIndicatorTopBottom()
        {
            try
            {
                var indicator = new IndicatorTopBottom(this.Chart, 2);

                indicator.Create();

                chartIndicators.Add(indicator);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RemoveIndicatorTopBottom()
        {
            var indicator = chartIndicators.Where(x => x.Type == IndicatorType.TopBottom).FirstOrDefault();

            if (indicator != null)
            {
                indicator.Clear();
                chartIndicators.Remove(indicator);
            }
        }
    }
}
