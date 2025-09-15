using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;


namespace Login_Signin_Logout
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.Text = "Login";
            this.Size = new Size(450, 450);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.BackColor = Color.White;

            // Heading Container
            headingContainer.Size = new Size(this.ClientSize.Width, 120);
            headingContainer.Location = new Point(0, 0);
            headingContainer.BackColor = Color.FromArgb(70, 130, 180);
            headingContainer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // Main Heading
            Heading1.Text = "Lets get you logged in!";
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

            // Login Button
            btnLogin.Text = "Login";
            btnLogin.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnLogin.Size = new Size(340, 35);
            btnLogin.Location = new Point(50, 285);
            btnLogin.BackColor = Color.FromArgb(70, 130, 180);
            btnLogin.ForeColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;

            // Link Label 
            regesterLabel.Text = "Don't have an account? Sign Up";
            regesterLabel.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            regesterLabel.Location = new Point(50, 330);
            regesterLabel.AutoSize = true;
            regesterLabel.LinkColor = Color.FromArgb(70, 130, 180);
            regesterLabel.ActiveLinkColor = Color.DarkBlue;
            regesterLabel.VisitedLinkColor = Color.Purple;
            regesterLabel.Cursor = Cursors.Hand;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            string dbPath = @"C:\Users\geoge\OneDrive\Desktop\dbs\new.db";
            string connectionString = $"Data Source={dbPath};Version=3;";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(1) FROM Users WHERE Username=@Username AND Password=@Password";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count == 1)
                        {
                            MessageBox.Show("Login successful!");
                            Dashboard dashboardForm = new Dashboard(username);
                            dashboardForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to database: " + ex.Message);
                }
            }
        }


        private void regesterLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup signupForm = new Signup();
            signupForm.Show();
            this.Hide();
        }

    }
}
