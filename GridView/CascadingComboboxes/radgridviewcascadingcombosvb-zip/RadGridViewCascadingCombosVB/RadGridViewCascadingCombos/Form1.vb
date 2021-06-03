Imports System.ComponentModel
Imports Telerik.WinControls.UI

Public Class Form1
    Dim fullList As BindingList(Of Food)
    Dim fruitsList As BindingList(Of Food)
    Dim vegetablesList As BindingList(Of Food)

    Public Sub New()
        InitializeComponent()

        Me.RadGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill

        fullList = New BindingList(Of Food)()
        fullList.Add(New Food(0, "Onion"))
        fullList.Add(New Food(1, "Cucumber"))
        fullList.Add(New Food(2, "Tomato"))
        fullList.Add(New Food(3, "Peach"))
        fullList.Add(New Food(4, "Banana"))
        fullList.Add(New Food(5, "Grape"))

        fruitsList = New BindingList(Of Food)()
        fruitsList.Add(fullList(3))
        fruitsList.Add(fullList(4))
        fruitsList.Add(fullList(5))

        vegetablesList = New BindingList(Of Food)()
        vegetablesList.Add(fullList(0))
        vegetablesList.Add(fullList(1))
        vegetablesList.Add(fullList(2))

        Dim typesList As New BindingList(Of FoodType)()
        typesList.Add(New FoodType(0, "Vegetables"))
        typesList.Add(New FoodType(1, "Fruits"))

        Dim foodType As New GridViewComboBoxColumn()
        foodType.FieldName = "FoodType"
        Me.RadGridView1.Columns.Add(foodType)
        foodType.DataSource = typesList
        foodType.Width = 100
        foodType.DisplayMember = "FoodTypeName"
        foodType.ValueMember = "FoodTypeID"

        Dim food As New GridViewComboBoxColumn()
        food.FieldName = "Food"
        Me.RadGridView1.Columns.Add(food)
        food.DataSource = fullList
        food.Width = 100
        food.DisplayMember = "FoodName"
        food.ValueMember = "FoodID"

        Me.RadGridView1.Rows.Add(New Object() {0, 1})
        Me.RadGridView1.Rows.Add(New Object() {1, 4})
        Me.RadGridView1.Rows.Add(New Object() {1, 3})
        Me.RadGridView1.Rows.Add(New Object() {0, 0})
        Me.RadGridView1.Rows.Add(New Object() {0, 2})
        Me.RadGridView1.Rows.Add(New Object() {0, 1})
        Me.RadGridView1.Rows.Add(New Object() {1, 4})
        Me.RadGridView1.Rows.Add(New Object() {1, 3})
        Me.RadGridView1.Rows.Add(New Object() {0, 0})
        Me.RadGridView1.Rows.Add(New Object() {0, 2})
        Me.RadGridView1.Rows.Add(New Object() {0, 1})
        Me.RadGridView1.Rows.Add(New Object() {1, 4})
        Me.RadGridView1.Rows.Add(New Object() {1, 3})
        Me.RadGridView1.Rows.Add(New Object() {0, 0})
        Me.RadGridView1.Rows.Add(New Object() {0, 2})

    End Sub

    Private Sub RadGridView1_CellEditorInitialized(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles RadGridView1.CellEditorInitialized
        If e.Column.HeaderText = "Food" Then
            If Me.RadGridView1.CurrentRow.Cells("FoodType").Value IsNot DBNull.Value AndAlso Me.RadGridView1.CurrentRow.Cells("FoodType").Value IsNot Nothing Then
                Dim editor As RadDropDownListEditor = DirectCast(Me.RadGridView1.ActiveEditor, RadDropDownListEditor)
                Dim editorElement As RadDropDownListEditorElement = DirectCast(editor.EditorElement, RadDropDownListEditorElement)
                If Integer.Parse(Me.RadGridView1.CurrentRow.Cells("FoodType").Value.ToString()) = 0 Then
                    editorElement.DataSource = vegetablesList
                Else
                    editorElement.DataSource = fruitsList
                End If
                editorElement.SelectedValue = Nothing
                editorElement.SelectedValue = Me.RadGridView1.CurrentCell.Value
            End If
        End If

    End Sub

    Private Sub RadGridView1_CellValueChanged(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles RadGridView1.CellValueChanged
        If e.Column.HeaderText = "FoodType" Then
            e.Row.Cells("Food").Value = Nothing
        End If
    End Sub
End Class

Public Class FoodType
    Private m_foodTypeID As Integer
    Private foodType As String

    Public Sub New(ByVal foodTypeID As Integer, ByVal foodType__1 As String)
        Me.m_foodTypeID = foodTypeID
        Me.foodType = foodType__1
    End Sub

    Public Property FoodTypeID() As Integer
        Get
            Return m_foodTypeID
        End Get
        Set(ByVal value As Integer)
            m_foodTypeID = value
        End Set
    End Property

    Public Property FoodTypeName() As String
        Get
            Return foodType
        End Get
        Set(ByVal value As String)
            foodType = value
        End Set
    End Property
End Class

Public Class Food
    Private m_foodID As Integer
    Private m_foodName As String

    Public Sub New(ByVal foodID As Integer, ByVal foodName As String)
        Me.m_foodID = foodID
        Me.m_foodName = foodName
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
            Return m_foodName
        End Get
        Set(ByVal value As String)
            m_foodName = value
        End Set
    End Property
End Class

