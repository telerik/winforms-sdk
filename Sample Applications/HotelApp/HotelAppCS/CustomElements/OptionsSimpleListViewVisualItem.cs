using HotelApp.Data;
using System;
using System.Drawing;
using Telerik.WinControls.UI;

namespace HotelApp
{
    public class OptionsSimpleListViewVisualItem : SimpleListViewVisualItem
    {
        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(SimpleListViewVisualItem);
            }
        }

        private StackLayoutElement layout = new StackLayoutElement();
        private LightVisualElement countElement = new LightVisualElement();
        private LightVisualElement countImage = new LightVisualElement();

        protected override void CreateChildElements()
        {
            base.CreateChildElements();

            this.layout.ShouldHandleMouseInput = false;
            this.countImage.ShouldHandleMouseInput = false;
            this.countElement.NotifyParentOnMouseInput = true;
            this.countElement.ShouldHandleMouseInput = false;
            this.countElement.StretchHorizontally = false;
            this.countElement.Alignment = System.Drawing.ContentAlignment.MiddleRight;
            this.countElement.MinSize = countElement.MaxSize = new System.Drawing.Size(30, 0);
            this.countImage.ImageLayout = System.Windows.Forms.ImageLayout.None;
            this.countImage.ImageAlignment = ContentAlignment.MiddleRight;
            this.countImage.StretchHorizontally = true;

            this.layout.Children.Add(countImage);
            this.layout.Children.Add(countElement);
            this.layout.StretchHorizontally = true;
            this.Children.Add(layout);
        }

        protected override void SynchronizeProperties()
        {
            base.SynchronizeProperties();

            this.DrawText = false;
            this.ToggleElement.Text = this.Text;

            this.ToggleElement.CustomFont = Utils.MainFont;
            this.ToggleElement.CustomFontSize = 10.5f;
            this.ToggleElement.TextElement.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);

            this.countElement.CustomFont = Utils.MainFont;
            this.countElement.CustomFontSize = 10.5f;
            this.countElement.CustomFontStyle = FontStyle.Regular;

            if (this.Data.Group.Text == "STAFF - SERVICE")
            {
                this.countImage.Image = null;
                this.countElement.Text = GetRoomsByHouseKeeper(this.dataItem.Text);
            }
            else if (this.Text == "Not assigned rooms")
            {
                this.countImage.Image = null;
                this.countElement.Text = GetNotAssignedRooms();
            }
            else
            {
                if (this.Text == Enum.GetName(typeof(BookingStatus), BookingStatus.Actual))
                {
                    this.countImage.Image = null;
                    this.countElement.Text = GetBookingByStatus(BookingStatus.Actual);
                }
                else if (this.Text == Enum.GetName(typeof(BookingStatus), BookingStatus.Cancelled))
                {
                    this.countImage.Image = null;
                    this.countElement.Text = GetBookingByStatus(BookingStatus.Cancelled);
                }
                else if (this.Text == Enum.GetName(typeof(BookingStatus), BookingStatus.CheckedOut) && this.Data.ListView.Name.Contains("Booking"))
                {
                    this.countImage.Image = null;
                    this.countElement.Text = GetBookingByStatus(BookingStatus.CheckedOut);
                }
                else if (this.Text == Enum.GetName(typeof(BookingStatus), BookingStatus.NoShow))
                {
                    this.countImage.Image = null;
                    this.countElement.Text = GetBookingByStatus(BookingStatus.NoShow);
                }
                else if (this.Text == Enum.GetName(typeof(BookingStatus), BookingStatus.Reservation))
                {
                    this.countImage.Image = null;
                    this.countElement.Text = GetBookingByStatus(BookingStatus.Reservation);
                }
                else if (this.Text == Enum.GetName(typeof(HouseKeepingStatus), HouseKeepingStatus.Clean))
                {
                    this.countImage.Image = Utils.GetRoomIconByHouseKeepingStatus(HouseKeepingStatus.Clean);
                    this.countElement.Text = GetRoomsByHouseKeepingStatus(HouseKeepingStatus.Clean);
                }
                else if (this.Text == Enum.GetName(typeof(HouseKeepingStatus), HouseKeepingStatus.NotClean))
                {
                    this.countImage.Image = Utils.GetRoomIconByHouseKeepingStatus(HouseKeepingStatus.NotClean);
                    this.countElement.Text = GetRoomsByHouseKeepingStatus(HouseKeepingStatus.NotClean);
                }
                else if (this.Text == Enum.GetName(typeof(HouseKeepingStatus), HouseKeepingStatus.InProgress))
                {
                    this.countImage.Image = Utils.GetRoomIconByHouseKeepingStatus(HouseKeepingStatus.InProgress);
                    this.countElement.Text = GetRoomsByHouseKeepingStatus(HouseKeepingStatus.InProgress);
                }
                else if (this.Text == "Repair")
                {
                    this.countImage.Image = Properties.Resources.repair_small;
                    this.countElement.Text = GetRoomsToRepair(true);
                }
                else if (this.Text == Enum.GetName(typeof(RoomStatus), RoomStatus.Available))
                {
                    this.countImage.Image = null;
                    this.countElement.Text = GetRoomsByStatus(RoomStatus.Available);
                }
                else if (this.Text == Enum.GetName(typeof(RoomStatus), RoomStatus.Occupied))
                {
                    this.countImage.Image = null;
                    this.countElement.Text = GetRoomsByStatus(RoomStatus.Occupied);
                }
                else if (this.Text == Enum.GetName(typeof(RoomStatus), RoomStatus.Reserved))
                {
                    this.countImage.Image = null;
                    this.countElement.Text = GetRoomsByStatus(RoomStatus.Reserved);
                }
                else if (this.Text == Enum.GetName(typeof(RoomStatus), RoomStatus.CheckedOut))
                {
                    this.countImage.Image = null;
                    this.countElement.Text = GetRoomsByStatus(RoomStatus.CheckedOut);
                }
                else if ((RoomType)this.Data.Value == RoomType.Single)
                {
                    this.countImage.Image = Utils.GetRoomIconByType(RoomType.Single);
                    this.countElement.Text = GetRoomsByType(RoomType.Single);
                }
                else if ((RoomType)this.Data.Value == RoomType.Double)
                {
                   this.countImage.Image = Utils.GetRoomIconByType(RoomType.Double);
                   this.countElement.Text = GetRoomsByType(RoomType.Double);
                }
                else if ((RoomType)this.Data.Value == RoomType.Triple)
                {
                    this.countImage.Image = Utils.GetRoomIconByType(RoomType.Triple);
                    this.countElement.Text = GetRoomsByType(RoomType.Triple);
                }
                else if ((RoomType)this.Data.Value == RoomType.Family)
                {
                    this.countImage.Image = Utils.GetRoomIconByType(RoomType.Family);
                    this.countElement.Text = GetRoomsByType(RoomType.Family);
                }
            }
        }

        private string GetRoomsByHouseKeeper(string name)
        {
            int count = 0;
            HotelAppForm form = this.ElementTree.Control.FindForm() as HotelAppForm;
            if (form != null)
            {
                foreach (Room r in form.Rooms)
                {
                    if (r.HouseKeeperId == Utils.GetHouseKeeperIdByName(name, form.HouseKeepers))
                    {
                        count++;
                    }
                }
            }
            return count.ToString();
        }

        private string GetNotAssignedRooms()
        {
            int count = 0;
            HotelAppForm form = this.ElementTree.Control.FindForm() as HotelAppForm;
            if (form != null)
            {
                foreach (Room r in form.Rooms)
                {
                    if (r.HouseKeeperId == null && r.HouseKeepingStatus != HouseKeepingStatus.Clean)
                    {
                        count++;
                    }
                }
            }
            return count.ToString();
        }

        private string GetBookingByStatus(BookingStatus bookingStatus)
        {
            int count = 0;
            HotelAppForm form = this.ElementTree.Control.FindForm() as HotelAppForm;
            if (form != null)
            {
                foreach (Booking booking in form.Bookings)
                {
                    if (booking.GetBookingStatusAtDate(form.BookingsDate, booking) == bookingStatus &&
                        booking.From <= form.BookingsDate && booking.To >= form.BookingsDate)
                    {
                        count++;
                    }
                }
            }
            return count.ToString();
        }

        private string GetRoomsByType(RoomType roomType)
        {
            int count = 0;
            HotelAppForm form = this.ElementTree.Control.FindForm() as HotelAppForm;
            if (form != null)
            {
                foreach (Room room in form.Rooms)
                {
                    if (room.Type == roomType && form.GetItemByRoomId(room.Id).Visible)
                    {
                        count++;
                    }
                }
            }
            return count.ToString();
        }

        private string GetRoomsByStatus(RoomStatus roomStatus)
        {
            int count = 0;
            HotelAppForm form = this.ElementTree.Control.FindForm() as HotelAppForm;
            if (form != null)
            {
                foreach (Room room in form.Rooms)
                {
                    if (room.GetStatusByBooking(form.OverviewDate, form.Bookings) == roomStatus && form.GetItemByRoomId(room.Id).Visible)
                    //if (room.GetStatusAtDate(form.OverviewDate, form.Bookings) == roomStatus && form.GetItemByRoomId(room.Id).Visible)
                    {
                        count++;
                    }
                }
            }
            return count.ToString();
        }

        private string GetRoomsToRepair(bool repair)
        {
            int count = 0;
            HotelAppForm form = this.ElementTree.Control.FindForm() as HotelAppForm;
            if (form != null)
            {
                foreach (Room room in form.Rooms)
                {
                    if (room.NeedsRepairs == repair && form.GetItemByRoomId(room.Id).Visible)
                    {
                        count++;
                    }
                }
            }
            return count.ToString();
        }

        private string GetRoomsByHouseKeepingStatus(HouseKeepingStatus houseKeepingStatus)
        {
            int count = 0;
            HotelAppForm form = this.ElementTree.Control.FindForm() as HotelAppForm;
            if (form != null)
            {
                foreach (Room room in form.Rooms)
                {
                    if (room.HouseKeepingStatus == houseKeepingStatus && form.GetItemByRoomId(room.Id).Visible)
                    {
                        count++;
                    }
                }
            }
            return count.ToString();
        }
    }
}