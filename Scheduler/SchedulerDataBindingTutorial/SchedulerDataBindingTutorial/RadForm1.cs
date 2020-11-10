using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace SchedulerDataBindingTutorial
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schedulerDataDataSet.Resources' table. You can move, or remove it, as needed.
            this.resourcesTableAdapter.Fill(this.schedulerDataDataSet.Resources);
            // TODO: This line of code loads data into the 'schedulerDataDataSet.AppointmentsResources' table. You can move, or remove it, as needed.
            this.appointmentsResourcesTableAdapter.Fill(this.schedulerDataDataSet.AppointmentsResources);
            // TODO: This line of code loads data into the 'schedulerDataDataSet.Appointments' table. You can move, or remove it, as needed.
            this.appointmentsTableAdapter.Fill(this.schedulerDataDataSet.Appointments);

            AppointmentMappingInfo appointmentMappingInfo = new AppointmentMappingInfo();
            appointmentMappingInfo.BackgroundId = "BackgroundId";
            appointmentMappingInfo.Description = "Description";
            appointmentMappingInfo.End = "End";
            appointmentMappingInfo.Location = "Location";
            appointmentMappingInfo.MasterEventId = "MasterEventId";
            appointmentMappingInfo.RecurrenceRule = "RecurrenceRule";
            appointmentMappingInfo.ResourceId = "ResourceID";
            appointmentMappingInfo.Exceptions = "Appointments_Appointments";
            appointmentMappingInfo.Resources = "AppointmentsResources_Appointments";
            appointmentMappingInfo.Start = "Start";
            appointmentMappingInfo.StatusId = "StatusID";
            appointmentMappingInfo.Summary = "Summary";
            schedulerBindingDataSource1.EventProvider.Mapping = appointmentMappingInfo;
            ResourceMappingInfo resourceMappingInfo = new ResourceMappingInfo();
            resourceMappingInfo.Id = "ID";
            resourceMappingInfo.Name = "Name";
            this.schedulerBindingDataSource1.ResourceProvider.Mapping = resourceMappingInfo;

            schedulerBindingDataSource1.ResourceProvider.DataSource = schedulerDataDataSet.Resources;
            schedulerBindingDataSource1.EventProvider.DataSource = schedulerDataDataSet.Appointments;
            radScheduler1.DataSource = schedulerBindingDataSource1;
            
            this.radScheduler1.GroupType = GroupType.Resource;

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            appointmentsResourcesTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
            SchedulerDataDataSet.AppointmentsResourcesDataTable deletedRelationRecords =
                this.schedulerDataDataSet.AppointmentsResources.GetChanges(DataRowState.Deleted)
                as SchedulerDataDataSet.AppointmentsResourcesDataTable;
            SchedulerDataDataSet.AppointmentsResourcesDataTable newRelationRecords =
                this.schedulerDataDataSet.AppointmentsResources.GetChanges(DataRowState.Added)
                as SchedulerDataDataSet.AppointmentsResourcesDataTable;
            SchedulerDataDataSet.AppointmentsResourcesDataTable modifiedRelationRecords =
                this.schedulerDataDataSet.AppointmentsResources.GetChanges(DataRowState.Modified)
                as SchedulerDataDataSet.AppointmentsResourcesDataTable;
            SchedulerDataDataSet.AppointmentsDataTable newAppointmentRecords =
                this.schedulerDataDataSet.Appointments.GetChanges(DataRowState.Added) as SchedulerDataDataSet.AppointmentsDataTable;
            SchedulerDataDataSet.AppointmentsDataTable deletedAppointmentRecords =
                this.schedulerDataDataSet.Appointments.GetChanges(DataRowState.Deleted) as SchedulerDataDataSet.AppointmentsDataTable;
            SchedulerDataDataSet.AppointmentsDataTable modifiedAppointmentRecords =
                this.schedulerDataDataSet.Appointments.GetChanges(DataRowState.Modified) as SchedulerDataDataSet.AppointmentsDataTable;
            try
            {
                if (newAppointmentRecords != null)
                {
                    Dictionary<int, int> newAppointmentIds = new Dictionary<int, int>();
                    Dictionary<object, int> oldAppointmentIds = new Dictionary<object, int>();
                    for (int i = 0; i < newAppointmentRecords.Count; i++)
                    {
                        oldAppointmentIds.Add(newAppointmentRecords[i], newAppointmentRecords[i].ID);
                    }
                    appointmentsTableAdapter.Update(newAppointmentRecords);
                    for (int i = 0; i < newAppointmentRecords.Count; i++)
                    {
                        newAppointmentIds.Add(oldAppointmentIds[newAppointmentRecords[i]], newAppointmentRecords[i].ID);
                    }
                    if (newRelationRecords != null)
                    {
                        for (int i = 0; i < newRelationRecords.Count; i++)
                        {
                            newRelationRecords[i].AppointmentID = newAppointmentIds[newRelationRecords[i].AppointmentID];
                        }
                    }
                }
                if (deletedRelationRecords != null)
                {
                    appointmentsResourcesTableAdapter.Update(deletedRelationRecords);
                }
                if (deletedAppointmentRecords != null)
                {
                    appointmentsTableAdapter.Update(deletedAppointmentRecords);
                }
                if (modifiedAppointmentRecords != null)
                {
                    appointmentsTableAdapter.Update(modifiedAppointmentRecords);
                }
                if (newRelationRecords != null)
                {
                    appointmentsResourcesTableAdapter.Update(newRelationRecords);
                }
                if (modifiedRelationRecords != null)
                {
                    appointmentsResourcesTableAdapter.Update(modifiedRelationRecords);
                }
                this.schedulerDataDataSet.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("An error occurred during the update process:\n{0}", ex.Message));
            }
            finally
            {
                if (deletedRelationRecords != null)
                {
                    deletedRelationRecords.Dispose();
                }
                if (newRelationRecords != null)
                {
                    newRelationRecords.Dispose();
                }
                if (modifiedRelationRecords != null)
                {
                    modifiedRelationRecords.Dispose();
                }
            }
        }
    }
}