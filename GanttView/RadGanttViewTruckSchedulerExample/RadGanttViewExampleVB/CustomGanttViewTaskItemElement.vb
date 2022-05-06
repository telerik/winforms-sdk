Imports Telerik.WinControls.UI

Public Class CustomGanttViewTaskItemElement
    Inherits GanttViewTaskItemElement

    Public Sub New(ByVal owner As GanttViewGraphicalViewElement)
        MyBase.New(owner)
    End Sub

    Protected Overrides Function CreateTaskElement() As GanttGraphicalViewBaseTaskElement
        Return New CustomGanttGraphicalViewBaseTaskElement()
    End Function

    Protected Overrides ReadOnly Property ThemeEffectiveType As Type
        Get
            Return GetType(GanttViewTaskItemElement)
        End Get
    End Property
End Class
