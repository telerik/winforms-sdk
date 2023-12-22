using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace ERP.Repository.Service
{
    [MetadataType(typeof(BillOfMaterialMetadata))]
    public partial class BillOfMaterial : ISavableObject
    {
        partial void OnComponentIDChanged()
        {
            if (this.Product != null && this.Product.ProductID != this.ComponentID)
            {
                this.Product = MainRepository.ProductsCache.First(p => p.ProductID == this.ComponentID);
            }
        }

        partial void OnProductAssemblyIDChanged()
        {
            if (this.ProductAssemblyID != null)
            {
                this.Product1 = MainRepository.ProductsCache.First(p => p.ProductID == this.ProductAssemblyID);
                this.BOMLevel = Math.Max(this.BOMLevel, (short)1);
            }
            else
            {
                this.BOMLevel = 0;
            }
        }

        partial void OnBOMLevelChanging(short value)
        {
            if (value < 1 && this.ProductAssemblyID != null)
            {
                throw new ValidationException("BOM level should be higher or equal to 1.");
            }
        }

        partial void OnUnitMeasureCodeChanged()
        {
            if (this.UnitMeasure != null && this.UnitMeasure.UnitMeasureCode != this.UnitMeasureCode)
            {
                this.UnitMeasure = MainRepository.UnitMeasuresCache.First(u => u.UnitMeasureCode == this.UnitMeasureCode);
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
                try
                {
                    MainRepository.Context.AttachTo("BillOfMaterials", this);
                    MainRepository.Update(this);
                    MainRepository.SaveChangesAsync();
                }
                catch(Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
        }

        public void Delete()
        {
            MainRepository.DeleteAndSave(this);
        }

        public void Cancel()
        {
            if (this.Product != null && this.Product.ProductID != this.ComponentID)
            {
                this.ComponentID = this.Product.ProductID;
            }

            if (this.Product1 != null && this.Product1.ProductID != this.ProductAssemblyID)
            {
                this.ProductAssemblyID = this.Product1.ProductID;
            }

            if (this.UnitMeasure != null && this.UnitMeasure.UnitMeasureCode != this.UnitMeasureCode)
            {
                this.UnitMeasureCode = this.UnitMeasure.UnitMeasureCode;
            }
        }
    }

    public class BillOfMaterialMetadata
    {
        [DisplayAttribute(Name = "Parent Product", Order = 0)]
        public Product Product { get; set; }

        [DisplayAttribute(Name = "Child Product", Order = 1)]
        public Product Product1 { get; set; }

        [DisplayAttribute(Name = "Start Date", Order = 2)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? StartDate { get; set; }

        [DisplayAttribute(Name = "End Date", Order = 3)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? EndDate { get; set; }

        [DisplayAttribute(Name = "BOM Level", Order = 4)]
        public short BOMLevel { get; set; }

        [DisplayAttribute(Name = "Unit Measure", Order = 5)]
        public UnitMeasure UnitMeasure { get; set; }

        [DisplayAttribute(Name = "Per Assembly Qty", Order = 6)]
        public decimal PerAssemblyQty { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public string UnitMeasureCode { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public int BillOfMaterialsID { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public int ProductAssemblyID { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public int ComponentID { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public System.Guid rowguid { get; set; }
    }
}
