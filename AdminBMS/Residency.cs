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
    public partial class Residency : Form
    {
        public Residency()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
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

        private void Residency_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            var database = new Database();
            if (database.connect_db())
            {
                string query = "SELECT * FROM residency";
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

        private void dataGridViewMyAllData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteBtN_Click(object sender, EventArgs e)
        {
            if (dataGridViewMyAllData.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string residencyid = dataGridViewMyAllData.SelectedRows[0].Cells["residencyid"].Value.ToString();

                    using (MySqlConnection connection = new MySqlConnection(Database.connection_string))
                    {
                        using (MySqlCommand cmd = new MySqlCommand("DELETE FROM residency WHERE residencyid = @residencyid", connection))
                        {
                            cmd.Parameters.AddWithValue("@residencyid", residencyid);

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
                    string selectedresidencyID = dataGridViewMyAllData.SelectedRows[0].Cells["residencyid"].Value.ToString();

                    using (MySqlConnection connection = new MySqlConnection(Database.connection_string))
                    {
                        using (MySqlCommand cmd = new MySqlCommand("UPDATE residency SET name=@name, age=@age, status=@status, date=@date WHERE residencyid=@residencyid", connection))
                        {
                            cmd.Parameters.AddWithValue("@residencyid", selectedresidencyID);
                            cmd.Parameters.AddWithValue("@name", nameTb.Text);
                            cmd.Parameters.AddWithValue("@age", ageTb.Text);
                            cmd.Parameters.AddWithValue("@status", statusTb.Text);
                            cmd.Parameters.AddWithValue("@date", Convert.ToDateTime(dateTb.Text).ToString("yyyy-MM-dd HH:mm:ss"));

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
    

        public void ClearData()
        {
            residencyIDTb.Text = "";
            nameTb.Text = "";
            statusTb.Text = "";
            dateTb.Text = "";

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
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

        private void dataGridViewMyAllData_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            residencyIDTb.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[1].Value.ToString();
            nameTb.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[2].Value.ToString();
            ageTb.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[3].Value.ToString();
            statusTb.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[4].Value.ToString();
            dateTb.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
    }
}
