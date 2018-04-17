Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class RadGanttViewTimelineSnapping

#Region "InitialSetup"
    Public Sub New()
        InitializeComponent()
        Me.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineStart = New DateTime(2010, 10, 7)
        Me.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineEnd = New DateTime(2010, 12, 10)
        Dim tasks As DataTable = New DataTable("Tasks")
        tasks.Columns.Add("Id", GetType(Integer))
        tasks.Columns.Add("ParentId", GetType(Integer))
        tasks.Columns.Add("Title", GetType(String))
        tasks.Columns.Add("Start", GetType(DateTime))
        tasks.Columns.Add("End", GetType(DateTime))
        tasks.Columns.Add("Progress", GetType(Decimal))
        Dim links As DataTable = New DataTable("Links")
        links.Columns.Add("StartId", GetType(Integer))
        links.Columns.Add("EndId", GetType(Integer))
        links.Columns.Add("LinkType", GetType(Integer))
        Dim data As DataSet = New DataSet()
        data.Tables.Add(tasks)
        data.Tables.Add(links)
        tasks.Rows.Add(1, 0, "Summary task title", New DateTime(2010, 10, 10), New DateTime(2010, 10, 15), 30D)
        tasks.Rows.Add(2, 1, "First child task title", New DateTime(2010, 10, 10), New DateTime(2010, 10, 12), 10)
        tasks.Rows.Add(3, 1, "Second child task title", New DateTime(2010, 10, 12), New DateTime(2010, 10, 15), 20D)
        tasks.Rows.Add(4, 1, "Milestone", New DateTime(2010, 10, 15), New DateTime(2010, 10, 15), 0D)
        links.Rows.Add(2, 3, 1)
        links.Rows.Add(3, 4, 1)
        Me.radGanttView1.GanttViewElement.TaskDataMember = "Tasks"
        Me.radGanttView1.GanttViewElement.ChildMember = "Id"
        Me.radGanttView1.GanttViewElement.ParentMember = "ParentId"
        Me.radGanttView1.GanttViewElement.TitleMember = "Title"
        Me.radGanttView1.GanttViewElement.StartMember = "Start"
        Me.radGanttView1.GanttViewElement.EndMember = "End"
        Me.radGanttView1.GanttViewElement.ProgressMember = "Progress"
        Me.radGanttView1.GanttViewElement.LinkDataMember = "Links"
        Me.radGanttView1.GanttViewElement.LinkStartMember = "StartId"
        Me.radGanttView1.GanttViewElement.LinkEndMember = "EndId"
        Me.radGanttView1.GanttViewElement.LinkTypeMember = "LinkType"
        Me.radGanttView1.GanttViewElement.DataSource = data
        Me.radGanttView1.Columns.Add("Start")
        Me.radGanttView1.Columns.Add("End")
        Me.radGanttView1.GanttViewBehavior = New CustomGanttViewBehavior()
        Me.radGanttView1.GanttViewElement.DragDropService = New MyGanttViewDragDropService(Me.radGanttView1.GanttViewElement)
    End Sub
End Class
#End Region

#Region "DragAndDrop"
Public Class MyGanttViewDragDropService
    Inherits GanttViewDragDropService

    Private dragStartPoint As Point

    Private snappedDate As DateTime

    Public Sub New(ByVal owner As RadGanttViewElement)
        MyBase.New(owner)
    End Sub

    Protected Overrides Sub SetHintWindowPosition(ByVal mousePt As Point)
        Dim dragDistance As Integer = mousePt.X - Me.dragStartPoint.X
        Dim dataItem As GanttViewDataItem = (TryCast((CType(Me.Context, GanttGraphicalViewBaseTaskElement)).Parent, GanttGraphicalViewBaseItemElement)).Data
        Dim startDate As DateTime = dataItem.Start
        Dim newDate As DateTime = startDate.AddTicks(Me.Owner.GraphicalViewElement.OnePixelTime.Ticks * dragDistance)
        Me.snappedDate = New DateTime(CLng(Math.Floor(CDec((newDate.Ticks / TimeSpan.TicksPerDay)))) * TimeSpan.TicksPerDay)
        Dim rectF As RectangleF = Me.Owner.GraphicalViewElement.GetDrawRectangle(dataItem, snappedDate)
        Dim rectLocation As Point = Point.Round(rectF.Location)
        Dim snapToDatePoint As Point = Me.Owner.GraphicalViewElement.PointToScreen(rectLocation)
        Dim mouseOffset As Integer = Me.dragStartPoint.X - (CType(Me.Context, GanttGraphicalViewBaseTaskElement)).PointToScreen(New Point(0, 0)).X
        Dim newMousePt As Point = New Point(snapToDatePoint.X + mouseOffset, mousePt.Y)
        MyBase.SetHintWindowPosition(newMousePt)
    End Sub

    Protected Overrides Sub OnPreviewDragDrop(ByVal e As RadDropEventArgs)
        Dim taskElement As GanttViewTaskElement = TryCast(e.DragInstance, GanttViewTaskElement)
        If taskElement IsNot Nothing Then
            Dim taskItemElement As GanttViewTaskItemElement = TryCast(taskElement.Parent, GanttViewTaskItemElement)
            If taskItemElement.Data.Start = Me.snappedDate Then
                Return
            End If

            Dim duration As TimeSpan = taskItemElement.Data.[End] - taskItemElement.Data.Start
            taskItemElement.Data.Start = snappedDate
            taskItemElement.Data.[End] = snappedDate + duration
            Me.CalculateLinkLines(taskItemElement.GraphicalViewElement, taskItemElement.Data)
            e.Handled = True
        End If

        MyBase.OnPreviewDragDrop(e)
    End Sub

    Protected Overrides Sub OnPreviewDragStart(ByVal e As PreviewDragStartEventArgs)
        Me.dragStartPoint = Cursor.Position
        MyBase.OnPreviewDragStart(e)
    End Sub

    Protected Overrides Sub OnStopped()
        Me.dragStartPoint = Point.Empty
        MyBase.OnStopped()
    End Sub

    Protected Friend Overridable Sub CalculateLinkLines(ByVal viewElement As GanttViewGraphicalViewElement, ByVal item As GanttViewDataItem)
        For Each link As GanttViewLinkDataItem In viewElement.GanttViewElement.Links
            If link.StartItem Is item OrElse link.EndItem Is item Then
                viewElement.CalculateLinkLines(link, Nothing)
            End If
        Next
    End Sub
End Class

#End Region

#Region "MouseBehavior"
Public Class CustomGanttViewBehavior
    Inherits BaseGanttViewBehavior

    Protected Overrides Sub ProcessMouseMoveWhenResizingTask(ByVal element As GanttGraphicalViewBaseTaskElement, ByVal e As MouseEventArgs)
        Dim data As GanttViewDataItem = (CType(element.Parent, GanttGraphicalViewBaseItemElement)).Data
        Dim baseDate As DateTime = If(Me.IsResizingStart, data.Start, data.[End])
        Dim mousePosition As Point = Me.GanttViewElement.GraphicalViewElement.PointFromControl(e.Location)
        Dim distanceFromLeftBorder As Integer = Me.GanttViewElement.GraphicalViewElement.HorizontalScrollBarElement.Value + mousePosition.X
        Dim newDate As DateTime = Me.GanttViewElement.GraphicalViewElement.TimelineBehavior.AdjustedTimelineStart.AddSeconds(distanceFromLeftBorder * Me.GanttViewElement.GraphicalViewElement.OnePixelTime.TotalSeconds).AddSeconds(1)
        If newDate.Hour = 0 AndAlso newDate.Minute = 0 AndAlso newDate.Second = 0 Then
            If Me.IsResizingStart Then
                Dim maxStart As DateTime = data.[End].Subtract(New TimeSpan(Me.GanttViewElement.GraphicalViewElement.OnePixelTime.Ticks * Me.GanttViewElement.MinimumTaskWidth))
                If newDate > maxStart Then
                    newDate = maxStart
                End If

                data.Start = newDate
            ElseIf Me.IsResizingEnd Then
                Dim minEnd As DateTime = data.Start.Add(New TimeSpan(Me.GanttViewElement.GraphicalViewElement.OnePixelTime.Ticks * Me.GanttViewElement.MinimumTaskWidth))
                If newDate < minEnd Then
                    newDate = minEnd
                End If

                data.[End] = newDate
            End If
        End If

        Me.ProcessScrolling(Me.GanttViewElement.ElementTree.Control.PointToScreen(e.Location), False)
        For Each link As GanttViewLinkDataItem In Me.GanttViewElement.Links
            If link.StartItem Is data OrElse link.EndItem Is data Then
                Me.GanttViewElement.GraphicalViewElement.CalculateLinkLines(link, Nothing)
            End If
        Next

        element.Parent.InvalidateMeasure(True)
        Me.GanttViewElement.GraphicalViewElement.Invalidate()
    End Sub
End Class
#End Region
