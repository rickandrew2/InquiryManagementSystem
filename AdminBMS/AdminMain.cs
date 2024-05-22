using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminBMS
{
    public partial class AdminMain : Form
    {

        public AdminMain()
        {
            InitializeComponent();
        }

        private void toManageBtn_Click(object sender, EventArgs e)
        {
            ManagePage managePage = new ManagePage();
            this.Hide(); // Hide the current form
            managePage.Show();
        }

        private void AdminMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Dispose of the form properly to release its resources
            this.Dispose();
        }

        private void backBtn_Click(object sender, EventArgs e)
        { // Show a confirmation dialog
            DialogResult result = MessageBox.Show("Are you sure you want to go back to the login page?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the user clicks Yes, proceed to go back to the login page
            if (result == DialogResult.Yes)
            {
                AdminLog log = new AdminLog();
                this.Hide(); // Hide the current form
                log.Show();
            }
            // If the user clicks No, do nothing and return
            else if (result == DialogResult.No)
            {
                // Do nothing
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AdminMain_Load(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
