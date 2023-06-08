namespace PRA_Project
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbLogo = new PictureBox();
            tbUsername = new TextBox();
            lblUsername = new Label();
            lblPassword = new Label();
            tbPassword = new TextBox();
            btnLogin = new Button();
            lblError = new Label();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.BackgroundImage = Properties.Resources.doggo;
            pbLogo.BackgroundImageLayout = ImageLayout.Stretch;
            pbLogo.Location = new Point(12, 629);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(120, 120);
            pbLogo.TabIndex = 9;
            pbLogo.TabStop = false;
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbUsername.Location = new Point(403, 318);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(322, 32);
            tbUsername.TabIndex = 10;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.Location = new Point(403, 290);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(106, 25);
            lblUsername.TabIndex = 11;
            lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.Location = new Point(403, 385);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(102, 25);
            lblPassword.TabIndex = 13;
            lblPassword.Text = "Password:";
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbPassword.Location = new Point(403, 413);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '^';
            tbPassword.Size = new Size(322, 32);
            tbPassword.TabIndex = 12;
            tbPassword.UseSystemPasswordChar = true;
            tbPassword.KeyDown += tbPassword_KeyDown;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(474, 485);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(171, 52);
            btnLogin.TabIndex = 14;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.BackColor = Color.Red;
            lblError.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblError.Location = new Point(439, 215);
            lblError.Name = "lblError";
            lblError.Size = new Size(251, 37);
            lblError.TabIndex = 15;
            lblError.Text = "! Invalid Credentials";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 761);
            Controls.Add(lblError);
            Controls.Add(btnLogin);
            Controls.Add(lblPassword);
            Controls.Add(tbPassword);
            Controls.Add(lblUsername);
            Controls.Add(tbUsername);
            Controls.Add(pbLogo);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogo;
        private TextBox tbUsername;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox tbPassword;
        private Button btnLogin;
        private Label lblError;
    }
}