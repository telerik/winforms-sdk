using Telerik.WinControls.UI.Localization;

namespace TheNameSpacePdfViewer
{
    // Use: PdfViewerLocalizationProvider.CurrentProvider = new PdfLocalizationProvider();

    public class PdfLocalizationProvider : PdfViewerLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {

            switch (id)
            {
                case PdfViewerStringId.PrintPreviewGroupBoxPreview:
                    return "Visualizar";
                case PdfViewerStringId.PrintPreviewGroupBoxOrientation:
                    return "Orientação";
                case PdfViewerStringId.PrintPreviewGroupBoxSettings:
                    return "Config.";// "Settings";
                case PdfViewerStringId.PrintPreviewButtonPrint:
                    return "Imprimir";// "Print";
                case PdfViewerStringId.PrintPreviewButtonCancel:
                    return "Cancelar";
                case PdfViewerStringId.PrintPreviewButtonWatermark:
                    return "Marca d'agua";// "Watermark";
                case PdfViewerStringId.PrintPreviewButtonSettings:
                    return "Config. Impressão"; // "Print Settings";
                case PdfViewerStringId.PrintPreviewLabelPageSizeInches:
                    return "{0:F2} x {1:F2} Polegadas";
                case PdfViewerStringId.PrintPreviewLabelPageSizeCm:
                    return "{0:F2}cm x {1:F2}cm";
                case PdfViewerStringId.PrintPreviewLabelScale:
                    return "Scala: {0}%";
                case PdfViewerStringId.PrintPreviewLabelCurrentPage:
                    return "Pagina {0} of {1}";
                case PdfViewerStringId.PrintPreviewFormTitle:
                    return "Visualizar impressão";
                case PdfViewerStringId.PrintPreviewPrintError:
                    return "Erro ao imprimir o documento!";
                case PdfViewerStringId.PrintPreviewRadioPortrait:
                    return "Retrato";
                case PdfViewerStringId.PrintPreviewRadioLandscape:
                    return "Paisagem";
                case PdfViewerStringId.NavigatorFitToWidthButton:
                    return "Ajustar largura";
                case PdfViewerStringId.NavigatorFitToPageButton:
                    return "Ajustar página inteira";
                case PdfViewerStringId.ContextMenuCopy:
                    return "&Copiar";
                case PdfViewerStringId.ContextMenuSelectAll:
                    return "Selecionar &tudo";
                case PdfViewerStringId.ContextMenuDeselectAll:
                    return "&Desmarcar tudo";
                case PdfViewerStringId.ContextMenuHand:
                    return "&Mão";
                case PdfViewerStringId.ContextMenuSelection:
                    return "&Seleção";
                case PdfViewerStringId.ContextMenuPreviousPage:
                    return "&Página Anterior";
                case PdfViewerStringId.ContextMenuNextPage:
                    return "Próxi&ma Página";
                case PdfViewerStringId.ContextMenuPrint:
                    return "Imp&rimir...";
                case PdfViewerStringId.ContextMenuFind:
                    return "&Procurar Próximo";
                case PdfViewerStringId.NavigatorOpenButton:
                    return "Abrir";
                case PdfViewerStringId.NavigatorPrintButton:
                    return "Imprimir";
                case PdfViewerStringId.NavigatorPreviousPageButton:
                    return "Página Anterior";
                case PdfViewerStringId.NavigatorNextPageButton:
                    return "Próxima página";
                case PdfViewerStringId.NavigatorCurrentPageTextBox:
                    return "Página Atual";
                case PdfViewerStringId.NavigatorTotalPagesLabel:
                    return "Total de páginas";
                case PdfViewerStringId.NavigatorZoomInButton:
                    return "Zoom in";
                case PdfViewerStringId.NavigatorZoomOutButton:
                    return "Zoom out";
                case PdfViewerStringId.NavigatorZoomDropDown:
                    return "Zoom drop-down";
                case PdfViewerStringId.NavigatorHandToolButton:
                    return "Tudo";
                case PdfViewerStringId.NavigatorSelectToolButton:
                    return "Seleção";
                case PdfViewerStringId.NavigatorFindNextButton:
                    return "Procurar próximo";
                case PdfViewerStringId.NavigatorFindPreviousButton:
                    return "Procurar anterior";
                case PdfViewerStringId.NavigatorSearchTextBox:
                    return "Buscar";

                case PdfViewerStringId.NavigatorDefaultStrip:
                    return "Padrão (strip)";
            }
            return base.GetLocalizedString(id);
        }
    }
}
