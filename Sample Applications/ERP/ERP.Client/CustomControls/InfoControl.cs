using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            InitializeComponent();
            this.infoPdfViewer.EnableThumbnails = false;
        }
       
        private void printButton_Click(object sender, EventArgs e)
        {
            infoPdfViewer.PrintPreview();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
                dialog.FilterIndex = 2;
                dialog.RestoreDirectory = true;
                dialog.FileName = DocumentName;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    
                    infoPdfViewer.SaveDocument(dialog.FileName);
                }
            }
           
        }
    }
}
