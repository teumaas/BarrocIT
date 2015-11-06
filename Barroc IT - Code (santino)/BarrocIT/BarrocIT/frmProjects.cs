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
        DatabaseHandler SQLHandler;
        SqlCommand SQLCommand;
        frmAddProjects Add;
        frmEditProjects Edit;
        frmMain Main;

        private int CustomerID;
        private string Username;
            
        public frmProjects(string User, int ID, frmMain Main)
        {
            InitializeComponent();
            CustomerID = ID;
            Username = User;
            this.Main = Main;

            SQLHandler = new DatabaseHandler();

            dataGridAddProject.DataSource = SQLHandler.SQLCommand("SELECT * FROM tbl_projects WHERE CustomerID = '"+ CustomerID + "';");

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
            try
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
            catch
            {
            }
        }

        private void btnProjectRemove_Click(object sender, EventArgs e)
        {
            try
            {
                object ProjectID = dataGridAddProject.CurrentRow.Cells[0].Value;

                SQLCommand = new SqlCommand("DELETE FROM tbl_projects WHERE ProjectID = @ProjectID", SQLHandler.getConnection());

                SQLCommand.Parameters.AddWithValue("@ProjectID", ProjectID);
                SQLCommand.Parameters.AddWithValue("@CustomerID", CustomerID);

                SQLHandler.openConnection();
                SQLCommand.ExecuteNonQuery();
                SQLHandler.closeConnection();

                dataGridAddProject.DataSource = SQLHandler.SQLCommand("SELECT * FROM tbl_projects WHERE CustomerID = @CustomerID;");
                SQLHandler.closeConnection();
            }
            catch
            {
            }
        }

        private void frmProjects_Validated(object sender, EventArgs e)
        {
            dataGridAddProject.DataSource = SQLHandler.SQLCommand("SELECT * FROM tbl_projects WHERE CustomerID = '" + CustomerID + "';");
        }
        public void refreshDataGridView()
        {
            dataGridAddProject.DataSource = SQLHandler.SQLCommand("SELECT * FROM tbl_projects WHERE CustomerID = '" + CustomerID + "';");
        }

        private void frmProjects_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.Enabled = true;
        }
    }
}
