using ERP.Repository;
using ERP.Repository.Service;

namespace ERP.Client.ViewModels
{
    public class PurchaseOrdersViewModel : ERPViewModelBase<PurchaseOrderHeader>
    {
        public override object GetNewItem()
        {
            // Should be implemented for adding new items.
            return null;
        }

        protected override void GetQuery()
        {
            MainRepository.GetPurchaseOrders(this.Callback);
        }

        public override string ItemName
        {
            get
            {
                return "Purchase Order";
            }
        }

        public override string ToString()
        {
            return "Purchase Orders";
        }
    }
}
