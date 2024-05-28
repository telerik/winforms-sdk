Public Class ColorEditor
    Inherits PropertyEditorBase

    Private WithEvents ColorPickerControl As ColorPicker

    ''' <summary>
    ''' Displays our custom color picker
    ''' </summary>
    Protected Overrides Function GetEditControl(ByVal PropertyName As String, ByVal CurrentValue As Object) As System.Windows.Forms.Control
        ColorPickerControl = New ColorPicker()

        Dim CurrentColor As Color

        If CurrentValue IsNot Nothing Then
            CurrentColor = CurrentValue                 ' Use our current value if we have one
        Else
            CurrentColor = Color.White                  ' Use white, if we dont.
        End If

        ColorPickerControl.RGB = CurrentColor

        Return ColorPickerControl
    End Function


    ''' <summary>
    ''' Gets the edited value and returns that value to the class...or the user clicked the escape or cancel
    ''' in which case, the original value is returned
    ''' </summary>
    Protected Overrides Function GetEditedValue(ByVal EditControl As System.Windows.Forms.Control, ByVal PropertyName As String, ByVal OldValue As Object) As Object
        Dim RetValue As Object

        If ColorPickerControl Is Nothing Then
            RetValue = OldValue
        End If

        If ColorPickerControl.DialogResult = DialogResult.Cancel Then
            RetValue = OldValue
        Else
            RetValue = ColorPickerControl.RGB
        End If

        ColorPickerControl.Dispose()
        ColorPickerControl = Nothing

        Return RetValue

    End Function

    Public Overrides Function GetPaintValueSupported(ByVal context As System.ComponentModel.ITypeDescriptorContext) As Boolean
        Return True
    End Function

    Public Overrides Sub PaintValue(ByVal e As System.Drawing.Design.PaintValueEventArgs)
        ' Erase the area.
        e.Graphics.FillRectangle(Brushes.White, e.Bounds)

        ' Draw the sample.
        Dim clr As Color = DirectCast(e.Value, Color)
        e.Graphics.FillRectangle(New SolidBrush(clr), e.Bounds)
    End Sub

End Class
