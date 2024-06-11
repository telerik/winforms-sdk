using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using System.Drawing;

namespace AppPortfolio
{
    public class PortfolioButtonElement : RadButtonElement
    {
        private string executeCommand = string.Empty;

        private string productImageLocation = string.Empty;
        private string productDescription = string.Empty;
        private string productTitle = string.Empty;

        public PortfolioButtonElement()
        {
            this.ButtonFillElement.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
        }

        [DefaultValue("")]
        public string NavigateToURL
        {
            get { return executeCommand; }
            set { executeCommand = value; }
        }

        [DefaultValue("")]
        public string ProductImageLocation
        {
            get
            {
                return this.productImageLocation;
            }
            set
            {
                this.productImageLocation = value;
            }
        }

        public Image GetProductImage()
        {
            if (string.IsNullOrEmpty(this.productImageLocation))
            {
                return null;
            }

            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            Stream stream = executingAssembly.GetManifestResourceStream(this.productImageLocation);

            return new Bitmap(stream);
        }

        [DefaultValue("")]
        public string ProductDescription
        {
            get
            {
                return this.productDescription;
            }
            set
            {
                this.productDescription = value;
            }
        }

        [DefaultValue("")]
        public string ProductTitle
        {
            get
            {
                return this.productTitle;
            }
            set
            {
                this.productTitle = value;
            }
        }

        public virtual void ExecuteCommand()
        {
            Process.Start(this.NavigateToURL, null);

            //string fileName = string.Empty;
            //if (!Path.IsPathRooted(this.NavigateToURL))
            //{
            //    fileName = Path.Combine(basePath, this.NavigateToURL);
            //}
            //else
            //{
            //    fileName = this.NavigateToURL;
            //}
            //if (!File.Exists(fileName))
            //{
            //    MessageBox.Show("File not found: " + fileName);
            //    return;
            //}

            //ProcessStartInfo startInfo = new ProcessStartInfo(fileName);
            //startInfo.WorkingDirectory = Path.GetDirectoryName(fileName);
            //Process.Start(startInfo);



            //formTypeName += this.NavigateToURL.Replace("/", ".");
            //formType = Assembly.GetEntryAssembly().GetType(formTypeName);
            //Control ctrl = Activator.CreateInstance(formType) as Control;

            //Form ctrlForm = new Form();
            //if (ctrl != null)
            //{
            //    ctrlForm.Controls.Add(ctrl);
            //    ctrlForm.ShowDialog();
            //}


            //formTypeName = this.NavigateToURL.Replace("/", ".");
            //formType = Assembly.GetEntryAssembly().GetType(formTypeName);
            //Form form = Activator.CreateInstance(formType) as Form;
            //if (form != null)
            //{
            //    form.ShowDialog();
            //}

        }
    }

}
