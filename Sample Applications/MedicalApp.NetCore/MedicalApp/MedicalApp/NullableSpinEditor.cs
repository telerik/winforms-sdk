using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;

using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace MedicalAppCS
{
    public class NullableSpinEditor : RadSpinEditor
    {
        public NullableSpinEditor()
        {
            this.EnableNullValueInput = true;
        }
    }  
}
