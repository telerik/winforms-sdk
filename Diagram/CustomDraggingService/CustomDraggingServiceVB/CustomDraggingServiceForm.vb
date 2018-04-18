Imports Telerik.Windows.Diagrams.Core

#Region "InitialSetup"
Public Class CustomDraggingServiceForm

    Dim dragService As CustomDraggingService

    Sub New()

        InitializeComponent()

        Me.dragService = New CustomDraggingService(Me.RadDiagram1.DiagramElement) With {.DragMode = DragMode.Horizontal}
        Me.RadDiagram1.DiagramElement.ServiceLocator.Register(Of IDraggingService)(Me.dragService)

    End Sub
    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Me.dragService.DragMode = If(Me.dragService.DragMode = DragMode.Horizontal, DragMode.Vertical, DragMode.Horizontal)
    End Sub
End Class

#End Region