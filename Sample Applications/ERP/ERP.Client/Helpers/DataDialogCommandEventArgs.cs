using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
