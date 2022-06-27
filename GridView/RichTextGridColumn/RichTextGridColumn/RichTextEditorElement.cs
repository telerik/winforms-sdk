using System;
using Telerik.WinControls;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace CustomGridColumn
{
    public class RichTextEditorElement : RadHostItem
    {
        public RichTextEditorElement()
            : base(new RadRichTextEditor())
        {
            RouteMessages = false;
            this.HostedControl.GotFocus += new EventHandler(HostedControl_GotFocus);
            this.HostedControl.KeyDown += new KeyEventHandler(HostedControl_KeyDown);
        }

        private void HostedControl_GotFocus(object sender, EventArgs e)
        {
            RichTextEditorCellElement cell = this.Parent as RichTextEditorCellElement;
            if (cell != null)
            {
                cell.ColumnInfo.IsCurrent = true;
                cell.RowInfo.IsCurrent = true;
                cell.GridViewElement.BeginEdit();
            }
        }

        void HostedControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Enter)
            {
                ((RadGridView)this.ElementTree.Control).EndEdit();
            }
        }
    }
}
