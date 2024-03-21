Imports Telerik.WinControls.UI

Public Class Main

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.RadGridViewDynamicSummary1.AllowAddNewRow = False
        Me.RadGridViewDynamicSummary1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill

        Me.RadGridViewDynamicSummary1.Columns.Add(New GridViewTextBoxColumn("Month"))
        Me.RadGridViewDynamicSummary1.Columns.Add(New GridViewDecimalColumn("Income"))
        Me.RadGridViewDynamicSummary1.Columns.Add(New GridViewDateTimeColumn("Date Paid"))


        Dim rowInfo As GridViewRowInfo = Me.RadGridViewDynamicSummary1.Rows.AddNew()
        rowInfo.Cells(0).Value = "January"
        rowInfo.Cells(1).Value = 22.5
        rowInfo.Cells(2).Value = Now().AddDays(-14)
        rowInfo = Me.RadGridViewDynamicSummary1.Rows.AddNew()
        rowInfo.Cells(0).Value = "February"
        rowInfo.Cells(1).Value = 30.65
        rowInfo.Cells(2).Value = Now().AddDays(-9)
        rowInfo = Me.RadGridViewDynamicSummary1.Rows.AddNew()
        rowInfo.Cells(0).Value = "March"
        rowInfo.Cells(1).Value = 4.65
        rowInfo.Cells(2).Value = Now().AddDays(-6)
        rowInfo = Me.RadGridViewDynamicSummary1.Rows.AddNew()
        rowInfo.Cells(0).Value = "April"
        rowInfo.Cells(1).Value = 21.57
        rowInfo.Cells(2).Value = Now().AddDays(-2)
        rowInfo = Me.RadGridViewDynamicSummary1.Rows.AddNew()
        rowInfo.Cells(0).Value = "May"
        rowInfo.Cells(1).Value = 24.65
        rowInfo.Cells(2).Value = Now().AddDays(-1)


        Me.RadDropDownListSummaryPosition.Enabled = False
        Me.RadDropDownListSummaryColumn.Enabled = False


        '// --------------------------------------------------------------------------------
        '// Demo implementation
        '// --------------------------------------------------------------------------------
        'Me.RadGridViewDynamicSummary1.EnableDynamicRowSummary(GridView.AggregateFunction.Max, _
        '                                                      CType(Me.RadGridViewDynamicSummary1.Columns(1), GridViewDecimalColumn), _
        '                                                      GridView.SummaryRowPosition.Bottom)
        '
        'And to Remove
        'Me.RadGridViewDynamicSummary1.DisableDynamicRowSummary()
        '// --------------------------------------------------------------------------------
        '// this is all you need to use this functionality
        '// --------------------------------------------------------------------------------

    End Sub

    Private Sub RadCheckBoxEnabled_ToggleStateChanged(ByVal sender As System.Object, _
                                                      ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles RadCheckBoxEnabled.ToggleStateChanged

        If RadCheckBoxEnabled.Checked Then
            Me.RadDropDownListSummaryPosition.Enabled = True
            Me.RadDropDownListSummaryColumn.Enabled = True

            SetUp()
        Else
            Me.RadDropDownListSummaryPosition.Enabled = False
            Me.RadDropDownListSummaryColumn.Enabled = False

            Me.RadGridViewDynamicSummary1.DisableDynamicRowSummary()
        End If
    End Sub


    Private Sub RadDropDownListSummaryPosition_SelectedIndexChanged(ByVal sender As System.Object, _
                                                                        ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles RadDropDownListSummaryPosition.SelectedIndexChanged

        If Me.RadCheckBoxEnabled.Checked Then
            SetUp()
        End If
    End Sub

    Private Sub RadDropDownListSummaryColumn_SelectedIndexChanged(ByVal sender As System.Object, _
                                                                  ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles RadDropDownListSummaryColumn.SelectedIndexChanged

        If Me.RadCheckBoxEnabled.Checked Then
            SetUp()
        End If
    End Sub

    Private Sub SetUp()

        Dim summaryRowPosition As GridView.SummaryRowPosition
        If Me.RadDropDownListSummaryPosition.SelectedIndex = 0 Then
            summaryRowPosition = GridView.SummaryRowPosition.Top
        Else
            summaryRowPosition = GridView.SummaryRowPosition.Bottom
        End If

        Dim summaryDateTimeColumn As GridViewDateTimeColumn = CType(Me.RadGridViewDynamicSummary1.Columns("Date Paid"), GridViewDateTimeColumn)
        Dim summaryDecimalColumn As GridViewDecimalColumn = CType(Me.RadGridViewDynamicSummary1.Columns("Income"), GridViewDecimalColumn)

        If Me.RadDropDownListSummaryColumn.SelectedIndex = 0 Then
            Me.RadGridViewDynamicSummary1.EnableDynamicRowSummary(GridView.AggregateFunction.Count, summaryDecimalColumn, summaryRowPosition)
        Else
            Me.RadGridViewDynamicSummary1.EnableDynamicRowSummary(GridView.AggregateFunction.Count, summaryDateTimeColumn, summaryRowPosition)
        End If
    End Sub

    Private Sub RadGridViewDynamicSummary1_DynamicGroupSummaryChanged(ByVal sender As System.Object, _
                                                                    ByVal e As RadGridViewDynamicSummary.GridView.DynamicGroupSummaryRowChangedEventArgs) Handles RadGridViewDynamicSummary1.DynamicGroupSummaryChanged

        If e.IsEnabled Then
            Me.RadListControlEvents.Items.Add("column: " & e.Column.ToString())
            Me.RadListControlEvents.Items.Add("enabled: " & e.IsEnabled.ToString())
            Me.RadListControlEvents.Items.Add("position: " & e.SummaryRowPosition.ToString())
            Me.RadListControlEvents.Items.Add("function: " & e.AggregateFunction.ToString())
        Else
            Me.RadListControlEvents.Items.Add("enabled: " & e.IsEnabled.ToString())
        End If
        Me.RadListControlEvents.SelectedIndex = Me.RadListControlEvents.Items.Count - 1

    End Sub
End Class
