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

        private void buttonPanelItemsChange(string actionName)
        {
            switch (actionName)
            {
                case "add":
                    {
                        action_button.Text = "Add User";
                        Label_old_id.Visible = false;
                        textBox_old_id.Visible = false;
                        textBox_old_id.Text = string.Empty;
                        textBox_id.Visible = true;
                        textBox_id.Text = string.Empty;
                        textBox_email.Visible = true;
                        textBox_email.Text = string.Empty;
                        textBox_password.Visible = true;
                        textBox_password.Text = string.Empty;
                        textBox_username.Visible = true;
                        textBox_username.Text = string.Empty;
                        label_email.Visible = true;
                        label_id.Visible = true;
                        label_password.Visible = true;
                        label_user_name.Visible = true;
                        radio_group_panel.Visible = true;
                        radioBtn_student.Checked = false;
                        radioBtn_professor.Checked = false;
                        radioBtn_admin.Checked = false;
                    }
                    break;
                case "edit":
                    {
                        action_button.Text = "Edit User";
                        Label_old_id.Visible = true;
                        Label_old_id.Text = "Old ID";
                        textBox_old_id.Visible = true;
                        textBox_old_id.Text = string.Empty;
                        textBox_id.Visible = true;
                        textBox_id.Text = string.Empty;
                        textBox_email.Visible = true;
                        textBox_email.Text = string.Empty;
                        textBox_password.Visible = true;
                        textBox_password.Text = string.Empty;
                        textBox_username.Visible = true;
                        textBox_username.Text = string.Empty;
                        label_email.Visible = true;
                        label_id.Visible = true;
                        label_password.Visible = true;
                        label_user_name.Visible = true;
                        radio_group_panel.Visible = true;
                        radioBtn_student.Checked = false;
                        radioBtn_professor.Checked = false;
                        radioBtn_admin.Checked = false;
                    }
                    break;
                case "delete":
                    {
                        Label_old_id.Text = "ID";
                        action_button.Text = "Delete User";
                        textBox_old_id.Visible = true;
                        textBox_old_id.Text = string.Empty;
                        Label_old_id.Visible = true;
                        textBox_id.Visible = false;
                        textBox_id.Text = string.Empty;
                        textBox_email.Visible = false;
                        textBox_email.Text = string.Empty;
                        textBox_password.Visible = false;
                        textBox_password.Text = string.Empty;
                        textBox_username.Visible = false;
                        textBox_username.Text = string.Empty;
                        label_email.Visible = false;
                        label_id.Visible = false;
                        label_password.Visible = false;
                        label_user_name.Visible = false;
                        radio_group_panel.Visible = false;
                    }
                    break;
            }
        }

        private void buttonColorChange(Button activeButton, Button btn2, Button btn3, Button btn4, Button btn5)
        {
            activeButton.BackColor = Color.FromArgb(0, 122, 204);
            btn2.BackColor = Color.FromArgb(28, 28, 28);
            btn3.BackColor = Color.FromArgb(28, 28, 28);
            btn4.BackColor = Color.FromArgb(28, 28, 28);
            btn5.BackColor = Color.FromArgb(28, 28, 28);
            activeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 122, 204);
            btn2.FlatAppearance.MouseOverBackColor = Color.SkyBlue;
            btn3.FlatAppearance.MouseOverBackColor = Color.SkyBlue;
            btn4.FlatAppearance.MouseOverBackColor = Color.SkyBlue;
            btn5.FlatAppearance.MouseOverBackColor = Color.SkyBlue;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            buttonColorChange(add_btn, edit_btn, delete_btn, viewAllUsers_btn, logout_btn);
            buttonPanelItemsChange("add");
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            buttonColorChange(edit_btn, add_btn, delete_btn, viewAllUsers_btn, logout_btn);
            buttonPanelItemsChange("edit");
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            buttonColorChange(delete_btn, edit_btn, add_btn, viewAllUsers_btn, logout_btn);
            buttonPanelItemsChange("delete");
        }

        private void viewAllUsers_btn_Click(object sender, EventArgs e)
        {
            buttonColorChange(viewAllUsers_btn, edit_btn, add_btn, delete_btn, logout_btn);
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            buttonColorChange(logout_btn, edit_btn, add_btn, delete_btn, viewAllUsers_btn);
            new LoginForm().Show();
            this.Hide();
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            buttonColorChange(add_btn, edit_btn, delete_btn, viewAllUsers_btn, logout_btn);
            buttonPanelItemsChange("add");
        }

        private void AdminDashboardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
