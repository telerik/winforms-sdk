Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Enumerations

Public Class RadForm1
    Private checkBox As RadCheckBoxElement

    Public Sub New()
        InitializeComponent()
        AddHandler Me.RadListView1.VisualItemFormatting, AddressOf radListView1_VisualItemFormatting
        Me.RadListView1.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView

        For i As Integer = 0 To 3 - 1
            Me.RadListView1.Columns.Add("Column " & i)
        Next

        For i As Integer = 0 To 40 - 1
            Dim group As CustomListViewGroupItem = New CustomListViewGroupItem()
            group.Text = "Group " & i
            Me.RadListView1.Groups.Add(group)

            For j As Integer = 0 To 3 - 1
                Dim item As ListViewDataItem = New ListViewDataItem()
                Me.RadListView1.Items.Add(item)
                item(0) = i
                item(1) = j
                item(2) = "Item " & (10 * i + j)
                item.Group = group
            Next
        Next
        
        Me.RadListView1.EnableCustomGrouping = True
        Me.RadListView1.ShowGroups = True
        Me.RadListView1.ShowCheckBoxes = True
        Me.checkBox = New RadCheckBoxElement()
        Me.checkBox.Margin = New Padding(0, 10, 0, 0)
        AddHandler Me.checkBox.ToggleStateChanged, AddressOf checkBox_ToggleStateChanged
        Me.checkBox.ZIndex = 1000
        Me.checkBox.Alignment = ContentAlignment.TopLeft
        Me.checkBox.StretchHorizontally = False
        Me.checkBox.StretchVertically = False
        Me.checkBox.IsThreeState = True
        Me.RadListView1.ListViewElement.Children.Add(Me.checkBox)
        AddHandler Me.RadListView1.ItemCheckedChanged, AddressOf radListView1_ItemCheckedChanged
        AddHandler Me.RadListView1.VisualItemCreating, AddressOf radListView1_VisualItemCreating
        AddHandler Me.RadListView1.MouseUp, AddressOf radListView1_MouseUp
    End Sub

    Private Sub radListView1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
        Me.RadListView1.ListViewElement.SynchronizeVisualItems()
    End Sub

    Private Sub radListView1_VisualItemFormatting(ByVal sender As Object, ByVal e As ListViewVisualItemEventArgs)
        Dim visualItem As DetailListViewVisualItem = TryCast(e.VisualItem, DetailListViewVisualItem)

        If visualItem IsNot Nothing Then
            e.VisualItem.Margin = New Padding(20, 0, 0, 0)
        Else
            e.VisualItem.Margin = New Padding(0)
        End If
    End Sub

    Private Sub checkBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
        If Me.checkBox.ToggleState = ToggleState.Indeterminate Then
            Me.checkBox.ToggleState = ToggleState.Off
            Return
        End If

        Me.RadListView1.BeginUpdate()
        RemoveHandler Me.RadListView1.ItemCheckedChanged, AddressOf radListView1_ItemCheckedChanged

        For Each item As ListViewDataItem In Me.RadListView1.Items
            item.CheckState = Me.checkBox.ToggleState
        Next

        Me.RadListView1.EndUpdate()
        AddHandler Me.RadListView1.ItemCheckedChanged, AddressOf radListView1_ItemCheckedChanged
    End Sub

    Private Sub radListView1_ItemCheckedChanged(ByVal sender As Object, ByVal e As ListViewItemEventArgs)
        RemoveHandler Me.checkBox.ToggleStateChanged, AddressOf checkBox_ToggleStateChanged
        Dim checkState As ToggleState = ToggleState.Off

        For i As Integer = 0 To Me.RadListView1.Items.Count - 1

            If i = 0 Then
                checkState = Me.RadListView1.Items(0).CheckState
            ElseIf Me.RadListView1.Items(i).CheckState <> Me.RadListView1.Items(i - 1).CheckState Then
                checkState = ToggleState.Indeterminate
                Exit For
            End If
        Next

        Me.checkBox.ToggleState = checkState
        AddHandler Me.checkBox.ToggleStateChanged, AddressOf checkBox_ToggleStateChanged
        Me.RadListView1.ListViewElement.SynchronizeVisualItems()
    End Sub

    Private Sub radListView1_ItemCreating(ByVal sender As Object, ByVal e As ListViewItemCreatingEventArgs)
        If TypeOf e.Item Is ListViewDataItemGroup Then
            e.Item = New CustomListViewGroupItem()
        End If
    End Sub

    Private Sub radListView1_VisualItemCreating(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.ListViewVisualItemCreatingEventArgs)
        If TypeOf e.VisualItem Is DetailListViewGroupVisualItem Then
            e.VisualItem = New CustomVisualGroupItem()
        End If
    End Sub

    Private Sub RadForm1_Load(ByVal sender As Object, ByVal e As EventArgs)
    End Sub

    Public Class CustomListViewGroupItem
    Inherits ListViewDataItemGroup

        Public Overrides Property CheckState As ToggleState
            Get
                Dim hasItems As Boolean = False
                Dim previousState As ToggleState = ToggleState.Off

                For Each item As ListViewDataItem In Me.Items

                    If Not hasItems Then
                        hasItems = True
                    Else

                        If item.CheckState <> previousState Then
                            Return ToggleState.Indeterminate
                        End If
                    End If

                    previousState = item.CheckState
                Next

                Return previousState
            End Get
            Set(ByVal value As ToggleState)
                Dim stateToSet As ToggleState = If(value <> ToggleState.[On], ToggleState.Off, ToggleState.[On])
                Me.Owner.BeginUpdate()

                For Each item As ListViewDataItem In Me.Items
                    item.CheckState = stateToSet
                Next

                Me.Owner.EndUpdate()
            End Set
        End Property

        Private Class CSharpImpl
            <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
            Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
                target = value
                Return value
            End Function
        End Class
    End Class

    Public Class CustomVisualGroupItem
    Inherits DetailListViewGroupVisualItem

        Private checkBox As RadCheckBoxElement

        Public Overrides Function IsCompatible(ByVal data As ListViewDataItem, ByVal context As Object) As Boolean
            Return TypeOf data Is CustomListViewGroupItem
        End Function

        Protected Overrides Sub CreateChildElements()
            MyBase.CreateChildElements()
            Me.checkBox = New RadCheckBoxElement()
            checkBox.StretchHorizontally = False
            Me.checkBox.Alignment = System.Drawing.ContentAlignment.MiddleLeft
            AddHandler Me.checkBox.ToggleStateChanged, AddressOf checkBox_ToggleStateChanged
            Me.Padding = New System.Windows.Forms.Padding(16, 0, 0, 0)
            Me.checkBox.Margin = New System.Windows.Forms.Padding(-16, 0, 0, 0)
            Me.checkBox.IsThreeState = True
            Me.Children.Add(checkBox)
        End Sub

        Private Sub checkBox_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs)
            If Me.Data IsNot Nothing Then
                Me.Data.CheckState = checkBox.ToggleState
            End If
        End Sub

        Protected Overrides Sub SynchronizeProperties()
            MyBase.SynchronizeProperties()
            RemoveHandler Me.checkBox.ToggleStateChanged, AddressOf checkBox_ToggleStateChanged
            Me.checkBox.ToggleState = Me.Data.CheckState
            AddHandler Me.checkBox.ToggleStateChanged, AddressOf checkBox_ToggleStateChanged
        End Sub

        Protected Overrides ReadOnly Property ThemeEffectiveType As Type
            Get
                Return GetType(DetailListViewGroupVisualItem)
            End Get
        End Property
         
    End Class

     
End Class
