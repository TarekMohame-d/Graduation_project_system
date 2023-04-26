using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Graduation_project_system
{
    public partial class ProfessorForm : Form
    {
        Users user;

        public ProfessorForm(Users user)
        {
            InitializeComponent();
            this.user = user;
            textBox_profile_username.Text = user.userName;
            textBox_profile_email.Text = user.userEmail;
            textBox_profile_id.Text = user.userID;
            label_profile_name.Text = user.userName;
            textBox_prof_project_id.Text = user.userID;
            textBox_profile_password.Text = user.userPassword;
        }

        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        OracleCommand command;

        public ProfessorForm()
        {
            InitializeComponent();
        }

        private void changePanelView(String panelName)
        {
            switch (panelName)
            {
                case "profile":
                    {
                        profile_panel.Visible = true;
                        manage_users_panel.Visible = false;
                        manage_projects_panel.Visible = false;
                    }
                    break;
                case "manageUsers":
                    {
                        manage_users_panel.Visible = true;
                        profile_panel.Visible = false;
                        manage_projects_panel.Visible = false;
                    }
                    break;
                case "manageProjects":
                    {
                        manage_projects_panel.Visible = true;
                        manage_users_panel.Visible = false;
                        profile_panel.Visible = false;
                    }
                    break;
            }
        }

        private void buttonColorChange(Button activeButton, Button btn2, Button btn3, Button btn4, Button btn5, bool imgClicked = false)
        {
            if (imgClicked == false)
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
                label_profile_name.BackColor = Color.FromArgb(28, 28, 28);
            }
            else
            {
                label_profile_name.BackColor = Color.FromArgb(0, 122, 204);
                activeButton.BackColor = Color.FromArgb(28, 28, 28);
                btn2.BackColor = Color.FromArgb(28, 28, 28);
                btn3.BackColor = Color.FromArgb(28, 28, 28);
                btn4.BackColor = Color.FromArgb(28, 28, 28);
                btn5.BackColor = Color.FromArgb(28, 28, 28);
                activeButton.FlatAppearance.MouseOverBackColor = Color.SkyBlue;
                btn2.FlatAppearance.MouseOverBackColor = Color.SkyBlue;
                btn3.FlatAppearance.MouseOverBackColor = Color.SkyBlue;
                btn4.FlatAppearance.MouseOverBackColor = Color.SkyBlue;
                btn5.FlatAppearance.MouseOverBackColor = Color.SkyBlue;
            }
        }

        private void manage_users_btn_Click(object sender, EventArgs e)
        {
            buttonColorChange(manage_users_btn, manage_projects_btn, temp_btn1, temp_btn2, logout_btn);
            changePanelView("manageUsers");
        }

        private void viewAllUsers_btn_Click(object sender, EventArgs e)
        {
            buttonColorChange(temp_btn2, manage_projects_btn, manage_users_btn, temp_btn1, logout_btn);
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            buttonColorChange(logout_btn, manage_projects_btn, manage_users_btn, temp_btn1, temp_btn2);
            new LoginForm().Show();
            this.Hide();
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            buttonColorChange(manage_users_btn, manage_projects_btn, temp_btn1, temp_btn2, logout_btn);
            changePanelView("manageUsers");
            conn = new OracleConnection(ordb);
            conn.Open();
            command = new OracleCommand();
            command.Connection = conn;
        }

        private void AdminDashboardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            buttonColorChange(manage_users_btn, manage_projects_btn, temp_btn1, temp_btn2, logout_btn, true);
            changePanelView("profile");
            profile_panel.Visible = true;
        }

        private void button_profile_save_Click(object sender, EventArgs e)
        {
            if (textBox_profile_username.Text == "")
            {
                MessageBox.Show("There are fields thats empty", "Edit profile failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox_profile_username.Text != user.userName || textBox_profile_password.Text != user.userPassword)
            {
                command = new OracleCommand();
                command.Connection = conn;
                command.CommandText = "update professors set profusername=:name, profpassword=:pw where professorID =:id";
                command.Parameters.Add("name", textBox_profile_username.Text);
                command.Parameters.Add("pw", textBox_profile_password.Text);
                command.Parameters.Add("id", textBox_profile_id.Text);
                int r = command.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("User data updated successfully", "Edit profile succeeded", MessageBoxButtons.OK, MessageBoxIcon.None);
                    user.userName = textBox_profile_username.Text;
                    user.userPassword = textBox_profile_password.Text;
                    label_profile_name.Text = user.userName;
                }
                else
                {
                    MessageBox.Show("Error occurred please try again", "Edit profile failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void radioBtn_teamLeader_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_user_id.Items.Clear();
            textBox_username.Text = "";
            textBox_email.Text = "";
            textBox_password.Text = "";
            if (radioBtn_teamLeader.Checked)
            {
                command = new OracleCommand();
                command.Connection = conn;
                command.CommandText = "GetTeamLeaderID";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("id", OracleDbType.RefCursor, ParameterDirection.Output);
                OracleDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    comboBox_user_id.Items.Add(dr[0]);
                }
                dr.Close();
            }
        }

        private void radioBtn_professor_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_user_id.Items.Clear();
            textBox_username.Text = "";
            textBox_email.Text = "";
            textBox_password.Text = "";
            if (radioBtn_professor.Checked)
            {
                command = new OracleCommand();
                command.Connection = conn;
                command.CommandText = "GetProfessorID";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("id", OracleDbType.RefCursor, ParameterDirection.Output);
                OracleDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    comboBox_user_id.Items.Add(dr[0]);
                }
                dr.Close();
            }
        }

        private void add_user_button_Click(object sender, EventArgs e)
        {
            if (textBox_username.Text == "" || textBox_email.Text == "" || textBox_password.Text == "" || (!radioBtn_teamLeader.Checked && !radioBtn_professor.Checked))
            {
                MessageBox.Show("There are fields thats empty", "Add user failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (radioBtn_teamLeader.Checked)
            {
                command = new OracleCommand();
                command.Connection = conn;
                command.CommandText = "SELECT teamleaderID from teamleaders WHERE teamleaderemail =:email";
                command.Parameters.Add("email", textBox_email.Text);
                OracleDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("User with this email already exists", "Add user failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    command = new OracleCommand();
                    command.Connection = conn;
                    command.CommandText = "insert into teamleaders values(userid_seq.nextval, :name, :email, :pw, null, null)";
                    command.Parameters.Add("name", textBox_username.Text);
                    command.Parameters.Add("email", textBox_email.Text);
                    command.Parameters.Add("pw", textBox_password.Text);
                    int r = command.ExecuteNonQuery();
                    if (r != -1)
                    {
                        MessageBox.Show("Team Leader added successfully", "Add user succeeded", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                }
            }
            else if (radioBtn_professor.Checked)
            {
                command = new OracleCommand();
                command.Connection = conn;
                command.CommandText = "SELECT professorID from professors WHERE profemail =:email";
                command.Parameters.Add("email", textBox_email.Text);
                OracleDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("User with this email already exists", "Edit user failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    command = new OracleCommand();
                    command.Connection = conn;
                    command.CommandText = "insert into professors values(userid_seq.nextval, :name, :email, :pw)";
                    command.Parameters.Add("name", textBox_username.Text);
                    command.Parameters.Add("email", textBox_email.Text);
                    command.Parameters.Add("pw", textBox_password.Text);
                    int r = command.ExecuteNonQuery();
                    if (r != -1)
                    {
                        MessageBox.Show("Professor added successfully", "Add user succeeded", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                }
            }
        }

        private void comboBox_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioBtn_teamLeader.Checked)
            {
                command = new OracleCommand();
                command.Connection = conn;
                command.CommandText = "select teamleaderusername, teamleaderemail, teamleaderpw from teamleaders where teamleaderID=:id";
                command.CommandType = CommandType.Text;
                command.Parameters.Add("id", comboBox_user_id.SelectedItem.ToString());
                OracleDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    textBox_username.Text = dr[0].ToString();
                    textBox_email.Text = dr[1].ToString();
                    textBox_password.Text = dr[2].ToString();
                }
                dr.Close();
            }
            else
            {
                command = new OracleCommand();
                command.Connection = conn;
                command.CommandText = "select profusername, profemail, profpassword from professors where professorID=:id";
                command.CommandType = CommandType.Text;
                command.Parameters.Add("id", comboBox_user_id.SelectedItem.ToString());
                OracleDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    textBox_username.Text = dr[0].ToString();
                    textBox_email.Text = dr[1].ToString();
                    textBox_password.Text = dr[2].ToString();
                }
                dr.Close();
            }
        }

        private void Edit_user_button_Click(object sender, EventArgs e)
        {
            if (textBox_username.Text == "" || textBox_email.Text == "" || textBox_password.Text == "" || (!radioBtn_teamLeader.Checked && !radioBtn_professor.Checked))
            {
                MessageBox.Show("There are fields thats empty", "Add user failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (radioBtn_teamLeader.Checked)
            {
                command = new OracleCommand();
                command.Connection = conn;
                command.CommandText = "SELECT teamleaderID from teamleaders WHERE teamleaderemail =:email";
                command.Parameters.Add("email", textBox_email.Text);
                OracleDataReader dr = command.ExecuteReader();
                if (dr.Read() && dr[0].ToString() != comboBox_user_id.SelectedItem.ToString())
                {
                    MessageBox.Show("User with this email already exists", "Edit user failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    command = new OracleCommand();
                    command.Connection = conn;
                    command.CommandText = "update teamleaders set teamleaderusername=:name, teamleaderemail=:email, teamleaderpw=:pw where teamleaderID=:id";
                    command.Parameters.Add("name", textBox_username.Text);
                    command.Parameters.Add("email", textBox_email.Text);
                    command.Parameters.Add("pw", textBox_password.Text);
                    command.Parameters.Add("id", comboBox_user_id.SelectedItem.ToString());
                    int r = command.ExecuteNonQuery();
                    if (r != -1)
                    {
                        MessageBox.Show("Team Leader modified successfully", "Modified user succeeded", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                }
            }
            else if (radioBtn_professor.Checked)
            {
                command = new OracleCommand();
                command.Connection = conn;
                command.CommandText = "SELECT professorID from professors WHERE profemail =:email";
                command.Parameters.Add("email", textBox_email.Text);
                OracleDataReader dr = command.ExecuteReader();
                if (dr.Read() && dr[0].ToString() != comboBox_user_id.SelectedItem.ToString())
                {
                    MessageBox.Show("User with this email already exists", "Edit user failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    command = new OracleCommand();
                    command.Connection = conn;
                    command.CommandText = "update professors set profusername=:name, profemail=:email, profpassword=:pw where professorID=:id";
                    command.Parameters.Add("name", textBox_username.Text);
                    command.Parameters.Add("email", textBox_email.Text);
                    command.Parameters.Add("pw", textBox_password.Text);
                    command.Parameters.Add("id", comboBox_user_id.SelectedItem.ToString());
                    int r = command.ExecuteNonQuery();
                    if (r != -1)
                    {
                        MessageBox.Show("Professor modified successfully", "Modified user succeeded", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                }
            }
        }

        private void delete_user_button_Click(object sender, EventArgs e)
        {
            if ((!radioBtn_teamLeader.Checked && !radioBtn_professor.Checked) || comboBox_user_id.SelectedItem == null)
            {
                MessageBox.Show("Please check user type and id", "Radio unchecked", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (radioBtn_teamLeader.Checked)
            {
                command = new OracleCommand();
                command.Connection = conn;
                command.CommandText = "Delete from teamleaders where teamleaderID=:id";
                command.Parameters.Add("id", comboBox_user_id.SelectedItem.ToString());
                int r = command.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("User deleted successfully", "Delete user succeeded", MessageBoxButtons.OK, MessageBoxIcon.None);
                    clear_user_data_button_Click(sender, e);
                }
            }
            else if (radioBtn_professor.Checked)
            {
                command = new OracleCommand();
                command.Connection = conn;
                command.CommandText = "Delete from professors where professorID=:id";
                command.Parameters.Add("id", comboBox_user_id.SelectedItem.ToString());
                int r = command.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("User deleted successfully", "Delete user succeeded", MessageBoxButtons.OK, MessageBoxIcon.None);
                    clear_user_data_button_Click(sender, e);
                }
            }
        }

        private void manage_projects_btn_Click(object sender, EventArgs e)
        {
            comboBox_project_id.Items.Clear();
            buttonColorChange(manage_projects_btn, manage_users_btn, temp_btn1, temp_btn2, logout_btn);
            changePanelView("manageProjects");
            command = new OracleCommand();
            command.Connection = conn;
            command.CommandText = "select projectID from projects order by projectID";
            command.CommandType = CommandType.Text;
            OracleDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                comboBox_project_id.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void add_project_button_Click(object sender, EventArgs e)
        {
            if (textBox_project_name.Text == "" || textBox_project_description.Text == "" || textBox_prof_project_id.Text == "" || textBox_project_limit.Text == "")
            {
                MessageBox.Show("There are fields thats empty", "Add project failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (int.Parse(textBox_project_limit.Text) > 7)
            {
                MessageBox.Show("Project must be less than 7", "Add project failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                command = new OracleCommand();
                command.Connection = conn;
                command.CommandText = "SELECT * from projects WHERE projectName=:projName";
                command.Parameters.Add("projName", textBox_project_name.Text);
                OracleDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Project with this name already exists", "Add project failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    command = new OracleCommand();
                    command.Connection = conn;
                    command.CommandText = "insert into projects values(projectid_seq.nextval, :projName, :projDescription, :limit, :count, :profID)";
                    command.Parameters.Add("projName", textBox_project_name.Text);
                    command.Parameters.Add("projDescription", textBox_project_description.Text);
                    command.Parameters.Add("limit", textBox_project_limit.Text);
                    command.Parameters.Add("count", "0");
                    command.Parameters.Add("profID", textBox_prof_project_id.Text);
                    int r = command.ExecuteNonQuery();
                    if (r != -1)
                    {
                        MessageBox.Show("Project added successfully", "Add project succeeded", MessageBoxButtons.OK, MessageBoxIcon.None);
                        textBox_project_name.Text = "";
                        textBox_project_description.Text = "";
                        textBox_project_limit.Text = "";
                    }
                }
            }
        }

        private void edit_project_button_Click(object sender, EventArgs e)
        {
            if (textBox_project_name.Text == "" || textBox_project_description.Text == "" || textBox_prof_project_id.Text == "" || textBox_project_limit.Text == "")
            {
                MessageBox.Show("There are fields thats empty", "Edit project failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            command = new OracleCommand();
            command.Connection = conn;
            command.CommandText = "SELECT projectID from projects WHERE projectName=:projName";
            command.Parameters.Add("projName", textBox_project_name.Text);
            OracleDataReader dr = command.ExecuteReader();
            if (dr.Read() && dr[0].ToString() != comboBox_project_id.SelectedItem.ToString())
            {
                MessageBox.Show("Project with this name already exists", "Edit project failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                command = new OracleCommand();
                command.Connection = conn;
                command.CommandText = "update projects set projectName=:name, description=:des, limitOfAssignedUsers=:limit where projectID=:id";
                command.Parameters.Add("name", textBox_project_name.Text);
                command.Parameters.Add("des", textBox_project_description.Text);
                command.Parameters.Add("limit", textBox_project_limit.Text);
                command.Parameters.Add("id", comboBox_project_id.SelectedItem.ToString());
                int r = command.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("Project modified successfully", "Modified project succeeded", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
        }

        private void comboBox_project_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            command = new OracleCommand();
            command.Connection = conn;
            command.CommandText = "select projectName, description, professorID from projects where projectID=:id";
            command.CommandType = CommandType.Text;
            command.Parameters.Add("id", comboBox_project_id.SelectedItem.ToString());
            OracleDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                textBox_project_name.Text = dr[0].ToString();
                textBox_project_description.Text = dr[1].ToString();
                textBox_prof_project_id.Text = dr[2].ToString();
            }
            dr.Close();
            command = new OracleCommand();
            command.Connection = conn;
            command.CommandText = "GetProjectAssignedlimit";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("projId", int.Parse(comboBox_project_id.SelectedItem.ToString()));
            command.Parameters.Add("limit", OracleDbType.Int32, ParameterDirection.Output);
            command.ExecuteNonQuery();
            textBox_project_limit.Text = command.Parameters["limit"].Value.ToString();
        }

        private void button_clear_project_texboxs_Click(object sender, EventArgs e)
        {
            textBox_project_name.Text = "";
            textBox_project_description.Text = "";
            textBox_project_limit.Text = "";
        }

        private void clear_user_data_button_Click(object sender, EventArgs e)
        {
            textBox_username.Text = "";
            textBox_email.Text = "";
            textBox_password.Text = "";
        }

        private void delete_project_button_Click(object sender, EventArgs e)
        {
            command = new OracleCommand();
            command.Connection = conn;
            command.CommandText = "Delete from projects where projectID=:id";
            command.Parameters.Add("id", comboBox_project_id.SelectedItem.ToString());
            int r = command.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("project deleted successfully", "Delete project succeeded", MessageBoxButtons.OK, MessageBoxIcon.None);
                button_clear_project_texboxs_Click(sender, e);
            }
        }
    }
}