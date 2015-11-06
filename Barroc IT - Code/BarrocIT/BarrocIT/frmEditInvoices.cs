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
    public partial class frmEditInvoices : Form
    {
        private DatabaseHandler SQLHandler;
        private SqlCommand SQLCommand;
        private frmInvoices frminvoices;

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

        public frmEditInvoices(int IID, int CID, int PID, DateTime IDate, bool IPaid, bool ISent, bool IStatus, string ITerms, DateTime LCD, string LAN, string TCode, frmInvoices frminvoices)
        {
            InitializeComponent();
            this.frminvoices = frminvoices;

            InvoiceID = IID;
            CustomerID = CID;
            ProjectID = PID;
            InvoiceDate = IDate;
            InvoicePaid = IPaid;
            InvoiceSent = ISent;
            InvoiceStatus = IStatus;
            InvoiceTerms = ITerms;
            LastContactDate = LCD;
            LedgerAccountNumber = LAN;
            TaxCode = TCode;

                txtInvoiceID.Text = Convert.ToString(InvoiceID);
                txtCustomerID.Text = Convert.ToString(CustomerID);
                txtProjectID.Text = Convert.ToString(ProjectID);
                dtpInvoiceDate.Text = Convert.ToString(InvoiceDate);
                cmbInvoicePaid.SelectedIndex = int.Parse(Convert.ToString(InvoicePaid).Replace("False", "0").Replace("True", "1"));
                cmbInvoiceSent.SelectedIndex = int.Parse(Convert.ToString(InvoiceSent).Replace("False", "0").Replace("True", "1"));
                cmbInvoiceStatus.SelectedIndex = int.Parse(Convert.ToString(InvoiceStatus).Replace("False", "0").Replace("True", "1"));
                txtInvoiceTerms.Text = Convert.ToString(InvoiceTerms);
                dtpLastContactDate.Text = Convert.ToString(LastContactDate);
                txtLedgerContactNumber.Text = Convert.ToString(LedgerAccountNumber);
                txtTaxCode.Text = Convert.ToString(TaxCode);
             
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
               try
               {
                    SQLHandler = new DatabaseHandler();
                    SQLCommand = new SqlCommand("UPDATE tbl_invoices SET InvoiceDate = @InvoiceDate, InvoicePaid = @InvoicePaid, InvoiceSent = @InvoiceSent, InvoiceStatus = @InvoiceStatus, InvoiceTerms = @InvoiceTerms, LastContactDate = @LastContactDate, LedgerAccNum = @LedgerAccNum, TaxCode = @TaxCode WHERE @InvoiceID = InvoiceID", SQLHandler.getConnection());

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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frminvoices.Enabled = true;
            this.Close();
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

        private void frmEditInvoices_FormClosing(object sender, FormClosingEventArgs e)
        {
            frminvoices.Enabled = true;
        }
    }
}
