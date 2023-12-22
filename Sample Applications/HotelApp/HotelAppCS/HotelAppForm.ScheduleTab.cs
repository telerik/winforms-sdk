using CustomControls;
using HotelApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.UI;

namespace HotelApp
{
    partial class HotelAppForm
    {
        #region Initialization
        private void InitSchedulePage()
        {
            this.scheduleRadSchedulerHeader.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed;
            this.scheduleHeaderPanel.BackgroundImage = Properties.Resources.fasha_no_borders;
            this.scheduleHeaderPanel.BackgroundImageLayout = ImageLayout.Stretch;
            this.scheduleHeaderPanel.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed;

            this.scheduleHeaderPanel.PanelElement.PanelFill.BackColor = Color.Transparent;
            this.scheduleHeaderPanel.PanelElement.PanelFill.GradientStyle = GradientStyles.Solid;
            this.scheduleSearchPanel.PanelElement.PanelFill.BackColor = Color.Transparent;
            this.scheduleSearchPanel.BackColor = Color.Transparent;
            this.scheduleSearchPanel.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed;

            this.scheduleSearchDropDown.Inialize(this.Rooms, this.Bookings);
            this.scheduleListView.ShowGroups = true;
            this.scheduleListView.EnableGrouping = true;
            this.scheduleListView.EnableCustomGrouping = true;
            this.scheduleListView.ListViewElement.Padding = new System.Windows.Forms.Padding(0, 16, 0, 0);
            ListViewDataItemGroup scheduleStatusGroup = new ListViewDataItemGroup();
            scheduleStatusGroup.Text = "STATUS";
            ListViewDataItemGroup scheduleTypesGroup = new ListViewDataItemGroup();
            scheduleTypesGroup.Text = "TYPE";
            this.scheduleListView.ShowCheckBoxes = true;
            this.scheduleListView.Groups.AddRange(new ListViewDataItemGroup[] { scheduleStatusGroup, scheduleTypesGroup });

            Array scheduleStatusOptions = Enum.GetValues(typeof(RoomStatus));
            foreach (object item in scheduleStatusOptions)
            {
                ListViewDataItem statusItem = new ListViewDataItem(item.ToString());
                statusItem.CheckState = Telerik.WinControls.Enumerations.ToggleState.On;
                this.scheduleListView.Items.Add(statusItem);
                statusItem.Group = scheduleStatusGroup;
            }

            Array roomOptions = Enum.GetValues(typeof(RoomType));
            foreach (object item in roomOptions)
            {
                ListViewDataItem roomTypeItem = new ListViewDataItem(Utils.GetRoomType((RoomType)item));
                roomTypeItem.Value = (RoomType)item;
                roomTypeItem.CheckState = Telerik.WinControls.Enumerations.ToggleState.On;
                roomTypeItem.Group = scheduleTypesGroup;
                this.scheduleListView.Items.Add(roomTypeItem);
            }

            this.scheduleDateNavigator.DateTimePicker.ValueChanged += SchedulerDateTimePicker_ValueChanged;
            this.ScheduleRadScheduler.AppointmentTitleFormat = "{2}";
            this.ScheduleRadScheduler.ElementProvider = new MyElementProvider(this.ScheduleRadScheduler);
            this.scheduleDaysButton.ButtonElement.CustomFont = Utils.MainFontMedium;
            this.scheduleDaysButton.ButtonElement.CustomFontSize = 10.5f;
            this.scheduleWeeklyButton.ButtonElement.CustomFont = Utils.MainFontMedium;
            this.scheduleWeeklyButton.ButtonElement.CustomFontSize = 10.5f;
            this.scheduleMonthlyButton.ButtonElement.CustomFont = Utils.MainFontMedium;
            this.scheduleMonthlyButton.ButtonElement.CustomFontSize = 10.5f;

            this.scheduleDaysButton.ToggleStateChanged += scheduleDaysButton_ToggleStateChanged;
            this.scheduleWeeklyButton.ToggleStateChanged += scheduleWeeklyButton_ToggleStateChanged;
            this.scheduleMonthlyButton.ToggleStateChanged += scheduleMonthlyButton_ToggleStateChanged;

            this.ScheduleRadScheduler.SchedulerElement.SetResourceHeaderAngleTransform(SchedulerViewType.Timeline, 0);
            this.scheduleDaysButton.ToggleState = ToggleState.On;
            this.scheduleRadSchedulerHeader.TextAlignment = ContentAlignment.MiddleCenter;

            this.scheduleRadSchedulerHeader.ForeColor = Color.White;
            this.scheduleRadSchedulerHeader.PanelElement.CustomFont = Utils.MainFont;
            this.scheduleRadSchedulerHeader.PanelElement.CustomFontSize = 15f;

            this.scheduleHeaderPanel.RootElement.EnableElementShadow = false;
            this.scheduleSearchPanel.RootElement.EnableElementShadow = false;
            this.scheduleListView.RootElement.EnableElementShadow = false;
            this.ScheduleRadScheduler.RootElement.EnableElementShadow = false;
            this.scheduleBookingPanel.RootElement.EnableElementShadow = false;

            this.scheduleBookingPanel.Visible = false;
            this.ScheduleRadScheduler.MouseClick += ScheduleRadScheduler_MouseClick;

            this.ScheduleRadScheduler.AppointmentFormatting += ScheduleRadScheduler_AppointmentFormatting;
            this.ScheduleRadScheduler.CellFormatting += ScheduleRadScheduler_CellFormatting;

            this.ScheduleRadScheduler.AppointmentEditDialogShowing += ScheduleRadScheduler_AppointmentEditDialogShowing;
            this.ScheduleRadScheduler.AppointmentChanged += ScheduleRadScheduler_AppointmentChanged;
            SchedulerBindingDataSource scheduleSource = new SchedulerBindingDataSource();
            AppointmentMappingInfo appointmentMappingInfo = new AppointmentMappingInfo();
            appointmentMappingInfo.End = "To";
            appointmentMappingInfo.Start = "From";
            appointmentMappingInfo.Summary = "Name";
            appointmentMappingInfo.ResourceId = "RoomId";
            appointmentMappingInfo.BackgroundId = "Status";

            appointmentMappingInfo.FindBySchedulerProperty("ResourceId").ConvertToScheduler = ConvertTo;
            appointmentMappingInfo.FindBySchedulerProperty("ResourceId").ConvertToDataSource = ConvertFrom;
            scheduleSource.EventProvider.Mapping = appointmentMappingInfo;
            scheduleSource.EventProvider.DataSource = this.Bookings;
            ResourceMappingInfo resourceMappingInfo = new ResourceMappingInfo();
            resourceMappingInfo.Id = "Id";
            resourceMappingInfo.Name = "Name";
            scheduleSource.ResourceProvider.Mapping = resourceMappingInfo;

            BindingList<Room> scheduleRoomsCopy = new BindingList<Room>();
            foreach (Room r in this.Rooms)
            {
                scheduleRoomsCopy.Add(new Room(r.Id, r.Status, r.Type, r.HouseKeepingStatus, r.NeedsRepairs, r.PricePerDay));
            }
            scheduleSource.ResourceProvider.DataSource = scheduleRoomsCopy;

            this.ScheduleRadScheduler.DataSource = scheduleSource;

            this.ScheduleRadScheduler.Backgrounds.Clear();

            AppointmentBackgroundInfo reservationBackgroundInfo = new AppointmentBackgroundInfo(1, "Reservation", Color.Yellow, Color.Yellow);
            reservationBackgroundInfo.ShadowWidth = 0;
            this.ScheduleRadScheduler.Backgrounds.Add(reservationBackgroundInfo);
            AppointmentBackgroundInfo actualBackgroundInfo = new AppointmentBackgroundInfo(2, "Actual", Color.Green, Color.Green);
            actualBackgroundInfo.ShadowWidth = 0;
            this.ScheduleRadScheduler.Backgrounds.Add(actualBackgroundInfo);
            AppointmentBackgroundInfo cancelledBackgroundInfo = new AppointmentBackgroundInfo(3, "Cancelled", Color.OrangeRed, Color.OrangeRed);
            cancelledBackgroundInfo.ShadowWidth = 0;
            this.ScheduleRadScheduler.Backgrounds.Add(cancelledBackgroundInfo);
            AppointmentBackgroundInfo checkedOutBackgroundInfo = new AppointmentBackgroundInfo(4, "CheckedOut", Color.Orange, Color.Orange);
            checkedOutBackgroundInfo.ShadowWidth = 0;
            this.ScheduleRadScheduler.Backgrounds.Add(checkedOutBackgroundInfo);
            AppointmentBackgroundInfo noShowBackgroundInfo = new AppointmentBackgroundInfo(5, "NoShow", Utils.MainThemeColor, Utils.MainThemeColor);
            noShowBackgroundInfo.ShadowWidth = 0;
            this.ScheduleRadScheduler.Backgrounds.Add(noShowBackgroundInfo);

            this.ScheduleRadScheduler.GroupType = GroupType.Resource;
            this.ScheduleRadScheduler.ShowAppointmentStatus = false;
            foreach (Resource r in this.ScheduleRadScheduler.Resources)
            {
                r.Color = Color.White;
            }
            this.ScheduleRadScheduler.ActiveViewChanged += ScheduleRadScheduler_ActiveViewChanged;
            this.ScheduleRadScheduler.SchedulerElement.RefreshViewElement();
            this.ScheduleRadScheduler.ActiveView.ResourcesPerView = 5;
            TimelineGroupingByResourcesElement timelineElement = this.ScheduleRadScheduler.SchedulerElement.ViewElement as TimelineGroupingByResourcesElement;
            foreach (SchedulerTimelineViewElement timelineViewElement in timelineElement.GetChildViewElements())
            {
                timelineViewElement.ViewHeaderHeight = 0;
            }
            timelineElement.ResourceHeaderWidth = 80;
            timelineElement.View.GroupSeparatorWidth = 0;
            this.ScheduleRadScheduler.AppointmentAdded += ScheduleRadScheduler_AppointmentAdded;
            this.ScheduleRadScheduler.GetTimelineView().GetTimescale(Timescales.Days).Format = "dd MMM";

            this.ScheduleRadScheduler.Culture = culture;
        }
        #endregion

        #region Events
        private void ScheduleRadScheduler_AppointmentChanged(object sender, AppointmentChangedEventArgs e)
        {
            Booking b = e.Appointment.DataItem as Booking;
            if (b != null)
            {
                this.scheduleBookingInfo.LoadBookingInfo(b, this.Rooms);
            }
        }

        private void ScheduleRadScheduler_AppointmentAdded(object sender, AppointmentAddedEventArgs e)
        {
            Guest guest = this.ScheduleRadScheduler.Tag as Guest;
            Booking b = e.Appointment.DataItem as Booking;
            if (b != null)
            {
                if (guest != null)
                {
                    this.ScheduleRadScheduler.Tag = null;

                    if (guest != null)
                    {
                        b.Guests.Clear();
                        b.Guests.Add(guest);
                        b.Name = guest.Name;
                    }
                }
                else
                {
                    b.Guests = new List<Guest>();
                }
            }
        }

        private void ScheduleRadScheduler_AppointmentEditDialogShowing(object sender, AppointmentEditDialogShowingEventArgs e)
        {
            e.AppointmentEditDialog = new BookingEditAppointmentDialog(this.Guests);
        }

        private void scheduleSearchDropDown_SelectedIndexChanging(object sender, Telerik.WinControls.UI.Data.PositionChangingCancelEventArgs e)
        {
            if (e.Position > -1)
            {
                this.PageView.SelectedPage = this.OverviewPage;
                this.searchTextBoxOverview.Text = this.scheduleSearchDropDown.Text;
            }
        }

        private void SchedulerDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (this.BookingsDate != this.scheduleDateNavigator.DateTimePicker.Value &&
                this.OverviewDate != this.scheduleDateNavigator.DateTimePicker.Value)
            {
                this.BookingsDate = this.scheduleDateNavigator.DateTimePicker.Value;
                this.OverviewDate = this.scheduleDateNavigator.DateTimePicker.Value;
            }
            this.ScheduleRadScheduler.FocusedDate = this.scheduleDateNavigator.CurrentDate;
            this.scheduleListView.ListViewElement.SynchronizeVisualItems();
        }

        private void ScheduleRadScheduler_ActiveViewChanged(object sender, SchedulerViewChangedEventArgs e)
        {
            this.scheduleDateNavigator.DateTimePicker.Value = e.NewView.StartDate;
            RefreshView();
        }

        private void ScheduleRadScheduler_AppointmentFormatting(object sender, SchedulerAppointmentEventArgs e)
        {
            e.AppointmentElement.BackColor = Color.FromArgb(209, 209, 209);
            e.AppointmentElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid;
            e.AppointmentElement.NumberOfColors = 4;
            e.AppointmentElement.BorderColor = Color.FromArgb(209, 209, 209);
            e.AppointmentElement.BorderBoxStyle = Telerik.WinControls.BorderBoxStyle.OuterInnerBorders;
            e.AppointmentElement.ForeColor = Color.Black;

            Booking b = e.Appointment.DataItem as Booking;
            if (b != null)
            {
                TimeSpan duration = b.To - b.From;
                e.AppointmentElement.Text = b.Name + " - " + duration.TotalDays + " day";
                if (duration.TotalDays > 1)
                {
                    e.AppointmentElement.Text += "s";
                }
                e.AppointmentElement.DisableHTMLRendering = true;
                e.AppointmentElement.CustomFont = Utils.MainFont;
                e.AppointmentElement.CustomFontSize = 9f;
                e.AppointmentElement.TextAlignment = ContentAlignment.MiddleCenter;
            }
        }

        private void RefreshView()
        {
            SchedulerMonthViewGroupedByResourceElement monthView = this.ScheduleRadScheduler.SchedulerElement.ViewElement as SchedulerMonthViewGroupedByResourceElement;
            TimelineGroupingByResourcesElement timelineElement = this.ScheduleRadScheduler.SchedulerElement.ViewElement as TimelineGroupingByResourcesElement;
            if (monthView == null && timelineElement == null)
                return;
            this.ScheduleRadScheduler.ActiveView.ResourcesPerView = 5;
            if (monthView != null)
            {
                monthView.ResourceHeaderHeight = 100;
                monthView.DrawBorder = false;
                monthView.ResourcesHeader.DrawBorder = false;
                this.ScheduleRadScheduler.ActiveView.ResourcesPerView = 2;
                foreach (RadElement view in monthView.Children)
                {
                    SchedulerMonthViewElement monthViewElement = view as SchedulerMonthViewElement;
                    if (monthViewElement != null)
                    {
                        monthViewElement.VerticalHeader.HeaderWidth = 50;
                        monthViewElement.Children[3].Visibility = ElementVisibility.Collapsed;
                        monthViewElement.DrawBorder = false;
                    }
                }
            }
            else if (timelineElement != null)
            {
                foreach (SchedulerTimelineViewElement timelineViewElement in timelineElement.GetChildViewElements())
                {
                    timelineViewElement.ViewHeaderHeight = 0;
                }
                timelineElement.ResourceHeaderWidth = 80;
            }
        }


        private void ScheduleRadScheduler_CellFormatting(object sender, SchedulerCellEventArgs e)
        {
            e.CellElement.ZIndex = 0;
            e.CellElement.Visibility = ElementVisibility.Visible;
            if (e.CellElement.VisualState.Contains("CornerHeaderCell2"))
            {
                e.CellElement.Visibility = ElementVisibility.Collapsed;
            }
            e.CellElement.Opacity = 1;
            if ((e.CellElement.VisualState == "ResourceCell" && e.CellElement.Scheduler.ActiveViewType != SchedulerViewType.Month) ||
                e.CellElement.VisualState == "MonthViewHeaderCellElement.IsVertical")
            {
                e.CellElement.BorderBoxStyle = BorderBoxStyle.FourBorders;
                e.CellElement.BorderLeftWidth = 0;
                e.CellElement.BorderTopWidth = 1;
                e.CellElement.BorderTopColor = Color.FromArgb(209, 209, 209);
                e.CellElement.BorderRightWidth = 1;
                e.CellElement.BorderRightColor = Color.FromArgb(209, 209, 209);
                e.CellElement.BorderBottomWidth = 0;
                e.CellElement.ForeColor = Color.Black;
            }
            else
            {
                e.CellElement.ResetValue(LightVisualElement.BorderBoxStyleProperty, ValueResetFlags.Local);
                e.CellElement.ResetValue(LightVisualElement.BorderLeftWidthProperty, ValueResetFlags.Local);
                e.CellElement.ResetValue(LightVisualElement.BorderTopWidthProperty, ValueResetFlags.Local);
                e.CellElement.ResetValue(LightVisualElement.BorderTopColorProperty, ValueResetFlags.Local);
                e.CellElement.ResetValue(LightVisualElement.BorderRightWidthProperty, ValueResetFlags.Local);
                e.CellElement.ResetValue(LightVisualElement.BorderRightColorProperty, ValueResetFlags.Local);
                e.CellElement.ResetValue(LightVisualElement.BorderBottomWidthProperty, ValueResetFlags.Local);
            }

            if (!(e.CellElement is SchedulerHeaderCellElement ||
                  e.CellElement is SchedulerResourceHeaderCellElement ||
                  e.CellElement.Date.Year == 1980))
            {
                e.CellElement.BackColor = Color.FromArgb(244, 244, 244);
                e.CellElement.DrawFill = true;
                e.CellElement.GradientStyle = GradientStyles.Solid;
            }
            else
            {
                e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local);
                e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local);
                e.CellElement.ResetValue(LightVisualElement.GradientStyleProperty, ValueResetFlags.Local);
            }
        }

        private void scheduleMonthlyButton_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == ToggleState.On)
            {
                this.scheduleRadSchedulerHeader.Text = "Monthly";
                this.scheduleDaysButton.ToggleState = ToggleState.Off;
                this.scheduleWeeklyButton.ToggleState = ToggleState.Off;
                this.ScheduleRadScheduler.ActiveViewType = SchedulerViewType.Month;
            }
        }

        private void scheduleWeeklyButton_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == ToggleState.On)
            {
                this.scheduleRadSchedulerHeader.Text = "Weekly";
                this.scheduleDaysButton.ToggleState = ToggleState.Off;
                this.scheduleMonthlyButton.ToggleState = ToggleState.Off;
                this.ScheduleRadScheduler.ActiveViewType = SchedulerViewType.Timeline;
                this.ScheduleRadScheduler.GetTimelineView().GetScaling().DisplayedCellsCount = 7;
            }
        }

        private void scheduleDaysButton_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState == ToggleState.On)
            {
                this.scheduleRadSchedulerHeader.Text = "3 Days";
                this.scheduleWeeklyButton.ToggleState = ToggleState.Off;
                this.scheduleMonthlyButton.ToggleState = ToggleState.Off;
                this.ScheduleRadScheduler.ActiveViewType = SchedulerViewType.Timeline;
                this.ScheduleRadScheduler.GetTimelineView().GetScaling().DisplayedCellsCount = 3;
            }
        }

        private void ScheduleRadScheduler_MouseClick(object sender, MouseEventArgs e)
        {
            AppointmentElement clickedAppointment = this.ScheduleRadScheduler.ElementTree.GetElementAtPoint(e.Location) as AppointmentElement;

            if (clickedAppointment != null)
            {
                Booking b = clickedAppointment.Appointment.DataItem as Booking;
                if (b != null)
                {
                    this.scheduleBookingInfo.LoadBookingInfo(b, this.Rooms);
                    this.scheduleBookingPanel.Visible = true;
                }
            }
        }
		#endregion
    }
}
