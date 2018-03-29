Imports Telerik.WinControls.UI

Public Class RadForm1
    Sub New()

        InitializeComponent()

        Dim dt As DataTable = New DataTable()
        dt.Columns.Add("Id", GetType(Integer))
        dt.Columns.Add("IssueTitle", GetType(String))
        dt.Columns.Add("Priority", GetType(String))
        For i As Integer = 1 To 20 - 1
            If i Mod 2 = 0 Then
                dt.Rows.Add(i, "Issue#" & i, "Low")
            Else
                dt.Rows.Add(i, "Issue#" & i, "High")
            End If
        Next
        Me.RadGridView1.AutoGenerateColumns = False
        Dim idColumn As GridViewDecimalColumn = New GridViewDecimalColumn("Id")
        Me.RadGridView1.Columns.Add(idColumn)
        Dim titleColumn As GridViewTextBoxColumn = New GridViewTextBoxColumn("IssueTitle")
        Me.RadGridView1.Columns.Add(titleColumn)
        Dim myColumn As CustomColumn = New CustomColumn()
        myColumn.FieldName = "Priority"
        myColumn.Name = "Priority"
        myColumn.HeaderText = "Priority"
        Me.RadGridView1.Columns.Add(myColumn)
        Me.RadGridView1.DataSource = dt
        Me.RadGridView1.BestFitColumns(BestFitColumnMode.AllCells)
        Me.RadGridView1.EnableFiltering = True

        AddHandler Me.RadGridView1.CellBeginEdit, AddressOf radGridView1_CellBeginEdit
    End Sub

    Private Sub radGridView1_CellBeginEdit(sender As Object, e As GridViewCellCancelEventArgs)
        If TypeOf e.Row Is GridViewFilteringRowInfo AndAlso e.Column.Name = "Priority" Then
            e.Cancel = True
        End If
    End Sub

End Class
