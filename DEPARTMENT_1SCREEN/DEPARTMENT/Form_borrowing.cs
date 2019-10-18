using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEPARTMENT
{
    public partial class Form_borrowing : Form
    {
        public Form_borrowing()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Borrowing Successful!");
        }

        private void Form_borrowing_Load(object sender, EventArgs e)
        {

        }
        public void ValueFromForm1(string value)
        {

            richTextBox2.Text = value;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
