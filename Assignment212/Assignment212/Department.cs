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
    public partial class Department : Form
    {
        public Department()
        {
            InitializeComponent();
        }

        private void dEPARTMENTSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dEPARTMENTSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ist2ibDataSet);

        }

        private void Department_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ist2ibDataSet.DEPARTMENTS' table. You can move, or remove it, as needed.
            this.dEPARTMENTSTableAdapter.Fill(this.ist2ibDataSet.DEPARTMENTS);

        }

        private void departmentNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string maxId = "DP01";
                foreach (DataRow row in ist2ibDataSet.DEPARTMENTS.Rows)
                {
                    string id = row["DepartmentID"].ToString();
                    if (string.Compare(id, maxId) > 0)
                        maxId = id;
                }

                int num = int.Parse(maxId.Substring(2)) + 1;
                string newId = "DP" + num.ToString("D2");
                dEPARTMENTSTableAdapter.Insert(newId,departmentNameTextBox.Text, departmentHeadTextBox.Text, doctorIDTextBox.Text);

               
                dEPARTMENTSTableAdapter.Fill(ist2ibDataSet.DEPARTMENTS);
               MessageBox.Show("Department inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult Confirmation;
            Confirmation = MessageBox.Show("Are you sure you want to delete this information?","Confirm",MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (Confirmation == DialogResult.Yes)
            {
                string deptId = ((DataRowView)dEPARTMENTSBindingSource.Current)["DepartmentID"].ToString();
                dEPARTMENTSTableAdapter.DeleteQuery(deptId);
                this.dEPARTMENTSTableAdapter.Fill(this.ist2ibDataSet.DEPARTMENTS);
                MessageBox.Show("Department deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Department operation cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dEPARTMENTSTableAdapter.UpdateQuery(departmentIDTextBox.Text, departmentNameTextBox.Text, departmentHeadTextBox.Text, doctorIDTextBox.Text);
            MessageBox.Show("Department updated successfully!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
