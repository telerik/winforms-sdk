Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls.UI
Imports GridEditingForm.NwindDataSetTableAdapters

Namespace GridEditingForm
	Public Partial Class Form1
		Inherits Form
		Private nwindDataSet As NwindDataSet
		Private carsTableAdapter As CarsTableAdapter
		Private categoriesTableAdapter As CategoriesTableAdapter
		Private customerTableAdapter As CustomersTableAdapter
		Private employeesTableAdapter As EmployeesTableAdapter
		Private carsBindingSource As BindingSource
		Private categoriesBindingSource As BindingSource
		Private customerBindingSource As BindingSource
		Private employeesBindingSource As BindingSource

		Public Sub New()
			InitializeComponent()

			nwindDataSet = New NwindDataSet()
			nwindDataSet.DataSetName = "NwindDataSet"

			carsBindingSource = New BindingSource()
			categoriesBindingSource = New BindingSource()
			customerBindingSource = New BindingSource()
			employeesBindingSource = New BindingSource()

			carsTableAdapter = New CarsTableAdapter()
			categoriesTableAdapter = New CategoriesTableAdapter()
			customerTableAdapter = New CustomersTableAdapter()
			employeesTableAdapter = New EmployeesTableAdapter()

			carsBindingSource.DataSource = nwindDataSet
			carsBindingSource.DataMember = "Cars"

			categoriesBindingSource.DataSource = nwindDataSet
			categoriesBindingSource.DataMember = "Categories"

			customerBindingSource.DataSource = nwindDataSet
			customerBindingSource.DataMember = "Customers"

			employeesBindingSource.DataSource = nwindDataSet
			employeesBindingSource.DataMember = "Employees"
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			AddHandler radGridView1.CommandCellClick, AddressOf radGridView1_CommandCellClick
			AddHandler radGridView1.CellDoubleClick, AddressOf radGridView1_CellDoubleClick
			Me.radGridView1.ReadOnly = True
			Me.radGridView1.AutoSizeRows = True

			carsTableAdapter.Fill(nwindDataSet.Cars)
			categoriesTableAdapter.Fill(nwindDataSet.Categories)
			customerTableAdapter.Fill(nwindDataSet.Customers)
			employeesTableAdapter.Fill(nwindDataSet.Employees)
		End Sub

		Private Sub radGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As GridViewCellEventArgs)
			Dim rowInfo As GridViewRowInfo = Me.radGridView1.CurrentRow
			Dim form As EditingForm = New EditingForm()
			form.BuildEditFormFromRow(rowInfo)
			Dim res As DialogResult = form.ShowDialog()

		End Sub

		Private Sub radGridView1_CommandCellClick(ByVal sender As Object, ByVal e As EventArgs)
			Dim rowInfo As GridViewRowInfo = Me.radGridView1.CurrentRow
			Dim form As EditingForm = New EditingForm()
			form.BuildEditFormFromRow(rowInfo)
			Dim res As DialogResult = form.ShowDialog()
		End Sub

		Private Sub rrbCars_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles rrbCars.ToggleStateChanged
			If Me.rrbCars.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radGridView1.Columns.Clear()
				Me.radGridView1.DataSource = carsBindingSource

                AddCommandColumn()
			End If
		End Sub

		Private Sub rrbCategories_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles rrbCategories.ToggleStateChanged
			If Me.rrbCategories.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radGridView1.Columns.Clear()
				Me.radGridView1.DataSource = categoriesBindingSource

				AddCommandColumn()
			End If
		End Sub

		Private Sub rrbCustomers_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles rrbCustomers.ToggleStateChanged
			If Me.rrbCustomers.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radGridView1.Columns.Clear()
				Me.radGridView1.DataSource = customerBindingSource

				AddCommandColumn()
			End If
		End Sub

		Private Sub rrbEmployees_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles rrbEmployees.ToggleStateChanged
			If Me.rrbEmployees.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
				Me.radGridView1.Columns.Clear()
				Me.radGridView1.DataSource = employeesBindingSource

				AddCommandColumn()
			End If
        End Sub

        Private Sub AddCommandColumn()
            Dim command As New GridViewCommandColumn()
            command.HeaderText = "Edit data"
            command.UseDefaultText = True
            command.DefaultText = "Edit"
            command.TextAlignment = ContentAlignment.MiddleCenter
            Me.radGridView1.Columns.Add(command)

            Me.radGridView1.MasterTemplate.BestFitColumns()
        End Sub
	End Class
End Namespace