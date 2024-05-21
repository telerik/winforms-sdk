using System.ComponentModel;
using System.Drawing;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace RadListControlCustomItems.Helpers
{
    /// <summary>
    /// The custom list data item.
    /// </summary>
    public class CustomListDataItem : RadListDataItem
    {
        #region Constants and Fields

        /// <summary>
        /// The image 2 property.
        /// </summary>
        public static readonly RadProperty Image2Property = RadProperty.Register(
            "Image2", typeof(Image), typeof(CustomListDataItem), new RadElementPropertyMetadata(null));

        /// <summary>
        /// The image property.
        /// </summary>
        public static readonly RadProperty ImageProperty = RadProperty.Register(
            "Image", typeof(Image), typeof(CustomListDataItem), new RadElementPropertyMetadata(null));

        /// <summary>
        /// The name property.
        /// </summary>
        public static readonly RadProperty NameProperty = RadProperty.Register(
            "Name", typeof(string), typeof(CustomListDataItem), new RadElementPropertyMetadata(string.Empty));

        #endregion Constants and Fields

        #region Properties

        /// <summary>
        /// Gets or sets Image.
        /// </summary>
        public new Image Image
        {
            get
            {
                return (Image)this.GetValue(ImageProperty);
            }

            set
            {
                this.SetValue(ImageProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets Image2.
        /// </summary>
        public Image Image2
        {
            get
            {
                return (Image)this.GetValue(Image2Property);
            }

            set
            {
                this.SetValue(Image2Property, value);
            }
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        public string Name
        {
            get
            {
                return (string)this.GetValue(NameProperty);
            }

            set
            {
                this.SetValue(NameProperty, value);
            }
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// The set data bound item.
        /// </summary>
        /// <param name="dataBinding">
        /// The data binding.
        /// </param>
        /// <param name="value">
        /// The value.
        /// </param>
        protected override void SetDataBoundItem(bool dataBinding, object value)
        {
            base.SetDataBoundItem(dataBinding, value);
            if (value is INotifyPropertyChanged)
            {
                var item = value as INotifyPropertyChanged;
                item.PropertyChanged += this.item_PropertyChanged;
            }
        }

        /// <summary>
        /// The item_ property changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void item_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Image")
            {
                this.Image = (this.DataBoundItem as BussinessObject).Image;
            }

            if (e.PropertyName == "Image2")
            {
                this.Image2 = (this.DataBoundItem as BussinessObject).Image2;
            }

            if (e.PropertyName == "Name")
            {
                this.Name = (this.DataBoundItem as BussinessObject).Name;
            }
        }

        #endregion Methods
    }
}