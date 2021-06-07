using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace StandaloneRadExpressionEdtiorForm
{
    public partial class StandaloneExpressionEditorForm : RadExpressionEditorForm
    {
        private static RadGridView hiddenGrid;
        private static GridViewDataColumn dataColumn;
        
        static StandaloneExpressionEditorForm()
        {
            hiddenGrid = new RadGridView();
            dataColumn = new GridViewTextBoxColumn();
            hiddenGrid.Columns.Add(dataColumn);
            hiddenGrid.Rows.AddNew();
        }

        public StandaloneExpressionEditorForm() 
            : base(dataColumn)
        {
        }

        public string ReturnValue
        {
            get
            {
                return hiddenGrid.Rows[0].Cells[0].Value.ToString();
            }
        }


        public DialogResult ShowDialog(object initialValue)
        {
            this.Expression = initialValue.ToString();
            return base.ShowDialog();
        }
    }
}