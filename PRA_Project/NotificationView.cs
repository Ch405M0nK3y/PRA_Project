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
    public partial class NotificationView : Form
    {

        NotificationRepository notificationRepository = RepositoryFactory.GetNotificationRepository();
        IDictionary<int, Notification> notificationDictionary = new Dictionary<int, Notification>();

        SubjectRepository subjectRepository = RepositoryFactory.GetSubjectRepository();
        IDictionary<int, Subject> subjectDictionary = new Dictionary<int, Subject>();
        private Subject subject;
        Notification notification;

        public NotificationView(Subject subject)
        {
            InitializeComponent();
            notificationDictionary = notificationRepository.Load();
            subjectDictionary = subjectRepository.Load();
            this.subject = subject;
            ShowData(subject);

        }
        public void ReloadWindow()
        {
            this.ReloadWindow();
        }
        private void ShowData(Subject subject)
        {
            foreach (Notification notification in notificationDictionary.Values)
            {
                if (notification.Subject.Equals(subject) && !notification.IsDeleted)
                {
                    TableItem item = new TableItem();
                    item.Tag = notification;
                    item.lbID.Text = notification.Id.ToString();
                    item.lbValue.Text = notification.ToString();
                    item.btnEdit.Click += BtnEdit_Click;
                    item.btnDelete.Click += BtnDelete_Click;
                    flpContainer.Controls.Add(item);
                }
            }
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Button btnDelete = sender as Button;

            TableItem item = btnDelete.Parent.Parent.Parent as TableItem;

            item.Visible = false;
            notification = notificationDictionary.Values.SingleOrDefault(x => x.Equals(item.Tag));
            notification.Delete();
            notificationRepository.Save(notificationDictionary);
        }

        private void BtnEdit_Click(object? sender, EventArgs e)
        {
            Button btnEdit = sender as Button;
            TableItem item = btnEdit.Parent.Parent.Parent as TableItem;
            notification = notificationDictionary.Values.SingleOrDefault(x => x.Equals(item.Tag));
            Thread newThread = new Thread(CreateNewNewsEditor);
            newThread.Start();
            this.Close();
        }

        private void CreateNewNewsEditor()
        {
            Form newForm = new AdminNewsEdditor(notification, subject, this);
            Application.Run(newForm);
        }


    }
}
