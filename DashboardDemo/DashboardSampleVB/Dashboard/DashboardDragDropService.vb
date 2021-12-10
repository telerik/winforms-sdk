Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class DashboardDragDropService
    Inherits RadDragDropService

    Protected Overrides Sub OnPreviewDragOver(ByVal e As RadDragOverEventArgs)
        MyBase.OnPreviewDragOver(e)
        Dim dropTarget As StackLayoutElement = TryCast(e.HitTarget, StackLayoutElement)
        Dim draggedObject As TaskElement = TryCast(e.DragInstance, TaskElement)

        If draggedObject IsNot Nothing AndAlso dropTarget IsNot Nothing AndAlso Not dropTarget.Equals(draggedObject.Parent) Then
            e.CanDrop = True
        End If
    End Sub

    Protected Overrides Sub OnPreviewDragDrop(ByVal e As RadDropEventArgs)
        Dim dropTarget As StackLayoutElement = TryCast(e.HitTarget, StackLayoutElement)
        Dim draggedObject As TaskElement = TryCast(e.DragInstance, TaskElement)

        If draggedObject IsNot Nothing AndAlso dropTarget IsNot Nothing Then
            draggedObject.Parent.Children.Remove(draggedObject)
            dropTarget.Children.Add(draggedObject)
        End If

        MyBase.OnPreviewDragDrop(e)
    End Sub
End Class