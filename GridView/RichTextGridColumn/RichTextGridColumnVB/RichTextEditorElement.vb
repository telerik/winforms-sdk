Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class RichTextEditorElement
    Inherits RadHostItem

    Public Sub New()
        MyBase.New(New RadRichTextEditor())
        RouteMessages = False
        AddHandler Me.HostedControl.GotFocus, New EventHandler(AddressOf HostedControl_GotFocus)
        AddHandler Me.HostedControl.KeyDown, New KeyEventHandler(AddressOf HostedControl_KeyDown)
    End Sub

    Private Sub HostedControl_GotFocus(ByVal sender As Object, ByVal e As EventArgs)
        Dim cell As RichTextEditorCellElement = TryCast(Me.Parent, RichTextEditorCellElement)

        If cell IsNot Nothing Then
            cell.ColumnInfo.IsCurrent = True
            cell.RowInfo.IsCurrent = True
            cell.GridViewElement.BeginEdit()
        End If
    End Sub

    Private Sub HostedControl_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.Control AndAlso e.KeyCode = Keys.Enter Then
            Dim grid As RadGridView = TryCast(Me.ElementTree.Control, RadGridView)
            grid.EndEdit()
        End If
    End Sub
End Class