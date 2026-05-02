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
    public partial class Form7 : Form
    {
        public Form5 Form5Instance;

        public Form7()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8();
           
            foreach (var item in Form5Instance.listBox1.Items)
            {
                frm8.listBox1.Items.Add(item);
            }

            frm8.Show();
        }
    }
}
