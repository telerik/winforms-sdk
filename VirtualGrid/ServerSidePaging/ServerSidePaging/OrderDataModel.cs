using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerSidePaging
{
    #region DataModel
    public class OrderDataModel
    {
        public int OrderId { get; set; }

        public string OrderDetails { get; set; }

        public int ProductId { get; set; }

        public int ClientId { get; set; }

        public string ShipAddress { get; set; }

        public ShippingType ShippingType { get; set; }

        public object this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0:
                        return OrderId;
                    case 1:
                        return OrderDetails;
                    case 2:
                        return ProductId;
                    case 3:
                        return ClientId;
                    case 4:
                        return ShipAddress;
                    case 5:
                        return ShippingType;
                    default:
                        return string.Empty;
                }
            }
        }
    }

    public enum ShippingType
    {
        None,
        Plane,
        Truck
    }

    #endregion
}
