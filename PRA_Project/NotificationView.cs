using PRA_Project.Dal;
using PRA_Project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRA_Project
{
    public partial class NotificationView : Form
    {
        NotificationRepository notificationRepository = RepositoryFactory.GetNotificationRepository();
        IDictionary<int, Notification> notificationDictionary = new Dictionary<int, Notification>();

        public NotificationView(Subject subject)
        {
            InitializeComponent();
            notificationDictionary = notificationRepository.Load();
            ShowData(subject);
        }

        private void ShowData(Subject subject)
        {
            foreach(Notification notification in notificationDictionary.Values)
            {
                if(notification.Subject.Equals(subject))
                {
                    TableItem item = new TableItem();
                    item.lbID.Text = notification.Id.ToString();
                    item.lbValue.Text = notification.ToString();
                    flpContainer.Controls.Add(item);
                }   
            }
        }
    }
}
