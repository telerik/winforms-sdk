using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.UI;

namespace AppPortfolio
{
    public partial class Form1 : ShapedForm
    {
        RadLabelElement carouselLabelElement = null;

        public Form1()
        {
            InitializeComponent();

            ThemeResolutionService.LoadPackageResource("AppPortfolio.Resources.AppPortfolioTheme.tssp");
            this.radTitleBar1.ThemeName = "AppPortfolioTheme";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.carouselLabelElement = new RadLabelElement();
            this.carouselLabelElement.Font = new Font("Verdana", 13f, FontStyle.Bold);
            this.carouselLabelElement.ZIndex = 5;
            this.carouselLabelElement.StretchHorizontally = false;
            this.carouselLabelElement.StretchVertically = false;
            this.carouselLabelElement.TextAlignment = ContentAlignment.MiddleRight;
            this.carouselLabelElement.Alignment = ContentAlignment.BottomCenter;
            this.carouselLabelElement.Margin = new Padding(10, 0, 0, 110);

            this.SetSelectedItemText();

            this.radCarousel1.CarouselElement.Children.Add(this.carouselLabelElement);

            ImagePrimitive winFormsImage = new ImagePrimitive();
            winFormsImage.Image = Properties.Resources.WinForms;
            winFormsImage.Alignment = ContentAlignment.TopLeft;
            winFormsImage.Margin = new Padding(20, 20, 0, 0);
            this.radCarousel1.CarouselElement.Children.Add(winFormsImage);

            ImagePrimitive telerikImage = new ImagePrimitive();
            telerikImage.Image = Properties.Resources.Telerik;
            telerikImage.Alignment = ContentAlignment.BottomRight;
            telerikImage.Margin = new Padding(0, 0, 20, 20);
            this.radCarousel1.CarouselElement.Children.Add(telerikImage);

            this.radCarousel1.SelectedValueChanged += new EventHandler(radCarousel1_SelectedValueChanged);

            foreach (RadItem item in this.radCarousel1.Items)
            {
                item.MouseDown += new MouseEventHandler(item_MouseDown);
            }

            this.radCarousel1.CarouselElement.AnimationStarted += new EventHandler(CarouselElement_AnimationStarted);
        }

        private AppDetailsPanel detailsPanel = null;

        private void item_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender != this.radCarousel1.SelectedItem)
            {
                return;
            }

            if (this.detailsPanel == null)
            {
                this.detailsPanel = new AppDetailsPanel();
                this.detailsPanel.Hide();
                this.detailsPanel.VisibleChanged += new EventHandler(detailsPanel_VisibleChanged);
                this.Controls.Add(detailsPanel);
            }

            this.detailsPanel.PortfolioButton = sender as PortfolioButtonElement;

            this.detailsPanel.Location = new Point(
                (this.Width - detailsPanel.Width) / 2,
                (this.Height - detailsPanel.Height) / 2);
            this.detailsPanel.Show();
            this.detailsPanel.BringToFront();
            this.detailsPanel.Focus();
        }

        private void detailsPanel_VisibleChanged(object sender, EventArgs e)
        {
            this.radCarousel1.EnableAutoLoop = !this.detailsPanel.Visible;

            if (this.detailsPanel.Visible)
            {
                this.detailsPanel.PanelElement.PerformInitAnimation();
            }
        }

        private void radCarousel1_SelectedValueChanged(object sender, EventArgs e)
        {
            this.SetSelectedItemText();
        }

        private void CarouselElement_AnimationStarted(object sender, EventArgs e)
        {
            AnimatedPropertySetting setting = new AnimatedPropertySetting();
            setting.Property = VisualElement.ForeColorProperty;
            setting.EndValue = Color.Transparent;
            setting.NumFrames = 10;
            setting.Interval = 40;

            if (this.carouselLabelElement != null)
            {
                setting.ApplyValue(this.carouselLabelElement);
            }
        }

        private void SetSelectedItemText()
        {
            if (this.carouselLabelElement == null)
            {
                return;
            }

            PortfolioButtonElement selectedElement = null;
            if (this.radCarousel1 != null)
            {
                selectedElement = this.radCarousel1.SelectedItem as PortfolioButtonElement;
            }

            string text = (selectedElement != null) ? selectedElement.Text : "Select Item";
            this.carouselLabelElement.Text = text;

            //Animate selected text

            AnimatedPropertySetting setting = new AnimatedPropertySetting(
                VisualElement.ForeColorProperty,
                Color.Transparent,
                Color.White,
                10,
                40);

            setting.ApplyValue(this.carouselLabelElement);
        }

        private void radCarousel1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    this.WindowState = FormWindowState.Normal;
                    this.FormBorderStyle = FormBorderStyle.Sizable;
                }
                else
                {
                    this.FormBorderStyle = FormBorderStyle.None;
                    this.WindowState = FormWindowState.Maximized;
                }
            }
            else if (e.KeyCode == Keys.F5)
            {
                this.radCarousel1.EnableAutoLoop = !this.radCarousel1.EnableAutoLoop;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                if (this.detailsPanel != null && this.detailsPanel.Visible)
                    this.detailsPanel.Hide();
            }
        }
    }
}