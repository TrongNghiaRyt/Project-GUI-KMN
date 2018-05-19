namespace KMN_Media
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnMenu = new System.Windows.Forms.Panel();
            this.tabTitle1 = new CUstomTAbControl.TabTitle();
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabMusic = new System.Windows.Forms.TabPage();
            this.exListBox1 = new testexListBox.exListBox();
            this.tabVideo = new System.Windows.Forms.TabPage();
            this.tabNow = new System.Windows.Forms.TabPage();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.pnPlay = new System.Windows.Forms.Panel();
            this.lbMax = new System.Windows.Forms.Label();
            this.lbMin = new System.Windows.Forms.Label();
            this.TBvolume = new KMNCustomControl.TrackBar();
            this.tbTime = new KMNCustomControl.TrackBar();
            this.pnSongInfo = new System.Windows.Forms.Panel();
            this.lbDuration = new System.Windows.Forms.Label();
            this.lbSongName = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.picSong = new System.Windows.Forms.PictureBox();
            this.imbPlayPause = new KMNCustomControl.ImageButton();
            this.imbVolume = new KMNCustomControl.ImageButton();
            this.imbStop = new KMNCustomControl.ImageButton();
            this.imbShuffle = new KMNCustomControl.ImageButton();
            this.imbRepeat = new KMNCustomControl.ImageButton();
            this.imbForward = new KMNCustomControl.ImageButton();
            this.imbBack = new KMNCustomControl.ImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnMenu.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.tabMusic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.pnPlay.SuspendLayout();
            this.pnSongInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.DarkGray;
            this.pnMenu.Controls.Add(this.label2);
            this.pnMenu.Controls.Add(this.label1);
            this.pnMenu.Controls.Add(this.pictureBox1);
            this.pnMenu.Controls.Add(this.tabTitle1);
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(175, 500);
            this.pnMenu.TabIndex = 0;
            // 
            // tabTitle1
            // 
            this.tabTitle1.BackColor = System.Drawing.Color.Transparent;
            this.tabTitle1.BackGroundColorClicked = System.Drawing.Color.BlueViolet;
            this.tabTitle1.BackGroundColorHolver = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tabTitle1.BackGroundColorNomal = System.Drawing.Color.White;
            this.tabTitle1.BackGroundColorSelected = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tabTitle1.Location = new System.Drawing.Point(0, 75);
            this.tabTitle1.Name = "tabTitle1";
            this.tabTitle1.Size = new System.Drawing.Size(175, 90);
            this.tabTitle1.SizeLayout = CUstomTAbControl.TabTitle.sizelayout.AutoSize;
            this.tabTitle1.Tabcontrol = this.tabMenu;
            this.tabTitle1.TabIndex = 0;
            this.tabTitle1.TextColorHolver = System.Drawing.Color.Black;
            this.tabTitle1.TextColorNormal = System.Drawing.Color.Black;
            this.tabTitle1.TextColorSelected = System.Drawing.Color.Black;
            this.tabTitle1.TextLayoutTitle = System.Drawing.ContentAlignment.MiddleCenter;
            this.tabTitle1.Titlelayout = CUstomTAbControl.TabTitle.TitleLayout.Vertical;
            this.tabTitle1.Titlemargin = 0;
            this.tabTitle1.TitlePadding = 0;
            this.tabTitle1.TitleSize = new System.Drawing.Size(175, 30);
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabMusic);
            this.tabMenu.Controls.Add(this.tabVideo);
            this.tabMenu.Controls.Add(this.tabNow);
            this.tabMenu.Location = new System.Drawing.Point(178, 0);
            this.tabMenu.Multiline = true;
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(625, 500);
            this.tabMenu.TabIndex = 2;
            // 
            // tabMusic
            // 
            this.tabMusic.AllowDrop = true;
            this.tabMusic.BackColor = System.Drawing.Color.White;
            this.tabMusic.Controls.Add(this.button1);
            this.tabMusic.Controls.Add(this.label3);
            this.tabMusic.Controls.Add(this.exListBox1);
            this.tabMusic.Location = new System.Drawing.Point(4, 22);
            this.tabMusic.Name = "tabMusic";
            this.tabMusic.Padding = new System.Windows.Forms.Padding(3);
            this.tabMusic.Size = new System.Drawing.Size(617, 474);
            this.tabMusic.TabIndex = 0;
            this.tabMusic.Text = "Music";
            // 
            // exListBox1
            // 
            this.exListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.exListBox1.FormattingEnabled = true;
            this.exListBox1.ItemHeight = 40;
            this.exListBox1.Location = new System.Drawing.Point(3, 43);
            this.exListBox1.Name = "exListBox1";
            this.exListBox1.Size = new System.Drawing.Size(611, 428);
            this.exListBox1.TabIndex = 0;
            this.exListBox1.SelectedIndexChanged += new System.EventHandler(this.exListBox1_SelectedIndexChanged);
            // 
            // tabVideo
            // 
            this.tabVideo.Location = new System.Drawing.Point(4, 22);
            this.tabVideo.Name = "tabVideo";
            this.tabVideo.Padding = new System.Windows.Forms.Padding(3);
            this.tabVideo.Size = new System.Drawing.Size(617, 474);
            this.tabVideo.TabIndex = 1;
            this.tabVideo.Text = "Video";
            this.tabVideo.UseVisualStyleBackColor = true;
            // 
            // tabNow
            // 
            this.tabNow.Location = new System.Drawing.Point(4, 22);
            this.tabNow.Name = "tabNow";
            this.tabNow.Size = new System.Drawing.Size(617, 474);
            this.tabNow.TabIndex = 2;
            this.tabNow.Text = "Now playing";
            this.tabNow.UseVisualStyleBackColor = true;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(8, 54);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(67, 28);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.Visible = false;
            this.axWindowsMediaPlayer1.OpenStateChange += new AxWMPLib._WMPOCXEvents_OpenStateChangeEventHandler(this.axWindowsMediaPlayer1_OpenStateChange);
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            // 
            // pnPlay
            // 
            this.pnPlay.BackColor = System.Drawing.Color.DimGray;
            this.pnPlay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnPlay.Controls.Add(this.axWindowsMediaPlayer1);
            this.pnPlay.Controls.Add(this.imbPlayPause);
            this.pnPlay.Controls.Add(this.lbMax);
            this.pnPlay.Controls.Add(this.lbMin);
            this.pnPlay.Controls.Add(this.TBvolume);
            this.pnPlay.Controls.Add(this.imbVolume);
            this.pnPlay.Controls.Add(this.imbStop);
            this.pnPlay.Controls.Add(this.imbShuffle);
            this.pnPlay.Controls.Add(this.imbRepeat);
            this.pnPlay.Controls.Add(this.imbForward);
            this.pnPlay.Controls.Add(this.imbBack);
            this.pnPlay.Controls.Add(this.tbTime);
            this.pnPlay.Location = new System.Drawing.Point(250, 500);
            this.pnPlay.Name = "pnPlay";
            this.pnPlay.Size = new System.Drawing.Size(550, 100);
            this.pnPlay.TabIndex = 1;
            // 
            // lbMax
            // 
            this.lbMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lbMax.Location = new System.Drawing.Point(492, 33);
            this.lbMax.Name = "lbMax";
            this.lbMax.Size = new System.Drawing.Size(50, 20);
            this.lbMax.TabIndex = 10;
            this.lbMax.Text = "00:00";
            this.lbMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMin
            // 
            this.lbMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lbMin.Location = new System.Drawing.Point(5, 33);
            this.lbMin.Name = "lbMin";
            this.lbMin.Size = new System.Drawing.Size(50, 20);
            this.lbMin.TabIndex = 10;
            this.lbMin.Text = "00:00";
            this.lbMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TBvolume
            // 
            this.TBvolume.BackColor = System.Drawing.Color.Transparent;
            this.TBvolume.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.TBvolume.CircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBvolume.Location = new System.Drawing.Point(407, 57);
            this.TBvolume.Max = 100;
            this.TBvolume.Min = 0;
            this.TBvolume.Name = "TBvolume";
            this.TBvolume.Size = new System.Drawing.Size(134, 16);
            this.TBvolume.TabIndex = 9;
            this.TBvolume.Val = 0;
            this.TBvolume.MouseClick += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseClick);
            // 
            // tbTime
            // 
            this.tbTime.BackColor = System.Drawing.Color.Transparent;
            this.tbTime.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbTime.CircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTime.Location = new System.Drawing.Point(3, 5);
            this.tbTime.Max = 10;
            this.tbTime.Min = 0;
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(539, 25);
            this.tbTime.TabIndex = 0;
            this.tbTime.Val = 0;
            this.tbTime.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbTime_MouseClick);
            // 
            // pnSongInfo
            // 
            this.pnSongInfo.BackColor = System.Drawing.Color.DimGray;
            this.pnSongInfo.Controls.Add(this.lbDuration);
            this.pnSongInfo.Controls.Add(this.lbSongName);
            this.pnSongInfo.Controls.Add(this.picSong);
            this.pnSongInfo.Location = new System.Drawing.Point(0, 500);
            this.pnSongInfo.Name = "pnSongInfo";
            this.pnSongInfo.Size = new System.Drawing.Size(250, 100);
            this.pnSongInfo.TabIndex = 1;
            // 
            // lbDuration
            // 
            this.lbDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lbDuration.Location = new System.Drawing.Point(106, 44);
            this.lbDuration.Name = "lbDuration";
            this.lbDuration.Size = new System.Drawing.Size(100, 23);
            this.lbDuration.TabIndex = 1;
            this.lbDuration.Text = "label1";
            this.lbDuration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSongName
            // 
            this.lbSongName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSongName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lbSongName.Location = new System.Drawing.Point(105, 8);
            this.lbSongName.Name = "lbSongName";
            this.lbSongName.Size = new System.Drawing.Size(100, 23);
            this.lbSongName.TabIndex = 1;
            this.lbSongName.Text = "label1";
            this.lbSongName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Algerian", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Location = new System.Drawing.Point(72, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "KMN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Media player";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Algerian", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 36);
            this.label3.TabIndex = 1;
            this.label3.Text = "MUSIC";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(526, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Choose path";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // picSong
            // 
            this.picSong.Location = new System.Drawing.Point(0, 0);
            this.picSong.Name = "picSong";
            this.picSong.Size = new System.Drawing.Size(100, 100);
            this.picSong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSong.TabIndex = 0;
            this.picSong.TabStop = false;
            // 
            // imbPlayPause
            // 
            this.imbPlayPause.ImgClick_pause = global::KMN_Media.Properties.Resources.PauseClick;
            this.imbPlayPause.ImgClick_play = global::KMN_Media.Properties.Resources.PlayButtonClick;
            this.imbPlayPause.ImgNormal_pause = global::KMN_Media.Properties.Resources.PauseNormal;
            this.imbPlayPause.ImgNormal_play = global::KMN_Media.Properties.Resources.PlayButtonNormal;
            this.imbPlayPause.ImgTouch_pause = global::KMN_Media.Properties.Resources.PauseHover;
            this.imbPlayPause.ImgTough_play = global::KMN_Media.Properties.Resources.PlayButtonHover;
            this.imbPlayPause.Location = new System.Drawing.Point(245, 43);
            this.imbPlayPause.Name = "imbPlayPause";
            this.imbPlayPause.Size = new System.Drawing.Size(42, 42);
            this.imbPlayPause.TabIndex = 1;
            this.imbPlayPause.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imbPlayPause_MouseClick);
            // 
            // imbVolume
            // 
            this.imbVolume.ImgClick_pause = global::KMN_Media.Properties.Resources.MuteClick;
            this.imbVolume.ImgClick_play = global::KMN_Media.Properties.Resources.HighVolumeClick;
            this.imbVolume.ImgNormal_pause = global::KMN_Media.Properties.Resources.MuteNormal;
            this.imbVolume.ImgNormal_play = global::KMN_Media.Properties.Resources.HighVolumeNormal;
            this.imbVolume.ImgTouch_pause = global::KMN_Media.Properties.Resources.MuteHover;
            this.imbVolume.ImgTough_play = global::KMN_Media.Properties.Resources.HighVolumeHover;
            this.imbVolume.Location = new System.Drawing.Point(369, 50);
            this.imbVolume.Name = "imbVolume";
            this.imbVolume.Size = new System.Drawing.Size(32, 32);
            this.imbVolume.TabIndex = 8;
            this.imbVolume.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imbVolume_MouseClick);
            // 
            // imbStop
            // 
            this.imbStop.ImgClick_pause = null;
            this.imbStop.ImgClick_play = global::KMN_Media.Properties.Resources.StopClick;
            this.imbStop.ImgNormal_pause = null;
            this.imbStop.ImgNormal_play = global::KMN_Media.Properties.Resources.StopNormal;
            this.imbStop.ImgTouch_pause = null;
            this.imbStop.ImgTough_play = global::KMN_Media.Properties.Resources.StopHover;
            this.imbStop.Location = new System.Drawing.Point(131, 50);
            this.imbStop.Name = "imbStop";
            this.imbStop.Size = new System.Drawing.Size(32, 32);
            this.imbStop.TabIndex = 7;
            this.imbStop.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imbStop_MouseClick);
            // 
            // imbShuffle
            // 
            this.imbShuffle.ImgClick_pause = null;
            this.imbShuffle.ImgClick_play = ((System.Drawing.Image)(resources.GetObject("imbShuffle.ImgClick_play")));
            this.imbShuffle.ImgNormal_pause = null;
            this.imbShuffle.ImgNormal_play = ((System.Drawing.Image)(resources.GetObject("imbShuffle.ImgNormal_play")));
            this.imbShuffle.ImgTouch_pause = null;
            this.imbShuffle.ImgTough_play = ((System.Drawing.Image)(resources.GetObject("imbShuffle.ImgTough_play")));
            this.imbShuffle.Location = new System.Drawing.Point(169, 50);
            this.imbShuffle.Name = "imbShuffle";
            this.imbShuffle.Size = new System.Drawing.Size(32, 32);
            this.imbShuffle.TabIndex = 6;
            this.imbShuffle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imbShuffle_MouseClick);
            // 
            // imbRepeat
            // 
            this.imbRepeat.ImgClick_pause = global::KMN_Media.Properties.Resources.replayOnClick;
            this.imbRepeat.ImgClick_play = global::KMN_Media.Properties.Resources.ReplayClick;
            this.imbRepeat.ImgNormal_pause = global::KMN_Media.Properties.Resources.replayOnNormal;
            this.imbRepeat.ImgNormal_play = global::KMN_Media.Properties.Resources.ReplayNormal;
            this.imbRepeat.ImgTouch_pause = global::KMN_Media.Properties.Resources.ReplayNormal;
            this.imbRepeat.ImgTough_play = global::KMN_Media.Properties.Resources.ReplayHover;
            this.imbRepeat.Location = new System.Drawing.Point(331, 50);
            this.imbRepeat.Name = "imbRepeat";
            this.imbRepeat.Size = new System.Drawing.Size(32, 32);
            this.imbRepeat.TabIndex = 5;
            this.imbRepeat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imbRepeat_MouseClick);
            // 
            // imbForward
            // 
            this.imbForward.ImgClick_pause = null;
            this.imbForward.ImgClick_play = global::KMN_Media.Properties.Resources.FastForwardClick;
            this.imbForward.ImgNormal_pause = null;
            this.imbForward.ImgNormal_play = global::KMN_Media.Properties.Resources.FastForwardNormal;
            this.imbForward.ImgTouch_pause = null;
            this.imbForward.ImgTough_play = global::KMN_Media.Properties.Resources.FastForwardHover;
            this.imbForward.Location = new System.Drawing.Point(293, 50);
            this.imbForward.Name = "imbForward";
            this.imbForward.Size = new System.Drawing.Size(32, 32);
            this.imbForward.TabIndex = 3;
            this.imbForward.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imbForward_MouseClick);
            // 
            // imbBack
            // 
            this.imbBack.ImgClick_pause = null;
            this.imbBack.ImgClick_play = global::KMN_Media.Properties.Resources.RewindClick;
            this.imbBack.ImgNormal_pause = null;
            this.imbBack.ImgNormal_play = global::KMN_Media.Properties.Resources.RewindNormal;
            this.imbBack.ImgTouch_pause = null;
            this.imbBack.ImgTough_play = global::KMN_Media.Properties.Resources.RewindHover;
            this.imbBack.Location = new System.Drawing.Point(207, 50);
            this.imbBack.Name = "imbBack";
            this.imbBack.Size = new System.Drawing.Size(32, 32);
            this.imbBack.TabIndex = 2;
            this.imbBack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imbBack_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KMN_Media.Properties.Resources.KMN;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pnSongInfo);
            this.Controls.Add(this.pnPlay);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.tabMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "KMN Player";
            this.Load += new System.EventHandler(this.MainForm_Load_1);
            this.pnMenu.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.tabMusic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.pnPlay.ResumeLayout(false);
            this.pnSongInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Panel pnPlay;
        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage tabMusic;
        private System.Windows.Forms.TabPage tabVideo;
        private System.Windows.Forms.TabPage tabNow;
        private KMNCustomControl.TrackBar tbTime;
        private System.Windows.Forms.Panel pnSongInfo;
        private System.Windows.Forms.PictureBox picSong;
        private System.Windows.Forms.Label lbSongName;
        private System.Windows.Forms.Label lbDuration;
        private KMNCustomControl.ImageButton imbPlayPause;
        private KMNCustomControl.ImageButton imbBack;
        private KMNCustomControl.ImageButton imbForward;
        private KMNCustomControl.ImageButton imbRepeat;
        private KMNCustomControl.ImageButton imbShuffle;
        private KMNCustomControl.ImageButton imbVolume;
        private KMNCustomControl.ImageButton imbStop;
        private KMNCustomControl.TrackBar TBvolume;
        private System.Windows.Forms.Label lbMin;
        private System.Windows.Forms.Label lbMax;
        private CUstomTAbControl.TabTitle tabTitle1;
        private testexListBox.exListBox exListBox1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}

