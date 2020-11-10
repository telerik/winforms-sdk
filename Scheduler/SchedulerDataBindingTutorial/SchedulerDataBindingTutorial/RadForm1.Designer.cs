namespace SchedulerDataBindingTutorial
{
    partial class RadForm1
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
            Telerik.WinControls.UI.SchedulerDailyPrintStyle schedulerDailyPrintStyle1 = new Telerik.WinControls.UI.SchedulerDailyPrintStyle();
            Telerik.WinControls.UI.AppointmentMappingInfo appointmentMappingInfo1 = new Telerik.WinControls.UI.AppointmentMappingInfo();
            Telerik.WinControls.UI.ResourceMappingInfo resourceMappingInfo1 = new Telerik.WinControls.UI.ResourceMappingInfo();
            this.radScheduler1 = new Telerik.WinControls.UI.RadScheduler();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.schedulerBindingDataSource1 = new Telerik.WinControls.UI.SchedulerBindingDataSource();
            this.resourcesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schedulerDataDataSet = new SchedulerDataBindingTutorial.SchedulerDataDataSet();
            this.appointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentsTableAdapter = new SchedulerDataBindingTutorial.SchedulerDataDataSetTableAdapters.AppointmentsTableAdapter();
            this.appointmentsResourcesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentsResourcesTableAdapter = new SchedulerDataBindingTutorial.SchedulerDataDataSetTableAdapters.AppointmentsResourcesTableAdapter();
            this.resourcesTableAdapter = new SchedulerDataBindingTutorial.SchedulerDataDataSetTableAdapters.ResourcesTableAdapter();
            this.fluentDarkTheme1 = new Telerik.WinControls.Themes.FluentDarkTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingDataSource1.EventProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingDataSource1.ResourceProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsResourcesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radScheduler1
            // 
            this.radScheduler1.Culture = new System.Globalization.CultureInfo("en-US");
            this.radScheduler1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radScheduler1.Location = new System.Drawing.Point(0, 24);
            this.radScheduler1.Name = "radScheduler1";
            schedulerDailyPrintStyle1.AppointmentFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            schedulerDailyPrintStyle1.DateEndRange = new System.DateTime(2020, 11, 14, 0, 0, 0, 0);
            schedulerDailyPrintStyle1.DateHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            schedulerDailyPrintStyle1.DateStartRange = new System.DateTime(2020, 11, 9, 0, 0, 0, 0);
            schedulerDailyPrintStyle1.PageHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.radScheduler1.PrintStyle = schedulerDailyPrintStyle1;
            this.radScheduler1.Size = new System.Drawing.Size(629, 586);
            this.radScheduler1.TabIndex = 0;
            this.radScheduler1.ThemeName = "FluentDark";
            // 
            // radButton1
            // 
            this.radButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radButton1.Location = new System.Drawing.Point(0, 0);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(629, 24);
            this.radButton1.TabIndex = 0;
            this.radButton1.Text = "Save";
            this.radButton1.ThemeName = "FluentDark";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // schedulerBindingDataSource1
            // 
            // 
            // 
            // 
            this.schedulerBindingDataSource1.EventProvider.DataSource = this.resourcesBindingSource;
            this.schedulerBindingDataSource1.EventProvider.Mapping = appointmentMappingInfo1;
            // 
            // 
            // 
            this.schedulerBindingDataSource1.ResourceProvider.Mapping = resourceMappingInfo1;
            // 
            // resourcesBindingSource
            // 
            this.resourcesBindingSource.DataMember = "Resources";
            this.resourcesBindingSource.DataSource = this.schedulerDataDataSet;
            // 
            // schedulerDataDataSet
            // 
            this.schedulerDataDataSet.DataSetName = "SchedulerDataDataSet";
            this.schedulerDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentsBindingSource
            // 
            this.appointmentsBindingSource.DataMember = "Appointments";
            this.appointmentsBindingSource.DataSource = this.schedulerDataDataSet;
            // 
            // appointmentsTableAdapter
            // 
            this.appointmentsTableAdapter.ClearBeforeFill = true;
            // 
            // appointmentsResourcesBindingSource
            // 
            this.appointmentsResourcesBindingSource.DataMember = "AppointmentsResources";
            this.appointmentsResourcesBindingSource.DataSource = this.schedulerDataDataSet;
            // 
            // appointmentsResourcesTableAdapter
            // 
            this.appointmentsResourcesTableAdapter.ClearBeforeFill = true;
            // 
            // resourcesTableAdapter
            // 
            this.resourcesTableAdapter.ClearBeforeFill = true;
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 610);
            this.Controls.Add(this.radScheduler1);
            this.Controls.Add(this.radButton1);
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "RadForm1";
            this.ThemeName = "FluentDark";
            this.Load += new System.EventHandler(this.RadForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingDataSource1.EventProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingDataSource1.ResourceProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsResourcesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadScheduler radScheduler1;
        private Telerik.WinControls.UI.SchedulerBindingDataSource schedulerBindingDataSource1;
        private SchedulerDataDataSet schedulerDataDataSet;
        private System.Windows.Forms.BindingSource appointmentsBindingSource;
        private SchedulerDataDataSetTableAdapters.AppointmentsTableAdapter appointmentsTableAdapter;
        private System.Windows.Forms.BindingSource appointmentsResourcesBindingSource;
        private SchedulerDataDataSetTableAdapters.AppointmentsResourcesTableAdapter appointmentsResourcesTableAdapter;
        private System.Windows.Forms.BindingSource resourcesBindingSource;
        private SchedulerDataDataSetTableAdapters.ResourcesTableAdapter resourcesTableAdapter;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.Themes.FluentDarkTheme fluentDarkTheme1;
    }
}