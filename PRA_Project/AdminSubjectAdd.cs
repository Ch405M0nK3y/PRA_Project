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
    public partial class AdminSubjectAdd : Form
    {
        public AdminSubjectAdd()
        {
            InitializeComponent();
            subjectDictionary = new Dictionary<int, Subject>();
            subjectDictionary = subjectRepository.Load();
        }

        SubjectRepository subjectRepository = RepositoryFactory.GetSubjectRepository();
        IDictionary<int, Subject> subjectDictionary;
        private Subject subject;
        
        public AdminSubjectAdd(Subject subject)
        {
            InitializeComponent();
            subjectDictionary = new Dictionary<int, Subject>();
            subjectDictionary = subjectRepository.Load();
            this.subject = subject;
            InitializeEditing();
        }

        private void InitializeEditing()
        {
            btnSubmitClass.Text = "Submit changes";
            btnViewAllClasses.Visible = false;
        }

        private void btnSubmitClass_Click(object sender, EventArgs e)
        {
            if(tbClassName.Text!= null && btnSubmitClass.Text.Equals("Submit"))
            {
                Subject sub = new Subject(tbClassName.Text, false);
                subjectDictionary.Add(sub.Id, sub);
                tbClassName.Text = "";
                subjectRepository.Save(subjectDictionary);
                MessageBox.Show("Successfully submitted!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if(tbClassName.Text!= null)
            {
                subject.Name = tbClassName.Text;
                subjectDictionary.Remove(subject.Id);
                subjectDictionary.Add(subject.Id, subject);
                subjectRepository.Save(subjectDictionary);
                MessageBox.Show($"Succesfully updated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

                Thread newThread = new Thread(CreateNewSubjectView);
                newThread.Start();
            }

        }
        private void CreateNewSubjectView()
        {
            Form newForm = new AdminSubjectView();
            Application.Run(newForm);
        }

        private void btnViewAllClasses_Click(object sender, EventArgs e)
        {
            Thread newThread = new Thread(CreateNewClassViewForm);
            newThread.Start();
        }
        private void CreateNewClassViewForm()
        {
            Form newForm = new AdminSubjectView();
            Application.Run(newForm);
        }

    }
}
