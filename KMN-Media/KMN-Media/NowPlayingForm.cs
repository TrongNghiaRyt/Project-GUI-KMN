using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMN_Media
{
    public partial class NowPlayingForm : Form
    {
        private string path;
        bool RunMedia = false;
        bool CheckFs = false;
        bool CheckMute = true;
        public NowPlayingForm()
        {
            InitializeComponent();
        }

        public string Path
        {
            get
            {
                return path;
            }

            set
            {
                path = value;
            }
        }

        private void NowPlayingForm_Load(object sender, EventArgs e)
        {
            MediaPlayer.URL = Path;
            MediaPlayer.Ctlcontrols.play();
            tbVolume.Max = 100;
            tbVolume.Val = 50;
            MediaPlayer.settings.volume = tbVolume.Val;
            RunMedia = true;
        }
        private void axWindowsMediaPlayer1_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            if (e.newState == (int)WMPLib.WMPOpenState.wmposMediaOpen)
            {
                tbDuration.Max = (int)MediaPlayer.currentMedia.duration;
                MaxLength.Text = MediaPlayer.currentMedia.durationString;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (RunMedia == true)
            {
                tbDuration.Val += 1;
                MinLength.Text = MediaPlayer.Ctlcontrols.currentPositionString;
            }
            CheckMuteButton();
        }

        private void imbFullscreen_Load(object sender, EventArgs e)
        {
           
        }

        private void tbVolume_MouseClick(object sender, MouseEventArgs e)
        {
            MediaPlayer.settings.volume = tbVolume.Val;
        }

        private void imbVolume_MouseClick(object sender, MouseEventArgs e)
        {
            if (CheckMute == true)
            {
                CheckMute = false;  
            }
            else
            {
                CheckMute = true;
            }
        }

        private void imbFullscreen_Click(object sender, EventArgs e)
        {
            //if (CheckFs == false)
            //{
            //    MediaPlayer.fullScreen = true;
            //    CheckFs = true;

            //}
            //else
            //{
            //    MediaPlayer.fullScreen = false;
            //    CheckFs = false;
            //}
            if (CheckFs == false)
            {
                SetFullscreen();
                CheckFs = true;
            }
            else
            {
                SetNormailScreen();
                CheckFs = false;
            }
        }
        private void CheckMuteButton()
        {
            if (CheckMute == true)
            {
                MediaPlayer.settings.volume = tbVolume.Val;
            }
            if (CheckMute == false)
            {
                MediaPlayer.settings.volume = 0;
            }
        }

        private void imbPlay_MouseClick(object sender, MouseEventArgs e)
        {
            if (MediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                MediaPlayer.Ctlcontrols.pause();
                timer1.Stop();
            }
            else
            {
                MediaPlayer.Ctlcontrols.play();
                timer1.Start();
            }
        }

        private void imbNext_MouseClick(object sender, MouseEventArgs e)
        {
            MediaPlayer.Ctlcontrols.currentPosition += 30;
            tbDuration.Val += 30;
        }

        private void imbPrevious_MouseClick(object sender, MouseEventArgs e)
        {
            MediaPlayer.Ctlcontrols.currentPosition -= 10;
            tbDuration.Val -= 10;
        }

        private void imbStop_MouseClick(object sender, MouseEventArgs e)
        {
            MediaPlayer.Ctlcontrols.stop();
            ResetStatus();
        }
        private void ResetStatus()
        {
            tbDuration.Val = 0;
            MinLength.Text = "00:00";
        }

        private void tbDuration_MouseClick(object sender, MouseEventArgs e)
        {
            MediaPlayer.Ctlcontrols.currentPosition = tbDuration.Val;
        }

        private void SetFullscreen()
        {
            this.WindowState= FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;
            MediaPlayer.Width = this.Width;
            MediaPlayer.Height = this.Height - 76;
            
        }
        private void SetNormailScreen()
        {
            this.WindowState = FormWindowState.Normal;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MediaPlayer.Width = 800;
            MediaPlayer.Height = 515;
            panel1.Width = 800;
            panel1.Height = 76;
        }
    }
}
