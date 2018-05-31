using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.UI;

namespace CustomDisplayText
{
    #region CustomRadSpinElement
    public class MyRadSpinElement : RadSpinElement
    {
        private bool leadingZero;
        private bool scientificNation;

        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(RadSpinElement);
            }
        }

        public bool ScientificNation
        {
            get
            {
                return this.scientificNation;
            }
            set
            {
                if (this.scientificNation != value)
                {
                    this.scientificNation = value;
                    this.SetSpinValue(this.internalValue, true);
                }
            }
        }

        public bool LeadingZero
        {
            get
            {
                return this.leadingZero;
            }
            set

            {
                if (this.leadingZero != value)
                {
                    this.leadingZero = value;
                    this.SetSpinValue(this.internalValue, true);
                }
            }
        }

        protected override decimal GetValueFromText()
        {
            if (!this.ScientificNation)
            {
                return base.GetValueFromText();
            }

            try
            {
                if (!string.IsNullOrEmpty(this.Text) && ((this.Text.Length != 1) || (this.Text != "-")))
                {

                    return this.Constrain(decimal.Parse(this.Text, NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint));
                }
                else
                {
                    return this.internalValue;
                }
            }
            catch
            {
                return this.internalValue;
            }
        }

        protected override void SetSpinValue(decimal value, bool fromValue)
        {
            base.SetSpinValue(value, fromValue);

            this.TextBoxControl.Text = GetNumberText(this.internalValue);
        }

        protected override string GetNumberText(decimal num)
        {
            if (this.Hexadecimal)
            {
                return string.Format("{0:X}", (long)num);
            }

            if (this.ScientificNation)
            {
                return num.ToString("E", CultureInfo.CurrentCulture);
            }

            if (this.LeadingZero)
            {
                return num.ToString("00.##", CultureInfo.CurrentCulture);
            }

            return num.ToString((this.ThousandsSeparator ? "N" : "F") + this.DecimalPlaces.ToString(CultureInfo.CurrentCulture), CultureInfo.CurrentCulture);
        }
    }

    #endregion
}
