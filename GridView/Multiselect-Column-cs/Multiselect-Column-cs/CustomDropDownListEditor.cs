using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace _547099
{
    public class CustomDropDownListEditor : RadDropDownListEditor
    {

        public override object Value
        {
            get
            {
                CustomEditorElement editorElement = this.EditorElement as CustomEditorElement;
                if (editorElement != null)
                {
                    List<int> selected = new List<int>();
                    foreach (RadListDataItem item in editorElement.ListElement.SelectedItems)
                    {
                        selected.Add((int)item.Value);
                    }
                    return selected.ToArray();
                }
                return base.Value;
            }
            set
            {
                CustomEditorElement editorElement = this.EditorElement as CustomEditorElement;
                if (editorElement != null)
                {
                    int[] names = value as int[];
                    if (names != null)
                    {
                        foreach (int val in names)
                        {
                            RadListDataItem item = FindByValue(val);
                            if (item != null)
                            {
                                item.Selected = true;
                            }
                        }
                    }
                    editorElement.CallTextChanged();
                }
            }
        }

        private RadListDataItem FindByValue(object value)
        {
            CustomEditorElement editorElement = this.EditorElement as CustomEditorElement;
            foreach (RadListDataItem item in editorElement.Items)
            {
                if (value.Equals(item.Value))
                {
                    return item;
                }
            }
            return null;
        }

        protected override RadElement CreateEditorElement()
        {
            return new CustomEditorElement();
        }
    }
}
