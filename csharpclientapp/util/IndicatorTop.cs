using IBSampleApp.types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace IBSampleApp.util
{
    public class IndicatorTop : IIndicator
    {
        private Chart chart;

        public string Name { get; set; }

        public int Length { get; set; }

        public IndicatorType Type { get; set; }

        public Series Series { get; set; }

        public string ToolTip { get; set; }

        public List<DataPoint> Tops = new List<DataPoint>();

        public bool SearchActive { get; set; }

        public int LastCheckedIndex { get; set; }

        public DataPoint LastTop { get; set; }

        private int priceType { get; set; }

        public double ApproximationRange = 0.0001;

        public IndicatorTop(Chart chart, int length, PriceType priceType = PriceType.High)
        {
            this.chart = chart;
            this.Type = IndicatorType.Tops;
            this.Name = Enum.GetName(typeof(IndicatorType), Type);
            this.Length = length;
            this.ToolTip = String.Empty;
            this.priceType = (int)priceType;

            SearchActive = true;
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
            Tops.Clear();

            LastCheckedIndex = 0;
            LastTop = chart.Series[0].Points[LastCheckedIndex];

            SearchActive = true;

            // calculate tops
            for (var i = 0; i < chart.Series[0].Points.Count; i++)
            {
                AddDataPoint(i);
            }
        }

        private void AddDataPoint(int index)
        {
            AddEmptyDataPoint(index);

            if (index < LastCheckedIndex + Length)
                return;

            var newTop = GetTop(LastCheckedIndex + 1);

            if (SearchActive && newTop.YValues[priceType] < LastTop.YValues[priceType])
            {
                AddNewTop(LastTop);
                SearchActive = false;
            }
            //TODO - check for double top. Don't do it here create a new indicator
            //if (newTop.YValues[priceType] >= LastTop.YValues[priceType] * (1 - ApproximationRange) && newTop.YValues[priceType] <= LastTop.YValues[priceType] * (1 + ApproximationRange))
            //{
            //    AddNewTop(LastTop);
            //    AddNewTop(newTop);
            //}
            else if (newTop.YValues[priceType] > LastTop.YValues[priceType])
            {
                SearchActive = true;
            }

            LastTop = newTop;

            LastCheckedIndex += Length;
        }

        private void AddEmptyDataPoint(int index)
        {
            var emptyDataPoint = new DataPoint()
            {
                XValue = chart.Series[0].Points[index].XValue,
                IsEmpty = true
            };

            Series.Points.Add(emptyDataPoint);
        }

        private void AddNewTop(DataPoint top)
        {
            if (!Tops.Contains(top))
                Tops.Add(top);

            // replace empty point in Series
            var point = Series.Points.Where(x => x.XValue == top.XValue).First();

            point.YValues[0] = top.YValues[priceType];
            point.MarkerStyle = MarkerStyle.Circle;
            point.IsEmpty = false;

            point.ToolTip = point.YValues[0].ToString();
        }

        private DataPoint GetTop(int index)
        {
            var top = chart.Series[0].Points[index];

            for (var i = index + 1; i < (index + Length); i++)
            {
                var date = DateTime.FromOADate(chart.Series[0].Points[index].XValue).Date;
                if (i < chart.Series[0].Points.Count)
                {
                    if (chart.Series[0].Points[i].YValues[priceType] > top.YValues[priceType]) //Compare Lows
                    {
                        top = chart.Series[0].Points[i];
                    }
                }
            }

            return top;
        }

        public void Update()
        {
            // update last bar
            AddDataPoint(Series.Points.Count);
        }

        public void Clear()
        {
            if (Series != null)
            {
                Tops.Clear();
                Series.Points.Clear();
                chart.Series.Remove(Series);
            }
        }


    }
}
