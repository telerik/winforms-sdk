// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Form1.cs" company="">
//
// </copyright>
// <summary>
//   The form 1.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RadListControlCustomItems
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using RadListControlCustomItems.Helpers;
    using RadListControlCustomItems.Properties;
    using Telerik.WinControls.UI;

    /// <summary>
    /// The form 1.
    /// </summary>
    public partial class Form1 : Form
    {
        #region Constants and Fields

        /// <summary>
        /// The rad list control 1.
        /// </summary>
        private readonly RadListControl radListControl1;

        #endregion Constants and Fields

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            this.InitializeComponent();
            this.radListControl1 = new RadListControl();
            this.Size = new Size(500, 300);
            this.Load += this.Form1_Load;
        }

        #endregion Constructors and Destructors

        #region Methods

        /// <summary>
        /// The creating visual list item.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="args">
        /// The args.
        /// </param>
        private void CreatingVisualListItem(object sender, CreatingVisualListItemEventArgs args)
        {
            args.VisualItem = new CustomListVisualItem();
        }

        /// <summary>
        /// The form 1_ load.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.radListControl1.Dock = DockStyle.Fill;
            this.radListControl1.CreatingVisualListItem += this.CreatingVisualListItem;
            this.radListControl1.ItemDataBinding += this.ItemDataBinding;
            this.radListControl1.ItemDataBound += this.ItemDataBound;

            this.Controls.Add(this.radListControl1);

            this.PrepareDataSourceAndShowDropDown(1000);
        }

        /// <summary>
        /// The item data binding.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="args">
        /// The args.
        /// </param>
        private void ItemDataBinding(object sender, ListItemDataBindingEventArgs args)
        {
            args.NewItem = new CustomListDataItem();
        }

        /// <summary>
        /// The item data bound.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="args">
        /// The args.
        /// </param>
        private void ItemDataBound(object sender, ListItemDataBoundEventArgs args)
        {
            var listDataItem = (CustomListDataItem)args.NewItem;
            var dataObject = (BussinessObject)listDataItem.DataBoundItem;

            listDataItem.Name = dataObject.Name;
            listDataItem.Image = dataObject.Image;
            listDataItem.Image2 = dataObject.Image2;
        }

        /// <summary>
        /// The prepare data source and show drop down.
        /// </summary>
        /// <param name="noObjects">
        /// The no objects.
        /// </param>
        private void PrepareDataSourceAndShowDropDown(int noObjects)
        {
            this.radListControl1.DataSource = null;
            this.radListControl1.DisplayMember = "Name";

            var list = new BindingList<BussinessObject>();
            for (int i = 0; i < noObjects; ++i)
            {
                var businessObject = new BussinessObject();
                businessObject.Image = Resources.combobox;
                businessObject.Image2 = i % 2 == 0 ? Resources.calendar : null;
                businessObject.Name = " Item " + (i + 1);
                list.Add(businessObject);
            }

            this.radListControl1.DataSource = list;
        }

        #endregion Methods
    }
}