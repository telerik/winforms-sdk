using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace CopyPasteDisplayMember
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            GridViewDecimalColumn decimalColumn = new GridViewDecimalColumn("Id");
            radGridView1.MasterTemplate.Columns.Add(decimalColumn);

            GridViewTextBoxColumn textBoxColumn = new GridViewTextBoxColumn("Name");
            radGridView1.MasterTemplate.Columns.Add(textBoxColumn);

            GridViewDateTimeColumn dateTimeColumn = new GridViewDateTimeColumn("CreatedOn");
            radGridView1.MasterTemplate.Columns.Add(dateTimeColumn);
            
            GridViewComboBoxColumn comboColumn = new GridViewComboBoxColumn("Country");
            comboColumn.DisplayMember = "Name";
            comboColumn.ValueMember = "ID";
            comboColumn.DataSource = new List<Country>
            {
                new Country { ID = 1, Name = "UK" },
                new Country { ID = 2, Name = "USA" }
            };
            radGridView1.MasterTemplate.Columns.Add(comboColumn);

            radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

            for (int i = 0; i < 10; i++)
            {
                radGridView1.Rows.Add(i, "Name" + i, DateTime.Now.AddDays(i), i % 2 + 1);
            }
        }

        public class Country
        {
            public int ID { get; set; }

            public string Name { get; set; }
        }

        public class CustomMasterGridViewTemplate : MasterGridViewTemplate
        {
            public override void Copy()
            {
                base.Copy();

                if (Clipboard.ContainsData(DataFormats.Text))
                {
                    string data = Clipboard.GetData(DataFormats.Text).ToString();
                    if (data != string.Empty)
                    {
                        StringBuilder sb = new StringBuilder();
                        //modify the copied data and replace it in the clipboard
                        foreach (GridViewRowInfo row in this.Owner.SelectedRows)
                        {
                            int i = 0;
                            while (i < row.Cells.Count)
                            {
                                if (i > 0)
                                {
                                    sb.Append(";");
                                }
                                //copy the DisplayMember
                                string cellText = this.Owner.CurrentView.GetCellElement(row.Cells[i].RowInfo, row.Cells[i].ColumnInfo).Text;
                                sb.Append(cellText);
                                i++;
                            }
                            sb.AppendLine();
                        }

                        Clipboard.SetData(DataFormats.Text, sb.ToString());
                    }
                }
            }

            public override void Paste()
            {
                if (Clipboard.ContainsData(DataFormats.Text))
                {
                    string data = Clipboard.GetData(DataFormats.Text).ToString();
                    if (data != string.Empty)
                    {
                        StringBuilder sb = new StringBuilder();
                        string[] rowTokens = data.Split(new string[] { Environment.NewLine.ToString() }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string rowToken in rowTokens)
                        {
                            string[] tokens = rowToken.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                            for (int i = 0; i < tokens.Length; i++)
                            {
                                GridViewComboBoxColumn comboColumn = this.Owner.Columns[i] as GridViewComboBoxColumn;
                                if (i < this.Owner.Columns.Count && comboColumn != null)
                                {
                                    //get the ValueMember
                                    sb.Append(GetValueMember(tokens[i], comboColumn.DataSource));
                                }
                                else
                                {
                                    sb.Append(tokens[i]);
                                }

                                if (i < tokens.Length - 1)
                                {
                                    sb.Append("\t");
                                }
                            }
                            sb.Append(Environment.NewLine.ToString());
                        }

                        Clipboard.SetData(DataFormats.Text, sb.ToString());
                    }
                }

                base.Paste();
            }

            private string GetValueMember(string token, object source)
            {
                IEnumerable<Country> dataSource = source as IEnumerable<Country>;
                if (dataSource != null)
                {
                    foreach (Country c in dataSource)
                    {
                        if (c.Name == token)
                        {
                            return c.ID.ToString();
                        }
                    }
                }

                return string.Empty;
            }
        }

        public class CustomGrid : RadGridView
        {
            protected override RadGridViewElement CreateGridViewElement()
            {
                return new CustomRadGridViewElement();
            }

            public override string ThemeClassName
            {
                get
                {
                    return typeof(RadGridView).FullName;
                }
            }
        }

        public class CustomRadGridViewElement : RadGridViewElement
        {
            protected override MasterGridViewTemplate CreateTemplate()
            {
                return new CustomMasterGridViewTemplate();
            }

            protected override Type ThemeEffectiveType
            {
                get
                {
                    return typeof(RadGridViewElement);
                }
            }
        }
    }
}