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
    public partial class frmAddCustomers : Form
    {
        DatabaseHandler SQLHandler;
        SqlCommand SQLCommand;
        frmMain frmmain;

        private int CustomerID;
        private string CustomerName;
        private string CustomerAdress1;
        private string CustomerAdress2;
        private string CustomerCity1;
        private string CustomerCity2;
        private string CustomerPhoneNumber1;
        private string CustomerPhoneNumber2;
        private string CustomerZipCode1;
        private string CustomerZipCode2;
        private string CustomerFaxNumber;
        private string CustomerContactPerson;
        private string CustomerEmail;
        private string CustomerBankNumber;
        private bool CustomerCreditWorthy;
        private bool CustomerBKRCheck;
        private bool CustomerPotential;

        public frmAddCustomers(frmMain frmmain)
        {
            InitializeComponent();
            this.frmmain = frmmain;
            CustomerID = 0;

            SQLHandler = new DatabaseHandler();

            int CID;
            int.TryParse(SQLHandler.GetFirstValue("SELECT MAX(CustomerID) FROM tbl_customers").ToString(), out CID);
            CID++;

            txtCustomerID.Text = CID.ToString();

            SQLHandler.closeConnection();          
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                SQLCommand = new SqlCommand("INSERT INTO tbl_customers (CustomerID, CustomerName, Adress1, Adress2, City1, City2, PhoneNum1, PhoneNum2, ZipCode1, ZipCode2, FaxNum, ContactPerson, Email, BankNum, CreditWorthy, BKRCheck, PotentialCustomer) VALUES (@CustomerID, @CustomerName, @CustomerAdress1, @CustomerAdress2, @CustomerCity1, @CustomerCity2, @CustomerPhoneNumber1, @CustomerPhoneNumber2, @CustomerZipCode1, @CustomerZipCode2, @CustomerFaxNumber, @CustomerContactPerson, @CustomerEmail, @CustomerBankNumber, @CustomerCreditWorthy, @CustomerBKRCheck, @CustomerPotential)", SQLHandler.getConnection());

                CustomerID = Convert.ToInt32(txtCustomerID.Text);
                CustomerName = txtCustomerName.Text;
                CustomerAdress1 = txtCustomerAdress1.Text;
                CustomerAdress2 = txtCustomerAdress2.Text;
                CustomerCity1 = txtCustomerCity1.Text;
                CustomerCity2 = txtCustomerCity2.Text;
                CustomerPhoneNumber1 = txtCustomerPhoneNumber1.Text;
                CustomerPhoneNumber2 = txtCustomerPhoneNumber2.Text;
                CustomerZipCode1 = txtCustomerZipCode1.Text;
                CustomerZipCode2 = txtCustomerZipCode2.Text;
                CustomerFaxNumber = txtCustomerFaxNumber.Text;
                CustomerContactPerson = txtCustomerContactPerson.Text;
                CustomerEmail = txtCustomerEmail.Text;
                CustomerBankNumber = txtCustomerBankNumber.Text;
                CustomerCreditWorthy = Convert.ToBoolean(cmbCustomerCreditWorthy.SelectedIndex);
                CustomerBKRCheck = Convert.ToBoolean(cmbCustomerBKRCheck.SelectedIndex);
                CustomerPotential = Convert.ToBoolean(cmbCustomerPotential.SelectedIndex);

                SQLCommand.Parameters.AddWithValue("@CustomerID", CustomerID);
                SQLCommand.Parameters.AddWithValue("@CustomerName", CustomerName);
                SQLCommand.Parameters.AddWithValue("@CustomerAdress1", CustomerAdress1);
                SQLCommand.Parameters.AddWithValue("@CustomerAdress2", CustomerAdress2);
                SQLCommand.Parameters.AddWithValue("@CustomerCity1", CustomerCity1);
                SQLCommand.Parameters.AddWithValue("@CustomerCity2", CustomerCity2);
                SQLCommand.Parameters.AddWithValue("@CustomerPhoneNumber1", CustomerPhoneNumber1);
                SQLCommand.Parameters.AddWithValue("@CustomerPhoneNumber2", CustomerPhoneNumber2);
                SQLCommand.Parameters.AddWithValue("@CustomerZipCode1", CustomerZipCode1);
                SQLCommand.Parameters.AddWithValue("@CustomerZipCode2", CustomerZipCode2);
                SQLCommand.Parameters.AddWithValue("@CustomerFaxNumber", CustomerFaxNumber);
                SQLCommand.Parameters.AddWithValue("@CustomerContactPerson", CustomerContactPerson);
                SQLCommand.Parameters.AddWithValue("@CustomerEmail", CustomerEmail);
                SQLCommand.Parameters.AddWithValue("@CustomerBankNumber", CustomerBankNumber);
                SQLCommand.Parameters.AddWithValue("@CustomerCreditWorthy", CustomerCreditWorthy);
                SQLCommand.Parameters.AddWithValue("@CustomerBKRCheck", CustomerBKRCheck);
                SQLCommand.Parameters.AddWithValue("@CustomerPotential", CustomerPotential);

                SQLHandler.openConnection();
                SQLCommand.ExecuteNonQuery();
                SQLHandler.closeConnection();

                frmmain.FillDataGrids();
                frmmain.Enabled = true;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Please make sure everything is entered correctly!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            frmmain.Enabled = true;
        }

        private void cmbCustomerCreditWorthy_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cmbCustomerBKRCheck_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cmbCustomerPotential_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void frmAddCustomers_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmmain.Enabled = true;
        }
    }
}
