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
using CrystalDecisions.Shared;

namespace Graduation_project_system
{
    public partial class viewing : Form
    {
        feedbackReport fr;
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        public viewing()
        {

            InitializeComponent();
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void viewing_Load(object sender, EventArgs e)
        {
            fr = new feedbackReport();
            crystalReportViewer1.ReportSource = fr;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
