namespace PRA_Project
{
    partial class AccType
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
            cbAccountType = new ComboBox();
            lblChoose = new Label();
            btnSubmit = new Button();
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
            pbLogo.TabIndex = 8;
            pbLogo.TabStop = false;
            // 
            // cbAccountType
            // 
            cbAccountType.AutoCompleteCustomSource.AddRange(new string[] { "Administrator", "Lecturer" });
            cbAccountType.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            cbAccountType.FormattingEnabled = true;
            cbAccountType.Location = new Point(402, 331);
            cbAccountType.Name = "cbAccountType";
            cbAccountType.Size = new Size(322, 33);
            cbAccountType.TabIndex = 9;
            // 
            // lblChoose
            // 
            lblChoose.AutoSize = true;
            lblChoose.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblChoose.Location = new Point(418, 291);
            lblChoose.Name = "lblChoose";
            lblChoose.Size = new Size(291, 37);
            lblChoose.TabIndex = 10;
            lblChoose.Text = "Choose account type:";
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.Location = new Point(474, 408);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(171, 52);
            btnSubmit.TabIndex = 16;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // AccType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 761);
            Controls.Add(btnSubmit);
            Controls.Add(lblChoose);
            Controls.Add(cbAccountType);
            Controls.Add(pbLogo);
            Name = "AccType";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AccType";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogo;
        private ComboBox cbAccountType;
        private Label lblChoose;
        private Button btnSubmit;
    }
}