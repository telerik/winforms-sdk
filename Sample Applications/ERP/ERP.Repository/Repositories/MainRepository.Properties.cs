using ERP.Repository.Service;
using System.Collections.Generic;
using System.Data.Services.Client;
using System.Linq;

namespace ERP.Repository
{
    public partial class MainRepository
    {
        private static List<Product> productsCache;
        private static List<StateProvince> statesCache;
        private static List<ShipMethod> shipMethodsCache;
        private static List<UnitMeasure> unitMeasuresCache;
        private static List<Vendor> vendorsCache;
        private static List<Location> locationsCache;
        private static List<ProductInventory> productInventoryCache;
        private static List<Customer> topCustomersCache;

        public static List<Product> ProductsCache
        {
            get
            {
                if (productsCache == null)
                {
                    productsCache = Context.Products.ToList();
                }

                return productsCache;
            }
            private set
            {
                if (productsCache != value)
                {
                    productsCache = value;
                }
            }
        }

        public static List<StateProvince> StatesCache
        {
            get
            {
                if (statesCache == null)
                {
                    statesCache = Context.StateProvinces.Expand(state => state.CountryRegion).ToList();
                }

                return statesCache;
            }
            private set
            {
                if (statesCache != value)
                {
                    statesCache = value;
                }
            }
        }

        public static List<ShipMethod> ShipMethodsCache
        {
            get
            {
                if (shipMethodsCache == null)
                {
                    shipMethodsCache = Context.ShipMethods.ToList();
                }

                return shipMethodsCache;
            }
            private set
            {
                if (shipMethodsCache != value)
                {
                    shipMethodsCache = value;
                }
            }
        }

        public static List<UnitMeasure> UnitMeasuresCache
        {
            get
            {
                if (unitMeasuresCache == null)
                {
                    unitMeasuresCache = Context.UnitMeasures.ToList();
                }

                return unitMeasuresCache;
            }
            private set
            {
                if (unitMeasuresCache != value)
                {
                    unitMeasuresCache = value;
                }
            }
        }

        public static List<Vendor> VendorsCache
        {
            get
            {
                if (vendorsCache == null)
                {
                    vendorsCache = Context.Vendors.ToList();
                }

                return vendorsCache;
            }
            private set
            {
                if (vendorsCache != value)
                {
                    vendorsCache = value;
                }
            }
        }

        public static List<Location> LocationsCache
        {
            get
            {
                if (locationsCache == null)
                {
                    locationsCache = Context.Locations.ToList();
                }

                return locationsCache;
            }
            private set
            {
                if (locationsCache != value)
                {
                    locationsCache = value;
                }
            }
        }

        public static List<ProductInventory> ProductInventoryCache
        {
            get
            {
                if (productInventoryCache == null)
                {
                    productInventoryCache = Context.ProductInventories.Expand(p => p.Product).Expand(p => p.Location).ToList();
                }

                return productInventoryCache;
            }
            private set
            {
                if (productInventoryCache != value)
                {
                    productInventoryCache = value;
                }
            }
        }

        public static List<Customer> TopCustomersCache
        {
            get 
            {
                if (topCustomersCache == null)
                {
                    topCustomersCache = 
                        ((DataServiceQuery<Customer>)Context.Customers.Where(c => c.PersonID != null && c.StoreID == null))
                        .Expand("Person/BusinessEntity/BusinessEntityAddresses/Address")
                        .Expand(c => c.Person.EmailAddresses)
                        .Expand(c => c.Person.PersonPhones)
                        .Take(100)
                        .ToList();
                }

                return topCustomersCache; 
            }
            private set 
            {
                if (topCustomersCache != value)
                {
                    topCustomersCache = value; 
                }
            }
        }
    }
}
