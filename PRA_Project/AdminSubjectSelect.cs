using PRA_Project.Dal;
using PRA_Project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRA_Project
{
    public partial class AdminSubjectSelect : Form
    {
        private User loggedInUser;
        SubjectRepository subjectRepository = RepositoryFactory.GetSubjectRepository();
        IDictionary<int, Subject> subjectDictionary = new Dictionary<int, Subject>();

        Subject selectedSubject;

        UserRepository userRepository = RepositoryFactory.GetUserRepository();
        IDictionary<int, User> userDictionary = new Dictionary<int, User>();

        public AdminSubjectSelect()
        {
            InitializeComponent();
            Init();
        }

        public User GetLoggedInUser()
        {
            User loggedInUser = userDictionary.Values.SingleOrDefault(x=> x.Admin == true);

            return loggedInUser;
        }

        private void Init()
        {
            subjectDictionary = subjectRepository.Load();
            userDictionary = userRepository.Load();
            foreach (Subject subject in subjectDictionary.Values)
            {
                cbSubjects.Items.Add(subject.Name);
            }
            cbSubjects.SelectedIndex = 0;
            loggedInUser = GetLoggedInUser();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
           selectedSubject = subjectDictionary[cbSubjects.SelectedIndex];
            Thread newThread = new Thread(CreateNewNewsEditor);
            newThread.Start();
        }

        private void CreateNewNewsEditor()
        {
            Form newForm = new AdminNewsEdditor(selectedSubject, loggedInUser);
            Application.Run(newForm);
        }
    }
}
