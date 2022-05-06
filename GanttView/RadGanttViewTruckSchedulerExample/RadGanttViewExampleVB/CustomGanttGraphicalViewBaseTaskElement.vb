Imports Telerik.WinControls.UI

Public Class CustomGanttGraphicalViewBaseTaskElement
    Inherits GanttGraphicalViewBaseTaskElement

    Private rnd As Random = New Random()
    Private drivingToPickUpLocationElement As DrivingToPickUpLocationElement
    Private loadingElement As LoadingElement
    Private drivingElement As DrivingElement
    Private driverRestElement As DriverRestElement
    Private waitingElement As WaitingElement
    Private unloadingElement As UnloadingElement
    Private borderElement As LightVisualElement

    Protected Overrides Sub InitializeFields()
        MyBase.InitializeFields()
        Me.TextAlignment = ContentAlignment.MiddleLeft
        Me.DrawFill = True
        Me.GradientStyle = Telerik.WinControls.GradientStyles.Solid
        Me.BackColor = Color.LightGray
        Me.DrawBorder = True
        Me.BorderGradientStyle = Telerik.WinControls.GradientStyles.Solid
        Me.BorderColor = Color.Black
    End Sub

    Protected Overrides Sub CreateChildElements()
        MyBase.CreateChildElements()
        Me.drivingToPickUpLocationElement = New DrivingToPickUpLocationElement()
        Me.drivingToPickUpLocationElement.DrawFill = True
        Me.drivingToPickUpLocationElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid
        Me.drivingToPickUpLocationElement.BackColor = Color.LightBlue
        Me.loadingElement = New LoadingElement()
        Me.loadingElement.DrawFill = True
        Me.loadingElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid
        Me.loadingElement.BackColor = Color.DarkBlue
        Me.drivingElement = New DrivingElement()
        Me.drivingElement.DrawFill = True
        Me.drivingElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid
        Me.drivingElement.BackColor = Color.Green
        Me.driverRestElement = New DriverRestElement()
        Me.driverRestElement.DrawFill = True
        Me.driverRestElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid
        Me.driverRestElement.BackColor = Color.SlateGray
        Me.waitingElement = New WaitingElement()
        Me.waitingElement.DrawFill = True
        Me.waitingElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid
        Me.waitingElement.BackColor = Color.Gold
        Me.unloadingElement = New UnloadingElement()
        Me.unloadingElement.DrawFill = True
        Me.unloadingElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid
        Me.unloadingElement.BackColor = Color.RosyBrown
        Me.borderElement = New LightVisualElement()
        Me.borderElement.DrawBorder = True
        Me.borderElement.BorderGradientStyle = Telerik.WinControls.GradientStyles.Solid
        Me.borderElement.BorderColor = Color.Black
        Me.borderElement.ShouldHandleMouseInput = False
        Me.borderElement.NotifyParentOnMouseInput = True
        Me.Children.Add(Me.drivingToPickUpLocationElement)
        Me.Children.Add(Me.loadingElement)
        Me.Children.Add(Me.drivingElement)
        Me.Children.Add(Me.driverRestElement)
        Me.Children.Add(Me.waitingElement)
        Me.Children.Add(Me.unloadingElement)
        Me.Children.Add(Me.borderElement)
    End Sub

    Protected Overrides Sub PaintElement(ByVal graphics As Telerik.WinControls.Paint.IGraphics, ByVal angle As Single, ByVal scale As SizeF)
        MyBase.PaintElement(graphics, angle, scale)
        Dim points As PointF() = New PointF(3) {}
        points(0) = New PointF(Me.loadingElement.BoundingRectangle.X, Me.Size.Height - 1)
        points(1) = New PointF(Me.loadingElement.BoundingRectangle.Right, Me.Size.Height * 0.35F)
        points(2) = New PointF(Me.unloadingElement.BoundingRectangle.X, Me.Size.Height * 0.35F)
        points(3) = New PointF(Me.unloadingElement.BoundingRectangle.Right, Me.Size.Height - 1)
        graphics.ChangeSmoothingMode(System.Drawing.Drawing2D.SmoothingMode.AntiAlias)
        graphics.FillPolygon(Color.FromArgb(100, Color.Gray), points)
        graphics.RestoreSmoothingMode()
    End Sub

    Protected Overrides Function ArrangeOverride(ByVal finalSize As SizeF) As SizeF
        Dim itemElement As CustomGanttViewTaskItemElement = CType(Me.Parent, CustomGanttViewTaskItemElement)
        Dim boundItem As DataRowView = TryCast(itemElement.Data.DataBoundItem, DataRowView)
        Dim graphicalView As GanttViewGraphicalViewElement = itemElement.GraphicalViewElement
        Dim availableSize As SizeF = MyBase.ArrangeOverride(finalSize)
        Dim clientRect As RectangleF = New RectangleF(PointF.Empty, availableSize)
        Dim arrangeRect As RectangleF = New RectangleF(clientRect.X, clientRect.Y, 0, clientRect.Height * 0.3F)
        Dim arrangeRectWidth As Single = graphicalView.GetDrawRectangle(itemElement.Data, itemElement.Data.Start, itemElement.Data.Start.Add(CType(boundItem("DrivingToPickUpLocation"), TimeSpan))).Width
        arrangeRect.Width = arrangeRectWidth
        Me.drivingToPickUpLocationElement.Arrange(arrangeRect)
        arrangeRect.X += arrangeRectWidth
        arrangeRectWidth = graphicalView.GetDrawRectangle(itemElement.Data, itemElement.Data.Start, itemElement.Data.Start.Add(CType(boundItem("Loading"), TimeSpan))).Width
        arrangeRect.Width = arrangeRectWidth
        Me.loadingElement.Arrange(arrangeRect)
        arrangeRect.X += arrangeRectWidth
        arrangeRectWidth = graphicalView.GetDrawRectangle(itemElement.Data, itemElement.Data.Start, itemElement.Data.Start.Add(CType(boundItem("Driving"), TimeSpan))).Width
        arrangeRect.Width = arrangeRectWidth
        Me.drivingElement.Arrange(arrangeRect)
        arrangeRect.X += arrangeRectWidth
        arrangeRectWidth = graphicalView.GetDrawRectangle(itemElement.Data, itemElement.Data.Start, itemElement.Data.Start.Add(CType(boundItem("DriverRest"), TimeSpan))).Width
        arrangeRect.Width = arrangeRectWidth
        Me.driverRestElement.Arrange(arrangeRect)
        arrangeRect.X += arrangeRectWidth
        arrangeRectWidth = graphicalView.GetDrawRectangle(itemElement.Data, itemElement.Data.Start, itemElement.Data.Start.Add(CType(boundItem("Waiting"), TimeSpan))).Width
        arrangeRect.Width = arrangeRectWidth
        Me.waitingElement.Arrange(arrangeRect)
        arrangeRect.X += arrangeRectWidth
        arrangeRectWidth = graphicalView.GetDrawRectangle(itemElement.Data, itemElement.Data.Start, itemElement.Data.Start.Add(CType(boundItem("Unloading"), TimeSpan))).Width
        arrangeRect.Width = arrangeRectWidth
        Me.unloadingElement.Arrange(arrangeRect)
        arrangeRect.X = clientRect.X
        arrangeRect.Width = clientRect.Width
        Me.borderElement.Arrange(arrangeRect)
        Return availableSize
    End Function
End Class

Public Class DrivingToPickUpLocationElement
    Inherits LightVisualElement
End Class

Public Class LoadingElement
    Inherits LightVisualElement
End Class

Public Class DrivingElement
    Inherits LightVisualElement
End Class

Public Class DriverRestElement
    Inherits LightVisualElement
End Class

Public Class WaitingElement
    Inherits LightVisualElement
End Class

Public Class UnloadingElement
    Inherits LightVisualElement
End Class