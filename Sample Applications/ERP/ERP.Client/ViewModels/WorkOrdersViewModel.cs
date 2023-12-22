using ERP.Repository;
using ERP.Repository.Service;

namespace ERP.Client.ViewModels
{
    public class WorkOrdersViewModel : ERPViewModelBase<WorkOrder>
    {
        public override object GetNewItem()
        {
            // Should be implemented for adding new items.
            return null;
        }

        protected override void GetQuery()
        {
            MainRepository.GetWorkOrders(this.Callback);
        }

        public override string ItemName
        {
            get 
            { 
                return "Work Order"; 
            }
        }

        public override string ToString()
        {
            return "Work Orders";
        }
    }
}
