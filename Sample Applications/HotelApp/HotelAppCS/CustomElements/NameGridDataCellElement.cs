using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Telerik.WinControls.UI;

namespace HotelApp
{
    public class NameGridDataCellElement : GridDataCellElement
    {
        private StackLayoutElement container = new StackLayoutElement();
        private LightVisualElement nameElement = new LightVisualElement();
        private LightVisualElement durationElement = new LightVisualElement();
            
        public NameGridDataCellElement(GridViewColumn column, GridRowElement row) : base(column, row)
        {
        }
            
        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(GridDataCellElement);
            }
        }
            
        protected override void CreateChildElements()
        {
            base.CreateChildElements();
            container.Orientation = Orientation.Horizontal;
            container.StretchHorizontally = true;
            container.StretchVertically = true;
            nameElement.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            nameElement.MaxSize = new System.Drawing.Size(100, 100);
            nameElement.MinSize = new System.Drawing.Size(100, 0);
            nameElement.StretchHorizontally = false;
            durationElement.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            durationElement.ForeColor = Color.Gray;
            container.Children.Add(nameElement);
            container.Children.Add(durationElement);
                
            this.Children.Add(container);
        }
            
        protected override void SetContentCore(object value)
        {
            base.SetContentCore(value);
            this.DrawText = false;
            Booking booking = this.RowInfo.DataBoundItem as Booking;
            if (booking != null)
            {
                nameElement.Text = booking.Name;
                durationElement.Text = (booking.To - booking.From).Days.ToString();
                if (durationElement.Text == "1")
                {
                    durationElement.Text = "1 day";
                }
                else
                {
                    durationElement.Text += " days";
                }
            }
        }
            
        public override bool IsCompatible(GridViewColumn data, object context)
        {
            return data.Name == "Name" && context is GridViewDataRowInfo;
        }
    }
    
}