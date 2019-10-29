using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace RadGridViewColumn_indicate_editor_type
{
   public class IndicatedCalculatorCellElement : GridCalculatorCellElement
    {
        private RadCalculatorArrowButtonElement indicator;

        public IndicatedCalculatorCellElement(GridViewColumn column, GridRowElement row) : base(column, row)
        {
            //this code adds a registration for RadDropDownListArrowButtonElement in order to allow its usage in other controls
            Theme theme = ThemeRepository.ControlDefault;
            StyleGroup sg = theme.FindStyleGroup("Telerik.WinControls.UI.RadCalculatorDropDown");
            sg.Registrations.Add(new StyleRegistration("Telerik.WinControls.UI.RadCalculatorArrowButtonElement"));

            indicator = new RadCalculatorArrowButtonElement();

            indicator.MaxSize = new System.Drawing.Size(18, 20);
            indicator.Alignment = ContentAlignment.MiddleRight;
            indicator.NotifyParentOnMouseInput = false;
            indicator.ShouldHandleMouseInput = true;
            indicator.Click += indicator_Click;
            this.Children.Add(indicator);
        }

        protected override void OnCellFormatting(CellFormattingEventArgs e)
        {
            base.OnCellFormatting(e);
            this.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            if (indicator != null)
            {
                indicator.Visibility = ((IndicatedCalculatorColumn)this.ColumnInfo).EnableIndicator == true ? ElementVisibility.Visible : ElementVisibility.Collapsed;
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
            RadCalculatorEditor editor = e.ActiveEditor as RadCalculatorEditor;
            if (editor != null)
            {
                this.GridControl.CellEditorInitialized -= grid_CellEditorInitialized;

                RadCalculatorEditorElement element = editor.EditorElement as RadCalculatorEditorElement;
                element.PopupForm.AnimationEnabled = false;
                element.ShowPopup();
            }
        }

        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(GridCalculatorCellElement);
            }
        }

        public override bool IsCompatible(GridViewColumn data, object context)
        {
            return data is IndicatedCalculatorColumn && context is GridDataRowElement;
        }
    }
}

