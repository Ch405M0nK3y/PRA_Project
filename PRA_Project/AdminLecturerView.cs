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

        User user;
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
                    if (!user.IsDeleted)
                    {
                        Lecturer lecturer = user as Lecturer;
                        TableItem tableItem = new TableItem();
                        tableItem.lbID.Text = lecturer.Id.ToString();
                        tableItem.lbValue.Text = lecturer.ToString();
                        tableItem.btnDelete.Visible = true;
                        tableItem.btnEdit.Visible = true;
                        tableItem.btnEdit.Click += BtnEdit_Click;
                        tableItem.btnDelete.Click += BtnDelete_Click;
                        tableItem.Tag = user;
                        flpContainer.Controls.Add(tableItem);
                    }
                }
            }
        }
        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Button btnDelete = sender as Button;

            TableItem item = btnDelete.Parent.Parent.Parent as TableItem;
            
            item.Visible = false;
            User user = item.Tag as User;
            user = userDictionary.Values.SingleOrDefault(x => x.Email.Equals(user.Email));
            user.Delete();
            userRepository.Save(userDictionary);
        }

        private void BtnEdit_Click(object? sender, EventArgs e)
        {
            Button btnEdit = sender as Button;
            TableItem item = btnEdit.Parent.Parent.Parent as TableItem;
            user = userDictionary.Values.SingleOrDefault(x => x.Equals(item.Tag));
            Thread newThread = new Thread(CreateNewSubjectEditor);
            newThread.Start();
            this.Close();
        }

        private void CreateNewSubjectEditor()
        {
            Form newForm = new AdminLecturerAdd(user);
            Application.Run(newForm);
        }

    }




}
