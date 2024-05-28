Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls

Namespace RadUserControls
	Public Partial Class UserControl1
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton1.Click
			RadMessageBox.Show("I am a RadButton")
		End Sub
	End Class
End Namespace