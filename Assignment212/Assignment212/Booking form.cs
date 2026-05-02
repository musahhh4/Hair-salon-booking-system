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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment212
{
    public partial class Booking_form : Form
    {
        public Booking_form()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "KWAZULU-NATAL")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Pietermaritzburg");
                comboBox2.Items.Add("Durban");
                comboBox2.Items.Add("Ladysmith");
                comboBox2.Items.Add("Newcastle");
                comboBox2.Items.Add("Estcourt");
            }
            else if (comboBox1.SelectedItem.ToString() == "GAUTENG")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Johannesburg");
                comboBox2.Items.Add("Pretoria");   
                comboBox2.Items.Add("Sandton");
                comboBox2.Items.Add("Soweto");
                comboBox2.Items.Add("Randburg");
            }
            else if (comboBox1.SelectedItem.ToString() == "MPUMALANGA")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Ermelo");
                comboBox2.Items.Add("Volkrust");
                comboBox2.Items.Add("Secunda");
                comboBox2.Items.Add("Mbombela");
                comboBox2.Items.Add("Emalahleni"); 
            }
            else if (comboBox1.SelectedItem.ToString() == "NORTH WEST")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Mahikeng");
                comboBox2.Items.Add("Rustenburg"); 
                comboBox2.Items.Add("Potchefstroom");
                comboBox2.Items.Add("Klerksdorp");
                comboBox2.Items.Add("Vryburg");
            }
            else if (comboBox1.SelectedItem.ToString() == "FREE STATE") 
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Bloemfontein");
                comboBox2.Items.Add("Welkom");
                comboBox2.Items.Add("Sasolburg");
                comboBox2.Items.Add("Kroonstad");
                comboBox2.Items.Add("Bethlehem");
            }
            else if (comboBox1.SelectedItem.ToString() == "LIMPOPO")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Polokwane");
                comboBox2.Items.Add("Tzaneen");
                comboBox2.Items.Add("Bela-Bela");
                comboBox2.Items.Add("Thohoyandou");
                comboBox2.Items.Add("Mokopane");
            }
            else if (comboBox1.SelectedItem.ToString() == "NORTHERN CAPE")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Upington");
                comboBox2.Items.Add("Kimberley"); 
                comboBox2.Items.Add("Springbok");
                comboBox2.Items.Add("Richmond");
                comboBox2.Items.Add("Vanderkloof");
            }
            else if (comboBox1.SelectedItem.ToString() == "WESTERN CAPE")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Cape Town");
                comboBox2.Items.Add("George");
                comboBox2.Items.Add("Stellenbosch");
                comboBox2.Items.Add("Plettenberg Bay");
                comboBox2.Items.Add("Paarl");
            }
            else 
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Gqeberha");
                comboBox2.Items.Add("East London");
                comboBox2.Items.Add("Bisho");
                comboBox2.Items.Add("Port Alfred");
                comboBox2.Items.Add("Port Elizabeth");
            }
        
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) 
            {
                radioButton2.Checked = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                radioButton1.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            listBox1.Items.Add("Full Names: " + textBox1.Text);
            listBox1.Items.Add("CellNo: " + textBox2.Text);
            listBox1.Items.Add("Province: " + comboBox1.Text);
            listBox1.Items.Add("City: " + comboBox2.Text);
            if (radioButton1.Checked)
            {
                listBox1.Items.Add("Gender: Male");
            }
            else if (radioButton2.Checked)
            {
                listBox1.Items.Add("Gender: Female");
            }
            listBox1.Items.Add("Preferred Date: " + dateTimePicker1.Value);
            listBox1.Items.Add("Time: " + dateTimePicker2.Value);
            listBox1.Items.Add("Preffered Doctor: " + comboBox3.Text);
            listBox1.Items.Add("Symptoms: " + textBox3.Text);

        }

        private void button3_Click(object sender, EventArgs e)
        {
           Appointment appointment = new Appointment();
            appointment.ShowDialog();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == " " || textBox2.Text == " " || comboBox1.Text == " " || comboBox2.Text == " " ||
                     dateTimePicker1.Value.ToString() == " "||dateTimePicker2.Value.ToString() ==" " || comboBox3.Text == "")
            {
                MessageBox.Show("Please complete all fields before submitting.", "Missing Information", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show("Appointment booked successfully!",  "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBox1.Clear();
                textBox2.Clear();
                comboBox1.Text = "";
                comboBox2.Text = "";
                dateTimePicker1.Value = DateTime.Now;
                dateTimePicker2.Value = DateTime.Now;
                comboBox3.Text = "";
            }

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
