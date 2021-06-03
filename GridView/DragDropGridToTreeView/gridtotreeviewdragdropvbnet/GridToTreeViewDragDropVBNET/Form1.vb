Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Public Class Form1


    Public Sub New()
        InitializeComponent()

        'populate with data
        Dim col As New GridViewTextBoxColumn("col")
        col.Width = 200
        RadGridView1.Columns.Add(col)

        For i As Integer = 0 To 9
            RadGridView1.Rows.Add("Row " & i)
            RadTreeView1.Nodes.Add("Node " & i)
        Next

        'register the custom row behavior
        Dim gridBehavior = TryCast(Me.RadGridView1.GridBehavior, BaseGridBehavior)
        gridBehavior.UnregisterBehavior(GetType(GridViewDataRowInfo))
        gridBehavior.RegisterBehavior(GetType(GridViewDataRowInfo), New CustomGridDataRowBehavior())

        Dim dragDropService As RadDragDropService = RadGridView1.GridViewElement.GetService(Of RadDragDropService)()
        AddHandler dragDropService.PreviewDragStart, AddressOf dragDropService_PreviewDragStart
        AddHandler dragDropService.PreviewDragOver, AddressOf dragDropService_PreviewDragOver
        AddHandler dragDropService.PreviewDragDrop, AddressOf dragDropService_PreviewDragDrop
        AddHandler dragDropService.PreviewDragHint, AddressOf dragDropService_PreviewDragHint
        AddHandler dragDropService.Stopped, AddressOf dragDropService_Stopped
    End Sub

    Private Sub dragDropService_PreviewDragStart(sender As Object, e As PreviewDragStartEventArgs)
        e.CanStart = True
    End Sub
    
    Private Sub dragDropService_PreviewDragHint(sender As Object, e As PreviewDragHintEventArgs)
        e.UseDefaultHint = False
    End Sub

    Private dropHintWindow As New RadLayeredWindow()
    Private Sub dragDropService_PreviewDragOver(sender As Object, e As RadDragOverEventArgs)
        dropHintWindow.Hide()

        If TypeOf e.DragInstance Is GridDataRowElement Then
            If TypeOf e.HitTarget Is RadTreeViewElement Then
                e.CanDrop = True
            ElseIf TypeOf e.HitTarget Is TreeNodeElement Then
                e.CanDrop = True
                SetHintWindowPosition(MousePosition, DirectCast(e.HitTarget, TreeNodeElement), e.DragInstance.GetDragHint())
            End If
        End If
    End Sub

    Protected Sub SetHintWindowPosition(mousePt As Point, nodeElement As TreeNodeElement, originalHintImage As Image)
        dropHintWindow.Hide()

        Dim point__1 As Point = Me.RadTreeView1.ElementTree.Control.PointToClient(mousePt)
        point__1 = nodeElement.PointFromScreen(mousePt)
        Dim dropPosition__2 As DropPosition = Me.GetDropPosition(point__1, nodeElement)
        Dim dropPositionImage As Image = Nothing

        Select Case dropPosition__2
            Case DropPosition.None
                Exit Select
            Case DropPosition.BeforeNode
                dropPositionImage = My.Resources.RadTreeViewDropBefore
                Exit Select
            Case DropPosition.AfterNode
                dropPositionImage = My.Resources.RadTreeViewDropAfter
                Exit Select
            Case DropPosition.AsChildNode
                dropPositionImage = My.Resources.RadTreeViewDropAsChild
                Exit Select
        End Select

        Dim offset As Integer = 10
        Dim newHintImage As New Bitmap(originalHintImage.Width + dropPositionImage.Width + offset, Math.Max(originalHintImage.Height, dropPositionImage.Height))

        Using g As Graphics = Graphics.FromImage(newHintImage)
            g.Clear(Color.White)
            g.DrawImage(dropPositionImage, Point.Empty)
            g.DrawImage(originalHintImage, New Point(dropPositionImage.Width + offset, 0))
            g.DrawRectangle(Pens.LightGray, New Rectangle(0, 0, newHintImage.Width - 1, newHintImage.Height - 1))
        End Using

        dropHintWindow.TopMost = True
        dropHintWindow.BackgroundImage = newHintImage
        dropHintWindow.ShowWindow(mousePt)
    End Sub

    Protected Function GetDropPosition(dropLocation As Point, targetNodeElement As TreeNodeElement) As DropPosition
        Dim part As Integer = targetNodeElement.Size.Height / 3
        Dim mouseY As Integer = dropLocation.Y
        Dim dropAtTop As Boolean = mouseY < part

        If dropAtTop Then
            Return DropPosition.BeforeNode
        End If

        If mouseY >= part AndAlso mouseY <= part * 2 Then
            Return DropPosition.AsChildNode
        End If

        Return DropPosition.AfterNode
    End Function

    Private Sub dragDropService_PreviewDragDrop(sender As Object, e As RadDropEventArgs)
        Dim rowElement As GridDataRowElement = TryCast(e.DragInstance, GridDataRowElement)
        If rowElement Is Nothing Then
            Return
        End If
        Dim sourceText As String = rowElement.RowInfo.Cells(0).Value.ToString()
        Dim targetNodeElement As TreeNodeElement = TryCast(e.HitTarget, TreeNodeElement)
        If targetNodeElement IsNot Nothing Then
            Dim treeViewElement As RadTreeViewElement = targetNodeElement.TreeViewElement
            Dim targetNode As RadTreeNode = targetNodeElement.Data
            Dim dropPosition__1 As DropPosition = Me.GetDropPosition(e.DropLocation, targetNodeElement)

            Select Case dropPosition__1
                Case DropPosition.None
                    Exit Select
                Case DropPosition.BeforeNode
                    RadGridView1.Rows.Remove(rowElement.RowInfo)

                    Dim nodes As RadTreeNodeCollection = If(targetNode.Parent Is Nothing, treeViewElement.Nodes, targetNode.Parent.Nodes)
                    nodes.Insert(targetNode.Index, New RadTreeNode(sourceText))

                    Exit Select
                Case DropPosition.AfterNode
                    RadGridView1.Rows.Remove(rowElement.RowInfo)

                    Dim nodes1 As RadTreeNodeCollection = If(targetNode.Parent Is Nothing, treeViewElement.Nodes, targetNode.Parent.Nodes)
                    Dim targetIndex As Integer = If(targetNodeElement.Data.Index <= treeViewElement.Nodes.Count - 1, _
                                                    (targetNodeElement.Data.Index + 1), treeViewElement.Nodes.Count - 1)
                    nodes1.Insert(targetIndex, New RadTreeNode(sourceText))

                    Exit Select
                Case DropPosition.AsChildNode
                    RadGridView1.Rows.Remove(rowElement.RowInfo)

                    targetNode.Nodes.Add(New RadTreeNode(sourceText))

                    Exit Select
            End Select
        End If

        Dim treeElement As RadTreeViewElement = TryCast(e.HitTarget, RadTreeViewElement)
        If treeElement IsNot Nothing Then
            RadGridView1.Rows.Remove(rowElement.RowInfo)
            RadTreeView1.Nodes.Add(New RadTreeNode(sourceText))
        End If
    End Sub

    Private Sub dragDropService_Stopped(sender As Object, e As EventArgs)
        dropHintWindow.Hide()
    End Sub
    'initiates drag and drop service for clicked row
    
    Public Class CustomGridDataRowBehavior
    Inherits GridDataRowBehavior
        Protected Overrides Function OnMouseDownLeft(e As MouseEventArgs) As Boolean
            Dim row As GridDataRowElement = TryCast(Me.GetRowAtPoint(e.Location), GridDataRowElement)
            If row IsNot Nothing Then
                Dim svc As RadGridViewDragDropService = Me.GridViewElement.GetService(Of RadGridViewDragDropService)()
                svc.AllowAutoScrollColumnsWhileDragging = False
                svc.AllowAutoScrollRowsWhileDragging = False
                svc.Start(row)
            End If
            Return MyBase.OnMouseDownLeft(e)
        End Function
    End Class
End Class
