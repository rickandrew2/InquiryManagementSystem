using MySql.Data.MySqlClient;
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
    public partial class PSR : Form
    {
        public PSR()
        {
            InitializeComponent();
        }

        private void PSR_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            var database = new Database();
            if (database.connect_db())
            {
                string query = "SELECT * FROM psr";
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = database.mySqlConnection;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = mySqlCommand;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;

                dataGridViewMyAllData.DataSource = bindingSource;

                database.close_db();
            }
        }

        private void ClearData()
        {
            psridTb.Text = "";
            fnTb.Text = "";
            addressTb.Text = "";
            contactTb.Text = "";
            dobTb.Text = "";
            norTb.Text = "";
            ssnTb.Text = "";

        }

        private void dataGridViewMyAllData_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            psridTb.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[0].Value?.ToString() ?? "";
            fnTb.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[1].Value?.ToString() ?? "";
            addressTb.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[2].Value?.ToString() ?? "";
            contactTb.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[3].Value?.ToString() ?? "";
            dobTb.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[4].Value?.ToString() ?? "";
            norTb.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[5].Value?.ToString() ?? "";
            ssnTb.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[6].Value?.ToString() ?? "";
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewMyAllData.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string psrID = dataGridViewMyAllData.SelectedRows[0].Cells["psrid"].Value.ToString();

                    using (MySqlConnection connection = new MySqlConnection(Database.connection_string))
                    {
                        using (MySqlCommand cmd = new MySqlCommand("DELETE FROM psr WHERE psrid = @psrid", connection))
                        {
                            cmd.Parameters.AddWithValue("@psrid", psrID);
                            connection.Open();
                            cmd.ExecuteNonQuery();
                            connection.Close();

                            MessageBox.Show("Record Successfully Deleted", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadData(); // Assuming you have a method to refresh or load data
                            ClearData();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Select a row to delete", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewMyAllData.SelectedRows.Count > 0)
            {
                try
                {
                    string psrID = dataGridViewMyAllData.SelectedRows[0].Cells["psrid"].Value.ToString();

                    using (MySqlConnection connection = new MySqlConnection(Database.connection_string))
                    {
                        using (MySqlCommand cmd = new MySqlCommand("UPDATE psr SET fullname=@name, address=@address, contactInfo=@contactinfo, " +
                            "dob=@dob, natureOfRequest=@nor, specificServiceNeed=@ssn WHERE psrid=@psrid", connection))
                        {
                            cmd.Parameters.AddWithValue("@psrid", psrID);
                            cmd.Parameters.AddWithValue("@name", fnTb.Text);
                            cmd.Parameters.AddWithValue("@address", addressTb.Text);
                            cmd.Parameters.AddWithValue("@contactinfo", contactTb.Text);
                            cmd.Parameters.AddWithValue("@dob", dobTb.Text);
                            cmd.Parameters.AddWithValue("@nor", norTb.Text);
                            cmd.Parameters.AddWithValue("@ssn", ssnTb.Text);

                            connection.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();
                            connection.Close();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Record Successfully Updated", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loadData();
                                ClearData();
                            }
                            else
                            {
                                MessageBox.Show("No record updated. Please make sure the selected record exists.", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating the record: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Select a row to UPDATE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to go back?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the user clicks Yes, proceed to go back to the manage page
            if (result == DialogResult.Yes)
            {
                ManagePage manage = new ManagePage();
                this.Hide(); // Hide the current form
                manage.Show();
            }
            // If the user clicks No, do nothing and return
            else if (result == DialogResult.No)
            {
                // Do nothing
            }
        }

        private void ssnTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to go back?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the user clicks Yes, proceed to go back to the manage page
            if (result == DialogResult.Yes)
            {
                ManagePage manage = new ManagePage();
                this.Hide(); // Hide the current form
                manage.Show();
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
