Imports Telerik.WinControls.UI

Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim node1 As New RadTreeNode("Node1")
        Dim node2 As New RadTreeNode("Node2")
        Dim node3 As New RadTreeNode("Node3")
        Dim node4 As New RadTreeNode("Node4")
        Dim node5 As New RadTreeNode("Node5")
        Dim node6 As New RadTreeNode("Node6")
        Dim node7 As New RadTreeNode("Node7")
        Dim node8 As New RadTreeNode("Node8")
        Dim node9 As New RadTreeNode("Node9")
        Dim node10 As New RadTreeNode("Node10")

        node1.Nodes.Add(node2)
        node1.Nodes.Add(node3)

        node4.Nodes.Add(node5)
        node4.Nodes.Add(node6)

        node6.Nodes.Add(node7)

        Me.RadReadOnlyTreeView1.Nodes.Add(node1)
        Me.RadReadOnlyTreeView1.Nodes.Add(node4)
        Me.RadReadOnlyTreeView1.Nodes.Add(node8)
        Me.RadReadOnlyTreeView1.Nodes.Add(node9)
        Me.RadReadOnlyTreeView1.Nodes.Add(node10)

        Me.RadReadOnlyTreeView1.CheckBoxes = True
    End Sub

    Private Sub RadCheckBox1_ToggleStateChanged(sender As System.Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles RadCheckBox1.ToggleStateChanged
        Me.RadReadOnlyTreeView1.BeginUpdate()
        Me.RadReadOnlyTreeView1.CheckBoxReadOnly = (RadCheckBox1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On)
        Me.RadReadOnlyTreeView1.EndUpdate()
    End Sub
End Class
