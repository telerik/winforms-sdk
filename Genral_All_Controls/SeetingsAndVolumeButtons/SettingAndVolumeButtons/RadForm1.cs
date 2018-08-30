using SettingAndVolumeButtons.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Primitives;

namespace SettingAndVolumeButtons
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            //new Telerik.WinControls.RadControlSpy.RadControlSpyForm().Show();
            InitializeComponent();
            //setup popup editor
            radPopupEditor1.DropDownSizingMode = Telerik.WinControls.UI.SizingMode.None;

            var imagePrimitive = radPopupEditor1.PopupEditorElement.ArrowButtonElement.Children[4] as ImagePrimitive;
            imagePrimitive.Image = Resources.volume.GetThumbnailImage(30, 30, null, IntPtr.Zero);
            radPopupEditor1.Width = imagePrimitive.Image.Width;

            var fillPrimitive = radPopupEditor1.PopupEditorElement.ArrowButtonElement.Children[0] as FillPrimitive;
            fillPrimitive.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;

            var borderPrimitive = radPopupEditor1.PopupEditorElement.ArrowButtonElement.Children[1] as BorderPrimitive;
            borderPrimitive.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;

            var popupBorder = this.radPopupEditor1.PopupEditorElement.Children[0] as BorderPrimitive;
            popupBorder.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;

            var popupFill = this.radPopupEditor1.PopupEditorElement.Children[1] as FillPrimitive;
            popupFill.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;

            radPopupEditor1.EditableAreaElement.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;

            //setup drop Down button
            radDropDownButton1.RootElement.BackColor = Color.Transparent;
            radDropDownButton1.DropDownButtonElement.BorderElement.Visibility = ElementVisibility.Collapsed;
            radDropDownButton1.DropDownButtonElement.ActionButton.ImagePrimitive.Image = Resources.wrench.GetThumbnailImage(30, 30, null, IntPtr.Zero); 
            radDropDownButton1.DropDownButtonElement.DisplayStyle = DisplayStyle.Image;
            radDropDownButton1.DropDownButtonElement.ActionButton.ButtonFillElement.BackColor = Color.Transparent;
            radDropDownButton1.DropDownButtonElement.ArrowButton.Visibility = ElementVisibility.Collapsed;
        }
    }
}
