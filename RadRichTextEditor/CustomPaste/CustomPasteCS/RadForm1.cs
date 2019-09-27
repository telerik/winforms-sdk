using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinForms.Documents.Base;
using Telerik.WinForms.Documents.FormatProviders.Txt;
using Telerik.WinForms.Documents.Model;
using Telerik.WinForms.Documents.RichTextBoxCommands;

namespace _1431704
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();

            radRichTextEditor1.CommandExecuting += RadRichTextEditor1_CommandExecuting;
        }

        bool pasteTextOnly = false;

        private void RadRichTextEditor1_CommandExecuting(object sender, Telerik.WinForms.Documents.RichTextBoxCommands.CommandExecutingEventArgs e)
        {
            
            if (e.Command is PasteCommand && pasteTextOnly)
            {
                e.Cancel = true;
                PasteNewText();
                pasteTextOnly = false;

            }
        }

    
        private void button1_Click(object sender, EventArgs e)
        {
            pasteTextOnly = true;
            this.radRichTextEditor1.RichTextBoxElement.Commands.PasteCommand.Execute();
        }
        TxtFormatProvider provider = new TxtFormatProvider();
        public void PasteNewText()
        {
            DocumentFragment clipboardDocument = null;
            string clipboardText = null;
            bool clipboardContainsData = false;

            if (ClipboardEx.ContainsDocument(null))
            {
                clipboardDocument = ClipboardEx.GetDocument();
                clipboardContainsData = true;
            }
            else if (ClipboardEx.ContainsText(null))
            {
                clipboardText = ClipboardEx.GetText(null);
                clipboardContainsData = true;
            }

            if (!clipboardContainsData)
            {
                return;
            }

            this.radRichTextEditor1.ChangeFontFamily(new Telerik.WinControls.RichTextEditor.UI.FontFamily("Consolas"));

            if (clipboardDocument != null)
            {
                RadDocument doc = new RadDocument();
                RadDocumentEditor editor = new RadDocumentEditor(doc);
                editor.InsertFragment(clipboardDocument);

                string text = provider.Export(doc);
                
                this.radRichTextEditor1.RichTextBoxElement.ActiveDocumentEditor.Insert(text);
            }
            else if (!string.IsNullOrEmpty(clipboardText))
            {
                this.radRichTextEditor1.RichTextBoxElement.ActiveDocumentEditor.Insert(clipboardText);
            }
        }


        private void radButton1_Click(object sender, EventArgs e)
        {
            pasteTextOnly = true;
            radRichTextEditor1.RichTextBoxElement.Commands.PasteCommand.Execute();
            pasteTextOnly = false;

        }
    }
}
