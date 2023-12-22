using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using MedicalAppCS.Properties;

using Telerik.Charting;
using Telerik.WinControls;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Docking;

namespace MedicalAppCS
{
    public partial class PatientEncounters : UserControl
    {
        private int personId = -1;
        private ErrorProvider errorProvider;

        public DateTime CurrentDate
        {
            get { return new DateTime(2015, 6, 17, DateTime.Now.Hour, DateTime.Now.Minute, 0); }
        }

        public PatientEncounters()
        {
            InitializeComponent();
            this.errorProvider = new ErrorProvider();
            RadPageViewItem previewItem = this.documentWindowNewEncounter.TabStripItem;
            RadPageViewStripElement pageViewStripElement = this.radDockPatientEncounters.SplitPanelElement.Children[2].Children[0] as RadPageViewStripElement;
            pageViewStripElement.PreviewItem = previewItem;
            previewItem.ButtonsPanel.CloseButton.Visibility = ElementVisibility.Collapsed;

            this.encounterStartDateTimePicker.DateTimePickerElement.ShowTimePicker = true;
            this.encounterEndDateTimePicker.DateTimePickerElement.ShowTimePicker = true;
            this.encounterStartDateTimePicker.ThemeName = "MedicalAppTheme";
            this.encounterEndDateTimePicker.ThemeName = "MedicalAppTheme";

            BorderPrimitive border = this.encounterCancelButton.ButtonElement.BorderElement;
            border.ForeColor = Color.FromArgb(171, 173, 179);
            border.Width = 1;
            border.BoxStyle = BorderBoxStyle.SingleBorder;
            this.encounterCancelButton.ButtonElement.ButtonFillElement.NumberOfColors = 1;
            this.encounterCancelButton.ButtonElement.ButtonFillElement.BackColor = Color.Transparent;
            this.encounterCancelButton.ForeColor = Color.FromArgb(55, 55, 55);
            this.encounterCancelButton.Font = new Font("Segoe UI", 12);

            this.radDockPatientEncounters.GetService<DragDropService>().Starting += PatientEncounters_Starting;
            foreach (DockWindow dw in this.radDockPatientEncounters.DockWindows)
            {
                dw.AllowedDockState = ~AllowedDockState.Floating;
            }

            ((System.ComponentModel.ISupportInitialize)(this.encountersBindingSource)).BeginInit();
            this.encountersBindingSource.DataMember = "Encounters";
            this.encountersBindingSource.DataSource = DataSources.PatientsDataSet;
            ((System.ComponentModel.ISupportInitialize)(this.encountersBindingSource)).EndInit();
            this.encountersBindingSource.ListChanged += encountersBindingSource_ListChanged;
        }

        private void encountersBindingSource_ListChanged(object sender, System.ComponentModel.ListChangedEventArgs e)
        {
            PatientsDataSet.EncountersDataTable encounters = DataSources.PatientsDataSet.Encounters;
            DataRow[] personEncounters = encounters.Select("PersonId = " + this.personId);
            this.UpdateConditions(personEncounters);
            this.UpdateChartData(personEncounters);
            this.UpdateBMIfields(personEncounters);
            this.FillEncountersListView(personEncounters);
        }

        private void PatientEncounters_Starting(object sender, StateServiceStartingEventArgs e)
        {
            e.Cancel = true;
        }

        private void PatientEncounters_Load(object sender, EventArgs e)
        {
            this.personId = (int)this.Tag;
            this.FillPersonInfo();
            PatientsDataSet.EncountersDataTable encounters = DataSources.PatientsDataSet.Encounters;
            DataRow[] personEncounters = encounters.Select("PersonId = " + this.personId);

            // Summary tab
            this.documentWindowSummary.TabStripItem.CloseButton.Visibility = ElementVisibility.Collapsed;
            this.summaryChartView.ChartElement.TitleElement.PositionOffset = new SizeF(110, 2);
            this.summaryChartView.ChartElement.TitleElement.Font = new Font("Segoe UI", 10.5f);
            this.UpdateConditions(personEncounters);
            this.UpdateChartData(personEncounters);
            this.UpdateBMIfields(personEncounters);

            // History tab 
            this.documentWindowHistory.TabStripItem.CloseButton.Visibility = ElementVisibility.Collapsed;
            this.FillEncountersListView(personEncounters);

            // New encounter tab
            this.documentWindowNewEncounter.TabStripItem.CloseButton.Visibility = ElementVisibility.Collapsed;
            this.FillDiagnosisDropDownLists();

            this.ClearEncounterValues();
        }

        private void EditPatientInfoButton_Click(object sender, EventArgs e)
        {
            EditPatientForm editPatientForm = new EditPatientForm();
            editPatientForm.Tag = this.personId;
            editPatientForm.StartPosition = FormStartPosition.CenterParent;
            editPatientForm.ShowDialog(this);

            this.FillPersonInfo();
        }

        private void radDockPatientEncounters_DockWindowClosing(object sender, DockWindowCancelEventArgs e)
        {
            if (e.NewWindow == this.documentWindowSummary || e.NewWindow == this.documentWindowHistory || e.NewWindow == this.documentWindowNewEncounter)
            {
                e.Cancel = true;
            }
        }

        public void UpdateControlsData()
        {
            PatientsDataSet.EncountersDataTable encounters = DataSources.PatientsDataSet.Encounters;
            DataRow[] personEncounters = encounters.Select("PersonId = " + this.personId);
            this.UpdateConditions(personEncounters);
            this.UpdateChartData(personEncounters);
            this.UpdateBMIfields(personEncounters);
            this.FillEncountersListView(personEncounters);
        }

        private void FillPersonInfo()
        {
            PatientsDataSet.PersonsRow person = DataSources.PatientsDataSet.Persons.FindById(this.personId);
            this.patientNameLabel.Text = person.FirstName + " " + person.FamilyName;
            DateTime today = CurrentDate;
            int age = today.Year - person.BirthDate.Year;
            if (person.BirthDate > today.AddYears(-age))
            {
                age--;
            }
            this.patientInformationLabel.Text = string.Format("{0} yo | {1} | {2}", age.ToString(), person.Gender == "M" ? "male" : "female", person.BirthDate.ToString("d-M-yyyy"));
            this.addressCityLabel.Text = person.City + ", " + person.State;
            this.addressStreetLabel.Text = person.Address + " " + person.PostalCode;
            this.phoneLabel.Text = person.Phone;

            int personImageId = -1;
            if (person["PersonImageId"] != DBNull.Value)
            {
                personImageId = person.PersonImageId;
            }
            PatientsDataSet.PersonImagesRow personImage = DataSources.PatientsDataSet.PersonImages.FindById(personImageId);
            Image image;
            if (personImage != null && personImage["Picture"] != DBNull.Value)
            {
                using (System.IO.MemoryStream ms = new System.IO.MemoryStream(personImage.Picture))
                {
                    image = Image.FromStream(ms);
                }
            }
            else
            {
                image = Resources.no_image;
            }

            Bitmap bitmap = new Bitmap(image, new Size(114, 114));
            this.patientImageLabel.Image = bitmap;
        }

        #region Summary

        private void summaryChartView_LabelFormatting(object sender, ChartViewLabelFormattingEventArgs e)
        {
            e.LabelElement.BackColor = Color.White;
            e.LabelElement.BorderColor = e.LabelElement.DataPointElement.BackColor;
            e.LabelElement.Shape = null;
        }

        private void summaryChartView_SelectedPointChanged(object sender, ChartViewSelectedPointChangedEventArgs e)
        {
            if (e.OldSelectedPoint != null)
            {
                (e.OldSelectedPoint.Presenter as LineSeries).ShowLabels = false;
            }

            if (e.NewSelectedPoint != null)
            {
                (e.NewSelectedPoint.Presenter as LineSeries).ShowLabels = true;
            }
        }

        private void UpdateConditions(DataRow[] personEncounters)
        {
            this.summaryConditionsListControl.Items.Clear();
            foreach (DataRow row in personEncounters)
            {
                int primaryId;
                if (int.TryParse(row["PrimaryDiagnosisId"].ToString(), out primaryId))
                {
                    PatientsDataSet.ConceptsRow concept = DataSources.PatientsDataSet.Concepts.FindById(primaryId);
                    RadListDataItem item = new RadListDataItem(concept.Name);
                    item.TextWrap = true;
                    this.summaryConditionsListControl.Items.Add(item);
                }

                int secondaryId;
                if (int.TryParse(row["SecondaryDiagnosisId"].ToString(), out secondaryId))
                {
                    PatientsDataSet.ConceptsRow concept = DataSources.PatientsDataSet.Concepts.FindById(secondaryId);
                    RadListDataItem item = new RadListDataItem(concept.Name);
                    item.TextWrap = true;
                    this.summaryConditionsListControl.Items.Add(item);
                }
            }
        }

        private void UpdateBMIfields(DataRow[] personEncounters)
        {
            PatientsDataSet.EncountersRow latestEncounter = null;
            foreach (PatientsDataSet.EncountersRow encounter in personEncounters)
            {
                if (encounter["Weight"] != DBNull.Value && encounter["Height"] != DBNull.Value)
                {
                    if (latestEncounter != null)
                    {
                        DateTime currentEncounterDateTime = (DateTime)encounter["EncounterDatetime"];
                        if (currentEncounterDateTime > latestEncounter.EncounterDatetime)
                        {
                            latestEncounter = encounter;
                        }
                    }
                    else
                    {
                        latestEncounter = encounter;
                    }
                }
            }

            if (latestEncounter != null)
            {
                this.summaryHeightLabel.Text = latestEncounter.Height + " cm";
                this.summaryWeightLabel.Text = latestEncounter.Weight + " kg";
                double heightInMeters = latestEncounter.Height / 100;
                double bmi = latestEncounter.Weight / (heightInMeters * heightInMeters);
                this.summaryBMILabel.Text = Math.Round(bmi).ToString();
                string category;
                Color bmiCategoryColor;
                if (bmi < 18.5)
                {
                    category = "UNDERWEIGHT";
                    bmiCategoryColor = Color.FromArgb(62, 201, 228);
                }
                else if (bmi < 25)
                {
                    category = "NORMAL";
                    bmiCategoryColor = Color.FromArgb(174, 215, 151);
                }
                else if (bmi < 30)
                {
                    category = "OVERWEIGHT";
                    bmiCategoryColor = Color.FromArgb(255, 192, 82);
                }
                else
                {
                    category = "OBESE";
                    bmiCategoryColor = Color.FromArgb(233, 88, 52);
                }

                this.summaryBMICategoryLabel.Text = category;
                this.summaryBMICategoryLabel.ForeColor = bmiCategoryColor;
                this.summaryBMIRadialGauge.Value = (float)bmi;
            }
            else
            {
                this.summaryHeightLabel.Text = string.Empty;
                this.summaryWeightLabel.Text = string.Empty;
                this.summaryBMICategoryLabel.Text = string.Empty;
                this.summaryBMILabel.Text = string.Empty;
                this.summaryBMIRadialGauge.Value = 0;
            }
        }

        private void UpdateChartData(DataRow[] personEncounters)
        {
            this.summaryChartView.Axes.Clear();
            this.summaryChartView.Series.Clear();

            DateTimeCategoricalAxis horizontalAxis = new DateTimeCategoricalAxis();
            horizontalAxis.PlotMode = AxisPlotMode.BetweenTicks;
            horizontalAxis.LabelFormat = "{0:dd-MM-yyyy}";

            LinearAxis verticalAxis = new LinearAxis();
            verticalAxis.AxisType = AxisType.Second;
            verticalAxis.Minimum = 0;
            verticalAxis.Maximum = 100;
            verticalAxis.DesiredTickCount = 6;
            verticalAxis.LastLabelVisibility = AxisLastLabelVisibility.Hidden;
            verticalAxis.LabelFormatProvider = new CustomFormatProvider();

            LineSeries lineSaO2 = this.CreateLineSeries(new StarShape(), Color.FromArgb(137, 142, 246), new SizeF(15, 15));
            lineSaO2.HorizontalAxis = horizontalAxis;
            lineSaO2.VerticalAxis = verticalAxis;

            CustomShape triangle = new CustomShape();
            triangle.CreateClosedShape(this.CreateInitialShape(3, 6));
            LineSeries lineBlPr = this.CreateLineSeries(triangle, Color.FromArgb(93, 82, 85), new SizeF(10, 10));
            lineBlPr.HorizontalAxis = horizontalAxis;
            lineBlPr.VerticalAxis = verticalAxis;

            LineSeries lineRespRate = this.CreateLineSeries(new RoundRectShape(0), Color.FromArgb(255, 192, 82), new SizeF(8, 8));
            lineRespRate.HorizontalAxis = horizontalAxis;
            lineRespRate.VerticalAxis = verticalAxis;

            LineSeries linePulse = this.CreateLineSeries(new DiamondShape(), Color.FromArgb(222, 88, 88), new SizeF(12, 12));
            linePulse.HorizontalAxis = horizontalAxis;
            linePulse.VerticalAxis = verticalAxis;

            LineSeries lineTemp = this.CreateLineSeries(null, Color.FromArgb(106, 214, 231), new SizeF(8, 8));
            lineTemp.HorizontalAxis = horizontalAxis;
            lineTemp.VerticalAxis = verticalAxis;

            foreach (PatientsDataSet.EncountersRow row in personEncounters)
            {
                if (row["BloodOxygenSaturation"] != DBNull.Value)
                {
                    int saO2Value = this.ScaleChartValue(row.BloodOxygenSaturation, 85, 100, 80, 100);
                    CategoricalDataPoint saO2Point = new CategoricalDataPoint(saO2Value, row.EncounterDatetime);
                    saO2Point.Label = row.BloodOxygenSaturation;
                    lineSaO2.DataPoints.Add(saO2Point);
                }
                if (row["BloodPressure"] != DBNull.Value)
                {
                    string[] values = row.BloodPressure.Split(new char[] { '/' });
                    int systolic = this.ScaleChartValue(int.Parse(values[0]), 70, 190, 60, 80);
                    int diastolic = this.ScaleChartValue(int.Parse(values[1]), 40, 100, 60, 80);
                    int blPressureValue = (systolic + diastolic) / 2;
                    CategoricalDataPoint blPrPoint = new CategoricalDataPoint(blPressureValue, row.EncounterDatetime);
                    blPrPoint.Label = row.BloodPressure;
                    lineBlPr.DataPoints.Add(blPrPoint);
                }
                if (row["RespiratoryRate"] != DBNull.Value)
                {
                    int respRateValue = this.ScaleChartValue(row.RespiratoryRate, 12, 28, 40, 60);
                    CategoricalDataPoint respRatePoint = new CategoricalDataPoint(respRateValue, row.EncounterDatetime);
                    respRatePoint.Label = row.RespiratoryRate;
                    lineRespRate.DataPoints.Add(respRatePoint);
                }
                if (row["Pulse"] != DBNull.Value)
                {
                    int pulseValue = this.ScaleChartValue(row.Pulse, 50, 150, 20, 40);
                    CategoricalDataPoint pulsePoint = new CategoricalDataPoint(pulseValue, row.EncounterDatetime);
                    pulsePoint.Label = row.Pulse + "/min";
                    linePulse.DataPoints.Add(pulsePoint);
                }
                if (row["Temperature"] != DBNull.Value)
                {
                    int tempValue = this.ScaleChartValue(row.Temperature, 32, 40, 0, 20);
                    CategoricalDataPoint tempPoint = new CategoricalDataPoint(tempValue, row.EncounterDatetime);
                    tempPoint.Label = row.Temperature;
                    lineTemp.DataPoints.Add(tempPoint);
                }
            }

            this.summaryChartView.Series.Add(lineSaO2);
            this.summaryChartView.Series.Add(lineBlPr);
            this.summaryChartView.Series.Add(lineRespRate);
            this.summaryChartView.Series.Add(linePulse);
            this.summaryChartView.Series.Add(lineTemp);
            CartesianGrid grid = this.summaryChartView.GetArea<CartesianArea>().GetGrid<CartesianGrid>();
            grid.AlternatingHorizontalColor = false;

            for (int i = 0; i < verticalAxis.Children.Count; i++)
            {
                AxisLabelElement label = verticalAxis.Children[i] as AxisLabelElement;

                if (label != null)
                {
                    label.PositionOffset = new PointF(0, -20);
                }
            }
        }

        private LineSeries CreateLineSeries(ElementShape shape, Color backColor, SizeF pointSize)
        {
            LineSeries lineSeries = new LineSeries();
            lineSeries.Shape = shape;
            lineSeries.BorderColor = Color.Transparent;
            lineSeries.BackColor = backColor;
            lineSeries.PointSize = pointSize;
            return lineSeries;
        }

        private List<PointF> CreateInitialShape(int vertices, double radius1)
        {
            List<PointF> pts = new List<PointF>();

            if (radius1 == 0) return null;

            for (int i = 0; i < vertices; i++)
            {
                double angle1 = ((4.0 * i - vertices) * Math.PI) / (2.0f * vertices);
                pts.Add(new PointF((float)(Math.Cos(angle1) * radius1), (float)(Math.Sin(angle1) * radius1)));
            }

            return pts;
        }

        private int ScaleChartValue(double value, double minValue, double maxValue, int startRange, int endRange)
        {
            if (value <= minValue)
            {
                return startRange;
            }
            else if (maxValue <= value)
            {
                return endRange;
            }

            int ticksCount = endRange - startRange;
            double coef = (value - minValue) / (maxValue - minValue);

            return (int)(ticksCount * coef) + startRange;
        }

        #endregion

        #region History

        private void historyEditEncounterButton_Click(object sender, EventArgs e)
        {
            this.CreateEditEncounterDocumentWindow();
        }

        private void historyEncountersListView_VisualItemCreating(object sender, ListViewVisualItemCreatingEventArgs e)
        {
            PatientsListViewVisualItem patientsItem = new PatientsListViewVisualItem();
            patientsItem.TopRightElement.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            patientsItem.Padding = new Padding(5, 0, 0, 0);
            e.VisualItem = patientsItem;
        }

        private void historyEncountersListView_VisualItemFormatting(object sender, ListViewVisualItemEventArgs e)
        {
            if (!e.VisualItem.Data.Selected && this.historyEncountersListView.Items.IndexOf(e.VisualItem.Data) % 2 != 0)
            {
                e.VisualItem.BackColor = Color.FromArgb(250, 250, 250);
            }
            else
            {
                e.VisualItem.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local);
            }

            DateTime date = (DateTime)e.VisualItem.Data["Date"];
            e.VisualItem.Text =
                "<html>" +
                    "<span style=\"color:#262626;font-size:11pt;font-family:Segoe UI;\">" + date.ToString("d MMM yyyy") + "</span>" +
                    "<br>" +
                    "<span style=\"color:#006DC0;font-size:16pt;font-family:Segoe UI;\">" + e.VisualItem.Data["PrimaryDiagnosisName"] + "</span>" +
                "</html>";

            (e.VisualItem as PatientsListViewVisualItem).TopRightElement.Text = (bool)e.VisualItem.Data["Hospitalized"] ? "INPATIENT" : "OUTPATIENT";
        }

        private void historyEncountersListView_SelectedItemChanged(object sender, EventArgs e)
        {
            ListViewDataItem item = this.historyEncountersListView.SelectedItem;
            if (item == null)
            {
                return;
            }
            int encounterId = (int)item["EncounterId"];
            PatientsDataSet.EncountersRow encounter = DataSources.PatientsDataSet.Encounters.FindById(encounterId);

            this.historyEncounterDateLabel.Text = encounter.EncounterDatetime.ToString("d MMM yyyy | HH:mm");
            PatientsDataSet.ConceptsRow concept = DataSources.PatientsDataSet.Concepts.FindById(encounter.PrimaryDiagnosisId);
            this.historyPrimaryDiagnosisLabel.Text = concept.Name;
            if (encounter["SecondaryDiagnosisId"] != DBNull.Value)
            {
                concept = DataSources.PatientsDataSet.Concepts.FindById(encounter.SecondaryDiagnosisId);
                this.historySecondaryDiagnosisLabel.Text = concept.Name;
            }
            else
            {
                this.historySecondaryDiagnosisLabel.Text = string.Empty;
            }

            if (encounter["Notes"] != DBNull.Value && !String.IsNullOrEmpty(Convert.ToString(encounter["Notes"])))
            {
                this.historyNotesLabel.Text = encounter.Notes;
            }
            else
            {
                this.radLabel14.Visible = false;
                this.historyNotesLabel.Text = string.Empty;
            }
        }

        private void historyEncountersListView_DoubleClick(object sender, EventArgs e)
        {
            this.CreateEditEncounterDocumentWindow();
        }

        private void FillEncountersListView(DataRow[] personEncounters)
        {
            DataTable encountersTable = new DataTable();
            encountersTable.Columns.Add("EncounterId", typeof(int));
            encountersTable.Columns.Add("Date", typeof(DateTime));
            encountersTable.Columns.Add("ConceptId", typeof(int));
            encountersTable.Columns.Add("PrimaryDiagnosisName", typeof(string));
            encountersTable.Columns.Add("Hospitalized", typeof(bool));
            for (int i = 0; i < personEncounters.Length; i++)
            {
                PatientsDataSet.EncountersRow encounter = (PatientsDataSet.EncountersRow)personEncounters[i];
                if (encounter["PrimaryDiagnosisId"] != DBNull.Value)
                {
                    PatientsDataSet.ConceptsRow concept = DataSources.PatientsDataSet.Concepts.FindById(encounter.PrimaryDiagnosisId);
                    bool hospitalized = encounter.EncounterEndDatetime.DayOfYear != encounter.EncounterDatetime.DayOfYear;
                    encountersTable.Rows.Add(encounter.Id, encounter.EncounterDatetime, encounter.PrimaryDiagnosisId, concept.Name, hospitalized);
                }
            }

            DataView dataView = encountersTable.DefaultView;
            dataView.Sort = "Date DESC";

            encountersTable = dataView.ToTable();

            this.historyEncountersListView.DataSource = null;
            bool encountersExist = personEncounters.Length != 0;

            foreach (Control control in this.documentWindowHistory.Controls)
            {
                control.Visible = encountersExist;
            }

            foreach (Control control in this.documentWindowSummary.Controls)
            {
                control.Visible = encountersExist;
            }

            this.summaryNoEncountersLabel.Visible = !encountersExist;
            this.historyNoEncountersLabel.Visible = !encountersExist;

            if (encountersExist)
            {
                this.historyEncountersListView.DataSource = encountersTable;
                this.historyEncountersListView.SelectedIndex = 0;
            }
        }

        private void CreateEditEncounterDocumentWindow()
        {
            DocumentWindow editEncounterDocumentWindow = new DocumentWindow();
            editEncounterDocumentWindow.DocumentButtons = DocumentStripButtons.None;

            ListViewDataItem item = this.historyEncountersListView.SelectedItem;
            if (item == null)
            {
                return;
            }
            int encounterId = (int)item["EncounterId"];

            EditEncounter editEncounter = new EditEncounter();
            editEncounter.Tag = encounterId;

            editEncounterDocumentWindow.Controls.Add(editEncounter);
            DateTime encounterDate = (DateTime)item["Date"];
            editEncounterDocumentWindow.Text = encounterDate.ToString("d MMM yyyy");

            this.documentTabStrip1.Controls.Add(editEncounterDocumentWindow);
            editEncounterDocumentWindow.Select();
        }

        #endregion

        #region New encounter

        private void encounterSaveButton_Click(object sender, EventArgs e)
        {
            if (!this.AreRequiredFieldsValid())
            {
                return;
            }

            PatientsDataSet.EncountersRow encounter = (PatientsDataSet.EncountersRow)DataSources.PatientsDataSet.Encounters.Rows.Add();
            encounter.PersonId = this.personId;
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

            this.ClearEncounterValues();
            this.documentWindowSummary.Select();
        }

        private void encounterCancelButton_Click(object sender, EventArgs e)
        {
            this.ClearEncounterValues();
            this.documentTabStrip1.SelectedTab = this.documentWindowSummary;
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

        private void ClearEncounterValues()
        {
            this.encounterStartDateTimePicker.DateTimePickerElement.Value = null;
            this.encounterEndDateTimePicker.DateTimePickerElement.Value = null;
            this.primaryDiagnosisDropDownList.SelectedItem = null;
            this.secondaryDiagnosisDropDownList.SelectedItem = null;
            this.encounterNotesTextBoxControl.Text = string.Empty;
            this.encounterTemperatureSpinEditor.NullableValue = null;
            this.encounterPulseSpinEditor.NullableValue = null;
            this.encounterRespiratoryRateSpinEditor.NullableValue = null;
            this.encounterBloodPressureMaskedEditBox.Text = string.Empty;
            this.encounterBloodOxygenSaturationSpinEditor.NullableValue = null;
            this.encounterWeightSpinEditor.NullableValue = null;
            this.encounterHeightSpinEditor.NullableValue = null;
        }

        private void FillDiagnosisDropDownLists()
        {
            this.primaryDiagnosisDropDownList.BeginUpdate();
            this.secondaryDiagnosisDropDownList.BeginUpdate();
            foreach (PatientsDataSet.ConceptsRow concept in DataSources.PatientsDataSet.Concepts)
            {
                this.primaryDiagnosisDropDownList.Items.Add(new RadListDataItem(concept.Name, concept.Id));
                this.secondaryDiagnosisDropDownList.Items.Add(new RadListDataItem(concept.Name, concept.Id));
            }
            this.primaryDiagnosisDropDownList.EndUpdate();
            this.secondaryDiagnosisDropDownList.EndUpdate();
        }

        #endregion
    }

    public class CustomFormatProvider : ICustomFormatter, IFormatProvider
    {
        public object GetFormat(Type formatType)
        {
            return this;
        }

        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            int num = int.Parse(arg.ToString());
            switch (num)
            {
                case 0:
                    return "Temperature";
                case 20:
                    return "Pulse";
                case 40:
                    return "Respiratory" + Environment.NewLine + "rate";
                case 60:
                    return "Blood" + Environment.NewLine + "pressure";
                case 80:
                    return "Blood" + Environment.NewLine + "oxygen" + Environment.NewLine + "saturation";
                default:
                    return string.Empty;
            }
        }
    }
}
