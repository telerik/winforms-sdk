using System;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace MedicalAppCS
{
    public partial class EditEncounter : UserControl
    {
        private int encounterId;
        private ErrorProvider errorProvider;

        public EditEncounter()
        {
            InitializeComponent();
            this.errorProvider = new ErrorProvider();
        }

        private void Encounter_Load(object sender, EventArgs e)
        {
            this.encounterId = (int)this.Tag;

            this.CustomizeStyles();
            
            // set encounter values
            PatientsDataSet.EncountersRow encounter = DataSources.PatientsDataSet.Encounters.FindById(this.encounterId);
            if (encounter == null)
            {
                this.Close();
                return;
            }
            
            if (encounter["EncounterDatetime"] != DBNull.Value)
            {
                this.encounterStartDateTimePicker.Value = encounter.EncounterDatetime;
            }
            if (encounter["EncounterEndDatetime"] != DBNull.Value)
            {
                this.encounterEndDateTimePicker.Value = encounter.EncounterEndDatetime;
            }
            int primaryDiagnosisId = -1;
            if (encounter["PrimaryDiagnosisId"] != DBNull.Value)
            {
                primaryDiagnosisId = encounter.PrimaryDiagnosisId;
            }
            int secondaryDiagnosisId = -1;
            if (encounter["SecondaryDiagnosisId"] != DBNull.Value)
            {
                secondaryDiagnosisId = encounter.SecondaryDiagnosisId;
            }
            this.primaryDiagnosisDropDownList.BeginUpdate();
            this.secondaryDiagnosisDropDownList.BeginUpdate();
            RadListDataItem primarySelectedItem = null;
            RadListDataItem secondarySelectedItem = null;
            foreach (PatientsDataSet.ConceptsRow concept in DataSources.PatientsDataSet.Concepts)
            {
                RadListDataItem primaryItem = new RadListDataItem(concept.Name, concept.Id);
                this.primaryDiagnosisDropDownList.Items.Add(primaryItem);
                if (primaryDiagnosisId == concept.Id)
                {
                    primarySelectedItem = primaryItem;
                }

                RadListDataItem secondaryItem = new RadListDataItem(concept.Name, concept.Id);
                this.secondaryDiagnosisDropDownList.Items.Add(secondaryItem);
                if (secondaryDiagnosisId == concept.Id)
                {
                    secondarySelectedItem = secondaryItem;
                }
            }
            this.primaryDiagnosisDropDownList.EndUpdate();
            this.secondaryDiagnosisDropDownList.EndUpdate();

            this.primaryDiagnosisDropDownList.SelectedItem = primarySelectedItem;
            this.secondaryDiagnosisDropDownList.SelectedItem = secondarySelectedItem;

            if (encounter["Notes"] != DBNull.Value)
            {
                this.encounterNotesTextBoxControl.Text = encounter.Notes;
            }
            if (encounter["Temperature"] != DBNull.Value)
            {
                this.encounterTemperatureSpinEditor.NullableValue = (decimal)encounter.Temperature;
            }
            if (encounter["Pulse"] != DBNull.Value)
            {
                this.encounterPulseSpinEditor.NullableValue = encounter.Pulse;
            }
            if (encounter["RespiratoryRate"] != DBNull.Value)
            {
                this.encounterRespiratoryRateSpinEditor.NullableValue = encounter.RespiratoryRate;
            }
            if (encounter["BloodPressure"] != DBNull.Value)
            {
                this.encounterBloodPressureMaskedEditBox.Text = encounter.BloodPressure;
            }
            if (encounter["BloodOxygenSaturation"] != DBNull.Value)
            {
                this.encounterBloodOxygenSaturationSpinEditor.NullableValue = encounter.BloodOxygenSaturation;
            }
            if (encounter["Weight"] != DBNull.Value)
            {
                this.encounterWeightSpinEditor.NullableValue = (decimal)encounter.Weight;
            }
            if (encounter["Height"] != DBNull.Value)
            {
                this.encounterHeightSpinEditor.NullableValue = (decimal)encounter.Height;
            }
        }

        private void encounterSaveButton_Click(object sender, EventArgs e)
        {
            if (!this.AreRequiredFieldsValid())
            {
                return;
            }

            PatientsDataSet.EncountersRow encounter = DataSources.PatientsDataSet.Encounters.FindById(this.encounterId);
            encounter.EncounterDatetime = this.encounterStartDateTimePicker.Value;
            encounter.EncounterEndDatetime = this.encounterEndDateTimePicker.Value;
            encounter.PrimaryDiagnosisId = (int)this.primaryDiagnosisDropDownList.SelectedItem.Value;
            if (this.secondaryDiagnosisDropDownList.SelectedItem != null)
            {
                encounter.SecondaryDiagnosisId = (int)this.secondaryDiagnosisDropDownList.SelectedItem.Value;
            }
            if (!string.IsNullOrEmpty(this.encounterNotesTextBoxControl.Text))
            {
                encounter.Notes = this.encounterNotesTextBoxControl.Text;
            }
            if (this.encounterTemperatureSpinEditor.NullableValue != null)
            {
                encounter.Temperature = (double)this.encounterTemperatureSpinEditor.NullableValue;
            }
            if (this.encounterPulseSpinEditor.NullableValue != null)
            {
                encounter.Pulse = (int)this.encounterPulseSpinEditor.NullableValue;
            }
            if (this.encounterRespiratoryRateSpinEditor.NullableValue != null)
            {
                encounter.RespiratoryRate = (int)this.encounterRespiratoryRateSpinEditor.NullableValue;
            }
            if (!string.IsNullOrEmpty(this.encounterBloodPressureMaskedEditBox.Text) && this.encounterBloodPressureMaskedEditBox.Text.Trim() != "/")
            {
                encounter.BloodPressure = this.encounterBloodPressureMaskedEditBox.Text;
            }
            if (this.encounterBloodOxygenSaturationSpinEditor.NullableValue != null)
            {
                encounter.BloodOxygenSaturation = (int)this.encounterBloodOxygenSaturationSpinEditor.NullableValue;
            }
            if (this.encounterWeightSpinEditor.NullableValue != null)
            {
                encounter.Weight = (double)this.encounterWeightSpinEditor.NullableValue;
            }
            if (this.encounterHeightSpinEditor.NullableValue != null)
            {
                encounter.Height = (double)this.encounterHeightSpinEditor.NullableValue;
            }

            this.encountersTableAdapter1.Update(DataSources.PatientsDataSet.Encounters);
            this.encountersTableAdapter1.Fill(DataSources.PatientsDataSet.Encounters);
            this.patientsTableAdapter1.Fill(DataSources.PatientsDataSet.Patients);
            this.Close();
        }

        private void encounterCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Close()
        {
            (this.Parent as Telerik.WinControls.UI.Docking.DocumentWindow).Close();
        }

        private void CustomizeStyles()
        {
            this.encounterStartDateTimePicker.DateTimePickerElement.ShowTimePicker = true;
            this.encounterEndDateTimePicker.DateTimePickerElement.ShowTimePicker = true;
            this.encounterStartDateTimePicker.ThemeName = "MedicalAppTheme";
            this.encounterEndDateTimePicker.ThemeName = "MedicalAppTheme";

            BorderPrimitive border = this.encounterCancelButton.ButtonElement.BorderElement;
            border.ForeColor = Color.FromArgb(171, 173, 179);
            border.Width = 1;
            border.BoxStyle = Telerik.WinControls.BorderBoxStyle.SingleBorder;

            this.encounterCancelButton.ButtonElement.ButtonFillElement.NumberOfColors = 1;
            this.encounterCancelButton.ButtonElement.ButtonFillElement.BackColor = Color.Transparent;

            this.encounterCancelButton.ForeColor = Color.FromArgb(55, 55, 55);
            this.encounterCancelButton.Font = new Font("Segoe UI", 11);
        }

        private bool AreRequiredFieldsValid()
        {
            if (this.encounterStartDateTimePicker.DateTimePickerElement.Value == null)
            {
                this.errorProvider.SetError(this.encounterStartDateTimePicker, "Start date is required");
                return false;
            }
            if (this.encounterEndDateTimePicker.DateTimePickerElement.Value == null)
            {
                this.errorProvider.SetError(this.encounterEndDateTimePicker, "End date is required");
                return false;
            }
            if (this.primaryDiagnosisDropDownList.SelectedItem == null)
            {
                this.errorProvider.SetError(this.primaryDiagnosisDropDownList, "Primary diagnosis is required");
                return false;
            }

            return true;
        }
    }
}
