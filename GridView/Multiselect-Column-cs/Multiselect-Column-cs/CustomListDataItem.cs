using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using System.ComponentModel;

namespace _547099
{
    public class CustomListDataItem : RadListDataItem
    {
        #region RadProperties

        public static readonly RadProperty CheckedProperty = RadProperty.Register("Checked", typeof(bool), typeof(CustomListDataItem), new RadElementPropertyMetadata(false));
        
        #endregion

        #region Properties

        public bool Checked
        {
            get
            {
                return (bool)this.GetValue(CustomListDataItem.CheckedProperty);
            }
            set
            {
                this.SetValue(CustomListDataItem.CheckedProperty, value);
            }
        }

       

        #endregion

        #region Overrides

        protected override void SetDataBoundItem(bool dataBinding, object value)
        {
            base.SetDataBoundItem(dataBinding, value);
            if (value is INotifyPropertyChanged)
            {
                INotifyPropertyChanged item = value as INotifyPropertyChanged;
                item.PropertyChanged += item_PropertyChanged;
            }
        }

        #endregion

        #region Private Methods

        private void item_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Checked")
            {
                this.Checked = (this.DataBoundItem  as RadListDataItem).Selected;
            }            
        }

        #endregion
    }
}
