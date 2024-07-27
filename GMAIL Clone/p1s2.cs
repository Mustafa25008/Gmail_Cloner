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
    public partial class p1s2 : Form
    {
        public p1s2()
        {
            InitializeComponent();
        }

        private void p1s2_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
        }
    }
}
