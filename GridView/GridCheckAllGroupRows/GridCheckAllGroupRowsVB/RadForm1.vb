Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class RadForm1
    Sub New()

        InitializeComponent()

        ThemeResolutionService.ApplicationThemeName = "TelerikMetro"

        AddHandler Me.RadGridView1.CreateCell, AddressOf radGridView1_CreateCell
        AddHandler Me.RadGridView1.CellValueChanged, AddressOf radGridView1_CellValueChanged

    End Sub

    Private Sub radGridView1_CellValueChanged(sender As Object, e As GridViewCellEventArgs)
        If e.Column.Name = "Discontinued" Then
            Dim parentGroup As GridViewGroupRowInfo = TryCast(e.Row.Parent, GridViewGroupRowInfo)
            If parentGroup IsNot Nothing Then
                Dim atLeastOneOff As Boolean = False
                For Each row As GridViewRowInfo In parentGroup.ChildRows
                    If CBool(row.Cells("Discontinued").Value) = False Then
                        atLeastOneOff = True
                        Exit For
                    End If
                Next
                parentGroup.Tag = Not atLeastOneOff
            End If
        End If
    End Sub

    Private Sub radGridView1_CreateCell(sender As Object, e As Telerik.WinControls.UI.GridViewCreateCellEventArgs)
        If e.CellType Is GetType(GridGroupContentCellElement) Then
            e.CellElement = New CustomGridGroupContentCellElement(e.Column, e.Row)
        End If
    End Sub

    Private Sub RadForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NwindDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.NwindDataSet.Products)

    End Sub
End Class
