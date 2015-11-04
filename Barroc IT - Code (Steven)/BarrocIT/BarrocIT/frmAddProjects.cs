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

namespace BarrocIT
{
    public partial class frmAddProjects : Form
    {
        DatabaseHandler SQLHandler;
        SqlCommand SQLCommand;
        frmProjects frmproject;

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
            try
            {
                SQLCommand = new SqlCommand("INSERT INTO tbl_projects (ProjectID, CustomerID, ProjectName, ProjectStatus, ProjectPrice, ProjectLimit, MaintenanceContact) VALUES (@ProjectID, @CustomerID, @ProjectName, @ProjectStatus, @ProjectPrice, @ProjectLimit, @MaintenanceContact)", SQLHandler.getConnection());

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
                this.Close();
            }
            catch
            {
                MessageBox.Show("Please make sure everything is entered correctly!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
 
        private void btnCancel_Click(object sender, EventArgs e)
        {
            SQLHandler.closeConnection();
            frmproject.Enabled = true;
            this.Close();
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
            frmproject.Enabled = true;
        }
    }
}
