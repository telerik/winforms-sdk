using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace _1408634
{
    public partial class CustomMCCBEditor : UserControl
    {
        public CustomMCCBEditor()
        {
            InitializeComponent();
            this.radGridView1.AllowAddNewRow = false;
            this.radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            this.radPopupEditor1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDown;
            this.radGridView1.ReadOnly = true;
            this.radGridView1.CurrentRowChanged += RadGridView1_CurrentRowChanged;
            this.TextBox.KeyDown += TextBox_KeyDown;
            this.radGridView1.CellDoubleClick += RadGridView1_CellDoubleClick;
        }

        private void RadGridView1_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            this.PopupEditor.PopupEditorElement.ClosePopup();
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.PopupEditor.PopupEditorElement.ClosePopup();
            }
        }

        private void RadGridView1_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
         

        }

        public object Value
        {
            get
            {
                if (this.radGridView1.CurrentRow != null && this.radGridView1.CurrentRow is GridViewDataRowInfo)
                {
                    return this.radGridView1.CurrentRow.Cells[0].Value;
                }
                return null;
            }
        }
        public RadTextBoxElement TextBox
        {
            get
            {
                return this.radPopupEditor1.TextBoxElement;
            }
        }
        public RadGridView GridControl
        {
            get
            {
                return this.radGridView1;
            }
        }
        public RadPopupEditor PopupEditor
        {
            get
            {
                return this.radPopupEditor1;
            }
        }

    }
}
