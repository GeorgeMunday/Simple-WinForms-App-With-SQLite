using System;
using System.Drawing;
using System.Windows.Forms;

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
            Heading1.Text = "Welcome to the Application";
            Heading1.TextAlign = ContentAlignment.MiddleCenter;
            Heading1.Dock = DockStyle.Fill;
            Heading1.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            Heading1.ForeColor = Color.White;
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

        }

        private void regesterLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Create and show the Signup form
            Signup signupForm = new Signup();
            signupForm.Show();

            // Hide the current Login form
            this.Hide();
        }

    }
}
}
