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
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
        }

        private void dOCTORBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dOCTORBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ist2ibDataSet);

        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ist2ibDataSet.DOCTOR' table. You can move, or remove it, as needed.
            this.dOCTORTableAdapter.Fill(this.ist2ibDataSet.DOCTOR);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == " " ||textBox3.Text == " " ||comboBox1.Text == " " || textBox2.Text == " " || textBox4.Text == " ")
            {
                MessageBox.Show("Please complete all fields before continuing.",
                     "Missing Information", MessageBoxButtons.OK,
                     MessageBoxIcon.Warning);
            }
            try
            {
                string maxId = "D001";
                foreach (DataRow row in ist2ibDataSet.DOCTOR.Rows)
                {
                    string id = row["DoctorID"].ToString();
                    if (string.Compare(id, maxId) > 0)
                        maxId = id;
                }

                int num = int.Parse(maxId.Substring(1)) + 1;
                string newId = "D" + num.ToString("D3");
                dOCTORTableAdapter.Insert(newId, textBox3.Text, comboBox1.Text, textBox2.Text, textBox4.Text);


               dOCTORTableAdapter.Fill(ist2ibDataSet.DOCTOR);
                MessageBox.Show("Doctor added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult Confirmation;
            Confirmation = MessageBox.Show("Are you sure you want to delete this information?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Confirmation == DialogResult.Yes)
            {
                string doctorID = ((DataRowView)dOCTORBindingSource.Current)["DoctorID"].ToString();
                dOCTORTableAdapter.DeleteQuery(doctorID);
                this.dOCTORTableAdapter.Fill(this.ist2ibDataSet.DOCTOR);
                MessageBox.Show("Doctor deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Delete operation cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Changes?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dOCTORBindingSource.EndEdit();
                dOCTORTableAdapter.Update(ist2ibDataSet);
            }
            else
            {
                dOCTORBindingSource.CancelEdit();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Login in order to view available appointments");
            Login form1 = new Login();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string searchValue = textBox5.Text;

            if (string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Please enter a value to search.");
            }
            try
            {
                this.dOCTORTableAdapter.FillBy(this.ist2ibDataSet.DOCTOR, searchValue);

                if (ist2ibDataSet.DOCTOR.Rows.Count == 0)
                {
                    MessageBox.Show("No record found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during search: " + ex.Message);
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

		private void textBox5_TextChanged(object sender, EventArgs e)
		{
            dOCTORTableAdapter.FillByName(ist2ibDataSet.DOCTOR, textBox5.Text);
		}
	}
}
