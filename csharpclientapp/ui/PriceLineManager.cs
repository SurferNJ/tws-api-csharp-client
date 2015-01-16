using IBSampleApp.types;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace CSharpClientApp.ui
{
    public class PriceLineManager
    {
        //public static readonly string BUY_LINE_NAME = "BUY_LINE";
        //public static readonly string SELL_LINE_NAME = "SELL_LINE";
        //public static readonly string BUY_LMT_LINE_NAME = "BUY_LMT_LINE";
        //public static readonly string SELL_LMT_LINE_NAME = "SELL_LMT_LINE";
        //public static readonly string SUPPORT_LINE_NAME = "SUPPORT_LINE";
        //public static readonly string RESISTANCE_LINE_NAME = "RESISTANCE_LINE";
        //public static readonly string OPEN_LINE_NAME = "OPEN_LINE";
        //public static readonly string LOW_LINE_NAME = "LOW_LINE";
        //public static readonly string HIGH_LINE_NAME = "HIGH_LINE";

        public ObservableCollection<PriceLine> PriceLines = new ObservableCollection<PriceLine>();

        public PriceLineManager()
        {
            PriceLines = new ObservableCollection<PriceLine>();
        }

        public void Remove(PriceLine line)
        {
            PriceLine oldLine = null;

            switch (line.Type)
            {

                case PriceLineType.BUY_LINE:
                    oldLine = PriceLines.Where(x => x.Type.Equals(PriceLineType.BUY_LINE)).FirstOrDefault();  
                    break;
                case PriceLineType.SELL_LINE:
                    oldLine = PriceLines.Where(x => x.Type.Equals(PriceLineType.SELL_LINE)).FirstOrDefault();
                    break;
            }

            if (oldLine != null) PriceLines.Remove(oldLine);
        }

        public void Add(PriceLine line)
        {
            PriceLine oldLine = null;

            switch (line.Type)
            {
                case PriceLineType.BUY_LINE:
                case PriceLineType.SELL_LINE:
                    oldLine = PriceLines.Where(x => x.Type.Equals(line.Type)).FirstOrDefault();
                    break;                
            }

            if (oldLine != null) PriceLines.Remove(oldLine);

            PriceLines.Add(line);
        }
    }

    public class PriceLine
    {
        public PriceLineType Type { get; set; }
        public double Price { get; set; }
    }
}
