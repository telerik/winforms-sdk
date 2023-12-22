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
    public partial class RelatedOrdersControl : UserControl
    {
        public RelatedOrdersControl()
        {
            InitializeComponent();
            radGridView1.EnableGrouping = false;
            radGridView1.EnableFiltering = true;
            radGridView1.ShowHeaderCellButtons = true;
            radGridView1.ShowFilteringRow = false;
            radGridView1.ReadOnly = true;
            radGridView1.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;

            radGridView1.Columns[0].FieldName = "SalesOrderNumber";
            radGridView1.Columns[1].FieldName = "Customer";
            radGridView1.Columns[2].FieldName = "DueDate";
            radGridView1.Columns[3].FieldName = "OnlineOrderFlag";
            radGridView1.Columns[4].FieldName = "AccountNumber";
            radGridView1.Columns[5].FieldName = "SubTotal";
            radGridView1.Columns[6].FieldName = "TaxAmt";
            radGridView1.Columns[7].FieldName = "Freight";
            radGridView1.Columns[8].FieldName = "TotalDue";
            radGridView1.Columns[9].FieldName = ".ShipMethod.Name";
        }
        public RadGridView OrdersGrid
        {
            get
            {
                return this.radGridView1;
            }
        }
    }
}
