using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarrocIT
{
    public partial class frmMain : Form
    {
        frmLogin Login;
        frmProjects AddProject;
        frmCalendar Calendar;
        frmAdd Add;
        frmEdit Edit;
        frmHelp Help;

        public frmMain()
        {
            InitializeComponent();
        }

        private void itemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            Calendar = new frmCalendar();
            Calendar.Show();
        }

        private void btnCustomersAdd_Click(object sender, EventArgs e)
        {
            Add = new frmAdd();
            Add.Show(); 
        }

        private void btnInvoicesAdd_Click(object sender, EventArgs e)
        {
            Add = new frmAdd();
            Add.Show();
        }

        private void btnProjectsView_Click(object sender, EventArgs e)
        {
            AddProject = new frmProjects();
            AddProject.Show();
        }

        private void btnMeetingsAdd_Click(object sender, EventArgs e)
        {
            Add = new frmAdd();
            Add.Show();
        }

        private void btnCustomersEdit_Click(object sender, EventArgs e)
        {
            Edit = new frmEdit();
            Edit.Show();
        }

        private void btnInvoicesEdit_Click(object sender, EventArgs e)
        {
            Edit = new frmEdit();
            Edit.Show();
        }

        private void btnProjectsEdit_Click(object sender, EventArgs e)
        {
            Edit = new frmEdit();
            Edit.Show();
        }

        private void btnMeetingsEdit_Click(object sender, EventArgs e)
        {
            Edit = new frmEdit();
            Edit.Show();
        }

        private void menuHelp_Click(object sender, EventArgs e)
        {
            Help = new frmHelp();
            Help.Show();
        }

        private void itemSignout_Click(object sender, EventArgs e)
        {
            Login = new frmLogin();
            Login.Show();
            this.Close();
        }
    }
}
