using ServerSideDropDownList.Core;
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

namespace ServerSideDropDownList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            RadDropDownList list = new RadDropDownList
            {
                Parent = this,
                Dock = DockStyle.Top
            };

            LargeDataEntities dbContext = new LargeDataEntities();
            list.AutoCompleteValueMember = "Name";

            list.DropDownListElement.AutoCompleteSuggest =
                new ServerAutoCompleteSuggestHelper<Datum>(list.DropDownListElement, dbContext.Data);

            list.DropDownListElement.AutoCompleteAppend = new ServerAutoCompleteAppendHelper<Datum>(list.DropDownListElement, dbContext.Data);
        }
    }
}
