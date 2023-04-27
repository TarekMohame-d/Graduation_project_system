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
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Graduation_project_system
{
    public partial class AddDeliverablesForm : Form
    {
        string professorID;
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        OracleCommand command;
        public AddDeliverablesForm(string professorID)
        {
            InitializeComponent();
            this.professorID = professorID;
            textBox_professor_id.Text = professorID;
        }

        private void fillComboboxs()
        {
            command = new OracleCommand();
            command.Connection = conn;
            comboBox_project_id.Items.Clear();
            command.CommandText = "select projectID from projects order by projectID";
            command.CommandType = CommandType.Text;
            OracleDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                comboBox_project_id.Items.Add(dr[0]);
            }
            dr.Close();
            command = new OracleCommand();
            command.Connection = conn;
            comboBox_deliverable_id.Items.Clear();
            command.CommandText = "select deliverableID from deliverables order by deliverableID";
            command.CommandType = CommandType.Text;
            OracleDataReader dr2 = command.ExecuteReader();
            while (dr2.Read())
            {
                comboBox_deliverable_id.Items.Add(dr2[0]);
            }
            dr.Close();
        }

        private void AddDeliverablesForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            fillComboboxs();
            dateTimePicker_deadLine.Value = DateTime.Now;
        }

        private void button_clear_deliverable_texboxs_Click(object sender, EventArgs e)
        {
            textBox_deliverable_name.Text = "";
            textBox_deliverable_description.Text = "";
            comboBox_project_id.SelectedItem = null;
            comboBox_deliverable_id.SelectedItem = null;
            dateTimePicker_deadLine.Value = DateTime.Now;
        }

        private void add_deliverable_button_Click(object sender, EventArgs e)
        {
            if (textBox_deliverable_name.Text == "" || textBox_deliverable_description.Text == "" || comboBox_project_id.SelectedItem == null)
            {
                MessageBox.Show("There are fields thats empty", "Add deliverable failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                command = new OracleCommand();
                command.Connection = conn;
                command.CommandText = "insert into deliverables values(deliverableID_seq.nextval, :deliverableName, :deliverableDescription, :deadline, :profID, :projectID)";
                command.Parameters.Add("deliverableName", textBox_deliverable_name.Text.ToLower());
                command.Parameters.Add("deliverableDescription", textBox_deliverable_description.Text);
                command.Parameters.Add("deadline", dateTimePicker_deadLine.Value.Date);
                command.Parameters.Add("profID", professorID);
                command.Parameters.Add("projectID", comboBox_project_id.SelectedItem.ToString());
                int r = command.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("Deliverable added successfully", "Add deliverable succeeded", MessageBoxButtons.OK, MessageBoxIcon.None);
                    fillComboboxs();
                    button_clear_deliverable_texboxs_Click(sender, e);
                }
            }
        }

        private void edit_deliverable_button_Click(object sender, EventArgs e)
        {
            if (textBox_deliverable_name.Text == "" || textBox_deliverable_description.Text == "" || comboBox_project_id.SelectedItem == null || comboBox_deliverable_id.SelectedItem == null)
            {
                MessageBox.Show("There are fields thats empty", "Edit deliverable failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                command = new OracleCommand();
                command.Connection = conn;
                command.CommandText = "update deliverables set deliverablename=:name, description=:des, deadline=:dedLine, projectID=:projID  where deliverableID=:delivID";
                command.Parameters.Add("name", textBox_deliverable_name.Text.ToLower());
                command.Parameters.Add("des", textBox_deliverable_description.Text);
                command.Parameters.Add("dedLine", dateTimePicker_deadLine.Value.Date);
                command.Parameters.Add("projID", comboBox_project_id.SelectedItem.ToString());
                command.Parameters.Add("delivID", comboBox_deliverable_id.SelectedItem.ToString());
                int r = command.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("Deliverable modified successfully", "Modified deliverable succeeded", MessageBoxButtons.OK, MessageBoxIcon.None);
                    button_clear_deliverable_texboxs_Click(sender, e);
                }
            }
        }

        private void delete_deliverable_button_Click(object sender, EventArgs e)
        {
            command = new OracleCommand();
            command.Connection = conn;
            command.CommandText = "Delete from deliverables where deliverableID=:id";
            command.Parameters.Add("id", comboBox_deliverable_id.SelectedItem.ToString());
            int r = command.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Deliverable deleted successfully", "Delete deliverable succeeded", MessageBoxButtons.OK, MessageBoxIcon.None);
                comboBox_project_id.Items.Remove(comboBox_deliverable_id.SelectedItem);
                button_clear_deliverable_texboxs_Click(sender, e);
            }
        }

        private void comboBox_deliverable_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_deliverable_id.SelectedItem != null)
            {
                command = new OracleCommand();
                command.Connection = conn;
                command.CommandText = "select deliverablename, description, deadline, projectID from deliverables where deliverableID=:id";
                command.CommandType = CommandType.Text;
                command.Parameters.Add("id", comboBox_deliverable_id.SelectedItem.ToString());
                OracleDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    textBox_deliverable_name.Text = dr[0].ToString();
                    textBox_deliverable_description.Text = dr[1].ToString();
                    dateTimePicker_deadLine.Text = dr[2].ToString();
                    comboBox_project_id.Text = dr[3].ToString();
                }
                dr.Close();
            }
        }
    }
}
