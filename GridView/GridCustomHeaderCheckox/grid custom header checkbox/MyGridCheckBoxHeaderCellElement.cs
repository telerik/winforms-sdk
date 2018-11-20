using System;
using Telerik.WinControls;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;

namespace _1171173
{
    internal class MyGridCheckBoxHeaderCellElement : GridHeaderCellElement
    {
        private RadCheckBoxElement checkBox;
        public MyGridCheckBoxHeaderCellElement(GridViewColumn column, GridRowElement row) : base(column, row)
        {

        }
        protected override void CreateChildElements()
        {
            base.CreateChildElements();

            checkBox = new RadCheckBoxElement();
            checkBox.ToggleStateChanged += CheckBox_ToggleStateChanged;
            this.Children.Add(checkBox);
        }

        private void CheckBox_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.MasterTemplate.BeginUpdate();
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                foreach (var item in this.GridControl.ChildRows)
                {
                    item.Cells[this.ColumnIndex].Value = true;
                }
            }
            else
            {
                foreach (var item in this.GridControl.ChildRows)
                {
                    item.Cells[this.ColumnIndex].Value = false;
                }
            }
            this.MasterTemplate.EndUpdate(true, new DataViewChangedEventArgs(ViewChangedAction.DataChanged));

        }
        public override bool IsCompatible(GridViewColumn data, object context)
        {
            return base.IsCompatible(data, context) && data.Name == "Bool";
        }
        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(GridHeaderCellElement);
            }
        }
    }

    public class CustomColumn : GridViewCheckBoxColumn
    {
        public CustomColumn(string fieldName) : base(fieldName)
        {
        }

        public override Type GetCellType(GridViewRowInfo row)
        {
            if (row is GridViewTableHeaderRowInfo)
            {
                return typeof(MyGridCheckBoxHeaderCellElement);
            }
            return base.GetCellType(row);
        }

    }
}