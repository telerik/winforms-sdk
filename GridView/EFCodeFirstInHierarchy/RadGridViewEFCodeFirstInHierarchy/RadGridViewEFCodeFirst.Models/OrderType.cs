using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadGridViewEFCodeFirst.Models
{
    public class OrderType
    {
        private ICollection<Order> orders;
        private ICollection<Shipper> shippers;

        public OrderType()
        {
            this.orders = new HashSet<Order>();
            this.shippers = new HashSet<Shipper>();
        }

        public int OrderTypeId { get; set; }

        public virtual ICollection<Order> Orders
        {
            get
            {
                return this.orders;
            }
            set
            {
                this.orders = value;
            }
        }

        public virtual ICollection<Shipper> Shippers
        {
            get
            {
                return this.shippers;
            }
            set
            {
                this.shippers = value;
            }
        }

        public string  Description { get; set; }
    }
}
