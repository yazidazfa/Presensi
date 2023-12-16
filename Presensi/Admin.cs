using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace Presensi
{
    public partial class Admin : Form
    {
        private DatabaseConnector databaseConnector;
        private DataTable dataTable;
        private string loggedInUsername;  
        public Admin(DatabaseConnector dbConnector, string username)
        {
            InitializeComponent();
            databaseConnector = dbConnector;
            loggedInUsername = username;
            LoadDataIntoDataGridView();
            dataGridView1.CellClick += dataGridView1_CellClick;
            UpdateUsernameLabel();
        }
        private void UpdateUsernameLabel()
        {
            // Assuming you have a label named 'lblUsername' in your form
            label_username.Text = $"Welcome, {loggedInUsername}!";
        }

        private void LoadDataIntoDataGridView()
        {
            try
            {
                databaseConnector.OpenConnection();

                // Replace 'your_table' with the actual table name
                string query = "SELECT id, name, password, tier FROM user";

                using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, databaseConnector.Connection))
                {
                    using (MySql.Data.MySqlClient.MySqlDataAdapter adapter = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd))
                    {
                        dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                databaseConnector.CloseConnection();
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in a valid row (not header or empty)
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Assuming your columns are named "id", "username", "password", and "tier"
                string id = selectedRow.Cells["id"].Value.ToString();
                string username = selectedRow.Cells["name"].Value.ToString();
                string password = selectedRow.Cells["password"].Value.ToString();
                string tier = selectedRow.Cells["tier"].Value.ToString();

                // Set the values in the textboxes and combobox
                tb_id.Text = id;
                tb_username.Text = username;
                tb_password.Text = password;
                cb_tier.SelectedItem = tier;
            }
        }
        private void AddDataToTable(string username, string password, string tier)
        {
            try
            {
                databaseConnector.OpenConnection();

                // Generate a random salt
                string salt = GenerateSalt();

                // Hash the password with the generated salt
                string hashedPassword = HashPassword(password, salt);

                // Check if the username already exists
                string usernameCheckQuery = $"SELECT COUNT(*) FROM user WHERE name = '{username}'";
                using (MySqlCommand usernameCheckCmd = new MySqlCommand(usernameCheckQuery, databaseConnector.Connection))
                {
                    int existingRecords = Convert.ToInt32(usernameCheckCmd.ExecuteScalar());
                    if (existingRecords > 0)
                    {
                        MessageBox.Show("User with the same username already exists. Cannot add duplicate records.");
                        return; // Exit the method if the username already exists
                    }
                }

                // Proceed with inserting data if the username does not exist
                string insertQuery = $"INSERT INTO user (name, password, salt, tier) VALUES ('{username}', '{hashedPassword}', '{salt}', '{tier}')";

                using (MySqlCommand cmd = new MySqlCommand(insertQuery, databaseConnector.Connection))
                {
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Data added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                databaseConnector.CloseConnection();
            }
        }
        private void UpdateDataInTable(string id, string username, string password, string tier)
        {
            try
            {
                databaseConnector.OpenConnection();

                // Check if the username already exists
                string usernameCheckQuery = $"SELECT COUNT(*) FROM user WHERE name = '{username}' AND id != {id}";
                using (MySqlCommand usernameCheckCmd = new MySqlCommand(usernameCheckQuery, databaseConnector.Connection))
                {
                    int existingRecords = Convert.ToInt32(usernameCheckCmd.ExecuteScalar());
                    if (existingRecords > 0)
                    {
                        MessageBox.Show("User with the same username already exists. Cannot update to a duplicate username.");
                        return; // Exit the method if the username already exists
                    }
                }

                // Generate a new random salt
                string salt = GenerateSalt();

                // Hash the new password with the generated salt
                string hashedPassword = HashPassword(password, salt);

                // Update data in MySQL table
                string query = $"UPDATE user SET name = '{username}', password = '{hashedPassword}', salt = '{salt}', tier = '{tier}' WHERE id = {id}";

                using (MySqlCommand cmd = new MySqlCommand(query, databaseConnector.Connection))
                {
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Data updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                databaseConnector.CloseConnection();
            }
        }
        private void DeleteDataFromTable(string id)
        {
            try
            {
                databaseConnector.OpenConnection();

                // Replace 'your_table' with the actual table name
                string deleteQuery = $"DELETE FROM user WHERE id = {id}";

                using (MySqlCommand cmd = new MySqlCommand(deleteQuery, databaseConnector.Connection))
                {
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Data deleted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                databaseConnector.CloseConnection();
            }
        }
        private string UnhashPassword(string hashedPassword, string salt)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] combinedBytes = Convert.FromBase64String(hashedPassword + salt);
                byte[] hashedBytes = sha256.ComputeHash(combinedBytes);
                return Convert.ToBase64String(hashedBytes);
            }
        }
        private string GenerateSalt()
        {
            // Generate a random salt using a secure RNG
            byte[] saltBytes = new byte[32];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(saltBytes);
            }
            return Convert.ToBase64String(saltBytes);
        }
        private string HashPassword(string password, string salt)
        {
            using (var sha256 = SHA256.Create())
            {
                // Combine password and salt, then hash
                byte[] combinedBytes = Encoding.UTF8.GetBytes(password + salt);
                byte[] hashedBytes = sha256.ComputeHash(combinedBytes);

                // Convert hashed bytes to base64 string
                return Convert.ToBase64String(hashedBytes);
            }
        }
        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            // Get values from textboxes
            string id = tb_id.Text.Trim();
            string username = tb_username.Text.Trim();
            string password = tb_password.Text.Trim();
            string tier = cb_tier.SelectedItem?.ToString(); // Assuming comboBoxTier is databound

            // Validate input if needed

            // Update data in MySQL table
            UpdateDataInTable(id, username, password, tier);

            // Refresh the DataGridView to reflect the changes
            LoadDataIntoDataGridView();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            // Clear all textboxes and combobox
            tb_id.Text = string.Empty;
            tb_username.Text = string.Empty;
            tb_password.Text = string.Empty;
            cb_tier.SelectedIndex = -1; // Clear the selection in the combobox
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text.Trim();
            string password = tb_password.Text.Trim();
            string tier = cb_tier.SelectedItem?.ToString(); 

            AddDataToTable(username, password, tier);

            LoadDataIntoDataGridView();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            // Assuming you have the ID of the record to delete
            string idToDelete = tb_id.Text.Trim();

            if (string.IsNullOrEmpty(idToDelete))
            {
                MessageBox.Show("Please select a record to delete.");
                return;
            }

            // Confirm with the user before deleting
            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                DeleteDataFromTable(idToDelete);

                // Refresh the DataGridView to reflect the changes
                LoadDataIntoDataGridView();
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();

            Form1 form1 = Form1.GetMainFormInstance();
            form1.Show();
        }
    }
}
