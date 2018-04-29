using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMNCustomControl
{
    public partial class TrackBar : UserControl
    {
        public TrackBar()
        {
            InitializeComponent();
        }

        #region Variables
        Color backGround = Color.FromArgb(200, 200, 200);
        Color circle = Color.Aqua;

        int max = 10;
        int min = 0;
        int val;
        int maxPS;
        bool isClick = false;
        #endregion

        #region Properties
        public Color CircleColor
        {
            get
            {
                return circle;
            }

            set
            {
                circle = value;
            }
        }

        public int Max
        {
            get
            {
                return max;
            }

            set
            {
                max = value;
            }
        }

        public int Min
        {
            get
            {
                return min;
            }

            set
            {
                min = value;
            }
        }

        public Color BackGroundColor
        {
            get
            {
                return backGround;
            }

            set
            {
                backGround = value;
            }
        }

        public int Val
        {
            get
            {
                return val;
            }

            set
            {
                val = value;
                pictureBox1.Location = new Point(((panel1.Width - panel1.Height) * (val - min)) / (max - min), 0);
                panel2.Size = new Size(pictureBox1.Location.X + (pictureBox1.Height / 2), panel1.Height / 2);
            }
        }
        #endregion

        #region Paint
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            e.Graphics.FillEllipse(
                new SolidBrush(backGround),
                new Rectangle(0, panel1.Height / 4, panel1.Height / 2, panel1.Height / 2)
                );
            e.Graphics.FillEllipse(
                new SolidBrush(backGround),
                new Rectangle(panel1.Width - panel1.Height / 2, panel1.Height / 4, panel1.Height / 2, panel1.Height / 2)
                );
            e.Graphics.FillRectangle(
                new SolidBrush(backGround),
                new Rectangle(this.Height / 4, panel1.Height / 4, panel1.Width - panel1.Height / 2, panel1.Height / 2)
                );
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(
               new SolidBrush(circle),
               new Rectangle(0, 0, pictureBox1.Height, pictureBox1.Height)
               );
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            e.Graphics.FillEllipse(
                new SolidBrush(circle),
                new Rectangle(0, 0, panel2.Height, panel2.Height)
                );
            e.Graphics.FillRectangle(
                new SolidBrush(circle),
                new Rectangle(panel2.Height / 2, 0, panel1.Width - (panel1.Height / 2), panel1.Height)
                );
        }
        #endregion

        #region Event
        private void TrackBar_Load(object sender, EventArgs e)
        {
            maxPS = panel1.Width - panel1.Height;

            pictureBox1.Size = new Size(panel1.Height, panel1.Height);
            panel2.Size = new Size(panel1.Height / 2, panel1.Height / 2);

            pictureBox1.Location = new Point((maxPS * (val - min)) / (max - min), 0);
            panel2.Location = new Point(0, panel1.Height / 4);
        }

        private void TrackBar_MouseDown(object sender, MouseEventArgs e)
        {
            isClick = true;
        }

        private void TrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            isClick = false;
            pictureBox1.Location = new Point(((panel1.Width - panel1.Height) * (val - min)) / (max - min), 0);
            panel2.Size = new Size(pictureBox1.Location.X + (pictureBox1.Height / 2), panel1.Height / 2);
        }

        private void TrackBar_MouseClick(object sender, MouseEventArgs e)
        {
            isClick = true;

            if (isClick == true && e.Button == MouseButtons.Left)
            {
                if (e.X + 1 >= maxPS + (panel1.Height / 2))
                {
                    pictureBox1.Location = new Point(maxPS, 0);
                    panel2.Size = new Size(pictureBox1.Location.X + (pictureBox1.Height / 2), panel1.Height / 2);
                }
                else if ((e.X + 1 - pictureBox1.Height / 2 >= 0) &&
                    (e.X + 1 - pictureBox1.Height) <= panel1.Width)
                {
                    pictureBox1.Location = new Point(e.X + 1 - pictureBox1.Height / 2, 0);
                    panel2.Size = new Size(pictureBox1.Location.X + (pictureBox1.Height / 2), panel1.Height / 2);
                }
                else
                {
                    if (e.X + 1 < pictureBox1.Height)
                    {
                        pictureBox1.Location = new Point(0, 0);
                        panel2.Size = new Size(pictureBox1.Location.X + (pictureBox1.Height / 2), panel1.Height / 2);
                    }
                    else
                    {
                        pictureBox1.Location = new Point(maxPS, 0);
                        panel2.Size = new Size(pictureBox1.Location.X + (pictureBox1.Height / 2), panel1.Height / 2);
                    }
                }
            }
            double temp = (double)((max - min) * pictureBox1.Location.X) / (panel1.Width - panel1.Height) + min;
            val = Convert.ToInt32(Math.Round(temp, MidpointRounding.AwayFromZero));

            isClick = false;
        }

        private void TrackBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isClick == true)
            {
                if (e.X + 1 >= maxPS + (panel1.Height / 2))
                {
                    pictureBox1.Location = new Point(maxPS, 0);
                    panel2.Size = new Size(pictureBox1.Location.X + (pictureBox1.Height / 2), panel1.Height / 2);
                }
                else if ((e.X + 1 - pictureBox1.Height / 2 >= 0) &&
                    (e.X + 1 - pictureBox1.Height) <= panel1.Width)
                {
                    pictureBox1.Location = new Point(e.X + 1 - pictureBox1.Height / 2, 0);
                    panel2.Size = new Size(pictureBox1.Location.X + (pictureBox1.Height / 2), panel1.Height / 2);
                }
                else
                {
                    if (e.X + 1 < pictureBox1.Height)
                    {
                        pictureBox1.Location = new Point(0, 0);
                        panel2.Size = new Size(pictureBox1.Location.X + (pictureBox1.Height / 2), panel1.Height / 2);
                    }
                    else
                    {
                        pictureBox1.Location = new Point(maxPS, 0);
                        panel2.Size = new Size(pictureBox1.Location.X + (pictureBox1.Height / 2), panel1.Height / 2);
                    }
                }
            }
            double temp = (double)((max - min) * pictureBox1.Location.X) / (panel1.Width - panel1.Height) + min;
            val = Convert.ToInt32(Math.Round(temp, MidpointRounding.AwayFromZero));
        }
        #endregion
    }
}
