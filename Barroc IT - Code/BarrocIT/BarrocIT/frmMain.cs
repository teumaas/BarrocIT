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
using System.Drawing.Printing;
using System.IO;

namespace BarrocIT
{
    public partial class frmMain : Form
    {
        private DatabaseHandler SQLHandler;
        private SqlCommand SQLCommand;
        private ImageList Tabs;
        private frmLogin Login;
        private frmAddCustomers Add;
        private frmEditCustomers Edit;
        private frmProjects Projects;
        private frmInvoices Invoices;
        private frmAppointments Appointments;
        private frmHelp Help;
        private frmCalendar Calendar;
        private DataGridView[] Datagrids;

        private string Username;
        private string dateAndTime;

        public frmMain(string User)
        {
            InitializeComponent();

            SQLCommand = new SqlCommand();
            SQLHandler = new DatabaseHandler();
            Datagrids = new DataGridView[4] { dataGridViewCustomers, dataGridViewInvoices, dataGridViewProjects, dataGridViewAppointments };

            FillDataGrids("*", "tbl_customers");

            Tabs = new ImageList();
            Tabs.Images.Add(Properties.Resources.Departments);
            Tabs.Images.Add(Properties.Resources.Invoice);
            Tabs.Images.Add(Properties.Resources.Project);
            Tabs.Images.Add(Properties.Resources.Appointment);

            tabConDepartments.ImageList = Tabs;
            tabCustomers.ImageIndex = 0;
            tabInvoices.ImageIndex = 1;
            tabProjects.ImageIndex = 2;
            tabAppointments.ImageIndex = 3;

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
        }
        private void btnCustomersAdd_Click(object sender, EventArgs e)
        {
            Add = new frmAddCustomers(this);
            this.Enabled = false;
            Add.Show();
        }

        private void btnCustomersEdit_Click(object sender, EventArgs e)
        {
            int CustomerID = (int)dataGridViewCustomers.CurrentRow.Cells[0].Value;
            string CustomerName = (string)dataGridViewCustomers.CurrentRow.Cells[1].Value;
            string CustomerCompany = (string)dataGridViewCustomers.CurrentRow.Cells[2].Value;
            string CustomerAdress1 = (string)dataGridViewCustomers.CurrentRow.Cells[3].Value;
            string CustomerAdress2 = dataGridViewCustomers.CurrentRow.Cells[4].Value.ToString();
            string CustomerCity1 = (string)dataGridViewCustomers.CurrentRow.Cells[5].Value;
            string CustomerCity2 = dataGridViewCustomers.CurrentRow.Cells[6].Value.ToString();
            string CustomerPhoneNumber1 = (string)dataGridViewCustomers.CurrentRow.Cells[7].Value;
            string CustomerPhoneNumber2 = dataGridViewCustomers.CurrentRow.Cells[8].Value.ToString();
            string CustomerZipCode1 = (string)dataGridViewCustomers.CurrentRow.Cells[9].Value;
            string CustomerZipCode2 = dataGridViewCustomers.CurrentRow.Cells[10].Value.ToString();
            string CustomerFaxNumber = dataGridViewCustomers.CurrentRow.Cells[11].Value.ToString();
            string CustomerContactPerson = (string)dataGridViewCustomers.CurrentRow.Cells[12].Value;
            string CustomerEmail = (string)dataGridViewCustomers.CurrentRow.Cells[13].Value;
            string CustomerBankNumber = (string)dataGridViewCustomers.CurrentRow.Cells[14].Value;
            bool CustomerCreditWorthy = (bool)dataGridViewCustomers.CurrentRow.Cells[15].Value;
            bool CustomerBKRCheck = (bool)dataGridViewCustomers.CurrentRow.Cells[16].Value;
            bool CustomerPotential = (bool)dataGridViewCustomers.CurrentRow.Cells[17].Value;

            Edit = new frmEditCustomers(CustomerID, CustomerName, CustomerCompany, CustomerAdress1, CustomerAdress2, CustomerCity1, CustomerCity2, CustomerPhoneNumber1, CustomerPhoneNumber2, CustomerZipCode1, CustomerZipCode2, CustomerFaxNumber, CustomerContactPerson, CustomerEmail, CustomerBankNumber, CustomerCreditWorthy, CustomerBKRCheck, CustomerPotential, this);
            this.Enabled = false;
            Edit.Show();
        }

        private void btnCustomersRemove_Click(object sender, EventArgs e)
        {
            DialogResult remove = MessageBox.Show("Do you really wish to remove this customer?", "Remove", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (remove == DialogResult.Cancel)
            {
            }
            else if (remove == DialogResult.OK)
            {
                try
                {
                    object CustomerID = dataGridViewCustomers.CurrentRow.Cells[0].Value;

                    SQLHandler.deleteFROMbyObject(CustomerID, "CustomerID", "tbl_customers");

                    FillDataGrids("*", "tbl_customers");
                    checkifDataGridisEmpty();
                }
                catch
                {
                    MessageBox.Show("There are still projects/invoices/appointments bound to this customer.", "Caution!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    FillDataGrids("*", "tbl_customers");
                }
            }
        }

        private void btnInvoicesView_Click(object sender, EventArgs e)
        {
            int CustomerID = (int) dataGridViewInvoices.CurrentRow.Cells[0].Value;

            Invoices = new frmInvoices(Username, CustomerID, this);
            this.Enabled = false;
            Invoices.Show();
        }

        private void btnProjectsView_Click(object sender, EventArgs e)
        {
            int CustomerID = (int) dataGridViewProjects.CurrentRow.Cells[0].Value;

            Projects = new frmProjects(Username, CustomerID, this);
            this.Enabled = false;
            Projects.Show();
        }

        private void btnAppointmentsView_Click(object sender, EventArgs e)
        {
            int CustomerID = (int) dataGridViewAppointments.CurrentRow.Cells[0].Value;

            Appointments = new frmAppointments(Username, CustomerID, this);
            this.Enabled = false;
            Appointments.Show();
        }

        private void itemRefresh_Click(object sender, EventArgs e)
        {
            FillDataGrids("*", "tbl_customers");
        }

        private void itemSignout_Click(object sender, EventArgs e)
        {
            Login = new frmLogin();
            SQLHandler.closeConnection();
            this.Close();
            Application.Restart();
        }

        private void itemInfo_Click(object sender, EventArgs e)
        {
            Help = new frmHelp(this);
            this.Enabled = false;
            Help.Show();
        }

        public void FillDataGrids(string column,string table)
        {
            dataGridViewCustomers.DataSource = SQLHandler.SQLCommand("SELECT " + column + " FROM " + table + ";");
            dataGridViewInvoices.DataSource = SQLHandler.SQLCommand("SELECT " + column + " FROM " + table + ";");
            dataGridViewProjects.DataSource = SQLHandler.SQLCommand("SELECT " + column + " FROM " + table + ";");
            dataGridViewAppointments.DataSource = SQLHandler.SQLCommand("SELECT " + column + " FROM " + table + ";");

            for (int i = 0; i <= 16; i++)
            {
                dataGridViewCustomers.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewInvoices.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewProjects.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewAppointments.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            checkifDataGridisEmpty();
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

        private void btnAppointmentsCalendar_Click(object sender, EventArgs e)
        {
            Calendar = new frmCalendar(this);
            this.Enabled = false;
            Calendar.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult exit = MessageBox.Show("Do you really wish to exit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (exit == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else if (exit == DialogResult.OK)
            {
                e.Cancel = false;
                Application.ExitThread();
                Dispose();
                Application.Exit();
            }
        }

        public void checkifDataGridisEmpty()
        {
            if (dataGridViewCustomers.Rows.Count == 0)
            {
                btnCustomersRemove.Enabled = false;
                btnCustomersPrintInfo.Enabled = false;
                btnCustomersEdit.Enabled = false;
                btnProjectsView.Enabled = false;
                btnAppointmentsCalendar.Enabled = false;
                btnAppointmentsView.Enabled = false;
                btnInvoicesView.Enabled = false;
            }
            else
            {
                btnCustomersRemove.Enabled = true;
                btnCustomersPrintInfo.Enabled = true;
                btnCustomersEdit.Enabled = true;
                btnProjectsView.Enabled = true;
                btnAppointmentsCalendar.Enabled = true;
                btnAppointmentsView.Enabled = true;
                btnInvoicesView.Enabled = true;
            }
        }
        private void itemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Made by Santino Bonora
        private void btnCustomersPrintInfo_Click(object sender, EventArgs e)
        {
            try
            {

                string dateTime = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
                dateAndTime = dateTime;
                string mydocpath = Application.ExecutablePath.Remove(Application.ExecutablePath.Length - 23) + "/Invoices";

                string[] streamData = new string[19];

                streamData[0] = "Barroc IT";
                streamData[1] = "";
                streamData[2] = "Customer ID:                  " + dataGridViewCustomers.CurrentRow.Cells[0].Value.ToString();
                streamData[3] = "Name:                         " + dataGridViewCustomers.CurrentRow.Cells[1].Value.ToString();
                streamData[4] = "Adress 1:                     " + dataGridViewCustomers.CurrentRow.Cells[2].Value.ToString();
                streamData[5] = "Adress 2:                     " + dataGridViewCustomers.CurrentRow.Cells[3].Value.ToString();
                streamData[6] = "City 1:                       " + dataGridViewCustomers.CurrentRow.Cells[4].Value.ToString();
                streamData[7] = "City 2:                       " + dataGridViewCustomers.CurrentRow.Cells[5].Value.ToString();
                streamData[8] = "Phone Number 1:               " + dataGridViewCustomers.CurrentRow.Cells[6].Value.ToString();
                streamData[9] = "Phone Number 2:               " + dataGridViewCustomers.CurrentRow.Cells[7].Value.ToString();
                streamData[10] = "Zipcode 1:                    " + dataGridViewCustomers.CurrentRow.Cells[8].Value.ToString();
                streamData[11] = "Zipcode 2:                    " + dataGridViewCustomers.CurrentRow.Cells[9].Value.ToString();
                streamData[12] = "Fax Number:                   " + dataGridViewCustomers.CurrentRow.Cells[10].Value.ToString();
                streamData[13] = "Contact person:               " + dataGridViewCustomers.CurrentRow.Cells[11].Value.ToString();
                streamData[14] = "Email Adress:                 " + dataGridViewCustomers.CurrentRow.Cells[12].Value.ToString();
                streamData[15] = "Bank number:                  " + dataGridViewCustomers.CurrentRow.Cells[13].Value.ToString();
                streamData[16] = "Credit Worthy:                " + dataGridViewCustomers.CurrentRow.Cells[14].Value.ToString().Replace("False", "No").Replace("True", "Yes");
                streamData[17] = "BKR Check:                    " + dataGridViewCustomers.CurrentRow.Cells[15].Value.ToString().Replace("False", "Not done").Replace("True", "Done");
                streamData[18] = "Potential Customer:           " + dataGridViewCustomers.CurrentRow.Cells[16].Value.ToString().Replace("False", "No").Replace("True", "Yes");

                using (StreamWriter sw = new StreamWriter(mydocpath + @"\" + dateTime + ".txt"))
                {

                    foreach (string s in streamData)
                    {
                        sw.WriteLine(s);
                    }

                    sw.Close();
                    MessageBox.Show("Your document is beining prepared. \nWait a moment please.");
                    try
                    {
                        StreamReader streamToPrint = new StreamReader(mydocpath + @"\" + dateTime + ".txt");
                        try
                        {
                            PrintDocument pd = new PrintDocument();
                            pd.PrintPage += new PrintPageEventHandler
                               (this.pd_PrintPage);
                            pd.Print();
                        }
                        finally
                        {
                            streamToPrint.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Made by Santino Bonora
        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            string mydocpath = Application.ExecutablePath.Remove(Application.ExecutablePath.Length - 23) + "/Invoices";
            StreamReader streamToPrint = new StreamReader(mydocpath + @"\" + dateAndTime + ".txt");
            Font printFont = new Font("Arial", 10);
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            string line = null;

            linesPerPage = ev.MarginBounds.Height /
               printFont.GetHeight(ev.Graphics);

            while (count < linesPerPage &&
               ((line = streamToPrint.ReadLine()) != null))
            {
                yPos = topMargin + (count *
                   printFont.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(line, printFont, Brushes.Black,
                   leftMargin, yPos, new StringFormat());
                count++;
            }

            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
        }
    }
}