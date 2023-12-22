namespace MedicalAppCS
{
    partial class MainForm
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
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn1 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Name");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn2 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Age");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn3 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 2", "Gender");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn4 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 3", "EncounterTime");
            Telerik.WinControls.UI.SchedulerDailyPrintStyle schedulerDailyPrintStyle1 = new Telerik.WinControls.UI.SchedulerDailyPrintStyle();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.mainPanel = new Telerik.WinControls.UI.RadPanel();
            this.radSplitButton1 = new Telerik.WinControls.UI.RadSplitButton();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            this.radLabelDoctorImage = new Telerik.WinControls.UI.RadLabel();
            this.radPanelButtonsContainer = new Telerik.WinControls.UI.RadPanel();
            this.chartsToggleButton = new Telerik.WinControls.UI.RadToggleButton();
            this.scheduleToggleButton = new Telerik.WinControls.UI.RadToggleButton();
            this.dashboardToggleButton = new Telerik.WinControls.UI.RadToggleButton();
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.radPageViewPageDashboard = new Telerik.WinControls.UI.RadPageViewPage();
            this.radListViewNextPatients = new Telerik.WinControls.UI.RadListView();
            this.radButtonNewAppointment = new Telerik.WinControls.UI.RadButton();
            this.radButtonRegisterNewPatient = new Telerik.WinControls.UI.RadButton();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.dashboardClockCalendarPanel = new Telerik.WinControls.UI.RadPanel();
            this.radCalendarDashboard = new Telerik.WinControls.UI.RadCalendar();
            this.radClock1 = new Telerik.WinControls.UI.RadClock();
            this.radPanelTomorrowAppointments = new Telerik.WinControls.UI.RadPanel();
            this.radLabelFirstAppointmentTomorrow = new Telerik.WinControls.UI.RadLabel();
            this.radLabel9 = new Telerik.WinControls.UI.RadLabel();
            this.radLabelTomorrowAppointmentsCount = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radPanelTodaysAppointments = new Telerik.WinControls.UI.RadPanel();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.radLabelLastAppointmentToday = new Telerik.WinControls.UI.RadLabel();
            this.radLabelTodayAppointmentsCount = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radPageViewPageSchedule = new Telerik.WinControls.UI.RadPageViewPage();
            this.radCalendarSchedule = new Telerik.WinControls.UI.RadCalendar();
            this.radButtonNewAppointmentScheduler = new Telerik.WinControls.UI.RadButton();
            this.radSchedulerNavigator1 = new Telerik.WinControls.UI.RadSchedulerNavigator();
            this.radScheduler1 = new Telerik.WinControls.UI.RadScheduler();
            this.radPageViewPageCharts = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.radButtonShowInfoCharts = new Telerik.WinControls.UI.RadButton();
            this.radListControl1 = new Telerik.WinControls.UI.RadListControl();
            this.radLabel11 = new Telerik.WinControls.UI.RadLabel();
            this.radLabelSelectedPatientAgeGenderCharts = new Telerik.WinControls.UI.RadLabel();
            this.radLabelSelectedPatientNameCharts = new Telerik.WinControls.UI.RadLabel();
            this.radLabelSelectedPatientImageCharts = new Telerik.WinControls.UI.RadLabel();
            this.radButtonRegisternewPatientCharts = new Telerik.WinControls.UI.RadButton();
            this.radGridViewPatients = new Telerik.WinControls.UI.RadGridView();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsDataSet = new MedicalAppCS.PatientsDataSet();
            this.appointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentsTableAdapter = new MedicalAppCS.PatientsDataSetTableAdapters.AppointmentsTableAdapter();
            this.conceptsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conceptsTableAdapter = new MedicalAppCS.PatientsDataSetTableAdapters.ConceptsTableAdapter();
            this.encountersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.encountersTableAdapter = new MedicalAppCS.PatientsDataSetTableAdapters.EncountersTableAdapter();
            this.personImagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personImagesTableAdapter = new MedicalAppCS.PatientsDataSetTableAdapters.PersonImagesTableAdapter();
            this.personsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personsTableAdapter = new MedicalAppCS.PatientsDataSetTableAdapters.PersonsTableAdapter();
            this.patientsTableAdapter = new MedicalAppCS.PatientsDataSetTableAdapters.PatientsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelDoctorImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelButtonsContainer)).BeginInit();
            this.radPanelButtonsContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartsToggleButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleToggleButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardToggleButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            this.radPageView1.SuspendLayout();
            this.radPageViewPageDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radListViewNextPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonNewAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonRegisterNewPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardClockCalendarPanel)).BeginInit();
            this.dashboardClockCalendarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCalendarDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radClock1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelTomorrowAppointments)).BeginInit();
            this.radPanelTomorrowAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelFirstAppointmentTomorrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelTomorrowAppointmentsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelTodaysAppointments)).BeginInit();
            this.radPanelTodaysAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelLastAppointmentToday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelTodayAppointmentsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            this.radPageViewPageSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCalendarSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonNewAppointmentScheduler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).BeginInit();
            this.radPageViewPageCharts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonShowInfoCharts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelSelectedPatientAgeGenderCharts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelSelectedPatientNameCharts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelSelectedPatientImageCharts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonRegisternewPatientCharts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewPatients.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conceptsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.encountersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personImagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.mainPanel.Controls.Add(this.radSplitButton1);
            this.mainPanel.Controls.Add(this.radLabelDoctorImage);
            this.mainPanel.Controls.Add(this.radPanelButtonsContainer);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1364, 89);
            this.mainPanel.TabIndex = 0;
            // 
            // radSplitButton1
            // 
            this.radSplitButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(139)))));
            this.radSplitButton1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1,
            this.radMenuItem2,
            this.radMenuItem3});
            this.radSplitButton1.Location = new System.Drawing.Point(427, 4);
            this.radSplitButton1.Name = "radSplitButton1";
            this.radSplitButton1.Size = new System.Drawing.Size(178, 38);
            this.radSplitButton1.TabIndex = 5;
            this.radSplitButton1.Text = "Dr. Jessica Roth";
            this.radSplitButton1.ThemeName = "MedicalAppTheme";
            this.radSplitButton1.DropDownOpening += new System.EventHandler(this.radSplitButton1_DropDownOpening);
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "Settings";
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "Profile";
            // 
            // radMenuItem3
            // 
            this.radMenuItem3.Name = "radMenuItem3";
            this.radMenuItem3.Text = "Log out";
            // 
            // radLabelDoctorImage
            // 
            this.radLabelDoctorImage.AutoSize = false;
            this.radLabelDoctorImage.Image = global::MedicalAppCS.Properties.Resources.doctor;
            this.radLabelDoctorImage.Location = new System.Drawing.Point(339, 3);
            this.radLabelDoctorImage.Name = "radLabelDoctorImage";
            this.radLabelDoctorImage.Size = new System.Drawing.Size(82, 82);
            this.radLabelDoctorImage.TabIndex = 3;
            // 
            // radPanelButtonsContainer
            // 
            this.radPanelButtonsContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(186)))), ((int)(((byte)(220)))));
            this.radPanelButtonsContainer.Controls.Add(this.chartsToggleButton);
            this.radPanelButtonsContainer.Controls.Add(this.scheduleToggleButton);
            this.radPanelButtonsContainer.Controls.Add(this.dashboardToggleButton);
            this.radPanelButtonsContainer.Location = new System.Drawing.Point(1, 4);
            this.radPanelButtonsContainer.Name = "radPanelButtonsContainer";
            this.radPanelButtonsContainer.Size = new System.Drawing.Size(258, 80);
            this.radPanelButtonsContainer.TabIndex = 2;
            // 
            // chartsToggleButton
            // 
            this.chartsToggleButton.Location = new System.Drawing.Point(178, -1);
            this.chartsToggleButton.Name = "chartsToggleButton";
            this.chartsToggleButton.Size = new System.Drawing.Size(81, 82);
            this.chartsToggleButton.TabIndex = 6;
            this.chartsToggleButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chartsToggleButton.ThemeName = "MedicalAppTheme";
            this.chartsToggleButton.Click += new System.EventHandler(this.chartsToggleButton_Click);
            // 
            // scheduleToggleButton
            // 
            this.scheduleToggleButton.Location = new System.Drawing.Point(99, -1);
            this.scheduleToggleButton.Name = "scheduleToggleButton";
            this.scheduleToggleButton.Size = new System.Drawing.Size(80, 82);
            this.scheduleToggleButton.TabIndex = 6;
            this.scheduleToggleButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.scheduleToggleButton.ThemeName = "MedicalAppTheme";
            this.scheduleToggleButton.Click += new System.EventHandler(this.scheduleToggleButton_Click);
            // 
            // dashboardToggleButton
            // 
            this.dashboardToggleButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dashboardToggleButton.Location = new System.Drawing.Point(20, -1);
            this.dashboardToggleButton.Name = "dashboardToggleButton";
            this.dashboardToggleButton.Size = new System.Drawing.Size(80, 82);
            this.dashboardToggleButton.TabIndex = 5;
            this.dashboardToggleButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dashboardToggleButton.ThemeName = "MedicalAppTheme";
            this.dashboardToggleButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.dashboardToggleButton.Click += new System.EventHandler(this.dashboardToggleButton_Click);
            // 
            // radPageView1
            // 
            this.radPageView1.Controls.Add(this.radPageViewPageDashboard);
            this.radPageView1.Controls.Add(this.radPageViewPageSchedule);
            this.radPageView1.Controls.Add(this.radPageViewPageCharts);
            this.radPageView1.DefaultPage = this.radPageViewPageDashboard;
            this.radPageView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPageView1.Location = new System.Drawing.Point(0, 89);
            this.radPageView1.Margin = new System.Windows.Forms.Padding(0);
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.SelectedPage = this.radPageViewPageDashboard;
            this.radPageView1.Size = new System.Drawing.Size(1364, 651);
            this.radPageView1.TabIndex = 1;
            this.radPageView1.Text = "radPageView1";
            this.radPageView1.ThemeName = "MedicalAppTheme";
            this.radPageView1.SelectedPageChanged += new System.EventHandler(this.radPageView1_SelectedPageChanged);
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).ShowItemCloseButton = true;
            // 
            // radPageViewPageDashboard
            // 
            this.radPageViewPageDashboard.Controls.Add(this.radListViewNextPatients);
            this.radPageViewPageDashboard.Controls.Add(this.radButtonNewAppointment);
            this.radPageViewPageDashboard.Controls.Add(this.radButtonRegisterNewPatient);
            this.radPageViewPageDashboard.Controls.Add(this.radLabel2);
            this.radPageViewPageDashboard.Controls.Add(this.radLabel1);
            this.radPageViewPageDashboard.Controls.Add(this.dashboardClockCalendarPanel);
            this.radPageViewPageDashboard.Controls.Add(this.radPanelTomorrowAppointments);
            this.radPageViewPageDashboard.Controls.Add(this.radPanelTodaysAppointments);
            this.radPageViewPageDashboard.ItemSize = new System.Drawing.SizeF(103F, 28F);
            this.radPageViewPageDashboard.Location = new System.Drawing.Point(10, 37);
            this.radPageViewPageDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.radPageViewPageDashboard.Name = "radPageViewPageDashboard";
            this.radPageViewPageDashboard.Size = new System.Drawing.Size(1343, 603);
            this.radPageViewPageDashboard.Text = "DASHBOARD";
            // 
            // radListViewNextPatients
            // 
            this.radListViewNextPatients.AllowArbitraryItemHeight = true;
            this.radListViewNextPatients.AllowEdit = false;
            this.radListViewNextPatients.AllowRemove = false;
            listViewDetailColumn1.HeaderText = "Name";
            listViewDetailColumn2.HeaderText = "Age";
            listViewDetailColumn3.HeaderText = "Gender";
            listViewDetailColumn4.HeaderText = "EncounterTime";
            this.radListViewNextPatients.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn1,
            listViewDetailColumn2,
            listViewDetailColumn3,
            listViewDetailColumn4});
            this.radListViewNextPatients.ItemSize = new System.Drawing.Size(200, 95);
            this.radListViewNextPatients.Location = new System.Drawing.Point(19, 87);
            this.radListViewNextPatients.Name = "radListViewNextPatients";
            this.radListViewNextPatients.SelectLastAddedItem = false;
            this.radListViewNextPatients.Size = new System.Drawing.Size(443, 303);
            this.radListViewNextPatients.TabIndex = 7;
            this.radListViewNextPatients.Text = "radListView1";
            this.radListViewNextPatients.ThemeName = "MedicalAppTheme";
            this.radListViewNextPatients.VerticalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysHide;
            this.radListViewNextPatients.VisualItemFormatting += new Telerik.WinControls.UI.ListViewVisualItemEventHandler(this.radListViewNextPatients_VisualItemFormatting);
            this.radListViewNextPatients.VisualItemCreating += new Telerik.WinControls.UI.ListViewVisualItemCreatingEventHandler(this.radListViewNextPatients_VisualItemCreating);
            this.radListViewNextPatients.DoubleClick += new System.EventHandler(this.radListViewNextPatients_DoubleClick);
            // 
            // radButtonNewAppointment
            // 
            this.radButtonNewAppointment.Location = new System.Drawing.Point(740, 27);
            this.radButtonNewAppointment.Name = "radButtonNewAppointment";
            this.radButtonNewAppointment.Size = new System.Drawing.Size(170, 33);
            this.radButtonNewAppointment.TabIndex = 6;
            this.radButtonNewAppointment.Text = "New appointment";
            this.radButtonNewAppointment.ThemeName = "MedicalAppTheme";
            this.radButtonNewAppointment.Click += new System.EventHandler(this.newAppointment_Click);
            // 
            // radButtonRegisterNewPatient
            // 
            this.radButtonRegisterNewPatient.Location = new System.Drawing.Point(288, 30);
            this.radButtonRegisterNewPatient.Name = "radButtonRegisterNewPatient";
            this.radButtonRegisterNewPatient.Size = new System.Drawing.Size(170, 33);
            this.radButtonRegisterNewPatient.TabIndex = 5;
            this.radButtonRegisterNewPatient.Text = "Register new patient";
            this.radButtonRegisterNewPatient.ThemeName = "MedicalAppTheme";
            this.radButtonRegisterNewPatient.Click += new System.EventHandler(this.registerNewPatient_Click);
            // 
            // radLabel2
            // 
            this.radLabel2.BackColor = System.Drawing.Color.Transparent;
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI Light", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(470, 20);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(121, 43);
            this.radLabel2.TabIndex = 4;
            this.radLabel2.Text = "Schedule";
            // 
            // radLabel1
            // 
            this.radLabel1.BackColor = System.Drawing.Color.Transparent;
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI Light", 24F);
            this.radLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(79)))));
            this.radLabel1.Location = new System.Drawing.Point(11, 20);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(181, 49);
            this.radLabel1.TabIndex = 3;
            this.radLabel1.Text = "Next patient";
            // 
            // dashboardClockCalendarPanel
            // 
            this.dashboardClockCalendarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(252)))), ((int)(((byte)(249)))));
            this.dashboardClockCalendarPanel.Controls.Add(this.radCalendarDashboard);
            this.dashboardClockCalendarPanel.Controls.Add(this.radClock1);
            this.dashboardClockCalendarPanel.Location = new System.Drawing.Point(930, 87);
            this.dashboardClockCalendarPanel.Name = "dashboardClockCalendarPanel";
            this.dashboardClockCalendarPanel.Size = new System.Drawing.Size(413, 303);
            this.dashboardClockCalendarPanel.TabIndex = 2;
            // 
            // radCalendarDashboard
            // 
            this.radCalendarDashboard.DayNameFormat = Telerik.WinControls.UI.DayNameFormat.FirstTwoLetters;
            this.radCalendarDashboard.Location = new System.Drawing.Point(193, 75);
            this.radCalendarDashboard.Name = "radCalendarDashboard";
            this.radCalendarDashboard.ShowFastNavigationButtons = false;
            this.radCalendarDashboard.ShowNavigationButtons = false;
            this.radCalendarDashboard.ShowRowHeaders = true;
            this.radCalendarDashboard.Size = new System.Drawing.Size(197, 180);
            this.radCalendarDashboard.TabIndex = 1;
            this.radCalendarDashboard.Text = "radCalendar2";
            this.radCalendarDashboard.ThemeName = "MedicalAppTheme";
            this.radCalendarDashboard.SelectionChanged += new System.EventHandler(this.radCalendarDashboard_SelectionChanged);
            // 
            // radClock1
            // 
            this.radClock1.Location = new System.Drawing.Point(20, 75);
            this.radClock1.Name = "radClock1";
            this.radClock1.Size = new System.Drawing.Size(134, 135);
            this.radClock1.TabIndex = 0;
            this.radClock1.Text = "radClock1";
            this.radClock1.ThemeName = "MedicalAppTheme";
            // 
            // radPanelTomorrowAppointments
            // 
            this.radPanelTomorrowAppointments.Controls.Add(this.radLabelFirstAppointmentTomorrow);
            this.radPanelTomorrowAppointments.Controls.Add(this.radLabel9);
            this.radPanelTomorrowAppointments.Controls.Add(this.radLabelTomorrowAppointmentsCount);
            this.radPanelTomorrowAppointments.Controls.Add(this.radLabel4);
            this.radPanelTomorrowAppointments.Location = new System.Drawing.Point(704, 87);
            this.radPanelTomorrowAppointments.Name = "radPanelTomorrowAppointments";
            this.radPanelTomorrowAppointments.Size = new System.Drawing.Size(206, 303);
            this.radPanelTomorrowAppointments.TabIndex = 1;
            this.radPanelTomorrowAppointments.ThemeName = "MedicalAppTheme";
            this.radPanelTomorrowAppointments.Click += new System.EventHandler(this.radPanelTomorrowAppointments_Click);
            // 
            // radLabelFirstAppointmentTomorrow
            // 
            this.radLabelFirstAppointmentTomorrow.BackColor = System.Drawing.Color.Transparent;
            this.radLabelFirstAppointmentTomorrow.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.radLabelFirstAppointmentTomorrow.Location = new System.Drawing.Point(14, 213);
            this.radLabelFirstAppointmentTomorrow.Name = "radLabelFirstAppointmentTomorrow";
            this.radLabelFirstAppointmentTomorrow.Size = new System.Drawing.Size(154, 26);
            this.radLabelFirstAppointmentTomorrow.TabIndex = 1;
            this.radLabelFirstAppointmentTomorrow.Text = "first one at 7:00 AM";
            this.radLabelFirstAppointmentTomorrow.Click += new System.EventHandler(this.radPanelTomorrowAppointments_Click);
            // 
            // radLabel9
            // 
            this.radLabel9.BackColor = System.Drawing.Color.Transparent;
            this.radLabel9.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.radLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(192)))));
            this.radLabel9.Location = new System.Drawing.Point(14, 175);
            this.radLabel9.Name = "radLabel9";
            this.radLabel9.Size = new System.Drawing.Size(128, 31);
            this.radLabel9.TabIndex = 1;
            this.radLabel9.Text = "appointments";
            this.radLabel9.Click += new System.EventHandler(this.radPanelTomorrowAppointments_Click);
            // 
            // radLabelTomorrowAppointmentsCount
            // 
            this.radLabelTomorrowAppointmentsCount.BackColor = System.Drawing.Color.Transparent;
            this.radLabelTomorrowAppointmentsCount.Font = new System.Drawing.Font("Segoe UI Light", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabelTomorrowAppointmentsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(192)))));
            this.radLabelTomorrowAppointmentsCount.Location = new System.Drawing.Point(1, 83);
            this.radLabelTomorrowAppointmentsCount.Name = "radLabelTomorrowAppointmentsCount";
            this.radLabelTomorrowAppointmentsCount.Size = new System.Drawing.Size(129, 108);
            this.radLabelTomorrowAppointmentsCount.TabIndex = 1;
            this.radLabelTomorrowAppointmentsCount.Text = "32";
            this.radLabelTomorrowAppointmentsCount.UseCompatibleTextRendering = false;
            this.radLabelTomorrowAppointmentsCount.Click += new System.EventHandler(this.radPanelTomorrowAppointments_Click);
            // 
            // radLabel4
            // 
            this.radLabel4.BackColor = System.Drawing.Color.Transparent;
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI Light", 14.5F);
            this.radLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(79)))));
            this.radLabel4.Location = new System.Drawing.Point(14, 12);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(121, 30);
            this.radLabel4.TabIndex = 1;
            this.radLabel4.Text = "TOMORROW";
            this.radLabel4.Click += new System.EventHandler(this.radPanelTomorrowAppointments_Click);
            // 
            // radPanelTodaysAppointments
            // 
            this.radPanelTodaysAppointments.Controls.Add(this.radLabel6);
            this.radPanelTodaysAppointments.Controls.Add(this.radLabelLastAppointmentToday);
            this.radPanelTodaysAppointments.Controls.Add(this.radLabelTodayAppointmentsCount);
            this.radPanelTodaysAppointments.Controls.Add(this.radLabel3);
            this.radPanelTodaysAppointments.Location = new System.Drawing.Point(478, 87);
            this.radPanelTodaysAppointments.Name = "radPanelTodaysAppointments";
            this.radPanelTodaysAppointments.Size = new System.Drawing.Size(206, 303);
            this.radPanelTodaysAppointments.TabIndex = 0;
            this.radPanelTodaysAppointments.ThemeName = "MedicalAppTheme";
            this.radPanelTodaysAppointments.Click += new System.EventHandler(this.radPanelTodaysAppointments_Click);
            // 
            // radLabel6
            // 
            this.radLabel6.BackColor = System.Drawing.Color.Transparent;
            this.radLabel6.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.radLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(192)))));
            this.radLabel6.Location = new System.Drawing.Point(14, 174);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(128, 31);
            this.radLabel6.TabIndex = 1;
            this.radLabel6.Text = "appointments";
            this.radLabel6.Click += new System.EventHandler(this.radPanelTodaysAppointments_Click);
            // 
            // radLabelLastAppointmentToday
            // 
            this.radLabelLastAppointmentToday.BackColor = System.Drawing.Color.Transparent;
            this.radLabelLastAppointmentToday.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.radLabelLastAppointmentToday.Location = new System.Drawing.Point(14, 213);
            this.radLabelLastAppointmentToday.Name = "radLabelLastAppointmentToday";
            this.radLabelLastAppointmentToday.Size = new System.Drawing.Size(150, 26);
            this.radLabelLastAppointmentToday.TabIndex = 1;
            this.radLabelLastAppointmentToday.Text = "last one at 5:00 PM";
            this.radLabelLastAppointmentToday.Click += new System.EventHandler(this.radPanelTodaysAppointments_Click);
            // 
            // radLabelTodayAppointmentsCount
            // 
            this.radLabelTodayAppointmentsCount.BackColor = System.Drawing.Color.Transparent;
            this.radLabelTodayAppointmentsCount.Font = new System.Drawing.Font("Segoe UI Light", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabelTodayAppointmentsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(192)))));
            this.radLabelTodayAppointmentsCount.Location = new System.Drawing.Point(1, 83);
            this.radLabelTodayAppointmentsCount.Name = "radLabelTodayAppointmentsCount";
            this.radLabelTodayAppointmentsCount.Size = new System.Drawing.Size(129, 108);
            this.radLabelTodayAppointmentsCount.TabIndex = 1;
            this.radLabelTodayAppointmentsCount.Text = "25";
            this.radLabelTodayAppointmentsCount.UseCompatibleTextRendering = false;
            this.radLabelTodayAppointmentsCount.Click += new System.EventHandler(this.radPanelTodaysAppointments_Click);
            // 
            // radLabel3
            // 
            this.radLabel3.BackColor = System.Drawing.Color.Transparent;
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI Light", 14.5F);
            this.radLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(79)))));
            this.radLabel3.Location = new System.Drawing.Point(14, 12);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(71, 30);
            this.radLabel3.TabIndex = 0;
            this.radLabel3.Text = "TODAY";
            this.radLabel3.Click += new System.EventHandler(this.radPanelTodaysAppointments_Click);
            // 
            // radPageViewPageSchedule
            // 
            this.radPageViewPageSchedule.Controls.Add(this.radCalendarSchedule);
            this.radPageViewPageSchedule.Controls.Add(this.radButtonNewAppointmentScheduler);
            this.radPageViewPageSchedule.Controls.Add(this.radSchedulerNavigator1);
            this.radPageViewPageSchedule.Controls.Add(this.radScheduler1);
            this.radPageViewPageSchedule.ItemSize = new System.Drawing.SizeF(90F, 28F);
            this.radPageViewPageSchedule.Location = new System.Drawing.Point(10, 37);
            this.radPageViewPageSchedule.Margin = new System.Windows.Forms.Padding(0);
            this.radPageViewPageSchedule.Name = "radPageViewPageSchedule";
            this.radPageViewPageSchedule.Padding = new System.Windows.Forms.Padding(15);
            this.radPageViewPageSchedule.Size = new System.Drawing.Size(1343, 603);
            this.radPageViewPageSchedule.Text = "SCHEDULE";
            // 
            // radCalendarSchedule
            // 
            this.radCalendarSchedule.DayNameFormat = Telerik.WinControls.UI.DayNameFormat.FirstTwoLetters;
            this.radCalendarSchedule.Location = new System.Drawing.Point(1046, 75);
            this.radCalendarSchedule.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.radCalendarSchedule.Name = "radCalendarSchedule";
            this.radCalendarSchedule.SelectedDates.AddRange(new System.DateTime[] {
            new System.DateTime(1900, 1, 1, 0, 0, 0, 0)});
            this.radCalendarSchedule.ShowRowHeaders = true;
            this.radCalendarSchedule.Size = new System.Drawing.Size(297, 243);
            this.radCalendarSchedule.TabIndex = 3;
            this.radCalendarSchedule.Text = "radCalendar1";
            this.radCalendarSchedule.ThemeName = "MedicalAppTheme";
            this.radCalendarSchedule.SelectionChanged += new System.EventHandler(this.radCalendarSchedule_SelectionChanged);
            // 
            // radButtonNewAppointmentScheduler
            // 
            this.radButtonNewAppointmentScheduler.Location = new System.Drawing.Point(1046, 15);
            this.radButtonNewAppointmentScheduler.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.radButtonNewAppointmentScheduler.Name = "radButtonNewAppointmentScheduler";
            this.radButtonNewAppointmentScheduler.Size = new System.Drawing.Size(297, 33);
            this.radButtonNewAppointmentScheduler.TabIndex = 2;
            this.radButtonNewAppointmentScheduler.Text = "New appointment";
            this.radButtonNewAppointmentScheduler.ThemeName = "MedicalAppTheme";
            this.radButtonNewAppointmentScheduler.Click += new System.EventHandler(this.newAppointment_Click);
            // 
            // radSchedulerNavigator1
            // 
            this.radSchedulerNavigator1.AssociatedScheduler = this.radScheduler1;
            this.radSchedulerNavigator1.DateFormat = "MMMM d, yyyy";
            this.radSchedulerNavigator1.Location = new System.Drawing.Point(19, 15);
            this.radSchedulerNavigator1.Margin = new System.Windows.Forms.Padding(0);
            this.radSchedulerNavigator1.Name = "radSchedulerNavigator1";
            this.radSchedulerNavigator1.NavigationStepType = Telerik.WinControls.UI.NavigationStepTypes.Day;
            // 
            // 
            // 
            this.radSchedulerNavigator1.RootElement.StretchVertically = false;
            this.radSchedulerNavigator1.Size = new System.Drawing.Size(1007, 77);
            this.radSchedulerNavigator1.TabIndex = 1;
            this.radSchedulerNavigator1.Text = "radSchedulerNavigator1";
            this.radSchedulerNavigator1.ThemeName = "MedicalAppTheme";
            this.radSchedulerNavigator1.DayViewClick += new System.EventHandler(this.DayViewButton_Click);
            // 
            // radScheduler1
            // 
            this.radScheduler1.ActiveViewType = Telerik.WinControls.UI.SchedulerViewType.MultiDay;
            this.radScheduler1.AllowAppointmentCreateInline = false;
            this.radScheduler1.AllowAppointmentMove = false;
            this.radScheduler1.AllowAppointmentResize = false;
            this.radScheduler1.AllowAppointmentsMultiSelect = true;
            this.radScheduler1.AllowCopyPaste = Telerik.WinControls.UI.CopyPasteMode.Disallow;
            this.radScheduler1.Culture = new System.Globalization.CultureInfo("en-US");
            this.radScheduler1.HeaderFormat = "dddd M\\/d";
            this.radScheduler1.Location = new System.Drawing.Point(19, 100);
            this.radScheduler1.Margin = new System.Windows.Forms.Padding(0);
            this.radScheduler1.Name = "radScheduler1";
            schedulerDailyPrintStyle1.AppointmentFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            schedulerDailyPrintStyle1.DateEndRange = new System.DateTime(2015, 8, 22, 0, 0, 0, 0);
            schedulerDailyPrintStyle1.DateHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            schedulerDailyPrintStyle1.DateStartRange = new System.DateTime(2015, 8, 17, 0, 0, 0, 0);
            schedulerDailyPrintStyle1.PageHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.radScheduler1.PrintStyle = schedulerDailyPrintStyle1;
            this.radScheduler1.Size = new System.Drawing.Size(1007, 488);
            this.radScheduler1.TabIndex = 0;
            this.radScheduler1.Text = "radScheduler1";
            this.radScheduler1.ThemeName = "MedicalAppTheme";
            this.radScheduler1.AppointmentDeleted += new System.EventHandler<Telerik.WinControls.UI.SchedulerAppointmentEventArgs>(this.radScheduler1_AppointmentDeleted);
            this.radScheduler1.DataBindingComplete += new System.EventHandler(this.radScheduler1_DataBindingComplete);
            this.radScheduler1.ContextMenuOpening += new Telerik.WinControls.UI.SchedulerContextMenuOpeningEventHandler(this.radScheduler1_ContextMenuOpening);
            this.radScheduler1.ActiveViewChanged += new System.EventHandler<Telerik.WinControls.UI.SchedulerViewChangedEventArgs>(this.radScheduler1_ActiveViewChanged);
            this.radScheduler1.AppointmentEditDialogShowing += new System.EventHandler<Telerik.WinControls.UI.AppointmentEditDialogShowingEventArgs>(this.radScheduler1_AppointmentEditDialogShowing);
            // 
            // radPageViewPageCharts
            // 
            this.radPageViewPageCharts.Controls.Add(this.radPanel2);
            this.radPageViewPageCharts.Controls.Add(this.radButtonRegisternewPatientCharts);
            this.radPageViewPageCharts.Controls.Add(this.radGridViewPatients);
            this.radPageViewPageCharts.ItemSize = new System.Drawing.SizeF(77F, 28F);
            this.radPageViewPageCharts.Location = new System.Drawing.Point(10, 37);
            this.radPageViewPageCharts.Margin = new System.Windows.Forms.Padding(0);
            this.radPageViewPageCharts.Name = "radPageViewPageCharts";
            this.radPageViewPageCharts.Padding = new System.Windows.Forms.Padding(15);
            this.radPageViewPageCharts.Size = new System.Drawing.Size(1343, 603);
            this.radPageViewPageCharts.Text = "CHARTS";
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.radButtonShowInfoCharts);
            this.radPanel2.Controls.Add(this.radListControl1);
            this.radPanel2.Controls.Add(this.radLabel11);
            this.radPanel2.Controls.Add(this.radLabelSelectedPatientAgeGenderCharts);
            this.radPanel2.Controls.Add(this.radLabelSelectedPatientNameCharts);
            this.radPanel2.Controls.Add(this.radLabelSelectedPatientImageCharts);
            this.radPanel2.Location = new System.Drawing.Point(1057, 58);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(286, 536);
            this.radPanel2.TabIndex = 2;
            this.radPanel2.ThemeName = "MedicalAppTheme";
            // 
            // radButtonShowInfoCharts
            // 
            this.radButtonShowInfoCharts.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.radButtonShowInfoCharts.Location = new System.Drawing.Point(138, 88);
            this.radButtonShowInfoCharts.Name = "radButtonShowInfoCharts";
            this.radButtonShowInfoCharts.Size = new System.Drawing.Size(92, 24);
            this.radButtonShowInfoCharts.TabIndex = 4;
            this.radButtonShowInfoCharts.Text = "Show info";
            this.radButtonShowInfoCharts.ThemeName = "MedicalAppTheme";
            this.radButtonShowInfoCharts.Click += new System.EventHandler(this.radButtonShowInfoCharts_Click);
            // 
            // radListControl1
            // 
            this.radListControl1.AutoSizeItems = true;
            this.radListControl1.Location = new System.Drawing.Point(13, 156);
            this.radListControl1.Name = "radListControl1";
            this.radListControl1.Size = new System.Drawing.Size(263, 366);
            this.radListControl1.TabIndex = 2;
            this.radListControl1.Text = "radListControl1";
            this.radListControl1.ThemeName = "MedicalAppTheme";
            // 
            // radLabel11
            // 
            this.radLabel11.BackColor = System.Drawing.Color.Transparent;
            this.radLabel11.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.radLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(4)))), ((int)(((byte)(69)))));
            this.radLabel11.Location = new System.Drawing.Point(13, 128);
            this.radLabel11.Name = "radLabel11";
            this.radLabel11.Size = new System.Drawing.Size(90, 22);
            this.radLabel11.TabIndex = 1;
            this.radLabel11.Text = "CONDITIONS";
            // 
            // radLabelSelectedPatientAgeGenderCharts
            // 
            this.radLabelSelectedPatientAgeGenderCharts.BackColor = System.Drawing.Color.Transparent;
            this.radLabelSelectedPatientAgeGenderCharts.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.radLabelSelectedPatientAgeGenderCharts.Location = new System.Drawing.Point(135, 52);
            this.radLabelSelectedPatientAgeGenderCharts.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.radLabelSelectedPatientAgeGenderCharts.Name = "radLabelSelectedPatientAgeGenderCharts";
            this.radLabelSelectedPatientAgeGenderCharts.Size = new System.Drawing.Size(82, 22);
            this.radLabelSelectedPatientAgeGenderCharts.TabIndex = 1;
            this.radLabelSelectedPatientAgeGenderCharts.Text = "28 yo | male";
            // 
            // radLabelSelectedPatientNameCharts
            // 
            this.radLabelSelectedPatientNameCharts.BackColor = System.Drawing.Color.Transparent;
            this.radLabelSelectedPatientNameCharts.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.radLabelSelectedPatientNameCharts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(192)))));
            this.radLabelSelectedPatientNameCharts.Location = new System.Drawing.Point(133, 8);
            this.radLabelSelectedPatientNameCharts.MaximumSize = new System.Drawing.Size(150, 0);
            this.radLabelSelectedPatientNameCharts.Name = "radLabelSelectedPatientNameCharts";
            // 
            // 
            // 
            this.radLabelSelectedPatientNameCharts.RootElement.MaxSize = new System.Drawing.Size(150, 0);
            this.radLabelSelectedPatientNameCharts.Size = new System.Drawing.Size(78, 26);
            this.radLabelSelectedPatientNameCharts.TabIndex = 1;
            this.radLabelSelectedPatientNameCharts.Text = "John Doe";
            // 
            // radLabelSelectedPatientImageCharts
            // 
            this.radLabelSelectedPatientImageCharts.AutoSize = false;
            this.radLabelSelectedPatientImageCharts.BackColor = System.Drawing.Color.Transparent;
            this.radLabelSelectedPatientImageCharts.Image = global::MedicalAppCS.Properties.Resources.no_image;
            this.radLabelSelectedPatientImageCharts.Location = new System.Drawing.Point(13, 8);
            this.radLabelSelectedPatientImageCharts.Name = "radLabelSelectedPatientImageCharts";
            this.radLabelSelectedPatientImageCharts.Size = new System.Drawing.Size(114, 114);
            this.radLabelSelectedPatientImageCharts.TabIndex = 0;
            // 
            // radButtonRegisternewPatientCharts
            // 
            this.radButtonRegisternewPatientCharts.Location = new System.Drawing.Point(1057, 19);
            this.radButtonRegisternewPatientCharts.Name = "radButtonRegisternewPatientCharts";
            this.radButtonRegisternewPatientCharts.Size = new System.Drawing.Size(286, 33);
            this.radButtonRegisternewPatientCharts.TabIndex = 1;
            this.radButtonRegisternewPatientCharts.Text = "Register new patient";
            this.radButtonRegisternewPatientCharts.ThemeName = "MedicalAppTheme";
            this.radButtonRegisternewPatientCharts.Click += new System.EventHandler(this.registerNewPatient_Click);
            // 
            // radGridViewPatients
            // 
            this.radGridViewPatients.Location = new System.Drawing.Point(19, 18);
            // 
            // 
            // 
            this.radGridViewPatients.MasterTemplate.AllowAddNewRow = false;
            this.radGridViewPatients.MasterTemplate.AllowEditRow = false;
            this.radGridViewPatients.MasterTemplate.AllowSearchRow = true;
            this.radGridViewPatients.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.FieldName = "Id";
            gridViewDecimalColumn1.HeaderText = "Id";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "Id";
            gridViewDecimalColumn1.Width = 143;
            gridViewTextBoxColumn1.FieldName = "First Name";
            gridViewTextBoxColumn1.HeaderText = "First Name";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "First Name";
            gridViewTextBoxColumn1.Width = 143;
            gridViewTextBoxColumn2.FieldName = "Last Name";
            gridViewTextBoxColumn2.HeaderText = "Last Name";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "Last Name";
            gridViewTextBoxColumn2.Width = 143;
            gridViewDecimalColumn2.DataType = typeof(double);
            gridViewDecimalColumn2.FieldName = "Age";
            gridViewDecimalColumn2.HeaderText = "Age";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "Age";
            gridViewDecimalColumn2.ReadOnly = true;
            gridViewDecimalColumn2.Width = 143;
            gridViewTextBoxColumn3.FieldName = "Sex";
            gridViewTextBoxColumn3.HeaderText = "Sex";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "Sex";
            gridViewTextBoxColumn3.Width = 143;
            gridViewDateTimeColumn1.CustomFormat = "";
            gridViewDateTimeColumn1.FieldName = "Date of Birth";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            gridViewDateTimeColumn1.FormatString = "{0:d-M-yyyy}";
            gridViewDateTimeColumn1.HeaderText = "Date of Birth";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "Date of Birth";
            gridViewDateTimeColumn1.Width = 143;
            gridViewDateTimeColumn2.CustomFormat = "";
            gridViewDateTimeColumn2.FieldName = "Last Visit";
            gridViewDateTimeColumn2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            gridViewDateTimeColumn2.FormatString = "{0:d-M-yyyy}";
            gridViewDateTimeColumn2.HeaderText = "Last Visit";
            gridViewDateTimeColumn2.IsAutoGenerated = true;
            gridViewDateTimeColumn2.Name = "Last Visit";
            gridViewDateTimeColumn2.ReadOnly = true;
            gridViewDateTimeColumn2.SortOrder = Telerik.WinControls.UI.RadSortOrder.Descending;
            gridViewDateTimeColumn2.Width = 146;
            this.radGridViewPatients.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewDecimalColumn2,
            gridViewTextBoxColumn3,
            gridViewDateTimeColumn1,
            gridViewDateTimeColumn2});
            this.radGridViewPatients.MasterTemplate.DataSource = this.patientsBindingSource;
            this.radGridViewPatients.MasterTemplate.EnableAlternatingRowColor = true;
            this.radGridViewPatients.MasterTemplate.EnableFiltering = true;
            this.radGridViewPatients.MasterTemplate.ShowFilteringRow = false;
            this.radGridViewPatients.MasterTemplate.ShowHeaderCellButtons = true;
            sortDescriptor1.Direction = System.ComponentModel.ListSortDirection.Descending;
            sortDescriptor1.PropertyName = "Last Visit";
            this.radGridViewPatients.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.radGridViewPatients.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridViewPatients.Name = "radGridViewPatients";
            this.radGridViewPatients.ShowHeaderCellButtons = true;
            this.radGridViewPatients.Size = new System.Drawing.Size(1018, 576);
            this.radGridViewPatients.TabIndex = 0;
            this.radGridViewPatients.Text = "radGridView1";
            this.radGridViewPatients.ThemeName = "MedicalAppTheme";
            this.radGridViewPatients.CurrentRowChanged += new Telerik.WinControls.UI.CurrentRowChangedEventHandler(this.radGridViewPatients_CurrentRowChanged);
            this.radGridViewPatients.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGridViewPatients_CellDoubleClick);
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.patientsDataSet;
            // 
            // patientsDataSet
            // 
            this.patientsDataSet.DataSetName = "PatientsDataSet";
            this.patientsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentsBindingSource
            // 
            this.appointmentsBindingSource.DataMember = "Appointments";
            this.appointmentsBindingSource.DataSource = this.patientsDataSet;
            // 
            // appointmentsTableAdapter
            // 
            this.appointmentsTableAdapter.ClearBeforeFill = true;
            // 
            // conceptsBindingSource
            // 
            this.conceptsBindingSource.DataMember = "Concepts";
            this.conceptsBindingSource.DataSource = this.patientsDataSet;
            // 
            // conceptsTableAdapter
            // 
            this.conceptsTableAdapter.ClearBeforeFill = true;
            // 
            // encountersBindingSource
            // 
            this.encountersBindingSource.DataMember = "Encounters";
            this.encountersBindingSource.DataSource = this.patientsDataSet;
            // 
            // encountersTableAdapter
            // 
            this.encountersTableAdapter.ClearBeforeFill = true;
            // 
            // personImagesBindingSource
            // 
            this.personImagesBindingSource.DataMember = "PersonImages";
            this.personImagesBindingSource.DataSource = this.patientsDataSet;
            // 
            // personImagesTableAdapter
            // 
            this.personImagesTableAdapter.ClearBeforeFill = true;
            // 
            // personsBindingSource
            // 
            this.personsBindingSource.DataMember = "Persons";
            this.personsBindingSource.DataSource = this.patientsDataSet;
            // 
            // personsTableAdapter
            // 
            this.personsTableAdapter.ClearBeforeFill = true;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 740);
            this.Controls.Add(this.radPageView1);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medical app";
            this.ThemeName = "MedicalAppTheme";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radSplitButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelDoctorImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelButtonsContainer)).EndInit();
            this.radPanelButtonsContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartsToggleButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleToggleButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardToggleButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            this.radPageView1.ResumeLayout(false);
            this.radPageViewPageDashboard.ResumeLayout(false);
            this.radPageViewPageDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radListViewNextPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonNewAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonRegisterNewPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardClockCalendarPanel)).EndInit();
            this.dashboardClockCalendarPanel.ResumeLayout(false);
            this.dashboardClockCalendarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCalendarDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radClock1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelTomorrowAppointments)).EndInit();
            this.radPanelTomorrowAppointments.ResumeLayout(false);
            this.radPanelTomorrowAppointments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelFirstAppointmentTomorrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelTomorrowAppointmentsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelTodaysAppointments)).EndInit();
            this.radPanelTodaysAppointments.ResumeLayout(false);
            this.radPanelTodaysAppointments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelLastAppointmentToday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelTodayAppointmentsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            this.radPageViewPageSchedule.ResumeLayout(false);
            this.radPageViewPageSchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCalendarSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonNewAppointmentScheduler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerNavigator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).EndInit();
            this.radPageViewPageCharts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            this.radPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonShowInfoCharts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelSelectedPatientAgeGenderCharts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelSelectedPatientNameCharts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelSelectedPatientImageCharts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonRegisternewPatientCharts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewPatients.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conceptsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.encountersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personImagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel mainPanel;
        private Telerik.WinControls.UI.RadPageView radPageView1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPageDashboard;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPageSchedule;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPageCharts;
        private Telerik.WinControls.UI.RadSchedulerNavigator radSchedulerNavigator1;
        private Telerik.WinControls.UI.RadScheduler radScheduler1;
        private Telerik.WinControls.UI.RadButton radButtonNewAppointmentScheduler;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.RadButton radButtonRegisternewPatientCharts;
        private Telerik.WinControls.UI.RadGridView radGridViewPatients;
        private Telerik.WinControls.UI.RadPanel radPanelButtonsContainer;
        private Telerik.WinControls.UI.RadLabel radLabelDoctorImage;
        private Telerik.WinControls.UI.RadSplitButton radSplitButton1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
        private Telerik.WinControls.UI.RadListView radListViewNextPatients;
        private Telerik.WinControls.UI.RadButton radButtonNewAppointment;
        private Telerik.WinControls.UI.RadButton radButtonRegisterNewPatient;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadPanel dashboardClockCalendarPanel;
        private Telerik.WinControls.UI.RadPanel radPanelTomorrowAppointments;
        private Telerik.WinControls.UI.RadPanel radPanelTodaysAppointments;
        private Telerik.WinControls.UI.RadCalendar radCalendarDashboard;
        private Telerik.WinControls.UI.RadClock radClock1;
        private Telerik.WinControls.UI.RadLabel radLabelFirstAppointmentTomorrow;
        private Telerik.WinControls.UI.RadLabel radLabel9;
        private Telerik.WinControls.UI.RadLabel radLabelTomorrowAppointmentsCount;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabelLastAppointmentToday;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadLabel radLabelTodayAppointmentsCount;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadCalendar radCalendarSchedule;
        private Telerik.WinControls.UI.RadLabel radLabelSelectedPatientAgeGenderCharts;
        private Telerik.WinControls.UI.RadLabel radLabelSelectedPatientNameCharts;
        private Telerik.WinControls.UI.RadLabel radLabelSelectedPatientImageCharts;
        private Telerik.WinControls.UI.RadListControl radListControl1;
        private Telerik.WinControls.UI.RadLabel radLabel11;
        private Telerik.WinControls.UI.RadButton radButtonShowInfoCharts;
        private Telerik.WinControls.UI.RadToggleButton chartsToggleButton;
        private Telerik.WinControls.UI.RadToggleButton scheduleToggleButton;
        private Telerik.WinControls.UI.RadToggleButton dashboardToggleButton;
        private PatientsDataSet patientsDataSet;
        private System.Windows.Forms.BindingSource appointmentsBindingSource;
        private PatientsDataSetTableAdapters.AppointmentsTableAdapter appointmentsTableAdapter;
        private System.Windows.Forms.BindingSource conceptsBindingSource;
        private PatientsDataSetTableAdapters.ConceptsTableAdapter conceptsTableAdapter;
        private System.Windows.Forms.BindingSource encountersBindingSource;
        private PatientsDataSetTableAdapters.EncountersTableAdapter encountersTableAdapter;
        private System.Windows.Forms.BindingSource personImagesBindingSource;
        private PatientsDataSetTableAdapters.PersonImagesTableAdapter personImagesTableAdapter;
        private System.Windows.Forms.BindingSource personsBindingSource;
        private PatientsDataSetTableAdapters.PersonsTableAdapter personsTableAdapter;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private PatientsDataSetTableAdapters.PatientsTableAdapter patientsTableAdapter;
    }
}

