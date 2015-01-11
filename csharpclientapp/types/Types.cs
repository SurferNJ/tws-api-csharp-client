using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace IBSampleApp.types
{
    public static class Types
    {

        public static string GetBarSizeDescription(BarSizeType barSizeType)
        {
            var name = Enum.GetName(typeof(BarSizeType), barSizeType);
            
            var rgx = new Regex("^_");
            var result = rgx.Replace(name, string.Empty);

            result = result.Replace("_", " ");

            return result;
        }

        //public static Dictionary<BarSizeType, string> BarSizeDescription = new Dictionary<BarSizeType, string>() { 
        //                            {BarSizeType._1sec, "1 sec" },
        //                            {BarSizeType._5secs, "1 sec" },
        //                            {BarSizeType._15secs, "15 secs" },
        //                            {BarSizeType._30secs, "30 secs" },
        //                            {BarSizeType._1min, "1 min" },
        //                            {BarSizeType._2mins, "2 mins" },
        //                            {BarSizeType._3mins, "3 mins" },
        //                            {BarSizeType._5mins, "5 mins" },
        //                            {BarSizeType._15mins, "15 mins" },
        //                            {BarSizeType._15mins, "15 mins" },
        //                            {BarSizeType._30mins, "30 mins" },
        //                            {BarSizeType._1hour, "1 hour" },
        //                            {BarSizeType._1day, "1 day" }
        //};
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




}
