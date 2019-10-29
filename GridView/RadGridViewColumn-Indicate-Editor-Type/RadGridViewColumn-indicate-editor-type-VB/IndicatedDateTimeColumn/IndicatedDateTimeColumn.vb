Imports Telerik.WinControls.UI

Public Class IndicatedDateTimeColumn
    Inherits GridViewDateTimeColumn

    Private _enableIndicator As Boolean

    Public Sub New()
        _enableIndicator = True
    End Sub

    Public Property EnableIndicator() As Boolean
        Get
            Return Me._enableIndicator
        End Get
        Set(ByVal value As Boolean)
            Me._enableIndicator = value
            Me.OwnerTemplate.Refresh()
        End Set
    End Property

    Public Overrides Function GetCellType(ByVal row As GridViewRowInfo) As Type
        If TypeOf row Is GridViewDataRowInfo Then
            Return GetType(IndicatedDateTimeCellElement)
        End If
        Return MyBase.GetCellType(row)
    End Function
End Class
