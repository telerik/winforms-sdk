Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports Telerik.WinControls.UI

Namespace _1408634
	Partial Public Class CustomMCCBEditor
		Inherits UserControl

		Public Sub New()
			InitializeComponent()
			Me.radGridView1.AllowAddNewRow = False
			Me.radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
			Me.radPopupEditor1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDown
			Me.radGridView1.ReadOnly = True
			AddHandler Me.radGridView1.CurrentRowChanged, AddressOf RadGridView1_CurrentRowChanged
			AddHandler Me.TextBox.KeyDown, AddressOf TextBox_KeyDown
			AddHandler Me.radGridView1.CellDoubleClick, AddressOf RadGridView1_CellDoubleClick
		End Sub

		Private Sub RadGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As GridViewCellEventArgs)
			Me.PopupEditor.PopupEditorElement.ClosePopup()
		End Sub

		Private Sub TextBox_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
			If e.KeyCode = Keys.Enter Then
				Me.PopupEditor.PopupEditorElement.ClosePopup()
			End If
		End Sub

		Private Sub RadGridView1_CurrentRowChanged(ByVal sender As Object, ByVal e As CurrentRowChangedEventArgs)


		End Sub

		Public ReadOnly Property Value() As Object
			Get
				If Me.radGridView1.CurrentRow IsNot Nothing AndAlso TypeOf Me.radGridView1.CurrentRow Is GridViewDataRowInfo Then
					Return Me.radGridView1.CurrentRow.Cells(0).Value
				End If
				Return Nothing
			End Get
		End Property
		Public ReadOnly Property TextBox() As RadTextBoxElement
			Get
				Return Me.radPopupEditor1.TextBoxElement
			End Get
		End Property
		Public ReadOnly Property GridControl() As RadGridView
			Get
				Return Me.radGridView1
			End Get
		End Property
		Public ReadOnly Property PopupEditor() As RadPopupEditor
			Get
				Return Me.radPopupEditor1
			End Get
		End Property

	End Class
End Namespace
