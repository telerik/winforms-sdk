Imports System.Text
Imports Telerik.WinControls.UI

Namespace DisabledEditors
	Public Class MyRadDateTimePicker
		Inherits RadDateTimePicker
       
        Private mtb As MyTextBox
		Private tbi As RadTextBoxItem

		Protected Overrides Sub CreateChildItems(ByVal parent As Telerik.WinControls.RadElement)
			MyBase.CreateChildItems(parent)

            mtb = New MyTextBox()
			tbi = New RadTextBoxItem(mtb)
			mtb.Font = Me.Font
			Me.DateTimePickerElement.TextBoxElement.Children.Add(tbi)
		End Sub

		Protected Overrides Sub OnEnabledChanged(ByVal e As EventArgs)
			If Not Me.Enabled Then
				tbi.Text = Me.DateTimePickerElement.TextBoxElement.TextBoxItem.Text
				Me.DateTimePickerElement.TextBoxElement.TextBoxItem.Visibility = Telerik.WinControls.ElementVisibility.Hidden
			Else
				Me.DateTimePickerElement.TextBoxElement.TextBoxItem.Visibility = Telerik.WinControls.ElementVisibility.Visible
			End If

			MyBase.OnEnabledChanged(e)
        End Sub

        Public Overrides Property ThemeClassName() As String
            Get
                Return GetType(RadDateTimePicker).FullName
            End Get
            Set(ByVal value As String)

            End Set
        End Property
	End Class
End Namespace
