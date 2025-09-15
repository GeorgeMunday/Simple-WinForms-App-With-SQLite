using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace Login_Signin_Logout
{
    public partial class Dashboard : Form
    {
        private string _username;
        private int num = 0;

        public Dashboard(string username)
        {
            InitializeComponent();
            _username = username;
            var (uname, firstName, lastName) = GetUserInfo(_username);

            // Form Properties
            this.Text = "Dashboard";
            this.Size = new Size(500, 500);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.BackColor = Color.White;

            // Heading Container
            headingContainer.Text = "";
            headingContainer.Size = new Size(this.ClientSize.Width, 100);
            headingContainer.Location = new Point(0, 0);
            headingContainer.BackColor = Color.FromArgb(70, 130, 180);
            headingContainer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // Welcome message
            Heading1.Text = $"Welcome, {firstName} {lastName}!";
            Heading1.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            Heading1.ForeColor = Color.White;
            Heading1.AutoSize = true;
            Heading1.Location = new Point(20, 35);

            // Username Label & TextBox
            Username.Text = "Username:";
            Username.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            Username.AutoSize = true;
            Username.Location = new Point(30, 130);

            txtUsername.Text = uname;
            txtUsername.Location = new Point(30, 155);
            txtUsername.Size = new Size(400, 30);
            txtUsername.Font = new Font("Segoe UI", 10);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.ReadOnly = true; // optional

            // First Name Label & TextBox
            this.firstName.Text = "First Name:";
            this.firstName.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            this.firstName.AutoSize = true;
            this.firstName.Location = new Point(30, 200);

            txtFirstName.Text = firstName;
            txtFirstName.Location = new Point(30, 225);
            txtFirstName.Size = new Size(400, 30);
            txtFirstName.Font = new Font("Segoe UI", 10);
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;

            // Last Name Label & TextBox
            this.lastName.Text = "Last Name:";
            this.lastName.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            this.lastName.AutoSize = true;
            this.lastName.Location = new Point(30, 270);

            txtLastName.Text = lastName;
            txtLastName.Location = new Point(30, 295);
            txtLastName.Size = new Size(400, 30);
            txtLastName.Font = new Font("Segoe UI", 10);
            txtLastName.BorderStyle = BorderStyle.FixedSingle;

            // Count Label
            count.Text = num.ToString();
            count.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            count.Location = new Point(30, 350);
            count.AutoSize = true;

            // Count Button
            button1.Text = "Increment";
            button1.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            button1.Size = new Size(100, 30);
            button1.Location = new Point(350, 345);

            // Log Out Button
            logOutBtn.Text = "Log Out";
            logOutBtn.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            logOutBtn.Size = new Size(100, 30);
            logOutBtn.Location = new Point(350, 400);
            logOutBtn.BackColor = Color.FromArgb(220, 53, 69);
            logOutBtn.ForeColor = Color.White;
            logOutBtn.FlatStyle = FlatStyle.Flat;
            logOutBtn.FlatAppearance.BorderSize = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count.Text = (++num).ToString();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
        }

        private (string Username, string FirstName, string LastName) GetUserInfo(string username)
        {
            string dbPath = @"C:\Users\geoge\OneDrive\Desktop\dbs\new.db";
            string connectionString = $"Data Source={dbPath};Version=3;";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Username, FirstName, LastName FROM Users WHERE Username = @Username";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return (
                                reader["Username"].ToString(),
                                reader["FirstName"].ToString(),
                                reader["LastName"].ToString()
                            );
                        }
                        else
                        {
                            return (null, null, null);
                        }
                    }
                }
            }
        }
    }
}
