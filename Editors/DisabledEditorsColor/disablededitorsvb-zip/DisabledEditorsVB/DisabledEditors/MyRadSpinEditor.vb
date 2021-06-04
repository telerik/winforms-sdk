Imports System.Text
Imports Telerik.WinControls.UI

Namespace DisabledEditors
	Public Class MyRadSpinEditor
        Inherits RadSpinEditor

		Private realTB As RadTextBoxItem
        Private mtb As MyTextBox
		Private tbi As RadTextBoxItem

		Protected Overrides Sub CreateChildItems(ByVal parent As Telerik.WinControls.RadElement)
			MyBase.CreateChildItems(parent)

            mtb = New MyTextBox()
			realTB = Me.SpinElement.TextBoxItem
			tbi = New RadTextBoxItem(mtb)
			mtb.Font = Me.Font
		End Sub

		Protected Overrides Sub OnEnabledChanged(ByVal e As EventArgs)
			If Not Me.Enabled Then
				tbi.Text = Me.Text
				Me.SpinElement.Children(2).Children.Remove(realTB)
				Me.SpinElement.Children(2).Children.Add(tbi)
			Else
				Me.SpinElement.Children(2).Children.Add(realTB)
				Me.SpinElement.Children(2).Children.Remove(tbi)
			End If

			MyBase.OnEnabledChanged(e)
        End Sub

        Public Overrides Property ThemeClassName() As String
            Get
                Return GetType(RadSpinEditor).FullName
            End Get
            Set(ByVal value As String)

            End Set
        End Property
	End Class
End Namespace
