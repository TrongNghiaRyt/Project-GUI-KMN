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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnMenu = new System.Windows.Forms.Panel();
            this.tabTitle1 = new CUstomTAbControl.TabTitle();
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabMusic = new System.Windows.Forms.TabPage();
            this.tabVideo = new System.Windows.Forms.TabPage();
            this.tabNow = new System.Windows.Forms.TabPage();
            this.pnPlay = new System.Windows.Forms.Panel();
            this.imbPlayPause = new KMNCustomControl.ImageButton();
            this.lbMax = new System.Windows.Forms.Label();
            this.lbMin = new System.Windows.Forms.Label();
            this.trackBar1 = new KMNCustomControl.TrackBar();
            this.imbVolume = new KMNCustomControl.ImageButton();
            this.imbStop = new KMNCustomControl.ImageButton();
            this.imbShuffle = new KMNCustomControl.ImageButton();
            this.imbRepeat = new KMNCustomControl.ImageButton();
            this.imbForward = new KMNCustomControl.ImageButton();
            this.imbBack = new KMNCustomControl.ImageButton();
            this.tbTime = new KMNCustomControl.TrackBar();
            this.pnSongInfo = new System.Windows.Forms.Panel();
            this.lbDuration = new System.Windows.Forms.Label();
            this.lbSongName = new System.Windows.Forms.Label();
            this.picSong = new System.Windows.Forms.PictureBox();
            this.pnMenu.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.pnPlay.SuspendLayout();
            this.pnSongInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSong)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.DarkGray;
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
            this.tabTitle1.Location = new System.Drawing.Point(0, 22);
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
            this.tabMenu.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabMenu.Controls.Add(this.tabMusic);
            this.tabMenu.Controls.Add(this.tabVideo);
            this.tabMenu.Controls.Add(this.tabNow);
            this.tabMenu.Location = new System.Drawing.Point(150, 0);
            this.tabMenu.Multiline = true;
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(650, 500);
            this.tabMenu.TabIndex = 2;
            // 
            // tabMusic
            // 
            this.tabMusic.AllowDrop = true;
            this.tabMusic.BackColor = System.Drawing.Color.White;
            this.tabMusic.Location = new System.Drawing.Point(23, 4);
            this.tabMusic.Name = "tabMusic";
            this.tabMusic.Padding = new System.Windows.Forms.Padding(3);
            this.tabMusic.Size = new System.Drawing.Size(623, 492);
            this.tabMusic.TabIndex = 0;
            this.tabMusic.Text = "Music";
            // 
            // tabVideo
            // 
            this.tabVideo.Location = new System.Drawing.Point(23, 4);
            this.tabVideo.Name = "tabVideo";
            this.tabVideo.Padding = new System.Windows.Forms.Padding(3);
            this.tabVideo.Size = new System.Drawing.Size(623, 492);
            this.tabVideo.TabIndex = 1;
            this.tabVideo.Text = "Video";
            this.tabVideo.UseVisualStyleBackColor = true;
            // 
            // tabNow
            // 
            this.tabNow.Location = new System.Drawing.Point(23, 4);
            this.tabNow.Name = "tabNow";
            this.tabNow.Size = new System.Drawing.Size(623, 492);
            this.tabNow.TabIndex = 2;
            this.tabNow.Text = "Now playing";
            this.tabNow.UseVisualStyleBackColor = true;
            // 
            // pnPlay
            // 
            this.pnPlay.BackColor = System.Drawing.Color.DimGray;
            this.pnPlay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnPlay.Controls.Add(this.imbPlayPause);
            this.pnPlay.Controls.Add(this.lbMax);
            this.pnPlay.Controls.Add(this.lbMin);
            this.pnPlay.Controls.Add(this.trackBar1);
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
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.Transparent;
            this.trackBar1.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.trackBar1.CircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.trackBar1.Location = new System.Drawing.Point(407, 57);
            this.trackBar1.Max = 10;
            this.trackBar1.Min = 0;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(134, 16);
            this.trackBar1.TabIndex = 9;
            this.trackBar1.Val = 0;
            // 
            // imbVolume
            // 
            this.imbVolume.ImgClick_pause = null;
            this.imbVolume.ImgClick_play = global::KMN_Media.Properties.Resources.HighVolumeClick;
            this.imbVolume.ImgNormal_pause = null;
            this.imbVolume.ImgNormal_play = global::KMN_Media.Properties.Resources.HighVolumeNormal;
            this.imbVolume.ImgTouch_pause = null;
            this.imbVolume.ImgTough_play = global::KMN_Media.Properties.Resources.HighVolumeHover;
            this.imbVolume.Location = new System.Drawing.Point(369, 50);
            this.imbVolume.Name = "imbVolume";
            this.imbVolume.Size = new System.Drawing.Size(32, 32);
            this.imbVolume.TabIndex = 8;
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
            // 
            // imbRepeat
            // 
            this.imbRepeat.ImgClick_pause = null;
            this.imbRepeat.ImgClick_play = global::KMN_Media.Properties.Resources.ReplayClick;
            this.imbRepeat.ImgNormal_pause = null;
            this.imbRepeat.ImgNormal_play = global::KMN_Media.Properties.Resources.ReplayNormal;
            this.imbRepeat.ImgTouch_pause = null;
            this.imbRepeat.ImgTough_play = global::KMN_Media.Properties.Resources.ReplayHover;
            this.imbRepeat.Location = new System.Drawing.Point(331, 50);
            this.imbRepeat.Name = "imbRepeat";
            this.imbRepeat.Size = new System.Drawing.Size(32, 32);
            this.imbRepeat.TabIndex = 5;
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
            // picSong
            // 
            this.picSong.Location = new System.Drawing.Point(0, 0);
            this.picSong.Name = "picSong";
            this.picSong.Size = new System.Drawing.Size(100, 100);
            this.picSong.TabIndex = 0;
            this.picSong.TabStop = false;
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
            this.Name = "MainForm";
            this.Text = "KMN Player";
            this.pnMenu.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.pnPlay.ResumeLayout(false);
            this.pnSongInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSong)).EndInit();
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
        private KMNCustomControl.TrackBar trackBar1;
        private System.Windows.Forms.Label lbMin;
        private System.Windows.Forms.Label lbMax;
        private CUstomTAbControl.TabTitle tabTitle1;
    }
}

