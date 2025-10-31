using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace ERP.Client 
{
    public partial class RelatedOrdersControl : UserControl
    {
        public RelatedOrdersControl()
        {
            this.InitializeComponent();
            this.radGridView1.EnableGrouping = false;
            this.radGridView1.EnableFiltering = true;
            this.radGridView1.ShowHeaderCellButtons = true;
            this.radGridView1.ShowFilteringRow = false;
            this.radGridView1.ReadOnly = true;
            this.radGridView1.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;

            this.radGridView1.Columns[0].FieldName = "SalesOrderNumber";
            this.radGridView1.Columns[1].FieldName = "Customer";
            this.radGridView1.Columns[2].FieldName = "DueDate";
            this.radGridView1.Columns[3].FieldName = "OnlineOrderFlag";
            this.radGridView1.Columns[4].FieldName = "AccountNumber";
            this.radGridView1.Columns[5].FieldName = "SubTotal";
            this.radGridView1.Columns[6].FieldName = "TaxAmt";
            this.radGridView1.Columns[7].FieldName = "Freight";
            this.radGridView1.Columns[8].FieldName = "TotalDue";
            this.radGridView1.Columns[9].FieldName = ".ShipMethod.Name";
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
