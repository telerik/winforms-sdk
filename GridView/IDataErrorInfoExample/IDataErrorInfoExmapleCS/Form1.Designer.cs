namespace IDataErrorInfoExmapleCS
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.RadGroupBoxOptions = new Telerik.WinControls.UI.RadGroupBox();
            this.RadPanelBorderColor = new Telerik.WinControls.UI.RadPanel();
            this.RadCheckBoxShowRowHeaderColumn = new Telerik.WinControls.UI.RadCheckBox();
            this.RadButtonBorderColor = new Telerik.WinControls.UI.RadButton();
            this.RadCheckBoxIncludeCellImage = new Telerik.WinControls.UI.RadCheckBox();
            this.RadLabelTextImageRelation = new Telerik.WinControls.UI.RadLabel();
            this.RadDropDownTextImageRelation = new Telerik.WinControls.UI.RadDropDownList();
            this.RadGroupBoxGridview = new Telerik.WinControls.UI.RadGroupBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.radColorDialog1 = new Telerik.WinControls.RadColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadGroupBoxOptions)).BeginInit();
            this.RadGroupBoxOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RadPanelBorderColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadCheckBoxShowRowHeaderColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadButtonBorderColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadCheckBoxIncludeCellImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadLabelTextImageRelation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadDropDownTextImageRelation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadGroupBoxGridview)).BeginInit();
            this.RadGroupBoxGridview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGridView1
            // 
            this.radGridView1.Location = new System.Drawing.Point(13, 23);
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            // 
            // 
            // 
            this.radGridView1.RootElement.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.radGridView1.Size = new System.Drawing.Size(368, 198);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Text = "radGridView1";
            // 
            // RadGroupBoxOptions
            // 
            this.RadGroupBoxOptions.Controls.Add(this.RadPanelBorderColor);
            this.RadGroupBoxOptions.Controls.Add(this.RadCheckBoxShowRowHeaderColumn);
            this.RadGroupBoxOptions.Controls.Add(this.RadButtonBorderColor);
            this.RadGroupBoxOptions.Controls.Add(this.RadCheckBoxIncludeCellImage);
            this.RadGroupBoxOptions.Controls.Add(this.RadLabelTextImageRelation);
            this.RadGroupBoxOptions.Controls.Add(this.RadDropDownTextImageRelation);
            this.RadGroupBoxOptions.FooterImageIndex = -1;
            this.RadGroupBoxOptions.FooterImageKey = "";
            this.RadGroupBoxOptions.HeaderImageIndex = -1;
            this.RadGroupBoxOptions.HeaderImageKey = "";
            this.RadGroupBoxOptions.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.RadGroupBoxOptions.HeaderText = "Options";
            this.RadGroupBoxOptions.Location = new System.Drawing.Point(388, 0);
            this.RadGroupBoxOptions.Name = "RadGroupBoxOptions";
            this.RadGroupBoxOptions.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.RadGroupBoxOptions.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.RadGroupBoxOptions.Size = new System.Drawing.Size(190, 234);
            this.RadGroupBoxOptions.TabIndex = 1;
            this.RadGroupBoxOptions.Text = "Options";
            // 
            // RadPanelBorderColor
            // 
            this.RadPanelBorderColor.BackColor = System.Drawing.Color.Red;
            this.RadPanelBorderColor.Location = new System.Drawing.Point(138, 164);
            this.RadPanelBorderColor.Name = "RadPanelBorderColor";
            this.RadPanelBorderColor.Size = new System.Drawing.Size(29, 24);
            this.RadPanelBorderColor.TabIndex = 10;
            // 
            // RadCheckBoxShowRowHeaderColumn
            // 
            this.RadCheckBoxShowRowHeaderColumn.BackColor = System.Drawing.Color.Transparent;
            this.RadCheckBoxShowRowHeaderColumn.Location = new System.Drawing.Point(13, 40);
            this.RadCheckBoxShowRowHeaderColumn.Name = "RadCheckBoxShowRowHeaderColumn";
            this.RadCheckBoxShowRowHeaderColumn.Size = new System.Drawing.Size(154, 18);
            this.RadCheckBoxShowRowHeaderColumn.TabIndex = 1;
            this.RadCheckBoxShowRowHeaderColumn.Text = "Show Row Header Column";
            this.RadCheckBoxShowRowHeaderColumn.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // RadButtonBorderColor
            // 
            this.RadButtonBorderColor.Location = new System.Drawing.Point(13, 164);
            this.RadButtonBorderColor.Name = "RadButtonBorderColor";
            this.RadButtonBorderColor.Size = new System.Drawing.Size(119, 24);
            this.RadButtonBorderColor.TabIndex = 9;
            this.RadButtonBorderColor.Text = "Error Border Color";
            this.RadButtonBorderColor.Click += new System.EventHandler(this.RadButtonBorderColor_Click_1);
            // 
            // RadCheckBoxIncludeCellImage
            // 
            this.RadCheckBoxIncludeCellImage.BackColor = System.Drawing.Color.Transparent;
            this.RadCheckBoxIncludeCellImage.Location = new System.Drawing.Point(13, 72);
            this.RadCheckBoxIncludeCellImage.Name = "RadCheckBoxIncludeCellImage";
            this.RadCheckBoxIncludeCellImage.Size = new System.Drawing.Size(112, 18);
            this.RadCheckBoxIncludeCellImage.TabIndex = 6;
            this.RadCheckBoxIncludeCellImage.Text = "Include Cell Image";
            // 
            // RadLabelTextImageRelation
            // 
            this.RadLabelTextImageRelation.BackColor = System.Drawing.Color.Transparent;
            this.RadLabelTextImageRelation.Location = new System.Drawing.Point(12, 102);
            this.RadLabelTextImageRelation.Name = "RadLabelTextImageRelation";
            this.RadLabelTextImageRelation.Size = new System.Drawing.Size(99, 18);
            this.RadLabelTextImageRelation.TabIndex = 8;
            this.RadLabelTextImageRelation.Text = "TextImageRelation";
            // 
            // RadDropDownTextImageRelation
            // 
            this.RadDropDownTextImageRelation.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.RadDropDownTextImageRelation.Enabled = false;
            this.RadDropDownTextImageRelation.Location = new System.Drawing.Point(13, 126);
            this.RadDropDownTextImageRelation.Name = "RadDropDownTextImageRelation";
            this.RadDropDownTextImageRelation.Size = new System.Drawing.Size(154, 20);
            this.RadDropDownTextImageRelation.TabIndex = 7;
            // 
            // RadGroupBoxGridview
            // 
            this.RadGroupBoxGridview.Controls.Add(this.RadGroupBoxOptions);
            this.RadGroupBoxGridview.Controls.Add(this.radGridView1);
            this.RadGroupBoxGridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RadGroupBoxGridview.FooterImageIndex = -1;
            this.RadGroupBoxGridview.FooterImageKey = "";
            this.RadGroupBoxGridview.HeaderImageIndex = -1;
            this.RadGroupBoxGridview.HeaderImageKey = "";
            this.RadGroupBoxGridview.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.RadGroupBoxGridview.HeaderText = "Grid";
            this.RadGroupBoxGridview.Location = new System.Drawing.Point(0, 0);
            this.RadGroupBoxGridview.Name = "RadGroupBoxGridview";
            this.RadGroupBoxGridview.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.RadGroupBoxGridview.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.RadGroupBoxGridview.Size = new System.Drawing.Size(578, 234);
            this.RadGroupBoxGridview.TabIndex = 2;
            this.RadGroupBoxGridview.Text = "Grid";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "error.png");
            // 
            // radColorDialog1
            // 
            this.radColorDialog1.SelectedColor = System.Drawing.Color.Red;
            this.radColorDialog1.SelectedHslColor = Telerik.WinControls.HslColor.FromAhsl(0, 1, 1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 234);
            this.Controls.Add(this.RadGroupBoxGridview);
            this.Name = "Form1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadGroupBoxOptions)).EndInit();
            this.RadGroupBoxOptions.ResumeLayout(false);
            this.RadGroupBoxOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RadPanelBorderColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadCheckBoxShowRowHeaderColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadButtonBorderColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadCheckBoxIncludeCellImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadLabelTextImageRelation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadDropDownTextImageRelation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadGroupBoxGridview)).EndInit();
            this.RadGroupBoxGridview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadGroupBox RadGroupBoxOptions;
        private Telerik.WinControls.UI.RadGroupBox RadGroupBoxGridview;
        internal Telerik.WinControls.UI.RadPanel RadPanelBorderColor;
        internal Telerik.WinControls.UI.RadCheckBox RadCheckBoxShowRowHeaderColumn;
        internal Telerik.WinControls.UI.RadButton RadButtonBorderColor;
        internal Telerik.WinControls.UI.RadCheckBox RadCheckBoxIncludeCellImage;
        internal Telerik.WinControls.UI.RadLabel RadLabelTextImageRelation;
        internal Telerik.WinControls.UI.RadDropDownList RadDropDownTextImageRelation;
        private System.Windows.Forms.ImageList imageList1;
        private Telerik.WinControls.RadColorDialog radColorDialog1;
    }
}

