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

namespace Presensi
{
    public partial class Operator : Form
    {
        private DatabaseConnector databaseConnector;
        private DataTable dataTable;
        private string loggedInUsername;
        private int userID;
        public Operator(DatabaseConnector dbConnector, string username, int userID)
        {
            InitializeComponent();
            databaseConnector = dbConnector;
            loggedInUsername = username;
            this.userID = userID; // Store the user ID
            UpdateUsernameLabel();

            LoadDataToDataGridView1();
        }
        private void UpdateUsernameLabel()
        {
            // Assuming you have a label named 'lblUsername' in your form
            label_username.Text = $"Welcome, {loggedInUsername}!";
        }
        private void btn_logout_Click(object sender, EventArgs e)
        {
            // Hide the current form (which is the admin form)
            this.Close();

            // Show the login Form1 again
            Form1 form1 = Form1.GetMainFormInstance();
            form1.Show();
        }

        private void LoadDataToDataGridView1()
        {
            try
            {
                databaseConnector.OpenConnection();

                // Replace 'event' with your actual table name and column names
                string query = "SELECT id AS event_id, nama, tanggal FROM event WHERE assignedID = @userId";

                using (MySqlCommand cmd = new MySqlCommand(query, databaseConnector.Connection))
                {
                    cmd.Parameters.AddWithValue("@userId", userID);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Bind the DataTable to the DataGridView
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
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
                string id = selectedRow.Cells["event_id"].Value.ToString();
                string nama = selectedRow.Cells["nama"].Value.ToString();

                // Set the values in the textboxes and combobox
                tb_id.Text = id;
                tb_nama.Text = nama;

                // Extract the date value and set it in the DateTimePicker
                if (DateTime.TryParse(selectedRow.Cells["tanggal"].Value.ToString(), out DateTime eventDate))
                {
                    // Assuming that dateTimePicker1 is the name of your DateTimePicker
                    dtp1.Value = eventDate;
                }
                else
                {
                    // Handle the case where the date value cannot be parsed
                    MessageBox.Show("Invalid date format in the selected row.");
                }
            }
        }

        private void UpdateDataInTableEvent(string id, string eventName, DateTime eventDate)
        {
            try
            {
                databaseConnector.OpenConnection();

                // Update data in MySQL table
                string query = $"UPDATE event SET nama = '{eventName}', tanggal = '{eventDate:yyyy-MM-dd HH:mm:ss}' WHERE id = {id}";

                using (MySqlCommand cmd = new MySqlCommand(query, databaseConnector.Connection))
                {
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Event data updated successfully!");

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

        private void btn_clear1_Click(object sender, EventArgs e)
        {
            tb_id.Text = string.Empty;
            tb_nama.Text = string.Empty;
        }

        private void btn_update1_Click(object sender, EventArgs e)
        {
            try
            {
                // Get values from textboxes and datetime picker
                string id = tb_id.Text.Trim();
                string eventName = tb_nama.Text.Trim();
                DateTime eventDate = dtp1.Value; // Assuming dtp1 is your DateTimePicker

                // Call the UpdateDataInTableEvent function
                UpdateDataInTableEvent(id, eventName, eventDate);

                // Refresh the DataGridView2 to reflect the changes
                LoadDataToDataGridView1();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
