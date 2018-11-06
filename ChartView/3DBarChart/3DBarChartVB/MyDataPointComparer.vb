Imports _3DBarChartVB
Imports Telerik.Charting

Public Class MyDataPointComparer
    Implements IComparer(Of DataPointModel)

    Public Function Compare(ByVal x As DataPointModel, ByVal y As DataPointModel) As Integer Implements IComparer(Of DataPointModel).Compare
        Return If(x.Year > y.Year, 1, -1)
    End Function

End Class