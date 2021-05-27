Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Xml
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Gauges
Imports Telerik.WinControls.XmlSerialization

Namespace UseGaugeAsElement
	Partial Public Class RadForm1
		Inherits Telerik.WinControls.UI.RadForm

		Public Sub New()
			InitializeComponent()
			AddHandler radGridView1.CreateCell, AddressOf RadGridView1_CreateCell
			radGridView1.DataSource = GetTable()

			Dim summaryItem As New GridViewSummaryItem()
			summaryItem.Name = "Dosage"
			summaryItem.Aggregate = GridAggregateFunction.Avg
			Dim summaryRowItem As New GridViewSummaryRowItem()
			summaryRowItem.Add(summaryItem)
			Me.radGridView1.SummaryRowsTop.Add(summaryRowItem)

			radGridView1.TableElement.RowHeight = 60
			radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
		End Sub

		Private Sub RadGridView1_CreateCell(ByVal sender As Object, ByVal e As GridViewCreateCellEventArgs)
			If e.CellType Is GetType(GridSummaryCellElement) AndAlso e.Column.Name = "Dosage" Then
				e.CellElement = New CustomSummaryCell(e.Column, e.Row)
			End If
		End Sub

		Private Shared Function GetTable() As DataTable

			Dim table As New DataTable()
			table.Columns.Add("Dosage", GetType(Integer))
			table.Columns.Add("Drug", GetType(String))
			table.Columns.Add("Name", GetType(String))
			table.Columns.Add("Date", GetType(Date))
			table.Columns.Add("Bool", GetType(Boolean))


			table.Rows.Add(25, "Indocin", "David", Date.Now.AddDays(-1), True)
			table.Rows.Add(50, "Enebrel", "Sam", Date.Now.AddDays(4), True)
			table.Rows.Add(10, "Hydralazine", "John", Date.Now.AddDays(2), True)
			table.Rows.Add(21, "Combivent", "Janet", Date.Now.AddDays(5), True)
			table.Rows.Add(100, "Dilantin", "Melanie", Date.Now.AddMonths(4), True)


			Return table
		End Function

	End Class
	Friend Class CustomSummaryCell
		Inherits GridSummaryCellElement

		Public Sub New(ByVal col As GridViewColumn, ByVal row As GridRowElement)
			MyBase.New(col, row)
		End Sub
		Private bullet1 As RadLinearGaugeElement
		Protected Overrides Sub CreateChildElements()
			MyBase.CreateChildElements()
			bullet1 = New RadLinearGaugeElement()
			bullet1.Padding = New Padding(5,3,7,3)
			Using sr As New StreamReader("..\..\BulletDefault1.xml")
				Dim ser = New ComponentXmlSerializer()
				Using textReader As New XmlTextReader(sr)
					ser.ReadObjectElement(textReader, bullet1)
				End Using
			End Using

			Me.Children.Add(bullet1)

		End Sub
		Public Overrides Sub SetContent()
			MyBase.SetContent()
			CType(Me.bullet1.Items(4), LinearGaugeNeedleIndicator).Value = Convert.ToSingle(Me.Value.ToString())
		End Sub
	End Class
End Namespace
