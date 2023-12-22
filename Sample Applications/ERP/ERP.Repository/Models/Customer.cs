using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Services.Client;
using System.Linq;

namespace ERP.Repository.Service
{
    [MetadataType(typeof(CustomerMetadata))]
    public partial class Customer : ISavableObject
    {
        [EntityNotSerializableAttribute]
        public bool IsPerson
        {
            get
            {
                return this.Person != null && this.Store == null;
            }
        }

        [EntityNotSerializableAttribute]
        [DisplayAttribute(Name = "Company Name")]
        public string CompanyName
        {
            get
            {
                if (this.Store != null)
                {
                    return this.Store.Name;
                }

                return string.Empty;
            }
            set
            {
                if (this.Store != null)
                {
                    this.Store.Name = value;
                    this.OnPropertyChanged("CompanyName");
                }
            }
        }

        [EntityNotSerializableAttribute]
        [DisplayAttribute(Name = "Contact Name")]
        public Person StoreContact
        {
            get
            {
                if (this.Store != null && this.Store.BusinessEntity != null)
                {
                    var contact = this.Store.BusinessEntity.BusinessEntityContacts.FirstOrDefault();
                    if (contact != null)
                    {
                        return contact.Person;
                    }
                }

                return null;
            }
        }

        [EntityNotSerializableAttribute]
        [DisplayAttribute(Name = "First Name")]
        public string FirstName
        {
            get
            {
                if (this.IsPerson)
                {
                    return this.Person.FirstName;
                }

                return string.Empty;
            }
            set
            {
                if (this.IsPerson)
                {
                    this.Person.FirstName = value;
                    this.OnPropertyChanged("FirstName");
                }
            }
        }

        [EntityNotSerializableAttribute]
        [DisplayAttribute(Name = "Last Name")]
        public string LastName
        {
            get
            {
                if (this.IsPerson)
                {
                    return this.Person.LastName;
                }

                return string.Empty;
            }
            set
            {
                if (this.IsPerson)
                {
                    this.Person.LastName = value;
                    this.OnPropertyChanged("LastName");
                }
            }
        }

        [EntityNotSerializableAttribute]
        [DisplayAttribute(AutoGenerateField = false)]
        public string Name
        {
            get
            {
                if (this.IsPerson)
                {
                    return this.Person.FullName;
                }
                else if (this.Store != null)
                {
                    return this.Store.Name;
                }

                return string.Empty;
            }
        }

        [EntityNotSerializableAttribute]
        [DisplayAttribute(Name = "Email Address")]
        public string EmailAddress
        {
            get
            {
                var mail = string.Empty;
                if (this.IsPerson)
                {
                    var personMail = this.Person.EmailAddresses.FirstOrDefault();
                    if (personMail != null)
                    {
                        mail = personMail.EmailAddress1;
                    }
                }
                else
                {
                    if (this.StoreContact != null)
                    {
                        var contactMail = this.StoreContact.EmailAddresses.FirstOrDefault();
                        if (contactMail != null)
                        {
                            mail = contactMail.EmailAddress1;
                        }
                    }
                }

                return mail;
            }
            set
            {
                if (this.IsPerson)
                {
                    var personMail = this.Person.EmailAddresses.FirstOrDefault();
                    if (personMail != null)
                    {
                        personMail.EmailAddress1 = value;
                    }
                }
                else if (this.StoreContact != null)
                {
                    var contactMail = this.StoreContact.EmailAddresses.FirstOrDefault();
                    if (contactMail != null)
                    {
                        contactMail.EmailAddress1 = value;
                    }
                }

                this.OnPropertyChanged("EmailAddress");
            }
        }

        [EntityNotSerializableAttribute]
        public string Phone
        {
            get
            {
                var phone = string.Empty;
                if (this.IsPerson)
                {
                    var personPhone = this.Person.PersonPhones.FirstOrDefault();
                    if (personPhone != null)
                    {
                        phone = personPhone.PhoneNumber;
                    }
                }
                else if (this.StoreContact != null)
                {
                    var contactPhone = this.StoreContact.PersonPhones.FirstOrDefault();
                    if (contactPhone != null)
                    {
                        phone = contactPhone.PhoneNumber;
                    }
                }

                return phone;
            }
            set
            {
                if (this.IsPerson)
                {
                    var personPhone = this.Person.PersonPhones.FirstOrDefault();
                    if (personPhone != null)
                    {
                        personPhone.PhoneNumber = value;
                    }
                }
                else if (this.StoreContact != null)
                {
                    var contactPhone = this.StoreContact.PersonPhones.FirstOrDefault();
                    if (contactPhone != null)
                    {
                        contactPhone.PhoneNumber = value;
                    }
                }
            }
        }

        [EntityNotSerializableAttribute]
        [DisplayAttribute(AutoGenerateField = false)]
        public Address Address
        {
            get
            {
                if (this.IsPerson)
                {
                    var personAddress = this.Person.BusinessEntity.BusinessEntityAddresses.FirstOrDefault();
                    if (personAddress != null)
                    {
                        return personAddress.Address;
                    }
                }
                else if (this.Store != null && this.Store.BusinessEntity != null)
                {
                    var storeAddress = this.Store.BusinessEntity.BusinessEntityAddresses.FirstOrDefault();
                    if (storeAddress != null && storeAddress.Address != null)
                    {
                        return storeAddress.Address;
                    }
                }

                return null;
            }
        }

        [EntityNotSerializableAttribute]
        [DisplayAttribute(Name = "Address Line 1")]
        public string AddressLine1
        {
            get
            {
                if (this.Address != null)
                {
                    return this.Address.AddressLine1;
                }

                return string.Empty;
            }
            set
            {
                if (this.Address != null && this.Address.AddressLine1 != value)
                {
                    this.Address.AddressLine1 = value;
                }
            }
        }

        [EntityNotSerializableAttribute]
        public string City
        {
            get
            {
                if (this.Address != null)
                {
                    return this.Address.City;
                }

                return string.Empty;
            }
            set
            {
                if (this.Address != null)
                {
                    this.Address.City = value;
                }
            }
        }

        [EntityNotSerializableAttribute]
        public string State
        {
            get
            {
                if (this.Address != null)
                {
                    this.Address.PropertyChanged -= this.OnAddressPropertyChanged;
                    this.Address.PropertyChanged += this.OnAddressPropertyChanged;

                    return MainRepository.StatesCache.Where(s => s.StateProvinceID == this.Address.StateProvinceID).First().Name;
                }

                return null;
            }
        }

        private void OnAddressPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "StateProvinceID")
            {
                this.OnPropertyChanged("State");
            }
        }

        private void ReevalateProperties()
        {
            this.OnPropertyChanged("Name");
            this.OnPropertyChanged("Address");
            this.OnPropertyChanged("State");
        }

        public override string ToString()
        {
            return this.Name;
        }

        public void Save(bool isAddingItem)
        {
            if (isAddingItem)
            {
                // Logic when adding new item.
            }
            else
            {
                if (this.Address != null)
                {
                    MainRepository.Update(this.Address);
                }

                if (this.IsPerson)
                {
                    MainRepository.Update(this.Person);
                }
                else
                {
                    MainRepository.Update(this.Store);
                }

                MainRepository.Update(this);
                MainRepository.SaveChangesAsync();
            }

            this.ReevalateProperties();
        }

        public void Delete()
        {
            foreach (var order in this.SalesOrderHeaders)
            {
                // delete the related orders
                MainRepository.Context.DeleteObject(order);
            }

            MainRepository.DeleteAndSave(this);
        }

        public void Cancel()
        {
            // Nothing to cancel.
        }
    }

    public class CustomerMetadata
    {
        [DisplayAttribute(Name = "Account Number", Order = 0)]
        [ReadOnly(true)]
        public int AccountNumber { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DisplayAttribute(Name = "Modified Date")]
        public DateTime ModifiedDate { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public DataServiceCollection<EmailAddress> EmailAddresses { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public DataServiceCollection<SalesOrderHeader> SalesOrderHeaders { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public DataServiceCollection<PersonPhone> PersonPhones { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public bool IsPerson { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public SalesTerritory SalesTerritory { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public BusinessEntityContact StoreContact { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public Person Person { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public Store Store { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public int PersonID { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public int StoreID { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public int TerritoryID { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public int CustomerID { get; set; }

        [DisplayAttribute(AutoGenerateField = false)]
        public System.Guid rowguid { get; set; }
    }
}
