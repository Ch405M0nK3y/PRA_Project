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
    public partial class AdminMenu : Form
    {
        User loggedInUser;
        public AdminMenu()
        {
            InitializeComponent();
        }

        public AdminMenu(User user)
        {
            InitializeComponent();
            this.loggedInUser = user;
            lbName.Text = user.FirstName + " " + user.LastName;
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            Thread newThread = new Thread(CreateNewAddSubjectForm);
            newThread.Start();
            
        }

        
        private void CreateNewAddSubjectForm()
        {
            Form newForm = new AdminSubjectAdd();

            Application.Run(newForm);
        }


        private void btnAddLecturer_Click(object sender, EventArgs e)
        {
            Thread newThread = new Thread(CreateNewAddLecturerForm);
            newThread.Start();
        }
        private void CreateNewAddLecturerForm()
        {
            Form newForm = new AdminLecturerAdd();

            Application.Run(newForm);
        }
        private void btnAddNotifications_Click(object sender, EventArgs e)
        {
            Thread newThread = new Thread(CreateNewAddNotificationsForm);
            newThread.Start();
        }

        private void CreateNewAddNotificationsForm()
        {
            Form newForm = new AdminNewsClassSelect();

            Application.Run(newForm);
        }
    }
}
