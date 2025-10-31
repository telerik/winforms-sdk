using System;

namespace ERP.Client
{
    public class DataDialogCommandEventArgs : EventArgs
    {
        public bool SavaChanges { get; private set; }

        public DataDialogCommandEventArgs(bool saveChanges)
        {
            this.SavaChanges = saveChanges;
        }
    }
}
