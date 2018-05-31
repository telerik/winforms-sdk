Imports System.Globalization
Imports Telerik.WinControls.UI

#Region "CustomRadSpinElement"
Public Class MyRadSpinElement
    Inherits RadSpinElement

    Private _leadingZero As Boolean
    Private _scientificNation As Boolean

    Protected Overrides ReadOnly Property ThemeEffectiveType As Type
        Get
            Return GetType(RadSpinElement)
        End Get
    End Property

    Public Property ScientificNation As Boolean
        Get
            Return Me._scientificNation
        End Get
        Set(ByVal value As Boolean)

            If Me._scientificNation <> value Then
                Me._scientificNation = value
                Me.SetSpinValue(Me.internalValue, True)
            End If
        End Set
    End Property

    Public Property LeadingZero As Boolean
        Get
            Return Me._leadingZero
        End Get
        Set(ByVal value As Boolean)

            If Me._leadingZero <> value Then
                Me._leadingZero = value
                Me.SetSpinValue(Me.internalValue, True)
            End If
        End Set
    End Property

    Protected Overrides Function GetValueFromText() As Decimal
        If Not Me.ScientificNation Then
            Return MyBase.GetValueFromText()
        End If

        Try

            If Not String.IsNullOrEmpty(Me.Text) AndAlso ((Me.Text.Length <> 1) OrElse (Me.Text <> "-")) Then
                Return Me.Constrain(Decimal.Parse(Me.Text, NumberStyles.AllowExponent Or NumberStyles.AllowDecimalPoint))
            Else
                Return Me.internalValue
            End If

        Catch
            Return Me.internalValue
        End Try
    End Function

    Protected Overrides Sub SetSpinValue(ByVal value As Decimal, ByVal fromValue As Boolean)
        MyBase.SetSpinValue(value, fromValue)
        Me.TextBoxControl.Text = GetNumberText(Me.internalValue)
    End Sub

    Protected Overrides Function GetNumberText(ByVal num As Decimal) As String
        If Me.Hexadecimal Then
            Return String.Format("{0:X}", CLng(num))
        End If

        If Me.ScientificNation Then
            Return num.ToString("E", CultureInfo.CurrentCulture)
        End If

        If Me.LeadingZero Then
            Return num.ToString("00.##", CultureInfo.CurrentCulture)
        End If

        Return num.ToString((If(Me.ThousandsSeparator, "N", "F")) & Me.DecimalPlaces.ToString(CultureInfo.CurrentCulture), CultureInfo.CurrentCulture)
    End Function
End Class
#End Region
