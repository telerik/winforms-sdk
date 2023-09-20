Imports Telerik.WinControls.UI

Public Class RowDetailsLayout
    Inherits TableViewRowLayout
    Private systemWidth As Integer
    Private availableSize As SizeF

    Public Overrides Sub InvalidateRenderColumns()
        MyBase.InvalidateRenderColumns()
        systemWidth = 0
        For Each column As GridViewColumn In Me.RenderColumns
            If Not (TypeOf column Is GridViewDataColumn) Then
                systemWidth += column.Width + Owner.CellSpacing
            End If
        Next column
        If systemWidth > 0 Then
            systemWidth -= Owner.CellSpacing
        End If
    End Sub

    Public Overrides Function MeasureRow(ByVal availableSize As SizeF) As SizeF
        Dim desiredSize As SizeF = MyBase.MeasureRow(availableSize)
        Me.availableSize = availableSize
        Return desiredSize
    End Function

    Public Overrides Function ArrangeCell(ByVal clientRect As RectangleF, ByVal cell As GridCellElement) As RectangleF
        Dim grid As RowDetailsGrid = CType(Owner.GridViewElement.GridControl, RowDetailsGrid)
        If cell.ColumnInfo Is grid.DetailsColumn Then
            cell.StretchHorizontally = True
            cell.BypassLayoutPolicies = True
            If cell.RowElement.IsCurrent Then
                Return New RectangleF(0, Owner.RowHeight, availableSize.Width - systemWidth, grid.DetailsRowHeight - Owner.RowHeight)
            Else
                Return RectangleF.Empty
            End If
        End If

        If TypeOf cell Is GridDataCellElement Then
            clientRect.Height = Owner.RowHeight
        End If

        Return MyBase.ArrangeCell(clientRect, cell)
    End Function
End Class