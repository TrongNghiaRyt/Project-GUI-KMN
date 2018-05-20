using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KMNCustomControl;

namespace KMNCustomControl
{
    public partial class ListVideo : UserControl
    {
        private string[] FileNames;
        public ListVideo()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.ValidateNames = true;
            ofd.Filter = "WMV|*.wmv|MP4|*.mp4";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileNames = ofd.FileNames;

                foreach (string Item in FileNames)
                {
                    //flowLayoutPanel1.Controls.Add(new VideoLayout(Item));
                }

            }
        }

       
    }
}
