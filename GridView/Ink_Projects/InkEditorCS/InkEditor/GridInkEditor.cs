using Microsoft.Ink;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace InkEditor
{
    class GridInkEditor : BaseGridEditor
    {
        InkEdit inkEdit1;
        public override object Value
        {
            get
            {
                return inkEdit1.Text;
            }

            set
            {
                if (value != null)
                {
                    inkEdit1.Text = value.ToString();
                }

            }
        }
        protected override RadElement CreateEditorElement()
        {
            this.inkEdit1 = new InkEdit();
            this.inkEdit1.RecoTimeout = 1000;
         
            
            this.inkEdit1.UseMouseForInput = true;

            var host = new RadHostItem(inkEdit1);
            host.BackColor = System.Drawing.Color.White;
            return host;
        }
        
    }
}
