///
/// This file contains french/german localizations for some Telerik controls
/// Special thanks to Remius ( http://www.telerik.com/community/client-profile.aspx?cId=192171 )
/// and to Philippe Gauthier
/// 
/// //TODO: TreeView seems to load localized texts on load of the "context menu". Need to find a way to force a reload...
/// //TODO: Not tested : RadDock
/// 

using Telerik.WinControls;
using Telerik.WinControls.UI.Localization;
using Telerik.WinControls.UI;

namespace TelerikLocalizations
{
	public class RadMessageBoxLocalization : RadMessageLocalizationProvider
	{
		public override string GetLocalizedString(string id)
		{
			//Get localized string, if null use "base" texts (english)
			return RadLocalizationGeneric.GetRadMessageBoxLocalizedString(id) ?? base.GetLocalizedString(id);
		}
	}
	public class RadTreeViewLocalization : TreeViewLocalizationProvider
	{
		public override string GetLocalizedString(string id)
		{
			//Get localized string, if null use "base" texts (english)
			return RadLocalizationGeneric.GetRadTreeViewLocalizedString(id) ?? base.GetLocalizedString(id);
		}
	}
	public class RadDockLocalization : RadDockLocalizationProvider
	{
		public override string GetLocalizedString(string id)
		{
			//Get localized string, if null use "base" texts (english)
			return RadLocalizationGeneric.GetRadDockLocalizedString(id) ?? base.GetLocalizedString(id);
		}
	}
	public class RadGridLocalization : RadGridLocalizationProvider
	{
		public override string GetLocalizedString(string id)
		{
			//Get localized string, if null use "base" texts (english)
			return RadLocalizationGeneric.GetRadGridLocalizedString(id) ?? base.GetLocalizedString(id);
		}
	}

	/// <summary>
	/// Translations Functions...
	/// </summary>
	/// <remarks>
	/// All stuff here should be placed in ResX files (standard format for localization!)
	/// For the demo I put strings here :o)
	///</remarks>
	internal static class RadLocalizationGeneric
	{
		/// <summary>
		/// MessageBox translations
		/// </summary>
		/// <param name="id">Id of item</param>
		/// <returns>Localized string or null if not overloaded here</returns>
		internal static string GetRadMessageBoxLocalizedString(string id)
		{
			switch (System.Globalization.CultureInfo.CurrentCulture.LCID)
			{
				case 1036:
					#region French
					switch (id)
					{
						case RadMessageStringID.AbortButton: return "Annuler";
						case RadMessageStringID.CancelButton: return "Annuler";
						case RadMessageStringID.IgnoreButton: return "Ignorer";
						case RadMessageStringID.NoButton: return "Non";
						case RadMessageStringID.OKButton: return "Ok";
						case RadMessageStringID.RetryButton: return "Réessayer";
						case RadMessageStringID.YesButton: return "Oui";
					}
					#endregion
					break;
				case 1031:
					#region German
					switch (id)
					{
						case RadMessageStringID.AbortButton: return "Abbrechen";
						case RadMessageStringID.CancelButton: return "Abbrechen";
						case RadMessageStringID.IgnoreButton: return "Ignorieren";
						case RadMessageStringID.NoButton: return "Nein";
						case RadMessageStringID.OKButton: return "OK";
						case RadMessageStringID.RetryButton: return "Wiederholen";
						case RadMessageStringID.YesButton: return "Ja";
					}
					#endregion
					break;
				case 1033:
				//English
				default:
					//Others
					break;
			}
			//Returns null when language not overriden or when string not translated
			return null;
		}

		/// <summary>
		/// TreeView translations
		/// </summary>
		/// <param name="id">Id of item</param>
		/// <returns>Localized string or null if not overloaded here</returns>
		internal static string GetRadTreeViewLocalizedString(string id)
		{
			switch (System.Globalization.CultureInfo.CurrentCulture.LCID)
			{
				case 1036:
					#region French
					switch (id)
					{
						case TreeViewStringId.ContextMenuCollapse:
							return "Réduire";
						case TreeViewStringId.ContextMenuDelete:
							return "Supprimer";
						case TreeViewStringId.ContextMenuEdit:
							return "Editer";
						case TreeViewStringId.ContextMenuExpand:
							return "Déplier";
						case TreeViewStringId.ContextMenuNew:
							return "Nouveau";
					}
					#endregion
					break;
				case 1031:
					#region German
					switch (id)
					{
						case TreeViewStringId.ContextMenuCollapse:
							return "Reduzieren";
						case TreeViewStringId.ContextMenuDelete:
							return "Löschen";
						case TreeViewStringId.ContextMenuEdit:
							return "Umbenennen";
						case TreeViewStringId.ContextMenuExpand:
							return "Erweitern";
						case TreeViewStringId.ContextMenuNew:
							return "Neu";
					}
					#endregion
					break;
				case 1033:
				//English
				default:
					//Others
					break;
			}
			//Returns null when language not overriden or when string not translated
			return null;
		}

		/// <summary>
		/// RadDock translations
		/// </summary>
		/// <param name="id">Id of item</param>
		/// <returns>Localized string or null if not overloaded here</returns>
		internal static string GetRadDockLocalizedString(string id)
		{
			switch (System.Globalization.CultureInfo.CurrentCulture.LCID)
			{
				case 1036:
					#region French
					switch (id)
					{
						case RadDockStringId.ContextMenuAutoHide:
							return "Masquer Automatiquement";
						case RadDockStringId.ContextMenuCancel:
							return "Annuler";
						case RadDockStringId.ContextMenuClose:
							return "Fermer";
						case RadDockStringId.ContextMenuCloseAll:
							return "Fermer tout";
						case RadDockStringId.ContextMenuCloseAllButThis:
							return "Fermer tout sauf celui-ci";
						case RadDockStringId.ContextMenuDockable:
							return "Accrochable";
						case RadDockStringId.ContextMenuFloating:
							return "Flottant";
						case RadDockStringId.ContextMenuHide:
							return "Masquer";
						case RadDockStringId.ContextMenuMoveToNextTabGroup:
							return "Déplacer vers l'onglet suivant";
						case RadDockStringId.ContextMenuMoveToPreviousTabGroup:
							return "Déplacer vers l'onglet précédent";
						case RadDockStringId.ContextMenuNewHorizontalTabGroup:
							return "Nouveau groupe horizontal";
						case RadDockStringId.ContextMenuNewVerticalTabGroup:
							return "Nouveau groupe vertical";
						case RadDockStringId.ContextMenuTabbedDocument:
							return "Mettre le document en onglet"; //TODO: check translation...
					}
					#endregion
					break;
				case 1031:
					#region German
					switch (id)
					{
						case RadDockStringId.ContextMenuAutoHide:
							return "Automatisch im Hintergrund";
						case RadDockStringId.ContextMenuCancel:
							return "Abbrechen";
						case RadDockStringId.ContextMenuClose:
							return "Schließen";
						case RadDockStringId.ContextMenuCloseAll:
							return "Alle schließen";
						case RadDockStringId.ContextMenuCloseAllButThis:
							return "Alle außer diesem schließen";
						case RadDockStringId.ContextMenuDockable:
							return "Andockbar";
						case RadDockStringId.ContextMenuFloating:
							return "Unverankert";
						case RadDockStringId.ContextMenuHide:
							return "Ausblenden";
						case RadDockStringId.ContextMenuMoveToNextTabGroup:
							return "In nächste Registerkartengruppe verschieben";
						case RadDockStringId.ContextMenuMoveToPreviousTabGroup:
							return "In vorherige Registerkartengruppe verschieben";
						case RadDockStringId.ContextMenuNewHorizontalTabGroup:
							return "Neue horizontale Registerkartengruppe";
						case RadDockStringId.ContextMenuNewVerticalTabGroup:
							return "Neue vertikale Registerkartengruppe";
						case RadDockStringId.ContextMenuTabbedDocument:
							return "Dokument im Registerkartenformat";
					}
					#endregion
					break;
				case 1033:
				//English
				default:
					//Others
					break;
			}
			//Returns null when language not overriden or when string not translated
			return null;
		}

		/// <summary>
		/// GridView translations
		/// </summary>
		/// <param name="id">Id of item</param>
		/// <returns>Localized string or null if not overloaded here</returns>
		internal static string GetRadGridLocalizedString(string id)
		{
			switch (System.Globalization.CultureInfo.CurrentCulture.LCID)
			{
				case 1036:
					#region French
					switch (id)
					{
						case RadGridStringId.FilterFunctionBetween:
							return "Compris entre";
						case RadGridStringId.FilterFunctionContains:
							return "Contient";
						case RadGridStringId.FilterFunctionDoesNotContain:
							return "Ne contient pas";
						case RadGridStringId.FilterFunctionEndsWith:
							return "Finit par";
						case RadGridStringId.FilterFunctionEqualTo:
							return "Est égal à";
						case RadGridStringId.FilterFunctionGreaterThan:
							return "Est supérieur à";
						case RadGridStringId.FilterFunctionGreaterThanOrEqualTo:
							return "Est supérieur ou égal à";
						case RadGridStringId.FilterFunctionIsEmpty:
							return "Est vide";
						case RadGridStringId.FilterFunctionIsNull:
							return "Est nul";
						case RadGridStringId.FilterFunctionLessThan:
							return "Est inférieur à";
						case RadGridStringId.FilterFunctionLessThanOrEqualTo:
							return "Est inférieur ou égal à";
						case RadGridStringId.FilterFunctionNoFilter:
							return "Pas de filtre";
						case RadGridStringId.FilterFunctionNotBetween:
							return "Non compris entre";
						case RadGridStringId.FilterFunctionNotEqualTo:
							return "Est différent de";
						case RadGridStringId.FilterFunctionNotIsEmpty:
							return "Est non vide";
						case RadGridStringId.FilterFunctionNotIsNull:
							return "Est non nul";
						case RadGridStringId.FilterFunctionStartsWith:
							return "Commence par";
						case RadGridStringId.FilterFunctionCustom:
							return "Filtre personnalisé";
						case RadGridStringId.CustomFilterMenuItem:
							return "Menu filtre personnalisé";
						case RadGridStringId.CustomFilterDialogCaption:
							return "Filtre personnalisé";
						case RadGridStringId.CustomFilterDialogLabel:
							return "Afficher les lignes où";
						case RadGridStringId.CustomFilterDialogRbAnd:
							return "Et";
						case RadGridStringId.CustomFilterDialogRbOr:
							return "Ou";
						case RadGridStringId.CustomFilterDialogBtnOk:
							return "OK";
						case RadGridStringId.CustomFilterDialogBtnCancel:
							return "Annuler";
						case RadGridStringId.DeleteRowMenuItem:
							return "Effacer la ligne";
						case RadGridStringId.SortAscendingMenuItem:
							return "Trier (ordre croissant)";
						case RadGridStringId.SortDescendingMenuItem:
							return "Trier (ordre décroissant)";
						case RadGridStringId.ClearSortingMenuItem:
							return "Annuler les tris";
						case RadGridStringId.ConditionalFormattingMenuItem:
							return "Formatage conditionnel";
						case RadGridStringId.GroupByThisColumnMenuItem:
							return "Grouper par cette colonne";
						case RadGridStringId.UngroupThisColumn:
							return "Dégrouper cette colonne";
						case RadGridStringId.ColumnChooserMenuItem:
							return "Masqueur de colonnes";
						case RadGridStringId.HideMenuItem:
							return "Masquer cette colonne";
						case RadGridStringId.UnpinMenuItem:
							return "Masquer automatiquement";
						case RadGridStringId.PinMenuItem:
							return "Epingler";
						case RadGridStringId.BestFitMenuItem:
							return "Ajuster la taille de la colonne";
						case RadGridStringId.PasteMenuItem:
							return "Coller";
						case RadGridStringId.EditMenuItem:
							return "Edition";
						case RadGridStringId.CopyMenuItem:
							return "Copier";
						case RadGridStringId.AddNewRowString:
							return "Cliquer pour ajouter une nouvelle ligne";
						case RadGridStringId.ConditionalFormattingCaption:
							return "Surligneur conditionnel";
						case RadGridStringId.ConditionalFormattingLblColumn:
							return "Colonne:";
						case RadGridStringId.ConditionalFormattingLblName:
							return "Nom:";
						case RadGridStringId.ConditionalFormattingLblType:
							return "Type:";
						case RadGridStringId.ConditionalFormattingLblValue1:
							return "Valeur 1:";
						case RadGridStringId.ConditionalFormattingLblValue2:
							return "Valeur 2:";
						case RadGridStringId.ConditionalFormattingGrpConditions:
							return "Conditions";
						case RadGridStringId.ConditionalFormattingGrpProperties:
							return "Propriétés";
						case RadGridStringId.ConditionalFormattingChkApplyToRow:
							return "Appliquer aux lignes existantes";
						case RadGridStringId.ConditionalFormattingBtnAdd:
							return "Ajouter";
						case RadGridStringId.ConditionalFormattingBtnRemove:
							return "Supprimer";
						case RadGridStringId.ConditionalFormattingBtnOK:
							return "OK";
						case RadGridStringId.ConditionalFormattingBtnCancel:
							return "Annuler";
						case RadGridStringId.ConditionalFormattingBtnApply:
							return "Appliquer";
						case RadGridStringId.ColumnChooserFormCaption:
							return "Masqueur de colonnes";
						case RadGridStringId.ColumnChooserFormMessage:
							return "Ajouter ici une colonne\npour la faire disparaitre\ntemporairement de la vue";
						case RadGridStringId.GroupingPanelDefaultMessage:
							return "Ajouter ici une colonne pour faire un regroupement par cette colonne";
						case RadGridStringId.ClearValueMenuItem:
							return "Effacer la Valeur";
						case RadGridStringId.ConditionalFormattingContains:
							return "Contient [Valeur1]";
						case RadGridStringId.ConditionalFormattingDoesNotContain:
							return "Ne contient pas [Valeur1]";
						case RadGridStringId.ConditionalFormattingEndsWith:
							return "Finit par [Valeur1]";
						case RadGridStringId.ConditionalFormattingEqualsTo:
							return "Est égal à [Valeur1]";
						case RadGridStringId.ConditionalFormattingIsBetween:
							return "Est compris entre [Valeur1] et [Valeur2]";
						case RadGridStringId.ConditionalFormattingIsGreaterThan:
							return "Est supérieur à [Valeur1]";
						case RadGridStringId.ConditionalFormattingIsGreaterThanOrEqual:
							return "Est supérieur ou égal à [Valeur1]";
						case RadGridStringId.ConditionalFormattingIsLessThan:
							return "Est inférieur à [Valeur1]";
						case RadGridStringId.ConditionalFormattingIsLessThanOrEqual:
							return "Est inférieur ou égal à [Valeur1]";
						case RadGridStringId.ConditionalFormattingIsNotBetween:
							return "Non compris entre [Valeur1] et [Valeur2]";
						case RadGridStringId.ConditionalFormattingIsNotEqualTo:
							return "Est différent de [Valeur1]";
						case RadGridStringId.ConditionalFormattingStartsWith:
							return "Commence par [Valeur1]";
						case RadGridStringId.ConditionalFormattingRuleAppliesOn:
							return "La règle s'applique au champ:";
						case RadGridStringId.ConditionalFormattingChooseOne:
							return "[Choisir un type]";
						case RadGridStringId.NoDataText:
							return "Pas de données à afficher";
					}
					#endregion
					break;
				case 1031:
					#region German
					switch (id)
					{
						case RadGridStringId.AddNewRowString:
							return "Klicken Sie hier, um eine neue Zeile einzufügen.";
						case RadGridStringId.BestFitMenuItem:
							return "Optimale Spaltenbreite";
						case RadGridStringId.ClearSortingMenuItem:
							return "Sortierung entfernen";
						case RadGridStringId.ClearValueMenuItem:
							return "Wert löschen";
						case RadGridStringId.ColumnChooserFormCaption:
							return "Spaltenauswahl";
						case RadGridStringId.ColumnChooserFormMessage:
							return "Um eine Spalte auszublenden,\n" +
											 "verschieben Sie diese von der Tabelle\n" +
											 "in dieses Fenster";
						case RadGridStringId.ColumnChooserMenuItem:
							return "Spalte einblenden";
						case RadGridStringId.ConditionalFormattingBtnAdd:
							return "Neue Regel";
						case RadGridStringId.ConditionalFormattingBtnApply:
							return "Anwenden";
						case RadGridStringId.ConditionalFormattingBtnCancel:
							return "Abbrechen";
						case RadGridStringId.ConditionalFormattingBtnOK:
							return "Bestätigen";
						case RadGridStringId.ConditionalFormattingChooseOne:
							return "[Wähle aus]";
						case RadGridStringId.ConditionalFormattingBtnRemove:
							return "Entferne Regel";
						case RadGridStringId.ConditionalFormattingCaption:
							return "Editor für die bedingte Formatierung";
						case RadGridStringId.ConditionalFormattingChkApplyToRow:
							return "Regel auf ganze Zeile anwenden";
						case RadGridStringId.ConditionalFormattingContains:
							return "Enthält [Wert1]";
						case RadGridStringId.ConditionalFormattingDoesNotContain:
							return "Enthält nicht [Wert1]";
						case RadGridStringId.ConditionalFormattingEndsWith:
							return "Endet mit [Wert1]";
						case RadGridStringId.ConditionalFormattingEqualsTo:
							return "Ist gleich [Wert1]";
						case RadGridStringId.ConditionalFormattingGrpConditions:
							return "Regeln";
						case RadGridStringId.ConditionalFormattingGrpProperties:
							return "Eigenschaften der Regel";
						case RadGridStringId.ConditionalFormattingIsBetween:
							return "Ist zwischen [Wert1] und [Wert2]";
						case RadGridStringId.ConditionalFormattingIsGreaterThan:
							return "Ist größer als [Wert1]";
						case RadGridStringId.ConditionalFormattingIsGreaterThanOrEqual:
							return "Ist größer oder gleich [Wert1]";
						case RadGridStringId.ConditionalFormattingIsLessThan:
							return "Ist kleiner [Wert1]";
						case RadGridStringId.ConditionalFormattingIsLessThanOrEqual:
							return "Ist kleiner oder gleich [Wert1]";
						case RadGridStringId.ConditionalFormattingIsNotBetween:
							return "Ist nicht zwischen [Wert1] und [Wert2]";
						case RadGridStringId.ConditionalFormattingIsNotEqualTo:
							return "Ist nicht gleich [Wert1]";
						case RadGridStringId.ConditionalFormattingLblColumn:
							return "Formatiere nur Zellen mit";
						case RadGridStringId.ConditionalFormattingLblName:
							return "Regelname:";
						case RadGridStringId.ConditionalFormattingLblType:
							return "Zellenwert:";
						case RadGridStringId.ConditionalFormattingLblValue1:
							return "Wert1:";
						case RadGridStringId.ConditionalFormattingLblValue2:
							return "Wert2:";
						case RadGridStringId.ConditionalFormattingMenuItem:
							return "Bedingte Formatierung";
						case RadGridStringId.ConditionalFormattingRuleAppliesOn:
							return "Regel anwenden auf:";
						case RadGridStringId.ConditionalFormattingStartsWith:
							return "Beginnt mit [Wert1]";
						case RadGridStringId.CopyMenuItem:
							return "Kopieren";
						case RadGridStringId.CustomFilterDialogBtnCancel:
							return "Abbrechen";
						case RadGridStringId.CustomFilterDialogBtnOk:
							return "Bestätigen";
						case RadGridStringId.CustomFilterDialogCaption:
							return "Dialog für das benutzerdefinierte Filtern";
						case RadGridStringId.CustomFilterDialogLabel:
							return "Zeige Zeilen für die gilt:";
						case RadGridStringId.CustomFilterDialogRbAnd:
							return "Und";
						case RadGridStringId.CustomFilterDialogRbOr:
							return "Oder";
						case RadGridStringId.CustomFilterMenuItem:
							return "Benutzerdefinierter Filter";
						case RadGridStringId.DeleteRowMenuItem:
							return "Zeile löschen";
						case RadGridStringId.EditMenuItem:
							return "Bearbeiten";
						case RadGridStringId.FilterFunctionBetween:
							return "Zwischen...";
						case RadGridStringId.FilterFunctionContains:
							return "Enthält...";
						case RadGridStringId.FilterFunctionCustom:
							return "Benutzerdefinierter Filter";
						case RadGridStringId.FilterFunctionDoesNotContain:
							return "Enthält nicht...";
						case RadGridStringId.FilterFunctionEndsWith:
							return "Endet mit...";
						case RadGridStringId.FilterFunctionEqualTo:
							return "Ist gleich...";
						case RadGridStringId.FilterFunctionGreaterThan:
							return "Größer als...";
						case RadGridStringId.FilterFunctionGreaterThanOrEqualTo:
							return "Größer oder gleich...";
						case RadGridStringId.FilterFunctionIsEmpty:
							return "Ist leer...";
						case RadGridStringId.FilterFunctionIsNull:
							return "Ist null...";
						case RadGridStringId.FilterFunctionLessThan:
							return "Kleiner als...";
						case RadGridStringId.FilterFunctionLessThanOrEqualTo:
							return "Kleiner oder gleich...";
						case RadGridStringId.FilterFunctionNoFilter:
							return "Kein Filter";
						case RadGridStringId.FilterFunctionNotBetween:
							return "Nicht zwischen...";
						case RadGridStringId.FilterFunctionNotEqualTo:
							return "Ist nicht gleich...";
						case RadGridStringId.FilterFunctionNotIsEmpty:
							return "Ist nicht leer...";
						case RadGridStringId.FilterFunctionNotIsNull:
							return "Ist nicht null...";
						case RadGridStringId.FilterFunctionStartsWith:
							return "Beginnt mit...";
						case RadGridStringId.GroupByThisColumnMenuItem:
							return "Nach dieser Spalte gruppieren";
						case RadGridStringId.GroupingPanelDefaultMessage:
							return "Ziehen Sie eine Spalte hierhin, um nach dieser Spalte zu gruppieren";
						case RadGridStringId.HideMenuItem:
							return "Spalte ausblenden";
						case RadGridStringId.NoDataText:
							return "Keine Daten vorhanden";
						case RadGridStringId.PasteMenuItem:
							return "Einfügen";
						case RadGridStringId.PinMenuItem:
							return "Spalte fixieren";
						case RadGridStringId.SortAscendingMenuItem:
							return "Sortieren in aufsteigender Reihenfolge";
						case RadGridStringId.SortDescendingMenuItem:
							return "Sortieren in absteigender Reihenfolge";
						case RadGridStringId.UngroupThisColumn:
							return "Gruppierung entfernen";
						case RadGridStringId.UnpinMenuItem:
							return "Fixierung aufheben";
					}
					#endregion
					break;
				case 1033:
				//English
				default:
					//Others
					break;
			}
			//Returns null when language not overriden or when string not translated
			return null;
		}
	}
}
