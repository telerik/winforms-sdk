using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls.UI;
using Telerik.WinControls.Layouts;
using Telerik.WinControls;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace MultiSelectDropDown
{
    public class CustomEditorElement : RadDropDownListEditorElement
    {
        private LightVisualElement customText;
        private RadButtonElement closeButton;
        private bool textChanged;

        public CustomEditorElement()
        {
            closeButton = new RadButtonElement("Close");
            closeButton.SetValue(DockLayoutPanel.DockProperty, Dock.Bottom);
            closeButton.Click += new EventHandler(closeButton_Click);
            this.Popup.SizingGripDockLayout.Children.Insert(1, closeButton);
            this.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;

            this.PopupClosing += new RadPopupClosingEventHandler(CustomEditorElement_PopupClosing);
            this.CreatingVisualItem += new CreatingVisualListItemEventHandler(CustomEditorElement_CreatingVisualItem);
            this.ListElement.ItemDataBinding += this.CustomEditorElement_ItemDataBinding;
        }

        private void deselectAll_Click(object sender, EventArgs e)
        {
            this.SetItemsCheckSelect(false);
        }

        private void selectAll_Click(object sender, EventArgs e)
        {
            this.SetItemsCheckSelect(true);
        }

        private void SetItemsCheckSelect(bool value)
        {
            foreach (CustomListDataItem item in this.Items)
            {
                item.Selected = value;
                item.Checked = value;
            }

            this.SynchronizeText();
        }

        protected override void SyncVisualProperties(RadListDataItem listItem)
        {
        }

        void closeButton_Click(object sender, EventArgs e)
        {
            ClosePopup();
            GridDataCellElement cell = this.Parent as GridDataCellElement;
            if (cell != null)
            {
                cell.GridViewElement.EndEdit();
            }
        }

        private void CustomEditorElement_ItemDataBinding(object sender, ListItemDataBindingEventArgs args)
        {
            args.NewItem = new CustomListDataItem();
        }

        void CustomEditorElement_CreatingVisualItem(object sender, CreatingVisualListItemEventArgs args)
        {
            args.VisualItem = new CustomListVisualItem();
        }

        void CustomEditorElement_PopupClosing(object sender, RadPopupClosingEventArgs args)
        {
            CustomEditorElement editor = (CustomEditorElement)sender;
            if (args.CloseReason == RadPopupCloseReason.Mouse)
            {
                if (editor.PopupForm.Bounds.Contains(Control.MousePosition))
                {
                    args.Cancel = true;
                }
            }
        }

        protected override void CreateChildElements()
        {
            base.CreateChildElements();

            customText = new LightVisualElement();
            customText.DrawBorder = false;
            customText.DrawFill = true;
            customText.GradientStyle = GradientStyles.Solid;
            customText.BackColor = Color.White;
            customText.TextAlignment = ContentAlignment.MiddleLeft;
            this.EditableElement.Children.Add(customText);
            this.TextBox.Visibility = ElementVisibility.Collapsed;
            this.MinSize = new Size(0, 21);
        }

        public override void ShowPopup()
        {
            bool[] selected = new bool[this.Items.Count];
            for (int i = 0; i < selected.Length; i++)
            {
                selected[i] = this.Items[i].Selected;
            }

            base.ShowPopup();
            for (int i = 0; i < selected.Length; i++)
            {
                this.Items[i].Selected = selected[i];
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            SynchronizeText();
        }

        internal void SynchronizeText()
        {
            if (textChanged)
            {
                return;
            }

            textChanged = true;
            StringBuilder text = new StringBuilder();
            foreach (CustomListDataItem item in this.ListElement.Items)
            {
                if (item.Checked) 
                {
                    text.AppendFormat("{0}; ", item.Text);
                }
            }

            customText.Text = text.ToString();
            textChanged = false;        
        }
    }
}