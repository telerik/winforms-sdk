using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls;
using Telerik.WinControls.Paint;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.UI;

namespace ERP.Client
{
    class ColorCellElement : VirtualGridCellElement
    {
        protected override void UpdateInfo(VirtualGridCellValueNeededEventArgs args)
        {
            base.UpdateInfo(args);
            this.TextAlignment = ContentAlignment.MiddleLeft;
            if (this.Value == null)
            {
                this.Text = "No Color";
             }
         }
        
        public override bool IsCompatible(int data, object context)
        {
            VirtualGridRowElement rowElement = context as VirtualGridRowElement;

            return data == 3 && rowElement.RowIndex >= 0;
        }
        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(VirtualGridCellElement);
            }
        }
       
        protected override void PostPaintElement(IGraphics graphics)
        {
            base.PostPaintElement(graphics);
            var gr = ((Graphics)((RadGdiGraphics)graphics).Graphics);

            gr.CompositingQuality = CompositingQuality.HighQuality;
            gr.SmoothingMode = SmoothingMode.HighQuality;

            if (this.Value != null)
            {
                var color = Color.Transparent;
                if (this.Value.ToString().StartsWith("#"))
                {
                    color = System.Drawing.ColorTranslator.FromHtml(this.Value.ToString());
                }
                else if(!this.Value.ToString().Contains('/'))
                {
                    color = Color.FromName(this.Value.ToString());
                }
                
                var rect = new RectangleF(Size.Width - 20, 3, 18, Size.Height - 6);
                using (var brush = new SolidBrush(color))
                {
                    gr.FillEllipse(brush,rect);
                    gr.DrawEllipse(Pens.Black, rect);

                }
            }
            
        }
        
        public override bool CanEdit
        {
            get
            {
                return false;
            }
        }
    }
}
