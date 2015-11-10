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
    public partial class frmAddInvoices : Form
    {
        private DatabaseHandler SQLHandler;
        private SqlCommand SQLCommand;
        private frmInvoices frminvoices;
        private Regex Validator;

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

            Validator = new Regex(@"[(a-z)(A-Z)(0-9)\s]");
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
            DialogResult exit = MessageBox.Show("Do you really wish to cancel?", "Cancel", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (exit == DialogResult.OK)
            {
                frminvoices.Enabled = true;
                Dispose();
                frminvoices.Activate();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validator.Match(txtProjectID.Text).Success)
                {
                    txtProjectID.BackColor = Color.IndianRed;
                }
                if (!Validator.Match(txtInvoiceTerms.Text).Success)
                {
                    txtInvoiceTerms.BackColor = Color.IndianRed;
                }
                if (!Validator.Match(txtLedgerContactNumber.Text).Success)
                {
                    txtLedgerContactNumber.BackColor = Color.IndianRed;
                }
                if (!Validator.Match(txtTaxCode.Text).Success)
                {
                    txtTaxCode.BackColor = Color.IndianRed;
                }
                if (Validator.Match(txtProjectID.Text).Success && Validator.Match(txtInvoiceTerms.Text).Success && Validator.Match(txtLedgerContactNumber.Text).Success && Validator.Match(txtTaxCode.Text).Success)
                {
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
                    Dispose();
                    frminvoices.Activate();
                }
            }
            catch
            {
                MessageBox.Show("Project ID invaild!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmAddInvoices_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult exit = MessageBox.Show("Do you really wish to cancel?", "Cancel", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (exit == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else if (exit == DialogResult.OK)
            {
                e.Cancel = false;
                frminvoices.Enabled = true;
            }
        }

        private void txtProjectID_KeyDown(object sender, KeyEventArgs e)
        {
            txtProjectID.BackColor = SystemColors.Window;
        }

        private void txtInvoiceTerms_KeyDown(object sender, KeyEventArgs e)
        {
            txtInvoiceTerms.BackColor = SystemColors.Window;
        }

        private void txtLedgerContactNumber_KeyDown(object sender, KeyEventArgs e)
        {
            txtLedgerContactNumber.BackColor = SystemColors.Window;
        }

        private void txtTaxCode_KeyDown(object sender, KeyEventArgs e)
        {
            txtTaxCode.BackColor = SystemColors.Window;
        }

        private void cmbInvoicePaid_Click(object sender, EventArgs e)
        {
            cmbInvoicePaid.DroppedDown = true;
        }

        private void cmbInvoiceSent_Click(object sender, EventArgs e)
        {
            cmbInvoiceSent.DroppedDown = true;
        }

        private void cmbInvoiceStatus_Click(object sender, EventArgs e)
        {
            cmbInvoiceStatus.DroppedDown = true;
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
    }
}
