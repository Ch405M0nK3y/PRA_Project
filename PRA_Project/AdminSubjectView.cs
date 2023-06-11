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

        Subject subject;
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
                if (!subject.IsDeleted)
                {
                    TableItem tableItem = new TableItem();
                    tableItem.lbID.Text = subject.Id.ToString();
                    tableItem.Tag = subject;
                    tableItem.lbValue.Text = subject.Name;
                    tableItem.btnDelete.Visible = true;
                    tableItem.btnEdit.Visible = true;
                    tableItem.btnEdit.Click += BtnEdit_Click;
                    tableItem.btnDelete.Click += BtnDelete_Click;
                    flpContainer.Controls.Add(tableItem);
                }
            }
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Button btnDelete = sender as Button;

            TableItem item = btnDelete.Parent.Parent.Parent as TableItem;

            item.Visible = false;
            subject = subjectDictionary.Values.SingleOrDefault(x => x.Equals(item.Tag));
            subject.Delete();
            subjectRepository.Save(subjectDictionary);
        }

        private void BtnEdit_Click(object? sender, EventArgs e)
        {
            Button btnEdit = sender as Button;
            TableItem item = btnEdit.Parent.Parent.Parent as TableItem;
            subject = subjectDictionary.Values.SingleOrDefault(x => x.Equals(item.Tag));
            Thread newThread = new Thread(CreateNewSubjectEditor);
            newThread.Start();
            this.Close();
        }

        private void CreateNewSubjectEditor()
        {
            Form newForm = new AdminSubjectAdd(subject);
            Application.Run(newForm);
        }
    }
}