using System;
using System.ComponentModel.DataAnnotations;

namespace ERP.Repository.Service
{
    [MetadataType(typeof(PurchaseOrderDetailMetadata))]
    public partial class PurchaseOrderDetail 
    {
    }

    public class PurchaseOrderDetailMetadata
    {
        [DisplayAttribute(Order = 0)]
        public Product Product { get; set; }

        [DisplayAttribute(Name = "Quantity", Order = 1)]
        public short OrderQty { get; set; }

        [DisplayAttribute(Name = "Received Quantity", Order = 1)]
        public short ReceivedQty { get; set; }

        [DisplayAttribute(Name = "Stocked Quantity", Order = 1)]
        public short StockedQty { get; set; }

        [DisplayAttribute(Name = "Rejected Quantity", Order = 1)]
        public short RejectedQty { get; set; }

        [DisplayAttribute(Name = "Price per Unit", Order = 2)]
        public decimal UnitPrice { get; set; }

        [DisplayAttribute(Name = "Total Price", Order = 3)]
        public decimal LineTotal { get; set; }

        [DisplayAttribute(Name = "Due Date", Order = 4)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DueDate { get; set; }

        [DisplayAttribute(Name = "Modified Date", Order = 5)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? ModifiedDate { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public int PurchaseOrderID { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public int ProductID { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public int PurchaseOrderDetailID { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public PurchaseOrderHeader PurchaseOrderHeader { get; set; }
    }
}
