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
    public partial class ChooseDoc : Form
    {
        public ChooseDoc()
        {
            InitializeComponent();
        }

        DocReq DocReq = new DocReq();
        Residency residency = new Residency();
        brgyClearance brgyClearance = new brgyClearance();
        Indigency indigency = new Indigency();

        private void toDRBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            this.Dispose();
            DocReq.ShowDialog();
        }

        private void toBRBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            this.Dispose();
            residency.ShowDialog();
        }

        private void toIndBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            this.Dispose();
            indigency.ShowDialog();
        }

        private void toBCBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            this.Dispose();
            brgyClearance.ShowDialog();
        }

        private void ChooseDoc_Load(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to go back?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the user clicks Yes, proceed to go back to the login page
            if (result == DialogResult.Yes)
            {
                ManagePage managepage = new ManagePage();
                this.Hide(); // Hide the current form
                managepage.Show();
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
    }
}
