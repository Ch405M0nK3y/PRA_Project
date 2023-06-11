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
    public partial class AdminSubjectView : Form
    {
        SubjectRepository subjectRepository = RepositoryFactory.GetSubjectRepository();
        IDictionary<int, Subject> subjectDictionary = new Dictionary<int, Subject>();
        public AdminSubjectView()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            subjectDictionary = subjectRepository.Load();
            ShowData();
        }

        private void ShowData()
        {
            foreach (Subject subject in subjectDictionary.Values)
            {
                TableItem tableItem = new TableItem();
                tableItem.lbID.Text = subject.Id.ToString();
                tableItem.lbValue.Text = subject.Name;
                flpContainer.Controls.Add(tableItem);

            }
        }

    }
}