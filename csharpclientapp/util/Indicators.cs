using IBSampleApp.types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;


namespace IBSampleApp.util
{
    public interface IIndicator
    {
        string Name { get; set; }

        int Length { get; set; }

        IndicatorType Type { get; set; }

        Series Series { get; set; }

        string ToolTip { get; set; }

        void Create();
        void Update();
        void Clear();
    }


}
