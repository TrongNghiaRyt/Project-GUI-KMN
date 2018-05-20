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
        private static string local = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyMusic);
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
        public static bool CheckUpdate = false;
        public static string Local
        {
            get
            {
                return local;
            }

            set
            {
                local = value;
            }
        }
        #endregion
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Link != null)
            {
                Local = Properties.Settings.Default.Link;
            }
            CreateMusicList();
            showPlayList();
        }
        private void CreateMusicList()
        {
            exListBox1.Items.Clear();
            string[] files = Directory.GetFiles(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyMusic));
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
            temp_time = TimeSpan.FromTicks(file.Properties.Duration.Ticks).ToString(@"hh\:mm\:ss");
            temp_album = file.Tag.Album;
            try
            {
                if (file.Tag.Pictures != null)
                {
                    var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                    temp_Image = Image.FromStream(new MemoryStream(bin));
                }
            }
            catch
            {

            }

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
            if (CheckUpdate == true)
            {
                UpdateListbox();
            }
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
                            if (exListBox1.SelectedIndex == exListBox1.Items.Count - 1)
                            {
                                BeginInvoke(new Action(() =>
                                {
                                    exListBox1.SelectedItem = exListBox1.Items[0];
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int itemNumber = exListBox2.Items.Count;
            Stream myStream = null;
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = true;
            open.Filter = "MP3 Audio Files (*.mp3)|*.MP3|WAV Audio Files (*.wav)|*.WAV|M4A Audio Files(*.m4a)|*.m4a|All files (*.*)|*.*";

            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = open.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            string[] fileNameAndPath = open.FileNames;

                            for (int i = 0; i < open.FileNames.Count(); i++)
                            {
                                getimageMp3(fileNameAndPath[i]);
                                exListBox2.Items.Add(new exListBoxItem(itemNumber, temp, temp_time, temp_album, fileNameAndPath[i], temp_Image));
                                itemNumber++;

                            }
                        }
                    }
                }
                catch
                {

                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            exListBox2.Items.Clear();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (tbListName.Text == "")
            {
                MessageBox.Show("You haven't set the playlist title!", "Blank playlist title");
            }
            else if (exListBox2.Items.Count == 0)
            {
                MessageBox.Show("There are notthing in the playlist", "Blank playlist");
            }
            else
            {
                string path = local;
                path += "\\" + tbListName.Text + ".bin";

                if (System.IO.File.Exists(path))
                {
                    //Do something
                    System.IO.File.Delete(path);
                }
                FileStream fs = new FileStream(path, FileMode.Create);
                BinaryWriter wr = new BinaryWriter(fs);
                wr.Write(tbListName.Text);
                wr.Write(exListBox2.Items.Count);
                for (int i=0; i<exListBox2.Items.Count; i++)
                {
                    exListBoxItem item = exListBox2.Items[i] as exListBoxItem;
                    wr.Write(item.Path);
                }

                fs.Close();
                wr.Close();

                MessageBox.Show("Playlist had created successfully!", "Success");
            }    
        }

        private void showPlayList()
        {
            cbList.Items.Clear();
            string[] files = Directory.GetFiles(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyMusic));
            foreach (string file in files)
            {
                string fileExtexsion = Path.GetExtension(file).Trim();
                if (fileExtexsion == ".bin")
                {
                    FileStream fs = new FileStream(file, FileMode.Open);
                    BinaryReader re = new BinaryReader(fs);

                    string name = re.ReadString();
                    cbList.Items.Add(name);

                    fs.Close();
                    re.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cbList.Text = "";
            showPlayList();
        }

        private void cbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            exListBox3.Items.Clear();
            string path = Local + "\\" + cbList.Text + ".bin";

            FileStream fs = new FileStream(path, FileMode.Open);
            BinaryReader re = new BinaryReader(fs);

            string a = re.ReadString();
            int num = re.ReadInt32();
            for (int i=0; i<num; i++)
            {
                string file = re.ReadString();
                getimageMp3(file);
                exListBox3.Items.Add(new exListBoxItem(i, temp, temp_time, temp_album, file, temp_Image));
            }
            
            fs.Close();
            re.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChoosePath cp = new ChoosePath();
            cp.Show();
        }
        private void UpdateListbox()
        {
            exListBox1.Items.Clear();
            CreateMusicList();
            CheckUpdate = false;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Link = Local;
            Properties.Settings.Default.Save();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (exListBox3.Items.Count == 0)
                MessageBox.Show("You haven't selected playlist!","Playlist error!");
            else
            {
                exListBox1.Items.Clear();
                for (int i=0; i<exListBox3.Items.Count; i++)
                {
                    exListBoxItem item = exListBox3.Items[i] as exListBoxItem;
                    exListBox1.Items.Add(new exListBoxItem(i, item.Time, item.Time, item.Album, item.Path, item.Img));
                    tabMenu.SelectedTab = tabMusic;

                    timer1.Start();
                    tbTime.Val = 0;
                    exListBoxItem items = exListBox1.Items[0] as exListBoxItem;
                    axWindowsMediaPlayer1.URL = items.Path;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    //exListBox1.SelectedIndex = 1;
                    picSong.Image = items.Img;
                    lbSongName.Text = items.Title;
                    lbDuration.Text = items.Album;
                    TBvolume.Val = 50;
                    RunWMP = true;
                    CheckStop = false;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string path = local + "//" + cbList.Text + ".bin";
            try
            {
                if (System.IO.File.Exists(path))
                {
                    //Do something
                    System.IO.File.Delete(path);
                    MessageBox.Show("Delete playlist successfully!", "success!");
                    cbList.Text = "";
                    showPlayList();
                    exListBox3.Items.Clear();
                }
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
