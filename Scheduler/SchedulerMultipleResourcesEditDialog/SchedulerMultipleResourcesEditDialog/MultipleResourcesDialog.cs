using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls.UI.Scheduler.Dialogs;
using Telerik.WinControls.UI;

namespace SchedulerMultipleResourcesEditDialog
{
    public class MultipleResourcesDialog : EditAppointmentDialog
    {
        private Telerik.WinControls.UI.RadListControl listResources;

        public MultipleResourcesDialog()
        {
            InitializeComponent();
        }

        protected override void LoadSettingsFromEvent(IEvent sourceEvent)
        {
            base.LoadSettingsFromEvent(sourceEvent);

            if (sourceEvent.ResourceId != null)
            { 
                foreach (RadListDataItem item in this.listResources.Items)
                {
                    if (sourceEvent.ResourceIds.Contains(item.Value as EventId))
                    {
                        item.Selected = true;
                    }
                    else
                    {
                        item.Selected = false;
                    }
                }

                if (this.schedulerData.GroupType == GroupType.None && sourceEvent.ResourceIds.Count > 1)
                {
                    this.listResources.SelectedIndex = 1;
                }

            }
        }

        protected override void LoadResources()
        {
            base.LoadResources();

            if (this.schedulerData == null)
            {
                return;
            }

            ISchedulerStorage<IResource> resourceStorage = this.schedulerData.GetResourceStorage();
            this.listResources.Items.Clear();

            if (this.schedulerData.GroupType == GroupType.None)
            {
                RadListDataItem item = new RadListDataItem("None");
                item.Value = -1;
                this.listResources.Items.Add(item);
            }

            foreach (IResource resource in resourceStorage)
            {
                if (resource.Visible)
                {
                    RadListDataItem item = new RadListDataItem(resource.Name);
                    item.Value = resource.Id;
                    this.listResources.Items.Add(item);
                }
            }

            if (this.listResources.Items.Count > 0)
            {
                this.listResources.SelectedIndex = 0;
            }
        }

        protected override void ApplySettingsToEvent(IEvent targetEvent)
        {
            base.ApplySettingsToEvent(targetEvent);

            if (this.listResources.SelectedIndex >= 0)
            {
                RadListDataItem selectedItem = listResources.Items[this.listResources.SelectedIndex];

                if (selectedItem.Text.Equals("None"))
                {
                    if (targetEvent.ResourceIds.Count > 0)
                    {
                        targetEvent.ResourceIds.Clear();
                    }
                }
                else
                {
                    targetEvent.ResourceIds.Clear();

                    foreach (RadListDataItem item in listResources.SelectedItems)
                    {
                        EventId resourceId = item.Value as EventId;
                        if (!targetEvent.ResourceIds.Contains(resourceId))
                        {
                            targetEvent.ResourceIds.Add(resourceId);
                        }
                    }
                }
            }
        }

        private void InitializeComponent()
        {
            this.listResources = new Telerik.WinControls.UI.RadListControl();
            ((System.ComponentModel.ISupportInitialize)(this.labelSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelStartTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelEndTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAllDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelResource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbResource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbShowTimeAs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRecurrence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listResources)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBackground
            // 
            // 
            // 
            // 
            this.cmbBackground.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.cmbBackground.Size = new System.Drawing.Size(180, 20);
            // 
            // dateStart
            // 
            this.dateStart.Value = new System.DateTime(2011, 5, 17, 11, 22, 29, 614);
            // 
            // timeStart
            // 
            this.timeStart.Value = new System.DateTime(2011, 5, 17, 11, 22, 29, 614);
            // 
            // dateEnd
            // 
            this.dateEnd.Value = new System.DateTime(2011, 5, 17, 11, 22, 29, 614);
            // 
            // timeEnd
            // 
            this.timeEnd.Value = new System.DateTime(2011, 5, 17, 11, 22, 29, 614);
            // 
            // chkAllDay
            // 
            // 
            // 
            // 
            this.chkAllDay.RootElement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            // 
            // cmbResource
            // 
            this.cmbResource.Location = new System.Drawing.Point(345, 169);
            this.cmbResource.Size = new System.Drawing.Size(180, 20);
            this.cmbResource.Visible = false;
            // 
            // cmbShowTimeAs
            // 
            // 
            // 
            // 
            this.cmbShowTimeAs.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.cmbShowTimeAs.Size = new System.Drawing.Size(178, 20);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(7, 322);
            // 
            // 
            // 
            this.textBoxDescription.RootElement.StretchVertically = true;
            this.textBoxDescription.Size = new System.Drawing.Size(519, 116);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(6, 444);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(87, 444);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(168, 444);
            // 
            // buttonRecurrence
            // 
            this.buttonRecurrence.Location = new System.Drawing.Point(249, 444);
            // 
            // radSeparator3
            // 
            this.radSeparator3.Location = new System.Drawing.Point(6, 306);
            // 
            // listResources
            // 
            this.listResources.CaseSensitiveSort = true;
            this.listResources.ItemHeight = 18;
            this.listResources.Location = new System.Drawing.Point(79, 169);
            this.listResources.Name = "listResources";
            this.listResources.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listResources.Size = new System.Drawing.Size(180, 131);
            this.listResources.TabIndex = 25;
            this.listResources.Text = "radListControl1";
            // 
            // MultipleResourcesDialog
            // 
            this.ClientSize = new System.Drawing.Size(537, 472);
            this.Controls.Add(this.listResources);
            this.Name = "MultipleResourcesDialog";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MinSize = new System.Drawing.Size(539, 365);
            this.Text = "Edit Appointment";
            this.Controls.SetChildIndex(this.listResources, 0);
            this.Controls.SetChildIndex(this.radSeparator3, 0);
            this.Controls.SetChildIndex(this.cmbResource, 0);
            this.Controls.SetChildIndex(this.labelSubject, 0);
            this.Controls.SetChildIndex(this.labelLocation, 0);
            this.Controls.SetChildIndex(this.labelBackground, 0);
            this.Controls.SetChildIndex(this.txtSubject, 0);
            this.Controls.SetChildIndex(this.txtLocation, 0);
            this.Controls.SetChildIndex(this.cmbBackground, 0);
            this.Controls.SetChildIndex(this.labelStartTime, 0);
            this.Controls.SetChildIndex(this.labelEndTime, 0);
            this.Controls.SetChildIndex(this.dateStart, 0);
            this.Controls.SetChildIndex(this.timeStart, 0);
            this.Controls.SetChildIndex(this.dateEnd, 0);
            this.Controls.SetChildIndex(this.timeEnd, 0);
            this.Controls.SetChildIndex(this.chkAllDay, 0);
            this.Controls.SetChildIndex(this.labelResource, 0);
            this.Controls.SetChildIndex(this.labelStatus, 0);
            this.Controls.SetChildIndex(this.cmbShowTimeAs, 0);
            this.Controls.SetChildIndex(this.textBoxDescription, 0);
            this.Controls.SetChildIndex(this.buttonOK, 0);
            this.Controls.SetChildIndex(this.buttonCancel, 0);
            this.Controls.SetChildIndex(this.buttonDelete, 0);
            this.Controls.SetChildIndex(this.buttonRecurrence, 0);
            this.Controls.SetChildIndex(this.radSeparator1, 0);
            this.Controls.SetChildIndex(this.radSeparator2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.labelSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelStartTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelEndTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAllDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelResource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbResource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbShowTimeAs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRecurrence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listResources)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
