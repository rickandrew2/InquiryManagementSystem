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
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AdminBMS
{
    public partial class Complaints : Form
    {
        public Complaints()
        {
            InitializeComponent();
        }

        private void Complaints_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            var database = new Database();
            if (database.connect_db())
            {
                string query = "SELECT * FROM complaint";
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

        private void dataGridViewMyAllData_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            complaintIDTb.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[0].Value.ToString();
            fnTb.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[1].Value.ToString();
            addressTB.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[2].Value.ToString();
            cnTb.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[3].Value.ToString();
            nocTb.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[4].Value.ToString();
            docTb.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewMyAllData.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string complaintID = dataGridViewMyAllData.SelectedRows[0].Cells["complaintid"].Value.ToString();

                    using (MySqlConnection connection = new MySqlConnection(Database.connection_string))
                    {
                        using (MySqlCommand cmd = new MySqlCommand("DELETE FROM complaint WHERE complaintid = @complaintid", connection))
                        {
                            cmd.Parameters.AddWithValue("@complaintid", complaintID);
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

        private void ClearData()
        {
            complaintIDTb.Text = "";
            fnTb.Text = "";
            addressTB.Text = "";
            cnTb.Text = "";
            nocTb.Text = "";
            docTb.Text = "";
        }

        private void updateBtn_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewMyAllData.SelectedRows.Count > 0)
            {
                string complaintID = dataGridViewMyAllData.SelectedRows[0].Cells["complaintid"].Value.ToString();

                using (MySqlConnection connection = new MySqlConnection(Database.connection_string))
                {
                    using (MySqlCommand cmd = new MySqlCommand("UPDATE complaint SET complaintid=@complaintid, fullname=@name, address=@address, contact_info=@contactinfo, " +
                        "complaint_nature=@con, complaint_details=@cod, created_at='' WHERE complaintid=@complaintid", connection))
                    {
                        cmd.Parameters.AddWithValue("@complaintid", complaintID);
                        cmd.Parameters.AddWithValue("@name", fnTb.Text);
                        cmd.Parameters.AddWithValue("@address", addressTB.Text);
                        cmd.Parameters.AddWithValue("@contactinfo", cnTb.Text);
                        cmd.Parameters.AddWithValue("@con", nocTb.Text);
                        cmd.Parameters.AddWithValue("@cod", docTb.Text);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Record Successfully Updated", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData(); // Assuming you have a method to refresh or load data
                        ClearData();
                    }
                }
            }
            else
            {
                MessageBox.Show("Select a row to UPDATE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                System.Windows.Forms.Application.Exit();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
