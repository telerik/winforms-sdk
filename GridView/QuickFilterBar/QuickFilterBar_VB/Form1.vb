Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Public Class Form1

    Private m_FilterCancelButton As RadButtonElement
    Private m_FilterLabel As RadLabelElement

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.RadGridView1.EnableFiltering = True
        Me.RadGridView1.ShowFilteringRow = True

        Me.RadGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.None
        Me.RadGridView1.Columns.Add(New GridViewTextBoxColumn("Name"))
        Me.RadGridView1.Columns.Add(New GridViewDecimalColumn("Value"))

        Dim rowInfo As GridViewRowInfo = Me.RadGridView1.Rows.AddNew()
        rowInfo.Cells(0).Value = "A1"
        rowInfo.Cells(1).Value = 3
        rowInfo = Me.RadGridView1.Rows.AddNew()
        rowInfo.Cells(0).Value = "A2"
        rowInfo.Cells(1).Value = 4
        rowInfo = Me.RadGridView1.Rows.AddNew()
        rowInfo.Cells(0).Value = "A3"
        rowInfo.Cells(1).Value = 5
        rowInfo = Me.RadGridView1.Rows.AddNew()
        rowInfo.Cells(0).Value = "A4"
        rowInfo.Cells(1).Value = 6
        rowInfo = Me.RadGridView1.Rows.AddNew()
        rowInfo.Cells(0).Value = "A2"
        rowInfo.Cells(1).Value = 4
        rowInfo = Me.RadGridView1.Rows.AddNew()
        rowInfo.Cells(0).Value = "A3"
        rowInfo.Cells(1).Value = 5
        rowInfo = Me.RadGridView1.Rows.AddNew()
        rowInfo.Cells(0).Value = "A4"
        rowInfo.Cells(1).Value = 6


        Dim statusBar As New RadStatusStrip()
        statusBar.StatusBarElement.GripStyle = ToolStripGripStyle.Hidden

        m_FilterCancelButton = New RadButtonElement()
        m_FilterCancelButton.Text = "-"
        AddHandler m_FilterCancelButton.MouseDown, AddressOf FilterCancelButton_MouseDown

        m_FilterLabel = New RadLabelElement()
        m_FilterLabel.Text = " Currently Unfiltered"

        statusBar.Items.Add(m_FilterCancelButton)
        statusBar.Items.Add(m_FilterLabel)

        Dim hostItem As New RadHostItem(statusBar)
        hostItem.MinSize = New Size(0, 25)
        Me.RadGridView1.GridViewElement.Panel.Children.Insert(1, hostItem)
        Telerik.WinControls.Layouts.DockLayoutPanel.SetDock(hostItem, Telerik.WinControls.Layouts.Dock.Bottom)

    End Sub

    Private Sub FilterCancelButton_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
        Me.RadGridView1.FilterDescriptors.Clear()
    End Sub

    Private Sub RadGridView1_FilterExpressionChanged(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.FilterExpressionChangedEventArgs) Handles RadGridView1.FilterExpressionChanged
        If e.FilterExpression.Length > 0 Then
            m_FilterLabel.Text = e.FilterExpression
        Else
            If m_FilterLabel IsNot Nothing Then
                m_FilterLabel.Text = "Currently unfiltered"
            End If
        End If
    End Sub

End Class
