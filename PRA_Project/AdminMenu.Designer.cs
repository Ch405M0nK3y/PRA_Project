namespace PRA_Project
{
    partial class AdminMenu
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
            pbLogo = new PictureBox();
            btnAddClass = new Button();
            btnAddLecturer = new Button();
            btnAddNews = new Button();
            lblWelcome = new Label();
            lbName = new Label();
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
            pbLogo.TabIndex = 10;
            pbLogo.TabStop = false;
            // 
            // btnAddClass
            // 
            btnAddClass.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddClass.Location = new Point(412, 293);
            btnAddClass.Name = "btnAddClass";
            btnAddClass.Size = new Size(322, 37);
            btnAddClass.TabIndex = 12;
            btnAddClass.Text = "Add Class";
            btnAddClass.UseVisualStyleBackColor = true;
            btnAddClass.Click += btnAddClass_Click;
            // 
            // btnAddLecturer
            // 
            btnAddLecturer.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddLecturer.Location = new Point(412, 356);
            btnAddLecturer.Name = "btnAddLecturer";
            btnAddLecturer.Size = new Size(322, 37);
            btnAddLecturer.TabIndex = 13;
            btnAddLecturer.Text = "Add Lecturer";
            btnAddLecturer.UseVisualStyleBackColor = true;
            btnAddLecturer.Click += btnAddLecturer_Click;
            // 
            // btnAddNews
            // 
            btnAddNews.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddNews.Location = new Point(412, 418);
            btnAddNews.Name = "btnAddNews";
            btnAddNews.Size = new Size(322, 37);
            btnAddNews.TabIndex = 14;
            btnAddNews.Text = "Add/Edit News";
            btnAddNews.UseVisualStyleBackColor = true;
            btnAddNews.Click += btnAddNotifications_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblWelcome.Location = new Point(12, 9);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(140, 37);
            lblWelcome.TabIndex = 15;
            lblWelcome.Text = "Welcome, ";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lbName.Location = new Point(137, 9);
            lbName.Name = "lbName";
            lbName.Size = new Size(259, 37);
            lbName.TabIndex = 16;
            lbName.Text = "\"Insert admin name\"";
            // 
            // AdminMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 761);
            Controls.Add(lbName);
            Controls.Add(lblWelcome);
            Controls.Add(btnAddNews);
            Controls.Add(btnAddLecturer);
            Controls.Add(btnAddClass);
            Controls.Add(pbLogo);
            Name = "AdminMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminMenu";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogo;
        private Button btnAddClass;
        private Button btnAddLecturer;
        private Button btnAddNews;
        private Label lblWelcome;
        private Label lbName;
    }
}