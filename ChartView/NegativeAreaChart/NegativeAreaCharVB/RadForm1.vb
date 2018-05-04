Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Linq
Imports System.Reflection
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.Charting
Imports Telerik.WinControls.Paint
Imports Telerik.WinControls.Primitives
Imports Telerik.WinControls.UI

Namespace _1066213
	Partial Public Class RadForm1
		Inherits Telerik.WinControls.UI.RadForm

		Private rnd As New Random()

		Public Sub New()
			InitializeComponent()
			AddHandler radChartView1.CreateRenderer, AddressOf RadChartView1_CreateRenderer

			Dim areaSeries As New AreaSeries()
		   ' areaSeries.Spline = true;

			Dim areaSeries2 As New AreaSeries()

			For x As Integer = 0 To 59
				areaSeries.DataPoints.Add(rnd.Next(1,100), x)
				areaSeries2.DataPoints.Add(rnd.Next(1, 100) * -1, x)
			Next x

			Me.radChartView1.Series.Add(areaSeries)
			Me.radChartView1.Series.Add(areaSeries2)
		End Sub

		Private Sub RadChartView1_CreateRenderer(ByVal sender As Object, ByVal e As ChartViewCreateRendererEventArgs)
			e.Renderer = New CustomCartesianRenderer(TryCast(e.Area, CartesianArea))
		End Sub
	End Class
	Public Class CustomCartesianRenderer
		Inherits CartesianRenderer

		Public Sub New(ByVal area As CartesianArea)
			MyBase.New(area)
		End Sub
		Protected Overrides Sub Initialize()
			MyBase.Initialize()
			For i As Integer = 0 To Me.DrawParts.Count - 1
				Dim linePart As AreaSeriesDrawPart = TryCast(Me.DrawParts(i), AreaSeriesDrawPart)
				If linePart IsNot Nothing Then
					Me.DrawParts(i) = New CustomAreaSeriesDrawPart(CType(linePart.Element, AreaSeries), Me)
				End If
			Next i
		End Sub
	End Class
	Friend Class CustomAreaSeriesDrawPart
		Inherits AreaSeriesDrawPart

		Public Sub New(ByVal series As AreaSeries, ByVal renderer As ChartRenderer)
			MyBase.New(series, renderer)
		End Sub
		Public Function GetLocationOfValue(ByVal value As Object, ByVal axis As NumericalAxis) As Double
			Dim model As NumericalAxisModel = TryCast(axis.Model, NumericalAxisModel)

			Dim val As Double = Convert.ToDouble(value)
			val = DirectCast(model.TransformValue(val), Double)
			Dim delta As Double = axis.ActualRange.Maximum - axis.ActualRange.Minimum
			Dim normalizedValue As Double = (val - axis.ActualRange.Minimum) / delta

			Dim view As IChartView = DirectCast(axis.View, IChartView)
			Dim area As CartesianArea = axis.View.GetArea(Of CartesianArea)()

			Dim result As Double

			If area IsNot Nothing AndAlso ((area.Orientation = Orientation.Vertical AndAlso axis.AxisType = Telerik.Charting.AxisType.First) OrElse (area.Orientation = Orientation.Horizontal AndAlso axis.AxisType = Telerik.Charting.AxisType.Second)) Then
				result = view.PlotOriginX + axis.Model.LayoutSlot.X + normalizedValue * (axis.Model.LayoutSlot.Width * view.ZoomWidth)
			Else
				result = view.PlotOriginY + DirectCast(view, ChartView).Margin.Top + axis.Model.LayoutSlot.Y + (1.0R - normalizedValue) * (axis.Model.LayoutSlot.Height * view.ZoomHeight)
			End If

			Return result
		End Function
		Protected Overrides Sub DrawArea()
			Dim renderer_Renamed As CartesianRenderer = DirectCast(Me.Renderer, CartesianRenderer)
			Dim area As AreaSeries = TryCast(Me.Element, AreaSeries)
			Dim graphics As Graphics = renderer_Renamed.Graphics
			Dim radGraphics As New RadGdiGraphics(graphics)

			Dim rect As RectangleF = ChartRenderer.ToRectangleF(Me.Element.Model.LayoutSlot)
			Dim clipRect As RectangleF = CType(renderer_Renamed.Area.GetType().GetMethod("GetCartesianClipRect", BindingFlags.Instance Or BindingFlags.NonPublic).Invoke(renderer_Renamed.Area, New Object() { }), RectangleF)

			Dim topLeft As New PointF(clipRect.X, clipRect.Y)
			Dim topRight As New PointF(clipRect.Right - 1, clipRect.Y)

			Dim lowerRight As New PointF(clipRect.Right - 1, clipRect.Bottom - 1)
			Dim lowerLeft As New PointF(clipRect.X, clipRect.Bottom - 1)

			Dim allPoints As List(Of PointF()) = GetPointsPositionsArrays()

			Dim zeroOnTheYAxis As Single = CSng(Me.GetLocationOfValue(0, CType(area.VerticalAxis, NumericalAxis)))
			lowerLeft.Y = zeroOnTheYAxis
			lowerRight.Y = zeroOnTheYAxis

			For Each points As PointF() In allPoints
				If points.Length < 2 Then
					Continue For
				End If

				Dim fillPath As GraphicsPath = Me.GetLinePaths(points)

				If fillPath Is Nothing Then
					Continue For
				End If

				If Me.Element.View.GetArea(Of CartesianArea)().Orientation = System.Windows.Forms.Orientation.Vertical Then
					If area.VerticalAxis.IsInverse Then
						fillPath.AddLine(points(points.Length - 1), New PointF(points(points.Length - 1).X, topRight.Y))
						fillPath.AddLine(topRight, topLeft)
						fillPath.AddLine(New PointF(points(0).X, topLeft.Y), points(0))
					Else

						fillPath.AddLine(points(points.Length - 1), New PointF(points(points.Length - 1).X, lowerRight.Y))
						fillPath.AddLine(lowerRight, lowerLeft)
						fillPath.AddLine(New PointF(points(0).X, lowerLeft.Y), points(0))
					End If
				Else
					If area.HorizontalAxis.IsInverse Then
						fillPath.AddLine(points(points.Length - 1), topRight)
						fillPath.AddLine(topRight, lowerRight)
						fillPath.AddLine(lowerRight, points(0))
					Else
						fillPath.AddLine(points(points.Length - 1), topLeft)
						fillPath.AddLine(topLeft, lowerLeft)
						fillPath.AddLine(lowerLeft, points(0))
					End If
				End If

				Dim fill As New FillPrimitiveImpl(Me.Element, Nothing)
				fill.PaintFill(radGraphics, fillPath, clipRect)

				Dim borderPath As New GraphicsPath()
				Dim series As AreaSeries = CType(Me.Element, AreaSeries)

				borderPath = New GraphicsPath()

				If series.StrokeMode = AreaSeriesStrokeMode.All OrElse series.StrokeMode = AreaSeriesStrokeMode.AllButPlotLine OrElse series.StrokeMode = AreaSeriesStrokeMode.LeftAndPoints OrElse series.StrokeMode = AreaSeriesStrokeMode.LeftLine Then
					If Me.Element.View.GetArea(Of CartesianArea)().Orientation = System.Windows.Forms.Orientation.Vertical Then
						If area.VerticalAxis.IsInverse Then
							borderPath.AddLine(topLeft, points(0))
						Else
							borderPath.AddLine(lowerLeft, points(0))
						End If
					Else
						If area.HorizontalAxis.IsInverse Then
							borderPath.AddLine(lowerRight, points(0))
						Else
							borderPath.AddLine(lowerLeft, points(0))
						End If
					End If
				End If

				If series.StrokeMode = AreaSeriesStrokeMode.All OrElse series.StrokeMode = AreaSeriesStrokeMode.AllButPlotLine OrElse series.StrokeMode = AreaSeriesStrokeMode.LeftAndPoints OrElse series.StrokeMode = AreaSeriesStrokeMode.Points OrElse series.StrokeMode = AreaSeriesStrokeMode.RightAndPoints Then
					Dim path As GraphicsPath = GetLinePaths(points)

					If path IsNot Nothing Then
						borderPath.AddPath(path, True)
					End If
				End If

				If series.StrokeMode = AreaSeriesStrokeMode.All OrElse series.StrokeMode = AreaSeriesStrokeMode.AllButPlotLine OrElse series.StrokeMode = AreaSeriesStrokeMode.RightAndPoints OrElse series.StrokeMode = AreaSeriesStrokeMode.RightLine Then
					If Me.Element.View.GetArea(Of CartesianArea)().Orientation = System.Windows.Forms.Orientation.Vertical Then
						If area.VerticalAxis.IsInverse Then
							borderPath.AddLine(points(points.Length - 1), topRight)
						Else
							borderPath.AddLine(points(points.Length - 1), lowerRight)
						End If
					Else
						If area.HorizontalAxis.IsInverse Then
							borderPath.AddLine(points(points.Length - 1), topRight)
						Else
							borderPath.AddLine(points(points.Length - 1), topLeft)
						End If
					End If
				End If

				If series.StrokeMode = AreaSeriesStrokeMode.All OrElse series.StrokeMode = AreaSeriesStrokeMode.PlotLine Then
					If Me.Element.View.GetArea(Of CartesianArea)().Orientation = System.Windows.Forms.Orientation.Vertical Then
						If area.VerticalAxis.IsInverse Then
							borderPath.AddLine(topRight, topLeft)
						Else
							borderPath.AddLine(lowerRight, lowerLeft)
						End If
					Else
						If area.HorizontalAxis.IsInverse Then
							borderPath.AddLine(topRight, lowerRight)
						Else
							borderPath.AddLine(lowerLeft, topLeft)
						End If
					End If
				End If

				Dim border As New BorderPrimitiveImpl(Me.Element, Nothing)
				border.PaintBorder(radGraphics, Nothing, borderPath, rect)

				If series.Image IsNot Nothing Then
					graphics.SetClip(fillPath)
					Dim image As New ImagePrimitiveImpl(series)
					image.PaintImage(radGraphics, series.Image, clipRect, series.ImageLayout, series.ImageAlignment, series.ImageOpacity, False)
					graphics.ResetClip()
				End If
			Next points
		End Sub
	End Class

End Namespace

