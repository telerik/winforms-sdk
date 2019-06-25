Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class DragAndDropRadGrid
    Inherits RadGridView

    Public Sub New()
        Me.MultiSelect = True
        Dim svc As RadDragDropService = Me.GridViewElement.GetService(Of RadDragDropService)()
        AddHandler svc.PreviewDragStart, AddressOf svc_PreviewDragStart
        AddHandler svc.PreviewDragDrop, AddressOf svc_PreviewDragDrop
        AddHandler svc.PreviewDragOver, AddressOf svc_PreviewDragOver
        Dim gridBehavior = TryCast(Me.GridBehavior, BaseGridBehavior)
        gridBehavior.UnregisterBehavior(GetType(GridViewDataRowInfo))
        gridBehavior.RegisterBehavior(GetType(GridViewDataRowInfo), New RowSelectionGridBehavior())
    End Sub

    Private Sub svc_PreviewDragOver(ByVal sender As Object, ByVal e As RadDragOverEventArgs)
        If TypeOf e.DragInstance Is GridDataRowElement Then
            e.CanDrop = TypeOf e.HitTarget Is GridDataRowElement OrElse TypeOf e.HitTarget Is GridTableElement OrElse TypeOf e.HitTarget Is GridSummaryRowElement
        End If
    End Sub

    Private Sub svc_PreviewDragDrop(ByVal sender As Object, ByVal e As RadDropEventArgs)
        Dim rowElement = TryCast(e.DragInstance, GridDataRowElement)
        If rowElement Is Nothing Then
            Return
        End If
        e.Handled = True
        Dim dropTarget = TryCast(e.HitTarget, RadItem)
        Dim targetGrid = TryCast(dropTarget.ElementTree.Control, RadGridView)
        If targetGrid Is Nothing Then
            Return
        End If
        Dim dragGrid = TryCast(rowElement.ElementTree.Control, RadGridView)
        If Not targetGrid Is dragGrid Then
            e.Handled = True
            'append dragged rows to the end of the target grid
            Dim index As Integer = targetGrid.RowCount
            'Grab every selected row from the source grid, including the current row
            Dim rows As New List(Of GridViewRowInfo)
            For Each row As GridViewRowInfo In dragGrid.SelectedRows
                rows.Add(row)
            Next
            If Not dragGrid.CurrentRow Is Nothing Then
                Dim row As GridViewRowInfo = dragGrid.CurrentRow
                If (Not rows.Contains(row)) Then
                    rows.Add(row)
                End If
            End If
            Me.MoveRows(targetGrid, dragGrid, rows, index)
        End If
    End Sub

    Private Sub MoveRows(ByVal targetGrid As RadGridView, ByVal dragGrid As RadGridView, ByVal dragRows As List(Of GridViewRowInfo), ByVal index As Integer)
        dragGrid.BeginUpdate()
        targetGrid.BeginUpdate()

        For i As Integer = dragRows.Count - 1 To 0
            Dim row As GridViewRowInfo = dragRows(i)

            If TypeOf row Is GridViewSummaryRowInfo Then
                Continue For
            End If

            If targetGrid.DataSource Is Nothing Then
                Dim newRow As GridViewRowInfo = targetGrid.Rows.NewRow()

                For Each cell As GridViewCellInfo In row.Cells
                    If newRow.Cells(cell.ColumnInfo.Name) IsNot Nothing Then newRow.Cells(cell.ColumnInfo.Name).Value = cell.Value
                Next

                targetGrid.Rows.Insert(index, newRow)
                row.IsSelected = False
                dragGrid.Rows.Remove(row)
            ElseIf GetType(DataSet).IsAssignableFrom(targetGrid.DataSource.[GetType]()) Then
                Dim sourceTable = (CType(dragGrid.DataSource, DataSet)).Tables(0)
                Dim targetTable = (CType(targetGrid.DataSource, DataSet)).Tables(0)
                Dim newRow = targetTable.NewRow()

                For Each cell As GridViewCellInfo In row.Cells
                    newRow(cell.ColumnInfo.Name) = cell.Value
                Next

                sourceTable.Rows.Remove((CType(row.DataBoundItem, DataRowView)).Row)
                targetTable.Rows.InsertAt(newRow, index)
            ElseIf GetType(IList).IsAssignableFrom(targetGrid.DataSource.[GetType]()) Then
                Dim targetCollection = CType(targetGrid.DataSource, IList)
                Dim sourceCollection = CType(dragGrid.DataSource, IList)
                sourceCollection.Remove(row.DataBoundItem)
                targetCollection.Add(row.DataBoundItem)
            Else
                Throw New ApplicationException("Unhandled Scenario")
            End If

            index += 1
        Next

        dragGrid.EndUpdate(True)
        targetGrid.EndUpdate(True)
    End Sub

    Private Sub svc_PreviewDragStart(ByVal sender As Object, ByVal e As PreviewDragStartEventArgs)
        e.CanStart = True
    End Sub

End Class
