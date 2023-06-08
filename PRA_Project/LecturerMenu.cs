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
    public partial class LecturerMenu : Form
    {
        public LecturerMenu()
        {
            InitializeComponent();
        }

        NotificationRepository subjectRepository = RepositoryFactory.GetNotificationRepository();
        IDictionary<int, Notification> notificationDictionary;

        List<Notification> notificationList;

        private void LecturerMenu_Load(object sender, EventArgs e)
        {
            //Set lblLecturer and lblClass
            //Load News
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            List<Notification> notificationList = notificationDictionary.Values.ToList();
            ShowData();
        }



        private void ShowData()
        {
            flpNews.Controls.Clear();
            foreach (Notification notification in notificationList)
            {
                flpNews.Controls.Add(NotificationPanel(notification));
            }
        }



        private Control NotificationPanel(Notification notification)
        {
            FlowLayoutPanel flpNotification = new FlowLayoutPanel();
            flpNotification.Tag = notification.Id;
            flpNotification.BorderStyle = BorderStyle.FixedSingle;
            flpNotification.FlowDirection = FlowDirection.TopDown;
            flpNotification.Controls.Add(GetLabel(notification.Title));
            flpNotification.Controls.Add(GetLabel(notification.Description));
            flpNotification.Controls.Add(GetDeleteButton());
            flpNotification.Click += flpNotification_Click;
            flpNotification.Width = 900;
            return flpNotification;
        }
        private FlowLayoutPanel selectedNotification = null;
        private void flpNotification_Click(object sender, EventArgs e)
        {
            if (selectedNotification != null)
                selectedNotification.BackColor = SystemColors.Control;



            if (sender is FlowLayoutPanel)
                selectedNotification = sender as FlowLayoutPanel;
            else
                selectedNotification = (sender as Label).Parent as FlowLayoutPanel;



            selectedNotification.BackColor = Color.Aqua;



            // Get title from selected panel, add to Title textbox
            // Get desc from selected panel, add to desc textbox
        }



        private Control GetDeleteButton()
        {
            Button btn = new Button();
            btn.Text = "Delete";
            return btn;
        }



        private Control GetLabel(string labelText)
        {
            Label lbl = new Label();
            lbl.Text = labelText;
            return lbl;
        }
    }
}
