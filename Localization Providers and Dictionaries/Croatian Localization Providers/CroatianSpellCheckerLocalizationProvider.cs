using System;
using System.Linq;
using Telerik.WinControls.UI;

namespace CroatianRadControlsLocalization
{
    public class CroatianSpellCheckerLocalizationProvider : RadSpellCheckerLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case RadSpellCheckerStringId.Title:
                    return "Provjera pravopisa";
                case RadSpellCheckerStringId.OK:
                    return "OK";
                case RadSpellCheckerStringId.Cancel:
                    return "Otkaži";
                case RadSpellCheckerStringId.Close:
                    return "Zatvori";
                case RadSpellCheckerStringId.Change:
                    return "Izmjeni";
                case RadSpellCheckerStringId.Complete:
                    return "Provjera pravopisa je završena.";
                case RadSpellCheckerStringId.AddToDictionary:
                    return "Dodaj u rječnik";
                case RadSpellCheckerStringId.IngoreAll:
                    return "Ignoriraj sve";
                case RadSpellCheckerStringId.Suggestions:
                    return "Prijedlozi:";
                case RadSpellCheckerStringId.ChangeTo:
                    return "Promjeni u:";
                case RadSpellCheckerStringId.NotInDictionary:
                    return "Nije u rječniku:";
            }

            return null;
        }
    }
}
