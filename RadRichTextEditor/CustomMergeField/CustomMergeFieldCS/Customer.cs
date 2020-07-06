using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomMergeField
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public bool HasOrders { get; set; }
        public List<Order> Orders { get; set; }
    }
}
