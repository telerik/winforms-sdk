using CustomControls;
using HotelApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.UI;

namespace HotelApp
{
    partial class HotelAppForm
    {
        #region Initialization

        private void InitBookingsPage()
        {
            this.bookingsMainContainer.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed;
            this.navigationPanelBookings.BackgroundImage = Properties.Resources.fasha_no_borders;
            this.navigationPanelBookings.BackgroundImageLayout = ImageLayout.Stretch;
            this.navigationPanelBookings.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed;

            this.navigationPanelBookings.PanelElement.PanelFill.BackColor = Color.Transparent;
            this.navigationPanelBookings.PanelElement.PanelFill.GradientStyle = GradientStyles.Solid;
            this.searchContainerBookings.PanelElement.PanelFill.BackColor = Color.Transparent;
            this.searchContainerBookings.BackColor = Color.Transparent;
            this.searchContainerBookings.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed;
            this.radPanelEmptyBooking.PanelElement.PanelFill.BackColor = Color.Transparent;
            this.radPanelEmptyBooking.BackColor = Color.Transparent;
            this.radPanelEmptyBooking.PanelElement.PanelBorder.Visibility = ElementVisibility.Collapsed;

            this.bookingInfoRightPanel.RootElement.EnableElementShadow = false;
            this.bookingInfoRightPanel.Visible = false;
            this.editGuestInfo.Visible = false;

            this.bookingsGrid.MasterTemplate.Tag = Rooms;
            this.bookingsGrid.TableElement.CellSpacing = 10;
            this.bookingsGrid.RootElement.EnableElementShadow = false;
            this.bookingsGrid.GridViewElement.DrawFill = false;
            this.bookingsGrid.TableElement.Margin = new Padding(15, 0, 15, 0);
            this.bookingsGrid.BackColor = Color.Transparent;
            this.bookingsGrid.GridViewElement.DrawFill = true;
            this.bookingsGrid.AllowAddNewRow = false;
            this.bookingsGrid.EnableGrouping = false;

            this.bookingsGrid.DataSource = GetBookingsByDate(this.bookings, dateNavigatorBookings.CurrentDate);
            this.bookingsGrid.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            this.bookingsGrid.Columns["Id"].IsVisible = false;
            this.bookingsGrid.Columns["Price"].IsVisible = false;
            this.bookingsGrid.Columns["PricePerDay"].IsVisible = false;
            this.bookingsGrid.Columns["Status"].IsVisible = false;
            this.bookingsGrid.Columns["Guests"].IsVisible = false;
            this.bookingsGrid.Columns["FullInfo"].IsVisible = false;
            this.bookingsGrid.Columns["Name"].Width = 310;
            this.bookingsGrid.Columns["RoomId"].Width = 230;
            this.bookingsGrid.Columns["RoomId"].HeaderText = "Room";
            this.bookingsGrid.Columns["RoomId"].TextAlignment = ContentAlignment.MiddleLeft;
            foreach (GridViewDataColumn col in this.bookingsGrid.Columns)
            {
                col.HeaderTextAlignment = ContentAlignment.MiddleLeft;
            }

            GridViewDateTimeColumn fromColumn = this.bookingsGrid.Columns["From"] as GridViewDateTimeColumn;
            fromColumn.Format = DateTimePickerFormat.Custom;
            fromColumn.CustomFormat = "dd.MM.yyyy";
            fromColumn.FormatString = "{0:dd.MM.yyyy}";
            fromColumn.Width = 220;
            fromColumn.TextAlignment = ContentAlignment.MiddleLeft;

            GridViewDateTimeColumn toColumn = this.bookingsGrid.Columns["To"] as GridViewDateTimeColumn;
            toColumn.Format = DateTimePickerFormat.Custom;
            toColumn.CustomFormat = "dd.MM.yyyy";
            toColumn.FormatString = "{0:dd.MM.yyyy}";
            toColumn.Width = 180;
            toColumn.TextAlignment = ContentAlignment.MiddleLeft;

            this.labelBookings.LabelElement.Margin = new Padding(12, 0, 0, 0);
            this.labelBookings.LabelElement.LabelText.Margin = new Padding(0, 0, 0, 5);
            this.labelBookings.LabelElement.CustomFont = Utils.MainFont;
            this.labelBookings.LabelElement.CustomFontSize = 15;

            bookingsLeftView.ShowGroups = true;
            bookingsLeftView.EnableGrouping = true;
            bookingsLeftView.EnableCustomGrouping = true;
            ListViewDataItemGroup statusGroup = new ListViewDataItemGroup();
            statusGroup.Text = "STATUS";

            this.bookingsLeftView.ShowCheckBoxes = true;
            this.bookingsLeftView.Groups.AddRange(new ListViewDataItemGroup[] { statusGroup });
            this.bookingsLeftView.ListViewElement.Padding = new System.Windows.Forms.Padding(0, 16, 0, 0);

            Array statusOptions = Enum.GetValues(typeof(BookingStatus));
            foreach (object item in statusOptions)
            {
                ListViewDataItem statusItem = new ListViewDataItem(item.ToString());
                statusItem.CheckState = Telerik.WinControls.Enumerations.ToggleState.On;
                this.bookingsLeftView.Items.Add(statusItem);
                statusItem.Group = statusGroup;
            }

            this.bookingsGrid.ReadOnly = true;
            this.bookingsGrid.EnableFiltering = true;
            this.bookingsGrid.EnableCustomFiltering = true;
            this.bookingsGrid.ShowFilteringRow = false;
        }

        #endregion

        #region Events
        private void bookingInfoRightPanel_VisibleChanged(object sender, EventArgs e)
        {
            if (this.bookingInfoRightPanel.Visible)
            {
                this.bookingsGrid.Columns["Name"].Width = 210;
                this.bookingsGrid.Columns["RoomId"].Width = 170;
                this.bookingsGrid.Columns["From"].Width = 170;
                this.bookingsGrid.Columns["To"].Width = 150;
            }
            else
            {
                this.bookingsGrid.Columns["Name"].Width = 310;
                this.bookingsGrid.Columns["RoomId"].Width = 230;
                this.bookingsGrid.Columns["From"].Width = 210;
                this.bookingsGrid.Columns["To"].Width = 210;
            }
        }

        private void bookingsGrid_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            this.bookingInfoRightPanel.Visible = true;
            this.editGuestInfo.Visible = false;
            this.bookingInfoUC.Visible = true;
            this.bookingInfoUC.LoadBookingInfo(e.Row.DataBoundItem as Booking, this.Rooms);
        }

        private void bookingsLeftView_ItemCheckedChanged(object sender, ListViewItemEventArgs e)
        {
            this.bookingsGrid.MasterTemplate.Refresh();
        }

        private void bookingsGrid_CustomFiltering(object sender, GridViewCustomFilteringEventArgs e)
        {
            e.Handled = true;
            BookingStatus status = (BookingStatus)e.Row.Cells["Status"].Value;
            e.Row.IsVisible = IsBookingStatusChecked(status);
            if (this.searchTextBoxBookings.Text != null)
            {
                e.Row.IsVisible &= e.Row.Cells["Name"].Value.ToString().Contains(this.searchTextBoxBookings.Text) ||
                                   e.Row.Cells["RoomId"].Value.ToString().Contains(this.searchTextBoxBookings.Text);
            }
        }

        private bool IsBookingStatusChecked(BookingStatus status)
        {
            foreach (ListViewDataItem item in this.bookingsLeftView.Items)
            {
                if (item.Text == status.ToString())
                {
                    if (item.CheckState == ToggleState.On)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        private void searchTextBoxBookings_TextChanged(object sender, EventArgs e)
        {
            this.bookingsGrid.MasterTemplate.Refresh();
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.bookingsGrid.DataSource = GetBookingsByDate(this.bookings, dateNavigatorBookings.CurrentDate);
            this.bookingsLeftView.ListViewElement.SynchronizeVisualItems();
            this.scheduleDateNavigator.DateTimePicker.Value = this.BookingsDate;
        }

        private object GetBookingsByDate(BindingList<Booking> bookings, DateTime date)
        {
            BindingList<Booking> dailyBookings = new BindingList<Booking>();
            foreach (Booking b in bookings)
            {
                if (b.From <= date && b.To >= date)
                {
                    dailyBookings.Add(b);
                }
            }
            return dailyBookings;
        }

        private void bookingsGrid_ViewCellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (e.Column.Name == "RoomId" && e.Row is GridViewTableHeaderRowInfo)
            {
                e.CellElement.Padding = new Padding(15, 0, 0, 0);
            }
            else
            {
                e.CellElement.ResetValue(LightVisualElement.PaddingProperty, ValueResetFlags.Local);
            }
        }

        private void bookingsGrid_CreateCell(object sender, GridViewCreateCellEventArgs e)
        {
            if (e.Row.RowInfo is GridViewDataRowInfo)
            {
                if (e.Column.Name == "Name")
                {
                    e.CellElement = new NameGridDataCellElement(e.Column, e.Row);
                }
                else if (e.Column.Name == "RoomId")
                {
                    e.CellElement = new RoomGridDataCellElement(e.Column, e.Row);
                }
            }
        }

        private void bookingsGrid_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            if (e.CurrentRow != null)
            {
                this.bookingInfoRightPanel.Visible = true;
                this.editGuestInfo.Visible = false;
                this.bookingInfoUC.Visible = true;
                this.bookingInfoUC.LoadBookingInfo(e.CurrentRow.DataBoundItem as Booking, this.Rooms);
            }
        }

        #endregion

    }
}
