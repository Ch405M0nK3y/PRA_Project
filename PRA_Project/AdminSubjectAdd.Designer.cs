namespace PRA_Project
{
    partial class AdminSubjectAdd
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
            pbLogo = new System.Windows.Forms.PictureBox();
            btnSubmitClass = new System.Windows.Forms.Button();
            btnViewAllClasses = new System.Windows.Forms.Button();
            lblClass = new System.Windows.Forms.Label();
            tbClassName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.BackgroundImage = PRA_Project.Properties.Resources.doggo;
            pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pbLogo.Location = new System.Drawing.Point(12, 629);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new System.Drawing.Size(120, 120);
            pbLogo.TabIndex = 11;
            pbLogo.TabStop = false;
            // 
            // btnSubmitClass
            // 
            btnSubmitClass.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSubmitClass.Location = new System.Drawing.Point(503, 403);
            btnSubmitClass.Name = "btnSubmitClass";
            btnSubmitClass.Size = new System.Drawing.Size(171, 52);
            btnSubmitClass.TabIndex = 15;
            btnSubmitClass.Text = "Submit";
            btnSubmitClass.UseVisualStyleBackColor = true;
            btnSubmitClass.Click += this.btnSubmitClass_Click;
            // 
            // btnViewAllClasses
            // 
            btnViewAllClasses.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnViewAllClasses.Location = new System.Drawing.Point(897, 629);
            btnViewAllClasses.Name = "btnViewAllClasses";
            btnViewAllClasses.Size = new System.Drawing.Size(171, 52);
            btnViewAllClasses.TabIndex = 16;
            btnViewAllClasses.Text = "View All";
            btnViewAllClasses.UseVisualStyleBackColor = true;
            btnViewAllClasses.Click += this.btnViewAllClasses_Click;
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblClass.Location = new System.Drawing.Point(429, 270);
            lblClass.Name = "lblClass";
            lblClass.Size = new System.Drawing.Size(114, 25);
            lblClass.TabIndex = 18;
            lblClass.Text = "Class name:";
            // 
            // tbClassName
            // 
            tbClassName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tbClassName.Location = new System.Drawing.Point(429, 298);
            tbClassName.Name = "tbClassName";
            tbClassName.Size = new System.Drawing.Size(322, 32);
            tbClassName.TabIndex = 17;
            // 
            // AdminSubjectAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(lblClass);
            this.Controls.Add(tbClassName);
            this.Controls.Add(btnViewAllClasses);
            this.Controls.Add(btnSubmitClass);
            this.Controls.Add(pbLogo);
            this.Name = "AdminSubjectAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Add Subject";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private PictureBox pbLogo;
        private Button btnSubmitClass;
        private Button btnViewAllClasses;
        private Label lblClass;
        private TextBox tbClassName;
    }
}