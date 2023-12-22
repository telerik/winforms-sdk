using System.ComponentModel.DataAnnotations;
using System.Data.Services.Client;

namespace ERP.Repository.Service
{
    [MetadataType(typeof(AddressMetadata))]
    public partial class Address : ISavableObject
    {
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
            MainRepository.DeleteAndSave(this);
        }

        public void Cancel()
        {
            // Nothing to cancel.
        }
    }

    public class AddressMetadata
    {
        [DisplayAttribute(Name = "Address Line 1")]
        public string AddressLine1 { get; set; }

        [DisplayAttribute(Name = "Address Line 2")]
        public string AddressLine2 { get; set; }

        [DisplayAttribute(Name = "Postal Code")]
        public string PostalCode { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public StateProvince StateProvince { get; set; }

        [DisplayAttribute(Name = "State")]
        public int StateProvinceID { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public int AddressID { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public DataServiceCollection<BusinessEntityAddress> BusinessEntityAddresses { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public DataServiceCollection<SalesOrderHeader> SalesOrderHeaders { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public DataServiceCollection<SalesOrderHeader> SalesOrderHeaders1 { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public System.Guid rowguid { get; set; }
    }
}
