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
    public partial class FORM_SA : Form
    {
        int x = 1;
        int y = 0;
       
        Form_dashboard_LCD LCD = new Form_dashboard_LCD();
        public FORM_SA()
        {
            InitializeComponent();
            label2.BringToFront();
            button2.Visible = false;
            button3.Visible = false;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {   y++;
            if (y % 2 != 0)
            {
            //    LCD.Location = new Point(100, 100);
             //   LCD.StartPosition = FormStartPosition.Manual;
               // LCD.Bounds = Screen.AllScreens[1].Bounds;
                LCD.Show();
          

            
                button2.Visible = true;
                button3.Visible = true;
                button1.Text = "HIDE";

            }
            else
            {  
                button1.Text = "EXTEND";
                LCD.Hide();
                LCD.Refresh();
                button2.Visible = false;
                button3.Visible = false;
            }
        }

        private object UBound(Screen[] allScreens)
       {
            throw new NotImplementedException();
       }

        private void button2_Click(object sender, EventArgs e)
        {
            if (x <= 9)
                x++;
            else
                x = 0;
            label1.Text = Convert.ToString(x);
            LCD.ValueFromForm1(label1.Text);
            LCD.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            x = 0;
            label1.Text = Convert.ToString(x);
            LCD.ValueFromForm1(label1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_announcements a = new Form_announcements();
            a.Show();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.label2.Text = dateTime.ToString();
        }

        private void FORM_SA_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form_Thesis thesis = new Form_Thesis();
            thesis.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {   
                LCD.ValueFromForm1v2(textBox2.Text);
               
            }
            LCD.Refresh();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
