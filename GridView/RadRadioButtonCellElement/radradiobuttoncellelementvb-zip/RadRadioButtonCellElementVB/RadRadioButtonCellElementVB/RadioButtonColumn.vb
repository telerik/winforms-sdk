Imports Telerik.WinControls.UI

Public Class RadioButtonColumn

    Inherits Telerik.WinControls.UI.GridViewDataColumn

    Public Sub New(ByVal fieldName As String)
        MyBase.New(fieldName)
    End Sub

    Public Overrides Function GetCellType(ByVal row As GridViewRowInfo) As System.Type
        If TypeOf row Is GridViewDataRowInfo Then
            Return GetType(RadioButtonCellElement)
        End If
        Return MyBase.GetCellType(row)
    End Function

End Class
