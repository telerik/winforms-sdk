using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RadControlsApp
{
    class Customer
    {
        private int id;
        private string name;
        private string address;

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public Customer(int id, string name, string address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }
    }
}
