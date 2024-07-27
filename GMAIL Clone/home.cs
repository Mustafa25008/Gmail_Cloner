using email_help_section;
using Gmail;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace GMAIL_Clone
{
    public partial class Form17 : Form
    {
        string useremail, ee;
        string con = "Data Source=DESKTOP-3NT1LI6;Initial Catalog=Gmail;Integrated Security=True;Encrypt=False";

        public Form17(string email, string e)
        {
            InitializeComponent();
            useremail = email;
            ee = e;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            /*Form11 primary = new Form11();
            primary.ShowDialog();*/
            string x = "Receive email";
            this.Hide();
            Compose compose = new Compose(useremail, x,ee);
            compose.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Star wala
            string x = "Star email";
            this.Hide();
            Compose compose = new Compose(useremail, x, ee);
            compose.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string x = "SSS email";
            this.Hide();
            Compose compose = new Compose(useremail, x, ee);
            compose.ShowDialog();
        }


        private void button14_Click(object sender, EventArgs e)
        {
            /*Form10 trash = new Form10();
            trash.ShowDialog();*/
            string x = "Trash";
            this.Hide();
            Compose compose = new Compose(useremail, x, ee);
            compose.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //Compose Email
            string x = "Sent eamil";
            this.Hide();
            Compose compose = new Compose(useremail, x, ee);
            compose.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string x = "Social email";
            this.Hide();
            Compose compose = new Compose(useremail, x, ee);
            compose.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string x = "Snooze email";
            this.Hide();
            Compose compose = new Compose(useremail, x, ee);
            compose.ShowDialog();
        }


        private void button12_Click(object sender, EventArgs e)
        {
            string x = "all email";
            this.Hide();
            Compose compose = new Compose(useremail, x, ee);
            compose.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string x = "Promo email";
            this.Hide();
            Compose compose = new Compose(useremail, x, ee);
            compose.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string x = "Imp email";
            this.Hide();
            Compose compose = new Compose(useremail, x, ee);
            compose.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string x = "Spam email";
            this.Hide();
            Compose compose = new Compose(useremail, x, ee);
            compose.ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            HelpSection help = new HelpSection();
            help.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            setting_dasboard settings = new setting_dasboard();
            settings.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void logotbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
        System.Windows.Forms.Timer Timer;
        int counter = 60;

        private void unsnozzemsg()
        {
            try
            {
                string query = "Update EmailRecords set Status = 'Sent' where ToEmail = @email AND Status = 'Snoozed';";
                string query1 = "Update EmailRecords2 set Status = 'Sent' where ToEmail = @email AND Status = 'Snoozed';";

                SqlConnection connection = new SqlConnection(con);
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@email", useremail);
                string check = Convert.ToString(command.ExecuteNonQuery());
                connection.Close();
                connection.Open();
                SqlCommand command1 = new SqlCommand(query1, connection);
                command1.Parameters.AddWithValue("@email", useremail);
                string check1 = Convert.ToString(command1.ExecuteNonQuery());
                connection.Close();
                if (check == "1" && check1 == "1")
                {
                    //MessageBox.Show("Messages have been Unsnoozed");
                }
                else
                {
                    //MessageBox.Show("Failed");
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show("An error occurs " + ex.Message);
            }
        }
        private void Form17_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(ee);
            timeee.Visible = false;
            starttm();
            //MessageBox.Show(Convert.ToString(counter));
        }
        
        private void timer_tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
            {
                Timer.Stop();
                unsnozzemsg();
                //this.Close();
            }
            timeee.Text = counter.ToString();
        }
        private void starttm()
        {
            Timer = new System.Windows.Forms.Timer();
            Timer.Interval = 1000;
            Timer.Tick += new EventHandler(timer_tick);
            Timer.Start();
            timeee.Text = counter.ToString();
        }
    }
}
