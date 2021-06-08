Imports System.Threading

Public Class WaitingForm
    Private Shared waitingThread As Thread
    Private Shared _waitingForm As WaitingForm

    Public Sub New()
        InitializeComponent()

        Dim f As MainForm = Program.MainForm

        Dim startX As Integer = (f.Width - Me.ClientSize.Width) / 2
        Dim startY As Integer = (f.Height - Me.ClientSize.Height) / 2
        Me.Location = New System.Drawing.Point(f.Location.X + startX, f.Location.Y + startY)
        Me.Location = New System.Drawing.Point(f.Location.X + startX, f.Location.Y + startY)

        Me.RadWaitingBar1.StartWaiting()
    End Sub

    Public Shared Sub ShowForm()
        waitingThread = New Thread(New ParameterizedThreadStart(AddressOf ThreadTask))
        waitingThread.IsBackground = False
        waitingThread.Start()
    End Sub

    Private Shared Sub ThreadTask(ByVal owner As Object)
        _waitingForm = New WaitingForm()
        _waitingForm.ShowInTaskbar = False
        _waitingForm.Owner = CType(owner, Form)
        _waitingForm.FormBorderStyle = FormBorderStyle.None
        _waitingForm.ControlBox = False
        _waitingForm.TopMost = True
        _waitingForm.StartPosition = FormStartPosition.Manual

        Application.Run(_waitingForm)
    End Sub

    Public Shared Sub CloseDialogDown()
        Application.ExitThread()
    End Sub

    Public Shared Sub CloseForm()
        Do While _waitingForm Is Nothing OrElse Not _waitingForm.IsHandleCreated
            Thread.Sleep(10)
        Loop
        Dim mi As New MethodInvoker(AddressOf CloseDialogDown)
        _waitingForm.Invoke(mi)
    End Sub
End Class