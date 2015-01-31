/* Copyright (C) 2013 Interactive Brokers LLC. All rights reserved.  This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;
using IBApi;
using IBSampleApp.messages;
using System.Globalization;
using System.Windows.Forms;
using IBSampleApp.types;
using CSharpClientApp.usercontrols;
using System.Drawing;

namespace IBSampleApp.ui
{
    public class HistoricalDataManager : DataManager
    {
        
        public const int HISTORICAL_ID_BASE = 30000000;
                        
        protected int seqId; // Sequence id to keep track of multiple HistoricalDataManagers

        private string fullDatePattern = "yyyyMMdd  HH:mm:ss GMT";
        private string yearMonthDayPattern = "yyyyMMdd";
        private string yearMonthDayTimePattern = "yyyyMMdd  HH:mm:ss";

        protected int barCounter = -1;

        protected DataChart dataChart;

        public DataChart DataChart { get { return dataChart; } }

        private List<HistoricalDataMessage> historicalData;
                
        public event EventHandler<ChartPaintCompletedEventArgs> PaintCompleted;

        public HistoricalDataManager(int seqId, IBClient ibClient, DataChart dataChart)
            : base(ibClient, null) 
        {
            this.seqId = seqId;
            this.dataChart = dataChart;
            dataChart.Chart.Series[0]["PriceUpColor"] = "Green";
            dataChart.Chart.Series[0]["PriceDownColor"] = "Red";
                        
        }

        // do not use this method... use BarSizeType parameter
        public void AddRequest(Contract contract, string endDateTime, string durationString, string barSizeSetting, string whatToShow, int useRTH, int dateFormat)
        {
            Clear();
            ibClient.ClientSocket.reqHistoricalData(seqId + HISTORICAL_ID_BASE, contract, endDateTime, durationString, barSizeSetting, whatToShow, useRTH, dateFormat, new List<TagValue>());
                        
        }

        public void AddRequest(Contract contract, string endDateTime, string durationString, BarSizeType barSizeType, string whatToShow, int useRTH, int dateFormat)
        {
            Clear();
            var barSizeSetting = Types.GetBarSizeDescription(barSizeType);
                        
            DateTime dt;
            if (ParseEndDate(endDateTime, out dt))
            {
                dataChart.ChartEndDate = dt;

                ibClient.ClientSocket.reqHistoricalData(seqId + HISTORICAL_ID_BASE, contract, endDateTime, durationString, barSizeSetting, whatToShow, useRTH, dateFormat, new List<TagValue>());

                SetBarSize(barSizeType);    
            }
        }

        public void SetBarSize(BarSizeType barSizeType)
        {            
            switch (barSizeType)
            {
                case BarSizeType._1_min:
                    dataChart.BarSizeInSeconds = 60; //TimeSpan.FromMinutes(1).TotalSeconds;
                    break;
                case BarSizeType._1_sec:
                    dataChart.BarSizeInSeconds = 1; //TimeSpan.FromSeconds(1).TotalSeconds;
                    break;
                case BarSizeType._15_mins:
                    dataChart.BarSizeInSeconds = 900; //TimeSpan.FromMinutes(15).TotalSeconds;
                    break;
                case BarSizeType._15_secs:
                    dataChart.BarSizeInSeconds = 15; //TimeSpan.FromSeconds(15).TotalSeconds;
                    break;
                case BarSizeType._2_mins:
                    dataChart.BarSizeInSeconds = 120; //TimeSpan.FromMinutes(2).TotalSeconds;
                    break;
                case BarSizeType._3_mins:
                    dataChart.BarSizeInSeconds = 180; //TimeSpan.FromMinutes(3).TotalSeconds;
                    break;
                case BarSizeType._30_mins:
                    dataChart.BarSizeInSeconds = 1800; //TimeSpan.FromMinutes(30).TotalSeconds;
                    break;
                case BarSizeType._30_secs:
                    dataChart.BarSizeInSeconds = 30; //TimeSpan.FromSeconds(30).TotalSeconds;
                    break;
                case BarSizeType._5_mins:
                    dataChart.BarSizeInSeconds = 300; //TimeSpan.FromMinutes(5).TotalSeconds;
                    break;
                case BarSizeType._5_secs:
                    dataChart.BarSizeInSeconds = 5; //TimeSpan.FromSeconds(5).TotalSeconds;
                    break;
                case BarSizeType._1_day:
                    dataChart.BarSizeInSeconds = 86400; //TimeSpan.FromSeconds(5).TotalSeconds;
                    break;
                 case BarSizeType._1_hour:
                    dataChart.BarSizeInSeconds = 3600; //TimeSpan.FromSeconds(5).TotalSeconds;
                    break;
            }


            switch (barSizeType)
            {
                case BarSizeType._1_min:
                case BarSizeType._1_sec:
                case BarSizeType._15_mins:
                case BarSizeType._15_secs:
                case BarSizeType._2_mins:
                case BarSizeType._3_mins:
                case BarSizeType._30_mins:
                case BarSizeType._30_secs:
                case BarSizeType._5_mins:
                case BarSizeType._5_secs:
                    dataChart.Chart.Series[0].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
                    dataChart.Chart.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm";
                    dataChart.Chart.ChartAreas[1].AxisX.LabelStyle.Format = "HH:mm";
                    dataChart.XLabelFormat = "MM/dd/yyyy hh:mm tt";                  
                    
                    break;
                default:
                    dataChart.Chart.Series[0].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
                    dataChart.Chart.ChartAreas[0].AxisX.LabelStyle.Format = "MM/dd/yyyy";
                    dataChart.Chart.ChartAreas[1].AxisX.LabelStyle.Format = "MM/dd/yyyy";
                    dataChart.XLabelFormat = "MM/dd/yyyy ddd";
                    break;
            }
        }

        public override void Clear()
        {
            barCounter = -1;

            foreach (var series in dataChart.Chart.Series)
            {
                series.Points.Clear();
            }
            
            historicalData = new List<HistoricalDataMessage>();
        }

        public override void NotifyError(int requestId)
        {
        }

        public override void UpdateUI(IBMessage message)
        {
            switch (message.Type)
            {
                case MessageType.HistoricalData:
                    historicalData.Add((HistoricalDataMessage)message);
                    break;
                case MessageType.HistoricalDataEnd:
                    PaintChart();
                    break;
            }
        }

        private bool ParseEndDate(string endDate, out DateTime dt)
        {
            dt = DateTime.MinValue; //DateTime.Today.AddDays(1).AddMilliseconds(-1);

            if (endDate.Length == fullDatePattern.Length)
                DateTime.TryParseExact(endDate, fullDatePattern, null, DateTimeStyles.None, out dt);
            else if (endDate.Length == yearMonthDayTimePattern.Length)
                DateTime.TryParseExact(endDate, yearMonthDayTimePattern, null, DateTimeStyles.None, out dt);
            else if (endDate.Length == yearMonthDayPattern.Length)
                DateTime.TryParseExact(endDate, yearMonthDayPattern, null, DateTimeStyles.None, out dt);
            else
                return false;

            return true;
        }

        private void PaintChart()
        {
            DateTime dt = DateTime.MinValue;
            dataChart.CurrentPriceLabel.Text = "";
            Chart historicalChart = dataChart.Chart;
            for (int i = 0; i < historicalData.Count; i++)
            {
                if (!ParseEndDate(historicalData[i].Date, out dt))
                    continue;

                // adding date and high
                var point = new DataPoint(dt.ToOADate(), new double[] 
                                            { historicalData[i].High, historicalData[i].Low,
                                                historicalData[i].Open, historicalData[i].Close });

                point.Color = (point.YValues[2] < point.YValues[3]) ? Color.Green : Color.IndianRed;

                

                historicalChart.Series[0].Points.Add(point);

                //historicalChart.Series[0].Points.AddXY(dt, historicalData[i].High);
                //// adding low
                //historicalChart.Series[0].Points[i].YValues[1] = historicalData[i].Low;
                ////adding open
                //historicalChart.Series[0].Points[i].YValues[2] = historicalData[i].Open;
                //// adding close
                //historicalChart.Series[0].Points[i].YValues[3] = historicalData[i].Close;

                double percentage = (historicalData[i].Close / historicalData[i].Open - 1);

                double percentageOvernight = i > 0 ? (historicalData[i].Close / historicalData[i - 1].Close - 1) : 0;
                                
                historicalChart.Series[0].Points[i].ToolTip = String.Concat("This: ", percentage.ToString("0.00%"),"\nPrevious: ",percentageOvernight.ToString("0.00%"));
                
                // adding volume
                historicalChart.Series[1].Points.AddXY(dt, historicalData[i].Volume);
            }

            // reset view to no zoom
            historicalChart.ChartAreas[0].AxisX.ScaleView.ZoomReset(); 
            historicalChart.ChartAreas[0].AxisY.ScaleView.ZoomReset();
                        

            // check if any subscibers raise event
            if (PaintCompleted != null)
            {
                var args = new ChartPaintCompletedEventArgs() { date = dt, dateOA = historicalChart.Series[0].Points.Last().XValue };
                PaintCompleted(this, args);
            }
        }
    }
}
