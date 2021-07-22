namespace ResizingPanelsDoubleBuffer
{
    partial class PanelsWithoutDoubleBuffer
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.radButton3 = new Telerik.WinControls.UI.RadButton();
            this.radButton4 = new Telerik.WinControls.UI.RadButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton4)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.radButton1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.radButton2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.radButton3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.radButton4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(690, 371);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(3, 3);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(75, 23);
            this.radButton1.TabIndex = 0;
            this.radButton1.Text = "radButton1";
            // 
            // radButton2
            // 
            this.radButton2.Location = new System.Drawing.Point(348, 188);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(75, 23);
            this.radButton2.TabIndex = 1;
            this.radButton2.Text = "radButton2";
            // 
            // radButton3
            // 
            this.radButton3.Location = new System.Drawing.Point(3, 188);
            this.radButton3.Name = "radButton3";
            this.radButton3.Size = new System.Drawing.Size(75, 23);
            this.radButton3.TabIndex = 2;
            this.radButton3.Text = "radButton3";
            // 
            // radButton4
            // 
            this.radButton4.Location = new System.Drawing.Point(348, 3);
            this.radButton4.Name = "radButton4";
            this.radButton4.Size = new System.Drawing.Size(75, 23);
            this.radButton4.TabIndex = 3;
            this.radButton4.Text = "radButton4";
            // 
            // PanelsWithoutDoubleBuffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 371);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PanelsWithoutDoubleBuffer";
            this.Text = "PanelsWithoutDoubleBuffer: ResizeMe!";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadButton radButton3;
        private Telerik.WinControls.UI.RadButton radButton4;
    }
}