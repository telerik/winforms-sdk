Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Telerik.WinControls.Primitives

Imports Telerik.WinControls.UI

Namespace CarouselImageGallery
	Public Partial Class GalleryView
		Inherits RadForm
		Private shouldZoomSelectedItem As Boolean = False
		Private zoomedItem As CarouselContentItem
		Private currScaleFactor As Single = 1f
		Private animationRunning As Integer

		Public Sub New()
			InitializeComponent()
		End Sub

		Public Sub ShowGallery(ByVal path As String)
			Me.Text = path

			Dim jpgFiles As String() = Directory.GetFiles(path, "*.jpg", SearchOption.AllDirectories)
			Dim jpegFiles As String() = Directory.GetFiles(path, "*.jpeg", SearchOption.AllDirectories)
			Dim bmpFiles As String() = Directory.GetFiles(path, "*.bmp", SearchOption.AllDirectories)
			Dim gifFiles As String() = Directory.GetFiles(path, "*.gif", SearchOption.AllDirectories)
			Dim pngFiles As String() = Directory.GetFiles(path, "*.png", SearchOption.AllDirectories)

			Me.radCarousel1.Items.Clear()

			Dim imageFiles As List(Of String) = New List(Of String)(jpgFiles.Length + jpegFiles.Length + bmpFiles.Length + gifFiles.Length + pngFiles.Length)
			imageFiles.AddRange(jpgFiles)
			imageFiles.AddRange(jpegFiles)
			imageFiles.AddRange(bmpFiles)
			imageFiles.AddRange(gifFiles)
			imageFiles.AddRange(pngFiles)

			Me.radCarousel1.DataSource = imageFiles
			Me.Show()
		End Sub

		Private Sub radCarousel1_ItemDataBound(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.ItemDataBoundEventArgs) Handles radCarousel1.ItemDataBound
			Dim button As RadButtonElement = CType(e.DataBoundItem, RadButtonElement)
			button.Text = CStr(e.DataItem)
			button.MinSize = New Size(20, 20)
			'button.AutoSize = false;
			button.DisplayStyle = DisplayStyle.Image
			button.ImagePrimitive.ImageLayout = ImageLayout.Zoom

			AddHandler button.MouseDown, AddressOf button_MouseDown

			If Me.radCarousel1.Items.Count < Me.radCarousel1.VisibleItemCount Then
				LoadItemImage(button, True)
			End If
		End Sub

		Private Sub button_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
			Dim currentZoomed As CarouselContentItem = zoomedItem
			ResetZoomedItem()

			Dim button As RadButtonElement = CType(sender, RadButtonElement)

			Dim contentItem As CarouselContentItem = CType(button.Parent, CarouselContentItem)
			If currentZoomed Is contentItem Then
				Return
			End If

			If Not Me.radCarousel1.SelectedItem Is button Then
				Return
			End If

			ZoomSelectedItemOnAnimationFinished()
		End Sub

		Private Sub ZoomItem(ByVal button As RadButtonElement)
			shouldZoomSelectedItem = False
			Dim size As Size = Me.radCarousel1.CarouselElement.ItemsContainer.Size

			Dim contentItem As CarouselContentItem = CType(button.Parent, CarouselContentItem)

			zoomedItem = contentItem

			button.ButtonFillElement.Visibility = ElementVisibility.Collapsed

			currScaleFactor = Math.Min((CSng(size.Width)) / button.Size.Width / 2f, (CSng(size.Height)) / button.Size.Height / 2f)

			Dim scaleChange As AnimatedPropertySetting = New AnimatedPropertySetting(RadElement.ScaleTransformProperty, New SizeF(currScaleFactor, currScaleFactor), New SizeF(2, 2), 20, 1)

			AddHandler scaleChange.AnimationFinished, AddressOf scaleChange_AnimationFinished

			Dim offset As SizeF = New SizeF((size.Width - contentItem.Size.Width * currScaleFactor) / 2f - contentItem.Location.X, (size.Height - contentItem.Size.Height * 0.50f * currScaleFactor) / 2f - contentItem.Location.Y)

			Dim positionChange As AnimatedPropertySetting = New AnimatedPropertySetting(RadElement.PositionOffsetProperty, offset, New SizeF(2, 2), 20, 1)

			scaleChange.ApplyValue(contentItem)
			positionChange.ApplyValue(contentItem)
		End Sub

		Private Sub scaleChange_AnimationFinished(ByVal sender As Object, ByVal e As AnimationStatusEventArgs)
			Dim button As RadButtonElement = CType(Me.zoomedItem.HostedItem, RadButtonElement)
            LoadItemImage(button, False)
            'SizeToFit is needed in order to enable ScaleSize
            button.ImagePrimitive.ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
			button.ImagePrimitive.ScaleSize = New Size(CInt(Fix(Math.Round(button.Size.Width - button.BorderThickness.All * currScaleFactor / 2f))), CInt(Fix(Math.Round(button.Size.Height - button.BorderThickness.All * currScaleFactor / 2f))))
		End Sub

		Private Function GetThumbnailImageAbort() As Boolean
			Return False
		End Function

		Private Sub GalleryView_Shown(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Shown
			If Me.radCarousel1.Items.Count > 0 Then
				Me.radCarousel1.SelectedIndex = 0
			End If

			Me.Text = String.Format("Showing gallery of {0} images. Location: ", Me.radCarousel1.Items.Count) & Me.Text

			Me.radCarousel1.CarouselElement.ItemsContainer.ForceUpdate()
		End Sub

		Private Sub radCarousel1_NewCarouselItemCreating(ByVal sender As Object, ByVal e As NewCarouselItemCreatingEventArgs) Handles radCarousel1.NewCarouselItemCreating
			e.NewCarouselItem = New RadButtonElement()
		End Sub

		Private Sub GalleryView_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			'this.radCarousel1.EnableAutoLoop = true;
		End Sub

		Private Sub radCarousel1_CarouselElement_ItemEntering(ByVal sender As Object, ByVal e As ItemEnteringEventArgs) Handles radCarousel1.CarouselElement.ItemEntering
			Dim button As RadButtonElement = CType(Me.radCarousel1.Items(e.ItemIndex), RadButtonElement)
			LoadItemImage(button, True)
		End Sub

		Private Sub LoadItemImage(ByVal button As RadButtonElement, ByVal thumbnail As Boolean)
			If Not button Is Nothing AndAlso (Not String.IsNullOrEmpty(button.Text)) AndAlso (button.Image Is Nothing OrElse (Not thumbnail)) Then
				Dim res As Image = Image.FromFile(button.Text)

				If thumbnail Then
					button.Image = res.GetThumbnailImage(CInt(Fix(70R * (CDbl(res.Width) / res.Height))), 70, AddressOf Me.GetThumbnailImageAbort, IntPtr.Zero)
				Else
					button.Image = res
				End If
			End If
		End Sub

		Private Sub radCarousel1_CarouselElement_ItemLeaving(ByVal sender As Object, ByVal e As ItemLeavingEventArgs) Handles radCarousel1.CarouselElement.ItemLeaving
			Dim button As RadButtonElement = CType(Me.radCarousel1.Items(e.ItemIndex), RadButtonElement)
			UnloadItemImage(button)
		End Sub

		Private Sub UnloadItemImage(ByVal button As RadButtonElement)
			If Not button Is Nothing AndAlso Not button.Image Is Nothing Then
				button.Image = Nothing
			End If
		End Sub

		Private Sub ResetZoomedItem()
			If Me.zoomedItem Is Nothing Then
				Return
			End If

			CType(zoomedItem.HostedItem, RadButtonElement).ButtonFillElement.Visibility = ElementVisibility.Visible
            'reset the scale size
            CType(zoomedItem.HostedItem, RadButtonElement).ImagePrimitive.ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.None

			Dim scaleChange As AnimatedPropertySetting = New AnimatedPropertySetting(RadElement.ScaleTransformProperty, New SizeF(1.0F, 1.0F), New SizeF(2, 2), 20, 0)

			Dim positionChange As AnimatedPropertySetting = New AnimatedPropertySetting(RadElement.PositionOffsetProperty, New SizeF(0, 0), New SizeF(2, 2), 20, 0)

			scaleChange.ApplyValue(zoomedItem)
			positionChange.ApplyValue(zoomedItem)

			CType(zoomedItem.HostedItem, RadButtonElement).ImagePrimitive.ScaleSize = Size.Empty

			UnloadItemImage(CType(zoomedItem.HostedItem, RadButtonElement))
			LoadItemImage(CType(zoomedItem.HostedItem, RadButtonElement), True)

			Me.zoomedItem = Nothing
		End Sub

		Private Sub radCarousel1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radCarousel1.SelectedIndexChanged
			ResetZoomedItem()
		End Sub

		Private Sub radCarousel1_CarouselElement_AnimationFinished(ByVal sender As Object, ByVal e As EventArgs) Handles radCarousel1.CarouselElement.AnimationFinished
			Me.animationRunning -= 1

			If animationRunning < 0 Then
				animationRunning = 0
			End If

			If Me.shouldZoomSelectedItem Then
				ZoomSelectedItemOnAnimationFinished()
			End If
		End Sub

		Private Sub ZoomSelectedItemOnAnimationFinished()
			shouldZoomSelectedItem = True

			If Not Me.radCarousel1.SelectedItem Is Nothing AndAlso animationRunning = 0 Then
				Me.ZoomItem(CType(Me.radCarousel1.SelectedItem, RadButtonElement))
			End If
		End Sub

		Private Sub radCarousel1_CarouselElement_AnimationStarted(ByVal sender As Object, ByVal e As EventArgs) Handles radCarousel1.CarouselElement.AnimationStarted
			Me.animationRunning += 1
			Me.ResetZoomedItem()
		End Sub
	End Class
End Namespace