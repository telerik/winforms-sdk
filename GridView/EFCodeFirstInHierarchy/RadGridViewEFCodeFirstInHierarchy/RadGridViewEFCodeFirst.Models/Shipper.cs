using System;
using System.Linq;

namespace RadGridViewEFCodeFirst.Models
{
    public class Shipper
    {
        public int ShipperId { get; set; }

        public int OrderTypeId { get; set; }

        public virtual OrderType OrderType { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }
    }
}
