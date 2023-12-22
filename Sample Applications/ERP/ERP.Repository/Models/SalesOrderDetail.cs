using System;
using System.ComponentModel.DataAnnotations;

namespace ERP.Repository.Service
{
    [MetadataType(typeof(SalesOrderDetailData))]
    public partial class SalesOrderDetail
    {
        [EntityNotSerializableAttribute]
        public Product Product
        {
            get
            {
                return MainRepository.GetProduct(this.ProductID);
            }
        }
    }

    public class SalesOrderDetailData
    {
        [DisplayAttribute(Name = "Carrier Tracking Number")]
        public string CarrierTrackingNumber { get; set; }

        [DisplayAttribute(Name = "Order Quantity")]
        public short OrderQty { get; set; }

        [DisplayAttribute(Name = "Unit Price")]
        public decimal UnitPrice { get; set; }

        [DisplayAttribute(Name = "Unit Price Discount")]
        public decimal UnitPriceDiscount { get; set; }

        [DisplayAttribute(Name = "Line Total")]
        public decimal LineTotal { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DisplayAttribute(Name = "Modified Date")]
        public DateTime ModifiedDate { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public SalesOrderHeader SalesOrderHeader { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public int ProductID { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public int SalesOrderID { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public int SpecialOfferID { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public int SalesOrderDetailID { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public SpecialOfferProduct SpecialOfferProduct { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public System.Guid rowguid { get; set; }
    }
}
