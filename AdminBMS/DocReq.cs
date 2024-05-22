using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Google.Protobuf.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.VisualBasic.ApplicationServices;

namespace AdminBMS
{
    public partial class DocReq : Form
    {

        public DocReq()
        {
            InitializeComponent();

        }

        private void DocReq_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            var database = new Database();
            if (database.connect_db())
            {
                string query = "SELECT * FROM docreq";
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

        // Clears the Data  
        private void ClearData()
        {
            docIDTb.Text = "";
            requesterTb.Text = "";
            docTypeTb.Text = "";
            requestDateTb.Text = "";

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void docreqDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewMyAllData_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            docIDTb.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[0].Value.ToString();
            requesterTb.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[1].Value.ToString();
            docTypeTb.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[2].Value.ToString();
            requestDateTb.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[3].Value.ToString();
            statusTb.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewMyAllData.SelectedRows.Count > 0)
            {
                string selectedreqID = dataGridViewMyAllData.SelectedRows[0].Cells["docreqID"].Value.ToString();

                using (MySqlConnection connection = new MySqlConnection(Database.connection_string))
                {
                    using (MySqlCommand cmd = new MySqlCommand("UPDATE docreq SET docreqid=@docreqid, requestername=@requestername, docType=@docType, reqDate=@reqDate, status=@status WHERE docreqid=@docreqid", connection))
                    {

                        cmd.Parameters.AddWithValue("@docreqid", docIDTb.Text);
                        cmd.Parameters.AddWithValue("@requestername", requesterTb.Text);
                        cmd.Parameters.AddWithValue("@docType", docTypeTb.Text);
                        cmd.Parameters.AddWithValue("@reqDate", Convert.ToDateTime(requestDateTb.Text).ToString("yyyy-MM-dd HH:mm:ss"));
                        cmd.Parameters.AddWithValue("@status", statusTb.Text);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Record Successfully Updated", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                        ClearData();
                    }
                }
            }
            else
            {
                MessageBox.Show("Select a row to UPDATE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewMyAllData.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string docreqid = dataGridViewMyAllData.SelectedRows[0].Cells["docreqID"].Value.ToString();

                    using (MySqlConnection connection = new MySqlConnection(Database.connection_string))
                    {
                        try
                        {
                            connection.Open();

                            // Begin a transaction
                            using (MySqlTransaction transaction = connection.BeginTransaction())
                            {
                                try
                                {
                                    // Delete dependent records from indigency table
                                    using (MySqlCommand cmd = new MySqlCommand("DELETE FROM indigency WHERE docreqID = @docreqID", connection, transaction))
                                    {
                                        cmd.Parameters.AddWithValue("@docreqID", docreqid);
                                        cmd.ExecuteNonQuery();
                                    }

                                    // Delete dependent records from brgyclearance table
                                    using (MySqlCommand cmd = new MySqlCommand("DELETE FROM brgyclearance WHERE docreqID = @docreqID", connection, transaction))
                                    {
                                        cmd.Parameters.AddWithValue("@docreqID", docreqid);
                                        cmd.ExecuteNonQuery();
                                    }

                                    // Delete dependent records from residency table
                                    using (MySqlCommand cmd = new MySqlCommand("DELETE FROM residency WHERE docreqID = @docreqID", connection, transaction))
                                    {
                                        cmd.Parameters.AddWithValue("@docreqID", docreqid);
                                        cmd.ExecuteNonQuery();
                                    }

                                    // Delete record from docreq table
                                    using (MySqlCommand cmd = new MySqlCommand("DELETE FROM docreq WHERE docreqID = @docreqID", connection, transaction))
                                    {
                                        cmd.Parameters.AddWithValue("@docreqID", docreqid);
                                        int rowsAffected = cmd.ExecuteNonQuery();

                                        if (rowsAffected > 0)
                                        {
                                            transaction.Commit();
                                            MessageBox.Show("Record Successfully Deleted", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            loadData();
                                            ClearData();
                                        }
                                        else
                                        {
                                            transaction.Rollback();
                                            MessageBox.Show("No record deleted. Please make sure the selected record exists.", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    transaction.Rollback();
                                    MessageBox.Show("An error occurred while deleting the record: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }

                            connection.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred while connecting to the database: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Select a row to delete", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void requesterTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewMyAllData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        private void backBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to go back?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the user clicks Yes, proceed to go back to the login page
            if (result == DialogResult.Yes)
            {
                ChooseDoc choosedoc = new ChooseDoc();
                this.Hide(); // Hide the current form
                choosedoc.Show();
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


