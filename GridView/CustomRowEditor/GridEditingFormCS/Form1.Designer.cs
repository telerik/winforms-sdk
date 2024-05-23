namespace GridEditingForm
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
        protected override void Dispose( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rrbEmployees = new Telerik.WinControls.UI.RadRadioButton();
            this.rrbCustomers = new Telerik.WinControls.UI.RadRadioButton();
            this.rrbCategories = new Telerik.WinControls.UI.RadRadioButton();
            this.rrbCars = new Telerik.WinControls.UI.RadRadioButton();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rrbEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rrbCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rrbCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rrbCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rrbEmployees);
            this.groupBox1.Controls.Add(this.rrbCustomers);
            this.groupBox1.Controls.Add(this.rrbCategories);
            this.groupBox1.Controls.Add(this.rrbCars);
            this.groupBox1.Location = new System.Drawing.Point(13, 384);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 47);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data tables";
            // 
            // rrbEmployees
            // 
            this.rrbEmployees.Location = new System.Drawing.Point(219, 19);
            this.rrbEmployees.Name = "rrbEmployees";
            this.rrbEmployees.Size = new System.Drawing.Size(76, 16);
            this.rrbEmployees.TabIndex = 3;
            this.rrbEmployees.Text = "Employees";
            this.rrbEmployees.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.rrbEmployees_ToggleStateChanged);
            // 
            // rrbCustomers
            // 
            this.rrbCustomers.Location = new System.Drawing.Point(138, 20);
            this.rrbCustomers.Name = "rrbCustomers";
            this.rrbCustomers.Size = new System.Drawing.Size(75, 16);
            this.rrbCustomers.TabIndex = 2;
            this.rrbCustomers.Text = "Customers";
            this.rrbCustomers.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.rrbCustomers_ToggleStateChanged);
            // 
            // rrbCategories
            // 
            this.rrbCategories.Location = new System.Drawing.Point(57, 20);
            this.rrbCategories.Name = "rrbCategories";
            this.rrbCategories.Size = new System.Drawing.Size(75, 16);
            this.rrbCategories.TabIndex = 1;
            this.rrbCategories.Text = "Categories";
            this.rrbCategories.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.rrbCategories_ToggleStateChanged);
            // 
            // rrbCars
            // 
            this.rrbCars.Location = new System.Drawing.Point(7, 20);
            this.rrbCars.Name = "rrbCars";
            this.rrbCars.Size = new System.Drawing.Size(44, 16);
            this.rrbCars.TabIndex = 0;
            this.rrbCars.Text = "Cars";
            this.rrbCars.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.rrbCars_ToggleStateChanged);
            // 
            // radGridView1
            // 
            this.radGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGridView1.Location = new System.Drawing.Point(12, 12);
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            // 
            // 
            // 
            this.radGridView1.RootElement.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.radGridView1.Size = new System.Drawing.Size(637, 366);
            this.radGridView1.TabIndex = 2;
            this.radGridView1.Text = "radGridView1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 444);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rrbEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rrbCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rrbCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rrbCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadRadioButton rrbEmployees;
        private Telerik.WinControls.UI.RadRadioButton rrbCustomers;
        private Telerik.WinControls.UI.RadRadioButton rrbCategories;
        private Telerik.WinControls.UI.RadRadioButton rrbCars;
        private Telerik.WinControls.UI.RadGridView radGridView1;

    }
}

