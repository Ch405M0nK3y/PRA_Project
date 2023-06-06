namespace PRA_Project
{
    partial class AdminClassAdd
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
            btnSubmitClass = new Button();
            btnViewAllClasses = new Button();
            lblClass = new Label();
            tbClassName = new TextBox();
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
            pbLogo.TabIndex = 11;
            pbLogo.TabStop = false;
            // 
            // btnSubmitClass
            // 
            btnSubmitClass.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmitClass.Location = new Point(503, 403);
            btnSubmitClass.Name = "btnSubmitClass";
            btnSubmitClass.Size = new Size(171, 52);
            btnSubmitClass.TabIndex = 15;
            btnSubmitClass.Text = "Submit";
            btnSubmitClass.UseVisualStyleBackColor = true;
            btnSubmitClass.Click += btnSubmitClass_Click;
            // 
            // btnViewAllClasses
            // 
            btnViewAllClasses.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewAllClasses.Location = new Point(897, 629);
            btnViewAllClasses.Name = "btnViewAllClasses";
            btnViewAllClasses.Size = new Size(171, 52);
            btnViewAllClasses.TabIndex = 16;
            btnViewAllClasses.Text = "View All";
            btnViewAllClasses.UseVisualStyleBackColor = true;
            btnViewAllClasses.Click += btnViewAllClasses_Click;
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblClass.Location = new Point(429, 270);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(114, 25);
            lblClass.TabIndex = 18;
            lblClass.Text = "Class name:";
            // 
            // tbClassName
            // 
            tbClassName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbClassName.Location = new Point(429, 298);
            tbClassName.Name = "tbClassName";
            tbClassName.Size = new Size(322, 32);
            tbClassName.TabIndex = 17;
            // 
            // AdminClassAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 761);
            Controls.Add(lblClass);
            Controls.Add(tbClassName);
            Controls.Add(btnViewAllClasses);
            Controls.Add(btnSubmitClass);
            Controls.Add(pbLogo);
            Name = "AdminClassAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminAddClass";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogo;
        private Button btnSubmitClass;
        private Button btnViewAllClasses;
        private Label lblClass;
        private TextBox tbClassName;
    }
}