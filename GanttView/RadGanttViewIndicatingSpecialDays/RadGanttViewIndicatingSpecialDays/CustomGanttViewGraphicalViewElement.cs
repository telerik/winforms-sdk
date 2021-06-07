using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Telerik.WinControls.UI;

namespace RadGanttViewIndicatingSpecialDays
{
    public class CustomGanttViewGraphicalViewElement : GanttViewGraphicalViewElement
    {
        private List<DateTime> specialDates = new List<DateTime>();

        public CustomGanttViewGraphicalViewElement(RadGanttViewElement ganttView)
            : base(ganttView)
        { }

        public List<DateTime> SpecialDates
        {
            get { return specialDates; }
            set { specialDates = value; }
        }

        protected override Type ThemeEffectiveType
        {
            get { return typeof(GanttViewGraphicalViewElement); }
        }

        //Logic for painting the elements
        protected override void PaintElement(Telerik.WinControls.Paint.IGraphics graphics, float angle, System.Drawing.SizeF scale)
        {
            base.PaintElement(graphics, angle, scale);

            Rectangle clipRect = this.Bounds;
            Graphics g = graphics.UnderlayGraphics as Graphics;

            g.SetClip(clipRect);

            DateTime currentDate = this.TimelineBehavior.AdjustedTimelineStart;

            while (currentDate <= this.TimelineBehavior.AdjustedTimelineEnd)
            {
                float x = (float)((currentDate - this.TimelineBehavior.AdjustedTimelineStart).TotalSeconds / this.OnePixelTime.TotalSeconds);
                x -= this.HorizontalScrollBarElement.Value;
                float y = this.GanttViewElement.HeaderHeight;
                float y2 = this.Bounds.Height;

                if (currentDate.DayOfWeek == DayOfWeek.Saturday || currentDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    graphics.FillRectangle(new RectangleF(x, y, 100f, y2), Color.LightGray);
                }
                else if (this.SpecialDates.Contains(currentDate.Date))
                {
                    graphics.FillRectangle(new RectangleF(x, y, 100f, y2), Color.Orange);
                }
                else
                {
                    graphics.FillRectangle(new RectangleF(x, y, 100f, y2), Color.White);
                }

                graphics.DrawLine(Color.LightBlue, x, y, x, y2);

                currentDate = currentDate.AddDays(1);
            }

            g.ResetClip();
        }
    }
}
