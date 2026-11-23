using System;

namespace Orders
{
    public class OrderItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        
        public decimal TotalPrice
        {
            get { return Product.Price * Quantity; }
        }

        public override string ToString()
        {
            return string.Format("{0} - Qty: {1} - ${2:F2}", Product.Name, Quantity, TotalPrice);
        }
    }
}
