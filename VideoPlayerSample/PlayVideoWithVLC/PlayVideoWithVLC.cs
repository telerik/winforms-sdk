using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Vlc.DotNet.Forms;

namespace VideoPlayer
{
    public partial class PlayVideoWithVLC : Telerik.WinControls.UI.RadForm
    {
        string[] mediaOptions = new string[] {"input-repeat=-1"};  public PlayVideoWithVLC()
        {
            InitializeComponent();
            this.myCbxAspectRatio.SelectedIndex = 0;

            ThemeResolutionService.ApplicationThemeName = "TelerikMetro";
        }

        private void OnVlcControlNeedLibDirectory(object sender, VlcLibDirectoryNeededEventArgs e)
        {
            var currentAssembly = Assembly.GetEntryAssembly();
            var currentDirectory = new FileInfo(currentAssembly.Location).DirectoryName;
            if (currentDirectory == null)
                return;
            if (IntPtr.Size == 4)
                e.VlcLibDirectory = new DirectoryInfo(@"..\..\..\lib\x86\");
            else
                e.VlcLibDirectory = new DirectoryInfo(Path.Combine(currentDirectory, @"..\..\..\lib\x64\"));

            if (!e.VlcLibDirectory.Exists)
            {
                var folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
                folderBrowserDialog.Description = "Select Vlc libraries folder.";
                folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;
                folderBrowserDialog.ShowNewFolderButton = true;
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    e.VlcLibDirectory = new DirectoryInfo(folderBrowserDialog.SelectedPath);
                }
            }
        }

        private void OnButtonPlayClicked(object sender, EventArgs e)
        {
            //myVlcControl.SetMedia(new Uri("http://download.blender.org/peach/bigbuckbunny_movies/big_buck_bunny_480p_surround-fix.avi"),mediaOptions);
            // myVlcControl.Play(new Uri("http://download.blender.org/peach/bigbuckbunny_movies/big_buck_bunny_480p_surround-fix.avi"));
            
             myVlcControl.SetMedia(new FileInfo(@"..\..\..\SampleVideos\Arc_de_Triomphe.mp4"),mediaOptions);
             myVlcControl.Play(); 
        }

        private void OnButtonStopClicked(object sender, EventArgs e)
        {
            myVlcControl.Stop();
        }

        private void OnButtonPauseClicked(object sender, EventArgs e)
        {
            myVlcControl.Pause();
        }

        private void OnVlcMediaLengthChanged(object sender, Vlc.DotNet.Core.VlcMediaPlayerLengthChangedEventArgs e)
        {
            #if !NET20
            myLblMediaLength.InvokeIfRequired(l => l.Text = new DateTime(new TimeSpan((long)e.NewLength).Ticks).ToString("mm:ss"));
            #else
            ControlExtensions.InvokeIfRequired(myLblMediaLength, l => l.Text = new DateTime(new TimeSpan((long)e.NewLength).Ticks).ToString("T"));
            #endif
        }

        private void OnVlcPositionChanged(object sender, Vlc.DotNet.Core.VlcMediaPlayerPositionChangedEventArgs e)
        {
            var position = myVlcControl.GetCurrentMedia().Duration.Ticks * e.NewPosition;
            #if !NET20
            myLblVlcPosition.InvokeIfRequired(l => l.Text = new DateTime((long)position).ToString("mm:ss"));
            #else
            ControlExtensions.InvokeIfRequired(myLblVlcPosition, c => c.Text = new DateTime((long)position).ToString("T"));
            #endif
        }

        private void OnVlcPaused(object sender, Vlc.DotNet.Core.VlcMediaPlayerPausedEventArgs e)
        {
            #if !NET20
            myLblState.InvokeIfRequired(l => l.Text = "Paused");
            #else
            ControlExtensions.InvokeIfRequired(myLblState, c => c.Text = "Paused");
            #endif
        }

        private void OnVlcStopped(object sender, Vlc.DotNet.Core.VlcMediaPlayerStoppedEventArgs e)
        {
            #if !NET20
            myLblState.InvokeIfRequired(l => l.Text = "Stopped");

            myCbxAspectRatio.InvokeIfRequired(c =>
            {
                c.Text = string.Empty;
                c.Enabled = false;
            });
            #else
            ControlExtensions.InvokeIfRequired(myLblState, c => c.Text = "Stopped");

            ControlExtensions.InvokeIfRequired(myCbxAspectRatio, c =>
            {
                c.Text = string.Empty;
                c.Enabled = false;
            });
            #endif
            ControlExtensions.InvokeIfRequired(myLblAudioCodec, c => c.Text = "Codec: ");
            ControlExtensions.InvokeIfRequired(myLblAudioChannels, c => c.Text = "Channels: ");
            ControlExtensions.InvokeIfRequired(myLblAudioRate, c => c.Text = "Rate: ");
            ControlExtensions.InvokeIfRequired(myLblVideoCodec, c => c.Text = "Codec: ");
            ControlExtensions.InvokeIfRequired(myLblVideoHeight, c => c.Text = "Height: ");
            ControlExtensions.InvokeIfRequired(myLblVideoWidth, c => c.Text = "Width: ");
        }

        private void OnVlcPlaying(object sender, Vlc.DotNet.Core.VlcMediaPlayerPlayingEventArgs e)
        {
            #if !NET20
            myLblState.InvokeIfRequired(l => l.Text = "Playing");

            myLblAudioCodec.InvokeIfRequired(l => l.Text = "Codec: ");
            myLblAudioChannels.InvokeIfRequired(l => l.Text = "Channels: ");
            myLblAudioRate.InvokeIfRequired(l => l.Text = "Rate: ");
            myLblVideoCodec.InvokeIfRequired(l => l.Text = "Codec: ");
            myLblVideoHeight.InvokeIfRequired(l => l.Text = "Height: ");
            myLblVideoWidth.InvokeIfRequired(l => l.Text = "Width: ");

            var mediaInformations = myVlcControl.GetCurrentMedia().TracksInformations;
            foreach (var mediaInformation in mediaInformations)
            {
                if (mediaInformation.Type == Vlc.DotNet.Core.Interops.Signatures.MediaTrackTypes.Audio)
                {
                    myLblAudioCodec.InvokeIfRequired(l => l.Text += mediaInformation.CodecName);
                    myLblAudioChannels.InvokeIfRequired(l => l.Text += mediaInformation.Audio.Channels);
                    myLblAudioRate.InvokeIfRequired(l => l.Text += mediaInformation.Audio.Rate);
                }
                else if (mediaInformation.Type == Vlc.DotNet.Core.Interops.Signatures.MediaTrackTypes.Video)
                {
                    myLblVideoCodec.InvokeIfRequired(l => l.Text += mediaInformation.CodecName);
                    myLblVideoHeight.InvokeIfRequired(l => l.Text += mediaInformation.Video.Height);
                    myLblVideoWidth.InvokeIfRequired(l => l.Text += mediaInformation.Video.Width);
                }
            }

            myCbxAspectRatio.InvokeIfRequired(c =>
            {
                if (myVlcControl.Video.AspectRatio != null)
                {
                    c.Text = myVlcControl.Video.AspectRatio;
                }
                
                c.Enabled = true;
            });
            #else
            ControlExtensions.InvokeIfRequired(myLblState, c => c.Text = "Playing");
            ControlExtensions.InvokeIfRequired(myLblAudioCodec, c => c.Text = "Codec: ");
            ControlExtensions.InvokeIfRequired(myLblAudioChannels, c => c.Text = "Channels: ");
            ControlExtensions.InvokeIfRequired(myLblAudioRate, c => c.Text = "Rate: ");
            ControlExtensions.InvokeIfRequired(myLblVideoCodec, c => c.Text = "Codec: ");
            ControlExtensions.InvokeIfRequired(myLblVideoHeight, c => c.Text = "Height: ");
            ControlExtensions.InvokeIfRequired(myLblVideoWidth, c => c.Text = "Width: ");
            var mediaInformations = myVlcControl.GetCurrentMedia().TracksInformations;
            foreach (var mediaInformation in mediaInformations)
            {
                if (mediaInformation.Type == Core.Interops.Signatures.MediaTrackTypes.Audio)
                {
                    ControlExtensions.InvokeIfRequired(myLblAudioCodec, c => c.Text += mediaInformation.CodecName);
                    ControlExtensions.InvokeIfRequired(myLblAudioChannels, c => c.Text += mediaInformation.Audio.Channels);
                    ControlExtensions.InvokeIfRequired(myLblAudioRate, c => c.Text += mediaInformation.Audio.Rate);
                }
                else if (mediaInformation.Type == Core.Interops.Signatures.MediaTrackTypes.Video)
                {
                    ControlExtensions.InvokeIfRequired(myLblVideoCodec, c => c.Text += mediaInformation.CodecName);
                    ControlExtensions.InvokeIfRequired(myLblVideoHeight, c => c.Text += mediaInformation.Video.Height);
                    ControlExtensions.InvokeIfRequired(myLblVideoWidth, c => c.Text += mediaInformation.Video.Width);
                }
            }
            ControlExtensions.InvokeIfRequired(myCbxAspectRatio, c =>
            {
                c.Text = myVlcControl.Video.AspectRatio;
                c.Enabled = true;
            });
            #endif
        }

        private void myCbxAspectRatio_TextChanged(object sender, EventArgs e)
        {
            myVlcControl.Video.AspectRatio = myCbxAspectRatio.Text;
            ResizeVlcControl();
        }
        
        void ResizeVlcControl()
        {
            if (!string.IsNullOrEmpty(myCbxAspectRatio.Text))
            {
                var ratio = myCbxAspectRatio.Text.Split(':');
                int width, height;
                if (ratio.Length == 2 && int.TryParse(ratio[0], out width) && int.TryParse(ratio[1], out height))
                    myVlcControl.Width = myVlcControl.Height * width / height;
            }
        }

        private void OnVlcMediaPlayerLog(object sender, Vlc.DotNet.Core.VlcMediaPlayerLogEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(string.Format("libVlc : {0} {1} @ {2}", e.Level, e.Message, e.Module));
        }

        private void PlayVideoWithVLC_SizeChanged(object sender, EventArgs e)
        {
            ResizeVlcControl();
        }
    }
}