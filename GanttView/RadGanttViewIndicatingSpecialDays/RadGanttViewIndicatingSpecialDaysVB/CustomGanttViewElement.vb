Imports Telerik.WinControls.UI

Public Class CustomGanttViewElement
    Inherits RadGanttViewElement

    Protected Overrides Function CreateGraphicalViewElement(ganttView As RadGanttViewElement) As GanttViewGraphicalViewElement
        Return New CustomGanttViewGraphicalViewElement(Me)
    End Function

    Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
        Get
            Return GetType(RadGanttViewElement)
        End Get
    End Property
End Class