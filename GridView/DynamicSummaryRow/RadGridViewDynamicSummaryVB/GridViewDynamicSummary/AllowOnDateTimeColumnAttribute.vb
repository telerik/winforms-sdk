<AttributeUsage(AttributeTargets.Field)> _
Class AllowOnDateTimeColumnAttribute
    Inherits Attribute

    Private m_AllowOnDateTimeColumn As Boolean

    ''' <summary>Indicates if a date time column should have the attributed value</summary>
    Public ReadOnly Property AllowOnDateTimecolumn() As Boolean
        Get
            Return m_AllowOnDateTimeColumn
        End Get
    End Property

    ''' <summary>Constructor</summary>
    ''' <param name="allowOnDateTimecolumn">allowOnDateTimecolumn boolean</param>
    Sub New(ByVal allowOnDateTimecolumn As Boolean)
        m_AllowOnDateTimeColumn = allowOnDateTimecolumn
    End Sub

End Class
