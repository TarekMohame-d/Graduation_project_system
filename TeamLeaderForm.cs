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
    public partial class TeamLeaderForm : Form
    {
        Users user;
        public TeamLeaderForm(Users user)
        {
            InitializeComponent();
            this.user = user;
        }
    }
}
