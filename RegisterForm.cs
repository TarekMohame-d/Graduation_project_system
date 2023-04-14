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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            this.ActiveControl = txt_email;
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            if (txt_email.Text == "" || txt_password.Text == "" || txt_username.Text == "" || txt_id.Text == "")
            {
                MessageBox.Show("There are fields thats empty", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

            }
        }

        private void checkBox_showpw_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_showpw.Checked)
            {
                txt_password.PasswordChar = '\0';
            }
            else
            {
                txt_password.PasswordChar = '•';
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }
    }
}
