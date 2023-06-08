namespace PRA_Project
{
    partial class LecturerMenu
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
            rtbDescription = new RichTextBox();
            tbTitle = new TextBox();
            lblDescription = new Label();
            lblTitle = new Label();
            btnSubmit = new Button();
            pbLogo = new PictureBox();
            flpNews = new FlowLayoutPanel();
            lbl1 = new Label();
            lblLecturer = new Label();
            lblClass = new Label();
            lbl2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // rtbDescription
            // 
            rtbDescription.Location = new Point(434, 165);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(322, 183);
            rtbDescription.TabIndex = 39;
            rtbDescription.Text = "";
            // 
            // tbTitle
            // 
            tbTitle.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbTitle.Location = new Point(434, 71);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(322, 32);
            tbTitle.TabIndex = 38;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescription.Location = new Point(434, 137);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(119, 25);
            lblDescription.TabIndex = 37;
            lblDescription.Text = "Description:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(434, 43);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(55, 25);
            lblTitle.TabIndex = 36;
            lblTitle.Text = "Title:";
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.Location = new Point(502, 381);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(171, 52);
            btnSubmit.TabIndex = 35;
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
            pbLogo.TabIndex = 34;
            pbLogo.TabStop = false;
            // 
            // flpNews
            // 
            flpNews.Location = new Point(155, 478);
            flpNews.Name = "flpNews";
            flpNews.Size = new Size(860, 223);
            flpNews.TabIndex = 40;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1.Location = new Point(25, 32);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(94, 25);
            lbl1.TabIndex = 41;
            lbl1.Text = "Welcome,";
            // 
            // lblLecturer
            // 
            lblLecturer.AutoSize = true;
            lblLecturer.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblLecturer.Location = new Point(123, 32);
            lblLecturer.Name = "lblLecturer";
            lblLecturer.Size = new Size(195, 25);
            lblLecturer.TabIndex = 42;
            lblLecturer.Text = "\"Insert lecturer name\"";
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblClass.Location = new Point(90, 78);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(118, 25);
            lblClass.TabIndex = 44;
            lblClass.Text = "\"Insert class\"";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl2.Location = new Point(25, 78);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(59, 25);
            lbl2.TabIndex = 43;
            lbl2.Text = "Class:";
            // 
            // LecturerMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 761);
            Controls.Add(lblClass);
            Controls.Add(lbl2);
            Controls.Add(lblLecturer);
            Controls.Add(lbl1);
            Controls.Add(flpNews);
            Controls.Add(rtbDescription);
            Controls.Add(tbTitle);
            Controls.Add(lblDescription);
            Controls.Add(lblTitle);
            Controls.Add(btnSubmit);
            Controls.Add(pbLogo);
            Name = "LecturerMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LecturerMenu";
            Load += LecturerMenu_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbDescription;
        private TextBox tbTitle;
        private Label lblDescription;
        private Label lblTitle;
        private Button btnSubmit;
        private PictureBox pbLogo;
        private FlowLayoutPanel flpNews;
        private Label lbl1;
        private Label lblLecturer;
        private Label lblClass;
        private Label lbl2;
    }
}