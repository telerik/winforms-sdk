using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;

namespace VirtualRadGridViewSortingFiltering.Core
{
    public class VirtualRadGridView : RadGridView
    {
        private RadWaitingBar loadingOverlay;

        public ItemSource ItemsSource
        {
            get { return (this.GridViewElement as VirtualRadGridViewElement).ItemsSource; }
        }

        public object VirtualDataSource
        {
            get { return this.ItemsSource.DataSource; }
            set
            {
                this.FilterDescriptors.Clear();
                this.SortDescriptors.Clear();
                this.GroupDescriptors.Clear();
                this.ItemsSource.DataSource = value;
                this.Initialize();
            }
        }

        public bool ShowLoadingOverlay { get; set; }

        public bool AutomaticallyRetreiveCellValues { get; set; }

        public bool AutomaticallyPushCellValues { get; set; }

        public RadWaitingBar LoadingOverlay
        {
            get { return this.loadingOverlay; }
        }

        public VirtualRadGridView()
            : base()
        {
            this.EnablePaging = true;
            this.EnableSorting = true;
            this.EnableFiltering = true;
            this.EnableGrouping = true;
            this.VirtualMode = true;
            this.AutomaticallyPushCellValues = true;
            this.AutomaticallyRetreiveCellValues = true;
            this.MasterTemplate.PagingBeforeGrouping = true;
            this.ShowLoadingOverlay = true;

            this.loadingOverlay = this.CreateLoadingOverlay();
            this.loadingOverlay.Parent = this;
            this.loadingOverlay.Dock = DockStyle.None;
            this.loadingOverlay.WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.Dash;
            this.loadingOverlay.Visible = false;
        }

        protected virtual RadWaitingBar CreateLoadingOverlay()
        {
            return new RadWaitingBar();
        }

        protected override void OnBindingContextChanged(EventArgs e)
        {
            base.OnBindingContextChanged(e);
            this.Initialize();
        }

        protected virtual void Initialize()
        {
            if (this.BindingContext == null)
            {
                return;
            }

            if (this.RowCount == this.ItemsSource.Count && this.ColumnCount == this.ItemsSource.BoundProperties.Count)
            {
                return;
            }

            this.InitializeRowsAndColumns();
        }

        protected virtual void InitializeRowsAndColumns()
        {
            if (!this.IsLoaded || this.VirtualDataSource == null)
            {
                return;
            }

            this.BeginUpdate();
            this.InitializeColumns();
            this.InitializeRows();
            this.EndUpdate();
        }

        protected virtual void InitializeColumns()
        {
            if (this.ColumnCount != this.ItemsSource.BoundProperties.Count)
            {
                this.ColumnCount = this.ItemsSource.BoundProperties.Count;
                for (int i = 0; i < this.Columns.Count; i++)
                {
                    PropertyDescriptor prop = this.ItemsSource.BoundProperties[i];
                    GridViewDataColumn newColumn = GridViewHelper.AutoGenerateGridColumn(prop.PropertyType, null);
                    newColumn.HeaderText = prop.DisplayName;
                    newColumn.Name = prop.Name;

                    this.Columns.RemoveAt(i);
                    this.Columns.Insert(i, newColumn);
                }
            }
        }

        protected virtual void InitializeRows()
        {
            if (this.RowCount != this.ItemsSource.Count)
            {
                this.RowCount = this.ItemsSource.Count;
            }
        }

        protected override void WireEvents()
        {
            base.WireEvents();

            this.SortChanged += VirtualRadGridView_SortChanged;
            this.FilterChanged += VirtualRadGridView_FilterChanged;
            this.CellEndEdit += VirtualRadGridView_CellEndEdit;
            this.ItemsSource.OperationCompleted += ItemsSource_OperationCompleted;
            this.ItemsSource.OperationStarted += ItemsSource_OperationStarted;
        }

        protected override void UnWireEvents()
        {
            base.UnWireEvents();

            this.SortChanged -= VirtualRadGridView_SortChanged;
            this.FilterChanged -= VirtualRadGridView_FilterChanged;
            this.CellEndEdit -= VirtualRadGridView_CellEndEdit;
            this.ItemsSource.OperationCompleted -= ItemsSource_OperationCompleted;
            this.ItemsSource.OperationStarted -= ItemsSource_OperationStarted;
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            if (disposing)
            {
                this.ItemsSource.Dispose();
            }
        }

        protected override RadGridViewElement CreateGridViewElement()
        {
            return new VirtualRadGridViewElement();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.loadingOverlay.Visible)
            {
                this.PositionLoadingOverlay();
            }
        }

        protected virtual void PositionLoadingOverlay()
        {
            int x = (this.Width / 2) - (this.loadingOverlay.Width / 2);
            int y = (this.Height / 2) - (this.loadingOverlay.Height / 2);
            this.loadingOverlay.Location = new System.Drawing.Point(x, y);
        }

        protected virtual void StartWaiting()
        {
            if (!this.ShowLoadingOverlay)
            {
                return;
            }

            this.PositionLoadingOverlay();

            this.loadingOverlay.Visible = true;
            this.loadingOverlay.StartWaiting();
        }

        protected virtual void StopWaiting()
        {
            this.loadingOverlay.StopWaiting();
            this.loadingOverlay.Visible = false;
        }

        void ItemsSource_OperationStarted(object sender, ItemSourceOperationEventArgs e)
        {
            this.StartWaiting();
        }

        void ItemsSource_OperationCompleted(object sender, ItemSourceOperationCompletedEventArgs e)
        {
            if (e.Canceled)
            {
                this.StopWaiting();
                return;
            }

            if ((e.OperationType & ItemSourceOperation.Filtering) == ItemSourceOperation.Filtering)
            {
                this.InitializeRowsAndColumns();
            }

            if ((e.OperationType & ItemSourceOperation.Sorting) == ItemSourceOperation.Sorting)
            {
                this.MasterTemplate.DataView.Refresh();
            }

            this.StopWaiting();
        }

        void VirtualRadGridView_FilterChanged(object sender, GridViewCollectionChangedEventArgs e)
        {
            if (!this.IsInEditMode)
            {
                this.PerformFilter();
            }
        }

        void VirtualRadGridView_CellEndEdit(object sender, GridViewCellEventArgs e)
        {
            if (e.Row is GridViewFilteringRowInfo)
            {
                this.PerformFilter();
            }
        }

        void VirtualRadGridView_SortChanged(object sender, GridViewCollectionChangedEventArgs e)
        {
            this.PerformSort();
        }

        protected virtual void PerformFilter(bool force = false)
        {
            this.ItemsSource.PerformOperation(ItemSourceOperation.Filtering, this.FilterDescriptors, force);
        }

        protected virtual void PerformSort(bool force = false)
        {
            this.ItemsSource.PerformOperation(ItemSourceOperation.Sorting, this.SortDescriptors, force);
        }

        protected override void OnCellValueNeeded(object sender, GridViewCellValueEventArgs e)
        {
            if (!this.AutomaticallyRetreiveCellValues)
            {
                base.OnCellValueNeeded(sender, e);
                return;
            }

            GridViewCellValueEventArgsEx args = new GridViewCellValueEventArgsEx(e, e.ColumnIndex, e.RowIndex);
            if (this.GroupDescriptors.Count == 0)
            {
                int rowIndex = this.GetRowIndexByPage(e.RowIndex);
                args.Value = this.ItemsSource.GetValue(this.ItemsSource[rowIndex], e.ColumnIndex);
            }
            else
            {
                args.Value = this.ItemsSource.GetValue(args.RowInfo.DataBoundItem, e.ColumnIndex);
            }

            base.OnCellValueNeeded(sender, args);
            e.Value = args.Value;
        }

        protected override void OnCellValuePushed(object sender, GridViewCellValueEventArgs e)
        {
            if (!this.AutomaticallyPushCellValues)
            {
                base.OnCellValuePushed(sender, e);
                return;
            }

            GridViewCellValueEventArgsEx args = new GridViewCellValueEventArgsEx(e, e.ColumnIndex, e.RowIndex);
            if (this.GroupDescriptors.Count == 0)
            {
                int rowIndex = this.GetRowIndexByPage(e.RowIndex);
                this.ItemsSource.SetValue(this.ItemsSource[rowIndex], e.ColumnIndex, e.Value);
            }
            else
            {
                this.ItemsSource.SetValue(args.RowInfo.DataBoundItem, e.ColumnIndex, e.Value);
            }

            base.OnCellValuePushed(sender, args);
        }

        public virtual int GetRowIndexByPage(int rowIndex)
        {
            int newRowIndex = rowIndex;
            if (this.MasterTemplate.PageIndex >= 1)
            {
                newRowIndex = newRowIndex + (this.MasterTemplate.PageSize * this.MasterTemplate.PageIndex);
            }

            return newRowIndex;
        }
    }
}
