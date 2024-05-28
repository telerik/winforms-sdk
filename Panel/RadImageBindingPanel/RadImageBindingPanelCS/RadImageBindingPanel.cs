using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using RadImageBindingPanelTest.Properties;
using Telerik.WinControls;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.Themes.Design;
using Telerik.WinControls.UI;

namespace RadImageBindingPanelTest
{
    [Description("Provides a data-bindable image control.")]
    [DefaultBindingProperty("Image"), DefaultEvent("ImageChanged"), DefaultProperty("Image")]
    public class RadImageBindingPanel : RadPanel
    {
        #region Fields

        private Telerik.WinControls.UI.RadButton btClear;
        private Telerik.WinControls.UI.RadButton btPaste;
        private Telerik.WinControls.UI.RadButton btOpenImage;

        #endregion Fields

        #region Public Properties

        public string OpenDialogTitle { get; set; }

        public new string ThemeClassName
        {
            get { return "Telerik.WinControls.UI.RadPanel"; }
        }

        public Size ButtonSize
        {
            get
            {
                return btOpenImage.Size;
            }
            set
            {
                btOpenImage.Size = value;
                btClear.Size = value;
                btPaste.Size = value;
                DoResize();
            }
        }

        [Bindable(true), RefreshProperties(RefreshProperties.All), Description("Gets or sets the Image of the control."), Category("Behavior")]
        public Image Image
        {
            get
            {
                return BackgroundImage;
            }
            set
            {
                BackgroundImage = value;
                OnImageChanged();
            }
        }

        public bool ReadOnly
        {
            get
            {
                return !btOpenImage.Visible;
            }
            set
            {
                btOpenImage.Visible = !value;
                btClear.Visible = !value;
                btPaste.Visible = !value;
                ((BorderPrimitive)(this.GetChildAt(0).GetChildAt(1))).ShouldPaint = !value;
                BackColor = value ? Color.Transparent : SystemColors.ControlLightLight;
            }
        }

        #endregion Public Properties

        #region Public Events

        public event EventHandler ImageChanged;

        private void OnImageChanged()
        {
            // Update Bindings
            foreach (Binding b in DataBindings)
            {
                if (b.PropertyName == "Image")
                    b.WriteValue();
            }

            // Fire Event
            if (ImageChanged != null)
                ImageChanged(this, EventArgs.Empty);

            Text = (Image == null && !ReadOnly) ?
                "Click the folder icon to open an image file or click on the clipboard to paste an image from the clipboard." :
                Text = string.Empty;
        }

        #endregion Public Events

        #region Constructor, Initialize

        protected override void CreateChildItems(RadElement parent)
        {
            base.CreateChildItems(parent);

            btOpenImage = new RadButton();
            btOpenImage.Dock = DockStyle.Top;
            btOpenImage.Image = Resources.btOpenImage_Image;
            btOpenImage.Click += new EventHandler(btOpenImage_Click);
            btOpenImage.ToolTipTextNeeded += new ToolTipTextNeededEventHandler(btOpenImage_ToolTipTextNeeded);

            btClear = new RadButton();
            btClear.Dock = DockStyle.Top;
            btClear.Image = Resources.btClear_Image;
            btClear.Click += new EventHandler(btClear_Click);
            btClear.ToolTipTextNeeded += new ToolTipTextNeededEventHandler(btClear_ToolTipTextNeeded);

            btPaste = new RadButton();
            btPaste.Dock = DockStyle.Top;
            btPaste.Image = Resources.btPaste_Image;
            btPaste.Click += new EventHandler(btPaste_Click);

            this.Controls.Add(btClear);
            this.Controls.Add(btOpenImage);
            this.Controls.Add(btPaste);
        }

        public RadImageBindingPanel()
            : base()
        {
            ((BorderPrimitive)this.PanelElement.Children[1]).ForeColor = System.Drawing.Color.FromArgb(173, 195, 222);
            ((TextPrimitive)this.PanelElement.GetChildAt(2)).TextWrap = true;

            HideButtonBackground(btClear);
            HideButtonBackground(btOpenImage);
            HideButtonBackground(btPaste);

            OpenDialogTitle = "Open Image";
            ButtonSize = new Size(20, 20);
            ReadOnly = false;
            Text = string.Empty;
            BackgroundImageLayout = ImageLayout.Zoom;
        }

        #endregion Constructor, Initialize

        #region Button Event Handlers

        private void btOpenImage_Click(object sender, EventArgs e)
        {
            DoOpen();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            Image = null;
        }

        private void RadImageBindingPanel_Resize(object sender, EventArgs e)
        {
            DoResize();
        }

        private void btPaste_Click(object sender, EventArgs e)
        {
            DoPaste();
        }

        private void btOpenImage_ToolTipTextNeeded(object sender, ToolTipTextNeededEventArgs e)
        {
            e.ToolTipText = "Open Image";
        }

        private void btClear_ToolTipTextNeeded(object sender, ToolTipTextNeededEventArgs e)
        {
            e.ToolTipText = "Clear Image";
        }

        #endregion Button Event Handlers

        #region Private Methods

        private void DoOpen()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.CheckFileExists = true;
            ofd.Filter = "Image Files (*.*)|*.*";
            ofd.Multiselect = false;
            ofd.Title = OpenDialogTitle;
            if (ofd.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                Image = Image.FromFile(ofd.FileName);
            }
            catch (OutOfMemoryException)
            {
                ShowError("Invalid image format.");
            }
            catch (FileNotFoundException)
            {
                ShowError("The file specified does not exist.");
            }
            catch (ArgumentException)
            {
                ShowError("Remote image loading is not supported.");
            }
            catch
            {
                ShowError("An unknown error occured opening the image.");
            }
        }

        private void DoResize()
        {
            btOpenImage.Location = new Point(Width - 3 * btOpenImage.Width, Height - btOpenImage.Height);
            btPaste.Location = new Point(Width - 2 * btOpenImage.Width, Height - btOpenImage.Height);
            btClear.Location = new Point(Width - btOpenImage.Width, Height - btOpenImage.Height);
        }

        private void DoPaste()
        {
            IDataObject obj = Clipboard.GetDataObject();
            if (obj == null)
            {
                ShowError("The clipboard is empty.");
                return;
            }
            if (!obj.GetDataPresent(DataFormats.Bitmap))
            {
                ShowError("The clipboard does not contain a valid image.");
                return;
            }
            Image = (Image)obj.GetData(DataFormats.Bitmap, true);
        }

        private DialogResult ShowError(string message)
        {
            return RadMessageBox.Show(message, "Error", MessageBoxButtons.OK, RadMessageIcon.Error);
        }

        private void HideButtonBackground(RadButton button)
        {
            button.BackColor = Color.Transparent;
            button.ButtonElement.ButtonFillElement.ShouldPaint = false;
            button.ButtonElement.BorderElement.ShouldPaint = false;
        }

        #endregion Private Methods
    }
}