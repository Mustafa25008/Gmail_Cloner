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
    public partial class section3 : Form
    {
        public section3()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = comboBox1.SelectedItem.ToString();

            if (value == "Computer")
            {
                p2s2 ad = new p2s2();
                ad.TopLevel = false;
                panel1.Controls.Add(ad);
                ad.BringToFront();
                ad.Show();

            }
            else
            {
                p1s2 ad = new p1s2();
                ad.TopLevel = false;
                panel1.Controls.Add(ad);
                ad.BringToFront();
                ad.Show();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
