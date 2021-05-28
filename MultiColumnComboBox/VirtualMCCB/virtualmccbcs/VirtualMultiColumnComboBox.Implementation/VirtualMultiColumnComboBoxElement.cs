using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;
using TrieImplementation;

namespace VirtualMultiColumnComboBox.Implementation
{
    public delegate void InvokeDelegate();
    public delegate void SearchCompletedEventHandler(object sender, SearchCompletedEventArgs e);
    public delegate void SearchStartingEventHandler(object sender, SearchStartingEventArgs e);
    public delegate void EditorControlCellValueNeededEventHandler(object sender, EditorControlCellValueNeededEventArgs e);

    public class VirtualMultiColumnComboBoxElement : RadMultiColumnComboBoxElement
    {
        #region Fields
        private Trie trie;
        private Dictionary<string, List<object>> actualDataSource;
        private object virtualDataSource;
        private CurrencyManager currencyManager;
        private object bindingContext;
        private int updatedVersion;
        private MethodInfo setCurrentStateMethod;
        private bool loadDatasourceAsync;
        private string enqueuedSearchText;
        private SearchType enqueuedSearchType;
        private int startSearchInterval = 100;
        private bool autoShowHidePopup;

        private bool ignoreCase = true;
        private string valueMember = "";
        private string valueObjectPropertyName;
        private bool dataSourceInitialized;
        private SearchType searchType = SearchType.Contains;
        private bool searching;
        private bool dataSourceInitializing;

        private Dictionary<string, PropertyDescriptor> typeProperties;
        #endregion

        #region Properties

        public virtual bool IgnoreCase
        {
            get
            {
                return this.ignoreCase;
            }
            set
            {
                this.ignoreCase = value;
                this.ResetAllVitalFields();
                if (this.virtualDataSource != null)
                {
                    this.InitializeDataSource();
                }
            }
        }

        /// <summary>
        /// Gets or Sets the type of the search. Can be Contains or StartsWith
        /// </summary>
        public SearchType SearchType
        {
            get
            {
                return this.searchType;
            }
            set
            {
                this.searchType = value;
            }
        }

        /// <summary>
        /// Gets or Sets the Virtual Data Source. The Virtual Data Source contains the Data after the filtering operation.
        /// It can also be used to set the Data Source initially
        /// </summary>
        public override object DataSource
        {
            get
            {
                return this.virtualDataSource;
            }
            set
            {
                if (value == null)
                {
                    return;
                }

                if (this.virtualDataSource == value)
                {
                    return;
                }

                this.virtualDataSource = value;
                this.InitializeDataSource();
            }
        }

        /// <summary>
        /// Gets the original data from the DataSource. The Key equals the ValueMember property.
        /// </summary>
        public Dictionary<string, List<object>> ActualDataSource
        {
            get
            {
                return this.actualDataSource;
            }
        }

        /// <summary>
        /// Gets or Sets the ValueMember. It defines what property will be used by the filtering operation.
        /// If null or empty the ToString() method will be used
        /// </summary>
        public override string ValueMember
        {
            get
            {
                return this.valueMember;
            }
            set
            {
                if (value == null)
                {
                    return;
                }

                if (this.valueMember == value)
                {
                    return;
                }

                this.valueMember = value;
                string[] allProperties = value.Split('.');
                this.valueObjectPropertyName = allProperties[allProperties.Length - 1];
                if (this.dataSourceInitialized)
                {
                    this.InitializeDataSourceCore();
                }
            }
        }

        /// <summary>
        /// Gets the value which indicates if the events are suspended
        /// </summary>
        public bool IsSuspended
        {
            get
            {
                return this.updatedVersion > 0;
            }
        }

        /// <summary>
        /// Gets or Sets the value which indicates whether the DataSource will be loaded
        /// in another thread in the background. The <see cref="DataSourceLoaded"/> event is
        /// fired when the DataSource is completely loaded
        /// </summary>
        public bool LoadDataSourceAsync
        {
            get
            {
                return this.loadDatasourceAsync;
            }
            set
            {
                this.loadDatasourceAsync = value;
            }
        }

        /// <summary>
        /// Gets or Sets the value which indicates after how many milliseconds after
        /// a key press a search will be made
        /// </summary>
        public int StartSearchInterval
        {
            get
            {
                return this.startSearchInterval;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The value can not be null");
                }

                this.startSearchInterval = value;
            }
        }

        /// <summary>
        /// Gets or Sets the value which indicates if the GridViewPopup will be automatically
        /// shown/closed during search operations
        /// </summary>
        public bool AutoShowHidePopup
        {
            get
            {
                return this.autoShowHidePopup;
            }
            set
            {
                this.autoShowHidePopup = value;
            }
        }

        /// <summary>
        /// Gets or Sets the text of the MulticolumnComboBox
        /// </summary>
        public override string Text
        {
            get
            {
                return this.textBox.Text;
            }
            set
            {
                this.textBox.Text = value;
                this.SetValue(RadMultiColumnComboBoxElement.TextProperty, value);
            }
        }


        #endregion

        #region Initialization
        /// <summary>
        /// Used to Initialize all important fields and some event handlers
        /// </summary>
        protected override void CreateChildElements()
        {
            base.CreateChildElements();
            this.trie = new Trie(this.ignoreCase);
            this.actualDataSource = new Dictionary<string, List<object>>(StringComparer.OrdinalIgnoreCase);//todo case insensitive
            this.typeProperties = new Dictionary<string, PropertyDescriptor>();
            this.DropDownHeight = 250;
        }

        #region MethodsWhichShouldNotCallBase
        protected override void CheckForCompleteMatchAndUpdateText() { }

        public override void ProcessReturnKey(KeyEventArgs e) { }

        protected override void ProcessPopupTabKey(KeyEventArgs e) { }
        #endregion
        /// <summary>
        /// Initializes the Virtual Data Source.
        /// </summary>

        private void InitializeDataSource()
        {
            this.dataSourceInitializing = true;
            //Reinitialize all important fields if the Data Source has already been initialized.
            if (this.dataSourceInitialized)
            {
                this.ResetAllVitalFields();
            }

            //starts a new thread to load  the datasource if specified.
            if (this.LoadDataSourceAsync)
            {
                Thread loadDataSourceThread = new Thread(() => this.InitializeDataSourceCore());
                loadDataSourceThread.IsBackground = true;
                loadDataSourceThread.Start();
            }
            else
            {
                this.InitializeDataSourceCore();
            }
        }

        protected virtual void InitializeDataSourceCore()
        {
            //Add a data binding in order to use the data with a CurrencyManager later
            List<object> tempDataSource = new List<object>();
            this.EditorControl.BindingContext = this.EditorControl.BindingContext ?? new BindingContext();

            INotifyCollectionChanged collectionChangedObject = this.virtualDataSource as INotifyCollectionChanged;
            if (collectionChangedObject != null)
	        {
                collectionChangedObject.CollectionChanged += CollectionChangedObject_CollectionChanged;
	        }

            //Iterate all items in the Data Source with the currency manager and set up the Trie.
            //Will use the ToString method of the object if no ValueMember is supplied

            this.currencyManager = (CurrencyManager)this.EditorControl.BindingContext[this.virtualDataSource];
            if (this.currencyManager.List.Count == 0)
            {
                return;
            }

            this.bindingContext = this.EditorControl.BindingContext[this.virtualDataSource, this.valueMember];
            int position = 0;
            this.currencyManager.Position = position;
            if (!string.IsNullOrEmpty(this.valueMember))
            {
                while (position < currencyManager.Count - 1)
                {
                    if (this.EditorControl == null)
                    {
                        return;
                    }

                    object current = this.currencyManager.List[position++];
                    string key = this.GetProperty(this.valueMember, current) + "";
                    object obj = current;
                    AddItemToDataSource(key, obj);
                    tempDataSource.Add(current);
                }
            }
            else
            {
                foreach (object item in currencyManager.List)
                {
                    string key = item.ToString();
                    this.AddItemToDataSource(key, item);
                    tempDataSource.Add(item);
                }
            }

            //Get the properties of the current object in order to build the columns of the grid
            if (this.EditorControl.InvokeRequired)
            {
                this.EditorControl.Invoke(new InvokeDelegate(() =>
                {
                    AddDataSource(tempDataSource);
                    this.EditorControl.RowCount = tempDataSource.Count;
                }));
            }
            else
            {
                AddDataSource(tempDataSource);
                this.EditorControl.RowCount = tempDataSource.Count;
            }
        }

        private Dictionary<string, PropertyInfo> cache = new Dictionary<string, PropertyInfo>();
        private object GetProperty(string property, object obj)
        {
            string[] splittedProps = property.Split('.');
            object currentObj = obj;

            for (int i = 0; i < splittedProps.Length; i++)
			{
			    Type objType = currentObj.GetType();
                string key = objType.FullName + ";" + splittedProps[i];
                if (!cache.ContainsKey(key))
                {
                    cache[key] = objType.GetProperty(splittedProps[i]);
                }

                PropertyInfo prop = cache[key];
                if (prop == null)
                {
                    return null;
                }

                currentObj = prop.GetValue(currentObj, null);
			}

            return currentObj;
        }
  
        private void AddDataSource(List<object> tempDataSource)
        {
            this.CacheProperties();
            this.GenerateGridColumns();

            //replace the original data source with a List<object> which will enable us to easily modify it.
            //Also mark the data source as completely initialized
            this.virtualDataSource = tempDataSource;
            this.dataSourceInitialized = true;
            this.dataSourceInitializing = false;
            this.OnDataSourceLoaded();
        }
  
        /// <summary>
        /// Adds an item to the <see cref="ActualDataSource"/> and the <see cref="Trie"/>.
        /// </summary>
        /// <param name="key">The search key</param>
        /// <param name="obj">The actual object</param>
        private void AddItemToDataSource(string key, object obj)
        {
            this.trie.Insert(key);
            this.AddItemToAccessItems(key, obj);
        }

        private void RemoveitemFromDataSource(string key, object obj)
        {
            this.trie.RemovedWords.Add(key);
            if (this.ActualDataSource.ContainsKey(key))
            {
                foreach (object item in this.actualDataSource[key].ToArray())
                {
                    if (item.Equals(obj))
                    {
                        this.actualDataSource[key].Remove(item);
                    }
                }
            }
        }

        /// <summary>
        /// Fired when the colllection changes, in case it is an <see cref="INotifyCollectionChanged"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CollectionChangedObject_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (object item in e.NewItems)
                {
                    this.currencyManager.Position = this.currencyManager.List.Count - 1;

                    PropertyManager propManager = (PropertyManager)this.bindingContext;
                    string key = propManager.Current.ToString();
                    object obj = currencyManager.Current;
                    this.AddItemToDataSource(key, obj);
                }
            }
            else if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                foreach (object item in e.NewItems)
                {
                    CurrencyManager manager = (CurrencyManager)this.BindingContext[e.NewItems];
                    PropertyManager propManager = (PropertyManager)this.BindingContext[e.NewItems, this.ValueMember];
                    string key = propManager.Current.ToString();
                    object obj = manager.Current;
                    this.RemoveitemFromDataSource(key, obj);
                    manager.Position++;
                }
            }
        }
  
        /// <summary>
        /// Saves the properties for later use
        /// </summary>
        private void CacheProperties()
        {
            PropertyDescriptorCollection properties = this.currencyManager.GetItemProperties();
            foreach (PropertyDescriptor descriptor in properties)
            {
                this.typeProperties[descriptor.Name] = descriptor;
            }
        }
  
        /// <summary>
        /// Generates the Columns of the grid in case <see cref="AutoGenerateColumns"/> is set to true
        /// </summary>
        private void GenerateGridColumns()
        {
            //Get the properties of the current object in order to build the columns of the grid
            if (this.EditorControl.AutoGenerateColumns)
            {
                foreach (PropertyDescriptor prop in typeProperties.Values)
                {
                    //if the property has its Browsable attribute set to false, no column will be generated
                    if (prop.IsBrowsable)
	                {
                        GridViewDataColumn column = this.ParseColumnFromProperty(prop);
                        if (!this.EditorControl.Columns.Contains(column.Name))
                        {
                            this.EditorControl.Columns.Add(column);
                        }
	                }
                }
            }
        }

        /// <summary>
        /// Gets the appropriate column from a property's type
        /// </summary>
        /// <param name="prop">The property used for parsing</param>
        /// <returns></returns>
        private GridViewDataColumn ParseColumnFromProperty(PropertyDescriptor prop)
        {
            if (prop.PropertyType == typeof(Int32))
            {
                return new GridViewDecimalColumn(prop.Name, prop.Name);
            }
            else if (prop.PropertyType == typeof(bool))
            {
                return new GridViewCheckBoxColumn(prop.Name, prop.Name);
            }
            else if (prop.PropertyType == typeof(Color))
            {
                return new GridViewColorColumn(prop.Name, prop.Name);
            }
            else if (prop.PropertyType == typeof(IEnumerable) 
                || prop.PropertyType == typeof(ICollection) || prop.PropertyType == typeof(IList))
            {
                return new GridViewComboBoxColumn(prop.Name, prop.Name);
            }
            else if (prop.PropertyType == typeof(DateTime))
            {
                return new GridViewDateTimeColumn(prop.Name, prop.Name);
            }
            else if (prop.PropertyType == typeof(Image))
            {
                return new GridViewImageColumn(prop.Name, prop.Name);
            }
            else
            {
                return new GridViewTextBoxColumn(prop.Name, prop.Name);
            }
        }
  
        /// <summary>
        /// Resets the important fields and data structures since it is better to reset
        /// them instead of clearing them. Also clears the columns of the grid
        /// </summary>
        private void ResetAllVitalFields()
        {
            this.trie = new Trie(this.ignoreCase);
            this.actualDataSource = new Dictionary<string, List<object>>();
            this.EditorControl.Columns.Clear();
        }

        /// <summary>
        /// Adds and object to the AllDataSource which enables us to easily access items by ValueMember
        /// with Constant time
        /// </summary>
        /// <param name="key">The ValueMember</param>
        /// <param name="value">The object from the datasource</param>
        private void AddItemToAccessItems(string key, object value)
        {
            if (!this.actualDataSource.ContainsKey(key))
            {
                this.actualDataSource[key] = new List<object>();
            }

            this.actualDataSource[key].Add(value);
        }

        /// <summary>
        /// Wires all events which can be wired at this point and enables virtual mode of the grid
        /// </summary>
        protected override void WireEvents()
        {
 	        base.WireEvents();
            this.EditorControl.VirtualMode = true;
            this.EditorControl.CellValueNeeded += GridCellValueNeeded;
        }

        /// <summary>
        /// Processes a keyup event in the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void ProcessTextKeyUp(object sender, KeyEventArgs e)
        {
            if (char.IsLetterOrDigit((char)e.KeyCode) ||
                e.KeyCode == Keys.Space ||
                e.KeyCode == Keys.Enter ||
                e.KeyCode == Keys.Back ||
                e.KeyCode == Keys.Delete)
            {
                if (!this.dataSourceInitializing)
                {
                    this.SetCurrentState(PopupEditorState.Filtering);
                    this.PerformSearchCore(this.Text, TrieImplementation.SearchType.Contains);
                }
            }

            this.ShowHidePopup(e);
        }

        /// <summary>
        /// Shows or hides the popup based on certain conditions
        /// </summary>
        /// <param name="e"></param>
        protected virtual void ShowHidePopup(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back && string.IsNullOrEmpty(this.Text) && this.IsDroppedDown && this.AutoShowHidePopup)
            {
                this.ClosePopup();
            }
            else if ((e.KeyCode != Keys.Back || e.KeyCode != Keys.Delete || !char.IsLetterOrDigit((char)e.KeyCode)) && !this.IsDropDownShown && this.AutoShowHidePopup)
            {
                this.ShowPopup();
            }
        }

        /// <summary>
        /// Sets the grids current <see cref="PopupEditorState"/>. We are using <see cref="System.Reflection"/>
        /// since the method is private.
        /// </summary>
        /// <param name="state"></param>
        protected virtual void SetCurrentState(PopupEditorState state)
        {
            if (this.setCurrentStateMethod == null)
            {
                this.setCurrentStateMethod = this.GetType().BaseType.GetMethod("SetCurrentState", BindingFlags.NonPublic | BindingFlags.Instance);
            }

            this.setCurrentStateMethod.Invoke(this, new object[] { state });
        }

        /// <summary>
        /// Unwires all events for safer disposal
        /// </summary>
        protected override void UnwireEvents()
        {
            base.UnwireEvents();
            this.EditorControl.CellValueNeeded -= GridCellValueNeeded;
        }
        #endregion

        #region Implementation
        /// <summary>
        /// The exposed method which can be used to perform a search operation
        /// </summary>
        /// <param name="text">The text to search</param>
        public void PerformSearch(string text)
        {
            this.PerformSearch(text, TrieImplementation.SearchType.Contains);
        }

        public void PerformSearch(string text, SearchType searchType)
        {
            this.PerformSearchCore(text, SearchType);
        }

        /// <summary>
        /// If too many search operations are requested in short period of time,
        /// the last is enqueued and when the previous search operation finishes,
        /// the enqueued one will be executed.
        /// </summary>
        private void PerformNewSearchFromQueue()
        {
            string newSearchText = this.enqueuedSearchText;
            TrieImplementation.SearchType newSearchType = this.enqueuedSearchType;
            this.enqueuedSearchText = null;
            this.PerformSearchCore(newSearchText, newSearchType);
        }

        /// <summary>
        /// The core method which performs the search operation
        /// </summary>
        /// <param name="text">The text to search</param>
        protected virtual void PerformSearchCore(string text, SearchType searchType)
        {
            if (!this.OnSearchStarting(text))
            {
                return;
            }

            if (!this.searching)
            {
                Thread searchThread = this.CreateSearchThread(searchType, text);
                searchThread.IsBackground = true;
                searchThread.Start();
            }
            else
            {
                this.enqueuedSearchType = searchType;
                this.enqueuedSearchText = text;
            }
            
        }
  
        /// <summary>
        /// Creates a <see cref="Thread"/> to perform search operations
        /// </summary>
        /// <param name="searchType">The <see cref="SearchType"/></param>
        /// <param name="text">The text to search</param>
        /// <returns></returns>
        private Thread CreateSearchThread(SearchType searchType, string text)
        {
            Thread searchThread = new Thread(() =>
            {
                if (this.searching)
                {
                    this.enqueuedSearchType = searchType;
                    this.enqueuedSearchText = text;
                    return;
                }

                Thread.Sleep(this.startSearchInterval);
                if (this.enqueuedSearchText != null)
                {
                    this.PerformNewSearchFromQueue();
                    return;
                }

                this.searching = true;
                ICollection<string> results = this.trie.Search(this.Text, searchType);

                if (!(this.virtualDataSource is List<object>))
                {
                    this.virtualDataSource = new List<object>();
                }

                List<object> dataSource = this.virtualDataSource as List<object>;
                dataSource.Clear();
                foreach (string result in results)
                {
                    if (this.actualDataSource.ContainsKey(result))
                    {
                        foreach (object item in this.actualDataSource[result])
                        {
                            dataSource.Add(item);
                        }
                    }
                }

                searching = false;
                this.EditorControl.Invoke(new InvokeDelegate(() =>
                {
                    if (this.EditorControl.RowCount != results.Count)
                    {
                        this.EditorControl.RowCount = results.Count;
                    }

                    this.SetCurrentState(PopupEditorState.Ready);
                    this.OnSearchCompleted(text, results);
                }));
            });
             
            return searchThread;
        }

        /// <summary>
        /// This event controls the displayed values using VirtualMode - http://www.telerik.com/help/winforms/gridview-virtual-mode.html
        /// </summary>
        private void GridCellValueNeeded(object sender, GridViewCellValueEventArgs e)
        {
            this.OnCellValueNeeded(e);
        }

        /// <summary>
        /// Suspends all events from firing
        /// </summary>
        public override void BeginUpdate()
        {
            base.BeginUpdate();
            this.updatedVersion++;
        }

        /// <summary>
        /// Resumes events from firing
        /// </summary>
        public override void EndUpdate()
        {
            base.EndUpdate();
            this.updatedVersion--;
            if (this.updatedVersion < 0)
            {
                this.updatedVersion = 0;
            }
        }

        #endregion

        #region Ctors
        /// <summary>
        /// Initializes the VirtualMultiColumnComboBoxElement
        /// </summary>
        /// <param name="ignoreCase">Defines if the performed search operations will be case sensitive</param>
        
        public VirtualMultiColumnComboBoxElement()
            : base()
        {
            this.EditorControl.LoadElementTree();
        }

        /// <summary>
        /// Needed for proper theming
        /// </summary>
        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(RadMultiColumnComboBoxElement);
            }
        }

        #endregion

        #region Events
        /// <summary>
        /// Fired when the Search method is done searching
        /// </summary>
        public event SearchCompletedEventHandler SearchCompleted;
        protected virtual void OnSearchCompleted(string text, IEnumerable<string> results)
        {
            if (this.enqueuedSearchText != null)
            {
                this.PerformNewSearchFromQueue();
            }

            if (this.SearchCompleted != null && !this.IsSuspended)
            {
                this.SearchCompleted(this, new SearchCompletedEventArgs(text, results));
            }
        }

        /// <summary>
        /// Fires before the searching has begun. Cancelable.
        /// </summary>
        public event SearchStartingEventHandler SearchStarting;
        protected virtual bool OnSearchStarting(string text)
        {
            SearchStartingEventArgs e = new SearchStartingEventArgs(text);
            if (this.SearchStarting != null && !this.IsSuspended)
            {
                this.SearchStarting(this, e);
            }

            return !e.Cancel;
        }

        
        /// <summary>
        /// Fired when value for a cell is needed. Also provides the datasource.
        /// </summary>
        public event EditorControlCellValueNeededEventHandler EditorControlCellValueNeeded;
        protected virtual void OnCellValueNeeded(GridViewCellValueEventArgs e)
        {
            if (this.IsSuspended)
            {
                return;
            }

            EditorControlCellValueNeededEventArgs args = new EditorControlCellValueNeededEventArgs
                (e.ColumnIndex, e.RowIndex, (List<object>)this.virtualDataSource);

            if (args.RowIndex < args.VirtualDataSource.Count && args.RowIndex != -1)
            {
                object currentObject = args.VirtualDataSource[args.RowIndex];
                string columnName = this.EditorControl.Columns[e.ColumnIndex].Name;
                if (this.typeProperties.ContainsKey(columnName))
                {
                    args.Value = this.typeProperties[columnName].GetValue(currentObject);
                }
            }

            if (this.EditorControlCellValueNeeded != null && args.VirtualDataSource.Count >= 0 && args.RowIndex != -1 &&
                args.VirtualDataSource.Count > args.RowIndex)
            {
                this.EditorControlCellValueNeeded(this, args);
            }

            e.Value = args.Value;
        }

        /// <summary>
        /// Fired when the DataSource is completely loaded
        /// </summary>
        public event EventHandler DataSourceLoaded;
        protected virtual void OnDataSourceLoaded()
        {
            if (this.DataSourceLoaded != null)
            {
                this.DataSourceLoaded(this, EventArgs.Empty);
            }
        }
        #endregion
    }
}
