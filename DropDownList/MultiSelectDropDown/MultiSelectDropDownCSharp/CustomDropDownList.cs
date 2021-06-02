using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace MultiSelectDropDown
{
    public class CustomDropDownList : RadDropDownList
    {
        public override string ThemeClassName
        {
            get
            {
                return typeof(RadDropDownList).FullName;
            }
            set
            {
            }
        }

        protected override RadDropDownListElement CreateDropDownListElement()
        {
            return new CustomEditorElement();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content),
        Editor(typeof(CustomListControlCollectionEditor), typeof(UITypeEditor)),
        Category(RadDesignCategory.DataCategory)]
        [Description("Gets a collection representing the items contained in this RadDropDownList.")]
        public new RadListDataItemCollection Items
        {
            get
            {
                return base.Items;
            }
        }
    }

    public class CustomListControlCollectionEditor : Telerik.WinControls.UI.Design.RadListControlCollectionEditor
    {
        public CustomListControlCollectionEditor(Type itemType) : base(itemType)
        {
        }

        protected override Type[] CreateNewItemTypes()
        {
            Type[] baseTypes = base.CreateNewItemTypes();
            Type[] newTypes = new Type[baseTypes.Length + 1];
            baseTypes.CopyTo(newTypes, 0);
            newTypes[baseTypes.Length] = typeof(CustomListDataItem);
            return newTypes;
        }
   }


}