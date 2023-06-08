namespace PRA_Project
{
    partial class AdminLecturerAdd
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
            btnSubmit = new Button();
            pbLogo = new PictureBox();
            tbFirstName = new TextBox();
            lblLectFirstName = new Label();
            lblLecLastName = new Label();
            tbLastName = new TextBox();
            lblLecClass = new Label();
            lblLecEmail = new Label();
            tbEmail = new TextBox();
            lblLecPassword = new Label();
            tbPassword = new TextBox();
            btnViewAll = new Button();
            cbSubject = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.Location = new Point(459, 521);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(219, 37);
            btnSubmit.TabIndex = 16;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // pbLogo
            // 
            pbLogo.BackgroundImage = Properties.Resources.doggo;
            pbLogo.BackgroundImageLayout = ImageLayout.Stretch;
            pbLogo.Location = new Point(12, 629);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(120, 120);
            pbLogo.TabIndex = 15;
            pbLogo.TabStop = false;
            // 
            // tbFirstName
            // 
            tbFirstName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbFirstName.Location = new Point(359, 146);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(409, 32);
            tbFirstName.TabIndex = 17;
            // 
            // lblLectFirstName
            // 
            lblLectFirstName.AutoSize = true;
            lblLectFirstName.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblLectFirstName.Location = new Point(359, 118);
            lblLectFirstName.Name = "lblLectFirstName";
            lblLectFirstName.Size = new Size(109, 25);
            lblLectFirstName.TabIndex = 18;
            lblLectFirstName.Text = "First name:";
            // 
            // lblLecLastName
            // 
            lblLecLastName.AutoSize = true;
            lblLecLastName.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblLecLastName.Location = new Point(359, 190);
            lblLecLastName.Name = "lblLecLastName";
            lblLecLastName.Size = new Size(106, 25);
            lblLecLastName.TabIndex = 20;
            lblLecLastName.Text = "Last name:";
            // 
            // tbLastName
            // 
            tbLastName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbLastName.Location = new Point(359, 218);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(409, 32);
            tbLastName.TabIndex = 19;
            // 
            // lblLecClass
            // 
            lblLecClass.AutoSize = true;
            lblLecClass.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblLecClass.Location = new Point(359, 265);
            lblLecClass.Name = "lblLecClass";
            lblLecClass.Size = new Size(60, 25);
            lblLecClass.TabIndex = 22;
            lblLecClass.Text = "Class:";
            // 
            // lblLecEmail
            // 
            lblLecEmail.AutoSize = true;
            lblLecEmail.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblLecEmail.Location = new Point(359, 342);
            lblLecEmail.Name = "lblLecEmail";
            lblLecEmail.Size = new Size(64, 25);
            lblLecEmail.TabIndex = 24;
            lblLecEmail.Text = "Email:";
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbEmail.Location = new Point(359, 370);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(409, 32);
            tbEmail.TabIndex = 23;
            // 
            // lblLecPassword
            // 
            lblLecPassword.AutoSize = true;
            lblLecPassword.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblLecPassword.Location = new Point(359, 423);
            lblLecPassword.Name = "lblLecPassword";
            lblLecPassword.Size = new Size(102, 25);
            lblLecPassword.TabIndex = 26;
            lblLecPassword.Text = "Password:";
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbPassword.Location = new Point(359, 451);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(409, 32);
            tbPassword.TabIndex = 25;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // btnViewAll
            // 
            btnViewAll.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewAll.Location = new Point(896, 668);
            btnViewAll.Name = "btnViewAll";
            btnViewAll.Size = new Size(219, 37);
            btnViewAll.TabIndex = 27;
            btnViewAll.Text = "View All";
            btnViewAll.UseVisualStyleBackColor = true;
            btnViewAll.Click += btnViewAll_Click;
            // 
            // cbSubject
            // 
            cbSubject.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbSubject.FormattingEnabled = true;
            cbSubject.Location = new Point(359, 293);
            cbSubject.Name = "cbSubject";
            cbSubject.Size = new Size(409, 33);
            cbSubject.TabIndex = 28;
            // 
            // AdminLecturerAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 761);
            Controls.Add(cbSubject);
            Controls.Add(btnViewAll);
            Controls.Add(lblLecPassword);
            Controls.Add(tbPassword);
            Controls.Add(lblLecEmail);
            Controls.Add(tbEmail);
            Controls.Add(lblLecClass);
            Controls.Add(lblLecLastName);
            Controls.Add(tbLastName);
            Controls.Add(lblLectFirstName);
            Controls.Add(tbFirstName);
            Controls.Add(btnSubmit);
            Controls.Add(pbLogo);
            Name = "AdminLecturerAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminLecturerAdd";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
        private PictureBox pbLogo;
        private TextBox tbFirstName;
        private Label lblLectFirstName;
        private Label lblLecLastName;
        private TextBox tbLastName;
        private Label lblLecClass;
        private Label lblLecEmail;
        private TextBox tbEmail;
        private Label lblLecPassword;
        private TextBox tbPassword;
        private Button btnViewAll;
        private ComboBox cbSubject;
    }
}