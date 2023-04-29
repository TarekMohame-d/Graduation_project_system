using Oracle.DataAccess.Client;
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

    public partial class LoginForm : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password = tiger; ";
        OracleConnection conn;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void checkBox_showPW_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_showPW.Checked)
            {
                textBox_password.PasswordChar = '\0';
            }
            else
            {
                textBox_password.PasswordChar = '•';
            }
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (textBox_username.Text == "" || textBox_password.Text == "")
            {
                MessageBox.Show("There are fields thats empty", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                OracleCommand cmd_professor = new OracleCommand();
                cmd_professor.Connection = conn;
                cmd_professor.CommandText = "select * from professors where profusername =:name and profpassword=:pw";
                cmd_professor.Parameters.Add("name", textBox_username.Text);
                cmd_professor.Parameters.Add("pw", textBox_password.Text);
                cmd_professor.CommandType = CommandType.Text;
                OracleDataReader dr_professor = cmd_professor.ExecuteReader();
                OracleCommand cmd_teamLeader = new OracleCommand();
                cmd_teamLeader.Connection = conn;
                cmd_teamLeader.CommandText = "select * from teamleaders where teamleaderusername =:name and teamleaderpw=:pw";
                cmd_teamLeader.Parameters.Add("name", textBox_username.Text);
                cmd_teamLeader.Parameters.Add("pw", textBox_password.Text);
                cmd_teamLeader.CommandType = CommandType.Text;
                OracleDataReader dr_teamLeader = cmd_teamLeader.ExecuteReader();
                if (dr_professor.Read())
                {
                    string professorID = dr_professor[0].ToString();
                    string professorEmail = dr_professor[2].ToString();
                    Users user = new Users(userName: textBox_username.Text, userID: professorID, userType: "p", userEmail: professorEmail, userPassword: textBox_password.Text);
                    new ProfessorForm(user).Show();
                    this.Hide();
                }
                else if (dr_teamLeader.Read())
                {
                    string teamLeaderID = dr_teamLeader[0].ToString();
                    string teamLeaderEmail = dr_teamLeader[2].ToString();
                    Users user = new Users(userName: textBox_username.Text, userID: teamLeaderID, userType: "s", userEmail: teamLeaderEmail, userPassword: textBox_password.Text);
                    new StudentForm(user).Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or Password is incorrect", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //ahmed
            //professor_1     professor_1_123
            textBox_username.Text = "teamLeader_1";
            textBox_password.Text = "teamLeader_1_123";
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

public class Users
{
    public string userName;
    public string userID;
    public string userType; // TeamLeader or Professor
    public string userEmail;
    public string userPassword;
    public Users(string userName, string userID, string userType, string userEmail, string userPassword)
    {
        this.userName = userName;
        this.userID = userID;
        this.userType = userType;
        this.userEmail = userEmail;
        this.userPassword = userPassword;
    }
}
