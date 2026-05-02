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
    public partial class Form6 : Form
    {
        public Form5 Form5Instance;
        public Form6()
        {
            InitializeComponent();
        }
        string bookingInfo;
        public Form6(string info)
        {
            InitializeComponent();
            bookingInfo = info;
        }
        private bool IsGroupBox1Valid()
        {
            if (!maskedTextBox1.MaskCompleted)
                return false;

            if (!maskedTextBox2.MaskCompleted)
                return false;

            if (!maskedTextBox3.MaskCompleted)
                return false;

            if (!maskedTextBox4.MaskCompleted)
                return false;

            return true;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // FIRST check GroupBox1
            if (!IsGroupBox1Valid())
            {
                MessageBox.Show(
                    "Please complete all payment details before continuing.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                groupBox2.Visible = false;
                groupBox1.Visible = true;
                return;
            }
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            // THEN check checkbox
            if (!checkBox1.Checked)
            {
                MessageBox.Show(
                    "Please agree to the Terms & Conditions before continuing.",
                    "Agreement Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            
            Form7 frm7 = new Form7();
            frm7.Form5Instance = this.Form5Instance;
            frm7.Show();
            this.Hide();
           
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            
            maskedTextBox2.Mask = "00/00";
            maskedTextBox2.ValidatingType = typeof(DateTime);

            groupBox2.Visible = false; // IMPORTANT: hide at start
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (!maskedTextBox2.MaskCompleted)
            {
                MessageBox.Show("Please enter a valid expiry date (MM/YY).");
                maskedTextBox2.Focus();
                return;
            }

            string input = maskedTextBox2.Text;

            int month = int.Parse(input.Substring(0, 2));
            int year = int.Parse(input.Substring(3, 2)) + 2000; // convert YY → 20YY

            // Check valid month
            if (month < 1 || month > 12)
            {
                MessageBox.Show("Invalid month. Enter a value between 01 and 12.");
                maskedTextBox2.Focus();
                return;
            }

            // Create expiry date (end of month)
            DateTime expiryDate = new DateTime(year, month, DateTime.DaysInMonth(year, month));

            // Compare with current date
            if (expiryDate < DateTime.Now.Date)
            {
                MessageBox.Show("Card has expired. Enter a valid future date.");
                maskedTextBox2.Clear();
                maskedTextBox2.Focus();
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            string text = maskedTextBox1.Text;
            string cleaned = "";
            bool hasInvalidChar = false;

            foreach (char c in text)
            {
                if (char.IsDigit(c) || c == ' ') // allow spaces for grouping
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
                int cursor = maskedTextBox1.SelectionStart;

                maskedTextBox1.Text = cleaned;

                // Keep cursor stable
                maskedTextBox1.SelectionStart = cursor > 0 ? cursor - 1 : 0;

                // Force focus back
                maskedTextBox1.Focus();

                MessageBox.Show("Card number must contain digits only.");
            }
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            string text = maskedTextBox3.Text;
            string cleaned = "";
            bool hasInvalidChar = false;

            foreach (char c in text)
            {
                if (char.IsDigit(c))
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
                int cursor = maskedTextBox3.SelectionStart;

                maskedTextBox3.Text = cleaned;

                // Keep cursor stable
                maskedTextBox3.SelectionStart = cursor > 0 ? cursor - 1 : 0;

                // Force focus back
                maskedTextBox3.Focus();

                MessageBox.Show("CVV must contain digits only.");
            }
        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            string text = maskedTextBox4.Text;
            string cleaned = "";
            bool hasInvalidChar = false;

            foreach (char c in text)
            {
                if (char.IsDigit(c))
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
                int cursor = maskedTextBox4.SelectionStart;

                maskedTextBox4.Text = cleaned;

                // Keep cursor stable
                maskedTextBox4.SelectionStart = cursor > 0 ? cursor - 1 : 0;

                // Force focus back
                maskedTextBox4.Focus();

                MessageBox.Show("Postal code must contain digits only.");
            }
        }
    }
}
