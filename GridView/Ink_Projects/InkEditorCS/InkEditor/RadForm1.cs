using Microsoft.Ink;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace InkEditor
{
    public partial class RadForm1 : Form
    {
        public RadForm1()
        {
            InitializeComponent();


          
            radGridView1.Columns.Add(new GridViewTextBoxColumn() { Name = "InkColumn" });
            radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            radGridView1.EnableGrouping = false;
            radGridView1.AllowAddNewRow = false;

           // for (int i = 0; i < 10; i++)
            {
               // radGridView1.Rows.Add("Row Index" + i);
              
            }

            radGridView1.Rows.Add("John");
            radGridView1.Rows.Add("Jack");
            radGridView1.Rows.Add("David");
            radGridView1.Rows.Add("Melanie");
            radGridView1.Rows.Add("Mike");
            radGridView1.Font = new Font("Segoe UI", 16, FontStyle.Regular);
            radGridView1.TableElement.RowHeight = 50;
            radGridView1.EditorRequired += RadGridView1_EditorRequired;
        }

        private void RadGridView1_EditorRequired(object sender, EditorRequiredEventArgs e)
        {
            if (radGridView1.CurrentColumn.Name == "InkColumn")
            {
                e.EditorType = typeof(GridInkEditor);
            }
        }
    }
}
