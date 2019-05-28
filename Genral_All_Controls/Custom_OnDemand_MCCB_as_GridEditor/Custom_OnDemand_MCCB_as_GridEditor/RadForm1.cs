using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace _1408634
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
            radGridView2.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            radGridView2.Columns.Add(new GridViewMultiComboBoxColumn());

            for (int i = 0; i < 10; i++)
            {
                radGridView2.Rows.Add("Sam");
            }

            radGridView2.EditorRequired += RadGridView1_EditorRequired;
            radGridView2.CellEditorInitialized += RadGridView2_CellEditorInitialized;
        }

        private void RadGridView2_CellEditorInitialized(object sender, GridViewCellEventArgs e)
        {
            var editor = e.ActiveEditor as MyCustomEditor;
            if (editor != null)
            {
                var control = (((RadHostItem)editor.EditorElement).HostedControl) as CustomMCCBEditor;
                control.TextBox.Text = "";
                control.PopupEditor.PopupClosed -= PopupEditor_PopupClosed;
                control.PopupEditor.PopupClosed += PopupEditor_PopupClosed;
                control.TextBox.TextChanged -= TextBox_TextChanged;
                control.TextBox.TextChanged += TextBox_TextChanged;
            }
        }

        private void PopupEditor_PopupClosed(object sender, RadPopupClosedEventArgs args)
        {
            var control = ((RadPopupEditorElement)sender).ElementTree.Control.Parent as CustomMCCBEditor;
            radGridView2.EndEdit();
            control.GridControl.CurrentRow = null;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            var textBoxElement = sender as RadTextBoxElement;
            var control = textBoxElement.ElementTree.Control.Parent as CustomMCCBEditor;
            var grid = control.GridControl;

            if (textBoxElement.Text.Length < 2)
            {
                return;
            }
            if (!control.PopupEditor.PopupEditorElement.IsPopupOpen)
            {
                control.PopupEditor.PopupEditorElement.ShowPopup();
            }


            grid.BeginUpdate();
            if (grid.Columns.Count == 0)
            {
                grid.Columns.Add("Data");
            }
            grid.Rows.Clear();

            var data = GetData(textBoxElement.Text);

            foreach (var item in data)
            {
                grid.Rows.Add(item.Text);
            }

            grid.EndUpdate();


        }

        private void RadGridView1_EditorRequired(object sender, EditorRequiredEventArgs e)
        {
            if (e.EditorType == typeof(RadMultiColumnComboBoxElement))
            {
                e.EditorType = typeof(MyCustomEditor);
            }
        }

        public List<Data> GetData(string filter)
        {
            List<Data> items = new List<Data>();
            for (int i = 0; i < 10; i++)
            {
                items.Add(new Data("Sam"));
                items.Add(new Data("Sam1"));
                items.Add(new Data("Melanie"));
                items.Add(new Data("Christoff"));
                items.Add(new Data("David"));
                items.Add(new Data("Melanie"));
            }
            if (!string.IsNullOrEmpty(filter))
            {
                return items.Where(x => x.Text.Contains(filter)).ToList();
            }
            return items;

        }
    }

    class MyCustomEditor : BaseGridEditor
    {
        CustomMCCBEditor control = new CustomMCCBEditor();
        public override object Value
        {
            get
            {
                return control.Value;
            }
            set
            {

            }
        }
        protected override RadElement CreateEditorElement()
        {
            var hostItem = new RadHostItem(control);
            return hostItem;
        }
        public override void BeginEdit()
        {
            base.BeginEdit();
            this.control.PopupEditor.TextBoxElement.Focus();
        }
    }

    public class Data
    {
        public Data(string text)
        {
            Text = text;
        }

        public string Text { get; set; }
    }


}
