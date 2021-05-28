using System;
using System.Collections.Generic;
using System.Text;
using Telerik.WinControls.UI;

namespace VirtualMultiColumnComboBox.Implementation
{
    public class EditorControlCellValueNeededEventArgs : GridViewCellValueEventArgs
    {
        public List<object> VirtualDataSource { get; private set; }

        public EditorControlCellValueNeededEventArgs(int columnIndex, int rowIndex, List<object> virtualDataSource)
            : base(columnIndex, rowIndex)
        {
            this.VirtualDataSource = virtualDataSource;
        }
    }
}
