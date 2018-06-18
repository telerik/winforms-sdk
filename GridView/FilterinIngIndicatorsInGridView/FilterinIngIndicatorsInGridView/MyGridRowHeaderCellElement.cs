using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace FilterinIngIndicatorsInGridView
{
    #region CustomGridRowHeaderCellElement
    public class MyGridRowHeaderCellElement : GridRowHeaderCellElement
    {
        private Image clearImage;

        public MyGridRowHeaderCellElement(GridViewColumn column, GridRowElement row)
          : base(column, row)
        {
            this.clearImage = Image.FromFile(@"..\..\cross16x16.png");
        }

        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(GridRowHeaderCellElement);
            }
        }

        public override bool IsCompatible(GridViewColumn data, object context)
        {
            return context is GridFilterRowElement;
        }

        protected override void UpdateImage()
        {
            if (this.GridControl != null && this.GridControl.FilterDescriptors.Count > 0 && !this.RowElement.IsCurrent && this.RowElement is GridFilterRowElement)
            {
                this.Image = this.clearImage;
                return;
            }

            base.UpdateImage();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (this.GridControl != null && this.GridControl.FilterDescriptors.Count > 0 && !this.RowElement.IsCurrent && this.RowElement is GridFilterRowElement)
            {
                this.GridControl.FilterDescriptors.Clear();
            }
        }
    }
    #endregion
}
