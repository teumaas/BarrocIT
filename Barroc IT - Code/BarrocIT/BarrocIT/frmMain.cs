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
    public partial class frmMain : Form
    {
        DatabaseHandler SQLHandler;
        SqlCommand SQLCommand;
        ImageList Tabs;
        frmLogin Login;
        frmAddCustomers Add;
        frmEditCustomers Edit;
        frmProjects Projects;
        frmInvoices Invoices;
        frmAppointments Appointments;
        frmHelp Help;

        private string Username;

        public frmMain(string User)
        {
            InitializeComponent();

            SQLHandler = new DatabaseHandler();

            FillDataGrids();

            Tabs = new ImageList();
            Tabs.Images.Add(Properties.Resources.Departments);
            Tabs.Images.Add(Properties.Resources.Invoice);
            Tabs.Images.Add(Properties.Resources.Project);
            Tabs.Images.Add(Properties.Resources.Calendar);

            tabConDepartments.ImageList = Tabs;
            tabCustomers.ImageIndex = 0;
            tabInvoices.ImageIndex = 1;
            tabProjects.ImageIndex = 2;
            tabAppointments.ImageIndex = 3;

            for (int i = 0; i <= 16; i++)
            {
                dataGridViewCustomers.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewInvoices.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewProjects.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewAppointments.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            Username = User;
            lblWhoami.Text += Username;

            if (Username == "Finance" || Username == "Development")
            {
                btnCustomersAdd.Enabled = false;
                btnCustomersEdit.Enabled = false;
                btnCustomersRemove.Enabled = false;
            }
            if (Username == "Sales" || Username == "Development")
            {
                tabConDepartments.TabPages.Remove(tabInvoices);
            }

            // Labels toevoegen??
            //dataGridViewCustomers.Columns[1].HeaderText = "Customer Name";

        }
        private void btnCustomersAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Add = new frmAddCustomers(this);
                this.Enabled = false;
                Add.Show();
            }
            catch { }
        }

        private void btnCustomersEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int CustomerID = (int)dataGridViewCustomers.CurrentRow.Cells[0].Value;
                string CustomerName = (string)dataGridViewCustomers.CurrentRow.Cells[1].Value;
                string CustomerAdress1 = (string)dataGridViewCustomers.CurrentRow.Cells[2].Value;
                string CustomerAdress2 = dataGridViewCustomers.CurrentRow.Cells[3].Value.ToString();
                string CustomerCity1 = (string)dataGridViewCustomers.CurrentRow.Cells[4].Value;
                string CustomerCity2 = dataGridViewCustomers.CurrentRow.Cells[5].Value.ToString();
                string CustomerPhoneNumber1 = (string)dataGridViewCustomers.CurrentRow.Cells[6].Value;
                string CustomerPhoneNumber2 = dataGridViewCustomers.CurrentRow.Cells[7].Value.ToString();
                string CustomerZipCode1 = (string)dataGridViewCustomers.CurrentRow.Cells[8].Value;
                string CustomerZipCode2 = dataGridViewCustomers.CurrentRow.Cells[9].Value.ToString();
                string CustomerFaxNumber = dataGridViewCustomers.CurrentRow.Cells[10].Value.ToString();
                string CustomerContactPerson = (string)dataGridViewCustomers.CurrentRow.Cells[11].Value;
                string CustomerEmail = (string)dataGridViewCustomers.CurrentRow.Cells[12].Value;
                string CustomerBankNumber = (string)dataGridViewCustomers.CurrentRow.Cells[13].Value;
                bool CustomerCreditWorthy = (bool)dataGridViewCustomers.CurrentRow.Cells[14].Value;
                bool CustomerBKRCheck = (bool)dataGridViewCustomers.CurrentRow.Cells[15].Value;
                bool CustomerPotential = (bool)dataGridViewCustomers.CurrentRow.Cells[16].Value;

                Edit = new frmEditCustomers(CustomerID, CustomerName, CustomerAdress1, CustomerAdress2, CustomerCity1, CustomerCity2, CustomerPhoneNumber1, CustomerPhoneNumber2, CustomerZipCode1, CustomerZipCode2, CustomerFaxNumber, CustomerContactPerson, CustomerEmail, CustomerBankNumber, CustomerCreditWorthy, CustomerBKRCheck, CustomerPotential, this);
                this.Enabled = false;
                Edit.Show();
            }
            catch {}
        }

        private void btnCustomersRemove_Click(object sender, EventArgs e)
        {
                object CustomerID = dataGridViewCustomers.CurrentRow.Cells[0].Value;

                SQLCommand = new SqlCommand("DELETE FROM tbl_customers WHERE CustomerID = @CustomerID", SQLHandler.getConnection());

                SQLCommand.Parameters.AddWithValue("@CustomerID", CustomerID);

                SQLHandler.openConnection();
                SQLCommand.ExecuteNonQuery();
                SQLHandler.closeConnection();
                FillDataGrids();
        }

        private void btnInvoicesView_Click(object sender, EventArgs e)
        {
            try
            {
                int CustomerID = (int)dataGridViewInvoices.CurrentRow.Cells[0].Value;

                Invoices = new frmInvoices(Username, CustomerID, this);
                this.Enabled = false;
                Invoices.Show();
            }
            catch {}
        }

        private void btnProjectsView_Click(object sender, EventArgs e)
        {
            try
            {
                int CustomerID = (int)dataGridViewProjects.CurrentRow.Cells[0].Value;

                Projects = new frmProjects(Username, CustomerID, this);
                this.Enabled = false;
                Projects.Show();
            }
            catch {}
        }

        private void btnAppointmentsView_Click(object sender, EventArgs e)
        {
            try
            {
                int CustomerID = (int)dataGridViewAppointments.CurrentRow.Cells[0].Value;

                Appointments = new frmAppointments(Username, CustomerID, this);
                this.Enabled = false;
                Appointments.Show();
            }
            catch {}
        }

        private void itemRefresh_Click(object sender, EventArgs e)
        {
            FillDataGrids();
        }

        private void itemSignout_Click(object sender, EventArgs e)
        {
            Login = new frmLogin();
            SQLHandler.closeConnection();
            this.Close();
            Application.Restart();
        }

        private void itemExit_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Are you sure you want to exit.", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (exit == DialogResult.Yes)
            {
                SQLHandler.closeConnection();
                Application.Exit();
            }
        }
        private void itemInfo_Click(object sender, EventArgs e)
        {
            Help = new frmHelp(this);
            this.Enabled = false;
            Help.Show();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            SQLHandler.closeConnection();
            Application.Exit();
        }

        public void FillDataGrids()
        {
            dataGridViewCustomers.DataSource = SQLHandler.SQLCommand("SELECT * FROM tbl_customers;");
            dataGridViewInvoices.DataSource = SQLHandler.SQLCommand("SELECT * FROM tbl_customers;");
            dataGridViewProjects.DataSource = SQLHandler.SQLCommand("SELECT * FROM tbl_customers;");
            dataGridViewAppointments.DataSource = SQLHandler.SQLCommand("SELECT * FROM tbl_customers;");
        }

        private void tabConDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabConDepartments.SelectedTab == tabCustomers)
            {
                this.Text = "Barroc IT - Customers";
            }
            if (tabConDepartments.SelectedTab == tabInvoices)
            {
                this.Text = "Barroc IT - Invoices";
            }
            if (tabConDepartments.SelectedTab == tabProjects)
            {
                this.Text = "Barroc IT - Projects";
            }
            if (tabConDepartments.SelectedTab == tabAppointments)
            {
                this.Text = "Barroc IT - Appointments";
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}