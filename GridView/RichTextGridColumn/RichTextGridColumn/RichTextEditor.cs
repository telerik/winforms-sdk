using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinForms.Documents.FormatProviders.Html;
using Telerik.WinForms.Documents.FormatProviders.Rtf;

namespace CustomGridColumn
{
    public class RichTextEditor : BaseGridEditor
    {
        public override object Value
        {
            get
            {
                RichTextEditorElement element = (RichTextEditorElement)EditorElement;
                RadRichTextEditor textBox = (RadRichTextEditor)element.HostedControl;
               HtmlFormatProvider provider = new HtmlFormatProvider();
                return provider.Export(textBox.Document);
            }
            set
            {
                RichTextEditorElement element = (RichTextEditorElement)EditorElement;
                RadRichTextEditor textBox = (RadRichTextEditor)element.HostedControl;
                HtmlFormatProvider provider = new HtmlFormatProvider();
                if (value != null)
                {
                    textBox.Document = provider.Import(value.ToString());
                }
                else
                {
                    textBox.Document = provider.Import(@"<html><body></body></html>");
                }
            }
        }

        public override void BeginEdit()
        {
            base.BeginEdit();

            RichTextEditorElement element = this.EditorElement as RichTextEditorElement;
            RadRichTextEditor richTextEditor = element.HostedControl as RadRichTextEditor;
            richTextEditor.Document.DocumentContentChanged += this.OnDocumentContentChanged;
        }

        private void OnDocumentContentChanged(object sender, System.EventArgs e)
        {
            this.OnValueChanged();
        }

        public override bool EndEdit()
        {
            RichTextEditorElement element = this.EditorElement as RichTextEditorElement;
            RadRichTextEditor richTextEditor = element.HostedControl as RadRichTextEditor;
            richTextEditor.Document.DocumentContentChanged -= this.OnDocumentContentChanged;

            return base.EndEdit();
        }

        protected override RadElement CreateEditorElement()
        {
            return new RichTextEditorElement();
        } 
    }
}
