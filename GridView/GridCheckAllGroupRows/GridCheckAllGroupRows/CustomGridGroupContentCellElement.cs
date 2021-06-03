using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace GridCheckAllGroupRows
{
    public class CustomGridGroupContentCellElement : GridGroupContentCellElement
    {
        RadCheckBoxElement checkBoxElement = new RadCheckBoxElement();
        LightVisualElement textElement = new LightVisualElement();
        StackLayoutElement stack = new StackLayoutElement();

        public CustomGridGroupContentCellElement(GridViewColumn column, GridRowElement row)
            : base(column, row)
        {
        }

        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(GridGroupContentCellElement);
            }
        }

        protected override void CreateChildElements()
        {
            base.CreateChildElements();
            stack = new StackLayoutElement();
            stack.Orientation = Orientation.Horizontal;
            stack.StretchHorizontally = true;

            checkBoxElement.StretchHorizontally = false;
            checkBoxElement.CheckStateChanged += checkBoxElement_CheckStateChanged;
            textElement.TextAlignment = ContentAlignment.MiddleLeft;
            this.Children.Add(stack);
            stack.Children.Add(checkBoxElement);
            stack.Children.Add(textElement);
        }

        private void checkBoxElement_CheckStateChanged(object sender, EventArgs e)
        {
            //update child rows
            GridViewGroupRowInfo group = this.RowInfo as GridViewGroupRowInfo;
            group.Tag = checkBoxElement.Checked;
            this.GridViewElement.GridControl.BeginUpdate();
            int scrollValue = this.GridControl.TableElement.VScrollBar.Value;
            foreach (GridViewRowInfo row in this.RowInfo.ChildRows)
            {
                GridViewGroupRowInfo groupRow = row as GridViewGroupRowInfo;
                if (groupRow != null)
                {
                    Toggle(groupRow, checkBoxElement.Checked);
                }

                row.Cells["Discontinued"].Value = checkBoxElement.Checked;
            }
            this.GridViewElement.GridControl.EndUpdate();
            this.GridViewElement.GridControl.TableElement.VScrollBar.Value = scrollValue;
        }

        private void Toggle(GridViewGroupRowInfo groupRow, bool state)
        {
            groupRow.Tag = state;
            foreach (GridViewRowInfo row in groupRow.ChildRows)
            {
                GridViewGroupRowInfo g = row as GridViewGroupRowInfo;
                if (g != null)
                {
                    Toggle(g, state);
                }

                row.Cells["Discontinued"].Value = state;
            }
        }

        public override void SetContent()
        {
            base.SetContent();
            this.DrawText = false;
            textElement.Text = ((GridViewGroupRowInfo)this.RowInfo).HeaderText;
            checkBoxElement.CheckStateChanged -= checkBoxElement_CheckStateChanged;
            if (this.RowInfo.Tag != null)
            {
                checkBoxElement.Checked = (bool)this.RowInfo.Tag;
            }
            else
            {
                checkBoxElement.Checked = false;
            }
            checkBoxElement.CheckStateChanged += checkBoxElement_CheckStateChanged;
        }
    }
}