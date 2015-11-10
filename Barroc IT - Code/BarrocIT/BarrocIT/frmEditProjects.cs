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
using System.Text.RegularExpressions;

namespace BarrocIT
{
    public partial class frmEditProjects : Form
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

        public frmEditProjects(int ID, int PID, string PName, bool PStatus, int PPrice, int PLimit, bool MaintenanceC, frmProjects frmproject)
        {
            InitializeComponent();
            this.frmproject = frmproject;

            Validator = new Regex(@"[(a-z)(A-Z)(0-9)\s]");

            ProjectID = PID;
            CustomerID = ID;
            ProjectName = PName;
            ProjectStatus = PStatus;
            ProjectPrice = PPrice;
            ProjectLimit = PLimit;
            MaintenanceContact = MaintenanceC;

            txtProjectID.Text = Convert.ToString(ProjectID);
            txtCustomerID.Text = Convert.ToString(CustomerID);
            txtProjectName.Text = ProjectName;
            cmbProjectStatus.SelectedIndex = int.Parse(Convert.ToString(ProjectStatus).Replace("False", "0").Replace("True", "1"));
            txtProjectPrice.Text = Convert.ToString(ProjectPrice);
            txtProjectLimit.Text = Convert.ToString(ProjectLimit);
            cmbMaintenceContact.SelectedIndex = int.Parse(Convert.ToString(MaintenanceContact).Replace("False", "0").Replace("True", "1"));       
        }

        private void btnSave_Click(object sender, EventArgs e)
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
                SQLHandler = new DatabaseHandler();
                SQLCommand = new SqlCommand("UPDATE tbl_projects SET ProjectName = @ProjectName, ProjectStatus = @ProjectStatus, ProjectPrice = @ProjectPrice, ProjectLimit = @ProjectLimit, MaintenanceContact = @MaintenanceContact WHERE @ProjectID = ProjectID", SQLHandler.getConnection());

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

        private void frmEditProjects_FormClosing(object sender, FormClosingEventArgs e)
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

        private void cmbProjectStatus_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cmbMaintenceContact_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
    }
}
