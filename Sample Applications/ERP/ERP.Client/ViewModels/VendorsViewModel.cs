using ERP.Repository;
using ERP.Repository.Service;

namespace ERP.Client.ViewModels
{
    public class VendorsViewModel : ERPViewModelBase<Vendor>
    {
        public override object GetNewItem()
        {
            // Should be implemented for adding new items.
            return null;
        }

        protected override void GetQuery()
        {
            MainRepository.GetVendors(this.Callback);
        }

        public override string ItemName
        {
            get
            {
                return "Vendor";
            }
        }

        public override string ToString()
        {
            return "Vendors";
        }
    }
}
