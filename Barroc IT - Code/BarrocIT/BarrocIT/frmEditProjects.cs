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
    public partial class frmEditProjects : Form
    {
        private DatabaseHandler SQLHandler;
        private SqlCommand SQLCommand;
        private frmProjects frmproject;

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

            ProjectID = PID;
            CustomerID = ID;
            ProjectName = PName;
            ProjectStatus = PStatus;
            ProjectPrice = PPrice;
            ProjectLimit = PLimit;
            MaintenanceContact = MaintenanceC;

            try
            {
                txtProjectID.Text = Convert.ToString(ProjectID);
                txtCustomerID.Text = Convert.ToString(CustomerID);
                txtProjectName.Text = ProjectName;
                cmbProjectStatus.SelectedIndex = int.Parse(Convert.ToString(ProjectStatus).Replace("False", "0").Replace("True", "1"));
                txtProjectPrice.Text = Convert.ToString(ProjectPrice);
                txtProjectLimit.Text = Convert.ToString(ProjectLimit);
                cmbMaintenceContact.SelectedIndex = int.Parse(Convert.ToString(MaintenanceContact).Replace("False", "0").Replace("True", "1"));
            }
            catch
            {
            }            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
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
                this.Close();
            }
            catch
            {
                MessageBox.Show("Please make sure everything is entered correctly!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmproject.Enabled = true;
            this.Close();
        }

        private void cmbProjectStatus_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cmbMaintenceContact_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void frmEditProjects_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmproject.Enabled = true;
        }
    }
}
