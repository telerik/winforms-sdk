using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Primitives;

using Telerik.WinControls.UI;

namespace CarouselImageGallery
{
    public partial class GalleryView : RadForm
    {
        private bool shouldZoomSelectedItem = false;
        private CarouselContentItem zoomedItem;
        private float currScaleFactor = 1f;
        private int animationRunning;

        public GalleryView()
        {
            InitializeComponent();
        }

        public void ShowGallery(string path)
        {
            this.Text = path;

            string[] jpgFiles = Directory.GetFiles(path, "*.jpg", SearchOption.AllDirectories);
            string[] jpegFiles = Directory.GetFiles(path, "*.jpeg", SearchOption.AllDirectories);
            string[] bmpFiles = Directory.GetFiles(path, "*.bmp", SearchOption.AllDirectories);
            string[] gifFiles = Directory.GetFiles(path, "*.gif", SearchOption.AllDirectories);
            string[] pngFiles = Directory.GetFiles(path, "*.png", SearchOption.AllDirectories);

            this.radCarousel1.Items.Clear();

            List<string> imageFiles = new List<string>(jpgFiles.Length + jpegFiles.Length + bmpFiles.Length + gifFiles.Length + pngFiles.Length);
            imageFiles.AddRange(jpgFiles);
            imageFiles.AddRange(jpegFiles);
            imageFiles.AddRange(bmpFiles);
            imageFiles.AddRange(gifFiles);
            imageFiles.AddRange(pngFiles);

            this.radCarousel1.DataSource = imageFiles;
            this.Show();
        }

        private void radCarousel1_ItemDataBound(object sender, Telerik.WinControls.UI.ItemDataBoundEventArgs e)
        {
            RadButtonElement button = (RadButtonElement)e.DataBoundItem;
            button.Text = (string)e.DataItem;
            button.MinSize = new Size(20, 20);
            //button.AutoSize = false;
            button.DisplayStyle = DisplayStyle.Image;
            button.ImagePrimitive.ImageLayout = ImageLayout.Zoom;

            button.MouseDown += new MouseEventHandler(button_MouseDown);

            if (this.radCarousel1.Items.Count < this.radCarousel1.VisibleItemCount)
                LoadItemImage(button, true);
        }

        private void button_MouseDown(object sender, MouseEventArgs e)
        {
            CarouselContentItem currentZoomed = zoomedItem;
            ResetZoomedItem();

            RadButtonElement button = (RadButtonElement)sender;

            CarouselContentItem contentItem = (CarouselContentItem)button.Parent;
            if (currentZoomed == contentItem)
                return;

            if (this.radCarousel1.SelectedItem != button)
                return;

            ZoomSelectedItemOnAnimationFinished();
        }

        private void ZoomItem(RadButtonElement button)
        {
            shouldZoomSelectedItem = false;
            Size size = this.radCarousel1.CarouselElement.ItemsContainer.Size;

            CarouselContentItem contentItem = (CarouselContentItem)button.Parent;

            zoomedItem = contentItem;

            button.ButtonFillElement.Visibility = ElementVisibility.Collapsed;

            currScaleFactor = Math.Min(
                ((float)size.Width) / button.Size.Width / 2f,
                ((float)size.Height) / button.Size.Height / 2f);

            AnimatedPropertySetting scaleChange = new AnimatedPropertySetting(
                RadElement.ScaleTransformProperty,
                new SizeF(currScaleFactor, currScaleFactor),
                new SizeF(2,2),
                20,0
                );

            scaleChange.AnimationFinished += new AnimationFinishedEventHandler(scaleChange_AnimationFinished);

            SizeF offset = new SizeF(
                (size.Width - contentItem.Size.Width * currScaleFactor) / 2f - contentItem.Location.X,
                (size.Height - contentItem.Size.Height * 0.50f * currScaleFactor) / 2f - contentItem.Location.Y);

            AnimatedPropertySetting positionChange = new AnimatedPropertySetting(
                RadElement.PositionOffsetProperty,
                offset,
                 new SizeF(2, 2),
                20,0
                );

            scaleChange.ApplyValue(contentItem);
            positionChange.ApplyValue(contentItem);
        }

        private void scaleChange_AnimationFinished(object sender, AnimationStatusEventArgs e)
        {
            RadButtonElement button = (RadButtonElement)this.zoomedItem.HostedItem;
            LoadItemImage(button, false);
            //SizeToFit is needed in order to enable ScaleSize
            button.ImagePrimitive.ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit;
            button.ImagePrimitive.ScaleSize = new Size(
            (int)Math.Round(button.Size.Width - button.BorderThickness.All * currScaleFactor / 2f),
            (int)Math.Round(button.Size.Height - button.BorderThickness.All * currScaleFactor / 2f));
        }

        private bool GetThumbnailImageAbort()
        {
            return false;
        }

        private void GalleryView_Shown(object sender, EventArgs e)
        {
            if (this.radCarousel1.Items.Count > 0)
            {
                this.radCarousel1.SelectedIndex = 0;
            }

            this.Text = string.Format("Showing gallery of {0} images. Location: ", this.radCarousel1.Items.Count) + this.Text;

            this.radCarousel1.CarouselElement.ItemsContainer.ForceUpdate();
        }

        private void radCarousel1_NewCarouselItemCreating(object sender, NewCarouselItemCreatingEventArgs e)
        {
            e.NewCarouselItem = new RadButtonElement();
        }

        private void GalleryView_Load(object sender, EventArgs e)
        {
            //this.radCarousel1.EnableAutoLoop = true;
        }

        private void radCarousel1_CarouselElement_ItemEntering(object sender, ItemEnteringEventArgs e)
        {
            RadButtonElement button = (RadButtonElement)this.radCarousel1.Items[e.ItemIndex];
            LoadItemImage(button, true);
        }

        private void LoadItemImage(RadButtonElement button, bool thumbnail)
        {
            if (button != null && !string.IsNullOrEmpty(button.Text) &&
                (button.Image == null || !thumbnail))
            {
                Image res = Image.FromFile(button.Text);

                button.Image = thumbnail
                                   ?
                                       res.GetThumbnailImage((int)(70d * ((double)res.Width / res.Height)),
                                                             70, this.GetThumbnailImageAbort,
                                                             IntPtr.Zero)
                                   :
                                       res;
            }
        }

        private void radCarousel1_CarouselElement_ItemLeaving(object sender, ItemLeavingEventArgs e)
        {
            RadButtonElement button = (RadButtonElement)this.radCarousel1.Items[e.ItemIndex];
            UnloadItemImage(button);
        }

        private void UnloadItemImage(RadButtonElement button)
        {
            if (button != null && button.Image != null)
            {
                button.Image = null;
            }
        }

        private void ResetZoomedItem()
        {
            if (this.zoomedItem == null)
                return;

            ((RadButtonElement)zoomedItem.HostedItem).ButtonFillElement.Visibility = ElementVisibility.Visible;
            //reset the scale size
            ((RadButtonElement)zoomedItem.HostedItem).ImagePrimitive.ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.None;

            AnimatedPropertySetting scaleChange = new AnimatedPropertySetting(
              RadElement.ScaleTransformProperty,
              new SizeF(1f, 1f),
               new SizeF(2, 2),
              20,0
              );

            AnimatedPropertySetting positionChange = new AnimatedPropertySetting(
                RadElement.PositionOffsetProperty,
                new SizeF(0, 0),
                new SizeF(2, 2),
                20,0
                );

            scaleChange.ApplyValue(zoomedItem);
            positionChange.ApplyValue(zoomedItem);

            ((RadButtonElement)zoomedItem.HostedItem).ImagePrimitive.ScaleSize = Size.Empty;

            UnloadItemImage((RadButtonElement)zoomedItem.HostedItem);
            LoadItemImage((RadButtonElement)zoomedItem.HostedItem, true);

            this.zoomedItem = null;
        }

        private void radCarousel1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetZoomedItem();
        }

        private void radCarousel1_CarouselElement_AnimationFinished(object sender, EventArgs e)
        {
            this.animationRunning--;

            if (animationRunning < 0)
                animationRunning = 0;

            if (this.shouldZoomSelectedItem)
                ZoomSelectedItemOnAnimationFinished();
        }

        private void ZoomSelectedItemOnAnimationFinished()
        {
            shouldZoomSelectedItem = true;

            if (this.radCarousel1.SelectedItem != null && animationRunning == 0)
            {
                this.ZoomItem((RadButtonElement)this.radCarousel1.SelectedItem);
            }
        }

        private void radCarousel1_CarouselElement_AnimationStarted(object sender, EventArgs e)
        {
            this.animationRunning++;
            this.ResetZoomedItem();
        }
    }
}