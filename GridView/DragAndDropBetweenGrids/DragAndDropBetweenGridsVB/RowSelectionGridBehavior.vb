Imports Telerik.WinControls.UI

Public Class RowSelectionGridBehavior
    Inherits GridDataRowBehavior
    Protected Overrides Function OnMouseDownLeft(ByVal e As MouseEventArgs) As Boolean
        Dim row As GridDataRowElement = TryCast(Me.GetRowAtPoint(e.Location), GridDataRowElement)
        If Not row Is Nothing Then
            Dim svc As RadGridViewDragDropService = Me.GridViewElement.GetService(Of RadGridViewDragDropService)()
            svc.AllowAutoScrollColumnsWhileDragging = False
            svc.AllowAutoScrollRowsWhileDragging = False
            svc.Start(row)
        End If
        Return MyBase.OnMouseDownLeft(e)
    End Function
End Class
