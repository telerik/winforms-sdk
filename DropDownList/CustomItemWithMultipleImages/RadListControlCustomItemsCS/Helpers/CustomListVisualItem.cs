using System;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.Layouts;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.UI;

namespace RadListControlCustomItems.Helpers
{
    /// <summary>
    /// The custom list visual item.
    /// </summary>
    public class CustomListVisualItem : RadListVisualItem
    {
        #region Constants and Fields

        /// <summary>
        /// The image.
        /// </summary>
        private readonly ImagePrimitive image = new ImagePrimitive();

        /// <summary>
        /// The image 2.
        /// </summary>
        private readonly ImagePrimitive image2 = new ImagePrimitive();

        /// <summary>
        /// The label.
        /// </summary>
        private readonly RadLabelElement label = new RadLabelElement();

        #endregion Constants and Fields

        #region Constructors and Destructors

        /// <summary>
        /// Initializes static members of the <see cref="CustomListVisualItem"/> class.
        /// </summary>
        static CustomListVisualItem()
        {
            SynchronizationProperties.Add(CustomListDataItem.ImageProperty);
            SynchronizationProperties.Add(CustomListDataItem.Image2Property);
            SynchronizationProperties.Add(CustomListDataItem.NameProperty);
        }

        #endregion Constructors and Destructors

        #region Properties

        /// <summary>
        /// Gets ThemeEffectiveType.
        /// </summary>
        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(RadListVisualItem);
            }
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// The create child elements.
        /// </summary>
        protected override void CreateChildElements()
        {
            base.CreateChildElements();

            this.label.StretchHorizontally = true;

            var stack = new StackLayoutPanel { Orientation = Orientation.Horizontal };

            this.image.ImageScaling = ImageScaling.SizeToFit;
            this.image2.ImageScaling = ImageScaling.SizeToFit;

            stack.Children.Add(this.label);
            stack.Children.Add(this.image);
            stack.Children.Add(this.image2);

            this.Children.Add(stack);
        }

        /// <summary>
        /// The property synchronized.
        /// </summary>
        /// <param name="property">
        /// The property.
        /// </param>
        protected override void PropertySynchronized(RadProperty property)
        {
            var dataItem = (CustomListDataItem)this.Data;

            this.image2.Image = dataItem.Image2;
            this.image.Image = dataItem.Image;
            this.label.Text = dataItem.Name;
        }

        #endregion Methods
    }
}