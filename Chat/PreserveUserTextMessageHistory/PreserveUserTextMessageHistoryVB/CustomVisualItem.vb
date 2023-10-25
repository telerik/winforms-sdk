Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class CustomVisualItem
    Inherits RadListVisualItem

    Private myLightVisualElement As LightVisualElement
    Private font1 As FontFamily

    Protected Overrides Sub CreateChildElements()
        font1 = ThemeResolutionService.GetCustomFont(ThemeResolutionService.TelerikWebUIFontName)
        MyBase.CreateChildElements()
        Me.myLightVisualElement = New LightVisualElement()
        Me.myLightVisualElement.CustomFont = font1.Name
        Me.myLightVisualElement.Visibility = ElementVisibility.Hidden
        Me.myLightVisualElement.Text = TelerikWebUIFont.GlyphEmail
        Me.myLightVisualElement.TextAlignment = ContentAlignment.MiddleRight
        Me.Children.Add(Me.myLightVisualElement)
    End Sub

    Public Property MessageNotification As ElementVisibility
        Get
            Return Me.myLightVisualElement.Visibility
        End Get
        Set(ByVal value As ElementVisibility)
            Me.myLightVisualElement.Visibility = value
        End Set
    End Property

    Protected Overrides ReadOnly Property ThemeEffectiveType As Type
        Get
            Return GetType(RadListVisualItem)
        End Get
    End Property
End Class
