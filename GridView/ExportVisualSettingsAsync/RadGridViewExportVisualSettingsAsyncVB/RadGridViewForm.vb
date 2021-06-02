Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Export

Public Class RadGridViewForm
    Sub New()

        InitializeComponent()

        ThemeResolutionService.ApplicationThemeName = "TelerikMetro"

        Me.RadGridView1.DataSource = Me.GetSampleData()
        Me.RadGridView1.TableElement.TableHeaderHeight = 50
        Me.RadGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill

        Me.RadGridView1.EnableAlternatingRowColor = True
        Me.RadGridView1.TableElement.AlternatingRowColor = Color.LightGreen

    End Sub

    Private Function GetSampleData() As DataTable
        Dim dataTable As New DataTable()
        dataTable.Columns.Add("Id", GetType(Integer))
        dataTable.Columns.Add("Name", GetType(String))
        dataTable.Columns.Add("IsValid", GetType(Boolean))
        dataTable.Columns.Add("Date", GetType(DateTime))

        For i As Integer = 0 To 4999
            dataTable.Rows.Add(i, "Name " & i, i Mod 2 = 0, DateTime.Now.AddDays(i))
        Next

        Return dataTable
    End Function

    Private Async Sub RadButton1_Click(sender As Object, e As EventArgs) Handles radButton1.Click
        Await Me.ExportGridVisuallyAsync()
    End Sub

    Private Async Function ExportGridVisuallyAsync() As Task
        Dim job As New Action(AddressOf Me.ExportData)
        Dim task As New Task(job)
        task.Start()

        Await task
    End Function

    Private Sub ExportData()
        Dim spreadExporter As New GridViewSpreadExport(Me.radGridView1)
        spreadExporter.ExportVisualSettings = True

        Dim exportRenderer As New SpreadExportRenderer()
        spreadExporter.RunExport("..\..\exported-grid.xlsx", exportRenderer)

        RadMessageBox.Show("Export completed!")
    End Sub
End Class
