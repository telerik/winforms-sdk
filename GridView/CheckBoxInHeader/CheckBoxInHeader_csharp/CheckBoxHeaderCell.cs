using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;

namespace CheckBoxInHeader_csharp
{
    public class CheckBoxHeaderCell : GridHeaderCellElement
    {
        RadCheckBoxElement checkbox;

        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(GridHeaderCellElement);
            }
        }

        public CheckBoxHeaderCell(GridViewColumn column, GridRowElement row)
            : base(column, row)
        {

        }

        public override void Initialize(GridViewColumn column, GridRowElement row)
        {
            base.Initialize(column, row);
            column.AllowSort = false;
        }

        public override void SetContent()
        {
        }

        protected override void DisposeManagedResources()
        {
            checkbox.ToggleStateChanged -= new StateChangedEventHandler(checkbox_ToggleStateChanged);
            base.DisposeManagedResources();
        }

        protected override void CreateChildElements()
        {
            base.CreateChildElements();
            checkbox = new RadCheckBoxElement();
            checkbox.ToggleStateChanged += new StateChangedEventHandler(checkbox_ToggleStateChanged);
            this.Children.Add(checkbox);
        }

        protected override SizeF ArrangeOverride(SizeF finalSize)
        {
            SizeF size = base.ArrangeOverride(finalSize);

            RectangleF rect = GetClientRectangle(finalSize);
            this.checkbox.Arrange(new RectangleF((finalSize.Width - this.checkbox.DesiredSize.Width) / 2, (rect.Height - 20) / 2, 20, 20));

            return size;
        }

        public override bool IsCompatible(GridViewColumn data, object context)
        {
            return data.Name == "Select" && context is GridTableHeaderRowElement
                && base.IsCompatible(data, context);
        }

        private void checkbox_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (!suspendProcessingToggleStateChanged)
            {
                bool valueState = false;

                if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
                {
                    valueState = true;
                }
                this.GridViewElement.EditorManager.EndEdit();
                this.TableElement.BeginUpdate();
                for (int i = 0; i < this.ViewInfo.Rows.Count; i++)
                {
                    this.ViewInfo.Rows[i].Cells[this.ColumnIndex].Value = valueState;
                }

                this.TableElement.EndUpdate(false);

                this.TableElement.Update(GridUINotifyAction.DataChanged);

            }
        }

        private bool suspendProcessingToggleStateChanged;
        public void SetCheckBoxState(Telerik.WinControls.Enumerations.ToggleState state)
        {
            suspendProcessingToggleStateChanged = true;
            this.checkbox.ToggleState = state;
            suspendProcessingToggleStateChanged = false;
        }

        public override void Attach(GridViewColumn data, object context)
        {
            base.Attach(data, context);
            this.GridControl.ValueChanged += new EventHandler(GridControl_ValueChanged);
        }

        public override void Detach()
        {
            if (this.GridControl != null)
            {
                this.GridControl.ValueChanged -= GridControl_ValueChanged;
            }

            base.Detach();
        }

        void GridControl_ValueChanged(object sender, EventArgs e)
        {
            RadCheckBoxEditor editor = sender as RadCheckBoxEditor;
            if (editor != null)
            {
                this.GridViewElement.EditorManager.EndEdit();
                if ((ToggleState)editor.Value == ToggleState.Off)
                {
                    SetCheckBoxState(ToggleState.Off);
                }
                else if ((ToggleState)editor.Value == ToggleState.On)
                {
                    bool found = false;
                    foreach (GridViewRowInfo row in this.ViewInfo.Rows)
                    {
                        if (row != this.RowInfo && row.Cells[this.ColumnIndex].Value == null || !(bool)row.Cells[this.ColumnIndex].Value)
                        {
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        SetCheckBoxState(ToggleState.On);
                    }
                }
            }
        }
    }
}
