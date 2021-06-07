Imports Telerik.WinControls.UI

Public Class RadGanttViewForm
    Public Sub New()
        InitializeComponent()

        AddHandler Me.Load, AddressOf RadGanttViewForm_Load
        AddHandler Me.CustomRadGanttView.GraphicalViewItemFormatting, AddressOf CustomRadGanttView_GraphicalViewItemFormatting
        AddHandler Me.CustomRadGanttView.TimelineItemFormatting, AddressOf CustomRadGanttView_TimelineItemFormatting

        DirectCast(Me.CustomRadGanttView.GanttViewElement.GraphicalViewElement, CustomGanttViewGraphicalViewElement).SpecialDates.Add(New DateTime(2014, 12, 25))
        DirectCast(Me.CustomRadGanttView.GanttViewElement.GraphicalViewElement, CustomGanttViewGraphicalViewElement).SpecialDates.Add(New DateTime(2014, 12, 26))

    End Sub

    Private Sub RadGanttViewForm_Load(sender As Object, e As EventArgs)
        Me.CustomRadGanttView.EnableCustomPainting = True
        Me.CustomRadGanttView.GanttViewElement.GraphicalViewElement.TimelineStart = New DateTime(2014, 12, 15)
        Me.CustomRadGanttView.GanttViewElement.GraphicalViewElement.TimelineEnd = New DateTime(2015, 1, 15)

        Me.AddTasks()
    End Sub

    Private Sub CustomRadGanttView_TimelineItemFormatting(sender As Object, e As GanttViewTimelineItemFormattingEventArgs)
        Dim tlDate As DateTime
        Dim element As LightVisualElement
        For i As Integer = 0 To e.ItemElement.Children(1).Children.Count - 1
            tlDate = e.ItemElement.Data.Start.AddDays(i)
            element = TryCast(e.ItemElement.Children(1).Children(i), LightVisualElement)
            If element IsNot Nothing Then
                element.Text = tlDate.Day & vbLf & tlDate.DayOfWeek.ToString().Substring(0, 2)
                element.Font = New Font("Arial", 7.5F)
            End If
        Next
    End Sub

    Private Sub CustomRadGanttView_GraphicalViewItemFormatting(sender As Object, e As GanttViewGraphicalViewItemFormattingEventArgs)
        e.ItemElement.DrawFill = False
    End Sub

  

    Private Sub AddTasks()
        'Setup data items
        Dim item1 As New GanttViewDataItem()
        item1.Start = New DateTime(2014, 12, 15)
        item1.[End] = New DateTime(2014, 12, 20)
        item1.Progress = 30D
        item1.Title = "Summary task.1. title"

        Dim subItem11 As New GanttViewDataItem()
        subItem11.Start = New DateTime(2014, 12, 16)
        subItem11.[End] = New DateTime(2014, 12, 18)
        subItem11.Progress = 10D
        subItem11.Title = "Sub-task.1.1 title"

        Dim subItem12 As New GanttViewDataItem()
        subItem12.Start = New DateTime(2014, 12, 21)
        subItem12.[End] = New DateTime(2014, 12, 23)
        subItem12.Progress = 20D
        subItem12.Title = "Sub-task.1.2 title"

        'Add subitems
        item1.Items.Add(subItem11)
        item1.Items.Add(subItem12)

        Me.CustomRadGanttView.Items.Add(item1)

        Dim item2 As New GanttViewDataItem()
        item2.Start = New DateTime(2014, 12, 21)
        item2.[End] = New DateTime(2014, 12, 12)
        item2.Progress = 40D
        item2.Title = "Summary task.2. title"

        Dim subitem21 As New GanttViewDataItem()
        subitem21.Start = New DateTime(2014, 12, 17)
        subitem21.[End] = New DateTime(2014, 12, 20)
        subitem21.Progress = 10D
        subitem21.Title = "Sub-task.2.1 title"

        Dim subitem22 As New GanttViewDataItem()
        subitem22.Start = New DateTime(2014, 12, 21)
        subitem22.[End] = New DateTime(2014, 12, 23)
        subitem22.Progress = 30D
        subitem22.Title = "Sub-task.2.2 title"

        Dim subitem23 As New GanttViewDataItem()
        subitem23.Start = New DateTime(2014, 12, 18)
        subitem23.[End] = New DateTime(2014, 12, 20)
        subitem23.Title = "Sub-task.2.3 title"

        'Add subitems
        item2.Items.Add(subitem21)
        item2.Items.Add(subitem22)
        item2.Items.Add(subitem23)

        Me.CustomRadGanttView.Items.Add(item2)

        'Add links between items
        Dim link1 As New GanttViewLinkDataItem()
        link1.StartItem = subItem11
        link1.EndItem = subItem12
        link1.LinkType = TasksLinkType.FinishToStart
        Me.CustomRadGanttView.Links.Add(link1)

        Dim link2 As New GanttViewLinkDataItem()
        link2.StartItem = subitem21
        link2.EndItem = subitem22
        link2.LinkType = TasksLinkType.StartToStart
        Me.CustomRadGanttView.Links.Add(link2)

        Dim link3 As New GanttViewLinkDataItem()
        link3.StartItem = subitem22
        link3.EndItem = subitem23
        link3.LinkType = TasksLinkType.FinishToStart
        Me.CustomRadGanttView.Links.Add(link3)

        Dim titleColumn As New GanttViewTextViewColumn("Title")
        Dim startColumn As New GanttViewTextViewColumn("Start")
        Dim endColumn As New GanttViewTextViewColumn("End")

        Me.CustomRadGanttView.GanttViewElement.Columns.Add(titleColumn)
        Me.CustomRadGanttView.GanttViewElement.Columns.Add(startColumn)
        Me.CustomRadGanttView.GanttViewElement.Columns.Add(endColumn)
    End Sub

End Class
