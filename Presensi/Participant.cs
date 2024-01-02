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
    public partial class Participant : Form
    {
        private DatabaseConnector databaseConnector;
        private DataTable dataTable;
        private string loggedInUsername;
        private int userID;
        private int? AttendanceID;
        public Participant(DatabaseConnector dbConnector, string username, int userID)
        {
            InitializeComponent();
            databaseConnector = dbConnector;
            loggedInUsername = username;
            UpdateUsernameLabel();
            this.userID = userID; // Store the user ID

            LoadDataToDataGridView1();

        }
        private void UpdateUsernameLabel()
        {
            // Assuming you have a label named 'lblUsername' in your form
            label_username3.Text = $"Welcome, {loggedInUsername}!";
        }

        private void LoadDataToDataGridView1()
        {
            try
            {
                databaseConnector.OpenConnection();

                // Get the assigned event ID for the current tier 2 user
                int UID = GetUserID(userID);

                if (UID == -1)
                {
                    MessageBox.Show("Error: Assigned event ID not found for the current user.");
                    return;
                }

                // Replace 'kehadiran' with your actual attendance table name
                string query = $"SELECT k.id AS AttendanceID, k.eventID, e.nama, e.tempat, k.userID, k.status " +
               $"FROM kehadiran k " +
               $"INNER JOIN event e ON k.eventID = e.id " +
               $"WHERE k.userID IN (SELECT id FROM user WHERE id = {UID})";

                using (MySqlCommand cmd = new MySqlCommand(query, databaseConnector.Connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Assuming dataGridView1 is your DataGridView
                        dataGridView1.DataSource = dataTable;
                    }
                }
                dataGridView1.ClearSelection();
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
        private int GetUserID(int userID)
        {
            try
            {
                databaseConnector.OpenConnection();

                // Replace 'event' and 'assignedID' with your actual table and column names
                string query = $"SELECT id FROM user WHERE id = {userID}";

                using (MySqlCommand cmd = new MySqlCommand(query, databaseConnector.Connection))
                {
                    object result = cmd.ExecuteScalar();

                    // If the assigned event ID is found, return it
                    if (result != null && int.TryParse(result.ToString(), out int UID))
                    {
                        return UID;
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
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                databaseConnector.CloseConnection();
            }
        }
        private void btn_logout_Click(object sender, EventArgs e)
        {
            // Hide the current form (which is the admin form)
            this.Close();

            // Show the login Form1 again
            Form1 form1 = Form1.GetMainFormInstance();
            form1.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in a valid row (not header or empty)
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Assuming your columns are named "id", "username", "password", and "tier"
                string idObject = selectedRow.Cells["AttendanceID"].Value.ToString();
                string statusObject = selectedRow.Cells["status"].Value.ToString();

                if (idObject != null && statusObject != null)
                {
                    string id = idObject.ToString();
                    string status = statusObject.ToString();

                    // Set the values in the textboxes and combobox
                    cb_status.Text = status;
                    AttendanceID = int.Parse(id);
                }
                else
                {
                    // Handle the case when the clicked row is empty
                    // For example, clear the text in the combobox and reset the AttendanceID
                    cb_status.Text = string.Empty;
                    AttendanceID = null; // Set to a default or invalid value
                }
            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                // Get values from textboxes and combobox
                string status = cb_status.SelectedItem?.ToString();

                if (AttendanceID == null)
                {
                    MessageBox.Show("Error: Please select a row first.");
                    return; // Return without updating if no row is selected
                }

                // Call the UpdateKehadiranStatus function
                UpdateDataToTableAtt(AttendanceID.Value, status);

                // Refresh the DataGridView3 to reflect the changes
                LoadDataToDataGridView1();

                cb_status.SelectedIndex = -1;
                AttendanceID = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
