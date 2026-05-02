using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment212
{
    public partial class HomePage : Form
    {
        PictureBox[] slideBoxes;
        int currentIndex = 0;
        
        public HomePage()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor();
            doctor.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show( "Are you sure you want to logout?", "Logout Confirmation",MessageBoxButtons.YesNo, MessageBoxIcon.Question );

            if (result == DialogResult.Yes)
            {
                Login form1 = new Login();
                form1.Show();

            }
            else
            { 
                this.Close();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Paint(object sender, PaintEventArgs e)
        {


        }

        private void label7_Click(object sender, EventArgs e)
        {
            Medical_Records medical_Records = new Medical_Records();
            medical_Records.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment();   
            appointment.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Department department = new Department();
            department.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            slideBoxes[currentIndex].Visible = false;
            currentIndex = (currentIndex + 1) % slideBoxes.Length;
            slideBoxes[currentIndex].Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            slideBoxes = new PictureBox[]
        { pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13 };

          
          for (int i = 0; i < slideBoxes.Length; i++)
                slideBoxes[i].Visible = (i == 0);

            timer1.Start();
            
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();  
            dashboard.Show();
        }
    }
}
