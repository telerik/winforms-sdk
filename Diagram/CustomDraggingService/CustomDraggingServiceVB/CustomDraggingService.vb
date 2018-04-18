Imports Telerik.Windows.Diagrams.Core

#Region "CustomDraggingService"
Public Class CustomDraggingService
    Inherits DraggingService

    Private startDragPoint As Telerik.Windows.Diagrams.Core.Point

    Private _dragMode As DragMode = DragMode.Both

    Public Sub New(ByVal graph As IGraphInternal)
        MyBase.New(graph)
    End Sub

    Public Property DragMode As DragMode
        Get
            Return Me._dragMode
        End Get

        Set(ByVal value As DragMode)
            Me._dragMode = value
        End Set
    End Property

    Public Overrides Sub InitializeDrag(ByVal point As Telerik.Windows.Diagrams.Core.Point)
        Me.startDragPoint = point
        MyBase.InitializeDrag(point)
    End Sub

    Public Overrides Sub Drag(ByVal newPoint As Telerik.Windows.Diagrams.Core.Point)
        Dim dragPoint As Telerik.Windows.Diagrams.Core.Point = newPoint
        If Me.dragMode = dragMode.Horizontal Then
            dragPoint = New Telerik.Windows.Diagrams.Core.Point(newPoint.X, Me.startDragPoint.Y)
        ElseIf Me.dragMode = dragMode.Vertical Then
            dragPoint = New Telerik.Windows.Diagrams.Core.Point(Me.startDragPoint.X, newPoint.Y)
        End If

        MyBase.Drag(dragPoint)
    End Sub
End Class

Public Enum DragMode
    Both
    Horizontal
    Vertical
End Enum
#End Region
