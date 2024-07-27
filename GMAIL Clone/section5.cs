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
    public partial class section5 : Form
    {
        public section5()
        {
            InitializeComponent();
        }

        private void section5_Load(object sender, EventArgs e)
        {
            p1s5 ad = new p1s5();
            ad.TopLevel = false;
            panel1.Controls.Add(ad);
            ad.BringToFront();
            ad.Show();
        }
    }
}
