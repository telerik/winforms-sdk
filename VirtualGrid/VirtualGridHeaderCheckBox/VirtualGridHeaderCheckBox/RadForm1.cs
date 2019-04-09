using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace VirtualGridHeaderCheckBox
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        private string[] columns;
        private string[] fields;

        public RadForm1()
        {
            InitializeComponent();
        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nwindDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.nwindDataSet.Products);
            this.columns = new string[] { "Product Name", "Units in stock", "Units on order", "Discontinued" };
            this.fields = new string[] { "ProductName", "UnitsInStock", "UnitsOnOrder", "Discontinued" };

            this.radVirtualGrid1.ColumnCount = this.columns.Length;
            this.radVirtualGrid1.RowCount = this.nwindDataSet.Products.Rows.Count;

            this.radVirtualGrid1.TableElement.ColumnWidth = 150;
            this.radVirtualGrid1.TableElement.SetColumnWidth(0, 500);

            this.radVirtualGrid1.CreateCellElement += radVirtualGrid1_CreateCellElement;
            this.radVirtualGrid1.CellValueNeeded += radVirtualGrid1_CellValueNeeded;
            this.radVirtualGrid1.CellValuePushed += radVirtualGrid1_CellValuePushed;
            this.radVirtualGrid1.CellFormatting += radVirtualGrid1_CellFormatting;
            this.radVirtualGrid1.EditorRequired += radVirtualGrid1_EditorRequired;

            this.radVirtualGrid1.MasterViewInfo.RegisterCustomColumn(3);
        }

        private void radVirtualGrid1_EditorRequired(object sender, VirtualGridEditorRequiredEventArgs e)
        {
            string columnName = this.columns[e.ColumnIndex];

            switch (columnName)
            {
                case "ProductName":
                    e.Editor = new VirtualGridTextBoxEditor();
                    break;
                case "UnitsInStock":
                case "UnitsOnOrder":
                    e.Editor = new VirtualGridSpinEditor();
                    break;
                case "Discontinued":
                    e.Cancel = true;
                    break;
            }
        }

        private void radVirtualGrid1_CellFormatting(object sender, VirtualGridCellElementEventArgs e)
        {
            if (e.CellElement.RowIndex < 0 || e.CellElement.ColumnIndex < 0)
            {
                return;
            }

            string columnName = this.fields[e.CellElement.ColumnIndex];

            switch (columnName)
            {
                case "ProductName":
                    e.CellElement.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
                    break;
                case "UnitsInStock":
                case "UnitsOnOrder":
                    e.CellElement.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
                    break;
            }
        }

        private void radVirtualGrid1_CellValueNeeded(object sender, VirtualGridCellValueNeededEventArgs e)
        {
            if (e.ColumnIndex < 0)
            {
                return;
            }

            if (e.RowIndex == RadVirtualGrid.HeaderRowIndex)
            {
                e.Value = this.columns[e.ColumnIndex];
            }

            if (e.RowIndex < 0)
            {
                return;
            }

            e.FieldName = this.fields[e.ColumnIndex];
            e.Value = this.nwindDataSet.Products.Rows[e.RowIndex][e.FieldName];

            e.FieldName = this.fields[e.ColumnIndex];
            e.Value = this.nwindDataSet.Products.Rows[e.RowIndex][e.FieldName];
        }

        private void radVirtualGrid1_CellValuePushed(object sender, VirtualGridCellValuePushedEventArgs e)
        {
            try
            {
                this.nwindDataSet.Products.Rows[e.RowIndex][this.fields[e.ColumnIndex]] = e.Value;
            }
            catch (Exception)
            {
                //Indicate error 
            }
        }

        private void radVirtualGrid1_CreateCellElement(object sender, VirtualGridCreateCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (e.RowIndex >= 0)
                {
                    e.CellElement = new MyVirtualGridCheckBoxCellElement();
                }
            }

            if (e.RowIndex == -1)
            {
                if (e.ColumnIndex == 3)
                {
                    e.CellElement = new CustomVirtualGridHeaderCellElement();
                }
            }
        }

        public class MyVirtualGridCheckBoxCellElement : VirtualGridCellElement
        {
            private RadCheckBoxElement checkBox;

            protected override void CreateChildElements()
            {
                base.CreateChildElements();

                this.checkBox = new RadCheckBoxElement();
                this.Children.Add(this.checkBox);
            }

            protected override void UpdateInfo(VirtualGridCellValueNeededEventArgs args)
            {
                base.UpdateInfo(args);

                if (args.Value is bool)
                {
                    this.checkBox.Checked = (bool)args.Value;
                }

                this.Text = String.Empty;
            }

            public override bool IsCompatible(int data, object context)
            {
                VirtualGridRowElement rowElement = context as VirtualGridRowElement;

                return data == 3 && rowElement.RowIndex >= 0;
            }

            public override void Attach(int data, object context)
            {
                base.Attach(data, context);

                this.checkBox.ToggleStateChanged += checkBox_ToggleStateChanged;
            }

            public override void Detach()
            {
                this.checkBox.ToggleStateChanged -= checkBox_ToggleStateChanged;

                base.Detach();
            }

            protected override Type ThemeEffectiveType
            {
                get
                {
                    return typeof(VirtualGridCellElement);
                }
            }

            private void checkBox_ToggleStateChanged(object sender, StateChangedEventArgs args)
            {
                this.TableElement.GridElement.SetCellValue(this.checkBox.Checked, this.RowIndex, this.ColumnIndex, this.ViewInfo);
                this.TableElement.SynchronizeRow(-1, true);
            }

            protected override SizeF ArrangeOverride(SizeF finalSize)
            {
                SizeF size = base.ArrangeOverride(finalSize);

                this.checkBox.Arrange(new RectangleF((finalSize.Width - this.checkBox.DesiredSize.Width) / 2f, (finalSize.Height - this.checkBox.DesiredSize.Height) / 2f, this.checkBox.DesiredSize.Width, this.checkBox.DesiredSize.Height));

                return size;
            }
        }
        
        public class CustomVirtualGridHeaderCellElement : VirtualGridHeaderCellElement
        {
            RadCheckBoxElement headerCheckBox = new RadCheckBoxElement();

            protected override Type ThemeEffectiveType
            {
                get
                {
                    return typeof(VirtualGridHeaderCellElement);
                }
            }

            public override bool IsCompatible(int data, object context)
            {
                return data == 3;
            }

            protected override void CreateChildElements()
            {
                base.CreateChildElements();
                this.Children.Add(headerCheckBox);
                this.headerCheckBox.ToggleStateChanged += headerCheckBox_ToggleStateChanged;
            }

            public override void Synchronize()
            {
                base.Synchronize();
                this.headerCheckBox.ToggleStateChanged -= headerCheckBox_ToggleStateChanged;
                headerCheckBox.IsChecked = GetCheckState(this.ColumnIndex);
                this.headerCheckBox.ToggleStateChanged += headerCheckBox_ToggleStateChanged;
            }

            private bool GetCheckState(int columnIndex)
            {
                bool isChecked = true;
                for (int i = 0; i < this.TableElement.RowCount; i++)
                {
                    isChecked &= (bool)((CustomRadVirtualGridElement)this.TableElement.GridElement).GetCellValue(this.headerCheckBox.Checked, i, this.ColumnIndex, this.ViewInfo);
                    if (isChecked == false)
                    {
                        break;
                    }
                }
                return isChecked;
            }

            private void headerCheckBox_ToggleStateChanged(object sender, StateChangedEventArgs args)
            {
                for (int i = 0; i < this.TableElement.RowCount; i++)
                {
                    this.TableElement.GridElement.SetCellValue(this.headerCheckBox.Checked, i, this.ColumnIndex, this.ViewInfo);
                }
                this.TableElement.SynchronizeRows();
            }
        }

        public class CustomVirtualGrid : RadVirtualGrid
        {
            public override string ThemeClassName
            {
                get
                {
                    return typeof(RadVirtualGrid).FullName;
                }
            }

            protected override RadVirtualGridElement CreateElement()
            {
                return new CustomRadVirtualGridElement();
            }
        }

        public class CustomRadVirtualGridElement : RadVirtualGridElement
        {
            public object GetCellValue(object value, int rowIndex, int columnIndex, VirtualGridViewInfo viewInfo)
            {
                VirtualGridCellValueNeededEventArgs args = new VirtualGridCellValueNeededEventArgs(rowIndex, columnIndex, viewInfo);
                this.OnCellValueNeeded(args);
                return args.Value;
            }
        }
    }
}