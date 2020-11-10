Imports Telerik.WinControls.UI

Public Class RadForm1

    Private Sub RadForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SchedulerDataDataSet.Resources' table. You can move, or remove it, as needed.
        Me.ResourcesTableAdapter.Fill(Me.SchedulerDataDataSet.Resources)
        'TODO: This line of code loads data into the 'SchedulerDataDataSet.AppointmentsResources' table. You can move, or remove it, as needed.
        Me.AppointmentsResourcesTableAdapter.Fill(Me.SchedulerDataDataSet.AppointmentsResources)
        'TODO: This line of code loads data into the 'SchedulerDataDataSet.Appointments' table. You can move, or remove it, as needed.
        Me.AppointmentsTableAdapter.Fill(Me.SchedulerDataDataSet.Appointments)
        
        Dim appointmentMappingInfo As AppointmentMappingInfo = New AppointmentMappingInfo()
        appointmentMappingInfo.BackgroundId = "BackgroundId"
        appointmentMappingInfo.Description = "Description"
        appointmentMappingInfo.[End] = "End"
        appointmentMappingInfo.Location = "Location"
        appointmentMappingInfo.MasterEventId = "MasterEventId"
        appointmentMappingInfo.RecurrenceRule = "RecurrenceRule"
        appointmentMappingInfo.ResourceId = "ResourceID"
        appointmentMappingInfo.Exceptions = "Appointments_Appointments"
        appointmentMappingInfo.Resources = "AppointmentsResources_Appointments"
        appointmentMappingInfo.Start = "Start"
        appointmentMappingInfo.StatusId = "StatusID"
        appointmentMappingInfo.Summary = "Summary"
        SchedulerBindingDataSource1.EventProvider.Mapping = appointmentMappingInfo
        Dim resourceMappingInfo As ResourceMappingInfo = New ResourceMappingInfo()
        resourceMappingInfo.Id = "ID"
        resourceMappingInfo.Name = "Name"
        Me.SchedulerBindingDataSource1.ResourceProvider.Mapping = resourceMappingInfo
        SchedulerBindingDataSource1.ResourceProvider.DataSource = schedulerDataDataSet.Resources
        SchedulerBindingDataSource1.EventProvider.DataSource = schedulerDataDataSet.Appointments
        RadScheduler1.DataSource = SchedulerBindingDataSource1
        Me.RadScheduler1.GroupType = GroupType.Resource
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        AppointmentsResourcesTableAdapter.Adapter.AcceptChangesDuringUpdate = False
        Dim deletedRelationRecords As SchedulerDataDataSet.AppointmentsResourcesDataTable = _
            TryCast(Me.SchedulerDataDataSet.AppointmentsResources.GetChanges(DataRowState.Deleted), SchedulerDataDataSet.AppointmentsResourcesDataTable)
        Dim newRelationRecords As SchedulerDataDataSet.AppointmentsResourcesDataTable = _
            TryCast(Me.SchedulerDataDataSet.AppointmentsResources.GetChanges(DataRowState.Added), SchedulerDataDataSet.AppointmentsResourcesDataTable)
        Dim modifiedRelationRecords As SchedulerDataDataSet.AppointmentsResourcesDataTable = _
            TryCast(Me.SchedulerDataDataSet.AppointmentsResources.GetChanges(DataRowState.Modified), SchedulerDataDataSet.AppointmentsResourcesDataTable)
        Dim newAppointmentRecords As SchedulerDataDataSet.AppointmentsDataTable = _
            TryCast(Me.SchedulerDataDataSet.Appointments.GetChanges(DataRowState.Added), SchedulerDataDataSet.AppointmentsDataTable)
        Dim deletedAppointmentRecords As SchedulerDataDataSet.AppointmentsDataTable = _
            TryCast(Me.SchedulerDataDataSet.Appointments.GetChanges(DataRowState.Deleted), SchedulerDataDataSet.AppointmentsDataTable)
        Dim modifiedAppointmentRecords As SchedulerDataDataSet.AppointmentsDataTable = _
            TryCast(Me.SchedulerDataDataSet.Appointments.GetChanges(DataRowState.Modified), SchedulerDataDataSet.AppointmentsDataTable)

        Try

            If newAppointmentRecords IsNot Nothing Then
                Dim newAppointmentIds As Dictionary(Of Integer, Integer) = New Dictionary(Of Integer, Integer)()
                Dim oldAppointmentIds As Dictionary(Of Object, Integer) = New Dictionary(Of Object, Integer)()

                For i As Integer = 0 To newAppointmentRecords.Count - 1
                    oldAppointmentIds.Add(newAppointmentRecords(i), newAppointmentRecords(i).ID)
                Next

                AppointmentsTableAdapter.Update(newAppointmentRecords)

                For i As Integer = 0 To newAppointmentRecords.Count - 1
                    newAppointmentIds.Add(oldAppointmentIds(newAppointmentRecords(i)), newAppointmentRecords(i).ID)
                Next

                If newRelationRecords IsNot Nothing Then

                    For i As Integer = 0 To newRelationRecords.Count - 1
                        newRelationRecords(i).AppointmentID = newAppointmentIds(newRelationRecords(i).AppointmentID)
                    Next
                End If
            End If

            If deletedRelationRecords IsNot Nothing Then
                AppointmentsResourcesTableAdapter.Update(deletedRelationRecords)
            End If

            If deletedAppointmentRecords IsNot Nothing Then
                AppointmentsTableAdapter.Update(deletedAppointmentRecords)
            End If

            If modifiedAppointmentRecords IsNot Nothing Then
                AppointmentsTableAdapter.Update(modifiedAppointmentRecords)
            End If

            If newRelationRecords IsNot Nothing Then
                AppointmentsResourcesTableAdapter.Update(newRelationRecords)
            End If

            If modifiedRelationRecords IsNot Nothing Then
                AppointmentsResourcesTableAdapter.Update(modifiedRelationRecords)
            End If

            Me.SchedulerDataDataSet.AcceptChanges()
        Catch ex As Exception
            MessageBox.Show(String.Format("An error occurred during the update process:" & vbLf & "{0}", ex.Message))
        Finally

            If deletedRelationRecords IsNot Nothing Then
                deletedRelationRecords.Dispose()
            End If

            If newRelationRecords IsNot Nothing Then
                newRelationRecords.Dispose()
            End If

            If modifiedRelationRecords IsNot Nothing Then
                modifiedRelationRecords.Dispose()
            End If
        End Try
    End Sub
End Class
