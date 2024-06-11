Imports Microsoft.VisualBasic
Imports System
Namespace CarouselImageGallery
	Public Partial Class GalleryView
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not components Is Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim carouselBezierPath2 As Telerik.WinControls.UI.CarouselBezierPath = New Telerik.WinControls.UI.CarouselBezierPath()
			Dim themeSource6 As Telerik.WinControls.ThemeSource = New Telerik.WinControls.ThemeSource()
			Me.radCarousel1 = New Telerik.WinControls.UI.RadCarousel()
			Me.radButtonElement1 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement2 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement3 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radThemeManager1 = New Telerik.WinControls.RadThemeManager()
			Me.office2010BlackTheme1 = New Telerik.WinControls.Themes.Office2010BlackTheme()
			CType(Me.radCarousel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radCarousel1
			' 
			Me.radCarousel1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radCarousel1.AnimationDelay = 10
			' 
			' 
			' 
'			Me.radCarousel1.CarouselElement.AnimationStarted += New System.EventHandler(Me.radCarousel1_CarouselElement_AnimationStarted);
'			Me.radCarousel1.CarouselElement.AnimationFinished += New System.EventHandler(Me.radCarousel1_CarouselElement_AnimationFinished);
'			Me.radCarousel1.CarouselElement.ItemLeaving += New Telerik.WinControls.UI.ItemLeavingEventHandler(Me.radCarousel1_CarouselElement_ItemLeaving);
'			Me.radCarousel1.CarouselElement.ItemEntering += New Telerik.WinControls.UI.ItemEnteringEventHandler(Me.radCarousel1_CarouselElement_ItemEntering);
			carouselBezierPath2.CtrlPoint1 = New Telerik.WinControls.UI.Point3D(20, 80, 350)
			carouselBezierPath2.CtrlPoint2 = New Telerik.WinControls.UI.Point3D(80, 80, 350)
			carouselBezierPath2.FirstPoint = New Telerik.WinControls.UI.Point3D(9.9371069182389942, 21.471172962226639, 0)
			carouselBezierPath2.LastPoint = New Telerik.WinControls.UI.Point3D(90.691823899371073, 20.278330019880716, 0)
			carouselBezierPath2.ZScale = 250
			Me.radCarousel1.CarouselPath = carouselBezierPath2
			Me.radCarousel1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radButtonElement1, Me.radButtonElement2, Me.radButtonElement3})
			Me.radCarousel1.Location = New System.Drawing.Point(4, 5)
			Me.radCarousel1.Name = "radCarousel1"
			Me.radCarousel1.NavigationButtonsOffset = New System.Drawing.Size(70, 70)
			Me.radCarousel1.SelectedIndex = 0
			Me.radCarousel1.Size = New System.Drawing.Size(795, 503)
			Me.radCarousel1.TabIndex = 0
			Me.radCarousel1.Text = "radCarousel1"
			Me.radCarousel1.ThemeName = "ImageGallery"
			Me.radCarousel1.VisibleItemCount = 7
'			Me.radCarousel1.NewCarouselItemCreating += New Telerik.WinControls.UI.NewCarouselItemCreatingEventHandler(Me.radCarousel1_NewCarouselItemCreating);
'			Me.radCarousel1.SelectedIndexChanged += New System.EventHandler(Me.radCarousel1_SelectedIndexChanged);
'			Me.radCarousel1.ItemDataBound += New Telerik.WinControls.UI.ItemDataBoundEventHandler(Me.radCarousel1_ItemDataBound);
			CType(Me.radCarousel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(85))))), (CInt(Fix((CByte(104))))))
			CType(Me.radCarousel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(33))))), (CInt(Fix((CByte(41))))))
			CType(Me.radCarousel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor4 = System.Drawing.Color.Black
			CType(Me.radCarousel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).NumberOfColors = 4
			CType(Me.radCarousel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientPercentage = 0.2F
			CType(Me.radCarousel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(147))))), (CInt(Fix((CByte(180))))))
			CType(Me.radCarousel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(103))))), (CInt(Fix((CByte(142))))))
			CType(Me.radCarousel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor3 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(115))))), (CInt(Fix((CByte(159))))))
			CType(Me.radCarousel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor4 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(143))))), (CInt(Fix((CByte(176))))))
			CType(Me.radCarousel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(16))))), (CInt(Fix((CByte(20))))))
			' 
			' radButtonElement1
			' 
			Me.radButtonElement1.AccessibleDescription = "radButtonElement1"
			Me.radButtonElement1.AccessibleName = "radButtonElement1"
			Me.radButtonElement1.CanFocus = True
			Me.radButtonElement1.Name = "radButtonElement1"
			Me.radButtonElement1.ShowBorder = False
			Me.radButtonElement1.Text = "radButtonElement1"
			Me.radButtonElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement2
			' 
			Me.radButtonElement2.AccessibleDescription = "radButtonElement2"
			Me.radButtonElement2.AccessibleName = "radButtonElement2"
			Me.radButtonElement2.CanFocus = True
			Me.radButtonElement2.Name = "radButtonElement2"
			Me.radButtonElement2.ShowBorder = False
			Me.radButtonElement2.Text = "radButtonElement2"
			Me.radButtonElement2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement3
			' 
			Me.radButtonElement3.AccessibleDescription = "radButtonElement3"
			Me.radButtonElement3.AccessibleName = "radButtonElement3"
			Me.radButtonElement3.CanFocus = True
			Me.radButtonElement3.Name = "radButtonElement3"
			Me.radButtonElement3.ShowBorder = False
			Me.radButtonElement3.Text = "radButtonElement3"
			Me.radButtonElement3.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radThemeManager1
			' 
			themeSource6.StorageType = Telerik.WinControls.ThemeStorageType.Resource
			themeSource6.ThemeLocation = "CarouselImageGallery.CarouselImageGallery.xml"
			Me.radThemeManager1.LoadedThemes.AddRange(New Telerik.WinControls.ThemeSource() { themeSource6})
			' 
			' GalleryView
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(803, 512)
			Me.Controls.Add(Me.radCarousel1)
			Me.Name = "GalleryView"
			' 
			' 
			' 
			Me.RootElement.ApplyShapeToControl = True
			Me.Text = "GalleryView"
			Me.ThemeName = "Office2010Black"
'			Me.Load += New System.EventHandler(Me.GalleryView_Load);
'			Me.Shown += New System.EventHandler(Me.GalleryView_Shown);
			CType(Me.radCarousel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents radCarousel1 As Telerik.WinControls.UI.RadCarousel
		Private radButtonElement1 As Telerik.WinControls.UI.RadButtonElement
		Private radButtonElement2 As Telerik.WinControls.UI.RadButtonElement
		Private radThemeManager1 As Telerik.WinControls.RadThemeManager
		Private radButtonElement3 As Telerik.WinControls.UI.RadButtonElement
		Private office2010BlackTheme1 As Telerik.WinControls.Themes.Office2010BlackTheme

	End Class
End Namespace