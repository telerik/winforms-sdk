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
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.Xlsx;
using System.IO;
using Telerik.Windows.Documents.Spreadsheet.Model;
using Telerik.WinForms.Controls.Spreadsheet;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders;
using ERP.Repository;
using Telerik.WinControls;

namespace ERP.Client
{
    public partial class BaseGridControl : UserControl
    {
        protected List<string> columnNames;
        protected object currentItem;
        protected Type[] columnTypes;
        protected string dataFormText; 
        public RadVirtualGrid gridControl
        {
            get { return this.radGridView1; }
        }

        public BaseGridControl()
        {
            this.InitializeComponent();
            this.columnNames = new List<string>();
            this.radGridView1.SelectionMode = VirtualGridSelectionMode.FullRowSelect;
            this.radGridView1.AllowFiltering = true;
            this.radGridView1.AllowAddNewRow = false;
            this.radGridView1.AutoSizeColumnsMode = VirtualGridAutoSizeColumnsMode.Fill;
            this.radGridView1.CellValueNeeded += this.RadGridView1_CellValueNeeded;
            this.radGridView1.EnablePaging = true;
            this.radGridView1.PageSize = 20;
            this.radGridView1.VirtualGridElement.PageIndexChanged += this.VirtualGridElement_PageIndexChanged;
            this.radGridView1.VirtualGridElement.PageIndexChanging += this.VirtualGridElement_PageIndexChanging;
            this.radGridView1.CellEditorInitialized += this.RadGridView1_CellEditorInitialized;
            this.radGridView1.BeginEditMode = RadVirtualGridBeginEditMode.BeginEditProgrammatically;
            this.radGridView1.VirtualGridElement.TableElement.PagingPanelElement.Margin = new Padding(0, 0, 0, 1);
            this.radGridView1.AllowMultiColumnSorting = false;
            this.radGridView1.SortChanged += this.RadGridView1_SortChanged;
            this.radGridView1.FilterChanged += this.RadGridView1_FilterChanged;
            this.Initialize();
        }

        private void RadGridView1_FilterChanged(object sender, VirtualGridEventArgs e)
        {
            this.RefreshData(0);
        }

        protected virtual void RadGridView1_SortChanged(object sender, VirtualGridEventArgs e)
        {
            var skip = e.ViewInfo.PageSize * this.radGridView1.PageIndex;
            this.RefreshData(skip);
        }

        private void RadGridView1_CellEditorInitialized(object sender, VirtualGridCellEditorInitializedEventArgs e)
        {
            if (e.RowIndex == RadVirtualGrid.FilterRowIndex)
            {
                var editor  = e.ActiveEditor as BaseInputEditor;
                var element = editor.EditorElement as RadItem;
                if (element is RadSpinEditorElement)
                {
                    ((RadSpinEditorElement)element).TextBoxItem.KeyDown += this.Element_KeyDown;
                }
                else if(element is RadDateTimeEditorElement)
                {
                    ((RadDateTimeEditorElement)element).KeyDown += this.Element_KeyDown;
                }
                else if (element is RadTextBoxEditorElement)
                {
                    ((RadTextBoxEditorElement)element).TextBoxItem.KeyDown += this.Element_KeyDown;
                }
            }
        }

        private void Element_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.RefreshData(0);
                this.gridControl.PageIndex = 0;
            }
        }

        protected async void ExecuteQueryAsync<T>(Task<T> task, Action<T> callback)
        {
            var result = await task;
            callback(result);
        }

        protected virtual void VirtualGridElement_PageIndexChanging(object sender, VirtualGridPageChangingEventArgs e)
        {
            var skip = e.ViewInfo.PageSize * e.NewIndex;
            this.RefreshData(skip);
        }

        protected virtual void Initialize()
        {

        }

        protected virtual void VirtualGridElement_PageIndexChanged(object sender, VirtualGridEventArgs e)
        {

        }

        protected virtual void RadGridView1_CellValueNeeded(object sender, VirtualGridCellValueNeededEventArgs e)
        {

        }

        private ERPDataForm dialog = new ERPDataForm();
        protected virtual void EditButton_Click(object sender, EventArgs e)
        {
            if (this.gridControl.CurrentCell == null)
            {
                RadMessageBox.Show("Please select a row.");
                return;
            }

            this.dialog.Text = this.dataFormText;
            this.dialog.DataEntry.DataSource = this.currentItem;
         
            if (this.dialog.ShowDialog() == DialogResult.OK)
            {
                this.RefreshData(this.gridControl.PageSize * this.gridControl.PageIndex);                
            }
        }

        protected virtual void DeleteButton_Click(object sender, EventArgs e)
        {
            if (this.gridControl.CurrentCell == null)
            {
                RadMessageBox.Show("Please select a row!");
                return;
            }

            if (RadMessageBox.Show("Delete Selected Item?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.DeleteCurrentRow();
                this.RefreshData(this.gridControl.PageSize * this.gridControl.PageIndex);
            }
        }

        protected virtual void DeleteCurrentRow()
        {
            
        }

        protected virtual void PrintButton_Click(object sender, EventArgs e)
        {
            if (this.gridControl.MasterViewInfo.IsWaiting)
            {
                RadMessageBox.Show("The Data is not loaded! Please wait!");
                return ;
            }

            var spreadsheet = new RadSpreadsheet();
            var window = new Form() { Width = 0, Height = 0, Opacity = 0 };
            spreadsheet.Parent = window;
            window.Show();
            spreadsheet.Workbook = this.CreateWorkbook();         
            spreadsheet.Print(new PrintWhatSettings(ExportWhat.ActiveSheet, false));
            window.Close();
        }

        protected virtual void ExportButton_Click(object sender, EventArgs e)
        {
            if (this.gridControl.MasterViewInfo.IsWaiting)
            {
                RadMessageBox.Show("The Data is not loaded! Please wait!");
                return ;
            }

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = "Document.xlsx";
            savefile.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                var formatProvider = new XlsxFormatProvider();

                using (Stream output = new FileStream(savefile.FileName, FileMode.Create))
                {
                    formatProvider.Export(this.CreateWorkbook(), output, null);
                }
            }
        }

        protected virtual Workbook CreateWorkbook()
        {
            return new Workbook();
        }
        protected void ClearSelection()
        {
            this.gridControl.SelectCell(-1, -1);
            this.gridControl.CurrentCell = null;
        }

        protected virtual void RefreshData(int skip)
        {

        }              
    }
}
