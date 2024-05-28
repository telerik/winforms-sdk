Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Public Class ColorPicker

    Private _ColorSelector As New Telerik.WinControls.UI.RadColorSelector

    Private _RGB As Color
    Public Property RGB() As Color
        Get
            Return _RGB
        End Get
        Set(ByVal value As Color)
            _RGB = value
            _ColorSelector.SelectedColor = Color.Aqua
            SelSelectedColor()
        End Set
    End Property

	Private Sub SelSelectedColor()

		' NO CLUE why the selection in the List Box doesn't scroll so it's visible...but i can live with that.

		'0 -> Basic tab    (which i have removed)
		'1 -> System tab
		'2 -> Web tab
		'3 -> Professional tab
		If _RGB.IsNamedColor Then
			If _RGB.IsSystemColor Then
				_ColorSelector.ControlsHolderPageView.SelectedPage = _ColorSelector.ControlsHolderPageView.Pages(1)
			Else
				_ColorSelector.ControlsHolderPageView.SelectedPage = _ColorSelector.ControlsHolderPageView.Pages(2)
			End If
			For Each myControl As Control In _ColorSelector.ControlsHolderPageView.SelectedPage.Controls
				If TypeOf myControl Is RadListControl Then
					For Each myItem As RadListDataItem In CType(myControl, RadListControl).Items
						If myItem.Text.Equals(_RGB.ToKnownColor.ToString) Then
							CType(myControl, RadListControl).SelectedItem = myItem
							myItem.Selected = True
							Exit For
						End If
					Next
				End If
			Next
		Else
			_ColorSelector.ControlsHolderPageView.SelectedPage = _ColorSelector.ControlsHolderPageView.Pages(3)
		End If

	End Sub

    Private Sub ColorPicker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BuildUI()
    End Sub

    Private Sub BuildUI()
        _ColorSelector = New Telerik.WinControls.UI.RadColorSelector
        _ColorSelector.Left = 5
        _ColorSelector.Top = 5
        _ColorSelector.ShowBasicColors = False
        _ColorSelector.ShowCustomColors = False
        _ColorSelector.AllowColorSaving = False
        _ColorSelector.AllowDrop = False

        If IsNothing(_RGB) Then
            Me.RGB = Color.White
        Else
            Me.RGB = _RGB
        End If

        ' Are we a Standard, Web or Professional Color?

        ' Wire up the buttons
        AddHandler _ColorSelector.OkButtonClicked, AddressOf ColorPicked
        AddHandler _ColorSelector.CancelButtonClicked, AddressOf Cancelled

        Me.Controls.Add(_ColorSelector)
    End Sub

    Private Sub ColorPicked()
        _RGB = _ColorSelector.SelectedColor
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Hide()
    End Sub

    Private Sub Cancelled()
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Hide()
    End Sub

End Class
