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
    public partial class AdminNewsClassSelect : Form
    {
        SubjectRepository subjectRepository = RepositoryFactory.GetSubjectRepository();
        IDictionary<int, Subject> subjectDictionary = new Dictionary<int, Subject>();
        
        List<TextBox> inputControls = new List<TextBox>();
        public AdminNewsClassSelect()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void AdminNewsClassSelect_Load(object sender, EventArgs e)
        {
            subjectDictionary = subjectRepository.Load();
            foreach (Subject subject in subjectDictionary.Values)
            {
                cbClassSelect.Items.Add(subject.Name);
            }
            cbClassSelect.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
