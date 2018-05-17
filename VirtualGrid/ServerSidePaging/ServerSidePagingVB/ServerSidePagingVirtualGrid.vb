Imports Telerik.WinControls.UI

#Region "PageIndexChangingEvent"
Public Class ServerSidePagingVirtualGrid

    Private repository As VirtualGridRepository
    Private data As IList(Of OrderDataModel)

    Public Sub New()
        InitializeComponent()
        Me.repository = New VirtualGridRepository()
        Me.RadVirtualGrid1.RowCount = Me.repository.Orders.Count()
        Me.RadVirtualGrid1.ColumnCount = Me.repository.ColumnNames.Length
        Me.RadVirtualGrid1.EnablePaging = True
        Me.RadVirtualGrid1.AutoSizeColumnsMode = Telerik.WinControls.UI.VirtualGridAutoSizeColumnsMode.Fill
        Me.SelectData(Me.RadVirtualGrid1.PageIndex)
        AddHandler Me.RadVirtualGrid1.CellValueNeeded, AddressOf RadVirtualGrid1_CellValueNeeded
        AddHandler Me.RadVirtualGrid1.PageChanging, AddressOf RadVirtualGrid1_PageChanging
    End Sub

    Private Sub RadVirtualGrid1_PageChanging(ByVal sender As Object, ByVal e As VirtualGridPageChangingEventArgs)
        Me.SelectData(e.NewIndex)
    End Sub

    Private Sub RadVirtualGrid1_CellValueNeeded(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.VirtualGridCellValueNeededEventArgs)
        If e.ColumnIndex < 0 Then
            Return
        End If

        If e.RowIndex = RadVirtualGrid.HeaderRowIndex Then
            e.Value = Me.repository.ColumnNames(e.ColumnIndex)
        End If

        If e.RowIndex >= 0 AndAlso e.RowIndex < Me.data.Count * (Me.RadVirtualGrid1.PageIndex + 1) Then
            Dim index As Integer = e.RowIndex - Me.RadVirtualGrid1.PageSize * Me.RadVirtualGrid1.PageIndex
            e.Value = Me.data(index)(e.ColumnIndex)
        End If
    End Sub

    Private Sub SelectData(ByVal pageIndex As Integer)
        Me.data = Me.repository.Orders.Skip(pageIndex * Me.RadVirtualGrid1.PageSize).Take(Me.RadVirtualGrid1.PageSize).ToList()
    End Sub
End Class
#End Region
