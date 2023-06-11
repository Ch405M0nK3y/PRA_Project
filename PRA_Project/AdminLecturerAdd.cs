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
    public partial class AdminLecturerAdd : Form
    {
        SubjectRepository subjectRepository = RepositoryFactory.GetSubjectRepository();
        IDictionary<int, Subject> subjectDictionary = new Dictionary<int, Subject>();
        UserRepository userRepository = RepositoryFactory.GetUserRepository();
        IDictionary<int, User> userDictionary = new Dictionary<int, User>();
        User user;

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

        public AdminLecturerAdd(User user)
        {
            InitializeComponent();
            userDictionary = new Dictionary<int, User>();
            userDictionary = userRepository.Load();
            this.user = user;
            LoadData();
            InitializeEditing();
            
        }

        private void InitializeEditing()
        {
            btnSubmit.Text = "Submit changes";
            btnViewAll.Visible = false;
            tbFirstName.Text = user.FirstName;
            tbLastName.Text = user.LastName;
            tbEmail.Text = user.Email;
            tbPassword.Text = user.Password;
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
            if (tbFirstName.Text != null && btnSubmit.Text.Equals("Submit"))
            {
                ValidateFields();
                Lecturer lecturer = new Lecturer(tbFirstName.Text, tbLastName.Text, tbEmail.Text, false, subjectDictionary[cbSubject.SelectedIndex], tbPassword.Text, false);
                userDictionary.Add(lecturer.Id, lecturer);
                userRepository.Save(userDictionary);
                MessageBox.Show("Lecturer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            } else if(tbFirstName.Text!= null)
            {
                Lecturer lecturer = user as Lecturer;
                lecturer.FirstName = tbFirstName.Text;
                lecturer.LastName = tbLastName.Text;
                lecturer.Email = tbLastName.Text;
                lecturer.Password = tbLastName.Text;
                lecturer.Subject = subjectDictionary[cbSubject.SelectedIndex];


                userDictionary.Remove(lecturer.Id);
                userDictionary.Add(lecturer.Id, lecturer);
                userRepository.Save(userDictionary);
                MessageBox.Show($"Succesfully updated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

                Thread newThread = new Thread(CreateNewAdminLecturerView);
                newThread.Start();
            }

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
