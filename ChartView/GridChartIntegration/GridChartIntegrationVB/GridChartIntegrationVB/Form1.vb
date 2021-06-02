Imports Telerik.WinControls.UI
Imports Telerik.Charting

Public Class Form1
    Public Sub New()
        InitializeComponent()
        Me.RadGridView1.MultiSelect = True
        Me.RadGridView1.SelectionMode = Telerik.WinControls.UI.GridViewSelectionMode.CellSelect

        AddHandler Me.RadGridView1.SelectionChanged, AddressOf radGridView1_SelectionChanged
    End Sub

    Private Sub radGridView1_SelectionChanged(sender As Object, e As EventArgs)
        If Me.RadGridView1.SelectedCells.Count > 0 Then
            PopulateChart(Me.RadGridView1.SelectedCells)
        End If
    End Sub

    Private Sub PopulateChart(gridViewSelectedCellsCollection As GridViewSelectedCellsCollection)
        Dim orderIds As New List(Of String)()
        Me.RadChartView1.Series.Clear()
        Me.RadChartView1.Axes.Clear()
        Me.RadChartView1.ShowLegend = True

        For Each cell As GridViewCellInfo In gridViewSelectedCellsCollection
            Dim cellValue As Double
            If Double.TryParse(cell.Value & "", cellValue) Then
                Dim barSeries As BarSeries
                Dim rowView As DataRowView = TryCast(cell.RowInfo.DataBoundItem, DataRowView)
                If Not orderIds.Contains(rowView.Row("OrderID").ToString()) Then
                    orderIds.Add(rowView.Row("OrderID").ToString())
                    barSeries = New BarSeries()
                    barSeries.Name = rowView.Row("OrderID").ToString()
                    barSeries.LegendTitle = barSeries.Name

                    Me.RadChartView1.Series.Add(barSeries)
                Else
                    barSeries = TryCast(GetBarSeries(rowView.Row("OrderID").ToString()), BarSeries)
                End If
                barSeries.DataPoints.Add(New CategoricalDataPoint(cellValue, cell.ColumnInfo.Name))
            End If
        Next

        Me.RadChartView1.Invalidate()
    End Sub

    Private Function GetBarSeries(p As String) As ChartSeries
        For Each s As ChartSeries In Me.RadChartView1.Series
            If s.Name = p Then
                Return s
            End If
        Next

        Return Nothing
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NwindDataSet.Order_Details' table. You can move, or remove it, as needed.
        Me.Order_DetailsTableAdapter.Fill(Me.NwindDataSet.Order_Details)
        Me.RadGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
    End Sub
End Class
