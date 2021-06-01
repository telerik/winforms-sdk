Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls.UI

Namespace GridViewComboxColumnCustomValue
	Partial Public Class RadForm1
		Inherits Telerik.WinControls.UI.RadForm

		Private data As New List(Of Food)()

		Public Sub New()
			InitializeComponent()
			radGridView1.AutoGenerateColumns = False
			AddHandler radGridView1.EditorRequired, AddressOf radGridView1_EditorRequired
			AddHandler radGridView1.CreateCell, AddressOf radGridView1_CreateCell
			data.Add(New Food(0, "Onion"))
			data.Add(New Food(1, "Cucumber"))
			data.Add(New Food(2, "Tomato"))
			data.Add(New Food(3, "Peach"))
			data.Add(New Food(4, "Banana"))
			data.Add(New Food(5, "Grape"))

			Dim comboBoxColumn As New GridViewComboBoxColumn()
			comboBoxColumn.DataSource = data
			comboBoxColumn.DisplayMember = "FoodName"
			comboBoxColumn.ValueMember = "FoodName"
			comboBoxColumn.Width = 200
			comboBoxColumn.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDown
			radGridView1.Columns.Add(comboBoxColumn)

			radGridView1.Rows.Add("Onion")

			AddHandler radGridView1.CellValueChanged, AddressOf radGridView1_CellValueChanged
		End Sub

		Private Sub radGridView1_CreateCell(ByVal sender As Object, ByVal e As GridViewCreateCellEventArgs)
			If e.CellType Is GetType(GridComboBoxCellElement) Then
				e.CellElement = New MyCombBoxCellElement(TryCast(e.Column, GridViewDataColumn), e.Row)
			End If
		End Sub

		Private Sub radGridView1_CellValueChanged(ByVal sender As Object, ByVal e As GridViewCellEventArgs)
		End Sub

		Private Sub radGridView1_EditorRequired(ByVal sender As Object, ByVal e As EditorRequiredEventArgs)
			If e.EditorType Is GetType(RadDropDownListEditor) Then
				e.EditorType = GetType(MyRadDropDownListEditor)
			End If
		End Sub
	End Class

	Public Class MyRadDropDownListEditor
		Inherits RadDropDownListEditor

		Public Overrides Property Value() As Object
			Get
				Dim editor As RadDropDownListElement = TryCast(Me.EditorElement, RadDropDownListElement)
				If editor.SelectedItem IsNot Nothing Then
					If Not String.IsNullOrEmpty(editor.ValueMember) Then
						Return editor.SelectedItem.Value
					End If

					Return editor.SelectedItem.Text
				End If

				Return editor.Text
			End Get
			Set(ByVal value As Object)
				MyBase.Value = value
			End Set
		End Property
	End Class

	Public Class MyCombBoxCellElement
		Inherits GridComboBoxCellElement

		Public Sub New(ByVal col As GridViewColumn, ByVal row As GridRowElement)
			MyBase.New(col, row)
		End Sub

		Public Overrides Sub SetContent()

			SetContentCore(Me.Value)
		End Sub
	End Class

	Public Class Food
        Private m_foodID As Integer

        Private s_foodName As String

        Public Sub New(ByVal foodID As Integer, ByVal foodName As String)
            Me.m_foodID = foodID
            Me.s_foodName = foodName
        End Sub

        Public Property FoodID() As Integer
            Get
                Return m_foodID
            End Get
            Set(ByVal value As Integer)
                m_foodID = value
            End Set
        End Property

        Public Property FoodName() As String
            Get
                Return s_foodName
            End Get
            Set(ByVal value As String)
                s_foodName = value
            End Set
        End Property
	End Class
End Namespace