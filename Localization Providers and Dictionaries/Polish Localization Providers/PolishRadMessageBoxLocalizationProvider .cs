using Telerik.WinControls;

public class PolishRadMessageBoxLocalizationProvider : RadMessageLocalizationProvider
{
    public override string GetLocalizedString(string id)
    {
        switch (id)
        {
            case RadMessageStringID.AbortButton:
                return "Przerwij";
            case RadMessageStringID.CancelButton:
                return "Anuluj";
            case RadMessageStringID.IgnoreButton:
                return "Ignoruj";
            case RadMessageStringID.NoButton:
                return "Nie";
            case RadMessageStringID.OKButton:
                return "OK";
            case RadMessageStringID.RetryButton:
                return "Ponów";
            case RadMessageStringID.YesButton:
                return "Tak";
        }
        return string.Empty;
    }
}
