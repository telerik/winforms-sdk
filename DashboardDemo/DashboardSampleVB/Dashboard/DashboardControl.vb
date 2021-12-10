Imports Telerik.WinControls

Public Class DashboardControl
    Inherits RadControl

    Private _element As DashboardElement

    Public ReadOnly Property Element As DashboardElement
        Get
            Return Me._element
        End Get
    End Property

    Protected Overrides Sub CreateChildItems(ByVal parent As RadElement)
        _element = New DashboardElement()
        parent.Children.Add(element)
    End Sub
End Class
