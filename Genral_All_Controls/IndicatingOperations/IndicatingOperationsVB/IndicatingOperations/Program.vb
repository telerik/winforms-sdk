Public Module Program
    Private m_MainForm As MainForm

    Public ReadOnly Property MainForm() As MainForm
        Get
            Return m_MainForm
        End Get
    End Property

    Public Sub Main()
        m_MainForm = New MainForm()
        Application.Run(m_MainForm)
    End Sub
End Module