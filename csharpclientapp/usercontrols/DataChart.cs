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

        // DataChart user control communicates with OrderFormBuy and OrderFormSell controls. They need to be assigned by parent control.
        public  CSharpClientApp.usercontrols.OrderForm OrderFormBuy { get; set; } 
        public CSharpClientApp.usercontrols.OrderForm OrderFormSell { get; set; }

        

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

        public Chart Chart { get { return this.historicalChart; } } 

        public DataChart()
        {
            InitializeComponent();

            _priceLineManager = new CSharpClientApp.ui.PriceLineManager();
            
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

            PriceLineManager.Add(priceLine);

            //OrderFormSell.SetTriggerPrice(OrderType.SELL_LMT, price);

            //AddHorizontalLineAnnotation(CSharpClientApp.ui.PriceLineManager.SELL_LINE_NAME, price, Color.Red);

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

                int pointX = Convert.ToInt32(historicalChart.ChartAreas[0].AxisX.PixelPositionToValue(e.X)) - 1;

                lblY.Text = historicalChart.ChartAreas[0].AxisY.PixelPositionToValue(e.Y).ToString("0.000");

                HitTestResult result = historicalChart.HitTest(e.X, e.Y);

                if (pointX > -1)
                {
                    lblX.Text = System.DateTime.FromOADate(historicalChart.Series[0].Points[pointX].XValue).ToString("MM/dd/yyyy");
                    lblHigh.Text = historicalChart.Series[0].Points[pointX].YValues[0].ToString("0.000");
                    lblLow.Text = historicalChart.Series[0].Points[pointX].YValues[1].ToString("0.000");
                    lblOpen.Text = historicalChart.Series[0].Points[pointX].YValues[2].ToString("0.000");
                    lblClose.Text = historicalChart.Series[0].Points[pointX].YValues[3].ToString("0.000");
                }
                else
                {
                    lblX.Text = String.Empty;
                    lblHigh.Text = String.Empty;
                    lblLow.Text = String.Empty;
                    lblOpen.Text = String.Empty;
                    lblClose.Text = String.Empty;
                }
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
    }
}
