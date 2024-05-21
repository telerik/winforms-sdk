Imports Telerik.WinControls.UI
 
Class MyPrintDialogsLocalizationProvider
    Inherits Telerik.WinControls.UI.PrintDialogsLocalizationProvider
    Public Overrides Function GetLocalizedString(id As String) As String
        Select Case id
            Case PrintDialogsStringId.PreviewDialogTitle
                Return "Vista previa de impresión"
            Case PrintDialogsStringId.PreviewDialogPrint
                Return "Imprimir..."
            Case PrintDialogsStringId.PreviewDialogPrintSettings
                Return "Propiedades de impresión..."
            Case PrintDialogsStringId.PreviewDialogWatermark
                Return "Marca de agua..."
            Case PrintDialogsStringId.PreviewDialogPreviousPage
                Return "Página anterior"
            Case PrintDialogsStringId.PreviewDialogNextPage
                Return "Página siguiente"
            Case PrintDialogsStringId.PreviewDialogZoomIn
                Return "Acercar"
            Case PrintDialogsStringId.PreviewDialogZoomOut
                Return "Alejar"
            Case PrintDialogsStringId.PreviewDialogZoom
                Return "Ampliar"
            Case PrintDialogsStringId.PreviewDialogAuto
                Return "Automatico"
            Case PrintDialogsStringId.PreviewDialogLayout
                Return " Diseño"
            Case PrintDialogsStringId.PreviewDialogFile
                Return "Archivo"
            Case PrintDialogsStringId.PreviewDialogView
                Return "Ver"
            Case PrintDialogsStringId.PreviewDialogTools
                Return "Herramientas"
            Case PrintDialogsStringId.PreviewDialogExit
                Return "Salir"
            Case PrintDialogsStringId.PreviewDialogStripTools
                Return "Herramientas"
            Case PrintDialogsStringId.PreviewDialogStripNavigation
                Return "Navegacion" 
 
            Case PrintDialogsStringId.WatermarkDialogTitle
                Return "Propiedades de la marca de agua"
            Case PrintDialogsStringId.WatermarkDialogButtonOK
                Return "Aceptar"
            Case PrintDialogsStringId.WatermarkDialogButtonCancel
                Return "Cancelar"
            Case PrintDialogsStringId.WatermarkDialogLabelPreview
                Return "Previsualizar"
            Case PrintDialogsStringId.WatermarkDialogButtonRemove
                Return "Remover marca de agua"
            Case PrintDialogsStringId.WatermarkDialogLabelPosition
                Return "Posision"
            Case PrintDialogsStringId.WatermarkDialogRadioInFront
                Return "Enfrente"
            Case PrintDialogsStringId.WatermarkDialogRadioBehind
                Return "Detras"
            Case PrintDialogsStringId.WatermarkDialogLabelPageRange
                Return "intervalo de página"
            Case PrintDialogsStringId.WatermarkDialogRadioAll
                Return "Todo"
            Case PrintDialogsStringId.WatermarkDialogRadioPages
                Return "Páginas"
            Case PrintDialogsStringId.WatermarkDialogLabelPagesDescription
                Return "(Ejemplo 1,3,5-12)"
            Case PrintDialogsStringId.WatermarkDialogTabText
                Return "Texto"
            Case PrintDialogsStringId.WatermarkDialogTabPicture
                Return "Imagen"
            Case PrintDialogsStringId.WatermarkDialogLabelText
                Return "Texto"
            Case PrintDialogsStringId.WatermarkDialogWatermarkText
                Return "Texto de marca de agua"
            Case PrintDialogsStringId.WatermarkDialogLabelHOffset
                Return "Horizontal ofset"
            Case PrintDialogsStringId.WatermarkDialogLabelVOffset
                Return "Vertical ofset"
            Case PrintDialogsStringId.WatermarkDialogLabelRotation
                Return "Rotacion"
            Case PrintDialogsStringId.WatermarkDialogLabelFont
                Return "Fuente:"
            Case PrintDialogsStringId.WatermarkDialogLabelSize
                Return "Tamaño:"
            Case PrintDialogsStringId.WatermarkDialogLabelColor
                Return "Color:"
            Case PrintDialogsStringId.WatermarkDialogLabelOpacity
                Return "Transparencia:"
            Case PrintDialogsStringId.WatermarkDialogLabelLoadImage
                Return "Cargar imagen:"
            Case PrintDialogsStringId.WatermarkDialogCheckboxTiling
                Return "Azulejos" 
 
            Case PrintDialogsStringId.SettingDialogTitle
                Return "Propiedades de imprecion"
            Case PrintDialogsStringId.SettingDialogButtonPrint
                Return "Imprimir"
            Case PrintDialogsStringId.SettingDialogButtonPreview
                Return "Previsualizar"
            Case PrintDialogsStringId.SettingDialogButtonCancel
                Return "Cancelar"
            Case PrintDialogsStringId.SettingDialogButtonOK
                Return "Aceptar"
            Case PrintDialogsStringId.SettingDialogPageFormat
                Return "Formato"
            Case PrintDialogsStringId.SettingDialogPagePaper
                Return "Papel"
            Case PrintDialogsStringId.SettingDialogPageHeaderFooter
                Return " Cabecera/Pie de página"
            Case PrintDialogsStringId.SettingDialogButtonPageNumber
                Return "Numero de página"
            Case PrintDialogsStringId.SettingDialogButtonTotalPages
                Return "Total de páginas"
            Case PrintDialogsStringId.SettingDialogButtonCurrentDate
                Return "Fecha actual"
            Case PrintDialogsStringId.SettingDialogButtonCurrentTime
                Return "Hora actual"
            Case PrintDialogsStringId.SettingDialogButtonUserName
                Return "Nombre de usuario"
            Case PrintDialogsStringId.SettingDialogButtonFont
                Return "Fuente..."
            Case PrintDialogsStringId.SettingDialogLabelHeader
                Return "Cabecera"
            Case PrintDialogsStringId.SettingDialogLabelFooter
                Return "Pie de página"
            Case PrintDialogsStringId.SettingDialogCheckboxReverse
                Return " Invertir en páginas pares"
            Case PrintDialogsStringId.SettingDialogLabelPage
                Return "Página"
            Case PrintDialogsStringId.SettingDialogLabelType
                Return "Escribir"
            Case PrintDialogsStringId.SettingDialogLabelPageSource
                Return "Página fuente"
            Case PrintDialogsStringId.SettingDialogLabelMargins
                Return "Margenes (pulgadas)"
            Case PrintDialogsStringId.SettingDialogLabelOrientation
                Return "Orientacion"
            Case PrintDialogsStringId.SettingDialogLabelTop
                Return "Arriba:"
            Case PrintDialogsStringId.SettingDialogLabelBottom
                Return "Abajo:"
            Case PrintDialogsStringId.SettingDialogLabelLeft
                Return "Izq.:"
            Case PrintDialogsStringId.SettingDialogLabelRight
                Return "Der.:"
            Case PrintDialogsStringId.SettingDialogRadioPortrait
                Return "Retrato"
            Case PrintDialogsStringId.SettingDialogRadioLandscape
                Return "Paisaje" 
 
            Case PrintDialogsStringId.SchedulerSettingsLabelPrintStyle
                Return "Estilo de impresión"
            Case PrintDialogsStringId.SchedulerSettingsDailyStyle
                Return "Estilo Diario"
            Case PrintDialogsStringId.SchedulerSettingsWeeklyStyle
                Return "Estilo semanal"
            Case PrintDialogsStringId.SchedulerSettingsMonthlyStyle
                Return "Estilo mensual"
            Case PrintDialogsStringId.SchedulerSettingsDetailStyle
                Return "Detalles de estilo"
            Case PrintDialogsStringId.SchedulerSettingsButtonWatermark
                Return "Marca de agua..."
            Case PrintDialogsStringId.SchedulerSettingsButtonFont
                Return "Fuente..."
            Case PrintDialogsStringId.SchedulerSettingsLabelPrintRange
                Return " intervalo de impresión"
            Case PrintDialogsStringId.SchedulerSettingsLabelStyleSettings
                Return "Ajustes de estilo"
            Case PrintDialogsStringId.SchedulerSettingsLabelPrintSettings
                Return "Propiedades de impresión"
            Case PrintDialogsStringId.SchedulerSettingsLabelStartDate
                Return "Fecha de inicio"
            Case PrintDialogsStringId.SchedulerSettingsLabelEndDate
                Return "Fecha de fin"
            Case PrintDialogsStringId.SchedulerSettingsLabelStartTime
                Return "Hora de inicio"
            Case PrintDialogsStringId.SchedulerSettingsLabelEndTime
                Return "Hora de fin"
            Case PrintDialogsStringId.SchedulerSettingsLabelDateFont
                Return "Fuente de la fecha del encabezado"
            Case PrintDialogsStringId.SchedulerSettingsLabelAppointmentFont
                Return "Fuente de cita"
            Case PrintDialogsStringId.SchedulerSettingsLabelLayout
                Return "Diseño"
            Case PrintDialogsStringId.SchedulerSettingsPrintPageTitle
                Return "Imprimir título de la página"
            Case PrintDialogsStringId.SchedulerSettingsPrintCalendar
                Return "Incluir calendario en el título"
            Case PrintDialogsStringId.SchedulerSettingsPrintTimezone
                Return "Imprimir la zona horaria seleccionada"
            Case PrintDialogsStringId.SchedulerSettingsPrintNotesBlank
                Return "Área de notas (en blanco)"
            Case PrintDialogsStringId.SchedulerSettingsPrintNotesLined
                Return "Área de notas (alineado)"
            Case PrintDialogsStringId.SchedulerSettingsNonworkingDays
                Return "Excluir días no laborables"
            Case PrintDialogsStringId.SchedulerSettingsExactlyOneMonth
                Return "Imprimir exactamente un mes"
            Case PrintDialogsStringId.SchedulerSettingsLabelWeeksPerPage
                Return "Semana por página"
            Case PrintDialogsStringId.SchedulerSettingsNewPageEach
                Return "Comenzar una nueva página cada"
            Case PrintDialogsStringId.SchedulerSettingsStringDay
                Return "Dia"
            Case PrintDialogsStringId.SchedulerSettingsStringMonth
                Return "Mes"
            Case PrintDialogsStringId.SchedulerSettingsStringWeek
                Return "Semana"
            Case PrintDialogsStringId.SchedulerSettingsStringPage
                Return "Página"
            Case PrintDialogsStringId.SchedulerSettingsStringPages
                Return "Páginas"
            Case PrintDialogsStringId.SchedulerSettingsLabelGroupBy
                Return "Agrupar por:"
            Case PrintDialogsStringId.SchedulerSettingsGroupByNone
                Return "Ninguno"
            Case PrintDialogsStringId.SchedulerSettingsGroupByResource
                Return "Recurso"
            Case PrintDialogsStringId.SchedulerSettingsGroupByDate
                Return "Fecha"
 
            Case PrintDialogsStringId.GridSettingsLabelPreview
                Return "Previsualizacion"
            Case PrintDialogsStringId.GridSettingsLabelStyleSettings
                Return "Propiedades de estilo"
            Case PrintDialogsStringId.GridSettingsLabelFitMode
                Return "Modo de ajuste de página:"
            Case PrintDialogsStringId.GridSettingsLabelHeaderCells
                Return "Celdas de encabezado"
            Case PrintDialogsStringId.GridSettingsLabelGroupCells
                Return "Agrupar celdas"
            Case PrintDialogsStringId.GridSettingsLabelDataCells
                Return "Datos de celdas"
            Case PrintDialogsStringId.GridSettingsLabelSummaryCells
                Return "Resumen de celdas"
            Case PrintDialogsStringId.GridSettingsLabelBackground
                Return "Fondo"
            Case PrintDialogsStringId.GridSettingsLabelBorderColor
                Return "Color de borde"
            Case PrintDialogsStringId.GridSettingsLabelAlternatingRowColor
                Return "Alternar color de filas"
            Case PrintDialogsStringId.GridSettingsLabelPadding
                Return "Configuración de relleno de fuente"
            Case PrintDialogsStringId.GridSettingsPrintGrouping
                Return "Imprimir agrupación"
            Case PrintDialogsStringId.GridSettingsPrintSummaries
                Return "Imprimir resumenes"
            Case PrintDialogsStringId.GridSettingsPrintHiddenRows
                Return "Imprimir filas ocultas"
            Case PrintDialogsStringId.GridSettingsPrintHiddenColumns
                Return "Imprimir columnas ocultas"
            Case PrintDialogsStringId.GridSettingsPrintHeader
                Return "Imprimir encabezado en cada página"
            Case PrintDialogsStringId.GridSettingsButtonWatermark
                Return "Marca de agua..."
            Case PrintDialogsStringId.GridSettingsButtonFont
                Return "Fuente..."
            Case PrintDialogsStringId.GridSettingsFitPageWidth
                Return "Ajustar al ancho de página"
            Case PrintDialogsStringId.GridSettingsNoFit
                Return "No ajustar"
            Case PrintDialogsStringId.GridSettingsNoFitCentered
                Return "No ajustar al centro"
            Case PrintDialogsStringId.GridSettingsLabelPrint
                Return "Imprimir"
        End Select
 
 
        'PrintDialogsLocalizationProvider.CurrentProvider = New MyPrintDialogsLocalizationProvider()
 
        Return [String].Empty
    End Function
End Class