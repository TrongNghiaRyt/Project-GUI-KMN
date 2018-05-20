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
    public partial class ImageButton : UserControl
    {
        public ImageButton()
        {
            InitializeComponent();
            RecBorder = new SolidBrush(ColorTranslator.FromHtml("#4cd7da"));
            TextBorder = new SolidBrush(ColorTranslator.FromHtml("#4cd7da"));
            Rect = new Rectangle(0, 0, this.Width, this.Height);
            StrFormat = new StringFormat();
            StrFormat.Alignment = StringAlignment.Center;
            StrFormat.LineAlignment = StringAlignment.Center;
        }

        private SolidBrush RecBorder, TextBorder;
        private Rectangle Rect;
        private bool Active;
        private StringFormat StrFormat;

        public Image ImgNormal_play { get; set; } = null;
        public Image ImgTough_play { get; set; } = null;
        public Image ImgClick_play { get; set; } = null;

        public Image ImgNormal_pause { get; set; } = null;
        public Image ImgTouch_pause { get; set; } = null;
        public Image ImgClick_pause { get; set; } = null;
        private int status = 0;

        private int weight_i;
        private int height_i;
        private Image tempImg;

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            tempImg = ImgNormal_play;
            if (tempImg == null)
            {
                weight_i = this.Width;
                height_i = this.Height;
            }
            else
            {
                weight_i = ImgNormal_play.Width;
                height_i = ImgNormal_play.Height;
                this.Size = new Size(weight_i, height_i);
                Rect = new Rectangle(0, 0, weight_i, height_i);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (tempImg == null)
            {
                e.Graphics.DrawRectangle(new Pen(RecBorder), Rect);
                e.Graphics.DrawString(this.Text, this.Font, TextBorder, Rect, StrFormat);
            }
            else
            {
                e.Graphics.DrawImage(tempImg, Rect);
            }
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            if (status == 0)
                tempImg = ImgTough_play;
            else
                tempImg = ImgTouch_pause;
            this.Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (status == 0)
                tempImg = ImgClick_play;
            else
                tempImg = ImgClick_pause;
            this.Invalidate();
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (ImgNormal_pause != null)
            {
                if (status == 0)
                {
                    status = 1;

                }
                else
                {
                    status = 0;

                }

            }
            else
            {
                status = 0;
            }
            this.Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if (status == 0)
                tempImg = ImgTough_play;
            else
                tempImg = ImgTouch_pause;
            this.Invalidate();
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            if (status == 0)
                tempImg = ImgNormal_play;
            else
                tempImg = ImgNormal_pause;

            this.Invalidate();
        }
    }
}
