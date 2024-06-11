using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Layouts;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.UI;

namespace AppPortfolio
{
    public class AppDetailsPanel : RadControl
    {
        private AppDetailsPanelElement panelElement = null;

        static AppDetailsPanel()
        {
            ThemeResolutionService.LoadPackageResource("AppPortfolio.Resources.AppPortfolioTheme.tssp");
        }

        public AppDetailsPanel()
        {
            this.Size = new Size(950, 450);
            this.Location = new Point(0, 50);
            this.ThemeName = "AppPortfolioTheme";
            this.KeyDown += new KeyEventHandler(AppDetailsPanel_KeyDown);
        }

        private void AppDetailsPanel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                this.PanelElement.PerformInitAnimation();
            else if (e.KeyCode == Keys.Escape)
                this.Hide();
        }

        public AppDetailsPanelElement PanelElement
        {
            get
            {
                return this.panelElement;
            }
        }

        public PortfolioButtonElement PortfolioButton
        {
            get
            {
                return this.panelElement.PortfolioButton;
            }
            set
            {
                this.panelElement.PortfolioButton = value;
            }
        }

        protected override void OnDoubleClick(EventArgs e)
        {
            base.OnDoubleClick(e);

            this.Hide();
        }

        protected override void CreateChildItems(RadElement parent)
        {
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImage = Properties.Resources.BackgroundItemBig;

            base.CreateChildItems(parent);

            this.panelElement = new AppDetailsPanelElement();
            parent.Children.Add(this.panelElement);
        }
    }

    public class AppDetailsPanelElement : RadPanelElement
    {
        private ImagePrimitive productImage = null;
        private TextPrimitive titleLabel = null;
        private TextPrimitive descriptionLabel = null;
        private RadButtonElement buttonElement = null;
        private RadButtonElement backButtonElement = null;

        private PortfolioButtonElement portfolioButton;

        public Image ProductImage
        {
            get
            {
                return this.productImage.Image;
            }
            set
            {
                this.productImage.Image = value;
            }
        }

        public string Title
        {
            get
            {
                return this.titleLabel.Text;
            }
            set
            {
                this.titleLabel.Text = value;
            }
        }

        public string Description
        {
            get
            {
                return this.descriptionLabel.Text;
            }
            set
            {
                this.descriptionLabel.Text = value;
            }
        }

        public PortfolioButtonElement PortfolioButton
        {
            get
            {
                return portfolioButton;
            }
            set
            {
                if (this.portfolioButton != value)
                {
                    this.portfolioButton = value;

                    if (this.portfolioButton != null)
                    {
                        this.productImage.Image = this.portfolioButton.GetProductImage();
                        this.titleLabel.Text = this.portfolioButton.ProductTitle;
                        this.descriptionLabel.Text = this.portfolioButton.ProductDescription;
                    }
                    else
                    {
                        this.productImage.Image = null;
                        this.titleLabel.Text = string.Empty;
                        this.descriptionLabel.Text = string.Empty;
                    }
                }
            }
        }

        protected override void CreateChildElements()
        {
            base.CreateChildElements();

            this.productImage = new ImagePrimitive();
            this.productImage.Image = Properties.Resources.Telerik;

            this.descriptionLabel = new TextPrimitive();
            this.descriptionLabel.ForeColor = Color.White;
            this.descriptionLabel.Font = new Font("Segoe UI", 10f);
            this.descriptionLabel.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.descriptionLabel.StretchHorizontally = true;
            this.descriptionLabel.TextAlignment = ContentAlignment.TopLeft;
            this.descriptionLabel.MaxSize = new Size(450, 0);
            this.descriptionLabel.MinSize = new Size(0, 200);
            this.descriptionLabel.TextWrap = true;
            this.descriptionLabel.Text = "Description";

            this.titleLabel = new TextPrimitive();
            this.titleLabel.Margin = new Padding(0, 0, 0, 20);
            this.titleLabel.ForeColor = Color.Red;
            this.titleLabel.Font = new Font("Verdana", 20f, FontStyle.Bold);
            this.titleLabel.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.titleLabel.Text = "Title";

            BoxLayout verticalButtonLayout = new BoxLayout();
            verticalButtonLayout.Orientation = Orientation.Horizontal;
            this.buttonElement = new RadButtonElement();
            this.buttonElement.StretchHorizontally = false;
            this.buttonElement.StretchVertically = false;
            this.buttonElement.Text = "SEE DEMO";
            this.buttonElement.Click += new EventHandler(buttonElement_Click);

            this.backButtonElement = new RadButtonElement();
            this.backButtonElement.StretchHorizontally = false;
            this.backButtonElement.StretchVertically = false;
            this.backButtonElement.Text = "BACK";
            this.backButtonElement.Click += new EventHandler(backButtonElement_Click);

            verticalButtonLayout.Children.Add(buttonElement);
            verticalButtonLayout.Children.Add(backButtonElement);

            BoxLayout verticalLayout = new BoxLayout();
            verticalLayout.Orientation = System.Windows.Forms.Orientation.Vertical;
            verticalLayout.Children.Add(this.titleLabel);
            verticalLayout.Children.Add(this.descriptionLabel);
            //  verticalLayout.Children.Add(this.buttonElement);
            //  verticalLayout.Children.Add(this.backButtonElement);
            verticalLayout.Children.Add(verticalButtonLayout);

            BoxLayout horizontalLayout = new BoxLayout();
            horizontalLayout.Margin = new Padding(20);
            horizontalLayout.StretchHorizontally = true;
            horizontalLayout.StretchVertically = true;
            horizontalLayout.Orientation = System.Windows.Forms.Orientation.Horizontal;

            BoxLayout.SetProportion(this.productImage, 1);
            BoxLayout.SetProportion(verticalLayout, 1);
            horizontalLayout.Children.Add(this.productImage);
            horizontalLayout.Children.Add(verticalLayout);

            this.Children.Add(horizontalLayout);
        }

        private void backButtonElement_Click(object sender, EventArgs e)
        {
            this.ElementTree.Control.Hide();
        }

        private void buttonElement_Click(object sender, EventArgs e)
        {
            if (this.portfolioButton != null)
            {
                this.PortfolioButton.ExecuteCommand();
            }
        }

        public void PerformInitAnimation()
        {
            AnimatedPropertySetting setting = new AnimatedPropertySetting(
                            RadElement.MarginProperty,
                            new Padding(0, 20, 0, 0),
                            new Padding(0, 0, 0, 0),
                            10,
                            40);

            AnimatedPropertySetting setting1 = new AnimatedPropertySetting(
                            VisualElement.OpacityProperty,
                            0d,
                            1d,
                            10,
                            40);

            setting.ApplyValue(this.productImage);
            setting.ApplyValue(this.descriptionLabel);

            setting1.ApplyValue(this.productImage);
            setting1.ApplyValue(this.descriptionLabel);
            setting1.ApplyValue(this.titleLabel);

            setting = new AnimatedPropertySetting(
                            RadElement.MarginProperty,
                            new Padding(0, 20, 0, 20),
                            new Padding(0, 0, 0, 20),
                            10,
                            40);

            setting.ApplyValue(this.titleLabel);
        }
    }
}