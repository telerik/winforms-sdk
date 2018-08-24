Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls

Namespace ScalingZoom
	Partial Public Class RadForm1
		Inherits Telerik.WinControls.UI.RadForm

		Private factors As New Dictionary(Of String, SizeF)()
		Public Sub New()
			InitializeComponent()
			radGridView1.DataSource = GetTable()

			factors.Add("100%", New SizeF(1, 1))
			factors.Add("125%", New SizeF(1.25F, 1.25F))
			factors.Add("150%", New SizeF(1.5F, 1.5F))
			factors.Add("200%", New SizeF(2, 2))

			radDropDownList1.DisplayMember = "Key"
			radDropDownList1.ValueMember = "Value"
			radDropDownList1.DataSource = factors
			radDropDownList1.DropDownStyle = RadDropDownStyle.DropDownList
			AddHandler radDropDownList1.SelectedIndexChanged, AddressOf RadDropDownList1_SelectedIndexChanged
		End Sub


		Private Sub RadDropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)

			Dim currentScale = Me.RootElement.DpiScaleFactor
			Dim newFactor = DirectCast(radDropDownList1.SelectedValue, SizeF)
			newFactor = New SizeF(newFactor.Width * (1F / currentScale.Width), newFactor.Height * (1F / currentScale.Height))

			If newFactor.Width < 1F Then
				Me.Size = New Size(CInt(Me.Width * newFactor.Width), CInt(Me.Height * newFactor.Height))
			End If

			Me.Scale(newFactor)

		End Sub
		Private Shared Function GetTable() As DataTable

			Dim table As New DataTable()
			table.Columns.Add("Dosage", GetType(Integer))
			table.Columns.Add("Drug", GetType(String))
			table.Columns.Add("Name", GetType(String))
			table.Columns.Add("Date", GetType(Date))


			table.Rows.Add(25, "Indocin", "David", Date.Now)
			table.Rows.Add(50, "Enebrel", "Sam", Date.Now)
			table.Rows.Add(10, "Hydralazine", "Christoff", Date.Now)
			table.Rows.Add(21, "Combivent", "Janet", Date.Now)
			table.Rows.Add(100, "Dilantin", "Melanie", Date.Now)
			Return table
		End Function
	End Class
End Namespace
