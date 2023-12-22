using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HotelApp
{
    public class Guest : System.ComponentModel.INotifyPropertyChanged
    {
        public string Id
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

        public string Address
        {
            get
            {
                return this._address;
            }
            set
            {
                this._address = value;
                OnPropertyChanged("Address");
            }
        }

        public string City
        {
            get
            {
                return this._city;
            }
            set
            {
                this._city = value;
                OnPropertyChanged("City");
            }
        }

        public string Phone
        {
            get
            {
                return this._phone;
            }
            set
            {
                this._phone = value;
                OnPropertyChanged("Phone");
            }
        }

        public CreditCard CardDetails
        {
            get
            {
                return this._cardDetails;
            }
            set
            {
                this._cardDetails = value;
                OnPropertyChanged("CardDetails");
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

        private string _id;
        private string _name;
        private string _address;
        private string _city;
        private string _phone;
        private CreditCard _cardDetails;

        public Guest()
        {
           this._cardDetails = new CreditCard();
        }

        public Guest(string id, string name, string address, string city, string phone, CreditCard cardDetails)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.City = city;
            this.Phone = phone;
            this.CardDetails = cardDetails;
        }
    }

    public class CreditCard
    {
        public string CreditCardId { get; set; }

        public DateTime ExpiresOn { get; set; }

        public uint CCV { get; set; }

        public CreditCard()
        {
        }

        public CreditCard(string creditCardId, DateTime expiresOn, uint ccv)
        {
            this.CreditCardId = creditCardId;
            this.ExpiresOn = expiresOn;
            this.CCV = ccv;
        }
    }
}