using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace IBSampleApp.util
{
    public static class UrlLauncher
    {
        // TODO - move these to config file
        private static readonly string urlEconomicCalendar = 
            "http://bloomberg.econoday.com/byweek.asp?day={0}&month={1}&year={2}&cust=bloomberg-us&lid=0";

        private static readonly string urlDailyBattlePlan =
            "https://www.google.com/?gws_rd=ssl#q=tradingmarkets.com+daily+battle+plan+{0}+{1}+{2}";

        private static readonly string urlClosingBell =
            "https://www.google.com/?gws_rd=ssl#q=closing+bell+business+insider+{0}+{1}+{2}";

        public static void EconomicCalendarShow(DateTime date)
        {
            
            var target = String.Format(urlEconomicCalendar, date.Day, date.Month, date.Year);

            ProcessStartInfo sInfo = new ProcessStartInfo(target);
            Process.Start(sInfo);
        }

        public static void DailyBattlePlanShow(DateTime date)
        {
            
            var target = String.Format(urlDailyBattlePlan, date.ToString("MMMM"), date.Day, date.Year);

            ProcessStartInfo sInfo = new ProcessStartInfo(target);
            Process.Start(sInfo);
        }

        public static void ClosingBellShow(DateTime date)
        {

            var target = String.Format(urlClosingBell, date.ToString("MMMM"), date.Day, date.Year);

            ProcessStartInfo sInfo = new ProcessStartInfo(target);
            Process.Start(sInfo);
        }
    }
}
