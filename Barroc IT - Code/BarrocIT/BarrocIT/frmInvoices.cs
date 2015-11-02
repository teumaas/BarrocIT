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
    public partial class frmInvoices : Form
    {
        DatabaseHandler SQLHandler;
        SqlCommand SQLCommand;
        frmAddInvoices Add;
        frmEditInvoices Edit;
        frmMain Main;

        private int CustomerID;
        private int ProjectID;
        private string Username;

        public frmInvoices(string User, int CID, frmMain Main)
        {
            InitializeComponent();
            CustomerID = CID;
            Username = User;
            this.Main = Main;

            SQLHandler = new DatabaseHandler();

            dataGridAddInvoice.DataSource = SQLHandler.SQLCommand("SELECT * FROM tbl_invoices WHERE CustomerID = '"+ CustomerID + "';");

            for (int i = 0; i <= 10; i++)
            {
                dataGridAddInvoice.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            if (Username == "Sales" || Username == "Development")
            {
                btnInvoicesAdd.Enabled = false;
                btnInvoicesEdit.Enabled = false;
                btnInvoicesRemove.Enabled = false;
            }
        }

        private void frmInvoices_Validated(object sender, EventArgs e)
        {
            refreshDataGridView();
        }

        public void refreshDataGridView()
        {
            dataGridAddInvoice.DataSource = SQLHandler.SQLCommand("SELECT * FROM tbl_invoices WHERE CustomerID = '" + CustomerID + "';");
        }
    
        private void btnInvoicesAdd_Click(object sender, EventArgs e)
        {
            Add = new frmAddInvoices(CustomerID, ProjectID, this);
            this.Enabled = false;
            Add.Show();
        }

        private void btnInvoicesEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int InvoiceID = (int)dataGridAddInvoice.CurrentRow.Cells[0].Value;
                int CustomerID = (int)dataGridAddInvoice.CurrentRow.Cells[1].Value;
                int ProjectID = (int)dataGridAddInvoice.CurrentRow.Cells[2].Value;
                DateTime InvoiceDate = (DateTime)dataGridAddInvoice.CurrentRow.Cells[3].Value;
                bool InvoicePaid = (bool)dataGridAddInvoice.CurrentRow.Cells[4].Value;
                bool InvoiceSent = (bool)dataGridAddInvoice.CurrentRow.Cells[5].Value;
                bool InvoiceStatus = (bool)dataGridAddInvoice.CurrentRow.Cells[6].Value;
                string InvoiceTerms = (string)dataGridAddInvoice.CurrentRow.Cells[7].Value;
                DateTime LastContactDate = (DateTime)dataGridAddInvoice.CurrentRow.Cells[8].Value;
                string LegderAccountNumber = (string)dataGridAddInvoice.CurrentRow.Cells[9].Value;
                string TaxCode = (string)dataGridAddInvoice.CurrentRow.Cells[10].Value;

                Edit = new frmEditInvoices(InvoiceID, CustomerID, ProjectID, InvoiceDate, InvoicePaid, InvoiceSent, InvoiceStatus, InvoiceTerms, LastContactDate, LegderAccountNumber, TaxCode, this);
                this.Enabled = false;
                Edit.Show();
            }
            catch
            {
            }
        }

        private void btnInvoicesRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int InvoiceID = (int)dataGridAddInvoice.CurrentRow.Cells[0].Value;

                SQLCommand = new SqlCommand("DELETE FROM tbl_Invoices WHERE InvoiceID = '" + InvoiceID + "'", SQLHandler.getConnection());

                SQLHandler.openConnection();
                SQLCommand.ExecuteNonQuery();
                SQLHandler.closeConnection();

                refreshDataGridView();
                SQLHandler.closeConnection();
            }
            catch
            {
            }
        }

        private void btnInvoicesPrintInvoice_Click(object sender, EventArgs e)
        {

        }

        private void frmInvoices_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.Enabled = true;
        }
    }
}
