using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;
using System.Drawing;

namespace CustomCellEditor
{
    public class CustomInfoCell : GridComboBoxCellElement
    {
        private int buttonWidth = 20;
        private int buttonPadding = 2;

        public CustomInfoCell(GridViewColumn column, GridRowElement row)
            : base(column, row)
        {            
        }

        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(GridComboBoxCellElement);
            }
        }

        protected override SizeF ArrangeOverride(SizeF finalSize)
        {
            base.ArrangeOverride(finalSize);
            RectangleF rect = GetClientRectangle(finalSize);
            RectangleF rectEdit = new RectangleF(rect.X, rect.Y, rect.Width - (buttonWidth + buttonPadding), rect.Height);
            RectangleF rectButton = new RectangleF(rectEdit.Right + buttonPadding, rectEdit.Y, buttonWidth, rect.Height);
            if (this.Children.Count == 2)
            {
                this.Children[0].Arrange(rectButton);
                this.Children[1].Arrange(rectEdit);
            }

            return finalSize;
        }
    }
}