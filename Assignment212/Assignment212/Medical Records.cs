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
    public partial class Medical_Records : Form
    {
        public Medical_Records()
        {
            InitializeComponent();
        }

        private void mEDICAL_RECORDSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mEDICAL_RECORDSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ist2ibDataSet);

        }

        private void mEDICAL_RECORDSBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.mEDICAL_RECORDSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ist2ibDataSet);

        }

        private void Medical_Records_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ist2ibDataSet.MEDICAL_RECORDS' table. You can move, or remove it, as needed.
            this.mEDICAL_RECORDSTableAdapter.Fill(this.ist2ibDataSet.MEDICAL_RECORDS);

        }

        private void recordIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (recordIDTextBox.Text == " " || patientIDTextBox.Text == " " || doctorIDTextBox.Text == " " || dateRecordDateTimePicker.Text == " ")
            {
                MessageBox.Show("Please complete all fields before continuing.",
                     "Missing Information", MessageBoxButtons.OK,
                     MessageBoxIcon.Warning);
            }
            try
            {
                string maxId = "R001";
                foreach (DataRow row in ist2ibDataSet.MEDICAL_RECORDS.Rows)
                {
                    string id = row["DoctorID"].ToString();
                    if (string.Compare(id, maxId) > 0)
                        maxId = id;
                }

                int num = int.Parse(maxId.Substring(1)) + 1;
                string newId = "R" + num.ToString("D3");
                mEDICAL_RECORDSTableAdapter.Insert(newId, patientIDTextBox.Text, doctorIDTextBox.Text, dateRecordDateTimePicker.Value);


                mEDICAL_RECORDSTableAdapter.Fill(ist2ibDataSet.MEDICAL_RECORDS);
                MessageBox.Show("Medical recorded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult Confirmation;
            Confirmation = MessageBox.Show("Are you sure you want to delete this information?", "Confirm", MessageBoxButtons.YesNo);
            if (Confirmation == DialogResult.Yes)
                mEDICAL_RECORDSBindingSource.RemoveCurrent();

            MessageBox.Show("Medical record deleted successfully!",
                            "Success", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Changes?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
               mEDICAL_RECORDSTableAdapter.UpdateQuery(recordIDTextBox.Text ,patientIDTextBox.Text, doctorIDTextBox.Text, dateRecordDateTimePicker.Value.ToString("yyyy-MM-dd"));
            MessageBox.Show("Department updated successfully!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
