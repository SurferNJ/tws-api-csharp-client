using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace IBSampleApp.types
{
    public static class Types
    {
        // TODO: move these settings to config file
        public static Dictionary<ExpMovAvgType, Color> EMAColors = new Dictionary<ExpMovAvgType, Color>() { 
                                    {ExpMovAvgType.EMA10, Color.Green },
                                    {ExpMovAvgType.EMA21, Color.Blue },
                                    {ExpMovAvgType.EMA30, Color.Yellow },
                                    {ExpMovAvgType.EMA50, Color.Red },
                                    {ExpMovAvgType.EMA100, Color.White },
                                    {ExpMovAvgType.EMA150, Color.LightBlue },
                                    {ExpMovAvgType.EMA200, Color.Purple }
        };
        
        public static string GetEMADuration(ExpMovAvgType ema)
        {
            var name = Enum.GetName(typeof(ExpMovAvgType), ema);

            var result = name.Remove(0, 3);

            return result;
        }

        public static string GetBarSizeDescription(BarSizeType barSizeType)
        {
            var name = Enum.GetName(typeof(BarSizeType), barSizeType);
            
            var rgx = new Regex("^_");
            var result = rgx.Replace(name, string.Empty);

            result = result.Replace("_", " ");

            return result;
        }
    }

    public enum BarSizeType
    {
        _1_sec = 1,
        _5_secs,
        _15_secs,
        _30_secs,
        _1_min,
        _2_mins,
        _3_mins,
        _5_mins,
        _15_mins,
        _30_mins,
        _1_hour,
        _1_day
    }

    public enum ExpMovAvgType
    {
        EMA10 = 1,
        EMA21,
        EMA30,
        EMA50,
        EMA100,
        EMA150,
        EMA200        
    }

    public enum PriceLineType
    {
        BUY_LINE = 1,
        SELL_LINE,
        BUY_LMT_LINE,
        SELL_LMT_LINE,
        SUPPORT_LINE,
        RESISTANCE_LINE,
        OPEN_LINE,
        LOW_LINE,
        HIGH_LINE,
        DAILY_MARKER,
        DAILY_1M_LINE
    }

    public class ChartPaintCompletedEventArgs : EventArgs
    {       
        public DateTime date { get; set; }
        public double dateOA { get; set; }
    }




}
