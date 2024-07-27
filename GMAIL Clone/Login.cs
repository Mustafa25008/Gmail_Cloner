using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace GMAIL_Clone
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        string con = "Data Source=DESKTOP-3NT1LI6;Initial Catalog=Gmail;Integrated Security=True;Encrypt=False";

        

        private void regbtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Please Enter Email or Password");
                return;
            }
            if (!textBox4.Text.EndsWith("@gmail.com"))
            {
                //Company Email Checking
                SqlConnection connection = new SqlConnection(con);
                connection.Open();
                SqlCommand command = new SqlCommand("Select count(*) from CompanyEmails Where ContactEmail = @email;", connection);
                command.Parameters.AddWithValue("@email", textBox4.Text);
                int count1 = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();
                if (count1 == 1)
                {
                    MessageBox.Show("Company mail already Exist");
                    return;
                }
                else
                {
                    MessageBox.Show("Please Enter Valid Email");
                    return;
                }
            }
            try
            {
                SqlConnection connection = new SqlConnection(con);
                connection.Open();
                SqlCommand command = new SqlCommand("Select count(*) from Users Where username = @email;", connection);
                command.Parameters.AddWithValue("@email", textBox4.Text);
                int count = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();
                if (count == 1)
                {
                    MessageBox.Show("User Already Exist");
                    
                }
                else
                {
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand("Insert Into Users Values(@email1, @passw);",connection);
                    sqlCommand.Parameters.AddWithValue("@email1",textBox4.Text);
                    sqlCommand.Parameters.AddWithValue("@passw", textBox3.Text);
                    sqlCommand.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("User Registered");
                    textBox4.Clear();
                    textBox3.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurs! " + ex.Message);
                return;
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            Loginpnl.Visible = false;
            registerpnl.Visible = false;
        }

        private void lgbtn_Click(object sender, EventArgs e)
        {
            Loginpnl.Visible = true;
            Loginpnl.Dock = DockStyle.Fill;
        }

        private void rgbtn_Click(object sender, EventArgs e)
        {
            registerpnl.Visible = true;
            registerpnl.Dock = DockStyle.Fill;
        }

        private void Bkbtn1_Click(object sender, EventArgs e)
        {
            Loginpnl.Visible = false;
            registerpnl.Visible = false;
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please Enter Email or Password");
                return;
            }
            try
            {
                string ee="user";
                SqlConnection connection = new SqlConnection(con);
                connection.Open();
                SqlCommand command = new SqlCommand("Select count(*) from Users Where username = @email and password = @pass;", connection);
                command.Parameters.AddWithValue("@email", textBox1.Text);
                command.Parameters.AddWithValue("@pass", textBox2.Text);
                int count = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();
                if(count == 1)
                {
                    MessageBox.Show("Login sucessfull");
                    ee = "user";
                    this.Hide();
                    Form17 home = new Form17(textBox1.Text, ee);
                    home.ShowDialog();
                }
                else
                {
                    //Company Email
                    connection.Open();
                    SqlCommand command1 = new SqlCommand("Select count(*) from CompanyEmails Where ContactEmail = @email and Password = @pass;", connection);
                    command1.Parameters.AddWithValue("@email", textBox1.Text);
                    command1.Parameters.AddWithValue("@pass", textBox2.Text);
                    int count1 = Convert.ToInt32(command1.ExecuteScalar());
                    connection.Close();
                    if (count1 == 1)
                    {
                        MessageBox.Show("Login sucessfull");
                        ee = "comp";
                        this.Hide();
                        Form17 home = new Form17(textBox1.Text, ee);
                        home.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Email or password");
                    }
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurs! " + ex.Message);
                return;
            }

        }

        private void bkbtn2_Click(object sender, EventArgs e)
        {
            Loginpnl.Visible = false;
            registerpnl.Visible = false;
            textBox1.Clear(); textBox2.Clear();
        }
    }
}
