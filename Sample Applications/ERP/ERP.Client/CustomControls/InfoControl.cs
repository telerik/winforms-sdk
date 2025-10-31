using System;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace ERP.Client
{
    public partial class InfoControl : UserControl
    {
        public RadPdfViewer InfoPdfViewer
        {
            get { return this.infoPdfViewer; }
        }
        public string DocumentName
        {
            get;
            set;
        }

        public InfoControl()
        {
            this.InitializeComponent();
            this.infoPdfViewer.EnableThumbnails = false;
        }
       
        private void printButton_Click(object sender, EventArgs e)
        {
            this.infoPdfViewer.PrintPreview();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
                dialog.FilterIndex = 2;
                dialog.RestoreDirectory = true;
                dialog.FileName = this.DocumentName;

                if (dialog.ShowDialog() == DialogResult.OK)
                {

                    this.infoPdfViewer.SaveDocument(dialog.FileName);
                }
            }
           
        }
    }
}
