namespace AppPortfolio
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Telerik.WinControls.UI.CarouselEllipsePath carouselEllipsePath1 = new Telerik.WinControls.UI.CarouselEllipsePath();
            this.radTitleBar1 = new Telerik.WinControls.UI.RadTitleBar();
            this.desertTheme1 = new Telerik.WinControls.Themes.DesertTheme();
            this.radCarousel1 = new Telerik.WinControls.UI.RadCarousel();
            this.startHelpDeskButton = new AppPortfolio.PortfolioButtonElement();
            this.portfolioButtonElement3 = new AppPortfolio.PortfolioButtonElement();
            this.portfolioButtonElement1 = new AppPortfolio.PortfolioButtonElement();
            this.portfolioButtonElement4 = new AppPortfolio.PortfolioButtonElement();
            this.portfolioButtonElement6 = new AppPortfolio.PortfolioButtonElement();
            this.portfolioButtonElement8 = new AppPortfolio.PortfolioButtonElement();
            this.portfolioButtonElement2 = new AppPortfolio.PortfolioButtonElement();
            this.portfolioButtonElement7 = new AppPortfolio.PortfolioButtonElement();
            this.portfolioButtonElement5 = new AppPortfolio.PortfolioButtonElement();
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCarousel1)).BeginInit();
            this.SuspendLayout();
            // 
            // radTitleBar1
            // 
            this.radTitleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radTitleBar1.Location = new System.Drawing.Point(0, 0);
            this.radTitleBar1.Name = "radTitleBar1";
            this.radTitleBar1.Size = new System.Drawing.Size(1016, 25);
            this.radTitleBar1.TabIndex = 1;
            this.radTitleBar1.TabStop = false;
            this.radTitleBar1.Text = "Telerik UI for WinForms Portfolio";
            this.radTitleBar1.ThemeName = "Office2007Black";
            // 
            // radCarousel1
            // 
            this.radCarousel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radCarousel1.AnimationDelay = global::AppPortfolio.Properties.Settings.Default.CarouselAnimationDelay;
            this.radCarousel1.AnimationFrames = global::AppPortfolio.Properties.Settings.Default.CarouselAnimationFrames;
            this.radCarousel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radCarousel1.BackgroundImage")));
            this.radCarousel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            // 
            // 
            // 
            this.radCarousel1.CarouselElement.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
            carouselEllipsePath1.Center = new Telerik.WinControls.UI.Point3D(52.357071213640921D, 38.435374149659864D, -10D);
            carouselEllipsePath1.FinalAngle = 360D;
            carouselEllipsePath1.InitialAngle = 0D;
            carouselEllipsePath1.U = new Telerik.WinControls.UI.Point3D(-7.9237713139418258D, -19.217687074829932D, -60D);
            carouselEllipsePath1.V = new Telerik.WinControls.UI.Point3D(28.986960882647942D, -14.795918367346939D, -10D);
            carouselEllipsePath1.ZScale = 400D;
            this.radCarousel1.CarouselPath = carouselEllipsePath1;
            this.radCarousel1.EnableAutoLoop = true;
            this.radCarousel1.ItemReflectionPercentage = 0D;
            this.radCarousel1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.startHelpDeskButton,
            this.portfolioButtonElement3,
            this.portfolioButtonElement1,
            this.portfolioButtonElement4,
            this.portfolioButtonElement6,
            this.portfolioButtonElement8,
            this.portfolioButtonElement2,
            this.portfolioButtonElement7 });
            this.radCarousel1.Location = new System.Drawing.Point(3, 38);
            this.radCarousel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radCarousel1.MinFadeOpacity = 0.8D;
            this.radCarousel1.Name = "radCarousel1";
            this.radCarousel1.NavigationButtonsOffset = new System.Drawing.Size(425, 60);
            this.radCarousel1.OpacityChangeCondition = Telerik.WinControls.UI.OpacityChangeConditions.None;
            this.radCarousel1.Size = new System.Drawing.Size(1009, 594);
            this.radCarousel1.TabIndex = 0;
            this.radCarousel1.Text = "radCarousel1";
            this.radCarousel1.ThemeName = "No theme";
            this.radCarousel1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.radCarousel1_KeyDown);
            ((Telerik.WinControls.UI.RadCarouselElement)(this.radCarousel1.GetChildAt(0))).Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radCarousel1.GetChildAt(0).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radCarousel1.GetChildAt(0).GetChildAt(1))).BoxStyle = Telerik.WinControls.BorderBoxStyle.OuterInnerBorders;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radCarousel1.GetChildAt(0).GetChildAt(1))).ForeColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radCarousel1.GetChildAt(0).GetChildAt(1))).ForeColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radCarousel1.GetChildAt(0).GetChildAt(1))).ForeColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radCarousel1.GetChildAt(0).GetChildAt(1))).InnerColor = System.Drawing.Color.Black;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radCarousel1.GetChildAt(0).GetChildAt(1))).InnerColor2 = System.Drawing.Color.Black;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radCarousel1.GetChildAt(0).GetChildAt(1))).InnerColor3 = System.Drawing.Color.Black;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radCarousel1.GetChildAt(0).GetChildAt(1))).InnerColor4 = System.Drawing.Color.Black;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radCarousel1.GetChildAt(0).GetChildAt(1))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radCarousel1.GetChildAt(0).GetChildAt(1))).ZIndex = 10;
            ((Telerik.WinControls.UI.RadRepeatButtonElement)(this.radCarousel1.GetChildAt(0).GetChildAt(3))).Image = global::AppPortfolio.Properties.Resources.LeftArrowNormal;
            ((Telerik.WinControls.UI.RadRepeatButtonElement)(this.radCarousel1.GetChildAt(0).GetChildAt(4))).Image = global::AppPortfolio.Properties.Resources.RightArrowNormal;
            // 
            // startHelpDeskButton
            // 
            this.startHelpDeskButton.AccessibleDescription = "Telerik Help Desk";
            this.startHelpDeskButton.AccessibleName = "Telerik Help Desk";
            this.startHelpDeskButton.CanFocus = true;
            this.startHelpDeskButton.DataBindings.Add(new System.Windows.Forms.Binding("ProductImageLocation", global::AppPortfolio.Properties.Settings.Default, "HelpdeskImageLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.startHelpDeskButton.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.startHelpDeskButton.Image = ((System.Drawing.Image)(resources.GetObject("startHelpDeskButton.Image")));
            this.startHelpDeskButton.Name = "startHelpDeskButton";
            this.startHelpDeskButton.NavigateToURL = global::AppPortfolio.Properties.Settings.Default.HelpDeskPath;
            this.startHelpDeskButton.ProductDescription = global::AppPortfolio.Properties.Settings.Default.HelpDeskDescription;
            this.startHelpDeskButton.ProductImageLocation = global::AppPortfolio.Properties.Settings.Default.HelpDeskImageLocation;
            this.startHelpDeskButton.ProductTitle = global::AppPortfolio.Properties.Settings.Default.HelpDeskTitle;
            this.startHelpDeskButton.ShowBorder = false;
            this.startHelpDeskButton.Text = global::AppPortfolio.Properties.Settings.Default.HelpDeskTitle;
            this.startHelpDeskButton.ToolTipText = global::AppPortfolio.Properties.Settings.Default.HelpDeskTitle;
            // 
            // portfolioButtonElement3
            // 
            this.portfolioButtonElement3.AccessibleDescription = "Bookstore Kiosk Demo";
            this.portfolioButtonElement3.AccessibleName = "Bookstore Kiosk Demo";
            this.portfolioButtonElement3.CanFocus = true;
            this.portfolioButtonElement3.DataBindings.Add(new System.Windows.Forms.Binding("ProductImageLocation", global::AppPortfolio.Properties.Settings.Default, "BookKioskImageLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.portfolioButtonElement3.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.portfolioButtonElement3.Image = ((System.Drawing.Image)(resources.GetObject("portfolioButtonElement3.Image")));
            this.portfolioButtonElement3.Name = "portfolioButtonElement3";
            this.portfolioButtonElement3.NavigateToURL = global::AppPortfolio.Properties.Settings.Default.BookstorePath;
            this.portfolioButtonElement3.ProductDescription = global::AppPortfolio.Properties.Settings.Default.BookstoreKioskDescription;
            this.portfolioButtonElement3.ProductImageLocation = global::AppPortfolio.Properties.Settings.Default.BookKioskImageLocation;
            this.portfolioButtonElement3.ProductTitle = global::AppPortfolio.Properties.Settings.Default.BookstoreKioskTitle;
            this.portfolioButtonElement3.ShowBorder = false;
            this.portfolioButtonElement3.Text = global::AppPortfolio.Properties.Settings.Default.BookstoreKioskTitle;
            this.portfolioButtonElement3.ToolTipText = global::AppPortfolio.Properties.Settings.Default.BookstoreKioskTitle;
            // 
            // portfolioButtonElement1
            // 
            this.portfolioButtonElement1.AccessibleDescription = "Telerik Checkers";
            this.portfolioButtonElement1.AccessibleName = "Telerik Checkers";
            this.portfolioButtonElement1.CanFocus = true;
            this.portfolioButtonElement1.DataBindings.Add(new System.Windows.Forms.Binding("ProductDescription", global::AppPortfolio.Properties.Settings.Default, "CheckersDescription", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.portfolioButtonElement1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AppPortfolio.Properties.Settings.Default, "CheckersText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.portfolioButtonElement1.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.portfolioButtonElement1.Image = ((System.Drawing.Image)(resources.GetObject("portfolioButtonElement1.Image")));
            this.portfolioButtonElement1.Name = "portfolioButtonElement1";
            this.portfolioButtonElement1.NavigateToURL = global::AppPortfolio.Properties.Settings.Default.CheckersPath;
            this.portfolioButtonElement1.ProductDescription = global::AppPortfolio.Properties.Settings.Default.CheckersDescription;
            this.portfolioButtonElement1.ProductImageLocation = global::AppPortfolio.Properties.Settings.Default.CheckersImage;
            this.portfolioButtonElement1.ProductTitle = global::AppPortfolio.Properties.Settings.Default.CheckersTitle;
            this.portfolioButtonElement1.ShowBorder = false;
            this.portfolioButtonElement1.Text = global::AppPortfolio.Properties.Settings.Default.CheckersText;
            this.portfolioButtonElement1.ToolTipText = global::AppPortfolio.Properties.Settings.Default.CheckersText;
            // 
            // portfolioButtonElement4
            // 
            this.portfolioButtonElement4.AccessibleDescription = "Sales Dashboard";
            this.portfolioButtonElement4.AccessibleName = "Sales Dashboard";
            this.portfolioButtonElement4.CanFocus = true;
            this.portfolioButtonElement4.DataBindings.Add(new System.Windows.Forms.Binding("ProductImageLocation", global::AppPortfolio.Properties.Settings.Default, "SalesDashboardImageLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.portfolioButtonElement4.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.portfolioButtonElement4.Image = ((System.Drawing.Image)(resources.GetObject("portfolioButtonElement4.Image")));
            this.portfolioButtonElement4.Name = "portfolioButtonElement4";
            this.portfolioButtonElement4.NavigateToURL = global::AppPortfolio.Properties.Settings.Default.SalesDashboardPath;
            this.portfolioButtonElement4.ProductDescription = global::AppPortfolio.Properties.Settings.Default.SalesDashBoardDescription;
            this.portfolioButtonElement4.ProductImageLocation = global::AppPortfolio.Properties.Settings.Default.SalesDashboardImageLocation;
            this.portfolioButtonElement4.ProductTitle = global::AppPortfolio.Properties.Settings.Default.SalesDashboardTitle;
            this.portfolioButtonElement4.ShowBorder = false;
            this.portfolioButtonElement4.Text = global::AppPortfolio.Properties.Settings.Default.SalesDashboardTitle;
            this.portfolioButtonElement4.ToolTipText = global::AppPortfolio.Properties.Settings.Default.SalesDashboardTitle;
            // 
            // portfolioButtonElement6
            // 
            this.portfolioButtonElement6.AccessibleDescription = "Photo Gallery Example";
            this.portfolioButtonElement6.AccessibleName = "Photo Gallery Example";
            this.portfolioButtonElement6.CanFocus = true;
            this.portfolioButtonElement6.DataBindings.Add(new System.Windows.Forms.Binding("ProductImageLocation", global::AppPortfolio.Properties.Settings.Default, "PhotoAlbumImageLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.portfolioButtonElement6.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.portfolioButtonElement6.Image = ((System.Drawing.Image)(resources.GetObject("portfolioButtonElement6.Image")));
            this.portfolioButtonElement6.Name = "portfolioButtonElement6";
            this.portfolioButtonElement6.NavigateToURL = global::AppPortfolio.Properties.Settings.Default.PhotoAlbumPath;
            this.portfolioButtonElement6.ProductDescription = global::AppPortfolio.Properties.Settings.Default.PhotoAlbumDescription;
            this.portfolioButtonElement6.ProductImageLocation = global::AppPortfolio.Properties.Settings.Default.PhotoAlbumImageLocation;
            this.portfolioButtonElement6.ProductTitle = global::AppPortfolio.Properties.Settings.Default.PhotoAlbumTitle;
            this.portfolioButtonElement6.ShowBorder = false;
            this.portfolioButtonElement6.Text = global::AppPortfolio.Properties.Settings.Default.PhotoAlbumTitle;
            this.portfolioButtonElement6.ToolTipText = global::AppPortfolio.Properties.Settings.Default.PhotoAlbumTitle;
            // 
            // portfolioButtonElement8
            // 
            this.portfolioButtonElement8.AccessibleDescription = "FileExplorer Demo Application";
            this.portfolioButtonElement8.AccessibleName = "FileExplorer Demo Application";
            this.portfolioButtonElement8.CanFocus = true;
            this.portfolioButtonElement8.DataBindings.Add(new System.Windows.Forms.Binding("ProductImageLocation", global::AppPortfolio.Properties.Settings.Default, "FileExplorerImage", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.portfolioButtonElement8.DataBindings.Add(new System.Windows.Forms.Binding("ProductTitle", global::AppPortfolio.Properties.Settings.Default, "FileExplorerTitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.portfolioButtonElement8.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AppPortfolio.Properties.Settings.Default, "FileExplorerText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.portfolioButtonElement8.DataBindings.Add(new System.Windows.Forms.Binding("ToolTipText", global::AppPortfolio.Properties.Settings.Default, "FileExplorerText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.portfolioButtonElement8.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.portfolioButtonElement8.Image = ((System.Drawing.Image)(resources.GetObject("portfolioButtonElement8.Image")));
            this.portfolioButtonElement8.Name = "portfolioButtonElement8";
            this.portfolioButtonElement8.NavigateToURL = global::AppPortfolio.Properties.Settings.Default.FileExplorerPath;
            this.portfolioButtonElement8.ProductDescription = global::AppPortfolio.Properties.Settings.Default.FileExplorerDescription;
            this.portfolioButtonElement8.ProductImageLocation = global::AppPortfolio.Properties.Settings.Default.FileExplorerImage;
            this.portfolioButtonElement8.ProductTitle = global::AppPortfolio.Properties.Settings.Default.FileExplorerTitle;
            this.portfolioButtonElement8.ShowBorder = false;
            this.portfolioButtonElement8.Text = global::AppPortfolio.Properties.Settings.Default.FileExplorerText;
            this.portfolioButtonElement8.ToolTipText = global::AppPortfolio.Properties.Settings.Default.FileExplorerText;
            // 
            // portfolioButtonElement2
            // 
            this.portfolioButtonElement2.AccessibleDescription = "Quick Start Framework";
            this.portfolioButtonElement2.AccessibleName = "Quick Start Framework";
            this.portfolioButtonElement2.CanFocus = true;
            this.portfolioButtonElement2.DataBindings.Add(new System.Windows.Forms.Binding("ProductImageLocation", global::AppPortfolio.Properties.Settings.Default, "QSFImageLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.portfolioButtonElement2.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.portfolioButtonElement2.Image = ((System.Drawing.Image)(resources.GetObject("portfolioButtonElement2.Image")));
            this.portfolioButtonElement2.Name = "portfolioButtonElement2";
            this.portfolioButtonElement2.NavigateToURL = global::AppPortfolio.Properties.Settings.Default.QSFPath;
            this.portfolioButtonElement2.ProductDescription = global::AppPortfolio.Properties.Settings.Default.QSFDescription;
            this.portfolioButtonElement2.ProductImageLocation = global::AppPortfolio.Properties.Settings.Default.QSFImageLocation;
            this.portfolioButtonElement2.ProductTitle = global::AppPortfolio.Properties.Settings.Default.QSFTitle;
            this.portfolioButtonElement2.ShowBorder = false;
            this.portfolioButtonElement2.Text = global::AppPortfolio.Properties.Settings.Default.QSFTitle;
            this.portfolioButtonElement2.ToolTipText = global::AppPortfolio.Properties.Settings.Default.QSFTitle;
            // 
            // portfolioButtonElement7
            // 
            this.portfolioButtonElement7.AccessibleDescription = "BugTracker Demo Application";
            this.portfolioButtonElement7.AccessibleName = "BugTracker Demo Application";
            this.portfolioButtonElement7.CanFocus = true;
            this.portfolioButtonElement7.DataBindings.Add(new System.Windows.Forms.Binding("ProductImageLocation", global::AppPortfolio.Properties.Settings.Default, "BugTrackerImageLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.portfolioButtonElement7.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.portfolioButtonElement7.Image = ((System.Drawing.Image)(resources.GetObject("portfolioButtonElement7.Image")));
            this.portfolioButtonElement7.Name = "portfolioButtonElement7";
            this.portfolioButtonElement7.NavigateToURL = global::AppPortfolio.Properties.Settings.Default.BugTrackerPath;
            this.portfolioButtonElement7.ProductDescription = global::AppPortfolio.Properties.Settings.Default.BugTrackerDescription;
            this.portfolioButtonElement7.ProductImageLocation = global::AppPortfolio.Properties.Settings.Default.BugTrackerImageLocation;
            this.portfolioButtonElement7.ProductTitle = global::AppPortfolio.Properties.Settings.Default.BugTrackerTitle;
            this.portfolioButtonElement7.ShowBorder = false;
            this.portfolioButtonElement7.Text = global::AppPortfolio.Properties.Settings.Default.BugTrackerTitle;
            this.portfolioButtonElement7.ToolTipText = global::AppPortfolio.Properties.Settings.Default.BugTrackerTitle;
            // 
            // portfolioButtonElement5
            // 
            this.portfolioButtonElement5.AccessibleDescription = "Telerik Movie Lab";
            this.portfolioButtonElement5.AccessibleName = "Telerik Movie Lab";
            this.portfolioButtonElement5.CanFocus = true;
            this.portfolioButtonElement5.DataBindings.Add(new System.Windows.Forms.Binding("ProductImageLocation", global::AppPortfolio.Properties.Settings.Default, "MovieLabImageLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.portfolioButtonElement5.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.portfolioButtonElement5.Image = ((System.Drawing.Image)(resources.GetObject("portfolioButtonElement5.Image")));
            this.portfolioButtonElement5.Name = "portfolioButtonElement5";
            this.portfolioButtonElement5.NavigateToURL = global::AppPortfolio.Properties.Settings.Default.MovieLabPath;
            this.portfolioButtonElement5.ProductDescription = global::AppPortfolio.Properties.Settings.Default.MovieLabDescription;
            this.portfolioButtonElement5.ProductImageLocation = global::AppPortfolio.Properties.Settings.Default.MovieLabImageLocation;
            this.portfolioButtonElement5.ProductTitle = global::AppPortfolio.Properties.Settings.Default.MovieLabTitle;
            this.portfolioButtonElement5.ShowBorder = false;
            this.portfolioButtonElement5.Text = global::AppPortfolio.Properties.Settings.Default.MovieLabTitle;
            this.portfolioButtonElement5.ToolTipText = global::AppPortfolio.Properties.Settings.Default.MovieLabTitle;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(1016, 635);
            this.Controls.Add(this.radCarousel1);
            this.Controls.Add(this.radTitleBar1);
            this.HelpButton = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telerik UI for WinForms Portfolio";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCarousel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadCarousel radCarousel1;
        private PortfolioButtonElement startHelpDeskButton;
        private PortfolioButtonElement portfolioButtonElement1;
        private PortfolioButtonElement portfolioButtonElement2;
        private PortfolioButtonElement portfolioButtonElement3;
        private PortfolioButtonElement portfolioButtonElement4;
        private PortfolioButtonElement portfolioButtonElement5;
        private PortfolioButtonElement portfolioButtonElement6;
        private PortfolioButtonElement portfolioButtonElement7;
        private PortfolioButtonElement portfolioButtonElement8;
        private Telerik.WinControls.Themes.DesertTheme desertTheme1;
        private Telerik.WinControls.UI.RadTitleBar radTitleBar1;
    }
}

