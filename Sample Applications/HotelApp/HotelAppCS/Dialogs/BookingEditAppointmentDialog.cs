using CustomControls;
using HotelApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Scheduler.Dialogs;

namespace HotelApp
{
    public partial class BookingEditAppointmentDialog : EditAppointmentDialog
    {
        private BindingList<Guest> Guests;

        public BookingEditAppointmentDialog()
        {
            InitializeComponent();
            this.Opacity = 0;
            this.addNewGuestButton.Click += addNewGuestButton_Click;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.Opacity = 1;
        }

        protected override bool ValidateInput()
        {
            if (this.guestsDropDownList.SelectedIndex < 0)
            {
                return false;
            }
            return base.ValidateInput();
        }
        
        public BookingEditAppointmentDialog(BindingList<Guest> guests) : this()
        {
            this.Guests = guests;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.ShowIcon = false;
            this.txtSubject.Width -= 10;
            this.txtSubject.Visible = false;
            this.txtSubject.Left += 10;
            this.chkAllDay.Visible = false;
            this.labelBackground.Top -= 40;
            this.cmbBackground.Top -= 40;
            this.cmbBackground.Left -= 13;
            this.labelStatus.Top -= 40;
            this.labelStatus.Left += 10;
            this.radSeparator1.Top -= 40;
            this.dateStart.Top -= 30;
            this.dateStart.Left += 10;
            this.dateEnd.Top = this.dateStart.Top;
            this.dateStart.Width = 170;
            this.dateEnd.Width = 180;
            this.dateEnd.Left += 10;
            this.labelStartTime.Text = "Check-in:";
            this.labelEndTime.Text = "Check-out:";
            this.labelStartTime.Top -= 30;
            this.labelEndTime.Top -= 30;
            this.labelEndTime.Left = this.labelStatus.Left - 5;
            this.labelEndTime.Top = this.labelStartTime.Top;
            this.dateEnd.Left = this.guestsDropDownList.Left;
            this.cmbBackground.Width = 170;
            this.guestsDropDownList.Width = 410;
            this.guestsDropDownList.Left = this.txtSubject.Left;
            this.guestsDropDownList.Top = this.txtSubject.Top;
            this.buttonOK.Top -= 320;
            this.buttonCancel.Top -= 320;
            this.buttonCancel.Left -= 20;
            this.Height -= 320;
            this.FormElement.TitleBar.CustomFont = Utils.MainFont;
            this.MaximumSize = new Size(this.Width, this.Height);

            this.guestsDropDownList.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.addNewGuestButton.ButtonElement.Padding = new Padding(0);
            this.addNewGuestButton.ImageAlignment = ContentAlignment.MiddleCenter;
            this.addNewGuestButton.Top = this.txtSubject.Top;
        }

        private void addNewGuestButton_Click(object sender, EventArgs e)
        {
            RadForm addGuestForm = new RadForm();
            addGuestForm.ShowIcon = false;
            addGuestForm.Text = "Add new guest";
            RadScrollablePanel scrollablePanel = new RadScrollablePanel();
            EditGuestInfo editGuestInfo = new EditGuestInfo();
            scrollablePanel.Controls.Add(editGuestInfo);
            scrollablePanel.Dock = DockStyle.Fill;
            addGuestForm.Controls.Add(scrollablePanel);
            editGuestInfo.HeaderPanel.Visible = false;
            addGuestForm.Height = editGuestInfo.Height + addGuestForm.FormElement.TitleBar.Size.Height + 1; 
            editGuestInfo.SaveButton.Click += SaveButton_Click;
            Guest guest = new Guest();
            editGuestInfo.Initialize(guest, new Booking()); 
            addGuestForm.StartPosition = FormStartPosition.Manual;
            addGuestForm.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - addGuestForm.Width / 2,Screen.PrimaryScreen.Bounds.Height / 2 - addGuestForm.Height / 2);
           
            if (addGuestForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            { 
                this.Guests.Add(guest);
            }
        }
        
        private void SaveButton_Click(object sender, EventArgs e)
        {
            RadButton saveButton = sender as RadButton;
            if (saveButton != null)
            {
                RadForm f = saveButton.FindForm() as RadForm;
                
                if (saveButton.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    f.DialogResult = System.Windows.Forms.DialogResult.OK;
                    f.Close(); 
                }
            }
        }

        protected override void LoadSettingsFromEvent(Telerik.WinControls.UI.IEvent sourceEvent)
        {
            base.LoadSettingsFromEvent(sourceEvent);

            Booking b = this.Appointment.DataItem as Booking;
            if (b != null)
            {
                this.Text = "Edit booking for room #" + b.RoomId;
            }
            else
            {
                this.Text = "New booking for room #" + this.Appointment.ResourceId;
            }

            this.labelSubject.Text = "Guest:";
            this.txtSubject.Enabled = false;
            this.textBoxDescription.Visible = false;
            this.cmbShowTimeAs.Visible = false;
            this.labelBackground.Text = "Status:";
            this.chkAllDay.Visible = false;
            this.labelLocation.Visible = false;
            this.txtLocation.Visible = false;
            this.cmbResource.Visible = false;
            this.labelResource.Visible = false;
            this.radSeparator2.Visible = false;
            this.radSeparator3.Visible = false;
            this.radSeparator1.SeparatorElement.Line1.BackColor = Color.FromArgb(209, 209, 209);  
            this.radLabelReminder.Visible = false;
            this.radDropDownListReminder.Visible = false;
            this.timeStart.Visible = false;
            this.timeEnd.Visible = false;

            this.buttonDelete.Visible = false;
            this.buttonRecurrence.Visible = false;

            this.guestsDropDownList.DataSource = this.Guests;
            this.guestsDropDownList.DisplayMember = "Name";
            this.guestsDropDownList.ValueMember = "Id";
            this.guestsDropDownList.SelectedIndex = -1;
            if (b != null)
            {
                for (int i = 0; i < this.guestsDropDownList.Items.Count; i++)
                {
                    if (this.guestsDropDownList.Items[i].Text == b.Guests[0].Name)
                    {
                        this.guestsDropDownList.SelectedIndex = i;
                        this.guestsDropDownList.DropDownListElement.TextBox.TextBoxItem.SelectionLength = 0;
                        break;
                    }
                }
            } 
            this.labelStatus.Visible = false;
            this.guestsDropDownList.SelectedValueChanged += guestsDropDownList_SelectedValueChanged;
        }

        private void guestsDropDownList_SelectedValueChanged(object sender, EventArgs e)
        {
            string value = this.guestsDropDownList.SelectedValue + "";
            Guest guest = Utils.GetGuestById(this.Guests, value);

            if (guest != null)
            {
                this.txtSubject.Text = guest.Name;
            }
            ((RadScheduler)this.SchedulerData).Tag = guest;
        }
    }
}