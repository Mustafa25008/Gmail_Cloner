namespace Gmail
{
    public partial class setting_dasboard : Form
    {
        public setting_dasboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 notif = new Form5();
            notif.ShowDialog();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1 defaultReply = new Form1();
            defaultReply.ShowDialog();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            ReplyFollow replyFollow = new ReplyFollow();
            replyFollow.ShowDialog();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form10 manageLabels = new Form10();
            manageLabels.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 manage = new Form3();
            manage.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 inboxType = new Form4();
            inboxType.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 inboxCategories = new Form2();
            inboxCategories.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 inboxNotifications = new Form6();
            inboxNotifications.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form9 notifSound = new Form9();
            notifSound.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form8 manageNotif = new Form8();
            manageNotif.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Signature sig = new Signature();
            sig.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            OutOfficeReply outOfficeReply = new OutOfficeReply();
            outOfficeReply.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            InboxTips tips = new InboxTips();
            tips.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DaysSync sync = new DaysSync();
            sync.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            images_button images = new images_button();
            images.ShowDialog();
        }
    }
}
