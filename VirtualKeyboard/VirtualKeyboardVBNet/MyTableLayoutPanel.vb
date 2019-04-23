Imports System.Linq
Imports System.Text

Namespace CSSoftKeyboard
	Public Class MyBufferedTableLayoutPanel
		Inherits TableLayoutPanel
		Public Sub New()
			MyBase.New()
			Me.SetStyle(ControlStyles.UserPaint Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer, True)
		End Sub
	End Class
End Namespace
