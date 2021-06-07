using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;

namespace RadGanttViewIndicatingSpecialDays
{
    public class CustomGanttViewElement : RadGanttViewElement
    {
        protected override GanttViewGraphicalViewElement CreateGraphicalViewElement(RadGanttViewElement ganttView)
        {
            return new CustomGanttViewGraphicalViewElement(this);
        }

        protected override Type ThemeEffectiveType
        {
            get { return typeof(RadGanttViewElement); }
        }
    }
}
