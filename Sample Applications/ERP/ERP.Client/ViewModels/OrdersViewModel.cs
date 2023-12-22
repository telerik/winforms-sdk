using ERP.Repository;
using ERP.Repository.Service;

namespace ERP.Client.ViewModels
{
    public class OrdersViewModel : ERPViewModelBase<SalesOrderHeader>
    {
        public override object GetNewItem()
        {
            // Should be implemented for adding new items.
            return null;
        }

        protected override void GetQuery()
        {
            MainRepository.GetOrders(this.Callback);
        }

        public override string ItemName
        {
            get
            { 
                return "Sales Order"; 
            }
        }

        public override string ToString()
        {
            return "Sales Orders";
        }
    }
}
