using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IBSampleApp.util
{
    public static class FinancialFormulas
    {
        public static double CalculateEMA(int index, double price, int length, double EMAYesterday)
        {

            if (index < 0)
                return 0.0;

            double k = 2 / ((double)length + 1);

            return price * k + EMAYesterday * (1 - k);
        }

    }
}
