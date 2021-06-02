using RadSplashScreen.Properties;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace RadSplashScreen
{
    public partial class SplashForm : ShapedForm
    {
        public SplashForm()
        {
            InitializeComponent();

            PictureBox spashPictureBox = new PictureBox();
            spashPictureBox.Image = Resources.telerik_logo_RGB_photoshop;
            spashPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            spashPictureBox.Dock = DockStyle.Fill;
            this.Controls.Add(spashPictureBox);

            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
