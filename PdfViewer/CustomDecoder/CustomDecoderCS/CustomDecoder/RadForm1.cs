using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.Windows.Documents.Fixed.FormatProviders.Pdf.Filters;

namespace CustomDecoder
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        private JpxDecoder filterNew;
        public RadForm1()
        {
            filterNew = new JpxDecoder();
            FiltersManager.RegisterFilter(filterNew);

            InitializeComponent();
            var stream = File.OpenRead("../../SampleData/test.pdf");
            radPdfViewer1.LoadDocument(stream);

        }
    }
}
