using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.UI;

namespace CustomDisplayText
{
    #region CustomRadSpinEditor
    public class MyRadSpinEditor : RadSpinEditor
    {
        private MyRadSpinElement spinElement;

        public override string ThemeClassName
        {
            get
            {
                return typeof(RadSpinEditor).FullName;
            }
        }

        public bool ScientificNatation
        {
            get
            {
                return this.spinElement.ScientificNation;
            }
            set
            {
                this.spinElement.ScientificNation = value;
            }
        }

        public bool LeadingZero
        {
            get
            {
                return this.spinElement.LeadingZero;
            }
            set
            {
                this.spinElement.LeadingZero = value;
            }
        }

        protected override RadSpinElement CreateSpinElement()
        {
            this.spinElement = new MyRadSpinElement();

            return this.spinElement;
        }
    }
    #endregion
}
