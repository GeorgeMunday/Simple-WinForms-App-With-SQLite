namespace Login_Signin_Logout
{
    partial class Dashboard
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
            this.headingContainer = new System.Windows.Forms.GroupBox();
            this.Heading1 = new System.Windows.Forms.Label();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.count = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.headingContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // headingContainer
            // 
            this.headingContainer.Controls.Add(this.Heading1);
            this.headingContainer.Location = new System.Drawing.Point(0, 1);
            this.headingContainer.Name = "headingContainer";
            this.headingContainer.Size = new System.Drawing.Size(597, 139);
            this.headingContainer.TabIndex = 0;
            this.headingContainer.TabStop = false;
            this.headingContainer.Text = "groupBox1";
            // 
            // Heading1
            // 
            this.Heading1.AutoSize = true;
            this.Heading1.Location = new System.Drawing.Point(12, 58);
            this.Heading1.Name = "Heading1";
            this.Heading1.Size = new System.Drawing.Size(44, 16);
            this.Heading1.TabIndex = 0;
            this.Heading1.Text = "label1";
            // 
            // logOutBtn
            // 
            this.logOutBtn.Location = new System.Drawing.Point(456, 146);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(141, 101);
            this.logOutBtn.TabIndex = 1;
            this.logOutBtn.Text = "Log Out";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(12, 168);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(37, 16);
            this.Username.TabIndex = 3;
            this.Username.Text = "label";
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(12, 204);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(44, 16);
            this.firstName.TabIndex = 5;
            this.firstName.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(494, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 92);
            this.button1.TabIndex = 6;
            this.button1.Text = "click me!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(553, 357);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(44, 16);
            this.count.TabIndex = 7;
            this.count.Text = "label3";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(12, 246);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(37, 16);
            this.lastName.TabIndex = 9;
            this.lastName.Text = "label";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(55, 162);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(143, 22);
            this.txtUsername.TabIndex = 10;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(55, 246);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(143, 22);
            this.txtLastName.TabIndex = 11;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(55, 204);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(143, 22);
            this.txtFirstName.TabIndex = 12;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 499);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.count);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.headingContainer);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.headingContainer.ResumeLayout(false);
            this.headingContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox headingContainer;
        private System.Windows.Forms.Label Heading1;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
    }
}