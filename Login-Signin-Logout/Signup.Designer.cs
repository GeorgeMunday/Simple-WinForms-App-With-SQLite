namespace Login_Signin_Logout
{
    partial class Signup
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
            this.regesterLabel = new System.Windows.Forms.LinkLabel();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.headingContainer = new System.Windows.Forms.GroupBox();
            this.Heading1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.Label();
            this.headingContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // regesterLabel
            // 
            this.regesterLabel.AutoSize = true;
            this.regesterLabel.Location = new System.Drawing.Point(23, 392);
            this.regesterLabel.Name = "regesterLabel";
            this.regesterLabel.Size = new System.Drawing.Size(91, 16);
            this.regesterLabel.TabIndex = 17;
            this.regesterLabel.TabStop = true;
            this.regesterLabel.Text = "regesterLabel";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(12, 295);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(461, 80);
            this.btnSignUp.TabIndex = 16;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // headingContainer
            // 
            this.headingContainer.Controls.Add(this.Heading1);
            this.headingContainer.Location = new System.Drawing.Point(3, 1);
            this.headingContainer.Name = "headingContainer";
            this.headingContainer.Size = new System.Drawing.Size(461, 113);
            this.headingContainer.TabIndex = 15;
            this.headingContainer.TabStop = false;
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
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(96, 243);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(178, 22);
            this.txtPassword.TabIndex = 14;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(23, 243);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(66, 16);
            this.Password.TabIndex = 13;
            this.Password.Text = "password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(96, 180);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(178, 22);
            this.txtUsername.TabIndex = 12;
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(23, 180);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(67, 16);
            this.userName.TabIndex = 11;
            this.userName.Text = "username";
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 439);
            this.Controls.Add(this.regesterLabel);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.headingContainer);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.userName);
            this.Name = "Signup";
            this.Text = "Form2";
            this.headingContainer.ResumeLayout(false);
            this.headingContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel regesterLabel;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.GroupBox headingContainer;
        private System.Windows.Forms.Label Heading1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label userName;
    }
}