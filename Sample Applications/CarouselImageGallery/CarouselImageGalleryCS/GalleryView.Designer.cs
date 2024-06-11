namespace CarouselImageGallery
{
    partial class GalleryView
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
            Telerik.WinControls.UI.CarouselBezierPath carouselBezierPath2 = new Telerik.WinControls.UI.CarouselBezierPath();
            Telerik.WinControls.ThemeSource themeSource6 = new Telerik.WinControls.ThemeSource();
            this.radCarousel1 = new Telerik.WinControls.UI.RadCarousel();
            this.radButtonElement1 = new Telerik.WinControls.UI.RadButtonElement();
            this.radButtonElement2 = new Telerik.WinControls.UI.RadButtonElement();
            this.radButtonElement3 = new Telerik.WinControls.UI.RadButtonElement();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.office2010BlackTheme1 = new Telerik.WinControls.Themes.Office2010BlackTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radCarousel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radCarousel1
            // 
            this.radCarousel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.radCarousel1.AnimationDelay = 10;
            // 
            // 
            // 
            this.radCarousel1.CarouselElement.AnimationStarted += new System.EventHandler(this.radCarousel1_CarouselElement_AnimationStarted);
            this.radCarousel1.CarouselElement.AnimationFinished += new System.EventHandler(this.radCarousel1_CarouselElement_AnimationFinished);
            this.radCarousel1.CarouselElement.ItemLeaving += new Telerik.WinControls.UI.ItemLeavingEventHandler(this.radCarousel1_CarouselElement_ItemLeaving);
            this.radCarousel1.CarouselElement.ItemEntering += new Telerik.WinControls.UI.ItemEnteringEventHandler(this.radCarousel1_CarouselElement_ItemEntering);
            carouselBezierPath2.CtrlPoint1 = new Telerik.WinControls.UI.Point3D(20, 80, 350);
            carouselBezierPath2.CtrlPoint2 = new Telerik.WinControls.UI.Point3D(80, 80, 350);
            carouselBezierPath2.FirstPoint = new Telerik.WinControls.UI.Point3D(9.9371069182389942, 21.471172962226639, 0);
            carouselBezierPath2.LastPoint = new Telerik.WinControls.UI.Point3D(90.691823899371073, 20.278330019880716, 0);
            carouselBezierPath2.ZScale = 250;
            this.radCarousel1.CarouselPath = carouselBezierPath2;
            this.radCarousel1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement1,
            this.radButtonElement2,
            this.radButtonElement3});
            this.radCarousel1.Location = new System.Drawing.Point(4, 5);
            this.radCarousel1.Name = "radCarousel1";
            this.radCarousel1.NavigationButtonsOffset = new System.Drawing.Size(70, 70);
            this.radCarousel1.SelectedIndex = 0;
            this.radCarousel1.Size = new System.Drawing.Size(795, 503);
            this.radCarousel1.TabIndex = 0;
            this.radCarousel1.Text = "radCarousel1";
            this.radCarousel1.ThemeName = "ImageGallery";
            this.radCarousel1.VisibleItemCount = 7;
            this.radCarousel1.NewCarouselItemCreating += new Telerik.WinControls.UI.NewCarouselItemCreatingEventHandler(this.radCarousel1_NewCarouselItemCreating);
            this.radCarousel1.SelectedIndexChanged += new System.EventHandler(this.radCarousel1_SelectedIndexChanged);
            this.radCarousel1.ItemDataBound += new Telerik.WinControls.UI.ItemDataBoundEventHandler(this.radCarousel1_ItemDataBound);
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radCarousel1.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(104)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radCarousel1.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(41)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radCarousel1.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.Black;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radCarousel1.GetChildAt(0).GetChildAt(0))).NumberOfColors = 4;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radCarousel1.GetChildAt(0).GetChildAt(0))).GradientPercentage = 0.2F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radCarousel1.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(180)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radCarousel1.GetChildAt(0).GetChildAt(1))).ForeColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(142)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radCarousel1.GetChildAt(0).GetChildAt(1))).ForeColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(159)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radCarousel1.GetChildAt(0).GetChildAt(1))).ForeColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(176)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radCarousel1.GetChildAt(0).GetChildAt(1))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            // 
            // radButtonElement1
            // 
            this.radButtonElement1.AccessibleDescription = "radButtonElement1";
            this.radButtonElement1.AccessibleName = "radButtonElement1";
            this.radButtonElement1.CanFocus = true;
            this.radButtonElement1.Name = "radButtonElement1";
            this.radButtonElement1.ShowBorder = false;
            this.radButtonElement1.Text = "radButtonElement1";
            this.radButtonElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radButtonElement2
            // 
            this.radButtonElement2.AccessibleDescription = "radButtonElement2";
            this.radButtonElement2.AccessibleName = "radButtonElement2";
            this.radButtonElement2.CanFocus = true;
            this.radButtonElement2.Name = "radButtonElement2";
            this.radButtonElement2.ShowBorder = false;
            this.radButtonElement2.Text = "radButtonElement2";
            this.radButtonElement2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radButtonElement3
            // 
            this.radButtonElement3.AccessibleDescription = "radButtonElement3";
            this.radButtonElement3.AccessibleName = "radButtonElement3";
            this.radButtonElement3.CanFocus = true;
            this.radButtonElement3.Name = "radButtonElement3";
            this.radButtonElement3.ShowBorder = false;
            this.radButtonElement3.Text = "radButtonElement3";
            this.radButtonElement3.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radThemeManager1
            // 
            themeSource6.StorageType = Telerik.WinControls.ThemeStorageType.Resource;
            themeSource6.ThemeLocation = "CarouselImageGallery.CarouselImageGallery.xml";
            this.radThemeManager1.LoadedThemes.AddRange(new Telerik.WinControls.ThemeSource[] {
            themeSource6});
            // 
            // GalleryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 512);
            this.Controls.Add(this.radCarousel1);
            this.Name = "GalleryView";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "GalleryView";
            this.ThemeName = "Office2010Black";
            this.Load += new System.EventHandler(this.GalleryView_Load);
            this.Shown += new System.EventHandler(this.GalleryView_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.radCarousel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadCarousel radCarousel1;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement1;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement2;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement3;
        private Telerik.WinControls.Themes.Office2010BlackTheme office2010BlackTheme1;

    }
}