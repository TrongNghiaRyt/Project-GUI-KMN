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
    public partial class TabTitle : UserControl
    {
        public TabTitle()
        {
            InitializeComponent();
        }
        #region BackGround Color
        private Color _backgroundcolornormal = Color.White;
        public Color BackGroundColorNomal { get { return _backgroundcolornormal; } set { _backgroundcolornormal = value; } }
        private Color _backgroundcolorholver = Color.FromArgb(128, 255, 128);
        public Color BackGroundColorHolver { get { return _backgroundcolorholver; } set { _backgroundcolorholver = value; } }
        private Color _backgroundcolorselected = Color.Green;
        public Color BackGroundColorSelected { get { return _backgroundcolorselected; } set { _backgroundcolorselected = value; } }
        #endregion

        #region Text Color
        private Color _textcolornormal = Color.Black;
        public Color TextColorNormal { get { return _textcolornormal; } set { _textcolornormal = value; } }
        private Color _textcolorholver = Color.Black;
        public Color TextColorHolver { get { return _textcolorholver; } set { _textcolorholver = value; } }
        private Color _textcolorselected = Color.White;
        public Color TextColorSelected { get { return _textcolorselected; } set { _textcolorselected = value; } }
        #endregion

        #region Title Size
        private Size _titlesize = new Size(200, 30);
        public Size TitleSize { get { return _titlesize; }set { _titlesize = value;UpdateControl(); } }
        #endregion

        #region Enumeration
        public enum TitleLayout
        {
            Vertical,Horizontal,
        }
        public enum sizelayout
        {
            AutoSize,Manual,
        }
        #endregion

        #region TabCOntrol
        private TabControl _tabcontrol=null;
        public TabControl Tabcontrol
        {
            get
            {
                return _tabcontrol;
            }
            set
            {
                _tabcontrol = value;
                UpdateControl();
            }
        }
        #endregion

        #region Title Layout
        private TitleLayout _titlelayout = TitleLayout.Vertical;
        public TitleLayout Titlelayout
        {
            get { return _titlelayout; }
            set { _titlelayout = value; UpdateControl(); }
        }
        #endregion

        #region Title Margin
        private int _margin = 5;
        public int Titlemargin
        {
            get { return _margin; }
            set
            {
                _margin = value;
                UpdateControl();
            }
        }
        #endregion

        #region Title Padding
        private int _titlepadding = 0;
        public int TitlePadding
        {
            get { return _titlepadding; }
            set { _titlepadding = value; UpdateControl(); }
        }
        #endregion

        #region AutoSize
        private sizelayout _sizeLayout = sizelayout.AutoSize;
        public sizelayout SizeLayout
        {
            get { return _sizeLayout; }
            set
            {
                _sizeLayout = value;
                UpdateControl();
            }
        }
        #endregion

        #region TextTitle
        private ContentAlignment _textlayouttitle = ContentAlignment.MiddleLeft;
        public ContentAlignment TextLayoutTitle
        {
            get { return _textlayouttitle; }
            set
            {
                _textlayouttitle = value;
                UpdateControl();
            }
        }
        #endregion

        #region Title Collection
        List<SingleTitle> _titles = new List<SingleTitle>();
        #endregion

        #region Update
        private void UpdateControl()
        {
            this.Size = new Size(0, 0);
            _titles.Clear();
            this.Controls.Clear();
            if (_tabcontrol != null)
            {
                int _index = 0;
                foreach(TabPage _page in _tabcontrol.TabPages)
                {
                    SingleTitle _temp = new SingleTitle();
                    _temp.TabPage = _page;
                    _temp.BackGroundColorNormal = _backgroundcolornormal;
                    _temp.BackGroundColorHolver = _backgroundcolorholver;
                    _temp.BackGroundColorSelected = _backgroundcolorselected;
                    _temp.TextColorNormal = _textcolornormal;
                    _temp.TextColorHolver = _textcolorholver;
                    _temp.TextColorSelected = _textcolorselected;
                    _temp.TextLayout = _textlayouttitle;
                    _temp.Size = _titlesize;
                    switch (_titlelayout)
                    {
                        case TitleLayout.Horizontal:
                            switch (_sizeLayout)
                            {
                                case sizelayout.AutoSize:
                                    _temp.Size = new Size(TextRenderer.MeasureText(_page.Text, _page.Font, new Size(1000, 500)). Width + 5 + _titlepadding, _titlesize.Height);
                                    try
                                    {
                                        _temp.Location = new Point(_titles[_titles.Count - 1].Location.X + _titles[_titles.Count - 1].Size.Width + _margin, 0);

                                    }
                                    catch
                                    {
                                        _temp.Location=new Point(_index*(_temp.Width+_margin),0);
                                    }
                                    break;
                                case sizelayout.Manual:
                                    _temp.Location = new Point(_index * (_temp.Width + _margin), 0);
                                    break;
                                    this.Size = new Size(this.Width + _temp.Width + _margin, _titlesize.Height);
                                    break;
                            }
                            break;
                        case TitleLayout.Vertical:
                            _temp.TextPadding = _titlepadding;
                            _temp.Location = new Point(0, _index * (_titlesize.Height + _margin));
                            this.Size = new Size(_titlesize.Width, this.Height + _titlesize.Height + _margin);
                            break;

                    }
                    _temp.Click += _temp_Click;
                    _titles.Add(_temp);
                    this.Controls.Add(_temp);
                    _index++;
                    try
                    {
                        _titles[0].Active();
                    }
                    catch { }
                }
            }
        }
        #endregion

        private void _temp_Click(object sender, EventArgs e)
        {
            SingleTitle temp = (SingleTitle)sender;
            temp.Active();
            _tabcontrol.SelectedTab = temp.TabPage;
            foreach(SingleTitle _title in _titles)
            {
                if (_title != temp) _title.Deactive();
            }
        }
    }
}
