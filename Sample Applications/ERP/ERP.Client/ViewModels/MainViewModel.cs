using System.Collections.Generic;
using Telerik.Windows.Controls;

namespace ERP.Client.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private NavigationNode navigationTreeSelectedItem;
        private ViewModelBase currentViewModel;
        private bool isBusy;

        public MainViewModel()
        {
            this.IsBusy = true;
            this.NavigationTree = this.BuildNavigationTree();
        }

        public IList<NavigationNode> NavigationTree { get; set; }

        public ViewModelBase CurrentViewModel
        {
            get
            {
                return this.currentViewModel;
            }

            set
            {
                if (this.currentViewModel != value)
                {
                    this.currentViewModel = value;
                    this.OnPropertyChanged(() => this.CurrentViewModel);
                }
            }
        }

        public bool IsBusy
        {
            get
            {
                return this.isBusy;
            }
            set
            {
                if (this.isBusy != value)
                {
                    this.isBusy = value;
                    this.OnPropertyChanged(() => this.IsBusy);
                }
            }
        }

        public NavigationNode NavigationTreeSelectedItem
        {
            get
            {
                return this.navigationTreeSelectedItem;
            }
            set
            {
                if (this.navigationTreeSelectedItem != value 
                    && value != null
                    && value.Name != "Home")
                {
                    this.navigationTreeSelectedItem = value;
                    this.OnPropertyChanged(() => this.NavigationTreeSelectedItem);

                    if (this.navigationTreeSelectedItem.ViewModel != null)
                    {
                        this.CurrentViewModel = this.navigationTreeSelectedItem.ViewModel;
                        this.ExpandParentNodes(this.navigationTreeSelectedItem.Parent);
                    }
                }
            }
        }

        private void ExpandParentNodes(NavigationNode node)
        {
            while (node != null)
            {
                node.IsExpanded = true;
                node = node.Parent;
            }
        }

        private IList<NavigationNode> BuildNavigationTree()
        {
            var tree = new List<NavigationNode>();

            var salesItem = new NavigationNode { Name = "Sales", ImagePath = "/ERP.Client;component/Images/folder.png" };
            var customersNode = new NavigationNode { Name = "Customers", Parent = salesItem };
            customersNode.ChildNodes.Add(new NavigationNode { Name = "Individuals", ViewModel = new IndividualCustomersViewModel(), Parent = customersNode });
            customersNode.ChildNodes.Add(new NavigationNode { Name = "Stores", ViewModel = new StoreCustomersViewModel(), Parent = customersNode });
            salesItem.ChildNodes.Add(customersNode);
            salesItem.ChildNodes.Add(new NavigationNode { Name = "Orders", ViewModel = new OrdersViewModel(), Parent = salesItem, IsSelected = true });
            tree.Add(salesItem);

            var production = new NavigationNode { Name = "Production", ImagePath = "/ERP.Client;component/Images/folder.png" };
            var manufactoringProcess = new NavigationNode { Name = "Manufactoring Process", Parent = production };
            manufactoringProcess.ChildNodes.Add(new NavigationNode { Name = "Bill of Materials", ViewModel = new BillOfMaterialsViewModel(), Parent = manufactoringProcess });
            manufactoringProcess.ChildNodes.Add(new NavigationNode { Name = "Work orders", ViewModel = new WorkOrdersViewModel(), Parent = manufactoringProcess });
            manufactoringProcess.ChildNodes.Add(new NavigationNode { Name = "Instructions", Parent = manufactoringProcess, ViewModel = new DocumentViewModel("Instructions") });
            production.ChildNodes.Add(manufactoringProcess);
            production.ChildNodes.Add(new NavigationNode { Name = "Product inventory", ViewModel = new ProductInventoryViewModel(), Parent = production });
            production.ChildNodes.Add(new NavigationNode { Name = "Documentation", Parent = production, ViewModel = new DocumentViewModel("Documentation") });
            tree.Add(production);

            var vendors = new NavigationNode { Name = "Vendors", ImagePath = "/ERP.Client;component/Images/folder.png" };
            vendors.ChildNodes.Add(new NavigationNode { Name = "Suppliers", ViewModel = new VendorsViewModel(), Parent = vendors });
            vendors.ChildNodes.Add(new NavigationNode { Name = "Purchases", ViewModel = new PurchaseOrdersViewModel(), Parent = vendors });
            tree.Add(vendors);

            return tree;
        }
    }
}
