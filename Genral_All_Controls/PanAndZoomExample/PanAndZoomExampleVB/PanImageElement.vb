Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Public Class PanImageElement
    Inherits LightVisualElement

    Private _imageElement As ImageElement

    Protected Overrides Sub InitializeFields()
        MyBase.InitializeFields()
        Me.DrawBorder = True
        Me.BorderColor = Color.LightBlue
        Me.BorderGradientStyle = GradientStyles.Solid
        Me.ClipDrawing = True
    End Sub

    Protected Overrides Sub CreateChildElements()
        MyBase.CreateChildElements()
        Me._imageElement = New ImageElement()
        Me.Children.Add(Me._imageElement)
    End Sub

    Public ReadOnly Property ImageElement As ImageElement
        Get
            Return _imageElement
        End Get
    End Property

    Protected Overrides Function MeasureOverride(ByVal availableSize As SizeF) As SizeF
        Dim finalSize As SizeF = MyBase.MeasureOverride(availableSize)
        Me._imageElement.Measure(New SizeF(Single.PositiveInfinity, Single.PositiveInfinity))
        Return finalSize
    End Function

    Protected Overrides Function ArrangeOverride(ByVal finalSize As SizeF) As SizeF
        Dim clientRect As RectangleF = Me.GetClientRectangle(finalSize)
        Dim imageRect As RectangleF = New RectangleF(clientRect.X + Me._imageElement.Offset.Width, clientRect.Y + Me._imageElement.Offset.Height, Me._imageElement.DesiredSize.Width, Me._imageElement.DesiredSize.Height)

        If imageRect.Width < clientRect.Width Then
            imageRect.X = clientRect.X
            Me._imageElement.Offset = New SizeF(0, Me._imageElement.Offset.Height)
        End If

        If imageRect.Height < clientRect.Height Then
            imageRect.Y = clientRect.Y
            Me._imageElement.Offset = New SizeF(Me._imageElement.Offset.Width, 0)
        End If

        Me._imageElement.Arrange(imageRect)
        Return clientRect.Size
    End Function
End Class
