using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace ScalingZoom
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        Dictionary<string, SizeF> factors = new Dictionary<string, SizeF>();
        public RadForm1()
        {
            InitializeComponent();
            radGridView1.DataSource = GetTable();

            factors.Add("100%", new SizeF(1, 1));
            factors.Add("125%", new SizeF(1.25F, 1.25F));
            factors.Add("150%", new SizeF(1.5F, 1.5F));
            factors.Add("200%", new SizeF(2, 2));

            radDropDownList1.DisplayMember = "Key";
            radDropDownList1.ValueMember = "Value";
            radDropDownList1.DataSource = factors;
            radDropDownList1.DropDownStyle = RadDropDownStyle.DropDownList;
            radDropDownList1.SelectedIndexChanged += RadDropDownList1_SelectedIndexChanged;
        }


        private void RadDropDownList1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
           
            var currentScale = this.RootElement.DpiScaleFactor;
            var newFactor = (SizeF)radDropDownList1.SelectedValue;
            newFactor = new SizeF(newFactor.Width * (1f / currentScale.Width), newFactor.Height * (1f / currentScale.Height));

            if (newFactor.Width < 1f)
            {
                this.Size = new Size((int)(this.Width * newFactor.Width), (int)(this.Height * newFactor.Height));
            }

            this.Scale(newFactor);
           
        }
        static DataTable GetTable()
        {

            DataTable table = new DataTable();
            table.Columns.Add("Dosage", typeof(int));
            table.Columns.Add("Drug", typeof(string));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Date", typeof(DateTime));


            table.Rows.Add(25, "Indocin", "David", DateTime.Now);
            table.Rows.Add(50, "Enebrel", "Sam", DateTime.Now);
            table.Rows.Add(10, "Hydralazine", "Christoff", DateTime.Now);
            table.Rows.Add(21, "Combivent", "Janet", DateTime.Now);
            table.Rows.Add(100, "Dilantin", "Melanie", DateTime.Now);
            return table;
        }
    }
}
