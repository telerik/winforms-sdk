namespace LoadOnDemand
{
    partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {

        //Form overrides dispose to clean up the component list.
        [System.Diagnostics.DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components != null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        //Required by the Windows Form Designer

        private System.ComponentModel.IContainer components;
        //NOTE: The following procedure is required by the Windows Form Designer
        //It can be modified using the Windows Form Designer.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.RadDropDownList1 = new Telerik.WinControls.UI.RadDropDownList();
            this.RadLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.RadLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.RadLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.RadLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.lblSelectedValue = new Telerik.WinControls.UI.RadLabel();
            this.lblSelectedItem = new Telerik.WinControls.UI.RadLabel();
            this.lblSelectedIndex = new Telerik.WinControls.UI.RadLabel();
            this.RadTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.RadLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.RadGridView1 = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)this.RadDropDownList1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.RadLabel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.RadLabel2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.RadLabel3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.RadLabel4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.lblSelectedValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.lblSelectedItem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.lblSelectedIndex).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.RadTextBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.RadLabel5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.RadGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            this.SuspendLayout();
            //
            //RadDropDownList1
            //
            this.RadDropDownList1.DropDownAnimationEnabled = true;
            this.RadDropDownList1.Location = new System.Drawing.Point(131, 12);
            this.RadDropDownList1.MaxDropDownItems = 0;
            this.RadDropDownList1.Name = "RadDropDownList1";
            this.RadDropDownList1.ShowImageInEditorArea = true;
            this.RadDropDownList1.Size = new System.Drawing.Size(167, 20);
            this.RadDropDownList1.TabIndex = 0;
            //
            //RadLabel1
            //
            this.RadLabel1.Location = new System.Drawing.Point(12, 14);
            this.RadLabel1.Name = "RadLabel1";
            this.RadLabel1.Size = new System.Drawing.Size(103, 18);
            this.RadLabel1.TabIndex = 1;
            this.RadLabel1.Text = "RadDropDownList1";
            //
            //RadLabel2
            //
            this.RadLabel2.Location = new System.Drawing.Point(304, 14);
            this.RadLabel2.Name = "RadLabel2";
            this.RadLabel2.Size = new System.Drawing.Size(76, 18);
            this.RadLabel2.TabIndex = 2;
            this.RadLabel2.Text = "SelectedIndex";
            //
            //RadLabel3
            //
            this.RadLabel3.Location = new System.Drawing.Point(304, 38);
            this.RadLabel3.Name = "RadLabel3";
            this.RadLabel3.Size = new System.Drawing.Size(71, 18);
            this.RadLabel3.TabIndex = 3;
            this.RadLabel3.Text = "SelectedItem";
            //
            //RadLabel4
            //
            this.RadLabel4.Location = new System.Drawing.Point(304, 63);
            this.RadLabel4.Name = "RadLabel4";
            this.RadLabel4.Size = new System.Drawing.Size(76, 18);
            this.RadLabel4.TabIndex = 4;
            this.RadLabel4.Text = "SelectedValue";
            //
            //lblSelectedValue
            //
            this.lblSelectedValue.Location = new System.Drawing.Point(386, 63);
            this.lblSelectedValue.Name = "lblSelectedValue";
            this.lblSelectedValue.Size = new System.Drawing.Size(32, 18);
            this.lblSelectedValue.TabIndex = 5;
            this.lblSelectedValue.Text = "value";
            //
            //lblSelectedItem
            //
            this.lblSelectedItem.Location = new System.Drawing.Point(386, 38);
            this.lblSelectedItem.Name = "lblSelectedItem";
            this.lblSelectedItem.Size = new System.Drawing.Size(29, 18);
            this.lblSelectedItem.TabIndex = 6;
            this.lblSelectedItem.Text = "Item";
            //
            //lblSelectedIndex
            //
            this.lblSelectedIndex.Location = new System.Drawing.Point(386, 14);
            this.lblSelectedIndex.Name = "lblSelectedIndex";
            this.lblSelectedIndex.Size = new System.Drawing.Size(33, 18);
            this.lblSelectedIndex.TabIndex = 7;
            this.lblSelectedIndex.Text = "Index";
            //
            //RadTextBox1
            //
            this.RadTextBox1.Location = new System.Drawing.Point(12, 87);
            this.RadTextBox1.Name = "RadTextBox1";
            this.RadTextBox1.Size = new System.Drawing.Size(49, 20);
            this.RadTextBox1.TabIndex = 8;
            this.RadTextBox1.TabStop = false;
            //
            //RadLabel5
            //
            this.RadLabel5.Location = new System.Drawing.Point(70, 87);
            this.RadLabel5.Name = "RadLabel5";
            this.RadLabel5.Size = new System.Drawing.Size(184, 18);
            this.RadLabel5.TabIndex = 9;
            this.RadLabel5.Text = "(Focus to leave RadDropDownList1)";
            //
            //RadGridView1
            //
            this.RadGridView1.Location = new System.Drawing.Point(12, 113);
            this.RadGridView1.Name = "RadGridView1";
            this.RadGridView1.Size = new System.Drawing.Size(524, 150);
            this.RadGridView1.TabIndex = 10;
            this.RadGridView1.Text = "RadGridView1";
            //
            //RadForm1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 278);
            this.Controls.Add(this.RadGridView1);
            this.Controls.Add(this.RadLabel5);
            this.Controls.Add(this.RadTextBox1);
            this.Controls.Add(this.lblSelectedIndex);
            this.Controls.Add(this.lblSelectedItem);
            this.Controls.Add(this.lblSelectedValue);
            this.Controls.Add(this.RadLabel4);
            this.Controls.Add(this.RadLabel3);
            this.Controls.Add(this.RadLabel2);
            this.Controls.Add(this.RadLabel1);
            this.Controls.Add(this.RadDropDownList1);
            this.Name = "RadForm1";
            //
            //
            //
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "C# Example";
            this.Load += RadForm1_Load;
            ((System.ComponentModel.ISupportInitialize)this.RadDropDownList1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.RadLabel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.RadLabel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.RadLabel3).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.RadLabel4).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.lblSelectedValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.lblSelectedItem).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.lblSelectedIndex).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.RadTextBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.RadLabel5).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.RadGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal Telerik.WinControls.UI.RadDropDownList RadDropDownList1;
        internal Telerik.WinControls.UI.RadLabel RadLabel1;
        internal Telerik.WinControls.UI.RadLabel RadLabel2;
        internal Telerik.WinControls.UI.RadLabel RadLabel3;
        internal Telerik.WinControls.UI.RadLabel RadLabel4;
        internal Telerik.WinControls.UI.RadLabel lblSelectedValue;
        internal Telerik.WinControls.UI.RadLabel lblSelectedItem;
        internal Telerik.WinControls.UI.RadLabel lblSelectedIndex;
        internal Telerik.WinControls.UI.RadTextBox RadTextBox1;
        internal Telerik.WinControls.UI.RadLabel RadLabel5;
        internal Telerik.WinControls.UI.RadGridView RadGridView1;
    }
}

//=======================================================
//Service provided by Telerik (www.telerik.com)
//Conversion powered by NRefactory.
//Twitter: @telerik, @toddanglin
//Facebook: facebook.com/telerik
//=======================================================
