using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp132
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog f = new System.Windows.Forms.OpenFileDialog();
            f.ShowDialog();
            System.Drawing.Image i = System.Drawing.Image.FromFile(f.FileName);
            pictureBox1.Image = i;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            System.IO.MemoryStream m = new System.IO.MemoryStream();
            pictureBox1.Image.Save(m, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] b = m.GetBuffer();
            System.Windows.Forms.SaveFileDialog sfile = new System.Windows.Forms.SaveFileDialog();
            sfile.ShowDialog();
            System.IO.FileStream f = new System.IO.FileStream(sfile.FileName, System.IO.FileMode.Create);
            f.Write(b, 0,b.Length);
            f.Flush();
            f.Close();

        }
    }
}
