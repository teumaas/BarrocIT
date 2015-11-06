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
using System.Drawing.Printing;
using System.IO;


namespace BarrocIT
{
    public partial class frmInvoices : Form
    {
        private DatabaseHandler SQLHandler;
        private SqlCommand SQLCommand;
        private frmAddInvoices Add;
        private frmEditInvoices Edit;
        private frmMain Main;

        private int CustomerID;
        private int ProjectID;
        private string Username;
        private string dateAndTime;

        public frmInvoices(string User, int CID, frmMain Main)
        {
            InitializeComponent();
            CustomerID = CID;
            Username = User;
            this.Main = Main;

            SQLHandler = new DatabaseHandler();

            refreshDataGridView();

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
    
        private void btnInvoicesAdd_Click(object sender, EventArgs e)
        {
            Add = new frmAddInvoices(CustomerID, ProjectID, this);
            this.Enabled = false;
            Add.Show();
        }

        private void btnInvoicesEdit_Click(object sender, EventArgs e)
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

        private void btnInvoicesRemove_Click(object sender, EventArgs e)
        {
            try
            {
                object InvoiceID = dataGridAddInvoice.CurrentRow.Cells[0].Value;

                SQLHandler.deleteFROMbyObject(InvoiceID, "InvoiceID", "tbl_invoices");
                refreshDataGridView();
            }
            catch
            {
            }
        }

        private void frmInvoices_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.Enabled = true;
        }

        public void refreshDataGridView()
        {
            dataGridAddInvoice.DataSource = SQLHandler.SQLCommand("SELECT * FROM tbl_invoices WHERE CustomerID = '" + CustomerID + "';");
        }

        private void btnInvoicesPrintInvoice_Click(object sender, EventArgs e)
        {
            try
            {

                string dateTime = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
                dateAndTime = dateTime;
                string mydocpath = Application.ExecutablePath.Remove(Application.ExecutablePath.Length - 23) + "/Invoices";
                
                string[] streamData = new string[13];

                streamData[0] = "Barroc IT";
                streamData[1] = "";
                streamData[2] = "Factuur nummer:                 " + dataGridAddInvoice.CurrentRow.Cells[0].Value.ToString();
                streamData[3] = "Klant nummer:                   " + dataGridAddInvoice.CurrentRow.Cells[1].Value.ToString();
                streamData[4] = "Project nummer:                 " + dataGridAddInvoice.CurrentRow.Cells[2].Value.ToString();
                streamData[5] = "Aanmaak datum van offerte:      " + dataGridAddInvoice.CurrentRow.Cells[3].Value.ToString();
                streamData[6] = "de factuur is betaald:          " + dataGridAddInvoice.CurrentRow.Cells[4].Value.ToString();
                streamData[7] = "factuur is verzonden:           " + dataGridAddInvoice.CurrentRow.Cells[5].Value.ToString();
                streamData[8] = "status van de factuur:          " + dataGridAddInvoice.CurrentRow.Cells[6].Value.ToString();
                streamData[9] = "Factuur termijnen:              " + dataGridAddInvoice.CurrentRow.Cells[7].Value.ToString();
                streamData[10] = "laatste datum van contact:     " + dataGridAddInvoice.CurrentRow.Cells[8].Value.ToString();
                streamData[11] = "ledgerAccount:                 " + dataGridAddInvoice.CurrentRow.Cells[9].Value.ToString();
                streamData[12] = "BTW code:                      " + dataGridAddInvoice.CurrentRow.Cells[10].Value.ToString();             

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

        private void frmInvoices_Validating(object sender, CancelEventArgs e)
        {
            refreshDataGridView();
        }

        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/GitHub/BarrocIT/Barroc IT - Code/invoices";
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
