using HotelApp.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.Layouts;
using Telerik.WinControls.UI;

namespace CustomControls
{
    public class SearchTextBox : RadTextBox
    {
        public override string ThemeClassName
        {
            get
            {
                return typeof(RadTextBox).FullName;
            }
        }

        protected override void OnLoad(Size desiredSize)
        {
            base.OnLoad(desiredSize);
            searchButton.ButtonFillElement.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            searchButton.ShowBorder = false;
            searchButton.EnableElementShadow = false;
            this.TextBoxElement.Padding = new Padding(0);
        }

        RadButtonElement searchButton = new RadButtonElement();

        protected override void InitializeTextElement()
        {
            base.InitializeTextElement();
            this.TextBoxElement.TextBoxItem.NullText = "Search by room# or guest name";
            searchButton.Click += new EventHandler(button_Click);
            searchButton.Margin = new Padding(0, 0, 0, 0);
            this.TextBoxElement.TextBoxItem.CustomFont =  Utils.MainFont;          
            this.TextBoxElement.TextBoxItem.CustomFontSize = 9;
            searchButton.TextElement.CustomFont = "TelerikWebUI";
            searchButton.TextElement.CustomFontSize = 12;
            searchButton.TextElement.ForeColor = Color.Gray;
            searchButton.MaxSize = new System.Drawing.Size(40, 35);
            searchButton.Text = "\ue13E";
            StackLayoutElement stackPanel = new StackLayoutElement();
            stackPanel.Orientation = Orientation.Horizontal;
            stackPanel.Margin = new Padding(1, 0, 1, 0);
            stackPanel.Children.Add(searchButton);
           
            RadTextBoxItem tbItem = this.TextBoxElement.TextBoxItem;
            this.TextBoxElement.Children.Remove(tbItem);
            DockLayoutPanel dockPanel = new DockLayoutPanel();
            dockPanel.Children.Add(stackPanel);
            dockPanel.Children.Add(tbItem);
            DockLayoutPanel.SetDock(tbItem, Telerik.WinControls.Layouts.Dock.Left);
            DockLayoutPanel.SetDock(stackPanel, Telerik.WinControls.Layouts.Dock.Right);

            this.TextBoxElement.Children.Add(dockPanel);
        }

        public class SearchBoxEventArgs : EventArgs
        {
            private string searchText;

            public string SearchText
            {
                get
                {
                    return searchText;
                }
                set
                {
                    searchText = value;
                }
            }
        }

        public event EventHandler<SearchBoxEventArgs> Search;

        private void button_Click(object sender, EventArgs e)
        {
            SearchBoxEventArgs newEvent = new SearchBoxEventArgs();
            newEvent.SearchText = this.Text;
            SearchEventRaiser(newEvent);
        }

        private void SearchEventRaiser(SearchBoxEventArgs e)
        {
            if (Search != null)
                Search(this, e);
        }
    }
}