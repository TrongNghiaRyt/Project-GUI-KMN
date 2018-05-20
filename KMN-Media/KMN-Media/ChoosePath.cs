using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMN_Media
{
    public partial class ChoosePath : Form
    {
        private static string localpath;
        public ChoosePath()
        {
            InitializeComponent();
        }

        public static string Localpath
        {
            get
            {
                return localpath;
            }

            set
            {
                localpath = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog open = new FolderBrowserDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                Localpath = open.SelectedPath;
                ReloadForm();
            }
        }

        private void ChoosePath_Load(object sender, EventArgs e)
        {
                this.textBox1.Text = MainForm.Local;
                Localpath = MainForm.Local;
        }
        private void ReloadForm()
        {
            textBox1.Text = Localpath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm.Local = Localpath;
            MainForm.CheckUpdate = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
