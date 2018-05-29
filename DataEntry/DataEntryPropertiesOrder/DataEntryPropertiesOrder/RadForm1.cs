using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace DataEntryPropertiesOrder
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();

            ThemeResolutionService.ApplicationThemeName = "TelerikMetro";

            this.radDataEntry1.DataSource = new DataEntrySort<Person> { new Person("Smith", "John", new DateTime(1980,1, 1), 12345, "452 Holly Lane Hopewell, VA 23860") };
        }

        public class Person
        {
            [RadSortOrder(3)]
            public string LastName { get; set; }

            [RadSortOrder(2)]
            public string FirstName { get; set; }

            [RadSortOrder(4)]
            public DateTime BirthDate { get; set; }

            [RadSortOrder(1)]
            public int Id { get; set; }

            [RadSortOrder(5)]
            public string Address { get; set; }

            public Person(string lastName, string firstName, DateTime dateOfBirth, int id, string address)
            {
                this.LastName = lastName;
                this.FirstName = firstName;
                this.BirthDate = dateOfBirth;
                this.Id = id;
                this.Address = address;
            }
        }

        public class PropertyDescriptorComparer : System.Collections.IComparer
        {
            public int Compare(object x, object y)
            {
                if (x == y)
                    return 0;
                if (x == null)
                    return 1;
                if (y == null)
                    return -1;
                PropertyDescriptor propertyDescriptorX = x as PropertyDescriptor;
                PropertyDescriptor propertyDescriptorY = y as PropertyDescriptor;
                RadSortOrderAttribute propertyOrderAttributeX =
                    propertyDescriptorX.Attributes[typeof(RadSortOrderAttribute)] as RadSortOrderAttribute;
                RadSortOrderAttribute propertyOrderAttributeY =
                    propertyDescriptorY.Attributes[typeof(RadSortOrderAttribute)] as RadSortOrderAttribute;
                if (Equals(propertyOrderAttributeX, propertyOrderAttributeY))
                    return 0;
                if (propertyOrderAttributeX == null)
                    return 1;
                if (propertyOrderAttributeY == null)
                    return -1;
                return propertyOrderAttributeX.Value.CompareTo(propertyOrderAttributeY.Value);
            }
        }

        public class DataEntrySort<T> : BindingList<T> , ITypedList
        {
            public PropertyDescriptorCollection GetItemProperties(PropertyDescriptor[] listAccessors)
            {
                PropertyDescriptorCollection typePropertiesCollection = TypeDescriptor.GetProperties(typeof(T));
                return typePropertiesCollection.Sort(new PropertyDescriptorComparer());
            }

            public string GetListName(PropertyDescriptor[] listAccessors)
            {
                return string.Format("A list with Properties for {0}", typeof(T).Name);
            }
        }
    }
}