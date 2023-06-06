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
        public AdminNewsClassSelect()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void AdminNewsClassSelect_Load(object sender, EventArgs e)
        {
            /*
             * Rework the following to work with IDictionary and fill subjects->cbClassSelect and 
             * fill Notifications->cbNews + "Add news"
             * 
            SubjectRepository service = new();

            try
            {
                List<Subject> subject = service.GetSubjects();
                foreach (Subject s in subject)
                {
                    ddlPlayers.Items.Add(s);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            */
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
