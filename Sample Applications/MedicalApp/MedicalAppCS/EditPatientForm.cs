using System;
using System.Drawing;
using System.Windows.Forms;

using Telerik.WinControls;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;

namespace MedicalAppCS
{
    public partial class EditPatientForm : RadForm
    {
        private int personId;
        private ErrorProvider errorProvider;
        bool isPuctureBoxValueChanged = false;

        public EditPatientForm()
        {
            InitializeComponent();
            this.errorProvider = new ErrorProvider();
        }

        private void photoBrowseEditor_ValueChanged(object sender, EventArgs e)
        {
            this.isPuctureBoxValueChanged = true;
        }

        private void EditPatientForm_Load(object sender, EventArgs e)
        {
            this.personsTableAdapter1.Fill(DataSources.PatientsDataSet.Persons);

            this.personId = int.Parse(this.Tag.ToString());
            PatientsDataSet.PersonsRow person = DataSources.PatientsDataSet.Persons.FindById(this.personId);
            if (person["FirstName"] != DBNull.Value)
            {
                this.firstNameTextBoxControl.Text = person.FirstName;
            }
            if (person["MiddleName"] != DBNull.Value)
            {
                this.middleNameTextBoxControl.Text = person.MiddleName;
            }
            if (person["FamilyName"] != DBNull.Value)
            {
                this.lastNameTextBoxControl.Text = person.FamilyName;
            }
            if (person["Gender"] != DBNull.Value)
            {
                if (person.Gender == "M")
                {
                    this.genderMaleRadioButton.ToggleState = ToggleState.On;
                }
                else
                {
                    this.genderFemaleRadioButton.ToggleState = ToggleState.On;
                }
            }
            if (person["BirthDate"] != DBNull.Value)
            {
                this.birthDateDateTimePicker.Value = person.BirthDate;
            }
            if (person["City"] != DBNull.Value)
            {
                this.cityTextBoxControl.Text = person.City;
            }
            if (person["State"] != DBNull.Value)
            {
                this.stateTextBoxControl.Text = person.State;
            }
            if (person["Address"] != DBNull.Value)
            {
                this.addressTextBoxControl.Text = person.Address;
            }
            if (person["PostalCode"] != DBNull.Value)
            {
                this.postalCodeTextBoxControl.Text = person.PostalCode;
            }
            if (person["Phone"] != DBNull.Value)
            {
                this.phoneMaskedEditBox.Text = person.Phone;
            }
        }

        private bool AreRequiredFieldsValid()
        {
            if (string.IsNullOrEmpty(this.firstNameTextBoxControl.Text))
            {
                this.errorProvider.SetError(this.firstNameTextBoxControl, "First Name is required.");
                return false;
            }
            if (string.IsNullOrEmpty(this.middleNameTextBoxControl.Text))
            {
                this.errorProvider.SetError(this.middleNameTextBoxControl, "Middle Name is required.");
                return false;
            }
            if (string.IsNullOrEmpty(this.lastNameTextBoxControl.Text))
            {
                this.errorProvider.SetError(this.lastNameTextBoxControl, "Last Name is required.");
                return false;
            }
            if (this.birthDateDateTimePicker.DateTimePickerElement.Value == null)
            {
                this.errorProvider.SetError(this.birthDateDateTimePicker, "Birth date is required.");
                return false;
            }

            return true;
        }
        
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!this.AreRequiredFieldsValid())
            {
                return;
            }

            PatientsDataSet.PersonsRow person = DataSources.PatientsDataSet.Persons.FindById(this.personId);
            person.FirstName = this.firstNameTextBoxControl.Text;
            person.MiddleName = this.middleNameTextBoxControl.Text;
            person.FamilyName = this.lastNameTextBoxControl.Text;
            person.Gender = this.genderMaleRadioButton.ToggleState == ToggleState.On ? "M" : "F";
            person.BirthDate = this.birthDateDateTimePicker.Value;
            person.City = this.cityTextBoxControl.Text;
            person.State = this.stateTextBoxControl.Text;
            person.Address = this.addressTextBoxControl.Text;
            person.PostalCode = this.postalCodeTextBoxControl.Text;
            person.Phone = this.phoneMaskedEditBox.Text;

            string imagePath = this.photoBrowseEditor.Value;
            if (this.isPuctureBoxValueChanged)
            {
                person.PersonImageId = -1;
            }

            if (!string.IsNullOrEmpty(imagePath))
            {
                Image image = Image.FromFile(imagePath);
                Bitmap bitmap = new Bitmap(image, new Size(120, 120));
                ImageConverter imageConverter = new ImageConverter();
                byte[] bytes = (byte[])imageConverter.ConvertTo(bitmap, typeof(byte[]));
                PatientsDataSet.PersonImagesRow personImageRow = (PatientsDataSet.PersonImagesRow)DataSources.PatientsDataSet.PersonImages.Rows.Add();
                personImageRow.Picture = bytes;
                this.personImagesTableAdapter1.Update(DataSources.PatientsDataSet.PersonImages);
                PatientsDataSet.PersonImagesDataTable data = this.personImagesTableAdapter1.GetData();
                personImageRow = data[data.Count - 1];
                person.PersonImageId = personImageRow.Id;
            }

            this.personsTableAdapter1.Update(DataSources.PatientsDataSet.Persons);
            this.personsTableAdapter1.Fill(DataSources.PatientsDataSet.Persons);
            if (this.isPuctureBoxValueChanged)
            {
                this.personImagesTableAdapter1.Fill(DataSources.PatientsDataSet.PersonImages);
            }
            this.patientsTableAdapter1.Fill(DataSources.PatientsDataSet.Patients);
            RadMessageBox.Show(this, "Patient information saved.");
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
