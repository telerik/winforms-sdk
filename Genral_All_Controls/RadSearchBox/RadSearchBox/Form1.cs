using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.Layouts;

namespace RadSearchBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            SearchTextBox searchBox = new SearchTextBox();
            searchBox.Size = new System.Drawing.Size(200, 20);
            searchBox.Location = new Point(10, 200);
            searchBox.Search += searchBox_Search;
            this.Controls.Add(searchBox);
        }

        private void searchBox_Search(object sender, SearchTextBox.SearchBoxEventArgs e)
        {
            RadMessageBox.Show("Search >> " + e.SearchText);
        }

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
            }

            RadButtonElement searchButton = new RadButtonElement();

            protected override void InitializeTextElement()
            {
                base.InitializeTextElement();
                this.TextBoxElement.TextBoxItem.NullText = "Enter search criteria";
                searchButton.Click += new EventHandler(button_Click);
                searchButton.Margin = new Padding(0, 0, 0, 0);
                searchButton.Text = string.Empty;
                searchButton.Image = Properties.Resources.SearchIcon;

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
}