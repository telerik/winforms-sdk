namespace DisabledEditors
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
            this.myRadSpinEditor1 = new DisabledEditors.MyRadSpinEditor();
            this.myRadMaskedEditBox1 = new DisabledEditors.MyRadMaskedEditBox();
            this.myRadDateTimePicker1 = new DisabledEditors.MyRadDateTimePicker();
            this.myTextBox1 = new DisabledEditors.MyRadTextBox();
            this.myRadDropDownList1 = new DisabledEditors.MyRadDropDownList();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.myRadSpinEditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myRadMaskedEditBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myRadDateTimePicker1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myRadDropDownList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // myRadSpinEditor1
            // 
            this.myRadSpinEditor1.Location = new System.Drawing.Point(22, 38);
            this.myRadSpinEditor1.Name = "myRadSpinEditor1";
            // 
            // 
            // 
            this.myRadSpinEditor1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.myRadSpinEditor1.ShowBorder = true;
            this.myRadSpinEditor1.Size = new System.Drawing.Size(150, 20);
            this.myRadSpinEditor1.TabIndex = 5;
            this.myRadSpinEditor1.TabStop = false;
            this.myRadSpinEditor1.Value = new decimal(new int[] {
            99,
            0,
            0,
            0});
            // 
            // myRadMaskedEditBox1
            // 
            this.myRadMaskedEditBox1.AllowPromptAsInput = false;
            this.myRadMaskedEditBox1.AutoSize = true;
            this.myRadMaskedEditBox1.Culture = new System.Globalization.CultureInfo("en-US");
            this.myRadMaskedEditBox1.Location = new System.Drawing.Point(22, 64);
            this.myRadMaskedEditBox1.MaskType = Telerik.WinControls.UI.MaskType.DateTime;
            this.myRadMaskedEditBox1.Name = "myRadMaskedEditBox1";
            this.myRadMaskedEditBox1.SelectedText = "10";
            this.myRadMaskedEditBox1.SelectionLength = 2;
            this.myRadMaskedEditBox1.Size = new System.Drawing.Size(150, 20);
            this.myRadMaskedEditBox1.TabIndex = 4;
            this.myRadMaskedEditBox1.TabStop = false;
            this.myRadMaskedEditBox1.Text = "10/4/2011 12:58 PM";
            this.myRadMaskedEditBox1.Value = new System.DateTime(2011, 10, 4, 12, 58, 44, 670);
            // 
            // myRadDateTimePicker1
            // 
            this.myRadDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.myRadDateTimePicker1.Location = new System.Drawing.Point(22, 90);
            this.myRadDateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.myRadDateTimePicker1.MinDate = new System.DateTime(((long)(0)));
            this.myRadDateTimePicker1.Name = "myRadDateTimePicker1";
            this.myRadDateTimePicker1.NullableValue = new System.DateTime(2011, 10, 4, 12, 54, 8, 247);
            this.myRadDateTimePicker1.NullDate = new System.DateTime(((long)(0)));
            this.myRadDateTimePicker1.Size = new System.Drawing.Size(150, 20);
            this.myRadDateTimePicker1.TabIndex = 3;
            this.myRadDateTimePicker1.TabStop = false;
            this.myRadDateTimePicker1.Text = "myRadDateTimePicker1";
            this.myRadDateTimePicker1.Value = new System.DateTime(2011, 10, 4, 12, 54, 8, 247);
            // 
            // myTextBox1
            // 
            this.myTextBox1.Location = new System.Drawing.Point(22, 114);
            this.myTextBox1.Name = "myTextBox1";
            this.myTextBox1.Size = new System.Drawing.Size(150, 20);
            this.myTextBox1.TabIndex = 1;
            this.myTextBox1.TabStop = false;
            this.myTextBox1.Text = "This is a long long long text";
            // 
            // myRadDropDownList1
            // 
            this.myRadDropDownList1.DropDownAnimationEnabled = true;
            this.myRadDropDownList1.Location = new System.Drawing.Point(22, 12);
            this.myRadDropDownList1.Name = "myRadDropDownList1";
            this.myRadDropDownList1.ShowImageInEditorArea = true;
            this.myRadDropDownList1.Size = new System.Drawing.Size(150, 20);
            this.myRadDropDownList1.TabIndex = 6;
            this.myRadDropDownList1.Text = "myRadDropDownList1";
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(57, 140);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(75, 24);
            this.radButton1.TabIndex = 7;
            this.radButton1.Text = "!Enable";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 176);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.myRadDropDownList1);
            this.Controls.Add(this.myRadSpinEditor1);
            this.Controls.Add(this.myRadMaskedEditBox1);
            this.Controls.Add(this.myRadDateTimePicker1);
            this.Controls.Add(this.myTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.myRadSpinEditor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myRadMaskedEditBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myRadDateTimePicker1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myRadDropDownList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyRadTextBox myTextBox1;
        private MyRadDateTimePicker myRadDateTimePicker1;
        private MyRadMaskedEditBox myRadMaskedEditBox1;
        private MyRadSpinEditor myRadSpinEditor1;
        private MyRadDropDownList myRadDropDownList1;
        private Telerik.WinControls.UI.RadButton radButton1;
    }
}

