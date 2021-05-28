using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;
using TrieImplementation;

namespace VirtualMultiColumnComboBox.Implementation
{
    public class VirtualMultiColumnComboBox : RadMultiColumnComboBox
    {
        #region Properties

        public bool IgnoreCase
        {
            get { return ((VirtualMultiColumnComboBoxElement)this.MultiColumnComboBoxElement).IgnoreCase; }
            set { ((VirtualMultiColumnComboBoxElement)this.MultiColumnComboBoxElement).IgnoreCase = value; }
        }

        /// <summary>
        /// Gets or Sets the type of the search. Can be Contains or StartsWith
        /// </summary>
        public SearchType SearchType
        {
            get { return ((VirtualMultiColumnComboBoxElement)this.MultiColumnComboBoxElement).SearchType; }
            set { ((VirtualMultiColumnComboBoxElement)this.MultiColumnComboBoxElement).SearchType = value; }
        }

        /// <summary>
        /// Gets or Sets the value which indicates whether the DataSource will be loaded
        /// in another thread in the background. The <see cref="DataSourceLoaded"/> event is
        /// fired when the DataSource is completely loaded
        /// </summary>
        public bool LoadDataSourceAsync
        {
            get { return ((VirtualMultiColumnComboBoxElement)this.MultiColumnComboBoxElement).LoadDataSourceAsync; }
            set { ((VirtualMultiColumnComboBoxElement)this.MultiColumnComboBoxElement).LoadDataSourceAsync = value; }
        }

        /// <summary>
        /// Gets or Sets the value which indicates after how many milliseconds after
        /// a key press a search will be made
        /// </summary>
        public int StartSearchInterval
        {
            get { return ((VirtualMultiColumnComboBoxElement)this.MultiColumnComboBoxElement).StartSearchInterval; }
            set { ((VirtualMultiColumnComboBoxElement)this.MultiColumnComboBoxElement).StartSearchInterval = value; }
        }

        /// <summary>
        /// Gets or Sets the value which indicates if the GridViewPopup will be automatically
        /// shown/closed during search operations
        /// </summary>
        public bool AutoShowHidePopup
        {
            get { return ((VirtualMultiColumnComboBoxElement)this.MultiColumnComboBoxElement).AutoShowHidePopup; }
            set { ((VirtualMultiColumnComboBoxElement)this.MultiColumnComboBoxElement).AutoShowHidePopup = value; }
        }

        #endregion
        
        #region Methods
        
        /// <summary>
        /// Creates our VirtualMultiColumnComboBoxElemnt
        /// </summary>
        /// <returns></returns>
        protected override RadMultiColumnComboBoxElement CreateMultiColumnComboBoxElement()
        {
            return new VirtualMultiColumnComboBoxElement();
        }
        
        /// <summary>
        /// Needed for proper theming
        /// </summary>
        public override string ThemeClassName
        {
            get { return typeof(RadMultiColumnComboBox).FullName; }
            set { }
        }
        
        /// <summary>
        /// Performs a search operation with the specified text.
        /// </summary>
        /// <param name="text">The text to search</param>
        public void PerformSearch(string text)
        {
            this.PerformSearch(text, TrieImplementation.SearchType.Contains);
        }
            
        public void PerformSearch(string text, SearchType searchType)
        {
            ((VirtualMultiColumnComboBoxElement)this.MultiColumnComboBoxElement).PerformSearch(text, SearchType);
        }
        
        #endregion
        
        #region Events

        /// <summary>
        /// Fired when the Search method is done searching
        /// </summary>
        public event SearchCompletedEventHandler SearchCompleted
        {
            add { ((VirtualMultiColumnComboBoxElement)this.MultiColumnComboBoxElement).SearchCompleted += value; }
            remove { ((VirtualMultiColumnComboBoxElement)this.MultiColumnComboBoxElement).SearchCompleted -= value; }
        }

        /// <summary>
        /// Fires before the searching has begun. Cancelable.
        /// </summary>
        public event SearchStartingEventHandler SearchStarting
        {
            add { ((VirtualMultiColumnComboBoxElement)this.MultiColumnComboBoxElement).SearchStarting += value; }
            remove { ((VirtualMultiColumnComboBoxElement)this.MultiColumnComboBoxElement).SearchStarting -= value; }
        }

        /// <summary>
        /// Fired when value for a cell is needed. Also provides the datasource.
        /// </summary>
        public event EditorControlCellValueNeededEventHandler EditorControlCellValueNeeded
        {
            add { ((VirtualMultiColumnComboBoxElement)this.MultiColumnComboBoxElement).EditorControlCellValueNeeded += value; }
            remove { ((VirtualMultiColumnComboBoxElement)this.MultiColumnComboBoxElement).EditorControlCellValueNeeded -= value; }
        }

        /// <summary>
        /// Fired when the DataSource is completely loaded
        /// </summary>
        public event EventHandler DataSourceLoaded
        {
            add { ((VirtualMultiColumnComboBoxElement)this.MultiColumnComboBoxElement).DataSourceLoaded += value; }
            remove { ((VirtualMultiColumnComboBoxElement)this.MultiColumnComboBoxElement).DataSourceLoaded -= value; }
        }

        #endregion
    }
}