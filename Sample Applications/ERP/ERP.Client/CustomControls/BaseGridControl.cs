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
        protected ISavableObject currentItem;
        protected Type[] columnTypes;
        protected string dataFormText; 
        public RadVirtualGrid gridControl
        {
            get { return this.radGridView1; }
        }

        public BaseGridControl()
        {
            InitializeComponent();
            columnNames = new List<string>();
            this.radGridView1.AllowFiltering = true;
            this.radGridView1.AllowAddNewRow = false;
            this.radGridView1.AutoSizeColumnsMode = VirtualGridAutoSizeColumnsMode.Fill;
            this.radGridView1.CellValueNeeded += RadGridView1_CellValueNeeded;
            this.radGridView1.EnablePaging = true;
            this.radGridView1.PageSize = 20;
            this.radGridView1.VirtualGridElement.PageIndexChanged += VirtualGridElement_PageIndexChanged;
            this.radGridView1.VirtualGridElement.PageIndexChanging += VirtualGridElement_PageIndexChanging;
            this.radGridView1.CellEditorInitialized += RadGridView1_CellEditorInitialized;
            this.radGridView1.BeginEditMode = RadVirtualGridBeginEditMode.BeginEditProgrammatically;
            this.radGridView1.VirtualGridElement.TableElement.PagingPanelElement.Margin = new Padding(0, 0, 0, 1);
            this.radGridView1.AllowMultiColumnSorting = false;
            this.radGridView1.SortChanged += RadGridView1_SortChanged;
            this.Initialize();
        }

        protected virtual void RadGridView1_SortChanged(object sender, VirtualGridEventArgs e)
        {
            var skip = e.ViewInfo.PageSize * radGridView1.PageIndex;
            RefreshData(skip);
        }

        private void RadGridView1_CellEditorInitialized(object sender, VirtualGridCellEditorInitializedEventArgs e)
        {
            if (e.RowIndex == RadVirtualGrid.FilterRowIndex)
            {
                var editor  = e.ActiveEditor as BaseInputEditor;
                var element = editor.EditorElement as RadItem;
                if (element is RadSpinEditorElement)
                {
                    ((RadSpinEditorElement)element).TextBoxItem.KeyDown += Element_KeyDown;
                }
                else if(element is RadDateTimeEditorElement)
                {
                    ((RadDateTimeEditorElement)element).KeyDown += Element_KeyDown;
                }
                else if (element is RadTextBoxEditorElement)
                {
                    ((RadTextBoxEditorElement)element).TextBoxItem.KeyDown += Element_KeyDown;
                }
            }
        }

        private void Element_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RefreshData(0);
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
            RefreshData(skip);
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

        protected virtual void EditButton_Click(object sender, EventArgs e)
        {
            if (this.gridControl.CurrentCell == null)
            {
                RadMessageBox.Show("Please select a row.");
                return;
            }

            var dialog = new ERPDataForm();
            dialog.Text = dataFormText;
            dialog.DataEntry.DataSource = currentItem;
         
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                currentItem.Save(false);
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
                (currentItem as ISavableObject).Delete();
                this.RefreshData(this.gridControl.PageSize * this.gridControl.PageIndex);
            }
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
            spreadsheet.Workbook = CreateWorkbook();         
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
                    formatProvider.Export(CreateWorkbook(), output);
                }
            }
        }

        protected virtual Workbook CreateWorkbook()
        {
            return new Workbook();
        }
        protected virtual void RefreshData(int skip)
        {

        }
       
    }
}
