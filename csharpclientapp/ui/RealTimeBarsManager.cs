/* Copyright (C) 2013 Interactive Brokers LLC. All rights reserved.  This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IBApi;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using IBSampleApp.messages;
using CSharpClientApp.usercontrols;

namespace IBSampleApp.ui
{
    public class RealTimeBarsManager : DataManager
    {
        public const int RT_BARS_ID_BASE = 40000000;

        protected int seqId;

        protected int barCounter = -1;

        public List<DataChart> DataCharts = new List<DataChart>();

        // IB timestamp offset
        public static DateTime StartTimeStamp = new DateTime(1970, 1, 1, 0, 0, 0);

        public RealTimeBarsManager(int seqId, IBClient ibClient) 
            : base(ibClient)
        {
            this.seqId = seqId;
        }

        public void AddRequest(Contract contract, string whatToShow, bool useRTH)
        {
            //Clear();
            //ibClient.ClientSocket.reqHistoricalData(seqId, contract, endDateTime, durationString, barSizeSetting, whatToShow, useRTH, 1);
            ibClient.ClientSocket.reqRealTimeBars(seqId + RT_BARS_ID_BASE, contract, 5, whatToShow, useRTH, null);
        }

        public void CancelRequest()
        {
            ibClient.ClientSocket.cancelRealTimeBars(seqId + RT_BARS_ID_BASE);            
        }

        public override void Clear()
        {
            ibClient.ClientSocket.cancelRealTimeBars(seqId + RT_BARS_ID_BASE);
            //base.Clear();
        }

        public override void NotifyError(int requestId)
        {
        }


        public override void UpdateUI(IBMessage message)
        {            
            

            RealTimeBarMessage rtBar = (RealTimeBarMessage)message;
            DateTime messageTimestamp = StartTimeStamp.AddSeconds(rtBar.Timestamp).ToLocalTime();

            foreach (var dataChart in this.DataCharts)
            {
                
                // don't show RT data on historical charts
                if (messageTimestamp > dataChart.ChartEndDate) return;

                Chart rtBarsChart = dataChart.Chart;
                var index = rtBarsChart.Series[0].Points.Count - 1;

                // update current price
                dataChart.CurrentPriceLabel.Text = rtBar.Close.ToString("0.00000");
                if (rtBar.Close > rtBarsChart.Series[0].Points[index].YValues[3])
                    dataChart.CurrentPriceLabel.ForeColor = System.Drawing.Color.Green;
                else if ((rtBar.Close < rtBarsChart.Series[0].Points[index].YValues[3]))
                    dataChart.CurrentPriceLabel.ForeColor = System.Drawing.Color.Red;                
                
                // check if new bar needs to be created
                var chartTimeStamp = System.DateTime.FromOADate(rtBarsChart.Series[0].Points[index].XValue);
                var deltaSeconds = (messageTimestamp - chartTimeStamp).TotalSeconds;


                
                if (deltaSeconds > dataChart.BarSizeInSeconds)
                {
                    double xMin = rtBarsChart.ChartAreas[0].AxisX.ScaleView.ViewMinimum;                    

                    // adding new bar
                    rtBarsChart.Series[0].Points.AddXY(messageTimestamp, rtBar.High);
                    rtBarsChart.Series[0].Points[index + 1].YValues[1] = rtBar.Low;
                    rtBarsChart.Series[0].Points[index + 1].YValues[2] = rtBar.Open;
                    rtBarsChart.Series[0].Points[index + 1].YValues[3] = rtBar.Close;

                    rtBarsChart.ChartAreas[0].AxisX.ScaleView.Scroll(ScrollType.Last);
                    //rtBarsChart.ChartAreas[0].AxisX.ScaleView.Zoom(xMin, xMax);

                }
                else
                {
                    // reloading (updating) last bar
                    var timestamp = rtBarsChart.Series[0].Points[index].XValue;
                    var open = rtBarsChart.Series[0].Points[index].YValues[2];
                    var close = rtBar.Close;
                    var high = Math.Max(rtBar.High, rtBarsChart.Series[0].Points[index].YValues[0]);
                    var low = Math.Min(rtBar.Low, rtBarsChart.Series[0].Points[index].YValues[1]);

                    rtBarsChart.Series[0].Points.Remove(rtBarsChart.Series[0].Points[index]);

                    rtBarsChart.Series[0].Points.AddXY(timestamp, high);
                    rtBarsChart.Series[0].Points[index].YValues[1] = low;
                    rtBarsChart.Series[0].Points[index].YValues[2] = open;
                    rtBarsChart.Series[0].Points[index].YValues[3] = close;
                }


            }
        }
    }
}
