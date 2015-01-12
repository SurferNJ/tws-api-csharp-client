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
        public const string BUY_LINE_NAME = "BUY_LINE";
        public const string SELL_LINE_NAME = "SELL_LINE";
        public const string BUY_LMT_LINE_NAME = "BUY_LMT_LINE";
        public const string SELL_LMT_LINE_NAME = "SELL_LMT_LINE";
        public const string SUPPORT_LINE_NAME = "SUPPORT_LINE";
        public const string RESISTANCE_LINE_NAME = "RESISTANCE_LINE";

        public ObservableCollection<PriceLine> PriceLines = new ObservableCollection<PriceLine>();

        public PriceLineManager()
        {
            PriceLines = new ObservableCollection<PriceLine>();
        }

        public void Remove(PriceLine line)
        {
            PriceLine oldLine = null;

            switch (line.Name)
            {
                    
                case BUY_LINE_NAME:
                    oldLine = PriceLines.Where(x => x.Name.Equals(BUY_LINE_NAME)).FirstOrDefault();  
                    break;
                case SELL_LINE_NAME:
                    oldLine = PriceLines.Where(x => x.Name.Equals(SELL_LINE_NAME)).FirstOrDefault();
                    break;
            }

            if (oldLine != null) PriceLines.Remove(oldLine);
        }

        public void Add(PriceLine line)
        {
            PriceLine oldLine = null;

            switch (line.Name)
            {
                case BUY_LINE_NAME:
                case SELL_LINE_NAME:
                    oldLine = PriceLines.Where(x => x.Name.Equals(line.Name)).FirstOrDefault();
                    break;                
            }

            if (oldLine != null) PriceLines.Remove(oldLine);

            PriceLines.Add(line);
        }
    }

    public class PriceLine
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
