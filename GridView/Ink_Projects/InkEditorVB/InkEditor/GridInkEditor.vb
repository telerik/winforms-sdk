Imports Microsoft.Ink
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace InkEditor
	Friend Class GridInkEditor
		Inherits BaseGridEditor

		Private inkEdit1 As InkEdit
		Public Overrides Property Value() As Object
			Get
				Return inkEdit1.Text
			End Get

			Set(ByVal value As Object)
				If value IsNot Nothing Then
					inkEdit1.Text = value.ToString()
				End If

			End Set
		End Property
		Protected Overrides Function CreateEditorElement() As RadElement
			Me.inkEdit1 = New InkEdit()
			Me.inkEdit1.RecoTimeout = 1000


			Me.inkEdit1.UseMouseForInput = True

			Dim host = New RadHostItem(inkEdit1)
			host.BackColor = System.Drawing.Color.White
			Return host
		End Function

	End Class
End Namespace
