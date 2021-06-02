Imports System.Threading

Module Program

    Public splashForm As SplashForm = Nothing

    Public Sub Main()

        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        Dim splashThread As New Thread(
        New ThreadStart(Sub()
                            SplashForm = New SplashForm()
                            Application.Run(SplashForm)
                        End Sub))

        splashThread.SetApartmentState(ApartmentState.STA)
        splashThread.Start()

        Dim mainForm As MainForm = New MainForm()
        AddHandler mainForm.Load, AddressOf mainForm_Load

        Application.Run(mainForm)

    End Sub

    Private Sub mainForm_Load(sender As Object, e As EventArgs)
        'close splash
        If splashForm Is Nothing Then
            Return
        End If

        splashForm.Invoke(Sub() splashForm.Close())
        splashForm.Dispose()
        splashForm = Nothing
    End Sub

End Module
