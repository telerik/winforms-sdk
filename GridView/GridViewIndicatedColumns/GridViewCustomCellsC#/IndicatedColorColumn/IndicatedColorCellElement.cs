using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace GridViewCustomCells
{
    public class IndicatedColorCellElement : GridColorCellElement
    {
        private RadButtonElement indicator;

        public IndicatedColorCellElement(GridViewColumn column, GridRowElement row) : base(column, row)
        {
        }

        protected override void CreateChildElements()
        {
            base.CreateChildElements();

            indicator = new RadButtonElement();

            indicator.Text = ". . .";
            indicator.FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentBounds;
            indicator.LayoutPanel.Alignment = ContentAlignment.MiddleCenter;
            indicator.MaxSize = new System.Drawing.Size(30, 17);
            indicator.NotifyParentOnMouseInput = false;
            indicator.StretchHorizontally = false;
            indicator.Margin = new System.Windows.Forms.Padding(0, 1, 2, 1);
            indicator.Alignment = ContentAlignment.MiddleRight;
            indicator.Click += indicator_Click;

            this.Children.Add(indicator);
        }

        protected override void OnCellFormatting(CellFormattingEventArgs e)
        {
            base.OnCellFormatting(e);
            if (indicator != null)
            {
                indicator.Visibility = ((IndicatedColorColumn)this.ColumnInfo).EnableIndicator == true ? ElementVisibility.Visible : ElementVisibility.Collapsed;
            }
        }

        void indicator_Click(object sender, EventArgs e)
        {
            this.GridControl.CellEditorInitialized += grid_CellEditorInitialized;
            this.GridControl.EndEdit();
            this.GridControl.BeginEdit();
        }

        void grid_CellEditorInitialized(object sender, GridViewCellEventArgs e)
        {
            GridColorPickerEditor editor = e.ActiveEditor as GridColorPickerEditor;
            if (editor != null)
            {
                this.GridControl.CellEditorInitialized -= grid_CellEditorInitialized;
                GridColorPickerElement element = editor.EditorElement as GridColorPickerElement;
                element.ColorPickerButton.PerformClick();
            }
        }

        protected override SizeF ArrangeOverride(SizeF finalSize)
        {
            RectangleF clientRect = this.GetClientRectangle(finalSize);
            SizeF size = base.ArrangeOverride(finalSize);

            indicator.Arrange(clientRect);
            RectangleF lmpRect = new RectangleF(this.ColorBox.DesiredSize.Width, clientRect.Y, clientRect.Width - this.ColorBox.DesiredSize.Width, clientRect.Height);
            lmpRect.Width -= indicator.DesiredSize.Width;
            this.Layout.Arrange(lmpRect);

            return size;
        }

        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(GridColorCellElement);
            }
        }

        public override bool IsCompatible(GridViewColumn data, object context)
        {
            return data is IndicatedColorColumn && context is GridDataRowElement;
        }
    }
}