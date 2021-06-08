Imports System.ComponentModel

Public Class MainForm
    Dim WithEvents worker As BackgroundWorker
    Dim dt As DataTable

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        worker = New BackgroundWorker()
    End Sub

    Private Sub rbtnPrepareDataSource_Click(sender As System.Object, e As System.EventArgs) Handles rbtnPrepareDataSource.Click
        Me.rbtnPrepareDataSource.Enabled = False
        Me.RadWaitingBar1.Visible = True
        Me.RadWaitingBar1.StartWaiting()
        worker.RunWorkerAsync()
    End Sub

    Private Sub rbtnBind_Click(sender As System.Object, e As System.EventArgs) Handles rbtnBind.Click
        If Me.RadGridView1.DataSource Is Nothing Then
            WaitingForm.ShowForm()
            Me.RadGridView1.DataSource = dt
        End If
    End Sub

    Private Sub worker_DoWork(sender As System.Object, e As DoWorkEventArgs) Handles worker.DoWork
        dt = New DataTable()

        Dim dc As New DataColumn()
        dc.ColumnName = "ID"
        dt.Columns.Add(dc)

        Dim dc2 As New DataColumn()
        dc2.ColumnName = "Name"
        dt.Columns.Add(dc2)

        For i As Integer = 0 To 999999
            Dim dr As DataRow = dt.NewRow()
            dr(0) = i
            dr(1) = "Name " & i.ToString()
            dt.Rows.Add(dr)
        Next i
    End Sub

    Private Sub worker_RunWorkerCompleted(sender As System.Object, e As RunWorkerCompletedEventArgs) Handles worker.RunWorkerCompleted
        Me.RadWaitingBar1.StopWaiting()
        Me.RadWaitingBar1.Visible = False
        Me.rbtnBind.Enabled = True
    End Sub

    Private Sub RadGridView1_DataBindingComplete(sender As Object, e As Telerik.WinControls.UI.GridViewBindingCompleteEventArgs) Handles RadGridView1.DataBindingComplete
        WaitingForm.CloseForm()
    End Sub
End Class
