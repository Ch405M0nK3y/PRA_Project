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
using System.Xml.Linq;

namespace PRA_Project
{
    public partial class AdminLecturerView : Form
    {
        UserRepository userRepository = RepositoryFactory.GetUserRepository();
        IDictionary<int, User> userDictionary = new Dictionary<int, User>();
        public AdminLecturerView()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            userDictionary = userRepository.Load();
            ShowData();
        }

        private void ShowData()
        {
            foreach (User user in userDictionary.Values)
            {
                if (!user.Admin)
                {
                    Lecturer lecturer = user as Lecturer;
                    TableItem tableItem = new TableItem();
                    tableItem.lbID.Text = lecturer.Id.ToString();
                    tableItem.lbValue.Text = lecturer.ToString();
                    flpContainer.Controls.Add(tableItem);
                }
            }
        }

    }




}
