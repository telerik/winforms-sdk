using HotelApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HotelApp
{
    public class Booking : System.ComponentModel.INotifyPropertyChanged
    {
        public Booking()
        {
            this.Guests = new List<Guest>();
        }

        public uint Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
                OnPropertyChanged("Id");
            }
        }

        public List<Guest> Guests
        {
            get
            {
                return this._guests;
            }
            set
            {
                this._guests = value;
                OnPropertyChanged("Guests");
            }
        }

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
                OnPropertyChanged("Name");
            }
        }

        public int RoomId
        {
            get
            {
                return this._roomId;
            }
            set
            {
                this._roomId = value;
                OnPropertyChanged("RoomId");
            }
        }

        public DateTime From
        {
            get
            {
                return this._from;
            }
            set
            {
                this._from = value;
                OnPropertyChanged("From");
            }
        }

        public DateTime To
        {
            get
            {
                return this._to;
            }
            set
            {
                this._to = value;
                OnPropertyChanged("To");
            }
        }

        public decimal Price
        {
            get
            {
                return this._pricePerDay * (decimal)this.To.Subtract(this.From).TotalDays;
            }
            set
            {
                this._price = value;
                OnPropertyChanged("Price");
            }
        }
        
        public decimal PricePerDay
        {
            get
            {
                return this._pricePerDay;
            }
            set
            {
                this._pricePerDay = value;
                OnPropertyChanged("PricePerDay");
            }
        }

        public BookingStatus Status
        {
            get
            {
                return this._status;
            }
            set
            {
                this._status = value;
                OnPropertyChanged("Status");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private uint _id;
        private List<Guest> _guests;
        private string _name;
        private int _roomId;
        private DateTime _from;
        private DateTime _to;
        private decimal _price;
        private decimal _pricePerDay;
        private BookingStatus _status; 

        public string FullInfo
        {
            get
            {
                return "Room#" + this.RoomId + " " + this.Name + " " + this.From.ToShortDateString() + "-" + this.To.ToShortDateString();
            }
        }
        
        public Booking(uint id, Guest guest, int roomId, DateTime from, DateTime to, decimal pricePerDay, BookingStatus status)
        {
            this.Id = id;
            this.Guests = new List<Guest>() { guest };
            this.Name = guest.Name;
            this.RoomId = roomId;
            this.From = from;
            this.To = to;
            this.PricePerDay = pricePerDay;
            this.Status = status;
        }

        public BookingStatus GetBookingStatusAtDate(DateTime date, Booking booking)
        {
            BookingStatus status = BookingStatus.Reservation;
            
            if (booking.Status == BookingStatus.Cancelled || booking.Status == BookingStatus.NoShow)
            {
                return booking.Status;
            }
                
            if (booking.From <= date && booking.To == date && this.Status != BookingStatus.Actual)
            {
                status = BookingStatus.CheckedOut; 
            }
            else if (booking.From <= date && booking.To >= date && this.Status != BookingStatus.Reservation)
            {
                status = BookingStatus.Actual; 
            }
            else
            {
                if (date < booking.From)
                {
                    status = BookingStatus.Reservation;
                }
            }
         
            return status;
        }
    }

    public enum BookingStatus
    { 
        Reservation = 1,
        Actual = 2,
        Cancelled = 3,
        CheckedOut = 4,
        NoShow = 5
    }
}