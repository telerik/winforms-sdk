namespace RotatorSlideShow
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
            this.radRotator1 = new Telerik.WinControls.UI.RadRotator();
            this.pnlRotator = new Telerik.WinControls.UI.RadPanel();
            this.btnCreateSlideShow = new Telerik.WinControls.UI.RadButton();
            this.btnLoadSlideShow = new Telerik.WinControls.UI.RadButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnStepBack = new Telerik.WinControls.UI.RadButton();
            this.btnStepForward = new Telerik.WinControls.UI.RadButton();
            this.btnStart = new Telerik.WinControls.UI.RadButton();
            this.tbInterval = new Telerik.WinControls.UI.RadTextBox();
            this.lblInterval = new Telerik.WinControls.UI.RadLabel();
            this.btnApply = new Telerik.WinControls.UI.RadButton();
            this.tbLocationAnimation = new Telerik.WinControls.UI.RadTextBox();
            this.lblLocationAnimation = new Telerik.WinControls.UI.RadLabel();
            this.gboxSettings = new System.Windows.Forms.GroupBox();
            this.btnClose = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radRotator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRotator)).BeginInit();
            this.pnlRotator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateSlideShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadSlideShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStepBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStepForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnApply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLocationAnimation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLocationAnimation)).BeginInit();
            this.gboxSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radRotator1
            // 
            this.radRotator1.BackColor = System.Drawing.Color.Transparent;
            this.radRotator1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.radRotator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radRotator1.Location = new System.Drawing.Point(0, 0);
            this.radRotator1.LocationAnimation = new System.Drawing.SizeF(0F, -1F);
            this.radRotator1.Name = "radRotator1";
            this.radRotator1.Running = false;
            this.radRotator1.Size = new System.Drawing.Size(498, 333);
            this.radRotator1.TabIndex = 0;
            this.radRotator1.Text = "radRotator1";
            // 
            // pnlRotator
            // 
            this.pnlRotator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRotator.BackColor = System.Drawing.Color.Transparent;
            this.pnlRotator.Controls.Add(this.radRotator1);
            this.pnlRotator.Location = new System.Drawing.Point(15, 10);
            this.pnlRotator.Name = "pnlRotator";
            this.pnlRotator.Size = new System.Drawing.Size(498, 333);
            this.pnlRotator.TabIndex = 1;
            // 
            // btnCreateSlideShow
            // 
            this.btnCreateSlideShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreateSlideShow.Location = new System.Drawing.Point(15, 349);
            this.btnCreateSlideShow.Name = "btnCreateSlideShow";
            this.btnCreateSlideShow.Size = new System.Drawing.Size(101, 23);
            this.btnCreateSlideShow.TabIndex = 2;
            this.btnCreateSlideShow.Text = "Create SlideShow";
            this.btnCreateSlideShow.ThemeName = "ControlDefault";
            this.btnCreateSlideShow.Click += new System.EventHandler(this.btnCreateSlideShow_Click);
            // 
            // btnLoadSlideShow
            // 
            this.btnLoadSlideShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoadSlideShow.Location = new System.Drawing.Point(123, 349);
            this.btnLoadSlideShow.Name = "btnLoadSlideShow";
            this.btnLoadSlideShow.Size = new System.Drawing.Size(97, 23);
            this.btnLoadSlideShow.TabIndex = 3;
            this.btnLoadSlideShow.Text = "Load SlideShow";
            this.btnLoadSlideShow.Click += new System.EventHandler(this.btnLoadSlideShow_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "xml";
            this.openFileDialog1.Filter = "Rotator Slide Show Files|*.xml";
            // 
            // btnStepBack
            // 
            this.btnStepBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStepBack.Location = new System.Drawing.Point(463, 349);
            this.btnStepBack.Name = "btnStepBack";
            this.btnStepBack.Size = new System.Drawing.Size(22, 23);
            this.btnStepBack.TabIndex = 4;
            this.btnStepBack.Text = "<";
            this.btnStepBack.Click += new System.EventHandler(this.btnStepBack_Click);
            // 
            // btnStepForward
            // 
            this.btnStepForward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStepForward.Location = new System.Drawing.Point(491, 349);
            this.btnStepForward.Name = "btnStepForward";
            this.btnStepForward.Size = new System.Drawing.Size(22, 23);
            this.btnStepForward.TabIndex = 4;
            this.btnStepForward.Text = ">";
            this.btnStepForward.Click += new System.EventHandler(this.btnStepForward_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(382, 349);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbInterval
            // 
            this.tbInterval.ForeColor = System.Drawing.Color.Black;
            this.tbInterval.Location = new System.Drawing.Point(125, 26);
            this.tbInterval.MaxLength = 5;
            this.tbInterval.Name = "tbInterval";
            this.tbInterval.Padding = new System.Windows.Forms.Padding(2, 2, 2, 3);
            // 
            // 
            // 
            this.tbInterval.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.tbInterval.RootElement.ForeColor = System.Drawing.Color.Black;
            this.tbInterval.Size = new System.Drawing.Size(42, 20);
            this.tbInterval.TabIndex = 8;
            this.tbInterval.Text = "2000";
            // 
            // lblInterval
            // 
            this.lblInterval.BackColor = System.Drawing.Color.Transparent;
            this.lblInterval.ForeColor = System.Drawing.Color.Black;
            this.lblInterval.Location = new System.Drawing.Point(15, 30);
            this.lblInterval.Name = "lblInterval";
            // 
            // 
            // 
            this.lblInterval.RootElement.ForeColor = System.Drawing.Color.Black;
            this.lblInterval.Size = new System.Drawing.Size(47, 16);
            this.lblInterval.TabIndex = 7;
            this.lblInterval.Text = "Interval:";
            // 
            // btnApply
            // 
            this.btnApply.ForeColor = System.Drawing.Color.Black;
            this.btnApply.Location = new System.Drawing.Point(125, 80);
            this.btnApply.Name = "btnApply";
            // 
            // 
            // 
            this.btnApply.RootElement.ForeColor = System.Drawing.Color.Black;
            this.btnApply.Size = new System.Drawing.Size(49, 21);
            this.btnApply.TabIndex = 14;
            this.btnApply.Text = "Apply";
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // tbLocationAnimation
            // 
            this.tbLocationAnimation.ForeColor = System.Drawing.Color.Black;
            this.tbLocationAnimation.Location = new System.Drawing.Point(125, 54);
            this.tbLocationAnimation.Name = "tbLocationAnimation";
            this.tbLocationAnimation.Padding = new System.Windows.Forms.Padding(2, 2, 2, 3);
            // 
            // 
            // 
            this.tbLocationAnimation.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.tbLocationAnimation.RootElement.ForeColor = System.Drawing.Color.Black;
            this.tbLocationAnimation.Size = new System.Drawing.Size(42, 20);
            this.tbLocationAnimation.TabIndex = 12;
            this.tbLocationAnimation.Text = "0, -1";
            // 
            // lblLocationAnimation
            // 
            this.lblLocationAnimation.BackColor = System.Drawing.Color.Transparent;
            this.lblLocationAnimation.ForeColor = System.Drawing.Color.Black;
            this.lblLocationAnimation.Location = new System.Drawing.Point(15, 58);
            this.lblLocationAnimation.Name = "lblLocationAnimation";
            // 
            // 
            // 
            this.lblLocationAnimation.RootElement.ForeColor = System.Drawing.Color.Black;
            this.lblLocationAnimation.Size = new System.Drawing.Size(104, 16);
            this.lblLocationAnimation.TabIndex = 13;
            this.lblLocationAnimation.Text = "Location animation:";
            // 
            // gboxSettings
            // 
            this.gboxSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gboxSettings.BackColor = System.Drawing.Color.Transparent;
            this.gboxSettings.Controls.Add(this.lblInterval);
            this.gboxSettings.Controls.Add(this.tbLocationAnimation);
            this.gboxSettings.Controls.Add(this.lblLocationAnimation);
            this.gboxSettings.Controls.Add(this.tbInterval);
            this.gboxSettings.Controls.Add(this.btnApply);
            this.gboxSettings.Location = new System.Drawing.Point(15, 378);
            this.gboxSettings.Name = "gboxSettings";
            this.gboxSettings.Size = new System.Drawing.Size(187, 112);
            this.gboxSettings.TabIndex = 15;
            this.gboxSettings.TabStop = false;
            this.gboxSettings.Text = "Settings";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(441, 472);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(528, 507);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gboxSettings);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStepForward);
            this.Controls.Add(this.btnStepBack);
            this.Controls.Add(this.btnLoadSlideShow);
            this.Controls.Add(this.btnCreateSlideShow);
            this.Controls.Add(this.pnlRotator);
            this.Name = "Form1";
            this.Text = "Empty";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radRotator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRotator)).EndInit();
            this.pnlRotator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateSlideShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadSlideShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStepBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStepForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnApply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLocationAnimation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLocationAnimation)).EndInit();
            this.gboxSettings.ResumeLayout(false);
            this.gboxSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadRotator radRotator1;
        private Telerik.WinControls.UI.RadPanel pnlRotator;
        private Telerik.WinControls.UI.RadButton btnCreateSlideShow;
        private Telerik.WinControls.UI.RadButton btnLoadSlideShow;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Telerik.WinControls.UI.RadButton btnStepBack;
        private Telerik.WinControls.UI.RadButton btnStepForward;
        private Telerik.WinControls.UI.RadButton btnStart;
        private Telerik.WinControls.UI.RadTextBox tbInterval;
        private Telerik.WinControls.UI.RadLabel lblInterval;
        private Telerik.WinControls.UI.RadButton btnApply;
        private Telerik.WinControls.UI.RadTextBox tbLocationAnimation;
        private Telerik.WinControls.UI.RadLabel lblLocationAnimation;
        private System.Windows.Forms.GroupBox gboxSettings;
        private Telerik.WinControls.UI.RadButton btnClose;
    }
}

