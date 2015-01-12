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
