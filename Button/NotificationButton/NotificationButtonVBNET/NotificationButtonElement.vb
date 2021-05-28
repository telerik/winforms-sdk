Imports System.ComponentModel
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Public Class NotificationButtonElement
Inherits RadItem
    Private buttonElement_Renamed As RadButtonElement
    Public Event Click As EventHandler
    Private result As Integer
    Private lve As LightVisualElement
    Private sizeConst As Integer

    Protected Overrides Sub CreateChildElements()
        MyBase.CreateChildElements()
        sizeConst= 20
        buttonElement_Renamed = New RadButtonElement()
        buttonElement_Renamed.Class = "RibbonBarButtonElement"
        buttonElement_Renamed.ButtonFillElement.Class = "ButtonInRibbonFill"
        buttonElement_Renamed.BorderElement.Class = "ButtonInRibbonBorder"
        buttonElement_Renamed.Margin = New System.Windows.Forms.Padding(0, 10, 10, 0)
        AddHandler buttonElement_Renamed.Click, AddressOf buttonElement_Click
        Me.Children.Add(buttonElement_Renamed)

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
        Me.Children.Add(lve)
    End Sub

    Protected Overrides Sub OnPropertyChanged(ByVal e As RadPropertyChangedEventArgs)
        MyBase.OnPropertyChanged(e)

        If e.Property.Name = "Bounds" Then
            lve.Margin = New System.Windows.Forms.Padding(Me.Bounds.Width - sizeConst - 1, 0, 0, 0)
        End If
    End Sub

    Public Overrides Property Text() As String
        Get
            Return MyBase.Text
        End Get
        Set(value As String)
            MyBase.Text = value
            Me.ButtonElement.Text = value
        End Set
    End Property

    Private Sub buttonElement_Click(ByVal sender As Object, ByVal e As EventArgs)
        If Not ClickEvent Is Nothing Then
            RaiseEvent Click(Me.ButtonElement, e)
        End If
    End Sub

    Public ReadOnly Property ButtonElement() As RadButtonElement
        Get
            Return Me.buttonElement_Renamed
        End Get
    End Property

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
End Class
