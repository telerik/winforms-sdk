Imports Telerik.WinControls.UI
Imports System.Windows.Forms

Public Class ServerAutoCompleteAppendHelper(Of T)
    Inherits AutoCompleteAppendHelper
    Public Property Data() As IQueryable(Of T)
        Get
            Return m_Data
        End Get
        Private Set(value As IQueryable(Of T))
            m_Data = value
        End Set
    End Property
    Private m_Data As IQueryable(Of T)

    Public Sub New(owner As RadDropDownListElement, data As IEnumerable(Of T))
        MyBase.New(owner)
        Me.Data = data.AsQueryable()
        ExpressionBuilder.Instance.Optimize(Me.Data)
    End Sub

    Public Overrides Sub AutoComplete(e As KeyPressEventArgs)
        Dim findString As String = Me.CreateFindString(e)

        Dim whereExp = ExpressionBuilder.Instance.BuildStartsWithExpression(Of T)(Me.Owner.AutoCompleteValueMember, findString)
        Dim selectExp = ExpressionBuilder.Instance.BuildSelectExpression(Of T)(Me.Owner.AutoCompleteValueMember)

        Dim result As String = Me.Data.Where(whereExp).[Select](selectExp).OrderBy(Function(x) x.Length).FirstOrDefault()
        If result IsNot Nothing Then
            Owner.EditableElementText = result
            Owner.SelectionStart = findString.Length
            Owner.SelectionLength = Owner.EditableElementText.Length
            e.Handled = True
        End If
    End Sub

    Private Function CreateFindString(e As KeyPressEventArgs) As String
        Dim findString As String = ""
        If Owner.SelectionLength = 0 Then
            findString = Owner.EditableElementText + e.KeyChar
        Else
            findString = Owner.EditableElementText.Substring(0, Owner.SelectionStart) + e.KeyChar
        End If

        Return findString
    End Function
End Class