using System;

[AttributeUsage(AttributeTargets.Field)]
public class AllowOnDateTimeColumnAttribute : Attribute
{
    private bool m_AllowOnDateTimeColumn;
    /// <summary>Indicates if a date time column should have the attributed value</summary>
    public bool AllowOnDateTimecolumn
    {
        get { return m_AllowOnDateTimeColumn; }
    }

    /// <summary>Constructor</summary>
    /// <param name="allowOnDateTimecolumn">allowOnDateTimecolumn boolean</param>
    public AllowOnDateTimeColumnAttribute(bool allowOnDateTimecolumn)
    {
        m_AllowOnDateTimeColumn = allowOnDateTimecolumn;
    }
}
