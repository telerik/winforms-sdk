using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Xml.Serialization;

using GridObjectRelationalCRUD.Models;

namespace GridObjectRelationalCRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.radGridView1.DataSource = DataContext.Artists;
            this.radGridView1.AutoGenerateHierarchy = true;

            this.SetupTemplates();
        }

        private void SetupTemplates()
        {
            this.radGridView1.EnableFiltering = true;
            this.radGridView1.Columns["Id"].IsVisible = false;
            this.radGridView1.Columns["Albums"].IsVisible = false;
            this.radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

            this.radGridView1.Templates[0].AllowAddNewRow = true;
            this.radGridView1.Templates[0].Columns["Id"].IsVisible = false;
            this.radGridView1.Templates[0].Columns["ArtistId"].IsVisible = false;
            this.radGridView1.Templates[0].Columns["Tracks"].IsVisible = false;
            this.radGridView1.Templates[0].AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;

            this.radGridView1.Templates[0].Templates[0].AllowAddNewRow = true;
            this.radGridView1.Templates[0].Templates[0].Columns["Id"].IsVisible = false;
            this.radGridView1.Templates[0].Templates[0].Columns["Size"].IsVisible = false;
            this.radGridView1.Templates[0].Templates[0].AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
        }

        private void radGridView1_CellValueChanged(object sender, GridViewCellEventArgs e)
        {
            if (e.Row is GridViewNewRowInfo || e.Row is GridViewFilteringRowInfo)
            {
                return;
            } 
             
            if (e.Row.HierarchyLevel > 0)
            {
                this.SetBoundValue(e.Row.DataBoundItem, e.Column.FieldName, e.Value);
                e.Row.InvalidateRow();
            }
        }

        private void radGridView1_UserAddingRow(object sender, GridViewRowCancelEventArgs e)
        {
            GridViewRowInfo row = e.Rows[0];
            if (row.HierarchyLevel == 0)
            {
                return;
            }

            GridViewRelation relation = this.radGridView1.Relations.Find(row.ViewTemplate.Parent, row.ViewTemplate);
            GridViewRowInfo parentRow = row.Parent as GridViewRowInfo;
            PropertyDescriptorCollection parentProperties = ListBindingHelper.GetListItemProperties(parentRow.DataBoundItem);
            PropertyDescriptor childDescriptor = parentProperties.Find(relation.ChildColumnNames[0], true);
            if (childDescriptor != null)
            {
                IList children = childDescriptor.GetValue(parentRow.DataBoundItem) as IList;
                if (children != null)
                {
                    object newItem = Activator.CreateInstance(ListBindingHelper.GetListItemType(children));
                    bool success = true;
                    foreach (GridViewColumn column in row.ViewTemplate.Columns)
                    {
                        if (column.IsVisible && !column.ReadOnly && row.Cells[column.FieldName].Value != null && success)
                        {
                            success = success & this.SetBoundValue(newItem, column.FieldName, row.Cells[column.FieldName].Value);
                        } 
                    }

                    if (!success)
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        children.Add(newItem);
                    }
                }
            }
        }

        private void radGridView1_UserAddedRow(object sender, GridViewRowEventArgs e)
        {
            e.Row.ViewTemplate.Refresh();
        }

        private void radGridView1_UserDeletedRow(object sender, GridViewRowEventArgs e)
        {
            GridViewRowInfo[] rows = e.Rows;
            for (int i = 0; i < (int)rows.Length; i++)
            {
                GridViewRowInfo row = rows[i];
                if (row.HierarchyLevel != 0)
                {
                    GridViewRelation relation = this.radGridView1.Relations.Find(row.ViewTemplate.Parent, row.ViewTemplate);
                    GridViewRowInfo parentRow = row.Parent as GridViewRowInfo;
                    PropertyDescriptorCollection parentProperties = ListBindingHelper.GetListItemProperties(parentRow.DataBoundItem);
                    PropertyDescriptor childDescriptor = parentProperties.Find(relation.ChildColumnNames[0], true);
                    if (childDescriptor != null)
                    {
                        IList children = childDescriptor.GetValue(parentRow.DataBoundItem) as IList;
                        if (children != null)
                        {
                            children.Remove(row.DataBoundItem);
                            row.ViewInfo.Refresh();
                            
                            foreach (var childRow in row.ViewInfo.ChildRows)
                            {
                                childRow.InvalidateRow();
                            }
                        }
                    }
                }
            }
        }

        private bool SetBoundValue(object dataBoundItem, string propertyName, object value)
        {
            PropertyDescriptor descriptor = TypeDescriptor.GetProperties(dataBoundItem).Find(propertyName, true);
            if (value != null)
            {
                try
                {
                    Type type = Nullable.GetUnderlyingType(descriptor.PropertyType);
                    if (descriptor.Converter != null && type != null && type.IsGenericType)
                    {
                        value = descriptor.Converter.ConvertFromInvariantString(value.ToString());
                    }
                    descriptor.SetValue(dataBoundItem, value);
                    return true;
                }
                catch
                {
                    RadMessageBox.Show(string.Concat("Invalid property value for ", propertyName), "Error", MessageBoxButtons.OK, RadMessageIcon.Error);
                    return false;
                }
            }
            else
            {
                try
                {
                    descriptor.SetValue(dataBoundItem, value);
                }
                catch
                {
                    descriptor.SetValue(dataBoundItem, DBNull.Value);
                }
            }

            return true;
        }
    }
}
