using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.ComponentModel;

namespace ERP.Repository.Service
{
    [MetadataType(typeof(ProductMetadata))]
    public partial class ProductInventory : ISavableObject
    {
        [DisplayAttribute(Name = "Product Number", Order = 0)]
        [EntityNotSerializableAttribute]
        [ReadOnly(true)]
        public string ProductNumber
        {
            get
            {
                return this.Product.ProductNumber;
            }
            set
            {
                if (this.Product.ProductNumber != value)
                {
                    this.Product.ProductNumber = value;
                    this.OnPropertyChanged("ProductNumber");
                }
            }
        }

        [EntityNotSerializableAttribute]
        public string Color
        {
            get
            {
                return this.Product.Color;
            }
            set
            {
                if (this.Product.Color != value)
                {
                    this.Product.Color = value;
                    this.OnPropertyChanged("Color");
                }
            }
        }

        [DisplayAttribute(Name = "Stock Level")]
        [EntityNotSerializableAttribute]
        public short StockLevel
        {
            get
            {
                return this.Product.SafetyStockLevel;
            }
            set
            {
                if (this.Product.SafetyStockLevel != value)
                {
                    this.Product.SafetyStockLevel = value;
                    this.OnPropertyChanged("StockLevel");
                }
            }
        }

        [EntityNotSerializableAttribute]
        public string Size
        {
            get
            {
                return this.Product.Size;
            }
            set
            {
                if (this.Product.Size != value)
                {
                    this.Product.Size = value;
                    this.OnPropertyChanged("Size");
                }
            }
        }

        [EntityNotSerializableAttribute]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:G29}")]
        public decimal Price
        {
            get
            {
                return this.Product.ListPrice;
            }
            set
            {
                if (this.Product.ListPrice != value)
                {
                    this.Product.ListPrice = value;
                    this.OnPropertyChanged("Price");
                }
            }
        }

        [EntityNotSerializableAttribute]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:G29}")]
        public decimal Cost
        {
            get
            {
                return this.Product.StandardCost;
            }
            set
            {
                if (this.Product.StandardCost != value)
                {
                    this.Product.StandardCost = value;
                    this.OnPropertyChanged("Cost");
                }
            }
        }

        partial void OnProductIDChanged()
        {
            if (this.Product != null && this.Product.ProductID != this.ProductID)
            {
                this.Product = MainRepository.ProductsCache.FirstOrDefault(p => p.ProductID == this.ProductID);
                this.ReevalateProperties();
            }
        }

        partial void OnLocationIDChanged()
        {
            if (this.Location != null && this.Location.LocationID != this.LocationID)
            {
                this.Location = MainRepository.LocationsCache.FirstOrDefault(p => p.LocationID == this.LocationID);
            }
        }

        partial void OnBinChanging(byte value)
        {
            if (value < 0 || value > 100)
            {
                throw new ValidationException("Value should be in the range between 0 and 100.");
            }
        }

        partial void OnShelfChanging(string value)
        {
            var isLeter = value.Length == 1 && Regex.IsMatch(value, "^[a-zA-Z]*$");
            if (!isLeter && value != "N/A")
            {
                throw new ValidationException("Value should be [A-Za-z] or 'N/A'.");
            }
        }

        private void ReevalateProperties()
        {
            this.OnPropertyChanged("ProductNumber");
            this.OnPropertyChanged("Color");
            this.OnPropertyChanged("StockLevel");
            this.OnPropertyChanged("Cost");
            this.OnPropertyChanged("Size");
            this.OnPropertyChanged("Price");
        }

        public void Save(bool isAddingItem)
        {
            if (isAddingItem)
            {
                // Logic when adding new item.
            }
            else
            {
                MainRepository.Update(this.Product);
                MainRepository.Update(this);
                MainRepository.SaveChangesAsync();
            }
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

            if (this.Location != null && this.Location.LocationID != this.LocationID)
            {
                this.LocationID = this.Location.LocationID;
            }

            this.ReevalateProperties();
        }
    }

    public class ProductMetadata
    {
        [DisplayAttribute(Order = 5)]
        public short Quantity { get; set; }

        [DisplayAttribute(Order = 1)]
        public Product Product { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public int ProductID { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public int LocationID { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public DateTime? ModifiedDate { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public System.Guid rowguid { get; set; }
    }
}
