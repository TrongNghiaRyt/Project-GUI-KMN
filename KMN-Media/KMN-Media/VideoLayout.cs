using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace KMN_Media
{
    public partial class VideoLayout : UserControl
    {
        public VideoLayout()
        {
            InitializeComponent();
        }
        public VideoLayout(string path)
        {
            PathOfVideoUser = path;
            InitializeComponent();
        }

        private int itime = 0;

        private string _path;

        private string _NameOfVideo;

        private string pathOfVideoUser;
        private string nameOfVideoUser;
        public string PathOfVideoUser
        {
            get
            {
                return pathOfVideoUser;
            }

            set
            {
                pathOfVideoUser = value;
            }
        }

        public string NameOfVideoUser
        {
            get
            {
                return nameOfVideoUser;
            }

            set
            {
                nameOfVideoUser = value;
            }
        }


        private void UserControl3_Load(object sender, EventArgs e)
        {
            //using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = true, ValidateNames = true, Filter = "WMV|*.wmv|WAV|*.wav|MP3*|*.mp3|MP4|*.mp4|MKV|*.mkv" })
            //{
            //    if (ofd.ShowDialog() == DialogResult.OK)
            //    {
            //        this.axWindowsMediaPlayer1.URL = ofd.FileName;
            //        axWindowsMediaPlayer1.Ctlcontrols.stop();
            //    }

            this.axWindowsMediaPlayer1.URL = PathOfVideoUser;
            label1.Text = "Title: " + axWindowsMediaPlayer1.currentMedia.name;// name of video

            var player = new WindowsMediaPlayer();
            var clip = player.newMedia(PathOfVideoUser);
            label2.Text = "Length: " + TimeSpan.FromSeconds(clip.duration).ToString(); // length of video

            //var ffMpeg = new NReco.VideoConverter.FFMpegConverter();

            //string namepicture = axWindowsMediaPlayer1.currentMedia.name + ".jpg";
            //ffMpeg.GetVideoThumbnail(ofd.FileName, namepicture); // using FFMPEG to take first photo of video


            //  pictureBox1.Image = Image.FromFile(namepicture); // saving picture into pictureBox
            timer1.Start();
            //     }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            itime++;
            if (itime == 1)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
            }
        }

        private void VideoLayout_Click(object sender, EventArgs e)
        {
            NowPlayingForm np = new NowPlayingForm();
            np.Path = PathOfVideoUser;
            np.Show();
        }
    }
}
