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
    public partial class frmAddInvoices : Form
    {
        DatabaseHandler SQLHandler;
        SqlCommand SQLCommand;
        frmInvoices frminvoices;

        private int InvoiceID;
        private int CustomerID;
        private int ProjectID;
        private DateTime InvoiceDate;
        private bool InvoicePaid;
        private bool InvoiceSent;
        private bool InvoiceStatus;
        private string InvoiceTerms;
        private DateTime LastContactDate;
        private string LedgerAccountNumber;
        private string TaxCode;

        public frmAddInvoices(int CID, int PID, frmInvoices frminvoices)
        {
            InitializeComponent();
            this.frminvoices = frminvoices;
            CustomerID = CID;
            ProjectID = PID;
            InvoiceDate = DateTime.Today;
            LastContactDate = DateTime.Today;


            SQLHandler = new DatabaseHandler();
            SQLCommand = new SqlCommand("SELECT MAX(CustomerID) FROM tbl_invoices", SQLHandler.getConnection());
            SQLCommand = new SqlCommand("SELECT MAX(ProjectID) FROM tbl_invoices", SQLHandler.getConnection());

            int IID;
            int.TryParse(SQLHandler.GetFirstValue("SELECT MAX(InvoiceID) FROM tbl_invoices").ToString(), out IID);
            IID++;

            txtInvoiceID.Text = IID.ToString();
            txtCustomerID.Text = Convert.ToString(CustomerID);
            dtpInvoiceDate.Text = Convert.ToString(InvoiceDate);
            dtpLastContactDate.Text = Convert.ToString(LastContactDate);

            SQLHandler.closeConnection();          
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            frminvoices.Enabled = true;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                SQLHandler = new DatabaseHandler();
                SQLCommand = new SqlCommand("INSERT INTO tbl_invoices (CustomerID, ProjectID, InvoiceDate, InvoicePaid, InvoiceSent, InvoiceStatus, InvoiceTerms, LastContactDate, LedgerAccNum, TaxCode) VALUES (@CustomerID, @ProjectID, @InvoiceDate, @InvoicePaid, @InvoiceSent, @InvoiceStatus, @InvoiceTerms, @LastContactDate, @LedgerAccNum, @TaxCode)", SQLHandler.getConnection());

                InvoiceID = Convert.ToInt32(txtInvoiceID.Text);
                CustomerID = Convert.ToInt32(txtCustomerID.Text);
                ProjectID = Convert.ToInt32(txtProjectID.Text);
                InvoiceDate = Convert.ToDateTime(dtpInvoiceDate.Text);
                InvoicePaid = Convert.ToBoolean(cmbInvoicePaid.SelectedIndex);
                InvoiceSent = Convert.ToBoolean(cmbInvoiceSent.SelectedIndex);
                InvoiceStatus = Convert.ToBoolean(cmbInvoiceStatus.SelectedIndex);
                InvoiceTerms = Convert.ToString(txtInvoiceTerms.Text);
                LastContactDate = Convert.ToDateTime(dtpLastContactDate.Text);
                LedgerAccountNumber = Convert.ToString(txtLedgerContactNumber.Text);
                TaxCode = Convert.ToString(txtTaxCode.Text);

                SQLCommand.Parameters.AddWithValue("@InvoiceID", InvoiceID);
                SQLCommand.Parameters.AddWithValue("@CustomerID", CustomerID);
                SQLCommand.Parameters.AddWithValue("@ProjectID", ProjectID);
                SQLCommand.Parameters.AddWithValue("@InvoiceDate", InvoiceDate);
                SQLCommand.Parameters.AddWithValue("@InvoicePaid", InvoicePaid);
                SQLCommand.Parameters.AddWithValue("@InvoiceSent", InvoiceSent);
                SQLCommand.Parameters.AddWithValue("@InvoiceStatus", InvoiceStatus);
                SQLCommand.Parameters.AddWithValue("@InvoiceTerms", InvoiceTerms);
                SQLCommand.Parameters.AddWithValue("@LastContactDate", LastContactDate);
                SQLCommand.Parameters.AddWithValue("@LedgerAccNum", LedgerAccountNumber);
                SQLCommand.Parameters.AddWithValue("@TaxCode", TaxCode);

                SQLHandler.openConnection();
                SQLCommand.ExecuteNonQuery();
                SQLHandler.closeConnection();

                frminvoices.refreshDataGridView();
                frminvoices.Enabled = true;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Please make sure everything is entered correctly!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbInvoicePaid_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cmbInvoiceSent_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cmbInvoiceStatus_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void frmAddInvoices_FormClosing(object sender, FormClosingEventArgs e)
        {
            frminvoices.Enabled = true;
        }
    }
}
