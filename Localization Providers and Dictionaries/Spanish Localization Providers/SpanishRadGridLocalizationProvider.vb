Public Class SpanishRadGridLocalizationProvider
    Inherits RadGridLocalizationProvider
 
    Public Overrides Function GetLocalizedString(id As String) As String
        Select Case id
            Case RadGridStringId.ConditionalFormattingPleaseSelectValidCellValue
                Return "Seleccione un valor válido de celda"
            Case RadGridStringId.ConditionalFormattingPleaseSetValidCellValue
                Return "Establezca un valor válido de celda"
            Case RadGridStringId.ConditionalFormattingPleaseSetValidCellValues
                Return "Establezca valores validos de celda"
            Case RadGridStringId.ConditionalFormattingPleaseSetValidExpression
                Return "Estableza una expresión valida"
            Case RadGridStringId.ConditionalFormattingItem
                Return "Item"
            Case RadGridStringId.ConditionalFormattingInvalidParameters
                Return "Parámetros no válidos"
            Case RadGridStringId.FilterFunctionBetween
                Return "Entre"
            Case RadGridStringId.FilterFunctionContains
                Return "Contiene"
            Case RadGridStringId.FilterFunctionDoesNotContain
                Return "No contiene"
            Case RadGridStringId.FilterFunctionEndsWith
                Return "Finaliza con"
            Case RadGridStringId.FilterFunctionEqualTo
                Return "Igual a"
            Case RadGridStringId.FilterFunctionGreaterThan
                Return "Mayor que"
            Case RadGridStringId.FilterFunctionGreaterThanOrEqualTo
                Return "Mayor o igual a"
            Case RadGridStringId.FilterFunctionIsEmpty
                Return "Esta vacío"
            Case RadGridStringId.FilterFunctionIsNull
                Return "Es nulo"
            Case RadGridStringId.FilterFunctionLessThan
                Return "Menor que"
            Case RadGridStringId.FilterFunctionLessThanOrEqualTo
                Return "Menor o igual que"
            Case RadGridStringId.FilterFunctionNoFilter
                Return "Sin filtro"
            Case RadGridStringId.FilterFunctionNotBetween
                Return "No entre"
            Case RadGridStringId.FilterFunctionNotEqualTo
                Return "Distinto de"
            Case RadGridStringId.FilterFunctionNotIsEmpty
                Return "No está vacío"
            Case RadGridStringId.FilterFunctionNotIsNull
                Return "No es nulo"
            Case RadGridStringId.FilterFunctionStartsWith
                Return "Comienza por"
            Case RadGridStringId.FilterFunctionCustom
                Return "Personalizado"
            Case RadGridStringId.FilterOperatorBetween
                Return "Entre"
            Case RadGridStringId.FilterOperatorContains
                Return "Contiene"
            Case RadGridStringId.FilterOperatorDoesNotContain
                Return "No contiene"
            Case RadGridStringId.FilterOperatorEndsWith
                Return "Finaliza con"
            Case RadGridStringId.FilterOperatorEqualTo
                Return "Igual"
            Case RadGridStringId.FilterOperatorGreaterThan
                Return "Mayor que"
            Case RadGridStringId.FilterOperatorGreaterThanOrEqualTo
                Return "Mayor o igual que"
            Case RadGridStringId.FilterOperatorIsEmpty
                Return "Esta vacío"
            Case RadGridStringId.FilterOperatorIsNull
                Return "Es nulo"
            Case RadGridStringId.FilterOperatorLessThan
                Return "Menor que"
            Case RadGridStringId.FilterOperatorLessThanOrEqualTo
                Return "Menor o igual que"
            Case RadGridStringId.FilterOperatorNoFilter
                Return "Sin filtro"
            Case RadGridStringId.FilterOperatorNotBetween
                Return "No entre"
            Case RadGridStringId.FilterOperatorNotEqualTo
                Return "Distinto de"
            Case RadGridStringId.FilterOperatorNotIsEmpty
                Return "No vacío"
            Case RadGridStringId.FilterOperatorNotIsNull
                Return "No nulo"
            Case RadGridStringId.FilterOperatorStartsWith
                Return "Comienza por"
            Case RadGridStringId.FilterOperatorIsLike
                Return "Como"
            Case RadGridStringId.FilterOperatorNotIsLike
                Return "No como"
            Case RadGridStringId.FilterOperatorIsContainedIn
                Return "Contenido en"
            Case RadGridStringId.FilterOperatorNotIsContainedIn
                Return "No contenido en"
            Case RadGridStringId.FilterOperatorCustom
                Return "Personalizado"
            Case RadGridStringId.CustomFilterMenuItem
                Return "Personalizado"
            Case RadGridStringId.CustomFilterDialogCaption
                Return "RadGridView Pantalla de Filtro [{0}]"
            Case RadGridStringId.CustomFilterDialogLabel
                Return "Mostrar filas donde:"
            Case RadGridStringId.CustomFilterDialogRbAnd
                Return "Y"
            Case RadGridStringId.CustomFilterDialogRbOr
                Return "O"
            Case RadGridStringId.CustomFilterDialogBtnOk
                Return "OK"
            Case RadGridStringId.CustomFilterDialogBtnCancel
                Return "Cancelar"
            Case RadGridStringId.CustomFilterDialogCheckBoxNot
                Return "No"
            Case RadGridStringId.CustomFilterDialogTrue
                Return "Verdadero"
            Case RadGridStringId.CustomFilterDialogFalse
                Return "Falso"
            Case RadGridStringId.FilterMenuBlanks
                Return "Vacío"
            Case RadGridStringId.FilterMenuAvailableFilters
                Return "Filtros disponibles"
            Case RadGridStringId.FilterMenuSearchBoxText
                Return "Buscar..."
            Case RadGridStringId.FilterMenuClearFilters
                Return "Limpiar filtro"
            Case RadGridStringId.FilterMenuButtonOK
                Return "OK"
            Case RadGridStringId.FilterMenuButtonCancel
                Return "Cancelar"
            Case RadGridStringId.FilterMenuSelectionAll
                Return "Todo"
            Case RadGridStringId.FilterMenuSelectionAllSearched
                Return "Todos los resultados"
            Case RadGridStringId.FilterMenuSelectionNull
                Return "Nulo"
            Case RadGridStringId.FilterMenuSelectionNotNull
                Return "No nulo"
            Case RadGridStringId.FilterFunctionSelectedDates
                Return "Filtro para fecha especificas:"
            Case RadGridStringId.FilterFunctionToday
                Return "Hoy"
            Case RadGridStringId.FilterFunctionYesterday
                Return "Ayer"
            Case RadGridStringId.FilterFunctionDuringLast7days
                Return "En los ultimos 7 dias"
            Case RadGridStringId.FilterLogicalOperatorAnd
                Return "AND"
            Case RadGridStringId.FilterLogicalOperatorOr
                Return "OR"
            Case RadGridStringId.FilterCompositeNotOperator
                Return "NOT"
            Case RadGridStringId.DeleteRowMenuItem
                Return "Borrar fila"
            Case RadGridStringId.SortAscendingMenuItem
                Return "Ordenar ascendente"
            Case RadGridStringId.SortDescendingMenuItem
                Return "Ordenar descendente"
            Case RadGridStringId.ClearSortingMenuItem
                Return "Limpiar clasificación"
            Case RadGridStringId.ConditionalFormattingMenuItem
                Return "Formateo condicional"
            Case RadGridStringId.GroupByThisColumnMenuItem
                Return "Agrupar por esta columna"
            Case RadGridStringId.UngroupThisColumn
                Return "Desagrupar esta columna"
            Case RadGridStringId.ColumnChooserMenuItem
                Return "Selector de columnas"
            Case RadGridStringId.HideMenuItem
                Return "Ocultar columna"
            Case RadGridStringId.HideGroupMenuItem
                Return "Ocultar grupo"
            Case RadGridStringId.UnpinMenuItem
                Return "Desanclar columna"
            Case RadGridStringId.UnpinRowMenuItem
                Return "Desanclar fila"
            Case RadGridStringId.PinMenuItem
                Return "Estado de anclado"
            Case RadGridStringId.PinAtLeftMenuItem
                Return "Anclar a la izquierda"
            Case RadGridStringId.PinAtRightMenuItem
                Return "Anclar a la derecha"
            Case RadGridStringId.PinAtBottomMenuItem
                Return "Anclar abajo"
            Case RadGridStringId.PinAtTopMenuItem
                Return "Anclar arriba"
            Case RadGridStringId.BestFitMenuItem
                Return "Mejor ajuste"
            Case RadGridStringId.PasteMenuItem
                Return "Pegar"
            Case RadGridStringId.EditMenuItem
                Return "Editar"
            Case RadGridStringId.ClearValueMenuItem
                Return "Limpiar valor"
            Case RadGridStringId.CopyMenuItem
                Return "Copiar"
            Case RadGridStringId.CutMenuItem
                Return "Cortar"
            Case RadGridStringId.AddNewRowString
                Return "Click aqui para añadir una nueva fila"
            Case RadGridStringId.ConditionalFormattingSortAlphabetically
                Return "Clasificar columnas alfabeticamente"
            Case RadGridStringId.ConditionalFormattingCaption
                Return "Gestor de reglas de formateo condicional"
            Case RadGridStringId.ConditionalFormattingLblColumn
                Return "Formatear solo celdas con"
            Case RadGridStringId.ConditionalFormattingLblName
                Return "Nombre Regla"
            Case RadGridStringId.ConditionalFormattingLblType
                Return "Valor de celda"
            Case RadGridStringId.ConditionalFormattingLblValue1
                Return "Valor 1"
            Case RadGridStringId.ConditionalFormattingLblValue2
                Return "Valor 2"
            Case RadGridStringId.ConditionalFormattingGrpConditions
                Return "Reglas"
            Case RadGridStringId.ConditionalFormattingGrpProperties
                Return "Propiedades regla"
            Case RadGridStringId.ConditionalFormattingChkApplyToRow
                Return "Aplicar este formateo a la fila completa"
            Case RadGridStringId.ConditionalFormattingChkApplyOnSelectedRows
                Return "Aplica este formateo a la fila si esta seleccionada"
            Case RadGridStringId.ConditionalFormattingBtnAdd
                Return "Añadir nueva regla"
            Case RadGridStringId.ConditionalFormattingBtnRemove
                Return "Eliminar"
            Case RadGridStringId.ConditionalFormattingBtnOK
                Return "OK"
            Case RadGridStringId.ConditionalFormattingBtnCancel
                Return "Cancelar"
            Case RadGridStringId.ConditionalFormattingBtnApply
                Return "Aplicar"
            Case RadGridStringId.ConditionalFormattingRuleAppliesOn
                Return "Regla aplicada a"
            Case RadGridStringId.ConditionalFormattingCondition
                Return "Condición"
            Case RadGridStringId.ConditionalFormattingExpression
                Return "Expresión"
            Case RadGridStringId.ConditionalFormattingChooseOne
                Return "[Seleccionar uno]"
            Case RadGridStringId.ConditionalFormattingEqualsTo
                Return "igual a [Valor1]"
            Case RadGridStringId.ConditionalFormattingIsNotEqualTo
                Return "distinto de [Valor1]"
            Case RadGridStringId.ConditionalFormattingStartsWith
                Return "comienza por [Valor1]"
            Case RadGridStringId.ConditionalFormattingEndsWith
                Return "finaliza con [Valor1]"
            Case RadGridStringId.ConditionalFormattingContains
                Return "contiene [Valor1]"
            Case RadGridStringId.ConditionalFormattingDoesNotContain
                Return "no contiene [Valor1]"
            Case RadGridStringId.ConditionalFormattingIsGreaterThan
                Return "es mayor que [Valor1]"
            Case RadGridStringId.ConditionalFormattingIsGreaterThanOrEqual
                Return "es mayor o igual que [Valor1]"
            Case RadGridStringId.ConditionalFormattingIsLessThan
                Return "es menor que [Valor1]"
            Case RadGridStringId.ConditionalFormattingIsLessThanOrEqual
                Return "es menor o igual que [Valor1]"
            Case RadGridStringId.ConditionalFormattingIsBetween
                Return "esta entre [Valor1] y [Valor2]"
            Case RadGridStringId.ConditionalFormattingIsNotBetween
                Return "no esta entre [Valor1] y [Valor2]"
            Case RadGridStringId.ConditionalFormattingLblFormat
                Return "Formato"
            Case RadGridStringId.ConditionalFormattingBtnExpression
                Return "Editor de expresiones"
            Case RadGridStringId.ConditionalFormattingTextBoxExpression
                Return "Expresión"
            Case RadGridStringId.ConditionalFormattingPropertyGridCaseSensitive
                Return "Sensible mayúsculas"
            Case RadGridStringId.ConditionalFormattingPropertyGridCellBackColor
                Return "Color fondo celda"
            Case RadGridStringId.ConditionalFormattingPropertyGridCellForeColor
                Return "Color frente celda"
            Case RadGridStringId.ConditionalFormattingPropertyGridEnabled
                Return "Activo"
            Case RadGridStringId.ConditionalFormattingPropertyGridRowBackColor
                Return "Color fondo fila"
            Case RadGridStringId.ConditionalFormattingPropertyGridRowForeColor
                Return "Color frente fila"
            Case RadGridStringId.ConditionalFormattingPropertyGridRowTextAlignment
                Return "Alineamiento texto fila"
            Case RadGridStringId.ConditionalFormattingPropertyGridTextAlignment
                Return "Alineamiento texto"
            Case RadGridStringId.ConditionalFormattingPropertyGridCaseSensitiveDescription
                Return "Determina si se tendrán en cuenta las comparaciones sensibles a mayusculas cuando se evaluen cadenas de caracteres"
            Case RadGridStringId.ConditionalFormattingPropertyGridCellBackColorDescription
                Return "Introducir color de fondo para usar con esta celda."
            Case RadGridStringId.ConditionalFormattingPropertyGridCellForeColorDescription
                Return "Introducir color frontal para usar con esta celda."
            Case RadGridStringId.ConditionalFormattingPropertyGridEnabledDescription
                Return "Determina si la condición esta activa (puede ser evaluada y aplicada)."
            Case RadGridStringId.ConditionalFormattingPropertyGridRowBackColorDescription
                Return "Introducir el color de fondo para usar en toda la fila."
            Case RadGridStringId.ConditionalFormattingPropertyGridRowForeColorDescription
                Return "Introducir el color frontal para usar en toda la fila."
            Case RadGridStringId.ConditionalFormattingPropertyGridRowTextAlignmentDescription
                Return "Introduzca la alineación para usar con los valores de las celdas, cuando ApplyToRow sea verdadero."
            Case RadGridStringId.ConditionalFormattingPropertyGridTextAlignmentDescription
                Return "Introduzca la alineación para usar con los valores de las celdas."
            Case RadGridStringId.ColumnChooserFormCaption
                Return "Selector de columnas"
            Case RadGridStringId.ColumnChooserFormMessage
                Return "Arrastrar un titulo de columna desde el" & vbLf & "grid aqui para eliminarla " & vbLf & "de la vista actual."
            Case RadGridStringId.GroupingPanelDefaultMessage
                Return "Arrastra una columna aqui para agrupar por esta columna."
            Case RadGridStringId.GroupingPanelHeader
                Return "Agrupar por:"
            Case RadGridStringId.PagingPanelPagesLabel
                Return "Página"
            Case RadGridStringId.PagingPanelOfPagesLabel
                Return "de"
            Case RadGridStringId.NoDataText
                Return "No hay información para mostrar"
            Case RadGridStringId.CompositeFilterFormErrorCaption
                Return "Error de filtro"
            Case RadGridStringId.CompositeFilterFormInvalidFilter
                Return "El descriptor de filtro compuesto no es válido."
            Case RadGridStringId.ExpressionMenuItem
                Return "Expresión"
            Case RadGridStringId.ExpressionFormTitle
                Return "Contructor de expresiones"
            Case RadGridStringId.ExpressionFormFunctions
                Return "Funciones"
            Case RadGridStringId.ExpressionFormFunctionsText
                Return "Texto"
            Case RadGridStringId.ExpressionFormFunctionsAggregate
                Return "Agregado"
            Case RadGridStringId.ExpressionFormFunctionsDateTime
                Return "Fecha-Hora"
            Case RadGridStringId.ExpressionFormFunctionsLogical
                Return "Logico"
            Case RadGridStringId.ExpressionFormFunctionsMath
                Return "Math"
            Case RadGridStringId.ExpressionFormFunctionsOther
                Return "Otros"
            Case RadGridStringId.ExpressionFormOperators
                Return "Operadores"
            Case RadGridStringId.ExpressionFormConstants
                Return "Constantes"
            Case RadGridStringId.ExpressionFormFields
                Return "Campos"
            Case RadGridStringId.ExpressionFormDescription
                Return "Descripcion"
            Case RadGridStringId.ExpressionFormResultPreview
                Return "Vista previa de resultados"
            Case RadGridStringId.ExpressionFormTooltipPlus
                Return "Sumar"
            Case RadGridStringId.ExpressionFormTooltipMinus
                Return "Restar"
            Case RadGridStringId.ExpressionFormTooltipMultiply
                Return "Multiplicar"
            Case RadGridStringId.ExpressionFormTooltipDivide
                Return "Dividir"
            Case RadGridStringId.ExpressionFormTooltipModulo
                Return "Módulo"
            Case RadGridStringId.ExpressionFormTooltipEqual
                Return "Igual"
            Case RadGridStringId.ExpressionFormTooltipNotEqual
                Return "Distinto"
            Case RadGridStringId.ExpressionFormTooltipLess
                Return "Menor"
            Case RadGridStringId.ExpressionFormTooltipLessOrEqual
                Return "Menor o igual"
            Case RadGridStringId.ExpressionFormTooltipGreaterOrEqual
                Return "Mayor o igual"
            Case RadGridStringId.ExpressionFormTooltipGreater
                Return "Mayor"
            Case RadGridStringId.ExpressionFormTooltipAnd
                Return """AND"" lógico"
            Case RadGridStringId.ExpressionFormTooltipOr
                Return """OR"" lógico"
            Case RadGridStringId.ExpressionFormTooltipNot
                Return """NOT"" lógico"
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
                Return "Cancelar"
            Case RadGridStringId.SearchRowChooseColumns
                Return "SearchRowChooseColumns"
            Case RadGridStringId.SearchRowSearchFromCurrentPosition
                Return "SearchRowSearchFromCurrentPosition"
            Case RadGridStringId.SearchRowMenuItemMasterTemplate
                Return "SearchRowMenuItemMasterTemplate"
            Case RadGridStringId.SearchRowMenuItemChildTemplates
                Return "SearchRowMenuItemChildTemplates"
            Case RadGridStringId.SearchRowMenuItemAllColumns
                Return "SearchRowMenuItemAllColumns"
            Case RadGridStringId.SearchRowTextBoxNullText
                Return "SearchRowTextBoxNullText"
            Case RadGridStringId.SearchRowResultsOfLabel
                Return "SearchRowResultsOfLabel"
            Case RadGridStringId.SearchRowMatchCase
                Return "Match case"
        End Select
        Return String.Empty
    End Function
End Class