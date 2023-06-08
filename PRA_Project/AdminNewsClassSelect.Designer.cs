namespace PRA_Project
{
    partial class AdminNewsClassSelect
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
            cbClassSelect = new ComboBox();
            cbNews = new ComboBox();
            lblNews = new Label();
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
            btnSubmit.Location = new Point(503, 449);
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
            // cbClassSelect
            // 
            cbClassSelect.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbClassSelect.FormattingEnabled = true;
            cbClassSelect.Location = new Point(429, 298);
            cbClassSelect.Name = "cbClassSelect";
            cbClassSelect.Size = new Size(322, 33);
            cbClassSelect.TabIndex = 23;
            // 
            // cbNews
            // 
            cbNews.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbNews.FormattingEnabled = true;
            cbNews.Location = new Point(429, 374);
            cbNews.Name = "cbNews";
            cbNews.Size = new Size(322, 33);
            cbNews.TabIndex = 25;
            // 
            // lblNews
            // 
            lblNews.AutoSize = true;
            lblNews.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblNews.Location = new Point(429, 346);
            lblNews.Name = "lblNews";
            lblNews.Size = new Size(193, 25);
            lblNews.TabIndex = 24;
            lblNews.Text = "Choose Notification:";
            lblNews.Click += label1_Click;
            // 
            // AdminNewsClassSelect
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 761);
            Controls.Add(cbNews);
            Controls.Add(lblNews);
            Controls.Add(cbClassSelect);
            Controls.Add(lblClass);
            Controls.Add(btnSubmit);
            Controls.Add(pbLogo);
            Name = "AdminNewsClassSelect";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add/Edit Notifications";
            Load += AdminNewsClassSelect_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblClass;
        private Button btnSubmit;
        private PictureBox pbLogo;
        private ComboBox cbClassSelect;
        private ComboBox cbNews;
        private Label lblNews;
    }
}