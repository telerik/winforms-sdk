using ERP.Repository;
using System;
using System.Collections.Generic;
using System.Data.Services.Client;
using System.Windows.Input;


namespace ERP.Client.ViewModels
{
    public abstract class ERPViewModelBase<T>  where T : class, global::System.ComponentModel.INotifyPropertyChanged
    {
    
        private T selectedItem;
        private bool showAdditionalItems;
        private IEnumerable<object> additionalItems;
      
        private bool isBusy;

        public ERPViewModelBase()
        {
          
            this.Callback = new Action<DataServiceQuery<T>>(query =>
            {
             
            });

          
        }

        protected abstract void GetQuery();
        public abstract object GetNewItem();
        public abstract string ItemName { get; }

        public Action<DataServiceQuery<T>> Callback { get; private set; }
        

        //public QueryableDataServiceCollectionView<T> Items
        //{
        //    get
        //    {
        //        if (this.items == null)
        //        {
        //            this.IsBusy = true;
        //            this.GetQuery();
        //        }

        //        return this.items;
        //    }
        //    set
        //    {
        //        if (this.items != value)
        //        {
        //            this.items = value;
        //            this.OnPropertyChanged(() => this.Items);
        //        }
        //    }
        //}

        public T SelectedItem
        {
            get
            {
                return this.selectedItem;
            }

            set
            {
                if (!EqualityComparer<T>.Default.Equals(this.selectedItem, value))
                {
                    this.selectedItem = value;
                //    this.OnPropertyChanged(() => this.SelectedItem);
                    this.InvalidateCommands();
                }
            }
        }

        public object ItemToEdit
        {
            get
            {
                return this.SelectedItem;
            }
        }

        public bool IsBusy
        {
            get
            {
                return this.isBusy;
            }
            private set
            {
                if (this.isBusy != value)
                {
                    this.isBusy = value;
                 //   this.OnPropertyChanged(() => this.IsBusy);
                }
            }
        }

        public IEnumerable<object> AdditionalItems
        {
            get
            {
                return this.additionalItems;
            }
            set
            {
                if (this.additionalItems != value)
                {
                    this.additionalItems = value;
                   // this.OnPropertyChanged(() => this.AdditionalItems);
                }
            }
        }

        public bool ShowAdditionalItems
        {
            get
            {
                return this.showAdditionalItems;
            }
            set
            {
                if (this.showAdditionalItems != value)
                {
                    this.showAdditionalItems = value;
                  //  this.OnPropertyChanged(() => this.ShowAdditionalItems);
                }
            }
        }

        private void InvalidateCommands()
        {
         //   (this.EditRecordCommand as DelegateCommand).InvalidateCanExecute();
         //   (this.DeleteRecordCommand as DelegateCommand).InvalidateCanExecute();
        }

        //private void OnItemsLoaded(object sender, Telerik.Windows.Controls.DataServices.LoadedDataEventArgs e)
        //{
        //    this.Items.LoadedData -= this.OnItemsLoaded;
        //    this.Items.PropertyChanged += this.OnItemsPropertyChanged;
        //    this.IsBusy = false;
        //}

        //private void OnItemsPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        //{
        //    if (e.PropertyName == "IsBusy")
        //    {
        //        this.IsBusy = this.Items.IsBusy;
        //    }
        //}

        //private void Refresh()
        //{
        //    if (this.Items.HasChanges)
        //    {
        //        this.Items.RejectChanges();
        //    }

        //    this.Items.Refresh();
        //}
    }
}
