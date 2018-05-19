using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testexListBox;
using TagLib;
using System.IO;

namespace KMN_Media
{
    public partial class MainForm : Form
    {
        #region Variable
        string local = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyMusic);
        string temp;
        string temp_time;
        string temp_album;
        Image temp_Image = null;
        bool checkmute = true;
        bool RunWMP = false;
        bool CheckStop = false;
        bool CheckRepeat = false;
        bool CheckShuffer = false;
        Random rd = new Random();
        #endregion
        public MainForm()
        {
            InitializeComponent();
        }
        private void CreateMusicList()
        {
            exListBox1.Items.Clear();
            string[] files = Directory.GetFiles(local);
            foreach (string file in files)
            {
                int i = 0;
                string fileExtexsion = Path.GetExtension(file).Trim();
                if (fileExtexsion == ".mp3" || fileExtexsion == ".m4a" || fileExtexsion == ".wav")
                {
                    getimageMp3(file);
                    exListBox1.Items.Add(new exListBoxItem(i, temp, temp_time, temp_album, file, temp_Image));
                    i++;
                }
            }
        }
        private void getimageMp3(string filename)
        {
            var file = TagLib.File.Create(filename);
            temp = file.Tag.Title;
            temp_time = file.Properties.Duration.ToString();
            temp_album = file.Tag.Album;
            try
            {
                if (file.Tag.Pictures != null)
                {
                    var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                    temp_Image = Image.FromStream(new MemoryStream(bin));
                }
            }
            catch (Exception e)
            {

            }

        }
        private void MainForm_Load(object sender, EventArgs e)
        {

            CreateMusicList();
        }
        private void exListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer1.Start();
            tbTime.Val = 0;
            exListBoxItem item = exListBox1.SelectedItem as exListBoxItem;
            axWindowsMediaPlayer1.URL = item.Path;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            picSong.Image = item.Img;
            lbSongName.Text = item.Title;
            lbDuration.Text = item.Album;
            TBvolume.Val = 50;
            RunWMP = true;
            CheckStop = false;

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (RunWMP == true)
            {
                tbTime.Val += 1;
                lbMin.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
            }
            ChangeMode();
            CheckMuteButton();
        }

        private void tbTime_MouseClick(object sender, MouseEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = tbTime.Val;
        }

        private void imbForward_Load(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (CheckStop == false)
            {
                if (e.newState == 1)
                {
                    if (CheckRepeat == true)
                    {
                        ResetStatus();
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                    }
                    else
                    {
                        if (CheckShuffer == true)
                        {
                            int i = rd.Next(0, exListBox1.Items.Count - 1);
                            BeginInvoke(new Action(() =>
                            {

                                exListBox1.SelectedItem = exListBox1.Items[i];
                            }));
                        }
                        else
                        {
                            if (exListBox1.SelectedIndex != exListBox1.Items.Count - 1)
                            {
                                BeginInvoke(new Action(() =>
                                {
                                    exListBox1.SelectedIndex = exListBox1.SelectedIndex + 1;
                                }));
                            }
                        }
                    }
                }
            }
        }

        private void imbForward_MouseClick(object sender, MouseEventArgs e)
        {
            if (exListBox1.SelectedIndex != exListBox1.Items.Count - 1)
            {
                BeginInvoke(new Action(() => {
                    exListBox1.SelectedIndex = exListBox1.SelectedIndex + 1;
                }));
            }
        }

        private void imbBack_MouseClick(object sender, MouseEventArgs e)
        {
            if (exListBox1.SelectedIndex != exListBox1.Items.Count + 1)
            {
                BeginInvoke(new Action(() => {
                    exListBox1.SelectedIndex = exListBox1.SelectedIndex - 1;
                }));
            }
        }

        private void imbPlayPause_MouseClick(object sender, MouseEventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                timer1.Stop();
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                timer1.Start();
            }
        }

        private void trackBar1_MouseClick(object sender, MouseEventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = TBvolume.Val;
        }

        private void imbVolume_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkmute == true)
            {
                checkmute = false;
            }
            else checkmute = true;
        }
        private void CheckMuteButton()
        {
            if (checkmute == true)
            {
                axWindowsMediaPlayer1.settings.volume = TBvolume.Val;
            }
            if (checkmute == false)
            {
                axWindowsMediaPlayer1.settings.volume = 0;
            }
        }

        private void imbStop_MouseClick(object sender, MouseEventArgs e)
        {
            CheckStop = true;
            ResetStatus();
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            timer1.Stop();
        }

        private void axWindowsMediaPlayer1_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            if (e.newState == (int)WMPLib.WMPOpenState.wmposMediaOpen)
            {
                tbTime.Max = (int)axWindowsMediaPlayer1.currentMedia.duration;
                lbMax.Text = axWindowsMediaPlayer1.currentMedia.durationString;
            }
        }

        private void imbRepeat_MouseClick(object sender, MouseEventArgs e)
        {
            if (CheckRepeat == false)
            {
                CheckRepeat = true;
            }
            else CheckRepeat = false;
        }
        private void ResetStatus()
        {
            tbTime.Val = 0;
            lbMin.Text = "00:00";
        }

        private void imbShuffle_MouseClick(object sender, MouseEventArgs e)
        {
            if (CheckShuffer == false)
            {
                CheckShuffer = true;
            }
            else CheckShuffer = false;
        }
        private void ChangeMode()
        {
            if (CheckShuffer == true)
            {
                CheckRepeat = false;
            }
            if (CheckRepeat == true)
            {
                CheckShuffer = false;
            }
        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {
            CreateMusicList();
        }
    }
}
