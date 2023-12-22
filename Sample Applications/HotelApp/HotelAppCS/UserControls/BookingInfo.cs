using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelApp;
using HotelApp.Data;
using Telerik.WinControls.UI;
using Telerik.WinControls.Primitives;

namespace CustomControls
{
    public partial class BookingInfo : UserControl
    {
        #region Properties
        
        public Booking Booking { get; set; }
        
        public Room Room { get; set; }
        
        #endregion
        
        #region Constructor
        
        public BookingInfo()
        {
            InitializeComponent();
            
            this.bookingDatesGrid.ViewCellFormatting += bookingDatesGrid_ViewCellFormatting;
            this.bookingDatesGrid.ViewRowFormatting += bookingDatesGrid_ViewRowFormatting;
            this.bookingDatesGrid.CurrentRow = null;
            this.bookingDatesGrid.EnableSorting = false;
            this.bookingDatesGrid.EnableHotTracking = false;
            this.bookingDatesGrid.SelectionChanging += bookingDatesGrid_SelectionChanging;
            this.bookingDatesGrid.CurrentRowChanging += bookingDatesGrid_CurrentRowChanging;
            
            this.closeButton.RootElement.EnableElementShadow = false;
            this.bookingInfoLabel.RootElement.EnableElementShadow = false;
            this.headerContainer.RootElement.EnableElementShadow = false;
            this.bookingStatusContainer.RootElement.EnableElementShadow = false;
            this.bookingStatusLabel.RootElement.EnableElementShadow = false;
            this.bookingStatusDropDown.RootElement.EnableElementShadow = false;
            this.bookingNameContainer.RootElement.EnableElementShadow = false;
            this.bookingNameLabel.RootElement.EnableElementShadow = false;
            this.bookingRoomTypeIcon.RootElement.EnableElementShadow = false;
            this.manageReservationContainer.RootElement.EnableElementShadow = false;
            this.roomIdLabel.RootElement.EnableElementShadow = false;
            this.manageStatusLabel.RootElement.EnableElementShadow = false;
            this.bookingDatesGrid.RootElement.EnableElementShadow = false;

            this.roomIdLabel.Click += roomIdLabel_Click;

            this.paymentSeparator.SeparatorElement.Line1.BackColor = Color.FromArgb(209, 209, 209);
            
            this.closeButton.ButtonElement.Padding = new Padding(0);
            this.closeButton.ImageAlignment = ContentAlignment.TopRight;
            this.closeButton.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.closeButton.Image = HotelApp.Properties.Resources.not_clean;
            
            this.bookingNameLabel.Image = HotelApp.Properties.Resources.edit;
            this.bookingNameLabel.TextImageRelation = TextImageRelation.TextBeforeImage;
            this.bookingNameLabel.LabelElement.LabelImage.Padding = new Padding(0, -3, 0, 0);
            this.bookingNameLabel.LabelElement.Padding = new Padding(5, 0, 0, 0);
            this.bookingNameLabel.LabelElement.CustomFont = Utils.MainFontMedium;
            this.bookingNameLabel.LabelElement.CustomFontSize = 14f;
            this.bookingNameLabel.Click += bookingNameLabel_Click;
            this.bookingInfoLabel.LabelElement.CustomFont = Utils.MainFontMedium;
            this.bookingInfoLabel.LabelElement.CustomFontSize = 10.5f;
            this.bookingInfoLabel.LabelElement.LabelText.Margin = new Padding(0, -9, 0, 0);
            this.bookingStatusLabel.LabelElement.CustomFont = Utils.MainFont;
            this.bookingStatusLabel.LabelElement.CustomFontSize = 10.5f;
            this.bookingStatusLabel.TextAlignment = ContentAlignment.MiddleRight;
            this.roomIdLabel.LabelElement.CustomFont = Utils.MainFont;
            this.roomIdLabel.LabelElement.CustomFontSize = 10.5f;
            
            this.roomIdLabel.LabelElement.LabelText.Margin = new Padding(5, 0, 0, 0);
            this.bookingStatusDropDown.DropDownListElement.CustomFont = Utils.MainFont;
            this.bookingStatusDropDown.DropDownListElement.CustomFontSize = 10.5f;
            this.bookingStatusDropDown.DropDownListElement.ArrowButton.Margin = new System.Windows.Forms.Padding(0, 0, 25, 0);
            BorderPrimitive borderPrimitive = this.bookingStatusDropDown.DropDownListElement.FindDescendant<BorderPrimitive>();
            if (borderPrimitive != null)
            {
                borderPrimitive.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            }
            this.dropDownSeparator.SeparatorElement.Line1.BackColor = Color.FromArgb(209, 209, 209);
            this.manageStatusLabel.LabelElement.CustomFont = Utils.MainFont;
            this.manageStatusLabel.LabelElement.CustomFontSize = 10.5f;
            this.manageStatusLabel.ForeColor = Utils.MainThemeColor;
            this.bookingPriceLabel.LabelElement.CustomFont = Utils.MainFontMedium;
            this.bookingPriceLabel.LabelElement.Padding = new Padding(5, 0, 0, 0);
            this.bookingNameLabel.LabelElement.CustomFont = Utils.MainFont;
            this.bookingNameLabel.LabelElement.CustomFontSize = 15f;

            this.bookingStatusDropDown.DropDownListElement.EditorElement.Padding = new Padding(0, 2, 0, 0);
            
            this.roomImageBox.RootElement.EnableElementShadow = false;
            this.roomImageBox.PanelElement.PanelFill.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            
            this.bookingStatusDropDown.DataSource = Enum.GetValues(typeof(BookingStatus));
            this.bookingStatusDropDown.SelectedValueChanged += bookingStatusDropDown_SelectedValueChanged;
        }
        
        #endregion
        
        #region Events
            
        private void bookingStatusDropDown_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.Booking.Status != (BookingStatus)this.bookingStatusDropDown.SelectedValue)
            {
                this.Booking.Status = (BookingStatus)this.bookingStatusDropDown.SelectedValue;
                HotelAppForm form = this.FindForm() as HotelAppForm;
                if (form != null)
                {
                    form.BookingsListView.ListViewElement.SynchronizeVisualItems();
                }
            }
        }
            
        private void roomIdLabel_Click(object sender, EventArgs e)
        {
            HotelAppForm form = this.FindForm() as HotelAppForm;
            if (form != null)
            {
                string comingFrom = "Booking";
                if (form.PageView.SelectedPage == form.PageView.Pages[2])
                {
                    comingFrom = "Schedule";
                }
                form.ShowRoomDetails(this.Room, this.Booking, comingFrom);
            }
        }
            
        private void bookingNameLabel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            EditGuestInfo editGuestInfo = null;
            foreach (Control c in this.Parent.Controls)
            {
                editGuestInfo = c as EditGuestInfo;
                if (editGuestInfo != null)
                {
                    break;
                }
            }
                
            if (editGuestInfo != null)
            {
                editGuestInfo.Visible = true;
                editGuestInfo.Initialize(this.Booking.Guests.FirstOrDefault(), this.Booking);
            }
        }
        
        private void bookingDatesGrid_ViewRowFormatting(object sender, RowFormattingEventArgs e)
        {
            e.RowElement.DrawBorder = false;
        }
        
        private void bookingDatesGrid_SelectionChanging(object sender, GridViewSelectionCancelEventArgs e)
        {
            e.Cancel = true;
        }
        
        private void bookingDatesGrid_CurrentRowChanging(object sender, CurrentRowChangingEventArgs e)
        {
            e.Cancel = true;
        }
            
        private void bookingDatesGrid_ViewCellFormatting(object sender, CellFormattingEventArgs e)
        {
            e.CellElement.CustomFont = Utils.MainFont;
            e.CellElement.CustomFontSize = 10.5f;
            GridHeaderCellElement headerCell = e.CellElement as GridHeaderCellElement;
            if (headerCell != null)
            {
                if (e.Column.Name == "Occupied")
                {
                    headerCell.ImageAlignment = ContentAlignment.MiddleLeft;
                    headerCell.TextAlignment = ContentAlignment.MiddleLeft;
                }
                else
                {
                    headerCell.ImageAlignment = ContentAlignment.MiddleRight;
                    headerCell.TextAlignment = ContentAlignment.MiddleRight;
                    headerCell.Padding = new Padding(0, 0, 25, 0);
                }
            }
            if (e.Column.Name == "Occupied")
            {
                e.CellElement.Padding = new Padding(12, 0, 0, 0);
            }
            else
            {
                e.CellElement.Padding = new Padding(0, 0, 25, 0);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
        }
        
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Parent.Visible = false;
        }
            
        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (this.Booking != null)
            {
                this.bookingNameLabel.Text = this.Booking.Name;
            }
        }
            
        internal void LoadBookingInfo(Booking booking, BindingList<Room> rooms)
        {
            this.manageStatusLabel.ForeColor = Utils.MainThemeColor;
            this.roomIdLabel.ForeColor = Utils.MainThemeColor;
            this.Booking = booking;
            this.bookingInfoLabel.Text = "  BOOKING #" + booking.Id;
            
            Room room = Utils.GetRoomById(booking.RoomId, rooms);
            this.Room = room;
            this.roomImageBox.BackgroundImage = Utils.GetRoomImageByRoomType(room.Type);
            this.roomImageBox.BackgroundImageLayout = ImageLayout.Zoom;
            this.roomImageBox.PanelElement.PanelBorder.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            this.bookingNameLabel.Text = booking.Name;
            this.bookingRoomTypeIcon.Image = Utils.GetImageByRoomType(room.Type);
            this.bookingStatusDropDown.SelectedValue = this.Booking.Status;
            this.roomIdLabel.Text = " Room " + room.Id;
            this.bookingPriceLabel.Text = "<html><size=15>$" + booking.Price + "<size=10.5> Payment";
            
            this.bookingDatesGrid.EnableGrouping = false;
            this.bookingDatesGrid.AllowAddNewRow = false;
            this.bookingDatesGrid.ReadOnly = true;
            this.bookingDatesGrid.TableElement.RowHeaderColumnWidth = 0;
            this.bookingDatesGrid.TableElement.TableHeaderHeight = 30;
            this.bookingDatesGrid.TableElement.RowHeight = 40;
            this.bookingDatesGrid.TableElement.VScrollBar.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            this.bookingDatesGrid.TableElement.VScrollBar.PropertyChanged += VScrollBar_PropertyChanged;
            if (this.bookingDatesGrid.Columns.Count == 0)
            {
                this.bookingDatesGrid.Columns.Add("Occupied");
                this.bookingDatesGrid.Columns.Add("Days");
                    
                foreach (GridViewDataColumn c in this.bookingDatesGrid.Columns)
                {
                    c.HeaderImage = HotelApp.Properties.Resources.GlyphCalendar_small;
                    c.TextImageRelation = TextImageRelation.ImageBeforeText;
                }
                this.bookingDatesGrid.Columns["Occupied"].TextAlignment = ContentAlignment.MiddleLeft;
                this.bookingDatesGrid.Columns["Days"].TextAlignment = ContentAlignment.MiddleRight;
                this.bookingDatesGrid.Columns["Occupied"].MaxWidth = 180;
                this.bookingDatesGrid.Columns["Occupied"].Width = 180;
            }
            this.bookingDatesGrid.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.bookingDatesGrid.Rows.Clear();
            this.bookingDatesGrid.Rows.Add("From: " + booking.From.ToString("dd.MM.yyyy") + " " +
                                           booking.From.DayOfWeek.ToString().Substring(0, 3), (booking.To - booking.From).Days);
            this.bookingDatesGrid.Rows.Add("To: " + booking.To.ToString("dd.MM.yyyy") + " " + booking.To.DayOfWeek.ToString().Substring(0, 3));
            while (this.bookingDatesGrid.SelectedRows.Count > 0)
            {
                this.bookingDatesGrid.SelectedRows.First().IsSelected = false;
            }
                
            HotelAppForm f = this.FindForm() as HotelAppForm;
            if (f != null && f.PageView.SelectedPage == f.PageView.Pages[2])
            {
                this.manageStatusLabel.Visible = false;
            }
            else
            {
                this.manageStatusLabel.Visible = true;
            }
        }
            
        private void VScrollBar_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Visibility" && this.bookingDatesGrid.TableElement.VScrollBar.Visibility != Telerik.WinControls.ElementVisibility.Collapsed)
            {
                this.bookingDatesGrid.TableElement.VScrollBar.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            }
        }
            
        private void manageStatusLabel_Click(object sender, EventArgs e)
        {
            HotelAppForm f = this.FindForm() as HotelAppForm;
            if (f != null && f.PageView.SelectedPage == f.PageView.Pages[1])
            {
                f.PageView.SelectedPage = f.PageView.Pages[2];
            }
        }

        #endregion
    }
}