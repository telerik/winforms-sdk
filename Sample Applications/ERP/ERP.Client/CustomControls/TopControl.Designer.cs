using Telerik.WinControls.UI;

namespace ERP.Client
{
    partial class TopControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.viewLabel = new Telerik.WinControls.UI.RadLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chooseThemeLabel = new Telerik.WinControls.UI.RadLabel();
            this.chooseThemeDropDown = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.viewLabel)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chooseThemeLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseThemeDropDown)).BeginInit();
            this.SuspendLayout();
            // 
            // viewLabel
            // 
            this.viewLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.viewLabel.Location = new System.Drawing.Point(0, 17);
            this.viewLabel.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.viewLabel.Name = "viewLabel";
            this.viewLabel.Size = new System.Drawing.Size(56, 18);
            this.viewLabel.TabIndex = 0;
            this.viewLabel.Text = "ViewLabel";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.30975F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.8413F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.81324F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.viewLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chooseThemeLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.chooseThemeDropDown, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1046, 53);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // chooseThemeLabel
            // 
            this.chooseThemeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chooseThemeLabel.Location = new System.Drawing.Point(721, 17);
            this.chooseThemeLabel.Name = "chooseThemeLabel";
            this.chooseThemeLabel.Size = new System.Drawing.Size(83, 18);
            this.chooseThemeLabel.TabIndex = 1;
            this.chooseThemeLabel.Text = "Choose Theme:";
            // 
            // chooseThemeDropDown
            // 
            this.chooseThemeDropDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseThemeDropDown.Location = new System.Drawing.Point(817, 14);
            this.chooseThemeDropDown.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.chooseThemeDropDown.Name = "chooseThemeDropDown";
            this.chooseThemeDropDown.Size = new System.Drawing.Size(219, 24);
            this.chooseThemeDropDown.TabIndex = 2;
            // 
            // TopControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TopControl";
            this.Size = new System.Drawing.Size(1046, 53);
            ((System.ComponentModel.ISupportInitialize)(this.viewLabel)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chooseThemeLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseThemeDropDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel viewLabel;
        private Telerik.WinControls.UI.RadLabel chooseThemeLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.UI.RadDropDownList chooseThemeDropDown;
    }
}
