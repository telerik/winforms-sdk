Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls.UI

Namespace _1164656
	Partial Public Class RadForm1
		Inherits Telerik.WinControls.UI.RadForm

		Public Sub New()
			InitializeComponent()
			Call (New Telerik.WinControls.RadControlSpy.RadControlSpyForm()).Show()

			radGridView1.DataSource = GetTable()

			Dim comboColumn = New MyDDLColumn()
			comboColumn.Name = "Name1"
			comboColumn.HeaderText = "Name1"
			comboColumn.DataSource = GetTable()
			comboColumn.ValueMember = "Name"
			comboColumn.DisplayMember = "Name"
			comboColumn.FieldName = "Name"
			comboColumn.Width = 200
			Me.radGridView1.Columns.Add(comboColumn)

			radGridView1.DataSource = GetTable()


			AddHandler radGridView1.EditorRequired, AddressOf RadGridView1_EditorRequired
			AddHandler radGridView1.CellValueChanged, AddressOf RadGridView1_CellValueChanged
		End Sub

		Private Sub RadGridView1_CellValueChanged(ByVal sender As Object, ByVal e As GridViewCellEventArgs)

		End Sub

		Private Sub RadGridView1_EditorRequired(ByVal sender As Object, ByVal e As EditorRequiredEventArgs)
			If e.EditorType Is GetType(RadDropDownListEditor) Then
				e.EditorType = GetType(MyRadDropDownListEditor)
			End If
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
	Friend Class MyRadDropDownListEditor
		Inherits RadDropDownListEditor

		Public Overrides Property Value() As Object
			Get
				Dim result = MyBase.Value
				If result Is Nothing OrElse String.IsNullOrEmpty(result.ToString()) Then
					Dim editor = TryCast(Me.EditorElement, RadDropDownListElement)
					Return editor.Text
				End If
				Return result
			End Get

			Set(ByVal value As Object)
				MyBase.Value = value
				Dim editor = TryCast(Me.EditorElement, RadDropDownListElement)
				If editor.SelectedValue Is Nothing Then
					editor.TextBox.TextBoxItem.Text = value.ToString()
				End If
			End Set
		End Property
		Public Overrides Sub BeginEdit()
			MyBase.BeginEdit()
			Dim editor = TryCast(Me.EditorElement, RadDropDownListElement)
			editor.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDown
		End Sub
	End Class
	Friend Class MyDDLColumn
		Inherits GridViewComboBoxColumn

		Public Overrides Function GetLookupValue(ByVal cellValue As Object) As Object
			Dim result = MyBase.GetLookupValue(cellValue)
			If result Is Nothing Then
				Return cellValue
			End If
			Return result

		End Function

	End Class
End Namespace