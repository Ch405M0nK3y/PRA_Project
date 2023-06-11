namespace PRA_Project
{
    partial class AdminSubjectSelect
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
            lblClass = new Label();
            btnSubmit = new Button();
            pbLogo = new PictureBox();
            cbSubjects = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblClass.Location = new Point(429, 270);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(153, 25);
            lblClass.TabIndex = 22;
            lblClass.Text = "Choose Subject:";
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.Location = new Point(506, 378);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(171, 52);
            btnSubmit.TabIndex = 20;
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
            pbLogo.TabIndex = 19;
            pbLogo.TabStop = false;
            // 
            // cbSubjects
            // 
            cbSubjects.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbSubjects.FormattingEnabled = true;
            cbSubjects.Location = new Point(429, 298);
            cbSubjects.Name = "cbSubjects";
            cbSubjects.Size = new Size(322, 33);
            cbSubjects.TabIndex = 23;
            // 
            // AdminNotificationMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 761);
            Controls.Add(cbSubjects);
            Controls.Add(lblClass);
            Controls.Add(btnSubmit);
            Controls.Add(pbLogo);
            Name = "AdminNotificationMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add/Edit Notifications";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblClass;
        private Button btnSubmit;
        private PictureBox pbLogo;
        private ComboBox cbSubjects;
    }
}