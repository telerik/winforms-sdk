using System;
using System.Windows.Forms;
using Telerik.WinControls.UI;


namespace CustomGridColumn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            this.radGridView1.Columns.Add(new GridViewRichTextColumn("Text", "Text"));

            GridViewRowInfo row = radGridView1.Rows.AddNew(); 
            row.Height = 200;
            row.Cells[0].Value = "<html><span style=\"background-color:red\">Highlighted Text</span></html>";

             row = radGridView1.Rows.AddNew(); 
            row.Height = 200;
            row.Cells[0].Value = "<html><span style=\"background-color:red\">Second Text</span></html>";

             row = radGridView1.Rows.AddNew(); 
            row.Height = 200;
            row.Cells[0].Value = "<html><span style=\"background-color:red\">Third Text</span></html>";

            this.radGridView1.CurrentCellChanged += RadGridView1_CurrentCellChanged;
        }

        private void RadGridView1_CurrentCellChanged(object sender, CurrentCellChangedEventArgs e)
        {
            if (e.NewCell != null && e.NewCell.ColumnInfo is GridViewRichTextColumn)
            {
                RichTextEditorCellElement cellElement = this.radGridView1.TableElement.GetCellElement(e.NewCell.RowInfo,
                    e.NewCell.ColumnInfo) as RichTextEditorCellElement;
                if (cellElement != null)
                {
                    RichTextEditorElement element = (RichTextEditorElement)((RichTextEditor)cellElement.Editor).EditorElement;
                    RadRichTextEditor textBox = (RadRichTextEditor)element.HostedControl;
                    this.richTextEditorRibbonBar1.AssociatedRichTextEditor = textBox;
                    Console.WriteLine(textBox.GetHashCode());
                }
            }
        }
    
    }

}
