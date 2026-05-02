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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        string bookingInfo;
        public Form8(string info)
        {
            InitializeComponent();
            bookingInfo = info;
        }
        public void AddBooking(string bookingInfo)
        {
            listBox1.Items.Add(bookingInfo);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(120, 0, 0, 0);
        }
    }
}
