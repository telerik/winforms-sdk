using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Data.Services.Client;
using System.ComponentModel;

namespace ERP.Repository.Service
{
    [MetadataType(typeof(VendorMetadata))]
    public partial class Vendor : ISavableObject
    {
        public override string ToString()
        {
            return this.Name;
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
            }

            MainRepository.SaveChanges();
        }

        public void Delete()
        {
            this.ActiveFlag = false;
            MainRepository.Update(this);
            MainRepository.SaveChanges();
        }

        public void Cancel()
        {
            // Nothing to cancel.
        }
    }

    public class VendorMetadata
    {
        [DisplayAttribute(Name = "Preference")]
        public bool PreferredVendorStatus { get; set; }

        [DisplayAttribute(Name = "Account Number")]
        [ReadOnly(true)]
        public string AccountNumber { get; set; }

        [DisplayAttribute(Name = "URL")]
        public string PurchasingWebServiceURL { get; set; }

        [DisplayAttribute(Name = "Active Status")]
        public bool ActiveFlag { get; set; }

        [DisplayAttribute(Name = "Credit Rating")]
        public byte CreditRating { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public DataServiceCollection<ProductVendor> ProductVendors { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public DataServiceCollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public int BusinessEntityID { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public BusinessEntity BusinessEntity { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd.MM.yyyy}")]
        [DisplayAttribute(Name = "Modified Date")]
        public DateTime? ModifiedDate { get; set; }
    }
}
