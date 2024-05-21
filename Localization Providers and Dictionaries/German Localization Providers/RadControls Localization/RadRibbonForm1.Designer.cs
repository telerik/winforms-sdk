using System;
using Telerik.WinControls.UI;

namespace GermanRadControlsLocalization
{
    partial class RadRibbonForm1
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
            if ( disposing )
            {
                this.initialTimer.Dispose();
                this.radSchedulerReminder1.AlarmFormShowing -= new EventHandler<RadAlarmFormShowingEventArgs>( radSchedulerReminder1_ShowingAlarmForm );
                this.radSchedulerReminder1.Dispose();

                if ( components != null )
                {
                    components.Dispose();
                }
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
			Telerik.WinControls.UI.Docking.AutoHideGroup autoHideGroup1 = new Telerik.WinControls.UI.Docking.AutoHideGroup();
			Telerik.WinControls.UI.Docking.AutoHideGroup autoHideGroup2 = new Telerik.WinControls.UI.Docking.AutoHideGroup();
			Telerik.WinControls.UI.DateTimeInterval dateTimeInterval1 = new Telerik.WinControls.UI.DateTimeInterval();
			Telerik.WinControls.UI.SchedulerDailyPrintStyle schedulerDailyPrintStyle1 = new Telerik.WinControls.UI.SchedulerDailyPrintStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadRibbonForm1));
			Telerik.WinControls.UI.DateTimeInterval dateTimeInterval2 = new Telerik.WinControls.UI.DateTimeInterval();
			Telerik.WinControls.UI.SchedulerDailyPrintStyle schedulerDailyPrintStyle2 = new Telerik.WinControls.UI.SchedulerDailyPrintStyle();
			this.dockWindowPlaceholder2 = new Telerik.WinControls.UI.Docking.DockWindowPlaceholder();
			this.dockWindowPlaceholder1 = new Telerik.WinControls.UI.Docking.DockWindowPlaceholder();
			this.radRibbonBar1 = new Telerik.WinControls.UI.RadRibbonBar();
			this.ribbonTab1 = new Telerik.WinControls.UI.RibbonTab();
			this.radRibbonBarGroup1 = new Telerik.WinControls.UI.RadRibbonBarGroup();
			this.radButtonElement2 = new Telerik.WinControls.UI.RadButtonElement();
			this.radButtonElement1 = new Telerik.WinControls.UI.RadButtonElement();
			this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
			this.panel1 = new System.Windows.Forms.Panel();
			this.radDock1 = new Telerik.WinControls.UI.Docking.RadDock();
			this.documentWindow2 = new Telerik.WinControls.UI.Docking.DocumentWindow();
			this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
			this.radPageViewPage1 = new Telerik.WinControls.UI.RadPageViewPage();
			this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
			this.radPageViewPage2 = new Telerik.WinControls.UI.RadPageViewPage();
			this.radTreeView1 = new Telerik.WinControls.UI.RadTreeView();
			this.radPageViewPage3 = new Telerik.WinControls.UI.RadPageViewPage();
			this.radCalendar1 = new Telerik.WinControls.UI.RadCalendar();
			this.radPageViewPage4 = new Telerik.WinControls.UI.RadPageViewPage();
			this.radDateTimePicker1 = new Telerik.WinControls.UI.RadDateTimePicker();
			this.radPageViewPage5 = new Telerik.WinControls.UI.RadPageViewPage();
			this.radPropertyGrid1 = new Telerik.WinControls.UI.RadPropertyGrid();
			this.radPageViewPage6 = new Telerik.WinControls.UI.RadPageViewPage();
			this.radButton3 = new Telerik.WinControls.UI.RadButton();
			this.radButton2 = new Telerik.WinControls.UI.RadButton();
			this.radButton1 = new Telerik.WinControls.UI.RadButton();
			this.radPageViewPage7 = new Telerik.WinControls.UI.RadPageViewPage();
			this.radSchedulerNavigator1 = new Telerik.WinControls.UI.RadSchedulerNavigator();
			this.radScheduler1 = new Telerik.WinControls.UI.RadScheduler();
			this.radCalendar2 = new Telerik.WinControls.UI.RadCalendar();
			this.radDropDownList1 = new Telerik.WinControls.UI.RadDropDownList();
			this.radButton4 = new Telerik.WinControls.UI.RadButton();
			this.radPageViewPage8 = new Telerik.WinControls.UI.RadPageViewPage();
			this.radButton6 = new Telerik.WinControls.UI.RadButton();
			this.radPageViewPage9 = new Telerik.WinControls.UI.RadPageViewPage();
			this.radCommandBar1 = new Telerik.WinControls.UI.RadCommandBar();
			this.commandBarRowElement1 = new Telerik.WinControls.UI.CommandBarRowElement();
			this.commandBarStripElement1 = new Telerik.WinControls.UI.CommandBarStripElement();
			this.commandBarButton1 = new Telerik.WinControls.UI.CommandBarButton();
			this.commandBarLabel1 = new Telerik.WinControls.UI.CommandBarLabel();
			this.commandBarTextBox1 = new Telerik.WinControls.UI.CommandBarTextBox();
			this.commandBarStripElement2 = new Telerik.WinControls.UI.CommandBarStripElement();
			this.commandBarDropDownButton1 = new Telerik.WinControls.UI.CommandBarDropDownButton();
			this.commandBarToggleButton1 = new Telerik.WinControls.UI.CommandBarToggleButton();
			this.commandBarSeparator1 = new Telerik.WinControls.UI.CommandBarSeparator();
			this.commandBarToggleButton2 = new Telerik.WinControls.UI.CommandBarToggleButton();
			this.radPageViewPage10 = new Telerik.WinControls.UI.RadPageViewPage();
			this.radButton5 = new Telerik.WinControls.UI.RadButton();
			this.radPageViewPage11 = new Telerik.WinControls.UI.RadPageViewPage();
			this.radWizard1 = new Telerik.WinControls.UI.RadWizard();
			this.wizardCompletionPage1 = new Telerik.WinControls.UI.WizardCompletionPage();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.wizardWelcomePage1 = new Telerik.WinControls.UI.WizardWelcomePage();
			this.wizardPage1 = new Telerik.WinControls.UI.WizardPage();
			this.radPageViewPage12 = new Telerik.WinControls.UI.RadPageViewPage();
			this.radTimePicker2 = new Telerik.WinControls.UI.RadTimePicker();
			this.RadGridViewPrinting = new Telerik.WinControls.UI.RadPageViewPage();
			this.buttonGridViewPrintPreview = new Telerik.WinControls.UI.RadButton();
			this.buttonGridViewPrintSettings = new Telerik.WinControls.UI.RadButton();
			this.GridViewPrinting = new Telerik.WinControls.UI.RadGridView();
			this.SchedulerPrinting = new Telerik.WinControls.UI.RadPageViewPage();
			this.radScheduler2 = new Telerik.WinControls.UI.RadScheduler();
			this.radSchedulerNavigator2 = new Telerik.WinControls.UI.RadSchedulerNavigator();
			this.ButtonSchedulerPrintingPrintPreview = new Telerik.WinControls.UI.RadButton();
			this.ButtonSchedulerPrintingPrintSettings = new Telerik.WinControls.UI.RadButton();
			this.radPageViewPage13 = new Telerik.WinControls.UI.RadPageViewPage();
			this.radButtonSpellChecker = new Telerik.WinControls.UI.RadButton();
			this.radTextBoxSpellChecker = new Telerik.WinControls.UI.RadTextBox();
			this.radPageViewPage14 = new Telerik.WinControls.UI.RadPageViewPage();
			this.toolTabStrip1 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
			this.toolWindow1 = new Telerik.WinControls.UI.Docking.ToolWindow();
			this.radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
			this.documentContainer1 = new Telerik.WinControls.UI.Docking.DocumentContainer();
			this.documentTabStrip1 = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
			this.documentWindow1 = new Telerik.WinControls.UI.Docking.DocumentWindow();
			this.toolTabStrip2 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
			this.toolWindow2 = new Telerik.WinControls.UI.Docking.ToolWindow();
			this.radDesktopAlert1 = new Telerik.WinControls.UI.RadDesktopAlert(this.components);
			this.radSchedulerReminder1 = new Telerik.WinControls.UI.RadSchedulerReminder(this.components);
			this.radMarkupDialog1 = new Telerik.WinControls.UI.RadMarkupDialog();
			this.radSpellChecker1 = new Telerik.WinControls.UI.RadSpellChecker();
			this.radTextBoxControl1 = new Telerik.WinControls.UI.RadTextBoxControl();
			this.ButtonSearch = new Telerik.WinControls.UI.RadButton();
			((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.radDock1)).BeginInit();
			this.radDock1.SuspendLayout();
			this.documentWindow2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
			this.radPageView1.SuspendLayout();
			this.radPageViewPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
			this.radPageViewPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).BeginInit();
			this.radPageViewPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.radCalendar1)).BeginInit();
			this.radPageViewPage4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).BeginInit();
			this.radPageViewPage5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.radPropertyGrid1)).BeginInit();
			this.radPageViewPage6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.radButton3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
			this.radPageViewPage7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.radSchedulerNavigator1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radCalendar2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton4)).BeginInit();
			this.radPageViewPage8.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.radButton6)).BeginInit();
			this.radPageViewPage9.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).BeginInit();
			this.radPageViewPage10.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.radButton5)).BeginInit();
			this.radPageViewPage11.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.radWizard1)).BeginInit();
			this.radWizard1.SuspendLayout();
			this.radPageViewPage12.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.radTimePicker2)).BeginInit();
			this.RadGridViewPrinting.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.buttonGridViewPrintPreview)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.buttonGridViewPrintSettings)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GridViewPrinting)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GridViewPrinting.MasterTemplate)).BeginInit();
			this.SchedulerPrinting.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.radScheduler2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radSchedulerNavigator2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ButtonSchedulerPrintingPrintPreview)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ButtonSchedulerPrintingPrintSettings)).BeginInit();
			this.radPageViewPage13.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.radButtonSpellChecker)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.radTextBoxSpellChecker)).BeginInit();
			this.radPageViewPage14.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.toolTabStrip1)).BeginInit();
			this.toolTabStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
			this.radSplitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.documentContainer1)).BeginInit();
			this.documentContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.documentTabStrip1)).BeginInit();
			this.documentTabStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.toolTabStrip2)).BeginInit();
			this.toolTabStrip2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.radTextBoxControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ButtonSearch)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			this.SuspendLayout();
			// 
			// dockWindowPlaceholder2
			// 
			this.dockWindowPlaceholder2.DockWindowName = "toolWindow1";
			this.dockWindowPlaceholder2.DockWindowText = "toolWindow1";
			this.dockWindowPlaceholder2.Location = new System.Drawing.Point(0, 0);
			this.dockWindowPlaceholder2.Name = "dockWindowPlaceholder2";
			this.dockWindowPlaceholder2.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
			this.dockWindowPlaceholder2.Size = new System.Drawing.Size(200, 200);
			this.dockWindowPlaceholder2.Text = "dockWindowPlaceholder2";
			// 
			// dockWindowPlaceholder1
			// 
			this.dockWindowPlaceholder1.DockWindowName = "toolWindow2";
			this.dockWindowPlaceholder1.DockWindowText = "toolWindow2";
			this.dockWindowPlaceholder1.Location = new System.Drawing.Point(0, 0);
			this.dockWindowPlaceholder1.Name = "dockWindowPlaceholder1";
			this.dockWindowPlaceholder1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
			this.dockWindowPlaceholder1.Size = new System.Drawing.Size(200, 200);
			this.dockWindowPlaceholder1.Text = "dockWindowPlaceholder1";
			// 
			// radRibbonBar1
			// 
			this.radRibbonBar1.CommandTabs.AddRange(new Telerik.WinControls.RadItem[] {
            this.ribbonTab1});
			this.radRibbonBar1.Location = new System.Drawing.Point(0, 0);
			this.radRibbonBar1.Name = "radRibbonBar1";
			// 
			// 
			// 
			this.radRibbonBar1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
			this.radRibbonBar1.Size = new System.Drawing.Size(1292, 158);
			this.radRibbonBar1.TabIndex = 0;
			this.radRibbonBar1.Text = "RadRibbonForm1";
			// 
			// ribbonTab1
			// 
			this.ribbonTab1.AccessibleDescription = "Tab1";
			this.ribbonTab1.AccessibleName = "Tab1";
			this.ribbonTab1.IsSelected = true;
			this.ribbonTab1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup1});
			this.ribbonTab1.Name = "ribbonTab1";
			this.ribbonTab1.Text = "Tab1";
			this.ribbonTab1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			// 
			// radRibbonBarGroup1
			// 
			this.radRibbonBarGroup1.AccessibleDescription = " Group1";
			this.radRibbonBarGroup1.AccessibleName = " Group1";
			this.radRibbonBarGroup1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement2,
            this.radButtonElement1});
			this.radRibbonBarGroup1.Name = "radRibbonBarGroup1";
			this.radRibbonBarGroup1.Text = " Change Language";
			this.radRibbonBarGroup1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			// 
			// radButtonElement2
			// 
			this.radButtonElement2.AccessibleDescription = "English";
			this.radButtonElement2.AccessibleName = "English";
			this.radButtonElement2.DisplayStyle = Telerik.WinControls.DisplayStyle.Text;
			this.radButtonElement2.Name = "radButtonElement2";
			this.radButtonElement2.Text = "English";
			this.radButtonElement2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			this.radButtonElement2.Click += new System.EventHandler(this.radButtonElement2_Click);
			// 
			// radButtonElement1
			// 
			this.radButtonElement1.AccessibleDescription = "German";
			this.radButtonElement1.AccessibleName = "German";
			this.radButtonElement1.DisplayStyle = Telerik.WinControls.DisplayStyle.Text;
			this.radButtonElement1.Name = "radButtonElement1";
			this.radButtonElement1.Text = "German";
			this.radButtonElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			this.radButtonElement1.Click += new System.EventHandler(this.radButtonElement1_Click);
			// 
			// radStatusStrip1
			// 
			this.radStatusStrip1.Location = new System.Drawing.Point(0, 871);
			this.radStatusStrip1.Name = "radStatusStrip1";
			this.radStatusStrip1.Size = new System.Drawing.Size(1292, 24);
			this.radStatusStrip1.SizingGrip = false;
			this.radStatusStrip1.TabIndex = 1;
			this.radStatusStrip1.Text = "radStatusStrip1";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.radDock1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 158);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1292, 713);
			this.panel1.TabIndex = 2;
			// 
			// radDock1
			// 
			this.radDock1.ActiveWindow = this.documentWindow2;
			this.radDock1.CausesValidation = false;
			this.radDock1.Controls.Add(this.toolTabStrip1);
			this.radDock1.Controls.Add(this.radSplitContainer1);
			this.radDock1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.radDock1.IsCleanUpTarget = true;
			this.radDock1.Location = new System.Drawing.Point(0, 0);
			this.radDock1.MainDocumentContainer = this.documentContainer1;
			this.radDock1.Name = "radDock1";
			// 
			// 
			// 
			this.radDock1.RootElement.MinSize = new System.Drawing.Size(25, 25);
			this.radDock1.RootElement.Padding = new System.Windows.Forms.Padding(5);
			autoHideGroup1.Windows.Add(this.dockWindowPlaceholder2);
			this.radDock1.SerializableAutoHideContainer.BottomAutoHideGroups.Add(autoHideGroup1);
			autoHideGroup2.Windows.Add(this.dockWindowPlaceholder1);
			this.radDock1.SerializableAutoHideContainer.LeftAutoHideGroups.Add(autoHideGroup2);
			this.radDock1.Size = new System.Drawing.Size(1292, 713);
			this.radDock1.TabIndex = 0;
			this.radDock1.TabStop = false;
			this.radDock1.Text = "radDock1";
			// 
			// documentWindow2
			// 
			this.documentWindow2.Controls.Add(this.radPageView1);
			this.documentWindow2.Location = new System.Drawing.Point(6, 29);
			this.documentWindow2.Name = "documentWindow2";
			this.documentWindow2.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument;
			this.documentWindow2.Size = new System.Drawing.Size(1175, 597);
			this.documentWindow2.Text = "documentWindow1";
			// 
			// radPageView1
			// 
			this.radPageView1.Controls.Add(this.radPageViewPage1);
			this.radPageView1.Controls.Add(this.radPageViewPage2);
			this.radPageView1.Controls.Add(this.radPageViewPage3);
			this.radPageView1.Controls.Add(this.radPageViewPage4);
			this.radPageView1.Controls.Add(this.radPageViewPage5);
			this.radPageView1.Controls.Add(this.radPageViewPage6);
			this.radPageView1.Controls.Add(this.radPageViewPage7);
			this.radPageView1.Controls.Add(this.radPageViewPage8);
			this.radPageView1.Controls.Add(this.radPageViewPage9);
			this.radPageView1.Controls.Add(this.radPageViewPage10);
			this.radPageView1.Controls.Add(this.radPageViewPage11);
			this.radPageView1.Controls.Add(this.radPageViewPage12);
			this.radPageView1.Controls.Add(this.RadGridViewPrinting);
			this.radPageView1.Controls.Add(this.SchedulerPrinting);
			this.radPageView1.Controls.Add(this.radPageViewPage13);
			this.radPageView1.Controls.Add(this.radPageViewPage14);
			this.radPageView1.Location = new System.Drawing.Point(3, 3);
			this.radPageView1.Name = "radPageView1";
			this.radPageView1.SelectedPage = this.radPageViewPage14;
			this.radPageView1.Size = new System.Drawing.Size(1200, 653);
			this.radPageView1.TabIndex = 0;
			this.radPageView1.Text = "radPageView1";
			// 
			// radPageViewPage1
			// 
// TODO: Beim Generieren des Codes für "			this.radPageViewPage1.Context" ist die Ausnahme "Ungültiger primitiver Typ: System.IntPtr. Verwenden Sie CodeObjectCreateExpression." aufgetreten.
			this.radPageViewPage1.Controls.Add(this.radGridView1);
			this.radPageViewPage1.Location = new System.Drawing.Point(10, 37);
			this.radPageViewPage1.Name = "radPageViewPage1";
			this.radPageViewPage1.Size = new System.Drawing.Size(1179, 605);
			this.radPageViewPage1.Text = "RadGridView";
			// 
			// radGridView1
			// 
			this.radGridView1.ForeColor = System.Drawing.Color.Black;
			this.radGridView1.Location = new System.Drawing.Point(3, 29);
			// 
			// radGridView1
			// 
			this.radGridView1.MasterTemplate.AllowColumnChooser = false;
			this.radGridView1.MasterTemplate.AutoGenerateColumns = false;
			this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
			this.radGridView1.MasterTemplate.Caption = null;
			this.radGridView1.MasterTemplate.MultiSelect = true;
			this.radGridView1.MasterTemplate.ShowGroupedColumns = true;
			this.radGridView1.Name = "radGridView1";
			this.radGridView1.Size = new System.Drawing.Size(1156, 509);
			this.radGridView1.TabIndex = 0;
			this.radGridView1.Text = "radGridView1";
			// 
			// radPageViewPage2
			// 
// TODO: Beim Generieren des Codes für "			this.radPageViewPage2.Context" ist die Ausnahme "Ungültiger primitiver Typ: System.IntPtr. Verwenden Sie CodeObjectCreateExpression." aufgetreten.
			this.radPageViewPage2.Controls.Add(this.radTreeView1);
			this.radPageViewPage2.Location = new System.Drawing.Point(10, 37);
			this.radPageViewPage2.Name = "radPageViewPage2";
			this.radPageViewPage2.Size = new System.Drawing.Size(1179, 605);
			this.radPageViewPage2.Text = "RadTreeView";
			// 
			// radTreeView1
			// 
			this.radTreeView1.Location = new System.Drawing.Point(18, 16);
			this.radTreeView1.Name = "radTreeView1";
			this.radTreeView1.Size = new System.Drawing.Size(334, 389);
			this.radTreeView1.SpacingBetweenNodes = -1;
			this.radTreeView1.TabIndex = 0;
			this.radTreeView1.Text = "radTreeView1";
			// 
			// radPageViewPage3
			// 
// TODO: Beim Generieren des Codes für "			this.radPageViewPage3.Context" ist die Ausnahme "Ungültiger primitiver Typ: System.IntPtr. Verwenden Sie CodeObjectCreateExpression." aufgetreten.
			this.radPageViewPage3.Controls.Add(this.radCalendar1);
			this.radPageViewPage3.Location = new System.Drawing.Point(10, 37);
			this.radPageViewPage3.Name = "radPageViewPage3";
			this.radPageViewPage3.Size = new System.Drawing.Size(1179, 605);
			this.radPageViewPage3.Text = "RadCalendar";
			// 
			// radCalendar1
			// 
			this.radCalendar1.Location = new System.Drawing.Point(28, 25);
			this.radCalendar1.Name = "radCalendar1";
			this.radCalendar1.Size = new System.Drawing.Size(403, 346);
			this.radCalendar1.TabIndex = 0;
			this.radCalendar1.Text = "radCalendar1";
			// 
			// radPageViewPage4
			// 
// TODO: Beim Generieren des Codes für "			this.radPageViewPage4.Context" ist die Ausnahme "Ungültiger primitiver Typ: System.IntPtr. Verwenden Sie CodeObjectCreateExpression." aufgetreten.
			this.radPageViewPage4.Controls.Add(this.radDateTimePicker1);
			this.radPageViewPage4.Location = new System.Drawing.Point(10, 37);
			this.radPageViewPage4.Name = "radPageViewPage4";
			this.radPageViewPage4.Size = new System.Drawing.Size(1179, 605);
			this.radPageViewPage4.Text = "RadDateTimePicker";
			// 
			// radDateTimePicker1
			// 
			this.radDateTimePicker1.Location = new System.Drawing.Point(49, 48);
			this.radDateTimePicker1.Name = "radDateTimePicker1";
			this.radDateTimePicker1.Size = new System.Drawing.Size(312, 20);
			this.radDateTimePicker1.TabIndex = 0;
			this.radDateTimePicker1.TabStop = false;
			this.radDateTimePicker1.Text = "Mittwoch, 3. August 2011";
			this.radDateTimePicker1.Value = new System.DateTime(2011, 8, 3, 10, 3, 6, 991);
			// 
			// radPageViewPage5
			// 
// TODO: Beim Generieren des Codes für "			this.radPageViewPage5.Context" ist die Ausnahme "Ungültiger primitiver Typ: System.IntPtr. Verwenden Sie CodeObjectCreateExpression." aufgetreten.
			this.radPageViewPage5.Controls.Add(this.radPropertyGrid1);
			this.radPageViewPage5.Location = new System.Drawing.Point(10, 37);
			this.radPageViewPage5.Name = "radPageViewPage5";
			this.radPageViewPage5.Size = new System.Drawing.Size(1179, 605);
			this.radPageViewPage5.Text = "RadPropertyGrid";
			// 
			// radPropertyGrid1
			// 
			this.radPropertyGrid1.Location = new System.Drawing.Point(15, 16);
			this.radPropertyGrid1.Name = "radPropertyGrid1";
			this.radPropertyGrid1.Size = new System.Drawing.Size(457, 387);
			this.radPropertyGrid1.TabIndex = 0;
			this.radPropertyGrid1.Text = "radPropertyGrid1";
			// 
			// radPageViewPage6
			// 
// TODO: Beim Generieren des Codes für "			this.radPageViewPage6.Context" ist die Ausnahme "Ungültiger primitiver Typ: System.IntPtr. Verwenden Sie CodeObjectCreateExpression." aufgetreten.
			this.radPageViewPage6.Controls.Add(this.radButton3);
			this.radPageViewPage6.Controls.Add(this.radButton2);
			this.radPageViewPage6.Controls.Add(this.radButton1);
			this.radPageViewPage6.Location = new System.Drawing.Point(10, 37);
			this.radPageViewPage6.Name = "radPageViewPage6";
			this.radPageViewPage6.Size = new System.Drawing.Size(1179, 605);
			this.radPageViewPage6.Text = "RadMessageBox";
			// 
			// radButton3
			// 
			this.radButton3.Location = new System.Drawing.Point(46, 119);
			this.radButton3.Name = "radButton3";
			this.radButton3.Size = new System.Drawing.Size(186, 24);
			this.radButton3.TabIndex = 1;
			this.radButton3.Text = "MessageBox Yes/No/Cancel";
			this.radButton3.Click += new System.EventHandler(this.radButton3_Click);
			// 
			// radButton2
			// 
			this.radButton2.Location = new System.Drawing.Point(46, 74);
			this.radButton2.Name = "radButton2";
			this.radButton2.Size = new System.Drawing.Size(186, 24);
			this.radButton2.TabIndex = 1;
			this.radButton2.Text = "MessageBox Abort/Ignore/Retry";
			this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
			// 
			// radButton1
			// 
			this.radButton1.Location = new System.Drawing.Point(46, 27);
			this.radButton1.Name = "radButton1";
			this.radButton1.Size = new System.Drawing.Size(186, 24);
			this.radButton1.TabIndex = 0;
			this.radButton1.Text = "MessageBox OK/Cancel";
			this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
			// 
			// radPageViewPage7
			// 
// TODO: Beim Generieren des Codes für "			this.radPageViewPage7.Context" ist die Ausnahme "Ungültiger primitiver Typ: System.IntPtr. Verwenden Sie CodeObjectCreateExpression." aufgetreten.
			this.radPageViewPage7.Controls.Add(this.radSchedulerNavigator1);
			this.radPageViewPage7.Controls.Add(this.radScheduler1);
			this.radPageViewPage7.Controls.Add(this.radCalendar2);
			this.radPageViewPage7.Controls.Add(this.radDropDownList1);
			this.radPageViewPage7.Controls.Add(this.radButton4);
			this.radPageViewPage7.Location = new System.Drawing.Point(10, 37);
			this.radPageViewPage7.Name = "radPageViewPage7";
			this.radPageViewPage7.Size = new System.Drawing.Size(1179, 605);
			this.radPageViewPage7.Text = "RadScheduler";
			// 
			// radSchedulerNavigator1
			// 
			this.radSchedulerNavigator1.AssociatedScheduler = this.radScheduler1;
			this.radSchedulerNavigator1.DateFormat = "yyyy/MM/dd";
			this.radSchedulerNavigator1.Location = new System.Drawing.Point(276, 13);
			this.radSchedulerNavigator1.Name = "radSchedulerNavigator1";
			this.radSchedulerNavigator1.NavigationStepType = Telerik.WinControls.UI.NavigationStepTypes.Day;
			// 
			// 
			// 
			this.radSchedulerNavigator1.RootElement.StretchVertically = false;
			this.radSchedulerNavigator1.Size = new System.Drawing.Size(713, 77);
			this.radSchedulerNavigator1.TabIndex = 1;
			this.radSchedulerNavigator1.Text = "radSchedulerNavigator1";
			// 
			// radScheduler1
			// 
			dateTimeInterval1.End = new System.DateTime(((long)(0)));
			dateTimeInterval1.Start = new System.DateTime(((long)(0)));
			this.radScheduler1.AccessibleInterval = dateTimeInterval1;
			this.radScheduler1.AppointmentTitleFormat = null;
			this.radScheduler1.Culture = new System.Globalization.CultureInfo("de-DE");
			this.radScheduler1.DataSource = null;
			this.radScheduler1.GroupType = Telerik.WinControls.UI.GroupType.None;
			this.radScheduler1.HeaderFormat = "dd dddd";
			this.radScheduler1.Location = new System.Drawing.Point(276, 96);
			this.radScheduler1.Name = "radScheduler1";
			this.radScheduler1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
			schedulerDailyPrintStyle1.AppointmentFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			schedulerDailyPrintStyle1.DateEndRange = new System.DateTime(2013, 2, 16, 0, 0, 0, 0);
			schedulerDailyPrintStyle1.DateHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			schedulerDailyPrintStyle1.DateStartRange = new System.DateTime(2012, 5, 8, 0, 0, 0, 0);
			schedulerDailyPrintStyle1.PageHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
			this.radScheduler1.PrintStyle = schedulerDailyPrintStyle1;
			// 
			// 
			// 
			this.radScheduler1.RootElement.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
			this.radScheduler1.Size = new System.Drawing.Size(712, 500);
			this.radScheduler1.TabIndex = 0;
			this.radScheduler1.Text = "radScheduler1";
			this.radScheduler1.AppointmentEditDialogShowing += new System.EventHandler<Telerik.WinControls.UI.AppointmentEditDialogShowingEventArgs>(this.radScheduler1_AppointmentEditDialogShowing);
			// 
			// radCalendar2
			// 
			this.radCalendar2.Location = new System.Drawing.Point(13, 13);
			this.radCalendar2.Name = "radCalendar2";
			this.radCalendar2.SelectedDates.AddRange(new System.DateTime[] {
            new System.DateTime(1900, 1, 1, 0, 0, 0, 0)});
			this.radCalendar2.Size = new System.Drawing.Size(257, 583);
			this.radCalendar2.TabIndex = 2;
			this.radCalendar2.Text = "radCalendar1";
			// 
			// radDropDownList1
			// 
			this.radDropDownList1.DropDownSizingMode = ((Telerik.WinControls.UI.SizingMode)((Telerik.WinControls.UI.SizingMode.RightBottom | Telerik.WinControls.UI.SizingMode.UpDown)));
			this.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
			this.radDropDownList1.Location = new System.Drawing.Point(995, 13);
			this.radDropDownList1.Name = "radDropDownList1";
			this.radDropDownList1.Size = new System.Drawing.Size(140, 20);
			this.radDropDownList1.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending;
			this.radDropDownList1.TabIndex = 3;
			this.radDropDownList1.Text = "radDropDownList1";
			// 
			// radButton4
			// 
			this.radButton4.Location = new System.Drawing.Point(995, 39);
			this.radButton4.Name = "radButton4";
			this.radButton4.Size = new System.Drawing.Size(140, 24);
			this.radButton4.TabIndex = 4;
			this.radButton4.Text = "Neue Zeitzone hinzufügen";
			this.radButton4.Click += new System.EventHandler(this.radButton4_Click);
			// 
			// radPageViewPage8
			// 
// TODO: Beim Generieren des Codes für "			this.radPageViewPage8.Context" ist die Ausnahme "Ungültiger primitiver Typ: System.IntPtr. Verwenden Sie CodeObjectCreateExpression." aufgetreten.
			this.radPageViewPage8.Controls.Add(this.radButton6);
			this.radPageViewPage8.Location = new System.Drawing.Point(10, 37);
			this.radPageViewPage8.Name = "radPageViewPage8";
			this.radPageViewPage8.Size = new System.Drawing.Size(1179, 605);
			this.radPageViewPage8.Text = "ColorDialog";
			// 
			// radButton6
			// 
			this.radButton6.Location = new System.Drawing.Point(58, 68);
			this.radButton6.Name = "radButton6";
			this.radButton6.Size = new System.Drawing.Size(130, 24);
			this.radButton6.TabIndex = 0;
			this.radButton6.Text = "ColorDialog";
			this.radButton6.Click += new System.EventHandler(this.radButton6_Click);
			// 
			// radPageViewPage9
			// 
// TODO: Beim Generieren des Codes für "			this.radPageViewPage9.Context" ist die Ausnahme "Ungültiger primitiver Typ: System.IntPtr. Verwenden Sie CodeObjectCreateExpression." aufgetreten.
			this.radPageViewPage9.Controls.Add(this.radCommandBar1);
			this.radPageViewPage9.Location = new System.Drawing.Point(10, 37);
			this.radPageViewPage9.Name = "radPageViewPage9";
			this.radPageViewPage9.Size = new System.Drawing.Size(1179, 605);
			this.radPageViewPage9.Text = "CommandBar";
			// 
			// radCommandBar1
			// 
			this.radCommandBar1.Dock = System.Windows.Forms.DockStyle.Top;
			this.radCommandBar1.Location = new System.Drawing.Point(0, 0);
			this.radCommandBar1.Name = "radCommandBar1";
			this.radCommandBar1.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElement1});
			this.radCommandBar1.Size = new System.Drawing.Size(1179, 1);
			this.radCommandBar1.TabIndex = 0;
			this.radCommandBar1.Text = "radCommandBar1";
			// 
			// commandBarRowElement1
			// 
			this.commandBarRowElement1.DisplayName = null;
			this.commandBarRowElement1.MinSize = new System.Drawing.Size(25, 25);
			this.commandBarRowElement1.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.commandBarStripElement1,
            this.commandBarStripElement2});
			// 
			// commandBarStripElement1
			// 
			this.commandBarStripElement1.DisplayName = "commandBarStripElement1";
			this.commandBarStripElement1.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.commandBarButton1,
            this.commandBarLabel1,
            this.commandBarTextBox1});
			this.commandBarStripElement1.Name = "commandBarStripElement1";
			this.commandBarStripElement1.Text = "";
			// 
			// commandBarButton1
			// 
			this.commandBarButton1.AccessibleDescription = "commandBarButton1";
			this.commandBarButton1.AccessibleName = "commandBarButton1";
			this.commandBarButton1.DisplayName = "commandBarButton1";
			this.commandBarButton1.Image = ((System.Drawing.Image)(resources.GetObject("commandBarButton1.Image")));
			this.commandBarButton1.Name = "commandBarButton1";
			this.commandBarButton1.Text = "commandBarButton1";
			this.commandBarButton1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			// 
			// commandBarLabel1
			// 
			this.commandBarLabel1.AccessibleDescription = "commandBarLabel1";
			this.commandBarLabel1.AccessibleName = "commandBarLabel1";
			this.commandBarLabel1.DisplayName = "commandBarLabel1";
			this.commandBarLabel1.Name = "commandBarLabel1";
			this.commandBarLabel1.Text = "commandBarLabel1";
			this.commandBarLabel1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			// 
			// commandBarTextBox1
			// 
			this.commandBarTextBox1.AccessibleDescription = "commandBarTextBox1";
			this.commandBarTextBox1.AccessibleName = "commandBarTextBox1";
			this.commandBarTextBox1.DisplayName = "commandBarTextBox1";
			this.commandBarTextBox1.Name = "commandBarTextBox1";
			this.commandBarTextBox1.Text = "commandBarTextBox1";
			this.commandBarTextBox1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			// 
			// commandBarStripElement2
			// 
			this.commandBarStripElement2.DisplayName = "commandBarStripElement2";
			this.commandBarStripElement2.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.commandBarDropDownButton1,
            this.commandBarToggleButton1,
            this.commandBarSeparator1,
            this.commandBarToggleButton2});
			this.commandBarStripElement2.Name = "commandBarStripElement2";
			this.commandBarStripElement2.Text = "";
			// 
			// commandBarDropDownButton1
			// 
			this.commandBarDropDownButton1.AccessibleDescription = "commandBarDropDownButton1";
			this.commandBarDropDownButton1.AccessibleName = "commandBarDropDownButton1";
			this.commandBarDropDownButton1.DisplayName = "commandBarDropDownButton1";
			this.commandBarDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("commandBarDropDownButton1.Image")));
			this.commandBarDropDownButton1.Name = "commandBarDropDownButton1";
			this.commandBarDropDownButton1.Text = "commandBarDropDownButton1";
			this.commandBarDropDownButton1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			// 
			// commandBarToggleButton1
			// 
			this.commandBarToggleButton1.AccessibleDescription = "commandBarToggleButton1";
			this.commandBarToggleButton1.AccessibleName = "commandBarToggleButton1";
			this.commandBarToggleButton1.DisplayName = "commandBarToggleButton1";
			this.commandBarToggleButton1.Image = ((System.Drawing.Image)(resources.GetObject("commandBarToggleButton1.Image")));
			this.commandBarToggleButton1.Name = "commandBarToggleButton1";
			this.commandBarToggleButton1.Text = "commandBarToggleButton1";
			this.commandBarToggleButton1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			// 
			// commandBarSeparator1
			// 
			this.commandBarSeparator1.AccessibleDescription = "commandBarSeparator1";
			this.commandBarSeparator1.AccessibleName = "commandBarSeparator1";
			this.commandBarSeparator1.DisplayName = "commandBarSeparator1";
			this.commandBarSeparator1.Name = "commandBarSeparator1";
			this.commandBarSeparator1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			this.commandBarSeparator1.VisibleInOverflowMenu = false;
			// 
			// commandBarToggleButton2
			// 
			this.commandBarToggleButton2.AccessibleDescription = "commandBarToggleButton2";
			this.commandBarToggleButton2.AccessibleName = "commandBarToggleButton2";
			this.commandBarToggleButton2.DisplayName = "commandBarToggleButton2";
			this.commandBarToggleButton2.Image = ((System.Drawing.Image)(resources.GetObject("commandBarToggleButton2.Image")));
			this.commandBarToggleButton2.Name = "commandBarToggleButton2";
			this.commandBarToggleButton2.Text = "commandBarToggleButton2";
			this.commandBarToggleButton2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			// 
			// radPageViewPage10
			// 
// TODO: Beim Generieren des Codes für "			this.radPageViewPage10.Context" ist die Ausnahme "Ungültiger primitiver Typ: System.IntPtr. Verwenden Sie CodeObjectCreateExpression." aufgetreten.
			this.radPageViewPage10.Controls.Add(this.radButton5);
			this.radPageViewPage10.Location = new System.Drawing.Point(10, 37);
			this.radPageViewPage10.Name = "radPageViewPage10";
			this.radPageViewPage10.Size = new System.Drawing.Size(1179, 605);
			this.radPageViewPage10.Text = "RadMarkupEditor";
			// 
			// radButton5
			// 
			this.radButton5.Location = new System.Drawing.Point(56, 51);
			this.radButton5.Name = "radButton5";
			this.radButton5.Size = new System.Drawing.Size(130, 24);
			this.radButton5.TabIndex = 0;
			this.radButton5.Text = "Editor";
			this.radButton5.Click += new System.EventHandler(this.radButton5_Click);
			// 
			// radPageViewPage11
			// 
// TODO: Beim Generieren des Codes für "			this.radPageViewPage11.Context" ist die Ausnahme "Ungültiger primitiver Typ: System.IntPtr. Verwenden Sie CodeObjectCreateExpression." aufgetreten.
			this.radPageViewPage11.Controls.Add(this.radWizard1);
			this.radPageViewPage11.Location = new System.Drawing.Point(10, 37);
			this.radPageViewPage11.Name = "radPageViewPage11";
			this.radPageViewPage11.Size = new System.Drawing.Size(1179, 605);
			this.radPageViewPage11.Text = "RadWizard";
			// 
			// radWizard1
			// 
			this.radWizard1.CompletionPage = this.wizardCompletionPage1;
			this.radWizard1.Controls.Add(this.panel2);
			this.radWizard1.Controls.Add(this.panel3);
			this.radWizard1.Controls.Add(this.panel4);
			this.radWizard1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.radWizard1.Location = new System.Drawing.Point(0, 0);
			this.radWizard1.Name = "radWizard1";
			this.radWizard1.PageHeaderIcon = ((System.Drawing.Image)(resources.GetObject("radWizard1.PageHeaderIcon")));
			this.radWizard1.Pages.Add(this.wizardWelcomePage1);
			this.radWizard1.Pages.Add(this.wizardPage1);
			this.radWizard1.Pages.Add(this.wizardCompletionPage1);
			this.radWizard1.Size = new System.Drawing.Size(1179, 605);
			this.radWizard1.TabIndex = 0;
			this.radWizard1.Text = "radWizard1";
			this.radWizard1.WelcomePage = this.wizardWelcomePage1;
			// 
			// wizardCompletionPage1
			// 
			this.wizardCompletionPage1.ContentArea = this.panel4;
			this.wizardCompletionPage1.Name = "wizardCompletionPage1";
			this.wizardCompletionPage1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.White;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(0, 0);
			this.panel4.TabIndex = 2;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Location = new System.Drawing.Point(150, 56);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1029, 501);
			this.panel2.TabIndex = 0;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.White;
			this.panel3.Location = new System.Drawing.Point(0, 81);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1179, 476);
			this.panel3.TabIndex = 1;
			// 
			// wizardWelcomePage1
			// 
			this.wizardWelcomePage1.ContentArea = this.panel2;
			this.wizardWelcomePage1.Name = "wizardWelcomePage1";
			this.wizardWelcomePage1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			// 
			// wizardPage1
			// 
			this.wizardPage1.ContentArea = this.panel3;
			this.wizardPage1.Name = "wizardPage1";
			this.wizardPage1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
			// 
			// radPageViewPage12
			// 
// TODO: Beim Generieren des Codes für "			this.radPageViewPage12.Context" ist die Ausnahme "Ungültiger primitiver Typ: System.IntPtr. Verwenden Sie CodeObjectCreateExpression." aufgetreten.
			this.radPageViewPage12.Controls.Add(this.radTimePicker2);
			this.radPageViewPage12.Location = new System.Drawing.Point(10, 37);
			this.radPageViewPage12.Name = "radPageViewPage12";
			this.radPageViewPage12.Size = new System.Drawing.Size(1179, 605);
			this.radPageViewPage12.Text = "RadTimePicker";
			// 
			// radTimePicker2
			// 
			this.radTimePicker2.Location = new System.Drawing.Point(36, 50);
			this.radTimePicker2.Name = "radTimePicker2";
			this.radTimePicker2.Size = new System.Drawing.Size(271, 20);
			this.radTimePicker2.TabIndex = 1;
			this.radTimePicker2.TabStop = false;
			this.radTimePicker2.Text = "radTimePicker2";
			this.radTimePicker2.Value = new System.DateTime(2012, 5, 8, 15, 3, 26, 0);
			// 
			// RadGridViewPrinting
			// 
// TODO: Beim Generieren des Codes für "			this.RadGridViewPrinting.Context" ist die Ausnahme "Ungültiger primitiver Typ: System.IntPtr. Verwenden Sie CodeObjectCreateExpression." aufgetreten.
			this.RadGridViewPrinting.Controls.Add(this.buttonGridViewPrintPreview);
			this.RadGridViewPrinting.Controls.Add(this.buttonGridViewPrintSettings);
			this.RadGridViewPrinting.Controls.Add(this.GridViewPrinting);
			this.RadGridViewPrinting.Location = new System.Drawing.Point(10, 37);
			this.RadGridViewPrinting.Name = "RadGridViewPrinting";
			this.RadGridViewPrinting.Size = new System.Drawing.Size(1179, 605);
			this.RadGridViewPrinting.Text = "RadGridView Printing";
			// 
			// buttonGridViewPrintPreview
			// 
			this.buttonGridViewPrintPreview.Location = new System.Drawing.Point(159, 15);
			this.buttonGridViewPrintPreview.Name = "buttonGridViewPrintPreview";
			this.buttonGridViewPrintPreview.Size = new System.Drawing.Size(130, 24);
			this.buttonGridViewPrintPreview.TabIndex = 2;
			this.buttonGridViewPrintPreview.Text = "Print preview";
			this.buttonGridViewPrintPreview.Click += new System.EventHandler(this.buttonGridViewPrintPreview_Click);
			// 
			// buttonGridViewPrintSettings
			// 
			this.buttonGridViewPrintSettings.Location = new System.Drawing.Point(14, 15);
			this.buttonGridViewPrintSettings.Name = "buttonGridViewPrintSettings";
			this.buttonGridViewPrintSettings.Size = new System.Drawing.Size(130, 24);
			this.buttonGridViewPrintSettings.TabIndex = 1;
			this.buttonGridViewPrintSettings.Text = "Print settings";
			this.buttonGridViewPrintSettings.Click += new System.EventHandler(this.buttonGridViewPrintSettings_Click);
			// 
			// GridViewPrinting
			// 
			this.GridViewPrinting.Location = new System.Drawing.Point(14, 51);
			this.GridViewPrinting.Name = "GridViewPrinting";
			this.GridViewPrinting.Size = new System.Drawing.Size(894, 493);
			this.GridViewPrinting.TabIndex = 0;
			this.GridViewPrinting.Text = "GridViewPrinting";
			// 
			// SchedulerPrinting
			// 
// TODO: Beim Generieren des Codes für "			this.SchedulerPrinting.Context" ist die Ausnahme "Ungültiger primitiver Typ: System.IntPtr. Verwenden Sie CodeObjectCreateExpression." aufgetreten.
			this.SchedulerPrinting.Controls.Add(this.radScheduler2);
			this.SchedulerPrinting.Controls.Add(this.radSchedulerNavigator2);
			this.SchedulerPrinting.Controls.Add(this.ButtonSchedulerPrintingPrintPreview);
			this.SchedulerPrinting.Controls.Add(this.ButtonSchedulerPrintingPrintSettings);
			this.SchedulerPrinting.Location = new System.Drawing.Point(10, 37);
			this.SchedulerPrinting.Name = "SchedulerPrinting";
			this.SchedulerPrinting.Size = new System.Drawing.Size(1179, 605);
			this.SchedulerPrinting.Text = "RadScheduler Printing";
			// 
			// radScheduler2
			// 
			dateTimeInterval2.End = new System.DateTime(((long)(0)));
			dateTimeInterval2.Start = new System.DateTime(((long)(0)));
			this.radScheduler2.AccessibleInterval = dateTimeInterval2;
			this.radScheduler2.AppointmentTitleFormat = null;
			this.radScheduler2.Culture = new System.Globalization.CultureInfo("de-DE");
			this.radScheduler2.DataSource = null;
			this.radScheduler2.GroupType = Telerik.WinControls.UI.GroupType.None;
			this.radScheduler2.HeaderFormat = "dd dddd";
			this.radScheduler2.Location = new System.Drawing.Point(15, 152);
			this.radScheduler2.Name = "radScheduler2";
			schedulerDailyPrintStyle2.AppointmentFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			schedulerDailyPrintStyle2.DateEndRange = new System.DateTime(2013, 2, 16, 0, 0, 0, 0);
			schedulerDailyPrintStyle2.DateHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			schedulerDailyPrintStyle2.DateStartRange = new System.DateTime(2012, 6, 18, 0, 0, 0, 0);
			schedulerDailyPrintStyle2.PageHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
			this.radScheduler2.PrintStyle = schedulerDailyPrintStyle2;
			this.radScheduler2.Size = new System.Drawing.Size(902, 500);
			this.radScheduler2.TabIndex = 3;
			this.radScheduler2.Text = "radScheduler2";
			// 
			// radSchedulerNavigator2
			// 
			this.radSchedulerNavigator2.AssociatedScheduler = this.radScheduler2;
			this.radSchedulerNavigator2.DateFormat = "yyyy/MM/dd";
			this.radSchedulerNavigator2.Location = new System.Drawing.Point(15, 68);
			this.radSchedulerNavigator2.Name = "radSchedulerNavigator2";
			this.radSchedulerNavigator2.NavigationStepType = Telerik.WinControls.UI.NavigationStepTypes.Day;
			// 
			// 
			// 
			this.radSchedulerNavigator2.RootElement.StretchVertically = false;
			this.radSchedulerNavigator2.Size = new System.Drawing.Size(902, 77);
			this.radSchedulerNavigator2.TabIndex = 2;
			this.radSchedulerNavigator2.Text = "radSchedulerNavigator2";
			// 
			// ButtonSchedulerPrintingPrintPreview
			// 
			this.ButtonSchedulerPrintingPrintPreview.Location = new System.Drawing.Point(161, 17);
			this.ButtonSchedulerPrintingPrintPreview.Name = "ButtonSchedulerPrintingPrintPreview";
			this.ButtonSchedulerPrintingPrintPreview.Size = new System.Drawing.Size(130, 24);
			this.ButtonSchedulerPrintingPrintPreview.TabIndex = 1;
			this.ButtonSchedulerPrintingPrintPreview.Text = "print preview";
			this.ButtonSchedulerPrintingPrintPreview.Click += new System.EventHandler(this.ButtonSchedulerPrintingPrintPreview_Click);
			// 
			// ButtonSchedulerPrintingPrintSettings
			// 
			this.ButtonSchedulerPrintingPrintSettings.Location = new System.Drawing.Point(15, 17);
			this.ButtonSchedulerPrintingPrintSettings.Name = "ButtonSchedulerPrintingPrintSettings";
			this.ButtonSchedulerPrintingPrintSettings.Size = new System.Drawing.Size(130, 24);
			this.ButtonSchedulerPrintingPrintSettings.TabIndex = 0;
			this.ButtonSchedulerPrintingPrintSettings.Text = "print settings";
			this.ButtonSchedulerPrintingPrintSettings.Click += new System.EventHandler(this.ButtonSchedulerPrintingPrintSettings_Click);
			// 
			// radPageViewPage13
			// 
// TODO: Beim Generieren des Codes für "			this.radPageViewPage13.Context" ist die Ausnahme "Ungültiger primitiver Typ: System.IntPtr. Verwenden Sie CodeObjectCreateExpression." aufgetreten.
			this.radPageViewPage13.Controls.Add(this.radButtonSpellChecker);
			this.radPageViewPage13.Controls.Add(this.radTextBoxSpellChecker);
			this.radPageViewPage13.Location = new System.Drawing.Point(10, 37);
			this.radPageViewPage13.Name = "radPageViewPage13";
			this.radPageViewPage13.Size = new System.Drawing.Size(1179, 605);
			this.radPageViewPage13.Text = "RadSpellChecker";
			// 
			// radButtonSpellChecker
			// 
			this.radButtonSpellChecker.Location = new System.Drawing.Point(567, 48);
			this.radButtonSpellChecker.Name = "radButtonSpellChecker";
			this.radButtonSpellChecker.Size = new System.Drawing.Size(110, 24);
			this.radButtonSpellChecker.TabIndex = 1;
			this.radButtonSpellChecker.Text = "SpellChecker";
			this.radButtonSpellChecker.Click += new System.EventHandler(this.radButtonSpellChecker_Click);
			// 
			// radTextBoxSpellChecker
			// 
			this.radTextBoxSpellChecker.Location = new System.Drawing.Point(52, 52);
			this.radTextBoxSpellChecker.Name = "radTextBoxSpellChecker";
			this.radTextBoxSpellChecker.Size = new System.Drawing.Size(475, 20);
			this.radTextBoxSpellChecker.TabIndex = 0;
			this.radTextBoxSpellChecker.TabStop = false;
			// 
			// radPageViewPage14
			// 
// TODO: Beim Generieren des Codes für "			this.radPageViewPage14.Context" ist die Ausnahme "Ungültiger primitiver Typ: System.IntPtr. Verwenden Sie CodeObjectCreateExpression." aufgetreten.
			this.radPageViewPage14.Controls.Add(this.ButtonSearch);
			this.radPageViewPage14.Controls.Add(this.radTextBoxControl1);
			this.radPageViewPage14.Location = new System.Drawing.Point(10, 37);
			this.radPageViewPage14.Name = "radPageViewPage14";
			this.radPageViewPage14.Size = new System.Drawing.Size(1179, 605);
			this.radPageViewPage14.Text = "RadTextBoxControl";
			// 
			// toolTabStrip1
			// 
			this.toolTabStrip1.CanUpdateChildIndex = true;
			this.toolTabStrip1.Controls.Add(this.toolWindow1);
			this.toolTabStrip1.Location = new System.Drawing.Point(5, 5);
			this.toolTabStrip1.Name = "toolTabStrip1";
			// 
			// 
			// 
			this.toolTabStrip1.RootElement.MinSize = new System.Drawing.Size(25, 25);
			this.toolTabStrip1.SelectedIndex = 0;
			this.toolTabStrip1.Size = new System.Drawing.Size(91, 703);
			this.toolTabStrip1.SizeInfo.AbsoluteSize = new System.Drawing.Size(91, 200);
			this.toolTabStrip1.SizeInfo.SplitterCorrection = new System.Drawing.Size(-109, 0);
			this.toolTabStrip1.TabIndex = 1;
			this.toolTabStrip1.TabStop = false;
			// 
			// toolWindow1
			// 
			this.toolWindow1.Caption = null;
			this.toolWindow1.Location = new System.Drawing.Point(1, 24);
			this.toolWindow1.Name = "toolWindow1";
			this.toolWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
			this.toolWindow1.Size = new System.Drawing.Size(89, 677);
			this.toolWindow1.Text = "toolWindow2";
			// 
			// radSplitContainer1
			// 
			this.radSplitContainer1.CausesValidation = false;
			this.radSplitContainer1.Controls.Add(this.documentContainer1);
			this.radSplitContainer1.Controls.Add(this.toolTabStrip2);
			this.radSplitContainer1.IsCleanUpTarget = true;
			this.radSplitContainer1.Location = new System.Drawing.Point(100, 5);
			this.radSplitContainer1.Name = "radSplitContainer1";
			this.radSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.radSplitContainer1.Padding = new System.Windows.Forms.Padding(5);
			// 
			// 
			// 
			this.radSplitContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
			this.radSplitContainer1.RootElement.Padding = new System.Windows.Forms.Padding(5);
			this.radSplitContainer1.Size = new System.Drawing.Size(1187, 703);
			this.radSplitContainer1.SizeInfo.AbsoluteSize = new System.Drawing.Size(1066, 200);
			this.radSplitContainer1.SizeInfo.SplitterCorrection = new System.Drawing.Size(109, 0);
			this.radSplitContainer1.SplitterWidth = 4;
			this.radSplitContainer1.TabIndex = 0;
			this.radSplitContainer1.TabStop = false;
			// 
			// documentContainer1
			// 
			this.documentContainer1.CausesValidation = false;
			this.documentContainer1.Controls.Add(this.documentTabStrip1);
			this.documentContainer1.Name = "documentContainer1";
			// 
			// 
			// 
			this.documentContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
			this.documentContainer1.RootElement.Padding = new System.Windows.Forms.Padding(5);
			this.documentContainer1.SizeInfo.AbsoluteSize = new System.Drawing.Size(200, 502);
			this.documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
			this.documentContainer1.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, 133);
			// 
			// documentTabStrip1
			// 
			this.documentTabStrip1.CanUpdateChildIndex = true;
			this.documentTabStrip1.CausesValidation = false;
			this.documentTabStrip1.Controls.Add(this.documentWindow2);
			this.documentTabStrip1.Controls.Add(this.documentWindow1);
			this.documentTabStrip1.Location = new System.Drawing.Point(0, 0);
			this.documentTabStrip1.Name = "documentTabStrip1";
			// 
			// 
			// 
			this.documentTabStrip1.RootElement.MinSize = new System.Drawing.Size(25, 25);
			this.documentTabStrip1.SelectedIndex = 0;
			this.documentTabStrip1.Size = new System.Drawing.Size(1187, 632);
			this.documentTabStrip1.TabIndex = 0;
			this.documentTabStrip1.TabStop = false;
			// 
			// documentWindow1
			// 
			this.documentWindow1.Location = new System.Drawing.Point(4, 4);
			this.documentWindow1.Name = "documentWindow1";
			this.documentWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument;
			this.documentWindow1.Size = new System.Drawing.Size(1058, 494);
			this.documentWindow1.Text = "documentWindow2";
			// 
			// toolTabStrip2
			// 
			this.toolTabStrip2.CanUpdateChildIndex = true;
			this.toolTabStrip2.Controls.Add(this.toolWindow2);
			this.toolTabStrip2.Location = new System.Drawing.Point(0, 636);
			this.toolTabStrip2.Name = "toolTabStrip2";
			// 
			// 
			// 
			this.toolTabStrip2.RootElement.MinSize = new System.Drawing.Size(25, 25);
			this.toolTabStrip2.SelectedIndex = 0;
			this.toolTabStrip2.Size = new System.Drawing.Size(1187, 67);
			this.toolTabStrip2.SizeInfo.AbsoluteSize = new System.Drawing.Size(200, 67);
			this.toolTabStrip2.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, -133);
			this.toolTabStrip2.TabIndex = 1;
			this.toolTabStrip2.TabStop = false;
			// 
			// toolWindow2
			// 
			this.toolWindow2.Caption = null;
			this.toolWindow2.Location = new System.Drawing.Point(1, 24);
			this.toolWindow2.Name = "toolWindow2";
			this.toolWindow2.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
			this.toolWindow2.Size = new System.Drawing.Size(1185, 41);
			this.toolWindow2.Text = "toolWindow1";
			// 
			// radSchedulerReminder1
			// 
			this.radSchedulerReminder1.AssociatedScheduler = null;
			this.radSchedulerReminder1.ThemeName = null;
			this.radSchedulerReminder1.TimeInterval = 60000;
			// 
			// radTextBoxControl1
			// 
			this.radTextBoxControl1.Location = new System.Drawing.Point(58, 68);
			this.radTextBoxControl1.Name = "radTextBoxControl1";
			this.radTextBoxControl1.Size = new System.Drawing.Size(477, 20);
			this.radTextBoxControl1.TabIndex = 0;
			this.radTextBoxControl1.Text = "radTextBoxControl1";
			// 
			// ButtonSearch
			// 
			this.ButtonSearch.Location = new System.Drawing.Point(577, 68);
			this.ButtonSearch.Name = "ButtonSearch";
			this.ButtonSearch.Size = new System.Drawing.Size(110, 24);
			this.ButtonSearch.TabIndex = 1;
			this.ButtonSearch.Text = "Search";
			this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
			// 
			// RadRibbonForm1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1292, 895);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.radStatusStrip1);
			this.Controls.Add(this.radRibbonBar1);
			this.Name = "RadRibbonForm1";
			// 
			// 
			// 
			this.RootElement.ApplyShapeToControl = true;
			this.Text = "RadRibbonForm1";
			this.Load += new System.EventHandler(this.RadRibbonForm1_Load);
			((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.radDock1)).EndInit();
			this.radDock1.ResumeLayout(false);
			this.documentWindow2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
			this.radPageView1.ResumeLayout(false);
			this.radPageViewPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
			this.radPageViewPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).EndInit();
			this.radPageViewPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.radCalendar1)).EndInit();
			this.radPageViewPage4.ResumeLayout(false);
			this.radPageViewPage4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).EndInit();
			this.radPageViewPage5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.radPropertyGrid1)).EndInit();
			this.radPageViewPage6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.radButton3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
			this.radPageViewPage7.ResumeLayout(false);
			this.radPageViewPage7.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.radSchedulerNavigator1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radCalendar2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radButton4)).EndInit();
			this.radPageViewPage8.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.radButton6)).EndInit();
			this.radPageViewPage9.ResumeLayout(false);
			this.radPageViewPage9.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).EndInit();
			this.radPageViewPage10.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.radButton5)).EndInit();
			this.radPageViewPage11.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.radWizard1)).EndInit();
			this.radWizard1.ResumeLayout(false);
			this.radPageViewPage12.ResumeLayout(false);
			this.radPageViewPage12.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.radTimePicker2)).EndInit();
			this.RadGridViewPrinting.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.buttonGridViewPrintPreview)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.buttonGridViewPrintSettings)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GridViewPrinting.MasterTemplate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GridViewPrinting)).EndInit();
			this.SchedulerPrinting.ResumeLayout(false);
			this.SchedulerPrinting.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.radScheduler2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radSchedulerNavigator2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ButtonSchedulerPrintingPrintPreview)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ButtonSchedulerPrintingPrintSettings)).EndInit();
			this.radPageViewPage13.ResumeLayout(false);
			this.radPageViewPage13.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.radButtonSpellChecker)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.radTextBoxSpellChecker)).EndInit();
			this.radPageViewPage14.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.toolTabStrip1)).EndInit();
			this.toolTabStrip1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
			this.radSplitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.documentContainer1)).EndInit();
			this.documentContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.documentTabStrip1)).EndInit();
			this.documentTabStrip1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.toolTabStrip2)).EndInit();
			this.toolTabStrip2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.radTextBoxControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ButtonSearch)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadRibbonBar radRibbonBar1;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RibbonTab ribbonTab1;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup1;
        private Telerik.WinControls.UI.Docking.RadDock radDock1;
        private Telerik.WinControls.UI.Docking.DocumentWindow documentWindow2;
        private Telerik.WinControls.UI.RadPageView radPageView1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage2;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip1;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow1;
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
        private Telerik.WinControls.UI.Docking.DocumentContainer documentContainer1;
        private Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip1;
        private Telerik.WinControls.UI.Docking.DocumentWindow documentWindow1;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip2;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow2;
        private Telerik.WinControls.UI.Docking.DockWindowPlaceholder dockWindowPlaceholder2;
        private Telerik.WinControls.UI.Docking.DockWindowPlaceholder dockWindowPlaceholder1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement2;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement1;
        private Telerik.WinControls.UI.RadTreeView radTreeView1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage3;
        private Telerik.WinControls.UI.RadCalendar radCalendar1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage4;
        private Telerik.WinControls.UI.RadDateTimePicker radDateTimePicker1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage5;
        private Telerik.WinControls.UI.RadPropertyGrid radPropertyGrid1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage7;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage8;
        private Telerik.WinControls.UI.RadSchedulerNavigator radSchedulerNavigator1;
        private Telerik.WinControls.UI.RadScheduler radScheduler1;
        private Telerik.WinControls.UI.RadCalendar radCalendar2;
        private Telerik.WinControls.UI.RadDesktopAlert radDesktopAlert1;
        private Telerik.WinControls.UI.RadSchedulerReminder radSchedulerReminder1;
        private Telerik.WinControls.UI.RadDropDownList radDropDownList1;
        private Telerik.WinControls.UI.RadButton radButton4;
        private RadPageViewPage radPageViewPage9;
        private RadCommandBar radCommandBar1;
        private CommandBarRowElement commandBarRowElement1;
        private CommandBarStripElement commandBarStripElement1;
        private RadPageViewPage radPageViewPage10;
        private RadPageViewPage radPageViewPage11;
        private RadWizard radWizard1;
        private WizardCompletionPage wizardCompletionPage1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private WizardWelcomePage wizardWelcomePage1;
        private WizardPage wizardPage1;
        private RadMarkupDialog radMarkupDialog1;
        private CommandBarButton commandBarButton1;
        private RadButton radButton5;
        private RadPageViewPage radPageViewPage6;
        private RadButton radButton3;
        private RadButton radButton2;
        private RadButton radButton1;
        private RadButton radButton6;
        private CommandBarLabel commandBarLabel1;
        private CommandBarTextBox commandBarTextBox1;
        private CommandBarStripElement commandBarStripElement2;
        private CommandBarDropDownButton commandBarDropDownButton1;
        private CommandBarToggleButton commandBarToggleButton1;
        private CommandBarSeparator commandBarSeparator1;
        private CommandBarToggleButton commandBarToggleButton2;
        private RadPageViewPage radPageViewPage12;
        private RadTimePicker radTimePicker2;
        private RadPageViewPage RadGridViewPrinting;
        private RadButton buttonGridViewPrintPreview;
        private RadButton buttonGridViewPrintSettings;
        private RadGridView GridViewPrinting;
        private Telerik.WinControls.UI.RadPrintDocument radPrintDocument1;
        private RadPageViewPage SchedulerPrinting;
        private RadScheduler radScheduler2;
        private RadSchedulerNavigator radSchedulerNavigator2;
        private RadButton ButtonSchedulerPrintingPrintPreview;
        private RadButton ButtonSchedulerPrintingPrintSettings;
		private RadPageViewPage radPageViewPage13;
		private RadSpellChecker radSpellChecker1;
		private RadButton radButtonSpellChecker;
		private RadTextBox radTextBoxSpellChecker;
		private RadPageViewPage radPageViewPage14;
		private RadButton ButtonSearch;
		private RadTextBoxControl radTextBoxControl1;

    }
}
