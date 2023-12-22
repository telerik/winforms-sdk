using ERP.Repository;
using ERP.Repository.Service;
using System;

namespace ERP.Client.ViewModels
{
    public class BillOfMaterialsViewModel: ERPViewModelBase<BillOfMaterial>
    {
        public override object GetNewItem()
        {
            // Should be implemented for adding new items.
            return null;
        }

        protected override void GetQuery()
        {
            MainRepository.GetBillOfMaterials(this.Callback);
        }

        public override string ItemName
        {
            get
            {
                return "Bill of Material";
            }
        }

        public override string ToString()
        {
            return "Bill of Materials";
        }
    }
}
