namespace PRA_Project
{
    partial class AdminSubjectView
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
            pbLogo.TabIndex = 11;
            pbLogo.TabStop = false;
            // 
            // flpContainer
            // 
            flpContainer.AutoScroll = true;
            flpContainer.FlowDirection = FlowDirection.TopDown;
            flpContainer.Location = new Point(194, 85);
            flpContainer.Name = "flpContainer";
            flpContainer.Size = new Size(763, 654);
            flpContainer.TabIndex = 12;
            flpContainer.WrapContents = false;
            // 
            // AdminSubjectView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 761);
            Controls.Add(flpContainer);
            Controls.Add(pbLogo);
            Name = "AdminSubjectView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminViewClasses";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbLogo;
        private FlowLayoutPanel flpContainer;
    }
}