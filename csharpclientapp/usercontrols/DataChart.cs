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


namespace CSharpClientApp.usercontrols
{
    public partial class DataChart : UserControl
    {
        //const string BUY_LINE_NAME = "BUY_LINE";
        //const string SELL_LINE_NAME = "SELL_LINE";

        public event System.Windows.Forms.MouseEventHandler DataChartDoubleClick;

        public event System.Windows.Forms.MouseEventHandler DataChartMouseMove;

        // DataChart user control communicates with OrderFormBuy and OrderFormSell controls. They need to be assigned by parent control.
        public  CSharpClientApp.usercontrols.OrderForm OrderFormBuy { get; set; } 
        public CSharpClientApp.usercontrols.OrderForm OrderFormSell { get; set; }

        public double XValue { get; set; }
        public double YValue { get; set; }

        public int BarSizeInSeconds { get; set; }

        public DateTime ChartEndDate { get; set; }
                        
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

            
            //this.Chart.ChartAreas[0].AxisY.IsMarginVisible = true;

            //historicalChart.Series[0].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            
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

                        double posXStart = historicalChart.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 4;
                        double posXFinish = historicalChart.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 4;

                        historicalChart.ChartAreas[0].AxisX.ScaleView.Zoom(posXStart, posXFinish);

                        //historicalChart.ChartAreas[0].AxisX.ScaleView.Zoom(posXStart, posXFinish);
                    }
                    else
                    {
                        // Zoom Out
                        double xMin = historicalChart.ChartAreas[0].AxisX.ScaleView.ViewMinimum;
                        double xMax = historicalChart.ChartAreas[0].AxisX.ScaleView.ViewMaximum;

                        double posXStart = xMin - (xMax - xMin) / 4;
                        double posXFinish = xMax + (xMax - xMin) / 4;

                        historicalChart.ChartAreas[0].AxisX.ScaleView.Zoom(posXStart, posXFinish);
                    }
                }
                else
                {
                    // Scrolling
                    double xMin = historicalChart.ChartAreas[0].AxisX.ScaleView.ViewMinimum;

                    var offset = e.Delta > 0 ? 0 : 2;

                    double posXStart = xMin + offset;

                    historicalChart.ChartAreas[0].AxisX.ScaleView.Scroll(posXStart);

                    
                }

                ScaleYAxis();
            }
            catch { }
        }

        private void AddHorizontalLineAnnotation(string name, double price, Color color)
        {
            var a = new HorizontalLineAnnotation()
            {
                Name = name,
                AxisX = historicalChart.ChartAreas[0].AxisX,
                AxisY = historicalChart.ChartAreas[0].AxisY,
                AnchorY = price,
                X = 0,
                Width = historicalChart.ChartAreas[0].AxisX.Maximum,
                IsSizeAlwaysRelative = false,
                IsInfinitive = true,
                ClipToChartArea = historicalChart.ChartAreas[0].Name,
                LineColor = color,
                LineWidth = 3,
                AllowSelecting = true,
                AllowMoving = true
            };

            historicalChart.Annotations.Add(a);
        }

        private void SetBuyLMTOrder(double price)
        {
            var priceLine = new CSharpClientApp.ui.PriceLine()
            {
                Name = CSharpClientApp.ui.PriceLineManager.BUY_LINE_NAME,
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
                    var existingAnnotation = historicalChart.Annotations.Where(x => x.Name.Equals(priceLine.Name)
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
                    AddHorizontalLineAnnotation(priceLine.Name, priceLine.Price, GetAnnotationColor(priceLine.Name));
                }
            }
        } 

        private Color GetAnnotationColor(string lineName)
        {
            var result = Color.Yellow;

            switch (lineName)
            {
                case CSharpClientApp.ui.PriceLineManager.BUY_LINE_NAME:
                case CSharpClientApp.ui.PriceLineManager.BUY_LMT_LINE_NAME:
                    result = Color.Green;
                    break;
                case CSharpClientApp.ui.PriceLineManager.SELL_LINE_NAME:
                case CSharpClientApp.ui.PriceLineManager.SELL_LMT_LINE_NAME:
                    result = Color.Red;
                    break;
            }

            return result;
        }
        
        private void SetSellLMTOrder(double price)
        {
            var priceLine = new CSharpClientApp.ui.PriceLine()
            {
                Name = CSharpClientApp.ui.PriceLineManager.SELL_LINE_NAME,
                Price = price
            };

            // Add price line annotation to all charts
            PriceLineManager.Add(priceLine);

            //TODO: implement sell order
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
                
                int xValue = Convert.ToInt32(historicalChart.ChartAreas[0].AxisX.PixelPositionToValue(e.X)) - 1;
                var xPoint = (xValue > -1) ? historicalChart.Series[0].Points[xValue] : null;

                var yValue = historicalChart.ChartAreas[0].AxisY.PixelPositionToValue(e.Y);                

                UpdateControls(xPoint, yValue);

                // notify listeners, so all charts can stay in sync
                var newEvent = DataChartMouseMove;
                newEvent(this, e);
            }
            catch { } // do nothing as exceptions can occur during graph resizing            
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

        private void checkEMA10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEMA10.Checked)
                checkEMA10.Checked = AddIndicator_EMA(ExpMovAvgType.EMA10);
            else
                RemoveIndicator_EMA(ExpMovAvgType.EMA10);
        }

        private bool AddIndicator_EMA(ExpMovAvgType ema)
        {
            if (this.Chart.Series[0].Points.Count <= 0) return false;

            var seriesName = Enum.GetName(typeof(ExpMovAvgType), ema);

            var series = this.Chart.Series.FindByName(seriesName);

            if (series == null)
            {
                historicalChart.Series.Add(new Series(seriesName));
                series = this.Chart.Series[seriesName];

                series.ChartType = SeriesChartType.Line;
                series.IsVisibleInLegend = false;
                series.Color = Types.EMAColors[ema];
                series.BorderWidth = 2;
                series.IsXValueIndexed = true;
                series.XAxisType = AxisType.Primary;
                series.YAxisType = AxisType.Primary;

            }


            try
            {
                this.Chart.DataManipulator.IsStartFromFirst = true;
                this.Chart.DataManipulator.FinancialFormula(FinancialFormula.ExponentialMovingAverage, Types.GetEMADuration(ema), "Series1:Y2", seriesName);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            return true;

        }

        private void RemoveIndicator_EMA(ExpMovAvgType ema)
        {
            var seriesName = Enum.GetName(typeof(ExpMovAvgType), ema);

            var series = this.Chart.Series.FindByName(seriesName);

            if (series != null)
                series.Points.Clear();
        }

        private void checkEMA21_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEMA21.Checked)
                checkEMA21.Checked = AddIndicator_EMA(ExpMovAvgType.EMA21);
            else
                RemoveIndicator_EMA(ExpMovAvgType.EMA21);
        }

        private void checkEMA30_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEMA30.Checked)
                checkEMA30.Checked = AddIndicator_EMA(ExpMovAvgType.EMA30);
            else
                RemoveIndicator_EMA(ExpMovAvgType.EMA30);
        }

        private void checkEMA50_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEMA50.Checked)
                checkEMA50.Checked = AddIndicator_EMA(ExpMovAvgType.EMA50);
            else
                RemoveIndicator_EMA(ExpMovAvgType.EMA50);
        }

        private void checkEMA100_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEMA100.Checked)
                checkEMA100.Checked = AddIndicator_EMA(ExpMovAvgType.EMA100);
            else
                RemoveIndicator_EMA(ExpMovAvgType.EMA100);
        }

        private void checkEMA150_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEMA150.Checked)
                checkEMA150.Checked = AddIndicator_EMA(ExpMovAvgType.EMA150);
            else
                RemoveIndicator_EMA(ExpMovAvgType.EMA150);
        }

        private void checkEMA200_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEMA200.Checked)
                checkEMA200.Checked = AddIndicator_EMA(ExpMovAvgType.EMA200);
            else
                RemoveIndicator_EMA(ExpMovAvgType.EMA200);
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
    }
}
