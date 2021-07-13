Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim table As DataTable = New DataTable()
        table.Columns.Add("ID", GetType(Integer))
        table.Columns.Add("Name", GetType(String))
        table.Columns.Add("Value", GetType(Integer))
        Dim r As Random = New Random()
        For i As Integer = 0 To 9
            table.Rows.Add(i, "Row " & i, r.Next(3))
        Next i
        Me.RadGridView1.DataSource = table

        Dim items As List(Of Item) = New List(Of Item)()
        items.Add(New Item(0, "Zero"))
        items.Add(New Item(1, "One"))
        items.Add(New Item(2, "Two"))
        items.Add(New Item(3, "Three"))

        Dim combo As GridViewComboBoxColumn = New GridViewComboBoxColumn()
        combo.Name = "CustomColumn"
        combo.FieldName = "Value"
        combo.DataSource = items
        combo.DisplayMember = "Name"
        combo.ValueMember = "Id"
        Me.RadGridView1.Columns.Add(combo)

        AddHandler RadGridView1.CreateCell, AddressOf radGridView1_CreateCell
        AddHandler RadGridView1.CellBeginEdit, AddressOf radGridView1_CellBeginEdit
        AddHandler RadGridView1.CellEndEdit, AddressOf radGridView1_CellEndEdit
        Me.RadGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub radGridView1_CreateCell(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.GridViewCreateCellEventArgs)
        If TypeOf e.Row Is GridDataRowElement Then
            If e.Column.Name = "CustomColumn" Then
                e.CellType = GetType(CustomInfoCell)
            End If
        End If
    End Sub

    Private _font As Font = New Font("Arial", 9.0F, FontStyle.Bold)
    Private Sub radGridView1_CellBeginEdit(ByVal sender As Object, ByVal e As GridViewCellCancelEventArgs)
        If e.Column.Name = "CustomColumn" Then
            Dim buttonElement As RadButtonElement = New RadButtonElement()
            buttonElement.Font = _font
            buttonElement.Text = "..."
            AddHandler buttonElement.Click, AddressOf buttonElement_Click
            Me.RadGridView1.CurrentCell.Children.Add(buttonElement)
        End If
    End Sub

    Private Sub buttonElement_Click(ByVal sender As Object, ByVal e As EventArgs)
        MessageBox.Show(Me.RadGridView1.CurrentRow.Cells(1).Value.ToString())
    End Sub

    Private Sub radGridView1_CellEndEdit(ByVal sender As Object, ByVal e As GridViewCellEventArgs)
        If e.Column.Name = "CustomColumn" Then
            If Me.RadGridView1.CurrentCell.Children.Count = 1 Then
                Me.RadGridView1.CurrentCell.Children.RemoveAt(0)
            End If
        End If
    End Sub

    Public Class Item
        Private id_Renamed As Integer
        Private name_Renamed As String

        Public Sub New()
        End Sub

        Public Sub New(ByVal id_Renamed As Integer, ByVal name_Renamed As String)
            Me.id_Renamed = id_Renamed
            Me.name_Renamed = name_Renamed
        End Sub

        Public Property Id() As Integer
            Get
                Return id_Renamed
            End Get
            Set(ByVal value As Integer)
                id_Renamed = Value
            End Set
        End Property

        Public Property Name() As String
            Get
                Return name_Renamed
            End Get
            Set(ByVal value As String)
                name_Renamed = Value
            End Set
        End Property
    End Class
End Class
