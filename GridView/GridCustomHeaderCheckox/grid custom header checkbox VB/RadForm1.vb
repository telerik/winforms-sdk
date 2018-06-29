Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls.UI

Namespace _1171173
	Partial Public Class RadForm1
		Inherits Telerik.WinControls.UI.RadForm

		Public Sub New()
			InitializeComponent()

			radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
			radGridView1.DataSource = GetTable()
			radGridView1.EnableFiltering = True


		End Sub



		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			Dim col = New CustomColumn("Bool")
			radGridView1.Columns.RemoveAt(0)
			radGridView1.Columns.Insert(0, col)

		End Sub
		Private Shared Function GetTable() As DataTable

			Dim table As New DataTable()
			table.Columns.Add("Bool", GetType(Boolean))
			table.Columns.Add("Drug", GetType(String))
			table.Columns.Add("Name", GetType(String))
			table.Columns.Add("Date", GetType(Date))

			For i As Integer = 0 To 9
				table.Rows.Add(False, "Indocin", "David", Date.Now)
				table.Rows.Add(False, "Enebrel", "Sam", Date.Now)
				table.Rows.Add(False, "Hydralazine", "Christoff", Date.Now)
				table.Rows.Add(False, "Combivent", "Janet", Date.Now)
				table.Rows.Add(False, "Dilantin", "Melanie", Date.Now)
			Next i
			Return table
		End Function
	End Class
End Namespace
