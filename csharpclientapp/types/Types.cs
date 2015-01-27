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
        public static Dictionary<IndicatorType, Color> IndicatorColors = new Dictionary<IndicatorType, Color>() { 
                                    {IndicatorType.EMA10, Color.Green },
                                    {IndicatorType.EMA21, Color.Blue },
                                    {IndicatorType.EMA30, Color.Yellow },
                                    {IndicatorType.EMA50, Color.Red },
                                    {IndicatorType.EMA100, Color.White },
                                    {IndicatorType.EMA150, Color.LightBlue },
                                    {IndicatorType.EMA200, Color.Purple },
                                    {IndicatorType.Tops, Color.White },
                                    {IndicatorType.Bottoms, Color.Gold }
        };
        
        public static string GetEMADuration(IndicatorType ema)
        {
            var name = Enum.GetName(typeof(IndicatorType), ema);

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

    public enum IndicatorType
    {
        EMA10 = 1,
        EMA21,
        EMA30,
        EMA50,
        EMA100,
        EMA150,
        EMA200,
        Tops,
        Bottoms
    }

    public enum PriceType
    {
        High = 0,
        Low = 1,
        Open = 2,
        Close = 3
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
        DAILY_MARKER_1M,
        PERCENTAGE_LINE,
        PERCENTAGE_LINE_TEXT,
        BOTTOM_LINE,
        TOP_LINE
    }

    public class ChartPaintCompletedEventArgs : EventArgs
    {       
        public DateTime date { get; set; }
        public double dateOA { get; set; }
    }

    public class ChangeScopeEventArgs : EventArgs
    {
        public int delta { get; set; }
    }




}
