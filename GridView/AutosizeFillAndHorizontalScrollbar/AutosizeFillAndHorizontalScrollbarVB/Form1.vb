Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace MixedSelfGrid
	Public Partial Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load


			Dim people As DataTable = New DataTable("people")
			people.Columns.Add("ID", GetType(Integer))
			people.Columns.Add("Title", GetType(String))
			people.Columns.Add("FirstName", GetType(String))
			people.Columns.Add("LastName", GetType(String))
			people.Columns.Add("Address", GetType(String))
			people.Columns.Add("City", GetType(String))
			people.Columns.Add("State", GetType(String))
			people.Columns.Add("ZIP", GetType(String))


			people.Rows.Add(0, "CEO - Chief executive officer", "John", "Doe", "1 Red Street", "Boston", "Massachusetts", "01234")
			people.Rows.Add(0, "CFO - Chief financial officer", "Mario", "Rossi", "1 Black Street", "Boston", "Massachusetts", "01234")
			people.Rows.Add(0, "VP - Vice president", "Carlo", "Bianchi", "1 Green Street", "Miami", "Florida", "54321")

			Me.radGridView1.DataSource = people

			Me.radGridView1.Columns("ID").MinWidth = 70
			Me.radGridView1.Columns("ID").MaxWidth = 70
			Me.radGridView1.Columns("ID").Width = 70

			Me.radGridView1.Columns("Title").MinWidth = 100
			' Set the column that has to fill the rest of the space to the full grid Width
			Me.radGridView1.Columns("Title").Width = Me.radGridView1.Width

			Me.radGridView1.Columns("FirstName").MinWidth = 200
			Me.radGridView1.Columns("FirstName").MaxWidth = 200
			Me.radGridView1.Columns("FirstName").Width = 200

			Me.radGridView1.Columns("LastName").MinWidth = 200
			Me.radGridView1.Columns("LastName").MaxWidth = 200
			Me.radGridView1.Columns("LastName").Width = 200

			Me.radGridView1.Columns("Address").MinWidth = 200
			Me.radGridView1.Columns("Address").MaxWidth = 200
			Me.radGridView1.Columns("Address").Width = 200

			Me.radGridView1.Columns("City").MinWidth = 200
			Me.radGridView1.Columns("City").MaxWidth = 200
			Me.radGridView1.Columns("City").Width = 200

			Me.radGridView1.Columns("State").MinWidth = 70
			Me.radGridView1.Columns("State").MaxWidth = 70
			Me.radGridView1.Columns("State").Width = 70

			Me.radGridView1.Columns("ZIP").MinWidth = 50
			Me.radGridView1.Columns("ZIP").MaxWidth = 50
			Me.radGridView1.Columns("ZIP").Width = 50

			Me.radGridView1.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
		End Sub

		Private Sub radGridView1_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radGridView1.SizeChanged
			If (CType(sender, RadGridView)).MasterTemplate.Columns.Count > 0 Then
				Dim columnsWidth As Integer = 0
				Dim index As Integer = 0
				Do While index < (CType(sender, RadGridView)).MasterTemplate.Columns.Count
					If (CType(sender, RadGridView)).Columns(index).IsVisible Then
						columnsWidth += (CType(sender, RadGridView)).Columns(index).Width
					End If
					index += 1
				Loop
				Dim gridWidth As Integer = (CType(sender, RadGridView)).Width
				If columnsWidth > gridWidth Then
					CType(sender, RadGridView).MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.None
				Else
					CType(sender, RadGridView).MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
				End If
			End If

		End Sub

	End Class
End Namespace
