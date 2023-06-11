namespace PRA_Project
{
    partial class AdminNewsEdditor
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
            lblDescription = new Label();
            lblTitle = new Label();
            btnSubmit = new Button();
            pbLogo = new PictureBox();
            tbTitle = new TextBox();
            rtbDescription = new RichTextBox();
            btnViewAll = new Button();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescription.Location = new Point(435, 248);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(119, 25);
            lblDescription.TabIndex = 30;
            lblDescription.Text = "Description:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(435, 169);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(55, 25);
            lblTitle.TabIndex = 28;
            lblTitle.Text = "Title:";
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.Location = new Point(515, 478);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(171, 52);
            btnSubmit.TabIndex = 27;
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
            pbLogo.TabIndex = 26;
            pbLogo.TabStop = false;
            // 
            // tbTitle
            // 
            tbTitle.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbTitle.Location = new Point(435, 197);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(322, 32);
            tbTitle.TabIndex = 32;
            // 
            // rtbDescription
            // 
            rtbDescription.Location = new Point(435, 276);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(322, 183);
            rtbDescription.TabIndex = 33;
            rtbDescription.Text = "";
            // 
            // btnViewAll
            // 
            btnViewAll.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewAll.Location = new Point(1001, 697);
            btnViewAll.Name = "btnViewAll";
            btnViewAll.Size = new Size(171, 52);
            btnViewAll.TabIndex = 36;
            btnViewAll.Text = "View all";
            btnViewAll.UseVisualStyleBackColor = true;
            btnViewAll.Click += btnViewAll_Click;
            // 
            // AdminNewsEdditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 761);
            Controls.Add(btnViewAll);
            Controls.Add(rtbDescription);
            Controls.Add(tbTitle);
            Controls.Add(lblDescription);
            Controls.Add(lblTitle);
            Controls.Add(btnSubmit);
            Controls.Add(pbLogo);
            Name = "AdminNewsEdditor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminNewsEdditor";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDescription;
        private Label lblTitle;
        private Button btnSubmit;
        private PictureBox pbLogo;
        private TextBox tbTitle;
        private RichTextBox rtbDescription;
        private Button btnViewAll;
    }
}