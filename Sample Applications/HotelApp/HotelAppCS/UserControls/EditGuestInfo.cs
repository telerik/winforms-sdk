using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using HotelApp;
using Telerik.WinControls.UI;
using HotelApp.Data;

namespace CustomControls
{
    public partial class EditGuestInfo : UserControl
    {
        Guest currentGuest;
        Booking booking;

        public RadPanel HeaderPanel
        {
            get
            {
                return this.headerPanel;
            }
        }

        public RadButton SaveButton
        {
            get
            {
                return this.saveButton;
            }
        }

        public EditGuestInfo()
        {
            InitializeComponent();

            this.headerPanel.RootElement.EnableElementShadow = false;

            this.guestInfoLabel.RootElement.EnableElementShadow = false;
            this.guestInfoLabel.LabelElement.CustomFont = Utils.MainFontMedium;
            this.guestInfoLabel.LabelElement.CustomFontSize = 10.5f;
            this.guestInfoLabel.LabelElement.LabelText.Margin = new Padding(5, 15, 0, 0);

            this.nameLabel.LabelElement.CustomFont = Utils.MainFont;
            this.nameLabel.LabelElement.CustomFontSize = 10.5f;
            this.nameLabel.ForeColor = Color.FromArgb(89, 89, 89);
            this.nameLabel.TextAlignment = ContentAlignment.BottomLeft;

            this.nameTextBox.TextBoxElement.CustomFont = Utils.MainFont;
            this.nameTextBox.TextBoxElement.CustomFontSize = 10.5f;
            this.nameTextBox.ForeColor = Color.FromArgb(33, 33, 33);

            this.idLabel.LabelElement.CustomFont = Utils.MainFont;
            this.idLabel.LabelElement.CustomFontSize = 10.5f;
            this.idLabel.ForeColor = Color.FromArgb(89, 89, 89);
            this.idLabel.TextAlignment = ContentAlignment.BottomLeft;

            this.idTextBox.TextBoxElement.CustomFont = Utils.MainFont;
            this.idTextBox.TextBoxElement.CustomFontSize = 10.5f;
            this.idTextBox.ForeColor = Color.FromArgb(33, 33, 33);

            this.addressLabel.LabelElement.CustomFont = Utils.MainFont;
            this.addressLabel.LabelElement.CustomFontSize = 10.5f;
            this.addressLabel.ForeColor = Color.FromArgb(89, 89, 89);
            this.addressLabel.TextAlignment = ContentAlignment.BottomLeft;

            this.addressTextBox.TextBoxElement.CustomFont = Utils.MainFont;
            this.addressTextBox.TextBoxElement.CustomFontSize = 10.5f;
            this.addressTextBox.ForeColor = Color.FromArgb(33, 33, 33);

            this.cityLabel.LabelElement.CustomFont = Utils.MainFont;
            this.cityLabel.LabelElement.CustomFontSize = 10.5f;
            this.cityLabel.ForeColor = Color.FromArgb(89, 89, 89);
            this.cityLabel.TextAlignment = ContentAlignment.BottomLeft;

            this.cityTextBox.TextBoxElement.CustomFont = Utils.MainFont;
            this.cityTextBox.TextBoxElement.CustomFontSize = 10.5f;
            this.cityTextBox.ForeColor = Color.FromArgb(33, 33, 33);

            this.phoneLabel.LabelElement.CustomFont = Utils.MainFont;
            this.phoneLabel.LabelElement.CustomFontSize = 10.5f;
            this.phoneLabel.ForeColor = Color.FromArgb(89, 89, 89);
            this.phoneLabel.TextAlignment = ContentAlignment.BottomLeft;

            this.phoneTextBox.TextBoxElement.CustomFont = Utils.MainFont;
            this.phoneTextBox.TextBoxElement.CustomFontSize = 10.5f;
            this.phoneTextBox.ForeColor = Color.FromArgb(33, 33, 33);

            this.creditCardNumberLabel.LabelElement.CustomFont = Utils.MainFont;
            this.creditCardNumberLabel.LabelElement.CustomFontSize = 10.5f;
            this.creditCardNumberLabel.ForeColor = Color.FromArgb(89, 89, 89);
            this.creditCardNumberLabel.TextAlignment = ContentAlignment.BottomLeft;

            this.creditCardNumberTexBox.TextBoxElement.CustomFont = Utils.MainFont;
            this.creditCardNumberTexBox.TextBoxElement.CustomFontSize = 10.5f;
            this.creditCardNumberTexBox.ForeColor = Color.FromArgb(33, 33, 33);

            this.validLabel.LabelElement.CustomFont = Utils.MainFont;
            this.validLabel.LabelElement.CustomFontSize = 10.5f;
            this.validLabel.ForeColor = Color.FromArgb(89, 89, 89);

            this.validDateTimePicker.DateTimePickerElement.CustomFont = Utils.MainFont;
            this.validDateTimePicker.DateTimePickerElement.CustomFontSize = 10.5f;
            this.validDateTimePicker.DateTimePickerElement.ForeColor = Color.FromArgb(33, 33, 33);

            this.ccvLabel.LabelElement.CustomFont = Utils.MainFont;
            this.ccvLabel.LabelElement.CustomFontSize = 10.5f;
            this.ccvLabel.ForeColor = Color.FromArgb(89, 89, 89);

            this.ccvTextBox.TextBoxElement.CustomFont = Utils.MainFont;
            this.ccvTextBox.TextBoxElement.CustomFontSize = 10.5f;
            this.ccvTextBox.ForeColor = Color.FromArgb(33, 33, 33);

            this.editPanel.RootElement.EnableElementShadow = false;
            this.radSplitContainer1.RootElement.EnableElementShadow = false;
            foreach (RadControl c in this.editPanel.Controls)
            {
                c.RootElement.EnableElementShadow = false;
            }

            foreach (Telerik.WinControls.UI.SplitPanel sp in this.radSplitContainer1.SplitPanels)
            {
                sp.RootElement.EnableElementShadow = false;
                sp.SplitPanelElement.Border.Visibility = ElementVisibility.Collapsed;
                foreach (RadControl c in sp.Controls)
                {
                    c.RootElement.EnableElementShadow = false;
                }
            }
            this.closeButton.RootElement.EnableElementShadow = false;
            this.closeButton.ButtonElement.Padding = new Padding(0);
            this.closeButton.ImageAlignment = ContentAlignment.TopRight;
            this.closeButton.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.closeButton.Image = HotelApp.Properties.Resources.not_clean;

            this.nameLabel.LabelElement.LabelText.Margin = new Padding(5, 0, 0, 0);
            this.idLabel.LabelElement.LabelText.Margin = new Padding(5, 0, 0, 0);
            this.addressLabel.LabelElement.LabelText.Margin = new Padding(5, 0, 0, 0);
            this.cityLabel.LabelElement.LabelText.Margin = new Padding(5, 0, 0, 0);
            this.phoneLabel.LabelElement.LabelText.Margin = new Padding(5, 0, 0, 0);
            this.creditCardNumberLabel.LabelElement.LabelText.Margin = new Padding(5, 0, 0, 0);
            this.validLabel.LabelElement.LabelText.Margin = new Padding(5, 0, 0, 0);

            this.validDateTimePicker.Format = DateTimePickerFormat.Custom;
            this.validDateTimePicker.CustomFormat = "MM.yyyy";
            this.validDateTimePicker.DateTimePickerElement.CalendarSize = new Size(350, 380);
            this.validDateTimePicker.DateTimePickerElement.TextBoxElement.Padding = new Padding(10, 0, 0, 0);
            this.validDateTimePicker.DateTimePickerElement.ArrowButton.Margin = new Padding(0, 0, 10, 0);

            this.ccvTextBox.TextBoxElement.Padding = new Padding(3, 0, 0, 0);

            this.nameTextBox.TextBoxElement.Border.Visibility = ElementVisibility.Collapsed;
            this.addressTextBox.TextBoxElement.Border.Visibility = ElementVisibility.Collapsed;
            this.cityTextBox.TextBoxElement.Border.Visibility = ElementVisibility.Collapsed;
            this.idTextBox.TextBoxElement.Border.Visibility = ElementVisibility.Collapsed;
            this.phoneTextBox.TextBoxElement.Border.Visibility = ElementVisibility.Collapsed;
            this.creditCardNumberTexBox.TextBoxElement.Border.Visibility = ElementVisibility.Collapsed;

            this.nameSeparator.SeparatorElement.Line1.BackColor = Color.FromArgb(209, 209, 209);
            this.idSeparator.SeparatorElement.Line1.BackColor = Color.FromArgb(209, 209, 209);
            this.addressSeparator.SeparatorElement.Line1.BackColor = Color.FromArgb(209, 209, 209);
            this.citySeparator.SeparatorElement.Line1.BackColor = Color.FromArgb(209, 209, 209);
            this.phoneSeparator.SeparatorElement.Line1.BackColor = Color.FromArgb(209, 209, 209);
            this.creditCardSeparator.SeparatorElement.Line1.BackColor = Color.FromArgb(209, 209, 209);
            this.validSeparator.SeparatorElement.Line1.BackColor = Color.FromArgb(209, 209, 209);
            this.ccvSeparator.SeparatorElement.Line1.BackColor = Color.FromArgb(209, 209, 209);
            this.ccvTextBox.TextBoxElement.ShowBorder = false;

            this.saveButton.ButtonElement.CustomFont = Utils.MainFontMedium;
            this.saveButton.ButtonElement.CustomFontSize = 10.5f;
            this.saveButton.ButtonElement.ForeColor = Color.FromArgb(33, 33, 33);

            this.idTextBox.NullText = "Enter ID";
            this.nameTextBox.NullText = "Enter name";
            this.addressTextBox.NullText = "Enter address";
            this.cityTextBox.NullText = "Enter city";
            this.phoneTextBox.NullText = "Enter phone";
            this.creditCardNumberTexBox.NullText = "Enter credit card id";
            this.validDateTimePicker.Value = DateTime.Today;
            this.ccvTextBox.NullText = "Enter ccv";
        }

        public Guest CurrentGuest
        {
            get
            {
                return this.currentGuest;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            HotelAppForm form = this.FindForm() as HotelAppForm;
            if (form != null)
            {
                if (form.PageView.SelectedPage == form.PageView.Pages[1])
                {
                    this.Parent.Visible = false;
                }
                else
                {
                    this.Visible = false;
                    this.Parent.Controls[0].Visible = true;
                }
            }
        }

        internal void Initialize(HotelApp.Guest guest, Booking booking)
        {
            currentGuest = guest;
            this.booking = booking;
            if (currentGuest == null)
            {
                return;
            }
            this.guestInfoLabel.Text = "EDIT GUEST INFORMATION";
            this.idTextBox.Text = guest.Id;
            this.nameTextBox.Text = guest.Name;
            this.addressTextBox.Text = guest.Address;
            this.cityTextBox.Text = guest.City;
            this.phoneTextBox.Text = guest.Phone;
            if (guest.CardDetails != null)
            {
                this.creditCardNumberTexBox.Text = guest.CardDetails.CreditCardId;
                this.validDateTimePicker.Value = guest.CardDetails.ExpiresOn;
                this.ccvTextBox.Text = guest.CardDetails.CCV.ToString();
            }
            
            if (booking != null && !booking.Guests.Contains(guest))
            {
                booking.Guests.Add(guest);
                booking.Name = booking.Guests.First().Name;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                if (currentGuest == null)
                {
                    currentGuest = new Guest();
                    currentGuest.CardDetails = new CreditCard();
                }
                this.currentGuest.Name = this.nameTextBox.Text;
                this.currentGuest.Id = this.idTextBox.Text;
                this.currentGuest.Address = this.addressTextBox.Text;
                this.currentGuest.City = this.cityTextBox.Text;
                this.currentGuest.Phone = this.phoneTextBox.Text;
                this.currentGuest.CardDetails.CreditCardId = this.creditCardNumberTexBox.Text;
                this.currentGuest.CardDetails.ExpiresOn = this.validDateTimePicker.Value;
                this.currentGuest.CardDetails.CCV = uint.Parse(this.ccvTextBox.Text);
                if (!this.booking.Guests.Contains(this.currentGuest))
                {
                    this.booking.Guests.Add(this.currentGuest);
                }
                booking.Name = booking.Guests.First().Name;
                HotelAppForm form = this.FindForm() as HotelAppForm;
                if (form != null && !form.Bookings.Contains(this.booking))
                {
                    form.Bookings.Add(this.booking);
                }
                this.saveButton.DialogResult = DialogResult.OK;
                this.closeButton.PerformClick();
            }
            else
            {
                this.saveButton.DialogResult = DialogResult.Cancel;
            }
        }

        private bool IsValidData()
        {
            this.errorLabel.Text = "";
            this.errorLabel.ForeColor = Color.Red;
            if (this.nameTextBox.Text == "")
            {
                this.errorLabel.Text = "Name is not allowed to be empty!";
                return false;
            }
            if (this.idTextBox.Text == "")
            {
                this.errorLabel.Text = "Id is not allowed to be empty!";
                return false;
            }
            if (this.addressTextBox.Text == "")
            {
                this.errorLabel.Text = "Address is not allowed to be empty!";
                return false;
            }
            if (this.cityTextBox.Text == "")
            {
                this.errorLabel.Text = "City is not allowed to be empty!";
                return false;
            }
            if (this.phoneTextBox.Text == "")
            {
                this.errorLabel.Text = "Phone is not allowed to be empty!";
                return false;
            }
            if (this.creditCardNumberTexBox.Text == "")
            {
                this.errorLabel.Text = "Credit card # is not allowed to be empty!";
                return false;
            }
            uint ccv = 0;
            if (!uint.TryParse(this.ccvTextBox.Text, out ccv))
            {
                this.errorLabel.Text = "CCV is not allowed to be empty!";
                return false;
            }
            return true;
        }
    }
}