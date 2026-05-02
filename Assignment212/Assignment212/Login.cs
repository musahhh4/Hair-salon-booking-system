using Assignment212.ist2ibDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment212
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            lOGIN_USERSTableAdapter.FillBy(ist2ibDataSet.LOGIN_USERS, textBox1.Text, textBox2.Text);
            if (ist2ibDataSet.LOGIN_USERS.Rows.Count > 0)
            {
                MessageBox.Show("Login Successful! Welcome: " + ist2ibDataSet.LOGIN_USERS.Rows[0]["username"].ToString(),
                                  "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                HomePage main = new HomePage();
                main.Show();
            }
            else
            {
                DialogResult Login = MessageBox.Show("Invalid username or password!", "Login Failed", MessageBoxButtons.OKCancel);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ist2ibDataSet.LOGIN_USERS' table. You can move, or remove it, as needed.
            this.lOGIN_USERSTableAdapter.Fill(this.ist2ibDataSet.LOGIN_USERS);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if ((radioButton1.Checked == false && radioButton2.Checked == false))
            {
                MessageBox.Show("Please Indicate that you are a PATIENT OR DOCTOR", "CAUTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (radioButton1.Checked == true)
            {
                Patient patient = new Patient();
                patient.Show();

            }
            else
            {
                Doctor doctor = new Doctor();
                doctor.Show();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please SignUp to create a profile","Sign Up Required",MessageBoxButtons.OK, MessageBoxIcon.Information );
            button2.Visible = true;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            label3.Visible = false;
            button3.Visible = false;
            button4.Visible = false;


        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Focus();
                MessageBox.Show("Please fill in the Username and log in","Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                textBox1.BackColor = Color.White;
                if (textBox2.Text == "")
                {
                    textBox2.Focus();
                }
                else
                {
                    textBox2.BackColor = Color.White;
                    if ((textBox1.Text == "") || (textBox2.Text == ""))
                    {
                        MessageBox.Show("Please fill in the Password and log in", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
