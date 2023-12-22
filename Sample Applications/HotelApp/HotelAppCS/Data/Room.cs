using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Telerik.WinControls.UI;

namespace HotelApp
{
    public class Room : System.ComponentModel.INotifyPropertyChanged
    {
        public Room()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private int id;
        private RoomStatus status;
        private RoomType type;
        private HouseKeepingStatus houseKeepingStatus;
        private int? houseKeeperId;
        private bool needsRepairs;
        private decimal pricePerDay;
        private RoomPriority priority;
        private DateTime houseKeepingStart;
        private DateTime houseKeepingEnd;
        private bool visible;

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
                OnPropertyChanged("Id");
            }
        }

        public string Name
        {
            get
            {
                return this.Id.ToString();
            }
        }

        public RoomStatus Status
        {
            get
            {
                return this.status;
            }
            set
            {
                this.status = value;
                OnPropertyChanged("Status");
            }
        }

        public RoomType Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
                OnPropertyChanged("Type");
            }
        }

        public HouseKeepingStatus HouseKeepingStatus
        {
            get
            {
                return this.houseKeepingStatus;
            }
            set
            {
                this.houseKeepingStatus = value;
                OnPropertyChanged("HouseKeepingStatus");
            }
        }

        public int? HouseKeeperId
        {
            get
            {
                return this.houseKeeperId;
            }
            set
            {
                this.houseKeeperId = value;
                OnPropertyChanged("HouseKeeperId");
            }
        }

        public bool NeedsRepairs
        {
            get
            {
                return this.needsRepairs;
            }
            set
            {
                this.needsRepairs = value;
                OnPropertyChanged("NeedsRepairs");
            }
        }

        public decimal PricePerDay
        {
            get
            {
                return this.pricePerDay;
            }
            set
            {
                this.pricePerDay = value;
                OnPropertyChanged("PricePerDay");
            }
        }

        public RoomPriority Priority
        {
            get
            {
                return this.priority;
            }
            set
            {
                this.priority = value;
                OnPropertyChanged("Priority");
            }
        }

        public DateTime HouseKeepingStart
        {
            get
            {
                return this.houseKeepingStart;
            }
            set
            {
                this.houseKeepingStart = value;
                OnPropertyChanged("HouseKeepingStart");
            }
        }

        public DateTime HouseKeepingEnd
        {
            get
            {
                return this.houseKeepingEnd;
            }
            set
            {
                this.houseKeepingEnd = value;
                OnPropertyChanged("HouseKeepingEnd");
            }
        }

        public bool Visible
        {
            get
            {
                return this.visible;
            }
            set
            {
                this.visible = value;
                OnPropertyChanged("Visible");
            }
        }

        public Room(int id, RoomStatus status, RoomType type, HouseKeepingStatus houseKeepingStatus, bool needsRepairs, decimal price)
        {
            this.id = id;
            this.status = status;
            this.type = type;
            this.houseKeepingStatus = houseKeepingStatus;
            this.needsRepairs = needsRepairs;
            this.priority = RoomPriority.Low;
            this.pricePerDay = price;
            this.houseKeeperId = null;
            this.houseKeepingStart = DateTime.Now;
            this.houseKeepingEnd = DateTime.Now;
            this.visible = true;
        }

        public RoomStatus GetStatusAtDate(DateTime date, BindingList<Booking> bookings)//, bool IsToday)
        {
            RoomStatus status = RoomStatus.Available;

            foreach (Booking booking in bookings)
            {
                if (booking.RoomId == this.Id)
                {
                    if (booking.From <= date && booking.To == date)
                    {
                        status = RoomStatus.CheckedOut;
                        break;
                    }
                    else if (booking.From <= date && booking.To >= date)
                    {
                        status = RoomStatus.Occupied;
                        break;
                    }
                    else
                    {
                        if (date < booking.From)
                        {
                            status = RoomStatus.Reserved;
                        }
                    }
                }
            }
            return status;
        }
        
        public RoomStatus GetStatusByBooking(DateTime date, BindingList<Booking> bookings)
        {
            foreach (Booking booking in bookings)
            {
                if (booking.RoomId == this.Id)
                {
                    if (date >= booking.From && date <= booking.To)
                    {
                        if (booking.Status == BookingStatus.Actual)
                        {
                            return RoomStatus.Occupied;
                        }
                        else if (booking.Status == BookingStatus.NoShow)
                        {
                            return RoomStatus.Available;
                        }
                        else if (booking.Status == BookingStatus.CheckedOut)
                        {
                            return RoomStatus.CheckedOut;
                        }
                        else if (booking.Status == BookingStatus.Reservation)
                        {
                            return RoomStatus.Reserved;
                        }
                    }
                }
            }
            return RoomStatus.Available ;
        }
    }

    public enum RoomPriority
    {
        Low = 1,
        Medium = 2,
        High = 3
    }

    public enum RoomStatus
    {
        Reserved,
        Occupied,
        Available,
        CheckedOut
    }

    public enum RoomType
    {
        Single,
        Double,
        Triple,
        Family
    }

    public enum HouseKeepingStatus
    {
        Clean = 1,
        NotClean = 2,
        InProgress = 3,
    }
}