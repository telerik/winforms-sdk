using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace FilterinIngIndicatorsInGridView
{
    #region CustomGridFilterCellElement
    public class MyGridFilterCellElement : GridFilterCellElement
    {
        private RadButtonElement clearButtonElement;

        public MyGridFilterCellElement(GridViewDataColumn column, GridRowElement row)
            : base(column, row)
        {
        }

        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(GridFilterCellElement);
            }
        }

        public RadButtonElement ClearButtonElement
        {
            get
            {
                return this.clearButtonElement;
            }
        }

        protected override void CreateChildElements()
        {
            base.CreateChildElements();

            this.clearButtonElement = new RadButtonElement();
            this.clearButtonElement.Image = Image.FromFile(@"..\..\cross16x16.png");
            this.clearButtonElement.Click += ClearButtonElement_Click;
            this.clearButtonElement.NotifyParentOnMouseInput = false;
            this.Children.Add(this.clearButtonElement);
        }

        protected override SizeF ArrangeOverride(SizeF finalSize)
        {
            SizeF size = base.ArrangeOverride(finalSize);
            if (this.IsFilterApplied)
            {
                RectangleF arrangeRect = new RectangleF(finalSize.Width - this.FilterButton.DesiredSize.Width - this.clearButtonElement.DesiredSize.Width - this.ElementSpacing, 4,
                    this.clearButtonElement.DesiredSize.Width, this.clearButtonElement.DesiredSize.Height);
                this.clearButtonElement.Arrange(arrangeRect);
            }

            if (this.ColumnInfo is GridViewDecimalColumn)
            {
                this.TextAlignment = ContentAlignment.MiddleLeft;
            }

            return size;
        }

        protected override void SetTextAlignment()
        {
            base.SetTextAlignment();

            if (this.ColumnInfo is GridViewDecimalColumn)
            {
                this.TextAlignment = ContentAlignment.MiddleLeft;
            }
        }

        protected override void SetContentCore(object value)
        {
            base.SetContentCore(value);

            this.clearButtonElement.Visibility = this.DataColumnInfo.FilterDescriptor != null ? ElementVisibility.Visible : ElementVisibility.Collapsed;
        }

        public override bool IsCompatible(GridViewColumn data, object context)
        {
            return context is GridFilterRowElement;
        }

        private void ClearButtonElement_Click(object sender, EventArgs e)
        {
            this.DataColumnInfo.FilterDescriptor = null;
        }
    }

    #endregion
}
