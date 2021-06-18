Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Telerik.WinControls.UI.Scheduler.Dialogs
Imports Telerik.WinControls.UI

Public Class MultipleResourcesDialog
    Inherits EditAppointmentDialog
    Private listResources As Telerik.WinControls.UI.RadListControl

    Public Sub New()
        InitializeComponent()
    End Sub

    Protected Overrides Sub LoadSettingsFromEvent(ByVal sourceEvent As IEvent)
        MyBase.LoadSettingsFromEvent(sourceEvent)

        If sourceEvent.ResourceId IsNot Nothing Then
            For Each item As RadListDataItem In Me.listResources.Items
                If sourceEvent.ResourceIds.Contains(TryCast(item.Value, EventId)) Then
                    item.Selected = True
                Else
                    item.Selected = False
                End If
            Next

            If Me.SchedulerData.GroupType = GroupType.None AndAlso sourceEvent.ResourceIds.Count > 1 Then
                Me.listResources.SelectedIndex = 1

            End If
        End If
    End Sub

    Protected Overrides Sub LoadResources()
        MyBase.LoadResources()

        If Me.SchedulerData Is Nothing Then
            Return
        End If

        Dim resourceStorage As ISchedulerStorage(Of IResource) = Me.SchedulerData.GetResourceStorage()
        Me.listResources.Items.Clear()

        If Me.SchedulerData.GroupType = GroupType.None Then
            Dim item As New RadListDataItem("None")
            item.Value = -1
            Me.listResources.Items.Add(item)
        End If

        For Each resource As IResource In resourceStorage
            If resource.Visible Then
                Dim item As New RadListDataItem(resource.Name)
                item.Value = resource.Id
                Me.listResources.Items.Add(item)
            End If
        Next

        If Me.listResources.Items.Count > 0 Then
            Me.listResources.SelectedIndex = 0
        End If
    End Sub

    Protected Overrides Sub ApplySettingsToEvent(ByVal targetEvent As IEvent)
        MyBase.ApplySettingsToEvent(targetEvent)

        If Me.listResources.SelectedIndex >= 0 Then
            Dim selectedItem As RadListDataItem = listResources.Items(Me.listResources.SelectedIndex)

            If selectedItem.Text.Equals("None") Then
                If targetEvent.ResourceIds.Count > 0 Then
                    targetEvent.ResourceIds.Clear()
                End If
            Else
                targetEvent.ResourceIds.Clear()

                For Each item As RadListDataItem In listResources.SelectedItems
                    Dim resourceId As EventId = TryCast(item.Value, EventId)
                    If Not targetEvent.ResourceIds.Contains(resourceId) Then
                        targetEvent.ResourceIds.Add(resourceId)
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub InitializeComponent()
        Me.listResources = New Telerik.WinControls.UI.RadListControl()
        DirectCast(Me.labelSubject, System.ComponentModel.ISupportInitialize).BeginInit()
        DirectCast(Me.labelLocation, System.ComponentModel.ISupportInitialize).BeginInit()
        DirectCast(Me.labelBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        DirectCast(Me.txtSubject, System.ComponentModel.ISupportInitialize).BeginInit()
        DirectCast(Me.txtLocation, System.ComponentModel.ISupportInitialize).BeginInit()
        DirectCast(Me.cmbBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        DirectCast(Me.labelStartTime, System.ComponentModel.ISupportInitialize).BeginInit()
        DirectCast(Me.labelEndTime, System.ComponentModel.ISupportInitialize).BeginInit()
        DirectCast(Me.dateStart, System.ComponentModel.ISupportInitialize).BeginInit()
        DirectCast(Me.timeStart, System.ComponentModel.ISupportInitialize).BeginInit()
        DirectCast(Me.dateEnd, System.ComponentModel.ISupportInitialize).BeginInit()
        DirectCast(Me.timeEnd, System.ComponentModel.ISupportInitialize).BeginInit()
        DirectCast(Me.chkAllDay, System.ComponentModel.ISupportInitialize).BeginInit()
        DirectCast(Me.labelResource, System.ComponentModel.ISupportInitialize).BeginInit()
        DirectCast(Me.cmbResource, System.ComponentModel.ISupportInitialize).BeginInit()
        DirectCast(Me.labelStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        DirectCast(Me.cmbShowTimeAs, System.ComponentModel.ISupportInitialize).BeginInit()
        DirectCast(Me.textBoxDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        DirectCast(Me.buttonOK, System.ComponentModel.ISupportInitialize).BeginInit()
        DirectCast(Me.buttonCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        DirectCast(Me.buttonDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        DirectCast(Me.buttonRecurrence, System.ComponentModel.ISupportInitialize).BeginInit()
        DirectCast(Me.errorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        DirectCast(Me.radSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
        DirectCast(Me.radSeparator2, System.ComponentModel.ISupportInitialize).BeginInit()
        DirectCast(Me.radSeparator3, System.ComponentModel.ISupportInitialize).BeginInit()
        DirectCast(Me.listResources, System.ComponentModel.ISupportInitialize).BeginInit()
        DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' cmbBackground
        ' 
        ' 
        ' 
        ' 
        Me.cmbBackground.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.cmbBackground.Size = New System.Drawing.Size(180, 20)
        ' 
        ' dateStart
        ' 
        Me.dateStart.Value = New System.DateTime(2011, 5, 17, 11, 22, 29, _
         614)
        ' 
        ' timeStart
        ' 
        Me.timeStart.Value = New System.DateTime(2011, 5, 17, 11, 22, 29, _
         614)
        ' 
        ' dateEnd
        ' 
        Me.dateEnd.Value = New System.DateTime(2011, 5, 17, 11, 22, 29, _
         614)
        ' 
        ' timeEnd
        ' 
        Me.timeEnd.Value = New System.DateTime(2011, 5, 17, 11, 22, 29, _
         614)
        ' 
        ' chkAllDay
        ' 
        ' 
        ' 
        ' 
        Me.chkAllDay.RootElement.ForeColor = System.Drawing.Color.FromArgb(CInt(CByte(5)), CInt(CByte(5)), CInt(CByte(5)))
        ' 
        ' cmbResource
        ' 
        Me.cmbResource.Location = New System.Drawing.Point(345, 169)
        Me.cmbResource.Size = New System.Drawing.Size(180, 20)
        Me.cmbResource.Visible = False
        ' 
        ' cmbShowTimeAs
        ' 
        ' 
        ' 
        ' 
        Me.cmbShowTimeAs.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.cmbShowTimeAs.Size = New System.Drawing.Size(178, 20)
        ' 
        ' textBoxDescription
        ' 
        Me.textBoxDescription.Location = New System.Drawing.Point(7, 322)
        ' 
        ' 
        ' 
        Me.textBoxDescription.RootElement.StretchVertically = True
        Me.textBoxDescription.Size = New System.Drawing.Size(519, 116)
        ' 
        ' buttonOK
        ' 
        Me.buttonOK.Location = New System.Drawing.Point(6, 444)
        ' 
        ' buttonCancel
        ' 
        Me.buttonCancel.Location = New System.Drawing.Point(87, 444)
        ' 
        ' buttonDelete
        ' 
        Me.buttonDelete.Location = New System.Drawing.Point(168, 444)
        ' 
        ' buttonRecurrence
        ' 
        Me.buttonRecurrence.Location = New System.Drawing.Point(249, 444)
        ' 
        ' radSeparator3
        ' 
        Me.radSeparator3.Location = New System.Drawing.Point(6, 306)
        ' 
        ' listResources
        ' 
        Me.listResources.CaseSensitiveSort = True
        Me.listResources.ItemHeight = 18
        Me.listResources.Location = New System.Drawing.Point(79, 169)
        Me.listResources.Name = "listResources"
        Me.listResources.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.listResources.Size = New System.Drawing.Size(180, 131)
        Me.listResources.TabIndex = 25
        Me.listResources.Text = "radListControl1"
        ' 
        ' MultipleResourcesDialog
        ' 
        Me.ClientSize = New System.Drawing.Size(537, 472)
        Me.Controls.Add(Me.listResources)
        Me.Name = "MultipleResourcesDialog"
        ' 
        ' 
        ' 
        Me.RootElement.ApplyShapeToControl = True
        Me.RootElement.MinSize = New System.Drawing.Size(539, 365)
        Me.Text = "Edit Appointment"
        Me.Controls.SetChildIndex(Me.listResources, 0)
        Me.Controls.SetChildIndex(Me.radSeparator3, 0)
        Me.Controls.SetChildIndex(Me.cmbResource, 0)
        Me.Controls.SetChildIndex(Me.labelSubject, 0)
        Me.Controls.SetChildIndex(Me.labelLocation, 0)
        Me.Controls.SetChildIndex(Me.labelBackground, 0)
        Me.Controls.SetChildIndex(Me.txtSubject, 0)
        Me.Controls.SetChildIndex(Me.txtLocation, 0)
        Me.Controls.SetChildIndex(Me.cmbBackground, 0)
        Me.Controls.SetChildIndex(Me.labelStartTime, 0)
        Me.Controls.SetChildIndex(Me.labelEndTime, 0)
        Me.Controls.SetChildIndex(Me.dateStart, 0)
        Me.Controls.SetChildIndex(Me.timeStart, 0)
        Me.Controls.SetChildIndex(Me.dateEnd, 0)
        Me.Controls.SetChildIndex(Me.timeEnd, 0)
        Me.Controls.SetChildIndex(Me.chkAllDay, 0)
        Me.Controls.SetChildIndex(Me.labelResource, 0)
        Me.Controls.SetChildIndex(Me.labelStatus, 0)
        Me.Controls.SetChildIndex(Me.cmbShowTimeAs, 0)
        Me.Controls.SetChildIndex(Me.textBoxDescription, 0)
        Me.Controls.SetChildIndex(Me.buttonOK, 0)
        Me.Controls.SetChildIndex(Me.buttonCancel, 0)
        Me.Controls.SetChildIndex(Me.buttonDelete, 0)
        Me.Controls.SetChildIndex(Me.buttonRecurrence, 0)
        Me.Controls.SetChildIndex(Me.radSeparator1, 0)
        Me.Controls.SetChildIndex(Me.radSeparator2, 0)
        DirectCast(Me.labelSubject, System.ComponentModel.ISupportInitialize).EndInit()
        DirectCast(Me.labelLocation, System.ComponentModel.ISupportInitialize).EndInit()
        DirectCast(Me.labelBackground, System.ComponentModel.ISupportInitialize).EndInit()
        DirectCast(Me.txtSubject, System.ComponentModel.ISupportInitialize).EndInit()
        DirectCast(Me.txtLocation, System.ComponentModel.ISupportInitialize).EndInit()
        DirectCast(Me.cmbBackground, System.ComponentModel.ISupportInitialize).EndInit()
        DirectCast(Me.labelStartTime, System.ComponentModel.ISupportInitialize).EndInit()
        DirectCast(Me.labelEndTime, System.ComponentModel.ISupportInitialize).EndInit()
        DirectCast(Me.dateStart, System.ComponentModel.ISupportInitialize).EndInit()
        DirectCast(Me.timeStart, System.ComponentModel.ISupportInitialize).EndInit()
        DirectCast(Me.dateEnd, System.ComponentModel.ISupportInitialize).EndInit()
        DirectCast(Me.timeEnd, System.ComponentModel.ISupportInitialize).EndInit()
        DirectCast(Me.chkAllDay, System.ComponentModel.ISupportInitialize).EndInit()
        DirectCast(Me.labelResource, System.ComponentModel.ISupportInitialize).EndInit()
        DirectCast(Me.cmbResource, System.ComponentModel.ISupportInitialize).EndInit()
        DirectCast(Me.labelStatus, System.ComponentModel.ISupportInitialize).EndInit()
        DirectCast(Me.cmbShowTimeAs, System.ComponentModel.ISupportInitialize).EndInit()
        DirectCast(Me.textBoxDescription, System.ComponentModel.ISupportInitialize).EndInit()
        DirectCast(Me.buttonOK, System.ComponentModel.ISupportInitialize).EndInit()
        DirectCast(Me.buttonCancel, System.ComponentModel.ISupportInitialize).EndInit()
        DirectCast(Me.buttonDelete, System.ComponentModel.ISupportInitialize).EndInit()
        DirectCast(Me.buttonRecurrence, System.ComponentModel.ISupportInitialize).EndInit()
        DirectCast(Me.errorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        DirectCast(Me.radSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
        DirectCast(Me.radSeparator2, System.ComponentModel.ISupportInitialize).EndInit()
        DirectCast(Me.radSeparator3, System.ComponentModel.ISupportInitialize).EndInit()
        DirectCast(Me.listResources, System.ComponentModel.ISupportInitialize).EndInit()
        DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
End Class