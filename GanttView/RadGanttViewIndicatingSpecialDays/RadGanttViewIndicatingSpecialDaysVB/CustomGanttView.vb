Imports Telerik.WinControls.UI

Public Class CustomGanttView
    Inherits RadGanttView

    Protected Overrides Function CreateGanttViewElement() As RadGanttViewElement
        Return New CustomGanttViewElement()
    End Function

    Public Overrides Property ThemeClassName As String
        Get
            Return GetType(RadGanttView).FullName
        End Get
        Set(value As String)
            MyBase.ThemeClassName = value
        End Set
    End Property
End Class
