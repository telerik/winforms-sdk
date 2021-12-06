Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports System.Windows.Forms

Public Class RadForm1
    Private externalSource As DataTable = New DataTable()
    Public Shared columnWidth As Integer = 220
    Public Shared borderColor As Color = Color.FromArgb(21, 215, 255)

    Public Sub New()
        InitializeComponent()
        externalSource.Columns.Add("Id", GetType(String))
        externalSource.Columns.Add("ParentId", GetType(String))
        externalSource.Columns.Add("Title", GetType(String))
        externalSource.Columns.Add("Date", GetType(DateTime))
        externalSource.Columns.Add("DeliveryType", GetType(DeliveryType))
        Dim id As String = String.Empty
        Dim childId As String = String.Empty

        For i As Integer = 0 To 100 - 1
            id = Guid.NewGuid().ToString()
            externalSource.Rows.Add(id, Nothing, "Root " & i, DateTime.Now.AddDays(i).AddHours(i), If(i Mod 2 = 0, DeliveryType.PickUp, DeliveryType.Delivery))

            For j As Integer = 0 To 20 - 1
                childId = Guid.NewGuid().ToString()
                externalSource.Rows.Add(childId, id, "Child " & i & "." & j, DateTime.Now.AddDays(i).AddHours(i), If(j Mod 2 = 0, DeliveryType.PickUp, DeliveryType.Delivery))

                For k As Integer = 0 To 5 - 1
                    externalSource.Rows.Add(Guid.NewGuid().ToString(), childId, "Child " & i & "." & j & "." & k, DateTime.Now.AddDays(i).AddHours(i), If(j Mod 2 = 0, DeliveryType.PickUp, DeliveryType.Delivery))
                Next
            Next
        Next

        AddHandler Me.RadTreeView1.TreeViewElement.CreateNodeElement, AddressOf TreeViewElement_CreateNodeElement
        Me.RadTreeView1.LazyMode = True
        AddHandler Me.RadTreeView1.NodesNeeded, AddressOf radTreeView1_NodesNeeded
        Me.RadTreeView1.ItemHeight = 50
        Me.RadTreeView1.AllowEdit = True
        Me.RadTreeView1.TreeViewElement.EditMode = TreeNodeEditMode.Text
        AddHandler Me.RadTreeView1.EditorRequired, AddressOf radTreeView1_EditorRequired
        AddHandler Me.RadTreeView1.EditorInitialized, AddressOf RadTreeView1_EditorInitialized
    End Sub

    Private Sub RadTreeView1_EditorInitialized(ByVal sender As Object, ByVal e As TreeNodeEditorInitializedEventArgs)
    End Sub

    Private Sub radTreeView1_EditorRequired(ByVal sender As Object, ByVal e As TreeNodeEditorRequiredEventArgs)
        e.Editor = New CustomRadTreeViewEditor()
    End Sub

    Private Sub TreeViewElement_CreateNodeElement(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.CreateTreeNodeElementEventArgs)
        e.NodeElement = New CustomTreeNodeElement()
    End Sub

    Private Sub radTreeView1_NodesNeeded(ByVal sender As Object, ByVal e As NodesNeededEventArgs)
        LoadNodesForParent(e.Parent, e.Nodes)
    End Sub

    Private Sub LoadNodesForParent(ByVal parentNode As RadTreeNode, ByVal nodes As IList(Of RadTreeNode))
        If parentNode Is Nothing Then

            For Each row As DataRow In externalSource.Rows

                If row("ParentId") Is Nothing OrElse row("ParentId").Equals(System.DBNull.Value) Then
                    nodes.Add(New RadTreeNode() With {
                        .Text = row("Title").ToString(),
                        .Tag = row,
                        .Value = row("Id")
                    })
                End If
            Next
        Else

            For Each row As DataRow In externalSource.Rows

                If row("ParentId").ToString() = parentNode.Value.ToString() Then
                    nodes.Add(New RadTreeNode() With {
                        .Text = row("Title").ToString(),
                        .Tag = row,
                        .Value = row("Id")
                    })
                End If
            Next
        End If
    End Sub

    Public Enum DeliveryType
        PickUp
        Delivery
    End Enum

    Public Class CustomTreeNodeElement
        Inherits TreeNodeElement

        Protected Overrides Function CreateContentElement() As TreeNodeContentElement
            Return New CustomContentElement()
        End Function

        Protected Overrides ReadOnly Property ThemeEffectiveType As Type
            Get
                Return GetType(TreeNodeElement)
            End Get
        End Property
    End Class

    Class CustomContentElement
        Inherits TreeNodeContentElement

        Private mainContainer As StackLayoutElement
        Private headersContainer As StackLayoutElement
        Private nodeContentContainer As StackLayoutElement

        Protected Overrides ReadOnly Property ThemeEffectiveType As Type
            Get
                Return GetType(TreeNodeContentElement)
            End Get
        End Property

        Protected Overrides Sub CreateChildElements()
            MyBase.CreateChildElements()
            mainContainer = New StackLayoutElement()
            mainContainer.Orientation = Orientation.Vertical
            headersContainer = New StackLayoutElement()
            nodeContentContainer = New StackLayoutElement()
            mainContainer.Children.Add(headersContainer)
            mainContainer.Children.Add(nodeContentContainer)
            Me.Children.Add(mainContainer)
        End Sub

        Public Overrides Sub Synchronize()
            MyBase.Synchronize()
            Me.DrawText = False
            Dim row As DataRow = TryCast(Me.NodeElement.Data.Tag, DataRow)

            If row IsNot Nothing Then
                mainContainer.MinSize = New Size(columnWidth * row.Table.Columns.Count, Me.NodeElement.Data.TreeView.ItemHeight)

                If headersContainer.Children.Count = 0 Then

                    For Each col As DataColumn In row.Table.Columns
                        Dim columnHeader As LightVisualElement = New LightVisualElement()
                        columnHeader.Margin = New Padding(0, 0, -1, 0)
                        columnHeader.MinSize = New System.Drawing.Size(columnWidth, 20)
                        columnHeader.StretchHorizontally = True
                        columnHeader.Text = col.ColumnName
                        headersContainer.Children.Add(columnHeader)
                        StyleBorder(columnHeader)
                        Dim contentCell As LightVisualElement = New LightVisualElement()
                        contentCell.Margin = New System.Windows.Forms.Padding(0, -1, -1, 0)
                        StyleBorder(contentCell)
                        contentCell.MinSize = New System.Drawing.Size(columnWidth, 24)
                        nodeContentContainer.Children.Add(contentCell)
                    Next
                End If

                For i As Integer = 0 To nodeContentContainer.Children.Count - 1
                    Dim contentCell As LightVisualElement = TryCast(nodeContentContainer.Children(i), LightVisualElement)
                    Dim text As String = row(i).ToString()
                    Dim dt As DateTime = DateTime.MinValue

                    If i = nodeContentContainer.Children.Count - 2 Then

                        If DateTime.TryParse(text, dt) Then
                            text = dt.ToString("dd/MM/yyyy")
                        End If
                    ElseIf i = nodeContentContainer.Children.Count - 1 Then
                        text = [Enum].GetName(GetType(DeliveryType), row(i))
                    End If

                    contentCell.Text = text
                Next
            End If
        End Sub

        Private Class CSharpImpl
            <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
            Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
                target = value
                Return value
            End Function
        End Class
    End Class

    Private Shared Sub StyleBorder(ByVal element As LightVisualElement)
        element.DrawBorder = True
        element.BorderGradientStyle = GradientStyles.Solid
        element.BorderColor = borderColor
    End Sub

    Public Class CustomRadTreeViewEditor
        Inherits BaseInputEditor

        Protected Overrides Function CreateEditorElement() As RadElement
            Return New CustomRadTreeViewEditorElement()
        End Function

        Public Overloads ReadOnly Property EditorElement As CustomRadTreeViewEditorElement
            Get
                Return TryCast(MyBase.EditorElement, CustomRadTreeViewEditorElement)
            End Get
        End Property

        Public Overrides ReadOnly Property DataType As Type
            Get
                Return GetType(String)
            End Get
        End Property

        Public Overrides Property Value As Object
            Get
                Dim nodeElement As TreeNodeContentElement = TryCast(Me.EditorElement.Parent, TreeNodeContentElement)
                Dim row As DataRow = TryCast(nodeElement.NodeElement.Data.Tag, DataRow)
                Return row
            End Get
            Set(ByVal value As Object)
            End Set
        End Property

        Public Overrides Sub BeginEdit()
            MyBase.BeginEdit()
            Dim nodeElement As TreeNodeContentElement = TryCast(Me.EditorElement.Parent, TreeNodeContentElement)
            nodeElement.NodeElement.Data.Image = My.Resources.pen
        End Sub

        Public Overrides Function EndEdit() As Boolean
            Dim nodeElement As TreeNodeContentElement = TryCast(Me.EditorElement.Parent, TreeNodeContentElement)
            nodeElement.NodeElement.Data.Image = Nothing
            Return MyBase.EndEdit()
        End Function

        Public Class CustomRadTreeViewEditorElement
            Inherits BaseTextBoxEditorElement

            Private mainContainer As StackLayoutElement
            Private headersContainer As StackLayoutElement
            Private nodeContentContainer As StackLayoutElement
            Private dropDownList As RadDropDownListElement
            Private dateEditor As RadDateTimeEditorElement
            Private idEditor As LightVisualElement
            Private parentIdEditor As LightVisualElement
            Private titleEditor As RadTextBoxControlElement

            Protected Overrides Sub CreateChildElements()
                mainContainer = New StackLayoutElement()
                mainContainer.Orientation = Orientation.Vertical
                mainContainer.StretchHorizontally = True
                mainContainer.StretchVertically = True
                headersContainer = New StackLayoutElement()
                headersContainer.Orientation = Orientation.Horizontal
                nodeContentContainer = New StackLayoutElement()
                nodeContentContainer.StretchHorizontally = True
                mainContainer.Children.Add(headersContainer)
                mainContainer.Children.Add(nodeContentContainer)
                Me.Children.Add(mainContainer)
                dropDownList = New RadDropDownListElement()
            End Sub

            Protected Overrides Sub OnLoaded()
                MyBase.OnLoaded()

                If Me.Children.Contains(Me.TextBoxItem) Then
                    Me.Children.Remove(Me.TextBoxItem)
                End If

                Dim nodeElement As TreeNodeContentElement = TryCast(Me.Parent, TreeNodeContentElement)

                If nodeElement.NodeElement.Data IsNot Nothing Then
                    Dim row As DataRow = TryCast(nodeElement.NodeElement.Data.Tag, DataRow)
                    mainContainer.MinSize = New Size(columnWidth * row.Table.Columns.Count, nodeElement.NodeElement.Data.TreeView.ItemHeight)
                    mainContainer.DrawFill = True
                    mainContainer.GradientStyle = GradientStyles.Solid
                    mainContainer.BackColor = nodeElement.NodeElement.BackColor
                    mainContainer.Margin = New Padding(-2, -4, 0, 0)

                    If headersContainer.Children.Count = 0 Then

                        For Each col As DataColumn In row.Table.Columns
                            Dim columnHeader As LightVisualElement = New LightVisualElement()
                            columnHeader.MinSize = New System.Drawing.Size(columnWidth, 20)
                            columnHeader.StretchHorizontally = True
                            columnHeader.Text = col.ColumnName
                            headersContainer.Children.Add(columnHeader)
                            StyleBorder(columnHeader)

                            If col.ColumnName = "DeliveryType" Then
                                Me.dropDownList = New RadDropDownListElement()
                                Me.dropDownList.DropDownStyle = RadDropDownStyle.DropDownList
                                Me.dropDownList.MinSize = New System.Drawing.Size(columnWidth, 0)
                                nodeContentContainer.Children.Add(Me.dropDownList)
                                Me.dropDownList.DataSource = [Enum].GetValues(GetType(DeliveryType))
                                AddHandler Me.dropDownList.SelectedValueChanged, AddressOf DropDownList_SelectedValueChanged
                            ElseIf col.ColumnName = "Date" Then
                                Me.dateEditor = New RadDateTimeEditorElement()
                                Me.dateEditor.Format = DateTimePickerFormat.Custom
                                Me.dateEditor.CustomFormat = "dd/MM/yyyy"
                                Me.dateEditor.MinSize = New System.Drawing.Size(columnWidth, 20)
                                nodeContentContainer.Children.Add(Me.dateEditor)
                                AddHandler Me.dateEditor.ValueChanged, AddressOf DateEditor_ValueChanged
                            ElseIf col.ColumnName = "Id" Then
                                Me.idEditor = New LightVisualElement()
                                Me.idEditor.StretchVertically = True
                                Me.idEditor.MinSize = New System.Drawing.Size(columnWidth, 24)
                                StyleBorder(Me.idEditor)
                                nodeContentContainer.Children.Add(Me.idEditor)
                            ElseIf col.ColumnName = "ParentId" Then
                                Me.parentIdEditor = New LightVisualElement()
                                Me.parentIdEditor.MinSize = New System.Drawing.Size(columnWidth, 20)
                                Me.parentIdEditor.Margin = New System.Windows.Forms.Padding(0, -1, 0, 0)
                                StyleBorder(Me.parentIdEditor)
                                nodeContentContainer.Children.Add(Me.parentIdEditor)
                            ElseIf col.ColumnName = "Title" Then
                                Me.titleEditor = New RadTextBoxControlElement()
                                Me.titleEditor.Margin = New System.Windows.Forms.Padding(0, -1, 0, 0)
                                StyleBorder(Me.titleEditor)
                                Me.titleEditor.MinSize = New System.Drawing.Size(columnWidth, 20)
                                nodeContentContainer.Children.Add(Me.titleEditor)
                                AddHandler Me.titleEditor.TextChanged, AddressOf TitleEditor_TextChanged
                            End If
                        Next
                    End If

                    RemoveHandler Me.dropDownList.SelectedValueChanged, AddressOf DropDownList_SelectedValueChanged
                    RemoveHandler Me.dateEditor.ValueChanged, AddressOf DateEditor_ValueChanged
                    RemoveHandler Me.titleEditor.TextChanged, AddressOf TitleEditor_TextChanged
                    Me.idEditor.Text = row("Id").ToString()
                    Me.parentIdEditor.Text = row("ParentId").ToString()
                    Me.titleEditor.Text = row("Title").ToString()
                    Me.dateEditor.Value = CType(row("Date"), DateTime)
                    Me.dropDownList.SelectedValue = row("DeliveryType")
                    AddHandler Me.titleEditor.TextChanged, AddressOf TitleEditor_TextChanged
                    AddHandler Me.dateEditor.ValueChanged, AddressOf DateEditor_ValueChanged
                    AddHandler Me.dropDownList.SelectedValueChanged, AddressOf DropDownList_SelectedValueChanged
                End If
            End Sub

            Private Sub DropDownList_SelectedValueChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.ValueChangedEventArgs)
                Dim nodeElement As TreeNodeContentElement = TryCast(Me.Parent, TreeNodeContentElement)
                Dim row As DataRow = TryCast(nodeElement.NodeElement.Data.Tag, DataRow)
                row("DeliveryType") = Me.dropDownList.SelectedValue
            End Sub

            Private Sub DateEditor_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
                Dim nodeElement As TreeNodeContentElement = TryCast(Me.Parent, TreeNodeContentElement)
                Dim row As DataRow = TryCast(nodeElement.NodeElement.Data.Tag, DataRow)
                row("Date") = Me.dateEditor.Value
            End Sub

            Private Sub TitleEditor_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
                Dim nodeElement As TreeNodeContentElement = TryCast(Me.Parent, TreeNodeContentElement)
                Dim row As DataRow = TryCast(nodeElement.NodeElement.Data.Tag, DataRow)
                row("Title") = Me.titleEditor.Text
            End Sub

            Private Class CSharpImpl
                <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
                Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
                    target = value
                    Return value
                End Function
            End Class
        End Class

        Private Class CSharpImpl
            <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
            Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
                target = value
                Return value
            End Function
        End Class
    End Class

End Class
