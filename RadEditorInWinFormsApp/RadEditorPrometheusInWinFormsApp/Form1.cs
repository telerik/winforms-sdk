using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using mshtml;

namespace GetRadEditorHtml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.webBrowser1.ReadyState == WebBrowserReadyState.Loading ||
                this.webBrowser1.ReadyState == WebBrowserReadyState.Uninitialized)
            {
                MessageBox.Show("Please wait for RadEditor to load first.");
                return;
            }

            //Register a script function to extract editor's html 
            string jsFunction = @"
            function GetEditorHtml()
            {
                return $find('RadEditor1').get_html(true);
            }";

            IHTMLDocument doc1 = (IHTMLDocument)this.webBrowser1.Document.DomDocument;
            HTMLWindow2 iHtmlWindow2 = (HTMLWindow2)doc1.Script;
            //register
            iHtmlWindow2.execScript(jsFunction, "javascript");

            //call the function to get editor's text
            try
            {
                object res = this.webBrowser1.Document.InvokeScript("GetEditorHtml");
                MessageBox.Show(res == null ? "null" : res.ToString(), this.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "RadEditor's text: " + this.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.webBrowser1.Url = new Uri("http://www.telerik.com/DEMOS/ASPNET/Prometheus/Editor/Examples/Default/DefaultCS.aspx");
        }
    }
}