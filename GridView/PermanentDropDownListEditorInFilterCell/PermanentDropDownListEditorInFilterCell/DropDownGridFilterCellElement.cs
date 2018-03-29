using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Layouts;
using Telerik.WinControls.UI;

namespace PermanentDropDownListEditorInFilterCell
{
    class DropDownGridFilterCellElement : GridFilterCellElement
    {
        RadDropDownListElement dropDown;
        LightVisualElement operatorElement;
        StackLayoutPanel container; 
        BindingList<string> filterValues = new BindingList<string>();

        public DropDownGridFilterCellElement(GridViewDataColumn column, GridRowElement row) : base(column, row)
        {
        }

        BindingContext bc = new BindingContext();

        protected override void CreateChildElements()
        {
            base.CreateChildElements();
            operatorElement = new LightVisualElement();
            container = new StackLayoutPanel();
            dropDown = new RadDropDownListElement();

            dropDown.BindingContext = bc;
            dropDown.DropDownStyle = RadDropDownStyle.DropDownList; 
            dropDown.SelectedIndexChanged += dropDown_SelectedIndexChanged;

            this.Children.Add(container);
            container.Children.Add(operatorElement);
            container.Children.Add(dropDown);
        }

        private void dropDown_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            GridViewDataColumn dataColumn = this.ColumnInfo as GridViewDataColumn;

            if (dataColumn.FilterDescriptor == null)
            {
                dataColumn.FilterDescriptor = new Telerik.WinControls.Data.FilterDescriptor(this.ColumnInfo.Name, Telerik.WinControls.Data.FilterOperator.Contains, null);
                dataColumn.FilterDescriptor.IsFilterEditor = true;
            }
            if (e.Position > -1)
            {
                this.Value = dropDown.Items[e.Position].Text;
                this.RowInfo.Tag = e.Position;
                dataColumn.FilterDescriptor.Value = this.Value;
            }
            if (e.Position == 0)
            {
                dataColumn.FilterDescriptor = null;
            }
        }

        public override void Detach()
        {
            dropDown.SelectedIndexChanged -= dropDown_SelectedIndexChanged;
            base.Detach();
        }

        protected override void SetContentCore(object value)
        {
            base.SetContentCore(value);

            GridViewDataColumn dataColumn = this.ColumnInfo as GridViewDataColumn;
            if (dropDown.DataSource == null)
            {
                filterValues.Add("No filter");
                foreach (string distinctValue in dataColumn.DistinctValues)
                {
                    filterValues.Add(distinctValue);
                }
                dropDown.SelectedIndexChanged -= dropDown_SelectedIndexChanged;
                dropDown.DataSource = filterValues;

                dropDown.SelectedIndex = 0;
                dropDown.SelectedIndexChanged += dropDown_SelectedIndexChanged;
            }
            this.DrawText = false;
            this.ForeColor = Color.Transparent;
            operatorElement.ForeColor = Color.Black; 

            if (this.RowInfo.Tag != null && this.RowInfo.Tag.ToString() != dropDown.SelectedIndex.ToString())
            {
                dropDown.SelectedIndexChanged -= dropDown_SelectedIndexChanged;
                //synchronize the selected option
                dropDown.SelectedIndex = (int)this.RowInfo.Tag;
                dropDown.SelectedIndexChanged += dropDown_SelectedIndexChanged;
            }

            if (dataColumn != null && dataColumn.FilterDescriptor != null)
            {
                //synchronize the filter operator
                this.operatorElement.Text = dataColumn.FilterDescriptor.Operator.ToString();
            }
            else
            {
                dropDown.SelectedIndexChanged -= dropDown_SelectedIndexChanged;
                dropDown.SelectedIndex = 0;
                dropDown.SelectedIndexChanged += dropDown_SelectedIndexChanged;
            }
        }

        //hide the default filter button
        protected override void UpdateFilterButtonVisibility(bool enabled)
        {
            enabled = false;
            base.UpdateFilterButtonVisibility(enabled);
        }

        public override bool IsCompatible(GridViewColumn data, object context)
        {
            return data is CustomColumn && context is GridViewFilteringRowInfo;
        }
    }
}