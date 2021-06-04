namespace EditRowInACustomFormCS
{
    partial class UserControl1
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
            this.textBox = new Telerik.WinControls.UI.RadTextBox();
            this.dateTimePicker = new Telerik.WinControls.UI.RadDateTimePicker();
            this.saveButton = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.textBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButton)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(7, 4);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(146, 20);
            this.textBox.TabIndex = 0;
            this.textBox.TabStop = false;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePicker.Location = new System.Drawing.Point(159, 4);
            this.dateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.NullableValue = new System.DateTime(2010, 7, 28, 9, 22, 47, 0);
            this.dateTimePicker.NullDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Size = new System.Drawing.Size(150, 20);
            this.dateTimePicker.TabIndex = 1;
            this.dateTimePicker.TabStop = false;
            this.dateTimePicker.Text = "Wednesday, July 28, 2010";
            this.dateTimePicker.Value = new System.DateTime(2010, 7, 28, 9, 22, 47, 0);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(332, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(105, 20);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.textBox);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(440, 28);
            ((System.ComponentModel.ISupportInitialize)(this.textBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox textBox;
        private Telerik.WinControls.UI.RadDateTimePicker dateTimePicker;
        private Telerik.WinControls.UI.RadButton saveButton;
    }
}
