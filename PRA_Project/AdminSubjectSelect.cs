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

        SubjectRepository subjectRepository = RepositoryFactory.GetSubjectRepository();
        IDictionary<int, Subject> subjectDictionary = new Dictionary<int, Subject>();

        Subject selectedSubject;

        public AdminSubjectSelect()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            subjectDictionary = subjectRepository.Load();
            foreach (Subject subject in subjectDictionary.Values)
            {
                cbSubjects.Items.Add(subject.Name);
            }
            cbSubjects.SelectedIndex = 0;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
           selectedSubject = subjectDictionary[cbSubjects.SelectedIndex];
            Thread newThread = new Thread(CreateNewNotificationView);
            newThread.Start();
        }

        private void CreateNewNotificationView()
        {
            Form newForm = new NotificationView(selectedSubject);
            Application.Run(newForm);
        }
    }
}
