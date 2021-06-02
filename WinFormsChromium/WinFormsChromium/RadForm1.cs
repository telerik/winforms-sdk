using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsChromium
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public ChromiumWebBrowser browser;

        public void InitBrowser()
        {
            Cef.Initialize(new CefSettings());
            browser = new ChromiumWebBrowser("www.google.com");
            this.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;

            browser.LoadingStateChanged += browser_LoadingStateChanged; 
        }

        private void browser_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            if (e.IsLoading == false)
            {
                browser.ExecuteScriptAsync("alert('All Resources Have Loaded');");
            }
        }
        
        public RadForm1()
        {
            InitializeComponent();
            InitBrowser();
        }
    }
}