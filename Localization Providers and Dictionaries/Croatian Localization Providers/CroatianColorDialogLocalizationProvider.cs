using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.UI;

namespace CroatianRadControlsLocalization
{
    class CroatianColorDialogLocalizationProvider : ColorDialogLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                //localizing the static strings
                case ColorDialogStringId.ColorDialogProfessionalTab: return "Profesionalne";
                case ColorDialogStringId.ColorDialogWebTab: return "Mrežne";
                case ColorDialogStringId.ColorDialogSystemTab: return "Sustavne";
                case ColorDialogStringId.ColorDialogBasicTab: return "Osnovne";
                case ColorDialogStringId.ColorDialogAddCustomColorButton: return "Dodaj svoju boju";
                case ColorDialogStringId.ColorDialogOKButton: return "OK";
                case ColorDialogStringId.ColorDialogCancelButton: return "Otkaži";
                case ColorDialogStringId.ColorDialogNewColorLabel: return "Novo";
                case ColorDialogStringId.ColorDialogCurrentColorLabel: return "Trenutno";
                case ColorDialogStringId.ColorDialogCaption: return "Prozor boja";
            }

            return base.GetLocalizedString(id);
        }
    }
}
