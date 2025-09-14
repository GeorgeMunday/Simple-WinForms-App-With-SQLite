namespace Login_Signin_Logout
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userName = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.Heading1 = new System.Windows.Forms.Label();
            this.headingContainer = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.regesterLabel = new System.Windows.Forms.LinkLabel();
            this.headingContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(12, 168);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(67, 16);
            this.userName.TabIndex = 1;
            this.userName.Text = "username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(85, 168);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(178, 22);
            this.txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(85, 231);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(178, 22);
            this.txtPassword.TabIndex = 5;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(12, 231);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(66, 16);
            this.Password.TabIndex = 4;
            this.Password.Text = "password";
            // 
            // Heading1
            // 
            this.Heading1.AutoSize = true;
            this.Heading1.Location = new System.Drawing.Point(11, 47);
            this.Heading1.Name = "Heading1";
            this.Heading1.Size = new System.Drawing.Size(66, 16);
            this.Heading1.TabIndex = 6;
            this.Heading1.Text = "Heading1";
            // 
            // headingContainer
            // 
            this.headingContainer.Controls.Add(this.Heading1);
            this.headingContainer.Location = new System.Drawing.Point(1, 0);
            this.headingContainer.Name = "headingContainer";
            this.headingContainer.Size = new System.Drawing.Size(461, 113);
            this.headingContainer.TabIndex = 8;
            this.headingContainer.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(1, 278);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(461, 80);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "btnLogin";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // regesterLabel
            // 
            this.regesterLabel.AutoSize = true;
            this.regesterLabel.Location = new System.Drawing.Point(12, 380);
            this.regesterLabel.Name = "regesterLabel";
            this.regesterLabel.Size = new System.Drawing.Size(91, 16);
            this.regesterLabel.TabIndex = 10;
            this.regesterLabel.TabStop = true;
            this.regesterLabel.Text = "regesterLabel";
            this.regesterLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.regesterLabel_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 439);
            this.Controls.Add(this.regesterLabel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.headingContainer);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.userName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.headingContainer.ResumeLayout(false);
            this.headingContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Heading1;
        private System.Windows.Forms.GroupBox headingContainer;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel regesterLabel;
    }
}

