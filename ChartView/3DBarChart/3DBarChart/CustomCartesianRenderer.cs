using System;
using System.Collections.Generic;
using Telerik.Charting;
using Telerik.WinControls.UI;

namespace _3DBarChart
{
    public class CustomCartesianRenderer : CartesianRenderer
    {
        private Dictionary<object, double> summaries = new Dictionary<object, double>();

        public CustomCartesianRenderer(CartesianArea area)
            : base(area)
        { }

        public Dictionary<object, double> Summaries
        {
            get { return this.summaries; }
        }

        protected override void Initialize()
        {
            base.Initialize();

            this.summaries = new Dictionary<object, double>();

            foreach (BarSeries series in this.Area.Series)
            {
                foreach (CategoricalDataPoint dp in series.DataPoints)
                {
                    object key = dp.Category;

                    if (!this.summaries.ContainsKey(key))
                    {
                        this.summaries.Add(key, 0);
                    }

                    this.summaries[key] += dp.Value.Value;
                }
            }

            for (int i = 0; i < this.DrawParts.Count; i++)
            {
                BarSeriesDrawPart barPart = this.DrawParts[i] as BarSeriesDrawPart;

                if (barPart != null)
                {
                    CustomBarSeriesDrawPart customDrawPart = new CustomBarSeriesDrawPart((BarSeries)barPart.Element, this);
                    customDrawPart.DrawCap = barPart.Element.Name == "Last";

                    this.DrawParts[i] = customDrawPart;
                }
            }
        }
    }
}
