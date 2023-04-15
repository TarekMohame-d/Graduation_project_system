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
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
        }

        private void buttonColorChange(Button activeButton, Button btn2, Button btn3, Button btn4, Button btn5)
        {
            activeButton.BackColor = Color.FromArgb(0, 122, 204);
            btn2.BackColor = Color.FromArgb(28, 28, 28);
            btn3.BackColor = Color.FromArgb(28, 28, 28);
            btn4.BackColor = Color.FromArgb(28, 28, 28);
            btn5.BackColor = Color.FromArgb(28, 28, 28);
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            buttonColorChange(add_btn, edit_btn, delete_btn, viewAllUsers_btn, logout_btn);
            addUser_panel.Visible = true;
            editUser_panel.Visible = false;
            deleteUser_panel.Visible = false;
            viewUser_panel.Visible = false;
            logout_panel.Visible = false;
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            buttonColorChange(edit_btn, add_btn, delete_btn, viewAllUsers_btn, logout_btn);
            addUser_panel.Visible = false;
            editUser_panel.Visible = true;
            deleteUser_panel.Visible = false;
            viewUser_panel.Visible = false;
            logout_panel.Visible = false;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            buttonColorChange(delete_btn, edit_btn, add_btn, viewAllUsers_btn, logout_btn);
            addUser_panel.Visible = false;
            editUser_panel.Visible = false;
            deleteUser_panel.Visible = true;
            viewUser_panel.Visible = false;
            logout_panel.Visible = false;
        }

        private void viewAllUsers_btn_Click(object sender, EventArgs e)
        {
            buttonColorChange(viewAllUsers_btn, edit_btn, add_btn, delete_btn, logout_btn);
            addUser_panel.Visible = false;
            editUser_panel.Visible = false;
            deleteUser_panel.Visible = false;
            viewUser_panel.Visible = true;
            logout_panel.Visible = false;
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            buttonColorChange(logout_btn, edit_btn, add_btn, delete_btn, viewAllUsers_btn);
            addUser_panel.Visible = false;
            editUser_panel.Visible = false;
            deleteUser_panel.Visible = false;
            viewUser_panel.Visible = false;
            logout_panel.Visible = true;
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            buttonColorChange(add_btn, edit_btn, delete_btn, viewAllUsers_btn, logout_btn);
            addUser_panel.Visible = true;
            editUser_panel.Visible = false;
            deleteUser_panel.Visible = false;
            viewUser_panel.Visible = false;
            logout_panel.Visible = false;
        }

        private void AdminDashboardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
