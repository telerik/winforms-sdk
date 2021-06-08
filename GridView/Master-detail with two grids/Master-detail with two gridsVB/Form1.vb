Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls.UI

Namespace Master_detail_with_two_grids
	Public Partial Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()

			radGridView1.Columns("Picture").IsVisible = False
			AddHandler radGridView1.CurrentRowChanged, AddressOf radGridView1_CurrentRowChanged

		End Sub

		Private Sub radGridView1_CurrentRowChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.CurrentRowChangedEventArgs)
			If Not e.CurrentRow Is Nothing AndAlso TypeOf e.CurrentRow Is GridViewDataRowInfo Then
				Me.radGridView2.DataSource = (CType((CType(e.CurrentRow.DataBoundItem, DataRowView)).Row, NwindDataSet.CategoriesRow)).GetProductsRows()

				radGridView2.Columns("CategoriesRow").IsVisible = False
				radGridView2.Columns("RowError").IsVisible = False
				radGridView2.Columns("RowState").IsVisible = False
				radGridView2.Columns("Table").IsVisible = False
				radGridView2.Columns("ItemArray").IsVisible = False
				radGridView2.Columns("HasErrors").IsVisible = False

				radGridView1.BestFitColumns()
				radGridView2.BestFitColumns()
			End If
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindDataSet.Products' table. You can move, or remove it, as needed.
			Me.productsTableAdapter.Fill(Me.nwindDataSet.Products)
			' TODO: This line of code loads data into the 'nwindDataSet.Categories' table. You can move, or remove it, as needed.
			Me.categoriesTableAdapter.Fill(Me.nwindDataSet.Categories)
		End Sub
	End Class
End Namespace
