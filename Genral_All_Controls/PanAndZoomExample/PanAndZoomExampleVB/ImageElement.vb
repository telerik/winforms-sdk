Imports Telerik.WinControls.UI

Public Class ImageElement
    Inherits LightVisualElement

    Private localOffset As SizeF
    Private mouseDownLocation As Point
    Private _offset As SizeF
    Private flag As Boolean = False
    Private zoom As Single = 20.0F

    Protected Overrides Sub InitializeFields()
        MyBase.InitializeFields()
        Me.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
    End Sub

    Public Property Offset As SizeF
        Get
            Return _offset
        End Get
        Set(ByVal value As SizeF)
            _offset = value
        End Set
    End Property

    Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
        MyBase.OnMouseEnter(e)
        Me.ElementTree.Control.Cursor = Cursors.Hand
    End Sub

    Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
        MyBase.OnMouseLeave(e)
        Me.ElementTree.Control.Cursor = Cursors.[Default]
    End Sub

    Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        Me.localOffset = Me._offset
        Me.mouseDownLocation = e.Location
        Me.Capture = True
        Me.flag = True
    End Sub

    Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
        MyBase.OnMouseMove(e)

        If e.Button = MouseButtons.Left AndAlso Me.flag Then
            Dim width As Single = Me.localOffset.Width + e.Location.X - Me.mouseDownLocation.X
            Dim height As Single = Me.localOffset.Height + e.Location.Y - Me.mouseDownLocation.Y

            If width > 0 Then
                width = 0
            End If

            If height > 0 Then
                height = 0
            End If

            If width < Me.Parent.Size.Width - Me.Size.Width Then
                width = Me.Parent.Size.Width - Me.Size.Width
            End If

            If height < Me.Parent.Size.Height - Me.Size.Height Then
                height = Me.Parent.Size.Height - Me.Size.Height
            End If

            Me._offset = New SizeF(width, height)
            Me.Parent.InvalidateArrange()
        End If
    End Sub

    Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        Me.flag = False
        Me.Capture = False
    End Sub

    Protected Overrides Sub OnMouseWheel(ByVal e As MouseEventArgs)
        MyBase.OnMouseWheel(e)

        If Control.ModifierKeys = Keys.Control Then
            zoom += (e.Delta / 120)

            If zoom < 1.0F Then
                zoom = 1.0F
            End If

            If zoom > 40.0F Then
                zoom = 40.0F
            End If

            Me.Parent.InvalidateMeasure(True)
            Me.Parent.UpdateLayout()

            If Me.Size.Width > Me.Parent.Size.Width Then

                If Me._offset.Width + Me.Size.Width < Me.Parent.Size.Width Then
                    Me._offset = New SizeF(Me._offset.Width + (Me.Parent.ControlBoundingRectangle.Right - Me.ControlBoundingRectangle.Right), Me._offset.Height)
                End If
            End If

            If Me.Size.Height > Me.Parent.Size.Height Then

                If Me._offset.Height + Me.Size.Height < Me.Parent.Size.Height Then
                    Me._offset = New SizeF(Me._offset.Width, Me._offset.Height + Me.Parent.ControlBoundingRectangle.Bottom - Me.ControlBoundingRectangle.Bottom)
                End If
            End If

            Me.Parent.InvalidateArrange(True)
        End If
    End Sub

    Protected Overrides Function MeasureOverride(ByVal availableSize As SizeF) As SizeF
        If Image IsNot Nothing Then Return New SizeF(Me.Image.Width * zoom / 20.0F, Me.Image.Height * zoom / 20.0F)
        Return New SizeF(Me.Parent.Size.Width, Me.Parent.Size.Height)
    End Function
End Class