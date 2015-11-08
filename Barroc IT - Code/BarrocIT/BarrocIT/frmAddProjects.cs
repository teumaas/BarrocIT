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
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Text.RegularExpressions;

namespace BarrocIT
{
    public partial class frmAddProjects : Form
    {
        private DatabaseHandler SQLHandler;
        private SqlCommand SQLCommand;
        private frmProjects frmproject;
        private Regex Validator;

        private int CustomerID;
        private int ProjectID;
        private string ProjectName;
        private bool ProjectStatus;
        private int ProjectPrice;
        private int ProjectLimit;
        private bool MaintenanceContact;
        
        public frmAddProjects(int ID, frmProjects frmproject)
        {
            InitializeComponent();
            this.frmproject = frmproject;
            ProjectID = 0;
            CustomerID = ID;

            Validator = new Regex(@"[(a-z)(A-Z)(0-9)\s]");
            SQLHandler = new DatabaseHandler();
            SQLCommand = new SqlCommand("SELECT MAX(ProjectID) FROM tbl_projects", SQLHandler.getConnection());

            int temp;
            int.TryParse(SQLHandler.GetFirstValue("SELECT MAX(ProjectID) FROM tbl_projects").ToString(),out temp);
            temp++;

            txtProjectID.Text = temp.ToString();
            txtCustomerID.Text = Convert.ToString(CustomerID);

            SQLHandler.closeConnection();
        }
        
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!Validator.Match(txtProjectName.Text).Success)
            {
                txtProjectName.BackColor = Color.IndianRed;
            }
            if (!Validator.Match(txtProjectPrice.Text).Success)
            {
                txtProjectPrice.BackColor = Color.IndianRed;
            }
            if (!Validator.Match(txtProjectLimit.Text).Success)
            {
                txtProjectLimit.BackColor = Color.IndianRed;
            }
            if (Validator.Match(txtProjectName.Text).Success && Validator.Match(txtProjectPrice.Text).Success && Validator.Match(txtProjectLimit.Text).Success)
            {
                SQLCommand = new SqlCommand("INSERT INTO tbl_projects (ProjectID, CustomerID, ProjectName, ProjectStatus, ProjectPrice, ProjectLimit, MaintenanceContact) VALUES (@ProjectID, @CustomerID, @ProjectName, @ProjectStatus, @ProjectPrice, @ProjectLimit, @MaintenanceContact)",SQLHandler.getConnection());

                CustomerID = Convert.ToInt32(txtCustomerID.Text);
                ProjectID = Convert.ToInt32(txtProjectID.Text);
                ProjectName = txtProjectName.Text;
                ProjectStatus = Convert.ToBoolean(cmbProjectStatus.SelectedIndex);
                ProjectPrice = Convert.ToInt32(txtProjectPrice.Text);
                ProjectLimit = Convert.ToInt32(txtProjectLimit.Text);
                MaintenanceContact = Convert.ToBoolean(cmbMaintenceContact.SelectedIndex);

                SQLCommand.Parameters.AddWithValue("@CustomerID", CustomerID);
                SQLCommand.Parameters.AddWithValue("@ProjectID", ProjectID);
                SQLCommand.Parameters.AddWithValue("@ProjectName", ProjectName);
                SQLCommand.Parameters.AddWithValue("@ProjectStatus", ProjectStatus);
                SQLCommand.Parameters.AddWithValue("@ProjectPrice", ProjectPrice);
                SQLCommand.Parameters.AddWithValue("@ProjectLimit", ProjectLimit);
                SQLCommand.Parameters.AddWithValue("@MaintenanceContact", MaintenanceContact);

                SQLHandler.openConnection();
                SQLCommand.ExecuteNonQuery();
                SQLHandler.closeConnection();

                frmproject.refreshDataGridView();
                frmproject.Enabled = true;
                Dispose();
                frmproject.Activate();
            }
        }
 
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Do you really wish to cancel?", "Cancel", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (exit == DialogResult.OK)
            {
                frmproject.Enabled = true;
                Dispose();
                frmproject.Activate();
            }
        }

        private void cmbMaintenceContact_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cmbProjectStatus_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void frmAddProjects_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult exit = MessageBox.Show("Do you really wish to cancel?", "Cancel", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (exit == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else if (exit == DialogResult.OK)
            {
                e.Cancel = false;
                frmproject.Enabled = true;
            }
        }

        private void txtProjectPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtProjectLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtProjectPrice_Enter(object sender, EventArgs e)
        {
            Clipboard.Clear();
        }

        private void txtProjectLimit_Enter(object sender, EventArgs e)
        {
            Clipboard.Clear();
        }

        private void txtProjectName_KeyDown(object sender, KeyEventArgs e)
        {
            txtProjectName.BackColor = SystemColors.Window;
        }

        private void txtProjectPrice_KeyDown(object sender, KeyEventArgs e)
        {
            txtProjectPrice.BackColor = SystemColors.Window;
        }

        private void txtProjectLimit_KeyDown(object sender, KeyEventArgs e)
        {
            txtProjectLimit.BackColor = SystemColors.Window;
        }

        private void cmbProjectStatus_Click(object sender, EventArgs e)
        {
            cmbProjectStatus.DroppedDown = true;
        }

        private void cmbMaintenceContact_Click(object sender, EventArgs e)
        {
            cmbMaintenceContact.DroppedDown = true;
        }
    }
}
