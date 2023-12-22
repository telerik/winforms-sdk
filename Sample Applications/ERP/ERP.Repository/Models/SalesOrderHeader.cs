using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Data.Services.Client;

namespace ERP.Repository.Service
{
    [MetadataType(typeof(SalesOrderHeaderMetadata))]
    public partial class SalesOrderHeader : ISavableObject
    {
        partial void OnCustomerIDChanged()
        {
            if (this.Customer != null && this.Customer.CustomerID != this.CustomerID)
            {
                this.Customer = MainRepository.Context.Customers.Where(c => c.CustomerID == this.CustomerID).ToList().First();
            }
        }

        partial void OnShipMethodIDChanged()
        {
            if (this.ShipMethod != null && this.ShipMethod.ShipMethodID != this.ShipMethodID)
            {
                this.ShipMethod = MainRepository.ShipMethodsCache.FirstOrDefault(s => s.ShipMethodID == this.ShipMethodID);
            }
        }

        public void Save(bool isAddingItem)
        {
            if (isAddingItem)
            {
                // Logic when adding new item.
            }
            else
            {
                MainRepository.UpdateAndSaveAsync(this);
            }
        }

        public void Delete()
        {
            MainRepository.DeleteAndSave(this);
        }

        public void Cancel()
        {
            if (this.Customer != null && this.Customer.CustomerID != this.CustomerID)
            {
                this.CustomerID = this.Customer.CustomerID;
            }

            if (this.ShipMethod != null && this.ShipMethod.ShipMethodID != this.ShipMethodID)
            {
                this.ShipMethodID = this.ShipMethod.ShipMethodID;
            }
        }
    }

    public class SalesOrderHeaderMetadata
    {
        [DisplayAttribute(AutoGenerateField = false)]
        public string Comment { get; set; }

        [DisplayAttribute(Name = "Order Number", Order = 0)]
        public string SalesOrderNumber { get; set; }

        [DisplayAttribute(Order = 1)]
        public Customer Customer { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public int RevisionNumber { get; set; }

        [DisplayAttribute(Name = "Ship Method")]
        public ShipMethod ShipMethod { get; set; }

        [DisplayAttribute(Name = "Sub Total")]
        public decimal SubTotal { get; set; }

        [DisplayAttribute(Name = "Tax Amount")]
        public decimal TaxAmt { get; set; }

        [DisplayAttribute(Name = "Total Due")]
        public decimal TotalDue { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public int ShipMethodID { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public DateTime OrderDate { get; set; }

        [DisplayAttribute(Name = "Due Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DueDate { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime ModifiedDate { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime ShipDate { get; set; }

        [DisplayAttribute(Name = "Is Online Order")]
        public bool OnlineOrderFlag { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public string PurchaseOrderNumber { get; set; }

        [DisplayAttribute(Name = "Account Number")]
        public string AccountNumber { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public int CustomerID { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public int SalesOrderID { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public Address Address { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public byte Status { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public Address Address1 { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public CreditCard CreditCard { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public CurrencyRate CurrencyRate { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public int SalesPersonID { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public int BillToAddressID { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public int TerritoryID { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public int ShipToAddressID { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public int CreditCardID { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public int CreditCardApprovalCode { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public int CurrencyRateID { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public SalesPerson SalesPerson { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public SalesTerritory SalesTerritory { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public DataServiceCollection<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public DataServiceCollection<SalesOrderDetail> SalesOrderDetails { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public System.Guid rowguid { get; set; }
    }
}
