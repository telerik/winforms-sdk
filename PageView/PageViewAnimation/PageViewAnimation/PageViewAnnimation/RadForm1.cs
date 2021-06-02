using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace PageViewAnnimation
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        System.Windows.Forms.Timer timer;
        RadPageViewPage currentPage;

        public RadForm1()
        {
            InitializeComponent();

            RadPageViewExplorerBarElement explorerBarElement = radPageView1.ViewElement as RadPageViewExplorerBarElement;
            
            foreach (RadPageViewExplorerBarItem item in explorerBarElement.Items)
            {
                item.MouseHover += item_MouseHover;
                item.AssociatedContentAreaElement.RadPropertyChanging += AssociatedContentAreaElement_RadPropertyChanging;
            }

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 30;
            timer.Tick += timer_Tick;
            radPageView1.PageExpanded += radPageView1_PageExpanded;
        }
        
        void timer_Tick(object sender, EventArgs e)
        {
            currentPage.PageLength += 20;
            if (currentPage.PageLength >= 300)
            {
                timer.Stop();
            }
        }

        void radPageView1_PageExpanded(object sender, RadPageViewEventArgs e)
        {
            timer.Stop();
            currentPage = e.Page;
            currentPage.PageLength = 0;
            timer.Start();
        }

        void AssociatedContentAreaElement_RadPropertyChanging(object sender, RadPropertyChangingEventArgs args)
        {
            if (args.Property.Name == "Bounds")
            {
                //suspend layout when animating
                args.Cancel = timer.Enabled;
            }
        }

        void item_MouseHover(object sender, EventArgs e)
        {
            RadPageViewExplorerBarItem item = (RadPageViewExplorerBarItem)sender;

            RadPageViewExplorerBarElement explorerBarElement = radPageView1.ViewElement as RadPageViewExplorerBarElement;
            foreach (RadPageViewExplorerBarItem i in explorerBarElement.Items)
            {
                i.IsExpanded = false;
            }

            item.IsExpanded = true;
        }
    }
}