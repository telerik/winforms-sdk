using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace GridViewCustomCells
{
    public class IndicatedBrowseCellElement : GridBrowseCellElement
    {
        private BrowseEditorButton indicator;

        public IndicatedBrowseCellElement(GridViewColumn column, GridRowElement row) : base(column, row)
        {
            indicator = new BrowseEditorButton();

            //this code adds a registration for RadDropDownListArrowButtonElement in order to allow its usage in other controls
            Theme theme = ThemeRepository.ControlDefault;
            StyleGroup sg = theme.FindStyleGroup("Telerik.WinControls.UI.RadBrowseEditor");
            sg.Registrations.Add(new StyleRegistration("Telerik.WinControls.UI.BrowseEditorButton"));

            indicator.Alignment = ContentAlignment.MiddleRight;
            indicator.ShouldHandleMouseInput = true;
            indicator.NotifyParentOnMouseInput = false;

            indicator.FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentBounds;
            indicator.MaxSize = new System.Drawing.Size(30, 15);
            indicator.Margin = new System.Windows.Forms.Padding(0, 1, 4, 1);
            indicator.Click += indicator_Click;

            this.Children.Add(indicator);
            
        }
       
        protected override void OnCellFormatting(CellFormattingEventArgs e)
        {
            base.OnCellFormatting(e);
            if (indicator != null)
            {
                indicator.Visibility = ((IndicatedBrowseColumn)this.ColumnInfo).EnableIndicator == true ? ElementVisibility.Visible : ElementVisibility.Collapsed;
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
            GridBrowseEditor editor = e.ActiveEditor as GridBrowseEditor;
            if (editor != null)
            {
                this.GridControl.CellEditorInitialized -= grid_CellEditorInitialized;

                GridBrowseEditorElement element = editor.EditorElement as GridBrowseEditorElement;
                element.BrowseButton.PerformClick();
            }
        }

        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(GridBrowseCellElement);
            }
        }

        public override bool IsCompatible(GridViewColumn data, object context)
        {
            return data is IndicatedBrowseColumn && context is GridDataRowElement;
        }
    }
}