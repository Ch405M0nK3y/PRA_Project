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
    public partial class TableItem : UserControl
    {
        public TableItem()
        {
            InitializeComponent();
            this.BackColor = Color.Salmon;
            lbID.Font = new Font("Comic Sans MS", 13, FontStyle.Bold);
            lbValue.Font = new Font("Comic Sans MS", 13, FontStyle.Bold);
        }


    }
}
