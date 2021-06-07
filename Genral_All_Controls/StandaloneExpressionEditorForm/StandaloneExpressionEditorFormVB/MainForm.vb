Imports Telerik.WinControls.UI

Partial Public Class MainForm

    Public Sub New()
        InitializeComponent()
        AddHandler Me.RadButton1.Click, AddressOf radButton1_Click

    End Sub

    Private Sub radButton1_Click(sender As Object, e As EventArgs)
        Dim form As New StandaloneExpressionEditorForm()
        If form.ShowDialog(Me.RadTextBox1.Text) = System.Windows.Forms.DialogResult.OK Then
            Me.RadTextBox2.Text = form.ReturnValue
        End If
    End Sub
End Class
