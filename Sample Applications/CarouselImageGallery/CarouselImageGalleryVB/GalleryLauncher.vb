Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls.UI

Namespace CarouselImageGallery
	Public Partial Class GalleryLauncher
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub radButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton2.Click
			Dim fbd As FolderBrowserDialog = New FolderBrowserDialog()
			If (Not String.IsNullOrEmpty(Me.radDropDownList1.Text)) Then
				fbd.SelectedPath = Me.radDropDownList1.Text
			End If

			If fbd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				Me.radDropDownList1.Text = fbd.SelectedPath
			End If
		End Sub

		Private Sub btnBrowse_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBrowse.Click
			Dim path As String = Me.radDropDownList1.Text.Trim()
			If Me.radDropDownList1.FindItemExact(path, False) Is Nothing Then
				Me.radDropDownList1.Items.Add(New RadListDataItem(path))
			End If

			Dim galleryView As GalleryView = New GalleryView()

			galleryView.ShowGallery(path)
		End Sub

		Private Sub GalleryLauncher_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.radDropDownList1.Text = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
		End Sub
	End Class
End Namespace