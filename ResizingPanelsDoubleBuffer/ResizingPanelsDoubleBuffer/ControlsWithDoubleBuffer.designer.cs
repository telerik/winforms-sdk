namespace ResizingPanelsDoubleBuffer
{
    partial class ControlsWithDoubleBuffer
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
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.customGroupBox2 = new CustomGroupBox();
            this.customGroupBox1 = new CustomGroupBox();
            this.customPanel1 = new CustomPanel();
            this.customGroupBox4 = new CustomGroupBox();
            this.customGroupBox3 = new CustomGroupBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.AutoScroll = true;
            this.radPanel1.Controls.Add(this.customGroupBox2);
            this.radPanel1.Controls.Add(this.customGroupBox1);
            this.radPanel1.Location = new System.Drawing.Point(12, 34);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(390, 390);
            this.radPanel1.TabIndex = 0;
            this.radPanel1.ThemeName = "ControlDefault";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.Blue;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.White;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.White;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(0))).GradientPercentage = 0.2101597F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(0))).GradientPercentage2 = 0.2323962F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.White;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(1))).Width = 0F;
            // 
            // groupBox2
            // 
            this.customGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.customGroupBox2.Location = new System.Drawing.Point(150, 250);
            this.customGroupBox2.Name = "customGroupBox2";
            this.customGroupBox2.Size = new System.Drawing.Size(350, 250);
            this.customGroupBox2.TabIndex = 1;
            this.customGroupBox2.TabStop = false;
            this.customGroupBox2.Text = "customGroupBox2";
            // 
            // groupBox1
            // 
            this.customGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.customGroupBox1.Location = new System.Drawing.Point(150, 50);
            this.customGroupBox1.Name = "customGroupBox1";
            this.customGroupBox1.Size = new System.Drawing.Size(350, 150);
            this.customGroupBox1.TabIndex = 0;
            this.customGroupBox1.TabStop = false;
            this.customGroupBox1.Text = "customGroupBox1";
            // 
            // panel1
            // 
            this.customPanel1.AutoScroll = true;
            this.customPanel1.BackColor = System.Drawing.Color.Transparent;
            this.customPanel1.Controls.Add(this.customGroupBox4);
            this.customPanel1.Controls.Add(this.customGroupBox3);
            this.customPanel1.Location = new System.Drawing.Point(408, 34);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(390, 390);
            this.customPanel1.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.customGroupBox4.BackColor = System.Drawing.Color.Transparent;
            this.customGroupBox4.Location = new System.Drawing.Point(150, 50);
            this.customGroupBox4.Name = "customGroupBox4";
            this.customGroupBox4.Size = new System.Drawing.Size(350, 150);
            this.customGroupBox4.TabIndex = 1;
            this.customGroupBox4.TabStop = false;
            this.customGroupBox4.Text = "customGroupBox4";
            // 
            // groupBox3
            // 
            this.customGroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.customGroupBox3.Location = new System.Drawing.Point(150, 250);
            this.customGroupBox3.Name = "customGroupBox3";
            this.customGroupBox3.Size = new System.Drawing.Size(350, 250);
            this.customGroupBox3.TabIndex = 0;
            this.customGroupBox3.TabStop = false;
            this.customGroupBox3.Text = "customGroupBox3";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(12, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(54, 14);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "RadPanel";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(408, 12);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(72, 14);
            this.radLabel2.TabIndex = 3;
            this.radLabel2.Text = "CustomPanel";
            // 
            // ControlsWithDoubleBuffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 438);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.radPanel1);
            this.Name = "ControlsWithDoubleBuffer";
            this.Text = "ControlsWithDoubleBuffer: Scroll!";
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.customPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanel1;
        private CustomGroupBox customGroupBox1;
        private CustomGroupBox customGroupBox2;
        private CustomPanel customPanel1;
        private CustomGroupBox customGroupBox4;
        private CustomGroupBox customGroupBox3;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
    }
}

