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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        private void pATIENTSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pATIENTSBindingSource.EndEdit();
            this.pATIENTSTableAdapter.Update(this.ist2ibDataSet.PATIENTS);

        }

        private void Patient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ist2ibDataSet.PATIENTS' table. You can move, or remove it, as needed.
            this.pATIENTSTableAdapter.Fill(this.ist2ibDataSet.PATIENTS);

        }

        private void patientIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult Confirmation;
            Confirmation = MessageBox.Show("Are you sure you want to delete this information?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Confirmation == DialogResult.Yes)
            {
                string PatientID = ((DataRowView)pATIENTSBindingSource.Current)["PatientID"].ToString();
                pATIENTSTableAdapter.DeleteQuery(PatientID);
                this.pATIENTSTableAdapter.Fill(this.ist2ibDataSet.PATIENTS);
                MessageBox.Show("Patient deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Delete operation cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(patientIDTextBox.Text == " " || nameTextBox.Text == " " || cellNoTextBox.Text == " " || emailTextBox.Text == " " || comboBox1.Text == " " || addressTextBox.Text== " ")
            {
                MessageBox.Show("Please complete all fields before continuing.",
                     "Missing Information", MessageBoxButtons.OK,
                     MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string maxId = "PRN100";
                    foreach (DataRow row in ist2ibDataSet.PATIENTS.Rows)
                    {
                        string id = row["PatientID"].ToString();
                        if (string.Compare(id, maxId) > 0)
                            maxId = id;
                    }

                    int num = int.Parse(maxId.Substring(3)) + 1;
                    string newId = "PRN" + num.ToString("D3");
                    pATIENTSTableAdapter.Insert(newId, nameTextBox.Text, cellNoTextBox.Text, emailTextBox.Text, comboBox1.Text, addressTextBox.Text);


                   pATIENTSTableAdapter.Fill(ist2ibDataSet.PATIENTS);
                    MessageBox.Show("Patient added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pATIENTSTableAdapter.UpdateQuery1(patientIDTextBox.Text, nameTextBox.Text, cellNoTextBox.Text, emailTextBox.Text, comboBox1.Text, addressTextBox.Text);
            MessageBox.Show("Department updated successfully!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Login in order to do Appointment");
            Login form1 = new Login();
        }

        private void button5_Click(object sender, EventArgs e)
        {
             this.Close();   
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
