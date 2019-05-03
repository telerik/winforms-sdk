Imports System
Imports System.Data
Imports System.Windows.Forms
Imports Telerik.WinControls.Export
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export

Namespace SplashFormExportExample
	Partial Public Class Form1
		Inherits System.Windows.Forms.Form

		Public Sub New()
			InitializeComponent()

			Me.radGridView1.DataSource = Me.GetData()
			Me.radGridView1.DataMember = "Table1"
		End Sub

		Private Sub radButtonExportToPDF_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButtonExportToPDF.Click
			Dim saveFileDialog As New SaveFileDialog()
			saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf"
			If saveFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				Dim fileName As String = saveFileDialog.FileName

				fileName = fileName.Substring(0, fileName.Length - 4) & Date.Now.Minute + Date.Now.Second & ".xlsx"
				Me.NewSpreadExport(fileName)
			End If
		End Sub

		Private Sub NewSpreadExport(ByVal fileName As String)

			SplashForm.ShowForm(Me)

			Dim spreadExporter As New GridViewSpreadExport(Me.radGridView1)
			spreadExporter.ExportVisualSettings = True
			spreadExporter.ExportFormat = SpreadExportFormat.Xlsx
			spreadExporter.HiddenColumnOption = HiddenOption.DoNotExport
			Dim exportRenderer As New SpreadExportRenderer()
			AddHandler exportRenderer.WorkbookCreated, AddressOf exportRenderer_WorkbookCreated
			spreadExporter.RunExport(fileName, exportRenderer)
		End Sub

		Private Sub exportRenderer_WorkbookCreated(ByVal sender As Object, ByVal e As WorkbookCreatedEventArgs)
			SplashForm.CloseForm()
		End Sub

		Private Function GetData() As DataSet
			Dim ds As New DataSet()
			Dim table As New DataTable()
			table.Columns.Add("First Name", GetType(String))
			table.Columns.Add("Last Name", GetType(String))
			table.Columns.Add("+R/S", GetType(Double))
			table.Columns.Add("Job", GetType(String))
			table.Columns.Add("Category", GetType(String))
			table.Columns.Add("Birth Date", GetType(Date))

			For i As Integer = 0 To 999
				table.Rows.Add("Carey", "Payette", 25.5, "Carey", "Payette", Date.Now.AddDays(-2537))
				table.Rows.Add("Michael", "Crump", 33333, "Michael", "Crump", Date.Now.AddDays(-1545))
				table.Rows.Add("Jeff", "Fritz", 98.76543, "Jeff", "Fritz", Date.Now.AddDays(12))
				table.Rows.Add("Phil", "Japikse", 1500.0, "Phil", "Japikse", Date.Now.AddDays(-68))
				table.Rows.Add("Jesse", "Liberty", 99.99, "Jesse", "Liberty", Date.Now.AddDays(1))
				table.Rows.Add("Iris", "Classon", 12345.6, "Iris", "Classon", Date.Now)
			Next i

			ds.Tables.Add(table)

			Return ds
		End Function
	End Class
End Namespace
