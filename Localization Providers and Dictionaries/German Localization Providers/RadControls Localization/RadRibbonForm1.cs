using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Security;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Telerik.Data.Expressions;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Scheduler.Dialogs;

namespace GermanRadControlsLocalization
{
    public partial class RadRibbonForm1 : Telerik.WinControls.UI.RadRibbonForm
    {
        #region Fields 

        private int columnNum;
        private string[] comboItems = new string[]
        {
            "Sales Representative",
            "Owner",
            "Order Administrator",
            "Accounting Manager",
            "Sales Manger"
        };


        /// <summary>
        /// GridViewPrinting
        /// </summary>
        ViewDefinitionInfo columnGroupViewInfo;
        Font italicFont = new Font("Segoe UI", 9f, FontStyle.Italic);


        /// <summary>
        /// Scheduler printing
        /// </summary>
        private Telerik.WinControls.UI.RadPrintDocument radPrintDocument2;
        private Telerik.WinControls.UI.SchedulerDailyPrintStyle schedulerDailyPrintStyle1;

        #endregion

        public RadRibbonForm1()
        {
            InitializeComponent();

            this.radGridView1.ViewCellFormatting += new CellFormattingEventHandler(radGridView1_ViewCellFormatting);

            try
            {

                ExpressionContext.Context = new CustomExpressionContext();
                RadExpressionEditorForm.ExpressionItemsList.LoadFromXML(@".\functions.xml");
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, RadMessageIcon.Error);
                //throw;
            }
        }

        private void RadRibbonForm1_Load(object sender, EventArgs e)
        {
            InitializeRadRibbonBar();
            InitializeRadGridView();
            InitializeRadTreeView();
            InitializeRadCalendar();
            InitializeRadDateTimePicker();
            InitializeRadPropertyGrid();
            InitializeRadScheduler();
            InitializeRadMarkupEditor();
            InitializeRadWizard();
            InitializeColorDialog();
            InitializeCommandBar();
            InitializeRadGridViewPrinting();
            InitializeRadSchedulerPrinting();
            InitializeRadSpellChecker();

            RadPageViewStripElement strip = this.radPageView1.ViewElement as RadPageViewStripElement;
            strip.StripButtons = StripViewButtons.All;

        }

        #region RadPropertyGrid

        private void InitializeRadPropertyGrid()
        {
            this.radPropertyGrid1.HelpVisible = true;
            this.radPropertyGrid1.ToolbarVisible = true;
            this.radPropertyGrid1.SelectedObject = new RadPropertyGrid();


        }

        #endregion

        #region RadDateTimePicker

        private void InitializeRadDateTimePicker()
        {
            // Initialize RadDateTimePicker
            this.radDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.radDateTimePicker1.CustomFormat = "dd/MM/yyyy";

            // Localize DateTimePicker            
            this.radDateTimePicker1.Culture = new System.Globalization.CultureInfo("de-DE");
            RadDateTimePickerCalendar calendarBehavior = this.radDateTimePicker1.DateTimePickerElement.GetCurrentBehavior() as RadDateTimePickerCalendar;
            RadCalendar calendar = calendarBehavior.Calendar as RadCalendar;

            calendar.FastNavigationStep = 3;
            calendar.DayNameFormat = Telerik.WinControls.UI.DayNameFormat.FirstTwoLetters;
            calendar.NavigationNextToolTip = "nächster Monat";
            calendar.NavigationPrevToolTip = "vorheriger Monat";
            calendar.FastNavigationNextToolTip = String.Format("nächste {0} Monate", calendar.FastNavigationStep);
            calendar.FastNavigationPrevToolTip = String.Format("vorherige {0} Monate", calendar.FastNavigationStep);
            calendar.ShowFooter = true;
            calendar.ShowHeader = true;
            calendar.ShowColumnHeaders = true;
            calendar.ShowNavigationButtons = true;
            calendar.ShowFastNavigationButtons = true;
            calendar.AllowSelect = true;
            calendar.ShowRowHeaders = true;

            calendar.Culture = new System.Globalization.CultureInfo("de-DE");
            calendar.TodayButton.Text = "Heute";
            calendar.ClearButton.Text = "Löschen";
            calendar.NavigationNextToolTip = "nächster Monat";
            calendar.NavigationPrevToolTip = "vorheriger Monat";
            calendar.FastNavigationNextToolTip = String.Format("nächste {0} Monate", calendar.FastNavigationStep);
            calendar.FastNavigationPrevToolTip = String.Format("vorherige {0} Monate", calendar.FastNavigationStep);

        }

        #endregion

        #region RadCalendar

        private void InitializeRadCalendar()
        {
            // Initialize Calendar
            this.radCalendar1.ShowFooter = true;
            this.radCalendar1.ShowHeader = true;
            this.radCalendar1.ShowColumnHeaders = true;
            this.radCalendar1.ShowNavigationButtons = true;
            this.radCalendar1.ShowFastNavigationButtons = true;
            this.radCalendar1.DayNameFormat = Telerik.WinControls.UI.DayNameFormat.FirstTwoLetters;
            this.radCalendar1.AllowSelect = true;
            this.radCalendar1.AllowMultipleSelect = true;
            this.radCalendar1.AllowViewSelector = true;
            this.radCalendar1.ShowRowHeaders = true;
            this.radCalendar1.AllowRowHeaderSelectors = true;
            this.radCalendar1.FastNavigationStep = 3;

            // Localize Calendar 
            this.radCalendar1.Culture = new System.Globalization.CultureInfo("de-DE");
            this.radCalendar1.TodayButton.Text = "Heute";
            this.radCalendar1.ClearButton.Text = "Löschen";
            this.radCalendar1.NavigationNextToolTip = "nächster Monat";
            this.radCalendar1.NavigationPrevToolTip = "vorheriger Monat";
            this.radCalendar1.FastNavigationNextToolTip = String.Format("nächste {0} Monate", this.radCalendar1.FastNavigationStep);
            this.radCalendar1.FastNavigationPrevToolTip = String.Format("vorherige {0} Monate", this.radCalendar1.FastNavigationStep);

        }

        #endregion

        #region RadTreeView

        private void InitializeRadTreeView()
        {
            this.radTreeView1.ItemHeight = 27;

            this.radTreeView1.Nodes.Add(new RadTreeNode("Personal Folders"));
            this.radTreeView1.Nodes[0].Nodes.Add(new RadTreeNode("Deleted Items"));
            this.radTreeView1.Nodes[0].Nodes.Add(new RadTreeNode("Drafts"));
            this.radTreeView1.Nodes[0].Nodes.Add(new RadTreeNode("Inbox"));
            this.radTreeView1.Nodes[0].Nodes.Add(new RadTreeNode("Junk E-mails"));
            this.radTreeView1.Nodes[0].Nodes.Add(new RadTreeNode("Outbox"));
            this.radTreeView1.Nodes[0].Nodes.Add(new RadTreeNode("Sent Items"));
            this.radTreeView1.Nodes[0].Nodes.Add(new RadTreeNode("Search Folder"));
            this.radTreeView1.Nodes[0].Nodes[2].Nodes.Add(new RadTreeNode("Folders"));
            this.radTreeView1.Nodes[0].Nodes[6].Nodes.Add(new RadTreeNode("From Follow up"));
            this.radTreeView1.Nodes[0].Nodes[6].Nodes.Add(new RadTreeNode("Large Mail"));
            this.radTreeView1.Nodes[0].Nodes[6].Nodes.Add(new RadTreeNode("Unread Mail"));
            this.radTreeView1.Nodes[0].Nodes[2].Nodes[0].ItemHeight = 50;

            this.radTreeView1.ExpandAll();
            this.radTreeView1.Nodes[0].Nodes[1].Current = true;
            this.radTreeView1.Nodes[0].Nodes[1].Selected = true;

            this.radTreeView1.AllowAdd = true;
            this.radTreeView1.AllowRemove = true;
            this.radTreeView1.ExpandAnimation = ExpandAnimation.None;
            this.radTreeView1.AllowPlusMinusAnimation = false;
            this.radTreeView1.PlusMinusAnimationStep = 1;
            this.radTreeView1.FullRowSelect = true;
            this.radTreeView1.ShowExpandCollapse = true;
            this.radTreeView1.ShowRootLines = true;
            this.radTreeView1.ShowLines = true;
            this.radTreeView1.AllowEdit = true;
            this.radTreeView1.AllowDefaultContextMenu = true;
            this.radTreeView1.AllowDragDrop = true;


        }

        #endregion

        #region RadGridView

        private void InitializeRadGridView()
        {
            this.radGridView1.ShowGroupPanel = false;
            this.radGridView1.EnableGrouping = false;

            string[] columnTypes = new string[]
            {
                "Text", // 0
                "NumericText", //1
                "Decimal", // 2
                "DateTime", // 3
                "ComboBox", // 4
                "Command", // 5
                "CheckBox"  // 6
    			
            };

            foreach (string t in columnTypes)
            {
                GridViewDataColumn newColumn = AppendNewColumn(t, false);
                this.radGridView1.Columns.Add(newColumn);
            }

            GridViewDecimalColumn radiusColumn = new GridViewDecimalColumn();
            radiusColumn.Name = "Radius";
            radiusColumn.HeaderText = "Radius";
            this.radGridView1.Columns.Insert(7, radiusColumn);

            GridViewHyperlinkColumn hyperlinkColumn = new GridViewHyperlinkColumn("Hyperlink");
            hyperlinkColumn.ReadOnly = true;
            hyperlinkColumn.Width = 200;
            this.radGridView1.Columns.Add(hyperlinkColumn);

            GridViewColorColumn colorColumn = new GridViewColorColumn("Color");
            colorColumn.Width = 100;
            this.radGridView1.Columns.Add(colorColumn);

            GridViewBrowseColumn browseColumn = new GridViewBrowseColumn("Browse");
            browseColumn.Width = 180;
            this.radGridView1.Columns.Add(browseColumn);

            GridViewDataColumn newColumn2 = AppendNewColumn("CustomExpression", false);
            this.radGridView1.Columns.Add(newColumn2);

            DateTime date = DateTime.Now;
            //add new unbound rows solution I
            GridViewRowInfo rowInfo = this.radGridView1.Rows.AddNew();
            rowInfo.Cells[0].Value = "Maria Anders";
            rowInfo.Cells[1].Value = 1000;
            rowInfo.Cells[2].Value = 10000.01f;
            rowInfo.Cells[3].Value = date.AddDays(1);
            rowInfo.Cells[4].Value = "Sales Representative";
            rowInfo.Cells[5].Value = "Button 1";
            rowInfo.Cells[6].Value = true;
            rowInfo.Cells[7].Value = 12.37;
            rowInfo.Cells[8].Value = "http://www.telerik.com";
            rowInfo.Cells[9].Value = "Red";
            rowInfo.Cells[10].Value = @"C:\Music\Sting\Russians.wav";
            ;

            rowInfo = this.radGridView1.Rows.AddNew();
            rowInfo.Cells[0].Value = "Hanna Moos";
            rowInfo.Cells[1].Value = 2000;
            rowInfo.Cells[2].Value = 20000.02f;
            rowInfo.Cells[3].Value = date.AddDays(2);
            rowInfo.Cells[4].Value = "Owner";
            rowInfo.Cells[5].Value = "Button 2";
            rowInfo.Cells[6].Value = false;
            rowInfo.Cells[7].Value = 5.00;
            rowInfo.Cells[8].Value = "http://www.cnn.com";
            rowInfo.Cells[9].Value = "Orange";
            rowInfo.Cells[10].Value = @"C:\Music\Sheryl Crow\Maybe Angels.wav";

            //add new unbound rows solution II
            this.radGridView1.Rows.Add("Roland Mendel", 3000, 30000.03f, date.AddDays(3), "Order Administrator", "Button 3", true, 30.21,
                            "http://www.bbc.com", "Blue", @"Love Is the Seventh Wave.wav");
            this.radGridView1.Rows.Add("Diego Roel", 4000, 40000.04f, date.AddDays(4), "Accounting Manager", "Button 4", false, 11.11,
                            "http://www.google.com", "Yellow", @"C:\Music\Sheryl Crow\Run, Baby, Run.wav");
            this.radGridView1.Rows.Add("Janine Labrune", 5000, 50000.05f, date.AddDays(5), "Sales Manger", "Button 5", true, 7.36,
                            "http://www.microsoft.com", "Indigo", @"C:\Music\Sheryl Crow\Strong Enough.wav");

            this.radGridView1.TableElement.UpdateView();
            this.radGridView1.CurrentRow = this.radGridView1.Rows[0];

            this.radGridView1.Columns["CustomExpression"].Expression = "ROUND(PI() * POWER(Radius, 2) + Decimal)";

            // Excel like filtering

            this.radGridView1.EnableFiltering = true;
            this.radGridView1.MasterTemplate.ShowHeaderCellButtons = true;
            this.radGridView1.MasterTemplate.ShowFilteringRow = false;

            foreach (GridViewDataColumn column in this.radGridView1.Columns)
            {
                column.BestFit();
            }

        }

        private GridViewDataColumn AppendNewColumn(string columnType, bool numberInTheHeader)
        {
            GridViewDataColumn newColumn = null;

            switch (columnType)
            {
                case "Text":
                    newColumn = new GridViewTextBoxColumn();
                    newColumn.FieldName = "Text";
                    break;
                case "NumericText":
                    newColumn = new GridViewMaskBoxColumn();
                    ((GridViewMaskBoxColumn)newColumn).Mask = "f";
                    newColumn.TextAlignment = ContentAlignment.MiddleLeft;
                    newColumn.FieldName = "NumericText";
                    newColumn.EnableExpressionEditor = true;
                    break;
                case "Decimal":
                    newColumn = new GridViewDecimalColumn();
                    newColumn.TextAlignment = ContentAlignment.MiddleRight;
                    newColumn.FieldName = "Decimal";
                    newColumn.EnableExpressionEditor = true;
                    break;
                case "DateTime":
                    newColumn = new GridViewDateTimeColumn();
                    newColumn.FormatString = "{0:MM-dd-yyyy}";
                    newColumn.TextAlignment = ContentAlignment.MiddleRight;
                    newColumn.FieldName = "DateTime";
                    newColumn.EnableExpressionEditor = true;
                    break;
                case "Image":
                    newColumn = new GridViewImageColumn();
                    ((GridViewImageColumn)newColumn).ImageLayout = ImageLayout.Center;
                    newColumn.Width = 40;
                    newColumn.FieldName = "Image";
                    break;
                case "ComboBox":
                    newColumn = new GridViewComboBoxColumn();
                    ((GridViewComboBoxColumn)newColumn).DataSource = this.comboItems;
                    newColumn.Width = 100;
                    newColumn.FieldName = "ComboBox";
                    break;
                case "Command":
                    newColumn = new GridViewCommandColumn();
                    ((GridViewCommandColumn)newColumn).TextAlignment = ContentAlignment.MiddleCenter;
                    newColumn.FieldName = "Command";
                    break;
                case "CheckBox":
                    newColumn = new GridViewCheckBoxColumn();
                    newColumn.Width = 50;
                    newColumn.FieldName = "CheckBox";
                    newColumn.EnableExpressionEditor = true;
                    break;
                case "CustomExpression":
                    newColumn = new GridViewDecimalColumn();
                    newColumn.EnableExpressionEditor = true;
                    newColumn.Name = "CustomExpression";
                    newColumn.HeaderText = "Custom Expression";
                    newColumn.Width = 80;
                    break;
            }

            if (numberInTheHeader)
            {
                newColumn.HeaderText = (this.columnNum++).ToString() + " - " + columnType;
            }
            else
            {
                newColumn.HeaderText = columnType;
            }

            newColumn.IsVisible = true;

            return newColumn;
        }

        void radGridView1_ViewCellFormatting(object sender, CellFormattingEventArgs e)
        {

            if (e.CellElement is GridHeaderCellElement && e.CellElement.ColumnInfo.Name == "ComboBox")
            {
                if (radGridView1.Columns["ComboBox"].FilterDescriptor != null)
                {
                    ((GridHeaderCellElement)e.CellElement).FilterButton.ToolTipText = radGridView1.Columns["ComboBox"].FilterDescriptor.ToString();
                }
            }
        }

        #endregion

        #region RibbonBar

        private void InitializeRadRibbonBar()
        {
            // Localize RibbonBar
            this.radRibbonBar1.LocalizationSettings.MaximizeRibbonItemText = "Menüband ma&ximieren";
            this.radRibbonBar1.LocalizationSettings.MinimizeRibbonItemText = "Menüband mi&nimieren";
            this.radRibbonBar1.LocalizationSettings.ShowQuickAccessMenuAboveItemText = "Über dem &Menüband anzeigen";
            this.radRibbonBar1.LocalizationSettings.ShowQuickAccessMenuBelowItemText = "Unter dem &Menüband anzeigen";

            this.radRibbonBar1.OptionsButton.Text = "Optionen";
            this.radRibbonBar1.ExitButton.Text = "Beenden";

            // Create Menu
            RadMenuItem menuItem1 = new RadMenuItem("Neu");

            this.radRibbonBar1.StartMenuItems.AddRange(new RadItem[]
                {
                        menuItem1
                }
            );

            // Create QuickAccessToolBar
            RadButtonElement buttonNew = new RadButtonElement("Neu");

            this.radRibbonBar1.QuickAccessToolBarItems.AddRange(new RadItem[]
                {
                        buttonNew,
                }
            );

            this.radRibbonBar1.QuickAccessToolbarBelowRibbon = false;
        }

        private void radButtonElement1_Click(object sender, EventArgs e)
        {
            // Change to german language
            LocalizationProviders.ChangeLanguage(true);
        }

        private void radButtonElement2_Click(object sender, EventArgs e)
        {
            // Change to english language
            LocalizationProviders.ChangeLanguage(false);
        }

        #endregion

        #region MessageBox

        private void radButton1_Click(object sender, EventArgs e)
        {
            RadMessageBox.Show("Test", "Information", MessageBoxButtons.OKCancel);
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            RadMessageBox.Show("Test", "Information", MessageBoxButtons.AbortRetryIgnore);

        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            RadMessageBox.Show("Test", "Information", MessageBoxButtons.YesNoCancel);

        }

        #endregion

        #region Scheduler

        private SchedulerCustomEditAppointmentDialog appointmentDialog = null;
        private SchedulerCustomAlarmForm customAlarmForm = null;
        private List<IRemindObject> openedAlerts = new List<IRemindObject>();
        private Timer initialTimer;

        private void InitializeRadScheduler()
        {
            // Initialize Calendar
            this.radCalendar2.ShowColumnHeaders = true;
            this.radCalendar2.ShowFastNavigationButtons = true;
            this.radCalendar2.ShowFooter = true;
            this.radCalendar2.ShowHeader = true;
            this.radCalendar2.ShowNavigationButtons = true;
            this.radCalendar2.ShowOtherMonthsDays = false;
            this.radCalendar2.ShowRowHeaders = true;
            this.radCalendar2.DayNameFormat = Telerik.WinControls.UI.DayNameFormat.FirstTwoLetters;
            this.radCalendar2.AllowSelect = true;
            this.radCalendar2.AllowMultipleSelect = false;
            this.radCalendar2.AllowViewSelector = true;
            this.radCalendar2.AllowRowHeaderSelectors = false;
            this.radCalendar2.FastNavigationStep = 4;
            this.radCalendar2.TitleFormat = "MMMM";

            this.radCalendar2.AllowMultipleView = true;
            this.radCalendar2.MultiViewColumns = 1;
            this.radCalendar2.MultiViewRows = 3;

            this.radCalendar2.SelectedDate = DateTime.Today;
            this.radCalendar2.SelectionChanged += new EventHandler(radCalendar2_SelectionChanged);

            // Add ClickEvent for the Today Button
            this.radCalendar2.TodayButton.Click += new EventHandler(TodayButton_Click);
            // Clear Button is not usefull, so Disable it
            this.radCalendar2.ClearButton.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;


            // Localize Calendar 
            this.radCalendar2.Culture = new System.Globalization.CultureInfo("de-DE");
            this.radCalendar2.TodayButton.Text = "Heute";
            this.radCalendar2.ClearButton.Text = "Löschen";
            this.radCalendar2.NavigationNextToolTip = "nächster Monat";
            this.radCalendar2.NavigationPrevToolTip = "vorheriger Monat";
            this.radCalendar2.FastNavigationNextToolTip = String.Format("nächste {0} Monate", this.radCalendar2.FastNavigationStep);
            this.radCalendar2.FastNavigationPrevToolTip = String.Format("vorherige {0} Monate", this.radCalendar2.FastNavigationStep);


            // Initialize Scheduler
            this.customAlarmForm = new SchedulerCustomAlarmForm();

            this.radSchedulerNavigator1.DateFormat = "dd. MMMM yyyy";

            // !!!!!!!!!! Schaltet in der Monatssicht den Monatskalender ein !!!!!
            this.radSchedulerNavigator1.AutomaticNavigation = true;

            this.radScheduler1.AppointmentFactory = new SchedulerCustomAppointmentFactory();

            this.radScheduler1.GetDayView().DayCount = 1;
            this.radSchedulerNavigator1.ShowWeekendStateChanged += new StateChangedEventHandler(radSchedulerNavigator1_ShowWeekendStateChanged);

            this.radScheduler1.PropertyChanged += new PropertyChangedEventHandler(radScheduler1_PropertyChanged);
            this.radScheduler1.Appointments.CollectionChanged += new Telerik.WinControls.Data.NotifyCollectionChangedEventHandler(Appointments_CollectionChanged);
            this.radScheduler1.AppointmentTitleFormat = "{2} ({3})";

            //this.radSchedulerNavigator1.TimelineViewButtonVisible = false;

            this.InitializeTimeZones();

            // initialize Timer
            this.initialTimer = new Timer();
            this.initialTimer.Interval = 2000;
            this.initialTimer.Tick += new EventHandler(initialTimer_Tick);
            this.initialTimer.Start();


            this.radCalendar2.ViewChanged += new EventHandler(radCalendar2_ViewChanged);

            CreateSchedulerDemoData();

            this.InitializeCalendar2();

            this.radScheduler1.ActiveViewType = SchedulerViewType.Week;
            (this.radScheduler1.ActiveView as SchedulerDayViewBase).RangeFactor = ScaleRange.HalfHour;
            (this.radScheduler1.ActiveView as SchedulerDayViewBase).RulerWidth = 45;

            SchedulerDayViewElement dayView = this.radScheduler1.SchedulerElement.ViewElement as SchedulerDayViewElement;
            RulerPrimitive ruler = (this.radScheduler1.SchedulerElement.ViewElement as SchedulerDayViewElement).DataAreaElement.Ruler;
            if (ruler != null)
            {
                ruler.RulerWidth = 43;
            }

            if (dayView != null)
            {
                dayView.DataAreaElement.Table.ScrollToWorkHours();

            }

            this.radScheduler1.ActiveViewChanged += new EventHandler<SchedulerViewChangedEventArgs>(radScheduler1_ActiveViewChanged);

            this.radSchedulerNavigator1.SchedulerNavigatorElement.NavigateTodayButton.Click += new EventHandler(NavigateTodayButton_Click);

        }

        private void NavigateTodayButton_Click(object sender, EventArgs e)
        {
            if (this.radScheduler1.ActiveViewType == SchedulerViewType.Month)
            {
                SchedulerMonthView view = this.radScheduler1.GetMonthView();
                DateTime today = DateTime.Now;
                //view.StartDate = new DateTime( today.Year , today.Month , 1 );
                //view.StartDate = new DateTime( view.StartDate.Year , view.StartDate.Month , 1 );
            }
        }

        private void InitializeTimeZones()
        {
            List<SchedulerTimeZone> listOfTimeZones = SchedulerTimeZone.GetSchedulerTimeZones();

            foreach (SchedulerTimeZone timezone in listOfTimeZones)
            {
                timezone.Label = timezone.Label.Replace("(", string.Empty);
                timezone.Label = timezone.Label.Replace(")", string.Empty);
            }

            this.radDropDownList1.DataSource = new List<SchedulerTimeZone>(listOfTimeZones);
        }


        private void TodayButton_Click(object sender, EventArgs e)
        {
            this.radCalendar1.SelectedDates.Clear();
            this.radScheduler1.ActiveView.StartDate = DateTime.Today;
        }


        private void radScheduler1_AppointmentEditDialogShowing(object sender, AppointmentEditDialogShowingEventArgs e)
        {

            if (this.appointmentDialog == null)
            {
                this.appointmentDialog = new SchedulerCustomEditAppointmentDialog();
            }

            e.AppointmentEditDialog = this.appointmentDialog;

        }

        void initialTimer_Tick(object sender, EventArgs e)
        {
            this.initialTimer.Stop();
            this.initialTimer.Dispose();

            this.ReminderApplySchedulerSettings();
        }

        private void ReminderApplySchedulerSettings()
        {
            this.radSchedulerReminder1.AssociatedScheduler = this.radScheduler1;
            this.radSchedulerReminder1.RemindObjectShown += new EventHandler<RadShowRemindObjectArgs>(radSchedulerReminder1_RemindObjectShown);
            this.radSchedulerReminder1.ItemOpened += new EventHandler<RadOpenItemArgs>(radSchedulerReminder1_ItemOpened);
            this.radSchedulerReminder1.AlarmFormShowing += new EventHandler<RadAlarmFormShowingEventArgs>(radSchedulerReminder1_ShowingAlarmForm);
            this.radSchedulerReminder1.StartReminderInterval = this.radScheduler1.ActiveView.StartDate;
            this.radSchedulerReminder1.EndReminderInterval = DateHelper.GetEndOfDay(DateTime.Now);
            this.radSchedulerReminder1.StartReminder();
        }

        void radSchedulerReminder1_ItemOpened(object sender, RadOpenItemArgs e)
        {
            if (this.appointmentDialog == null)
            {
                this.appointmentDialog = new SchedulerCustomEditAppointmentDialog((IEvent)e.RemindObject, this.radScheduler1);
            }

            SchedulerCustomEditAppointmentDialog editAppointmentDialog = this.appointmentDialog;
            editAppointmentDialog.ShowDialog(this);
        }

        void radSchedulerReminder1_RemindObjectShown(object sender, RadShowRemindObjectArgs e)
        {
            if (this.openedAlerts.Contains(e.RemindObject))
            {
                return;
            }

            Telerik.WinControls.UI.RadDesktopAlert radDesktopAlert = new Telerik.WinControls.UI.RadDesktopAlert(this.components);

            //System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( Form1 ) );

            RadButtonElement radButtonElement = new RadButtonElement();
            radButtonElement.Click += new EventHandler(radButtonElement_Click);
            radButtonElement.Tag = e.RemindObject;
            radButtonElement.Image = null; //   ( ( Image ) ( resources.GetObject( "SymbolEdit" ) ) );


            this.openedAlerts.Add(e.RemindObject);

            radDesktopAlert.ButtonItems.Add(radButtonElement);

            radDesktopAlert.FixedSize = new System.Drawing.Size(329, 120);
            radDesktopAlert.ContentImage = null; // ( ( Image ) ( resources.GetObject( "ClockAlarm" ) ) );

            radDesktopAlert.ContentText = "<html><I>" + ((Appointment)e.RemindObject).Description + "</I></html>";
            radDesktopAlert.CaptionText = e.RemindObject.Subject;
            radDesktopAlert.Show();
            radDesktopAlert.Closed += new RadPopupClosedEventHandler(radDesktopAlert_AlertClosed);
        }

        void radSchedulerReminder1_ShowingAlarmForm(object sender, RadAlarmFormShowingEventArgs e)
        {
            e.AlarmForm = this.customAlarmForm;
        }

        void radDesktopAlert_AlertClosed(object sender, RadPopupClosedEventArgs args)
        {
            Telerik.WinControls.UI.RadDesktopAlert radDesktopAlert = sender as Telerik.WinControls.UI.RadDesktopAlert;
            this.openedAlerts.Remove((IRemindObject)radDesktopAlert.ButtonItems[0].Tag);
        }

        void radButtonElement_Click(object sender, EventArgs e)
        {
            RadButtonElement radButtonElement = sender as RadButtonElement;
            EditAppointmentDialog editAppointmentDialog = new EditAppointmentDialog((IEvent)radButtonElement.Tag, this.radScheduler1);
            editAppointmentDialog.ShowDialog(this);
        }

        void radCalendar2_ViewChanged(object sender, EventArgs e)
        {
            InitializeCalendar2();
        }

        void radScheduler1_ActiveViewChanged(object sender, SchedulerViewChangedEventArgs e)
        {
            if (e.NewView as SchedulerMonthView == null)
            {
                SchedulerDayViewBase dayBase = (this.radScheduler1.ActiveView as SchedulerDayViewBase);

                if (dayBase != null)
                {
                    if (e.OldView != null && e.NewView != null)
                    {
                        if (e.NewView.ViewType != e.OldView.ViewType)
                        {
                            dayBase.RangeFactor = ScaleRange.HalfHour;
                        }
                    }

                    SchedulerDayViewElement dayView = this.radScheduler1.SchedulerElement.ViewElement as SchedulerDayViewElement;

                    dayView.DataAreaElement.Table.ScrollToWorkHours();
                }
            }

            if (e.NewView.ViewType != e.OldView.ViewType && e.NewView.ViewType == SchedulerViewType.Month)
            {
                this.radScheduler1.GetMonthView().WeekCount = 5;
            }

            if (e.NewView.ViewType != e.OldView.ViewType)
            {
                SchedulerDayViewBase view = e.NewView as SchedulerDayViewBase;
                if (view != null)
                {
                    UpdateControls(true);
                    view.RulerWidth = 55;
                }
                else
                {
                    UpdateControls(false);
                }

                e.NewView.DefaultTimeZone = e.OldView.DefaultTimeZone;
            }

        }

        private void UpdateControls(bool isDayView)
        {
            this.radButton4.Visible = isDayView;
            this.radDropDownList1.Visible = isDayView;
        }

        void Appointments_CollectionChanged(object sender, Telerik.WinControls.Data.NotifyCollectionChangedEventArgs e)
        {
            InitializeCalendar2();
        }

        private void InitializeCalendar2()
        {
            MultiMonthViewElement viewElement = this.radCalendar2.CalendarElement.CalendarVisualElement as MultiMonthViewElement;

            this.radCalendar2.CalendarElement.Margin = new Padding(0, 0, 0, 14);

            if (viewElement != null)
            {
                CalendarMultiMonthViewTableElement table = viewElement.GetMultiTableElement();

                foreach (MonthViewElement monthView in table.Children)
                {
                    monthView.TitleElement.Margin = new Padding(-4, -2, -2, -2);
                    monthView.TitleElement.Padding = new Padding(3);

                    Font BoldFont = null;

                    foreach (CalendarCellElement cell in monthView.TableElement.Children)
                    {
                        bool headerCell = (bool)cell.GetValue(CalendarCellElement.IsHeaderCellProperty);

                        if (!headerCell)
                        {
                            SchedulerDayView view = new SchedulerDayView();
                            view.DayCount = 1;
                            view.StartDate = cell.Date;
                            view.GetViewContainingDate(cell.Date);

                            view.UpdateAppointments(this.radScheduler1.Appointments);

                            if (view.Appointments.Count > 0)
                            {
                                if (BoldFont == null)
                                    BoldFont = new Font(cell.Font, FontStyle.Bold);

                                cell.Font = BoldFont;
                                //cell.Font = new Font( cell.Font , FontStyle.Bold );
                            }
                            else
                            {
                                cell.Font = this.radCalendar1.Font;
                            }
                        }
                    }
                }
            }
        }

        void radScheduler1_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            InitializeCalendar2();
        }

        void radCalendar2_SelectionChanged(object sender, EventArgs e)
        {
            if (this.radCalendar2.SelectedDates.Count > 0)
            {
                this.radScheduler1.ActiveView.StartDate = this.radCalendar2.SelectedDate;
            }
        }

        private void radSchedulerNavigator1_ShowWeekendStateChanged(object sender, StateChangedEventArgs args)
        {
            if (this.radScheduler1.ActiveView as SchedulerMonthView == null)
            {
                (this.radScheduler1.ActiveView as SchedulerDayViewBase).RulerWidth = 45;

                (this.radScheduler1.SchedulerElement.ViewElement as SchedulerDayViewElement).DataAreaElement.ScrollView.Value = Point.Empty;

                (this.radScheduler1.SchedulerElement.ViewElement as SchedulerDayViewElement).DataAreaElement.Table.ScrollToWorkHours();
            }
        }

        private void CreateSchedulerDemoData()
        {
            DateTime baseDate = DateTime.Today;
            DateTime[] start = new DateTime[] { baseDate.AddHours(14.0), baseDate.AddDays(1.0).AddHours(9.0), baseDate.AddDays(2.0).AddHours(13.0),
                baseDate.AddDays(-3.0).AddHours(13.0), baseDate.AddDays(-2.0).AddHours(10.0), baseDate.AddDays(-1.0).AddHours(12.0),
                baseDate.AddDays(-4.0).AddHours(12.0), baseDate.AddDays(-4.0).AddHours(15.0), baseDate.AddDays(-4.0).AddHours(0.0)};

            DateTime[] end = new DateTime[] { baseDate.AddHours(16.0), baseDate.AddDays(1.0).AddHours(15.0), baseDate.AddDays(2.0).AddHours(17.0),
                baseDate.AddDays(-3.0).AddHours(14.0), baseDate.AddDays(-2.0).AddHours(13.0), baseDate.AddDays(-1.0).AddHours(15.0),
                baseDate.AddDays(-4.0).AddHours(14.0),  baseDate.AddDays(-4.0).AddHours(16.0), baseDate.AddDays(-4.0).AddHours(32.0)};

            string[] summaries = new string[] { "Control Customization In Silverlight",
                "MOSS 2007 Web 2.0 Controls / AJAX / Silverlight",
                "I Must Attend This Meeting Week Day.",
                "Integrating WPF And WCF Into Office Business Applications",
                "Introduction To WWF",
                "Object-Relational Mapping In Modern Architectures",
                "SQL Reporting Services 2005 And What's New In 2008",
                "Fun With Programming",
                "Deep Dive Into Entity Framework Object Services" };
            string[] descriptions = new string[] { "Silverlight 3 provides a rich set of options for customizing your controls. Unlike other technologies, creating user and custom controls is not necessary to get the customized control you want. In this talk I will cover Compositing, Styling, Templating and Custom Controls to help attendees understand when and how to customize their controls.",
                "Face it! The out of the box user interface for your Windows SharePoint Services 3.0 sites and your Microsoft Office SharePoint Server 2007 sites is BORING!  In this session we’ll look at spicing up your life a bit with many ways to make your SharePoint sites 'Web 2.0'. This session includes:1. New AJAX support provided with Service Pack 1. Learn how to AJAX enable your web.config files. Learn to AJAX enable your web parts and to call web services using AJAX. Integrate controls from the AJAX Control ToolKit.2. A look at the SharePoint controls provided by third party Telerik. 3. Silverlight integration into SharePoint And then watch your SharePoint sites come to life!",
                "Now hat WCF/WF services have gained some popularity companies are starting to ask the question 'How do we manage those services?'. The most common problems with the today’s middle-tier services are related to the deployment of those services to test, staging and production environments, observing the operation of the services deployed, scaling the services that hit the boundaries of their servers, and versioning the services without requiring all clients to get upgraded simultaneously. This talk will show Microsoft’s approach for solving some of these problems. We will start with a single long-running durable Workflow service implemented in .Net 4.0 and we will show how it gets it persistence working. Then we will show how to export it and how to import it in a different environment. After that we will see how to inspect and control instances of that service.",
                "This session will highlight many of the ways that the Windows Presentation Foundation (WPF) and the Windows Communications Foundation (WCF) can be leveraged in applications built with Visual Studio Tools for the Office System (VSTO). Visual Studio® 2008 introduced an array of new features aimed at a wide range of Office solution types. With Visual Studio 2008, you can build solutions that incorporate the native capabilities of the Office client applications (like Outlook) combined with the sophisticated UI capabilities of WPF that's connected to remote data and services via WCF and use the RAD features of LINQ<br/> to manipulate that data. These new technologies provide opportunities for building owerful solutions with functionality that was previously difficult or impossible to achieve. Now that Office has evolved into a true development platform, office-based solutions are becoming increasingly sophisticated, less document-focused, and more loosely coupled. This session will show you how easy it is to build robust solutions that leverage the latest technologies. WPF provides developers and designers with a unified programming model for building rich Windows smart client user experiences with Office client applications that incorporate UI, media, and documents. WCF contains a support framework and a design-time toolset for building service-oriented solutions that connect rich Office clients with powerful server-side functionality and remote data access. Visual Studio 2008 provides a simple GUI wizard that lets you consume WCF services without having to worry about service metadata, protocols, or XML configuration.",
                "With the .NET 3.0 Framework, developers were given the plumbing to create business process management solutions graphically. In this session, Mark will introduce the basics of working with Workflow Foundation. This is a 100 level talk for developers that are new to WF. We will spend some time talking about the architecture and when best to use a tool like WF for the greatest return. We'll also compare WF to BizTalk and learn that they are completely different worlds.",
                "WCF, WPF, Silverlight: Always new Buzzwords appear and come to market with new technologies, which are hard to learn. But how do those technologies integrate and collaborate? Data Access is usually encapsulated in a data access layer. Does this still make sense with the all over presence and acceptance of object-relational mapping (ORM)? Using surprisingly simple tools, you can implement basic and complex applications. This presentation shows that you need to rethink your architecture in order to implement persistent objects in nowadays application requirements. You will learn about the necessary feature set of an object-relational mapping tool and how it simplifies your daily work and how it reduces your data access code by 90%",
                "Business Data Catalog is a new business integration feature in Microsoft Office SharePoint Server 2007 to surface business data from back-end server applications without any coding. Business Data Catalog bridges the gap between the portal site and your business applications and enables you to bring in key data from various business applications to Office SharePoint Server 2007 lists, Web Parts, search, user profiles, and custom applications. To achieve this goal, Business Data Catalog provides homogeneous access to the underlying data sources with a metadata model that provides a consistent and simplified client object model. Business Data Catalog is the key infrastructural component around which the other Business Data features of Office SharePoint Server 2007 are built. We will explore how to expose SQL-Server 2005 data in a SP 2007 portal.",
                "Looking for something fun and inspirational? Let Carl Franklin show you some of the fun you can have with Visual Studio .NET and a few cool ideas, from artificial intelligence to practical joke software.",
                "The Entity Framework combined with the Entity Data Model (EDM) bring data access to a new level in Enterprise Applications. Entity Framework Object Services APIs, while providing a lot of automated functionality, are filled with features that give developers much more control over how objects are handled. The most important jobs of the ObjectContext are relationship management and change tracking. This session drills into how the ObjectContext manages relationships and how you can control its behavior. This is especially important in SOA scenarios where you may need to transport ObjectGraphs. We also look closely at change tracking, focusing on the challenges and solutions for dealing with data concurrency when moving objects across tiers in your enterprise applications. Knowing what to expect from these features and how to take control of them will empower you in your use of the Entity Framework and EDMs in your Web sites, SOA applications, and smart clients, as well as other applications that share the EDM." };
            string[] locations = new string[] { "Hall 14", "Hall 05", "Hall 11", "Hall 13", "Hall 01", "Hall 02", "Hall 14", "Hall 10", "Home" };
            AppointmentBackground[] backgrounds = new AppointmentBackground[] { AppointmentBackground.Business, AppointmentBackground.MustAttend,
                AppointmentBackground.Personal, AppointmentBackground.Important, AppointmentBackground.NeedsPreparation, AppointmentBackground.Birthday
                ,AppointmentBackground.TravelRequired, AppointmentBackground.NeedsPreparation, AppointmentBackground.Business};
            AppointmentStatus[] statuses = new AppointmentStatus[]{AppointmentStatus.Busy, AppointmentStatus.Free, AppointmentStatus.Busy,AppointmentStatus.Tentative,
                AppointmentStatus.Tentative, AppointmentStatus.Tentative, AppointmentStatus.Free, AppointmentStatus.Free, AppointmentStatus.Busy};

            Appointment appointment = null;
            for (int i = 0; i < summaries.Length; i++)
            {
                // Achtung: SchedulerOutlookLikeAppointment verwenden !!!!
                appointment = new SchedulerOutlookLikeAppointment();

                appointment.Start = start[i];
                appointment.End = end[i];
                appointment.Summary = summaries[i];
                appointment.Description = descriptions[i];
                appointment.Location = locations[i];

                //appointment = new Appointment( start [ i ] , end [ i ] , summaries [ i ] ,
                //                              descriptions [ i ] , locations [ i ] );
                appointment.BackgroundId = (int)backgrounds[i];
                appointment.StatusId = (int)statuses[i];
                this.radScheduler1.Appointments.Add(appointment);
            }

            // Achtung: SchedulerOutlookLikeAppointment verwenden !!!!
            appointment = new SchedulerOutlookLikeAppointment();

            appointment.Start = baseDate.AddHours(11.0);
            appointment.End = baseDate.AddHours(12.0);
            appointment.Summary = "The Daily Scrum";
            appointment.Description = "One of the most popular Agile project management and development methods, Scrum is starting to be adopted at major corporations and on very large projects. After an quick introduction to the basics of Scrum like: the Scrum Master, team, product owner, and burn down, and of course the daily Scrum, Stephen, Remi, and Joel show many real world applications of the methodology drawn from his own experience as a Scrum Master. Negotiating with the business, estimation, and team dynamics are all discussed as well as how to use Scrum in small organizations, large enterprise environments, and consulting environments. The speakers will also discuss using Scrum with virtual teams and even an offshoring environment. The session will finish with a large Q&A on best practices";

            appointment.Location = "Room 604";

            appointment.RecurrenceRule = new DailyRecurrenceRule(baseDate.AddHours(11.0), 2);
            appointment.BackgroundId = (int)AppointmentBackground.Business;
            appointment.StatusId = (int)AppointmentStatus.Busy;

            this.radScheduler1.Appointments.Add(appointment);
            this.radScheduler1.Appointments.EndUpdate();

            this.radScheduler1.Resources.Add(new Resource(1, "Dell Laptop"));
            this.radScheduler1.Resources.Add(new Resource(2, "Lenovo Laptop"));
            this.radScheduler1.Resources.Add(new Resource(3, "Toshiba Laptop"));
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            SchedulerDayViewBase view = this.radScheduler1.ActiveView as SchedulerDayViewBase;
            if (view != null)
            {
                SchedulerTimeZone schedulerTimeZone = this.radDropDownList1.SelectedValue as SchedulerTimeZone;
                if (!view.TimeZones.Contains(schedulerTimeZone))
                {
                    view.TimeZones.Add(schedulerTimeZone);
                }
            }

        }

        #endregion

        #region ColorDialog

        private void InitializeColorDialog()
        {

        }

        private void radButton6_Click(object sender, EventArgs e)
        {
            RadColorDialog colorDialog = new RadColorDialog();

            colorDialog.ShowDialog();
        }


        #endregion

        #region CommandBar

        private void InitializeCommandBar()
        {

        }

        #endregion

        #region RadMarkupEditor

        private void InitializeRadMarkupEditor()
        {

        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            this.radMarkupDialog1.ShowDialog();
        }

        #endregion

        #region RadWizard

        private void InitializeRadWizard()
        {

        }

        #endregion

        #region RadGridViewPrinting

        private void InitializeRadGridViewPrinting()
        {
            this.radPrintDocument1 = new Telerik.WinControls.UI.RadPrintDocument();

            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewImageColumn gridViewImageColumn1 = new Telerik.WinControls.UI.GridViewImageColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.RadPrintWatermark radPrintWatermark1 = new Telerik.WinControls.UI.RadPrintWatermark();

            ((System.ComponentModel.ISupportInitialize)(this.GridViewPrinting)).BeginInit();
            this.SuspendLayout();
            // 
            // radGridView1
            // 
            this.GridViewPrinting.MasterTemplate.AllowAddNewRow = false;
            this.GridViewPrinting.MasterTemplate.AutoExpandGroups = true;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.FieldName = "EmployeeID";
            gridViewDecimalColumn1.HeaderText = "EmployeeID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "EmployeeID";
            gridViewTextBoxColumn1.FieldName = "TitleOfCourtesy";
            gridViewTextBoxColumn1.HeaderText = "TitleOfCourtesy";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "TitleOfCourtesy";
            gridViewTextBoxColumn2.FieldName = "FirstName";
            gridViewTextBoxColumn2.HeaderText = "FirstName";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "FirstName";
            gridViewTextBoxColumn2.Width = 100;
            gridViewTextBoxColumn3.FieldName = "LastName";
            gridViewTextBoxColumn3.HeaderText = "LastName";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "LastName";
            gridViewTextBoxColumn3.Width = 100;
            gridViewTextBoxColumn4.FieldName = "Title";
            gridViewTextBoxColumn4.HeaderText = "Title";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "Title";
            gridViewTextBoxColumn4.Width = 80;
            gridViewDateTimeColumn1.FieldName = "BirthDate";
            gridViewDateTimeColumn1.HeaderText = "BirthDate";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.IsVisible = false;
            gridViewDateTimeColumn1.Name = "BirthDate";
            gridViewDateTimeColumn2.FieldName = "HireDate";
            gridViewDateTimeColumn2.HeaderText = "HireDate";
            gridViewDateTimeColumn2.IsAutoGenerated = true;
            gridViewDateTimeColumn2.IsVisible = false;
            gridViewDateTimeColumn2.Name = "HireDate";
            gridViewTextBoxColumn5.FieldName = "Country";
            gridViewTextBoxColumn5.HeaderText = "Country";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "Country";
            gridViewImageColumn1.DataType = typeof(byte[]);
            gridViewImageColumn1.FieldName = "Photo";
            gridViewImageColumn1.HeaderText = "Photo";
            gridViewImageColumn1.IsAutoGenerated = true;
            gridViewImageColumn1.IsVisible = false;
            gridViewImageColumn1.Name = "Photo";
            gridViewTextBoxColumn6.FieldName = "Address";
            gridViewTextBoxColumn6.HeaderText = "Address";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.Name = "Address";
            gridViewTextBoxColumn6.Width = 150;
            gridViewTextBoxColumn7.FieldName = "City";
            gridViewTextBoxColumn7.HeaderText = "City";
            gridViewTextBoxColumn7.IsAutoGenerated = true;
            gridViewTextBoxColumn7.IsVisible = false;
            gridViewTextBoxColumn7.Name = "City";
            gridViewTextBoxColumn8.FieldName = "Region";
            gridViewTextBoxColumn8.HeaderText = "Region";
            gridViewTextBoxColumn8.IsAutoGenerated = true;
            gridViewTextBoxColumn8.IsVisible = false;
            gridViewTextBoxColumn8.Name = "Region";
            gridViewTextBoxColumn9.FieldName = "PostalCode";
            gridViewTextBoxColumn9.HeaderText = "PostalCode";
            gridViewTextBoxColumn9.IsAutoGenerated = true;
            gridViewTextBoxColumn9.IsVisible = false;
            gridViewTextBoxColumn9.Name = "PostalCode";
            gridViewTextBoxColumn10.FieldName = "HomePhone";
            gridViewTextBoxColumn10.HeaderText = "Phone";
            gridViewTextBoxColumn10.IsAutoGenerated = true;
            gridViewTextBoxColumn10.Name = "HomePhone";
            gridViewTextBoxColumn10.Width = 80;
            gridViewTextBoxColumn11.FieldName = "Extension";
            gridViewTextBoxColumn11.HeaderText = "Extension";
            gridViewTextBoxColumn11.IsAutoGenerated = true;
            gridViewTextBoxColumn11.IsVisible = false;
            gridViewTextBoxColumn11.Name = "Extension";
            gridViewTextBoxColumn12.FieldName = "Notes";
            gridViewTextBoxColumn12.HeaderText = "Notes";
            gridViewTextBoxColumn12.IsAutoGenerated = true;
            gridViewTextBoxColumn12.IsVisible = false;
            gridViewTextBoxColumn12.Name = "Notes";
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.FieldName = "ReportsTo";
            gridViewDecimalColumn2.HeaderText = "ReportsTo";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.IsVisible = false;
            gridViewDecimalColumn2.Name = "ReportsTo";

            this.GridViewPrinting.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewDateTimeColumn1,
            gridViewDateTimeColumn2,
            gridViewTextBoxColumn5,
            gridViewImageColumn1,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12,
            gridViewDecimalColumn2});

            // 
            // radPrintDocument1
            // 
            this.radPrintDocument1.AssociatedObject = this.GridViewPrinting;
            this.radPrintDocument1.FooterFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPrintDocument1.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            radPrintWatermark1.DrawInFront = true;
            radPrintWatermark1.Font = new System.Drawing.Font("Microsoft Sans Serif", 144F);
            radPrintWatermark1.Text = null;
            this.radPrintDocument1.Watermark = radPrintWatermark1;

            ((System.ComponentModel.ISupportInitialize)(this.GridViewPrinting)).EndInit();
            this.ResumeLayout(false);

            this.GridViewPrinting.EnableFiltering = true;
            this.GridViewPrinting.ShowFilteringRow = false;
            this.GridViewPrinting.ShowHeaderCellButtons = true;
            this.GridViewPrinting.ShowGroupedColumns = true;
            this.GridViewPrinting.AutoExpandGroups = true;
            this.GridViewPrinting.EnableAlternatingRowColor = true;
            this.GridViewPrinting.CellFormatting += new CellFormattingEventHandler(radGridView1_CellFormatting);
            this.GridViewPrinting.PrintCellFormatting += new PrintCellFormattingEventHandler(radGridView1_PrintCellFormatting);

            this.GridViewPrinting.Columns["FirstName"].Width = 80;
            this.GridViewPrinting.Columns["LastName"].Width = 80;
            this.GridViewPrinting.Columns["Title"].Width = 120;
            this.GridViewPrinting.Columns["Photo"].Width = 80;
            this.GridViewPrinting.Columns["Photo"].ImageLayout = ImageLayout.Stretch;
            this.GridViewPrinting.Columns["City"].Width = 70;
            this.GridViewPrinting.Columns["Country"].Width = 70;
            this.GridViewPrinting.Columns["Address"].Width = 200;
            this.GridViewPrinting.Columns["Notes"].Width = 260;
            this.GridViewPrinting.Columns["Notes"].WrapText = true;
            this.GridViewPrinting.Columns["BirthDate"].FormatString = "{0:d}";
            this.GridViewPrinting.Columns["BirthDate"].Width = 120;
            this.GridViewPrinting.Columns["HireDate"].FormatString = "{0:d}";
            ((GridViewTextBoxColumn)this.GridViewPrinting.Columns["Notes"]).Multiline = true;

            // column groups view
            ColumnGroupsViewDefinition cgv = new ColumnGroupsViewDefinition();
            columnGroupViewInfo = new ViewDefinitionInfo();
            columnGroupViewInfo.ViewDefinition = cgv;
            columnGroupViewInfo.Columns = new List<string>() { "Photo", "FirstName", "LastName", "Title", "Address", "City", "Country", "HomePhone", "Notes" };
            columnGroupViewInfo.RowHeight = 90;
            columnGroupViewInfo.HeaderHeight = 60;

            cgv.ColumnGroups.Add(new GridViewColumnGroup());
            cgv.ColumnGroups.Add(new GridViewColumnGroup("General"));
            cgv.ColumnGroups.Add(new GridViewColumnGroup("Details"));
            cgv.ColumnGroups.Add(new GridViewColumnGroup("Notes"));

            cgv.ColumnGroups[0].Rows.Add(new GridViewColumnGroupRow());
            cgv.ColumnGroups[1].Rows.Add(new GridViewColumnGroupRow());
            cgv.ColumnGroups[1].Rows.Add(new GridViewColumnGroupRow());
            cgv.ColumnGroups[2].Rows.Add(new GridViewColumnGroupRow());
            cgv.ColumnGroups[2].Rows.Add(new GridViewColumnGroupRow());

            cgv.ColumnGroups[0].Rows[0].ColumnNames.Add("Photo");
            cgv.ColumnGroups[0].ShowHeader = false;

            cgv.ColumnGroups[1].Rows[0].ColumnNames.Add("Title");
            cgv.ColumnGroups[1].Rows[1].ColumnNames.Add("FirstName");
            cgv.ColumnGroups[1].Rows[1].ColumnNames.Add("LastName");

            cgv.ColumnGroups[2].Rows[0].ColumnNames.Add("City");
            cgv.ColumnGroups[2].Rows[0].ColumnNames.Add("Country");
            cgv.ColumnGroups[2].Rows[0].ColumnNames.Add("HomePhone");
            cgv.ColumnGroups[2].Rows[1].ColumnNames.Add("Address");

            cgv.ColumnGroups[3].Rows.Add(new GridViewColumnGroupRow());
            cgv.ColumnGroups[3].Rows[0].ColumnNames.Add("Notes");
            cgv.ColumnGroups[3].ShowHeader = false;

            // add some data
            this.InitData();

            this.radGridView1.GroupDescriptors.Add(new Telerik.WinControls.Data.GroupDescriptor("Title Desc"));

            //InitializeGrid();
            InitializePrintDocument();

            SetView(columnGroupViewInfo);

        }

        private void InitData()
        {
            this.GridViewPrinting.Rows.Add(1, "", "Andrew", "Fuller", "VicePresident", new DateTime(1940, 03, 03), new DateTime(1960, 03, 03), "USA", null,
                                            "VictoriaStreet 21", "New York", "", "", "", "", "", 0);
            this.GridViewPrinting.Rows.Add(2, "", "Andrew", "Fuller", "VicePresident", new DateTime(1940, 03, 03), new DateTime(1960, 03, 03), "USA", null,
                                            "VictoriaStreet 21", "New York", "", "", "", "", "", 0);
            this.GridViewPrinting.Rows.Add(3, "", "Andrew", "Fuller", "VicePresident", new DateTime(1940, 03, 03), new DateTime(1960, 03, 03), "USA", null,
                                            "VictoriaStreet 21", "New York", "", "", "", "", "", 0);
            this.GridViewPrinting.Rows.Add(4, "", "Andrew", "Fuller", "VicePresident", new DateTime(1940, 03, 03), new DateTime(1960, 03, 03), "USA", null,
                                            "VictoriaStreet 21", "New York", "", "", "", "", "", 0);
            this.GridViewPrinting.Rows.Add(5, "", "Andrew", "Fuller", "VicePresident", new DateTime(1940, 03, 03), new DateTime(1960, 03, 03), "USA", null,
                                            "VictoriaStreet 21", "New York", "", "", "", "", "", 0);
            this.GridViewPrinting.Rows.Add(6, "", "Andrew", "Fuller", "VicePresident", new DateTime(1940, 03, 03), new DateTime(1960, 03, 03), "USA", null,
                                            "VictoriaStreet 21", "New York", "", "", "", "", "", 0);
            this.GridViewPrinting.Rows.Add(7, "", "Andrew", "Fuller", "VicePresident", new DateTime(1940, 03, 03), new DateTime(1960, 03, 03), "USA", null,
                                            "VictoriaStreet 21", "New York", "", "", "", "", "", 0);
            this.GridViewPrinting.Rows.Add(8, "", "Andrew", "Fuller", "VicePresident", new DateTime(1940, 03, 03), new DateTime(1960, 03, 03), "USA", null,
                                            "VictoriaStreet 21", "New York", "", "", "", "", "", 0);
            this.GridViewPrinting.Rows.Add(9, "", "Andrew", "Fuller", "VicePresident", new DateTime(1940, 03, 03), new DateTime(1960, 03, 03), "USA", null,
                                            "VictoriaStreet 21", "New York", "", "", "", "", "", 0);
            this.GridViewPrinting.Rows.Add(10, "", "Andrew", "Fuller", "VicePresident", new DateTime(1940, 03, 03), new DateTime(1960, 03, 03), "USA", null,
                                            "VictoriaStreet 21", "New York", "", "", "", "", "", 0);
            this.GridViewPrinting.Rows.Add(11, "", "Andrew", "Fuller", "VicePresident", new DateTime(1940, 03, 03), new DateTime(1960, 03, 03), "USA", null,
                                            "VictoriaStreet 21", "New York", "", "", "", "", "", 0);
            this.GridViewPrinting.Rows.Add(12, "", "Andrew", "Fuller", "VicePresident", new DateTime(1940, 03, 03), new DateTime(1960, 03, 03), "USA", null,
                                            "VictoriaStreet 21", "New York", "", "", "", "", "", 0);
            this.GridViewPrinting.Rows.Add(13, "", "Andrew", "Fuller", "VicePresident", new DateTime(1940, 03, 03), new DateTime(1960, 03, 03), "USA", null,
                                            "VictoriaStreet 21", "New York", "", "", "", "", "", 0);
            this.GridViewPrinting.Rows.Add(14, "", "Andrew", "Fuller", "VicePresident", new DateTime(1940, 03, 03), new DateTime(1960, 03, 03), "USA", null,
                                            "VictoriaStreet 21", "New York", "", "", "", "", "", 0);
            this.GridViewPrinting.Rows.Add(15, "", "Andrew", "Fuller", "VicePresident", new DateTime(1940, 03, 03), new DateTime(1960, 03, 03), "USA", null,
                                            "VictoriaStreet 21", "New York", "", "", "", "", "", 0);
            this.GridViewPrinting.Rows.Add(16, "", "Andrew", "Fuller", "VicePresident", new DateTime(1940, 03, 03), new DateTime(1960, 03, 03), "USA", null,
                                            "VictoriaStreet 21", "New York", "", "", "", "", "", 0);
            this.GridViewPrinting.Rows.Add(17, "", "Andrew", "Fuller", "VicePresident", new DateTime(1940, 03, 03), new DateTime(1960, 03, 03), "USA", null,
                                            "VictoriaStreet 21", "New York", "", "", "", "", "", 0);
            this.GridViewPrinting.Rows.Add(18, "", "Andrew", "Fuller", "VicePresident", new DateTime(1940, 03, 03), new DateTime(1960, 03, 03), "USA", null,
                                            "VictoriaStreet 21", "New York", "", "", "", "", "", 0);
            this.GridViewPrinting.Rows.Add(19, "", "Andrew", "Fuller", "VicePresident", new DateTime(1940, 03, 03), new DateTime(1960, 03, 03), "USA", null,
                                            "VictoriaStreet 21", "New York", "", "", "", "", "", 0);
            this.GridViewPrinting.Rows.Add(20, "", "Andrew", "Fuller", "VicePresident", new DateTime(1940, 03, 03), new DateTime(1960, 03, 03), "USA", null,
                                            "VictoriaStreet 21", "New York", "", "", "", "", "", 0);
            this.GridViewPrinting.Rows.Add(21, "", "Andrew", "Fuller", "VicePresident", new DateTime(1940, 03, 03), new DateTime(1960, 03, 03), "USA", null,
                                            "VictoriaStreet 21", "New York", "", "", "", "", "", 0);
            this.GridViewPrinting.Rows.Add(22, "", "Andrew", "Fuller", "VicePresident", new DateTime(1940, 03, 03), new DateTime(1960, 03, 03), "USA", null,
                                            "VictoriaStreet 21", "New York", "", "", "", "", "", 0);
            this.GridViewPrinting.Rows.Add(23, "", "Andrew", "Fuller", "VicePresident", new DateTime(1940, 03, 03), new DateTime(1960, 03, 03), "USA", null,
                                            "VictoriaStreet 21", "New York", "", "", "", "", "", 0);
            this.GridViewPrinting.Rows.Add(24, "", "Andrew", "Fuller", "VicePresident", new DateTime(1940, 03, 03), new DateTime(1960, 03, 03), "USA", null,
                                            "VictoriaStreet 21", "New York", "", "", "", "", "", 0);
            this.GridViewPrinting.Rows.Add(25, "", "Andrew", "Fuller", "VicePresident", new DateTime(1940, 03, 03), new DateTime(1960, 03, 03), "USA", null,
                                            "VictoriaStreet 21", "New York", "", "", "", "", "", 0);
        }

        private void InitializePrintDocument()
        {
            this.radPrintDocument1.LeftFooter = "Page [Page #] of [Total Pages]";
            this.radPrintDocument1.LeftHeader = "[Time Printed]";
            this.radPrintDocument1.MiddleFooter = "***";
            this.radPrintDocument1.MiddleHeader = "Company employees info";
            this.radPrintDocument1.RightFooter = "Printed by: [User Name]";
            this.radPrintDocument1.RightHeader = "[Date Printed]";

            this.radPrintDocument1.LeftFooter = "Seite [Page #] von [Total Pages]";
            this.radPrintDocument1.LeftHeader = "[Time Printed]";
            this.radPrintDocument1.MiddleFooter = "***";
            this.radPrintDocument1.MiddleHeader = "Firma Angestellteninformation";
            this.radPrintDocument1.RightFooter = "Gedruckt von: [User Name]";
            this.radPrintDocument1.RightHeader = "[Date Printed]";
        }

        private void SetView(ViewDefinitionInfo info)
        {
            //currentViewInfo = info;

            this.GridViewPrinting.FilterDescriptors.Clear();

            this.GridViewPrinting.BeginUpdate();

            foreach (GridViewColumn col in this.GridViewPrinting.Columns)
            {
                col.IsVisible = info.Columns.Contains(col.Name);
            }

            GridTraverser traverser = new GridTraverser(this.GridViewPrinting.MasterView);
            while (traverser.MoveNext())
            {
                if (traverser.Current is GridViewDataRowInfo)
                {
                    traverser.Current.Height = info.RowHeight;
                }
            }

            this.GridViewPrinting.MasterView.TableHeaderRow.Height = info.HeaderHeight;

            this.GridViewPrinting.EndUpdate(false);

            this.GridViewPrinting.ViewDefinition = info.ViewDefinition;
            this.GridViewPrinting.PrintStyle.FitWidthMode = PrintFitWidthMode.NoFitCentered;
        }

        private void radGridView1_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            GridDataCellElement cell = e.CellElement as GridDataCellElement;
            if (cell != null)
            {
                if (cell.ColumnInfo.Name == "Notes")
                {
                    cell.Font = italicFont;
                    cell.Padding = new Padding(4);
                }
                else
                {
                    cell.ResetValue(LightVisualElement.FontProperty, ValueResetFlags.Local);
                    cell.ResetValue(LightVisualElement.PaddingProperty, ValueResetFlags.Local);
                }
            }
        }

        private void radGridView1_PrintCellFormatting(object sender, PrintCellFormattingEventArgs e)
        {
            if (e.Column != null && e.Column.Name == "Notes" && e.Row is GridViewDataRowInfo)
            {
                e.PrintCell.Font = this.italicFont;
            }
        }

        private void buttonGridViewPrintSettings_Click(object sender, EventArgs e)
        {
            GridViewPrintSettingsDialog dialog = new GridViewPrintSettingsDialog();
            dialog.ThemeName = this.GridViewPrinting.ThemeName;
            dialog.ShowPreviewButton = false;
            dialog.PrintDocument = this.radPrintDocument1;
            dialog.StartPosition = FormStartPosition.CenterScreen;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                buttonGridViewPrintPreview_Click(sender, e);
            }

        }

        private void buttonGridViewPrintPreview_Click(object sender, EventArgs e)
        {
            RadPrintPreviewDialog dialog = new RadPrintPreviewDialog();
            dialog.ThemeName = this.GridViewPrinting.ThemeName;
            dialog.Document = this.radPrintDocument1;
            dialog.StartPosition = FormStartPosition.CenterScreen;
            dialog.ShowDialog();

        }

        #endregion

        #region RadSchedulerPrinting

        private void InitializeRadSchedulerPrinting()
        {
            // Initialize Scheduler
            this.customAlarmForm = new SchedulerCustomAlarmForm();

            //this.radSchedulerNavigator2.DateFormat = "dd/MMMM/yyyy";
            this.radSchedulerNavigator2.DateFormat = "dd. MMMM yyyy";

            // !!!!!!!!!! Schaltet in der Monatssicht den Monatskalender ein !!!!!
            this.radSchedulerNavigator2.AutomaticNavigation = true;

            this.radScheduler2.AppointmentFactory = new SchedulerCustomAppointmentFactory();

            FillAppointments();
            this.radScheduler2.ActiveViewType = SchedulerViewType.Week;


            this.schedulerDailyPrintStyle1 = new Telerik.WinControls.UI.SchedulerDailyPrintStyle();
            this.schedulerDailyPrintStyle1.AppointmentFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.schedulerDailyPrintStyle1.DateEndRange = new System.DateTime(2013, 2, 10, 0, 0, 0, 0);
            this.schedulerDailyPrintStyle1.DateHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.schedulerDailyPrintStyle1.DateStartRange = new System.DateTime(2013, 2, 4, 0, 0, 0, 0);
            this.schedulerDailyPrintStyle1.PageHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);

            this.radScheduler2.PrintStyle = this.schedulerDailyPrintStyle1;

            this.radPrintDocument2 = new Telerik.WinControls.UI.RadPrintDocument();
            this.radPrintDocument2.AssociatedObject = this.radScheduler2;
            this.radPrintDocument2.FooterFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radPrintDocument2.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

            this.radPrintDocument2.LeftFooter = "Page [Page #] of [Total Pages]";
            this.radPrintDocument2.LeftHeader = "[Time Printed]";
            this.radPrintDocument2.MiddleFooter = "***";
            this.radPrintDocument2.MiddleHeader = "Weekly Task List";
            this.radPrintDocument2.RightFooter = "Printed by: [User Name]";
            this.radPrintDocument2.RightHeader = "[Date Printed]";

            this.radPrintDocument2.LeftFooter = "Seite [Page #] von [Total Pages]";
            this.radPrintDocument2.LeftHeader = "[Time Printed]";
            this.radPrintDocument2.MiddleFooter = "***";
            this.radPrintDocument2.MiddleHeader = "Wöchentliche Terminliste";
            this.radPrintDocument2.RightFooter = "Gedruckt von: [User Name]";
            this.radPrintDocument2.RightHeader = "[Date Printed]";
        }

        private void ButtonSchedulerPrintingPrintSettings_Click(object sender, EventArgs e)
        {
            SchedulerPrintSettingsDialog dialog = new SchedulerPrintSettingsDialog();
            dialog.ThemeName = this.radScheduler2.ThemeName;
            dialog.PrintDocument = this.radPrintDocument2;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ButtonSchedulerPrintingPrintPreview_Click(sender, e);
            }
            else
            {
                //this.UpdateSelectedStyle();
            }

        }

        private void ButtonSchedulerPrintingPrintPreview_Click(object sender, EventArgs e)
        {
            RadPrintPreviewDialog dialog = new RadPrintPreviewDialog();
            dialog.ThemeName = this.radScheduler2.ThemeName;
            dialog.Document = this.radPrintDocument2;
            dialog.ShowDialog();

            //this.UpdateSelectedStyle();

        }

        private void FillAppointments()
        {
            this.radSchedulerNavigator2.SchedulerNavigatorElement.TimeZonesDropDown.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            this.radScheduler2.Appointments.BeginUpdate();

            DateTime dtStart = DateHelper.GetStartOfWeek(DateTime.Today, System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat).AddHours(10);
            DateTime dtEnd = DateHelper.GetStartOfWeek(DateTime.Today, System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat).AddHours(12);

            Appointment appointment = new Appointment(dtStart, dtEnd,
                "Building Windows 8 applications with the Metro look",
                "In this session, I will show you how to build a Windows 8 Metro Style Application in XAML and C#.During the process, I will highlight the similarities with other XAML platforms like Silverlight for the Windows Phone, and even how to share code between the two, as well as how to take advantage of the new features in WinRT such as contracts/charms and the new intrinsic GridView controls with semantic zoom.");
            appointment.BackgroundId = (int)AppointmentBackground.Anniversary;
            appointment.StatusId = (int)AppointmentStatus.Unavailable;
            this.radScheduler2.Appointments.Add(appointment);

            appointment = new Appointment(dtStart.AddDays(4).AddHours(2), dtEnd.AddDays(4).AddHours(2),
                "Silverlight 5 for LOB development",
                "Most Silverlight 5 sessions give you an overview of the most magical features in the platform. However, not everyone is busy building 3D-enabled applications or media-intensive applications. Most Silverlight developers build LOB applications. For this group, this session is exactly what you need.");
            appointment.BackgroundId = (int)AppointmentBackground.Business;
            appointment.StatusId = (int)AppointmentStatus.Free;
            this.radScheduler2.Appointments.Add(appointment);

            appointment = new Appointment(dtStart.AddHours(4), dtEnd.AddHours(4),
                "Building Applications with HTML 5 and Javascript – a new perspective: Windows 8",
                "HTML 5 is out there for some time (though still a draft) and a lot of web applications are being built using this standard and technologies like Javascript. But how about building apps for the OS system Windows 8 using HTML 5 and Javascript?");
            appointment.BackgroundId = (int)AppointmentBackground.Important;
            appointment.StatusId = (int)AppointmentStatus.Tentative;
            this.radScheduler2.Appointments.Add(appointment);

            dtStart = dtStart.AddDays(1);
            dtEnd = dtEnd.AddDays(1);

            appointment = new Appointment(dtStart, dtEnd.AddDays(3),
                "What’s New In Windows Phone",
                "An overview of the features new in Windows Phone 7.5 (code name Mango) along with details on some of the most important new features, starting with Fast Application Switching, greater access to the calendar and contacts, a local database, a greatly enhanced motion API and much more.");
            appointment.BackgroundId = (int)AppointmentBackground.MustAttend;
            appointment.StatusId = (int)AppointmentStatus.Free;
            this.radScheduler2.Appointments.Add(appointment);

            appointment = new Appointment(dtStart.AddHours(1), dtEnd.AddHours(1),
                "Windows Phone 7 Application - from start to market",
                "A crash course in Windows Phone application development with Visual Studio and Expression Blend, with an emphasis on declarative Xaml programming. This presentation will start with foundational information and take you through advanced topics such as tasks and data binding, as well as preparing your program for the marketplace.");
            appointment.BackgroundId = (int)AppointmentBackground.NeedsPreparation;
            appointment.StatusId = (int)AppointmentStatus.Busy;
            this.radScheduler2.Appointments.Add(appointment);

            appointment = new Appointment(dtStart.AddDays(4).AddHours(2), dtEnd.AddDays(4).AddHours(3),
                "How Do You Test SharePoint 2010 Applications?",
                "There are many types of testing you can perform on a developed web application – from unit, to functional, to smoke, to load testing – and more!  Different tools are required for different types of testing, and properly testing SharePoint 2010 can present unique challenges.  Using Visual Studio 2010 Ultimate and several commercial testing tools, I will demonstrate several key testing types in action as applied to a SharePoint 2010 application.  When performing a stress test, I will take you through the interpretation of the results and guide you on how and what to test in your application.");
            appointment.BackgroundId = (int)AppointmentBackground.PhoneCall;
            appointment.StatusId = (int)AppointmentStatus.Busy;
            this.radScheduler2.Appointments.Add(appointment);

            appointment = new Appointment(dtStart.AddHours(4), dtEnd.AddHours(5),
                "Common Design Patterns",
                "Design Patterns provide common templates for solving the same family of problems in a similar way. They also provide a higher-level language for software developers to use to describe approaches they might choose when designing a component of an application. In this session, you'll learn about several of the most common, and useful, design patterns used by Microsoft developers today.");
            appointment.BackgroundId = (int)AppointmentBackground.Personal;
            appointment.StatusId = (int)AppointmentStatus.Tentative;
            this.radScheduler2.Appointments.Add(appointment);

            DateTime tempDateTime = dtEnd.AddHours(7);
            appointment = new Appointment(dtStart.AddHours(6), tempDateTime.AddDays(1),
                "Moving your XAML applications to Metro",
                "By now you know what Metro is, what the Windows Runtime (WinRT) is, and that C# and VB.NET can access the WinRT via an interop layer. The big question: What's involved in moving my Silverlight (or WPF) application over to Metro? In this session Carl Franklin goes through the pain points and gives you a real idea of what it will take to port your application.");
            appointment.BackgroundId = (int)AppointmentBackground.Business;
            appointment.StatusId = (int)AppointmentStatus.Free;
            this.radScheduler2.Appointments.Add(appointment);

            dtStart = dtStart.AddDays(1);
            dtEnd = dtEnd.AddDays(1);

            appointment = new Appointment(dtStart.AddHours(1), dtEnd.AddHours(4),
                "Windows Azure – Under the hood",
                "As a happy Windows Azure user you’ve probably been wondering about the internals of Windows Azure. How is provisioning of services happening, how do all components scale seemingly infinite? What happens if my role instance goes down? Come join me and balance on the thin line between software architecture and system architecture that forms the base of one of the most complete cloud platforms out there: Windows Azure.");
            appointment.BackgroundId = (int)AppointmentBackground.Vacation;
            appointment.StatusId = (int)AppointmentStatus.Unavailable;
            this.radScheduler2.Appointments.Add(appointment);

            appointment = new Appointment(dtStart.AddDays(1).AddHours(5), dtEnd.AddDays(1).AddHours(7),
                "Taking Care of a Cloud Environment: Windows Azure",
                "No, this session is not about greener IT. It does cover the environment your application will live in once deployed to Windows Azure: learn about the virtual machine you’ve deployed to and how it interacts with the datacenter. Learn about how you can get use the RoleEnvironment class and diagnostics provided by Windows Azure. Communication between roles, logging and diagnostics are just some of the possibilities of what you can do if you know about how the Windows Azure environment works. And who knows, maybe we can even auto-scale our application...");
            appointment.BackgroundId = (int)AppointmentBackground.Personal;
            appointment.StatusId = (int)AppointmentStatus.Tentative;
            this.radScheduler2.Appointments.Add(appointment);

            appointment = new Appointment(dtStart.AddHours(8), dtEnd.AddHours(10),
                "Pragmatic ASP.NET Tips, Tricks, And Tools",
                "Every experienced ASP.NET developer has picked up a few cool tricks or useful tools that they put to use on every new project after they've learned them. This session draws upon the experience of many successful ASP.NET developers and distills this knowledge into a collection of tips and tricks you can start using in your work today. Some of the topics covered in this session include error handling, tracing, caching, base page classes, site layout and architecture, and data access best practices. You'll learn about highly reusable Http Modules and Handlers and a few code routines you may want to add to your personal library. Stick around for part 2 if you’re interested in learning about a wide variety of (usually free) tools available to aid ASP.NET developers. This session is appropriate for anyone who is working with ASP.NET today, and especially for those who are new to ASP.NET.");
            appointment.BackgroundId = (int)AppointmentBackground.MustAttend;
            appointment.StatusId = (int)AppointmentStatus.Busy;
            this.radScheduler2.Appointments.Add(appointment);

            dtStart = dtStart.AddDays(1);
            dtEnd = dtEnd.AddDays(1);

            appointment = new Appointment(dtStart, dtEnd,
                "Fun With Programming",
                "Looking for something fun and inspirational? Let Carl Franklin show you some of the fun you can have with Visual Studio .NET and a few cool ideas, from artificial intelligence to practical joke software.");
            appointment.BackgroundId = (int)AppointmentBackground.NeedsPreparation;
            appointment.StatusId = (int)AppointmentStatus.Busy;
            this.radScheduler2.Appointments.Add(appointment);

            this.radScheduler2.Appointments.EndUpdate();
        }

        #endregion

        #region RadSpellChecker

        private void InitializeRadSpellChecker()
        {
            this.radTextBoxSpellChecker.Text = "The quik broun foxx jumpd ovur lasy dog";
        }

        private void radButtonSpellChecker_Click(object sender, EventArgs e)
        {
            this.radSpellChecker1.Check(this.radTextBoxSpellChecker);
        }

        #endregion

        #region RadTextBoxControl

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            string text = this.radTextBoxControl1.Text;

            if (!string.IsNullOrEmpty(text))
            {
                string query = string.Format("http://www.bing.com/search?q={0}", text);
                Process.Start(query);
            }
        }

        #endregion

    }

    /// <summary>
    /// GridView Printing
    /// </summary>
    internal class ViewDefinitionInfo
    {
        public List<string> Columns;
        public IGridViewDefinition ViewDefinition;
        public int RowHeight = 30;
        public int HeaderHeight = 30;
    };
}
