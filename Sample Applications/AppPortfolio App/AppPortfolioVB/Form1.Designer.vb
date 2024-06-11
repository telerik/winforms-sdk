Imports Microsoft.VisualBasic
Imports System
Namespace AppPortfolioVB
    Partial Public Class Form1
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Dim carouselEllipsePath1 As Telerik.WinControls.UI.CarouselEllipsePath = New Telerik.WinControls.UI.CarouselEllipsePath()
            Me.radTitleBar1 = New Telerik.WinControls.UI.RadTitleBar()
            Me.desertTheme1 = New Telerik.WinControls.Themes.DesertTheme()
            Me.radCarousel1 = New Telerik.WinControls.UI.RadCarousel()
            Me.startHelpDeskButton = New AppPortfolioVB.PortfolioButtonElement()
            Me.portfolioButtonElement3 = New AppPortfolioVB.PortfolioButtonElement()
            Me.portfolioButtonElement1 = New AppPortfolioVB.PortfolioButtonElement()
            Me.portfolioButtonElement4 = New AppPortfolioVB.PortfolioButtonElement()
            Me.portfolioButtonElement6 = New AppPortfolioVB.PortfolioButtonElement()
            Me.portfolioButtonElement8 = New AppPortfolioVB.PortfolioButtonElement()
            Me.portfolioButtonElement2 = New AppPortfolioVB.PortfolioButtonElement()
            Me.portfolioButtonElement7 = New AppPortfolioVB.PortfolioButtonElement()
            Me.portfolioButtonElement5 = New AppPortfolioVB.PortfolioButtonElement()
            CType(Me.radTitleBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radCarousel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' radTitleBar1
            ' 
            Me.radTitleBar1.Text = "Telerik UI for WinForms Portfolio"
            Me.radTitleBar1.Dock = System.Windows.Forms.DockStyle.Top
            Me.radTitleBar1.Location = New System.Drawing.Point(0, 0)
            Me.radTitleBar1.Name = "radTitleBar1"
            Me.radTitleBar1.Size = New System.Drawing.Size(1016, 25)
            Me.radTitleBar1.TabIndex = 1
            Me.radTitleBar1.TabStop = False
            Me.radTitleBar1.Text = "Telerik UI for WinForms Portfolio"
            Me.radTitleBar1.ThemeName = "Office2007Black"
            ' 
            ' radCarousel1
            ' 
            Me.radCarousel1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.radCarousel1.AnimationDelay = My.Settings.Default.CarouselAnimationDelay
            Me.radCarousel1.AnimationFrames = My.Settings.Default.CarouselAnimationFrames
            Me.radCarousel1.BackgroundImage = (CType(resources.GetObject("radCarousel1.BackgroundImage"), System.Drawing.Image))
            Me.radCarousel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            ' 
            ' 
            ' 
            Me.radCarousel1.CarouselElement.Margin = New System.Windows.Forms.Padding(0, 0, 1, 1)
            carouselEllipsePath1.Center = New Telerik.WinControls.UI.Point3D(52.357071213640921R, 38.435374149659864R, -10.0R)
            carouselEllipsePath1.FinalAngle = 360.0R
            carouselEllipsePath1.InitialAngle = 0.0R
            carouselEllipsePath1.U = New Telerik.WinControls.UI.Point3D(-7.9237713139418258R, -19.217687074829932R, -60.0R)
            carouselEllipsePath1.V = New Telerik.WinControls.UI.Point3D(28.986960882647942R, -14.795918367346939R, -10.0R)
            carouselEllipsePath1.ZScale = 400.0R
            Me.radCarousel1.CarouselPath = carouselEllipsePath1
            Me.radCarousel1.EnableAutoLoop = True
            Me.radCarousel1.ItemReflectionPercentage = 0.0R
            Me.radCarousel1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.startHelpDeskButton, Me.portfolioButtonElement3, Me.portfolioButtonElement1, Me.portfolioButtonElement4, Me.portfolioButtonElement6, Me.portfolioButtonElement8, Me.portfolioButtonElement2, Me.portfolioButtonElement7})
            Me.radCarousel1.Location = New System.Drawing.Point(3, 38)
            Me.radCarousel1.MinFadeOpacity = 0.8R
            Me.radCarousel1.Name = "radCarousel1"
            Me.radCarousel1.Dock = Windows.Forms.DockStyle.Fill
            Me.radCarousel1.NavigationButtonsOffset = New System.Drawing.Size(425, 60)
            Me.radCarousel1.OpacityChangeCondition = Telerik.WinControls.UI.OpacityChangeConditions.None
            Me.radCarousel1.SelectedIndex = 0
            Me.radCarousel1.Size = New System.Drawing.Size(1009, 594)
            Me.radCarousel1.TabIndex = 0
            Me.radCarousel1.Text = "radCarousel1"
            Me.radCarousel1.ThemeName = "No theme"
            '			Me.radCarousel1.KeyDown += New System.Windows.Forms.KeyEventHandler(Me.radCarousel1_KeyDown);
            CType(Me.radCarousel1.GetChildAt(0), Telerik.WinControls.UI.RadCarouselElement).Margin = New System.Windows.Forms.Padding(0, 0, 1, 1)
            CType(Me.radCarousel1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
            CType(Me.radCarousel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.OuterInnerBorders
            CType(Me.radCarousel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(66))))), (CInt(Fix((CByte(66))))), (CInt(Fix((CByte(66))))))
            CType(Me.radCarousel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor3 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(66))))), (CInt(Fix((CByte(66))))), (CInt(Fix((CByte(66))))))
            CType(Me.radCarousel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor4 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(81))))), (CInt(Fix((CByte(55))))), (CInt(Fix((CByte(55))))))
            CType(Me.radCarousel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).InnerColor = System.Drawing.Color.Black
            CType(Me.radCarousel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).InnerColor2 = System.Drawing.Color.Black
            CType(Me.radCarousel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).InnerColor3 = System.Drawing.Color.Black
            CType(Me.radCarousel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).InnerColor4 = System.Drawing.Color.Black
            CType(Me.radCarousel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(81))))), (CInt(Fix((CByte(55))))), (CInt(Fix((CByte(55))))))
            CType(Me.radCarousel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ZIndex = 10
            CType(Me.radCarousel1.GetChildAt(0).GetChildAt(3), Telerik.WinControls.UI.RadRepeatButtonElement).Image = Global.Resources.LeftArrowNormal
            CType(Me.radCarousel1.GetChildAt(0).GetChildAt(4), Telerik.WinControls.UI.RadRepeatButtonElement).Image = Global.Resources.RightArrowNormal
            ' 
            ' startHelpDeskButton
            ' 
            Me.startHelpDeskButton.AccessibleDescription = "Telerik Help Desk"
            Me.startHelpDeskButton.AccessibleName = "Telerik Help Desk"
            Me.startHelpDeskButton.CanFocus = True
            Me.startHelpDeskButton.DataBindings.Add(New System.Windows.Forms.Binding("ProductImageLocation", My.Settings.Default, "HelpdeskImageLocation", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.startHelpDeskButton.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
            Me.startHelpDeskButton.Image = (CType(resources.GetObject("startHelpDeskButton.Image"), System.Drawing.Image))
            Me.startHelpDeskButton.Name = "startHelpDeskButton"
            Me.startHelpDeskButton.NavigateToURL = My.Settings.Default.HelpDeskPath
            Me.startHelpDeskButton.ProductDescription = My.Settings.Default.HelpDeskDescription
            Me.startHelpDeskButton.ProductImageLocation = My.Settings.Default.HelpDeskImageLocation
            Me.startHelpDeskButton.ProductTitle = My.Settings.Default.HelpDeskTitle
            Me.startHelpDeskButton.ShowBorder = False
            Me.startHelpDeskButton.Text = My.Settings.Default.HelpDeskTitle
            Me.startHelpDeskButton.ToolTipText = My.Settings.Default.HelpDeskTitle
            Me.startHelpDeskButton.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' portfolioButtonElement3
            ' 
            Me.portfolioButtonElement3.AccessibleDescription = "Bookstore Kiosk Demo"
            Me.portfolioButtonElement3.AccessibleName = "Bookstore Kiosk Demo"
            Me.portfolioButtonElement3.CanFocus = True
            Me.portfolioButtonElement3.DataBindings.Add(New System.Windows.Forms.Binding("ProductImageLocation", My.Settings.Default, "BookKioskImageLocation", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.portfolioButtonElement3.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
            Me.portfolioButtonElement3.Image = (CType(resources.GetObject("portfolioButtonElement3.Image"), System.Drawing.Image))
            Me.portfolioButtonElement3.Name = "portfolioButtonElement3"
            Me.portfolioButtonElement3.NavigateToURL = My.Settings.Default.BookstorePath
            Me.portfolioButtonElement3.ProductDescription = My.Settings.Default.BookstoreKioskDescription
            Me.portfolioButtonElement3.ProductImageLocation = My.Settings.Default.BookKioskImageLocation
            Me.portfolioButtonElement3.ProductTitle = My.Settings.Default.BookstoreKioskTitle
            Me.portfolioButtonElement3.ShowBorder = False
            Me.portfolioButtonElement3.Text = My.Settings.Default.BookstoreKioskTitle
            Me.portfolioButtonElement3.ToolTipText = My.Settings.Default.BookstoreKioskTitle
            Me.portfolioButtonElement3.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' portfolioButtonElement1
            ' 
            Me.portfolioButtonElement1.AccessibleDescription = "Telerik Checkers"
            Me.portfolioButtonElement1.AccessibleName = "Telerik Checkers"
            Me.portfolioButtonElement1.CanFocus = True
            Me.portfolioButtonElement1.DataBindings.Add(New System.Windows.Forms.Binding("ProductDescription", My.Settings.Default, "CheckersDescription", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.portfolioButtonElement1.DataBindings.Add(New System.Windows.Forms.Binding("Text", My.Settings.Default, "CheckersText", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.portfolioButtonElement1.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
            Me.portfolioButtonElement1.Image = (CType(resources.GetObject("portfolioButtonElement1.Image"), System.Drawing.Image))
            Me.portfolioButtonElement1.Name = "portfolioButtonElement1"
            Me.portfolioButtonElement1.NavigateToURL = My.Settings.Default.CheckersPath
            Me.portfolioButtonElement1.ProductDescription = My.Settings.Default.CheckersDescription
            Me.portfolioButtonElement1.ProductImageLocation = My.Settings.Default.CheckersImage
            Me.portfolioButtonElement1.ProductTitle = My.Settings.Default.CheckersTitle
            Me.portfolioButtonElement1.ShowBorder = False
            Me.portfolioButtonElement1.Text = My.Settings.Default.CheckersText
            Me.portfolioButtonElement1.ToolTipText = My.Settings.Default.CheckersText
            Me.portfolioButtonElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' portfolioButtonElement4
            ' 
            Me.portfolioButtonElement4.AccessibleDescription = "Sales Dashboard"
            Me.portfolioButtonElement4.AccessibleName = "Sales Dashboard"
            Me.portfolioButtonElement4.CanFocus = True
            Me.portfolioButtonElement4.DataBindings.Add(New System.Windows.Forms.Binding("ProductImageLocation", My.Settings.Default, "SalesDashboardImageLocation", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.portfolioButtonElement4.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
            Me.portfolioButtonElement4.Image = (CType(resources.GetObject("portfolioButtonElement4.Image"), System.Drawing.Image))
            Me.portfolioButtonElement4.Name = "portfolioButtonElement4"
            Me.portfolioButtonElement4.NavigateToURL = My.Settings.Default.SalesDashboardPath
            Me.portfolioButtonElement4.ProductDescription = My.Settings.Default.SalesDashBoardDescription
            Me.portfolioButtonElement4.ProductImageLocation = My.Settings.Default.SalesDashboardImageLocation
            Me.portfolioButtonElement4.ProductTitle = My.Settings.Default.SalesDashboardTitle
            Me.portfolioButtonElement4.ShowBorder = False
            Me.portfolioButtonElement4.Text = My.Settings.Default.SalesDashboardTitle
            Me.portfolioButtonElement4.ToolTipText = My.Settings.Default.SalesDashboardTitle
            Me.portfolioButtonElement4.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' portfolioButtonElement6
            ' 
            Me.portfolioButtonElement6.AccessibleDescription = "Photo Gallery Example"
            Me.portfolioButtonElement6.AccessibleName = "Photo Gallery Example"
            Me.portfolioButtonElement6.CanFocus = True
            Me.portfolioButtonElement6.DataBindings.Add(New System.Windows.Forms.Binding("ProductImageLocation", My.Settings.Default, "PhotoAlbumImageLocation", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.portfolioButtonElement6.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
            Me.portfolioButtonElement6.Image = (CType(resources.GetObject("portfolioButtonElement6.Image"), System.Drawing.Image))
            Me.portfolioButtonElement6.Name = "portfolioButtonElement6"
            Me.portfolioButtonElement6.NavigateToURL = My.Settings.Default.PhotoAlbumPath
            Me.portfolioButtonElement6.ProductDescription = My.Settings.Default.PhotoAlbumDescription
            Me.portfolioButtonElement6.ProductImageLocation = My.Settings.Default.PhotoAlbumImageLocation
            Me.portfolioButtonElement6.ProductTitle = My.Settings.Default.PhotoAlbumTitle
            Me.portfolioButtonElement6.ShowBorder = False
            Me.portfolioButtonElement6.Text = My.Settings.Default.PhotoAlbumTitle
            Me.portfolioButtonElement6.ToolTipText = My.Settings.Default.PhotoAlbumTitle
            Me.portfolioButtonElement6.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' portfolioButtonElement8
            ' 
            Me.portfolioButtonElement8.AccessibleDescription = "FileExplorer Demo Application"
            Me.portfolioButtonElement8.AccessibleName = "FileExplorer Demo Application"
            Me.portfolioButtonElement8.CanFocus = True
            Me.portfolioButtonElement8.DataBindings.Add(New System.Windows.Forms.Binding("ProductImageLocation", My.Settings.Default, "FileExplorerImage", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.portfolioButtonElement8.DataBindings.Add(New System.Windows.Forms.Binding("ProductTitle", My.Settings.Default, "FileExplorerTitle", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.portfolioButtonElement8.DataBindings.Add(New System.Windows.Forms.Binding("Text", My.Settings.Default, "FileExplorerText", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.portfolioButtonElement8.DataBindings.Add(New System.Windows.Forms.Binding("ToolTipText", My.Settings.Default, "FileExplorerText", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.portfolioButtonElement8.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
            Me.portfolioButtonElement8.Image = (CType(resources.GetObject("portfolioButtonElement8.Image"), System.Drawing.Image))
            Me.portfolioButtonElement8.Name = "portfolioButtonElement8"
            Me.portfolioButtonElement8.NavigateToURL = My.Settings.Default.FileExplorerPath
            Me.portfolioButtonElement8.ProductDescription = My.Settings.Default.FileExplorerDescription
            Me.portfolioButtonElement8.ProductImageLocation = My.Settings.Default.FileExplorerImage
            Me.portfolioButtonElement8.ProductTitle = My.Settings.Default.FileExplorerTitle
            Me.portfolioButtonElement8.ShowBorder = False
            Me.portfolioButtonElement8.Text = My.Settings.Default.FileExplorerText
            Me.portfolioButtonElement8.ToolTipText = My.Settings.Default.FileExplorerText
            Me.portfolioButtonElement8.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' portfolioButtonElement2
            ' 
            Me.portfolioButtonElement2.AccessibleDescription = "Quick Start Framework"
            Me.portfolioButtonElement2.AccessibleName = "Quick Start Framework"
            Me.portfolioButtonElement2.CanFocus = True
            Me.portfolioButtonElement2.DataBindings.Add(New System.Windows.Forms.Binding("ProductImageLocation", My.Settings.Default, "QSFImageLocation", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.portfolioButtonElement2.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
            Me.portfolioButtonElement2.Image = (CType(resources.GetObject("portfolioButtonElement2.Image"), System.Drawing.Image))
            Me.portfolioButtonElement2.Name = "portfolioButtonElement2"
            Me.portfolioButtonElement2.NavigateToURL = My.Settings.Default.QSFPath
            Me.portfolioButtonElement2.ProductDescription = My.Settings.Default.QSFDescription
            Me.portfolioButtonElement2.ProductImageLocation = My.Settings.Default.QSFImageLocation
            Me.portfolioButtonElement2.ProductTitle = My.Settings.Default.QSFTitle
            Me.portfolioButtonElement2.ShowBorder = False
            Me.portfolioButtonElement2.Text = My.Settings.Default.QSFTitle
            Me.portfolioButtonElement2.ToolTipText = My.Settings.Default.QSFTitle
            Me.portfolioButtonElement2.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' portfolioButtonElement7
            ' 
            Me.portfolioButtonElement7.AccessibleDescription = "BugTracker Demo Application"
            Me.portfolioButtonElement7.AccessibleName = "BugTracker Demo Application"
            Me.portfolioButtonElement7.CanFocus = True
            Me.portfolioButtonElement7.DataBindings.Add(New System.Windows.Forms.Binding("ProductImageLocation", My.Settings.Default, "BugTrackerImageLocation", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.portfolioButtonElement7.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
            Me.portfolioButtonElement7.Image = (CType(resources.GetObject("portfolioButtonElement7.Image"), System.Drawing.Image))
            Me.portfolioButtonElement7.Name = "portfolioButtonElement7"
            Me.portfolioButtonElement7.NavigateToURL = My.Settings.Default.BugTrackerPath
            Me.portfolioButtonElement7.ProductDescription = My.Settings.Default.BugTrackerDescription
            Me.portfolioButtonElement7.ProductImageLocation = My.Settings.Default.BugTrackerImageLocation
            Me.portfolioButtonElement7.ProductTitle = My.Settings.Default.BugTrackerTitle
            Me.portfolioButtonElement7.ShowBorder = False
            Me.portfolioButtonElement7.Text = My.Settings.Default.BugTrackerTitle
            Me.portfolioButtonElement7.ToolTipText = My.Settings.Default.BugTrackerTitle
            Me.portfolioButtonElement7.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' portfolioButtonElement5
            ' 
            Me.portfolioButtonElement5.AccessibleDescription = "Telerik Movie Lab"
            Me.portfolioButtonElement5.AccessibleName = "Telerik Movie Lab"
            Me.portfolioButtonElement5.CanFocus = True
            Me.portfolioButtonElement5.DataBindings.Add(New System.Windows.Forms.Binding("ProductImageLocation", My.Settings.Default, "MovieLabImageLocation", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.portfolioButtonElement5.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
            Me.portfolioButtonElement5.Image = (CType(resources.GetObject("portfolioButtonElement5.Image"), System.Drawing.Image))
            Me.portfolioButtonElement5.Name = "portfolioButtonElement5"
            Me.portfolioButtonElement5.NavigateToURL = My.Settings.Default.MovieLabPath
            Me.portfolioButtonElement5.ProductDescription = My.Settings.Default.MovieLabDescription
            Me.portfolioButtonElement5.ProductImageLocation = My.Settings.Default.MovieLabImageLocation
            Me.portfolioButtonElement5.ProductTitle = My.Settings.Default.MovieLabTitle
            Me.portfolioButtonElement5.ShowBorder = False
            Me.portfolioButtonElement5.Text = My.Settings.Default.MovieLabTitle
            Me.portfolioButtonElement5.ToolTipText = My.Settings.Default.MovieLabTitle
            Me.portfolioButtonElement5.Visibility = Telerik.WinControls.ElementVisibility.Visible
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(46))))), (CInt(Fix((CByte(16))))), (CInt(Fix((CByte(16))))))
            Me.ClientSize = New System.Drawing.Size(1016, 635)
            Me.Controls.Add(Me.radCarousel1)
            Me.Controls.Add(Me.radTitleBar1)
            Me.HelpButton = True
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Telerik UI for WinForms Portfolio"
            CType(Me.radTitleBar1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radCarousel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private WithEvents radCarousel1 As Telerik.WinControls.UI.RadCarousel
        Private startHelpDeskButton As PortfolioButtonElement
        Private portfolioButtonElement1 As PortfolioButtonElement
        Private portfolioButtonElement2 As PortfolioButtonElement
        Private portfolioButtonElement3 As PortfolioButtonElement
        Private portfolioButtonElement4 As PortfolioButtonElement
        Private portfolioButtonElement5 As PortfolioButtonElement
        Private portfolioButtonElement6 As PortfolioButtonElement
        Private portfolioButtonElement7 As PortfolioButtonElement
        Private portfolioButtonElement8 As PortfolioButtonElement
        Private desertTheme1 As Telerik.WinControls.Themes.DesertTheme
        Private radTitleBar1 As Telerik.WinControls.UI.RadTitleBar
    End Class
End Namespace

