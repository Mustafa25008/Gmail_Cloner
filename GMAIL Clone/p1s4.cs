using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace email_help_section
{
    public partial class p1s4 : Form
    {
        public p1s4()
        {
            InitializeComponent();
        }

        private void p1s4_Load(object sender, EventArgs e)
        {
            label10.Visible = false;
            label8.Visible = false;
            label7.Visible = false;
            label9.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label8.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label7.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label9.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label10.Visible = true;
        }
    }
}
