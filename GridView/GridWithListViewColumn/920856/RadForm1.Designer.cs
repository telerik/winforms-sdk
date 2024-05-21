namespace _920856
{
    partial class RadForm1
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
			this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
			this.desertTheme1 = new Telerik.WinControls.Themes.DesertTheme();
			this.radButton1 = new Telerik.WinControls.UI.RadButton();
			this.radButton2 = new Telerik.WinControls.UI.RadButton();
			this.radButton3 = new Telerik.WinControls.UI.RadButton();
			this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
			this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
			((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
			this.radPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
			this.radPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			this.SuspendLayout();
			// 
			// radGridView1
			// 
			this.radGridView1.AutoScroll = true;
			this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.radGridView1.Location = new System.Drawing.Point(0, 0);
			// 
			// radGridView1
			// 
			this.radGridView1.MasterTemplate.AllowAddNewRow = false;
			this.radGridView1.MasterTemplate.AllowDeleteRow = false;
			this.radGridView1.MasterTemplate.AllowDragToGroup = false;
			this.radGridView1.MasterTemplate.AllowEditRow = false;
			this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
			this.radGridView1.MasterTemplate.ShowFilteringRow = false;
			this.radGridView1.MasterTemplate.ShowRowHeaderColumn = false;
			this.radGridView1.Name = "radGridView1";
			this.radGridView1.Padding = new System.Windows.Forms.Padding(1);
			this.radGridView1.ReadOnly = true;
			this.radGridView1.ShowCellErrors = false;
			this.radGridView1.ShowGroupPanel = false;
			this.radGridView1.Size = new System.Drawing.Size(899, 429);
			this.radGridView1.TabIndex = 0;
			this.radGridView1.Text = "radGridView1";
			this.radGridView1.ThemeName = "Desert";
			this.radGridView1.CellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.radGridView1_CellFormatting);
			// 
			// radButton1
			// 
			this.radButton1.Location = new System.Drawing.Point(21, 15);
			this.radButton1.Name = "radButton1";
			this.radButton1.Size = new System.Drawing.Size(110, 24);
			this.radButton1.TabIndex = 1;
			this.radButton1.Text = "Update 1";
			this.radButton1.ThemeName = "Desert";
			this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
			// 
			// radButton2
			// 
			this.radButton2.Location = new System.Drawing.Point(21, 57);
			this.radButton2.Name = "radButton2";
			this.radButton2.Size = new System.Drawing.Size(110, 24);
			this.radButton2.TabIndex = 2;
			this.radButton2.Text = "Update 2";
			this.radButton2.ThemeName = "Desert";
			this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
			// 
			// radButton3
			// 
			this.radButton3.Location = new System.Drawing.Point(21, 98);
			this.radButton3.Name = "radButton3";
			this.radButton3.Size = new System.Drawing.Size(110, 24);
			this.radButton3.TabIndex = 3;
			this.radButton3.Text = "Flash Row";
			this.radButton3.ThemeName = "Desert";
			this.radButton3.Click += new System.EventHandler(this.radButton3_Click);
			// 
			// radPanel1
			// 
			this.radPanel1.Controls.Add(this.radGridView1);
			this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.radPanel1.Location = new System.Drawing.Point(0, 0);
			this.radPanel1.Name = "radPanel1";
			this.radPanel1.Size = new System.Drawing.Size(899, 429);
			this.radPanel1.TabIndex = 4;
			this.radPanel1.Text = "radPanel1";
			// 
			// radPanel2
			// 
			this.radPanel2.Controls.Add(this.radButton1);
			this.radPanel2.Controls.Add(this.radButton2);
			this.radPanel2.Controls.Add(this.radButton3);
			this.radPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.radPanel2.Location = new System.Drawing.Point(0, 291);
			this.radPanel2.Name = "radPanel2";
			this.radPanel2.Size = new System.Drawing.Size(899, 138);
			this.radPanel2.TabIndex = 5;
			// 
			// RadForm1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(899, 429);
			this.Controls.Add(this.radPanel2);
			this.Controls.Add(this.radPanel1);
			this.Name = "RadForm1";
			// 
			// 
			// 
			this.RootElement.ApplyShapeToControl = true;
			this.Text = "Grid Try 3";
			this.ThemeName = "Desert";
			((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
			this.radPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
			this.radPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.Themes.DesertTheme desertTheme1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadButton radButton3;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadPanel radPanel2;
    }
}