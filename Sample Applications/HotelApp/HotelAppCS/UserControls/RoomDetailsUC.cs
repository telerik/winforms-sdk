using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelApp.Data;
using Telerik.WinControls.UI;
using Telerik.WinControls.Primitives;
using CustomControls;
using Telerik.WinControls;

namespace HotelApp
{
    public partial class RoomDetailsUC : UserControl
    {
        private string comingFrom;
        private HotelAppForm form;
        private Room room;
        private EditGuestInfo editGuestInfo;
        private Booking booking;
        private Guest selectedGuest;
        private SchedulerBindingDataSource schedulerBindingDataSource1 = new SchedulerBindingDataSource();
        private AppointmentMappingInfo appointmentMappingInfo = new AppointmentMappingInfo();

        public RoomDetailsUC()
        {
            InitializeComponent();
            this.searchPanel.RootElement.EnableElementShadow = false;

            this.backButton.ButtonElement.Text = "";
            this.backButton.ButtonElement.CustomFont = "TelerikWebUI";
            this.backButton.ButtonElement.CustomFontSize = 20;
            this.backButton.ButtonElement.ForeColor = Color.Gray;
            this.backButton.RootElement.EnableElementShadow = false;
            this.backButton.ButtonElement.Padding = new Padding(0);
            this.backButton.Click += backButton_Click;

            this.roomIdLabel.RootElement.EnableElementShadow = false;
            this.roomIdLabel.LabelElement.CustomFont = Utils.MainFont;
            this.roomIdLabel.LabelElement.CustomFontSize = 15;
            this.roomIdLabel.LabelElement.CustomFontStyle = FontStyle.Regular;

            this.typeLabel.RootElement.EnableElementShadow = false;
            this.typeLabel.LabelElement.CustomFont = Utils.MainFont;
            this.typeLabel.LabelElement.CustomFontSize = 9;
            this.typeLabel.LabelElement.CustomFontStyle = FontStyle.Regular;
            this.typeLabel.TextImageRelation = TextImageRelation.ImageBeforeText;
            this.typeLabel.LabelElement.LabelText.Margin = new Padding(10, 0, 0, 0);

            this.statusLabel.RootElement.EnableElementShadow = false;
            this.statusLabel.LabelElement.CustomFont = Utils.MainFont;
            this.statusLabel.LabelElement.CustomFontSize = 15;
            this.statusLabel.LabelElement.CustomFontStyle = FontStyle.Regular;

            this.roomsScheduler.ActiveViewType = Telerik.WinControls.UI.SchedulerViewType.Month;
            this.roomsScheduler.ActiveViewChanging += roomsScheduler_ActiveViewChanging;
            this.roomsSchedulerNavigator.SchedulerNavigatorElement.ViewPanel.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            this.roomsScheduler.AppointmentFormatting += radScheduler1_AppointmentFormatting;
            this.roomsScheduler.AppointmentEditDialogShowing += roomsScheduler_AppointmentEditDialogShowing;
            this.roomsScheduler.AppointmentSelected += roomsScheduler_AppointmentSelected;

            this.roomsScheduler.CellSelectionChanged += roomsScheduler_CellSelectionChanged;
            this.roomsScheduler.ShowAppointmentStatus = false;
            SchedulerMonthViewElement monthViewElement = this.roomsScheduler.SchedulerElement.ViewElement as SchedulerMonthViewElement;
            monthViewElement.VerticalHeader.HeaderWidth = 50;
            monthViewElement.Children[3].Visibility = ElementVisibility.Collapsed;

            this.guestHeaderPanel.RootElement.EnableElementShadow = false;

            this.closeButton.RootElement.EnableElementShadow = false;
            this.closeButton.ButtonElement.Padding = new Padding(0);
            this.closeButton.ImageAlignment = ContentAlignment.TopRight;
            this.closeButton.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.closeButton.Image = HotelApp.Properties.Resources.not_clean;
            this.closeButton.Click += closeButton_Click;
            this.guestHeaderLabel.RootElement.EnableElementShadow = false;
            this.guestHeaderLabel.LabelElement.CustomFont = Utils.MainFontMedium;
            this.guestHeaderLabel.LabelElement.CustomFontSize = 10.5f;
            this.guestHeaderLabel.LabelElement.LabelText.Margin = new Padding(5, 0, 0, 0);

            this.guestNamePanel.RootElement.EnableElementShadow = false;
            this.guestNameLabel.RootElement.EnableElementShadow = false;
            this.roomIconLabel.RootElement.EnableElementShadow = false;

            this.guestNameLabel.LabelElement.CustomFont = Utils.MainFont;
            this.guestNameLabel.LabelElement.CustomFontSize = 15f;
            this.guestNameLabel.Image = HotelApp.Properties.Resources.edit;
            this.guestNameLabel.TextImageRelation = TextImageRelation.TextBeforeImage;
            this.guestNameLabel.LabelElement.LabelImage.Padding = new Padding(0, -3, 0, 0);
            this.guestNameLabel.LabelElement.Padding = new Padding(5, 0, 0, 0);
            this.guestNameLabel.Click += guestNameLabel_Click;
            this.guestNameLabel.TextChanged += guestNameLabel_TextChanged;

            this.guestSeparator.SeparatorElement.Line1.BackColor = Color.FromArgb(209, 209, 209);
            this.addGuestPanel.RootElement.EnableElementShadow = false;
            this.addGuestButton.RootElement.EnableElementShadow = false;
            this.addGuestLabel.RootElement.EnableElementShadow = false;

            this.addGuestLabel.LabelElement.CustomFont = Utils.MainFont;
            this.addGuestLabel.LabelElement.CustomFontSize = 10.5f;
            this.addGuestLabel.ForeColor = Utils.MainThemeColor;
            this.addGuestButton.Image = Properties.Resources.plus;
            this.addGuestButton.Click += addGuestButton_Click;
            this.addGuestButton.ButtonElement.ImagePrimitive.Margin = new Padding(-10, 0, 0, 0);

            this.houseKeepingHeaderLabel.RootElement.EnableElementShadow = false;
            this.houseKeepingHeaderLabel.LabelElement.LabelText.Margin = new Padding(5, 0, 0, 0);

            this.statusHeaderLabel.LabelElement.CustomFont = Utils.MainFont;
            this.statusHeaderLabel.LabelElement.CustomFontSize = 10.5f;
            this.statusHeaderLabel.RootElement.EnableElementShadow = false;
            this.statusHeaderLabel.LabelElement.LabelText.Margin = new Padding(7, 0, 0, 0);
            this.statusDropDown.RootElement.EnableElementShadow = false;
            this.statusDropDown.DropDownListElement.ArrowButton.Margin = new Padding(0, 0, 20, 0);
            this.statusDropDown.DropDownListElement.EditableElement.TextBox.Margin = new Padding(-5, 5, 0, 0);

            this.priorityHeader.RootElement.EnableElementShadow = false;
            this.priorityHeader.LabelElement.LabelText.Margin = new Padding(5, 10, 0, 0);
            this.priorityHeader.LabelElement.CustomFont = Utils.MainFont;
            this.priorityHeader.LabelElement.CustomFontSize = 10.5f;
            this.priorityHeader.TextAlignment = ContentAlignment.BottomLeft;

            this.priorityDropDown.DropDownListElement.EditableElement.TextBox.Margin = new Padding(-5, 5, 0, 0);
            this.priorityDropDown.DropDownListElement.ArrowButton.Margin = new Padding(0, 0, 20, 0);
            this.priorityDropDown.RootElement.EnableElementShadow = false;
            this.needsRepairsCheckBox.RootElement.EnableElementShadow = false;
            this.needsRepairsCheckBox.ButtonElement.Margin = new Padding(10, 0, 0, 0);

            this.updateButton.Left = 10;
            this.updateButton.Top -= 5;

            this.statusSeparator.SeparatorElement.Line1.BackColor = Color.FromArgb(209, 209, 209);
            this.prioritySeparator.SeparatorElement.Line1.BackColor = Color.FromArgb(209, 209, 209);

            BorderPrimitive borderPrimitive = this.priorityDropDown.DropDownListElement.FindDescendant<BorderPrimitive>();
            if (borderPrimitive != null)
            {
                borderPrimitive.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            }
            borderPrimitive = this.statusDropDown.DropDownListElement.FindDescendant<BorderPrimitive>();
            if (borderPrimitive != null)
            {
                borderPrimitive.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            }

            this.statusDropDown.VisualListItemFormatting += statusDropDown_VisualListItemFormatting;
            this.statusDropDown.DataSource = Enum.GetValues(typeof(HouseKeepingStatus));
            this.priorityDropDown.DataSource = Enum.GetValues(typeof(RoomPriority));

            editGuestInfo = new EditGuestInfo();
            editGuestInfo.Dock = DockStyle.Fill;
            editGuestInfo.VisibleChanged += editGuestInfo_VisibleChanged;
            this.guestPanel.Controls.Add(editGuestInfo);
            HideEditGuestForm();
        }

        private void roomsScheduler_CellSelectionChanged(object sender, EventArgs e)
        {
            this.editGuestInfo.Visible = false;
            this.guestNameLabel.Text = string.Empty;
            this.addGuestButton.Enabled = true;
        }

        private void guestNameLabel_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.guestNameLabel.Text))
            {
                this.addGuestButton.Visible = true;
                this.addGuestLabel.Visible = true;
            }
            else
            {
                this.addGuestButton.Visible = false;
                this.addGuestLabel.Visible = false;
            }
        }

        private void roomsScheduler_AppointmentSelected(object sender, SchedulerAppointmentSelectedEventArgs e)
        {
            this.editGuestInfo.Visible = false;
            if (e.Appointment != null)
            {
                Booking b = e.Appointment.DataItem as Booking;
                if (b != null)
                {
                    if (b.Guests.Count > 0)
                    {
                        this.selectedGuest = b.Guests.First();
                        this.guestNameLabel.Text = b.Guests.First().Name;
                    }

                    this.guestNamePanel.Visible = true;
                }
                else
                {
                    this.guestNamePanel.Visible = false;
                }
            }
            else
            {
                this.guestNameLabel.Text = string.Empty;
                this.addGuestButton.Enabled = true;
            }
        }

        private void roomsScheduler_ActiveViewChanging(object sender, SchedulerViewChangingEventArgs e)
        {
            if (!(e.NewView is SchedulerMonthView))
            {
                e.Cancel = true;
            }
        }

        private void roomsScheduler_AppointmentEditDialogShowing(object sender, AppointmentEditDialogShowingEventArgs e)
        {
            e.AppointmentEditDialog = new BookingEditAppointmentDialog(form.Guests);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.guestPanel.Visible = false;
        }

        private void guestNameLabel_Click(object sender, EventArgs e)
        {
            if (booking != null)
            {
                ShowEditGuestForm();
                editGuestInfo.Initialize(this.selectedGuest, booking);
            }
        }

        private void editGuestInfo_VisibleChanged(object sender, EventArgs e)
        {
            if (!editGuestInfo.Visible)
            {
                HideEditGuestForm();                
                FilterBookings(room);
            }
        }

        private void addGuestButton_Click(object sender, EventArgs e)
        {
            ShowEditGuestForm();
            DateTimeInterval selectedInterval = this.roomsScheduler.SelectionBehavior.GetSelectedInterval();
            if (selectedInterval != DateTimeInterval.Empty)
            {
                DateTime start = selectedInterval.Start;
                DateTime end = selectedInterval.End;
                booking = new Booking() { From = start, To = end, RoomId = this.room.Id };
                booking.PricePerDay = this.room.PricePerDay;
                booking.Status = BookingStatus.Reservation;
                editGuestInfo.Initialize(new Guest(), booking);
            }
        }

        private void ShowEditGuestForm()
        {
            this.ManageVisible(false);
            this.editGuestInfo.Visible = true;
        }

        private void ManageVisible(bool visible)
        {
            foreach (Control c in this.guestPanel.Controls)
            {
                if (!(c is EditGuestInfo))
                {
                    if (visible && booking == null &&
                        c == this.guestNamePanel)
                    {
                        continue;
                    }

                    c.Visible = visible;
                }
            }
        }

        private void HideEditGuestForm()
        {
            ManageVisible(true);
            editGuestInfo.Visible = false;
            this.guestNamePanel.Visible = true;
            if (this.booking != null)
            {
                this.selectedGuest = this.booking.Guests.FirstOrDefault();
                this.guestNameLabel.Text = this.selectedGuest.Name;
            }
            else if (editGuestInfo.CurrentGuest != null)
            {
                this.guestNameLabel.Text = this.editGuestInfo.CurrentGuest.Name;
            }
        }

        private void statusDropDown_VisualListItemFormatting(object sender, VisualItemFormattingEventArgs args)
        {
            args.VisualItem.Text = Utils.GetHouseKeepingStatus((HouseKeepingStatus)args.VisualItem.Data.DataBoundItem);
        }

        private void radScheduler1_AppointmentFormatting(object sender, SchedulerAppointmentEventArgs e)
        {
            e.AppointmentElement.BackColor = Color.FromArgb(209, 209, 209);
            e.AppointmentElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid; 
            e.AppointmentElement.BorderColor = Color.FromArgb(209, 209, 209);
            e.AppointmentElement.BorderBoxStyle = Telerik.WinControls.BorderBoxStyle.OuterInnerBorders;
            e.AppointmentElement.ForeColor = Color.Black;
            e.AppointmentElement.CustomFont = Utils.MainFont;
            e.AppointmentElement.CustomFontSize = 9f;
            e.AppointmentElement.DisableHTMLRendering = false;
            e.AppointmentElement.TextAlignment = ContentAlignment.MiddleCenter;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (form != null)
            {
                if (comingFrom == "Booking")
                {
                    form.PageView.SelectedPage = form.PageView.Pages[1];
                }
                else if (comingFrom == "Schedule")
                {
                    form.PageView.SelectedPage = form.PageView.Pages[2];
                }
                form.NavigationPanel.Visible = true;
                form.RoomsListView.ListViewElement.SynchronizeVisualItems();
            }
        }

        internal void InitializeData(Room room, Booking booking, string comingFrom)
        {
            this.guestPanel.Visible = true;
            this.room = room;
            this.booking = booking;
            this.selectedGuest = booking == null ? null : booking.Guests.FirstOrDefault();
            this.form = this.FindForm() as HotelAppForm;
            this.roomDetailsSearchDropDown.Inialize(form.Rooms, form.Bookings);
            this.comingFrom = comingFrom;
            this.roomIdLabel.Text = "Room # " + room.Id;
            this.typeLabel.Text = room.Type.ToString();
            this.typeLabel.Image = Utils.GetImageByRoomType(room.Type);
            this.statusLabel.Text = "Status now: " + room.Status.ToString();
            this.roomIconLabel.Image = this.typeLabel.Image;
            this.roomIconLabel.LabelElement.LabelImage.Margin = new Padding(40, 0, 0, 0);
            this.statusDropDown.SelectedValue = room.HouseKeepingStatus;
            this.priorityDropDown.SelectedValue = room.Priority;
            this.needsRepairsCheckBox.Checked = room.NeedsRepairs;
            if (form != null)
            {
                appointmentMappingInfo.End = "To";
                appointmentMappingInfo.Start = "From";
                appointmentMappingInfo.Summary = "Name";
                appointmentMappingInfo.BackgroundId = "Status";
                schedulerBindingDataSource1.EventProvider.Mapping = appointmentMappingInfo;
                schedulerBindingDataSource1.EventProvider.DataSource = form.Bookings; 

                this.roomsScheduler.DataSource = schedulerBindingDataSource1;
                this.roomsScheduler.ShowAppointmentStatus = false;

                FilterBookings(room);

                this.roomsScheduler.ActiveView.AppointmentTitleFormat = "{2}";

                this.roomsScheduler.Backgrounds.Clear();

                AppointmentBackgroundInfo reservationBackgroundInfo = new AppointmentBackgroundInfo(1, "Reservation", Color.Yellow, Color.Yellow);
                reservationBackgroundInfo.ShadowWidth = 0;
                this.roomsScheduler.Backgrounds.Add(reservationBackgroundInfo);
                AppointmentBackgroundInfo actualBackgroundInfo = new AppointmentBackgroundInfo(2, "Actual", Color.Green, Color.Green);
                actualBackgroundInfo.ShadowWidth = 0;
                this.roomsScheduler.Backgrounds.Add(actualBackgroundInfo);
                AppointmentBackgroundInfo cancelledBackgroundInfo = new AppointmentBackgroundInfo(3, "Cancelled", Color.OrangeRed, Color.OrangeRed);
                cancelledBackgroundInfo.ShadowWidth = 0;
                this.roomsScheduler.Backgrounds.Add(cancelledBackgroundInfo);
                AppointmentBackgroundInfo checkedOutBackgroundInfo = new AppointmentBackgroundInfo(4, "CheckedOut", Color.Orange, Color.Orange);
                checkedOutBackgroundInfo.ShadowWidth = 0;
                this.roomsScheduler.Backgrounds.Add(checkedOutBackgroundInfo);
                AppointmentBackgroundInfo noShowBackgroundInfo = new AppointmentBackgroundInfo(5, "NoShow", Utils.MainThemeColor, Utils.MainThemeColor);
                noShowBackgroundInfo.ShadowWidth = 0;
                this.roomsScheduler.Backgrounds.Add(noShowBackgroundInfo);
            }

            if (booking != null)
            {
                if (booking.Guests.Count > 0)
                {
                    this.guestNameLabel.Text = booking.Guests.First().Name;
                }

                this.guestNamePanel.Visible = true;
            }
            else
            {
                this.guestNamePanel.Visible = false;
            }
            this.roomsScheduler.SchedulerElement.RefreshViewElement();
        }
 
        private void FilterBookings(Room room)
        {
            this.roomsScheduler.Appointments.BeginUpdate();
            foreach (Appointment a in this.roomsScheduler.Appointments)
            {
                Booking b = a.DataItem as Booking;
                if (b == null)
                {
                    a.Visible = false;
                    continue;
                }
                if (b.RoomId != room.Id)
                {
                    a.Visible = false;
                }
                else
                { 
                    a.Visible = true;
                }
            }
            this.roomsScheduler.Appointments.EndUpdate();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            this.room.Priority = (RoomPriority)this.priorityDropDown.SelectedValue;
            this.room.HouseKeepingStatus = (HouseKeepingStatus)this.statusDropDown.SelectedValue;

            if (this.booking == null && this.editGuestInfo.CurrentGuest != null)
            {
                TimeSpan timeDuration = this.roomsScheduler.SelectionBehavior.GetCellDuration();
                HotelAppForm form = this.FindForm() as HotelAppForm;
                DateTimeInterval bookingDuration = new DateTimeInterval(this.roomsScheduler.SelectionBehavior.SelectionStartDate, this.roomsScheduler.SelectionBehavior.SelectionEndDate);
                if (bookingDuration != DateTimeInterval.Empty)
                {
                    Booking newBooking = new Booking((uint)form.Bookings.Count, editGuestInfo.CurrentGuest, this.room.Id,
                        this.roomsScheduler.SelectionBehavior.SelectionStartDate, this.roomsScheduler.SelectionBehavior.SelectionEndDate.AddDays(1),
                        this.room.PricePerDay * bookingDuration.Duration.Days, BookingStatus.Reservation);
                    form.Bookings.Add(newBooking);
                }
            }

            if (booking != null)
            {
                schedulerBindingDataSource1.EventProvider.DataSource = form.Bookings;
                FilterBookings(room);                
            }
        }
    }
}