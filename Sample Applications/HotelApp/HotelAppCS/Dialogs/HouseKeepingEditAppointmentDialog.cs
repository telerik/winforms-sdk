using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI.Scheduler.Dialogs;

namespace HotelApp
{
    public partial class HouseKeepingEditAppointmentDialog : EditAppointmentDialog
    {
        public HouseKeepingEditAppointmentDialog()
        {
            InitializeComponent();
        }

        protected override void LoadSettingsFromEvent(Telerik.WinControls.UI.IEvent sourceEvent)
        {
            base.LoadSettingsFromEvent(sourceEvent);

            this.labelSubject.Text = "Room Id";
            this.labelStatus.Text = "Status";
            this.labelBackground.Text = "Priority";
            this.labelLocation.Visible = false;
            this.txtLocation.Visible = false;

            this.radLabelReminder.Visible = false;
            this.radDropDownListReminder.Visible = false;
            this.buttonRecurrence.Visible = false;
            this.buttonDelete.Visible = false;
            this.textBoxDescription.Visible = false;

            Room r = this.Appointment.DataItem as Room;
            if (r != null)
            {
                this.needsRepairsCheckBox.Checked = r.NeedsRepairs;
            }
        }

        protected override void ApplySettingsToEvent(Telerik.WinControls.UI.IEvent targetEvent)
        {
            base.ApplySettingsToEvent(targetEvent);
            Room r = this.Appointment.DataItem as Room;
            if (r != null)
            {
                r.NeedsRepairs = this.needsRepairsCheckBox.Checked;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.Text = "Room House Keeping";
            this.chkAllDay.Visible = false;
            this.labelBackground.Top -= 40;
            this.cmbBackground.Top -= 40;
            this.cmbBackground.Left -= 23;
            this.labelStatus.Top -= 40;
            this.labelStatus.Left -= 40;
            this.cmbShowTimeAs.Top -= 40;
            this.cmbShowTimeAs.Left -= 80;
            this.cmbShowTimeAs.Width = 130;
            this.needsRepairsCheckBox.Top = this.cmbShowTimeAs.Top + 10;
            this.needsRepairsCheckBox.Left += 80;

            this.radSeparator1.Top -= 40;
            this.radSeparator1.SeparatorElement.Line1.BackColor = Color.FromArgb(209, 209, 209);
            this.radSeparator2.Top -= 40;
            this.radSeparator2.SeparatorElement.Line1.BackColor = Color.FromArgb(209, 209, 209);
            this.timeStart.Top -= 40;
            this.timeEnd.Top -= 40;
            this.dateStart.Top -= 40;
            this.dateEnd.Top -= 40;
            this.labelStartTime.Top -= 40;
            this.labelEndTime.Top -= 40;
            this.cmbResource.Top -= 40;
            this.cmbResource.Left += 30;
            this.labelResource.Top -= 40;
            this.labelResource.Text = "House Keeper";
            this.radSeparator3.Top -= 40;
            this.radSeparator3.SeparatorElement.Line1.BackColor = Color.FromArgb(209, 209, 209);

            this.timeStart.Width += 10;
            this.timeEnd.Width += 10;
            this.buttonOK.Top -= 220;
            this.buttonCancel.Top -= 220;
            this.buttonCancel.Left -= 20;
            this.doneButton.Top = this.buttonOK.Top;
            this.doneButton.Left += 40;
            this.Height -= 220;
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            if (!this.ValidateInput())
            {
                return;
            }
            Room r = this.Appointment.DataItem as Room;
            if (r != null)
            {
                this.cmbShowTimeAs.SelectedValue = (int)HouseKeepingStatus.Clean;
                this.ApplySettingsToEvent(this.Appointment);
                r.HouseKeeperId = null;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}