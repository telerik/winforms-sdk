using ERP.Repository.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ERP.Repository
{
    public static class MainRepository
    {
        public static List<Product> ProductsCache { get; set; }
        public static List<StateProvince> StatesCache { get; set; }
        public static List<ShipMethod> ShipMethodsCache { get; set; }
        public static List<UnitMeasure> UnitMeasuresCache { get; set; }
        public static List<Vendor> VendorsCache { get; set; }
        public static List<Location> LocationsCache { get; set; }
        public static List<ProductInventory> ProductInventoryCache { get; set; }
        public static List<Customer> CustomersCache { get; set; }
        public static List<BillOfMaterial> BillsCache { get; set; }
        public static List<Customer> IndividualCustomersCache { get; set; }
        public static List<SalesOrderHeader> OrdersCache { get; set; }
        public static List<PurchaseOrderHeader> PurchaseOrdersCache { get; set; }
        public static List<Customer> StoreCustomersCache { get; set; }
        public static List<WorkOrder> WorkOrdersCache { get; set; }
        public static List<Customer> TopCustomersCache { get; set; }

        public static void InitializeData()
        {
            // AppDomain.CurrentDomain.BaseDirectory returns the bin\Debug or bin\Release folder
            // We need to go up one level to get to ERP.Client, then into Data folder
            var baseDir = AppDomain.CurrentDomain.BaseDirectory;
            var dataDir = Path.Combine(baseDir,"..", "..", "ERP.Client\\Data");
            
            // Normalize the path to remove the ".." components
            var dir = Path.GetFullPath(dataDir);

            var products = LoadData<Product>($"{dir}\\Product.json");
            ProductsCache = (List<Product>)products;

            var bills = LoadData<BillOfMaterial>($"{dir}\\Bill.json");
            BillsCache = (List<BillOfMaterial>)bills;

            var customers = LoadData<Customer>($"{dir}\\Customer.json");
            CustomersCache = (List<Customer>)customers;

            var individualCustomers = LoadData<Customer>($"{dir}\\IndividualCustomer.json");
            IndividualCustomersCache = (List<Customer>)individualCustomers;

            var locations = LoadData<Location>($"{dir}\\Location.json");
            LocationsCache = (List<Location>)locations;

            var orders = LoadData<SalesOrderHeader>($"{dir}\\Order.json");
            OrdersCache = (List<SalesOrderHeader>)orders;

            var productInventories = LoadData<ProductInventory>($"{dir}\\ProductInventory.json");
            ProductInventoryCache = (List<ProductInventory>)productInventories;

            var purchaseOrders = LoadData<PurchaseOrderHeader>($"{dir}\\PurchaseOrder.json");
            PurchaseOrdersCache = (List<PurchaseOrderHeader>)purchaseOrders;

            var shipMethods = LoadData<ShipMethod>($"{dir}\\ShipMethod.json");
            ShipMethodsCache = (List<ShipMethod>)shipMethods;

            var states = LoadData<StateProvince>($"{dir}\\StateProvince.json");
            StatesCache = (List<StateProvince>)states;

            var storeCustomers = LoadData<Customer>($"{dir}\\StoreCustomer.json");
            StoreCustomersCache = (List<Customer>)storeCustomers;

            var unitMeasures = LoadData<UnitMeasure>($"{dir}\\UnitMeasure.json");
            UnitMeasuresCache = (List<UnitMeasure>)unitMeasures;

            var vendors = LoadData<Vendor>($"{dir}\\Vendor.json");
            VendorsCache = (List<Vendor>)vendors;

            var workOrders = LoadData<WorkOrder>($"{dir}\\WorkOrder.json");
            WorkOrdersCache = (List<WorkOrder>)workOrders;

            TopCustomersCache = CustomersCache.Where(c => c.PersonID != null && c.StoreID == null).Take(100).ToList();
        }

        private static IEnumerable<SalesOrderHeader> GetSalesOrders()
        {
            var salesOrders = OrdersCache
                .Where(s => s.Customer.Person.BusinessEntity.BusinessEntityAddresses.Any());

            return salesOrders;
        }

        private static IEnumerable<BillOfMaterial> GetBills()
        {
            var materials = BillsCache;

            return materials;
        }

        private static IEnumerable<PurchaseOrderHeader> GetPurchaseOrders()
        {
            var purchaseOrders = PurchaseOrdersCache;

            return purchaseOrders;
        }

        public static void GetOrders(Action<IEnumerable<SalesOrderHeader>> callback)
        {
            callback(GetSalesOrders());
        }

        public static void GetCustomers(bool isIndividual, Action<IEnumerable<Customer>> callback)
        {
            if (isIndividual)
            {
                callback(IndividualCustomersCache);
            }
            else
            {
                callback(StoreCustomersCache);
            }
        }

        public static void GetBillOfMaterials(Action<IEnumerable<BillOfMaterial>> callback)
        {
            callback(GetBills());
        }

        public static void GetWorkOrders(Action<IEnumerable<WorkOrder>> action)
        {
            action(WorkOrdersCache);
        }

        public static void GetProductInventories(Action<IEnumerable<ProductInventory>> action)
        {
            action(ProductInventoryCache);
        }

        public static void GetVendors(Action<IEnumerable<Vendor>> action)
        {
            action(VendorsCache);
        }

        public static void GetPurchaseOrders(Action<IEnumerable<PurchaseOrderHeader>> action)
        {
            action(PurchaseOrdersCache);
        }

        public static Product GetProduct(int id)
        {
            return ProductsCache.FirstOrDefault(p => p.ProductID == id);
        }

        private static object LoadData<T>(string fileName)
        {
            if (File.Exists(fileName))
            {
                var json = File.ReadAllText(fileName);
                var listType = typeof(List<>).MakeGenericType(typeof(T));
                var data = JsonConvert.DeserializeObject(json, listType);

                return data;
            }

            return null;
        }
    }
}
