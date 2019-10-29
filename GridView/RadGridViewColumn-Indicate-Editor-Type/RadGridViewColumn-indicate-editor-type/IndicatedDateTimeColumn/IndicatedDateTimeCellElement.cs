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
   public class IndicatedDateTimeCellElement : GridDateTimeCellElement
    {
        private RadDropDownListArrowButtonElement indicator;

        public IndicatedDateTimeCellElement(GridViewColumn column, GridRowElement row)
            : base(column, row)
        {
            //this code adds a registration for RadDropDownListArrowButtonElement in order to allow its usage in other controls
            Theme theme = ThemeRepository.ControlDefault;
            StyleGroup sg = theme.FindStyleGroup("Telerik.WinControls.UI.RadDropDownList");
            sg.Registrations.Add(new StyleRegistration("Telerik.WinControls.UI.RadDropDownListArrowButtonElement"));

            indicator = new RadDropDownListArrowButtonElement();
            indicator.MaxSize = new System.Drawing.Size(18, 20);
            indicator.Alignment = ContentAlignment.MiddleRight;
            indicator.NotifyParentOnMouseInput = false;
            indicator.Click += indicator_Click;
            this.Children.Add(indicator);
        }

        protected override void OnCellFormatting(CellFormattingEventArgs e)
        {
            base.OnCellFormatting(e);
            if (indicator != null)
            {
                indicator.Visibility = ((IndicatedDateTimeColumn)this.ColumnInfo).EnableIndicator == true ? ElementVisibility.Visible : ElementVisibility.Collapsed;
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
            RadDateTimeEditor editor = e.ActiveEditor as RadDateTimeEditor;
            if (editor != null)
            {
                this.GridControl.CellEditorInitialized -= grid_CellEditorInitialized;
                RadDateTimeEditorElement element = editor.EditorElement as RadDateTimeEditorElement;
                RadDateTimePickerCalendar calendar = element.CurrentBehavior as RadDateTimePickerCalendar;

                calendar.PopupControl.AnimationEnabled = false;
                calendar.ShowDropDown();
            }
        }

        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(GridDateTimeCellElement);
            }
        }

        public override bool IsCompatible(GridViewColumn data, object context)
        {
            return data is IndicatedDateTimeColumn && context is GridDataRowElement;
        }
    }
}

