using Telerik.WinControls.UI;
namespace CustomGridColumn
{
    public class GridViewRichTextColumn : GridViewTextBoxColumn
    {
        public GridViewRichTextColumn()
        {
        }

        public GridViewRichTextColumn(string fieldName)
            : base(fieldName)
        {
        }


        public GridViewRichTextColumn(string uniqueName, string fieldName)
            : base(uniqueName, fieldName)
        {
        }

        public override System.Type GetCellType(GridViewRowInfo row)
        {
            if (row is GridViewDataRowInfo)
            {
                return typeof(RichTextEditorCellElement);
            }

            return base.GetCellType(row);
        }

        public override System.Type GetDefaultEditorType()
        {
            return typeof(RichTextEditor);
        }

        public override IInputEditor GetDefaultEditor()
        {
            return new RichTextEditor();
        }
    }
}
