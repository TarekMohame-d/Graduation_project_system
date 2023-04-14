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
        String studentName, teamId, teamLeader;

        public StudentForm(string studentName, string teamId, string teamLeader)
        {
            InitializeComponent();
            this.studentName = studentName;
            this.teamId = teamId;
            this.teamLeader = teamLeader;
            label2.Text = studentName;
            label3.Text = teamId;
            label5.Text = teamLeader;
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
