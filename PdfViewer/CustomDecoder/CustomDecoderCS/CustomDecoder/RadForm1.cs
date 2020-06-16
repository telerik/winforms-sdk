using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private JpxDecoder filter;
        public RadForm1()
        {
            filter = new JpxDecoder();
            FiltersManager.RegisterFilter(filter);

            InitializeComponent();

            radPdfViewer1.LoadDocument("../../SampleData/test.pdf");

        }
    }
}
