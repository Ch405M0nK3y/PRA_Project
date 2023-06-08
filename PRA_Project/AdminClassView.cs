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
    public partial class AdminClassView : Form
    {

        public AdminClassView()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
           // List<Subject> subjectList = subjectDictionary.ToList();
            ShowData();
        }

        private void ShowData()
        {
            flpClassView.Controls.Clear();
            //foreach (Subject subject in subjectList)
            //{
            //    flpClassView.Controls.Add(SubjectPanel(subject));
            //}
        }

        private Control SubjectPanel(Subject subject)
        {
            FlowLayoutPanel flpSubject = new FlowLayoutPanel();
            flpSubject.Tag = subject.Id;
            flpSubject.BorderStyle = BorderStyle.FixedSingle;
            flpSubject.FlowDirection = FlowDirection.TopDown;
            flpSubject.Controls.Add(GetLabel(subject.Name));
            flpSubject.Width = 900;
            return flpSubject;
        }

        private Control GetLabel(string labelText)
        {
            Label lbl = new Label();
            lbl.Text = labelText;
            return lbl;
        }
    }
}