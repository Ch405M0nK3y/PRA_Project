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

        SubjectRepository subjectRepository = RepositoryFactory.GetSubjectRepository();
        IDictionary<int, Subject> subjectDictionary = new Dictionary<int, Subject>();
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
            subjectDictionary = subjectRepository.Load();
            foreach (User user in userDictionary.Values)
            {

                if (!user.Admin)
                {
                    Lecturer lecturer = user as Lecturer;
                    lecturer.Subject = subjectDictionary.Values.SingleOrDefault(x => x.Name.Equals(lecturer.Subject.Name));
                    TableItem tableItem = new TableItem();
                    tableItem.lbID.Text = user.Id.ToString();
                    tableItem.lbValue.Text = user.ToString();
                    flpContainer.Controls.Add(tableItem);
                    


                }
            }
        }

    }




}
