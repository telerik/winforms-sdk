using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Data.Services.Client;

namespace ERP.Repository.Service
{
    [MetadataType(typeof(PurchaseOrderHeaderMetadata))]
    public partial class PurchaseOrderHeader : ISavableObject
    {
        public PurchaseOrderHeader()
        {
            this.OrderStatuses = new string[] { "Pending", "Approved", "Rejected", "Complete" };
        }

        [EntityNotSerializableAttribute]
        [DisplayAttribute(AutoGenerateField = false)]
        public string[] OrderStatuses 
        { 
            get; 
            set; 
        }

        [DisplayAttribute(Name = "Order Status")]
        [EntityNotSerializableAttribute]
        public string OrderStatus
        {
            get
            {
                if (this.Status > 0 && this.Status <= this.OrderStatuses.Length)
                {
                    return this.OrderStatuses[this.Status - 1];
                }

                return string.Empty;
            }
            set
            {
                var index = Array.FindIndex(this.OrderStatuses, status => status == value) + 1;
                if (index > -1)
                {
                    this.Status = (byte)index;
                }

                this.OnPropertyChanged("OrderStatus");
            }
        }

        partial void OnShipMethodIDChanged()
        {
            if (this.ShipMethod != null && this.ShipMethod.ShipMethodID != this.ShipMethodID)
            {
                this.ShipMethod = MainRepository.ShipMethodsCache.FirstOrDefault(s => s.ShipMethodID == this.ShipMethodID);
            }
        }

        partial void OnVendorIDChanged()
        {
            if (this.Vendor != null && this.Vendor.BusinessEntityID != this.VendorID)
            {
                this.Vendor = MainRepository.VendorsCache.FirstOrDefault(v => v.BusinessEntityID == this.VendorID);
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
                MainRepository.Update(this);
                MainRepository.SaveChangesAsync();
            }
        }

        public void Delete()
        {
            foreach (var orderDetails in this.PurchaseOrderDetails)
            {
                MainRepository.Context.DeleteObject(orderDetails);
            }

            MainRepository.DeleteAndSave(this);
        }

        public void Cancel()
        {
            if (this.ShipMethod != null && this.ShipMethod.ShipMethodID != this.ShipMethodID)
            {
                this.ShipMethodID = this.ShipMethod.ShipMethodID;
            }

            if (this.Vendor != null && this.Vendor.BusinessEntityID != this.VendorID)
            {
                this.VendorID = this.Vendor.BusinessEntityID;
            }
        }
    }

    public class PurchaseOrderHeaderMetadata
    {
        [DisplayAttribute(AutoGenerateField = false)]
        public byte Status { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public int EmployeeID { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public int PurchaseOrderID { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public int ShipMethodID { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public int VendorID { get; set; }

        [DisplayAttribute(Name = "Sub Total")]
        public decimal SubTotal { get; set; }

        [DisplayAttribute(Name = "Tax Amount")]
        public decimal TaxAmt { get; set; }

        [DisplayAttribute(Name = "Total Due")]
        public decimal TotalDue { get; set; }

        [DisplayAttribute(Name = "Ship Method")]
        public ShipMethod ShipMethod { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DisplayAttribute(Name = "Ship Date")]
        public DateTime ShipDate { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DisplayAttribute(Name = "Modified Date")]
        public DateTime ModifiedDate { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DisplayAttribute(Name = "Order Date")]
        public DateTime OrderDate { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public byte RevisionNumber { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public DataServiceCollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
    }
}
