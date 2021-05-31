Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Public Class Form1

    Private images As New List(Of Image)() From { _
        My.Resources.open, _
        My.Resources.paste, _
        My.Resources.pdf _
    }

    Public Sub New()
        InitializeComponent()

        Dim rand As New Random()
        Dim list As New List(Of MyObject)()

        For i As Integer = 0 To 9
            list.Add(New MyObject(rand.[Next](0, 4), "Name " & i, images(rand.[Next](0, images.Count))))
        Next

        RadGridView1.DataSource = list
        RadGridView1.AutoSizeRows = True
        RadGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill

        'populate the grid with data
        Dim svc As RadDragDropService = Me.RadGridView1.GridViewElement.GetService(Of RadDragDropService)()
        AddHandler svc.PreviewDragStart, AddressOf svc_PreviewDragStart
        AddHandler svc.PreviewDragOver, AddressOf svc_PreviewDragOver

        AddHandler RadGridView1.GroupByChanged, AddressOf radGridView1_GroupByChanged
        RadGridView1.EnableCustomGrouping = True
        AddHandler RadGridView1.CustomGrouping, AddressOf radGridView1_CustomGrouping
        AddHandler RadGridView1.GroupSummaryEvaluate, AddressOf radGridView1_GroupSummaryEvaluate
    End Sub

    Private Sub svc_PreviewDragStart(sender As Object, e As PreviewDragStartEventArgs)
        Dim dragged As SnapshotDragItem = TryCast(e.DragInstance, SnapshotDragItem)
        If dragged IsNot Nothing AndAlso TypeOf dragged.Item Is GridHeaderCellElement Then
            e.CanStart = True
        End If
    End Sub

    Private Sub svc_PreviewDragOver(sender As Object, e As RadDragOverEventArgs)
        Dim dragged As SnapshotDragItem = TryCast(e.DragInstance, SnapshotDragItem)
        If dragged IsNot Nothing AndAlso TypeOf dragged.Item Is GridHeaderCellElement Then
            e.CanDrop = TypeOf e.HitTarget Is GroupPanelElement
        End If
    End Sub

    Private Sub radGridView1_GroupByChanged(sender As Object, e As GridViewCollectionChangedEventArgs)
        If Me.RadGridView1.GridViewElement.GroupPanelElement.PanelContainer.Children IsNot Nothing AndAlso Me.RadGridView1.GridViewElement.GroupPanelElement.PanelContainer.Children.Count > 0 Then
            Dim templateGroupsElement As TemplateGroupsElement = TryCast(RadGridView1.GridViewElement.GroupPanelElement.PanelContainer.Children(0), TemplateGroupsElement)
            If templateGroupsElement IsNot Nothing Then
                For Each groupElement As GroupElement In templateGroupsElement.GroupElements
                    For Each groupFieldsElement As GroupFieldElement In groupElement.GroupingFieldElements
                        If groupFieldsElement.RemoveButton.Visibility <> ElementVisibility.Visible Then
                            groupFieldsElement.RemoveButton.Visibility = ElementVisibility.Visible
                        End If
                    Next
                Next
            End If
        End If
    End Sub

    Private Sub radGridView1_CustomGrouping(sender As Object, e As GridViewCustomGroupingEventArgs)
        If Me.UseDefaultGrouping(e.Level) Then
            e.Handled = False
            Return
        End If
        Dim photo As Image = TryCast(e.Row.Cells("Photo").Value, Image)
        Dim index As Integer = images.IndexOf(photo)

        Select Case index
            Case 0
                e.GroupKey = "open"

                Exit Select
            Case 1
                e.GroupKey = "paste"
                Exit Select
            Case 2
                e.GroupKey = "pdf"
                Exit Select
            Case Else
                e.GroupKey = "Other image"
                Exit Select
        End Select
    End Sub

    Private Function UseDefaultGrouping(level As Integer) As Boolean
        Dim groupDescriptor As Telerik.WinControls.Data.GroupDescriptor = Me.RadGridView1.GroupDescriptors(level)
        For i As Integer = 0 To groupDescriptor.GroupNames.Count - 1
            If groupDescriptor.GroupNames(i).PropertyName.Equals("Photo", StringComparison.InvariantCultureIgnoreCase) Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub radGridView1_GroupSummaryEvaluate(sender As Object, e As GroupSummaryEvaluationEventArgs)
        If Me.UseDefaultGrouping(e.Group.Level) Then
            Return
        End If

        If e.Value Is Nothing Then
            e.FormatString = "Photo """ + e.Group.Key.ToString() + """"
        End If
    End Sub

    Public Class MyObject
        Public Property ID() As Integer
            Get
                Return m_ID
            End Get
            Set(value As Integer)
                m_ID = value
            End Set
        End Property
        Private m_ID As Integer

        Public Property Title() As String
            Get
                Return m_Title
            End Get
            Set(value As String)
                m_Title = value
            End Set
        End Property
        Private m_Title As String

        Public Property Photo() As Image
            Get
                Return m_Photo
            End Get
            Set(value As Image)
                m_Photo = value
            End Set
        End Property
        Private m_Photo As Image

        Public Sub New(iD As Integer, title As String, photo As Image)
            Me.ID = iD
            Me.Title = title
            Me.Photo = photo
        End Sub
    End Class

End Class
