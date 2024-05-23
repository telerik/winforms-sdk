using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using RadGridReportingLite;
using Telerik.WinControls;

namespace ExampleApplication
{
    public partial class FormMain : RadForm
    {
        public FormMain()
        {
            InitializeComponent();

            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < this.adventureWorks_DataSet.Tables.Count; i++)
			{
                RadListDataItem item = new RadListDataItem(this.adventureWorks_DataSet.Tables[i].TableName);
                item.Value = this.adventureWorks_DataSet.Tables[i].TableName;
                this.radComboBoxTables.Items.Add(item);

                this.radGridView1.Focus();
			}

            this.radGridView1.Select();

            //Telerik.WinControls.RadControlSpy.RadControlSpyForm spy = 
            //    new Telerik.WinControls.RadControlSpy.RadControlSpyForm();

            //spy.Show();

            ThemeResolutionService.ApplicationThemeName = "Aqua";
        }

        private void radComboBoxTables_SelectedValueChanged(object sender, EventArgs e)
        {
            this.radComboBoxTables.CloseDropDown();

            if (this.radComboBoxTables.SelectedValue != null)
            {
                this.radGridView1.DataSource = this.adventureWorks_DataSet;
                this.radGridView1.DataMember = this.radComboBoxTables.SelectedValue.ToString();

                switch (this.radComboBoxTables.SelectedValue.ToString())
                {
                    case "CountryRegion":
                        ExampleApplication.DataBase.AdventureWorks_DataSetTableAdapters.CountryRegionTableAdapter
                            countryRegionAdapter = 
                            new ExampleApplication.DataBase.AdventureWorks_DataSetTableAdapters.CountryRegionTableAdapter();
                        countryRegionAdapter.Fill(this.adventureWorks_DataSet.CountryRegion);

                        this.radGridView1.MasterTemplate.Columns[0].Width = 140;
                        this.radGridView1.MasterTemplate.Columns[1].Width = 400;
                        this.radGridView1.MasterTemplate.Columns[2].Width = 110;
                        this.radGridView1.MasterTemplate.Columns[2].FormatString = "{0:MM/dd/yyyy}";
                        break;
                    case "Vendor":
                        ExampleApplication.DataBase.AdventureWorks_DataSetTableAdapters.VendorTableAdapter
                            vendorAdapter = 
                            new ExampleApplication.DataBase.AdventureWorks_DataSetTableAdapters.VendorTableAdapter();
                        vendorAdapter.Fill(this.adventureWorks_DataSet.Vendor);

                        this.radGridView1.MasterTemplate.Columns[0].Width = 70;
                        this.radGridView1.MasterTemplate.Columns[1].Width = 135;
                        this.radGridView1.MasterTemplate.Columns[2].Width = 250;
                        this.radGridView1.MasterTemplate.Columns[6].Width = 180;
                        this.radGridView1.MasterTemplate.Columns[7].Width = 110;
                        this.radGridView1.MasterTemplate.Columns[7].FormatString = "{0:MM/dd/yyyy}";
                        break;
                    case "Employee":
                        ExampleApplication.DataBase.AdventureWorks_DataSetTableAdapters.EmployeeTableAdapter
                            employeeAdapter =
                            new ExampleApplication.DataBase.AdventureWorks_DataSetTableAdapters.EmployeeTableAdapter();
                        employeeAdapter.Fill(this.adventureWorks_DataSet.Employee);

                        this.radGridView1.MasterTemplate.Columns[0].Width = 80;
                        this.radGridView1.MasterTemplate.Columns[1].Width = 120;
                        this.radGridView1.MasterTemplate.Columns[2].Width = 70;
                        this.radGridView1.MasterTemplate.Columns[3].Width = 180;
                        this.radGridView1.MasterTemplate.Columns[4].Width = 80;
                        this.radGridView1.MasterTemplate.Columns[5].Width = 220;
                        this.radGridView1.MasterTemplate.Columns[6].Width = 110;
                        this.radGridView1.MasterTemplate.Columns[6].FormatString = "{0:MM/dd/yyyy}";
                        this.radGridView1.MasterTemplate.Columns[7].Width = 70;
                        this.radGridView1.MasterTemplate.Columns[9].Width = 110;
                        this.radGridView1.MasterTemplate.Columns[9].FormatString = "{0:MM/dd/yyyy}";
                        this.radGridView1.MasterTemplate.Columns[14].Width = 110;
                        this.radGridView1.MasterTemplate.Columns[14].FormatString = "{0:MM/dd/yyyy}";

                        break;
                }
            }

        }

        private void radButtonReport_Click(object sender, EventArgs e)
        {
            if (this.radComboBoxTables.SelectedValue != null)
            {
                FormOptions form = new FormOptions();
                form.ShowDialog(this);
                if (form.DialogResult == DialogResult.OK)
                {
                    RadGridReport report = 
                        new RadGridReport(String.Format("Report {0}", 
                        this.radComboBoxTables.SelectedValue));
                    report.FitToPageSize = form.FitToPage;
                    report.UseGridColors = form.UseGridColors;
                    report.AllMargins = form.SetAllMargins;
                    report.PaperKind = form.PaperKind;
                    report.PageLandScape = form.IsLandScape;
                    report.ReportWindowState = FormWindowState.Maximized;
                    report.ReportSize = new Size(800, 350);
                    
                    report.RepeatTableHeader = form.RepeatHeaderRow;

                    report.ReportFormShow(this, this.radGridView1);
                }
            }
            else
            {
                FormMessage message = new FormMessage("Message", 
                    "Please select a table to populate RadGridView!");
                message.ShowDialog(this);
            }

            
        }
    }
}