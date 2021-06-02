Public Class SplashForm
    Public Sub New()

        InitializeComponent()

        Dim spashPictureBox As New PictureBox()

        spashPictureBox.Image = My.Resources.telerik_logo_RGB_photoshop
        spashPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        spashPictureBox.Dock = DockStyle.Fill
        Me.Controls.Add(spashPictureBox)

        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub
End Class