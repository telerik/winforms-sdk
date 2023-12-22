using System;
using System.Drawing;
using System.Windows.Forms;

using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace MedicalAppCS
{
    public partial class AppointmentForm : RadForm
    {
        private int appointmentId = -1;
        private bool editing = false;
        private ErrorProvider errorProvider;

        public AppointmentForm()
        {
            InitializeComponent();
            this.errorProvider = new ErrorProvider();
        }

        private void AddAppointmentForm_Load(object sender, EventArgs e)
        {
            this.startDateTimePicker.DateTimePickerElement.ShowTimePicker = true;
            this.endDateTimePicker.DateTimePickerElement.ShowTimePicker = true;
            this.startDateTimePicker.ThemeName = "MedicalAppTheme";
            this.endDateTimePicker.ThemeName = "MedicalAppTheme";

            int selectedPatientId = -1;
            PatientsDataSet.AppointmentsRow appointmentsRow = this.Tag as PatientsDataSet.AppointmentsRow;
            if (appointmentsRow != null)
            {
                this.appointmentId = appointmentsRow.Id;
                this.editing = true;
                this.Text = "Edit Appointment";
                this.startDateTimePicker.Value = appointmentsRow.Start;
                this.endDateTimePicker.Value = appointmentsRow.End;
                selectedPatientId = appointmentsRow.PersonId;
                if (appointmentsRow["Location"] != DBNull.Value)
                {
                    this.locationTextBoxControl.Text = appointmentsRow.Location;
                }
                if (appointmentsRow["Description"] != DBNull.Value)
                {
                    this.descriptionTextBoxControl.Text = appointmentsRow.Description;
                }
            }

            Appointment appointment = this.Tag as Appointment;
            if (appointment != null)
            {
                this.startDateTimePicker.Value = appointment.Start;
                this.endDateTimePicker.Value = appointment.End;
            }


            RadListDataItem selectedItem = null;
            this.patientsDropDownList.BeginUpdate();
            foreach (PatientsDataSet.PersonsRow person in DataSources.PatientsDataSet.Persons)
            {
                RadListDataItem item = new RadListDataItem(person.FirstName + " " + person.FamilyName, person.Id);
                if (selectedPatientId != -1 && selectedPatientId == person.Id)
                {
                    selectedItem = item;
                }
                this.patientsDropDownList.Items.Add(item);
            }
            this.patientsDropDownList.EndUpdate();
            this.patientsDropDownList.SelectedItem = selectedItem;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!this.AreRequiredFieldsValid())
            {
                return;
            }

            if (this.editing)
            {
                this.EditAppointment();
            }
            else
            {
                this.AddAppointment();
            }

            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddAppointment()
        {
            PatientsDataSet.AppointmentsRow appointment = (PatientsDataSet.AppointmentsRow)DataSources.PatientsDataSet.Appointments.Rows.Add();
            appointment.PersonId = (int)this.patientsDropDownList.SelectedItem.Value;
            appointment.Subject = this.patientsDropDownList.SelectedItem.Text;
            appointment.Start = this.startDateTimePicker.Value;
            appointment.End = this.endDateTimePicker.Value;
            appointment.Location = this.locationTextBoxControl.Text;
            appointment.Description = this.descriptionTextBoxControl.Text;

            this.appointmentsTableAdapter1.Update(DataSources.PatientsDataSet.Appointments);
            this.appointmentsTableAdapter1.Fill(DataSources.PatientsDataSet.Appointments);
            RadMessageBox.Show(this, "Appointment added.");
        }

        private void EditAppointment()
        {
            PatientsDataSet.AppointmentsRow appointment = DataSources.PatientsDataSet.Appointments.FindById(this.appointmentId);
            appointment.PersonId = (int)this.patientsDropDownList.SelectedItem.Value;
            appointment.Subject = this.patientsDropDownList.SelectedItem.Text;
            appointment.Start = this.startDateTimePicker.Value;
            appointment.End = this.endDateTimePicker.Value;
            appointment.Location = this.locationTextBoxControl.Text;
            appointment.Description = this.descriptionTextBoxControl.Text;

            this.appointmentsTableAdapter1.Update(DataSources.PatientsDataSet.Appointments);
            this.appointmentsTableAdapter1.Fill(DataSources.PatientsDataSet.Appointments);
            RadMessageBox.Show(this, "Appointment changed.");
        }

        private bool AreRequiredFieldsValid()
        {
            if (this.patientsDropDownList.SelectedItem == null)
            {
                this.errorProvider.SetError(this.patientsDropDownList, "Patient is required");
                return false;
            }
            if (this.startDateTimePicker.DateTimePickerElement.Value == null)
            {
                this.errorProvider.SetError(this.startDateTimePicker, "Start Date is required");
                return false;
            }
            if (this.endDateTimePicker.DateTimePickerElement.Value == null)
            {
                this.errorProvider.SetError(this.endDateTimePicker, "End Date is required");
                return false;
            }

            return true;
        }
    }
}
