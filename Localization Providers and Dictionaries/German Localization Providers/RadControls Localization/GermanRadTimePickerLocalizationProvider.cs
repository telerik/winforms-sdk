using System;
using System.Windows.Forms;
using Telerik.WinControls.Localization;
using Telerik.WinControls.UI;

namespace GermanRadControlsLocalization
{
	/// <summary>
	/// Provides localization services for RadTimePicker.
	/// </summary>
	public class GermanRadTimePickerLocalizationProvider : RadTimePickerLocalizationProvider
	{
		/// <summary>
		/// Gets the string corresponding to the given ID.
		/// </summary>
		/// <param name="id">String ID.</param>
		/// <returns>The string corresponding to the given ID.</returns>
		public override string GetLocalizedString(string id)
		{
			switch (id)
			{
				case RadTimePickerStringId.HourHeaderText:
                    return "Stunden";
				case RadTimePickerStringId.MinutesHeaderText: 
                    return "Minuten";
				case RadTimePickerStringId.CloseButtonText: 
                    return "Schließen";
				default: 
                    MessageBox.Show( string.Format( "GermanRadTimePickerLocalizationProvider: Missing Translation for: {0}" , id ) );
                    return base.GetLocalizedString( id );
			}
		}
	}
}
