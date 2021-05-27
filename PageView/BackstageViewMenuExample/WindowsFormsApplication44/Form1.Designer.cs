namespace WindowsFormsApplication44
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
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.expandCollapseItem = new Telerik.WinControls.UI.RadPageViewPage();
            this.searchPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.moviesPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.tvPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.videosPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.separatorPage = new Telerik.WinControls.UI.RadPageViewItemPage();
            this.radPageViewPage1 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radPageViewPage2 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            this.radPageView1.SuspendLayout();
            this.searchPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.moviesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            this.tvPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            this.videosPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            this.radPageViewPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            this.radPageViewPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            this.SuspendLayout();
            // 
            // radPageView1
            // 
            this.radPageView1.Controls.Add(this.expandCollapseItem);
            this.radPageView1.Controls.Add(this.searchPage);
            this.radPageView1.Controls.Add(this.moviesPage);
            this.radPageView1.Controls.Add(this.tvPage);
            this.radPageView1.Controls.Add(this.videosPage);
            this.radPageView1.Controls.Add(this.separatorPage);
            this.radPageView1.Controls.Add(this.radPageViewPage1);
            this.radPageView1.Controls.Add(this.radPageViewPage2);
            this.radPageView1.Location = new System.Drawing.Point(26, 27);
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.SelectedPage = this.searchPage;
            this.radPageView1.Size = new System.Drawing.Size(715, 563);
            this.radPageView1.TabIndex = 0;
            this.radPageView1.Text = "radPageView1";
            this.radPageView1.ViewMode = Telerik.WinControls.UI.PageViewMode.Backstage;
            this.radPageView1.SelectedPageChanging += new System.EventHandler<Telerik.WinControls.UI.RadPageViewCancelEventArgs>(this.radPageView1_SelectedPageChanging);
            // 
            // expandCollapseItem
            // 
            this.expandCollapseItem.Image = global::WindowsFormsApplication44.Properties.Resources.hamburger;
            this.expandCollapseItem.ItemSize = new System.Drawing.SizeF(96F, 45F);
            this.expandCollapseItem.Location = new System.Drawing.Point(305, 4);
            this.expandCollapseItem.Name = "expandCollapseItem";
            this.expandCollapseItem.Size = new System.Drawing.Size(406, 555);
            // 
            // searchPage
            // 
            this.searchPage.Controls.Add(this.radLabel1);
            this.searchPage.Image = global::WindowsFormsApplication44.Properties.Resources.search;
            this.searchPage.ItemSize = new System.Drawing.SizeF(96F, 45F);
            this.searchPage.Location = new System.Drawing.Point(305, 4);
            this.searchPage.Name = "searchPage";
            this.searchPage.Size = new System.Drawing.Size(406, 555);
            this.searchPage.Text = "searchPage";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(85, 69);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(109, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Search page content";
            // 
            // moviesPage
            // 
            this.moviesPage.Controls.Add(this.radLabel2);
            this.moviesPage.Image = global::WindowsFormsApplication44.Properties.Resources.mov;
            this.moviesPage.ItemSize = new System.Drawing.SizeF(96F, 45F);
            this.moviesPage.Location = new System.Drawing.Point(305, 4);
            this.moviesPage.Name = "moviesPage";
            this.moviesPage.Size = new System.Drawing.Size(406, 555);
            this.moviesPage.Text = "Movies";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(76, 109);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(111, 18);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Movies page content";
            // 
            // tvPage
            // 
            this.tvPage.Controls.Add(this.radLabel3);
            this.tvPage.Image = global::WindowsFormsApplication44.Properties.Resources.tv;
            this.tvPage.ItemSize = new System.Drawing.SizeF(96F, 45F);
            this.tvPage.Location = new System.Drawing.Point(305, 4);
            this.tvPage.Name = "tvPage";
            this.tvPage.Size = new System.Drawing.Size(406, 555);
            this.tvPage.Text = "TV";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(84, 158);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(89, 18);
            this.radLabel3.TabIndex = 1;
            this.radLabel3.Text = "TV page content";
            // 
            // videosPage
            // 
            this.videosPage.Controls.Add(this.radLabel4);
            this.videosPage.Image = global::WindowsFormsApplication44.Properties.Resources.vid;
            this.videosPage.ItemSize = new System.Drawing.SizeF(96F, 45F);
            this.videosPage.Location = new System.Drawing.Point(305, 4);
            this.videosPage.Name = "videosPage";
            this.videosPage.Size = new System.Drawing.Size(406, 555);
            this.videosPage.Text = "Videos";
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(84, 205);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(110, 18);
            this.radLabel4.TabIndex = 1;
            this.radLabel4.Text = "Videos page content";
            // 
            // separatorPage
            // 
            this.separatorPage.ItemSize = new System.Drawing.SizeF(96F, 40F);
            this.separatorPage.ItemType = Telerik.WinControls.UI.PageViewItemType.GroupHeaderItem;
            this.separatorPage.Location = new System.Drawing.Point(305, 4);
            this.separatorPage.Name = "separatorPage";
            this.separatorPage.Size = new System.Drawing.Size(406, 555);
            // 
            // radPageViewPage1
            // 
            this.radPageViewPage1.Controls.Add(this.radLabel5);
            this.radPageViewPage1.Image = global::WindowsFormsApplication44.Properties.Resources.signIn;
            this.radPageViewPage1.ItemSize = new System.Drawing.SizeF(96F, 45F);
            this.radPageViewPage1.Location = new System.Drawing.Point(305, 4);
            this.radPageViewPage1.Name = "radPageViewPage1";
            this.radPageViewPage1.Size = new System.Drawing.Size(406, 555);
            this.radPageViewPage1.Text = "Sign In";
            // 
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(157, 251);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(110, 18);
            this.radLabel5.TabIndex = 1;
            this.radLabel5.Text = "Sign In page content";
            // 
            // radPageViewPage2
            // 
            this.radPageViewPage2.Controls.Add(this.radLabel6);
            this.radPageViewPage2.Image = global::WindowsFormsApplication44.Properties.Resources.settings;
            this.radPageViewPage2.ItemSize = new System.Drawing.SizeF(96F, 45F);
            this.radPageViewPage2.Location = new System.Drawing.Point(305, 4);
            this.radPageViewPage2.Name = "radPageViewPage2";
            this.radPageViewPage2.Size = new System.Drawing.Size(406, 555);
            this.radPageViewPage2.Text = "Settings";
            // 
            // radLabel6
            // 
            this.radLabel6.Location = new System.Drawing.Point(149, 268);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(116, 18);
            this.radLabel6.TabIndex = 1;
            this.radLabel6.Text = "Settings page content";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(776, 615);
            this.Controls.Add(this.radPageView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            this.radPageView1.ResumeLayout(false);
            this.searchPage.ResumeLayout(false);
            this.searchPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.moviesPage.ResumeLayout(false);
            this.moviesPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            this.tvPage.ResumeLayout(false);
            this.tvPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            this.videosPage.ResumeLayout(false);
            this.videosPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            this.radPageViewPage1.ResumeLayout(false);
            this.radPageViewPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            this.radPageViewPage2.ResumeLayout(false);
            this.radPageViewPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPageView radPageView1;
        private Telerik.WinControls.UI.RadPageViewPage expandCollapseItem;
        private Telerik.WinControls.UI.RadPageViewPage searchPage;
        private Telerik.WinControls.UI.RadPageViewPage moviesPage;
        private Telerik.WinControls.UI.RadPageViewPage tvPage;
        private Telerik.WinControls.UI.RadPageViewPage videosPage;
        private Telerik.WinControls.UI.RadPageViewItemPage separatorPage;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel6;
    }
}

