using Microsoft.VisualBasic.Logging;
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
    public partial class ManagePage : Form
    {
        PSR psr = new PSR();
        Complaints complaints = new Complaints();
        ChooseDoc chooseDoc = new ChooseDoc();
        AdminMain adminMain = new AdminMain();
        public ManagePage()
        {
            InitializeComponent();
        }

        private void manageDR_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            this.Dispose();
            chooseDoc.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            this.Dispose();
            psr.ShowDialog();
        }

        private void manageRC_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            this.Dispose();
            complaints.ShowDialog();
        }

        private void ManagePage_Load(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to go back to the Main Page?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the user clicks Yes, proceed to go back to the login page
            if (result == DialogResult.Yes)
            {
                AdminMain adminMain = new AdminMain();
                this.Hide(); // Hide the current form
                adminMain.Show();
            }
            // If the user clicks No, do nothing and return
            else if (result == DialogResult.No)
            {
                // Do nothing
            }
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
