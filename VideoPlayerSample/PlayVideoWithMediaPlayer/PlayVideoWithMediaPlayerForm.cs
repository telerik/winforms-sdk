using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace VideoPlayer
{
    public partial class PlayVideoWithMediaPlayerForm : Telerik.WinControls.UI.RadForm
    {
        public PlayVideoWithMediaPlayerForm()
        {
            InitializeComponent();
            
            ThemeResolutionService.ApplicationThemeName = "TelerikMetro";

            FileInfo fi = new FileInfo(@"..\..\..\SampleVideos\Arc_de_Triomphe.mp4");
            this.axWindowsMediaPlayer1.URL = fi.FullName;
            this.axWindowsMediaPlayer1.settings.setMode("loop", true);
        }
    }
}