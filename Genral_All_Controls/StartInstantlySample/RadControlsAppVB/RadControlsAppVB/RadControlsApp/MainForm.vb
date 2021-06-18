Imports System.ComponentModel
Imports Telerik.WinControls.UI

Public Class MainForm
    Dim customers As BindingList(Of Customer) = New BindingList(Of Customer)

    Public Sub New()
        InitializeComponent()

        Me.Text = "SingleInstanceDemo"
        Me.Opacity = 0
    End Sub

    Private firstShow As Boolean = True

    Protected Overrides Sub OnShown(ByVal e As EventArgs)
        MyBase.OnShown(e)

        If firstShow Then
            Me.Visible = False
            Me.firstShow = False
            Me.Opacity = 1

            For i As Integer = 0 To 99999
                customers.Add(New Customer(i, "Customer " & i.ToString(), "Address" & i.ToString()))
            Next i

            Me.radGridView1.DataSource = customers
            Me.radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
        End If
    End Sub

    Protected Overrides Sub OnClosing(ByVal e As CancelEventArgs)
        e.Cancel = True
        Me.Hide()

        MyBase.OnClosing(e)
    End Sub
End Class
