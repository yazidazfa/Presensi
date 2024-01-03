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
            LoadDataToDataGridView2();
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
                string query = "SELECT id AS eventID, nama, tempat, tanggal FROM event WHERE assignedID = @userId";

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
                string id = selectedRow.Cells["eventID"].Value.ToString();
                string nama = selectedRow.Cells["nama"].Value.ToString();
                string tempat = selectedRow.Cells["tempat"].Value.ToString();

                // Set the values in the textboxes and combobox
                tb_id.Text = id;
                tb_nama.Text = nama;
                tb_tempat.Text = tempat;

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

        private void UpdateDataInTableEvent(string id, string eventName, DateTime eventDate, string tempat)
        {
            try
            {
                databaseConnector.OpenConnection();

                // Update data in MySQL table
                string query = $"UPDATE event SET nama = '{eventName}', tanggal = '{eventDate:yyyy-MM-dd HH:mm:ss}', tempat = '{tempat}' WHERE id = {id}";

                using (MySqlCommand cmd = new MySqlCommand(query, databaseConnector.Connection))
                {
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Event data updated successfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: Please select a row!");
            }
            finally
            {
                databaseConnector.CloseConnection();
            }
        }

        private void LoadDataToDataGridView2()
        {
            try
            {
                databaseConnector.OpenConnection();

                // Get the assigned event ID for the current tier 2 user
                int assignedEventID = GetAssignedEventIDForUser(userID);

                if (assignedEventID == -1)
                {
                    MessageBox.Show("Error: Assigned event ID not found for the current user.");
                    return;
                }

                // Replace 'kehadiran' with your actual attendance table name
                string query = $"SELECT k.id AS AttendanceID, k.eventID, e.nama AS NamaEvent, e.tempat, k.userID, k.status " +
               $"FROM kehadiran k " +
               $"INNER JOIN event e ON k.eventID = e.id " +
               $"WHERE k.eventID IN (SELECT id FROM event WHERE assignedID = {assignedEventID})";

                using (MySqlCommand cmd = new MySqlCommand(query, databaseConnector.Connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Assuming dataGridView3 is your DataGridView
                        dataGridView2.DataSource = dataTable;
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
        

        private int GetAssignedEventIDForUser(int userID)
        {
            try
            {
                databaseConnector.OpenConnection();

                // Replace 'event' and 'assignedID' with your actual table and column names
                string query = $"SELECT assignedID FROM event WHERE assignedID = {userID}";

                using (MySqlCommand cmd = new MySqlCommand(query, databaseConnector.Connection))
                {
                    object result = cmd.ExecuteScalar();

                    // If the assigned event ID is found, return it
                    if (result != null && int.TryParse(result.ToString(), out int assignedEventID))
                    {
                        return assignedEventID;
                    }

                    return -1; // Return -1 if assigned event ID is not found
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return -1;
            }
            finally
            {
                databaseConnector.CloseConnection();
            }
        }
        private void UpdateDataToTableAtt(int attendanceId, string status)
        {
            try
            {
                databaseConnector.OpenConnection();

                // Update data in MySQL table
                string query = $"UPDATE kehadiran SET status = '{status}' WHERE id = {attendanceId}";

                using (MySqlCommand cmd = new MySqlCommand(query, databaseConnector.Connection))
                {
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Attendance data updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: Please select a row!");
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
                string tempat = tb_tempat.Text.Trim();

                // Call the UpdateDataInTableEvent function
                UpdateDataInTableEvent(id, eventName, eventDate, tempat);

                // Refresh the DataGridView2 to reflect the changes
                LoadDataToDataGridView1();
                LoadDataToDataGridView2();
                tb_id.Text = string.Empty;
                tb_nama.Text = string.Empty;
                tb_tempat.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: Please select a row!");
            }
        }

        private void btn_update2_Click(object sender, EventArgs e)
        {
            try
            {
                // Get values from textboxes and combobox
                string idString = tb_id2.Text.Trim();
                string status = cb_status.SelectedItem?.ToString();

                // Convert the idString to an integer
                if (int.TryParse(idString, out int id))
                {
                    // Call the UpdateDataInTableAtt function
                    UpdateDataToTableAtt(id, status);

                    // Refresh the DataGridView3 to reflect the changes
                    LoadDataToDataGridView2();
                }
                else
                {
                    MessageBox.Show("Error: Please select a row!");
                }
                tb_id2.Text = string.Empty;
                cb_status.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: Please select a row!");
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in a valid row (not header or empty)
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView2.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView2.Rows[e.RowIndex];

                // Assuming your columns are named "id", "username", "password", and "tier"
                string id = selectedRow.Cells["AttendanceID"].Value.ToString();
                string status = selectedRow.Cells["status"].Value.ToString();

                // Set the values in the textboxes and combobox
                tb_id2.Text = id;
                cb_status.Text = status;
            }
        }
    }
}
