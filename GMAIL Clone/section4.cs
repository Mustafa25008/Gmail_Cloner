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
    public partial class section4 : Form
    {
        public section4()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            p1s4 ad = new p1s4();
            ad.TopLevel = false;
            panel1.Controls.Add(ad);
            ad.BringToFront();
            ad.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
