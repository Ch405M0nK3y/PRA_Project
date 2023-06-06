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
    public partial class AdminLecturerView : Form
    {
        public AdminLecturerView()
        {
            InitializeComponent();
            LoadData();
        }


        private void LoadData()
        {
            List<Lecturer> lecturerList = lecturerDictionary.ToList();
            ShowData();
        }

        private void ShowData()
        {
            flpLecturerView.Controls.Clear();
            foreach (Lecturer lecturer in lecturerList)
            {
                flpLecturerView.Controls.Add(LecturerPanel(lecturer));
            }
        }

        private Control LecturerPanel(Lecturer lecturer)
        {
            FlowLayoutPanel flpLecturer = new FlowLayoutPanel();
            flpLecturer.Tag = lecturer.Id;
            flpLecturer.BorderStyle = BorderStyle.FixedSingle;
            flpLecturer.FlowDirection = FlowDirection.LeftToRight;
            flpLecturer.Controls.Add(GetLabel(lecturer.FirstName));
            flpLecturer.Controls.Add(GetLabel(lecturer.LastName));
            flpLecturer.Controls.Add(GetLabel(lecturer.Email));
            flpLecturer.Controls.Add(GetLabel(lecturer.Subject.Name));
            flpLecturer.Width = 900;
            return flpLecturer;
        }

        private Control GetLabel(string labelText)
        {
            Label lbl = new Label();
            lbl.Text = labelText;
            return lbl;
        }
    }
}
