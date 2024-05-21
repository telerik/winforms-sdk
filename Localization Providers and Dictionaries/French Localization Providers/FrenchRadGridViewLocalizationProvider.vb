Imports Telerik.WinControls.UI.Localization

Namespace Localization

    Public Class FrenchRadGridViewLocalizationProvider
        Inherits RadGridLocalizationProvider

        Public Overrides Function GetLocalizedString(id As String) As String
        Select Case id
            Case RadGridStringId.ConditionalFormattingPleaseSelectValidCellValue
                Return "Veuillez sélectionner une valeur de cellule valide"
            Case RadGridStringId.ConditionalFormattingPleaseSetValidCellValue
                Return "Veuillez définir une valeur de cellule valide"
            Case RadGridStringId.ConditionalFormattingPleaseSetValidCellValues
                Return "Veuillez définir une valeur de cellule valide"
            Case RadGridStringId.ConditionalFormattingPleaseSetValidExpression
                Return "Veuillez définir une expression valide"
            Case RadGridStringId.ConditionalFormattingItem
                Return "Elément"
            Case RadGridStringId.ConditionalFormattingInvalidParameters
                Return "Paramètres invalides"
            Case RadGridStringId.FilterFunctionBetween
                Return "Entre"
            Case RadGridStringId.FilterFunctionContains
                Return "Contient"
            Case RadGridStringId.FilterFunctionDoesNotContain
                Return "Ne contient pas"
            Case RadGridStringId.FilterFunctionEndsWith
                Return "Se termine par"
            Case RadGridStringId.FilterFunctionEqualTo
                Return "Egal à"
            Case RadGridStringId.FilterFunctionGreaterThan
                Return "Supérieur à"
            Case RadGridStringId.FilterFunctionGreaterThanOrEqualTo
                Return "Supérieur ou égal à"
            Case RadGridStringId.FilterFunctionIsEmpty
                Return "Est vide"
            Case RadGridStringId.FilterFunctionIsNull
                Return "Est nul"
            Case RadGridStringId.FilterFunctionLessThan
                Return "Inférieur à"
            Case RadGridStringId.FilterFunctionLessThanOrEqualTo
                Return "Inférieur ou égal à"
            Case RadGridStringId.FilterFunctionNoFilter
                Return "Sans filtre"
            Case RadGridStringId.FilterFunctionNotBetween
                Return "Pas entre"
            Case RadGridStringId.FilterFunctionNotEqualTo
                Return "Non égal à"
            Case RadGridStringId.FilterFunctionNotIsEmpty
                Return "Non pas vide"
            Case RadGridStringId.FilterFunctionNotIsNull
                Return "Non nul"
            Case RadGridStringId.FilterFunctionStartsWith
                Return "Commence par"
            Case RadGridStringId.FilterFunctionCustom
                Return "Personnalisé"
            Case RadGridStringId.FilterOperatorBetween
                Return "Entre"
            Case RadGridStringId.FilterOperatorContains
                Return "Contient"
            Case RadGridStringId.FilterOperatorDoesNotContain
                Return "Ne contient pas"
            Case RadGridStringId.FilterOperatorEndsWith
                Return "Se termine par"
            Case RadGridStringId.FilterOperatorEqualTo
                Return "Egal à"
            Case RadGridStringId.FilterOperatorGreaterThan
                Return "Supérieur à"
            Case RadGridStringId.FilterOperatorGreaterThanOrEqualTo
                Return "Supérieur ou égal à"
            Case RadGridStringId.FilterOperatorIsEmpty
                Return "Est vide"
            Case RadGridStringId.FilterOperatorIsNull
                Return "Est nul"
            Case RadGridStringId.FilterOperatorLessThan
                Return "Inférieur à"
            Case RadGridStringId.FilterOperatorLessThanOrEqualTo
                Return "Inférieur ou égal à"
            Case RadGridStringId.FilterOperatorNoFilter
                Return "Sans filtre"
            Case RadGridStringId.FilterOperatorNotBetween
                Return "Pas entre"
            Case RadGridStringId.FilterOperatorNotEqualTo
                Return "Non égal à"
            Case RadGridStringId.FilterOperatorNotIsEmpty
                Return "Non vide"
            Case RadGridStringId.FilterOperatorNotIsNull
                Return "Non nul"
            Case RadGridStringId.FilterOperatorStartsWith
                Return "Commence par"
            Case RadGridStringId.FilterOperatorIsLike
                Return "Comme"
            Case RadGridStringId.FilterOperatorNotIsLike
                Return "Pas comme"
            Case RadGridStringId.FilterOperatorIsContainedIn
                Return "Contenu dans"
            Case RadGridStringId.FilterOperatorNotIsContainedIn
                Return "Non Contenu dans"
            Case RadGridStringId.FilterOperatorCustom
                Return "Personnalise"
            Case RadGridStringId.CustomFilterMenuItem
                Return "Personnalise"
            Case RadGridStringId.CustomFilterDialogCaption
                Return "Boîte de dialogue RadGridView Filter [{0}]"
            Case RadGridStringId.CustomFilterDialogLabel
                Return "Afficher les lignes où:"
            Case RadGridStringId.CustomFilterDialogRbAnd
                Return "Et"
            Case RadGridStringId.CustomFilterDialogRbOr
                Return "Ou"
            Case RadGridStringId.CustomFilterDialogBtnOk
                Return "OK"
            Case RadGridStringId.CustomFilterDialogBtnCancel
                Return "Annuler"
            Case RadGridStringId.CustomFilterDialogCheckBoxNot
                Return "Non"
            Case RadGridStringId.CustomFilterDialogTrue
                Return "Vrai"
            Case RadGridStringId.CustomFilterDialogFalse
                Return "Faux"
            Case RadGridStringId.FilterMenuBlanks
                Return "Vide"
            Case RadGridStringId.FilterMenuAvailableFilters
                Return "Filtre disponible"
            Case RadGridStringId.FilterMenuSearchBoxText
                Return "Rechercher..."
            Case RadGridStringId.FilterMenuClearFilters
                Return "Effacer le filtre"
            Case RadGridStringId.FilterMenuButtonOK
                Return "OK"
            Case RadGridStringId.FilterMenuButtonCancel
                Return "Annuler"
            Case RadGridStringId.FilterMenuSelectionAll
                Return "Tous"
            Case RadGridStringId.FilterMenuSelectionAllSearched
                Return "Tous les résultats"
            Case RadGridStringId.FilterMenuSelectionNull
                Return "Nul"
            Case RadGridStringId.FilterMenuSelectionNotNull
                Return "Non nul"
            Case RadGridStringId.FilterFunctionSelectedDates
                Return "Filtre par date:"
            Case RadGridStringId.FilterFunctionToday
                Return "Aujourd'hui"
            Case RadGridStringId.FilterFunctionYesterday
                Return "Hier"
            Case RadGridStringId.FilterFunctionDuringLast7days
                Return "Durant les 7 derniers jours"
            Case RadGridStringId.FilterLogicalOperatorAnd
                Return "ET"
            Case RadGridStringId.FilterLogicalOperatorOr
                Return "OU"
            Case RadGridStringId.FilterCompositeNotOperator
                Return "NON"
            Case RadGridStringId.DeleteRowMenuItem
                Return "Supprimer ligne"
            Case RadGridStringId.SortAscendingMenuItem
                Return "Tri croissant"
            Case RadGridStringId.SortDescendingMenuItem
                Return "Tri décroissant"
            Case RadGridStringId.ClearSortingMenuItem
                Return "Supprimer tri"
            Case RadGridStringId.ConditionalFormattingMenuItem
                Return "Mise en forme conditionnelle"
            Case RadGridStringId.GroupByThisColumnMenuItem
                Return "Grouper par cette colonne"
            Case RadGridStringId.UngroupThisColumn
                Return "Arrêtez Grouper par cette colonne"
            Case RadGridStringId.ColumnChooserMenuItem
                Return "Sélecteur de colonnes"
            Case RadGridStringId.HideMenuItem
                Return "Masquer la colonne"
            Case RadGridStringId.HideGroupMenuItem
                Return "Masquer le groupe"
            Case RadGridStringId.UnpinMenuItem
                Return "Détacher la colonne"
            Case RadGridStringId.UnpinRowMenuItem
                Return "Détacher la ligne"
            Case RadGridStringId.PinMenuItem
                Return "Etat épinglé"
            Case RadGridStringId.PinAtLeftMenuItem
                Return "Epingler à gauche"
            Case RadGridStringId.PinAtRightMenuItem
                Return "Epingler à droite"
            Case RadGridStringId.PinAtBottomMenuItem
                Return "Epingler en bas"
            Case RadGridStringId.PinAtTopMenuItem
                Return "Epingler en haut"
            Case RadGridStringId.BestFitMenuItem
                Return "Meilleur ajustement"
            Case RadGridStringId.PasteMenuItem
                Return "Coller"
            Case RadGridStringId.EditMenuItem
                Return "Modifier"
            Case RadGridStringId.ClearValueMenuItem
                Return "Vider valeur"
            Case RadGridStringId.CopyMenuItem
                Return "Copier"
            Case RadGridStringId.CutMenuItem
                Return "Couper"
            Case RadGridStringId.AddNewRowString
                Return "Cliquez ici pour ajouter une nouvelle ligne"
            Case RadGridStringId.SearchRowResultsOfLabel
                Return "de"
            Case RadGridStringId.SearchRowMatchCase
                Return "Cas de correspondance"
            Case RadGridStringId.ConditionalFormattingSortAlphabetically
                Return "Trier les colonnes par ordre alphabétique"
            Case RadGridStringId.ConditionalFormattingCaption
                Return "Gestionnaire de règles de mise en forme conditionnelle"
            Case RadGridStringId.ConditionalFormattingLblColumn
                Return "Formater uniquement les cellules avec"
            Case RadGridStringId.ConditionalFormattingLblName
                Return "Nom de la règle"
            Case RadGridStringId.ConditionalFormattingLblType
                Return "Valeur de la cellule"
            Case RadGridStringId.ConditionalFormattingLblValue1
                Return "Valeur 1"
            Case RadGridStringId.ConditionalFormattingLblValue2
                Return "Valueur 2"
            Case RadGridStringId.ConditionalFormattingGrpConditions
                Return "Règles"
            Case RadGridStringId.ConditionalFormattingGrpProperties
                Return "Propriétés de la règle"
            Case RadGridStringId.ConditionalFormattingChkApplyToRow
                Return "Appliquer cette mise en forme à toute la ligne"
            Case RadGridStringId.ConditionalFormattingChkApplyOnSelectedRows
                Return "Appliquer cette mise en forme si la ligne est sélectionnée"
            Case RadGridStringId.ConditionalFormattingBtnAdd
                Return "Ajouter une règle"
            Case RadGridStringId.ConditionalFormattingBtnRemove
                Return "Supprimer"
            Case RadGridStringId.ConditionalFormattingBtnOK
                Return "OK"
            Case RadGridStringId.ConditionalFormattingBtnCancel
                Return "Annuler"
            Case RadGridStringId.ConditionalFormattingBtnApply
                Return "Appliquer"
            Case RadGridStringId.ConditionalFormattingRuleAppliesOn
                Return "La règle s'applique à"
            Case RadGridStringId.ConditionalFormattingCondition
                Return "Condition"
            Case RadGridStringId.ConditionalFormattingExpression
                Return "Expression"
            Case RadGridStringId.ConditionalFormattingChooseOne
                Return "[Choisissez-en un]"
            Case RadGridStringId.ConditionalFormattingEqualsTo
                Return "Équivaut à [Value1]"
            Case RadGridStringId.ConditionalFormattingIsNotEqualTo
                Return "N'est pas égal à [Value1]"
            Case RadGridStringId.ConditionalFormattingStartsWith
                Return "Commence par [Value1]"
            Case RadGridStringId.ConditionalFormattingEndsWith
                Return "Se termine par [Value1]"
            Case RadGridStringId.ConditionalFormattingContains
                Return "Continet [Value1]"
            Case RadGridStringId.ConditionalFormattingDoesNotContain
                Return "Ne contient pas [Value1]"
            Case RadGridStringId.ConditionalFormattingIsGreaterThan
                Return "Est supérieur à [Value1]"
            Case RadGridStringId.ConditionalFormattingIsGreaterThanOrEqual
                Return "Est supérieur ou égal à [Valeur1]"
            Case RadGridStringId.ConditionalFormattingIsLessThan
                Return "Est inférieur à [Value1]"
            Case RadGridStringId.ConditionalFormattingIsLessThanOrEqual
                Return "Est inférieur ou égal à [Valeur1]"
            Case RadGridStringId.ConditionalFormattingIsBetween
                Return "Est entre [Value1] et [Value2]"
            Case RadGridStringId.ConditionalFormattingIsNotBetween
                Return "N'est pas entre [Value1] et [Value1]"
            Case RadGridStringId.ConditionalFormattingLblFormat
                Return "Format"
            Case RadGridStringId.ConditionalFormattingBtnExpression
                Return "Editeur d'expression"
            Case RadGridStringId.ConditionalFormattingTextBoxExpression
                Return "Expression"
            Case RadGridStringId.ConditionalFormattingPropertyGridCaseSensitive
                Return "Sensible aux majuscules et minuscules"
            Case RadGridStringId.ConditionalFormattingPropertyGridCellBackColor
                Return "Couleur de fond cellule"
            Case RadGridStringId.ConditionalFormattingPropertyGridCellForeColor
                Return "Couleur de texte cellule"
            Case RadGridStringId.ConditionalFormattingPropertyGridEnabled
                Return "Actif"
            Case RadGridStringId.ConditionalFormattingPropertyGridRowBackColor
                Return "Couleur fond ligne"
            Case RadGridStringId.ConditionalFormattingPropertyGridRowForeColor
                Return "Couleuyr texte ligne"
            Case RadGridStringId.ConditionalFormattingPropertyGridRowTextAlignment
                Return "Alignement texte ligne"
            Case RadGridStringId.ConditionalFormattingPropertyGridTextAlignment
                Return "Alignement texte"
            Case RadGridStringId.ConditionalFormattingPropertyGridCaseSensitiveDescription
                Return "Détermine si des comparaisons sensibles à la casse seront effectuées lors de l'évaluation des valeurs de chaîne."
            Case RadGridStringId.ConditionalFormattingPropertyGridCellBackColorDescription
                Return "Entrez la couleur d'arrière-plan à utiliser pour la cellule."
            Case RadGridStringId.ConditionalFormattingPropertyGridCellForeColorDescription
                Return "Entrez la couleur de premier plan à utiliser pour la cellule."
            Case RadGridStringId.ConditionalFormattingPropertyGridEnabledDescription
                Return "Détermine si la condition est activée (peut être évaluée et appliquée)."
            Case RadGridStringId.ConditionalFormattingPropertyGridRowBackColorDescription
                Return "Entrez la couleur d'arrière-plan à utiliser pour la ligne entière."
            Case RadGridStringId.ConditionalFormattingPropertyGridRowForeColorDescription
                Return "Entrez la couleur de premier plan à utiliser pour la ligne entière."
            Case RadGridStringId.ConditionalFormattingPropertyGridRowTextAlignmentDescription
                Return "Entrez l'alignement à utiliser pour les valeurs de cellule, lorsque ApplyToRow est true."
            Case RadGridStringId.ConditionalFormattingPropertyGridTextAlignmentDescription
                Return "Entrez l'alignement à utiliser pour les valeurs de cellule."
            Case RadGridStringId.ColumnChooserFormCaption
                Return "Sélecteur de colonnes"
            Case RadGridStringId.ColumnChooserFormMessage
                Return "Faites glisser un en-tête de colonne" & vbLf & "ici pour l'enlever de" & vbLf & "la vue actuelle."
            Case RadGridStringId.GroupingPanelDefaultMessage
                Return "Déposer une colonne ici pour grouper selon cette colonne."
            Case RadGridStringId.GroupingPanelHeader
                Return "Groupé par:"
            Case RadGridStringId.PagingPanelPagesLabel
                Return "Page"
            Case RadGridStringId.PagingPanelOfPagesLabel
                Return "de"
            Case RadGridStringId.NoDataText
                Return "Aucune donnée à afficher"
            Case RadGridStringId.CompositeFilterFormErrorCaption
                Return "Erreur de filtre"
            Case RadGridStringId.CompositeFilterFormInvalidFilter
                Return "Le descripteur de filtre composite n'est pas valide."
            Case RadGridStringId.ExpressionMenuItem
                Return "Expression"
            Case RadGridStringId.ExpressionFormTitle
                Return "Expression Builder"
            Case RadGridStringId.ExpressionFormFunctions
                Return "Fonctions"
            Case RadGridStringId.ExpressionFormFunctionsText
                Return "Text"
            Case RadGridStringId.ExpressionFormFunctionsAggregate
                Return "Aggrégé"
            Case RadGridStringId.ExpressionFormFunctionsDateTime
                Return "Date"
            Case RadGridStringId.ExpressionFormFunctionsLogical
                Return "Logique"
            Case RadGridStringId.ExpressionFormFunctionsMath
                Return "Math"
            Case RadGridStringId.ExpressionFormFunctionsOther
                Return "Sinon"
            Case RadGridStringId.ExpressionFormOperators
                Return "Operateurs"
            Case RadGridStringId.ExpressionFormConstants
                Return "Constantes"
            Case RadGridStringId.ExpressionFormFields
                Return "Champss"
            Case RadGridStringId.ExpressionFormDescription
                Return "Description"
            Case RadGridStringId.ExpressionFormResultPreview
                Return "Aperçu des résultats"
            Case RadGridStringId.ExpressionFormTooltipPlus
                Return "Plus"
            Case RadGridStringId.ExpressionFormTooltipMinus
                Return "Moins"
            Case RadGridStringId.ExpressionFormTooltipMultiply
                Return "Multiplier"
            Case RadGridStringId.ExpressionFormTooltipDivide
                Return "Diviser"
            Case RadGridStringId.ExpressionFormTooltipModulo
                Return "Modulo"
            Case RadGridStringId.ExpressionFormTooltipEqual
                Return "Egal"
            Case RadGridStringId.ExpressionFormTooltipNotEqual
                Return "Non égal"
            Case RadGridStringId.ExpressionFormTooltipLess
                Return "Moins"
            Case RadGridStringId.ExpressionFormTooltipLessOrEqual
                Return "Inférieur ou égal"
            Case RadGridStringId.ExpressionFormTooltipGreaterOrEqual
                Return "Supérieur ou égal"
            Case RadGridStringId.ExpressionFormTooltipGreater
                Return "Supérieur"
            Case RadGridStringId.ExpressionFormTooltipAnd
                Return "Logical ""AND"""
            Case RadGridStringId.ExpressionFormTooltipOr
                Return "Logical ""OR"""
            Case RadGridStringId.ExpressionFormTooltipNot
                Return "Logical ""NOT"""
            Case RadGridStringId.ExpressionFormAndButton
                Return String.Empty
                'if empty, default button image is used
            Case RadGridStringId.ExpressionFormOrButton
                Return String.Empty
                'if empty, default button image is used
            Case RadGridStringId.ExpressionFormNotButton
                Return String.Empty
                'if empty, default button image is used
            Case RadGridStringId.ExpressionFormOKButton
                Return "OK"
            Case RadGridStringId.ExpressionFormCancelButton
                Return "Annuler"
        End Select
        Return String.Empty
    End Function

    End Class
End Namespace