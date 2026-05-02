using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        

        private Image AdjustBrightness(Image image, float brightness)
    {
        float b = brightness;

        ColorMatrix cm = new ColorMatrix(new float[][]
        {
        new float[] {b, 0, 0, 0, 0},
        new float[] {0, b, 0, 0, 0},
        new float[] {0, 0, b, 0, 0},
        new float[] {0, 0, 0, 1, 0},
        new float[] {0, 0, 0, 0, 1}
        });

        ImageAttributes attributes = new ImageAttributes();
        attributes.SetColorMatrix(cm);

        Bitmap bmp = new Bitmap(image.Width, image.Height);

        using (Graphics g = Graphics.FromImage(bmp))
        {
            g.DrawImage(image,
                new Rectangle(0, 0, bmp.Width, bmp.Height),
                0, 0, image.Width, image.Height,
                GraphicsUnit.Pixel,
                attributes);
        }

        return bmp;
    }


    private void Form3_Load(object sender, EventArgs e)
        {
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            toolTip1.SetToolTip(textBox1, "Enter your first name");
            toolTip1.SetToolTip(textBox2, "Enter your last name");
            toolTip1.SetToolTip(textBox3, "Enter a valid cellphone number");
            toolTip1.SetToolTip(textBox4, "Enter your email address");
            toolTip1.SetToolTip(textBox5, "Create a username");
            toolTip1.SetToolTip(textBox6, "Create a password");
            toolTip1.SetToolTip(textBox7, "Confirm your password");
            toolTip1.SetToolTip(comboBox1, "Select preferred hairstyle");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(120, 0, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // EMPTY FIELD CHECK
                if (textBox1.Text == "" ||
                    textBox2.Text == "" ||
                    textBox3.Text == "" ||
                    textBox4.Text == "" ||
                    textBox5.Text == "" ||
                    textBox6.Text == "" ||
                    textBox7.Text == "")
                {
                    MessageBox.Show("Please fill in all text fields!",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // EMAIL VALIDATION
                if (!textBox4.Text.Contains("@") || !textBox4.Text.Contains("."))
                {
                    MessageBox.Show("Please enter a valid email address.",
                        "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox4.Focus();
                    return;
                }

                // PHONE VALIDATION (digits only + length check)
                if (textBox3.Text.Length < 10 || !textBox3.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Please enter a valid 10-digit cellphone number.",
                        "Invalid Phone", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox3.Focus();
                    return;
                }

                // PASSWORD MATCH CHECK
                if (textBox6.Text != textBox7.Text)
                {
                    MessageBox.Show("Passwords do not match!",
                        "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox7.Focus();
                    return;
                }

                // CUSTOMER TYPE
                if (!radioButton1.Checked && !radioButton2.Checked)
                {
                    MessageBox.Show("Please select a customer type.",
                        "Missing Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // GENDER
                if (!radioButton3.Checked && !radioButton4.Checked)
                {
                    MessageBox.Show("Please select a gender.",
                        "Missing Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // COMBOBOX
                if (comboBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a preferred hairstyle.",
                        "Missing Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // SUCCESS
                MessageBox.Show("Account created successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form2 loginForm = new Form2();
                loginForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error occurred: " + ex.Message,
                    "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //        if (textBox1.Text == "" ||
            //textBox2.Text == "" ||
            //textBox3.Text == "" ||
            //textBox4.Text == "" ||
            //textBox5.Text == "" ||
            //textBox6.Text == "" ||
            //textBox7.Text == "")
            //        {
            //            MessageBox.Show("Please fill in all text fields!",
            //                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            return;
            //        }

            //        // CUSTOMER TYPE (Normal / Student)
            //        if (!radioButton1.Checked && !radioButton2.Checked)
            //        {
            //            MessageBox.Show("Please select a customer type (Normal Client or Student).",
            //                "Missing Customer Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            return;
            //        }

            //        // GENDER (Male / Female)
            //        if (!radioButton3.Checked && !radioButton4.Checked)
            //        {
            //            MessageBox.Show("Please select a gender (Male or Female).",
            //                "Missing Gender", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            return;
            //        }

            //        // CUSTOMER TYPE DROPDOWN (if used for extra category)
            //        if (comboBox1.SelectedIndex == -1)
            //        {
            //            MessageBox.Show("Please select a service or category.",
            //                "Missing Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            return;
            //        }

            //        // SUCCESS
            //        MessageBox.Show("Account created successfully!",
            //            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //        // Redirect to login form
            //        Form2 loginForm = new Form2();
            //        loginForm.Show();
            //        this.Hide();



        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.LightYellow;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.LightYellow;
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.LightYellow;
        }

        private void textBox3_MouseEnter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.LightYellow;
        }

        private void textBox4_MouseEnter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.LightYellow;
        }

        private void textBox5_MouseEnter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.LightYellow;
        }

        private void textBox6_MouseEnter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.LightYellow;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox7_MouseEnter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.LightYellow;
        }

        private void textBox3_MouseLeave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void textBox4_MouseLeave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void textBox5_MouseLeave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void textBox6_MouseLeave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void textBox7_MouseLeave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }
    }
    
}
