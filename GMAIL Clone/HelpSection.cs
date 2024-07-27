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
    public partial class HelpSection : Form
    {
        public HelpSection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            section1 s1 = new section1();
            s1.BringToFront();
            s1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            section2 s1 = new section2();
            s1.BringToFront();
            s1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            section3 s1 = new section3();
            s1.BringToFront();
            s1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            section4 s1 = new section4();
            s1.BringToFront();
            s1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            section5 s1 = new section5();
            s1.BringToFront();
            s1.Show();
        }
    }
}
