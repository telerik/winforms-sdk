using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace _1407985
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
            radListView1.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            radListView1.Columns.Add("Col1");
            radListView1.Columns.Add("Col2");
            radListView1.Columns.Add("Col3");

            for (int i = 0; i < 5; i++)
            {
                var item = new ListViewDataItem();
                item[0] = "Row" + i;
                item[1] = "Test";
                item[2] = "Test2";
                radListView1.Items.Add(item);
            }

            var view = radListView1.ListViewElement.ViewElement as DetailListViewElement;

           
            radListView1.EditorRequired += RadListView1_EditorRequired;
           
        }

     

        private void RadListView1_EditorRequired(object sender, ListViewItemEditorRequiredEventArgs e)
        {
            if (e.ListViewElement.CurrentColumn.Name == "Col2")
            {
                var editor = new MyListViewDropDownListEditor();
                (editor.EditorElement as BaseDropDownListEditorElement).Items.Add("Product1");
                (editor.EditorElement as BaseDropDownListEditorElement).Items.Add("Product2");
                (editor.EditorElement as BaseDropDownListEditorElement).Items.Add("Product3");

                e.Editor = editor;
            }
        }

       
    }
    class MyListViewDropDownListEditor : ListViewDropDownListEditor
    {
        public override void OnValueChanged()
        {
           // base.OnValueChanged();
        }
    }
    class MyRadListView : RadListView
    {
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Tab)
            {
                var view = this.ListViewElement.ViewElement as DetailListViewElement;
                var element = this.ListViewElement;
                int columnIndex = element.Columns.IndexOf(element.CurrentColumn);

                ITraverser<ListViewDetailColumn> colEnumerator = (ITraverser<ListViewDetailColumn>)view.ColumnScroller.Traverser.GetEnumerator();
                colEnumerator.Position = columnIndex;

                if (colEnumerator.MoveNext())
                {
                    var isEditing = element.IsEditing;
                    
                    element.CurrentColumn = colEnumerator.Current;
                    if (isEditing)
                    {
                        element.BeginEdit();
                    }
                    return true;
                }
                else
                {
                    ListViewTraverser enumerator = view.Scroller.Traverser.GetEnumerator() as ListViewTraverser;
                    enumerator.Position = element.CurrentItem;

                    if (enumerator.MoveNext())
                    {
                        var isEditing = element.IsEditing;
                        

                        colEnumerator.Reset();
                        colEnumerator.MoveNext();
                        element.CurrentColumn = colEnumerator.Current;
                        element.CurrentItem = enumerator.Current;
                        element.SelectedItem = enumerator.Current;

                        if (isEditing)
                        {
                            element.BeginEdit();
                        }

                        return true;
                    }
                }


            }
            if (keyData == (Keys.Tab | Keys.Shift))
            {
                var view = this.ListViewElement.ViewElement as DetailListViewElement;
                var element = this.ListViewElement;
                int columnIndex = element.Columns.IndexOf(element.CurrentColumn);

                ITraverser<ListViewDetailColumn> colEnumerator = (ITraverser<ListViewDetailColumn>)view.ColumnScroller.Traverser.GetEnumerator();
                colEnumerator.Position = columnIndex;

                if (colEnumerator.MovePrevious())
                {
                    var isEditing = element.IsEditing;
                   
                    element.CurrentColumn = colEnumerator.Current;

                    if (isEditing)
                    {
                        element.BeginEdit();
                    }
                    return true;
                }
                else
                {
                    ListViewTraverser enumerator = view.Scroller.Traverser.GetEnumerator() as ListViewTraverser;
                    enumerator.Position = element.CurrentItem;

                    if (enumerator.MovePrevious())
                    {
                        var isEditing = element.IsEditing;
                        
                        colEnumerator.MoveToEnd();
                        element.CurrentColumn = colEnumerator.Current;
                        element.CurrentItem = enumerator.Current;
                        element.SelectedItem = enumerator.Current;

                        if (isEditing)
                        {
                            element.BeginEdit();
                        }

                        return true;
                    }
                }
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}
