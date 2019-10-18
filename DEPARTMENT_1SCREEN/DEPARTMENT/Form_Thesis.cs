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
    public partial class Form_Thesis : Form
    {
        int count;
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Arnest Jerome\OneDrive\Documents\SAD.accdb");
        Form_thesisupdate ft = new Form_thesisupdate();
        Form_borrowing fb = new Form_borrowing();
        public Form_Thesis()
        {
            InitializeComponent();
            button9.Enabled = false;
            button10.Enabled = false;
            button1.Enabled = false;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form_Thesis_Load(object sender, EventArgs e)
        {

        }

        private void constructDatagridview()
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Title";
            dataGridView1.Columns[1].Name = "Adviser";
            dataGridView1.Columns[2].Name = "Status";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            connection.Open();
            count = 0;
            OleDbCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select thesisTitle, thesisAdviser, thesisStatus, thesisYear, thesisAbstract, thesisAuthor, thesisImagePath from Thesis_table where thesisTitle LIKE'" + textBox1.Text + "%'";
                //OR thesisTitle LIKE'" + textBox1.Text +"%' OR thesisAdviser LIKE '"+ textBox4.Text +"%' OR thesisAuthor LIKE '"+ textBox3.Text +"'%";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            connection.Open();
            count = 0;
            OleDbCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select thesisTitle, thesisAdviser, thesisStatus, thesisYear, thesisAbstract, thesisAuthor, thesisImagePath from Thesis_table where thesisYear LIKE'" + textBox2.Text + "%'";
            //OR thesisTitle LIKE'" + textBox1.Text +"%' OR thesisAdviser LIKE '"+ textBox4.Text +"%' OR thesisAuthor LIKE '"+ textBox3.Text +"'%";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            connection.Open();
            count = 0;
            OleDbCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select thesisTitle, thesisAdviser, thesisStatus, thesisYear, thesisAbstract, thesisAuthor, thesisImagePath from Thesis_table where thesisAuthor LIKE'" + textBox3.Text + "%'";
            //OR thesisTitle LIKE'" + textBox1.Text +"%' OR thesisAdviser LIKE '"+ textBox4.Text +"%' OR thesisAuthor LIKE '"+ textBox3.Text +"'%";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            connection.Open();
            count = 0;
            OleDbCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select thesisTitle, thesisAdviser, thesisStatus, thesisYear, thesisAbstract, thesisAuthor, thesisImagePath from Thesis_table where thesisAdviser LIKE'" + textBox4.Text + "%'";
            //OR thesisTitle LIKE'" + textBox1.Text +"%' OR thesisAdviser LIKE '"+ textBox4.Text +"%' OR thesisAuthor LIKE '"+ textBox3.Text +"'%";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;


                richTextBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["thesisTitle"].FormattedValue.ToString();
                txtAuthor.Text = dataGridView1.Rows[e.RowIndex].Cells["thesisAuthor"].FormattedValue.ToString();
                txtAbstract.Text = dataGridView1.Rows[e.RowIndex].Cells["thesisAbstract"].FormattedValue.ToString();
                lblAdviser.Text = dataGridView1.Rows[e.RowIndex].Cells["thesisAdviser"].FormattedValue.ToString();
                lblStatus.Text = dataGridView1.Rows[e.RowIndex].Cells["thesisStatus"].FormattedValue.ToString();
                lblYear.Text = dataGridView1.Rows[e.RowIndex].Cells["thesisYear"].FormattedValue.ToString();

                pictureBox1.ImageLocation = dataGridView1.Rows[e.RowIndex].Cells["thesisImagePath"].FormattedValue.ToString();

                if (lblStatus.Text == "unavailable" || lblStatus.Text == "Unavailable")
                {
                    lblStatus.ForeColor = Color.Red;
                    button9.Enabled = false;
                    button10.Enabled = true;

                }
                else
                {
                    lblStatus.ForeColor = Color.Black;
                    button9.Enabled = true;
                    button10.Enabled = false;

                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ft.Show();
            ft.ValueFromForm1(richTextBox1.Text);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "" || richTextBox1.Text == "THIS IS THE THESIS TITLE")
            {
                button1.Enabled = false;
            }
            else
                button1.Enabled = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            fb.Show();
            fb.ValueFromForm1(richTextBox1.Text);
            
        }
    }
}
