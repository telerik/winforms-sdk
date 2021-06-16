using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace TreeViewDragDropToGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.radGridView1.RowCount = 10;

            TreeViewDragDropService treeViewDragDrop = this.radTreeView1.TreeViewElement.DragDropService;
            treeViewDragDrop.PreviewDragOver += this.OnPreviewDragOver;
            treeViewDragDrop.PreviewDragDrop += this.OnPreviewDragDrop;

            this.radTreeView1.AllowDragDrop = true;
            this.radGridView1.CellFormatting += new CellFormattingEventHandler(radGridView1_CellFormatting);
        }

        private void radGridView1_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            e.CellElement.AllowDrop = true;
        }

        private void OnPreviewDragDrop(object sender, Telerik.WinControls.RadDropEventArgs e)
        {
            GridDataCellElement dataCell = e.HitTarget as GridDataCellElement;

            if (dataCell != null)
            {
                TreeNodeElement element = e.DragInstance as TreeNodeElement;
                dataCell.Value = element.Data.Name;
                e.Handled = true;
            }
        }

        private void OnPreviewDragOver(object sender, Telerik.WinControls.RadDragOverEventArgs e)
        {
            GridDataCellElement dataCell = e.HitTarget as GridDataCellElement;

            if (dataCell != null)
            {
                TreeNodeElement element = e.DragInstance as TreeNodeElement;

                object value = null;
                e.CanDrop = RadDataConverter.Instance.TryParse(dataCell as IDataConversionInfoProvider,
                                                               element.Data.Name, out value) == null;
            }
        }

    }
}
