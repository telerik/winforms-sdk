using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using Telerik.Data.Expressions;
using Telerik.WinControls.Data;
using System.Linq;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using Telerik.WinControls.UI;
using Telerik.Collections.Generic;

namespace VirtualRadGridViewSortingFiltering.Core
{
    [Flags]
    public enum ItemSourceOperation
    {
        None = 0,
        Filtering = 1,
        Sorting = Filtering << 1
    }

    public class ItemSourceOperationEventArgs : EventArgs
    {
        public ItemSourceOperation OperationType { get; private set; }

        public ItemSourceOperationEventArgs(ItemSourceOperation operation)
        {
            this.OperationType = operation;
        }
    }

    public class ItemSourceOperationCompletedEventArgs : ItemSourceOperationEventArgs
    {
        public bool Canceled { get; private set; }

        public ItemSourceOperationCompletedEventArgs(ItemSourceOperation operation, bool canceled)
            : base(operation)
        {
            this.Canceled = canceled;
        }
    }

    public class OperationParameters
    {
        public ItemSourceOperation Operation { get; private set; }
        public IList Descriptors { get; private set; }

        public OperationParameters(ItemSourceOperation operation, IList descriptors)
        {
            this.Operation = operation;
            this.Descriptors = descriptors;
        }
    }

    public class ItemSource : IDisposable
    {
        private IList dataSource;
        private IList view;
        private PropertyDescriptorCollection boundProperties;
        private ConcurrentQueue<OperationParameters> queuedOperations;
        private BackgroundWorker backgroundWorker;
        private VirtualMasterGridViewTemplate masterTemplate;
        private bool perform;
        private string lastFilterExpression;
        private string lastSortExpression;
    
        public ItemSource(VirtualMasterGridViewTemplate masterTemplate)
        {
            this.backgroundWorker = new BackgroundWorker();
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += BgWorkerDoWork;
            this.backgroundWorker.ProgressChanged += BgWorkerProgressChanged;
            this.backgroundWorker.RunWorkerCompleted += BgWorkerRunWorkerCompleted;

            this.queuedOperations = new ConcurrentQueue<OperationParameters>();
            this.masterTemplate = masterTemplate;
        }

        protected BackgroundWorker BackgroundWorker
        {
            get { return this.backgroundWorker; }
        }

        public bool Perform
        {
            get { return this.perform; }
        }

        public ItemSourceOperation CurrentOperation { get; private set; }

        public object DataSource
        {
            get
            {
                return this.dataSource;
            }
            set
            {
                if (value == null)
                {
                    this.dataSource = this.view = null;
                    return;
                }

                IList dsList = ListBindingHelper.GetList(value) as IList;
                if (dsList == null || this.dataSource == dsList)
                {
                    return;
                }

                this.dataSource = this.view = dsList;
                this.boundProperties = null;
            }
        }

        public IList View
        {
            get { return this.view; }
        }

        public object this[int index]
        {
            get { return this.view[index]; }
        }

        public PropertyDescriptorCollection BoundProperties
        {
            get
            {
                if (this.dataSource == null || this.dataSource.Count == 0)
                {
                    return new PropertyDescriptorCollection(null);
                }

                if (boundProperties == null)
                {
                    boundProperties = ListBindingHelper.GetListItemProperties(this.dataSource);
                }

                return boundProperties;
            }
        }

        public int Count
        {
            get
            {
                return this.view.Count;
            }
        }

        public virtual bool SetValue(object entry, int index, object value)
        {
            if (!this.BoundProperties[index].IsReadOnly)
            {
                this.BoundProperties[index].SetValue(entry, value);
                return true;
            }

            return false;
        }

        public virtual bool SetValue(object entry, string member, object value)
        {
            if (!this.BoundProperties[member].IsReadOnly)
            {
                this.BoundProperties[member].SetValue(entry, value);
                return true;
            }

            return false;
        }

        public virtual object GetValue(object entry, int index)
        {
            return this.BoundProperties[index].GetValue(entry);
        }

        public virtual object GetValue(object entry, string member)
        {
            return this.BoundProperties[member].GetValue(entry);
        }

        protected virtual void BgWorkerRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (this.queuedOperations.Count > 0)
            {
                this.perform = true;
                this.backgroundWorker.RunWorkerAsync();
            }

            this.OnOperationCompleted((ItemSourceOperationCompletedEventArgs)e.Result);
        }

        protected virtual void BgWorkerProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.OnOperationStarted(new ItemSourceOperationEventArgs((ItemSourceOperation)e.UserState));
        }

        protected virtual void BgWorkerDoWork(object sender, DoWorkEventArgs e)
        {
            ItemSourceOperation operations = default(ItemSourceOperation);
            while (this.queuedOperations.Count > 0 && this.perform)
            {
                OperationParameters currentParams;
                if (!this.queuedOperations.TryDequeue(out currentParams))
                {
                    System.Threading.Thread.Sleep(100);
                    continue;
                }

                this.backgroundWorker.ReportProgress(0, currentParams.Operation);
                switch (currentParams.Operation)
                {
                    case ItemSourceOperation.Filtering:
                        this.Filter(currentParams.Descriptors as FilterDescriptorCollection);
                        break;
                    case ItemSourceOperation.Sorting:
                        this.Sort(currentParams.Descriptors as SortDescriptorCollection);
                        break;
                    default:
                        break;
                }

                operations |= currentParams.Operation;
            }

            e.Result = new ItemSourceOperationCompletedEventArgs(operations, !this.perform);
        }

        public void PerformOperation(ItemSourceOperation operation, IList descriptors, bool force = false)
        {
            switch (operation)
            {
                case ItemSourceOperation.Filtering:
                    FilterDescriptorCollection filterDescriptors = descriptors as FilterDescriptorCollection;
                    if (this.lastFilterExpression == filterDescriptors.Expression && !force)
                    {
                        return;
                    }

                    this.lastFilterExpression = filterDescriptors.Expression;
                    break;
                case ItemSourceOperation.Sorting:
                    SortDescriptorCollection sortDescriptors = descriptors as SortDescriptorCollection;
                    if (this.lastSortExpression == sortDescriptors.Expression && !force)
                    {
                        return;
                    }

                    this.lastSortExpression = sortDescriptors.Expression;
                    break;
                default:
                    break;
            }

            OperationParameters operationParams = new OperationParameters(operation, descriptors);
            this.queuedOperations.Enqueue(operationParams);
            if (this.backgroundWorker.IsBusy)
            {
                OperationParameters peek;
                bool peeked = this.queuedOperations.TryPeek(out peek);
                if (peeked && peek.Operation == operationParams.Operation && peek != operationParams)
                {
                    OperationParameters dequeued;
                    this.queuedOperations.TryDequeue(out dequeued);
                }
                else if (peeked && peek.Operation != operationParams.Operation)
                {
                    this.perform = false;
                }
            }

            if (!this.backgroundWorker.IsBusy)
            {
                this.perform = true;
                this.backgroundWorker.RunWorkerAsync();
                this.OnOperationStarted(new ItemSourceOperationEventArgs(operationParams.Operation));
            }
        }

        protected virtual void Sort(SortDescriptorCollection descriptors)
        {
            SortDescriptor[] currentDescriptors = descriptors.ToArray();
            if (this.CurrentOperation != ItemSourceOperation.None)
            {
                return;
            }

            if (currentDescriptors.Length == 0)
            {
                this.view = this.dataSource;
                this.Filter(this.masterTemplate.FilterDescriptors);

                return;
            }

            this.CurrentOperation = ItemSourceOperation.Sorting;
            List<object> sortView = this.view as List<object>;

            if (sortView == null)
            {
                sortView = new List<object>(this.view.Count);
                foreach (object item in this.view)
                {
                    sortView.Add(item);
                }
            }

            ParallelQuery<object> query = sortView.AsParallel();
            SortDescriptor firstDescriptor = currentDescriptors.First();
            if (firstDescriptor.Direction == ListSortDirection.Descending)
            {
                query = query.OrderByDescending(x => this.GetValue(x, firstDescriptor.PropertyName));
            }
            else
            {
                query = query.OrderBy(x => this.GetValue(x, firstDescriptor.PropertyName));
            }

            OrderedParallelQuery<object> orderedQuery = query as OrderedParallelQuery<object>;
            for (int i = 1; i < currentDescriptors.Length; i++)
            {
                SortDescriptor currentDescriptor = currentDescriptors[i];
                if (currentDescriptor.Direction == ListSortDirection.Descending)
                {
                    orderedQuery = orderedQuery.ThenByDescending(x => this.GetValue(x, currentDescriptor.PropertyName));
                }
                else
                {
                    orderedQuery = orderedQuery.ThenBy(x => this.GetValue(x, currentDescriptor.PropertyName));
                }
            }

            this.view = orderedQuery.ToList();
            this.CurrentOperation = ItemSourceOperation.None;
        }

        protected virtual void Filter(FilterDescriptorCollection descriptors)
        {
            FilterDescriptor[] currentDescriptors = descriptors.ToArray();
            ExpressionNode node = ExpressionParser.Parse(descriptors.Expression, this.masterTemplate.CaseSensitive);

            if (this.CurrentOperation != ItemSourceOperation.None || node == null || currentDescriptors.Length == 0)
            {
                this.view = this.dataSource;
                this.CurrentOperation = ItemSourceOperation.None;
                return;
            }

            this.CurrentOperation = ItemSourceOperation.Filtering;
            List<object> newView = new List<object>();
            IList filteredView = this.dataSource;

            for (int i = 0; i < filteredView.Count; i++)
            {
                if (!this.perform)
                {
                    this.CurrentOperation = ItemSourceOperation.None;
                    return;
                }

                object entry = filteredView[i];
                ExpressionContext context = new ExpressionContext();

                for (int j = 0; j < currentDescriptors.Length; j++)
                {
                    string member = currentDescriptors[j].PropertyName;
                    if (!context.ContainsKey(member))
                    {
                        context.Add(member, this.GetValue(entry, member));
                    }
                    else
                    {
                        context[member] = this.GetValue(entry, member);
                    }
                }

                object evalResult = node.Eval(null, context);

                if (evalResult is bool && (bool)evalResult)
                {
                    newView.Add(entry);
                }
            }

            this.view = newView;
            this.CurrentOperation = ItemSourceOperation.None;
        }

        public event EventHandler<ItemSourceOperationCompletedEventArgs> OperationCompleted;
        public event EventHandler<ItemSourceOperationEventArgs> OperationStarted;

        protected virtual void OnOperationCompleted(ItemSourceOperationCompletedEventArgs args)
        {
            if (this.OperationCompleted != null)
            {
                this.OperationCompleted(this, args);
            }
        }

        protected virtual void OnOperationStarted(ItemSourceOperationEventArgs args)
        {
            if (this.OperationStarted != null)
            {
                this.OperationStarted(this, args);
            }
        }

        public void Dispose()
        {
            this.backgroundWorker.CancelAsync();
            this.backgroundWorker.DoWork -= BgWorkerDoWork;
            this.backgroundWorker.ProgressChanged -= BgWorkerProgressChanged;
            this.backgroundWorker.RunWorkerCompleted -= BgWorkerRunWorkerCompleted;
            this.backgroundWorker = null;
        }
    }
}
