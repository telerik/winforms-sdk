Imports Telerik.WinControls.UI

Public Class CustomColumn
    Inherits GridViewTextBoxColumn
    Public Overrides Function GetCellType(ByVal row As GridViewRowInfo) As Type
        If TypeOf row Is GridViewFilteringRowInfo Then
            Return GetType(DropDownGridFilterCellElement)
        End If
        Return MyBase.GetCellType(row)
    End Function
End Class
