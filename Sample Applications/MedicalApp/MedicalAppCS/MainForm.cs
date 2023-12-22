using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

using MedicalAppCS.Properties;

using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.Enumerations;
using System.Globalization;

namespace MedicalAppCS
{
    public partial class MainForm : RadForm
    {

        public DateTime CurrentDate
        {
            get { return new DateTime(2015, 6, 17, DateTime.Now.Hour, DateTime.Now.Minute, 0); }
        }

        public MainForm()
        {
            InitializeComponent();
            ThemeResolutionService.LoadPackageResource("MedicalAppCS.Themes.MedicalAppTheme.tssp");
            RadMessageBox.Instance.ThemeName = "MedicalAppTheme";
            this.SetToggleButtonsStateImages();
            DataSources.PatientsDataSet = this.patientsDataSet;
            DataSources.PatientsDataSet.Appointments.AppointmentsRowChanged += Appointments_AppointmentsRowChanged;
        }

        #region Main screen

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.personsTableAdapter.Fill(this.patientsDataSet.Persons);
            this.personImagesTableAdapter.Fill(this.patientsDataSet.PersonImages);
            this.encountersTableAdapter.Fill(this.patientsDataSet.Encounters);
            this.conceptsTableAdapter.Fill(this.patientsDataSet.Concepts);
            this.appointmentsTableAdapter.Fill(this.patientsDataSet.Appointments);
            this.patientsTableAdapter.Fill(this.patientsDataSet.Patients);

            this.SetPageViewPageVisualStyles(this.radPageViewPageDashboard);
            this.SetPageViewPageVisualStyles(this.radPageViewPageSchedule);
            this.SetPageViewPageVisualStyles(this.radPageViewPageCharts);
            this.SetCurrentPageViewPage(this.radPageViewPageDashboard);
            this.UpdateSelectedPageData();

            // Main panel
            this.FormElement.TitleBar.MaximizeButton.Enabled = false;
            this.FormElement.ImageBorder.BorderThickness = new Padding(0);
            this.mainPanel.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed;
            this.radPanelButtonsContainer.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed;
            this.radSplitButton1.DropDownButtonElement.DropDownMenu.PopupElement.Alignment = ContentAlignment.MiddleRight;

            // Dashboard
            this.dashboardClockCalendarPanel.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed;
            this.radCalendarDashboard.FocusedDate = CurrentDate;

            // Schedule
            this.radCalendarSchedule.FocusedDate = CurrentDate;
            this.CustomizeCurrentSchedulerView();
            this.radSchedulerNavigator1.TimelineViewButton.Visibility = ElementVisibility.Hidden;
            this.radScheduler1.SchedulerElement.ViewElement.AppointmentMargin = new Padding(0, 0, 0, 1);
            this.AddSchedulerAppointmentBackgrounds();
            this.BindScheduler();

            CalendarNavigationElement navigationElement = this.radCalendarSchedule.CalendarElement.CalendarNavigationElement;
            navigationElement.PreviousButton.Visibility = ElementVisibility.Visible;
            navigationElement.NextButton.Visibility = ElementVisibility.Visible;
            navigationElement.BackColor = Color.FromArgb(242, 242, 243);
            navigationElement.MinSize = new Size(0, 32);
            navigationElement.Padding = new Padding(3, 6, 3, 6);

            // Charts
            this.radGridViewPatients.TableElement.RowHeight = 30;
        }

        private void Appointments_AppointmentsRowChanged(object sender, PatientsDataSet.AppointmentsRowChangeEvent e)
        {
            this.AddNextPatients();
            this.UpdateTodayAndTomorrowLabels();
        }

        private void dashboardToggleButton_Click(object sender, EventArgs e)
        {
            this.ResetToggleButtons(this.dashboardToggleButton);
            this.SetCurrentPageViewPage(this.radPageViewPageDashboard);
        }

        private void scheduleToggleButton_Click(object sender, EventArgs e)
        {
            this.ResetToggleButtons(this.scheduleToggleButton);
            this.SetCurrentPageViewPage(this.radPageViewPageSchedule);
        }

        private void chartsToggleButton_Click(object sender, EventArgs e)
        {
            this.ResetToggleButtons(this.chartsToggleButton);
            this.SetCurrentPageViewPage(this.radPageViewPageCharts);
        }

        private void radSplitButton1_DropDownOpening(object sender, EventArgs e)
        {
            RadPopupOpeningEventArgs args = e as RadPopupOpeningEventArgs;
            args.CustomLocation = new Point(args.CustomLocation.X + this.radSplitButton1.Width - 20, args.CustomLocation.Y);
        }

        private void radPageView1_SelectedPageChanged(object sender, EventArgs e)
        {
            this.UpdateSelectedPageData();
        }

        private void UpdateSelectedPageData()
        {
            if (this.radPageView1.SelectedPage != null && this.radPageView1.Pages.IndexOf(this.radPageView1.SelectedPage) < 3)
            {
                (this.radPageView1.ViewElement as RadPageViewStripElement).ContentArea.BackColor = Color.White;
            }
            else
            {
                (this.radPageView1.ViewElement as RadPageViewStripElement).ContentArea.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local);
            }

            if (this.radPageView1.SelectedPage == this.radPageViewPageDashboard)
            {
                this.AddNextPatients();
                this.UpdateTodayAndTomorrowLabels();
            }
            else if (this.radPageView1.SelectedPage == this.radPageViewPageCharts)
            {
                this.FillPatientInfo();
            }
        }

        private void SetPageViewPageVisualStyles(RadPageViewPage page)
        {
            (page.Item as RadPageViewStripItem).ButtonsPanel.CloseButton.Visibility = ElementVisibility.Collapsed;
            page.Item.Padding = new Padding(14, 10, 14, 10);
            page.Item.BackColor = Color.FromArgb(36, 24, 58);
            page.Item.SetThemeValueOverride(LightVisualElement.ForeColorProperty, Color.White, "");
            page.Item.SetThemeValueOverride(LightVisualElement.ForeColorProperty, Color.FromArgb(11, 187, 221), "Selected");
            page.Item.SetThemeValueOverride(LightVisualElement.ForeColorProperty, Color.FromArgb(11, 187, 221), "MouseOver");
            page.Item.SetThemeValueOverride(LightVisualElement.ForeColorProperty, Color.FromArgb(11, 187, 221), "MouseDown");
        }

        private void SetCurrentPageViewPage(RadPageViewPage page)
        {
            this.radPageViewPageDashboard.Item.Visibility = ElementVisibility.Collapsed;
            this.radPageViewPageSchedule.Item.Visibility = ElementVisibility.Collapsed;
            this.radPageViewPageCharts.Item.Visibility = ElementVisibility.Collapsed;
            page.Item.Visibility = ElementVisibility.Visible;
            this.radPageView1.SelectedPage = page;
        }

        private void SetToggleButtonsStateImages()
        {
            this.dashboardToggleButton.ButtonElement.SetThemeValueOverride(ImagePrimitive.ImageProperty, Resources.dashboard, "");
            this.dashboardToggleButton.ButtonElement.SetThemeValueOverride(ImagePrimitive.ImageProperty, Resources.dashboard_selected, "ToggleState=On");
            this.dashboardToggleButton.ButtonElement.SetThemeValueOverride(ImagePrimitive.ImageProperty, Resources.dashboard_selected, "MouseOver");
            this.dashboardToggleButton.ButtonElement.SetThemeValueOverride(ImagePrimitive.ImageProperty, Resources.dashboard_selected, "Pressed");
            this.scheduleToggleButton.ButtonElement.SetThemeValueOverride(ImagePrimitive.ImageProperty, Resources.schedule, "");
            this.scheduleToggleButton.ButtonElement.SetThemeValueOverride(ImagePrimitive.ImageProperty, Resources.schedule_selected, "ToggleState=On");
            this.scheduleToggleButton.ButtonElement.SetThemeValueOverride(ImagePrimitive.ImageProperty, Resources.schedule_selected, "MouseOver");
            this.scheduleToggleButton.ButtonElement.SetThemeValueOverride(ImagePrimitive.ImageProperty, Resources.schedule_selected, "Pressed");
            this.chartsToggleButton.ButtonElement.SetThemeValueOverride(ImagePrimitive.ImageProperty, Resources.charts, "");
            this.chartsToggleButton.ButtonElement.SetThemeValueOverride(ImagePrimitive.ImageProperty, Resources.charts_selected, "ToggleState=On");
            this.chartsToggleButton.ButtonElement.SetThemeValueOverride(ImagePrimitive.ImageProperty, Resources.charts_selected, "MouseOver");
            this.chartsToggleButton.ButtonElement.SetThemeValueOverride(ImagePrimitive.ImageProperty, Resources.charts_selected, "Pressed");
        }

        private void ResetToggleButtons(RadToggleButton currentButton)
        {
            if (this.dashboardToggleButton != currentButton)
            {
                this.dashboardToggleButton.ToggleState = ToggleState.Off;
            }
            if (this.scheduleToggleButton != currentButton)
            {
                this.scheduleToggleButton.ToggleState = ToggleState.Off;
            }
            if (this.chartsToggleButton != currentButton)
            {
                this.chartsToggleButton.ToggleState = ToggleState.Off;
            }
        }

        #endregion

        #region Dashboard

        private void radListViewNextPatients_VisualItemCreating(object sender, ListViewVisualItemCreatingEventArgs e)
        {
            e.VisualItem = new PatientsListViewVisualItem();
        }

        private void radListViewNextPatients_VisualItemFormatting(object sender, ListViewVisualItemEventArgs e)
        {
            (e.VisualItem as PatientsListViewVisualItem).TopRightElement.Text = ((DateTime)e.VisualItem.Data["Time"]).ToString("HH:mm");
            int itemIndex = this.radListViewNextPatients.Items.IndexOf(e.VisualItem.Data);
            Padding padding;
            if (itemIndex == 0)
            {
                string fullName = e.VisualItem.Data["Name"].ToString();
                if (fullName.Length > 17)
                {
                    string[] names = fullName.Split(new char[] { ' ' });
                    fullName = names[0] + "<br>  " + names[1];
                }
                e.VisualItem.Text =
                    "<html>" +
                        "<span style=\"color:#006DC0;font-size:24pt;font-family:Segoe UI Light;\">  " + fullName + "</span>" +
                        "<br>" +
                        "<span style=\"color:#4F4C4C;font-size:13pt;font-family:Segoe UI;\">    " + e.VisualItem.Data["Age"] + " yo | " + e.VisualItem.Data["Gender"] + "</span>" +
                    "</html>";

                e.VisualItem.BorderTopColor = Color.Transparent;
                padding = new Padding(2, 1, 2, 9);
            }
            else
            {
                if (itemIndex == 1)
                {
                    padding = new Padding(2, 10, 2, 10);
                }
                else
                {
                    padding = new Padding(2, 10, 2, 1);
                    e.VisualItem.BorderBottomColor = Color.Transparent;
                }

                e.VisualItem.Font = new Font("Segoe UI Light", 16f);
                e.VisualItem.ForeColor = Color.FromArgb(0, 109, 192);
                e.VisualItem.Text = "   " + e.VisualItem.Data["Name"].ToString();
            }

            e.VisualItem.Padding = padding;
            e.VisualItem.TextAlignment = ContentAlignment.TopLeft;
        }

        private void radListViewNextPatients_DoubleClick(object sender, EventArgs e)
        {
            if (this.radListViewNextPatients.SelectedItem == null)
            {
                return;
            }

            int patientId = (int)this.radListViewNextPatients.SelectedItem["PersonId"];
            this.CreatePatientEncountersInfoTab(patientId);
        }

        private void registerNewPatient_Click(object sender, EventArgs e)
        {
            AddPatientForm addPatientForm = new AddPatientForm();
            addPatientForm.StartPosition = FormStartPosition.CenterParent;
            addPatientForm.ShowDialog(this);
        }

        private void newAppointment_Click(object sender, EventArgs e)
        {
            AppointmentForm addAppointmentForm = new AppointmentForm();
            addAppointmentForm.StartPosition = FormStartPosition.CenterParent;
            addAppointmentForm.ShowDialog(this);

            this.SetSchedulerAppointmentsBackground();
        }

        private void radPanelTodaysAppointments_Click(object sender, EventArgs e)
        {
            this.SetSchedulerPageActive(CurrentDate);
        }

        private void radPanelTomorrowAppointments_Click(object sender, EventArgs e)
        {
            this.SetSchedulerPageActive(CurrentDate.AddDays(1));
        }

        private void radCalendarDashboard_SelectionChanged(object sender, EventArgs e)
        {
            this.SetSchedulerPageActive(this.radCalendarDashboard.SelectedDate);
        }

        private void SetSchedulerPageActive(DateTime date)
        {
            this.scheduleToggleButton.ToggleState = ToggleState.On;
            this.scheduleToggleButton_Click(null, null);
            this.radScheduler1.ActiveViewType = SchedulerViewType.MultiDay;
            this.radScheduler1.FocusedDate = date;
        }

        private void AddNextPatients()
        {
            //Select incoming three encounters and add them
            PatientsDataSet.AppointmentsDataTable appointments = this.patientsDataSet.Appointments;
            DataRow[] nextAppointments = appointments.Select("Start >= #" + CurrentDate.ToString(CultureInfo.InvariantCulture) + "#");

            DataTable table = new DataTable();
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Age", typeof(int));
            table.Columns.Add("Gender", typeof(string));
            table.Columns.Add("Time", typeof(DateTime));
            table.Columns.Add("PersonId", typeof(int));
            table.Columns.Add("PersonImageId", typeof(int));

            for (int i = 0; i < nextAppointments.Length; i++)
            {
                PatientsDataSet.AppointmentsRow nextAppointment = (PatientsDataSet.AppointmentsRow)nextAppointments[i];

                if (i > 2)
                {
                    // add only next three items
                    break;
                }

                PatientsDataSet.PersonsRow person = this.patientsDataSet.Persons.FindById(nextAppointment.PersonId);
                DateTime today = CurrentDate;
                int age = today.Year - person.BirthDate.Year;
                if (person.BirthDate > today.AddYears(-age))
                {
                    age--;
                }
                table.Rows.Add(person.FirstName + " " + person.FamilyName, age, person.Gender == "M" ? "male" : "female", nextAppointment.Start, person.Id, person.PersonImageId);
            }

            if (nextAppointments.Length != 0)
            {
                this.radListViewNextPatients.DataSource = table;

                for (int i = 0; i < radListViewNextPatients.Items.Count; i++)
                {
                    int personImageId = (int)radListViewNextPatients.Items[i]["PersonImageId"];
                    Size imageSize;
                    if (i == 0)
                    {
                        imageSize = new Size(110, 112);
                    }
                    else
                    {
                        imageSize = new Size(72, 72);
                    }

                    Bitmap bitmap = this.GetPersonImageById(personImageId, imageSize);

                    this.radListViewNextPatients.Items[i].Image = bitmap;
                }
            }
        }

        private void UpdateTodayAndTomorrowLabels()
        {
            DataRow[] todaysAndTomorrowsAppointments = this.patientsDataSet.Appointments
                .Select("Start > #" + CurrentDate.ToString("d", CultureInfo.InvariantCulture) + "# AND Start < #" + CurrentDate.AddDays(2).ToString("d", CultureInfo.InvariantCulture) + "#");
            int todayAppointmentsCount = 0;
            int tomorrowAppointmentsCount = 0;
            DateTime lastAppointmentTodayDateTime = DateTime.MinValue;
            DateTime firstAppointmentTodayDateTime = DateTime.MaxValue;
            foreach (PatientsDataSet.AppointmentsRow appointment in todaysAndTomorrowsAppointments)
            {
                if (appointment.Start.Day == CurrentDate.Day)
                {
                    todayAppointmentsCount++;
                    if (lastAppointmentTodayDateTime < appointment.Start)
                    {
                        lastAppointmentTodayDateTime = appointment.Start;
                    }
                }
                else if (appointment.Start.Day == CurrentDate.AddDays(1).Day)
                {
                    tomorrowAppointmentsCount++;
                    if (firstAppointmentTodayDateTime > appointment.Start)
                    {
                        firstAppointmentTodayDateTime = appointment.Start;
                    }
                }
            }

            this.radLabelTodayAppointmentsCount.Text = todayAppointmentsCount.ToString();
            this.radLabelLastAppointmentToday.Text = "last one at " + lastAppointmentTodayDateTime.ToString("H:mm");

            this.radLabelTomorrowAppointmentsCount.Text = tomorrowAppointmentsCount.ToString();
            this.radLabelFirstAppointmentTomorrow.Text = "first one at " + firstAppointmentTodayDateTime.ToString("H:mm");
        }

        #endregion

        #region Scheduler

        private void radScheduler1_ActiveViewChanged(object sender, SchedulerViewChangedEventArgs e)
        {
            this.CustomizeCurrentSchedulerView();
        }

        private void radScheduler1_DataBindingComplete(object sender, EventArgs e)
        {
            this.SetSchedulerAppointmentsBackground();
        }

        private void radScheduler1_AppointmentEditDialogShowing(object sender, AppointmentEditDialogShowingEventArgs e)
        {
            e.Cancel = true;

            // if creating new appointment
            AppointmentForm addAppointmentForm = new AppointmentForm();
            if (e.Appointment.DataItem != null)
            {
                DataRowView rowView = e.Appointment.DataItem as DataRowView;
                addAppointmentForm.Tag = rowView.Row;
            }
            else
            {
                addAppointmentForm.Tag = new Appointment(e.Appointment.Start, e.Appointment.End);
            }

            addAppointmentForm.StartPosition = FormStartPosition.CenterParent;
            addAppointmentForm.ShowDialog(this);
            this.SetSchedulerAppointmentsBackground();
        }

        private void radScheduler1_AppointmentDeleted(object sender, SchedulerAppointmentEventArgs e)
        {
            this.appointmentsTableAdapter.Update(DataSources.PatientsDataSet.Appointments);
        }

        private void DayViewButton_Click(object sender, EventArgs e)
        {
            this.radScheduler1.ActiveViewType = SchedulerViewType.MultiDay;
        }

        private void radCalendarSchedule_SelectionChanged(object sender, EventArgs e)
        {
            this.radScheduler1.FocusedDate = this.radCalendarSchedule.SelectedDate;
        }

        private void BindScheduler()
        {
            SchedulerBindingDataSource dataSource = new SchedulerBindingDataSource();
            AppointmentMappingInfo appointmentMappingInfo = new AppointmentMappingInfo();
            appointmentMappingInfo.Start = "Start";
            appointmentMappingInfo.End = "End";
            appointmentMappingInfo.Summary = "Subject";
            appointmentMappingInfo.Description = "Description";
            appointmentMappingInfo.Location = "Location";

            dataSource.EventProvider.Mapping = appointmentMappingInfo;
            dataSource.EventProvider.DataSource = this.appointmentsBindingSource;

            this.radScheduler1.DataSource = dataSource;
        }

        private void CustomizeCurrentSchedulerView()
        {
            this.radScheduler1.FocusedDate = CurrentDate;
            SchedulerDayViewBase dayViewBase = null;
            if (this.radScheduler1.ActiveViewType == SchedulerViewType.Day)
            {
                dayViewBase = this.radScheduler1.GetDayView();
            }
            else if (this.radScheduler1.ActiveViewType == SchedulerViewType.MultiDay)
            {
                dayViewBase = this.radScheduler1.GetMultiDayView();
            }
            else if (this.radScheduler1.ActiveViewType == SchedulerViewType.Week)
            {
                dayViewBase = this.radScheduler1.GetWeekView();
            }

            if (dayViewBase != null)
            {
                dayViewBase.RulerFormatStrings.HoursFormatString = "HH";
                dayViewBase.RulerFormatStrings.MinutesFormatString = ":mm";
                dayViewBase.RulerStartScale = 7;
                dayViewBase.RulerEndScale = 20;
                dayViewBase.RulerWidth = 55;
                dayViewBase.RangeFactor = ScaleRange.QuarterHour;
            }
        }

        private void AddSchedulerAppointmentBackgrounds()
        {
            this.radScheduler1.Backgrounds.Clear();
            this.AddSchedulerAppointmentbacroundInfo(1, "Purple", Color.FromArgb(218, 219, 255));
            this.AddSchedulerAppointmentbacroundInfo(2, "Yellow", Color.FromArgb(255, 252, 223));
            this.AddSchedulerAppointmentbacroundInfo(3, "Red", Color.FromArgb(252, 218, 202));
            this.AddSchedulerAppointmentbacroundInfo(4, "Green", Color.FromArgb(216, 245, 179));
        }

        private void AddSchedulerAppointmentbacroundInfo(int id, string name, Color backColor)
        {
            AppointmentBackgroundInfo backInfo = new AppointmentBackgroundInfo(id, name, backColor, backColor);
            backInfo.ForeColor = Color.Black;
            backInfo.ShadowStyle = ShadowStyles.Solid;
            backInfo.ShadowWidth = 0;
            backInfo.BorderBoxStyle = BorderBoxStyle.SingleBorder;
            backInfo.BorderColor = Color.FromArgb(198, 202, 185);
            backInfo.BorderGradientStyle = GradientStyles.Solid;
            backInfo.DateTimeColor = this.radScheduler1.SchedulerElement.DefaultDateTimeTitleColor;
            backInfo.DateTimeFont = this.radScheduler1.SchedulerElement.DefaultDateTimeTitleFont;
            this.radScheduler1.Backgrounds.Add(backInfo);
        }

        private void SetSchedulerAppointmentsBackground()
        {
            int colorIndex = 1;
            foreach (IEvent appointment in this.radScheduler1.Appointments)
            {
                appointment.BackgroundId = colorIndex;
                colorIndex++;
                if (this.radScheduler1.Backgrounds.Count < colorIndex)
                {
                    colorIndex = 1;
                }
            }
        }

        #endregion

        #region Charts

        private void radGridViewPatients_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            this.FillPatientInfo();
        }

        private void radGridViewPatients_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            if (e.Row is GridViewDataRowInfo)
            {
                GridViewRowInfo currentRow = this.radGridViewPatients.CurrentRow;
                if (currentRow == null)
                {
                    return;
                }

                this.CreatePatientEncountersInfoTab((int)currentRow.Cells["Id"].Value);
            }
        }

        private void FillPatientInfo()
        {
            GridViewRowInfo currentRow = this.radGridViewPatients.CurrentRow;
            if (currentRow == null || currentRow is GridViewGroupRowInfo)
            {
                return;
            }

            this.radLabelSelectedPatientNameCharts.Text = currentRow.Cells["First Name"].Value.ToString() + " " + currentRow.Cells["Last Name"].Value.ToString();
            this.radLabelSelectedPatientAgeGenderCharts.Text = string.Format("{0} yo | {1}",
                currentRow.Cells["Age"].Value.ToString(), (currentRow.Cells["Sex"].Value.ToString() == "M" ? "male" : "female"));
            int personId = (int)currentRow.Cells["Id"].Value;
            PatientsDataSet.PersonsRow person = this.patientsDataSet.Persons.FindById(personId);
            int personImageId = -1;
            if (person["PersonImageId"] != DBNull.Value)
            {
                personImageId = person.PersonImageId;
            }
            Bitmap bitmap = this.GetPersonImageById(personImageId, new Size(114, 114));
            this.radLabelSelectedPatientImageCharts.Image = bitmap;

            this.FillSelectedPersonConditions(personId);
        }

        private void radButtonShowInfoCharts_Click(object sender, EventArgs e)
        {
            GridViewRowInfo currentRow = this.radGridViewPatients.CurrentRow;
            if (currentRow == null)
            {
                return;
            }

            this.CreatePatientEncountersInfoTab((int)currentRow.Cells["Id"].Value);
        }

        private void CreatePatientEncountersInfoTab(int personId)
        {
            PatientsDataSet.PersonsRow person = this.patientsDataSet.Persons.FindById(personId);
            if (person == null)
            {
                return;
            }

            RadPageViewPage patientEncountersPage = new RadPageViewPage();
            PatientEncounters patientEncounters = new PatientEncounters();
            patientEncounters.Tag = personId;
            patientEncountersPage.Text = person.FirstName.ToUpper() + " " + person.FamilyName.ToUpper();
            patientEncountersPage.Controls.Add(patientEncounters);
            this.radPageView1.Pages.Add(patientEncountersPage);
            this.radPageView1.SelectedPage = patientEncountersPage;
        }

        private void FillSelectedPersonConditions(int personId)
        {
            this.radListControl1.Items.Clear();
            DataRow[] results = this.patientsDataSet.Encounters.Select("PersonId = " + personId);
            foreach (DataRow row in results)
            {
                int primaryId;
                if (int.TryParse(row["PrimaryDiagnosisId"].ToString(), out primaryId))
                {
                    PatientsDataSet.ConceptsRow concept = this.patientsDataSet.Concepts.FindById(primaryId);
                    RadListDataItem item = new RadListDataItem(concept.Name);
                    item.TextWrap = true;
                    this.radListControl1.Items.Add(item);
                }

                int secondaryId;
                if (int.TryParse(row["SecondaryDiagnosisId"].ToString(), out secondaryId))
                {
                    PatientsDataSet.ConceptsRow concept = this.patientsDataSet.Concepts.FindById(secondaryId);
                    RadListDataItem item = new RadListDataItem(concept.Name);
                    item.TextWrap = true;
                    this.radListControl1.Items.Add(item);
                }
            }
        }

        #endregion

        private Bitmap GetPersonImageById(int personImageId, Size size)
        {
            PatientsDataSet.PersonImagesRow personImage = this.patientsDataSet.PersonImages.FindById(personImageId);
            Image image;
            if (personImage != null && personImage["Picture"] != DBNull.Value)
            {
                using (MemoryStream ms = new MemoryStream(personImage.Picture))
                {
                    image = Image.FromStream(ms);
                }
            }
            else
            {
                image = Resources.no_image;
            }

            Bitmap bitmap = new Bitmap(image, size);
            return bitmap;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        protected override FormControlBehavior InitializeFormBehavior()
        {
            return new MyFormBehavior(this, true);
        }

        private void radScheduler1_ContextMenuOpening(object sender, SchedulerContextMenuOpeningEventArgs e)
        {
            e.Menu.Items.RemoveAt(2);
        }
    }

    public class MyFormBehavior : RadFormBehavior
    {
        public MyFormBehavior(IComponentTreeHandler treeHandler, bool shouldCreateChildren) :
            base(treeHandler, shouldCreateChildren)
        {
        }

        public override Padding BorderWidth
        {
            get
            {
                return new Padding(1);
            }
        }
    }

    public class PatientsListViewVisualItem : SimpleListViewVisualItem
    {
        LightVisualElement topRightElement;

        public LightVisualElement TopRightElement
        {
            get
            {
                return this.topRightElement;
            }
        }

        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(SimpleListViewVisualItem);
            }
        }

        protected override void CreateChildElements()
        {
            base.CreateChildElements();

            this.topRightElement = new LightVisualElement();
            this.topRightElement.StretchHorizontally = false;
            this.topRightElement.StretchVertically = false;
            this.topRightElement.DrawFill = true;
            this.topRightElement.NumberOfColors = 1;
            this.topRightElement.BackColor = Color.FromArgb(27, 4, 69);
            this.topRightElement.ForeColor = Color.White;
            this.topRightElement.Font = new Font("Segoe UI Semibold", 11f);
            this.topRightElement.Alignment = ContentAlignment.TopRight;
            this.topRightElement.Padding = new Padding(2);

            this.Children.Add(this.topRightElement);
        }
    }
}