namespace GridViewEditDialog
{
    partial class EditForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.save_Button = new Telerik.WinControls.UI.RadButton();
            this.cancel_Button = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.radDropDownList1 = new Telerik.WinControls.UI.RadDropDownList();
            this.radSpinEditor1 = new Telerik.WinControls.UI.RadSpinEditor();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.save_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancel_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.save_Button, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cancel_Button, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.radLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.radLabel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.radLabel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.radTextBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.radDropDownList1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.radSpinEditor1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(277, 133);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // save_Button
            // 
            this.save_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.save_Button.Image = global::GridViewEditDialog.Properties.Resources.save_as1;
            this.save_Button.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.save_Button.Location = new System.Drawing.Point(3, 105);
            this.save_Button.Name = "save_Button";
            this.save_Button.Size = new System.Drawing.Size(132, 24);
            this.save_Button.TabIndex = 0;
            this.save_Button.Text = "Save";
            this.save_Button.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.save_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.save_Button.Click += new System.EventHandler(this.save_Button_Click);
            // 
            // cancel_Button
            // 
            this.cancel_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cancel_Button.Image = global::GridViewEditDialog.Properties.Resources.splitcon_firstlook_Delete_small;
            this.cancel_Button.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.cancel_Button.Location = new System.Drawing.Point(141, 105);
            this.cancel_Button.Name = "cancel_Button";
            this.cancel_Button.Size = new System.Drawing.Size(133, 24);
            this.cancel_Button.TabIndex = 1;
            this.cancel_Button.Text = "Cancel";
            this.cancel_Button.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancel_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancel_Button.Click += new System.EventHandler(this.cancel_Button_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radLabel1.Location = new System.Drawing.Point(3, 3);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(20, 18);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "ID:";
            // 
            // radLabel2
            // 
            this.radLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radLabel2.Location = new System.Drawing.Point(3, 36);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(39, 18);
            this.radLabel2.TabIndex = 3;
            this.radLabel2.Text = "Name:";
            // 
            // radLabel3
            // 
            this.radLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radLabel3.Location = new System.Drawing.Point(3, 69);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(39, 18);
            this.radLabel3.TabIndex = 4;
            this.radLabel3.Text = "Grade:";
            // 
            // radTextBox1
            // 
            this.radTextBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.radTextBox1.Location = new System.Drawing.Point(141, 36);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.Size = new System.Drawing.Size(76, 20);
            this.radTextBox1.TabIndex = 5;
            // 
            // radDropDownList1
            // 
            this.radDropDownList1.Dock = System.Windows.Forms.DockStyle.Left;
            this.radDropDownList1.Location = new System.Drawing.Point(141, 69);
            this.radDropDownList1.Name = "radDropDownList1";
            this.radDropDownList1.Size = new System.Drawing.Size(76, 20);
            this.radDropDownList1.TabIndex = 6;
            // 
            // radSpinEditor1
            // 
            this.radSpinEditor1.Dock = System.Windows.Forms.DockStyle.Left;
            this.radSpinEditor1.Location = new System.Drawing.Point(141, 3);
            this.radSpinEditor1.Name = "radSpinEditor1";
            this.radSpinEditor1.Size = new System.Drawing.Size(76, 20);
            this.radSpinEditor1.TabIndex = 7;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 133);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EditForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "EditForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.save_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancel_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.UI.RadButton save_Button;
        private Telerik.WinControls.UI.RadButton cancel_Button;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadDropDownList radDropDownList1;
        private Telerik.WinControls.UI.RadSpinEditor radSpinEditor1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
