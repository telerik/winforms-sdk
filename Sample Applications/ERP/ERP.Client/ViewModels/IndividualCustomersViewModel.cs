using ERP.Repository;
using ERP.Repository.Service;
using System.Collections.ObjectModel;

namespace ERP.Client.ViewModels
{
    public class IndividualCustomersViewModel : ERPViewModelBase<Customer>
    {
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == "SelectedItem")
            {
                if (this.SelectedItem != null)
                {
                    this.ShowAdditionalItems = true;
                    this.AdditionalItems = null;
                    this.AdditionalItems = new ObservableCollection<object>((this.SelectedItem as Customer).SalesOrderHeaders);
                }
                else
                {
                    this.ShowAdditionalItems = false;
                }
            }
        }

        public override object GetNewItem()
        {
            // Should be implemented for adding new items.
            return null;
        }

        protected override void GetQuery()
        {
            MainRepository.GetCustomers(true, this.Callback);
        }

        public override string ItemName
        {
            get
            {
                return "Individual";
            }
        }

        public override string ToString()
        {
            return "Individual Customers";
        }
    }
}
