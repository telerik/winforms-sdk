using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls.UI;
using System.Drawing;
using System.Windows.Forms;

namespace TicketTest
{
    public class ColumnElement: StackLayoutElement
    {
        ColumnHeaderElement header;
        StackLayoutElement content;

        public ColumnHeaderElement Header { get { return this.header; } }
        public StackLayoutElement Content { get { return this.content; } }

        public ColumnElement(string title)        
        {
            Header.Text = title;
        }

        protected override void InitializeFields()
        {
            base.InitializeFields();

            this.DrawFill = false;
            this.DrawBorder = true;
            this.BorderBoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders;
            this.BorderLeftWidth = 0;
            this.BorderTopWidth = 0;
            this.BorderRightWidth = 1;
            this.BorderRightColor = Color.Gray;
            this.StretchHorizontally = true;
            this.StretchVertically = true;
            this.Orientation = System.Windows.Forms.Orientation.Vertical;
        }

        protected override void CreateChildElements()
        {
            base.CreateChildElements();

            header = new ColumnHeaderElement();
            this.Children.Add(header);

            content = new StackLayoutElement();
            content.Orientation = Orientation.Vertical;
            content.StretchHorizontally = true;
            content.StretchVertically = true;
            content.AllowDrop = true;
            this.Children.Add(content);
        }
    }
}
