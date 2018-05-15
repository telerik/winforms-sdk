using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1165384
{
    class OrderItem : INotifyPropertyChanged
    {
        private string name;
        private string quantityPerUnit;
        private decimal price;
        private int amount;

        public string Name
        {
            get { return name; }
            set
            {
                name = value; OnPropertyChanged("Name");
            }
        }

        public string QuantityPerUnit
        {
            get { return quantityPerUnit; }
            set
            {
                quantityPerUnit = value; OnPropertyChanged("QuantityPerUnit");
            }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; OnPropertyChanged("Price"); }
        }

        public int Amount
        {
            get { return amount; }
            set { amount = value; OnPropertyChanged("Amount"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
