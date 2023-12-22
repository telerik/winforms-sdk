using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Client
{
    static class FieldsHelper
    {
        public static List<string> AddressFields = new List<string>() { "AddressLine1", "AddressLine2", "City", "StateProvince", "PostalCode", "ModifiedDate" };
        public static List<string> PurchaseOrderHeaderFields = new List<string>() { "OrderStatus", "OrderDate", "ShipDate", "SubTotal", "TaxAmt", "Freight", "TotalDue", "ModifiedDate", "ShipMethod", "Vendor" };
        public static List<string> VendorFields = new List<string> { "AccountNumber", "Name", "CreditRating", "PreferredVendorStatus", "ActiveFlag", "PurchasingWebServiceURL", "ModifiedDate" };
        public static List<string> InventoriesFields = new List<string> { "ProductNumber", "Product", "Quantity", "Color", "StockLevel", "Size", "Price", "Cost", "Shelf", "Bin", "Location" };
        public static List<string> WorkOrdersFields = new List<string> { "Product", "OrderQty", "StockedQty", "ScrappedQty", "StartDate", "EndDate", "DueDate", "ModifiedDate" };
        public static List<string> BillOfMaterialsFields = new List<string> { "Product", "Product1", "StartDate", "EndDate", "BOMLevel", "UnitMeasure", "PerAssemblyQty", "ModifiedDate" };
        public static List<string> OrdersFields = new List<string> { "SalesOrderNumber", "Customer", "DueDate", "OnlineOrderFlag", "AccountNumber", "SubTotal", "TaxAmt", "Freight", "TotalDue", "ShipMethod" };
        public static List<string> StoresFields = new List<string> { "AccountNumber", "CompanyName", "StoreContact", "EmailAddress", "Phone", "AddressLine1", "City", "State", "ModifiedDate" };
        public static List<string> IndividualsFields = new List<string> { "AccountNumber", "FirstName", "LastName", "EmailAddress", "Phone", "AddressLine1", "City", "State", "ModifiedDate" };
    }
}
