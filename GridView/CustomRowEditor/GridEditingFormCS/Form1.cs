using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using GridEditingForm.NwindDataSetTableAdapters;
using Telerik.WinControls.RadControlSpy;

namespace GridEditingForm
{
    public partial class Form1 : Form
    {
        NwindDataSet nwindDataSet;
        CarsTableAdapter carsTableAdapter;
        CategoriesTableAdapter categoriesTableAdapter;
        CustomersTableAdapter customerTableAdapter;
        EmployeesTableAdapter employeesTableAdapter;
        BindingSource carsBindingSource;
        BindingSource categoriesBindingSource;
        BindingSource customerBindingSource;
        BindingSource employeesBindingSource;

        public Form1()
        {
            InitializeComponent();


            nwindDataSet = new NwindDataSet();
            nwindDataSet.DataSetName = "NwindDataSet";

            carsBindingSource = new BindingSource();
            categoriesBindingSource = new BindingSource();
            customerBindingSource = new BindingSource();
            employeesBindingSource = new BindingSource();

            carsTableAdapter = new CarsTableAdapter();
            categoriesTableAdapter = new CategoriesTableAdapter();
            customerTableAdapter = new CustomersTableAdapter();
            employeesTableAdapter = new EmployeesTableAdapter();

            carsBindingSource.DataSource = nwindDataSet;
            carsBindingSource.DataMember = "Cars";

            categoriesBindingSource.DataSource = nwindDataSet;
            categoriesBindingSource.DataMember = "Categories";

            customerBindingSource.DataSource = nwindDataSet;
            customerBindingSource.DataMember = "Customers";

            employeesBindingSource.DataSource = nwindDataSet;
            employeesBindingSource.DataMember = "Employees";
        }

        private void Form1_Load( object sender, EventArgs e )
        {
            this.radGridView1.CommandCellClick += new CommandCellClickEventHandler(radGridView1_CommandCellClick);
            this.radGridView1.CellDoubleClick += new GridViewCellEventHandler(radGridView1_CellDoubleClick);
            this.radGridView1.ReadOnly = true;
            this.radGridView1.AutoSizeRows = true;

            carsTableAdapter.Fill(nwindDataSet.Cars);
            categoriesTableAdapter.Fill(nwindDataSet.Categories);
            customerTableAdapter.Fill(nwindDataSet.Customers);
            employeesTableAdapter.Fill(nwindDataSet.Employees);
        }

        void radGridView1_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            GridViewRowInfo rowInfo = this.radGridView1.CurrentRow;
            EditingForm form = new EditingForm();
            form.BuildEditFormFromRow(rowInfo);
            DialogResult res = form.ShowDialog();
            
        }

        void radGridView1_CommandCellClick(object sender, EventArgs e)
        {
            GridViewRowInfo rowInfo = this.radGridView1.CurrentRow;
            EditingForm form = new EditingForm();
            form.BuildEditFormFromRow(rowInfo);
            DialogResult res = form.ShowDialog();
        }

        private void rrbCars_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (this.rrbCars.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On) 
            {
                this.radGridView1.Columns.Clear();
                this.radGridView1.DataSource = carsBindingSource;

                AddCommandColumn();
            }
        }

        private void rrbCategories_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (this.rrbCategories.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radGridView1.Columns.Clear();
                this.radGridView1.DataSource = categoriesBindingSource;

                AddCommandColumn();
            }
        }

        private void rrbCustomers_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (this.rrbCustomers.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radGridView1.Columns.Clear();
                this.radGridView1.DataSource = customerBindingSource;
                AddCommandColumn();
            }
        }

        private void rrbEmployees_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (this.rrbEmployees.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.radGridView1.Columns.Clear();
                this.radGridView1.DataSource = employeesBindingSource;

                AddCommandColumn();
            }
        }

        private void AddCommandColumn()
        {
            GridViewCommandColumn command = new GridViewCommandColumn();
            command.HeaderText = "Edit data";
            command.UseDefaultText = true;
            command.DefaultText = "Edit";
            command.TextAlignment = ContentAlignment.MiddleCenter;
            this.radGridView1.Columns.Add(command);

            this.radGridView1.MasterTemplate.BestFitColumns();
        }
    }
}