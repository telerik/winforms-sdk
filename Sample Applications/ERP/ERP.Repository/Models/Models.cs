using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;

namespace ERP.Repository.Service
{
    public partial class Address : System.ComponentModel.INotifyPropertyChanged
    {
        public int AddressID
        {
            get
            {
                return this._AddressID;
            }
            set
            {
                this._AddressID = value;
                this.OnPropertyChanged("AddressID");
            }
        }
        private int _AddressID;
        public string AddressLine1
        {
            get
            {
                return this._AddressLine1;
            }
            set
            {
                this._AddressLine1 = value;
                this.OnPropertyChanged("AddressLine1");
            }
        }
        private string _AddressLine1;
        public string AddressLine2
        {
            get
            {
                return this._AddressLine2;
            }
            set
            {
                this._AddressLine2 = value;
                this.OnPropertyChanged("AddressLine2");
            }
        }
        private string _AddressLine2;
        public string City
        {
            get
            {
                return this._City;
            }
            set
            {
                this._City = value;
                this.OnPropertyChanged("City");
            }
        }
        private string _City;
        public int StateProvinceID
        {
            get
            {
                return this._StateProvinceID;
            }
            set
            {
                this._StateProvinceID = value;
                this.OnPropertyChanged("StateProvinceID");
            }
        }
        private int _StateProvinceID;
        public string PostalCode
        {
            get
            {
                return this._PostalCode;
            }
            set
            {
                this._PostalCode = value;
                this.OnPropertyChanged("PostalCode");
            }
        }
        private string _PostalCode;
        public System.Guid rowguid
        {
            get
            {
                return this._rowguid;
            }
            set
            {
                this._rowguid = value;
                this.OnPropertyChanged("rowguid");
            }
        }
        private System.Guid _rowguid;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public StateProvince StateProvince
        {
            get
            {
                return this._StateProvince;
            }
            set
            {
                this._StateProvince = value;
                this.OnPropertyChanged("StateProvince");
            }
        }
        private StateProvince _StateProvince;
        public ObservableCollection<BusinessEntityAddress> BusinessEntityAddresses
        {
            get
            {
                return this._BusinessEntityAddresses;
            }
            set
            {
                this._BusinessEntityAddresses = value;
                this.OnPropertyChanged("BusinessEntityAddresses");
            }
        }
        private ObservableCollection<BusinessEntityAddress> _BusinessEntityAddresses = new ObservableCollection<BusinessEntityAddress>();
        public ObservableCollection<SalesOrderHeader> SalesOrderHeaders
        {
            get
            {
                return this._SalesOrderHeaders;
            }
            set
            {
                this._SalesOrderHeaders = value;
                this.OnPropertyChanged("SalesOrderHeaders");
            }
        }
        private ObservableCollection<SalesOrderHeader> _SalesOrderHeaders = new ObservableCollection<SalesOrderHeader>();
        public ObservableCollection<SalesOrderHeader> SalesOrderHeaders1
        {
            get
            {
                return this._SalesOrderHeaders1;
            }
            set
            {
                this._SalesOrderHeaders1 = value;
                this.OnPropertyChanged("SalesOrderHeaders1");
            }
        }
        private ObservableCollection<SalesOrderHeader> _SalesOrderHeaders1 = new ObservableCollection<SalesOrderHeader>();
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    public partial class AddressType : System.ComponentModel.INotifyPropertyChanged
    {
        public int AddressTypeID
        {
            get
            {
                return this._AddressTypeID;
            }
            set
            {
                this._AddressTypeID = value;
                this.OnPropertyChanged("AddressTypeID");
            }
        }
        private int _AddressTypeID;
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this._Name = value;
                this.OnPropertyChanged("Name");
            }
        }
        private string _Name;
        public System.Guid rowguid
        {
            get
            {
                return this._rowguid;
            }
            set
            {
                this._rowguid = value;
                this.OnPropertyChanged("rowguid");
            }
        }
        private System.Guid _rowguid;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public ObservableCollection<BusinessEntityAddress> BusinessEntityAddresses
        {
            get
            {
                return this._BusinessEntityAddresses;
            }
            set
            {
                this._BusinessEntityAddresses = value;
                this.OnPropertyChanged("BusinessEntityAddresses");
            }
        }
        private ObservableCollection<BusinessEntityAddress> _BusinessEntityAddresses = new ObservableCollection<BusinessEntityAddress>();
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    public partial class BusinessEntity : System.ComponentModel.INotifyPropertyChanged
    {
        public int BusinessEntityID
        {
            get
            {
                return this._BusinessEntityID;
            }
            set
            {
                this._BusinessEntityID = value;
                this.OnPropertyChanged("BusinessEntityID");
            }
        }
        private int _BusinessEntityID;
        public System.Guid rowguid
        {
            get
            {
                return this._rowguid;
            }
            set
            {
                this._rowguid = value;
                this.OnPropertyChanged("rowguid");
            }
        }
        private System.Guid _rowguid;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public ObservableCollection<BusinessEntityAddress> BusinessEntityAddresses
        {
            get
            {
                return this._BusinessEntityAddresses;
            }
            set
            {
                this._BusinessEntityAddresses = value;
                this.OnPropertyChanged("BusinessEntityAddresses");
            }
        }
        private ObservableCollection<BusinessEntityAddress> _BusinessEntityAddresses = new ObservableCollection<BusinessEntityAddress>();
        public ObservableCollection<BusinessEntityContact> BusinessEntityContacts
        {
            get
            {
                return this._BusinessEntityContacts;
            }
            set
            {
                this._BusinessEntityContacts = value;
                this.OnPropertyChanged("BusinessEntityContacts");
            }
        }
        private ObservableCollection<BusinessEntityContact> _BusinessEntityContacts = new ObservableCollection<BusinessEntityContact>();
        public Person Person
        {
            get
            {
                return this._Person;
            }
            set
            {
                this._Person = value;
                this.OnPropertyChanged("Person");
            }
        }
        private Person _Person;
        public Store Store
        {
            get
            {
                return this._Store;
            }
            set
            {
                this._Store = value;
                this.OnPropertyChanged("Store");
            }
        }
        private Store _Store;
        public Vendor Vendor
        {
            get
            {
                return this._Vendor;
            }
            set
            {
                this._Vendor = value;
                this.OnPropertyChanged("Vendor");
            }
        }
        private Vendor _Vendor;
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    public partial class BusinessEntityAddress : System.ComponentModel.INotifyPropertyChanged
    {
        public int BusinessEntityID
        {
            get
            {
                return this._BusinessEntityID;
            }
            set
            {
                this._BusinessEntityID = value;
                this.OnPropertyChanged("BusinessEntityID");
            }
        }
        private int _BusinessEntityID;
        public int AddressID
        {
            get
            {
                return this._AddressID;
            }
            set
            {
                this._AddressID = value;
                this.OnPropertyChanged("AddressID");
            }
        }
        private int _AddressID;
        public int AddressTypeID
        {
            get
            {
                return this._AddressTypeID;
            }
            set
            {
                this._AddressTypeID = value;
                this.OnPropertyChanged("AddressTypeID");
            }
        }
        private int _AddressTypeID;
        public System.Guid rowguid
        {
            get
            {
                return this._rowguid;
            }
            set
            {
                this._rowguid = value;
                this.OnPropertyChanged("rowguid");
            }
        }
        private System.Guid _rowguid;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public Address Address
        {
            get
            {
                return this._Address;
            }
            set
            {
                this._Address = value;
                this.OnPropertyChanged("Address");
            }
        }
        private Address _Address;
        public AddressType AddressType
        {
            get
            {
                return this._AddressType;
            }
            set
            {
                this._AddressType = value;
                this.OnPropertyChanged("AddressType");
            }
        }
        private AddressType _AddressType;
        public BusinessEntity BusinessEntity
        {
            get
            {
                return this._BusinessEntity;
            }
            set
            {
                this._BusinessEntity = value;
                this.OnPropertyChanged("BusinessEntity");
            }
        }
        private BusinessEntity _BusinessEntity;
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    public partial class BusinessEntityContact : System.ComponentModel.INotifyPropertyChanged
    {
        public int BusinessEntityID
        {
            get
            {
                return this._BusinessEntityID;
            }
            set
            {
                this._BusinessEntityID = value;
                this.OnPropertyChanged("BusinessEntityID");
            }
        }
        private int _BusinessEntityID;
        public int PersonID
        {
            get
            {
                return this._PersonID;
            }
            set
            {
                this._PersonID = value;
                this.OnPropertyChanged("PersonID");
            }
        }
        private int _PersonID;
        public int ContactTypeID
        {
            get
            {
                return this._ContactTypeID;
            }
            set
            {
                this._ContactTypeID = value;
                this.OnPropertyChanged("ContactTypeID");
            }
        }
        private int _ContactTypeID;
        public System.Guid rowguid
        {
            get
            {
                return this._rowguid;
            }
            set
            {
                this._rowguid = value;
                this.OnPropertyChanged("rowguid");
            }
        }
        private System.Guid _rowguid;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public BusinessEntity BusinessEntity
        {
            get
            {
                return this._BusinessEntity;
            }
            set
            {
                this._BusinessEntity = value;
                this.OnPropertyChanged("BusinessEntity");
            }
        }
        private BusinessEntity _BusinessEntity;
        public ContactType ContactType
        {
            get
            {
                return this._ContactType;
            }
            set
            {
                this._ContactType = value;
                this.OnPropertyChanged("ContactType");
            }
        }
        private ContactType _ContactType;
        public Person Person
        {
            get
            {
                return this._Person;
            }
            set
            {
                this._Person = value;
                this.OnPropertyChanged("Person");
            }
        }
        private Person _Person;
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    public partial class ContactType : System.ComponentModel.INotifyPropertyChanged
    {
        public int ContactTypeID
        {
            get
            {
                return this._ContactTypeID;
            }
            set
            {
                this._ContactTypeID = value;
                this.OnPropertyChanged("ContactTypeID");
            }
        }
        private int _ContactTypeID;
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this._Name = value;
                this.OnPropertyChanged("Name");
            }
        }
        private string _Name;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public ObservableCollection<BusinessEntityContact> BusinessEntityContacts
        {
            get
            {
                return this._BusinessEntityContacts;
            }
            set
            {
                this._BusinessEntityContacts = value;
                this.OnPropertyChanged("BusinessEntityContacts");
            }
        }
        private ObservableCollection<BusinessEntityContact> _BusinessEntityContacts = new ObservableCollection<BusinessEntityContact>();
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    public partial class CountryRegion : System.ComponentModel.INotifyPropertyChanged
    {
        public string CountryRegionCode
        {
            get
            {
                return this._CountryRegionCode;
            }
            set
            {
                this._CountryRegionCode = value;
                this.OnPropertyChanged("CountryRegionCode");
            }
        }
        private string _CountryRegionCode;
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this._Name = value;
                this.OnPropertyChanged("Name");
            }
        }
        private string _Name;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public ObservableCollection<CountryRegionCurrency> CountryRegionCurrencies
        {
            get
            {
                return this._CountryRegionCurrencies;
            }
            set
            {
                this._CountryRegionCurrencies = value;
                this.OnPropertyChanged("CountryRegionCurrencies");
            }
        }
        private ObservableCollection<CountryRegionCurrency> _CountryRegionCurrencies = new ObservableCollection<CountryRegionCurrency>();
        public ObservableCollection<SalesTerritory> SalesTerritories
        {
            get
            {
                return this._SalesTerritories;
            }
            set
            {
                this._SalesTerritories = value;
                this.OnPropertyChanged("SalesTerritories");
            }
        }
        private ObservableCollection<SalesTerritory> _SalesTerritories = new ObservableCollection<SalesTerritory>();
        public ObservableCollection<StateProvince> StateProvinces
        {
            get
            {
                return this._StateProvinces;
            }
            set
            {
                this._StateProvinces = value;
                this.OnPropertyChanged("StateProvinces");
            }
        }
        private ObservableCollection<StateProvince> _StateProvinces = new ObservableCollection<StateProvince>();
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    public partial class EmailAddress : System.ComponentModel.INotifyPropertyChanged
    {
        public int BusinessEntityID
        {
            get
            {
                return this._BusinessEntityID;
            }
            set
            {
                this._BusinessEntityID = value;
                this.OnPropertyChanged("BusinessEntityID");
            }
        }
        private int _BusinessEntityID;
        public int EmailAddressID
        {
            get
            {
                return this._EmailAddressID;
            }
            set
            {
                this._EmailAddressID = value;
                this.OnPropertyChanged("EmailAddressID");
            }
        }
        private int _EmailAddressID;
        public string EmailAddress1
        {
            get
            {
                return this._EmailAddress1;
            }
            set
            {
                this._EmailAddress1 = value;
                this.OnPropertyChanged("EmailAddress1");
            }
        }
        private string _EmailAddress1;
        public System.Guid rowguid
        {
            get
            {
                return this._rowguid;
            }
            set
            {
                this._rowguid = value;
                this.OnPropertyChanged("rowguid");
            }
        }
        private System.Guid _rowguid;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public Person Person
        {
            get
            {
                return this._Person;
            }
            set
            {
                this._Person = value;
                this.OnPropertyChanged("Person");
            }
        }
        private Person _Person;
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    public partial class Password : System.ComponentModel.INotifyPropertyChanged
    {
        public int BusinessEntityID
        {
            get
            {
                return this._BusinessEntityID;
            }
            set
            {
                this._BusinessEntityID = value;
                this.OnPropertyChanged("BusinessEntityID");
            }
        }
        private int _BusinessEntityID;
        public string PasswordHash
        {
            get
            {
                return this._PasswordHash;
            }
            set
            {
                this._PasswordHash = value;
                this.OnPropertyChanged("PasswordHash");
            }
        }
        private string _PasswordHash;
        public string PasswordSalt
        {
            get
            {
                return this._PasswordSalt;
            }
            set
            {
                this._PasswordSalt = value;
                this.OnPropertyChanged("PasswordSalt");
            }
        }
        private string _PasswordSalt;
        public System.Guid rowguid
        {
            get
            {
                return this._rowguid;
            }
            set
            {
                this._rowguid = value;
                this.OnPropertyChanged("rowguid");
            }
        }
        private System.Guid _rowguid;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public Person Person
        {
            get
            {
                return this._Person;
            }
            set
            {
                this._Person = value;
                this.OnPropertyChanged("Person");
            }
        }
        private Person _Person;
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    public partial class Person : System.ComponentModel.INotifyPropertyChanged
    {
        public int BusinessEntityID
        {
            get
            {
                return this._BusinessEntityID;
            }
            set
            {
                this._BusinessEntityID = value;
                this.OnPropertyChanged("BusinessEntityID");
            }
        }
        private int _BusinessEntityID;
        public string PersonType
        {
            get
            {
                return this._PersonType;
            }
            set
            {
                this._PersonType = value;
                this.OnPropertyChanged("PersonType");
            }
        }
        private string _PersonType;
        public bool NameStyle
        {
            get
            {
                return this._NameStyle;
            }
            set
            {
                this._NameStyle = value;
                this.OnPropertyChanged("NameStyle");
            }
        }
        private bool _NameStyle;
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this._Title = value;
                this.OnPropertyChanged("Title");
            }
        }
        private string _Title;
        public string FirstName
        {
            get
            {
                return this._FirstName;
            }
            set
            {
                this._FirstName = value;
                this.OnPropertyChanged("FirstName");
            }
        }
        private string _FirstName;
        public string MiddleName
        {
            get
            {
                return this._MiddleName;
            }
            set
            {
                this._MiddleName = value;
                this.OnPropertyChanged("MiddleName");
            }
        }
        private string _MiddleName;
        public string LastName
        {
            get
            {
                return this._LastName;
            }
            set
            {
                this._LastName = value;
                this.OnPropertyChanged("LastName");
            }
        }
        private string _LastName;
        public string Suffix
        {
            get
            {
                return this._Suffix;
            }
            set
            {
                this._Suffix = value;
                this.OnPropertyChanged("Suffix");
            }
        }
        private string _Suffix;
        public int EmailPromotion
        {
            get
            {
                return this._EmailPromotion;
            }
            set
            {
                this._EmailPromotion = value;
                this.OnPropertyChanged("EmailPromotion");
            }
        }
        private int _EmailPromotion;
        public string AdditionalContactInfo
        {
            get
            {
                return this._AdditionalContactInfo;
            }
            set
            {
                this._AdditionalContactInfo = value;
                this.OnPropertyChanged("AdditionalContactInfo");
            }
        }
        private string _AdditionalContactInfo;
        public string Demographics
        {
            get
            {
                return this._Demographics;
            }
            set
            {
                this._Demographics = value;
                this.OnPropertyChanged("Demographics");
            }
        }
        private string _Demographics;
        public System.Guid rowguid
        {
            get
            {
                return this._rowguid;
            }
            set
            {
                this._rowguid = value;
                this.OnPropertyChanged("rowguid");
            }
        }
        private System.Guid _rowguid;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public BusinessEntity BusinessEntity
        {
            get
            {
                return this._BusinessEntity;
            }
            set
            {
                this._BusinessEntity = value;
                this.OnPropertyChanged("BusinessEntity");
            }
        }
        private BusinessEntity _BusinessEntity;
        public ObservableCollection<BusinessEntityContact> BusinessEntityContacts
        {
            get
            {
                return this._BusinessEntityContacts;
            }
            set
            {
                this._BusinessEntityContacts = value;
                this.OnPropertyChanged("BusinessEntityContacts");
            }
        }
        private ObservableCollection<BusinessEntityContact> _BusinessEntityContacts = new ObservableCollection<BusinessEntityContact>();
        public ObservableCollection<EmailAddress> EmailAddresses
        {
            get
            {
                return this._EmailAddresses;
            }
            set
            {
                this._EmailAddresses = value;
                this.OnPropertyChanged("EmailAddresses");
            }
        }
        private ObservableCollection<EmailAddress> _EmailAddresses = new ObservableCollection<EmailAddress>();
        public Password Password
        {
            get
            {
                return this._Password;
            }
            set
            {
                this._Password = value;
                this.OnPropertyChanged("Password");
            }
        }
        private Password _Password;
        public ObservableCollection<Customer> Customers
        {
            get
            {
                return this._Customers;
            }
            set
            {
                this._Customers = value;
                this.OnPropertyChanged("Customers");
            }
        }
        private ObservableCollection<Customer> _Customers = new ObservableCollection<Customer>();
        public ObservableCollection<PersonCreditCard> PersonCreditCards
        {
            get
            {
                return this._PersonCreditCards;
            }
            set
            {
                this._PersonCreditCards = value;
                this.OnPropertyChanged("PersonCreditCards");
            }
        }
        private ObservableCollection<PersonCreditCard> _PersonCreditCards = new ObservableCollection<PersonCreditCard>();
        public ObservableCollection<PersonPhone> PersonPhones
        {
            get
            {
                return this._PersonPhones;
            }
            set
            {
                this._PersonPhones = value;
                this.OnPropertyChanged("PersonPhones");
            }
        }
        private ObservableCollection<PersonPhone> _PersonPhones = new ObservableCollection<PersonPhone>();
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    public partial class PersonPhone : System.ComponentModel.INotifyPropertyChanged
    {
        public int BusinessEntityID
        {
            get
            {
                return this._BusinessEntityID;
            }
            set
            {
                this._BusinessEntityID = value;
                this.OnPropertyChanged("BusinessEntityID");
            }
        }
        private int _BusinessEntityID;
        public string PhoneNumber
        {
            get
            {
                return this._PhoneNumber;
            }
            set
            {
                this._PhoneNumber = value;
                this.OnPropertyChanged("PhoneNumber");
            }
        }
        private string _PhoneNumber;
        public int PhoneNumberTypeID
        {
            get
            {
                return this._PhoneNumberTypeID;
            }
            set
            {
                this._PhoneNumberTypeID = value;
                this.OnPropertyChanged("PhoneNumberTypeID");
            }
        }
        private int _PhoneNumberTypeID;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public Person Person
        {
            get
            {
                return this._Person;
            }
            set
            {
                this._Person = value;
                this.OnPropertyChanged("Person");
            }
        }
        private Person _Person;
        public PhoneNumberType PhoneNumberType
        {
            get
            {
                return this._PhoneNumberType;
            }
            set
            {
                this._PhoneNumberType = value;
                this.OnPropertyChanged("PhoneNumberType");
            }
        }
        private PhoneNumberType _PhoneNumberType;
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    public partial class PhoneNumberType : System.ComponentModel.INotifyPropertyChanged
    {
        public int PhoneNumberTypeID
        {
            get
            {
                return this._PhoneNumberTypeID;
            }
            set
            {
                this._PhoneNumberTypeID = value;
                this.OnPropertyChanged("PhoneNumberTypeID");
            }
        }
        private int _PhoneNumberTypeID;
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this._Name = value;
                this.OnPropertyChanged("Name");
            }
        }
        private string _Name;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public ObservableCollection<PersonPhone> PersonPhones
        {
            get
            {
                return this._PersonPhones;
            }
            set
            {
                this._PersonPhones = value;
                this.OnPropertyChanged("PersonPhones");
            }
        }
        private ObservableCollection<PersonPhone> _PersonPhones = new ObservableCollection<PersonPhone>();
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    public partial class StateProvince : System.ComponentModel.INotifyPropertyChanged
    {
        public int StateProvinceID
        {
            get
            {
                return this._StateProvinceID;
            }
            set
            {
                this._StateProvinceID = value;
                this.OnPropertyChanged("StateProvinceID");
            }
        }
        private int _StateProvinceID;
        public string StateProvinceCode
        {
            get
            {
                return this._StateProvinceCode;
            }
            set
            {
                this._StateProvinceCode = value;
                this.OnPropertyChanged("StateProvinceCode");
            }
        }
        private string _StateProvinceCode;
        public string CountryRegionCode
        {
            get
            {
                return this._CountryRegionCode;
            }
            set
            {
                this._CountryRegionCode = value;
                this.OnPropertyChanged("CountryRegionCode");
            }
        }
        private string _CountryRegionCode;
        public bool IsOnlyStateProvinceFlag
        {
            get
            {
                return this._IsOnlyStateProvinceFlag;
            }
            set
            {
                this._IsOnlyStateProvinceFlag = value;
                this.OnPropertyChanged("IsOnlyStateProvinceFlag");
            }
        }
        private bool _IsOnlyStateProvinceFlag;
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this._Name = value;
                this.OnPropertyChanged("Name");
            }
        }
        private string _Name;
        public int TerritoryID
        {
            get
            {
                return this._TerritoryID;
            }
            set
            {
                this._TerritoryID = value;
                this.OnPropertyChanged("TerritoryID");
            }
        }
        private int _TerritoryID;
        public System.Guid rowguid
        {
            get
            {
                return this._rowguid;
            }
            set
            {
                this._rowguid = value;
                this.OnPropertyChanged("rowguid");
            }
        }
        private System.Guid _rowguid;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public ObservableCollection<Address> Addresses
        {
            get
            {
                return this._Addresses;
            }
            set
            {
                this._Addresses = value;
                this.OnPropertyChanged("Addresses");
            }
        }
        private ObservableCollection<Address> _Addresses = new ObservableCollection<Address>();
        public CountryRegion CountryRegion
        {
            get
            {
                return this._CountryRegion;
            }
            set
            {
                this._CountryRegion = value;
                this.OnPropertyChanged("CountryRegion");
            }
        }
        private CountryRegion _CountryRegion;
        public ObservableCollection<SalesTaxRate> SalesTaxRates
        {
            get
            {
                return this._SalesTaxRates;
            }
            set
            {
                this._SalesTaxRates = value;
                this.OnPropertyChanged("SalesTaxRates");
            }
        }
        private ObservableCollection<SalesTaxRate> _SalesTaxRates = new ObservableCollection<SalesTaxRate>();
        public SalesTerritory SalesTerritory
        {
            get
            {
                return this._SalesTerritory;
            }
            set
            {
                this._SalesTerritory = value;
                this.OnPropertyChanged("SalesTerritory");
            }
        }
        private SalesTerritory _SalesTerritory;
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    public partial class BillOfMaterial : System.ComponentModel.INotifyPropertyChanged
    {
        public int BillOfMaterialsID
        {
            get
            {
                return this._BillOfMaterialsID;
            }
            set
            {
                this._BillOfMaterialsID = value;
                this.OnPropertyChanged("BillOfMaterialsID");
            }
        }
        private int _BillOfMaterialsID;
        public System.Nullable<int> ProductAssemblyID
        {
            get
            {
                return this._ProductAssemblyID;
            }
            set
            {
                this._ProductAssemblyID = value;
                this.OnProductAssemblyIDChanged();
                this.OnPropertyChanged("ProductAssemblyID");
            }
        }
        private System.Nullable<int> _ProductAssemblyID;
        public int ComponentID
        {
            get
            {
                return this._ComponentID;
            }
            set
            {
                this._ComponentID = value;
                this.OnComponentIDChanged();
                this.OnPropertyChanged("ComponentID");
            }
        }
        private int _ComponentID;
        public System.DateTime StartDate
        {
            get
            {
                return this._StartDate;
            }
            set
            {
                this._StartDate = value;
                this.OnPropertyChanged("StartDate");
            }
        }
        private System.DateTime _StartDate;
        public System.Nullable<System.DateTime> EndDate
        {
            get
            {
                return this._EndDate;
            }
            set
            {
                this._EndDate = value;
                this.OnPropertyChanged("EndDate");
            }
        }
        private System.Nullable<System.DateTime> _EndDate;
        public string UnitMeasureCode
        {
            get
            {
                return this._UnitMeasureCode;
            }
            set
            {
                this._UnitMeasureCode = value;
                this.OnUnitMeasureCodeChanged();
                this.OnPropertyChanged("UnitMeasureCode");
            }
        }
        private string _UnitMeasureCode;
        public short BOMLevel
        {
            get
            {
                return this._BOMLevel;
            }
            set
            {
                this.OnBOMLevelChanging(value);
                this._BOMLevel = value;
                this.OnPropertyChanged("BOMLevel");
            }
        }
        private short _BOMLevel;
        public decimal PerAssemblyQty
        {
            get
            {
                return this._PerAssemblyQty;
            }
            set
            {
                this._PerAssemblyQty = value;
                this.OnPropertyChanged("PerAssemblyQty");
            }
        }
        private decimal _PerAssemblyQty;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public Product Product
        {
            get
            {
                return this._Product;
            }
            set
            {
                this._Product = value;
                this.OnPropertyChanged("Product");
            }
        }
        private Product _Product;
        public Product Product1
        {
            get
            {
                return this._Product1;
            }
            set
            {
                this._Product1 = value;
                this.OnPropertyChanged("Product1");
            }
        }
        private Product _Product1;
        public UnitMeasure UnitMeasure
        {
            get
            {
                return this._UnitMeasure;
            }
            set
            {
                this._UnitMeasure = value;
                this.OnPropertyChanged("UnitMeasure");
            }
        }
        private UnitMeasure _UnitMeasure;
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }

        partial void OnComponentIDChanged();

        partial void OnProductAssemblyIDChanged();

        partial void OnBOMLevelChanging(short value);

        partial void OnUnitMeasureCodeChanged();
    }
    public partial class Culture : System.ComponentModel.INotifyPropertyChanged
    {
        public string CultureID
        {
            get
            {
                return this._CultureID;
            }
            set
            {
                this._CultureID = value;
                this.OnPropertyChanged("CultureID");
            }
        }
        private string _CultureID;
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this._Name = value;
                this.OnPropertyChanged("Name");
            }
        }
        private string _Name;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public ObservableCollection<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures
        {
            get
            {
                return this._ProductModelProductDescriptionCultures;
            }
            set
            {
                this._ProductModelProductDescriptionCultures = value;
                this.OnPropertyChanged("ProductModelProductDescriptionCultures");
            }
        }
        private ObservableCollection<ProductModelProductDescriptionCulture> _ProductModelProductDescriptionCultures = new ObservableCollection<ProductModelProductDescriptionCulture>();
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    public partial class Illustration : System.ComponentModel.INotifyPropertyChanged
    {
        public int IllustrationID
        {
            get
            {
                return this._IllustrationID;
            }
            set
            {
                this._IllustrationID = value;
                this.OnPropertyChanged("IllustrationID");
            }
        }
        private int _IllustrationID;
        public string Diagram
        {
            get
            {
                return this._Diagram;
            }
            set
            {
                this._Diagram = value;
                this.OnPropertyChanged("Diagram");
            }
        }
        private string _Diagram;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public ObservableCollection<ProductModelIllustration> ProductModelIllustrations
        {
            get
            {
                return this._ProductModelIllustrations;
            }
            set
            {
                this._ProductModelIllustrations = value;
                this.OnPropertyChanged("ProductModelIllustrations");
            }
        }
        private ObservableCollection<ProductModelIllustration> _ProductModelIllustrations = new ObservableCollection<ProductModelIllustration>();
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    public partial class Location : System.ComponentModel.INotifyPropertyChanged
    {
        public short LocationID
        {
            get
            {
                return this._LocationID;
            }
            set
            {
                this._LocationID = value;
                this.OnPropertyChanged("LocationID");
            }
        }
        private short _LocationID;
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this._Name = value;
                this.OnPropertyChanged("Name");
            }
        }
        private string _Name;
        public decimal CostRate
        {
            get
            {
                return this._CostRate;
            }
            set
            {
                this._CostRate = value;
                this.OnPropertyChanged("CostRate");
            }
        }
        private decimal _CostRate;
        public decimal Availability
        {
            get
            {
                return this._Availability;
            }
            set
            {
                this._Availability = value;
                this.OnPropertyChanged("Availability");
            }
        }
        private decimal _Availability;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public ObservableCollection<ProductInventory> ProductInventories
        {
            get
            {
                return this._ProductInventories;
            }
            set
            {
                this._ProductInventories = value;
                this.OnPropertyChanged("ProductInventories");
            }
        }
        private ObservableCollection<ProductInventory> _ProductInventories = new ObservableCollection<ProductInventory>();
        public ObservableCollection<WorkOrderRouting> WorkOrderRoutings
        {
            get
            {
                return this._WorkOrderRoutings;
            }
            set
            {
                this._WorkOrderRoutings = value;
                this.OnPropertyChanged("WorkOrderRoutings");
            }
        }
        private ObservableCollection<WorkOrderRouting> _WorkOrderRoutings = new ObservableCollection<WorkOrderRouting>();
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
        public override bool Equals(object obj)
        {
            if (obj != null && obj is Location location)
            {
                return this.LocationID == location.LocationID;
            }
            return base.Equals(obj);
        }
    }
    public partial class Product : System.ComponentModel.INotifyPropertyChanged
    {
        public int ProductID
        {
            get
            {
                return this._ProductID;
            }
            set
            {
                this._ProductID = value;
                this.OnPropertyChanged("ProductID");
            }
        }
        private int _ProductID;
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this._Name = value;
                this.OnPropertyChanged("Name");
            }
        }
        private string _Name;
        public string ProductNumber
        {
            get
            {
                return this._ProductNumber;
            }
            set
            {
                this._ProductNumber = value;
                this.OnPropertyChanged("ProductNumber");
            }
        }
        private string _ProductNumber;
        public bool MakeFlag
        {
            get
            {
                return this._MakeFlag;
            }
            set
            {
                this._MakeFlag = value;
                this.OnPropertyChanged("MakeFlag");
            }
        }
        private bool _MakeFlag;
        public bool FinishedGoodsFlag
        {
            get
            {
                return this._FinishedGoodsFlag;
            }
            set
            {
                this._FinishedGoodsFlag = value;
                this.OnPropertyChanged("FinishedGoodsFlag");
            }
        }
        private bool _FinishedGoodsFlag;
        public string Color
        {
            get
            {
                return this._Color;
            }
            set
            {
                this._Color = value;
                this.OnPropertyChanged("Color");
            }
        }
        private string _Color;
        public short SafetyStockLevel
        {
            get
            {
                return this._SafetyStockLevel;
            }
            set
            {
                this._SafetyStockLevel = value;
                this.OnPropertyChanged("SafetyStockLevel");
            }
        }
        private short _SafetyStockLevel;
        public short ReorderPoint
        {
            get
            {
                return this._ReorderPoint;
            }
            set
            {
                this._ReorderPoint = value;
                this.OnPropertyChanged("ReorderPoint");
            }
        }
        private short _ReorderPoint;
        public decimal StandardCost
        {
            get
            {
                return this._StandardCost;
            }
            set
            {
                this._StandardCost = value;
                this.OnPropertyChanged("StandardCost");
            }
        }
        private decimal _StandardCost;
        public decimal ListPrice
        {
            get
            {
                return this._ListPrice;
            }
            set
            {
                this._ListPrice = value;
                this.OnPropertyChanged("ListPrice");
            }
        }
        private decimal _ListPrice;
        public string Size
        {
            get
            {
                return this._Size;
            }
            set
            {
                this._Size = value;
                this.OnPropertyChanged("Size");
            }
        }
        private string _Size;
        public string SizeUnitMeasureCode
        {
            get
            {
                return this._SizeUnitMeasureCode;
            }
            set
            {
                this._SizeUnitMeasureCode = value;
                this.OnPropertyChanged("SizeUnitMeasureCode");
            }
        }
        private string _SizeUnitMeasureCode;
        public string WeightUnitMeasureCode
        {
            get
            {
                return this._WeightUnitMeasureCode;
            }
            set
            {
                this._WeightUnitMeasureCode = value;
                this.OnPropertyChanged("WeightUnitMeasureCode");
            }
        }
        private string _WeightUnitMeasureCode;
        public System.Nullable<decimal> Weight
        {
            get
            {
                return this._Weight;
            }
            set
            {
                this._Weight = value;
                this.OnPropertyChanged("Weight");
            }
        }
        private System.Nullable<decimal> _Weight;
        public int DaysToManufacture
        {
            get
            {
                return this._DaysToManufacture;
            }
            set
            {
                this._DaysToManufacture = value;
                this.OnPropertyChanged("DaysToManufacture");
            }
        }
        private int _DaysToManufacture;
        public string ProductLine
        {
            get
            {
                return this._ProductLine;
            }
            set
            {
                this._ProductLine = value;
                this.OnPropertyChanged("ProductLine");
            }
        }
        private string _ProductLine;
        public string Class
        {
            get
            {
                return this._Class;
            }
            set
            {
                this._Class = value;
                this.OnPropertyChanged("Class");
            }
        }
        private string _Class;
        public string Style
        {
            get
            {
                return this._Style;
            }
            set
            {
                this._Style = value;
                this.OnPropertyChanged("Style");
            }
        }
        private string _Style;
        public System.Nullable<int> ProductSubcategoryID
        {
            get
            {
                return this._ProductSubcategoryID;
            }
            set
            {
                this._ProductSubcategoryID = value;
                this.OnPropertyChanged("ProductSubcategoryID");
            }
        }
        private System.Nullable<int> _ProductSubcategoryID;
        public System.Nullable<int> ProductModelID
        {
            get
            {
                return this._ProductModelID;
            }
            set
            {
                this._ProductModelID = value;
                this.OnPropertyChanged("ProductModelID");
            }
        }
        private System.Nullable<int> _ProductModelID;
        public System.DateTime SellStartDate
        {
            get
            {
                return this._SellStartDate;
            }
            set
            {
                this._SellStartDate = value;
                this.OnPropertyChanged("SellStartDate");
            }
        }
        private System.DateTime _SellStartDate;
        public System.Nullable<System.DateTime> SellEndDate
        {
            get
            {
                return this._SellEndDate;
            }
            set
            {
                this._SellEndDate = value;
                this.OnPropertyChanged("SellEndDate");
            }
        }
        private System.Nullable<System.DateTime> _SellEndDate;
        public System.Nullable<System.DateTime> DiscontinuedDate
        {
            get
            {
                return this._DiscontinuedDate;
            }
            set
            {
                this._DiscontinuedDate = value;
                this.OnPropertyChanged("DiscontinuedDate");
            }
        }
        private System.Nullable<System.DateTime> _DiscontinuedDate;
        public System.Guid rowguid
        {
            get
            {
                return this._rowguid;
            }
            set
            {
                this._rowguid = value;
                this.OnPropertyChanged("rowguid");
            }
        }
        private System.Guid _rowguid;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public ObservableCollection<BillOfMaterial> BillOfMaterials
        {
            get
            {
                return this._BillOfMaterials;
            }
            set
            {
                this._BillOfMaterials = value;
                this.OnPropertyChanged("BillOfMaterials");
            }
        }
        private ObservableCollection<BillOfMaterial> _BillOfMaterials = new ObservableCollection<BillOfMaterial>();
        public ObservableCollection<BillOfMaterial> BillOfMaterials1
        {
            get
            {
                return this._BillOfMaterials1;
            }
            set
            {
                this._BillOfMaterials1 = value;
                this.OnPropertyChanged("BillOfMaterials1");
            }
        }
        private ObservableCollection<BillOfMaterial> _BillOfMaterials1 = new ObservableCollection<BillOfMaterial>();
        public ProductModel ProductModel
        {
            get
            {
                return this._ProductModel;
            }
            set
            {
                this._ProductModel = value;
                this.OnPropertyChanged("ProductModel");
            }
        }
        private ProductModel _ProductModel;
        public ProductSubcategory ProductSubcategory
        {
            get
            {
                return this._ProductSubcategory;
            }
            set
            {
                this._ProductSubcategory = value;
                this.OnPropertyChanged("ProductSubcategory");
            }
        }
        private ProductSubcategory _ProductSubcategory;
        public UnitMeasure UnitMeasure
        {
            get
            {
                return this._UnitMeasure;
            }
            set
            {
                this._UnitMeasure = value;
                this.OnPropertyChanged("UnitMeasure");
            }
        }
        private UnitMeasure _UnitMeasure;
        public UnitMeasure UnitMeasure1
        {
            get
            {
                return this._UnitMeasure1;
            }
            set
            {
                this._UnitMeasure1 = value;
                this.OnPropertyChanged("UnitMeasure1");
            }
        }
        private UnitMeasure _UnitMeasure1;
        public ObservableCollection<ProductCostHistory> ProductCostHistories
        {
            get
            {
                return this._ProductCostHistories;
            }
            set
            {
                this._ProductCostHistories = value;
                this.OnPropertyChanged("ProductCostHistories");
            }
        }
        private ObservableCollection<ProductCostHistory> _ProductCostHistories = new ObservableCollection<ProductCostHistory>();
        public ProductDocument ProductDocument
        {
            get
            {
                return this._ProductDocument;
            }
            set
            {
                this._ProductDocument = value;
                this.OnPropertyChanged("ProductDocument");
            }
        }
        private ProductDocument _ProductDocument;
        public ObservableCollection<ProductInventory> ProductInventories
        {
            get
            {
                return this._ProductInventories;
            }
            set
            {
                this._ProductInventories = value;
                this.OnPropertyChanged("ProductInventories");
            }
        }
        private ObservableCollection<ProductInventory> _ProductInventories = new ObservableCollection<ProductInventory>();
        public ObservableCollection<ProductListPriceHistory> ProductListPriceHistories
        {
            get
            {
                return this._ProductListPriceHistories;
            }
            set
            {
                this._ProductListPriceHistories = value;
                this.OnPropertyChanged("ProductListPriceHistories");
            }
        }
        private ObservableCollection<ProductListPriceHistory> _ProductListPriceHistories = new ObservableCollection<ProductListPriceHistory>();
        public ObservableCollection<ProductProductPhoto> ProductProductPhotoes
        {
            get
            {
                return this._ProductProductPhotoes;
            }
            set
            {
                this._ProductProductPhotoes = value;
                this.OnPropertyChanged("ProductProductPhotoes");
            }
        }
        private ObservableCollection<ProductProductPhoto> _ProductProductPhotoes = new ObservableCollection<ProductProductPhoto>();
        public ObservableCollection<ProductReview> ProductReviews
        {
            get
            {
                return this._ProductReviews;
            }
            set
            {
                this._ProductReviews = value;
                this.OnPropertyChanged("ProductReviews");
            }
        }
        private ObservableCollection<ProductReview> _ProductReviews = new ObservableCollection<ProductReview>();
        public ObservableCollection<ProductVendor> ProductVendors
        {
            get
            {
                return this._ProductVendors;
            }
            set
            {
                this._ProductVendors = value;
                this.OnPropertyChanged("ProductVendors");
            }
        }
        private ObservableCollection<ProductVendor> _ProductVendors = new ObservableCollection<ProductVendor>();
        public ObservableCollection<PurchaseOrderDetail> PurchaseOrderDetails
        {
            get
            {
                return this._PurchaseOrderDetails;
            }
            set
            {
                this._PurchaseOrderDetails = value;
                this.OnPropertyChanged("PurchaseOrderDetails");
            }
        }
        private ObservableCollection<PurchaseOrderDetail> _PurchaseOrderDetails = new ObservableCollection<PurchaseOrderDetail>();
        public ObservableCollection<ShoppingCartItem> ShoppingCartItems
        {
            get
            {
                return this._ShoppingCartItems;
            }
            set
            {
                this._ShoppingCartItems = value;
                this.OnPropertyChanged("ShoppingCartItems");
            }
        }
        private ObservableCollection<ShoppingCartItem> _ShoppingCartItems = new ObservableCollection<ShoppingCartItem>();
        public ObservableCollection<SpecialOfferProduct> SpecialOfferProducts
        {
            get
            {
                return this._SpecialOfferProducts;
            }
            set
            {
                this._SpecialOfferProducts = value;
                this.OnPropertyChanged("SpecialOfferProducts");
            }
        }
        private ObservableCollection<SpecialOfferProduct> _SpecialOfferProducts = new ObservableCollection<SpecialOfferProduct>();
        public ObservableCollection<TransactionHistory> TransactionHistories
        {
            get
            {
                return this._TransactionHistories;
            }
            set
            {
                this._TransactionHistories = value;
                this.OnPropertyChanged("TransactionHistories");
            }
        }
        private ObservableCollection<TransactionHistory> _TransactionHistories = new ObservableCollection<TransactionHistory>();
        public ObservableCollection<WorkOrder> WorkOrders
        {
            get
            {
                return this._WorkOrders;
            }
            set
            {
                this._WorkOrders = value;
                this.OnPropertyChanged("WorkOrders");
            }
        }
        private ObservableCollection<WorkOrder> _WorkOrders = new ObservableCollection<WorkOrder>();
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
        public override bool Equals(object obj)
        {
            if (obj != null && obj is Product product)
            {
                return this.ProductID == product.ProductID ;
            }
         
            if (obj != null && int.TryParse(obj.ToString(), out int number))
            {
                return number == this.ProductID;
            }
            return base.Equals(obj);
        }
    }
    public partial class ProductCategory : System.ComponentModel.INotifyPropertyChanged
    {
        public int ProductCategoryID
        {
            get
            {
                return this._ProductCategoryID;
            }
            set
            {
                this._ProductCategoryID = value;
                this.OnPropertyChanged("ProductCategoryID");
            }
        }
        private int _ProductCategoryID;
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this._Name = value;
                this.OnPropertyChanged("Name");
            }
        }
        private string _Name;
        public System.Guid rowguid
        {
            get
            {
                return this._rowguid;
            }
            set
            {
                this._rowguid = value;
                this.OnPropertyChanged("rowguid");
            }
        }
        private System.Guid _rowguid;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public ObservableCollection<ProductSubcategory> ProductSubcategories
        {
            get
            {
                return this._ProductSubcategories;
            }
            set
            {
                this._ProductSubcategories = value;
                this.OnPropertyChanged("ProductSubcategories");
            }
        }
        private ObservableCollection<ProductSubcategory> _ProductSubcategories = new ObservableCollection<ProductSubcategory>();
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    public partial class ProductCostHistory : System.ComponentModel.INotifyPropertyChanged
    {
        public int ProductID
        {
            get
            {
                return this._ProductID;
            }
            set
            {
                this._ProductID = value;
                this.OnPropertyChanged("ProductID");
            }
        }
        private int _ProductID;
        public System.DateTime StartDate
        {
            get
            {
                return this._StartDate;
            }
            set
            {
                this._StartDate = value;
                this.OnPropertyChanged("StartDate");
            }
        }
        private System.DateTime _StartDate;
        public System.Nullable<System.DateTime> EndDate
        {
            get
            {
                return this._EndDate;
            }
            set
            {
                this._EndDate = value;
                this.OnPropertyChanged("EndDate");
            }
        }
        private System.Nullable<System.DateTime> _EndDate;
        public decimal StandardCost
        {
            get
            {
                return this._StandardCost;
            }
            set
            {
                this._StandardCost = value;
                this.OnPropertyChanged("StandardCost");
            }
        }
        private decimal _StandardCost;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public Product Product
        {
            get
            {
                return this._Product;
            }
            set
            {
                this._Product = value;
                this.OnPropertyChanged("Product");
            }
        }
        private Product _Product;
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    public partial class ProductDescription : System.ComponentModel.INotifyPropertyChanged
    {
        public int ProductDescriptionID
        {
            get
            {
                return this._ProductDescriptionID;
            }
            set
            {
                this._ProductDescriptionID = value;
                this.OnPropertyChanged("ProductDescriptionID");
            }
        }
        private int _ProductDescriptionID;
        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this._Description = value;
                this.OnPropertyChanged("Description");
            }
        }
        private string _Description;
        public System.Guid rowguid
        {
            get
            {
                return this._rowguid;
            }
            set
            {
                this._rowguid = value;
                this.OnPropertyChanged("rowguid");
            }
        }
        private System.Guid _rowguid;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public ObservableCollection<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures
        {
            get
            {
                return this._ProductModelProductDescriptionCultures;
            }
            set
            {
                this._ProductModelProductDescriptionCultures = value;
                this.OnPropertyChanged("ProductModelProductDescriptionCultures");
            }
        }
        private ObservableCollection<ProductModelProductDescriptionCulture> _ProductModelProductDescriptionCultures = new ObservableCollection<ProductModelProductDescriptionCulture>();
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    public partial class ProductInventory : System.ComponentModel.INotifyPropertyChanged
    {
        public int ProductID
        {
            get
            {
                return this._ProductID;
            }
            set
            {
                this._ProductID = value;
                this.OnProductIDChanged();
                this.OnPropertyChanged("ProductID");
            }
        }
        private int _ProductID;
        public short LocationID
        {
            get
            {
                return this._LocationID;
            }
            set
            {
                this._LocationID = value;
                this.OnLocationIDChanged();
                this.OnPropertyChanged("LocationID");
            }
        }
        private short _LocationID;
        public string Shelf
        {
            get
            {
                return this._Shelf;
            }
            set
            {
                this.OnShelfChanging(value);
                this._Shelf = value;
                this.OnPropertyChanged("Shelf");
            }
        }
        private string _Shelf;
        public byte Bin
        {
            get
            {
                return this._Bin;
            }
            set
            {
                this.OnBinChanging(value);
                this._Bin = value;
                this.OnPropertyChanged("Bin");
            }
        }
        private byte _Bin;
        public short Quantity
        {
            get
            {
                return this._Quantity;
            }
            set
            {
                this._Quantity = value;
                this.OnPropertyChanged("Quantity");
            }
        }
        private short _Quantity;
        public System.Guid rowguid
        {
            get
            {
                return this._rowguid;
            }
            set
            {
                this._rowguid = value;
                this.OnPropertyChanged("rowguid");
            }
        }
        private System.Guid _rowguid;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public Location Location
        {
            get
            {
                return this._Location;
            }
            set
            {
                this._Location = value;
                this.OnPropertyChanged("Location");
            }
        }
        private Location _Location;
        public Product Product
        {
            get
            {
                return this._Product;
            }
            set
            {
                this._Product = value;
                this.OnPropertyChanged("Product");
            }
        }
        private Product _Product;
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }

        partial void OnProductIDChanged();

        partial void OnLocationIDChanged();

        partial void OnBinChanging(byte value);

        partial void OnShelfChanging(string value);
    }
    public partial class ProductListPriceHistory : System.ComponentModel.INotifyPropertyChanged
    {
        public int ProductID
        {
            get
            {
                return this._ProductID;
            }
            set
            {
                this._ProductID = value;
                this.OnPropertyChanged("ProductID");
            }
        }
        private int _ProductID;
        public System.DateTime StartDate
        {
            get
            {
                return this._StartDate;
            }
            set
            {
                this._StartDate = value;
                this.OnPropertyChanged("StartDate");
            }
        }
        private System.DateTime _StartDate;
        public System.Nullable<System.DateTime> EndDate
        {
            get
            {
                return this._EndDate;
            }
            set
            {
                this._EndDate = value;
                this.OnPropertyChanged("EndDate");
            }
        }
        private System.Nullable<System.DateTime> _EndDate;
        public decimal ListPrice
        {
            get
            {
                return this._ListPrice;
            }
            set
            {
                this._ListPrice = value;
                this.OnPropertyChanged("ListPrice");
            }
        }
        private decimal _ListPrice;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public Product Product
        {
            get
            {
                return this._Product;
            }
            set
            {
                this._Product = value;
                this.OnPropertyChanged("Product");
            }
        }
        private Product _Product;
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    public partial class ProductModel : System.ComponentModel.INotifyPropertyChanged
    {
        public int ProductModelID
        {
            get
            {
                return this._ProductModelID;
            }
            set
            {
                this._ProductModelID = value;
                this.OnPropertyChanged("ProductModelID");
            }
        }
        private int _ProductModelID;
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this._Name = value;
                this.OnPropertyChanged("Name");
            }
        }
        private string _Name;
        public string CatalogDescription
        {
            get
            {
                return this._CatalogDescription;
            }
            set
            {
                this._CatalogDescription = value;
                this.OnPropertyChanged("CatalogDescription");
            }
        }
        private string _CatalogDescription;
        public string Instructions
        {
            get
            {
                return this._Instructions;
            }
            set
            {
                this._Instructions = value;
                this.OnPropertyChanged("Instructions");
            }
        }
        private string _Instructions;
        public System.Guid rowguid
        {
            get
            {
                return this._rowguid;
            }
            set
            {
                this._rowguid = value;
                this.OnPropertyChanged("rowguid");
            }
        }
        private System.Guid _rowguid;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public ObservableCollection<Product> Products
        {
            get
            {
                return this._Products;
            }
            set
            {
                this._Products = value;
                this.OnPropertyChanged("Products");
            }
        }
        private ObservableCollection<Product> _Products = new ObservableCollection<Product>();
        public ObservableCollection<ProductModelIllustration> ProductModelIllustrations
        {
            get
            {
                return this._ProductModelIllustrations;
            }
            set
            {
                this._ProductModelIllustrations = value;
                this.OnPropertyChanged("ProductModelIllustrations");
            }
        }
        private ObservableCollection<ProductModelIllustration> _ProductModelIllustrations = new ObservableCollection<ProductModelIllustration>();
        public ObservableCollection<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures
        {
            get
            {
                return this._ProductModelProductDescriptionCultures;
            }
            set
            {
                this._ProductModelProductDescriptionCultures = value;
                this.OnPropertyChanged("ProductModelProductDescriptionCultures");
            }
        }
        private ObservableCollection<ProductModelProductDescriptionCulture> _ProductModelProductDescriptionCultures = new ObservableCollection<ProductModelProductDescriptionCulture>();
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    public partial class ProductModelIllustration : System.ComponentModel.INotifyPropertyChanged
    {
        public int ProductModelID
        {
            get
            {
                return this._ProductModelID;
            }
            set
            {
                this._ProductModelID = value;
                this.OnPropertyChanged("ProductModelID");
            }
        }
        private int _ProductModelID;
        public int IllustrationID
        {
            get
            {
                return this._IllustrationID;
            }
            set
            {
                this._IllustrationID = value;
                this.OnPropertyChanged("IllustrationID");
            }
        }
        private int _IllustrationID;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public Illustration Illustration
        {
            get
            {
                return this._Illustration;
            }
            set
            {
                this._Illustration = value;
                this.OnPropertyChanged("Illustration");
            }
        }
        private Illustration _Illustration;
        public ProductModel ProductModel
        {
            get
            {
                return this._ProductModel;
            }
            set
            {
                this._ProductModel = value;
                this.OnPropertyChanged("ProductModel");
            }
        }
        private ProductModel _ProductModel;
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    public partial class ProductModelProductDescriptionCulture : System.ComponentModel.INotifyPropertyChanged
    {
        public int ProductModelID
        {
            get
            {
                return this._ProductModelID;
            }
            set
            {
                this._ProductModelID = value;
                this.OnPropertyChanged("ProductModelID");
            }
        }
        private int _ProductModelID;
        public int ProductDescriptionID
        {
            get
            {
                return this._ProductDescriptionID;
            }
            set
            {
                this._ProductDescriptionID = value;
                this.OnPropertyChanged("ProductDescriptionID");
            }
        }
        private int _ProductDescriptionID;
        public string CultureID
        {
            get
            {
                return this._CultureID;
            }
            set
            {
                this._CultureID = value;
                this.OnPropertyChanged("CultureID");
            }
        }
        private string _CultureID;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public Culture Culture
        {
            get
            {
                return this._Culture;
            }
            set
            {
                this._Culture = value;
                this.OnPropertyChanged("Culture");
            }
        }
        private Culture _Culture;
        public ProductDescription ProductDescription
        {
            get
            {
                return this._ProductDescription;
            }
            set
            {
                this._ProductDescription = value;
                this.OnPropertyChanged("ProductDescription");
            }
        }
        private ProductDescription _ProductDescription;
        public ProductModel ProductModel
        {
            get
            {
                return this._ProductModel;
            }
            set
            {
                this._ProductModel = value;
                this.OnPropertyChanged("ProductModel");
            }
        }
        private ProductModel _ProductModel;
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    public partial class ProductPhoto : System.ComponentModel.INotifyPropertyChanged
    {
        public int ProductPhotoID
        {
            get
            {
                return this._ProductPhotoID;
            }
            set
            {
                this._ProductPhotoID = value;
                this.OnPropertyChanged("ProductPhotoID");
            }
        }
        private int _ProductPhotoID;
        public byte[] ThumbNailPhoto
        {
            get
            {
                if ((this._ThumbNailPhoto != null))
                {
                    return ((byte[])(this._ThumbNailPhoto.Clone()));
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this._ThumbNailPhoto = value;
                this.OnPropertyChanged("ThumbNailPhoto");
            }
        }
        private byte[] _ThumbNailPhoto;
        public string ThumbnailPhotoFileName
        {
            get
            {
                return this._ThumbnailPhotoFileName;
            }
            set
            {
                this._ThumbnailPhotoFileName = value;
                this.OnPropertyChanged("ThumbnailPhotoFileName");
            }
        }
        private string _ThumbnailPhotoFileName;
        public byte[] LargePhoto
        {
            get
            {
                if ((this._LargePhoto != null))
                {
                    return ((byte[])(this._LargePhoto.Clone()));
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this._LargePhoto = value;
                this.OnPropertyChanged("LargePhoto");
            }
        }
        private byte[] _LargePhoto;
        public string LargePhotoFileName
        {
            get
            {
                return this._LargePhotoFileName;
            }
            set
            {
                this._LargePhotoFileName = value;
                this.OnPropertyChanged("LargePhotoFileName");
            }
        }
        private string _LargePhotoFileName;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public ObservableCollection<ProductProductPhoto> ProductProductPhotoes
        {
            get
            {
                return this._ProductProductPhotoes;
            }
            set
            {
                this._ProductProductPhotoes = value;
                this.OnPropertyChanged("ProductProductPhotoes");
            }
        }
        private ObservableCollection<ProductProductPhoto> _ProductProductPhotoes = new ObservableCollection<ProductProductPhoto>();
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    public partial class ProductProductPhoto : System.ComponentModel.INotifyPropertyChanged
    {
        public int ProductID
        {
            get
            {
                return this._ProductID;
            }
            set
            {
                this._ProductID = value;
                this.OnPropertyChanged("ProductID");
            }
        }
        private int _ProductID;
        public int ProductPhotoID
        {
            get
            {
                return this._ProductPhotoID;
            }
            set
            {
                this._ProductPhotoID = value;
                this.OnPropertyChanged("ProductPhotoID");
            }
        }
        private int _ProductPhotoID;
        public bool Primary
        {
            get
            {
                return this._Primary;
            }
            set
            {
                this._Primary = value;
                this.OnPropertyChanged("Primary");
            }
        }
        private bool _Primary;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public Product Product
        {
            get
            {
                return this._Product;
            }
            set
            {
                this._Product = value;
                this.OnPropertyChanged("Product");
            }
        }
        private Product _Product;
        public ProductPhoto ProductPhoto
        {
            get
            {
                return this._ProductPhoto;
            }
            set
            {
                this._ProductPhoto = value;
                this.OnPropertyChanged("ProductPhoto");
            }
        }
        private ProductPhoto _ProductPhoto;
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    public partial class ProductReview : System.ComponentModel.INotifyPropertyChanged
    {
        public int ProductReviewID
        {
            get
            {
                return this._ProductReviewID;
            }
            set
            {
                this._ProductReviewID = value;
                this.OnPropertyChanged("ProductReviewID");
            }
        }
        private int _ProductReviewID;
        public int ProductID
        {
            get
            {
                return this._ProductID;
            }
            set
            {
                this._ProductID = value;
                this.OnPropertyChanged("ProductID");
            }
        }
        private int _ProductID;
        public string ReviewerName
        {
            get
            {
                return this._ReviewerName;
            }
            set
            {
                this._ReviewerName = value;
                this.OnPropertyChanged("ReviewerName");
            }
        }
        private string _ReviewerName;
        public System.DateTime ReviewDate
        {
            get
            {
                return this._ReviewDate;
            }
            set
            {
                this._ReviewDate = value;
                this.OnPropertyChanged("ReviewDate");
            }
        }
        private System.DateTime _ReviewDate;
        public string EmailAddress
        {
            get
            {
                return this._EmailAddress;
            }
            set
            {
                this._EmailAddress = value;
                this.OnPropertyChanged("EmailAddress");
            }
        }
        private string _EmailAddress;
        public int Rating
        {
            get
            {
                return this._Rating;
            }
            set
            {
                this._Rating = value;
                this.OnPropertyChanged("Rating");
            }
        }
        private int _Rating;
        public string Comments
        {
            get
            {
                return this._Comments;
            }
            set
            {
                this._Comments = value;
                this.OnPropertyChanged("Comments");
            }
        }
        private string _Comments;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public Product Product
        {
            get
            {
                return this._Product;
            }
            set
            {
                this._Product = value;
                this.OnPropertyChanged("Product");
            }
        }
        private Product _Product;
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    public partial class ProductSubcategory : System.ComponentModel.INotifyPropertyChanged
    {
        public int ProductSubcategoryID
        {
            get
            {
                return this._ProductSubcategoryID;
            }
            set
            {
                this._ProductSubcategoryID = value;
                this.OnPropertyChanged("ProductSubcategoryID");
            }
        }
        private int _ProductSubcategoryID;
        public int ProductCategoryID
        {
            get
            {
                return this._ProductCategoryID;
            }
            set
            {
                this._ProductCategoryID = value;
                this.OnPropertyChanged("ProductCategoryID");
            }
        }
        private int _ProductCategoryID;
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this._Name = value;
                this.OnPropertyChanged("Name");
            }
        }
        private string _Name;
        public System.Guid rowguid
        {
            get
            {
                return this._rowguid;
            }
            set
            {
                this._rowguid = value;
                this.OnPropertyChanged("rowguid");
            }
        }
        private System.Guid _rowguid;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public ObservableCollection<Product> Products
        {
            get
            {
                return this._Products;
            }
            set
            {
                this._Products = value;
                this.OnPropertyChanged("Products");
            }
        }
        private ObservableCollection<Product> _Products = new ObservableCollection<Product>();
        public ProductCategory ProductCategory
        {
            get
            {
                return this._ProductCategory;
            }
            set
            {
                this._ProductCategory = value;
                this.OnPropertyChanged("ProductCategory");
            }
        }
        private ProductCategory _ProductCategory;
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    public partial class ScrapReason : System.ComponentModel.INotifyPropertyChanged
    {
        public short ScrapReasonID
        {
            get
            {
                return this._ScrapReasonID;
            }
            set
            {
                this._ScrapReasonID = value;
                this.OnPropertyChanged("ScrapReasonID");
            }
        }
        private short _ScrapReasonID;
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this._Name = value;
                this.OnPropertyChanged("Name");
            }
        }
        private string _Name;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public ObservableCollection<WorkOrder> WorkOrders
        {
            get
            {
                return this._WorkOrders;
            }
            set
            {
                this._WorkOrders = value;
                this.OnPropertyChanged("WorkOrders");
            }
        }
        private ObservableCollection<WorkOrder> _WorkOrders = new ObservableCollection<WorkOrder>();
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    public partial class TransactionHistory : System.ComponentModel.INotifyPropertyChanged
    {
        public int TransactionID
        {
            get
            {
                return this._TransactionID;
            }
            set
            {
                this._TransactionID = value;
                this.OnPropertyChanged("TransactionID");
            }
        }
        private int _TransactionID;
        public int ProductID
        {
            get
            {
                return this._ProductID;
            }
            set
            {
                this._ProductID = value;
                this.OnPropertyChanged("ProductID");
            }
        }
        private int _ProductID;
        public int ReferenceOrderID
        {
            get
            {
                return this._ReferenceOrderID;
            }
            set
            {
                this._ReferenceOrderID = value;
                this.OnPropertyChanged("ReferenceOrderID");
            }
        }
        private int _ReferenceOrderID;
        public int ReferenceOrderLineID
        {
            get
            {
                return this._ReferenceOrderLineID;
            }
            set
            {
                this._ReferenceOrderLineID = value;
                this.OnPropertyChanged("ReferenceOrderLineID");
            }
        }
        private int _ReferenceOrderLineID;
        public System.DateTime TransactionDate
        {
            get
            {
                return this._TransactionDate;
            }
            set
            {
                this._TransactionDate = value;
                this.OnPropertyChanged("TransactionDate");
            }
        }
        private System.DateTime _TransactionDate;
        public string TransactionType
        {
            get
            {
                return this._TransactionType;
            }
            set
            {
                this._TransactionType = value;
                this.OnPropertyChanged("TransactionType");
            }
        }
        private string _TransactionType;
        public int Quantity
        {
            get
            {
                return this._Quantity;
            }
            set
            {
                this._Quantity = value;
                this.OnPropertyChanged("Quantity");
            }
        }
        private int _Quantity;
        public decimal ActualCost
        {
            get
            {
                return this._ActualCost;
            }
            set
            {
                this._ActualCost = value;
                this.OnPropertyChanged("ActualCost");
            }
        }
        private decimal _ActualCost;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public Product Product
        {
            get
            {
                return this._Product;
            }
            set
            {
                this._Product = value;
                this.OnPropertyChanged("Product");
            }
        }
        private Product _Product;
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    public partial class TransactionHistoryArchive : System.ComponentModel.INotifyPropertyChanged
    {
        public int TransactionID
        {
            get
            {
                return this._TransactionID;
            }
            set
            {
                this._TransactionID = value;
                this.OnPropertyChanged("TransactionID");
            }
        }
        private int _TransactionID;
        public int ProductID
        {
            get
            {
                return this._ProductID;
            }
            set
            {
                this._ProductID = value;
                this.OnPropertyChanged("ProductID");
            }
        }
        private int _ProductID;
        public int ReferenceOrderID
        {
            get
            {
                return this._ReferenceOrderID;
            }
            set
            {
                this._ReferenceOrderID = value;
                this.OnPropertyChanged("ReferenceOrderID");
            }
        }
        private int _ReferenceOrderID;
        public int ReferenceOrderLineID
        {
            get
            {
                return this._ReferenceOrderLineID;
            }
            set
            {
                this._ReferenceOrderLineID = value;
                this.OnPropertyChanged("ReferenceOrderLineID");
            }
        }
        private int _ReferenceOrderLineID;
        public System.DateTime TransactionDate
        {
            get
            {
                return this._TransactionDate;
            }
            set
            {
                this._TransactionDate = value;
                this.OnPropertyChanged("TransactionDate");
            }
        }
        private System.DateTime _TransactionDate;
        public string TransactionType
        {
            get
            {
                return this._TransactionType;
            }
            set
            {
                this._TransactionType = value;
                this.OnPropertyChanged("TransactionType");
            }
        }
        private string _TransactionType;
        public int Quantity
        {
            get
            {
                return this._Quantity;
            }
            set
            {
                this._Quantity = value;
                this.OnPropertyChanged("Quantity");
            }
        }
        private int _Quantity;
        public decimal ActualCost
        {
            get
            {
                return this._ActualCost;
            }
            set
            {
                this._ActualCost = value;
                this.OnPropertyChanged("ActualCost");
            }
        }
        private decimal _ActualCost;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    public partial class UnitMeasure : System.ComponentModel.INotifyPropertyChanged
    {
        public string UnitMeasureCode
        {
            get
            {
                return this._UnitMeasureCode;
            }
            set
            {
                this._UnitMeasureCode = value;
                this.OnPropertyChanged("UnitMeasureCode");
            }
        }
        private string _UnitMeasureCode;
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this._Name = value;
                this.OnPropertyChanged("Name");
            }
        }
        private string _Name;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public ObservableCollection<BillOfMaterial> BillOfMaterials
        {
            get
            {
                return this._BillOfMaterials;
            }
            set
            {
                this._BillOfMaterials = value;
                this.OnPropertyChanged("BillOfMaterials");
            }
        }
        private ObservableCollection<BillOfMaterial> _BillOfMaterials = new ObservableCollection<BillOfMaterial>();
        public ObservableCollection<Product> Products
        {
            get
            {
                return this._Products;
            }
            set
            {
                this._Products = value;
                this.OnPropertyChanged("Products");
            }
        }
        private ObservableCollection<Product> _Products = new ObservableCollection<Product>();
        public ObservableCollection<Product> Products1
        {
            get
            {
                return this._Products1;
            }
            set
            {
                this._Products1 = value;
                this.OnPropertyChanged("Products1");
            }
        }
        private ObservableCollection<Product> _Products1 = new ObservableCollection<Product>();
        public ObservableCollection<ProductVendor> ProductVendors
        {
            get
            {
                return this._ProductVendors;
            }
            set
            {
                this._ProductVendors = value;
                this.OnPropertyChanged("ProductVendors");
            }
        }
        private ObservableCollection<ProductVendor> _ProductVendors = new ObservableCollection<ProductVendor>();
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
        public override bool Equals(object obj)
        {
            if (obj != null && obj is UnitMeasure unitMeasure)
            {
                return this.UnitMeasureCode == unitMeasure.UnitMeasureCode.ToString();
            }
            if (obj != null && !string.IsNullOrEmpty(obj.ToString()))
            {
                return this.UnitMeasureCode == obj.ToString() || this.Name == obj.ToString();
            }


            return base.Equals(obj);
        }
    }
    public partial class WorkOrder : System.ComponentModel.INotifyPropertyChanged
    {
        public int WorkOrderID
        {
            get
            {
                return this._WorkOrderID;
            }
            set
            {
                this._WorkOrderID = value;
                this.OnPropertyChanged("WorkOrderID");
            }
        }
        private int _WorkOrderID;
        public int ProductID
        {
            get
            {
                return this._ProductID;
            }
            set
            {
                this._ProductID = value;
                this.OnProductIDChanged();
                this.OnPropertyChanged("ProductID");
            }
        }
        private int _ProductID;
        public int OrderQty
        {
            get
            {
                return this._OrderQty;
            }
            set
            {
                this._OrderQty = value;
                this.OnPropertyChanged("OrderQty");
            }
        }
        private int _OrderQty;
        public int StockedQty
        {
            get
            {
                return this._StockedQty;
            }
            set
            {
                this._StockedQty = value;
                this.OnPropertyChanged("StockedQty");
            }
        }
        private int _StockedQty;
        public short ScrappedQty
        {
            get
            {
                return this._ScrappedQty;
            }
            set
            {
                this._ScrappedQty = value;
                this.OnPropertyChanged("ScrappedQty");
            }
        }
        private short _ScrappedQty;
        public System.DateTime StartDate
        {
            get
            {
                return this._StartDate;
            }
            set
            {
                this._StartDate = value;
                this.OnPropertyChanged("StartDate");
            }
        }
        private System.DateTime _StartDate;
        public System.Nullable<System.DateTime> EndDate
        {
            get
            {
                return this._EndDate;
            }
            set
            {
                this._EndDate = value;
                this.OnPropertyChanged("EndDate");
            }
        }
        private System.Nullable<System.DateTime> _EndDate;
        public System.DateTime DueDate
        {
            get
            {
                return this._DueDate;
            }
            set
            {
                this._DueDate = value;
                this.OnPropertyChanged("DueDate");
            }
        }
        private System.DateTime _DueDate;
        public System.Nullable<short> ScrapReasonID
        {
            get
            {
                return this._ScrapReasonID;
            }
            set
            {
                this._ScrapReasonID = value;
                this.OnPropertyChanged("ScrapReasonID");
            }
        }
        private System.Nullable<short> _ScrapReasonID;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public Product Product
        {
            get
            {
                return this._Product;
            }
            set
            {
                this._Product = value;
                this.OnPropertyChanged("Product");
            }
        }
        private Product _Product;
        public ScrapReason ScrapReason
        {
            get
            {
                return this._ScrapReason;
            }
            set
            {
                this._ScrapReason = value;
                this.OnPropertyChanged("ScrapReason");
            }
        }
        private ScrapReason _ScrapReason;
        public ObservableCollection<WorkOrderRouting> WorkOrderRoutings
        {
            get
            {
                return this._WorkOrderRoutings;
            }
            set
            {
                this._WorkOrderRoutings = value;
                this.OnPropertyChanged("WorkOrderRoutings");
            }
        }
        private ObservableCollection<WorkOrderRouting> _WorkOrderRoutings = new ObservableCollection<WorkOrderRouting>();
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }

        partial void OnProductIDChanged();
    }
    public partial class WorkOrderRouting : System.ComponentModel.INotifyPropertyChanged
    {
        public int WorkOrderID
        {
            get
            {
                return this._WorkOrderID;
            }
            set
            {
                this._WorkOrderID = value;
                this.OnPropertyChanged("WorkOrderID");
            }
        }
        private int _WorkOrderID;
        public int ProductID
        {
            get
            {
                return this._ProductID;
            }
            set
            {
                this._ProductID = value;
                this.OnPropertyChanged("ProductID");
            }
        }
        private int _ProductID;
        public short OperationSequence
        {
            get
            {
                return this._OperationSequence;
            }
            set
            {
                this._OperationSequence = value;
                this.OnPropertyChanged("OperationSequence");
            }
        }
        private short _OperationSequence;
        public short LocationID
        {
            get
            {
                return this._LocationID;
            }
            set
            {
                this._LocationID = value;
                this.OnPropertyChanged("LocationID");
            }
        }
        private short _LocationID;
        public System.DateTime ScheduledStartDate
        {
            get
            {
                return this._ScheduledStartDate;
            }
            set
            {
                this._ScheduledStartDate = value;
                this.OnPropertyChanged("ScheduledStartDate");
            }
        }
        private System.DateTime _ScheduledStartDate;
        public System.DateTime ScheduledEndDate
        {
            get
            {
                return this._ScheduledEndDate;
            }
            set
            {
                this._ScheduledEndDate = value;
                this.OnPropertyChanged("ScheduledEndDate");
            }
        }
        private System.DateTime _ScheduledEndDate;
        public System.Nullable<System.DateTime> ActualStartDate
        {
            get
            {
                return this._ActualStartDate;
            }
            set
            {
                this._ActualStartDate = value;
                this.OnPropertyChanged("ActualStartDate");
            }
        }
        private System.Nullable<System.DateTime> _ActualStartDate;
        public System.Nullable<System.DateTime> ActualEndDate
        {
            get
            {
                return this._ActualEndDate;
            }
            set
            {
                this._ActualEndDate = value;
                this.OnPropertyChanged("ActualEndDate");
            }
        }
        private System.Nullable<System.DateTime> _ActualEndDate;
        public System.Nullable<decimal> ActualResourceHrs
        {
            get
            {
                return this._ActualResourceHrs;
            }
            set
            {
                this._ActualResourceHrs = value;
                this.OnPropertyChanged("ActualResourceHrs");
            }
        }
        private System.Nullable<decimal> _ActualResourceHrs;
        public decimal PlannedCost
        {
            get
            {
                return this._PlannedCost;
            }
            set
            {
                this._PlannedCost = value;
                this.OnPropertyChanged("PlannedCost");
            }
        }
        private decimal _PlannedCost;
        public System.Nullable<decimal> ActualCost
        {
            get
            {
                return this._ActualCost;
            }
            set
            {
                this._ActualCost = value;
                this.OnPropertyChanged("ActualCost");
            }
        }
        private System.Nullable<decimal> _ActualCost;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public Location Location
        {
            get
            {
                return this._Location;
            }
            set
            {
                this._Location = value;
                this.OnPropertyChanged("Location");
            }
        }
        private Location _Location;
        public WorkOrder WorkOrder
        {
            get
            {
                return this._WorkOrder;
            }
            set
            {
                this._WorkOrder = value;
                this.OnPropertyChanged("WorkOrder");
            }
        }
        private WorkOrder _WorkOrder;
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    public partial class ProductVendor : System.ComponentModel.INotifyPropertyChanged
    {
        public int ProductID
        {
            get
            {
                return this._ProductID;
            }
            set
            {
                this._ProductID = value;
                this.OnPropertyChanged("ProductID");
            }
        }
        private int _ProductID;
        public int BusinessEntityID
        {
            get
            {
                return this._BusinessEntityID;
            }
            set
            {
                this._BusinessEntityID = value;
                this.OnPropertyChanged("BusinessEntityID");
            }
        }
        private int _BusinessEntityID;
        public int AverageLeadTime
        {
            get
            {
                return this._AverageLeadTime;
            }
            set
            {
                this._AverageLeadTime = value;
                this.OnPropertyChanged("AverageLeadTime");
            }
        }
        private int _AverageLeadTime;
        public decimal StandardPrice
        {
            get
            {
                return this._StandardPrice;
            }
            set
            {
                this._StandardPrice = value;
                this.OnPropertyChanged("StandardPrice");
            }
        }
        private decimal _StandardPrice;
        public System.Nullable<decimal> LastReceiptCost
        {
            get
            {
                return this._LastReceiptCost;
            }
            set
            {
                this._LastReceiptCost = value;
                this.OnPropertyChanged("LastReceiptCost");
            }
        }
        private System.Nullable<decimal> _LastReceiptCost;
        public System.Nullable<System.DateTime> LastReceiptDate
        {
            get
            {
                return this._LastReceiptDate;
            }
            set
            {
                this._LastReceiptDate = value;
                this.OnPropertyChanged("LastReceiptDate");
            }
        }
        private System.Nullable<System.DateTime> _LastReceiptDate;
        public int MinOrderQty
        {
            get
            {
                return this._MinOrderQty;
            }
            set
            {
                this._MinOrderQty = value;
                this.OnPropertyChanged("MinOrderQty");
            }
        }
        private int _MinOrderQty;
        public int MaxOrderQty
        {
            get
            {
                return this._MaxOrderQty;
            }
            set
            {
                this._MaxOrderQty = value;
                this.OnPropertyChanged("MaxOrderQty");
            }
        }
        private int _MaxOrderQty;
        public System.Nullable<int> OnOrderQty
        {
            get
            {
                return this._OnOrderQty;
            }
            set
            {
                this._OnOrderQty = value;
                this.OnPropertyChanged("OnOrderQty");
            }
        }
        private System.Nullable<int> _OnOrderQty;
        public string UnitMeasureCode
        {
            get
            {
                return this._UnitMeasureCode;
            }
            set
            {
                this._UnitMeasureCode = value;
                this.OnPropertyChanged("UnitMeasureCode");
            }
        }
        private string _UnitMeasureCode;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public Product Product
        {
            get
            {
                return this._Product;
            }
            set
            {
                this._Product = value;
                this.OnPropertyChanged("Product");
            }
        }
        private Product _Product;
        public UnitMeasure UnitMeasure
        {
            get
            {
                return this._UnitMeasure;
            }
            set
            {
                this._UnitMeasure = value;
                this.OnPropertyChanged("UnitMeasure");
            }
        }
        private UnitMeasure _UnitMeasure;
        public Vendor Vendor
        {
            get
            {
                return this._Vendor;
            }
            set
            {
                this._Vendor = value;
                this.OnPropertyChanged("Vendor");
            }
        }
        private Vendor _Vendor;
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    public partial class PurchaseOrderDetail : System.ComponentModel.INotifyPropertyChanged
    {
        public int PurchaseOrderID
        {
            get
            {
                return this._PurchaseOrderID;
            }
            set
            {
                this._PurchaseOrderID = value;
                this.OnPropertyChanged("PurchaseOrderID");
            }
        }
        private int _PurchaseOrderID;
        public int PurchaseOrderDetailID
        {
            get
            {
                return this._PurchaseOrderDetailID;
            }
            set
            {
                this._PurchaseOrderDetailID = value;
                this.OnPropertyChanged("PurchaseOrderDetailID");
            }
        }
        private int _PurchaseOrderDetailID;
        public System.DateTime DueDate
        {
            get
            {
                return this._DueDate;
            }
            set
            {
                this._DueDate = value;
                this.OnPropertyChanged("DueDate");
            }
        }
        private System.DateTime _DueDate;
        public short OrderQty
        {
            get
            {
                return this._OrderQty;
            }
            set
            {
                this._OrderQty = value;
                this.OnPropertyChanged("OrderQty");
            }
        }
        private short _OrderQty;
        public int ProductID
        {
            get
            {
                return this._ProductID;
            }
            set
            {
                this._ProductID = value;
                this.OnPropertyChanged("ProductID");
            }
        }
        private int _ProductID;
        public decimal UnitPrice
        {
            get
            {
                return this._UnitPrice;
            }
            set
            {
                this._UnitPrice = value;
                this.OnPropertyChanged("UnitPrice");
            }
        }
        private decimal _UnitPrice;
        public decimal LineTotal
        {
            get
            {
                return this._LineTotal;
            }
            set
            {
                this._LineTotal = value;
                this.OnPropertyChanged("LineTotal");
            }
        }
        private decimal _LineTotal;
        public decimal ReceivedQty
        {
            get
            {
                return this._ReceivedQty;
            }
            set
            {
                this._ReceivedQty = value;
                this.OnPropertyChanged("ReceivedQty");
            }
        }
        private decimal _ReceivedQty;
        public decimal RejectedQty
        {
            get
            {
                return this._RejectedQty;
            }
            set
            {
                this._RejectedQty = value;
                this.OnPropertyChanged("RejectedQty");
            }
        }
        private decimal _RejectedQty;
        public decimal StockedQty
        {
            get
            {
                return this._StockedQty;
            }
            set
            {
                this._StockedQty = value;
                this.OnPropertyChanged("StockedQty");
            }
        }
        private decimal _StockedQty;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public Product Product
        {
            get
            {
                return this._Product;
            }
            set
            {
                this._Product = value;
                this.OnPropertyChanged("Product");
            }
        }
        private Product _Product;
        public PurchaseOrderHeader PurchaseOrderHeader
        {
            get
            {
                return this._PurchaseOrderHeader;
            }
            set
            {
                this._PurchaseOrderHeader = value;
                this.OnPropertyChanged("PurchaseOrderHeader");
            }
        }
        private PurchaseOrderHeader _PurchaseOrderHeader;
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    public partial class PurchaseOrderHeader : System.ComponentModel.INotifyPropertyChanged
    {
        public int PurchaseOrderID
        {
            get
            {
                return this._PurchaseOrderID;
            }
            set
            {
                this._PurchaseOrderID = value;
                this.OnPropertyChanged("PurchaseOrderID");
            }
        }
        private int _PurchaseOrderID;
        public byte RevisionNumber
        {
            get
            {
                return this._RevisionNumber;
            }
            set
            {
                this._RevisionNumber = value;
                this.OnPropertyChanged("RevisionNumber");
            }
        }
        private byte _RevisionNumber;
        public byte Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                this._Status = value;
                this.OnPropertyChanged("Status");
            }
        }
        private byte _Status;
        public int EmployeeID
        {
            get
            {
                return this._EmployeeID;
            }
            set
            {
                this._EmployeeID = value;
                this.OnPropertyChanged("EmployeeID");
            }
        }
        private int _EmployeeID;
        public int VendorID
        {
            get
            {
                return this._VendorID;
            }
            set
            {
                this._VendorID = value;
                this.OnVendorIDChanged();
                this.OnPropertyChanged("VendorID");
            }
        }
        private int _VendorID;
        public int ShipMethodID
        {
            get
            {
                return this._ShipMethodID;
            }
            set
            {
                this._ShipMethodID = value;
                this.OnShipMethodIDChanged();
                this.OnPropertyChanged("ShipMethodID");
            }
        }
        private int _ShipMethodID;
        public System.DateTime OrderDate
        {
            get
            {
                return this._OrderDate;
            }
            set
            {
                this._OrderDate = value;
                this.OnPropertyChanged("OrderDate");
            }
        }
        private System.DateTime _OrderDate;
        public System.Nullable<System.DateTime> ShipDate
        {
            get
            {
                return this._ShipDate;
            }
            set
            {
                this._ShipDate = value;
                this.OnPropertyChanged("ShipDate");
            }
        }
        private System.Nullable<System.DateTime> _ShipDate;
        public decimal SubTotal
        {
            get
            {
                return this._SubTotal;
            }
            set
            {
                this._SubTotal = value;
                this.OnPropertyChanged("SubTotal");
            }
        }
        private decimal _SubTotal;
        public decimal TaxAmt
        {
            get
            {
                return this._TaxAmt;
            }
            set
            {
                this._TaxAmt = value;
                this.OnPropertyChanged("TaxAmt");
            }
        }
        private decimal _TaxAmt;
        public decimal Freight
        {
            get
            {
                return this._Freight;
            }
            set
            {
                this._Freight = value;
                this.OnPropertyChanged("Freight");
            }
        }
        private decimal _Freight;
        public decimal TotalDue
        {
            get
            {
                return this._TotalDue;
            }
            set
            {
                this._TotalDue = value;
                this.OnPropertyChanged("TotalDue");
            }
        }
        private decimal _TotalDue;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public ObservableCollection<PurchaseOrderDetail> PurchaseOrderDetails
        {
            get
            {
                return this._PurchaseOrderDetails;
            }
            set
            {
                this._PurchaseOrderDetails = value;
                this.OnPropertyChanged("PurchaseOrderDetails");
            }
        }
        private ObservableCollection<PurchaseOrderDetail> _PurchaseOrderDetails = new ObservableCollection<PurchaseOrderDetail>();
        public ShipMethod ShipMethod
        {
            get
            {
                return this._ShipMethod;
            }
            set
            {
                this._ShipMethod = value;
                this.OnPropertyChanged("ShipMethod");
            }
        }
        private ShipMethod _ShipMethod;
        public Vendor Vendor
        {
            get
            {
                return this._Vendor;
            }
            set
            {
                this._Vendor = value;
                this.OnPropertyChanged("Vendor");
            }
        }
        private Vendor _Vendor;
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }

        partial void OnShipMethodIDChanged();

        partial void OnVendorIDChanged();
    }
    public partial class ShipMethod : System.ComponentModel.INotifyPropertyChanged
    {
        public int ShipMethodID
        {
            get
            {
                return this._ShipMethodID;
            }
            set
            {
                this._ShipMethodID = value;
                this.OnPropertyChanged("ShipMethodID");
            }
        }
        private int _ShipMethodID;
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this._Name = value;
                this.OnPropertyChanged("Name");
            }
        }
        private string _Name;
        public decimal ShipBase
        {
            get
            {
                return this._ShipBase;
            }
            set
            {
                this._ShipBase = value;
                this.OnPropertyChanged("ShipBase");
            }
        }
        private decimal _ShipBase;
        public decimal ShipRate
        {
            get
            {
                return this._ShipRate;
            }
            set
            {
                this._ShipRate = value;
                this.OnPropertyChanged("ShipRate");
            }
        }
        private decimal _ShipRate;
        public System.Guid rowguid
        {
            get
            {
                return this._rowguid;
            }
            set
            {
                this._rowguid = value;
                this.OnPropertyChanged("rowguid");
            }
        }
        private System.Guid _rowguid;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public ObservableCollection<PurchaseOrderHeader> PurchaseOrderHeaders
        {
            get
            {
                return this._PurchaseOrderHeaders;
            }
            set
            {
                this._PurchaseOrderHeaders = value;
                this.OnPropertyChanged("PurchaseOrderHeaders");
            }
        }
        private ObservableCollection<PurchaseOrderHeader> _PurchaseOrderHeaders = new ObservableCollection<PurchaseOrderHeader>();
        public ObservableCollection<SalesOrderHeader> SalesOrderHeaders
        {
            get
            {
                return this._SalesOrderHeaders;
            }
            set
            {
                this._SalesOrderHeaders = value;
                this.OnPropertyChanged("SalesOrderHeaders");
            }
        }
        private ObservableCollection<SalesOrderHeader> _SalesOrderHeaders = new ObservableCollection<SalesOrderHeader>();
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
        public override bool Equals(object obj)
        {
            if (obj != null && obj is ShipMethod shipMethod)
            {
                return this.ShipMethodID == (obj as ShipMethod).ShipMethodID;
            }
            return base.Equals(obj);            
        }
    }
    public partial class Vendor : System.ComponentModel.INotifyPropertyChanged
    {
        public int BusinessEntityID
        {
            get
            {
                return this._BusinessEntityID;
            }
            set
            {
                this._BusinessEntityID = value;
                this.OnPropertyChanged("BusinessEntityID");
            }
        }
        private int _BusinessEntityID;
        public string AccountNumber
        {
            get
            {
                return this._AccountNumber;
            }
            set
            {
                this._AccountNumber = value;
                this.OnPropertyChanged("AccountNumber");
            }
        }
        private string _AccountNumber;
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this._Name = value;
                this.OnPropertyChanged("Name");
            }
        }
        private string _Name;
        public byte CreditRating
        {
            get
            {
                return this._CreditRating;
            }
            set
            {
                this._CreditRating = value;
                this.OnPropertyChanged("CreditRating");
            }
        }
        private byte _CreditRating;
        public bool PreferredVendorStatus
        {
            get
            {
                return this._PreferredVendorStatus;
            }
            set
            {
                this._PreferredVendorStatus = value;
                this.OnPropertyChanged("PreferredVendorStatus");
            }
        }
        private bool _PreferredVendorStatus;
        public bool ActiveFlag
        {
            get
            {
                return this._ActiveFlag;
            }
            set
            {
                this._ActiveFlag = value;
                this.OnPropertyChanged("ActiveFlag");
            }
        }
        private bool _ActiveFlag;
        public string PurchasingWebServiceURL
        {
            get
            {
                return this._PurchasingWebServiceURL;
            }
            set
            {
                this._PurchasingWebServiceURL = value;
                this.OnPropertyChanged("PurchasingWebServiceURL");
            }
        }
        private string _PurchasingWebServiceURL;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public BusinessEntity BusinessEntity
        {
            get
            {
                return this._BusinessEntity;
            }
            set
            {
                this._BusinessEntity = value;
                this.OnPropertyChanged("BusinessEntity");
            }
        }
        private BusinessEntity _BusinessEntity;
        public ObservableCollection<ProductVendor> ProductVendors
        {
            get
            {
                return this._ProductVendors;
            }
            set
            {
                this._ProductVendors = value;
                this.OnPropertyChanged("ProductVendors");
            }
        }
        private ObservableCollection<ProductVendor> _ProductVendors = new ObservableCollection<ProductVendor>();
        public ObservableCollection<PurchaseOrderHeader> PurchaseOrderHeaders
        {
            get
            {
                return this._PurchaseOrderHeaders;
            }
            set
            {
                this._PurchaseOrderHeaders = value;
                this.OnPropertyChanged("PurchaseOrderHeaders");
            }
        }
        private ObservableCollection<PurchaseOrderHeader> _PurchaseOrderHeaders = new ObservableCollection<PurchaseOrderHeader>();
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
        public override bool Equals(object obj)
        {
            if (obj != null && obj is Vendor vendor)
            {
                return this.BusinessEntityID == vendor.BusinessEntityID;
            }
            return base.Equals(obj);
        }
    }
    public partial class CountryRegionCurrency : System.ComponentModel.INotifyPropertyChanged
    {
        public string CountryRegionCode
        {
            get
            {
                return this._CountryRegionCode;
            }
            set
            {
                this._CountryRegionCode = value;
                this.OnPropertyChanged("CountryRegionCode");
            }
        }
        private string _CountryRegionCode;
        public string CurrencyCode
        {
            get
            {
                return this._CurrencyCode;
            }
            set
            {
                this._CurrencyCode = value;
                this.OnPropertyChanged("CurrencyCode");
            }
        }
        private string _CurrencyCode;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public CountryRegion CountryRegion
        {
            get
            {
                return this._CountryRegion;
            }
            set
            {
                this._CountryRegion = value;
                this.OnPropertyChanged("CountryRegion");
            }
        }
        private CountryRegion _CountryRegion;
        public Currency Currency
        {
            get
            {
                return this._Currency;
            }
            set
            {
                this._Currency = value;
                this.OnPropertyChanged("Currency");
            }
        }
        private Currency _Currency;
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    public partial class CreditCard : System.ComponentModel.INotifyPropertyChanged
    {
        public int CreditCardID
        {
            get
            {
                return this._CreditCardID;
            }
            set
            {
                this._CreditCardID = value;
                this.OnPropertyChanged("CreditCardID");
            }
        }
        private int _CreditCardID;
        public string CardType
        {
            get
            {
                return this._CardType;
            }
            set
            {
                this._CardType = value;
                this.OnPropertyChanged("CardType");
            }
        }
        private string _CardType;
        public string CardNumber
        {
            get
            {
                return this._CardNumber;
            }
            set
            {
                this._CardNumber = value;
                this.OnPropertyChanged("CardNumber");
            }
        }
        private string _CardNumber;
        public byte ExpMonth
        {
            get
            {
                return this._ExpMonth;
            }
            set
            {
                this._ExpMonth = value;
                this.OnPropertyChanged("ExpMonth");
            }
        }
        private byte _ExpMonth;
        public short ExpYear
        {
            get
            {
                return this._ExpYear;
            }
            set
            {
                this._ExpYear = value;
                this.OnPropertyChanged("ExpYear");
            }
        }
        private short _ExpYear;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public ObservableCollection<PersonCreditCard> PersonCreditCards
        {
            get
            {
                return this._PersonCreditCards;
            }
            set
            {
                this._PersonCreditCards = value;
                this.OnPropertyChanged("PersonCreditCards");
            }
        }
        private ObservableCollection<PersonCreditCard> _PersonCreditCards = new ObservableCollection<PersonCreditCard>();
        public ObservableCollection<SalesOrderHeader> SalesOrderHeaders
        {
            get
            {
                return this._SalesOrderHeaders;
            }
            set
            {
                this._SalesOrderHeaders = value;
                this.OnPropertyChanged("SalesOrderHeaders");
            }
        }
        private ObservableCollection<SalesOrderHeader> _SalesOrderHeaders = new ObservableCollection<SalesOrderHeader>();
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    public partial class Currency : System.ComponentModel.INotifyPropertyChanged
    {
        public string CurrencyCode
        {
            get
            {
                return this._CurrencyCode;
            }
            set
            {
                this._CurrencyCode = value;
                this.OnPropertyChanged("CurrencyCode");
            }
        }
        private string _CurrencyCode;
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this._Name = value;
                this.OnPropertyChanged("Name");
            }
        }
        private string _Name;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public ObservableCollection<CountryRegionCurrency> CountryRegionCurrencies
        {
            get
            {
                return this._CountryRegionCurrencies;
            }
            set
            {
                this._CountryRegionCurrencies = value;
                this.OnPropertyChanged("CountryRegionCurrencies");
            }
        }
        private ObservableCollection<CountryRegionCurrency> _CountryRegionCurrencies = new ObservableCollection<CountryRegionCurrency>();
        public ObservableCollection<CurrencyRate> CurrencyRates
        {
            get
            {
                return this._CurrencyRates;
            }
            set
            {
                this._CurrencyRates = value;
                this.OnPropertyChanged("CurrencyRates");
            }
        }
        private ObservableCollection<CurrencyRate> _CurrencyRates = new ObservableCollection<CurrencyRate>();
        public ObservableCollection<CurrencyRate> CurrencyRates1
        {
            get
            {
                return this._CurrencyRates1;
            }
            set
            {
                this._CurrencyRates1 = value;
                this.OnPropertyChanged("CurrencyRates1");
            }
        }
        private ObservableCollection<CurrencyRate> _CurrencyRates1 = new ObservableCollection<CurrencyRate>();
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    public partial class CurrencyRate : System.ComponentModel.INotifyPropertyChanged
    {
        public int CurrencyRateID
        {
            get
            {
                return this._CurrencyRateID;
            }
            set
            {
                this._CurrencyRateID = value;
                this.OnPropertyChanged("CurrencyRateID");
            }
        }
        private int _CurrencyRateID;
        public System.DateTime CurrencyRateDate
        {
            get
            {
                return this._CurrencyRateDate;
            }
            set
            {
                this._CurrencyRateDate = value;
                this.OnPropertyChanged("CurrencyRateDate");
            }
        }
        private System.DateTime _CurrencyRateDate;
        public string FromCurrencyCode
        {
            get
            {
                return this._FromCurrencyCode;
            }
            set
            {
                this._FromCurrencyCode = value;
                this.OnPropertyChanged("FromCurrencyCode");
            }
        }
        private string _FromCurrencyCode;
        public string ToCurrencyCode
        {
            get
            {
                return this._ToCurrencyCode;
            }
            set
            {
                this._ToCurrencyCode = value;
                this.OnPropertyChanged("ToCurrencyCode");
            }
        }
        private string _ToCurrencyCode;
        public decimal AverageRate
        {
            get
            {
                return this._AverageRate;
            }
            set
            {
                this._AverageRate = value;
                this.OnPropertyChanged("AverageRate");
            }
        }
        private decimal _AverageRate;
        public decimal EndOfDayRate
        {
            get
            {
                return this._EndOfDayRate;
            }
            set
            {
                this._EndOfDayRate = value;
                this.OnPropertyChanged("EndOfDayRate");
            }
        }
        private decimal _EndOfDayRate;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public Currency Currency
        {
            get
            {
                return this._Currency;
            }
            set
            {
                this._Currency = value;
                this.OnPropertyChanged("Currency");
            }
        }
        private Currency _Currency;
        public Currency Currency1
        {
            get
            {
                return this._Currency1;
            }
            set
            {
                this._Currency1 = value;
                this.OnPropertyChanged("Currency1");
            }
        }
        private Currency _Currency1;
        public ObservableCollection<SalesOrderHeader> SalesOrderHeaders
        {
            get
            {
                return this._SalesOrderHeaders;
            }
            set
            {
                this._SalesOrderHeaders = value;
                this.OnPropertyChanged("SalesOrderHeaders");
            }
        }
        private ObservableCollection<SalesOrderHeader> _SalesOrderHeaders = new ObservableCollection<SalesOrderHeader>();
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    public partial class Customer : System.ComponentModel.INotifyPropertyChanged
    {
        public int CustomerID
        {
            get
            {
                return this._CustomerID;
            }
            set
            {
                this._CustomerID = value;
                this.OnPropertyChanged("CustomerID");
            }
        }
        private int _CustomerID;
        public System.Nullable<int> PersonID
        {
            get
            {
                return this._PersonID;
            }
            set
            {
                this._PersonID = value;
                this.OnPropertyChanged("PersonID");
            }
        }
        private System.Nullable<int> _PersonID;
        public System.Nullable<int> StoreID
        {
            get
            {
                return this._StoreID;
            }
            set
            {
                this._StoreID = value;
                this.OnPropertyChanged("StoreID");
            }
        }
        private System.Nullable<int> _StoreID;
        public System.Nullable<int> TerritoryID
        {
            get
            {
                return this._TerritoryID;
            }
            set
            {
                this._TerritoryID = value;
                this.OnPropertyChanged("TerritoryID");
            }
        }
        private System.Nullable<int> _TerritoryID;
        public string AccountNumber
        {
            get
            {
                return this._AccountNumber;
            }
            set
            {
                this._AccountNumber = value;
                this.OnPropertyChanged("AccountNumber");
            }
        }
        private string _AccountNumber;
        public System.Guid rowguid
        {
            get
            {
                return this._rowguid;
            }
            set
            {
                this._rowguid = value;
                this.OnPropertyChanged("rowguid");
            }
        }
        private System.Guid _rowguid;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public Person Person
        {
            get
            {
                return this._Person;
            }
            set
            {
                this._Person = value;
                this.OnPropertyChanged("Person");
            }
        }
        private Person _Person;
        public SalesTerritory SalesTerritory
        {
            get
            {
                return this._SalesTerritory;
            }
            set
            {
                this._SalesTerritory = value;
                this.OnPropertyChanged("SalesTerritory");
            }
        }
        private SalesTerritory _SalesTerritory;
        public Store Store
        {
            get
            {
                return this._Store;
            }
            set
            {
                this._Store = value;
                this.OnPropertyChanged("Store");
            }
        }
        private Store _Store;
        public ObservableCollection<SalesOrderHeader> SalesOrderHeaders
        {
            get
            {
                return this._SalesOrderHeaders;
            }
            set
            {
                this._SalesOrderHeaders = value;
                this.OnPropertyChanged("SalesOrderHeaders");
            }
        }
        private ObservableCollection<SalesOrderHeader> _SalesOrderHeaders = new ObservableCollection<SalesOrderHeader>();
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }

        public override bool Equals(object obj)
        {
            if (obj != null && obj is Customer customer)
            {
                return this.CustomerID == customer.CustomerID;
            }
            return base.Equals(obj);
        }
    }
    public partial class PersonCreditCard : System.ComponentModel.INotifyPropertyChanged
    {
        public int BusinessEntityID
        {
            get
            {
                return this._BusinessEntityID;
            }
            set
            {
                this._BusinessEntityID = value;
                this.OnPropertyChanged("BusinessEntityID");
            }
        }
        private int _BusinessEntityID;
        public int CreditCardID
        {
            get
            {
                return this._CreditCardID;
            }
            set
            {
                this._CreditCardID = value;
                this.OnPropertyChanged("CreditCardID");
            }
        }
        private int _CreditCardID;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public Person Person
        {
            get
            {
                return this._Person;
            }
            set
            {
                this._Person = value;
                this.OnPropertyChanged("Person");
            }
        }
        private Person _Person;
        public CreditCard CreditCard
        {
            get
            {
                return this._CreditCard;
            }
            set
            {
                this._CreditCard = value;
                this.OnPropertyChanged("CreditCard");
            }
        }
        private CreditCard _CreditCard;
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    public partial class SalesOrderDetail : System.ComponentModel.INotifyPropertyChanged
    {
        public int SalesOrderID
        {
            get
            {
                return this._SalesOrderID;
            }
            set
            {
                this._SalesOrderID = value;
                this.OnPropertyChanged("SalesOrderID");
            }
        }
        private int _SalesOrderID;
        public int SalesOrderDetailID
        {
            get
            {
                return this._SalesOrderDetailID;
            }
            set
            {
                this._SalesOrderDetailID = value;
                this.OnPropertyChanged("SalesOrderDetailID");
            }
        }
        private int _SalesOrderDetailID;
        public string CarrierTrackingNumber
        {
            get
            {
                return this._CarrierTrackingNumber;
            }
            set
            {
                this._CarrierTrackingNumber = value;
                this.OnPropertyChanged("CarrierTrackingNumber");
            }
        }
        private string _CarrierTrackingNumber;
        public short OrderQty
        {
            get
            {
                return this._OrderQty;
            }
            set
            {
                this._OrderQty = value;
                this.OnPropertyChanged("OrderQty");
            }
        }
        private short _OrderQty;
        public int ProductID
        {
            get
            {
                return this._ProductID;
            }
            set
            {
                this._ProductID = value;
                this.OnPropertyChanged("ProductID");
            }
        }
        private int _ProductID;
        public int SpecialOfferID
        {
            get
            {
                return this._SpecialOfferID;
            }
            set
            {
                this._SpecialOfferID = value;
                this.OnPropertyChanged("SpecialOfferID");
            }
        }
        private int _SpecialOfferID;
        public decimal UnitPrice
        {
            get
            {
                return this._UnitPrice;
            }
            set
            {
                this._UnitPrice = value;
                this.OnPropertyChanged("UnitPrice");
            }
        }
        private decimal _UnitPrice;
        public decimal UnitPriceDiscount
        {
            get
            {
                return this._UnitPriceDiscount;
            }
            set
            {
                this._UnitPriceDiscount = value;
                this.OnPropertyChanged("UnitPriceDiscount");
            }
        }
        private decimal _UnitPriceDiscount;
        public decimal LineTotal
        {
            get
            {
                return this._LineTotal;
            }
            set
            {
                this._LineTotal = value;
                this.OnPropertyChanged("LineTotal");
            }
        }
        private decimal _LineTotal;
        public System.Guid rowguid
        {
            get
            {
                return this._rowguid;
            }
            set
            {
                this._rowguid = value;
                this.OnPropertyChanged("rowguid");
            }
        }
        private System.Guid _rowguid;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public SalesOrderHeader SalesOrderHeader
        {
            get
            {
                return this._SalesOrderHeader;
            }
            set
            {
                this._SalesOrderHeader = value;
                this.OnPropertyChanged("SalesOrderHeader");
            }
        }
        private SalesOrderHeader _SalesOrderHeader;
        public SpecialOfferProduct SpecialOfferProduct
        {
            get
            {
                return this._SpecialOfferProduct;
            }
            set
            {
                this._SpecialOfferProduct = value;
                this.OnPropertyChanged("SpecialOfferProduct");
            }
        }
        private SpecialOfferProduct _SpecialOfferProduct;
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    public partial class SalesOrderHeader : System.ComponentModel.INotifyPropertyChanged
    {
        public int SalesOrderID
        {
            get
            {
                return this._SalesOrderID;
            }
            set
            {
                this._SalesOrderID = value;
                this.OnPropertyChanged("SalesOrderID");
            }
        }
        private int _SalesOrderID;
        public byte RevisionNumber
        {
            get
            {
                return this._RevisionNumber;
            }
            set
            {
                this._RevisionNumber = value;
                this.OnPropertyChanged("RevisionNumber");
            }
        }
        private byte _RevisionNumber;
        public System.DateTime OrderDate
        {
            get
            {
                return this._OrderDate;
            }
            set
            {
                this._OrderDate = value;
                this.OnPropertyChanged("OrderDate");
            }
        }
        private System.DateTime _OrderDate;
        public System.DateTime DueDate
        {
            get
            {
                return this._DueDate;
            }
            set
            {
                this._DueDate = value;
                this.OnPropertyChanged("DueDate");
            }
        }
        private System.DateTime _DueDate;
        public System.Nullable<System.DateTime> ShipDate
        {
            get
            {
                return this._ShipDate;
            }
            set
            {
                this._ShipDate = value;
                this.OnPropertyChanged("ShipDate");
            }
        }
        private System.Nullable<System.DateTime> _ShipDate;
        public byte Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                this._Status = value;
                this.OnPropertyChanged("Status");
            }
        }
        private byte _Status;
        public bool OnlineOrderFlag
        {
            get
            {
                return this._OnlineOrderFlag;
            }
            set
            {
                this._OnlineOrderFlag = value;
                this.OnPropertyChanged("OnlineOrderFlag");
            }
        }
        private bool _OnlineOrderFlag;
        public string SalesOrderNumber
        {
            get
            {
                return this._SalesOrderNumber;
            }
            set
            {
                this._SalesOrderNumber = value;
                this.OnPropertyChanged("SalesOrderNumber");
            }
        }
        private string _SalesOrderNumber;
        public string PurchaseOrderNumber
        {
            get
            {
                return this._PurchaseOrderNumber;
            }
            set
            {
                this._PurchaseOrderNumber = value;
                this.OnPropertyChanged("PurchaseOrderNumber");
            }
        }
        private string _PurchaseOrderNumber;
        public string AccountNumber
        {
            get
            {
                return this._AccountNumber;
            }
            set
            {
                this._AccountNumber = value;
                this.OnPropertyChanged("AccountNumber");
            }
        }
        private string _AccountNumber;
        public int CustomerID
        {
            get
            {
                return this._CustomerID;
            }
            set
            {
                this._CustomerID = value;
                this.OnCustomerIDChanged();
                this.OnPropertyChanged("CustomerID");
            }
        }
        private int _CustomerID;
        public System.Nullable<int> SalesPersonID
        {
            get
            {
                return this._SalesPersonID;
            }
            set
            {
                this._SalesPersonID = value;
                this.OnPropertyChanged("SalesPersonID");
            }
        }
        private System.Nullable<int> _SalesPersonID;
        public System.Nullable<int> TerritoryID
        {
            get
            {
                return this._TerritoryID;
            }
            set
            {
                this._TerritoryID = value;
                this.OnPropertyChanged("TerritoryID");
            }
        }
        private System.Nullable<int> _TerritoryID;
        public int BillToAddressID
        {
            get
            {
                return this._BillToAddressID;
            }
            set
            {
                this._BillToAddressID = value;
                this.OnPropertyChanged("BillToAddressID");
            }
        }
        private int _BillToAddressID;
        public int ShipToAddressID
        {
            get
            {
                return this._ShipToAddressID;
            }
            set
            {
                this._ShipToAddressID = value;
                this.OnPropertyChanged("ShipToAddressID");
            }
        }
        private int _ShipToAddressID;
        public int ShipMethodID
        {
            get
            {
                return this._ShipMethodID;
            }
            set
            {
                this._ShipMethodID = value;
                this.OnShipMethodIDChanged();
                this.OnPropertyChanged("ShipMethodID");
            }
        }
        private int _ShipMethodID;
        public System.Nullable<int> CreditCardID
        {
            get
            {
                return this._CreditCardID;
            }
            set
            {
                this._CreditCardID = value;
                this.OnPropertyChanged("CreditCardID");
            }
        }
        private System.Nullable<int> _CreditCardID;
        public string CreditCardApprovalCode
        {
            get
            {
                return this._CreditCardApprovalCode;
            }
            set
            {
                this._CreditCardApprovalCode = value;
                this.OnPropertyChanged("CreditCardApprovalCode");
            }
        }
        private string _CreditCardApprovalCode;
        public System.Nullable<int> CurrencyRateID
        {
            get
            {
                return this._CurrencyRateID;
            }
            set
            {
                this._CurrencyRateID = value;
                this.OnPropertyChanged("CurrencyRateID");
            }
        }
        private System.Nullable<int> _CurrencyRateID;
        public decimal SubTotal
        {
            get
            {
                return this._SubTotal;
            }
            set
            {
                this._SubTotal = value;
                this.OnPropertyChanged("SubTotal");
            }
        }
        private decimal _SubTotal;
        public decimal TaxAmt
        {
            get
            {
                return this._TaxAmt;
            }
            set
            {
                this._TaxAmt = value;
                this.OnPropertyChanged("TaxAmt");
            }
        }
        private decimal _TaxAmt;
        public decimal Freight
        {
            get
            {
                return this._Freight;
            }
            set
            {
                this._Freight = value;
                this.OnPropertyChanged("Freight");
            }
        }
        private decimal _Freight;
        public decimal TotalDue
        {
            get
            {
                return this._TotalDue;
            }
            set
            {
                this._TotalDue = value;
                this.OnPropertyChanged("TotalDue");
            }
        }
        private decimal _TotalDue;
        public string Comment
        {
            get
            {
                return this._Comment;
            }
            set
            {
                this._Comment = value;
                this.OnPropertyChanged("Comment");
            }
        }
        private string _Comment;
        public System.Guid rowguid
        {
            get
            {
                return this._rowguid;
            }
            set
            {
                this._rowguid = value;
                this.OnPropertyChanged("rowguid");
            }
        }
        private System.Guid _rowguid;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public Address Address
        {
            get
            {
                return this._Address;
            }
            set
            {
                this._Address = value;
                this.OnPropertyChanged("Address");
            }
        }
        private Address _Address;
        public Address Address1
        {
            get
            {
                return this._Address1;
            }
            set
            {
                this._Address1 = value;
                this.OnPropertyChanged("Address1");
            }
        }
        private Address _Address1;
        public ShipMethod ShipMethod
        {
            get
            {
                return this._ShipMethod;
            }
            set
            {
                this._ShipMethod = value;
                this.OnPropertyChanged("ShipMethod");
            }
        }
        private ShipMethod _ShipMethod;
        public CreditCard CreditCard
        {
            get
            {
                return this._CreditCard;
            }
            set
            {
                this._CreditCard = value;
                this.OnPropertyChanged("CreditCard");
            }
        }
        private CreditCard _CreditCard;
        public CurrencyRate CurrencyRate
        {
            get
            {
                return this._CurrencyRate;
            }
            set
            {
                this._CurrencyRate = value;
                this.OnPropertyChanged("CurrencyRate");
            }
        }
        private CurrencyRate _CurrencyRate;
        public Customer Customer
        {
            get
            {
                return this._Customer;
            }
            set
            {
                this._Customer = value;
                this.OnPropertyChanged("Customer");
            }
        }
        private Customer _Customer;
        public ObservableCollection<SalesOrderDetail> SalesOrderDetails
        {
            get
            {
                return this._SalesOrderDetails;
            }
            set
            {
                this._SalesOrderDetails = value;
                this.OnPropertyChanged("SalesOrderDetails");
            }
        }
        private ObservableCollection<SalesOrderDetail> _SalesOrderDetails = new ObservableCollection<SalesOrderDetail>();
        public SalesPerson SalesPerson
        {
            get
            {
                return this._SalesPerson;
            }
            set
            {
                this._SalesPerson = value;
                this.OnPropertyChanged("SalesPerson");
            }
        }
        private SalesPerson _SalesPerson;
        public SalesTerritory SalesTerritory
        {
            get
            {
                return this._SalesTerritory;
            }
            set
            {
                this._SalesTerritory = value;
                this.OnPropertyChanged("SalesTerritory");
            }
        }
        private SalesTerritory _SalesTerritory;
        public ObservableCollection<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons
        {
            get
            {
                return this._SalesOrderHeaderSalesReasons;
            }
            set
            {
                this._SalesOrderHeaderSalesReasons = value;
                this.OnPropertyChanged("SalesOrderHeaderSalesReasons");
            }
        }
        private ObservableCollection<SalesOrderHeaderSalesReason> _SalesOrderHeaderSalesReasons = new ObservableCollection<SalesOrderHeaderSalesReason>();
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }

        partial void OnCustomerIDChanged();

        partial void OnShipMethodIDChanged();
    }
    public partial class SalesOrderHeaderSalesReason : System.ComponentModel.INotifyPropertyChanged
    {
        public int SalesOrderID
        {
            get
            {
                return this._SalesOrderID;
            }
            set
            {
                this._SalesOrderID = value;
                this.OnPropertyChanged("SalesOrderID");
            }
        }
        private int _SalesOrderID;
        public int SalesReasonID
        {
            get
            {
                return this._SalesReasonID;
            }
            set
            {
                this._SalesReasonID = value;
                this.OnPropertyChanged("SalesReasonID");
            }
        }
        private int _SalesReasonID;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public SalesOrderHeader SalesOrderHeader
        {
            get
            {
                return this._SalesOrderHeader;
            }
            set
            {
                this._SalesOrderHeader = value;
                this.OnPropertyChanged("SalesOrderHeader");
            }
        }
        private SalesOrderHeader _SalesOrderHeader;
        public SalesReason SalesReason
        {
            get
            {
                return this._SalesReason;
            }
            set
            {
                this._SalesReason = value;
                this.OnPropertyChanged("SalesReason");
            }
        }
        private SalesReason _SalesReason;
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    public partial class SalesPerson : System.ComponentModel.INotifyPropertyChanged
    {
        public int BusinessEntityID
        {
            get
            {
                return this._BusinessEntityID;
            }
            set
            {
                this._BusinessEntityID = value;
                this.OnPropertyChanged("BusinessEntityID");
            }
        }
        private int _BusinessEntityID;
        public System.Nullable<int> TerritoryID
        {
            get
            {
                return this._TerritoryID;
            }
            set
            {
                this._TerritoryID = value;
                this.OnPropertyChanged("TerritoryID");
            }
        }
        private System.Nullable<int> _TerritoryID;
        public System.Nullable<decimal> SalesQuota
        {
            get
            {
                return this._SalesQuota;
            }
            set
            {
                this._SalesQuota = value;
                this.OnPropertyChanged("SalesQuota");
            }
        }
        private System.Nullable<decimal> _SalesQuota;
        public decimal Bonus
        {
            get
            {
                return this._Bonus;
            }
            set
            {
                this._Bonus = value;
                this.OnPropertyChanged("Bonus");
            }
        }
        private decimal _Bonus;
        public decimal CommissionPct
        {
            get
            {
                return this._CommissionPct;
            }
            set
            {
                this._CommissionPct = value;
                this.OnPropertyChanged("CommissionPct");
            }
        }
        private decimal _CommissionPct;
        public decimal SalesYTD
        {
            get
            {
                return this._SalesYTD;
            }
            set
            {
                this._SalesYTD = value;
                this.OnPropertyChanged("SalesYTD");
            }
        }
        private decimal _SalesYTD;
        public decimal SalesLastYear
        {
            get
            {
                return this._SalesLastYear;
            }
            set
            {
                this._SalesLastYear = value;
                this.OnPropertyChanged("SalesLastYear");
            }
        }
        private decimal _SalesLastYear;
        public System.Guid rowguid
        {
            get
            {
                return this._rowguid;
            }
            set
            {
                this._rowguid = value;
                this.OnPropertyChanged("rowguid");
            }
        }
        private System.Guid _rowguid;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public ObservableCollection<SalesOrderHeader> SalesOrderHeaders
        {
            get
            {
                return this._SalesOrderHeaders;
            }
            set
            {
                this._SalesOrderHeaders = value;
                this.OnPropertyChanged("SalesOrderHeaders");
            }
        }
        private ObservableCollection<SalesOrderHeader> _SalesOrderHeaders = new ObservableCollection<SalesOrderHeader>();
        public SalesTerritory SalesTerritory
        {
            get
            {
                return this._SalesTerritory;
            }
            set
            {
                this._SalesTerritory = value;
                this.OnPropertyChanged("SalesTerritory");
            }
        }
        private SalesTerritory _SalesTerritory;
        public ObservableCollection<SalesPersonQuotaHistory> SalesPersonQuotaHistories
        {
            get
            {
                return this._SalesPersonQuotaHistories;
            }
            set
            {
                this._SalesPersonQuotaHistories = value;
                this.OnPropertyChanged("SalesPersonQuotaHistories");
            }
        }
        private ObservableCollection<SalesPersonQuotaHistory> _SalesPersonQuotaHistories = new ObservableCollection<SalesPersonQuotaHistory>();
        public ObservableCollection<SalesTerritoryHistory> SalesTerritoryHistories
        {
            get
            {
                return this._SalesTerritoryHistories;
            }
            set
            {
                this._SalesTerritoryHistories = value;
                this.OnPropertyChanged("SalesTerritoryHistories");
            }
        }
        private ObservableCollection<SalesTerritoryHistory> _SalesTerritoryHistories = new ObservableCollection<SalesTerritoryHistory>();
        public ObservableCollection<Store> Stores
        {
            get
            {
                return this._Stores;
            }
            set
            {
                this._Stores = value;
                this.OnPropertyChanged("Stores");
            }
        }
        private ObservableCollection<Store> _Stores = new ObservableCollection<Store>();
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    public partial class SalesPersonQuotaHistory : System.ComponentModel.INotifyPropertyChanged
    {
        public int BusinessEntityID
        {
            get
            {
                return this._BusinessEntityID;
            }
            set
            {
                this._BusinessEntityID = value;
                this.OnPropertyChanged("BusinessEntityID");
            }
        }
        private int _BusinessEntityID;
        public System.DateTime QuotaDate
        {
            get
            {
                return this._QuotaDate;
            }
            set
            {
                this._QuotaDate = value;
                this.OnPropertyChanged("QuotaDate");
            }
        }
        private System.DateTime _QuotaDate;
        public decimal SalesQuota
        {
            get
            {
                return this._SalesQuota;
            }
            set
            {
                this._SalesQuota = value;
                this.OnPropertyChanged("SalesQuota");
            }
        }
        private decimal _SalesQuota;
        public System.Guid rowguid
        {
            get
            {
                return this._rowguid;
            }
            set
            {
                this._rowguid = value;
                this.OnPropertyChanged("rowguid");
            }
        }
        private System.Guid _rowguid;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public SalesPerson SalesPerson
        {
            get
            {
                return this._SalesPerson;
            }
            set
            {
                this._SalesPerson = value;
                this.OnPropertyChanged("SalesPerson");
            }
        }
        private SalesPerson _SalesPerson;
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    public partial class SalesReason : System.ComponentModel.INotifyPropertyChanged
    {
        public int SalesReasonID
        {
            get
            {
                return this._SalesReasonID;
            }
            set
            {
                this._SalesReasonID = value;
                this.OnPropertyChanged("SalesReasonID");
            }
        }
        private int _SalesReasonID;
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this._Name = value;
                this.OnPropertyChanged("Name");
            }
        }
        private string _Name;
        public string ReasonType
        {
            get
            {
                return this._ReasonType;
            }
            set
            {
                this._ReasonType = value;
                this.OnPropertyChanged("ReasonType");
            }
        }
        private string _ReasonType;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public ObservableCollection<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons
        {
            get
            {
                return this._SalesOrderHeaderSalesReasons;
            }
            set
            {
                this._SalesOrderHeaderSalesReasons = value;
                this.OnPropertyChanged("SalesOrderHeaderSalesReasons");
            }
        }
        private ObservableCollection<SalesOrderHeaderSalesReason> _SalesOrderHeaderSalesReasons = new ObservableCollection<SalesOrderHeaderSalesReason>();
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    public partial class SalesTaxRate : System.ComponentModel.INotifyPropertyChanged
    {
        public int SalesTaxRateID
        {
            get
            {
                return this._SalesTaxRateID;
            }
            set
            {
                this._SalesTaxRateID = value;
                this.OnPropertyChanged("SalesTaxRateID");
            }
        }
        private int _SalesTaxRateID;
        public int StateProvinceID
        {
            get
            {
                return this._StateProvinceID;
            }
            set
            {
                this._StateProvinceID = value;
                this.OnPropertyChanged("StateProvinceID");
            }
        }
        private int _StateProvinceID;
        public byte TaxType
        {
            get
            {
                return this._TaxType;
            }
            set
            {
                this._TaxType = value;
                this.OnPropertyChanged("TaxType");
            }
        }
        private byte _TaxType;
        public decimal TaxRate
        {
            get
            {
                return this._TaxRate;
            }
            set
            {
                this._TaxRate = value;
                this.OnPropertyChanged("TaxRate");
            }
        }
        private decimal _TaxRate;
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this._Name = value;
                this.OnPropertyChanged("Name");
            }
        }
        private string _Name;
        public System.Guid rowguid
        {
            get
            {
                return this._rowguid;
            }
            set
            {
                this._rowguid = value;
                this.OnPropertyChanged("rowguid");
            }
        }
        private System.Guid _rowguid;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public StateProvince StateProvince
        {
            get
            {
                return this._StateProvince;
            }
            set
            {
                this._StateProvince = value;
                this.OnPropertyChanged("StateProvince");
            }
        }
        private StateProvince _StateProvince;
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    public partial class SalesTerritory : System.ComponentModel.INotifyPropertyChanged
    {
        public int TerritoryID
        {
            get
            {
                return this._TerritoryID;
            }
            set
            {
                this._TerritoryID = value;
                this.OnPropertyChanged("TerritoryID");
            }
        }
        private int _TerritoryID;
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this._Name = value;
                this.OnPropertyChanged("Name");
            }
        }
        private string _Name;
        public string CountryRegionCode
        {
            get
            {
                return this._CountryRegionCode;
            }
            set
            {
                this._CountryRegionCode = value;
                this.OnPropertyChanged("CountryRegionCode");
            }
        }
        private string _CountryRegionCode;
        public string Group
        {
            get
            {
                return this._Group;
            }
            set
            {
                this._Group = value;
                this.OnPropertyChanged("Group");
            }
        }
        private string _Group;
        public decimal SalesYTD
        {
            get
            {
                return this._SalesYTD;
            }
            set
            {
                this._SalesYTD = value;
                this.OnPropertyChanged("SalesYTD");
            }
        }
        private decimal _SalesYTD;
        public decimal SalesLastYear
        {
            get
            {
                return this._SalesLastYear;
            }
            set
            {
                this._SalesLastYear = value;
                this.OnPropertyChanged("SalesLastYear");
            }
        }
        private decimal _SalesLastYear;
        public decimal CostYTD
        {
            get
            {
                return this._CostYTD;
            }
            set
            {
                this._CostYTD = value;
                this.OnPropertyChanged("CostYTD");
            }
        }
        private decimal _CostYTD;
        public decimal CostLastYear
        {
            get
            {
                return this._CostLastYear;
            }
            set
            {
                this._CostLastYear = value;
                this.OnPropertyChanged("CostLastYear");
            }
        }
        private decimal _CostLastYear;
        public System.Guid rowguid
        {
            get
            {
                return this._rowguid;
            }
            set
            {
                this._rowguid = value;
                this.OnPropertyChanged("rowguid");
            }
        }
        private System.Guid _rowguid;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public CountryRegion CountryRegion
        {
            get
            {
                return this._CountryRegion;
            }
            set
            {
                this._CountryRegion = value;
                this.OnPropertyChanged("CountryRegion");
            }
        }
        private CountryRegion _CountryRegion;
        public ObservableCollection<StateProvince> StateProvinces
        {
            get
            {
                return this._StateProvinces;
            }
            set
            {
                this._StateProvinces = value;
                this.OnPropertyChanged("StateProvinces");
            }
        }
        private ObservableCollection<StateProvince> _StateProvinces = new ObservableCollection<StateProvince>();
        public ObservableCollection<Customer> Customers
        {
            get
            {
                return this._Customers;
            }
            set
            {
                this._Customers = value;
                this.OnPropertyChanged("Customers");
            }
        }
        private ObservableCollection<Customer> _Customers = new ObservableCollection<Customer>();
        public ObservableCollection<SalesOrderHeader> SalesOrderHeaders
        {
            get
            {
                return this._SalesOrderHeaders;
            }
            set
            {
                this._SalesOrderHeaders = value;
                this.OnPropertyChanged("SalesOrderHeaders");
            }
        }
        private ObservableCollection<SalesOrderHeader> _SalesOrderHeaders = new ObservableCollection<SalesOrderHeader>();
        public ObservableCollection<SalesPerson> SalesPersons
        {
            get
            {
                return this._SalesPersons;
            }
            set
            {
                this._SalesPersons = value;
                this.OnPropertyChanged("SalesPersons");
            }
        }
        private ObservableCollection<SalesPerson> _SalesPersons = new ObservableCollection<SalesPerson>();
        public ObservableCollection<SalesTerritoryHistory> SalesTerritoryHistories
        {
            get
            {
                return this._SalesTerritoryHistories;
            }
            set
            {
                this._SalesTerritoryHistories = value;
                this.OnPropertyChanged("SalesTerritoryHistories");
            }
        }
        private ObservableCollection<SalesTerritoryHistory> _SalesTerritoryHistories = new ObservableCollection<SalesTerritoryHistory>();
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    public partial class SalesTerritoryHistory : System.ComponentModel.INotifyPropertyChanged
    {
        public int BusinessEntityID
        {
            get
            {
                return this._BusinessEntityID;
            }
            set
            {
                this._BusinessEntityID = value;
                this.OnPropertyChanged("BusinessEntityID");
            }
        }
        private int _BusinessEntityID;
        public int TerritoryID
        {
            get
            {
                return this._TerritoryID;
            }
            set
            {
                this._TerritoryID = value;
                this.OnPropertyChanged("TerritoryID");
            }
        }
        private int _TerritoryID;
        public System.DateTime StartDate
        {
            get
            {
                return this._StartDate;
            }
            set
            {
                this._StartDate = value;
                this.OnPropertyChanged("StartDate");
            }
        }
        private System.DateTime _StartDate;
        public System.Nullable<System.DateTime> EndDate
        {
            get
            {
                return this._EndDate;
            }
            set
            {
                this._EndDate = value;
                this.OnPropertyChanged("EndDate");
            }
        }
        private System.Nullable<System.DateTime> _EndDate;
        public System.Guid rowguid
        {
            get
            {
                return this._rowguid;
            }
            set
            {
                this._rowguid = value;
                this.OnPropertyChanged("rowguid");
            }
        }
        private System.Guid _rowguid;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public SalesPerson SalesPerson
        {
            get
            {
                return this._SalesPerson;
            }
            set
            {
                this._SalesPerson = value;
                this.OnPropertyChanged("SalesPerson");
            }
        }
        private SalesPerson _SalesPerson;
        public SalesTerritory SalesTerritory
        {
            get
            {
                return this._SalesTerritory;
            }
            set
            {
                this._SalesTerritory = value;
                this.OnPropertyChanged("SalesTerritory");
            }
        }
        private SalesTerritory _SalesTerritory;
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    public partial class ShoppingCartItem : System.ComponentModel.INotifyPropertyChanged
    {
        public int ShoppingCartItemID
        {
            get
            {
                return this._ShoppingCartItemID;
            }
            set
            {
                this._ShoppingCartItemID = value;
                this.OnPropertyChanged("ShoppingCartItemID");
            }
        }
        private int _ShoppingCartItemID;
        public string ShoppingCartID
        {
            get
            {
                return this._ShoppingCartID;
            }
            set
            {
                this._ShoppingCartID = value;
                this.OnPropertyChanged("ShoppingCartID");
            }
        }
        private string _ShoppingCartID;
        public int Quantity
        {
            get
            {
                return this._Quantity;
            }
            set
            {
                this._Quantity = value;
                this.OnPropertyChanged("Quantity");
            }
        }
        private int _Quantity;
        public int ProductID
        {
            get
            {
                return this._ProductID;
            }
            set
            {
                this._ProductID = value;
                this.OnPropertyChanged("ProductID");
            }
        }
        private int _ProductID;
        public System.DateTime DateCreated
        {
            get
            {
                return this._DateCreated;
            }
            set
            {
                this._DateCreated = value;
                this.OnPropertyChanged("DateCreated");
            }
        }
        private System.DateTime _DateCreated;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public Product Product
        {
            get
            {
                return this._Product;
            }
            set
            {
                this._Product = value;
                this.OnPropertyChanged("Product");
            }
        }
        private Product _Product;
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    public partial class SpecialOffer : System.ComponentModel.INotifyPropertyChanged
    {
        public int SpecialOfferID
        {
            get
            {
                return this._SpecialOfferID;
            }
            set
            {
                this._SpecialOfferID = value;
                this.OnPropertyChanged("SpecialOfferID");
            }
        }
        private int _SpecialOfferID;
        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this._Description = value;
                this.OnPropertyChanged("Description");
            }
        }
        private string _Description;
        public decimal DiscountPct
        {
            get
            {
                return this._DiscountPct;
            }
            set
            {
                this._DiscountPct = value;
                this.OnPropertyChanged("DiscountPct");
            }
        }
        private decimal _DiscountPct;
        public string Type
        {
            get
            {
                return this._Type;
            }
            set
            {
                this._Type = value;
                this.OnPropertyChanged("Type");
            }
        }
        private string _Type;
        public string Category
        {
            get
            {
                return this._Category;
            }
            set
            {
                this._Category = value;
                this.OnPropertyChanged("Category");
            }
        }
        private string _Category;
        public System.DateTime StartDate
        {
            get
            {
                return this._StartDate;
            }
            set
            {
                this._StartDate = value;
                this.OnPropertyChanged("StartDate");
            }
        }
        private System.DateTime _StartDate;
        public System.DateTime EndDate
        {
            get
            {
                return this._EndDate;
            }
            set
            {
                this._EndDate = value;
                this.OnPropertyChanged("EndDate");
            }
        }
        private System.DateTime _EndDate;
        public int MinQty
        {
            get
            {
                return this._MinQty;
            }
            set
            {
                this._MinQty = value;
                this.OnPropertyChanged("MinQty");
            }
        }
        private int _MinQty;
        public System.Nullable<int> MaxQty
        {
            get
            {
                return this._MaxQty;
            }
            set
            {
                this._MaxQty = value;
                this.OnPropertyChanged("MaxQty");
            }
        }
        private System.Nullable<int> _MaxQty;
        public System.Guid rowguid
        {
            get
            {
                return this._rowguid;
            }
            set
            {
                this._rowguid = value;
                this.OnPropertyChanged("rowguid");
            }
        }
        private System.Guid _rowguid;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public ObservableCollection<SpecialOfferProduct> SpecialOfferProducts
        {
            get
            {
                return this._SpecialOfferProducts;
            }
            set
            {
                this._SpecialOfferProducts = value;
                this.OnPropertyChanged("SpecialOfferProducts");
            }
        }
        private ObservableCollection<SpecialOfferProduct> _SpecialOfferProducts = new ObservableCollection<SpecialOfferProduct>();
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    public partial class SpecialOfferProduct : System.ComponentModel.INotifyPropertyChanged
    {
        public int SpecialOfferID
        {
            get
            {
                return this._SpecialOfferID;
            }
            set
            {
                this._SpecialOfferID = value;
                this.OnPropertyChanged("SpecialOfferID");
            }
        }
        private int _SpecialOfferID;
        public int ProductID
        {
            get
            {
                return this._ProductID;
            }
            set
            {
                this._ProductID = value;
                this.OnPropertyChanged("ProductID");
            }
        }
        private int _ProductID;
        public System.Guid rowguid
        {
            get
            {
                return this._rowguid;
            }
            set
            {
                this._rowguid = value;
                this.OnPropertyChanged("rowguid");
            }
        }
        private System.Guid _rowguid;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public Product Product
        {
            get
            {
                return this._Product;
            }
            set
            {
                this._Product = value;
                this.OnPropertyChanged("Product");
            }
        }
        private Product _Product;
        public ObservableCollection<SalesOrderDetail> SalesOrderDetails
        {
            get
            {
                return this._SalesOrderDetails;
            }
            set
            {
                this._SalesOrderDetails = value;
                this.OnPropertyChanged("SalesOrderDetails");
            }
        }
        private ObservableCollection<SalesOrderDetail> _SalesOrderDetails = new ObservableCollection<SalesOrderDetail>();
        public SpecialOffer SpecialOffer
        {
            get
            {
                return this._SpecialOffer;
            }
            set
            {
                this._SpecialOffer = value;
                this.OnPropertyChanged("SpecialOffer");
            }
        }
        private SpecialOffer _SpecialOffer;
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    public partial class Store : System.ComponentModel.INotifyPropertyChanged
    {
        public int BusinessEntityID
        {
            get
            {
                return this._BusinessEntityID;
            }
            set
            {
                this._BusinessEntityID = value;
                this.OnPropertyChanged("BusinessEntityID");
            }
        }
        private int _BusinessEntityID;
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this._Name = value;
                this.OnPropertyChanged("Name");
            }
        }
        private string _Name;
        public System.Nullable<int> SalesPersonID
        {
            get
            {
                return this._SalesPersonID;
            }
            set
            {
                this._SalesPersonID = value;
                this.OnPropertyChanged("SalesPersonID");
            }
        }
        private System.Nullable<int> _SalesPersonID;
        public string Demographics
        {
            get
            {
                return this._Demographics;
            }
            set
            {
                this._Demographics = value;
                this.OnPropertyChanged("Demographics");
            }
        }
        private string _Demographics;
        public System.Guid rowguid
        {
            get
            {
                return this._rowguid;
            }
            set
            {
                this._rowguid = value;
                this.OnPropertyChanged("rowguid");
            }
        }
        private System.Guid _rowguid;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public BusinessEntity BusinessEntity
        {
            get
            {
                return this._BusinessEntity;
            }
            set
            {
                this._BusinessEntity = value;
                this.OnPropertyChanged("BusinessEntity");
            }
        }
        private BusinessEntity _BusinessEntity;
        public ObservableCollection<Customer> Customers
        {
            get
            {
                return this._Customers;
            }
            set
            {
                this._Customers = value;
                this.OnPropertyChanged("Customers");
            }
        }
        private ObservableCollection<Customer> _Customers = new ObservableCollection<Customer>();
        public SalesPerson SalesPerson
        {
            get
            {
                return this._SalesPerson;
            }
            set
            {
                this._SalesPerson = value;
                this.OnPropertyChanged("SalesPerson");
            }
        }
        private SalesPerson _SalesPerson;
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    public partial class ProductDocument : System.ComponentModel.INotifyPropertyChanged
    {
        public int ProductID
        {
            get
            {
                return this._ProductID;
            }
            set
            {
                this._ProductID = value;
                this.OnPropertyChanged("ProductID");
            }
        }
        private int _ProductID;
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        private System.DateTime _ModifiedDate;
        public Product Product
        {
            get
            {
                return this._Product;
            }
            set
            {
                this._Product = value;
                this.OnPropertyChanged("Product");
            }
        }
        private Product _Product;
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
}
