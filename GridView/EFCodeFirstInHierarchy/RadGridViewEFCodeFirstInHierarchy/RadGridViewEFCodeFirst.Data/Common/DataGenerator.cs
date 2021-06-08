using RadGridViewEFCodeFirst.Data.Contracts;
using RadGridViewEFCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadGridViewEFCodeFirst.Data.Common
{
    public class DataGenerator
    {
        public static void PopulateData(IRadGridViewEFCodeFirstData data) 
        {
            for (int i = 1; i <= 100; i++)
            {
                OrderType orderType = new OrderType()
                {
                    OrderTypeId = i,
                    Description = "Test" + i
                };

                Order order = new Order()
                {
                    OrderId = i,
                    Description = "Description" + i,
                    OrderTypeId = orderType.OrderTypeId
                };

                Shipper shipper = new Shipper()
                {
                    ShipperId = i,
                    Name = "Name " + i,
                    OrderTypeId = orderType.OrderTypeId,
                    Address = "Address " + i,
                };

                data.OrderTypes.Add(orderType);
                data.Orders.Add(order);
                data.Shippers.Add(shipper);

                if (i % 100 == 0)
                {
                    data.SaveChanges();
                }
            }

            data.SaveChanges();
        }
    }
}
