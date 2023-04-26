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
    public partial class StudentForm : Form
    {
        Users user;
        public StudentForm(Users user)
        {
            InitializeComponent();
            label2.Text = user.userName;
            label3.Text = user.userID;
        }

        private void StudentForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.Black, 0, 40, 1600, 40);
            e.Graphics.DrawLine(Pens.Black, 0, 0, 1600, 0);
            e.Graphics.DrawLine(Pens.Black, 960, 0, 960, 40);
        }
        private void StudentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
