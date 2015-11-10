// Made by Tom Smits..

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Data.SqlClient;


namespace BarrocIT
{
    public partial class frmProjects : Form
    {
        private DatabaseHandler SQLHandler;
        private SqlCommand SQLCommand;
        private frmAddProjects Add;
        private frmEditProjects Edit;
        private frmMain Main;

        private int CustomerID;
        private string Username;
            
        public frmProjects(string User, int ID, frmMain Main)
        {
            InitializeComponent();
            CustomerID = ID;
            Username = User;
            this.Main = Main;

            SQLHandler = new DatabaseHandler();

            refreshDataGridView();

            for (int i = 0; i <= 6; i++)
            {
                dataGridAddProject.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            if (Username == "Finance")
            {
                btnProjectAdd.Enabled = false;
                btnProjectEdit.Enabled = false;
                btnProjectRemove.Enabled = false;
            }
            if (Username == "Finance")
            {
                btnProjectAdd.Enabled = false;
            }
            if (Username == "Development")
            {
                btnProjectAdd.Enabled = false;
                btnProjectRemove.Enabled = false;
            }
        }

        private void btnProjectAdd_Click(object sender, EventArgs e)
        {
            Add = new frmAddProjects(CustomerID, this);
            this.Enabled = false;
            Add.Show();
        }

        private void btnProjectEdit_Click(object sender, EventArgs e)
        {
            int ProjectID = (int)dataGridAddProject.CurrentRow.Cells[0].Value;
            string ProjectName = (string)dataGridAddProject.CurrentRow.Cells[2].Value;
            bool ProjectStatus = (bool)dataGridAddProject.CurrentRow.Cells[3].Value;
            int ProjectPrice = (int)dataGridAddProject.CurrentRow.Cells[4].Value;
            int ProjectLimit = (int)dataGridAddProject.CurrentRow.Cells[5].Value;
            bool MaintenanceContact = (bool)dataGridAddProject.CurrentRow.Cells[6].Value;

            Edit = new frmEditProjects(CustomerID, ProjectID, ProjectName, ProjectStatus, ProjectPrice, ProjectLimit, MaintenanceContact, this);
            this.Enabled = false;
            Edit.Show();
        }

        private void btnProjectRemove_Click(object sender, EventArgs e)
        {
            DialogResult remove = MessageBox.Show("Do you really wish to remove this project?", "Remove", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (remove == DialogResult.Cancel)
            {

            }
            else if (remove == DialogResult.OK)
            {
                object ProjectID = dataGridAddProject.CurrentRow.Cells[0].Value;

                SQLHandler.deleteFROMbyObject(ProjectID, "ProjectID", "tbl_projects");
                refreshDataGridView();
                checkifDataGridisEmpty();
            }
        }

        public void refreshDataGridView()
        {
            SQLCommand = new SqlCommand();

            dataGridAddProject.DataSource = SQLHandler.SQLCommand("SELECT * FROM tbl_projects WHERE CustomerID = '" + CustomerID + "';");
            checkifDataGridisEmpty();
        }

        public void checkifDataGridisEmpty()
        {
            if (dataGridAddProject.Rows.Count == 0)
            {
                btnProjectRemove.Enabled = false;
                btnProjectEdit.Enabled = false;
            }
            else
            {
                btnProjectRemove.Enabled = true;
                btnProjectEdit.Enabled = true;
            }
        }

        private void frmProjects_Validated(object sender, EventArgs e)
        {
            refreshDataGridView();
        }

        private void frmProjects_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.Enabled = true;
        }
    }
}
