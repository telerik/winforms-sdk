using System;

namespace Orders
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Category { get; set; }

        public Product()
        {
            Name = string.Empty;
            Category = string.Empty;
        }
    }
}
