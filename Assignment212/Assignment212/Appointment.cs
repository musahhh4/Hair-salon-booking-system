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
    public partial class Appointment : Form
    {
        public string FullName { get; }
        public string CellNo { get; }
        public string Doctor { get; }
        public DateTime PrefDate { get; }
        public DateTime PrefTime { get; }
        public string Symptoms { get; }
        public string Gender { get; }

        public Appointment()
        {
            InitializeComponent();
        }

        public Appointment(string fullName, string cellNo, string doctor, DateTime prefDate, DateTime prefTime, string symptoms, string gender)
        {
            FullName = fullName;
            CellNo = cellNo;
            Doctor = doctor;
            PrefDate = prefDate;
            PrefTime = prefTime;
            Symptoms = symptoms;
            Gender = gender;
        }

        private void aPPOINTMENTSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aPPOINTMENTSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ist2ibDataSet);

        }

        private void Appointment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ist2ibDataSet.APPOINTMENTS' table. You can move, or remove it, as needed.
            this.aPPOINTMENTSTableAdapter.Fill(this.ist2ibDataSet.APPOINTMENTS);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (appointmentIDTextBox.Text == " " || patientIDTextBox.Text == " " || doctorIDTextBox.Text == " " || appointmentDateDateTimePicker.Text == " " || appointmentTimeTextBox.Text == " "||statusTextBox.Text ==" ")
            {
                MessageBox.Show("Please complete all fields before continuing.",
                     "Missing Information", MessageBoxButtons.OK,
                     MessageBoxIcon.Warning);
            }
            else
            {
                aPPOINTMENTSBindingSource.MoveLast();
                int CurrentDoctorID = int.Parse(appointmentIDTextBox.Text);
                aPPOINTMENTSBindingSource.AddNew();
                appointmentIDTextBox.Text = (CurrentDoctorID + 1).ToString();
                MessageBox.Show("Appointment added successfully!",
                        "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult Confirmation;
            Confirmation = MessageBox.Show("Are you sure you want to delete this information?", "Confirm", MessageBoxButtons.YesNo);
            if (Confirmation == DialogResult.Yes)
                aPPOINTMENTSBindingSource.RemoveCurrent();

            MessageBox.Show("Appointment deleted successfully!",
                            "Success", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Changes?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                aPPOINTMENTSBindingSource.EndEdit();
                aPPOINTMENTSTableAdapter.Update(ist2ibDataSet);
            }
            else
            {
              aPPOINTMENTSBindingSource.CancelEdit();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            BackColor = Color.BlueViolet;
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            BackColor = Color.AliceBlue;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Booking_form booking_Form = new Booking_form();
            booking_Form.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
