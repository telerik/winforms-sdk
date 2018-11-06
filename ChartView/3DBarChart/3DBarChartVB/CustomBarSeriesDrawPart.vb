Imports System.Drawing.Drawing2D
Imports System.Reflection
Imports Telerik.Charting
Imports Telerik.WinControls
Imports Telerik.WinControls.Paint
Imports Telerik.WinControls.Primitives
Imports Telerik.WinControls.UI

Public Class CustomBarSeriesDrawPart
    Inherits BarSeriesDrawPart

    Private summaryFont As Font = New Font("Calibri", 12, FontStyle.Bold)

    Public Sub New(ByVal series As BarSeries, ByVal renderer As IChartRenderer)
        MyBase.New(series, renderer)
    End Sub

    Public Property DrawCap As Boolean

    Public Overrides Sub DrawSeriesParts()
        Dim customRenderer As CustomCartesianRenderer = TryCast(Me.Renderer, CustomCartesianRenderer)
        Dim graphics As Graphics = customRenderer.Graphics
        Dim radGraphics As RadGdiGraphics = New RadGdiGraphics(graphics)

        For j As Integer = 0 To Me.Element.DataPoints.Count - 1
            Dim dataPoint As DataPoint = Me.Element.DataPoints(j)
            Dim slot As RadRect = dataPoint.LayoutSlot

            If CBool(dataPoint.[GetType]().GetField("isEmpty", BindingFlags.Instance Or BindingFlags.NonPublic).GetValue(dataPoint)) Then
                Continue For
            End If

            Dim barBounds As RectangleF = New RectangleF(CSng((Me.OffsetX + slot.X)), CSng((Me.OffsetY + slot.Y)), CSng(slot.Width), CSng(slot.Height))
            Dim isAreaVertical As Boolean = (TryCast((CType(Me.Element, CartesianSeries)).Parent, CartesianArea)).Orientation = System.Windows.Forms.Orientation.Vertical
            Dim childElement As DataPointElement = CType(Me.Element.Children(j), DataPointElement)

            If isAreaVertical Then
                Dim realHeight As Single = barBounds.Height * childElement.HeightAspectRatio
                barBounds.Y += barBounds.Height - realHeight
                barBounds.Height = realHeight
            Else
                Dim realWidth As Single = barBounds.Width * childElement.HeightAspectRatio
                barBounds.Width = realWidth
            End If

            barBounds = AdjustBarDataPointBounds(childElement, barBounds)

            If isAreaVertical Then
                barBounds.Width = Math.Max(barBounds.Width, 1.0F)
            Else
                barBounds.Height = Math.Max(barBounds.Height, 1.0F)
            End If

            Dim background As RadImageShape = childElement.BackgroundShape

            If background IsNot Nothing Then
                background.Paint(graphics, barBounds)
            End If

            Dim fill As FillPrimitiveImpl = New FillPrimitiveImpl(childElement, Nothing)
            fill.PaintFill(radGraphics, 0, New SizeF(1, 1), barBounds)
            Dim border As BorderPrimitiveImpl = New BorderPrimitiveImpl(childElement, Nothing)
            border.PaintBorder(radGraphics, 0, New SizeF(1, 1), barBounds)

            If childElement.Image IsNot Nothing Then
                graphics.SetClip(barBounds)
                Dim pointImage As ImagePrimitiveImpl = New ImagePrimitiveImpl(childElement)
                pointImage.PaintImage(radGraphics, childElement.Image, barBounds, childElement.ImageLayout, childElement.ImageAlignment, childElement.ImageOpacity, False)
                graphics.ResetClip()
            End If

            Dim xOffset As Single = 20
            Dim yOffset As Single = 20
            Dim path As GraphicsPath = New GraphicsPath()
            Dim lines As List(Of PointF) = New List(Of PointF)()
            lines.Add(New PointF(barBounds.Right, barBounds.Y))
            lines.Add(New PointF(barBounds.Right + xOffset, barBounds.Y - yOffset))
            lines.Add(New PointF(barBounds.Right + xOffset, barBounds.Bottom - yOffset))
            lines.Add(New PointF(barBounds.Right, barBounds.Bottom))
            path.AddLines(lines.ToArray())
            path.CloseFigure()

            Using pen As Pen = New Pen(Me.Element.BorderColor), pen2 As Pen = New Pen(Color.FromArgb(100, Color.Black))
                graphics.DrawPath(pen, path)
                graphics.DrawPath(pen2, path)
            End Using

            Using brush As Brush = New SolidBrush(Me.Element.BackColor), brush2 As Brush = New SolidBrush(Color.FromArgb(100, Color.Black))
                graphics.FillPath(brush, path)
                graphics.FillPath(brush2, path)
            End Using

            If Me.DrawCap Then
                path = New GraphicsPath()
                lines = New List(Of PointF)()
                lines.Add(New PointF(barBounds.X, barBounds.Y))
                lines.Add(New PointF(barBounds.X + xOffset, barBounds.Y - yOffset))
                lines.Add(New PointF(barBounds.Right + xOffset, barBounds.Y - yOffset))
                lines.Add(New PointF(barBounds.Right, barBounds.Y))
                path.AddLines(lines.ToArray())
                path.CloseFigure()

                Using pen As Pen = New Pen(Me.Element.BorderColor), pen2 As Pen = New Pen(Color.FromArgb(100, Color.White))
                    graphics.DrawPath(pen, path)
                    graphics.DrawPath(pen2, path)
                End Using

                Using brush As Brush = New SolidBrush(Me.Element.BackColor), brush2 As Brush = New SolidBrush(Color.FromArgb(100, Color.White))
                    graphics.FillPath(brush, path)
                    graphics.FillPath(brush2, path)
                End Using

                Using sf As StringFormat = New StringFormat(StringFormat.GenericTypographic)
                    Dim category As Object = (CType(dataPoint, CategoricalDataPoint)).Category
                    Dim text As String = customRenderer.Summaries(category).ToString()
                    Dim textSize As SizeF = graphics.MeasureString(text, Me.summaryFont)
                    Dim rect As RectangleF = ChartRenderer.ToRectangleF(slot)
                    rect.Offset(Me.Element.View.Margin.Right + (rect.Width - textSize.Width) / 2, Me.Element.View.Margin.Top + textSize.Height - 10)
                    radGraphics.DrawString(text, rect, Me.summaryFont, Color.Black, sf, System.Windows.Forms.Orientation.Horizontal, False)
                End Using
            End If
        Next
    End Sub

    Private Function AdjustBarDataPointBounds(ByVal point As DataPointElement, ByVal bounds As RectangleF) As RectangleF
        Dim barBounds As RectangleF = bounds

        If point.BorderBoxStyle = BorderBoxStyle.SingleBorder OrElse point.BorderBoxStyle = BorderBoxStyle.OuterInnerBorders Then
            barBounds.X += point.BorderWidth - CInt(((point.BorderWidth - 1.0F) / 2.0F))
            barBounds.Width -= point.BorderWidth
            barBounds.Y += point.BorderWidth - CInt(((point.BorderWidth - 1.0F) / 2.0F))
            barBounds.Height -= point.BorderWidth
        ElseIf point.BorderBoxStyle = BorderBoxStyle.FourBorders Then
            barBounds.Y += 1
            barBounds.Height -= 1
            barBounds.X += 1
            barBounds.Width -= 1
        End If

        If (CType(Me.Renderer, CartesianRenderer)).Area.Orientation = System.Windows.Forms.Orientation.Horizontal Then
            barBounds.X -= 1
        End If

        Return barBounds
    End Function
End Class
