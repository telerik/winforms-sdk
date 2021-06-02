using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace MultiSelectDropDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DataTable t = new DataTable();
            t.Columns.Add("ID", typeof(int));
            t.Columns.Add("Name", typeof(string));
            t.Rows.Add(1, "one");
            t.Rows.Add(2, "two");
            t.Rows.Add(3, "three");
            t.Rows.Add(4, "four");
            t.Rows.Add(5, "five");
            t.Rows.Add(6, "six");
            t.Rows.Add(7, "seven");
            t.Rows.Add(8, "eight");
            t.Rows.Add(9, "nine");
            t.Rows.Add(10, "ten");

            CustomDropDownList list = new CustomDropDownList();
            list.Name = "MyDropDown";
            list.Location = new Point(130, 80);
            list.Size = new System.Drawing.Size(230, 20); 
            Controls.Add(list);
 
            list.DisplayMember = "Name";
            list.ValueMember = "ID";
            list.DataSource = t;
            list.SelectedIndexChanged += list_SelectedIndexChanged;
        }

        private void list_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (e.Position > -1)
            {
                CustomDropDownList list = sender as CustomDropDownList;
                ((CustomListDataItem)list.Items[e.Position]).Checked = true; 
                ((CustomEditorElement)list.DropDownListElement).SynchronizeText();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CustomDropDownList ddl = this.Controls["MyDropDown"] as CustomDropDownList;
            ((CustomListDataItem)ddl.DropDownListElement.ListElement.SelectedItem).Checked = false;
            ((CustomListDataItem)ddl.DropDownListElement.ListElement.SelectedItem).Selected = false;
            LightVisualElement lve = ddl.DropDownListElement.EditableElement.Children[1] as LightVisualElement;
            lve.Text = string.Empty;

            ddl.Items[1].Selected = true;
        }
    }
}