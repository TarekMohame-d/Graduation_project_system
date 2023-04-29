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
                        feedback_panel.Visible = false;
                        requests_panel.Visible = false;
                    }
                    break;
                case "manageUsers":
                    {
                        manage_users_panel.Visible = true;
                        profile_panel.Visible = false;
                        manage_projects_panel.Visible = false;
                        feedback_panel.Visible = false;
                        requests_panel.Visible = false;
                    }
                    break;
                case "manageProjects":
                    {
                        manage_projects_panel.Visible = true;
                        manage_users_panel.Visible = false;
                        profile_panel.Visible = false;
                        feedback_panel.Visible = false;
                        requests_panel.Visible = false;
                    }
                    break;
                case "feedback":
                    {
                        feedback_panel.Visible = true;
                        manage_projects_panel.Visible = false;
                        manage_users_panel.Visible = false;
                        profile_panel.Visible = false;
                        requests_panel.Visible = false;
                    }
                    break;
                case "request":
                    {
                        requests_panel.Visible = true;
                        feedback_panel.Visible = false;
                        manage_projects_panel.Visible = false;
                        manage_users_panel.Visible = false;
                        profile_panel.Visible = false;
                    }
                    break;
            }
        }

        private void buttonColorChange(Button activeButton, Button btn2, Button btn3, Button btn4, Button btn5, Button btn6, bool imgClicked = false)
        {
            if (imgClicked == false)
            {
                activeButton.BackColor = Color.FromArgb(0, 122, 204);
                btn2.BackColor = Color.FromArgb(28, 28, 28);
                btn3.BackColor = Color.FromArgb(28, 28, 28);
                btn4.BackColor = Color.FromArgb(28, 28, 28);
                btn5.BackColor = Color.FromArgb(28, 28, 28);
                btn6.BackColor = Color.FromArgb(28, 28, 28);
                activeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 122, 204);
                btn2.FlatAppearance.MouseOverBackColor = Color.SkyBlue;
                btn3.FlatAppearance.MouseOverBackColor = Color.SkyBlue;
                btn4.FlatAppearance.MouseOverBackColor = Color.SkyBlue;
                btn5.FlatAppearance.MouseOverBackColor = Color.SkyBlue;
                btn6.FlatAppearance.MouseOverBackColor = Color.SkyBlue;
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

        private void fillComboBoxes(string operation)
        {
            command = new OracleCommand();
            command.Connection = conn;
            switch (operation)
            {
                case "teamLeader":
                    {
                        comboBox_user_id.Items.Clear();
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
                    break;
                case "professor":
                    {
                        comboBox_user_id.Items.Clear();
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
                    break;
                case "project":
                    {
                        comboBox_project_id.Items.Clear();
                        command.CommandText = "select projectID from projects order by projectID";
                        command.CommandType = CommandType.Text;
                        OracleDataReader dr = command.ExecuteReader();
                        while (dr.Read())
                        {
                            comboBox_project_id.Items.Add(dr[0]);
                        }
                        dr.Close();
                    } break;
                case "feedback":
                    {
                        comboBox_submitted_id.Items.Clear();
                        command.CommandText = "select submittedID from submitted_deliverables order by submittedID";
                        command.CommandType = CommandType.Text;
                        OracleDataReader dr = command.ExecuteReader();
                        while (dr.Read())
                        {
                            comboBox_submitted_id.Items.Add(dr[0]);
                        }
                        dr.Close();
                    }
                    break;
                case "request":
                    {
                        comboBox_request_id.Items.Clear();
                        command.CommandText = "select requestID from requestProjects order by requestID";
                        command.CommandType = CommandType.Text;
                        OracleDataReader dr = command.ExecuteReader();
                        while (dr.Read())
                        {
                            comboBox_request_id.Items.Add(dr[0]);
                        }
                        dr.Close();
                    }
                    break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            buttonColorChange(manage_users_btn, manage_projects_btn, add_deliverables_button, accept_requests_button, logout_btn, button_feedback, true);
            changePanelView("profile");
            profile_panel.Visible = true;
        }

        private void manage_users_btn_Click(object sender, EventArgs e)
        {
            buttonColorChange(manage_users_btn, manage_projects_btn, add_deliverables_button, accept_requests_button, logout_btn, button_feedback);
            changePanelView("manageUsers");
        }

        private void manage_projects_btn_Click(object sender, EventArgs e)
        {
            buttonColorChange(manage_projects_btn, manage_users_btn, add_deliverables_button, accept_requests_button, logout_btn, button_feedback);
            button_clear_project_texboxs_Click(sender, e);
            changePanelView("manageProjects");
            fillComboBoxes("project");
        }

        private void add_deliverables_button_Click(object sender, EventArgs e)
        {
            buttonColorChange(add_deliverables_button, accept_requests_button, manage_projects_btn, manage_users_btn, logout_btn, button_feedback);
            new AddDeliverablesForm(user.userID).ShowDialog();
        }

        private void button_feedback_Click(object sender, EventArgs e)
        {
            buttonColorChange(button_feedback, logout_btn, manage_projects_btn, manage_users_btn, add_deliverables_button, accept_requests_button);
            changePanelView("feedback");
            fillComboBoxes("feedback");
        }

        private void accept_requests_button_Click(object sender, EventArgs e)
        {
            buttonColorChange(accept_requests_button, manage_projects_btn, manage_users_btn, add_deliverables_button, logout_btn, button_feedback);
            changePanelView("request");
            fillComboBoxes("request");
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            buttonColorChange(logout_btn, manage_projects_btn, manage_users_btn, add_deliverables_button, accept_requests_button, button_feedback);
            new LoginForm().Show();
            this.Hide();
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            buttonColorChange(manage_users_btn, manage_projects_btn, add_deliverables_button, accept_requests_button, logout_btn, button_feedback);
            changePanelView("manageUsers");
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void AdminDashboardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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
            clear_user_data_button_Click(sender, e);
            if (radioBtn_teamLeader.Checked)
            {
                fillComboBoxes("teamLeader");
            }
        }

        private void radioBtn_professor_CheckedChanged(object sender, EventArgs e)
        {
            clear_user_data_button_Click(sender, e);
            if (radioBtn_professor.Checked)
            {
                fillComboBoxes("professor");
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
                command.Parameters.Add("email", textBox_email.Text.ToLower());
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
                    command.Parameters.Add("email", textBox_email.Text.ToLower());
                    command.Parameters.Add("pw", textBox_password.Text);
                    int r = command.ExecuteNonQuery();
                    if (r != -1)
                    {
                        MessageBox.Show("Team Leader added successfully", "Add user succeeded", MessageBoxButtons.OK, MessageBoxIcon.None);
                        fillComboBoxes("teamLeader");
                    }
                }
            }
            else if (radioBtn_professor.Checked)
            {
                command = new OracleCommand();
                command.Connection = conn;
                command.CommandText = "SELECT professorID from professors WHERE profemail =:email";
                command.Parameters.Add("email", textBox_email.Text.ToLower());
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
                    command.Parameters.Add("email", textBox_email.Text.ToLower());
                    command.Parameters.Add("pw", textBox_password.Text);
                    int r = command.ExecuteNonQuery();
                    if (r != -1)
                    {
                        MessageBox.Show("Professor added successfully", "Add user succeeded", MessageBoxButtons.OK, MessageBoxIcon.None);
                        fillComboBoxes("professor");
                    }
                }
            }
        }

        private void comboBox_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_user_id.SelectedItem != null)
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
                command.Parameters.Add("email", textBox_email.Text.ToLower());
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
                    command.Parameters.Add("email", textBox_email.Text.ToLower());
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
                command.Parameters.Add("email", textBox_email.Text.ToLower());
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
                    command.Parameters.Add("email", textBox_email.Text.ToLower());
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
                    comboBox_user_id.Items.Remove(comboBox_user_id.SelectedItem);
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
                    comboBox_user_id.Items.Remove(comboBox_user_id.SelectedItem);
                }
            }
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
                command.Parameters.Add("projName", textBox_project_name.Text.ToLower());
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
                    command.Parameters.Add("projName", textBox_project_name.Text.ToLower());
                    command.Parameters.Add("projDescription", textBox_project_description.Text);
                    command.Parameters.Add("limit", textBox_project_limit.Text);
                    command.Parameters.Add("count", "0");
                    command.Parameters.Add("profID", textBox_prof_project_id.Text);
                    int r = command.ExecuteNonQuery();
                    if (r != -1)
                    {
                        MessageBox.Show("Project added successfully", "Add project succeeded", MessageBoxButtons.OK, MessageBoxIcon.None);
                        fillComboBoxes("project");
                    }
                }
            }
        }

        private void edit_project_button_Click(object sender, EventArgs e)
        {
            command = new OracleCommand();
            command.Connection = conn;
            command.CommandText = "SELECT projectID from projects WHERE projectName=:projName";
            command.Parameters.Add("projName", textBox_project_name.Text.ToLower());
            OracleDataReader dr = command.ExecuteReader();
            if (textBox_project_name.Text == "" || textBox_project_description.Text == "" || textBox_prof_project_id.Text == "" || textBox_project_limit.Text == "" || comboBox_project_id.SelectedItem == null)
            {
                MessageBox.Show("There are fields thats empty", "Edit project failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dr.Read() && dr[0].ToString() != comboBox_project_id.SelectedItem.ToString())
            {
                MessageBox.Show("Project with this name already exists", "Edit project failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                command = new OracleCommand();
                command.Connection = conn;
                command.CommandText = "update projects set projectName=:name, description=:des, limitOfAssignedUsers=:limit where projectID=:id";
                command.Parameters.Add("name", textBox_project_name.Text.ToLower());
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
                comboBox_project_id.Items.Remove(comboBox_project_id.SelectedItem);
            }
        }

        private void comboBox_project_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_project_id.SelectedItem != null)
            {
                command = new OracleCommand();
                command.Connection = conn;
                command.CommandText = "select projectName, description, professorID,LIMITOFASSIGNEDUSERS from projects where projectID=:id";
                command.CommandType = CommandType.Text;
                command.Parameters.Add("id", comboBox_project_id.SelectedItem.ToString());
                OracleDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    textBox_project_name.Text = dr[0].ToString();
                    textBox_project_description.Text = dr[1].ToString();
                    textBox_prof_project_id.Text = dr[2].ToString();
                    textBox_project_limit.Text = dr[3].ToString();
                }
                dr.Close();
                /*command = new OracleCommand();
                command.Connection = conn;
                command.CommandText = "GetProjectAssignedlimit";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("projId", int.Parse(comboBox_project_id.SelectedItem.ToString()));
                command.Parameters.Add("limit", OracleDbType.Int32, ParameterDirection.Output);
                command.ExecuteNonQuery();
                textBox_project_limit.Text = command.Parameters["limit"].Value.ToString();*/
            }
        }

        private void button_clear_project_texboxs_Click(object sender, EventArgs e)
        {
            textBox_project_name.Text = "";
            textBox_project_description.Text = "";
            textBox_project_limit.Text = "";
            comboBox_project_id.SelectedItem = null;
        }

        private void clear_user_data_button_Click(object sender, EventArgs e)
        {
            textBox_username.Text = "";
            textBox_email.Text = "";
            textBox_password.Text = "";
            comboBox_user_id.SelectedItem = null;
        }

        private void comboBox_submitted_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_submitted_id.SelectedItem != null)
            {
                command = new OracleCommand();
                command.Connection = conn;
                command.CommandText = "select submitted_info, feedback, projectID, teamleaderID, deliverableID from submitted_deliverables where submittedID=:id";
                command.CommandType = CommandType.Text;
                command.Parameters.Add("id", comboBox_submitted_id.SelectedItem.ToString());
                OracleDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    textBox_submitted_link.Text = dr[0].ToString();
                    textBox_feedback.Text = dr[1].ToString();
                    textBox_teamLeader_id_feedback.Text = dr[3].ToString();
                    command = new OracleCommand();
                    command.Connection = conn;
                    command.CommandText = "select teamleaderusername from teamleaders where teamleaderID=:id";
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("id", dr[3].ToString());
                    OracleDataReader dr2 = command.ExecuteReader();
                    if (dr2.Read())
                    {
                        textBox_teamLeader_name_feedback.Text = dr2[0].ToString();
                    }
                    command = new OracleCommand();
                    command.Connection = conn;
                    command.CommandText = "select deliverablename from deliverables where deliverableID=:id";
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("id", dr[4].ToString());
                    OracleDataReader dr3 = command.ExecuteReader();
                    if (dr3.Read())
                    {
                        textBox_deliverable_name_feedback.Text = dr3[0].ToString();
                    }
                    command = new OracleCommand();
                    command.Connection = conn;
                    command.CommandText = "select projectName from projects where projectID=:id";
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("id", dr[2].ToString());
                    OracleDataReader dr4 = command.ExecuteReader();
                    if (dr4.Read())
                    {
                        textBox_project_name_feedback.Text = dr4[0].ToString();
                    }
                    dr2.Close();
                    dr3.Close();
                    dr4.Close();
                }
                dr.Close();
            }
        }

        private void button_add_feedback_Click(object sender, EventArgs e)
        {
            if (textBox_submitted_link.Text == "" || textBox_project_name_feedback.Text == "" || textBox_deliverable_name_feedback.Text == "" || textBox_teamLeader_name_feedback.Text == "" || textBox_teamLeader_id_feedback.Text == "" || textBox_feedback.Text == "")
            {
                MessageBox.Show("There are fields thats empty", "Add feedback failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                command = new OracleCommand();
                command.Connection = conn;
                command.CommandText = "update submitted_deliverables set feedback=:feedbk where submittedID=:id";
                command.Parameters.Add("feedbk", textBox_feedback.Text);
                command.Parameters.Add("id", comboBox_submitted_id.SelectedItem.ToString());
                int r = command.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("Feedback added successfully", "Add feedback succeeded", MessageBoxButtons.OK, MessageBoxIcon.None);
                    fillComboBoxes("feedback");
                    button_clear_feedback_Click(sender, e);
                }
            }
        }

        private void button_edit_feedback_Click(object sender, EventArgs e)
        {
            if (textBox_submitted_link.Text == "" || textBox_project_name_feedback.Text == "" || textBox_deliverable_name_feedback.Text == "" || textBox_teamLeader_name_feedback.Text == "" || textBox_teamLeader_id_feedback.Text == "" || textBox_feedback.Text == "")
            {
                MessageBox.Show("There are fields thats empty", "Edit feedback failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                command = new OracleCommand();
                command.Connection = conn;
                command.CommandText = "update submitted_deliverables set feedback=:feedbk where submittedID=:id";
                command.Parameters.Add("feedbk", textBox_feedback.Text);
                command.Parameters.Add("id", comboBox_submitted_id.SelectedItem.ToString());
                int r = command.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("Feedback modified successfully", "Modified feedback succeeded", MessageBoxButtons.OK, MessageBoxIcon.None);
                    fillComboBoxes("feedback");
                    button_clear_feedback_Click(sender, e);
                }
            }
        }

        private void button_delete_feedback_Click(object sender, EventArgs e)
        {
            if (textBox_submitted_link.Text == "" || textBox_project_name_feedback.Text == "" || textBox_deliverable_name_feedback.Text == "" || textBox_teamLeader_name_feedback.Text == "" || textBox_teamLeader_id_feedback.Text == "" || textBox_feedback.Text == "")
            {
                MessageBox.Show("There are fields thats empty", "Edit feedback failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                command = new OracleCommand();
                command.Connection = conn;
                command.CommandText = "update submitted_deliverables set feedback=:feedbk where submittedID=:id";
                command.Parameters.Add("feedbk", null);
                command.Parameters.Add("id", comboBox_submitted_id.SelectedItem.ToString());
                int r = command.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("Feedback deleted successfully", "Delete feedback succeeded", MessageBoxButtons.OK, MessageBoxIcon.None);
                    fillComboBoxes("feedback");
                    button_clear_feedback_Click(sender, e);
                }
            }
        }

        private void button_clear_feedback_Click(object sender, EventArgs e)
        {
            textBox_submitted_link.Text = "";
            textBox_feedback.Text = "";
            textBox_teamLeader_id_feedback.Text = "";
            textBox_deliverable_name_feedback.Text = "";
            textBox_teamLeader_name_feedback.Text = "";
            textBox_project_name_feedback.Text = "";
            comboBox_submitted_id.SelectedItem = null;
        }

        private void comboBox_request_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_request_id.SelectedItem != null)
            {
                command = new OracleCommand();
                command.Connection = conn;
                command.CommandText = "select projectID, teamleaderID from requestProjects where requestID=:id";
                command.CommandType = CommandType.Text;
                command.Parameters.Add("id", comboBox_request_id.SelectedItem.ToString());
                OracleDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    command = new OracleCommand();
                    command.Connection = conn;
                    command.CommandText = "select projectName from projects where projectID=:id";
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("id", dr[0].ToString());
                    OracleDataReader dr2 = command.ExecuteReader();
                    if (dr2.Read())
                    {
                        textBox_request_project_name.Text = dr2[0].ToString();
                    }
                    command = new OracleCommand();
                    command.Connection = conn;
                    command.CommandText = "select teamleaderusername from teamleaders where teamleaderID=:id";
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("id", dr[1].ToString());
                    OracleDataReader dr3 = command.ExecuteReader();
                    if (dr3.Read())
                    {
                        textBox_request_teamLeader_name.Text = dr3[0].ToString();
                    }
                    dr2.Close();
                    dr3.Close();
                }
                dr.Close();
            }
        }

        private void button_request_accept_Click(object sender, EventArgs e)
        {
            if (textBox_request_project_name.Text == "" || textBox_request_teamLeader_name.Text == "" || comboBox_request_id.SelectedItem == null)
            {
                MessageBox.Show("There are fields thats empty", "Accept request failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                command = new OracleCommand();
                command.Connection = conn;
                command.CommandText = "select projectID, teamleaderID from requestProjects where requestID=:id";
                command.CommandType = CommandType.Text;
                command.Parameters.Add("id", comboBox_request_id.SelectedItem.ToString());
                OracleDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    command = new OracleCommand();
                    command.Connection = conn;
                    command.CommandText = "select professorID from projects where projectID=:id";
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("id", dr[0].ToString());
                    OracleDataReader dr2 = command.ExecuteReader();
                    if (dr2.Read())
                    {
                        command = new OracleCommand();
                        command.Connection = conn;
                        command.CommandText = "update teamleaders set ProfessorID=:profID, projectID=:projID where teamleaderID=:id";
                        command.CommandType = CommandType.Text;
                        command.Parameters.Add("profID", dr2[0].ToString());
                        command.Parameters.Add("projID", dr[0].ToString());
                        command.Parameters.Add("id", dr[1].ToString());
                        int r = command.ExecuteNonQuery();
                        if (r != -1)
                        {
                            command = new OracleCommand();
                            command.Connection = conn;
                            command.CommandText = "delete from requestProjects where requestID=:id";
                            command.Parameters.Add("id", comboBox_request_id.SelectedItem.ToString());
                            int r2 = command.ExecuteNonQuery();
                            if (r2 != -1)
                            {
                                command = new OracleCommand();
                                command.Connection = conn;
                                command.CommandText = "update projects set numberOfAssignedUsers = numberOfAssignedUsers + 1 where projectID=:id";
                                command.CommandType = CommandType.Text;
                                command.Parameters.Add("id", dr[0].ToString());
                                int r3 = command.ExecuteNonQuery();
                                if (r3 != -1)
                                {
                                    MessageBox.Show("Request accepted successfully", "Accept request succeeded", MessageBoxButtons.OK, MessageBoxIcon.None);
                                    button_clear_feedback_Click(sender, e);
                                }
                            }
                        }
                    }
                    dr2.Close();
                }
                dr.Close();
            }
        }

        private void view_users_button_Click(object sender, EventArgs e)
        {
            new ViewUsersForm().ShowDialog();
        }
    }
}