using System;
using System.Data;
using Telerik.WinControls.UI;

namespace RadGanttViewExample
{
    public class CustomGanttViewTaskItemElement : GanttViewTaskItemElement
    {
        public CustomGanttViewTaskItemElement(GanttViewGraphicalViewElement owner)
            : base(owner)
        { }

        protected override GanttGraphicalViewBaseTaskElement CreateTaskElement()
        {
            return new CustomGanttGraphicalViewBaseTaskElement();
        }

        protected override Type ThemeEffectiveType
        {
            get { return typeof(GanttViewTaskItemElement); }
        }
    }
}
