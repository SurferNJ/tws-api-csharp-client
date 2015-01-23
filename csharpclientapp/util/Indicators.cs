using IBSampleApp.types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace IBSampleApp.util
{
    public interface IIndicator
    {
        string Name { get; set; }

        int Length { get; set; }

        IndicatorType Type { get; set; }

        Series Series { get; set; }

        string ToolTip { get; set; }

        void Create();
        void Update();
        void Clear();
    }

    public class IndicatorEMA : IIndicator
    {
        private Chart chart;
                
        public string Name { get; set; }

        public int Length { get; set; }

        public IndicatorType Type { get; set; }

        public Series Series { get; set; }

        public string ToolTip { get; set; }

        public IndicatorEMA(Chart chart, IndicatorType ema)
        {
            this.chart = chart;
            this.Type = ema;
            this.Name = Enum.GetName(typeof(IndicatorType), ema);
            this.Length = int.Parse(Types.GetEMADuration(ema));
            this.ToolTip = String.Empty;
        }

        public void Create()
        {

            if (chart.Series[0].Points.Count <= 0) return;
                
            Series = chart.Series.FindByName(Name);

            if (Series == null)
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

                //this.Chart.DataManipulator.FinancialFormula.IsStartFromFirst = true;
                //this.Chart.DataManipulator.FinancialFormula(FinancialFormula.ExponentialMovingAverage, Types.GetEMADuration(ema), "Series1:Y4", seriesName);

                for (var i = 0; i < chart.Series[0].Points.Count; i++)
                {
                    AddDataPointEMA(i);
                }
            }
        }

        public void Update()
        {
            // update last bar
            AddDataPointEMA(Series.Points.Count - 1);
        }

        public void Clear()
        {
            if (Series != null)
            {
                Series.Points.Clear();
                chart.Series.Remove(Series);
            }
        }


        public void AddDataPointEMA(int index)
        {

            double EMAYesterday = Series.Points.Count > 0 ? Series.Points.Last().YValues[0] : 0.0;

            Series.Points.AddXY(chart.Series[0].Points[index].XValue, FinancialFormulas.CalculateEMA(index, chart.Series[0].Points[index].YValues[3], Length, EMAYesterday));
        }

    }
}
