using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace GridViewCustomCells
{
    public class IndicatedDecimalCellElement : GridDataCellElement
    {
        private RadRepeatArrowElement indicatorUP;
        private RadRepeatArrowElement indicatorDown;

        public IndicatedDecimalCellElement(GridViewColumn column, GridRowElement row) : base(column, row)
        {
            //this code adds a registration for RadDropDownListArrowButtonElement in order to allow its usage in other controls
            Theme theme = ThemeRepository.ControlDefault;
            StyleGroup sg = theme.FindStyleGroup("Telerik.WinControls.UI.RadSpinEditor");
            sg.Registrations.Add(new StyleRegistration("Telerik.WinControls.UI.RadSpinElementUpButton"));
            sg.Registrations.Add(new StyleRegistration("Telerik.WinControls.UI.RadSpinElementDownButton"));

            indicatorUP = new RadSpinElementUpButton();
            indicatorUP.Class = "UpButton";
            indicatorUP.Arrow.Direction = ArrowDirection.Up;     
            indicatorUP.StretchVertically = true;       
            indicatorUP.Click += indicator_Click;
            indicatorUP.Tag = true;

            indicatorDown = new RadSpinElementDownButton();
            indicatorDown.Class = "DownButton";
            indicatorDown.Arrow.Direction = ArrowDirection.Down;        
            indicatorDown.StretchVertically = true;            
            indicatorDown.Click += indicator_Click;
            indicatorDown.Tag = false;

            StackLayoutElement layout = new StackLayoutElement();
            layout.Orientation = System.Windows.Forms.Orientation.Vertical;
            layout.Alignment = System.Drawing.ContentAlignment.MiddleRight;
            layout.StretchHorizontally = false;
            layout.StretchVertically = true;
            layout.MaxSize = new System.Drawing.Size(20, 18);
            layout.FitToSizeMode = RadFitToSizeMode.FitToParentBounds;
            layout.Children.Add(indicatorUP);
            layout.Children.Add(indicatorDown);
            layout.Margin = new System.Windows.Forms.Padding(0, 1, 4, 1);
            layout.ElementSpacing = 0;

            this.Children.Add(layout);
        }

        protected override void OnCellFormatting(CellFormattingEventArgs e)
        {
            base.OnCellFormatting(e);
            this.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            if (indicatorUP != null)
            {
                indicatorUP.Visibility = ((IndicatedDecimalColumn)this.ColumnInfo).EnableIndicator == true ? ElementVisibility.Visible : ElementVisibility.Collapsed;
            }
        }

        bool Updown;

        void indicator_Click(object sender, EventArgs e)
        {
            this.GridControl.CellEditorInitialized += grid_CellEditorInitialized;

            Updown = (bool)((RadRepeatArrowElement)sender).Tag;
            this.GridControl.BeginEdit();
        }

        void grid_CellEditorInitialized(object sender, GridViewCellEventArgs e)
        {
            GridSpinEditor editor = e.ActiveEditor as GridSpinEditor;
            if (editor != null)
            {
                this.GridControl.CellEditorInitialized -= grid_CellEditorInitialized;
                GridSpinEditorElement element = editor.EditorElement as GridSpinEditorElement;

                if (Updown)
                {
                    element.ButtonUp.PerformClick();
                }
                else
                {
                    element.ButtonDown.PerformClick();
                }
            }
        }

        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(GridDataCellElement);
            }
        }

        public override bool IsCompatible(GridViewColumn data, object context)
        {
            return data is IndicatedDecimalColumn && context is GridDataRowElement;
        }
    }
}