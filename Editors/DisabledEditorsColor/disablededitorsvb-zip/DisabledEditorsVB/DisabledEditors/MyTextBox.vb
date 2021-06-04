Imports System.Text
Imports Telerik.WinControls.UI

Namespace DisabledEditors
	Public Class MyTextBox
		Inherits HostedTextBoxBase
		Public Sub New()
			Me.SetStyle(ControlStyles.UserPaint, True)
		End Sub

		Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
			Dim drawBrush As New SolidBrush(Color.Red)
			e.Graphics.DrawString(Text, Font, drawBrush, -1f, -1f)
		End Sub
	End Class
End Namespace
