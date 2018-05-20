using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace testexListBox
{
   public class exListBoxItem
    {
        private string _path;
        private Image _img;
        private string _title;
        private string _details;
        private string _time;
        private string _album;
        private int _id;
        private Point TitleLocation;
        private Size TitleSize;
        private Point TimeLocation;
        private Size TimeSize;
        private Point AlbumLocation;
        private Size AlbumSize;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public exListBoxItem(int id, string title, string time,string album,string path,Image img)
        {
            _id = id;
            _title = title;
            _time=time;
            Album = album;
            Img = img;
            Path = path;
            
        }

       

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Details
        {
            get { return _details; }
            set { _details = value; }
        }

        

        public string Time
        {
            get
            {
                return _time;
            }

            set
            {
                _time = value;
            }
        }

        public string Album
        {
            get
            {
                return _album;
            }

            set
            {
                _album = value;
            }
        }

        public Image Img
        {
            get
            {
                return _img;
            }

            set
            {
                _img = value;
            }
        }

        public string Path
        {
            get
            {
                return _path;
            }

            set
            {
                _path = value;
            }
        }

        public void drawItem(DrawItemEventArgs e, Padding margin,
                             Font titleFont, Font detailsFont, StringFormat aligment,
                             Size imageSize)
        {
            TitleLocation = new Point(e.Bounds.X + margin.Horizontal , e.Bounds.Y + e.Bounds.Height / 2 - 10);
            TitleSize = new Size((e.Bounds.Width - margin.Right  - margin.Horizontal)/3,
                                                  (int)titleFont.GetHeight() + 10);
            TimeLocation = new Point(TitleLocation.X + TitleSize.Width+margin.Horizontal+10, e.Bounds.Y + e.Bounds.Height / 2 - 10);
            TimeSize = new Size((((e.Bounds.Width - margin.Right- margin.Horizontal) / 3) / 2), (int)titleFont.GetHeight() + 10);
            AlbumLocation = new Point(TimeLocation.X + TimeSize.Width + margin.Horizontal + 10, e.Bounds.Y + e.Bounds.Height / 2 - 10);
            AlbumSize = new Size(((e.Bounds.Width - margin.Right - margin.Horizontal) / 3), (int)titleFont.GetHeight() + 10);
           
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(Brushes.CornflowerBlue, e.Bounds);
            }
            else
            {
                e.Graphics.FillRectangle(Brushes.Beige, e.Bounds);
            }   

            
            e.Graphics.DrawLine(Pens.Blue, e.Bounds.X, e.Bounds.Y, e.Bounds.X + e.Bounds.Width, e.Bounds.Y);
            Rectangle titleBounds = new Rectangle(TitleLocation, TitleSize);
            Rectangle TimeBounds = new Rectangle(TimeLocation, TimeSize);
            Rectangle AlbumBounds = new Rectangle(AlbumLocation, AlbumSize);
            
            e.Graphics.DrawString(this.Title, titleFont, Brushes.Black, titleBounds, aligment);
            e.Graphics.DrawString(this.Time, titleFont, Brushes.Black, TimeBounds, aligment);
            e.Graphics.DrawString(this.Album, titleFont, Brushes.Black, AlbumBounds, aligment);
            // put some focus rectangle
            e.DrawFocusRectangle();
        }

    }

    public partial class exListBox : ListBox
    {

        private Size _imageSize;
        private StringFormat _fmt;
        private Font _titleFont;
        private Font _detailsFont;

        public exListBox(Font titleFont, Font detailsFont,
                         StringAlignment aligment, StringAlignment lineAligment)
        {
            _titleFont = titleFont;
            _detailsFont = detailsFont;
           
            _fmt = new StringFormat();
            _fmt.Alignment = aligment;
            _fmt.LineAlignment = lineAligment;
            _titleFont = titleFont;
            _detailsFont = detailsFont;
        }

        public exListBox()
        {
            InitializeComponent();
           
            _fmt = new StringFormat();
            _fmt.Alignment = StringAlignment.Center;
            _fmt.LineAlignment = StringAlignment.Center;
            _titleFont = new Font(this.Font, FontStyle.Bold);
            _detailsFont = new Font(this.Font, FontStyle.Regular);
            
        }


        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            
            if (this.Items.Count > 0)            
            {                
                exListBoxItem item = (exListBoxItem)this.Items[e.Index];                
                item.drawItem(e, this.Margin, _titleFont, _detailsFont, _fmt, this._imageSize);
            }                            
        }
       
        

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
