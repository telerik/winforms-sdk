namespace MultiSelectDropDown
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
            MultiSelectDropDown.CustomListDataItem customListDataItem1 = new MultiSelectDropDown.CustomListDataItem();
            MultiSelectDropDown.CustomListDataItem customListDataItem2 = new MultiSelectDropDown.CustomListDataItem();
            MultiSelectDropDown.CustomListDataItem customListDataItem3 = new MultiSelectDropDown.CustomListDataItem();
            MultiSelectDropDown.CustomListDataItem customListDataItem4 = new MultiSelectDropDown.CustomListDataItem();
            this.customDropDownList1 = new MultiSelectDropDown.CustomDropDownList();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.customDropDownList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // customDropDownList1
            // 
            customListDataItem1.Text = "ListItem 1";
            customListDataItem1.TextWrap = true;
            customListDataItem2.Text = "ListItem 2";
            customListDataItem2.TextWrap = true;
            customListDataItem3.Text = "ListItem 3";
            customListDataItem3.TextWrap = true;
            customListDataItem4.Text = "ListItem 4";
            customListDataItem4.TextWrap = true;
            this.customDropDownList1.Items.Add(customListDataItem1);
            this.customDropDownList1.Items.Add(customListDataItem2);
            this.customDropDownList1.Items.Add(customListDataItem3);
            this.customDropDownList1.Items.Add(customListDataItem4);
            this.customDropDownList1.Location = new System.Drawing.Point(128, 184);
            this.customDropDownList1.Name = "customDropDownList1";
            this.customDropDownList1.Size = new System.Drawing.Size(233, 21);
            this.customDropDownList1.TabIndex = 0;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(13, 184);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(101, 18);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Added design time";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.customDropDownList1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customDropDownList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomDropDownList customDropDownList1;
        private Telerik.WinControls.UI.RadLabel radLabel1;



    }
}

