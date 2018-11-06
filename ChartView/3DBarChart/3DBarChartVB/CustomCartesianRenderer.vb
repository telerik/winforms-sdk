Imports Telerik.Charting
Imports Telerik.WinControls.UI

Public Class CustomCartesianRenderer
    Inherits CartesianRenderer

    Private _summaries As Dictionary(Of Object, Double) = New Dictionary(Of Object, Double)()

    Public Sub New(ByVal area As CartesianArea)
        MyBase.New(area)
    End Sub

    Public ReadOnly Property Summaries As Dictionary(Of Object, Double)
        Get
            Return Me._summaries
        End Get
    End Property

    Protected Overrides Sub Initialize()
        MyBase.Initialize()
        Me._summaries = New Dictionary(Of Object, Double)()

        For Each series As BarSeries In Me.Area.Series

            For Each dp As CategoricalDataPoint In series.DataPoints
                Dim key As Object = dp.Category

                If Not Me.summaries.ContainsKey(key) Then
                    Me.summaries.Add(key, 0)
                End If

                Me.summaries(key) += dp.Value.Value
            Next
        Next

        For i As Integer = 0 To Me.DrawParts.Count - 1
            Dim barPart As BarSeriesDrawPart = TryCast(Me.DrawParts(i), BarSeriesDrawPart)

            If barPart IsNot Nothing Then
                Dim customDrawPart As CustomBarSeriesDrawPart = New CustomBarSeriesDrawPart(CType(barPart.Element, BarSeries), Me)
                customDrawPart.DrawCap = barPart.Element.Name = "Last"
                Me.DrawParts(i) = customDrawPart
            End If
        Next
    End Sub
End Class