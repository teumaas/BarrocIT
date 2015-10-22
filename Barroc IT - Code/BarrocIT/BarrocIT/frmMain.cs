using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace BarrocIT
{
    public partial class frmMain : Form
    {
        DatabaseHandler SQLHandler;
        frmLogin Login;
        frmProjects AddProject;
        frmCalendar Calendar;
        frmAdd Add;
        frmEdit Edit;
        frmHelp Help;

        public frmMain()
        {
            InitializeComponent();

            SQLHandler = new DatabaseHandler();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            FillDataGrids();
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
            SQLHandler.testConnection();
        }

        private void btnInvoicesAdd_Click(object sender, EventArgs e)
        {
            AddEditForm(true);
        }

        private void btnProjectsView_Click(object sender, EventArgs e)
        {
            AddProject = new frmProjects();
            AddProject.Show();
        }

        private void btnCustomersEdit_Click(object sender, EventArgs e)
        {
            AddEditForm(false);
        }

        private void btnInvoicesEdit_Click(object sender, EventArgs e)
        {
            AddEditForm(false);
        }

        private void btnProjectsEdit_Click(object sender, EventArgs e)
        {
            AddEditForm(false);
        }

        private void itemSignout_Click(object sender, EventArgs e)
        {
            Login = new frmLogin();
            //SQLHandler.Close();
            this.Close();
            Application.Restart();
        }

        private void itemInfo_Click(object sender, EventArgs e)
        {
            Help = new frmHelp();
            Help.Show();
        }

        private void btnAppointmentsAdd_Click(object sender, EventArgs e)
        {
            AddEditForm(true);
        }

        private void btnAppointmentsEdit_Click(object sender, EventArgs e)
        {
            AddEditForm(false);
        }

        private bool AddEditForm(bool addedit)
        {
            if (addedit == true)
            {
                Add = new frmAdd();
                Add.Show();
            }
            else
            {
                Edit = new frmEdit();
                Edit.Show();
            }

            return addedit;
        }

        private void FillDataGrids()
        {
            dataGridViewCustomers.DataSource = SQLHandler.SQLCommand("SELECT * FROM tbl_customers;");
            dataGridViewInvoices.DataSource = SQLHandler.SQLCommand("SELECT * FROM tbl_invoices;");
            dataGridViewProjects.DataSource = SQLHandler.SQLCommand("SELECT * FROM tbl_customers;");
            dataGridViewAppointments.DataSource = SQLHandler.SQLCommand("SELECT * FROM tbl_appointments;");
        }

        private void LabelsProjects()
        {
            dataGridViewProjects.Rows[CustomerID].HeaderCell.Value = "Some text";
        }
    }
}
