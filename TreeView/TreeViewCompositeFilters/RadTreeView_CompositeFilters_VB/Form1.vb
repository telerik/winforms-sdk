Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Data

Public Class Form1

    Private Sub TreeView_SelectedNodeChanged(sender As System.Object, e As Telerik.WinControls.UI.RadTreeViewEventArgs) Handles TreeView.SelectedNodeChanged
        Me.CommandBarTextBoxFilter.Text = e.Node.Text
    End Sub

    Private Sub CommandBarButtonAddFilter_Click(sender As System.Object, e As System.EventArgs) Handles CommandBarButtonAddFilter.Click
        For Each item As RadListDataItem In Me.ListControlFilters.Items
            If item.Text.ToUpperInvariant = CommandBarTextBoxFilter.Text.ToUpperInvariant() Then
                Exit Sub
            End If
        Next
        Me.ListControlFilters.Items.Add(Me.CommandBarTextBoxFilter.Text)
        Filter()
        Me.CommandBarTextBoxFilter.Text = ""
    End Sub

    Private Sub CommandBarButtonRemoveFilter_Click(sender As System.Object, e As System.EventArgs) Handles CommandBarButtonRemoveFilter.Click
        Me.ListControlFilters.Items.Remove(Me.ListControlFilters.SelectedItem)
        Filter()
    End Sub

    Private Sub ListControlFilters_SelectedIndexChanged(sender As System.Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles ListControlFilters.SelectedIndexChanged
        Me.CommandBarButtonRemoveFilter.Enabled = (Me.ListControlFilters.SelectedItems.Count > 0)
    End Sub

    Private Sub Filter()
        Me.TreeView.FilterDescriptors.Clear()
        If Me.ListControlFilters.Items.Count > 0 Then
            Dim compositeFilter As New CompositeFilterDescriptor()
            For Each item As RadListDataItem In Me.ListControlFilters.Items
                compositeFilter.FilterDescriptors.Add(New FilterDescriptor("Text", FilterOperator.Contains, item.Text))
            Next
            compositeFilter.LogicalOperator = FilterLogicalOperator.Or
            Me.TreeView.FilterDescriptors.Add(compositeFilter)
        End If
    End Sub

    Private Sub CommandBarTextBoxFilter_TextChanged(sender As System.Object, e As System.EventArgs) Handles CommandBarTextBoxFilter.TextChanged
        Me.CommandBarButtonAddFilter.Enabled = (Me.CommandBarTextBoxFilter.Text.Length > 0)
    End Sub

    Private Sub TreeView_NodeFormatting(sender As System.Object, e As Telerik.WinControls.UI.TreeNodeFormattingEventArgs) Handles TreeView.NodeFormatting
        If Me.ListControlFilters.FindStringExact(e.Node.Text) > -1 Then
            e.NodeElement.BackColor = Color.LightGray
            e.NodeElement.NumberOfColors = 1
            e.NodeElement.DrawFill = True
        End If
    End Sub
End Class
