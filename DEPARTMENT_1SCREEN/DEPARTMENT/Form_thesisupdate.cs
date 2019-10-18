using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace DEPARTMENT
{
    public partial class Form_thesisupdate : Form
    {

        int count;
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Arnest Jerome\OneDrive\Documents\SAD.accdb");
        public Form_thesisupdate()
        {
            InitializeComponent();
            radioButton1.Checked = true;
        }

        private void Form_thesisupdate_Load(object sender, EventArgs e)
        {

        }
        public void ValueFromForm1(string value)
        {

            richTextBox2.Text = value;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            String stats="";
            if (radioButton1.Checked == true)
            {
                
                radioButton2.Checked = false;
                stats = "Available";
            }
            else if (radioButton2.Checked == true)
            {
                radioButton1.Checked = false;
                stats = "Unavailable";
            }

            connection.Open();
            count = 0;
            OleDbCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update Thesis_table SET thesisTitle ='" + textBox2.Text + "', thesisRef ='"+textBox1.Text+"', thesisYear ='"+textBox3.Text+"', thesisAuthor ='"+textBox4.Text+"', thesisAdviser ='"+textBox5.Text+"', thesisAbstract ='"+richTextBox1.Text+"', thesisStatus = '"+stats+"' WHERE thesisTitle ='" + richTextBox2.Text +"'";
            //OR thesisTitle LIKE'" + textBox1.Text +"%' OR thesisAdviser LIKE '"+ textBox4.Text +"%' OR thesisAuthor LIKE '"+ textBox3.Text +"'%";
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("RECORD SAVED SUCCESSFULLY!");
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
