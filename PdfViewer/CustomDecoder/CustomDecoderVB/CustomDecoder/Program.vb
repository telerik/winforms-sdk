Imports System
Imports System.Linq
Imports System.Windows.Forms

Namespace CustomDecoder
	Friend Module Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread>
		Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New RadForm1())
		End Sub
	End Module
End Namespace