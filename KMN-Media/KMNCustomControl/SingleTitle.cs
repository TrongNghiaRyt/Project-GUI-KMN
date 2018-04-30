using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CUstomTAbControl
{
    public partial class SingleTitle : UserControl
    {
        public SingleTitle()
        {
            InitializeComponent();
            if (!isselected)
            {
                this.BackColor = _backgroundcolornormal;    
            }
        }

        #region Delete Properties
        [Browsable(false)]
        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = value;
            }
        }
        #endregion

        #region BackGround Color
        private Color _backgroundcolornormal = Color.White;
        public Color BackGroundColorNormal { get { return _backgroundcolornormal; } set { _backgroundcolornormal = value; } }
        private Color _backgroundcolorholver = Color.FromArgb(128, 255, 128);
        public Color BackGroundColorHolver { get { return _backgroundcolorholver; }set { _backgroundcolorholver = value; } }
        private Color _backgroundcolorselected = Color.Green;
        public Color BackGroundColorSelected { get { return _backgroundcolorselected; } set { _backgroundcolorselected = value; } }
        #endregion

        #region Text Color
        private Color _textcolornormal = Color.Black;
        public Color TextColorNormal { get { return _textcolornormal; }set { _textcolornormal = value; } }
        private Color _textcolorholver = Color.Black;
        public Color TextColorHolver { get { return _textcolorholver; }set { _textcolorholver = value; } }
        private Color _textcolorselected = Color.White;
        public Color TextColorSelected { get { return _textcolorselected; }set { _textcolorselected = value; } }
        #endregion

        #region TabPage
        private TabPage _tabpage = null;
        public TabPage TabPage { get { return _tabpage; }set { _tabpage = value; _text = _tabpage.Text; } }
        #endregion

        #region Padding
        private int _padding = 0;
        public int TextPadding { get { return _padding; }set { _padding = value; } }
        #endregion

        #region StringFromat
        private ContentAlignment _textlayout = ContentAlignment.MiddleLeft;
        public ContentAlignment TextLayout { get { return _textlayout; } set { _textlayout = value; Invalidate(); } }
        #endregion

        #region Variable
        string _text;
        Color _textcolor = Color.Black;
        bool isselected = false;
        #endregion

        #region Method
        public void Active()
        {
            _textcolor = _textcolorselected;
            this.BackColor = _backgroundcolorselected;
            isselected = true;
        }
        public void Deactive()
        {
            _textcolor = _textcolornormal;
            this.BackColor = _backgroundcolornormal;
            isselected = false;
        }

        #endregion

        private void SingleTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isselected)
            {
                this.BackColor = _backgroundcolorholver;
                _textcolor = TextColorHolver;

            }
        }

        private void SingleTitle_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = _backgroundcolornormal;
            _textcolor = TextColorNormal;
        }

        private void SingleTitle_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using (StringFormat sf= new StringFormat())
            {
                switch (_textlayout)
                {
                    case ContentAlignment.TopLeft:
                        sf.Alignment = StringAlignment.Near;
                        sf.LineAlignment = StringAlignment.Near;
                        break;
                    case ContentAlignment.TopCenter:
                        sf.Alignment = StringAlignment.Center;
                        sf.LineAlignment = StringAlignment.Near;
                        break;
                    case ContentAlignment.TopRight:
                        sf.Alignment = StringAlignment.Far;
                        sf.Alignment = StringAlignment.Near;
                        break;
                    case ContentAlignment.MiddleLeft:
                        sf.Alignment = StringAlignment.Near;
                        sf.Alignment = StringAlignment.Center;
                        break;
                    case ContentAlignment.MiddleCenter:
                        sf.Alignment = StringAlignment.Center;
                        sf.Alignment = StringAlignment.Center;
                        break;
                    case ContentAlignment.MiddleRight:
                        sf.Alignment = StringAlignment.Far;
                        sf.Alignment = StringAlignment.Center;
                        break;
                    case ContentAlignment.BottomLeft:
                        sf.Alignment = StringAlignment.Near;
                        sf.LineAlignment = StringAlignment.Far;
                        break;
                    case ContentAlignment.BottomCenter:
                        sf.Alignment = StringAlignment.Center;
                        sf.LineAlignment = StringAlignment.Far;
                        break;
                    case ContentAlignment.BottomRight:
                        sf.Alignment = StringAlignment.Far;
                        sf.LineAlignment = StringAlignment.Far;
                        break;      
                }
                e.Graphics.DrawString(_text, this.Font, new SolidBrush(_textcolor), new Rectangle(_padding, 0, this.Width - 2 * _padding, this.Height), sf);

            }
        }
    }
}
