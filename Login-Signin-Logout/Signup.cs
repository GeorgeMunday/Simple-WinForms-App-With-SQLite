using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace Login_Signin_Logout
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
            Console.WriteLine("navigated to Sign up page");
            DBConnection();

            this.Text = "Sign Up";
            this.Size = new Size(450, 650);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.BackColor = Color.White;

            // Heading Container
            headingContainer.Size = new Size(this.ClientSize.Width, 120);
            headingContainer.Location = new Point(0, 0);
            headingContainer.BackColor = Color.FromArgb(70, 130, 180);
            headingContainer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // Main Heading
            Heading1.Text = "Lets get you signed up!";
            Heading1.TextAlign = ContentAlignment.MiddleCenter;
            Heading1.Dock = DockStyle.Fill;
            Heading1.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            Heading1.ForeColor = Color.White;
            Heading1.Location = new Point(0, 20);
            Heading1.Padding = new Padding(65, 30, 0, 0);
            // Username Label
            userName.Text = "Username";
            userName.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            userName.Location = new Point(50, 150);
            userName.AutoSize = true;

            // Username TextBox
            txtUsername.Location = new Point(50, 175);
            txtUsername.Size = new Size(340, 30);
            txtUsername.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;

            // Password Label
            Password.Text = "Password";
            Password.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            Password.Location = new Point(50, 215);
            Password.AutoSize = true;

            // Password TextBox
            txtPassword.Location = new Point(50, 240);
            txtPassword.Size = new Size(340, 30);
            txtPassword.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.UseSystemPasswordChar = true;

            // First Name Label
            firstName.Text = "First Name";
            firstName.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            firstName.Location = new Point(50, 280);
            firstName.AutoSize = true;

            // First Name TextBox
            txtFirstName.Location = new Point(50, 305);
            txtFirstName.Size = new Size(340, 30);
            txtFirstName.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;

            // Last Name Label
            lastName.Text = "Last Name";
            lastName.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            lastName.Location = new Point(50, 345);
            lastName.AutoSize = true;

            // Last Name TextBox
            txtLastName.Location = new Point(50, 370);
            txtLastName.Size = new Size(340, 30);
            txtLastName.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            txtLastName.BorderStyle = BorderStyle.FixedSingle;

            // Login Button
            btnSignUp.Text = "Sign Up";
            btnSignUp.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnSignUp.Size = new Size(340, 35);
            btnSignUp.Location = new Point(50,435);
            btnSignUp.BackColor = Color.FromArgb(70, 130, 180);
            btnSignUp.ForeColor = Color.White;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.FlatAppearance.BorderSize = 0;

            // Link Label 
            regesterLabel.Text = "Have an account? Log In";
            regesterLabel.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            regesterLabel.Location = new Point(50, 490);
            regesterLabel.AutoSize = true;
            regesterLabel.LinkColor = Color.FromArgb(70, 130, 180);
            regesterLabel.ActiveLinkColor = Color.DarkBlue;
            regesterLabel.VisitedLinkColor = Color.Purple;
            regesterLabel.Cursor = Cursors.Hand; ;
        }

        private SQLiteConnection DBConnection()
        {
            string dbPath = @"C:\Users\geoge\OneDrive\Desktop\dbs\new.db";
            string connectionString = $"Data Source={dbPath};Version=3;";
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            try
            {
                connection.Open();
                Console.WriteLine("DB connected");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message);
            }

            return connection;
        }

        private void CreateTableIfNotExists(SQLiteConnection connection)
        {
            string sql = @"CREATE TABLE IF NOT EXISTS Users (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Username TEXT UNIQUE,
                    Password TEXT,
                    FirstName TEXT,
                    LastName TEXT
                  )";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
            {
                cmd.ExecuteNonQuery();
            }
        }



        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            using (SQLiteConnection conn = DBConnection())
            {
                CreateTableIfNotExists(conn);

                string query = "INSERT INTO Users (Username, Password, FirstName, LastName) VALUES (@Username, @Password, @FirstName, @LastName)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Signup successful!");
                        txtUsername.Clear();
                        txtPassword.Clear();
                        txtFirstName.Clear();
                        txtLastName.Clear();
                        Login loginForm = new Login();
                        loginForm.Show();
                        this.Hide();
                    }
                    catch (SQLiteException ex)
                    {
                        if (ex.ResultCode == SQLiteErrorCode.Constraint)
                            MessageBox.Show("Username already exists.");
                        else
                            MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }


        private void regesterLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }
    }
}
