using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            label9.Enabled = false;
            label10.Enabled = false;
            textBox5.Enabled = false;
            comboBox2.Enabled = false;

            panel1.BackColor = Color.FromArgb(180, 255, 255, 255);
            comboBox3.Items.Add("08:00");
            comboBox3.Items.Add("09:00");
            comboBox3.Items.Add("10:00");
            comboBox3.Items.Add("11:00");
            comboBox3.Items.Add("12:00");
            comboBox3.Items.Add("13:00");
            comboBox3.Items.Add("14:00");
            comboBox3.Items.Add("15:00");
            comboBox3.Items.Add("16:00");
            toolTip1.SetToolTip(textBox1, "Enter customer name (letters only)");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // ================= VALIDATION =================

            if (textBox1.Text == "" ||
                textBox2.Text == "" ||
                maskedTextBox1.Text == "" ||
               // textBox5.Text == "" ||
                comboBox1.SelectedIndex == -1 )
            {
                MessageBox.Show("Please fill in all required fields!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Please select client type!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ================= DATE VALIDATION =================

            if (dateTimePicker1.Value.Date < DateTime.Today)
            {
                MessageBox.Show("You cannot select a past date!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBox3.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a time slot!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ================= PRICE (SAFE VERSION) =================

            int price = 0;

            if (comboBox1.SelectedItem.ToString() == "Knotless Braids")
                price = 450;
            else if (comboBox1.SelectedItem.ToString() == "Straight Back")
                price = 300;
            else if (comboBox1.SelectedItem.ToString() == "Straight Up")
                price = 350;
            else if (comboBox1.SelectedItem.ToString() == "S-Curl")
                price = 250;
            else if (comboBox1.SelectedItem.ToString() == "Installations")
                price = 750;
            else if (comboBox1.SelectedItem.ToString() == "Snoopie Braids")
                price = 400;
            else if (comboBox1.SelectedItem.ToString() == "Sew-In")
                price = 700;
            else if (comboBox1.SelectedItem.ToString() == "Ponytail")
                price = 300;
            else if (comboBox1.SelectedItem.ToString() == "Fulani Braids")
                price = 500;
            else if (comboBox1.SelectedItem.ToString() == "Locs")
                price = 600;
            else if (comboBox1.SelectedItem.ToString() == "Twists")
                price = 350;

            // ================= DISCOUNT =================

            double finalPrice = price;

            if (radioButton2.Checked) // Student
            {
                finalPrice = price - (price * 0.25);
            }

            // Update price display
            textBox3.Text = "R " + finalPrice.ToString("0.00");

            string clientType = radioButton2.Checked ? "Student" : "Normal Client";

            // ================= PROFESSIONAL LISTBOX OUTPUT =================
            string bookingInfo  = string.Join(Environment.NewLine, listBox1.Items.Cast<object>());


            
            listBox1.Items.Add("====================================");
            listBox1.Items.Add("           BOOKING DETAILS");
            listBox1.Items.Add("====================================");
            listBox1.Items.Add("Name: " + textBox1.Text + " " + textBox2.Text);
            listBox1.Items.Add("Contact: " + maskedTextBox1.Text);
            listBox1.Items.Add("Student Number: " + textBox5.Text);
            listBox1.Items.Add("Service: " + comboBox1.SelectedItem.ToString());
            listBox1.Items.Add("Appointment: " +
            dateTimePicker1.Value.ToString("dddd, dd MMMM yyyy") +
            " at " +
            comboBox3.SelectedItem.ToString());
            listBox1.Items.Add("Client Type: " + clientType);
            listBox1.Items.Add("Final Price: " + textBox3.Text);
            listBox1.Items.Add("====================================");
            listBox1.Items.Add("");

            MessageBox.Show("Information Confirmed",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            button2.Enabled = true;
        }




        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        int price = 0;

           
             if (comboBox1.SelectedItem.ToString() == "Straight Back")
                price = 300;
            else if (comboBox1.SelectedItem.ToString() == "Straight Up")
                price = 350;
            else if (comboBox1.SelectedItem.ToString() == "S-Curl")
                price = 250;
            else if (comboBox1.SelectedItem.ToString() == "Installations")
                price = 750;
            else if (comboBox1.SelectedItem.ToString() == "Snoopie Braids")
                price = 400;
            else if (comboBox1.SelectedItem.ToString() == "Sew-In")
                price = 700;
            else if (comboBox1.SelectedItem.ToString() == "Ponytail")
                price = 300;
            else if (comboBox1.SelectedItem.ToString() == "Fulani")
                price = 500;
            else if (comboBox1.SelectedItem.ToString() == "Locs")
                price = 600;
            else if (comboBox1.SelectedItem.ToString() == "Twists")
                price = 350;

            textBox3.Text = "R " + price.ToString();

            string style = comboBox1.SelectedItem.ToString();

           
             if (style == "Straight Back")
                pictureBox1.Image = Image.FromFile("images/straightback.jpg");

            else if (style == "Straight Up")
                pictureBox1.Image = Image.FromFile("images/straightup.jpg");

            else if (style == "S-Curl")
                pictureBox1.Image = Image.FromFile("images/scurl.jpg");

            else if (style == "Installations")
                pictureBox1.Image = Image.FromFile("images/installations.jpg");

            else if (style == "Snoopie Braids")
                pictureBox1.Image = Image.FromFile("images/Snoopie.jpg");

            else if (style == "Sew-In")
                pictureBox1.Image = Image.FromFile("images/sewin.jpg");

            else if (style == "Ponytail")
                pictureBox1.Image = Image.FromFile("images/ponytail.jpg");

            else if (style == "Fulani")
                pictureBox1.Image = Image.FromFile("images/fulani.jpg");

            else if (style == "Locs")
                pictureBox1.Image = Image.FromFile("images/locs.jpg");

            else if (style == "Twists")
                pictureBox1.Image = Image.FromFile("images/twists.jpg");

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label9.Enabled = false;
            label10.Enabled = false;
            textBox5.Enabled = false;
            comboBox2.Enabled = false;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label9.Enabled = true;
            label10.Enabled = true;
            textBox5.Enabled = true;
            comboBox2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            Form6 pay = new Form6();
            pay.Form5Instance = this;
            pay.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string cleaned = "";
            bool hasInvalidChar = false;

            foreach (char c in text)
            {
                if (char.IsLetter(c) || c == ' ') // allow letters + space
                {
                    cleaned += c;
                }
                else
                {
                    hasInvalidChar = true;
                }
            }

            if (hasInvalidChar)
            {
                int cursor = textBox1.SelectionStart;

                textBox1.Text = cleaned;

                // keep cursor stable
                textBox1.SelectionStart = cursor > 0 ? cursor - 1 : 0;

                // force focus back
                textBox1.Focus();
            }

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter customer name.");
                textBox1.Focus();
            }
        }

        private void Form5_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Only alphabets allowed (A–Z)", textBox1);
        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
            if (!maskedTextBox1.MaskCompleted)
            {
                MessageBox.Show(
                    "Please enter a valid 10-digit contact number before continuing.",
                    "Input Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                maskedTextBox1.Focus();
                return;
            }

            string phone = maskedTextBox1.Text;

            if (!phone.StartsWith("0"))
            {
                MessageBox.Show(
                    "The contact number must start with '0'. Please correct the entry.",
                    "Invalid Phone Number",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                maskedTextBox1.Focus();
            }
            //if (!maskedTextBox1.MaskCompleted || !maskedTextBox1.Text.StartsWith("0"))
            //{
            //    // TURN RED (error state)
            //    maskedTextBox1.BackColor = Color.LightCoral;

            //    // Force focus back
            //    maskedTextBox1.Focus();

            //    MessageBox.Show("Enter a valid 10-digit phone number starting with 0.");

            //    return;
            //}

            //// RESET to normal if valid
            //maskedTextBox1.BackColor = Color.White;
        }
    }


}
