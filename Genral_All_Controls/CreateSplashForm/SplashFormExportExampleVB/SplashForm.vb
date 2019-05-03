Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports Telerik.WinControls.UI

Namespace SplashFormExportExample

	Partial Public Class SplashForm
		Inherits Form

		Private Shared waitingThread As Thread
		Private Shared waitingForm As SplashForm

		Public Sub New()
			InitializeComponent()
		End Sub

		Public Shared Sub ShowForm(ByVal owner As Form)

			waitingThread = New Thread(New ParameterizedThreadStart(AddressOf ThreadTask))
			waitingThread.IsBackground = False
			Dim rect As New Rectangle(owner.DesktopLocation, owner.Size)
			waitingThread.Start(New With {Key .OwnerRect = rect})
		End Sub

		Private Shared Sub ThreadTask(ByVal info As Object)
			'initialize the form
			waitingForm = New SplashForm()
			waitingForm.ShowInTaskbar = False
			Dim [or] As Rectangle = CType(info.GetType().GetProperty("OwnerRect").GetValue(info), Rectangle)
'INSTANT VB NOTE: The variable location was renamed since Visual Basic does not handle local variables named the same as class members well:
			Dim location_Renamed As New Point([or].X + ([or].Width - waitingForm.Width) \ 2, [or].Y + ([or].Height - waitingForm.Height) \ 2)
			waitingForm.Location = location_Renamed
			waitingForm.FormBorderStyle = FormBorderStyle.None
			waitingForm.ControlBox = False
			waitingForm.TopMost = True
			waitingForm.StartPosition = FormStartPosition.Manual

			Dim pb As RadProgressBar = TryCast(waitingForm.Controls(0), RadProgressBar)
			Dim wb As New RadWaitingBar()
			wb.Size = pb.Size
			wb.Location = pb.Location

			waitingForm.Controls.Remove(pb)
			waitingForm.Controls.Add(wb)

			wb.StartWaiting()


			Application.Run(waitingForm)
		End Sub

		Public Shared Sub CloseDialogDown()
			Application.ExitThread()
		End Sub

		Public Shared Sub CloseForm()
			Do While waitingForm Is Nothing OrElse Not waitingForm.IsHandleCreated
				Thread.Sleep(10)
			Loop
			Dim mi As New MethodInvoker(AddressOf CloseDialogDown)
			waitingForm.Invoke(mi)
		End Sub

	End Class
End Namespace
