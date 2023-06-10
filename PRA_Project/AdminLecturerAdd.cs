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
    public partial class AdminLecturerAdd : Form
    {
        SubjectRepository subjectRepository = RepositoryFactory.GetSubjectRepository();
        IDictionary<int, Subject> subjectDictionary = new Dictionary<int, Subject>();
        UserRepository userRepository = RepositoryFactory.GetUserRepository();
        IDictionary<int, User> userDictionary = new Dictionary<int, User>();


        List<TextBox> inputControls = new List<TextBox>();

        private void LoadData()
        {
            subjectDictionary = subjectRepository.Load();
            userDictionary = userRepository.Load();
            foreach (Subject subject in subjectDictionary.Values)
            {
                cbSubject.Items.Add(subject.Name);
            }
            cbSubject.SelectedIndex = 0;
        }

        public AdminLecturerAdd()
        {
            InitializeComponent();
            Init();

        }

        private void Init()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox) inputControls.Add(item as TextBox);
            }
            LoadData();
        }

        private void ValidateFields()
        {
            foreach (TextBox item in inputControls)
            {
                if (item.Text == "")
                {
                    MessageBox.Show($"{item.Name.Substring(2)} cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ValidateFields();
            Lecturer lecturer = new Lecturer(tbFirstName.Text, tbLastName.Text, tbEmail.Text, false, subjectDictionary[cbSubject.SelectedIndex], tbPassword.Text);
            userDictionary.Add(lecturer.Id, lecturer);
            userRepository.Save(userDictionary);
            MessageBox.Show("Lecturer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
        }

        private void ClearFields()
        {
            foreach (TextBox tb in inputControls)
            {
                tb.Clear();
            }
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            Thread newThread = new Thread(CreateNewAdminLecturerView);
            newThread.Start();
        }

        private void CreateNewAdminLecturerView()
        {
            Form newForm = new AdminLecturerView();

            Application.Run(newForm);
        }
    }
}
