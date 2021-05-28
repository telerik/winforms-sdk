using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace MultiLinePageViewCS
{
    public partial class Form1 : RadForm
    {
        public Form1()
        {
            InitializeComponent();
          
            CommandBarRowElement row = new CommandBarRowElement();
            CommandBarStripElement strip = new CommandBarStripElement();
            row.Strips.Add(strip);
            radCommandBar1.Rows.Add(row);

            foreach (RadPageViewPage page in radPageView1.Pages)
            {
                if (strip.Items.Count >3)
                {
                    row = new CommandBarRowElement();
                    strip = new CommandBarStripElement();
                    row.Strips.Add(strip);
                    radCommandBar1.Rows.Add(row);
                }

                CommandBarButton pageButton = new CommandBarButton();
                pageButton.DrawText = true;
                pageButton.Orientation = Orientation.Horizontal;
                pageButton.Image = null;
                pageButton.Text = page.Item.Text;
                pageButton.Click += new EventHandler(pageButton_Click);
                pageButton.StretchHorizontally = true;
                strip.Items.Add(pageButton);
                strip.StretchHorizontally = true;
                
                strip.OverflowButton.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;

                //adding a label to each page in order to verify the change when a command bar button is clicked
                RadLabel pageTitle = new RadLabel();
                pageTitle.Text = "Current page = " + page.Item.Text;
                pageTitle.Location = new Point(10, 10);
                page.Controls.Add(pageTitle);
            }
            RadPageViewStripElement stripElement = radPageView1.ViewElement as RadPageViewStripElement;
            stripElement.ItemContainer.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
        }

        void pageButton_Click(object sender, EventArgs e)
        {
            CommandBarButton pageButton = sender as CommandBarButton;
            radPageView1.SelectedPage = radPageView1.Pages[pageButton.Text];
            //reset all buttons colors
            foreach (CommandBarRowElement row in radCommandBar1.Rows)
            {
                foreach (CommandBarStripElement strip in row.Strips)
                {
                    foreach (CommandBarButton button in strip.Items)
                    {
                        button.ResetValue(LightVisualElement.BackColorProperty, Telerik.WinControls.ValueResetFlags.Local);
                        button.ResetValue(LightVisualElement.NumberOfColorsProperty, Telerik.WinControls.ValueResetFlags.Local);
                    }
                }
            }
            pageButton.BackColor = Color.LightSalmon;
            pageButton.NumberOfColors = 1;
        }
    }
}