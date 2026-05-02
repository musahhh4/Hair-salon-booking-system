using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 Book = new Form2();
            Book.Show();
            this.Hide();

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form3 reg = new Form3();
            reg.Show();
            this.Hide();
            //Form3 reg = new Form3();
            //reg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text;

            // 1. Check empty fields
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Please enter both username and password.",
                    "Login Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // 2. Simple login validation (replace with database later if needed)
            if (username == "admin" && password == "1234")
            {
                MessageBox.Show(
                    "Login successful. Welcome!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                Form5 Book = new Form5();
                Book.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Invalid username or password.",
                    "Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                textBox2.Clear();
                textBox1.Focus();
            }
            //Form5 Book = new Form5();
            //Book.Show();
            //this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(120, 0, 0, 0);
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            textBox2.UseSystemPasswordChar = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !checkBox1.Checked;
        }
    }
}
