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
    public partial class AdminLog : Form
    {
        public AdminLog()
        {
            InitializeComponent();
            passwordTb.UseSystemPasswordChar = true;
        }


        private void AdminLog_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {

            string username = usernameTb.Text;
            string password = passwordTb.Text;



            // Check if the entered username and password are correct.
            if (username == "admin" && password == "adminpass")
            {
                // Successful login message with an Info icon.
                MessageBox.Show("You are now logged in as Admin.", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AdminMain adminmain = new AdminMain();
                this.Hide(); // Hide the current form
                adminmain.Show(); // Show the AdminMain form
            }
            else
            {
                // Login failed message with a Warning icon.
                MessageBox.Show("Incorrect username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked)
            {
                // If the checkbox is checked, show the password
                passwordTb.UseSystemPasswordChar = false;
            }
            else
            {
                // If the checkbox is unchecked, hide the password
                passwordTb.UseSystemPasswordChar = true;
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
    }
}
