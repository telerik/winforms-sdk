Imports Telerik.WinControls.UI

#Region "InitialSetupAndEvents"
Public Class FilteringIndicatorsForm
    Public Sub New()
        InitializeComponent()

        AddHandler Me.RadGridView1.CreateCell, AddressOf RadGridView1_CreateCell
        Dim gridBehavior As BaseGridBehavior = TryCast(RadGridView1.GridBehavior, BaseGridBehavior)
        gridBehavior.UnregisterBehavior(GetType(GridViewFilteringRowInfo))
        gridBehavior.RegisterBehavior(GetType(GridViewFilteringRowInfo), New MyGridFilterRowBehavior())
        Me.RadGridView1.DataSource = Me.GetData()
        Me.RadGridView1.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Me.RadGridView1.EnableFiltering = True
    End Sub

    Private Sub RadGridView1_CreateCell(ByVal sender As Object, ByVal e As GridViewCreateCellEventArgs)
        If e.CellType = GetType(GridFilterCellElement) Then
            e.CellElement = New MyGridFilterCellElement(CType(e.Column, GridViewDataColumn), e.Row)
        ElseIf e.CellType = GetType(GridRowHeaderCellElement) Then
            e.CellElement = New MyGridRowHeaderCellElement(e.Column, e.Row)
        End If
    End Sub

    Private Function GetData() As DataTable
        Dim dt As DataTable = New DataTable()
        dt.Columns.Add("Id", GetType(Integer))
        dt.Columns.Add("Name", GetType(String))
        dt.Columns.Add("Date", GetType(DateTime))
        dt.Columns.Add("Bool", GetType(Boolean))

        For i As Integer = 0 To 20 - 1
            dt.Rows.Add(i, "Name " & i, DateTime.Now.AddDays(i), i Mod 2 = 0)
        Next

        Return dt
    End Function
End Class
#End Region
