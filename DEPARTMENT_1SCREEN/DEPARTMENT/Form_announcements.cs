using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DEPARTMENT
{
    public partial class Form_announcements : Form
    {
        public Form_announcements()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;)|*.jpg; *.jpeg; *.gif; *.bmp;)";
            if (open.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = open.FileName;
                pictureBox1.Image = new Bitmap(open.FileName);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.Copy(textBox1.Text,Path.Combine(@"C:\Users\Arnest Jerome\Documents\Visual Studio 2015\Projects\DEPARTMENT\DEPARTMENT\Resources",Path.GetFileName(textBox1.Text)), true);
            label1.Text = "Image File Saved Successfully!";
        }

        private void Form_announcements_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = "";
        }
    }
}
