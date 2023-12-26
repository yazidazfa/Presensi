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
        public Participant(DatabaseConnector dbConnector, string username)
        {
            InitializeComponent();
            databaseConnector = dbConnector;
            loggedInUsername = username;
            UpdateUsernameLabel();
        }
        private void UpdateUsernameLabel()
        {
            // Assuming you have a label named 'lblUsername' in your form
            label_username3.Text = $"Welcome, {loggedInUsername}!";
        }
        private void btn_logout_Click(object sender, EventArgs e)
        {
            // Hide the current form (which is the admin form)
            this.Close();

            // Show the login Form1 again
            Form1 form1 = Form1.GetMainFormInstance();
            form1.Show();
        }
    }
}
