using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices.ActiveDirectory;

namespace GMAIL_Clone
{
    public partial class Compose : Form
    {
        string email, role, identity;
        string id, ee, foam, molty;
        string con = "Data Source=DESKTOP-3NT1LI6;Initial Catalog=Gmail;Integrated Security=True;Encrypt=False";

        public Compose(string e, string x, string q)
        {
            InitializeComponent();
            email = e;
            role = x;
            ee = q;
            identity = "Primary";

        }
        private void Compose_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(ee);
            fmemlb.Text = email;
            composepnl.Visible = false;
            Receivepnl.Visible = false;
            trashpnl.Visible = false;
            msgvpnl.Visible = false;
            starredpnl.Visible = false;

            if (role == "Sent eamil")
            {
                composepnl.Visible = true;
                composepnl.Dock = DockStyle.Fill;
            }

            else if (role == "Trash")
            {
                showtrash();
                trashpnl.Visible = true;
                trashpnl.Dock = DockStyle.Fill;
            }
            else if (role == "Star email")
            {
                showdata();
                starredpnl.Visible = true;
                starredpnl.Dock = DockStyle.Fill;
            }
            else
            {
                if (role == "Snooze email")
                {
                    button7.Text = "Unsnoze";
                }
                else
                {
                    button7.Text = "Snoozed";
                }
                dataGridView1.Visible = true;
                dataGridView1.Dock = DockStyle.Fill;
                showdata();
                Receivepnl.Visible = true;
                Receivepnl.Dock = DockStyle.Fill;
            }
        }

        void showdata()
        {
            string query = "", query1 = "";
            try
            {
                SqlConnection connection = new SqlConnection(con);
                connection.Open();
                //Primary
                if (role == "Receive email")
                {
                    query = "SELECT EmailID, FromEmail, Subject, Message, DateSent FROM EmailRecords WHERE ToEmail = @email AND Status = 'Sent' AND Identity1 = 'Primary';";
                    query1 = "SELECT EmailID, FromEmail, Subject, Message, DateSent FROM EmailRecords2 WHERE ToEmail = @email AND Status = 'Sent' AND Identity1 = 'Primary';";
                }
                //Snooze
                if (role == "Snooze email")
                {
                    query1 = "SELECT EmailID, FromEmail, Subject, Message, DateSent FROM EmailRecords2 WHERE ToEmail = @email AND Status = 'Snoozed';";

                    query = "SELECT EmailID, FromEmail, Subject, Message, DateSent FROM EmailRecords WHERE ToEmail = @email AND Status = 'Snoozed';";
                    mvtrh.Visible = false;
                    starbtn.Visible = false;
                }
                //All Sending Mail
                if (role == "SSS email")
                {
                    query1 = "SELECT EmailID, ToEmail, Subject, Message, DateSent FROM EmailRecords2 WHERE FromEmail = @email";// AND Status = 'Sent' AND Identity1 = 'Primary';
                    query = "SELECT EmailID, ToEmail, Subject, Message, DateSent FROM EmailRecords WHERE FromEmail = @email";// AND Status = 'Sent' AND Identity1 = 'Primary';
                    mvtrh.Visible = false;
                    starbtn.Visible = false;
                    button7.Visible = false;
                }
                //Spam
                if (role == "Spam email")
                {
                    query1 = "SELECT EmailID, FromEmail, Subject, Message, DateSent FROM EmailRecords2 WHERE ToEmail = @email AND Status = 'Sent' AND Identity1 = 'Spam';";

                    query = "SELECT EmailID, FromEmail, Subject, Message, DateSent FROM EmailRecords WHERE ToEmail = @email AND Status = 'Sent' AND Identity1 = 'Spam';";
                }
                //Promo
                if (role == "Promo email")
                {
                    query1 = "SELECT EmailID, FromEmail, Subject, Message, DateSent FROM EmailRecords2 WHERE ToEmail = @email AND Status = 'Sent' AND Identity1 = 'Promotion';";

                    query = "SELECT EmailID, FromEmail, Subject, Message, DateSent FROM EmailRecords WHERE ToEmail = @email AND Status = 'Sent' AND Identity1 = 'Promotion';";
                }
                //Social
                if (role == "Social email")
                {
                    query1 = "SELECT EmailID, FromEmail, Subject, Message, DateSent FROM EmailRecords2 WHERE ToEmail = @email AND Status = 'Sent' AND Identity1 = 'Social';";

                    query = "SELECT EmailID, FromEmail, Subject, Message, DateSent FROM EmailRecords WHERE ToEmail = @email AND Status = 'Sent' AND Identity1 = 'Social';";
                }
                //Important
                if (role == "Imp email")
                {
                    query = "SELECT EmailID, FromEmail, Subject, Message, DateSent FROM EmailRecords WHERE ToEmail = @email AND Status = 'Sent' AND Identity1 = 'Important';";
                    query1 = "SELECT EmailID, FromEmail, Subject, Message, DateSent FROM EmailRecords2 WHERE ToEmail = @email AND Status = 'Sent' AND Identity1 = 'Important';";
                }
                //All mail
                if (role == "all email")
                {// AND Status = 'Sent
                    query = "SELECT EmailID, FromEmail, Subject, Message, DateSent,Identity1 FROM EmailRecords WHERE ToEmail = @email and Status  != 'Deleted';";
                    query1 = "SELECT EmailID, FromEmail, Subject, Message, DateSent,Identity1 FROM EmailRecords2 WHERE ToEmail = @email and Status  != 'Deleted';";
                }
                //Star
                if (role == "Star email")
                {
                    query = "SELECT EmailID, FromEmail, Subject, Message, DateSent FROM EmailRecords WHERE ToEmail = @email AND Status = 'Starred';";
                    query1 = "SELECT EmailID, FromEmail, Subject, Message, DateSent FROM EmailRecords2 WHERE ToEmail = @email AND Status = 'Starred';";

                }
                DataTable table = new DataTable();
                DataTable dataTable1 = new DataTable();
                DataTable dataTable2 = new DataTable();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@email", email);
                var reader = command.ExecuteReader();
                dataTable1.Load(reader);
                reader.Close();
                //Checking WWW

                SqlCommand command2 = new SqlCommand(query1, connection);
                command2.Parameters.AddWithValue("@email", email);
                var reader1 = command2.ExecuteReader();
                dataTable2.Load(reader1);
                reader1.Close();

                table.Merge(dataTable1, false, MissingSchemaAction.Add);
                table.Merge(dataTable2, false, MissingSchemaAction.Add);

                //Checking WWW


                //DataTable table = new DataTable();
                //table.Load(reader);

                if (role == "Star email")
                {
                    stargrid.DataSource = dataTable1;
                    stargrid1.DataSource = dataTable2;
                }
                else
                {
                    dataGridView1.DataSource = dataTable1;
                    dataGridView3.DataSource = dataTable2;
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }


        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        // Clear all data
        void clrdata()
        {
            totxt.Clear(); subtxt.Clear(); msgtxt.Clear();
        }
        private void sendbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(totxt.Text) || string.IsNullOrEmpty(subtxt.Text) || string.IsNullOrEmpty(msgtxt.Text))
            {
                MessageBox.Show("Please Enter all information");
                return;
            }
            try
            {
                SqlConnection connection = new SqlConnection(con);
                connection.Open();
                SqlCommand command = new SqlCommand("Select count(*) from Users Where username = @email;", connection);
                command.Parameters.AddWithValue("@email", totxt.Text);
                int count = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();
                if (count < 1)
                {
                    connection.Open();
                    SqlCommand command1 = new SqlCommand("Select count(*) from CompanyEmails Where ContactEmail = @email;", connection);
                    command1.Parameters.AddWithValue("@email", totxt.Text);
                    int count1 = Convert.ToInt32(command1.ExecuteScalar());
                    connection.Close();
                    if (count1 < 1)
                    {
                        MessageBox.Show("Invalid Email or User not exist");
                        return;
                    }
                }
                //ckecking Identity
                string[] promotions_words = { "sale", "discount", "deal", "offer", "promotion",
                                  "newsletter", "subscription", "exclusive", "VIP",
                                  "Black Friday", "Cyber Monday", "Christmas sale",
                                  "Summer sale" };

                string[] social_words = new string[]
                {
                    "Invite", "Friend Request", "Connection Request","invite", "friend request", "connection request",
                    "Invited", "invited", "Request", "request", "friend","Friend","Friend","friends"
                };

                string[] promotionsMails = new string[]
                {
                    "google", "microsoft", "apple",
                    "netflix", "spotify", "uber", "airbnb", "salesforce", "adobe",
                    "slack", "zoom", "dropbox", "shopify",
                    "paypal", "oracle", "ibm", "tesla", "samsung"
                };

                string[] socialMails = new string[]
                {
                    "facebook", "twitter", "linkedIn"
                };
                string[] spam_words = new string[]{
                    "lottery", "prize", "free", "urgent", "claim", "winner", "casino","Prize","Jackpot",
                    "loan", "earn money fast", "jackpot", "cash prize", "prize", "bonus","Bonus", "reward", "Reward",
                    "act now", "weight loss", "eliminate debt", "miracle cure", "insurance", "free gift"
                };

                string[] impMails = new string[]
                {
                    "project", "deadline", "meeting", "report", "client", "invoice", "bank","invoice", "receipt", "payment", "account", "appointment", "legal", "passport", "license",
                    "Project", "Deadline", "Meeting", "Report", "Client", "Invoice", "Bank","Invoice", "Receipt", "Payment", "Account", "Appointment", "Legal", "Passport", "License"
                };

                //checking Important
                bool imp = false;
                foreach (string word in impMails)
                {
                    if (msgtxt.Text.Contains(word))
                    {
                        imp = true;
                        break;
                    }
                }
                //checking promotions
                bool promo = false;
                foreach (var word in promotionsMails)
                {
                    if (fmemlb.Text.Contains(word))
                    {
                        promo = true;
                        break;
                    }
                }
                if (promo == false)
                {
                    //Checking social words in text
                    foreach (string word in promotions_words)
                    {
                        if (msgtxt.Text.Contains(word))
                        {
                            promo = true;
                            break;
                        }
                    }
                }

                //checking social
                bool social = false;
                foreach (var word in socialMails)
                {
                    if (fmemlb.Text.Contains(word))
                    {
                        social = true;
                        break;
                    }
                }
                if (social == false)
                {
                    //Checking social words in text
                    foreach (string word in social_words)
                    {
                        if (msgtxt.Text.Contains(word))
                        {
                            social = true;
                            break;
                        }
                    }
                }

                bool spamm = false;
                //Checking spam words in text
                foreach (string word in spam_words)
                {
                    if (msgtxt.Text.Contains(word))
                    {
                        spamm = true;
                        break;
                    }
                }


                //idetifying
                if (promo)
                {
                    //MessageBox.Show("Promotion");
                    identity = "Promotion";
                }
                else if (social)
                {
                    //MessageBox.Show("Social");
                    identity = "Social";
                }
                else if (spamm)
                {
                    //MessageBox.Show("Spam");
                    identity = "Spam";
                }
                else if (imp)
                {
                    //MessageBox.Show("Spam");
                    identity = "Important";
                }
                else
                {
                    //MessageBox.Show("Primary");
                    identity = "Primary";
                }

                connection.Open();
                string tableName = (ee == "user") ? "EmailRecords" : "EmailRecords2";
                SqlCommand sqlCommand = new SqlCommand($"INSERT INTO {tableName} (FromEmail, ToEmail, Subject, Message, DateSent, Status, Identity1) VALUES (@FromEmail, @ToEmail, @Subject, @Msg, @Date, 'Sent', @Identity);", connection);
                sqlCommand.Parameters.AddWithValue("@FromEmail", fmemlb.Text);
                sqlCommand.Parameters.AddWithValue("@ToEmail", totxt.Text);
                sqlCommand.Parameters.AddWithValue("@Subject", subtxt.Text);
                sqlCommand.Parameters.AddWithValue("@Msg", msgtxt.Text);
                sqlCommand.Parameters.AddWithValue("@Date", DateTime.Now);
                sqlCommand.Parameters.AddWithValue("@Identity", identity);
                sqlCommand.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Email sent");
                clrdata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error occurs!" + ex.Message);
                return;
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            clrdata();
            this.Hide();
            Form17 home = new Form17(fmemlb.Text, ee);
            home.ShowDialog();
        }

        private void msgtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (role == "SSS email")
            {
                mvtrh.Visible = true;
                starbtn.Visible = true;
            }
            if (role == "Snooze email")
            {

                button7.Visible = true;
            }
            this.Hide();
            Form17 home = new Form17(fmemlb.Text, ee);
            home.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            mggtxt.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            foam = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            molty = "user";
        }

        private void mvtrh_Click(object sender, EventArgs e)
        {
            //string i = Convert.ToString(id);
            if (String.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please Select a Message");
                return;
            }
            try
            {
                string query = "";
                if (molty == "user")
                {
                    query = "Update EmailRecords set Status = 'Trash' where EmailID = @id;";
                }
                if (molty == "comp")
                {
                    query = "Update EmailRecords2 set Status = 'Trash' where EmailID = @id;";
                }
                SqlConnection connection = new SqlConnection(con);
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                string check = Convert.ToString(command.ExecuteNonQuery());
                connection.Close();
                if (check == "1")
                {
                    MessageBox.Show("Message moved to trash");
                }
                else
                {
                    MessageBox.Show("Failed to moved the Message to trash");
                }
                id = "";

                showdata();


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurs " + ex.Message);
            }
        }
        void showtrash()
        {
            try
            {
                SqlConnection connection = new SqlConnection(con);
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT EmailID, FromEmail, Subject, Message, DateSent FROM EmailRecords WHERE ToEmail = @email AND Status = 'Trash';", connection);
                command.Parameters.AddWithValue("@email", email);
                var reader = command.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(reader);
                dataGridView2.DataSource = table;
                reader.Close();

                SqlCommand command1 = new SqlCommand("SELECT EmailID, FromEmail, Subject, Message, DateSent FROM EmailRecords2 WHERE ToEmail = @email AND Status = 'Trash';", connection);
                command1.Parameters.AddWithValue("@email", email);
                var reader1 = command1.ExecuteReader();

                DataTable table1 = new DataTable();
                table1.Load(reader1);
                dataGridView4.DataSource = table1;
                reader1.Close();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form17 home = new Form17(fmemlb.Text, ee);
            home.ShowDialog();
        }

        private void refrbtn_Click(object sender, EventArgs e)
        {
            showtrash();
            MessageBox.Show("Data Refresh successfully");
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            molty = "user";
        }

        private void rstbtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please Select a Message");
                return;
            }
            try
            {
                string query = "";
                if (molty == "user")
                {
                    query = "Update EmailRecords set Status = 'Sent' where EmailID = @id;";
                }
                if (molty == "comp")
                {
                    query = "Update EmailRecords2 set Status = 'Sent' where EmailID = @id;";
                }
                SqlConnection connection = new SqlConnection(con);
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                string check = Convert.ToString(command.ExecuteNonQuery());
                connection.Close();
                if (check == "1")
                {
                    MessageBox.Show("Message Restore moved to Primary");
                }
                else
                {
                    MessageBox.Show("Failed to Restore the Message");
                }
                id = "";
                showtrash();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurs " + ex.Message);
            }
        }

        private void dlbtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please Select a Message");
                return;
            }
            try
            {
                string query = "";
                if (molty == "user")
                {
                    query = "Update EmailRecords set Status = 'Deleted' where EmailID = @id;";
                }
                if (molty == "comp")
                {
                    query = "Update EmailRecords2 set Status = 'Deleted' where EmailID = @id;";
                }
                SqlConnection connection = new SqlConnection(con);
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                string check = Convert.ToString(command.ExecuteNonQuery());
                connection.Close();
                if (check == "1")
                {
                    MessageBox.Show("Message Deleted");
                }
                else
                {
                    MessageBox.Show("Failed to Delete the Message");
                }
                id = "";
                showtrash();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurs " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //View Message
            if (String.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please Select a Message");
                return;
            }
            Receivepnl.Visible = false;
            msgvpnl.Visible = true;
            msgvpnl.Dock = DockStyle.Fill;

        }

        private void cncbtn_Click(object sender, EventArgs e)
        {
            msgvpnl.Visible = false;

            if (role == "Star email")
            {
                starredpnl.Visible = true;
                starredpnl.Dock = DockStyle.Fill;
            }
            /*if (role == "Receive email")*/
            else
            {
                Receivepnl.Visible = true;
                Receivepnl.Dock = DockStyle.Fill;
            }

            mggtxt.Clear();
            id = "";
        }

        private void Receivepnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void starbtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please Select a Message");
                return;
            }
            try
            {
                string query = "";
                if (molty == "user")
                {
                    query = "Update EmailRecords set Status = 'Starred' where EmailID = @id;";
                }
                if (molty == "comp")
                {
                    query = "Update EmailRecords2 set Status = 'Starred' where EmailID = @id;";
                }
                SqlConnection connection = new SqlConnection(con);
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                string check = Convert.ToString(command.ExecuteNonQuery());
                connection.Close();
                if (check == "1")
                {
                    MessageBox.Show("Message has been Starred");
                }
                else
                {
                    MessageBox.Show("Failed to starred Message");
                }
                id = "";
                showdata();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurs " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form17 home = new Form17(fmemlb.Text, ee);
            home.ShowDialog();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void stargrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = stargrid.SelectedRows[0].Cells[0].Value.ToString();
            mggtxt.Text = stargrid.SelectedRows[0].Cells[3].Value.ToString();
            molty = "user";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            //View Message
            if (String.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please Select a Message");
                return;
            }
            starredpnl.Visible = false;
            msgvpnl.Visible = true;
            msgvpnl.Dock = DockStyle.Fill;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please Select a Message");
                return;
            }
            try
            {
                string query = "";
                if (molty == "user")
                {
                    query = "Update EmailRecords set Status = 'Sent' where EmailID = @id;";
                }
                if (molty == "comp")
                {
                    query = "Update EmailRecords2 set Status = 'Sent' where EmailID = @id;";
                }
                SqlConnection connection = new SqlConnection(con);
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                string check = Convert.ToString(command.ExecuteNonQuery());
                connection.Close();
                if (check == "1")
                {
                    MessageBox.Show("Message Unstarred");
                }
                else
                {
                    MessageBox.Show("Failed to Unstar the Message");
                }
                id = "";
                showdata();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurs " + ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please Select a Message");
                return;
            }
            try
            {
                string query = "";
                if (button7.Text == "Snoozed")
                {
                    if (molty == "user")
                    {
                        query = "Update EmailRecords set Status = 'Snoozed' where EmailID = @id and FromEmail = @foam;";
                    }
                    if (molty == "comp")
                    {
                        query = "Update EmailRecords2 set Status = 'Snoozed' where EmailID = @id and FromEmail = @foam;";
                    }
                }
                else
                {
                    if (molty == "user")
                    {
                        query = "Update EmailRecords set Status = 'Sent' where EmailID = @id  and FromEmail = @foam;";
                    }
                    if (molty == "comp")
                    {
                        query = "Update EmailRecords2 set Status = 'Sent' where EmailID = @id  and FromEmail = @foam;";
                    }
                }
                SqlConnection connection = new SqlConnection(con);
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@foam", foam);
                string check = Convert.ToString(command.ExecuteNonQuery());
                connection.Close();
                if (check == "1")
                {
                    MessageBox.Show("Done");
                }
                else
                {
                    MessageBox.Show("Failed");
                }
                id = "";
                showdata();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurs " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();
            mggtxt.Text = dataGridView3.SelectedRows[0].Cells[3].Value.ToString();
            foam = dataGridView3.SelectedRows[0].Cells[1].Value.ToString();
            molty = "comp";
        }

        private void Receivepnl_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void stargrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = stargrid1.SelectedRows[0].Cells[0].Value.ToString();
            mggtxt.Text = stargrid1.SelectedRows[0].Cells[3].Value.ToString();
            foam = stargrid1.SelectedRows[0].Cells[1].Value.ToString();
            molty = "comp";
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView4.SelectedRows[0].Cells[0].Value.ToString();
            mggtxt.Text = dataGridView4.SelectedRows[0].Cells[3].Value.ToString();
            foam = dataGridView4.SelectedRows[0].Cells[1].Value.ToString();
            molty = "comp";
        }
    }
}
