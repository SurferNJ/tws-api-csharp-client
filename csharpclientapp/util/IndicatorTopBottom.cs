using IBSampleApp.types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace IBSampleApp.util
{
    public class IndicatorTopBottom : IIndicator
    {
        private Chart chart;

        public string Name { get; set; }

        public int Length { get; set; }

        public IndicatorType Type { get; set; }

        public Series Series { get; set; }

        public string ToolTip { get; set; }

        public List<DataPoint> Tops = new List<DataPoint>();

        public List<DataPoint> Bottoms = new List<DataPoint>();

        public bool BottomSearchActive { get; set; }

        public int LastCheckedIndex { get; set; }

        public DataPoint LastBottom { get; set; }

        public IndicatorTopBottom(Chart chart, int length)
        {
            this.chart = chart;
            this.Type = IndicatorType.TopBottom;
            this.Name = Enum.GetName(typeof(IndicatorType), Type);
            this.Length = length;
            this.ToolTip = String.Empty;

            BottomSearchActive = true;
        }

        public void Create()
        {

            if (chart.Series[0].Points.Count <= 0) return;

            var series = chart.Series.FindByName(Name);

            if (series == null)
            {
                // create new indicator series
                Series = new Series(Name);
                chart.Series.Add(Series);

                Series.ChartType = SeriesChartType.Line;
                Series.IsVisibleInLegend = false;
                Series.Color = Types.IndicatorColors[Type];
                Series.BorderWidth = 2;
                Series.IsXValueIndexed = true;
                Series.XAxisType = AxisType.Primary;
                Series.YAxisType = AxisType.Primary;

                if (ToolTip.Length > 0)
                    Series.ToolTip = ToolTip;

            }

            Series.Points.Clear();
            Bottoms.Clear();

            // prefill Series with empty datapoints 
            for (var i = 0; i < chart.Series[0].Points.Count; i++)
            {
                var emptyDataPoint = new DataPoint()
                    {
                        XValue = chart.Series[0].Points[i].XValue,
                        IsEmpty = true
                    };

                Series.Points.Add(emptyDataPoint);
            }

            LastCheckedIndex = 0;
            LastBottom = chart.Series[0].Points[LastCheckedIndex];

            BottomSearchActive = true;

            // calculate bottoms
            for (var i = 0; i < chart.Series[0].Points.Count; i = i + Length)
            {
                CheckNewTopBottom();
            }
        }

        private void CheckNewTopBottom()
        {
            if (LastCheckedIndex + Length > chart.Series[0].Points.Count)
                return;

            var newBottom = GetBottom(LastCheckedIndex + 1);

            if (BottomSearchActive && newBottom.YValues[1] > LastBottom.YValues[1])
            {
                AddNewBottom(LastBottom);
                BottomSearchActive = false;
            }
            //TODO - check for double bottom
            //if (newBottom.YValues[1] >= lastBottom.YValues[1] * (1 - Approximation) && newBottom.YValues[1] >= lastBottom.YValues[1] * (1 + Approximation))
            //{
            //    Bottoms.Add(lastBottom);
            //    BottomSearchActive = false;
            //}
            else if (newBottom.YValues[1] < LastBottom.YValues[1])
            {
                BottomSearchActive = true;
            }

            LastBottom = newBottom;

            LastCheckedIndex += Length;
        }

        private void AddNewBottom(DataPoint bottom)
        {
            Bottoms.Add(bottom);

            // replace empty point in Series
            var point = Series.Points.Where(x => x.XValue == bottom.XValue).First();

            point.YValues[0] = LastBottom.YValues[1];
            point.MarkerStyle = MarkerStyle.Circle;
            point.IsEmpty = false;            
        }

        //private void FillGaps(DataPoint newDataPoint)
        //{
        //    var lastDataPointIndex = Series.Points.Count;
        //    var newDataPointIndex = chart.Series[0].Points.IndexOf(newDataPoint);

        //    for (var i = lastDataPointIndex; i < newDataPointIndex - 1; i++ )
        //    {
        //        var newEmptyDataPoint = new DataPoint()
        //            {
        //                XValue = chart.Series[0].Points[i].XValue,
        //                IsEmpty = true
        //            };

        //        Series.Points.Add(newEmptyDataPoint);
        //    }

        //}

        private DataPoint GetBottom(int index)
        {            
            var bottom = chart.Series[0].Points[index];
            
            for (var i = index+1; i < (index + Length); i++)
            {
                var date = DateTime.FromOADate(chart.Series[0].Points[index].XValue).Date;
                if (i < chart.Series[0].Points.Count)
                {
                    if (chart.Series[0].Points[i].YValues[1] < bottom.YValues[1]) //Compare Lows
                    {
                        bottom = chart.Series[0].Points[i]; 
                    }
                }
            }

            return bottom;
        }

        public void Update()
        {
            // update last bar
            CheckNewTopBottom();
        }

        public void Clear()
        {
            if (Series != null)
            {
                Bottoms.Clear();
                Series.Points.Clear();
                chart.Series.Remove(Series);
            }
        }


        public void AddDataPointEMA(int index)
        {
            //throw new NotImplementedException();
            //double EMAYesterday = Series.Points.Count > 0 ? Series.Points.Last().YValues[0] : 0.0;

            //Series.Points.AddXY(chart.Series[0].Points[index].XValue, FinancialFormulas.CalculateEMA(index, chart.Series[0].Points[index].YValues[3], Length, EMAYesterday));
        }

    }
}
