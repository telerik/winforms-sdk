using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;

namespace RadGanttViewIndicatingSpecialDays
{
    public class CustomGanttView : RadGanttView
    {
        protected override RadGanttViewElement CreateGanttViewElement()
        {
            return new CustomGanttViewElement();
        }

        public override string ThemeClassName
        {
            get { return typeof(RadGanttView).FullName; }
        }
    }
}
