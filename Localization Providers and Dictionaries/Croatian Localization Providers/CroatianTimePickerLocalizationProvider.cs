using System;
using System.Linq;
using Telerik.WinControls.UI;

namespace CroatianRadControlsLocalization
{
    public class CroatianTimePickerLocalizationProvider : RadTimePickerLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case RadTimePickerStringId.HourHeaderText: return "Sati";
                case RadTimePickerStringId.MinutesHeaderText: return "Minute";
                case RadTimePickerStringId.CloseButtonText: return "Zatvori";
                default: return string.Empty;
            }
        }
    }
}
