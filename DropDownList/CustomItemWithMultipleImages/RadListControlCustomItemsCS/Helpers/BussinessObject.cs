using System.ComponentModel;
using System.Drawing;

namespace RadListControlCustomItems.Helpers
{
    /// <summary>
    /// The bussiness object.
    /// </summary>
    public class BussinessObject : INotifyPropertyChanged
    {
        #region Constants and Fields

        /// <summary>
        /// The image.
        /// </summary>
        private Image image;

        /// <summary>
        /// The image 2.
        /// </summary>
        private Image image2;

        /// <summary>
        /// The name.
        /// </summary>
        private string name;

        #endregion Constants and Fields

        #region Events

        /// <summary>
        /// The property changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion Events

        #region Properties

        /// <summary>
        /// Gets or sets Image.
        /// </summary>
        public Image Image
        {
            get
            {
                return this.image;
            }

            set
            {
                if (this.image == value)
                {
                    return;
                }

                this.image = value;
                this.OnNotifyPropertyChanged("Image");
            }
        }

        /// <summary>
        /// Gets or sets Image2.
        /// </summary>
        public Image Image2
        {
            get
            {
                return this.image2;
            }

            set
            {
                if (this.image2 == value)
                {
                    return;
                }

                this.image2 = value;
                this.OnNotifyPropertyChanged("Image2");
            }
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (this.name == value)
                {
                    return;
                }

                this.name = value;
                this.OnNotifyPropertyChanged("Name");
            }
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// The on notify property changed.
        /// </summary>
        /// <param name="property">
        /// The property.
        /// </param>
        private void OnNotifyPropertyChanged(string property)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        #endregion Methods
    }
}