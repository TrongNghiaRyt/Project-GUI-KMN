namespace KMN_Media
{
    partial class NowPlayingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NowPlayingForm));
            this.MediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbVolume = new KMNCustomControl.TrackBar();
            this.imbFullscreen = new KMNCustomControl.ImageButton();
            this.imbBack = new KMNCustomControl.ImageButton();
            this.imbVolume = new KMNCustomControl.ImageButton();
            this.imbNext = new KMNCustomControl.ImageButton();
            this.imbPrevious = new KMNCustomControl.ImageButton();
            this.imbStop = new KMNCustomControl.ImageButton();
            this.imbPlay = new KMNCustomControl.ImageButton();
            this.MinLength = new System.Windows.Forms.Label();
            this.MaxLength = new System.Windows.Forms.Label();
            this.tbDuration = new KMNCustomControl.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MediaPlayer
            // 
            this.MediaPlayer.AllowDrop = true;
            this.MediaPlayer.Dock = System.Windows.Forms.DockStyle.Top;
            this.MediaPlayer.Enabled = true;
            this.MediaPlayer.Location = new System.Drawing.Point(0, 0);
            this.MediaPlayer.Name = "MediaPlayer";
            this.MediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayer.OcxState")));
            this.MediaPlayer.Size = new System.Drawing.Size(800, 515);
            this.MediaPlayer.TabIndex = 0;
            this.MediaPlayer.OpenStateChange += new AxWMPLib._WMPOCXEvents_OpenStateChangeEventHandler(this.axWindowsMediaPlayer1_OpenStateChange);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.tbVolume);
            this.panel1.Controls.Add(this.imbFullscreen);
            this.panel1.Controls.Add(this.imbBack);
            this.panel1.Controls.Add(this.imbVolume);
            this.panel1.Controls.Add(this.imbNext);
            this.panel1.Controls.Add(this.imbPrevious);
            this.panel1.Controls.Add(this.imbStop);
            this.panel1.Controls.Add(this.imbPlay);
            this.panel1.Controls.Add(this.MinLength);
            this.panel1.Controls.Add(this.MaxLength);
            this.panel1.Controls.Add(this.tbDuration);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 515);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 76);
            this.panel1.TabIndex = 1;
            // 
            // tbVolume
            // 
            this.tbVolume.BackColor = System.Drawing.Color.Transparent;
            this.tbVolume.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbVolume.CircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbVolume.Location = new System.Drawing.Point(503, 49);
            this.tbVolume.Max = 10;
            this.tbVolume.Min = 0;
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(100, 16);
            this.tbVolume.TabIndex = 4;
            this.tbVolume.Val = 0;
            this.tbVolume.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbVolume_MouseClick);
            // 
            // imbFullscreen
            // 
            this.imbFullscreen.ImgClick_pause = null;
            this.imbFullscreen.ImgClick_play = global::KMN_Media.Properties.Resources.fullscreenClick;
            this.imbFullscreen.ImgNormal_pause = null;
            this.imbFullscreen.ImgNormal_play = global::KMN_Media.Properties.Resources.fullscreenNormal;
            this.imbFullscreen.ImgTouch_pause = null;
            this.imbFullscreen.ImgTough_play = global::KMN_Media.Properties.Resources.fullscreenHover;
            this.imbFullscreen.Location = new System.Drawing.Point(756, 41);
            this.imbFullscreen.Name = "imbFullscreen";
            this.imbFullscreen.Size = new System.Drawing.Size(32, 32);
            this.imbFullscreen.TabIndex = 3;
            this.imbFullscreen.Load += new System.EventHandler(this.imbFullscreen_Load);
            this.imbFullscreen.Click += new System.EventHandler(this.imbFullscreen_Click);
            // 
            // imbBack
            // 
            this.imbBack.ImgClick_pause = null;
            this.imbBack.ImgClick_play = global::KMN_Media.Properties.Resources.backClick;
            this.imbBack.ImgNormal_pause = null;
            this.imbBack.ImgNormal_play = global::KMN_Media.Properties.Resources.backNormal;
            this.imbBack.ImgTouch_pause = null;
            this.imbBack.ImgTough_play = global::KMN_Media.Properties.Resources.backHover;
            this.imbBack.Location = new System.Drawing.Point(6, 41);
            this.imbBack.Name = "imbBack";
            this.imbBack.Size = new System.Drawing.Size(32, 32);
            this.imbBack.TabIndex = 3;
            // 
            // imbVolume
            // 
            this.imbVolume.ImgClick_pause = global::KMN_Media.Properties.Resources.MuteClick;
            this.imbVolume.ImgClick_play = global::KMN_Media.Properties.Resources.HighVolumeClick;
            this.imbVolume.ImgNormal_pause = global::KMN_Media.Properties.Resources.MuteNormal;
            this.imbVolume.ImgNormal_play = global::KMN_Media.Properties.Resources.HighVolumeNormal;
            this.imbVolume.ImgTouch_pause = global::KMN_Media.Properties.Resources.MuteHover;
            this.imbVolume.ImgTough_play = global::KMN_Media.Properties.Resources.HighVolumeHover;
            this.imbVolume.Location = new System.Drawing.Point(465, 41);
            this.imbVolume.Name = "imbVolume";
            this.imbVolume.Size = new System.Drawing.Size(32, 32);
            this.imbVolume.TabIndex = 3;
            this.imbVolume.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imbVolume_MouseClick);
            // 
            // imbNext
            // 
            this.imbNext.ImgClick_pause = null;
            this.imbNext.ImgClick_play = global::KMN_Media.Properties.Resources.FastForwardClick;
            this.imbNext.ImgNormal_pause = null;
            this.imbNext.ImgNormal_play = global::KMN_Media.Properties.Resources.FastForwardNormal;
            this.imbNext.ImgTouch_pause = null;
            this.imbNext.ImgTough_play = global::KMN_Media.Properties.Resources.FastForwardHover;
            this.imbNext.Location = new System.Drawing.Point(427, 41);
            this.imbNext.Name = "imbNext";
            this.imbNext.Size = new System.Drawing.Size(32, 32);
            this.imbNext.TabIndex = 3;
            this.imbNext.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imbNext_MouseClick);
            // 
            // imbPrevious
            // 
            this.imbPrevious.ImgClick_pause = null;
            this.imbPrevious.ImgClick_play = global::KMN_Media.Properties.Resources.RewindClick;
            this.imbPrevious.ImgNormal_pause = null;
            this.imbPrevious.ImgNormal_play = global::KMN_Media.Properties.Resources.RewindNormal;
            this.imbPrevious.ImgTouch_pause = null;
            this.imbPrevious.ImgTough_play = global::KMN_Media.Properties.Resources.RewindHover;
            this.imbPrevious.Location = new System.Drawing.Point(341, 41);
            this.imbPrevious.Name = "imbPrevious";
            this.imbPrevious.Size = new System.Drawing.Size(32, 32);
            this.imbPrevious.TabIndex = 3;
            this.imbPrevious.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imbPrevious_MouseClick);
            // 
            // imbStop
            // 
            this.imbStop.ImgClick_pause = null;
            this.imbStop.ImgClick_play = global::KMN_Media.Properties.Resources.StopClick;
            this.imbStop.ImgNormal_pause = null;
            this.imbStop.ImgNormal_play = global::KMN_Media.Properties.Resources.StopNormal;
            this.imbStop.ImgTouch_pause = null;
            this.imbStop.ImgTough_play = global::KMN_Media.Properties.Resources.StopHover;
            this.imbStop.Location = new System.Drawing.Point(303, 41);
            this.imbStop.Name = "imbStop";
            this.imbStop.Size = new System.Drawing.Size(32, 32);
            this.imbStop.TabIndex = 3;
            this.imbStop.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imbStop_MouseClick);
            // 
            // imbPlay
            // 
            this.imbPlay.ImgClick_pause = global::KMN_Media.Properties.Resources.PauseClick;
            this.imbPlay.ImgClick_play = global::KMN_Media.Properties.Resources.PlayButtonClick;
            this.imbPlay.ImgNormal_pause = global::KMN_Media.Properties.Resources.PauseNormal;
            this.imbPlay.ImgNormal_play = global::KMN_Media.Properties.Resources.PlayButtonNormal;
            this.imbPlay.ImgTouch_pause = global::KMN_Media.Properties.Resources.PauseHover;
            this.imbPlay.ImgTough_play = global::KMN_Media.Properties.Resources.PlayButtonHover;
            this.imbPlay.Location = new System.Drawing.Point(379, 31);
            this.imbPlay.Name = "imbPlay";
            this.imbPlay.Size = new System.Drawing.Size(42, 42);
            this.imbPlay.TabIndex = 2;
            this.imbPlay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imbPlay_MouseClick);
            // 
            // MinLength
            // 
            this.MinLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinLength.ForeColor = System.Drawing.SystemColors.Control;
            this.MinLength.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MinLength.Location = new System.Drawing.Point(3, 3);
            this.MinLength.Name = "MinLength";
            this.MinLength.Size = new System.Drawing.Size(75, 25);
            this.MinLength.TabIndex = 1;
            this.MinLength.Text = "1:30:00";
            this.MinLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MaxLength
            // 
            this.MaxLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxLength.ForeColor = System.Drawing.SystemColors.Control;
            this.MaxLength.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MaxLength.Location = new System.Drawing.Point(722, 3);
            this.MaxLength.Name = "MaxLength";
            this.MaxLength.Size = new System.Drawing.Size(75, 25);
            this.MaxLength.TabIndex = 1;
            this.MaxLength.Text = "1:30:00";
            this.MaxLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbDuration
            // 
            this.tbDuration.BackColor = System.Drawing.Color.Transparent;
            this.tbDuration.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbDuration.CircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDuration.Location = new System.Drawing.Point(84, 3);
            this.tbDuration.Max = 10;
            this.tbDuration.Min = 0;
            this.tbDuration.Name = "tbDuration";
            this.tbDuration.Size = new System.Drawing.Size(632, 25);
            this.tbDuration.TabIndex = 0;
            this.tbDuration.Val = 0;
            this.tbDuration.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbDuration_MouseClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // NowPlayingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 590);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MediaPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "NowPlayingForm";
            this.Text = "NowPlayingForm";
            this.Load += new System.EventHandler(this.NowPlayingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer;
        private System.Windows.Forms.Panel panel1;
        private KMNCustomControl.TrackBar tbDuration;
        private System.Windows.Forms.Label MaxLength;
        private System.Windows.Forms.Label MinLength;
        private KMNCustomControl.ImageButton imbStop;
        private KMNCustomControl.ImageButton imbPlay;
        private KMNCustomControl.ImageButton imbNext;
        private KMNCustomControl.ImageButton imbPrevious;
        private KMNCustomControl.ImageButton imbFullscreen;
        private KMNCustomControl.ImageButton imbVolume;
        private KMNCustomControl.TrackBar tbVolume;
        private KMNCustomControl.ImageButton imbBack;
        private System.Windows.Forms.Timer timer1;
    }
}