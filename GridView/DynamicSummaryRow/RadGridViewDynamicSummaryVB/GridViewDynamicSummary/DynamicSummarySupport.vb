
Imports System.ComponentModel
Imports System.Reflection
Imports Telerik.WinControls.UI


Namespace GridView

    ''' <summary>Provides support for the RadgridViewDynamicSummary grid</summary>
    Public Class DynamicSummarySupport

        Private Sub New()
        End Sub

        ''' <summary>
        ''' Converts a Aggregate function into a GridAggregateFunction
        ''' </summary>
        ''' <param name="aggregateFunction">the aggregate function to convert</param>
        ''' <returns>GridAggregateFunction</returns>
        Public Shared Function AggregateFunctionToGridAggregateFunction(ByVal aggregateFunction As AggregateFunction) As GridAggregateFunction
            Select Case aggregateFunction
                Case aggregateFunction.Avg
                    Return GridAggregateFunction.Avg

                Case aggregateFunction.Count
                    Return GridAggregateFunction.Count

                Case aggregateFunction.Max
                    Return GridAggregateFunction.Max

                Case aggregateFunction.Min
                    Return GridAggregateFunction.Min

                Case aggregateFunction.First
                    Return GridAggregateFunction.First

                Case aggregateFunction.Last
                    Return GridAggregateFunction.Last

                Case aggregateFunction.None
                    Return GridAggregateFunction.None

                Case Else
                    Return GridAggregateFunction.Sum
            End Select
        End Function

        ''' <summary>
        ''' Gets the description attribute from the Aggregate Function enum
        ''' </summary>
        ''' <param name="en">the aggregate function enum</param>
        ''' <returns>string description</returns>
        Public Shared Function GetEnumDescription(ByVal en As AggregateFunction) As String
            Dim type As Type = en.[GetType]()

            Dim memInfo As MemberInfo() = type.GetMember(en.ToString())
            If memInfo IsNot Nothing AndAlso memInfo.Length > 0 Then
                Dim attrs As Object() = memInfo(0).GetCustomAttributes(GetType(DescriptionAttribute), False)

                If attrs IsNot Nothing AndAlso attrs.Length > 0 Then
                    Return DirectCast(attrs(0), DescriptionAttribute).Description
                End If
            End If

            Return (en.ToString())
        End Function

        ''' <summary>
        ''' Returns the allowOnDateTimeColumn attribute from the Aggregate Function enum
        ''' </summary>
        ''' <param name="en">the aggregate function enum</param>
        ''' <returns>allowOnDateTimeColumn boolean</returns>
        Public Shared Function GetEnumAllowOnDateTimeColumn(ByVal en As AggregateFunction) As Boolean
            Dim type As Type = en.[GetType]()

            Dim memInfo As MemberInfo() = type.GetMember(en.ToString())
            If memInfo IsNot Nothing AndAlso memInfo.Length > 0 Then
                Dim attrs As Object() = memInfo(0).GetCustomAttributes(GetType(AllowOnDateTimeColumnAttribute), False)

                If attrs IsNot Nothing AndAlso attrs.Length > 0 Then
                    Return DirectCast(attrs(0), AllowOnDateTimeColumnAttribute).AllowOnDateTimecolumn
                End If
            End If

            Return (False)
        End Function

    End Class

    ''' <summary>Enum of possible aggregate functions</summary>
    Public Enum AggregateFunction
        <Description("The average of ")> _
        <AllowOnDateTimeColumn(False)> _
        Avg

        <Description("The count of ")> _
        <AllowOnDateTimeColumn(True)> _
        Count

        <Description("The max of ")> _
        <AllowOnDateTimeColumn(True)> _
        Max

        <Description("The min of ")> _
        <AllowOnDateTimeColumn(True)> _
        Min

        <Description("The first of ")> _
        <AllowOnDateTimeColumn(False)> _
        First

        <Description("The last of ")> _
        <AllowOnDateTimeColumn(True)> _
        Last

        <Description("none")> _
        <AllowOnDateTimeColumn(True)> _
        None

        <Description("The sum is: ")> _
        <AllowOnDateTimeColumn(False)> _
        Sum
    End Enum

    ''' <summary>Enum indicating if the summary row should be rendered at the top or the bottom</summary>
    Public Enum SummaryRowPosition
        Top
        Bottom
    End Enum

End Namespace


