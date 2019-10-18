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
    public partial class Form_dashboard_LCD : Form
    {

        int a = 270, b = 705;
        private void timer2_Tick(object sender, EventArgs e)
        {   
            
            label8.SetBounds(a,b,1,1);
            a--;
          
            
            if (label8.Bounds.Right == 250)
            {
                a = 270;

            }

            if (label8.Bounds.Left == 270)
            {
                timer2.Interval = 3000;
            }
            else
            {
                timer2.Interval = 1;
            }

            
        }
        public Form_dashboard_LCD()
        {   
            
           
            InitializeComponent();
            label8.SetBounds(a, b, 1, 1);
            label8.Text = " STANDBY FOR ANNOUNCEMENTS.... ";
            label6.BringToFront();
            Timer tm = new Timer();
            tm.Interval = 5000;
            tm.Tick += new EventHandler(changeImage);
            tm.Start();
            timer1.Start();
            timer2.Interval = 3000;
           
            timer2.Start();
            
        }
        int z = 0;
        

        private void changeImage(object sender, EventArgs e)
        {  
            String[] files = Directory.GetFiles(@"C:\Users\Arnest Jerome\Documents\Visual Studio 2015\Projects\DEPARTMENT\DEPARTMENT\Resources");
            List<String> b1 = new List<String>();
  
               b1.AddRange(files);
         //   b1.Add(Properties.Resources.a);
         //   b1.Add(Properties.Resources.b);
          //  b1.Add(Properties.Resources.c);
          //  b1.Add(Properties.Resources.d);
         //   b1.Add(Properties.Resources.e);
          //  b1.Add(Properties.Resources.f);
  
           
            int c = b1.Count;
          //  int index = DateTime.Now.Second%c+1;
            this.pictureBox1.Image = Image.FromFile(b1[z]);
            if (z < c-2 )
                z++;
            else
                z=0;


        }
        private void Form_dashboard_LCD_Load(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToShortTimeString();
            label9.Text = DateTime.Now.ToShortDateString();
            pictureBox5.BringToFront();
            label7.BringToFront();
        }
        public void ValueFromForm1(string value)
        {
           
            label2.Text = value;
     
        }
        public void ValueFromForm1v2(string val)
        {
          
            label8.Text = val;
            a = 270;

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            String dateTime = DateTime.Now.ToShortTimeString();
            this.label6.Text = dateTime;
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Interval = 5000;
            timer3.Stop();
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        
      
    }
}
