﻿namespace PRA_Project
{
    partial class AdminLecturerView
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
            flpLecturerView = new FlowLayoutPanel();
            pbLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // flpLecturerView
            // 
            flpLecturerView.Location = new Point(138, 71);
            flpLecturerView.Name = "flpLecturerView";
            flpLecturerView.Size = new Size(900, 600);
            flpLecturerView.TabIndex = 14;
            // 
            // pbLogo
            // 
            pbLogo.BackgroundImage = Properties.Resources.doggo;
            pbLogo.BackgroundImageLayout = ImageLayout.Stretch;
            pbLogo.Location = new Point(12, 629);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(120, 120);
            pbLogo.TabIndex = 13;
            pbLogo.TabStop = false;
            // 
            // AdminLecturerView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 761);
            Controls.Add(flpLecturerView);
            Controls.Add(pbLogo);
            Name = "AdminLecturerView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminLecturerView";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpLecturerView;
        private PictureBox pbLogo;
    }
}