using ERP.Repository;
using ERP.Repository.Service;

namespace ERP.Client.ViewModels
{
    public class ProductInventoryViewModel : ERPViewModelBase<ProductInventory>
    {
        public override object GetNewItem()
        {
            // Should be implemented for adding new items.
            return null;
        }

        protected override void GetQuery()
        {
            MainRepository.GetProductInventories(this.Callback);
        }

        public override string ItemName
        {
            get
            {
                return "Product Inventory";
            }
        }

        public override string ToString()
        {
            return "Product Inventories";
        }
    }
}
