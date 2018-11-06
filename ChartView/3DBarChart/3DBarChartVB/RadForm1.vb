Imports Telerik.Charting
Imports Telerik.WinControls.UI

Public Class RadForm1
    Private barSeries1Data As List(Of DataPointModel)
    Private barSeries2Data As List(Of DataPointModel)

    Public Sub New()
        InitializeComponent()

        AddHandler Me.RadChartView1.CreateRenderer, AddressOf radChartView1_CreateRenderer
        Me.RadChartView1.Title = "Title"
        Me.RadChartView1.ShowTitle = True
        Me.barSeries1Data = New List(Of DataPointModel)()
        Me.barSeries2Data = New List(Of DataPointModel)()
        Me.GenerateData()
        Me.SetupBarSeries()
    End Sub

    Private Sub radChartView1_CreateRenderer(ByVal sender As Object, ByVal e As ChartViewCreateRendererEventArgs)
        e.Renderer = New CustomCartesianRenderer(TryCast(e.Area, CartesianArea))
    End Sub

    Private Sub SetupBarSeries()
        Me.barSeries1Data.Sort(New MyDataPointComparer())
        Me.barSeries2Data.Sort(New MyDataPointComparer())
        Dim barSeries1 As BarSeries = New BarSeries() With {
            .Name = "First"
        }
        barSeries1.DataSource = Me.barSeries1Data
        barSeries1.ValueMember = "Value"
        barSeries1.CategoryMember = "Year"
        Dim barSeries2 As BarSeries = New BarSeries() With {
            .Name = "Second"
        }
        barSeries2.DataSource = Me.barSeries2Data
        barSeries2.ValueMember = "Value"
        barSeries2.CategoryMember = "Year"
        Dim categoricalAxis As CategoricalAxis = New CategoricalAxis()
        categoricalAxis.PlotMode = AxisPlotMode.BetweenTicks
        barSeries1.HorizontalAxis = categoricalAxis
        barSeries2.HorizontalAxis = categoricalAxis
        categoricalAxis.Font = New Font("Calibri", 16, FontStyle.Bold)
        barSeries1.CombineMode = ChartSeriesCombineMode.Stack
        barSeries2.CombineMode = ChartSeriesCombineMode.Stack
        Me.RadChartView1.Series.Add(barSeries1)
        Me.RadChartView1.Series.Add(barSeries2)

        For i As Integer = 0 To 13 - 1
            Dim series As BarSeries = New BarSeries()
            Dim data As List(Of DataPointModel) = New List(Of DataPointModel)()

            For j As Integer = 0 To 5 - 1
                data.Add(New DataPointModel With {
                    .Value = 10 * j + 10,
                    .Year = 2010 + j
                })
            Next

            series.CombineMode = ChartSeriesCombineMode.Stack
            series.DataSource = data
            series.ValueMember = "Value"
            series.CategoryMember = "Year"

            If i = 12 Then
                series.Name = "Last"
            End If

            Me.RadChartView1.Series.Add(series)
        Next
    End Sub

    Private Sub GenerateData()
        Me.barSeries1Data.Add(New DataPointModel With {
            .Value = 177,
            .Year = 2010
        })
        Me.barSeries1Data.Add(New DataPointModel With {
            .Value = 111,
            .Year = 2014
        })
        Me.barSeries1Data.Add(New DataPointModel With {
            .Value = 118,
            .Year = 2011
        })
        Me.barSeries1Data.Add(New DataPointModel With {
            .Value = 128,
            .Year = 2012
        })
        Me.barSeries1Data.Add(New DataPointModel With {
            .Value = 143,
            .Year = 2013
        })
        Me.barSeries2Data.Add(New DataPointModel With {
            .Value = 153,
            .Year = 2010
        })
        Me.barSeries2Data.Add(New DataPointModel With {
            .Value = 88,
            .Year = 2014
        })
        Me.barSeries2Data.Add(New DataPointModel With {
            .Value = 141,
            .Year = 2011
        })
        Me.barSeries2Data.Add(New DataPointModel With {
            .Value = 109,
            .Year = 2012
        })
        Me.barSeries2Data.Add(New DataPointModel With {
            .Value = 130,
            .Year = 2013
        })
    End Sub
End Class

Public Class DataPointModel
    Public Property Value As Integer
    Public Property Year As Integer
End Class
