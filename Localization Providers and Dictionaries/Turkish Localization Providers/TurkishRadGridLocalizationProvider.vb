Imports Telerik.WinControls.UI.Localization
 
Namespace TurkishRadGridViewLocalization
    Public Class TurkishRadGridLocalizationProvider
        Inherits RadGridLocalizationProvider
        Public Overrides Function GetLocalizedString(id As String) As String
            Select Case id
                Case RadGridStringId.ConditionalFormattingPleaseSelectValidCellValue
                    Return "Lütfen Geçerli Bir Hücre Seçiniz"
                Case RadGridStringId.ConditionalFormattingPleaseSetValidCellValue
                    Return "Lütfen Geçerli Bir Hücre Giriniz"
                Case RadGridStringId.ConditionalFormattingPleaseSetValidCellValues
                    Return "Lütfen Geçerli Hücreler Giriniz"
                Case RadGridStringId.ConditionalFormattingPleaseSetValidExpression
                    Return "Lütfen Geçerli bir Operatör Giriniz"
                Case RadGridStringId.ConditionalFormattingItem
                    Return "Öğe"
                Case RadGridStringId.ConditionalFormattingInvalidParameters
                    Return "Geçersiz Öğe"
 
                Case RadGridStringId.FilterFunctionBetween
                    Return "Arasında"
                Case RadGridStringId.FilterFunctionContains
                    Return "İçerir"
                Case RadGridStringId.FilterFunctionDoesNotContain
                    Return "İçermez"
                Case RadGridStringId.FilterFunctionEndsWith
                    Return "İle Biten"
                Case RadGridStringId.FilterFunctionEqualTo
                    Return "Eşittir"
                Case RadGridStringId.FilterFunctionGreaterThan
                    Return "Büyüktür"
                Case RadGridStringId.FilterFunctionGreaterThanOrEqualTo
                    Return "Büyük veya Eşit"
                Case RadGridStringId.FilterFunctionIsEmpty
                    Return "Boş ise"
                Case RadGridStringId.FilterFunctionIsNull
                    Return "Null ise"
                Case RadGridStringId.FilterFunctionLessThan
                    Return "Küçüktür"
                Case RadGridStringId.FilterFunctionLessThanOrEqualTo
                    Return "Küçük veya Eşit"
                Case RadGridStringId.FilterFunctionNoFilter
                    Return "Temizle"
                Case RadGridStringId.FilterFunctionNotBetween
                    Return "Arasında Değil"
                Case RadGridStringId.FilterFunctionNotEqualTo
                    Return "Eşit Değil"
                Case RadGridStringId.FilterFunctionNotIsEmpty
                    Return "Boş Değil"
                Case RadGridStringId.FilterFunctionNotIsNull
                    Return "Null Değil"
                Case RadGridStringId.FilterFunctionStartsWith
                    Return "İle Başlar"
                Case RadGridStringId.FilterFunctionCustom
                    Return "Özel"
 
                Case RadGridStringId.FilterOperatorBetween
                    Return "Arasında"
                Case RadGridStringId.FilterOperatorContains
                    Return "İçerir"
                Case RadGridStringId.FilterOperatorDoesNotContain
                    Return "İçermez"
                Case RadGridStringId.FilterOperatorEndsWith
                    Return "İle Biter"
                Case RadGridStringId.FilterOperatorEqualTo
                    Return "Eşittir"
                Case RadGridStringId.FilterOperatorGreaterThan
                    Return "Büyüktür"
                Case RadGridStringId.FilterOperatorGreaterThanOrEqualTo
                    Return "Büyük veya Eşit"
                Case RadGridStringId.FilterOperatorIsEmpty
                    Return "Boş ise"
                Case RadGridStringId.FilterOperatorIsNull
                    Return "Null ise"
                Case RadGridStringId.FilterOperatorLessThan
                    Return "Küçüktür"
                Case RadGridStringId.FilterOperatorLessThanOrEqualTo
                    Return "Küçük veya Eşit"
                Case RadGridStringId.FilterOperatorNoFilter
                    Return "Temizle"
                Case RadGridStringId.FilterOperatorNotBetween
                    Return "Arasında Değil"
                Case RadGridStringId.FilterOperatorNotEqualTo
                    Return "Eşit Değil"
                Case RadGridStringId.FilterOperatorNotIsEmpty
                    Return "Boş Değil"
                Case RadGridStringId.FilterOperatorNotIsNull
                    Return "Null Değil"
                Case RadGridStringId.FilterOperatorStartsWith
                    Return "İle Başlar"
                Case RadGridStringId.FilterOperatorIsLike
                    Return "Benzeyen"
                Case RadGridStringId.FilterOperatorNotIsLike
                    Return "Benzemeyen"
                Case RadGridStringId.FilterOperatorIsContainedIn
                    Return "İçinde Geçen"
                Case RadGridStringId.FilterOperatorNotIsContainedIn
                    Return "İçinde Geçmeyen"
                Case RadGridStringId.FilterOperatorCustom
                    Return "Özel"
 
                Case RadGridStringId.CustomFilterMenuItem
                    Return "Özel Filtre"
                Case RadGridStringId.CustomFilterDialogCaption
                    Return "RadGridView Filtre Ekranı [{0}]"
                Case RadGridStringId.CustomFilterDialogLabel
                    Return "Özel Filtre Seçiniz:"
                Case RadGridStringId.CustomFilterDialogRbAnd
                    Return "VE"
                Case RadGridStringId.CustomFilterDialogRbOr
                    Return "VEYA"
                Case RadGridStringId.CustomFilterDialogBtnOk
                    Return "Tamam"
                Case RadGridStringId.CustomFilterDialogBtnCancel
                    Return "Vazgeç"
                Case RadGridStringId.CustomFilterDialogCheckBoxNot
                    Return "Değil"
                Case RadGridStringId.CustomFilterDialogTrue
                    Return "Doğru"
                Case RadGridStringId.CustomFilterDialogFalse
                    Return "Yanlış"
 
                Case RadGridStringId.FilterMenuBlanks
                    Return "Boşluklar"
                Case RadGridStringId.FilterMenuAvailableFilters
                    Return "Mevcut Filtreler"
                Case RadGridStringId.FilterMenuSearchBoxText
                    Return "Ara"
                Case RadGridStringId.FilterMenuClearFilters
                    Return "Filtreleri Temizle"
                Case RadGridStringId.FilterMenuButtonOK
                    Return "Tamam"
                Case RadGridStringId.FilterMenuButtonCancel
                    Return "Vazgeç"
                Case RadGridStringId.FilterMenuSelectionAll
                    Return "Tümünü Seç"
                Case RadGridStringId.FilterMenuSelectionAllSearched
                    Return "Tümü Arandı"
                Case RadGridStringId.FilterMenuSelectionNull
                    Return "Null"
                Case RadGridStringId.FilterMenuSelectionNotNull
                    Return "Null Olmayan"
 
                Case RadGridStringId.FilterFunctionSelectedDates
                    Return "Tarih Seçimi:"
                Case RadGridStringId.FilterFunctionToday
                    Return "Bugün"
                Case RadGridStringId.FilterFunctionYesterday
                    Return "Dün"
                Case RadGridStringId.FilterFunctionDuringLast7days
                    Return "Son 7 Gün"
 
                Case RadGridStringId.FilterLogicalOperatorAnd
                    Return "VE"
                Case RadGridStringId.FilterLogicalOperatorOr
                    Return "VEYA"
                Case RadGridStringId.FilterCompositeNotOperator
                    Return "OLMAYAN"
 
                Case RadGridStringId.DeleteRowMenuItem
                    Return "Satır Sil"
                Case RadGridStringId.SortAscendingMenuItem
                    Return "Küçükten Büyüğe"
                Case RadGridStringId.SortDescendingMenuItem
                    Return "Büyükten Küçüğe"
                Case RadGridStringId.ClearSortingMenuItem
                    Return "Sıralamayı Temizle"
                Case RadGridStringId.ConditionalFormattingMenuItem
                    Return "Duruma Bağlı Biçimlendirme "
                Case RadGridStringId.GroupByThisColumnMenuItem
                    Return "Bu Kolona Göre Grupla"
                Case RadGridStringId.UngroupThisColumn
                    Return "Bu kolonu gruptan çıkar"
                Case RadGridStringId.ColumnChooserMenuItem
                    Return "Kolon Seç"
                Case RadGridStringId.HideMenuItem
                    Return "Gizle"
                Case RadGridStringId.HideGroupMenuItem
                    Return "Grubu Gizle"
                Case RadGridStringId.UnpinMenuItem
                    Return "Sabitlemeyi Kaldır"
                Case RadGridStringId.UnpinRowMenuItem
                    Return "Kolonu sabitlemeyi kaldır"
                Case RadGridStringId.PinMenuItem
                    Return "Sabitle"
                Case RadGridStringId.PinAtLeftMenuItem
                    Return "Sola Sabitle"
                Case RadGridStringId.PinAtRightMenuItem
                    Return "Sağa Sabitle"
                Case RadGridStringId.PinAtBottomMenuItem
                    Return "Alta Sabitle"
                Case RadGridStringId.PinAtTopMenuItem
                    Return "Üste Sabitle"
                Case RadGridStringId.BestFitMenuItem
                    Return "Otomatik Genişlik"
                Case RadGridStringId.PasteMenuItem
                    Return "Yapıştır"
                Case RadGridStringId.EditMenuItem
                    Return "Düzenle"
                Case RadGridStringId.ClearValueMenuItem
                    Return "Değer Temizle"
                Case RadGridStringId.CopyMenuItem
                    Return "Kopyala"
                Case RadGridStringId.CutMenuItem
                    Return "Kes"
                Case RadGridStringId.AddNewRowString
                    Return "Yeni Satır Ekleme"
 
                Case RadGridStringId.ConditionalFormattingSortAlphabetically
                    Return "Alfabetik Sırala"
                Case RadGridStringId.ConditionalFormattingCaption
                    Return "Duruma Göre Biçimlendirme"
                Case RadGridStringId.ConditionalFormattingLblColumn
                    Return "Kolon"
                Case RadGridStringId.ConditionalFormattingLblName
                    Return "Adı"
                Case RadGridStringId.ConditionalFormattingLblType
                    Return "Türü"
                Case RadGridStringId.ConditionalFormattingLblValue1
                    Return "Değer 1"
                Case RadGridStringId.ConditionalFormattingLblValue2
                    Return "Değer 2"
                Case RadGridStringId.ConditionalFormattingGrpConditions
                    Return "Kurallar"
                Case RadGridStringId.ConditionalFormattingGrpProperties
                    Return "Kural Özellikleri"
                Case RadGridStringId.ConditionalFormattingChkApplyToRow
                    Return "Tüm satıra bu biçimlendirmeyi uygula"
                Case RadGridStringId.ConditionalFormattingChkApplyOnSelectedRows
                    Return "Seçili satırlara bu biçimlendirmeyi uygula"
                Case RadGridStringId.ConditionalFormattingBtnAdd
                    Return "Ekle"
                Case RadGridStringId.ConditionalFormattingBtnRemove
                    Return "Kaldır"
                Case RadGridStringId.ConditionalFormattingBtnOK
                    Return "Tamam"
                Case RadGridStringId.ConditionalFormattingBtnCancel
                    Return "Vazgeç"
                Case RadGridStringId.ConditionalFormattingBtnApply
                    Return "Uygula"
                Case RadGridStringId.ConditionalFormattingRuleAppliesOn
                    Return "Bu Kural için:"
                Case RadGridStringId.ConditionalFormattingCondition
                    Return "Durum"
                Case RadGridStringId.ConditionalFormattingExpression
                    Return "İfare"
                Case RadGridStringId.ConditionalFormattingChooseOne
                    Return "[Seçiniz]"
                Case RadGridStringId.ConditionalFormattingEqualsTo
                    Return "Eşittir[Değer 1]"
                Case RadGridStringId.ConditionalFormattingIsNotEqualTo
                    Return "Eşit Değildir [Değer 1]"
                Case RadGridStringId.ConditionalFormattingStartsWith
                    Return "İle Başlar [Değer 1]"
                Case RadGridStringId.ConditionalFormattingEndsWith
                    Return "İle Biter [Değer 1]"
                Case RadGridStringId.ConditionalFormattingContains
                    Return "İçerir [Değer 1]"
                Case RadGridStringId.ConditionalFormattingDoesNotContain
                    Return "İçermez [Değer 1]"
                Case RadGridStringId.ConditionalFormattingIsGreaterThan
                    Return "Büyüktür [Değer 1]"
                Case RadGridStringId.ConditionalFormattingIsGreaterThanOrEqual
                    Return "Büyük veya eşittir [Değer 1]"
                Case RadGridStringId.ConditionalFormattingIsLessThan
                    Return "Küçüktür [Değer 1]"
                Case RadGridStringId.ConditionalFormattingIsLessThanOrEqual
                    Return "Küçük veya eşittir [Değer 1]"
                Case RadGridStringId.ConditionalFormattingIsBetween
                    Return "[Değer 1] ve [Değer 2] arasında"
                Case RadGridStringId.ConditionalFormattingIsNotBetween
                    Return "[Değer 1] ve [Değer 2] arasında değil"
                Case RadGridStringId.ConditionalFormattingLblFormat
                    Return "Biçimlendirme"
 
                Case RadGridStringId.ConditionalFormattingBtnExpression
                    Return "Biçim Editörü"
                Case RadGridStringId.ConditionalFormattingTextBoxExpression
                    Return "Biçim"
 
                Case RadGridStringId.ConditionalFormattingPropertyGridCaseSensitive
                    Return "Büyük küçük harf duyarlı "
                Case RadGridStringId.ConditionalFormattingPropertyGridCellBackColor
                    Return "Hücre Zemin rengi"
                Case RadGridStringId.ConditionalFormattingPropertyGridCellForeColor
                    Return "Hücre metin rengi"
                Case RadGridStringId.ConditionalFormattingPropertyGridEnabled
                    Return "Aktif"
                Case RadGridStringId.ConditionalFormattingPropertyGridRowBackColor
                    Return "Satır Zemin rengi"
                Case RadGridStringId.ConditionalFormattingPropertyGridRowForeColor
                    Return "Satır metin rengi"
                Case RadGridStringId.ConditionalFormattingPropertyGridRowTextAlignment
                    Return "Satır Metin hizalama"
                Case RadGridStringId.ConditionalFormattingPropertyGridTextAlignment
                    Return "Metin Hizalama"
                Case RadGridStringId.ConditionalFormattingPropertyGridCaseSensitiveDescription
                    Return "Büyük/Küçük harf duyarlılığını aktif eder."
                Case RadGridStringId.ConditionalFormattingPropertyGridCellBackColorDescription
                    Return "Hücre için zemin rengi ayarlanıyor"
                Case RadGridStringId.ConditionalFormattingPropertyGridCellForeColorDescription
                    Return "Hücre için metin rengi ayarlanıyor"
                Case RadGridStringId.ConditionalFormattingPropertyGridEnabledDescription
                    Return "Aktif olup olmadığı seçiliyor"
                Case RadGridStringId.ConditionalFormattingPropertyGridRowBackColorDescription
                    Return "Satır için zemin rengi ayarlanıyor"
                Case RadGridStringId.ConditionalFormattingPropertyGridRowForeColorDescription
                    Return "Hücre için metin rengi ayarlanıyor"
                Case RadGridStringId.ConditionalFormattingPropertyGridRowTextAlignmentDescription
                    Return "Satır içindeki metin için hizalama ayarı"
                Case RadGridStringId.ConditionalFormattingPropertyGridTextAlignmentDescription
                    Return "Metin hizalama ayarları "
 
                Case RadGridStringId.ColumnChooserFormCaption
                    Return "Kolon Seçimi"
                Case RadGridStringId.ColumnChooserFormMessage
                    Return "kolonları seçmek için sürükleyin" & vbLf & ""
                Case RadGridStringId.GroupingPanelDefaultMessage
                    Return "Bir kolona göre gruplandırmak için kolonu buraya sürükleyin"
                Case RadGridStringId.GroupingPanelHeader
                    Return "Gruplandırma:"
                Case RadGridStringId.PagingPanelPagesLabel
                    Return "Sayfa"
                Case RadGridStringId.PagingPanelOfPagesLabel
                    Return "arasında"
                Case RadGridStringId.NoDataText
                    Return "Kullanılabilir veri yok"
                Case RadGridStringId.CompositeFilterFormErrorCaption
                    Return "Filtre Hatası"
                Case RadGridStringId.CompositeFilterFormInvalidFilter
                    Return "Hatalı Filtre kullanımı"
 
                Case RadGridStringId.ExpressionMenuItem
                    Return "İfade"
                Case RadGridStringId.ExpressionFormTitle
                    Return "İfade Oluşturucu"
                Case RadGridStringId.ExpressionFormFunctions
                    Return "Fonksiyonlar"
                Case RadGridStringId.ExpressionFormFunctionsText
                    Return "Metin"
                Case RadGridStringId.ExpressionFormFunctionsAggregate
                    Return "Toplama"
                Case RadGridStringId.ExpressionFormFunctionsDateTime
                    Return "Tarih/Saat"
                Case RadGridStringId.ExpressionFormFunctionsLogical
                    Return "Mantıksal"
                Case RadGridStringId.ExpressionFormFunctionsMath
                    Return "Matematik"
                Case RadGridStringId.ExpressionFormFunctionsOther
                    Return "Diğer"
                Case RadGridStringId.ExpressionFormOperators
                    Return "Operatörler"
                Case RadGridStringId.ExpressionFormConstants
                    Return "Sabitler"
                Case RadGridStringId.ExpressionFormFields
                    Return "Alanlar"
                Case RadGridStringId.ExpressionFormDescription
                    Return "Açıklama"
                Case RadGridStringId.ExpressionFormResultPreview
                    Return "Önizleme Sonucu"
                Case RadGridStringId.ExpressionFormTooltipPlus
                    Return "Toplama"
                Case RadGridStringId.ExpressionFormTooltipMinus
                    Return "Çıkarma"
                Case RadGridStringId.ExpressionFormTooltipMultiply
                    Return "Çarpma"
                Case RadGridStringId.ExpressionFormTooltipDivide
                    Return "Bölme"
                Case RadGridStringId.ExpressionFormTooltipModulo
                    Return "Mod"
                Case RadGridStringId.ExpressionFormTooltipEqual
                    Return "Eşit"
                Case RadGridStringId.ExpressionFormTooltipNotEqual
                    Return "Eşit Değil"
                Case RadGridStringId.ExpressionFormTooltipLess
                    Return "Küçük"
                Case RadGridStringId.ExpressionFormTooltipLessOrEqual
                    Return "Küçük veya Eşit"
                Case RadGridStringId.ExpressionFormTooltipGreaterOrEqual
                    Return "Büyük veya Eşit"
                Case RadGridStringId.ExpressionFormTooltipGreater
                    Return "Büyük"
                Case RadGridStringId.ExpressionFormTooltipAnd
                    Return "Mantıksal ""VE"""
                Case RadGridStringId.ExpressionFormTooltipOr
                    Return "Logisches ""ODER"""
                Case RadGridStringId.ExpressionFormTooltipNot
                    Return "Mantıksal ""Değil"""
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
                    Return "Tamam"
                Case RadGridStringId.ExpressionFormCancelButton
                    Return "Vazgeç"
                Case RadGridStringId.SearchRowResultsOfLabel
                    Return "de"
                Case RadGridStringId.SearchRowMatchCase
                    Return "Bul"
            End Select
            Return String.Empty
        End Function
    End Class
End Namespace

