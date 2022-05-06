Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class RadForm1
    Private rnd As Random = New Random()

    Public Sub New()
        InitializeComponent()
        Me.Text = "Truck system"
        Dim table As DataTable = New DataTable()
        table.Columns.Add("Id", GetType(Integer))
        table.Columns.Add("Title", GetType(String))
        table.Columns.Add("Start", GetType(DateTime))
        table.Columns.Add("End", GetType(DateTime))
        table.Columns.Add("DrivingToPickUpLocation", GetType(TimeSpan))
        table.Columns.Add("Loading", GetType(TimeSpan))
        table.Columns.Add("Driving", GetType(TimeSpan))
        table.Columns.Add("DriverRest", GetType(TimeSpan))
        table.Columns.Add("Waiting", GetType(TimeSpan))
        table.Columns.Add("Unloading", GetType(TimeSpan))
        Dim minValue As Integer = 20
        Dim maxValue As Integer = 90

        For i As Integer = 0 To 10 - 1
            Dim start As DateTime = DateTime.Now.AddHours(i)
            Dim drivingToPickup As TimeSpan = New TimeSpan(0, Me.rnd.[Next](minValue, maxValue), 0)
            Dim loading As TimeSpan = New TimeSpan(0, Me.rnd.[Next](minValue, maxValue), 0)
            Dim driving As TimeSpan = New TimeSpan(0, Me.rnd.[Next](minValue, maxValue), 0)
            Dim rest As TimeSpan = New TimeSpan(0, Me.rnd.[Next](minValue, maxValue), 0)
            Dim waiting As TimeSpan = New TimeSpan(0, Me.rnd.[Next](minValue, maxValue), 0)
            Dim unloading As TimeSpan = New TimeSpan(0, Me.rnd.[Next](minValue, maxValue), 0)
            Dim [end] As DateTime = start.Add(drivingToPickup + loading + driving + rest + waiting + unloading)
            table.Rows.Add(i, "Title " & i, start, [end], drivingToPickup, loading, driving, rest, waiting, unloading)
        Next

        Me.RadGanttView1.Columns.Add("Title")
        Me.RadGanttView1.ChildMember = "Id"
        Me.RadGanttView1.TitleMember = "Title"
        Me.RadGanttView1.StartMember = "Start"
        Me.RadGanttView1.EndMember = "End"
        Me.RadGanttView1.DataSource = table
        Me.RadGanttView1.GanttViewElement.GraphicalViewElement.TimelineStart = DateTime.Now.AddHours(-1)
        Me.RadGanttView1.GanttViewElement.GraphicalViewElement.TimelineEnd = DateTime.Now.AddDays(2)
        Me.RadGanttView1.GanttViewElement.GraphicalViewElement.TimelineRange = TimeRange.Day
        Me.RadGanttView1.GanttViewElement.GraphicalViewElement.OnePixelTime = New TimeSpan(0, 1, 0)
        Me.RadGanttView1.ItemHeight = 40
        Me.RadGanttView1.Ratio = 0.1F
        AddHandler Me.RadGanttView1.ItemElementCreating, AddressOf radGanttView1_ItemElementCreating
        AddHandler Me.RadGanttView1.ToolTipTextNeeded, AddressOf radGanttView1_ToolTipTextNeeded
    End Sub

    Private Sub radGanttView1_ToolTipTextNeeded(ByVal sender As Object, ByVal e As Telerik.WinControls.ToolTipTextNeededEventArgs)
        Dim mousePosition As Point = Me.RadGanttView1.PointToClient(Control.MousePosition)
        Dim elementUnderMouse As RadElement = Me.RadGanttView1.ElementTree.GetElementAtPoint(mousePosition)

        If elementUnderMouse Is Nothing Then
            Return
        End If

        Dim itemElement As GanttGraphicalViewBaseItemElement = TryCast(elementUnderMouse, GanttGraphicalViewBaseItemElement)

        If itemElement Is Nothing Then
            itemElement = elementUnderMouse.FindAncestor(Of GanttGraphicalViewBaseItemElement)()
        End If

        If itemElement Is Nothing Then
            Return
        End If

        If TypeOf elementUnderMouse Is DrivingToPickUpLocationElement Then
            e.ToolTipText = String.Format("Driving to site: {0}", (CType(itemElement.Data.DataBoundItem, DataRowView))("DrivingToPickUpLocation"))
        ElseIf TypeOf elementUnderMouse Is LoadingElement Then
            e.ToolTipText = String.Format("Loading time: {0}", (CType(itemElement.Data.DataBoundItem, DataRowView))("Loading"))
        ElseIf TypeOf elementUnderMouse Is DrivingElement Then
            e.ToolTipText = String.Format("Driving: {0}", (CType(itemElement.Data.DataBoundItem, DataRowView))("Driving"))
        ElseIf TypeOf elementUnderMouse Is DriverRestElement Then
            e.ToolTipText = String.Format("Driver rest: {0}", (CType(itemElement.Data.DataBoundItem, DataRowView))("DriverRest"))
        ElseIf TypeOf elementUnderMouse Is WaitingElement Then
            e.ToolTipText = String.Format("Waiting: {0}", (CType(itemElement.Data.DataBoundItem, DataRowView))("Waiting"))
        ElseIf TypeOf elementUnderMouse Is UnloadingElement Then
            e.ToolTipText = String.Format("Unloading: {0}", (CType(itemElement.Data.DataBoundItem, DataRowView))("Unloading"))
        End If
    End Sub

    Private Sub radGanttView1_ItemElementCreating(ByVal sender As Object, ByVal e As GanttViewItemElementCreatingEventArgs)
        Dim graphicalView As GanttViewGraphicalViewElement = TryCast(e.ViewElement, GanttViewGraphicalViewElement)

        If graphicalView IsNot Nothing AndAlso e.Item.Items.Count = 0 AndAlso e.Item.Start <> e.Item.[End] Then
            e.ItemElement = New CustomGanttViewTaskItemElement(graphicalView)
        End If
    End Sub
End Class
