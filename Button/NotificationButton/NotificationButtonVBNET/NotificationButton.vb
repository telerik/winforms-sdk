Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports System.ComponentModel

Public Class NotificationButton
Inherits RadButton
    Private result As Integer
    Private lve As LightVisualElement
    Private sizeConst As Integer

    Protected Overrides Sub CreateChildItems(ByVal parent As Telerik.WinControls.RadElement)
        MyBase.CreateChildItems(parent)
        sizeConst = 26
        lve = New LightVisualElement()
        lve.BackColor = Color.Red
        lve.DrawFill = True
        lve.StretchHorizontally = False
        lve.StretchVertically = False
        lve.GradientStyle = Telerik.WinControls.GradientStyles.Solid
        lve.Shape = New RoundRectShape(sizeConst / 2)
        lve.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        lve.ForeColor = Color.White
        lve.MinSize = New Size(sizeConst, sizeConst)
        lve.Visibility = ElementVisibility.Collapsed
        Me.RootElement.Children.Add(lve)

        ' Pushing the ButtonElement off the top and right edges
        ' so that the badge is not completely overlapped with the button
        Me.ButtonElement.Margin = New System.Windows.Forms.Padding(0, 5, 5, 0)
    End Sub

    Protected Overrides Sub InitLayout()
        MyBase.InitLayout()

        lve.Margin = New System.Windows.Forms.Padding(Me.Size.Width - sizeConst - 1, 0, 0, 0)
    End Sub

    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        MyBase.OnSizeChanged(e)

        lve.Margin = New System.Windows.Forms.Padding(Me.Size.Width - sizeConst - 1, 0, 0, 0)
    End Sub

    <DefaultValue(0)> _
    Public Property NotificationCount() As Integer
        Get
            If Not lve.Text Is Nothing Then
                Dim isInt As Boolean = Integer.TryParse(lve.Text, result)
                If isInt Then
                    Return result
                End If
            End If

            Return 0
        End Get
        Set(value As Integer)
            If value > 0 Then
                lve.Visibility = ElementVisibility.Visible
            Else
                lve.Visibility = ElementVisibility.Collapsed
            End If
            lve.Text = value.ToString()
        End Set
    End Property

    Protected Overrides ReadOnly Property DefaultSize() As Size
        Get
            Return New Size(150, 50)
        End Get
    End Property
End Class
