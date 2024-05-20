using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Localization;

namespace GermanRadControlsLocalization
{

    public static class LocalizationProviders
    {
   
        private static RadSchedulerLocalizationProvider _englishRadSchedulerLocalizationProvider;
        private static SchedulerNavigatorLocalizationProvider _englishSchedulerNavigatorLocalizationProvider;
        private static RadReminderLocalizationProvider _englishRadReminderLocalizationProvider;
        private static RadDockLocalizationProvider _englishRadDockLocalizationProvider;
        private static RadPageViewLocalizationProvider _englishRadPageViewLocalizationProvider;
        private static RadMessageLocalizationProvider _englishRadMessageLocalizationProvider;
        private static TreeViewLocalizationProvider _englishTreeViewLocalizationProvider;
        private static RadGridLocalizationProvider _englishRadGridLocalizationProvider;
        private static PropertyGridLocalizationProvider _englishRadPropertyGridLocalizationProvider;
        private static ColorDialogLocalizationProvider _englishColorDialogLocalizationProvider;
        private static CommandBarLocalizationProvider _englishCommandBarLocalizationProvider;
        private static RadMarkupEditorLocalizationProvider _englishRadMarkupEditorLocalizationProvider;
        private static RadWizardLocalizationProvider _englishRadWizardLocalizationProvider;
        private static RadTimePickerLocalizationProvider _englishRadTimePickerLocalizationProvider;
        private static PrintDialogsLocalizationProvider _englishPrintDialogsLocalizationProvider;
		private static RadBrowseEditorLocalizationProvider _englishRadBrowseEditorLocalizationProvider;
		private static RadSpellCheckerLocalizationProvider _englishRadSpellCheckerLocalizationProvider;
		private static TextBoxControlLocalizationProvider _englishRadTextBoxLocalizationProvider;

        private static RadSchedulerLocalizationProvider _germanRadSchedulerLocalizationProvider;
        private static SchedulerNavigatorLocalizationProvider _germanSchedulerNavigatorLocalizationProvider;
        private static RadReminderLocalizationProvider _germanRadReminderLocalizationProvider;
        private static RadDockLocalizationProvider _germanRadDockLocalizationProvider;
        private static RadPageViewLocalizationProvider _germanRadPageViewLocalizationProvider;
        private static RadMessageLocalizationProvider _germanRadMessageLocalizationProvider;
        private static TreeViewLocalizationProvider _germanTreeViewLocalizationProvider;
        private static RadGridLocalizationProvider _germanRadGridLocalizationProvider;
        private static PropertyGridLocalizationProvider _germanRadPropertyGridLocalizationProvider;
        private static ColorDialogLocalizationProvider _germanColorDialogLocalizationProvider;
        private static CommandBarLocalizationProvider _germanCommandBarLocalizationProvider;
        private static RadMarkupEditorLocalizationProvider _germanRadMarkupEditorLocalizationProvider;
        private static RadWizardLocalizationProvider _germanRadWizardLocalizationProvider;
        private static RadTimePickerLocalizationProvider _germanRadTimePickerLocalizationProvider;
        private static PrintDialogsLocalizationProvider _germanPrintDialogsLocalizationProvider;
		private static RadBrowseEditorLocalizationProvider _germanRadBrowseEditorLocalizationProvider;
		private static RadSpellCheckerLocalizationProvider _germanRadSpellCheckerLocalizationProvider;
		private static TextBoxControlLocalizationProvider _germanRadTextBoxLocalizationProvider;

        //private bool currentLanguageEnglish;

        public static void InitializeLocalizationProvider()
        {
            _englishRadSchedulerLocalizationProvider = RadSchedulerLocalizationProvider.CurrentProvider;
            _englishSchedulerNavigatorLocalizationProvider = SchedulerNavigatorLocalizationProvider.CurrentProvider;
            _englishRadReminderLocalizationProvider = RadReminderLocalizationProvider.CurrentProvider;
            _englishRadDockLocalizationProvider = RadDockLocalizationProvider.CurrentProvider;
            _englishRadPageViewLocalizationProvider = RadPageViewLocalizationProvider.CurrentProvider;
            _englishRadMessageLocalizationProvider = RadMessageLocalizationProvider.CurrentProvider;
            _englishTreeViewLocalizationProvider = TreeViewLocalizationProvider.CurrentProvider;
            _englishRadGridLocalizationProvider = RadGridLocalizationProvider.CurrentProvider;
            _englishRadPropertyGridLocalizationProvider = PropertyGridLocalizationProvider.CurrentProvider;
            _englishColorDialogLocalizationProvider = ColorDialogLocalizationProvider.CurrentProvider;
            _englishCommandBarLocalizationProvider = CommandBarLocalizationProvider.CurrentProvider;
            _englishRadMarkupEditorLocalizationProvider = RadMarkupEditorLocalizationProvider.CurrentProvider;
            _englishRadWizardLocalizationProvider = RadWizardLocalizationProvider.CurrentProvider;
            _englishRadTimePickerLocalizationProvider = RadTimePickerLocalizationProvider.CurrentProvider;
            _englishPrintDialogsLocalizationProvider = PrintDialogsLocalizationProvider.CurrentProvider;
        	_englishRadBrowseEditorLocalizationProvider = RadBrowseEditorLocalizationProvider.CurrentProvider;
        	_englishRadSpellCheckerLocalizationProvider = RadSpellCheckerLocalizationProvider.CurrentProvider;
        	_englishRadTextBoxLocalizationProvider = TextBoxControlLocalizationProvider.CurrentProvider;


            _germanRadSchedulerLocalizationProvider = new GermanRadSchedulerLocalizationProvider(  );
            _germanSchedulerNavigatorLocalizationProvider = new GermanRadSchedulerNavigatorLocalizationProvider(  );
            _germanRadReminderLocalizationProvider = new GermanRadReminderLocalizationProvider(  );
            _germanRadDockLocalizationProvider = new GermanRadDockLocalizationProvider(  );
            _germanRadPageViewLocalizationProvider = new GermanRadPageViewLocalizationProvider(  );
            _germanRadMessageLocalizationProvider = new GermanRadMessageBoxLocalizationProvider(  );
            _germanTreeViewLocalizationProvider = new GermanRadTreeViewLocalizationProvider(  );
            _germanRadGridLocalizationProvider = new GermanRadGridViewLocalizationProvider(  );
            _germanRadPropertyGridLocalizationProvider = new GermanRadPropertyGridLocalizationProvider();
            _germanColorDialogLocalizationProvider = new GermanColorDialogLocalizationProvider();
            _germanCommandBarLocalizationProvider = new GermanCommandBarLocalizationProvider();
            _germanRadMarkupEditorLocalizationProvider = new GermanRadMarkupEditorLocalizationProvider();
            _germanRadWizardLocalizationProvider = new GermanRadWizardLocalizationProvider();
            _germanRadTimePickerLocalizationProvider = new GermanRadTimePickerLocalizationProvider( );
            _germanPrintDialogsLocalizationProvider = new GermanPrintDialogsLocalizationProvider(  );
			_germanRadBrowseEditorLocalizationProvider = new GermanRadBrowseEditorLocalizationProvider(  );
			_germanRadSpellCheckerLocalizationProvider = new GermanRadSpellCheckerLocalizationProvider(  );
			_germanRadTextBoxLocalizationProvider = new GermanRadTextBoxLocalizationProvider(  );

            ChangeLanguage( true );
        }

        public static void ChangeLanguage( bool changeLanguageToGerman )
        {
            if ( changeLanguageToGerman )
            {
                RadSchedulerLocalizationProvider.CurrentProvider = _germanRadSchedulerLocalizationProvider;
                SchedulerNavigatorLocalizationProvider.CurrentProvider = _germanSchedulerNavigatorLocalizationProvider;
                RadReminderLocalizationProvider.CurrentProvider = _germanRadReminderLocalizationProvider;
                RadDockLocalizationProvider.CurrentProvider = _germanRadDockLocalizationProvider;
                RadPageViewLocalizationProvider.CurrentProvider = _germanRadPageViewLocalizationProvider;
                RadMessageLocalizationProvider.CurrentProvider = _germanRadMessageLocalizationProvider;
                TreeViewLocalizationProvider.CurrentProvider = _germanTreeViewLocalizationProvider;
                RadGridLocalizationProvider.CurrentProvider = _germanRadGridLocalizationProvider;
                PropertyGridLocalizationProvider.CurrentProvider = _germanRadPropertyGridLocalizationProvider;
                ColorDialogLocalizationProvider.CurrentProvider = _germanColorDialogLocalizationProvider;
                CommandBarLocalizationProvider.CurrentProvider = _germanCommandBarLocalizationProvider;
                RadMarkupEditorLocalizationProvider.CurrentProvider = _germanRadMarkupEditorLocalizationProvider;
                RadWizardLocalizationProvider.CurrentProvider = _germanRadWizardLocalizationProvider;
                RadTimePickerLocalizationProvider.CurrentProvider = _germanRadTimePickerLocalizationProvider;
                PrintDialogsLocalizationProvider.CurrentProvider = _germanPrintDialogsLocalizationProvider;
				RadBrowseEditorLocalizationProvider.CurrentProvider = _germanRadBrowseEditorLocalizationProvider;
				RadSpellCheckerLocalizationProvider.CurrentProvider = _germanRadSpellCheckerLocalizationProvider;
				TextBoxControlLocalizationProvider.CurrentProvider = _germanRadTextBoxLocalizationProvider;
			}
            else
            {
                RadSchedulerLocalizationProvider.CurrentProvider = _englishRadSchedulerLocalizationProvider;
                SchedulerNavigatorLocalizationProvider.CurrentProvider = _englishSchedulerNavigatorLocalizationProvider;
                RadReminderLocalizationProvider.CurrentProvider = _englishRadReminderLocalizationProvider;
                RadDockLocalizationProvider.CurrentProvider = _englishRadDockLocalizationProvider;
                RadPageViewLocalizationProvider.CurrentProvider = _englishRadPageViewLocalizationProvider;
                RadMessageLocalizationProvider.CurrentProvider = _englishRadMessageLocalizationProvider;
                TreeViewLocalizationProvider.CurrentProvider = _englishTreeViewLocalizationProvider;
                RadGridLocalizationProvider.CurrentProvider = _englishRadGridLocalizationProvider;
                PropertyGridLocalizationProvider.CurrentProvider = _englishRadPropertyGridLocalizationProvider;
                ColorDialogLocalizationProvider.CurrentProvider = _englishColorDialogLocalizationProvider;
                CommandBarLocalizationProvider.CurrentProvider = _englishCommandBarLocalizationProvider;
                RadMarkupEditorLocalizationProvider.CurrentProvider = _englishRadMarkupEditorLocalizationProvider;
                RadWizardLocalizationProvider.CurrentProvider = _englishRadWizardLocalizationProvider;
                RadTimePickerLocalizationProvider.CurrentProvider = _englishRadTimePickerLocalizationProvider;
                PrintDialogsLocalizationProvider.CurrentProvider = _englishPrintDialogsLocalizationProvider;
				RadBrowseEditorLocalizationProvider.CurrentProvider = _englishRadBrowseEditorLocalizationProvider;
				RadSpellCheckerLocalizationProvider.CurrentProvider = _englishRadSpellCheckerLocalizationProvider;
				TextBoxControlLocalizationProvider.CurrentProvider = _englishRadTextBoxLocalizationProvider;
			}

        }

    }
}
