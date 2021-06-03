using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Telerik.WinControls.UI;

namespace VirtualRadGridViewSortingFiltering.Core
{
    public class GridViewCellValueEventArgsEx : GridViewCellValueEventArgs
    {
        private static Type oldArgsType;
        private static FieldInfo rowInfoField;

        private GridViewRowInfo rowInfo;

        public GridViewCellValueEventArgs OldArgs { get; private set; }

        public GridViewRowInfo RowInfo
        {
            get
            {
                if (this.rowInfo == null)
                {
                    this.rowInfo = (GridViewRowInfo)rowInfoField.GetValue(this.OldArgs);
                }

                return this.rowInfo;
            }
        }

        static GridViewCellValueEventArgsEx()
        {
            oldArgsType = typeof(GridViewCellValueEventArgs);
            rowInfoField = oldArgsType.GetField("rowInfo", BindingFlags.Instance | BindingFlags.NonPublic);
        }

        public GridViewCellValueEventArgsEx(GridViewCellValueEventArgs oldArgs, int columnIndex, int rowIndex)
            : base(columnIndex, rowIndex)
        {
            this.OldArgs = oldArgs;
        }
    }
}
