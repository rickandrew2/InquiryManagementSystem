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
    public partial class Indigency : Form
    {
        public Indigency()
        {
            InitializeComponent();
        }

        private void Indigency_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void loadData()
        {
            var database = new Database();
            if (database.connect_db())
            {
                string query = "SELECT * FROM  indigency";
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

            indigencyIDTb.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[1].Value?.ToString() ?? "";
            nameTb.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[2].Value?.ToString() ?? "";
            ageTb.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[3].Value?.ToString() ?? "";
            parentTb.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[4].Value?.ToString() ?? "";
            addressTb.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[5].Value?.ToString() ?? "";
            purposeTb.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[6].Value?.ToString() ?? "";
            dateTb.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[7].Value?.ToString() ?? "";
        }


        private void ClearData()
        {
            indigencyIDTb.Text = "";
            parentTb.Text = "";
            ageTb.Text = "";
            addressTb.Text = "";
            purposeTb.Text = "";
            dateTb.Text = "";
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewMyAllData.SelectedRows.Count > 0)
            {
                try
                {
                    string indigencyID = dataGridViewMyAllData.SelectedRows[0].Cells["indigencyid"].Value.ToString();

                    using (MySqlConnection connection = new MySqlConnection(Database.connection_string))
                    {
                        using (MySqlCommand cmd = new MySqlCommand("UPDATE indigency SET name=@name, age=@age, Parents=@parents, sitio=@sitio, " +
                            "purpose=@purpose, date=@date WHERE indigencyID=@indigencyid", connection))
                        {
                            cmd.Parameters.AddWithValue("@indigencyid", indigencyID);
                            cmd.Parameters.AddWithValue("@name", nameTb.Text);
                            cmd.Parameters.AddWithValue("@age", ageTb.Text);
                            cmd.Parameters.AddWithValue("@parents", parentTb.Text); // Corrected parameter name
                            cmd.Parameters.AddWithValue("@sitio", addressTb.Text);
                            cmd.Parameters.AddWithValue("@purpose", purposeTb.Text);
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

        private void pictureBox2_Click(object sender, EventArgs e)
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

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewMyAllData.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string indigencyID = dataGridViewMyAllData.SelectedRows[0].Cells["indigencyid"].Value.ToString();

                    using (MySqlConnection connection = new MySqlConnection(Database.connection_string))
                    {
                        using (MySqlCommand cmd = new MySqlCommand("DELETE FROM indigency WHERE indigencyid = @indigencyid", connection))
                        {
                            cmd.Parameters.AddWithValue("@indigencyid", indigencyID);
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

        private void closeBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dataGridViewMyAllData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
