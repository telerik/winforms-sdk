using System;
using System.Data;
using System.Windows.Forms;
using Telerik.WinControls.Export;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Export;

namespace SplashFormExportExample
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();

            this.radGridView1.DataSource = this.GetData();
            this.radGridView1.DataMember = "Table1";
        }
        
        private void radButtonExportToPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;

                fileName = fileName.Substring(0, fileName.Length - 4) + DateTime.Now.Minute + DateTime.Now.Second + ".xlsx";
                this.NewSpreadExport(fileName);
            }
        }
        
        private void NewSpreadExport(string fileName)
        {
           
            SplashForm.ShowForm(this);

            GridViewSpreadExport spreadExporter = new GridViewSpreadExport(this.radGridView1);
            spreadExporter.ExportVisualSettings = true;
            spreadExporter.ExportFormat = SpreadExportFormat.Xlsx;
            spreadExporter.HiddenColumnOption = HiddenOption.DoNotExport;
            SpreadExportRenderer exportRenderer = new SpreadExportRenderer();
            exportRenderer.WorkbookCreated += exportRenderer_WorkbookCreated;
            spreadExporter.RunExport(fileName, exportRenderer);
        }
        
        void exportRenderer_WorkbookCreated(object sender, WorkbookCreatedEventArgs e)
        {
            SplashForm.CloseForm();
        }
        
        private DataSet GetData()
        {
            DataSet ds = new DataSet();
            DataTable table = new DataTable();
            table.Columns.Add("First Name", typeof(string));
            table.Columns.Add("Last Name", typeof(string));
            table.Columns.Add("+R/S", typeof(double));
            table.Columns.Add("Job", typeof(string));
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("Birth Date", typeof(DateTime));
            
            for (int i = 0; i < 1000; i++)
            {
                table.Rows.Add("Carey", "Payette", 25.5, "Carey", "Payette", DateTime.Now.AddDays(-2537));
                table.Rows.Add("Michael", "Crump", 33333, "Michael", "Crump", DateTime.Now.AddDays(-1545));
                table.Rows.Add("Jeff", "Fritz", 98.76543, "Jeff", "Fritz", DateTime.Now.AddDays(12));
                table.Rows.Add("Phil", "Japikse", 1500.0, "Phil", "Japikse", DateTime.Now.AddDays(-68));
                table.Rows.Add("Jesse", "Liberty", 99.99, "Jesse", "Liberty", DateTime.Now.AddDays(1));
                table.Rows.Add("Iris", "Classon", 12345.6, "Iris", "Classon", DateTime.Now);
            }

            ds.Tables.Add(table);

            return ds;
        }
    }
}
