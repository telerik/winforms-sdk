using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Themes;
using Telerik.WinControls.UI;

namespace WindowsFormsApplication44
{
    public partial class Form1 : Form
    {
        RadTextBoxElement textBox = new RadTextBoxElement();

        public Form1()
        {
            InitializeComponent();

            new Windows8Theme();
            ThemeResolutionService.ApplicationThemeName = "Windows8";

            // This is the first item which expands/collapses the menu.
            expandCollapseItem.Item.Click += expandCollapseItem_Click;

            //SearchItem
            textBox.MaxSize = new Size(0, 20);
            searchPage.Item.Children.Add(textBox);

            searchPage.Item.DrawBorder = false;
            searchPage.Item.DrawFill = false;
            searchPage.Item.DrawImage = false;

            searchPage.Item.Click += SearchItem_Click;

            //separator
            separatorPage.Item.Margin = new Padding(0, 300, 0, 0);
            separatorPage.Item.Children.Add(new SeparatorElement());
        }

        private void SearchItem_Click(object sender, EventArgs e)
        {
            Toggle();
        }

        private void expandCollapseItem_Click(object sender, EventArgs e)
        {
            Toggle();
        }

        private void Toggle()
        {
            RadPageViewBackstageElement backstage = (RadPageViewBackstageElement)radPageView1.ViewElement;
            bool expanded = backstage.ItemContainer.MinSize.Width > 36;

            int width = expanded ? 36 : 200;
            backstage.ItemContainer.MinSize = new Size(width, 0);
            backstage.ItemContainer.MaxSize = new Size(width, 0);
            searchPage.Item.DrawImage = expanded;
            textBox.Visibility = expanded ? ElementVisibility.Hidden : ElementVisibility.Visible;

            foreach (RadPageViewPage page in radPageView1.Pages)
            {
                page.Item.DrawText = !expanded;
            }
        }

        private void radPageView1_SelectedPageChanging(object sender, RadPageViewCancelEventArgs e)
        {
            //we don't need content for this page since it is used for expanding/collapsing the menu
            e.Cancel = e.Page.Name == "expandCollapseItem";
        }
    }
}