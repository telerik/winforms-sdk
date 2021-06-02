Imports Microsoft.Ink
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls.UI

Namespace InkEditor
	Partial Public Class RadForm1
		Inherits Form

		Public Sub New()
			InitializeComponent()



			radGridView1.Columns.Add(New GridViewTextBoxColumn() With {.Name = "InkColumn"})
			radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
			radGridView1.EnableGrouping = False
			radGridView1.AllowAddNewRow = False

			For i As Integer = 0 To 9
				radGridView1.Rows.Add("Row Index" & i)

			Next i
			radGridView1.Font = New Font("Segoe UI", 16, FontStyle.Regular)
			radGridView1.TableElement.RowHeight = 50
			AddHandler radGridView1.EditorRequired, AddressOf RadGridView1_EditorRequired
		End Sub

		Private Sub RadGridView1_EditorRequired(ByVal sender As Object, ByVal e As EditorRequiredEventArgs)
			If radGridView1.CurrentColumn.Name = "InkColumn" Then
				e.EditorType = GetType(GridInkEditor)
			End If
		End Sub
	End Class
End Namespace
