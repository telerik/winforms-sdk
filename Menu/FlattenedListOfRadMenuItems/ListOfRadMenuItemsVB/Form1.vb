Imports Telerik.WinControls.UI
Imports System.Collections.ObjectModel

Public Class Form1

    Public Sub New()
        InitializeComponent()

        Debug.Assert(GetRadTreeNodes(RadTreeView1.Nodes).Count = 10)
        Debug.Assert(GetRadMenuItems(RadMenu1.Items).Count = 10)

    End Sub

    Public Shared Function GetRadTreeNodes(ByVal nodes As Telerik.WinControls.UI.RadTreeNodeCollection) As ReadOnlyCollection(Of RadTreeNode)
        Dim returnNodes As New List(Of RadTreeNode)()
        For Each node As RadTreeNode In nodes
            returnNodes.Add(node)
            Dim subNodes As ReadOnlyCollection(Of RadTreeNode) = GetRadTreeNodes(node.Nodes)
            returnNodes.AddRange(subNodes)
        Next
        Dim readOnlyNodes As New ReadOnlyCollection(Of RadTreeNode)(returnNodes)
        Return readOnlyNodes
    End Function

    Public Shared Function GetRadMenuItems(ByVal items As Telerik.WinControls.RadItemCollection) As ReadOnlyCollection(Of RadMenuItemBase)
        Dim returnItems As New List(Of RadMenuItemBase)()
        For Each item As RadMenuItemBase In items
            returnItems.Add(item)
            Dim subItems As ReadOnlyCollection(Of RadMenuItemBase) = GetRadMenuItems(item.Items)
            returnItems.AddRange(subItems)
        Next
        Dim readOnlyItems As New ReadOnlyCollection(Of RadMenuItemBase)(returnItems)
        Return readOnlyItems
    End Function

End Class
