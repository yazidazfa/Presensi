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
    public partial class Form1 : Form
    {
        private static Form1 mainFormInstance;
        private DatabaseConnector databaseConnector;
        public string LoggedInUsername { get; private set; }
        public Form1()
        {
            InitializeComponent();
            databaseConnector = new DatabaseConnector();
            mainFormInstance = this;  // Set the mainFormInstance when the form is created
        }
        public static Form1 GetMainFormInstance()
        {
            return mainFormInstance;
        }
      
        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text.Trim();
            string password = tb_password.Text.Trim();

            int userTier = ValidateUser(username, password);

            if (userTier > 0)
            {
                LoggedInUsername = username;
                OpenAppropriateForm(userTier);
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
            tb_username.Text = string.Empty;
            tb_password.Text = string.Empty;
        }
        private bool ValidateLogin(string enteredPassword, string storedHash, string storedSalt)
        {
            using (var sha256 = SHA256.Create())
            {
                // Convert the stored salt from Base64 to byte array
                byte[] saltBytes = Convert.FromBase64String(storedSalt);

                // Combine password and salt, then hash
                byte[] combinedBytes = Encoding.UTF8.GetBytes(enteredPassword + storedSalt);
                byte[] hashedBytes = sha256.ComputeHash(combinedBytes);
                string enteredHash = Convert.ToBase64String(hashedBytes);

                // Debugging: Print the entered and stored hashes
                Console.WriteLine($"Entered hash: {enteredHash}");
                Console.WriteLine($"Stored hash: {storedHash}");

                // Compare entered hash with the stored hash
                return enteredHash == storedHash;
            }
        }
        private int ValidateUser(string username, string password)
        {
            try
            {
                databaseConnector.OpenConnection();

                // Replace 'users' with your actual table name and column names
                string query = "SELECT tier, password, salt FROM user WHERE name = @username";
                Console.WriteLine($"Executing query: {query} with parameter @username={username}");

                using (MySqlCommand cmd = new MySqlCommand(query, databaseConnector.Connection))
                {
                    // Use parameterized query to prevent SQL injection
                    cmd.Parameters.AddWithValue("@username", username);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Retrieve the user's tier, hashed password, and salt from the database
                            int userTier = reader.GetInt32("tier");
                            string storedPasswordHash = reader.GetString("password");
                            string salt = reader.GetString("salt");

                            // Debugging statements
                            Console.WriteLine($"Retrieved data from the database:");
                            Console.WriteLine($"User Tier: {userTier}");
                            Console.WriteLine($"Stored Password Hash: {storedPasswordHash}");
                            Console.WriteLine($"Salt: {salt}");

                            // Validate the entered password against the stored hash
                            if (ValidateLogin(password, storedPasswordHash, salt))
                            {
                                return userTier;
                            }
                            else
                            {
                                Console.WriteLine("Validation failed. Incorrect password.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No user found with the specified username.");
                        }
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

            return 0; // Return 0 if validation fails
        }
        private void OpenAppropriateForm(int userTier)
        {

            switch (userTier)
            {
                case 1:
                    Admin adminForm = new Admin(databaseConnector, LoggedInUsername);
                    adminForm.FormClosing += (sender, e) => ShowForm1OnClose(adminForm);
                    adminForm.Show();
                    break;
                case 2:
                    Operator operatorForm = new Operator();
                    operatorForm.FormClosing += (sender, e) => ShowForm1OnClose(operatorForm);
                    operatorForm.Show();
                    break;
                case 3:
                    Participant participantForm = new Participant();
                    participantForm.FormClosing += (sender, e) => ShowForm1OnClose(participantForm);
                    participantForm.Show();
                    break;
                default:
                    MessageBox.Show("Invalid user tier.");
                    break;
            }

            this.Hide();
        }
        private void ShowForm1OnClose(Form closingForm)
        {
            mainFormInstance.Show();
        }
        private void tb_password_TextChanged(object sender, EventArgs e)
        {
            tb_password.ForeColor = Color.Black;
            tb_password.PasswordChar = '*';
        }
    }
    public class DatabaseConnector
    {
        private static DatabaseConnector instance;
        private MySqlConnection connection;

        public MySqlConnection Connection
        {
            get { return connection; }
        }

        public DatabaseConnector()
        {
            Initialize();
        }
        public static DatabaseConnector GetInstance()
        {
            if (instance == null)
            {
                instance = new DatabaseConnector();
            }
            return instance;
        }
        private void Initialize()
        {
            string connectionString = "Server=localhost;Database=presensi;User ID=root;Password=;";

            connection = new MySqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
