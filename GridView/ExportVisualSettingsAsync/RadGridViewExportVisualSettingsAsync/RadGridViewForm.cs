using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Export;
using Telerik.WinControls.UI;
using RadGridViewExportVisualSettingsAsync;
using System.Threading.Tasks;

namespace RadControlsAsyncCS
{
    public partial class RadGridViewForm : RadForm
    {
        public RadGridViewForm()
        {
            InitializeComponent();

            ThemeResolutionService.ApplicationThemeName = "TelerikMetro";

            this.radGridView1.DataSource = this.GetSampleData();
            this.radGridView1.TableElement.TableHeaderHeight = 50;
            this.radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

            this.radGridView1.EnableAlternatingRowColor = true;
            this.radGridView1.TableElement.AlternatingRowColor = Color.LightGreen;
        }

        private DataTable GetSampleData()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("IsValid", typeof(bool));
            dataTable.Columns.Add("Date", typeof(DateTime));

            for (int i = 0; i < 5000; i++)
            {
                dataTable.Rows.Add(i, "Name " + i, i % 2 == 0, DateTime.Now.AddDays(i));
            }

            return dataTable;
        }

        private async void radButton1_Click(object sender, EventArgs e)
        {   
            await this.ExportGridVisuallyAsync();
        }

        private async Task ExportGridVisuallyAsync()
        {
            Action job = new Action(this.ExportData);
            Task task = new Task(job);
            task.Start();

            await task;
        }

        private void ExportData()
        {
            GridViewSpreadExport spreadExporter = new GridViewSpreadExport(this.radGridView1);
            spreadExporter.ExportVisualSettings = true;

            SpreadExportRenderer exportRenderer = new SpreadExportRenderer();
            spreadExporter.RunExport(@"..\..\exported-grid.xlsx", exportRenderer);

            RadMessageBox.Show("Export completed!");
        }
    }
}
