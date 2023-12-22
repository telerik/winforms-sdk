using System;
using System.Drawing;
using System.Windows.Forms;

using Telerik.WinControls;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;

namespace MedicalAppCS
{
    public partial class AddPatientForm : RadForm
    {
        private ErrorProvider errorProvider;
        
        public AddPatientForm()
        {
            InitializeComponent();
            this.errorProvider = new ErrorProvider();
            (this.photoBrowseEditor.BrowseDialog as OpenFileDialog).Filter = "Image Files|*.jpeg;*.png;*.jpg;*.gif";
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

            PatientsDataSet.PersonsRow person = (PatientsDataSet.PersonsRow)DataSources.PatientsDataSet.Persons.Rows.Add();
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
            this.patientsTableAdapter1.Fill(DataSources.PatientsDataSet.Patients);
            this.personsTableAdapter1.Fill(DataSources.PatientsDataSet.Persons);
            this.personImagesTableAdapter1.Fill(DataSources.PatientsDataSet.PersonImages);
            RadMessageBox.Show(this, "Patient added.");
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
