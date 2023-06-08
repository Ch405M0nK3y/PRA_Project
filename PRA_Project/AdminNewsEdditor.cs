using PRA_Project.Dal;
using PRA_Project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRA_Project
{
    public partial class AdminNewsEdditor : Form
    {

        private Subject subject;
        private User loggedInUser;
        

        NotificationRepository notificationRepository = RepositoryFactory.GetNotificationRepository();
        IDictionary<int, Notification> notificationDictionary = new Dictionary<int, Notification>();

        SubjectRepository subjectRepository = RepositoryFactory.GetSubjectRepository();
        IDictionary<int, Subject> subjectDictionary = new Dictionary<int, Subject>();

        List<Control> inputControls = new List<Control>();

        Notification notificationEdited;
        NotificationView parentForm;

        public AdminNewsEdditor(Subject subject, User loggedInUser)
        {
            InitializeComponent();
            this.subject = subject;
            this.loggedInUser = loggedInUser;
            
            Init();
        }

        public AdminNewsEdditor(Notification notification, Subject subject, NotificationView view)
        {
            InitializeComponent();
            InitializeEditing(notification);
            this.subject = subject;
            notificationEdited = notification;
            parentForm = view;
        }
        
        public void InitializeEditing(Notification notification)
        {
            notificationDictionary = notificationRepository.Load();
            tbTitle.Text = notification.Title;
            rtbDescription.Text = notification.Description;
            btnSubmit.Text = "Submit changes";
            btnViewAll.Visible = false;
        }

        private void Init()
        {
            notificationDictionary = notificationRepository.Load();
            subjectDictionary = subjectRepository.Load();
            foreach (Control item in this.Controls)
            {
                if (item is TextBox || item is RichTextBox) inputControls.Add(item as TextBox);
            }
        }



        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateFields() && btnSubmit.Text.Equals("Submit"))
            {
                CreateNewNotification();
                ClearForm();
            }
            else if (ValidateFields())
            {
                UpdateNotification();
            }
            
        }

        private void UpdateNotification()
        {
            notificationEdited.Title = tbTitle.Text;
            notificationEdited.Description = rtbDescription.Text;
            notificationEdited.DatePublished = DateTime.Now;

            notificationDictionary.Remove(notificationEdited.Id);
            notificationDictionary.Add(notificationEdited.Id, notificationEdited);
            notificationRepository.Save(notificationDictionary);
            MessageBox.Show($"Succesfully updated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            
            Thread newThread = new Thread(CreateNewEditedNotificationView);
            newThread.Start();
        }

        private void CreateNewEditedNotificationView()
        {
            Form newForm = new NotificationView(subject);
            Application.Run(newForm);
        }


        private void ClearForm()
        {
            rtbDescription.Clear();
            tbTitle.Clear();
        }

        private void CreateNewNotification()
        {
            Notification notification = new Notification(tbTitle.Text, subject, rtbDescription.Text, loggedInUser, DateTime.Now, false);

            notificationDictionary.Add(notification.Id, notification);

            notificationRepository.Save(notificationDictionary);
            MessageBox.Show($"Succesfully created!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ValidateFields()
        {
            bool success = true;
            foreach (Control control in inputControls)
            {
                if(control is TextBox textBox) 
                {
                    if (textBox.Text == null)
                    {
                        MessageBox.Show($"{textBox.Name} cannot be empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        success = false;
                    }
                    else if (textBox.Text.Contains('|'))
                    {
                        MessageBox.Show($"{textBox.Name} cannot contain character '|' ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        success = false;
                    }
                } else if(control is RichTextBox richTextBox)
                {
                    if (richTextBox.Text == null)
                    {
                        MessageBox.Show($"{richTextBox.Name} cannot be empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        success = false;
                    }
                    else if (richTextBox.Text.Contains('|'))
                    {
                        MessageBox.Show($"{richTextBox.Name} cannot contain character '|' ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        success = false;
                    }
                }

               
            }

            return success;
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            Thread newThread = new Thread(CreateNewNotificationView);
            newThread.Start();
        }

        private void CreateNewNotificationView()
        {
            Form newForm = new NotificationView(subject);
            Application.Run(newForm);
        }
    }
}
