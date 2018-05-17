using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerSidePaging
{
    #region MockRepository
    public class VirtualGridRepository
    {
        private Random rand = new Random();

        private IQueryable<OrderDataModel> orders;

        private string[] columnNames = new string[]
        {
            "OrderId",
            "OrderDetails",
            "ProductId",
            "ClientId",
            "ShipAddress",
            "ShippingType"
        };

        public IQueryable<OrderDataModel> Orders
        {
            get
            {
                if (this.orders == null)
                {
                    GenerateData();
                }

                return this.orders;
            }
        }

        public string[] ColumnNames
        {
            get
            {
                return this.columnNames;
            }
        }

        private IQueryable<OrderDataModel> GenerateData()
        {
            IList<OrderDataModel> data = new List<OrderDataModel>();

            for (int i = 0; i < 1000; i++)
            {
                data.Add(
                    new OrderDataModel
                    {
                        OrderId = i,
                        OrderDetails = "Order " + i,
                        ProductId = this.rand.Next(1000),
                        ClientId = this.rand.Next(1000),
                        ShipAddress = "Address " + i,
                        ShippingType = (ShippingType)rand.Next(3)
                    });
            }

            this.orders = data.AsQueryable();

            return orders;
        }
    }

    #endregion
}
