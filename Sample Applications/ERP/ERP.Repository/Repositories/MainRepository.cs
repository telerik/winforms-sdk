using ERP.Repository.Service;
using System;
using System.Data.Services.Client;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.Repository
{
    public partial class MainRepository : RepositoryBase
    {
        public static DataServiceQuery<Customer> GetIndividualCustomers()
        {
            var customersQuery =
                ((DataServiceQuery<Customer>)Context.Customers.Where(c => c.PersonID != null && c.StoreID == null))
                .Expand("Person/BusinessEntity/BusinessEntityAddresses/Address")
                .Expand("SalesOrderHeaders/Customer")
                .Expand("SalesOrderHeaders/ShipMethod")
                .Expand(c => c.Person.EmailAddresses)
                .Expand(c => c.Person.PersonPhones)
                .Expand(c => c.SalesOrderHeaders);
            return customersQuery;
        }

        public static DataServiceQuery<Customer> GetStoreCustomers()
        {
            var stores =
                ((DataServiceQuery<Customer>)Context.Customers.Where(c => c.StoreID != null && c.PersonID == null))
                .Expand("Store/BusinessEntity/BusinessEntityContacts/Person/EmailAddresses")
                .Expand("Store/BusinessEntity/BusinessEntityContacts/Person/PersonPhones")
                .Expand("Store/BusinessEntity/BusinessEntityAddresses/Address/StateProvince/CountryRegion")
                .Expand("SalesOrderHeaders/Customer");
            return stores;
        }

        public static DataServiceQuery<SalesOrderHeader> GetSalesOrders()
        {
            var salesOrders =
                Context.SalesOrderHeaders
                .Expand("Customer/Person/BusinessEntity/BusinessEntityAddresses/Address/StateProvince/CountryRegion")
                .Expand(c => c.Customer.Person.EmailAddresses)
                .Expand(c => c.Customer.Person.PersonPhones)
                .Expand(s => s.ShipMethod)
                .Expand(s => s.Address.StateProvince)
                .Expand(s => s.SalesOrderDetails)
                .Where(s => s.Customer.Person.BusinessEntity.BusinessEntityAddresses.Any()) as DataServiceQuery<SalesOrderHeader>;

            return salesOrders;
        }

        public static DataServiceQuery<BillOfMaterial> GetBills()
        {
            var materials =
                Context.BillOfMaterials
                .Expand(b => b.Product)
                .Expand(b => b.Product1)
                .Expand(b => b.UnitMeasure);

            return materials;
        }

        public static DataServiceQuery<PurchaseOrderHeader> GetPurchaseOrders()
        {
            var purchaseOrders =
                Context.PurchaseOrderHeaders
                .Expand(o => o.Vendor)
                .Expand(o => o.ShipMethod)
                .Expand("PurchaseOrderDetails/Product");

            return purchaseOrders;
        }

        public static void GetOrders(Action<DataServiceQuery<SalesOrderHeader>> callback)
        {
            ExecuteQueryAsync<DataServiceQuery<SalesOrderHeader>>(GetOrdersAsync(), callback);
        }

        public static void GetCustomers(bool isIndividual, Action<DataServiceQuery<Customer>> callback)
        {
            ExecuteQueryAsync<DataServiceQuery<Customer>>(GetCustomersAsync(isIndividual), callback);
        }

        public static void GetBillOfMaterials(Action<DataServiceQuery<BillOfMaterial>> callback)
        {
            ExecuteQueryAsync<DataServiceQuery<BillOfMaterial>>(GetBillOfMaterialsAsync(), callback);
        }

        public static void GetWorkOrders(Action<DataServiceQuery<WorkOrder>> action)
        {
            ExecuteQueryAsync<DataServiceQuery<WorkOrder>>(GetWorkOrdersAsync(), action);
        }

        public static void GetProductInventories(Action<DataServiceQuery<ProductInventory>> action)
        {
            ExecuteQueryAsync<DataServiceQuery<ProductInventory>>(GetProductInventoriesAsync(), action);
        }

        public static void GetVendors(Action<DataServiceQuery<Vendor>> action)
        {
            ExecuteQueryAsync<DataServiceQuery<Vendor>>(GetVendorsAsync(), action);
        }

        public static void GetPurchaseOrders(Action<DataServiceQuery<PurchaseOrderHeader>> action)
        {
            ExecuteQueryAsync<DataServiceQuery<PurchaseOrderHeader>>(GetPurchaseOrdersAsync(), action);
        }

        private static async Task<DataServiceQuery<SalesOrderHeader>> GetOrdersAsync()
        {
            return await Task.Run(() => GetSalesOrders());
        }

        private static async Task<DataServiceQuery<Customer>> GetCustomersAsync(bool isIndividual)
        {
            return await Task.Run(() => isIndividual ? GetIndividualCustomers() : GetStoreCustomers());
        }

        private static async Task<DataServiceQuery<BillOfMaterial>> GetBillOfMaterialsAsync()
        {
            return await Task.Run(() => GetBills());
        }

        private static async Task<DataServiceQuery<ProductInventory>> GetProductInventoriesAsync()
        {
            return await Task.Run(() =>
                Context.ProductInventories
                .Expand(p => p.Product)
                .Expand(p => p.Location));
        }

        private static async Task<DataServiceQuery<WorkOrder>> GetWorkOrdersAsync()
        {
            return await Task.Run(() => Context.WorkOrders.Expand(w => w.Product));
        }

        private static async Task<DataServiceQuery<Vendor>> GetVendorsAsync()
        {
            return await Task.Run(() => Context.Vendors);
        }

        private static async Task<DataServiceQuery<PurchaseOrderHeader>> GetPurchaseOrdersAsync()
        {
            return await Task.Run(() => GetPurchaseOrders());
        }

        public static Product GetProduct(int id)
        {
            return ProductsCache.FirstOrDefault(p => p.ProductID == id);
        }
    }
}
