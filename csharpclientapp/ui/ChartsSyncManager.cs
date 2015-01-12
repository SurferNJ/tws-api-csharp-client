using CSharpClientApp.usercontrols;
using IBSampleApp.ui;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CSharpClientApp.ui
{
    public class ChartsSyncManager
    {
        private List<HistoricalDataManager> historicalDataManagers;

        public ChartsSyncManager(List<HistoricalDataManager> historicalDataManagers)
        {
            this.historicalDataManagers = historicalDataManagers;

            foreach (var manager in this.historicalDataManagers)
            {
                manager.DataChart.DataChartMouseMove += new System.Windows.Forms.MouseEventHandler(this.historicalChart_MouseMove);
            }
        }

        private void historicalChart_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                var dataChart = (DataChart)sender;

                var xValue = dataChart.XValue;
                var yValue = dataChart.YValue;

                foreach (var manager in this.historicalDataManagers)
                {                    
                    if (manager.DataChart != dataChart)
                    {
                        
                        // sync X axis (date)
                        var xOADate = Math.Truncate(xValue);
                        var xPoint = manager.DataChart.Chart.Series[0].Points.Where(x => Math.Truncate(x.XValue) == xOADate).FirstOrDefault();
                        if (xPoint != null)
                            manager.DataChart.Chart.ChartAreas[0].CursorX.SetCursorPosition(manager.DataChart.Chart.Series[0].Points.IndexOf(xPoint) + 1);
                        else
                            manager.DataChart.Chart.ChartAreas[0].CursorX.SetCursorPosition(0.0);
                        
                        // syn Y axis (price)
                        if (yValue <= manager.DataChart.Chart.ChartAreas[0].AxisY.Maximum
                            && yValue >= manager.DataChart.Chart.ChartAreas[0].AxisY.Minimum)
                            manager.DataChart.Chart.ChartAreas[0].CursorY.SetCursorPosition(yValue);
                        else
                            manager.DataChart.Chart.ChartAreas[0].CursorY.SetCursorPosition(0.0);

                        manager.DataChart.UpdateControls(xPoint, yValue);
                    }
                }
            }
            catch { } // do nothing as exceptions can occur during graph resizing            
        }
    }

}
