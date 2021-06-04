Namespace DisabledEditors
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()

			Me.myTextBox1.SelectionStart = 0
		End Sub

		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton1.Click
			myTextBox1.Enabled = Not myTextBox1.Enabled
			myRadDateTimePicker1.Enabled = Not myRadDateTimePicker1.Enabled
			myRadMaskedEditBox1.Enabled = Not myRadMaskedEditBox1.Enabled
			myRadSpinEditor1.Enabled = Not myRadSpinEditor1.Enabled
			myRadDropDownList1.Enabled = Not myRadDropDownList1.Enabled
		End Sub
	End Class
End Namespace
