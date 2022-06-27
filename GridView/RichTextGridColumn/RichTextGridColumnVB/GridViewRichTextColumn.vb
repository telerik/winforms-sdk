Imports Telerik.WinControls.UI

Public Class GridViewRichTextColumn
    Inherits GridViewTextBoxColumn

    Public Sub New()
    End Sub

    Public Sub New(ByVal fieldName As String)
        MyBase.New(fieldName)
    End Sub

    Public Sub New(ByVal uniqueName As String, ByVal fieldName As String)
        MyBase.New(uniqueName, fieldName)
    End Sub

    Public Overrides Function GetCellType(ByVal row As GridViewRowInfo) As System.Type
        If TypeOf row Is GridViewDataRowInfo Then
            Return GetType(RichTextEditorCellElement)
        End If

        Return MyBase.GetCellType(row)
    End Function

    Public Overrides Function GetDefaultEditorType() As System.Type
        Return GetType(RichTextEditor)
    End Function

    Public Overrides Function GetDefaultEditor() As IInputEditor
        Return New RichTextEditor()
    End Function
End Class
