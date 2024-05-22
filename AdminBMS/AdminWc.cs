namespace AdminBMS
{
    public partial class AdminWc : Form
    {
        public AdminWc()
        {
            InitializeComponent();
        }

        private void adminLog_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLog adminlog = new AdminLog();
            adminlog.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLog adminlog = new AdminLog();
            adminlog.Show();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}