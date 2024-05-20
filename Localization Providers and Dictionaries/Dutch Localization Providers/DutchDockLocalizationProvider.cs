using Telerik.WinControls.UI.Localization;

namespace Localization
{
	public class DutchDockLocalizationProvider : RadDockLocalizationProvider
	{
		public override string GetLocalizedString(string id)
		{
			switch (id)
			{
				case RadDockStringId.ContextMenuFloating:
					return "Zwevend";
				case RadDockStringId.ContextMenuDockable:
					return "Dockbaar";
				case RadDockStringId.ContextMenuTabbedDocument:
					return "Getabt document";
				case RadDockStringId.ContextMenuAutoHide:
					return "Automatisch verbergen";
				case RadDockStringId.ContextMenuHide:
					return "Verbergen";
				case RadDockStringId.ContextMenuClose:
					return "Sluiten";
				case RadDockStringId.ContextMenuCloseAll:
					return "Alles sluiten";
				case RadDockStringId.ContextMenuCloseAllButThis:
					return "Alles sluiten behalve deze";
				case RadDockStringId.ContextMenuMoveToPreviousTabGroup:
					return "Ga naar vorige tab groep";
				case RadDockStringId.ContextMenuMoveToNextTabGroup:
					return "Ga naar volgende tab groep";
				case RadDockStringId.ContextMenuNewHorizontalTabGroup:
					return "Nieuwe horizontale tab groep";
				case RadDockStringId.ContextMenuNewVerticalTabGroup:
					return "Nieuwe verticale tab groep";
				case RadDockStringId.ToolTabStripCloseButton:
					return "Sluit scherm";
				case RadDockStringId.ToolTabStripDockStateButton:
					return "Window State";
				case RadDockStringId.ToolTabStripUnpinButton:
					return "Automatisch verbergen";
				case RadDockStringId.ToolTabStripPinButton:
					return "Gedockt";
				case RadDockStringId.DocumentTabStripCloseButton:
					return "Sluit document";
				case RadDockStringId.DocumentTabStripListButton:
					return "Actieve documenten";
					
				default:
					return base.GetLocalizedString(id);
			}
		}
	}
}