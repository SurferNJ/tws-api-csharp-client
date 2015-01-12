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

        public Chart Chart { get { return this.historicalChart; } }

        public DataChart()
        {
            InitializeComponent();

            _priceLineManager = new CSharpClientApp.ui.PriceLineManager();

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
            SetBuyLMTOrder(Double.Parse(lblY.Text));
        }

        private void contextMenuItemSellLMT_Click(object sender, EventArgs e)
        {
            SetSellLMTOrder(Double.Parse(lblY.Text));
        }

        private void historicalChart_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var newEvent = DataChartDoubleClick;

            newEvent(this, e);
        }

        // TODO: use this for plotting Technical Indicators 
        //private void DrawPriceLineSeries(double price)
        //{
        //    var seriesLine = new Series(BUY_LINE_SERIES);

        //    foreach (var point in historicalChart.Series[0].Points)
        //    {
        //        seriesLine.Points.AddXY(System.DateTime.FromOADate(point.XValue), price);
        //    }

        //    seriesLine.ChartType = SeriesChartType.Line;
        //    seriesLine.IsVisibleInLegend = false;
        //    seriesLine.Color = Color.Green;
        //    seriesLine.BorderWidth = 3;
        //    seriesLine.IsXValueIndexed = true;
        //    seriesLine.XAxisType = AxisType.Primary;
        //    seriesLine.YAxisType = AxisType.Primary;

        //    historicalChart.Series.Add(seriesLine);    
        //}

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
    }
}
