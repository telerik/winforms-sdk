using System;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinForms.Documents.FormatProviders.Html;
using Telerik.WinForms.Documents.FormatProviders.Rtf;
using Telerik.WinForms.Documents.Model;

namespace CustomGridColumn
{
    public class RichTextEditorCellElement : GridDataCellElement
    {
        private RichTextEditor editor;

        public RichTextEditorCellElement(GridViewColumn col, GridRowElement row)
            : base(col, row)
        {

        }

        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(GridDataCellElement);
            }
        }

        public override IInputEditor Editor
        {
            get
            {
                return this.editor;
            }
        }

        protected override void CreateChildElements()
        {
            base.CreateChildElements();
            this.editor = new RichTextEditor();

            this.Children.Add(this.editor.EditorElement);
        }

        protected override void SetContentCore(object value)
        {
            try
            {
                this.editor.Value = Convert.ToString(value);

                if (this.Value != null && this.Value != DBNull.Value && this.Value.ToString() != "")
                {
                    RichTextEditorElement element = (RichTextEditorElement)this.editor.EditorElement;
                    RadRichTextEditor textBox = (RadRichTextEditor)element.HostedControl;
                    HtmlFormatProvider provider = new HtmlFormatProvider(); 

                    RadDocument document = provider.Import(this.Value.ToString());
                    textBox.Document = document;
                    document.LayoutMode = DocumentLayoutMode.Flow;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, ex.ToString(), "EXCEPTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void Attach(GridViewColumn data, object context)
        {
            base.Attach(data, context);

            if (this.RowElement != null)
            {
                this.GridViewElement.EditorManager.RegisterPermanentEditorType(typeof(RichTextEditor));
            }
        }
    }
}
