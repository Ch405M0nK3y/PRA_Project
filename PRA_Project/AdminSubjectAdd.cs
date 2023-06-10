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
            dictionary = new Dictionary<int, Subject>();
            dictionary = subjectRepository.Load();
        }

        SubjectRepository subjectRepository = RepositoryFactory.GetSubjectRepository();
        IDictionary<int, Subject> dictionary;
        
        
        

        private void btnSubmitClass_Click(object sender, EventArgs e)
        {
            Subject sub = new Subject(tbClassName.Text);
            dictionary.Add(sub.Id, sub);
            tbClassName.Text = "";
            subjectRepository.Save(dictionary);
            MessageBox.Show("Successfully submitted!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
