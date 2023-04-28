using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graduation_project_system
{
    public partial class ViewUsersForm : Form
    {
        CR1ViewUsers cr1_viewUsers;
        public ViewUsersForm()
        {
            InitializeComponent();
        }

        private void ViewUsersForm_Load(object sender, EventArgs e)
        {
            cr1_viewUsers = new CR1ViewUsers();
            crystalReportViewer1.ReportSource = cr1_viewUsers;
        }
    }
}
