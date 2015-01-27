using IBSampleApp.types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace IBSampleApp.util
{
    public class IndicatorBottom : IIndicator
    {
        private Chart chart;

        public string Name { get; set; }

        public int Length { get; set; }

        public IndicatorType Type { get; set; }

        public Series Series { get; set; }

        public string ToolTip { get; set; }

        public List<DataPoint> Bottoms = new List<DataPoint>();

        public bool SearchActive { get; set; }

        public int LastCheckedIndex { get; set; }

        public DataPoint LastBottom { get; set; }

        private int priceType { get; set; }

        public double ApproximationRange = 0.0001;

        public IndicatorBottom(Chart chart, int length, PriceType priceType = PriceType.Low)
        {
            this.chart = chart;
            this.Type = IndicatorType.Bottoms;
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

                //Series.ChartType = SeriesChartType.Line;

                if (ToolTip.Length > 0)
                    Series.ToolTip = ToolTip;

            }

            Series.Points.Clear();
            Bottoms.Clear();

            LastCheckedIndex = 0;
            LastBottom = chart.Series[0].Points[LastCheckedIndex];

            SearchActive = true;

            // calculate bottoms
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

            var newBottom = GetBottom(LastCheckedIndex + 1);

            if (SearchActive && newBottom.YValues[priceType] > LastBottom.YValues[priceType])
            {
                AddNewBottom(LastBottom);
                SearchActive = false;
            }
            //TODO - check for double bottom. Don't do it here, create a new study
            //if (newBottom.YValues[priceType] >= LastBottom.YValues[priceType] * (1 - ApproximationRange) && newBottom.YValues[priceType] <= LastBottom.YValues[priceType] * (1 + ApproximationRange))
            //{
            //    AddNewBottom(LastBottom);
            //    AddNewBottom(newBottom);                
            //}
            else if (newBottom.YValues[priceType] < LastBottom.YValues[priceType])
            {
                SearchActive = true;
            }

            LastBottom = newBottom;

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

        private void AddNewBottom(DataPoint bottom)
        {
            if (!Bottoms.Contains(bottom))
                Bottoms.Add(bottom);

            
            // replace empty point in Series
            var point = Series.Points.Where(x => x.XValue == bottom.XValue).First();

            point.YValues[0] = bottom.YValues[priceType];
            point.MarkerStyle = MarkerStyle.Circle;
            point.IsEmpty = false;

            point.ToolTip = point.YValues[0].ToString();
        }

        private DataPoint GetBottom(int index)
        {            
            var bottom = chart.Series[0].Points[index];
            
            for (var i = index+1; i < (index + Length); i++)
            {
                var date = DateTime.FromOADate(chart.Series[0].Points[index].XValue).Date;
                if (i < chart.Series[0].Points.Count)
                {
                    if (chart.Series[0].Points[i].YValues[priceType] < bottom.YValues[priceType]) //Compare Lows
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
            AddDataPoint(Series.Points.Count);
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

    }
}
