Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Data

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NwindDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.NwindDataSet.Customers)

        Me.RadMultiColumnComboBox1.AutoFilter = True
        Me.RadMultiColumnComboBox1.DisplayMember = "ContactName"
        RadMultiColumnComboBox1.Text = ""
        Me.BackColor = Color.White
        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.RadMultiColumnComboBox1.DisplayMember
        filter.[Operator] = FilterOperator.Contains
        Me.RadMultiColumnComboBox1.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        RadMultiColumnComboBox1.MultiColumnComboBoxElement.EditorControl.EnableCustomFiltering = True

        AddHandler RadMultiColumnComboBox1.MultiColumnComboBoxElement.EditorControl.CustomFiltering, AddressOf EditorControl_CustomFiltering
        AddHandler RadMultiColumnComboBox1.KeyDown, AddressOf radMultiColumnComboBox1_KeyDown

    End Sub

    Private Sub radMultiColumnComboBox1_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = System.Windows.Forms.Keys.Enter Then
            If Me.radMultiColumnComboBox1.ValueMember <> "" Then
                radMultiColumnComboBox1.SelectedValue = radMultiColumnComboBox1.EditorControl.CurrentRow.Cells(radMultiColumnComboBox1.ValueMember).Value
            Else
                radMultiColumnComboBox1.SelectedValue = radMultiColumnComboBox1.EditorControl.CurrentRow.Cells(radMultiColumnComboBox1.DisplayMember).Value
            End If

            radMultiColumnComboBox1.Text = radMultiColumnComboBox1.EditorControl.CurrentRow.Cells(radMultiColumnComboBox1.DisplayMember).Value.ToString()
            radMultiColumnComboBox1.MultiColumnComboBoxElement.ClosePopup()
            radMultiColumnComboBox1.MultiColumnComboBoxElement.TextBoxElement.TextBoxItem.SelectAll()
        End If
    End Sub
    
    Private Sub EditorControl_CustomFiltering(sender As Object, e As Telerik.WinControls.UI.GridViewCustomFilteringEventArgs)
        Dim element As RadMultiColumnComboBoxElement = RadMultiColumnComboBox1.MultiColumnComboBoxElement

        Dim textToSearch As String = RadMultiColumnComboBox1.Text
        If AutoCompleteMode.Append = (element.AutoCompleteMode And AutoCompleteMode.Append) Then
            If element.SelectionLength > 0 AndAlso element.SelectionStart > 0 Then
                textToSearch = RadMultiColumnComboBox1.Text.Substring(0, element.SelectionStart)
            End If
        End If

        If String.IsNullOrEmpty(textToSearch) Then
            e.Visible = True

            For i As Integer = 0 To element.EditorControl.ColumnCount - 1
                e.Row.Cells(i).Style.Reset()

            Next

            e.Row.InvalidateRow()
            Return
        End If

        e.Visible = False
        For i As Integer = 0 To element.EditorControl.ColumnCount - 1
            Dim text As String = e.Row.Cells(i).Value.ToString()
            If text.IndexOf(textToSearch, 0, StringComparison.InvariantCultureIgnoreCase) >= 0 Then
                e.Visible = True
                e.Row.Cells(i).Style.CustomizeFill = True
                e.Row.Cells(i).Style.DrawFill = True
                e.Row.Cells(i).Style.BackColor = Color.FromArgb(201, 252, 254)
            Else
                e.Row.Cells(i).Style.Reset()

            End If
        Next
        e.Row.InvalidateRow()
    End Sub
End Class

