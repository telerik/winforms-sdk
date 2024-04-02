Imports Telerik.WinControls.UI

Namespace GridView

    Public Class DynamicGroupSummaryRowChangedEventArgs
        Inherits System.EventArgs

        Public Sub New(ByVal column As GridViewDataColumn, ByVal summaryRowPosition As GridView.SummaryRowPosition, ByVal aggregateFunction As AggregateFunction, ByVal isEnabled As Boolean)
            MyBase.New()
            Me.Column = column
            Me.SummaryRowPosition = summaryRowPosition
            Me.AggregateFunction = aggregateFunction
            Me.IsEnabled = isEnabled
        End Sub

        Public Column As GridViewDataColumn
        Public SummaryRowPosition As SummaryRowPosition
        Public AggregateFunction As AggregateFunction
        Public IsEnabled As Boolean
    End Class

End Namespace



