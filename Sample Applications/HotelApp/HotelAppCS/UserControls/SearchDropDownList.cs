using HotelApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Layouts;
using Telerik.WinControls.UI;

namespace HotelApp
{
    public class SearchDropDownList : RadDropDownList
    {
        public override string ThemeClassName
        {
            get
            {
                return typeof(RadDropDownList).FullName;
            }
        }
        public void Inialize(BindingList<Room> rooms, BindingList<Booking> bookings)
        {
            foreach (Room r in rooms)
            {
                this.Items.Add("Room#" + r.Name);
            }
            foreach (Booking b in bookings)
            {
                if (!this.Items.Contains(b.Name))
                {
                    this.Items.Add(b.Name);
                }
            }
            this.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.DropDownListElement.AutoCompleteSuggest.SuggestMode = SuggestMode.Contains;
            this.SelectedIndexChanging += scheduleSearchDropDown_SelectedIndexChanging;

            this.DropDownListElement.CustomFont = Utils.MainFont;
            this.DropDownListElement.CustomFontSize = 9f;

            this.DropDownListElement.EditableElement.TextBox.Padding = new Padding(0, 10, 0, 0);
        }
        
        protected override void CreateChildItems(Telerik.WinControls.RadElement parent)
        {
            base.CreateChildItems(parent);
            LightVisualElement searchIcon = new LightVisualElement();
            searchIcon.Text = "\ue13E";
            searchIcon.CustomFont = "TelerikWebUI";
            searchIcon.CustomFontSize = 12;
            searchIcon.ForeColor = Color.Gray;
            this.NullText = "Search by room# or guest name";
            this.RootElement.EnableElementShadow = false;
            StackLayoutElement stackPanel = new StackLayoutElement();
            stackPanel.Orientation = Orientation.Horizontal;
            stackPanel.Margin = new Padding(1, 0, 1, 0);
            stackPanel.Children.Add(searchIcon);
           
            RadTextBoxItem tbItem = this.DropDownListElement.TextBox.TextBoxItem;
            this.DropDownListElement.TextBox.Children.Remove(tbItem);
            DockLayoutPanel dockPanel = new DockLayoutPanel();
            dockPanel.Children.Add(stackPanel);
            dockPanel.Children.Add(tbItem);
            DockLayoutPanel.SetDock(tbItem, Telerik.WinControls.Layouts.Dock.Left);
            DockLayoutPanel.SetDock(stackPanel, Telerik.WinControls.Layouts.Dock.Right);

            this.DropDownListElement.TextBox.Children.Add(dockPanel);
            this.DropDownListElement.ArrowButton.Visibility = ElementVisibility.Collapsed;
        }

        private void scheduleSearchDropDown_SelectedIndexChanging(object sender, Telerik.WinControls.UI.Data.PositionChangingCancelEventArgs e)
        {
            if (e.Position > -1)
            {
                HotelAppForm form = this.FindForm() as HotelAppForm;

                form.PageView.SelectedPage = form.PageView.Pages[0];
                form.HideRoomDetails();
                form.OverviewSearch.Text = this.Text; 
            }
        }
    }
}