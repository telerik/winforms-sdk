using Telerik.Windows.Controls;

namespace ERP.Client.ViewModels
{
    public class DocumentViewModel : ViewModelBase, IDocumentViewModel, IViewModelBase
    {
        private bool isBusy;
        private string documentPath;

        public DocumentViewModel(string title)
        {
            this.Title = title;
            this.DocumentPath = "/ERP.Client;component/Documents/" + this.Title + ".pdf";
        }

        public string Title 
        { 
            get;
            private set; 
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
                    this.OnPropertyChanged(() => this.IsBusy);
                }
            }
        }

        public string DocumentPath
        {
            get
            {
                return this.documentPath;
            }

            set
            {
                if (this.documentPath != value)
                {
                    this.documentPath = value;
                    this.OnPropertyChanged(() => this.DocumentPath);
                }
            }
        }

        public override string ToString()
        {
            return this.Title;
        }
    }
}
