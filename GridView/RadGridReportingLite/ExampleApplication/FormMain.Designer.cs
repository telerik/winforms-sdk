namespace ExampleApplication
{
    partial class FormMain
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
            this.adventureWorks_DataSet = new ExampleApplication.DataBase.AdventureWorks_DataSet();
            this.adventureWorksDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radButtonReport = new Telerik.WinControls.UI.RadButton();
            this.radComboBoxTables = new Telerik.WinControls.UI.RadDropDownList();
            this.aquaTheme1 = new Telerik.WinControls.Themes.AquaTheme();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorks_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboBoxTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // adventureWorks_DataSet
            // 
            this.adventureWorks_DataSet.DataSetName = "AdventureWorks_DataSet";
            this.adventureWorks_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adventureWorksDataSetBindingSource
            // 
            this.adventureWorksDataSetBindingSource.DataSource = this.adventureWorks_DataSet;
            this.adventureWorksDataSetBindingSource.Position = 0;
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.radGridView1);
            this.radPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel2.Location = new System.Drawing.Point(0, 0);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(804, 541);
            this.radPanel2.TabIndex = 1;
            // 
            // radGridView1
            // 
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Location = new System.Drawing.Point(0, 0);
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(804, 541);
            this.radGridView1.TabIndex = 0;
            // 
            // radPanel1
            // 
            this.radPanel1.BackColor = System.Drawing.Color.White;
            this.radPanel1.Controls.Add(this.radButtonReport);
            this.radPanel1.Controls.Add(this.radComboBoxTables);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radPanel1.Location = new System.Drawing.Point(0, 541);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(804, 44);
            this.radPanel1.TabIndex = 0;
            // 
            // radButtonReport
            // 
            this.radButtonReport.BackColor = System.Drawing.Color.Transparent;
            this.radButtonReport.Location = new System.Drawing.Point(131, 8);
            this.radButtonReport.Name = "radButtonReport";
            this.radButtonReport.Size = new System.Drawing.Size(75, 26);
            this.radButtonReport.TabIndex = 1;
            this.radButtonReport.Text = "Report";
            this.radButtonReport.Click += new System.EventHandler(this.radButtonReport_Click);
            // 
            // radComboBoxTables
            // 
            this.radComboBoxTables.BackColor = System.Drawing.Color.WhiteSmoke;
            this.radComboBoxTables.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radComboBoxTables.Location = new System.Drawing.Point(12, 8);
            this.radComboBoxTables.Name = "radComboBoxTables";
            this.radComboBoxTables.NullText = "Select table";
            // 
            // 
            // 
            this.radComboBoxTables.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radComboBoxTables.Size = new System.Drawing.Size(102, 20);
            this.radComboBoxTables.TabIndex = 0;
            this.radComboBoxTables.SelectedValueChanged += new System.EventHandler(this.radComboBoxTables_SelectedValueChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 585);
            this.Controls.Add(this.radPanel2);
            this.Controls.Add(this.radPanel1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RadGridView Reporting";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorks_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            this.radPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboBoxTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.RadDropDownList radComboBoxTables;
        private System.Windows.Forms.BindingSource adventureWorksDataSetBindingSource;
        private ExampleApplication.DataBase.AdventureWorks_DataSet adventureWorks_DataSet;
        private Telerik.WinControls.UI.RadButton radButtonReport;
        private Telerik.WinControls.Themes.AquaTheme aquaTheme1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
    }
}

