Imports Telerik.WinControls.UI

Public Class Form1

    Public Sub New()
        InitializeComponent()
        AddCheckColumn()

        Me.RadGridView1.MasterTemplate.AllowAddNewRow = False
        Me.RadGridView1.EnableFiltering = True

        AddHandler Me.RadGridView1.ViewCellFormatting, AddressOf radGridView1_ViewCellFormatting
    End Sub

    Private Sub radGridView1_ViewCellFormatting(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.CellFormattingEventArgs)
        If TypeOf e.CellElement Is Telerik.WinControls.UI.GridFilterCellElement AndAlso e.CellElement.ColumnIndex = 0 Then
            e.CellElement.Children.Clear()
        End If
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NwindDataSet.Order_Details' table. You can move, or remove it, as needed.
        Me.Order_DetailsTableAdapter.Fill(Me.NwindDataSet.Order_Details)
    End Sub

    Private Sub AddCheckColumn()
        Dim checkColumn As New CustomCheckBoxColumn()
        checkColumn.Name = "Select"
        checkColumn.HeaderText = "All"
        Me.RadGridView1.Columns.Insert(0, checkColumn)
    End Sub
End Class

Public Class CustomCheckBoxColumn
    Inherits GridViewCheckBoxColumn
    Public Overrides Function GetCellType(ByVal row As GridViewRowInfo) As Type
        If TypeOf row Is GridViewTableHeaderRowInfo Then
            Return GetType(CheckBoxHeaderCell)
        End If
        Return MyBase.GetCellType(row)
    End Function
End Class