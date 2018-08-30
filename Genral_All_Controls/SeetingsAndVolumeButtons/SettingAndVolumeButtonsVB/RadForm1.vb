Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Telerik.WinControls.Primitives

Namespace SettingAndVolumeButtons
	Partial Public Class RadForm1
		Inherits Telerik.WinControls.UI.RadForm

		Public Sub New()
			'new Telerik.WinControls.RadControlSpy.RadControlSpyForm().Show();
			InitializeComponent()
			'setup popup editor
			radPopupEditor1.DropDownSizingMode = Telerik.WinControls.UI.SizingMode.None

			Dim imagePrimitive = TryCast(radPopupEditor1.PopupEditorElement.ArrowButtonElement.Children(4), ImagePrimitive)
			imagePrimitive.Image = My.Resources.volume.GetThumbnailImage(30, 30, Nothing, IntPtr.Zero)
			radPopupEditor1.Width = imagePrimitive.Image.Width

			Dim fillPrimitive = TryCast(radPopupEditor1.PopupEditorElement.ArrowButtonElement.Children(0), FillPrimitive)
			fillPrimitive.Visibility = Telerik.WinControls.ElementVisibility.Collapsed

			Dim borderPrimitive = TryCast(radPopupEditor1.PopupEditorElement.ArrowButtonElement.Children(1), BorderPrimitive)
			borderPrimitive.Visibility = Telerik.WinControls.ElementVisibility.Collapsed

			Dim popupBorder = TryCast(Me.radPopupEditor1.PopupEditorElement.Children(0), BorderPrimitive)
			popupBorder.Visibility = Telerik.WinControls.ElementVisibility.Collapsed

			Dim popupFill = TryCast(Me.radPopupEditor1.PopupEditorElement.Children(1), FillPrimitive)
			popupFill.Visibility = Telerik.WinControls.ElementVisibility.Collapsed

			radPopupEditor1.EditableAreaElement.Visibility = Telerik.WinControls.ElementVisibility.Collapsed

            'setup drop down button
			radDropDownButton1.RootElement.BackColor = Color.Transparent
			radDropDownButton1.DropDownButtonElement.BorderElement.Visibility = ElementVisibility.Collapsed
			radDropDownButton1.DropDownButtonElement.ActionButton.ImagePrimitive.Image = My.Resources.wrench.GetThumbnailImage(30, 30, Nothing, IntPtr.Zero)
			radDropDownButton1.DropDownButtonElement.DisplayStyle = DisplayStyle.Image
			radDropDownButton1.DropDownButtonElement.ActionButton.ButtonFillElement.BackColor = Color.Transparent
			radDropDownButton1.DropDownButtonElement.ArrowButton.Visibility = ElementVisibility.Collapsed
		End Sub
	End Class
End Namespace
