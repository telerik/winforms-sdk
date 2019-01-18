Imports System.ComponentModel
Imports System.Text
Imports Telerik.WinControls

Namespace GridViewEditDialog
	Partial Public Class EditForm
		Inherits Telerik.WinControls.UI.RadForm
		Private student As MainForms.Student

		Public Sub New()
			InitializeComponent()
		End Sub

		Public Sub New(ByVal student As MainForms.Student)
			Me.New()
			Me.student = student

			Me.radDropDownList1.Items.AddRange(New List(Of String)() From {"A", "A+", "A-", "B", "B+", "B-", "C", "C+", "C-", "D", "D+", "D-", "E", "E+", "E-", "F", "F+", "F-"})
			Me.radDropDownList1.DropDownStyle = RadDropDownStyle.DropDownList
			Me.radDropDownList1.DropDownListElement.SyncSelectionWithText = True

			Me.radSpinEditor1.Value = Me.student.Id
			Me.radTextBox1.Text = Me.student.Name
			Me.radDropDownList1.SelectedValue = Me.student.Grade
		End Sub

		Private Sub save_Button_Click(ByVal sender As Object, ByVal e As EventArgs) Handles save_Button.Click
			If IsValidData() Then
				Me.student.Id = CInt(Fix(Me.radSpinEditor1.Value))
				Me.student.Name = Me.radTextBox1.Text
				Me.student.Grade = Me.radDropDownList1.SelectedItem.Text
				Me.Close()
			End If
		End Sub

		Private Function IsValidData() As Boolean
			Me.errorProvider1.Clear()

			If Me.radTextBox1.Text = String.Empty Then
				Me.errorProvider1.SetError(Me.radTextBox1, "Invalid name!")
				Return False
			End If

			Return True
		End Function

		Private Sub cancel_Button_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cancel_Button.Click
			Me.Close()
		End Sub
	End Class
End Namespace