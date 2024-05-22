using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminBMS
{
    public partial class brgyClearance : Form
    {
        public brgyClearance()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            var database = new Database();
            if (database.connect_db())
            {
                string query = "SELECT * FROM brgyclearance";
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
            clearanceIDTb.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[1].Value.ToString();
            nameTb.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[2].Value.ToString();
            ageTb.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[3].Value.ToString();
            statusTb.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[4].Value.ToString();
            purposeTb.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[5].Value.ToString();
            spouseTb.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[6].Value.ToString();
            nationalityTb.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[7].Value.ToString();
            sexTb.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[8].Value.ToString();
            dateTb.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[9].Value.ToString();
        }


        private void brgyClearance_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewMyAllData.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string clearanceID = dataGridViewMyAllData.SelectedRows[0].Cells["clearanceid"].Value.ToString();

                    using (MySqlConnection connection = new MySqlConnection(Database.connection_string))
                    {
                        using (MySqlCommand cmd = new MySqlCommand("DELETE FROM brgyclearance WHERE clearanceid = @clearanceid", connection))
                        {
                            cmd.Parameters.AddWithValue("@clearanceid", clearanceID);
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
            clearanceIDTb.Text = "";
            nameTb.Text = "";
            ageTb.Text = "";
            statusTb.Text = "";
            purposeTb.Text = "";
            nationalityTb.Text = "";
            sexTb.Text = "";
            dateTb.Text = "";
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewMyAllData.SelectedRows.Count > 0)
            {
                try
                {
                    string clearanceID = dataGridViewMyAllData.SelectedRows[0].Cells["clearanceid"].Value.ToString();

                    using (MySqlConnection connection = new MySqlConnection(Database.connection_string))
                    {
                        using (MySqlCommand cmd = new MySqlCommand("UPDATE brgyclearance SET name=@name, age=@age, civilstatus=@civilstatus, " +
                            "purpose=@purpose, spousename=@spousename, nationality=@nationality, sex=@sex, date=@date WHERE clearanceid=@clearanceid", connection))
                        {
                            cmd.Parameters.AddWithValue("@clearanceid", clearanceID);
                            cmd.Parameters.AddWithValue("@name", nameTb.Text);
                            cmd.Parameters.AddWithValue("@age", ageTb.Text);
                            cmd.Parameters.AddWithValue("@civilstatus", statusTb.Text);
                            cmd.Parameters.AddWithValue("@purpose", purposeTb.Text);
                            cmd.Parameters.AddWithValue("@spousename", spouseTb.Text);
                            cmd.Parameters.AddWithValue("@nationality", nationalityTb.Text);
                            cmd.Parameters.AddWithValue("@sex", sexTb.Text);
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

        private void closeBtn_Click(object sender, EventArgs e)
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

        private void ageTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void spouseTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewMyAllData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


