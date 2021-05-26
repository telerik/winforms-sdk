Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Text
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Namespace GridViewCustomCells
	Public Class IndicatedComboBoxCellElement
		Inherits GridComboBoxCellElement

		Private indicator As RadDropDownListArrowButtonElement

		Public Sub New(ByVal column As GridViewColumn, ByVal row As GridRowElement)
			MyBase.New(column, row)
            'this code adds a registration for RadDropDownListArrowButtonElement in order to allow its usage in other controls
			Dim theme As Theme = ThemeRepository.ControlDefault
			Dim sg As StyleGroup = theme.FindStyleGroup("Telerik.WinControls.UI.RadDropDownList")
			sg.Registrations.Add(New StyleRegistration("Telerik.WinControls.UI.RadDropDownListArrowButtonElement"))

			indicator = New RadDropDownListArrowButtonElement()
			indicator.MaxSize = New System.Drawing.Size(18, 20)
			indicator.Alignment = ContentAlignment.MiddleRight
			indicator.NotifyParentOnMouseInput = False
			AddHandler indicator.Click, AddressOf indicator_Click

			Me.Children.Add(indicator)
		End Sub

		Protected Overrides Sub OnCellFormatting(ByVal e As CellFormattingEventArgs)
			MyBase.OnCellFormatting(e)
			If indicator IsNot Nothing Then
				indicator.Visibility = If(CType(Me.ColumnInfo, IndicatedComboBoxColumn).EnableIndicator = True, ElementVisibility.Visible, ElementVisibility.Collapsed)
			End If
		End Sub

		Private Sub indicator_Click(ByVal sender As Object, ByVal e As EventArgs)
			AddHandler Me.GridControl.CellEditorInitialized, AddressOf grid_CellEditorInitialized

			Me.GridControl.EndEdit()
			Me.GridControl.BeginEdit()
		End Sub

		Private Sub grid_CellEditorInitialized(ByVal sender As Object, ByVal e As GridViewCellEventArgs)

            Dim currentEditor As RadDropDownListEditor = TryCast(e.ActiveEditor, RadDropDownListEditor)
            If currentEditor IsNot Nothing Then
                RemoveHandler Me.GridControl.CellEditorInitialized, AddressOf grid_CellEditorInitialized

                Dim element As RadDropDownListEditorElement = TryCast(currentEditor.EditorElement, RadDropDownListEditorElement)
                element.ShowPopup()
            End If
		End Sub

		Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
			Get
				Return GetType(GridComboBoxCellElement)
			End Get
		End Property

		Public Overrides Function IsCompatible(ByVal data As GridViewColumn, ByVal context As Object) As Boolean
			Return TypeOf data Is IndicatedComboBoxColumn AndAlso TypeOf context Is GridDataRowElement
		End Function
	End Class
End Namespace