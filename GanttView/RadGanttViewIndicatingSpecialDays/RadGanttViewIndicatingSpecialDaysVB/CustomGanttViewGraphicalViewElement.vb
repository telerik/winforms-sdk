Imports Telerik.WinControls.UI

Public Class CustomGanttViewGraphicalViewElement
    Inherits GanttViewGraphicalViewElement

    Private m_specialDates As New List(Of DateTime)()

    Public Sub New(ganttView As RadGanttViewElement)
        MyBase.New(ganttView)
    End Sub

    Public Property SpecialDates() As List(Of DateTime)
        Get
            Return m_specialDates
        End Get
        Set(value As List(Of DateTime))
            m_specialDates = value
        End Set
    End Property

    Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
        Get
            Return GetType(GanttViewGraphicalViewElement)
        End Get
    End Property

    'Logic for painting the elements
    Protected Overrides Sub PaintElement(graphics As Telerik.WinControls.Paint.IGraphics, angle As Single, scale As System.Drawing.SizeF)
        MyBase.PaintElement(graphics, angle, scale)

        Dim clipRect As Rectangle = Me.Bounds
        Dim g As Graphics = TryCast(graphics.UnderlayGraphics, Graphics)

        g.SetClip(clipRect)

        Dim currentDate As DateTime = Me.TimelineBehavior.AdjustedTimelineStart

        While currentDate <= Me.TimelineBehavior.AdjustedTimelineEnd
            Dim x As Single = CSng((currentDate - Me.TimelineBehavior.AdjustedTimelineStart).TotalSeconds / Me.OnePixelTime.TotalSeconds)
            x -= Me.HorizontalScrollBarElement.Value
            Dim y As Single = Me.GanttViewElement.HeaderHeight
            Dim y2 As Single = Me.Bounds.Height

            If currentDate.DayOfWeek = DayOfWeek.Saturday OrElse currentDate.DayOfWeek = DayOfWeek.Sunday Then
                graphics.FillRectangle(New RectangleF(x, y, 100.0F, y2), Color.LightGray)
            ElseIf Me.SpecialDates.Contains(currentDate.[Date]) Then
                graphics.FillRectangle(New RectangleF(x, y, 100.0F, y2), Color.Orange)
            Else
                graphics.FillRectangle(New RectangleF(x, y, 100.0F, y2), Color.White)
            End If

            graphics.DrawLine(Color.LightBlue, x, y, x, y2)

            currentDate = currentDate.AddDays(1)
        End While

        g.ResetClip()
    End Sub
End Class
