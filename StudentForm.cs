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
    public partial class StudentForm : Form
    {
        feedbackReport fr;
        Users user;
        int userid;

        public StudentForm(Users user)
        {
            InitializeComponent();
            label_profile_name.Text = user.userName;
            userid = int.Parse(user.userID);
            conn = new OracleConnection(ordb);
            conn.Open();
            fr = new feedbackReport();
            //label3.Text = user.userID;
        }


        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        OracleCommand command;
        OracleCommand commandname;
        OracleCommand commandleader;


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
        private void changePanelView(String panelName)
        {
            switch (panelName)
            {
                case "request":
                    {
                        request_project.Visible = true;
                        view_assigned.Visible = false;
                        submit_deliverable.Visible = false;
                        feedback.Visible = false;
                    }
                    break;
                case "view":
                    {
                        request_project.Visible = false;
                        view_assigned.Visible = true;
                        submit_deliverable.Visible = false;
                        feedback.Visible = false;
                    }
                    break;
                case "submit":
                    {
                        request_project.Visible = false;
                        view_assigned.Visible = false;
                        submit_deliverable.Visible = true;
                        feedback.Visible = false;
                    }
                    break;
                case "feedback":
                    {
                        request_project.Visible = false;
                        view_assigned.Visible = false;
                        submit_deliverable.Visible = false;
                        feedback.Visible = true;
                    }
                    break;
            }
        }
        private void fillComboBoxes(string operation)
        {
            commandleader = new OracleCommand();
            commandleader.Connection = conn;
            command = new OracleCommand();
            command.Connection = conn;
            switch (operation)
            {
                case "request":
                    {
                        firstpreferenececombo.Items.Clear();
                        secondpreferenececombo.Items.Clear();
                        thirdpreferenececombo.Items.Clear();

                        commandleader.CommandText = "select PROFESSORID from TEAMLEADERS where TEAMLEADERID = :leaderid";
                        commandleader.CommandType = CommandType.Text;
                        commandleader.Parameters.Add("leaderid", userid);
                        OracleDataReader drleader = commandleader.ExecuteReader();
                        if (drleader.Read())
                        {
                            string profid = drleader[0].ToString();
                            // do something with the professor ID here
                            command.CommandText = "select PROJECTNAME from projects where PROFESSORID = :id";
                            command.Parameters.Add("id", profid);
                            OracleDataReader dr = command.ExecuteReader();
                            while (dr.Read())
                            {
                                firstpreferenececombo.Items.Add(dr[0]);
                                secondpreferenececombo.Items.Add(dr[0]);
                                thirdpreferenececombo.Items.Add(dr[0]);
                            }
                            dr.Close();
                        }

                        drleader.Close();

                    }
                    break;
                case "submit":
                    {
                        string pid = "";
                        command.Connection = conn;
                        command.CommandText = "select PROJECTID from TEAMLEADERS where TEAMLEADERID = :id";
                        command.Parameters.Add("id", userid);
                        OracleDataReader dr = command.ExecuteReader();
                        if (dr.Read())
                        {
                            pid = dr[0].ToString();
                        }
                        commandleader.CommandText = "select DELIVERABLENAME from DELIVERABLES where PROJECTID = :piddd";
                        commandleader.CommandType = CommandType.Text;
                        commandleader.Parameters.Add("piddd", pid);
                        OracleDataReader drleader = commandleader.ExecuteReader();
                        while (drleader.Read())
                        {
                            comboBox1.Items.Add(drleader[0]);
                        }
                    }
                    break;
            }
        }

        private void firstpreferenececombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Remove the selected item from the other two combo boxes
            string selectedValue = firstpreferenececombo.SelectedItem.ToString();
            secondpreferenececombo.Items.Remove(selectedValue);
            thirdpreferenececombo.Items.Remove(selectedValue);
        }

        private void secondpreferenececombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Remove the selected item from the other two combo boxes
            string selectedValue = secondpreferenececombo.SelectedItem.ToString();
            firstpreferenececombo.Items.Remove(selectedValue);
            thirdpreferenececombo.Items.Remove(selectedValue);
        }

        private void thirdpreferenececombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Remove the selected item from the other two combo boxes
            string selectedValue = thirdpreferenececombo.SelectedItem.ToString();
            firstpreferenececombo.Items.Remove(selectedValue);
            secondpreferenececombo.Items.Remove(selectedValue);
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

        private void label_page_title_Click(object sender, EventArgs e)
        {

        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }

        private void request_project_btn_Click(object sender, EventArgs e)
        {
            fillComboBoxes("request");
            buttonColorChange(request_project_btn, submit_deliverables_button, view_assigned_btn, view_feedback_btn, logout_btn);
            changePanelView("request");

        }

        private void submit_deliverables_button_Click(object sender, EventArgs e)
        {
            fillComboBoxes("submit");
            buttonColorChange(submit_deliverables_button, request_project_btn, view_assigned_btn, view_feedback_btn, logout_btn);
            changePanelView("submit");
        }

        private void view_assigned_btn_Click(object sender, EventArgs e)
        { 
            commandname = new OracleCommand();
            commandname.Connection = conn;
            commandname.CommandText = "select projectid from TEAMLEADERS where TEAMLEADERID = :id";
            commandname.Parameters.Add("id", userid);
            OracleDataReader dr = commandname.ExecuteReader();
            string pid = "";
            if (dr.Read())
            {
                pid = dr[0].ToString();
            }
            dr.Close();
            string cmdstr = "select DELIVERABLENAME,DESCRIPTION,DEADLINE from deliverables where PROJECTID = :id";
            OracleDataAdapter adapter = new OracleDataAdapter(cmdstr, ordb);

            adapter.SelectCommand.Parameters.Add("id", pid);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            buttonColorChange(view_assigned_btn, request_project_btn, submit_deliverables_button, view_feedback_btn, logout_btn);
            changePanelView("view");
        }

        private void view_feedback_btn_Click(object sender, EventArgs e)
        {
            /*commandname = new OracleCommand();
            commandname.Connection = conn;
            commandname.CommandText = "select DELIVERABLENAME from DELIVERABLES,SUBMITTED_DELIVERABLES where DELIVERABLES.DELIVERABLEID = SUBMITTED_DELIVERABLES.DELIVERABLEID and SUBMITTED_DELIVERABLES.TEAMLEADERID = :id";
            commandname.Parameters.Add("id", userid);
            OracleDataReader dr = commandname.ExecuteReader();
            while (dr.Read())
            {
                deliverablecombo.Items.Add(dr[0].ToString());
            }
            dr.Close();*/
            buttonColorChange(view_feedback_btn, request_project_btn, submit_deliverables_button, view_assigned_btn, logout_btn);
            changePanelView("feedback");
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            buttonColorChange(logout_btn, request_project_btn, submit_deliverables_button, view_assigned_btn, view_feedback_btn);
            new LoginForm().Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            string col1 = "";
           
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                bool flag = false;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        flag = true;
                        col1 = cell.Value.ToString();
                        break;
                    }
                }
                if(flag)
                break;
            }

            DataSet ds = new DataSet();
            string sql = "SELECT * FROM SUBMITTED_DELIVERABLES WHERE DELIVERABLEID = :didd and TEAMLEADERID = :lid";
            OracleDataAdapter da = new OracleDataAdapter(sql, ordb);
            da.SelectCommand.Parameters.Add(":didd", did);
            da.SelectCommand.Parameters.Add(":lid", userid);

            da.Fill(ds);


            DataRow newRow = ds.Tables[0].NewRow();

            commandname = new OracleCommand();
            commandname.Connection = conn;
            commandname.CommandText = "select max(SUBMITTEDID) from SUBMITTED_DELIVERABLES";

            OracleDataReader dr = commandname.ExecuteReader();
            int seq = 0;
            if (dr.Read())
            {
                seq = Convert.ToInt32(dr[0].ToString()) + 1;
            }
            
            newRow["SUBMITTEDID"] = seq; 
            newRow["SUBMITTED_INFO"] = col1;
            newRow["PROJECTID"] = proj; 
            newRow["TEAMLEADERID"] = userid;
            newRow["DELIVERABLEID"] = did;

            ds.Tables[0].Rows.Add(newRow);

           
            OracleCommandBuilder builder = new OracleCommandBuilder(da);
            da.Update(ds.Tables[0]);
            MessageBox.Show("Project submitted Successfully", "Submit Successfully !", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        string proj = "";
        string did = "";
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            commandname = new OracleCommand();
            commandname.Connection = conn;
            commandname.CommandText = "select DELIVERABLEID from DELIVERABLES where DELIVERABLENAME = :name";
            commandname.Parameters.Add("name", comboBox1.SelectedItem.ToString());
            OracleDataReader dr = commandname.ExecuteReader();

            if (dr.Read())
            {
                did = dr[0].ToString();
            }
            dr.Close();
            string cmdstr = "select SUBMITTED_INFO from SUBMITTED_DELIVERABLES where DELIVERABLEID = :id";
            OracleDataAdapter adapter = new OracleDataAdapter(cmdstr, ordb);
            adapter.SelectCommand.Parameters.Add("id", did);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];

            /*DataSet newDataSet = new DataSet();
            DataTable newTable = ds.Tables[0].Clone();
            newTable.ImportRow(ds.Tables[0].Rows[0]);
            newDataSet.Tables.Add(newTable);

            dataGridView1.DataSource = newDataSet.Tables[0].Rows[0];*/

            //// Retreive ProjectID
            command = new OracleCommand();
            command.Connection = conn;
            command.CommandText = "select PROJECTID from DELIVERABLES where DELIVERABLENAME = :n";
            command.Parameters.Add("n", comboBox1.SelectedItem.ToString());
            OracleDataReader dr2 = command.ExecuteReader();
            if (dr2.Read())
            {
                proj = dr2[0].ToString();
            }
            dr2.Close();


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void feedbackbtn_Click(object sender, EventArgs e)
        {
            new viewing().ShowDialog();
            
        }

        private void deliverablecombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void request_project_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_request_accept_Click(object sender, EventArgs e)
        {
            commandname = new OracleCommand();
            if (firstpreferenececombo.SelectedItem == null || secondpreferenececombo.SelectedItem == null || thirdpreferenececombo.SelectedItem == null)
            {
                MessageBox.Show("You must choose three preferences !!", "Request project failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (firstpreferenececombo.SelectedItem.ToString() == secondpreferenececombo.SelectedItem.ToString() 
                || firstpreferenececombo.SelectedItem.ToString() == thirdpreferenececombo.SelectedItem.ToString()
                || thirdpreferenececombo.SelectedItem.ToString() == secondpreferenececombo.SelectedItem.ToString())
            {
                MessageBox.Show("You can't choose two preferences for same project", "Request project failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //First Preference

            commandname.Connection = conn;
            commandname.CommandText = "select projectid from projects where projectname = :name";
            commandname.Parameters.Add("name", firstpreferenececombo.SelectedItem.ToString());
            OracleDataReader dr = commandname.ExecuteReader();
            string pid = "";
            if (dr.Read())
            {
                pid = dr[0].ToString();   
            }
            dr.Close();
            command = new OracleCommand();
            command.Connection = conn;
            command.CommandText = "insert into REQUESTPROJECTS values(requestid_seq.nextval, :id, :tid, 1)";
            command.Parameters.Add("id", pid);
            command.Parameters.Add("tid", userid);
            int r = command.ExecuteNonQuery();


            //Second Preference
            commandname = new OracleCommand();
            commandname.Connection = conn;
            commandname.CommandText = "select projectid from projects where projectname = :name";
            commandname.Parameters.Add("name", secondpreferenececombo.SelectedItem.ToString());
            OracleDataReader dr2 = commandname.ExecuteReader();
            string pid2 = "";
            if (dr2.Read())
            {
                pid2 = dr2[0].ToString();
            }
            dr2.Close();
            command = new OracleCommand();
            command.Connection = conn;
            command.CommandText = "insert into REQUESTPROJECTS values(requestid_seq.nextval, :id, :tid, 2)";
            command.Parameters.Add("id", pid2);
            command.Parameters.Add("tid", userid);
            int r2 = command.ExecuteNonQuery();

            // Third Preference
            commandname = new OracleCommand();
            commandname.Connection = conn;
            commandname.CommandText = "select projectid from projects where projectname = :name";
            commandname.Parameters.Add("name", thirdpreferenececombo.SelectedItem.ToString());
            OracleDataReader dr3 = commandname.ExecuteReader();
            string pid3 = "";
            if (dr3.Read())
            {
                pid3 = dr3[0].ToString();
            }
            dr3.Close();
            command = new OracleCommand();
            command.Connection = conn;
            command.CommandText = "insert into REQUESTPROJECTS values(requestid_seq.nextval, :id, :tid, 3)";
            command.Parameters.Add("id", pid3);
            command.Parameters.Add("tid", userid);
            int r3 = command.ExecuteNonQuery();

            if (r != -1 && r2 != -1 && r3 != -1)
            {
                MessageBox.Show("Projects requested Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                fillComboBoxes("request");
            }
        }
    }
}