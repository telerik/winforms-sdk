using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls.UI;

namespace AllowEndUsersAddItemsComboBoxEditor
{
public class CustomDropDownEditor : RadDropDownListEditor
{
       
    public override bool EndEdit()
    {
        GridComboBoxCellElement cellElement = this.OwnerElement as GridComboBoxCellElement;
        RadGridView grid = cellElement.GridControl;
        RadForm1 f = (RadForm1)grid.FindForm();
        // Checking if the typed value exists in the datasource of the column.
        NwindDataSet.CategoriesDataTable dt = f.DataSet.Categories;
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            if (dt.Rows[i]["CategoryName"].ToString() == ((RadDropDownListEditorElement)this.EditorElement).Text)
            {
                return base.EndEdit();
            }
        }
        // An example of what we can do when we enter the custom text.
        // In this case we are adding a new data row in the underlying datasource of 
        // the combobox column and then in the CellEndEdit we are setting
        // the ID value of the newly created row to RadGridView.
        NwindDataSet.CategoriesRow newCategoriesRow = dt.NewCategoriesRow();
        newCategoriesRow.CategoryName = ((RadDropDownListEditorElement)this.EditorElement).Text;
      
        f.DataSet.Categories.Rows.Add(newCategoriesRow);
        // Updating the database. You can do it here at another place
        // you find suitable for this purpose, for example, on FormClosing.
        f.CategoriesTA.Update(f.DataSet.Categories);
        cellElement.Tag = newCategoriesRow.CategoryID;
        return base.EndEdit();
    }
}
}
