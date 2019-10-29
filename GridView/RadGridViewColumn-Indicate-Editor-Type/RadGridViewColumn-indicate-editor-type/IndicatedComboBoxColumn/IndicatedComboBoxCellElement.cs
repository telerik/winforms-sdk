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
    public class IndicatedComboBoxCellElement : GridComboBoxCellElement
    {
        private RadDropDownListArrowButtonElement indicator;

        public IndicatedComboBoxCellElement(GridViewColumn column, GridRowElement row) : base(column, row)
        {
            //this code adds a registration for RadDropDownListArrowButtonElement in order to allow its usage in other controls
            Theme theme = ThemeRepository.ControlDefault;
            StyleGroup sg = theme.FindStyleGroup("Telerik.WinControls.UI.RadDropDownList");
            sg.Registrations.Add(new StyleRegistration("Telerik.WinControls.UI.RadDropDownListArrowButtonElement"));

            indicator = new RadDropDownListArrowButtonElement();
            indicator.MaxSize = new System.Drawing.Size(18, 20);
            indicator.Alignment = ContentAlignment.MiddleRight;
            indicator.NotifyParentOnMouseInput = false;
            indicator.Click += Indicator_Click;

            this.Children.Add(indicator);
        }

        private void Indicator_Click(object sender, EventArgs e)
        {
            this.GridControl.CellEditorInitialized += GridControl_CellEditorInitialized;
            this.GridControl.EndEdit();
            this.GridControl.BeginEdit();
        }

        private void GridControl_CellEditorInitialized(object sender, GridViewCellEventArgs e)
        {
            RadDropDownListEditor editor = e.ActiveEditor as RadDropDownListEditor;
            if (editor != null)
            {
                this.GridControl.CellEditorInitialized -= GridControl_CellEditorInitialized;

                RadDropDownListEditorElement element = editor.EditorElement as RadDropDownListEditorElement;
                element.ShowPopup();
            }
        }

        protected override void OnCellFormatting(CellFormattingEventArgs e)
        {
            base.OnCellFormatting(e);
            if (indicator != null)
            {
                indicator.Visibility = ((IndicatedComboBoxColumn)this.ColumnInfo).EnableIndicator == true ? ElementVisibility.Visible : ElementVisibility.Collapsed;
            }
        }
        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(GridComboBoxCellElement);
            }
        }

        public override bool IsCompatible(GridViewColumn data, object context)
        {
            return data is IndicatedComboBoxColumn && context is GridDataRowElement;
        }
    }
}

