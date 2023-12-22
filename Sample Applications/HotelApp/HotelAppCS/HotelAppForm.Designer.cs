using CustomControls;
using Telerik.WinControls.UI;

namespace HotelApp
{
    partial class HotelAppForm
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.SchedulerDailyPrintStyle schedulerDailyPrintStyle1 = new Telerik.WinControls.UI.SchedulerDailyPrintStyle();
            Telerik.WinControls.UI.SchedulerDailyPrintStyle schedulerDailyPrintStyle2 = new Telerik.WinControls.UI.SchedulerDailyPrintStyle();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.mainContainer = new Telerik.WinControls.UI.RadPageView();
            this.OverviewPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.overviewMainContainer = new Telerik.WinControls.UI.RadPanel();
            this.overviewRoomsView = new Telerik.WinControls.UI.RadListView();
            this.overviewLeftView = new Telerik.WinControls.UI.RadListView();
            this.navigationPanelOverview = new Telerik.WinControls.UI.RadPanel();
            this.searchContainerOverview = new Telerik.WinControls.UI.RadPanel();
            this.searchTextBoxOverview = new CustomControls.SearchTextBox();
            this.radPanelEmptyOverview = new Telerik.WinControls.UI.RadPanel();
            this.dateNavigatorOverview = new CustomControls.DateNavigator();
            this.BookingsPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.bookingsMainContainer = new Telerik.WinControls.UI.RadPanel();
            this.bookingsGrid = new Telerik.WinControls.UI.RadGridView();
            this.labelBookings = new Telerik.WinControls.UI.RadLabel();
            this.bookingInfoRightPanel = new Telerik.WinControls.UI.RadPanel();
            this.editGuestInfo = new CustomControls.EditGuestInfo();
            this.bookingInfoUC = new CustomControls.BookingInfo();
            this.bookingsLeftView = new Telerik.WinControls.UI.RadListView();
            this.navigationPanelBookings = new Telerik.WinControls.UI.RadPanel();
            this.searchContainerBookings = new Telerik.WinControls.UI.RadPanel();
            this.searchTextBoxBookings = new CustomControls.SearchTextBox();
            this.radPanelEmptyBooking = new Telerik.WinControls.UI.RadPanel();
            this.dateNavigatorBookings = new CustomControls.DateNavigator();
            this.SchedulePage = new Telerik.WinControls.UI.RadPageViewPage();
            this.ScheduleRadScheduler = new Telerik.WinControls.UI.RadScheduler();
            this.scheduleRadSchedulerHeader = new Telerik.WinControls.UI.RadPanel();
            this.scheduleBookingPanel = new Telerik.WinControls.UI.RadPanel();
            this.scheduleBookingInfo = new CustomControls.BookingInfo();
            this.scheduleEditGuestInfo = new CustomControls.EditGuestInfo();
            this.scheduleListView = new Telerik.WinControls.UI.RadListView();
            this.scheduleHeaderPanel = new Telerik.WinControls.UI.RadPanel();
            this.scheduleWeeklyButton = new Telerik.WinControls.UI.RadToggleButton();
            this.scheduleMonthlyButton = new Telerik.WinControls.UI.RadToggleButton();
            this.scheduleDaysButton = new Telerik.WinControls.UI.RadToggleButton();
            this.scheduleSearchPanel = new Telerik.WinControls.UI.RadPanel();
            this.scheduleSearchDropDown = new HotelApp.SearchDropDownList();
            this.scheduleDateNavigator = new CustomControls.DateNavigator();
            this.HouseKeepingPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.houseKeepingSplitContainer = new Telerik.WinControls.UI.RadSplitContainer();
            this.splitPanel1 = new Telerik.WinControls.UI.SplitPanel();
            this.houseKeepingScheduler = new Telerik.WinControls.UI.RadScheduler();
            this.houseKeepingSchedulerHeaderLabel = new Telerik.WinControls.UI.RadLabel();
            this.splitPanel2 = new Telerik.WinControls.UI.SplitPanel();
            this.notAssignedGridView = new Telerik.WinControls.UI.RadGridView();
            this.notAssignedLabel = new Telerik.WinControls.UI.RadLabel();
            this.houseKeepingListView = new Telerik.WinControls.UI.RadListView();
            this.houseKeepingNavigationPanel = new Telerik.WinControls.UI.RadPanel();
            this.houseKeepingWeeklyToggleButton = new Telerik.WinControls.UI.RadToggleButton();
            this.houseKeepingMonthlyToggleButton = new Telerik.WinControls.UI.RadToggleButton();
            this.houseKeepingDaysToggleButton = new Telerik.WinControls.UI.RadToggleButton();
            this.houseKeepingDateNavigator = new CustomControls.DateNavigator();
            this.ReportsPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.reportsTypePanel = new Telerik.WinControls.UI.RadPanel();
            this.userControlBookingsByType1 = new HotelApp.UserControlBookingsByType();
            this.reportsBookingsByTypeLabel = new Telerik.WinControls.UI.RadLabel();
            this.reportsStatusPanel = new Telerik.WinControls.UI.RadPanel();
            this.userControlCurrentStatus1 = new HotelApp.UserControlCurrentStatus();
            this.reportsCurrentStatusLabel = new Telerik.WinControls.UI.RadLabel();
            this.reportsHeaderPanel = new Telerik.WinControls.UI.RadPanel();
            this.reportsWeeklyToggleButton = new Telerik.WinControls.UI.RadToggleButton();
            this.reportsMonthlyToggleButton = new Telerik.WinControls.UI.RadToggleButton();
            this.reportsDaysToggleButton = new Telerik.WinControls.UI.RadToggleButton();
            this.reportsDateNavigator = new CustomControls.DateNavigator();
            this.materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            this.materialPinkTheme1 = new Telerik.WinControls.Themes.MaterialPinkTheme();
            this.materialBlueGreyTheme1 = new Telerik.WinControls.Themes.MaterialBlueGreyTheme();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            this.mainContainer.SuspendLayout();
            this.OverviewPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overviewMainContainer)).BeginInit();
            this.overviewMainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overviewRoomsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.overviewLeftView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPanelOverview)).BeginInit();
            this.navigationPanelOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchContainerOverview)).BeginInit();
            this.searchContainerOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchTextBoxOverview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelEmptyOverview)).BeginInit();
            this.BookingsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsMainContainer)).BeginInit();
            this.bookingsMainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsGrid.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelBookings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingInfoRightPanel)).BeginInit();
            this.bookingInfoRightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsLeftView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPanelBookings)).BeginInit();
            this.navigationPanelBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchContainerBookings)).BeginInit();
            this.searchContainerBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchTextBoxBookings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelEmptyBooking)).BeginInit();
            this.SchedulePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleRadScheduler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleRadSchedulerHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBookingPanel)).BeginInit();
            this.scheduleBookingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleHeaderPanel)).BeginInit();
            this.scheduleHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleWeeklyButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleMonthlyButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDaysButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleSearchPanel)).BeginInit();
            this.scheduleSearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleSearchDropDown)).BeginInit();
            this.HouseKeepingPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.houseKeepingSplitContainer)).BeginInit();
            this.houseKeepingSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).BeginInit();
            this.splitPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.houseKeepingScheduler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseKeepingSchedulerHeaderLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).BeginInit();
            this.splitPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notAssignedGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notAssignedGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notAssignedLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseKeepingListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseKeepingNavigationPanel)).BeginInit();
            this.houseKeepingNavigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.houseKeepingWeeklyToggleButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseKeepingMonthlyToggleButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseKeepingDaysToggleButton)).BeginInit();
            this.ReportsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportsTypePanel)).BeginInit();
            this.reportsTypePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportsBookingsByTypeLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsStatusPanel)).BeginInit();
            this.reportsStatusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportsCurrentStatusLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsHeaderPanel)).BeginInit();
            this.reportsHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportsWeeklyToggleButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsMonthlyToggleButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsDaysToggleButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Controls.Add(this.OverviewPage);
            this.mainContainer.Controls.Add(this.BookingsPage);
            this.mainContainer.Controls.Add(this.SchedulePage);
            this.mainContainer.Controls.Add(this.HouseKeepingPage);
            this.mainContainer.Controls.Add(this.ReportsPage);
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.SelectedPage = this.OverviewPage;
            this.mainContainer.Size = new System.Drawing.Size(1352, 697);
            this.mainContainer.TabIndex = 0;
            this.mainContainer.Text = "radPageView1";
            // 
            // OverviewPage
            // 
            this.OverviewPage.Controls.Add(this.overviewMainContainer);
            this.OverviewPage.Controls.Add(this.navigationPanelOverview);
            this.OverviewPage.ItemSize = new System.Drawing.SizeF(71F, 28F);
            this.OverviewPage.Location = new System.Drawing.Point(10, 37);
            this.OverviewPage.Name = "OverviewPage";
            this.OverviewPage.Size = new System.Drawing.Size(1331, 649);
            this.OverviewPage.Text = "OVERVIEW";
            // 
            // overviewMainContainer
            // 
            this.overviewMainContainer.Controls.Add(this.overviewRoomsView);
            this.overviewMainContainer.Controls.Add(this.overviewLeftView);
            this.overviewMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overviewMainContainer.Location = new System.Drawing.Point(0, 60);
            this.overviewMainContainer.Margin = new System.Windows.Forms.Padding(0);
            this.overviewMainContainer.Name = "overviewMainContainer";
            this.overviewMainContainer.Size = new System.Drawing.Size(1331, 589);
            this.overviewMainContainer.TabIndex = 3;
            // 
            // overviewRoomsView
            // 
            this.overviewRoomsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overviewRoomsView.Location = new System.Drawing.Point(269, 0);
            this.overviewRoomsView.Margin = new System.Windows.Forms.Padding(0);
            this.overviewRoomsView.Name = "overviewRoomsView";
            this.overviewRoomsView.Size = new System.Drawing.Size(1062, 589);
            this.overviewRoomsView.TabIndex = 2;
            this.overviewRoomsView.Text = "radListView1";
            // 
            // overviewLeftView
            // 
            this.overviewLeftView.Dock = System.Windows.Forms.DockStyle.Left;
            this.overviewLeftView.Location = new System.Drawing.Point(0, 0);
            this.overviewLeftView.Margin = new System.Windows.Forms.Padding(0);
            this.overviewLeftView.Name = "overviewLeftView";
            this.overviewLeftView.Size = new System.Drawing.Size(269, 589);
            this.overviewLeftView.TabIndex = 1;
            this.overviewLeftView.Text = "radListView1";
            // 
            // navigationPanelOverview
            // 
            this.navigationPanelOverview.Controls.Add(this.searchContainerOverview);
            this.navigationPanelOverview.Controls.Add(this.dateNavigatorOverview);
            this.navigationPanelOverview.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationPanelOverview.Location = new System.Drawing.Point(0, 0);
            this.navigationPanelOverview.Margin = new System.Windows.Forms.Padding(0);
            this.navigationPanelOverview.Name = "navigationPanelOverview";
            this.navigationPanelOverview.Size = new System.Drawing.Size(1331, 60);
            this.navigationPanelOverview.TabIndex = 0;
            // 
            // searchContainerOverview
            // 
            this.searchContainerOverview.Controls.Add(this.searchTextBoxOverview);
            this.searchContainerOverview.Controls.Add(this.radPanelEmptyOverview);
            this.searchContainerOverview.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchContainerOverview.Location = new System.Drawing.Point(699, 0);
            this.searchContainerOverview.Name = "searchContainerOverview";
            this.searchContainerOverview.Size = new System.Drawing.Size(632, 60);
            this.searchContainerOverview.TabIndex = 1;
            // 
            // searchTextBoxOverview
            // 
            this.searchTextBoxOverview.AutoSize = false;
            this.searchTextBoxOverview.Location = new System.Drawing.Point(3, 10);
            this.searchTextBoxOverview.Name = "searchTextBoxOverview";
            this.searchTextBoxOverview.NullText = "Search by room# or guest name";
            // 
            // 
            // 
            this.searchTextBoxOverview.RootElement.CustomFont = "Roboto";
            this.searchTextBoxOverview.RootElement.CustomFontSize = 8F;
            this.searchTextBoxOverview.Size = new System.Drawing.Size(590, 29);
            this.searchTextBoxOverview.TabIndex = 0;
            // 
            // radPanelEmptyOverview
            // 
            this.radPanelEmptyOverview.BackColor = System.Drawing.Color.Transparent;
            this.radPanelEmptyOverview.Dock = System.Windows.Forms.DockStyle.Right;
            this.radPanelEmptyOverview.Location = new System.Drawing.Point(592, 0);
            this.radPanelEmptyOverview.Name = "radPanelEmptyOverview";
            this.radPanelEmptyOverview.Size = new System.Drawing.Size(40, 60);
            this.radPanelEmptyOverview.TabIndex = 1;
            // 
            // dateNavigatorOverview
            // 
            this.dateNavigatorOverview.BackColor = System.Drawing.Color.Transparent;
            this.dateNavigatorOverview.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateNavigatorOverview.Location = new System.Drawing.Point(0, 0);
            this.dateNavigatorOverview.Name = "dateNavigatorOverview";
            this.dateNavigatorOverview.Size = new System.Drawing.Size(270, 60);
            this.dateNavigatorOverview.TabIndex = 0;
            // 
            // BookingsPage
            // 
            this.BookingsPage.Controls.Add(this.bookingsMainContainer);
            this.BookingsPage.Controls.Add(this.navigationPanelBookings);
            this.BookingsPage.ItemSize = new System.Drawing.SizeF(72F, 28F);
            this.BookingsPage.Location = new System.Drawing.Point(10, 37);
            this.BookingsPage.Name = "BookingsPage";
            this.BookingsPage.Size = new System.Drawing.Size(1331, 649);
            this.BookingsPage.Text = "BOOKINGS";
            // 
            // bookingsMainContainer
            // 
            this.bookingsMainContainer.Controls.Add(this.bookingsGrid);
            this.bookingsMainContainer.Controls.Add(this.labelBookings);
            this.bookingsMainContainer.Controls.Add(this.bookingInfoRightPanel);
            this.bookingsMainContainer.Controls.Add(this.bookingsLeftView);
            this.bookingsMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingsMainContainer.Location = new System.Drawing.Point(0, 60);
            this.bookingsMainContainer.Name = "bookingsMainContainer";
            this.bookingsMainContainer.Size = new System.Drawing.Size(1331, 589);
            this.bookingsMainContainer.TabIndex = 3;
            // 
            // bookingsGrid
            // 
            this.bookingsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingsGrid.Location = new System.Drawing.Point(269, 50);
            this.bookingsGrid.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            // 
            // 
            // 
            this.bookingsGrid.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.bookingsGrid.Name = "bookingsGrid";
            this.bookingsGrid.Size = new System.Drawing.Size(792, 539);
            this.bookingsGrid.TabIndex = 5;
            this.bookingsGrid.Text = "radGridView1";
            // 
            // labelBookings
            // 
            this.labelBookings.AutoSize = false;
            this.labelBookings.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelBookings.Location = new System.Drawing.Point(269, 0);
            this.labelBookings.Name = "labelBookings";
            this.labelBookings.Size = new System.Drawing.Size(792, 50);
            this.labelBookings.TabIndex = 4;
            this.labelBookings.Text = "Occupied by";
            this.labelBookings.TextAlignment = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // bookingInfoRightPanel
            // 
            this.bookingInfoRightPanel.Controls.Add(this.editGuestInfo);
            this.bookingInfoRightPanel.Controls.Add(this.bookingInfoUC);
            this.bookingInfoRightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.bookingInfoRightPanel.Location = new System.Drawing.Point(1061, 0);
            this.bookingInfoRightPanel.Name = "bookingInfoRightPanel";
            this.bookingInfoRightPanel.Size = new System.Drawing.Size(270, 589);
            this.bookingInfoRightPanel.TabIndex = 1;
            // 
            // editGuestInfo
            // 
            this.editGuestInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editGuestInfo.Location = new System.Drawing.Point(0, 0);
            this.editGuestInfo.Name = "editGuestInfo";
            this.editGuestInfo.Size = new System.Drawing.Size(270, 589);
            this.editGuestInfo.TabIndex = 1;
            // 
            // bookingInfoUC
            // 
            this.bookingInfoUC.Booking = null;
            this.bookingInfoUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingInfoUC.Location = new System.Drawing.Point(0, 0);
            this.bookingInfoUC.Name = "bookingInfoUC";
            this.bookingInfoUC.Room = null;
            this.bookingInfoUC.Size = new System.Drawing.Size(270, 589);
            this.bookingInfoUC.TabIndex = 0;
            // 
            // bookingsLeftView
            // 
            this.bookingsLeftView.Dock = System.Windows.Forms.DockStyle.Left;
            this.bookingsLeftView.Location = new System.Drawing.Point(0, 0);
            this.bookingsLeftView.Name = "bookingsLeftView";
            this.bookingsLeftView.Size = new System.Drawing.Size(269, 589);
            this.bookingsLeftView.TabIndex = 2;
            this.bookingsLeftView.Text = "radListView1";
            // 
            // navigationPanelBookings
            // 
            this.navigationPanelBookings.Controls.Add(this.searchContainerBookings);
            this.navigationPanelBookings.Controls.Add(this.dateNavigatorBookings);
            this.navigationPanelBookings.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationPanelBookings.Location = new System.Drawing.Point(0, 0);
            this.navigationPanelBookings.Name = "navigationPanelBookings";
            this.navigationPanelBookings.Size = new System.Drawing.Size(1331, 60);
            this.navigationPanelBookings.TabIndex = 1;
            // 
            // searchContainerBookings
            // 
            this.searchContainerBookings.Controls.Add(this.searchTextBoxBookings);
            this.searchContainerBookings.Controls.Add(this.radPanelEmptyBooking);
            this.searchContainerBookings.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchContainerBookings.Location = new System.Drawing.Point(699, 0);
            this.searchContainerBookings.Name = "searchContainerBookings";
            this.searchContainerBookings.Size = new System.Drawing.Size(632, 60);
            this.searchContainerBookings.TabIndex = 1;
            // 
            // searchTextBoxBookings
            // 
            this.searchTextBoxBookings.AutoSize = false;
            this.searchTextBoxBookings.Location = new System.Drawing.Point(3, 10);
            this.searchTextBoxBookings.Name = "searchTextBoxBookings";
            this.searchTextBoxBookings.NullText = "Search by room# or guest name";
            // 
            // 
            // 
            this.searchTextBoxBookings.RootElement.CustomFont = "Roboto";
            this.searchTextBoxBookings.RootElement.CustomFontSize = 8F;
            this.searchTextBoxBookings.Size = new System.Drawing.Size(590, 29);
            this.searchTextBoxBookings.TabIndex = 0;
            // 
            // radPanelEmptyBooking
            // 
            this.radPanelEmptyBooking.Dock = System.Windows.Forms.DockStyle.Right;
            this.radPanelEmptyBooking.Location = new System.Drawing.Point(592, 0);
            this.radPanelEmptyBooking.Name = "radPanelEmptyBooking";
            this.radPanelEmptyBooking.Size = new System.Drawing.Size(40, 60);
            this.radPanelEmptyBooking.TabIndex = 1;
            // 
            // dateNavigatorBookings
            // 
            this.dateNavigatorBookings.BackColor = System.Drawing.Color.Transparent;
            this.dateNavigatorBookings.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateNavigatorBookings.Location = new System.Drawing.Point(0, 0);
            this.dateNavigatorBookings.Name = "dateNavigatorBookings";
            this.dateNavigatorBookings.Size = new System.Drawing.Size(270, 60);
            this.dateNavigatorBookings.TabIndex = 0;
            // 
            // SchedulePage
            // 
            this.SchedulePage.Controls.Add(this.ScheduleRadScheduler);
            this.SchedulePage.Controls.Add(this.scheduleRadSchedulerHeader);
            this.SchedulePage.Controls.Add(this.scheduleBookingPanel);
            this.SchedulePage.Controls.Add(this.scheduleListView);
            this.SchedulePage.Controls.Add(this.scheduleHeaderPanel);
            this.SchedulePage.ItemSize = new System.Drawing.SizeF(70F, 28F);
            this.SchedulePage.Location = new System.Drawing.Point(10, 37);
            this.SchedulePage.Name = "SchedulePage";
            this.SchedulePage.Size = new System.Drawing.Size(1331, 649);
            this.SchedulePage.Text = "SCHEDULE";
            // 
            // ScheduleRadScheduler
            // 
            this.ScheduleRadScheduler.Culture = new System.Globalization.CultureInfo("en-US");
            this.ScheduleRadScheduler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScheduleRadScheduler.Location = new System.Drawing.Point(269, 120);
            this.ScheduleRadScheduler.Name = "ScheduleRadScheduler";
            schedulerDailyPrintStyle1.AppointmentFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            schedulerDailyPrintStyle1.DateEndRange = new System.DateTime(2017, 7, 23, 0, 0, 0, 0);
            schedulerDailyPrintStyle1.DateHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            schedulerDailyPrintStyle1.DateStartRange = new System.DateTime(2017, 7, 18, 0, 0, 0, 0);
            schedulerDailyPrintStyle1.PageHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.ScheduleRadScheduler.PrintStyle = schedulerDailyPrintStyle1;
            this.ScheduleRadScheduler.Size = new System.Drawing.Size(792, 529);
            this.ScheduleRadScheduler.TabIndex = 4;
            this.ScheduleRadScheduler.Text = "radScheduler1";
            // 
            // scheduleRadSchedulerHeader
            // 
            this.scheduleRadSchedulerHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.scheduleRadSchedulerHeader.Location = new System.Drawing.Point(269, 60);
            this.scheduleRadSchedulerHeader.Name = "scheduleRadSchedulerHeader";
            this.scheduleRadSchedulerHeader.Size = new System.Drawing.Size(792, 60);
            this.scheduleRadSchedulerHeader.TabIndex = 3;
            // 
            // scheduleBookingPanel
            // 
            this.scheduleBookingPanel.Controls.Add(this.scheduleBookingInfo);
            this.scheduleBookingPanel.Controls.Add(this.scheduleEditGuestInfo);
            this.scheduleBookingPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.scheduleBookingPanel.Location = new System.Drawing.Point(1061, 60);
            this.scheduleBookingPanel.Name = "scheduleBookingPanel";
            this.scheduleBookingPanel.Size = new System.Drawing.Size(270, 589);
            this.scheduleBookingPanel.TabIndex = 2;
            // 
            // scheduleBookingInfo
            // 
            this.scheduleBookingInfo.Booking = null;
            this.scheduleBookingInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scheduleBookingInfo.Location = new System.Drawing.Point(0, 0);
            this.scheduleBookingInfo.Name = "scheduleBookingInfo";
            this.scheduleBookingInfo.Room = null;
            this.scheduleBookingInfo.Size = new System.Drawing.Size(270, 589);
            this.scheduleBookingInfo.TabIndex = 0;
            // 
            // scheduleEditGuestInfo
            // 
            this.scheduleEditGuestInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scheduleEditGuestInfo.Location = new System.Drawing.Point(0, 0);
            this.scheduleEditGuestInfo.Name = "scheduleEditGuestInfo";
            this.scheduleEditGuestInfo.Size = new System.Drawing.Size(270, 589);
            this.scheduleEditGuestInfo.TabIndex = 0;
            // 
            // scheduleListView
            // 
            this.scheduleListView.Dock = System.Windows.Forms.DockStyle.Left;
            this.scheduleListView.Location = new System.Drawing.Point(0, 60);
            this.scheduleListView.Name = "scheduleListView";
            this.scheduleListView.Size = new System.Drawing.Size(269, 589);
            this.scheduleListView.TabIndex = 1;
            this.scheduleListView.Text = "radListView1";
            // 
            // scheduleHeaderPanel
            // 
            this.scheduleHeaderPanel.Controls.Add(this.scheduleWeeklyButton);
            this.scheduleHeaderPanel.Controls.Add(this.scheduleMonthlyButton);
            this.scheduleHeaderPanel.Controls.Add(this.scheduleDaysButton);
            this.scheduleHeaderPanel.Controls.Add(this.scheduleSearchPanel);
            this.scheduleHeaderPanel.Controls.Add(this.scheduleDateNavigator);
            this.scheduleHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.scheduleHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.scheduleHeaderPanel.Name = "scheduleHeaderPanel";
            this.scheduleHeaderPanel.Size = new System.Drawing.Size(1331, 60);
            this.scheduleHeaderPanel.TabIndex = 0;
            // 
            // scheduleWeeklyButton
            // 
            this.scheduleWeeklyButton.Location = new System.Drawing.Point(392, 12);
            this.scheduleWeeklyButton.Name = "scheduleWeeklyButton";
            this.scheduleWeeklyButton.Size = new System.Drawing.Size(100, 24);
            this.scheduleWeeklyButton.TabIndex = 3;
            this.scheduleWeeklyButton.Text = "Weekly";
            // 
            // scheduleMonthlyButton
            // 
            this.scheduleMonthlyButton.Location = new System.Drawing.Point(494, 12);
            this.scheduleMonthlyButton.Name = "scheduleMonthlyButton";
            this.scheduleMonthlyButton.Size = new System.Drawing.Size(100, 24);
            this.scheduleMonthlyButton.TabIndex = 4;
            this.scheduleMonthlyButton.Text = "Monthly";
            // 
            // scheduleDaysButton
            // 
            this.scheduleDaysButton.Location = new System.Drawing.Point(290, 12);
            this.scheduleDaysButton.Name = "scheduleDaysButton";
            this.scheduleDaysButton.Size = new System.Drawing.Size(100, 24);
            this.scheduleDaysButton.TabIndex = 2;
            this.scheduleDaysButton.Text = "3 Days";
            // 
            // scheduleSearchPanel
            // 
            this.scheduleSearchPanel.Controls.Add(this.scheduleSearchDropDown);
            this.scheduleSearchPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.scheduleSearchPanel.Location = new System.Drawing.Point(681, 0);
            this.scheduleSearchPanel.Name = "scheduleSearchPanel";
            this.scheduleSearchPanel.Size = new System.Drawing.Size(650, 60);
            this.scheduleSearchPanel.TabIndex = 1;
            // 
            // scheduleSearchDropDown
            // 
            this.scheduleSearchDropDown.Location = new System.Drawing.Point(21, 8);
            this.scheduleSearchDropDown.Name = "scheduleSearchDropDown";
            this.scheduleSearchDropDown.NullText = "Search by room# or guest name";
            // 
            // 
            // 
            this.scheduleSearchDropDown.RootElement.EnableElementShadow = false;
            this.scheduleSearchDropDown.Size = new System.Drawing.Size(589, 25);
            this.scheduleSearchDropDown.TabIndex = 0;
            // 
            // scheduleDateNavigator
            // 
            this.scheduleDateNavigator.BackColor = System.Drawing.Color.Transparent;
            this.scheduleDateNavigator.Dock = System.Windows.Forms.DockStyle.Left;
            this.scheduleDateNavigator.Location = new System.Drawing.Point(0, 0);
            this.scheduleDateNavigator.Name = "scheduleDateNavigator";
            this.scheduleDateNavigator.Size = new System.Drawing.Size(270, 60);
            this.scheduleDateNavigator.TabIndex = 0;
            // 
            // HouseKeepingPage
            // 
            this.HouseKeepingPage.Controls.Add(this.houseKeepingSplitContainer);
            this.HouseKeepingPage.Controls.Add(this.houseKeepingListView);
            this.HouseKeepingPage.Controls.Add(this.houseKeepingNavigationPanel);
            this.HouseKeepingPage.ItemSize = new System.Drawing.SizeF(99F, 28F);
            this.HouseKeepingPage.Location = new System.Drawing.Point(10, 37);
            this.HouseKeepingPage.Name = "HouseKeepingPage";
            this.HouseKeepingPage.Size = new System.Drawing.Size(1331, 649);
            this.HouseKeepingPage.Text = "HOUSE KEEPING";
            // 
            // houseKeepingSplitContainer
            // 
            this.houseKeepingSplitContainer.Controls.Add(this.splitPanel1);
            this.houseKeepingSplitContainer.Controls.Add(this.splitPanel2);
            this.houseKeepingSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.houseKeepingSplitContainer.Location = new System.Drawing.Point(269, 60);
            this.houseKeepingSplitContainer.Name = "houseKeepingSplitContainer";
            this.houseKeepingSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // 
            // 
            this.houseKeepingSplitContainer.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.houseKeepingSplitContainer.Size = new System.Drawing.Size(1062, 589);
            this.houseKeepingSplitContainer.TabIndex = 6;
            this.houseKeepingSplitContainer.TabStop = false;
            // 
            // splitPanel1
            // 
            this.splitPanel1.Controls.Add(this.houseKeepingScheduler);
            this.splitPanel1.Controls.Add(this.houseKeepingSchedulerHeaderLabel);
            this.splitPanel1.Location = new System.Drawing.Point(0, 0);
            this.splitPanel1.Name = "splitPanel1";
            // 
            // 
            // 
            this.splitPanel1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel1.Size = new System.Drawing.Size(1062, 292);
            this.splitPanel1.TabIndex = 0;
            this.splitPanel1.TabStop = false;
            // 
            // houseKeepingScheduler
            // 
            this.houseKeepingScheduler.Culture = new System.Globalization.CultureInfo("en-US");
            this.houseKeepingScheduler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.houseKeepingScheduler.Location = new System.Drawing.Point(0, 60);
            this.houseKeepingScheduler.Name = "houseKeepingScheduler";
            schedulerDailyPrintStyle2.AppointmentFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            schedulerDailyPrintStyle2.DateEndRange = new System.DateTime(2017, 8, 6, 0, 0, 0, 0);
            schedulerDailyPrintStyle2.DateHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            schedulerDailyPrintStyle2.DateStartRange = new System.DateTime(2017, 8, 1, 0, 0, 0, 0);
            schedulerDailyPrintStyle2.PageHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.houseKeepingScheduler.PrintStyle = schedulerDailyPrintStyle2;
            this.houseKeepingScheduler.Size = new System.Drawing.Size(1062, 232);
            this.houseKeepingScheduler.TabIndex = 5;
            this.houseKeepingScheduler.Text = "radScheduler1";
            // 
            // houseKeepingSchedulerHeaderLabel
            // 
            this.houseKeepingSchedulerHeaderLabel.AutoSize = false;
            this.houseKeepingSchedulerHeaderLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.houseKeepingSchedulerHeaderLabel.Location = new System.Drawing.Point(0, 0);
            this.houseKeepingSchedulerHeaderLabel.Name = "houseKeepingSchedulerHeaderLabel";
            this.houseKeepingSchedulerHeaderLabel.Size = new System.Drawing.Size(1062, 60);
            this.houseKeepingSchedulerHeaderLabel.TabIndex = 4;
            this.houseKeepingSchedulerHeaderLabel.Text = "radLabel1";
            // 
            // splitPanel2
            // 
            this.splitPanel2.Controls.Add(this.notAssignedGridView);
            this.splitPanel2.Controls.Add(this.notAssignedLabel);
            this.splitPanel2.Location = new System.Drawing.Point(0, 296);
            this.splitPanel2.Name = "splitPanel2";
            // 
            // 
            // 
            this.splitPanel2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel2.Size = new System.Drawing.Size(1062, 293);
            this.splitPanel2.TabIndex = 1;
            this.splitPanel2.TabStop = false;
            // 
            // notAssignedGridView
            // 
            this.notAssignedGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notAssignedGridView.Location = new System.Drawing.Point(0, 30);
            // 
            // 
            // 
            this.notAssignedGridView.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.notAssignedGridView.Name = "notAssignedGridView";
            this.notAssignedGridView.Size = new System.Drawing.Size(1062, 263);
            this.notAssignedGridView.TabIndex = 2;
            this.notAssignedGridView.Text = "radGridView1";
            // 
            // notAssignedLabel
            // 
            this.notAssignedLabel.AutoSize = false;
            this.notAssignedLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.notAssignedLabel.Location = new System.Drawing.Point(0, 0);
            this.notAssignedLabel.Name = "notAssignedLabel";
            this.notAssignedLabel.Size = new System.Drawing.Size(1062, 30);
            this.notAssignedLabel.TabIndex = 3;
            this.notAssignedLabel.Text = "Not assigned rooms";
            // 
            // houseKeepingListView
            // 
            this.houseKeepingListView.Dock = System.Windows.Forms.DockStyle.Left;
            this.houseKeepingListView.Location = new System.Drawing.Point(0, 60);
            this.houseKeepingListView.Name = "houseKeepingListView";
            this.houseKeepingListView.Size = new System.Drawing.Size(269, 589);
            this.houseKeepingListView.TabIndex = 1;
            this.houseKeepingListView.Text = "radListView1";
            // 
            // houseKeepingNavigationPanel
            // 
            this.houseKeepingNavigationPanel.Controls.Add(this.houseKeepingWeeklyToggleButton);
            this.houseKeepingNavigationPanel.Controls.Add(this.houseKeepingMonthlyToggleButton);
            this.houseKeepingNavigationPanel.Controls.Add(this.houseKeepingDaysToggleButton);
            this.houseKeepingNavigationPanel.Controls.Add(this.houseKeepingDateNavigator);
            this.houseKeepingNavigationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.houseKeepingNavigationPanel.Location = new System.Drawing.Point(0, 0);
            this.houseKeepingNavigationPanel.Name = "houseKeepingNavigationPanel";
            this.houseKeepingNavigationPanel.Size = new System.Drawing.Size(1331, 60);
            this.houseKeepingNavigationPanel.TabIndex = 0;
            // 
            // houseKeepingWeeklyToggleButton
            // 
            this.houseKeepingWeeklyToggleButton.Location = new System.Drawing.Point(392, 12);
            this.houseKeepingWeeklyToggleButton.Name = "houseKeepingWeeklyToggleButton";
            this.houseKeepingWeeklyToggleButton.Size = new System.Drawing.Size(100, 24);
            this.houseKeepingWeeklyToggleButton.TabIndex = 6;
            this.houseKeepingWeeklyToggleButton.Text = "Weekly";
            // 
            // houseKeepingMonthlyToggleButton
            // 
            this.houseKeepingMonthlyToggleButton.Location = new System.Drawing.Point(494, 12);
            this.houseKeepingMonthlyToggleButton.Name = "houseKeepingMonthlyToggleButton";
            this.houseKeepingMonthlyToggleButton.Size = new System.Drawing.Size(100, 24);
            this.houseKeepingMonthlyToggleButton.TabIndex = 7;
            this.houseKeepingMonthlyToggleButton.Text = "Monthly";
            // 
            // houseKeepingDaysToggleButton
            // 
            this.houseKeepingDaysToggleButton.Location = new System.Drawing.Point(290, 12);
            this.houseKeepingDaysToggleButton.Name = "houseKeepingDaysToggleButton";
            this.houseKeepingDaysToggleButton.Size = new System.Drawing.Size(100, 24);
            this.houseKeepingDaysToggleButton.TabIndex = 5;
            this.houseKeepingDaysToggleButton.Text = "3 Days";
            // 
            // houseKeepingDateNavigator
            // 
            this.houseKeepingDateNavigator.BackColor = System.Drawing.Color.Transparent;
            this.houseKeepingDateNavigator.Dock = System.Windows.Forms.DockStyle.Left;
            this.houseKeepingDateNavigator.Location = new System.Drawing.Point(0, 0);
            this.houseKeepingDateNavigator.Name = "houseKeepingDateNavigator";
            this.houseKeepingDateNavigator.Size = new System.Drawing.Size(270, 60);
            this.houseKeepingDateNavigator.TabIndex = 1;
            // 
            // ReportsPage
            // 
            this.ReportsPage.Controls.Add(this.reportsTypePanel);
            this.ReportsPage.Controls.Add(this.reportsStatusPanel);
            this.ReportsPage.Controls.Add(this.reportsHeaderPanel);
            this.ReportsPage.ItemSize = new System.Drawing.SizeF(62F, 28F);
            this.ReportsPage.Location = new System.Drawing.Point(10, 37);
            this.ReportsPage.Name = "ReportsPage";
            this.ReportsPage.Size = new System.Drawing.Size(1331, 649);
            this.ReportsPage.Text = "REPORTS";
            // 
            // reportsTypePanel
            // 
            this.reportsTypePanel.Controls.Add(this.userControlBookingsByType1);
            this.reportsTypePanel.Controls.Add(this.reportsBookingsByTypeLabel);
            this.reportsTypePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportsTypePanel.Location = new System.Drawing.Point(0, 450);
            this.reportsTypePanel.Name = "reportsTypePanel";
            this.reportsTypePanel.Size = new System.Drawing.Size(1331, 199);
            this.reportsTypePanel.TabIndex = 2;
            // 
            // userControlBookingsByType1
            // 
            this.userControlBookingsByType1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlBookingsByType1.Location = new System.Drawing.Point(0, 50);
            this.userControlBookingsByType1.Name = "userControlBookingsByType1";
            this.userControlBookingsByType1.Size = new System.Drawing.Size(1331, 149);
            this.userControlBookingsByType1.TabIndex = 2;
            // 
            // reportsBookingsByTypeLabel
            // 
            this.reportsBookingsByTypeLabel.AutoSize = false;
            this.reportsBookingsByTypeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportsBookingsByTypeLabel.Location = new System.Drawing.Point(0, 0);
            this.reportsBookingsByTypeLabel.Name = "reportsBookingsByTypeLabel";
            this.reportsBookingsByTypeLabel.Size = new System.Drawing.Size(1331, 50);
            this.reportsBookingsByTypeLabel.TabIndex = 0;
            this.reportsBookingsByTypeLabel.Text = "Bookings by Type";
            // 
            // reportsStatusPanel
            // 
            this.reportsStatusPanel.Controls.Add(this.userControlCurrentStatus1);
            this.reportsStatusPanel.Controls.Add(this.reportsCurrentStatusLabel);
            this.reportsStatusPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportsStatusPanel.Location = new System.Drawing.Point(0, 60);
            this.reportsStatusPanel.Name = "reportsStatusPanel";
            this.reportsStatusPanel.Size = new System.Drawing.Size(1331, 390);
            this.reportsStatusPanel.TabIndex = 1;
            // 
            // userControlCurrentStatus1
            // 
            this.userControlCurrentStatus1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlCurrentStatus1.Location = new System.Drawing.Point(0, 50);
            this.userControlCurrentStatus1.Name = "userControlCurrentStatus1";
            this.userControlCurrentStatus1.Size = new System.Drawing.Size(1331, 340);
            this.userControlCurrentStatus1.TabIndex = 1;
            // 
            // reportsCurrentStatusLabel
            // 
            this.reportsCurrentStatusLabel.AutoSize = false;
            this.reportsCurrentStatusLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportsCurrentStatusLabel.Location = new System.Drawing.Point(0, 0);
            this.reportsCurrentStatusLabel.Name = "reportsCurrentStatusLabel";
            this.reportsCurrentStatusLabel.Size = new System.Drawing.Size(1331, 50);
            this.reportsCurrentStatusLabel.TabIndex = 0;
            this.reportsCurrentStatusLabel.Text = "Current Status";
            // 
            // reportsHeaderPanel
            // 
            this.reportsHeaderPanel.Controls.Add(this.reportsWeeklyToggleButton);
            this.reportsHeaderPanel.Controls.Add(this.reportsMonthlyToggleButton);
            this.reportsHeaderPanel.Controls.Add(this.reportsDaysToggleButton);
            this.reportsHeaderPanel.Controls.Add(this.reportsDateNavigator);
            this.reportsHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportsHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.reportsHeaderPanel.Name = "reportsHeaderPanel";
            this.reportsHeaderPanel.Size = new System.Drawing.Size(1331, 60);
            this.reportsHeaderPanel.TabIndex = 0;
            // 
            // reportsWeeklyToggleButton
            // 
            this.reportsWeeklyToggleButton.Location = new System.Drawing.Point(392, 12);
            this.reportsWeeklyToggleButton.Name = "reportsWeeklyToggleButton";
            this.reportsWeeklyToggleButton.Size = new System.Drawing.Size(100, 24);
            this.reportsWeeklyToggleButton.TabIndex = 9;
            this.reportsWeeklyToggleButton.Text = "Weekly";
            // 
            // reportsMonthlyToggleButton
            // 
            this.reportsMonthlyToggleButton.Location = new System.Drawing.Point(494, 12);
            this.reportsMonthlyToggleButton.Name = "reportsMonthlyToggleButton";
            this.reportsMonthlyToggleButton.Size = new System.Drawing.Size(100, 24);
            this.reportsMonthlyToggleButton.TabIndex = 10;
            this.reportsMonthlyToggleButton.Text = "Monthly";
            // 
            // reportsDaysToggleButton
            // 
            this.reportsDaysToggleButton.Location = new System.Drawing.Point(290, 12);
            this.reportsDaysToggleButton.Name = "reportsDaysToggleButton";
            this.reportsDaysToggleButton.Size = new System.Drawing.Size(100, 24);
            this.reportsDaysToggleButton.TabIndex = 8;
            this.reportsDaysToggleButton.Text = "3 Days";
            // 
            // reportsDateNavigator
            // 
            this.reportsDateNavigator.BackColor = System.Drawing.Color.Transparent;
            this.reportsDateNavigator.Dock = System.Windows.Forms.DockStyle.Left;
            this.reportsDateNavigator.Location = new System.Drawing.Point(0, 0);
            this.reportsDateNavigator.Name = "reportsDateNavigator";
            this.reportsDateNavigator.Size = new System.Drawing.Size(270, 60);
            this.reportsDateNavigator.TabIndex = 2;
            // 
            // HotelAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 697);
            this.Controls.Add(this.mainContainer);
            this.Name = "HotelAppForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.HotelApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            this.OverviewPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.overviewMainContainer)).EndInit();
            this.overviewMainContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.overviewRoomsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.overviewLeftView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPanelOverview)).EndInit();
            this.navigationPanelOverview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchContainerOverview)).EndInit();
            this.searchContainerOverview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchTextBoxOverview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelEmptyOverview)).EndInit();
            this.BookingsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookingsMainContainer)).EndInit();
            this.bookingsMainContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookingsGrid.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelBookings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingInfoRightPanel)).EndInit();
            this.bookingInfoRightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookingsLeftView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPanelBookings)).EndInit();
            this.navigationPanelBookings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchContainerBookings)).EndInit();
            this.searchContainerBookings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchTextBoxBookings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelEmptyBooking)).EndInit();
            this.SchedulePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleRadScheduler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleRadSchedulerHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBookingPanel)).EndInit();
            this.scheduleBookingPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scheduleListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleHeaderPanel)).EndInit();
            this.scheduleHeaderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scheduleWeeklyButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleMonthlyButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDaysButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleSearchPanel)).EndInit();
            this.scheduleSearchPanel.ResumeLayout(false);
            this.scheduleSearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleSearchDropDown)).EndInit();
            this.HouseKeepingPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.houseKeepingSplitContainer)).EndInit();
            this.houseKeepingSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).EndInit();
            this.splitPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.houseKeepingScheduler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseKeepingSchedulerHeaderLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).EndInit();
            this.splitPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.notAssignedGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notAssignedGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notAssignedLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseKeepingListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseKeepingNavigationPanel)).EndInit();
            this.houseKeepingNavigationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.houseKeepingWeeklyToggleButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseKeepingMonthlyToggleButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseKeepingDaysToggleButton)).EndInit();
            this.ReportsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reportsTypePanel)).EndInit();
            this.reportsTypePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reportsBookingsByTypeLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsStatusPanel)).EndInit();
            this.reportsStatusPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reportsCurrentStatusLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsHeaderPanel)).EndInit();
            this.reportsHeaderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reportsWeeklyToggleButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsMonthlyToggleButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsDaysToggleButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private Telerik.WinControls.UI.RadPageView mainContainer;
        private Telerik.WinControls.UI.RadPageViewPage OverviewPage;
        private Telerik.WinControls.UI.RadPageViewPage BookingsPage;
        private Telerik.WinControls.UI.RadPageViewPage SchedulePage;
        private Telerik.WinControls.UI.RadPageViewPage HouseKeepingPage;
        private Telerik.WinControls.UI.RadPanel navigationPanelOverview;
        private Telerik.WinControls.UI.RadListView overviewLeftView;
        private Telerik.WinControls.UI.RadListView overviewRoomsView;
        private DateNavigator dateNavigatorOverview;
        private Telerik.WinControls.UI.RadPanel searchContainerOverview;
        private SearchTextBox searchTextBoxOverview;
        private Telerik.WinControls.UI.RadPanel radPanelEmptyOverview;
        private Telerik.WinControls.UI.RadPanel navigationPanelBookings;
        private Telerik.WinControls.UI.RadPanel searchContainerBookings;
        private SearchTextBox searchTextBoxBookings;
        private Telerik.WinControls.UI.RadPanel radPanelEmptyBooking;
        private DateNavigator dateNavigatorBookings;
        private Telerik.WinControls.UI.RadListView bookingsLeftView;
        private Telerik.WinControls.UI.RadPanel bookingsMainContainer;
        private Telerik.WinControls.UI.RadGridView bookingsGrid;
        private Telerik.WinControls.UI.RadLabel labelBookings;
        private Telerik.WinControls.UI.RadPanel overviewMainContainer;
        private Telerik.WinControls.UI.RadPageViewPage ReportsPage;
        private Telerik.WinControls.UI.RadPanel bookingInfoRightPanel;
        private BookingInfo bookingInfoUC;
        private EditGuestInfo editGuestInfo;
        private Telerik.WinControls.UI.RadPanel scheduleHeaderPanel;
        private Telerik.WinControls.UI.RadListView scheduleListView;
        private DateNavigator scheduleDateNavigator;
        private Telerik.WinControls.UI.RadPanel scheduleSearchPanel;
        private Telerik.WinControls.UI.RadToggleButton scheduleMonthlyButton;
        private Telerik.WinControls.UI.RadToggleButton scheduleWeeklyButton;
        private Telerik.WinControls.UI.RadToggleButton scheduleDaysButton;
        private Telerik.WinControls.UI.RadPanel scheduleBookingPanel;
        private BookingInfo scheduleBookingInfo;
        private Telerik.WinControls.UI.RadScheduler ScheduleRadScheduler;
        private Telerik.WinControls.UI.RadPanel scheduleRadSchedulerHeader;
        private EditGuestInfo scheduleEditGuestInfo;
        private SearchDropDownList scheduleSearchDropDown;
        private Telerik.WinControls.UI.RadLabel notAssignedLabel;
        private Telerik.WinControls.UI.RadGridView notAssignedGridView;
        private Telerik.WinControls.UI.RadListView houseKeepingListView;
        private Telerik.WinControls.UI.RadPanel houseKeepingNavigationPanel;
        private Telerik.WinControls.UI.RadScheduler houseKeepingScheduler;
        private Telerik.WinControls.UI.RadLabel houseKeepingSchedulerHeaderLabel;
        private DateNavigator houseKeepingDateNavigator;
        private Telerik.WinControls.UI.RadToggleButton houseKeepingWeeklyToggleButton;
        private Telerik.WinControls.UI.RadToggleButton houseKeepingMonthlyToggleButton;
        private Telerik.WinControls.UI.RadToggleButton houseKeepingDaysToggleButton;
        private RadSplitContainer houseKeepingSplitContainer;
        private Telerik.WinControls.UI.SplitPanel splitPanel1;
        private Telerik.WinControls.UI.SplitPanel splitPanel2;
        private RadPanel reportsHeaderPanel;
        private RadPanel reportsTypePanel;
        private RadPanel reportsStatusPanel;
        private DateNavigator reportsDateNavigator;
        private RadToggleButton reportsWeeklyToggleButton;
        private RadToggleButton reportsMonthlyToggleButton;
        private RadToggleButton reportsDaysToggleButton;
        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.Themes.MaterialPinkTheme materialPinkTheme1;
        private Telerik.WinControls.Themes.MaterialBlueGreyTheme materialBlueGreyTheme1;
        private RadLabel reportsBookingsByTypeLabel;
        private UserControlCurrentStatus userControlCurrentStatus1;
        private RadLabel reportsCurrentStatusLabel;
        private UserControlBookingsByType userControlBookingsByType1;
    }
}