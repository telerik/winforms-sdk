using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Data.Services.Client;

namespace ERP.Repository.Service
{
    [MetadataType(typeof(WorkOrderMetadata))]
    public partial class WorkOrder: ISavableObject
    {
        partial void OnProductIDChanged()
        {
            if (this.Product != null && this.Product.ProductID != this.ProductID)
            {
                this.Product = MainRepository.ProductsCache.FirstOrDefault(p => p.ProductID == this.ProductID);
            }
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
            MainRepository.DeleteAndSave(this);
        }

        public void Cancel()
        {
            if (this.Product != null && this.Product.ProductID != this.ProductID)
            {
                this.ProductID = this.Product.ProductID;
            }
        }
    }

    public class WorkOrderMetadata
    {
        [DisplayAttribute(Order = 0)]
        public Product Product { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd.MM.yyyy}")]
        [DisplayAttribute(Name = "Start Date")]
        public DateTime? StartDate { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd.MM.yyyy}")]
        [DisplayAttribute(Name = "Due Date")]
        public DateTime? DueDate { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd.MM.yyyy}")]
        [DisplayAttribute(Name = "End Date")]
        public DateTime? EndDate { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd.MM.yyyy}")]
        [DisplayAttribute(Name = "Modified Date")]
        public DateTime? ModifiedDate { get; set; }

        [DisplayAttribute(Name = "Scrapped")]
        public int ScrappedQty { get; set; }

        [DisplayAttribute(Name = "Stocked")]
        public int StockedQty { get; set; }

        [DisplayAttribute(Name = "Quantity")]
        public int OrderQty { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public ScrapReason ScrapReason { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public int ProductID { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public int WorkOrderID { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public int ScrapReasonID { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public DataServiceCollection<WorkOrderRouting> WorkOrderRoutings { get; set; }
    }
}
