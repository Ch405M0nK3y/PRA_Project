namespace PRA_Project
{
    partial class NotificationView
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
            flpContainer = new FlowLayoutPanel();
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
            pbLogo.TabIndex = 12;
            pbLogo.TabStop = false;
            // 
            // flpContainer
            // 
            flpContainer.AutoScroll = true;
            flpContainer.FlowDirection = FlowDirection.TopDown;
            flpContainer.Location = new Point(138, 66);
            flpContainer.Name = "flpContainer";
            flpContainer.Size = new Size(1034, 683);
            flpContainer.TabIndex = 13;
            flpContainer.WrapContents = false;
            // 
            // NotificationView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 761);
            Controls.Add(flpContainer);
            Controls.Add(pbLogo);
            Name = "NotificationView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NotificationView";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbLogo;
        private FlowLayoutPanel flpContainer;
    }
}